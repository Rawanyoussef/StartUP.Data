using Microsoft.AspNetCore.Mvc;
using StartUP.Service.UserService;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IUserServicecs _userService;

    public UsersController(IUserServicecs userService)
    {
        _userService = userService;
    }

    [HttpPost("SignUp")]
    public async Task<IActionResult> SignUp([FromBody] UserDto userDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        if (userDto.Password != userDto.ConfirmPassword)
        {
            return BadRequest("Passwords do not match.");
        }

        var result = await _userService.RegisterUserAsync(userDto);
        if (!result)
        {
            return Conflict("User with the same email already exists.");
        }

        return Ok("User registered successfully.");
    }



    [HttpPost("Login")]
    public async Task<IActionResult> LogIn(LoginDto login)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);

        }

        var result = await _userService.LoginUserAsync(login);
        if (!result)
        {
            return Conflict("Oops! 😕 Incorrect email or password. Double-check your details and try again!");
        }
        return Ok("Welcome back! 🎉 You’ve successfully logged in. Let’s get started! 🚀");
    }
}