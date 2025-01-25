﻿using StartUP.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUP.Repository.UserRepo
{
    public interface IUserRepo
    {
        Task AddUserAsync(User user);
        Task<User?> GetUserByEmailAsync(string email);
    }
}
