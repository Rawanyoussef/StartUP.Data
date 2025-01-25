using StartUP.Data.Entity;
using Microsoft.EntityFrameworkCore;
using StartUP.Data.Context;
using StartUP.Repository.UserRepo;

public class UserRepo : IUserRepo
{
    private readonly StartUPContext _context;

    public UserRepo(StartUPContext context)
    {
        _context = context;
    }

    public async Task AddUserAsync(User user)
    {
        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();
    }

    public async Task<User?> GetUserByEmailAsync(string email)
    {
        return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
    }
}
