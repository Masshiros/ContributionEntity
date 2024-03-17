using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Content
{
    [Table("ContributionPublicFavorites")]
    public class ContributionPublicFavorite : BaseEntity
    {
        public Guid ContributionPublicId { get; set; }
        public Guid UserId {get; set;}
        [MaxLength(2048)]
        public string Description { get; set; }
    }
}
