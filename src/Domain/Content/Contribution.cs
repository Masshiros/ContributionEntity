using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Content
{
    [Table("Contributions")]
    public class Contribution : BaseEntity
    {
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public Guid FacultyId { get; set; }
        [Required]
        public Guid AcademicYearId { get; set; }

        [Required] [MaxLength(256)] public string Title { get; set; }

        [MaxLength(500)]
        public string Thumbnail { get; set; }

        

        public string FilePath { get; set; }
        public DateTime SubmissionDate { get; set; }
       
        public DateTime PublicDate { get; set; }

        public bool IsCoordinatorComment { get; set; }
        public ContributionStatus Status { get; set; }

    }
    public enum ContributionStatus  {

    }
}

