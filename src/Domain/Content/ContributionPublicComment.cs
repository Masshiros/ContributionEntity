using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Content
{
    [Table("ContributionPublicComments")]
    [PrimaryKey(nameof(ContributionId), nameof(UserId))]
    public class ContributionPublicComment : ContributionComment
    {
        public Guid ParentId { get; set; }
    }
}
