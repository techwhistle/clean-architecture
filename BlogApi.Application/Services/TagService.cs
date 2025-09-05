using BlogApi.Application.DTOs;
using BlogApi.Application.Interfaces.Repositories;
using BlogApi.Application.Interfaces.Services;
using BlogApi.Domain.Blogs;

namespace BlogApi.Application.Services
{
    public class TagService : ITagService
    {
        private readonly ITagRepository _tagRepository;

        public TagService(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }

        public async Task<TagDto?> GetTagAsync(Guid id)
        {
            var tag = await _tagRepository.GetByIdAsync(id);
            if (tag == null) return null;

            return new TagDto
            {
                TagId = tag.TagId,
                Name = tag.Name
            };
        }

        public async Task<Guid> CreateTagAsync(string name)
        {
            var tag = new Tag
            {
                TagId = Guid.NewGuid(),
                Name = name
            };

            await _tagRepository.AddAsync(tag);
            return tag.TagId;
        }

        public async Task UpdateTagAsync(Guid id, string name)
        {
            var tag = await _tagRepository.GetByIdAsync(id);
            if (tag == null)
                throw new Exception("Tag not found");

            tag.Name = name;
            tag.ModifiedDate = DateTime.UtcNow;

            await _tagRepository.UpdateAsync(tag);
        }

        public async Task DeleteTagAsync(Guid id)
        {
            await _tagRepository.DeleteAsync(id);
        }
    }
}
