using BlogApi.Application.DTOs;
using BlogApi.Application.Interfaces.Repositories;
using BlogApi.Application.Interfaces.Services;
using BlogApi.Domain.Blogs;

namespace BlogApi.Application.Services;

public class PostService : IPostService
{
    private readonly IPostRepository _postRepository;

    public PostService(IPostRepository postRepository)
    {
        _postRepository = postRepository;
    }

    public async Task<PostDto> GetPostAsync(Guid id)
    {
        var post = await _postRepository.GetByIdAsync(id);
        if (post == null) throw new Exception("Post not found");

        return new PostDto
        {
            Id = post.PostId,
            Title = post.Title,
            Content = post.Content
        };
    }

    public async Task<Guid> CreatePostAsync(string title, string content, Guid authorId)
    {
        var post = new Post()
        {
            PostId = Guid.NewGuid(),
            Title = title,
            Content = content
        };

        await _postRepository.AddAsync(post);
        return post.PostId;
    }

    public async Task UpdatePostAsync(Guid id, string title, string content)
    {
        var post = await _postRepository.GetByIdAsync(id);
        if (post == null)
        {
            throw new Exception("Post not found");
        }

        post.Title = title;
        post.Content = content;
        post.ModifiedDate = DateTime.UtcNow;

        await _postRepository.UpdateAsync(post);
    }

    public async Task DeletePostAsync(Guid id)
    {
        await _postRepository.DeleteAsync(id);
    }
}
