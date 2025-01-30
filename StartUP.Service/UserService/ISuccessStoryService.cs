using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUP.Service.UserService
{
    public interface ISuccessStoryService
    {
        Task<IEnumerable<SuccessStoryDto>> GetAllAsync();
        Task<SuccessStoryDto> GetByIdAsync(int id);
        Task<IEnumerable<SuccessStoryDto>> GetRandomStoriesAsync(int count);
        Task<IEnumerable<SuccessStoryDto>> GetByUserIdAsync(int userId);
        Task<bool> AddAsync(SuccessStoryDto successStoryDto);
    }
}
