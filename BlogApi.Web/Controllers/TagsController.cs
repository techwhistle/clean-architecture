using BlogApi.Application.DTOs;
using BlogApi.Application.Interfaces.Services;
using BlogApi.Web.Models.Requests;
using Microsoft.AspNetCore.Mvc;

namespace BlogApi.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TagsController : ControllerBase
    {
        private readonly ITagService _tagService;

        public TagsController(ITagService tagService)
        {
            _tagService = tagService;
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<TagDto>> GetTag(Guid id)
        {
            var tag = await _tagService.GetTagAsync(id);
            if (tag == null)
                return NotFound();

            return Ok(tag);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> CreateTag([FromBody] CreateTagRequest request)
        {
            var tagId = await _tagService.CreateTagAsync(request.Name);
            return CreatedAtAction(nameof(GetTag), new { id = tagId }, tagId);
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> UpdateTag(Guid id, [FromBody] UpdateTagRequest request)
        {
            await _tagService.UpdateTagAsync(id, request.Name);
            return NoContent();
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteTag(Guid id)
        {
            await _tagService.DeleteTagAsync(id);
            return NoContent();
        }
    }
}
