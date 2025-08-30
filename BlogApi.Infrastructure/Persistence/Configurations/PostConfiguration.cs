using BlogApi.Domain.Blogs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogApi.Infrastructure.Persistence.Configurations
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("post");

            builder.HasKey(p => p.PostId);

            builder.Property(p => p.PostId)
                   .HasColumnName("post_id")
                   .IsRequired();

            builder.Property(p => p.Title)
                   .HasColumnName("title")
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(p => p.Content)
                   .HasColumnName("content")
                   .IsRequired();

            builder.Property(p => p.CreatedDate)
                   .HasColumnName("created_date")
                   .HasDefaultValueSql("CURRENT_TIMESTAMP")
                   .IsRequired();

            builder.Property(p => p.ModifiedDate)
                   .HasColumnName("modified_date")
                   .IsRequired(false);
        }
    }
}
