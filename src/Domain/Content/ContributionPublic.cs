using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Content
{
    [Table("ContributionPublics")]
    public class ContributionPublic : Contribution
    {
        [MaxLength(256)]

        public string UserName { get; set; }
        [MaxLength(500)]

        public string Avatar { get; set; }
        public string FacultyName { get; set; }
        [Required]
        public required int LikeQuantity { get; set; }
        [Required]
        public required int Views { get; set; }
        

    }
}
