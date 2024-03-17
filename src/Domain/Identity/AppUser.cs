using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Domain.Identity
{
    [Table("AppUsers")]
    public class AppUser : IdentityUser<Guid>
    {
        public Guid? FacultyId { get; set; }
        [Required]
        [MaxLength(100)]

        public required string FirstName { get; set; }
        [Required]
        [MaxLength(100)]

        public required string LastName { get; set; }
      
        public bool IsActive { get; set; }
        public DateTime? Dob { get; set; }
        public DateTime? DateCreated { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime? RefreshTokenExpiryTime { get; set; }
        public DateTime LastLoginDate { get; set; }
        [MaxLength(500)]
        public string? Avatar { get; set; }
    }

}
