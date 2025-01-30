using StartUP.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUP.Repository.UserRepo
{
    public interface ISuccessStoryRepository
    {
        Task<IEnumerable<SuccessStory>> GetAllAsync();
        Task<SuccessStory> GetByIdAsync(int id);
        Task<IEnumerable<SuccessStory>> GetRandomStoriesAsync(int count);
        Task<IEnumerable<SuccessStory>> GetByUserIdAsync(int userId);
        Task<bool> AddAsync(SuccessStory successStory);
    }
}
