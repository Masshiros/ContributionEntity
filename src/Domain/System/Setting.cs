using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.System
{
    [Table("Settings")]
    public class Setting : BaseEntity
    {
        [Required]
        public Guid UserId { get; set; }
        public bool? IsGive { get; set; }
        public DateTime? FinalClosureDate { get; set; }
    }
}
