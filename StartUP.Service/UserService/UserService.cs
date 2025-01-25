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
                Email = userDto.Email,
                Password = userDto.Password 
            };

            await _userRepo.AddUserAsync(user);
            return true;
        }
    }
}
