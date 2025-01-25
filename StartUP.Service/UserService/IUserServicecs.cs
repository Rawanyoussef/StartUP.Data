using StartUP.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUP.Service.UserService
{
    public interface IUserServicecs
    {
        Task<bool> RegisterUserAsync(UserDto userDto);

    }
}
