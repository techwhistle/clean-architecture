using BlogApi.Application.Interfaces.Repositories;
using BlogApi.Domain.Blogs;
using BlogApi.Infrastructure.Persistence;

namespace BlogApi.Infrastructure.Repositories
{
    public class TagRepository : BaseRepository<Tag>, ITagRepository
    {
        public TagRepository(BlogDbContext context) : base(context) { }
    }
}
