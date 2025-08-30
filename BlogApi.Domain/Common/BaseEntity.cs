using System.ComponentModel.DataAnnotations.Schema;

namespace BlogApi.Domain.Common
{
    public class BaseEntity
    {
        /// <summary>
        /// When the entity was created.
        /// </summary>
        [Column("create_date")]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        /// <summary>
        /// When the entity was last updated.
        /// </summary>
        [Column("modified_date")]
        public DateTime? ModifiedDate { get; set; }
    }
}
