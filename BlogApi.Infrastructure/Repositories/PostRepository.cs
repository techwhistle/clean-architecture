using BlogApi.Application.Interfaces.Repositories;
using BlogApi.Domain.Blogs;
using BlogApi.Infrastructure.Persistence;

namespace BlogApi.Infrastructure.Repositories;

public class PostRepository : BaseRepository<Post>, IPostRepository
{
    public PostRepository(BlogDbContext context) : base(context) { }
}
