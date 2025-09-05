using BlogApi.Domain.Blogs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogApi.Infrastructure.Persistence.Configurations
{
    public class TagConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.ToTable("tag");

            builder.HasKey(t => t.TagId);

            builder.Property(t => t.TagId)
                   .HasColumnName("tag_id")
                   .IsRequired();

            builder.Property(t => t.Name)
                   .HasColumnName("name")
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(t => t.CreatedDate)
                   .HasColumnName("created_date")
                   .HasDefaultValueSql("CURRENT_TIMESTAMP")
                   .IsRequired();

            builder.Property(t => t.ModifiedDate)
                   .HasColumnName("modified_date")
                   .IsRequired(false);
        }
    }
}
