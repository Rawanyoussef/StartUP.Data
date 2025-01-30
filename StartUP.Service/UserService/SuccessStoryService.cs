using StartUP.Data.Entity;
using StartUP.Repository.UserRepo;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StartUP.Service.UserService
{
    public class SuccessStoryService : ISuccessStoryService
    {
        private readonly ISuccessStoryRepository _repository;

        public SuccessStoryService(ISuccessStoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<SuccessStoryDto>> GetAllAsync()
        {
            var stories = await _repository.GetAllAsync();
            return stories.Select(s => new SuccessStoryDto
            {
                Id = s.Id,
                Name = s.Name,
                Category = s.Category,
                UserId = s.UserId
            });
        }

        public async Task<SuccessStoryDto> GetByIdAsync(int id)
        {
            var story = await _repository.GetByIdAsync(id);
            if (story == null) return null;

            return new SuccessStoryDto
            {
                Id = story.Id,
                Name = story.Name,
                Category = story.Category,
                UserId = story.UserId
            };
        }

        public async Task<IEnumerable<SuccessStoryDto>> GetRandomStoriesAsync(int count)
        {
            var stories = await _repository.GetRandomStoriesAsync(count);
            return stories.Select(s => new SuccessStoryDto
            {
                Id = s.Id,
                Name = s.Name,
                Category = s.Category,
                UserId = s.UserId
            });
        }

        public async Task<IEnumerable<SuccessStoryDto>> GetByUserIdAsync(int userId)
        {
            var stories = await _repository.GetByUserIdAsync(userId);
            return stories.Select(s => new SuccessStoryDto
            {
                Id = s.Id,
                Name = s.Name,
                Category = s.Category,
                UserId = s.UserId
            });
        }

        public async Task<bool> AddAsync(SuccessStoryDto successStoryDto)
        {
            var successStory = new SuccessStory
            {
                Name = successStoryDto.Name,
                Category = successStoryDto.Category,
                UserId = successStoryDto.UserId
            };

            return await _repository.AddAsync(successStory);
        }
    }

}


