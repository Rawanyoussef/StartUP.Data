using Microsoft.EntityFrameworkCore;
using StartUP.Data.Context;
using StartUP.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUP.Repository.UserRepo
{
    public class SuccessStoryRepository : ISuccessStoryRepository
    {

        private readonly StartUPContext _context;

        public SuccessStoryRepository(StartUPContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<SuccessStory>> GetAllAsync()
        {
            return await _context.SuccessStories.Include(s => s.User).ToListAsync();
        }

        public async Task<SuccessStory> GetByIdAsync(int id)
        {
            return await _context.SuccessStories.Include(s => s.User).FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<IEnumerable<SuccessStory>> GetRandomStoriesAsync(int count)
        {
            return await _context.SuccessStories.OrderBy(r => Guid.NewGuid()).Take(count).ToListAsync();
        }

        public async Task<IEnumerable<SuccessStory>> GetByUserIdAsync(int userId)
        {
            return await _context.SuccessStories.Where(s => s.UserId == userId).ToListAsync();
        }

        public async Task<bool> AddAsync(SuccessStory successStory)
        {
            _context.SuccessStories.Add(successStory);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
