using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Content
{
    [Table("Tags")]
    public class Tag : BaseEntity
    {
        [Required]
        [MaxLength(256)]

        public string Name { get; set; }
    }
}
