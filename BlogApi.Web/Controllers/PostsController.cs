using BlogApi.Application.DTOs;
using BlogApi.Application.Interfaces.Services;
using BlogApi.Web.Models.Requests;
using Microsoft.AspNetCore.Mvc;

namespace BlogApi.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostsController : ControllerBase
    {
        private readonly IPostService _postService;

        public PostsController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<PostDto>> GetPost(Guid id)
        {
            var post = await _postService.GetPostAsync(id);
            if (post == null)
                return NotFound();

            return Ok(post);
        }

        [HttpPost]
        public async Task<ActionResult<Guid>> CreatePost([FromBody] CreatePostRequest request)
        {
            var postId = await _postService.CreatePostAsync(request.Title, request.Content, request.AuthorId);
            return CreatedAtAction(nameof(GetPost), new { id = postId }, postId);
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> UpdatePost(Guid id, [FromBody] UpdatePostRequest request)
        {
            await _postService.UpdatePostAsync(id, request.Title, request.Content);
            return NoContent();
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeletePost(Guid id)
        {
            await _postService.DeletePostAsync(id);
            return NoContent();
        }
    }
}
