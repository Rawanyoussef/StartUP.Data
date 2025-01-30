using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StartUP.Service.UserService;

namespace StartUP.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuccessStoryController : ControllerBase
    {
        
        private readonly ISuccessStoryService _service;

        public SuccessStoryController(ISuccessStoryService service)
        {
            _service = service;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var stories = await _service.GetAllAsync();
            return Ok(stories);
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var story = await _service.GetByIdAsync(id);
            if (story == null) return NotFound("Story not found.");
            return Ok(story);
        }

        [HttpGet("GetRandom/{count}")]
        public async Task<IActionResult> GetRandom(int count)
        {
            var stories = await _service.GetRandomStoriesAsync(count);
            return Ok(stories);
        }

        [HttpGet("GetByUser/{userId}")]
        public async Task<IActionResult> GetByUser(int userId)
        {
            var stories = await _service.GetByUserIdAsync(userId);
            return Ok(stories);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] SuccessStoryDto successStoryDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _service.AddAsync(successStoryDto);
            if (!result)
            {
                return BadRequest("Could not create success story.");
            }

            return Ok("Success story created successfully.");
        }
    }
}
