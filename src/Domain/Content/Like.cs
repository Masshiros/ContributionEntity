using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Content
{
    [Table("Likes")]
    public class Like : BaseEntity
    {
        public Guid ContributionPublicId { get; set; }
        public Guid UserId { get; set; }
    }
}
