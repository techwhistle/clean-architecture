using BlogApi.Application.DTOs;

namespace BlogApi.Application.Interfaces.Services;

public interface ITagController
{
    Task<PostDto> GetPostAsync(Guid id);
    Task<Guid> CreatePostAsync(string title, string content, Guid authorId);
    Task UpdatePostAsync(Guid id, string title, string content);
    Task DeletePostAsync(Guid id);
}