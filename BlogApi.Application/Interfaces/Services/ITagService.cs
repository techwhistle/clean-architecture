using BlogApi.Application.DTOs;

namespace BlogApi.Application.Interfaces.Services;

public interface ITagService
{
    Task<TagDto> GetTagAsync(Guid id);
    Task<Guid> CreateTagAsync(string name);
    Task UpdateTagAsync(Guid id, string name);
    Task DeleteTagAsync(Guid id);
}