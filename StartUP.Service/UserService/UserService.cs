using StartUP.Data.Entity;
using StartUP.Repository.UserRepo;

namespace StartUP.Service.UserService
{
    public class UserService : IUserServicecs
    {
        private readonly IUserRepo _userRepo;

        public UserService(IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }

        public async Task<bool> RegisterUserAsync(UserDto userDto)
        {
            var existingUser = await _userRepo.GetUserByEmailAsync(userDto.Email);
            if (existingUser != null)
            {
                return false;
            }

            var user = new User
            {
                Name = userDto.Name,
                UserName = userDto.UserName,
                Email = userDto.Email,
                Password = userDto.Password,
                SSN = userDto.SSN,
                Age = userDto.Age,
                Image = userDto.Image,
                PhoneNumber = userDto.PhoneNumber,
                Role = userDto.Role
            };


            await _userRepo.AddUserAsync(user);
            return true;
        }



      
    }
}
