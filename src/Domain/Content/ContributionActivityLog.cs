using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Content
{
    [Table("ContributionActivityLogs")]
    internal class ContributionActivityLog : BaseEntity
    {
        public Guid UserId { get; set; }
        [MaxLength(255)]
        public string Title { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        public string UserName { get; set; }
        [Required]
        public ContributionStatus FromStatus { get; set;}
        [Required]
        public ContributionStatus ToStatus { get;set;}
    }
}
