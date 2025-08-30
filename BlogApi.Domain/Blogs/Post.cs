using BlogApi.Domain.Common;

namespace BlogApi.Domain.Blogs
{
    public class Post : BaseEntity
    {
        /// <summary>
        /// The unique identifier for the post.
        /// </summary>
        public Guid PostId { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;
    }
}
