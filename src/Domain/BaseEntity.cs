using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class BaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateEdited { get; set; }
        public DateTime? DateDeleted { get; set; }
    }
}
