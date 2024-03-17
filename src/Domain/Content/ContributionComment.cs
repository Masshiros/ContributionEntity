using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Domain.Content
{
    [Table("ContributionComments")]
    [PrimaryKey(nameof(ContributionId), nameof(UserId))]
    public class ContributionComment : BaseEntity
    {
        public Guid ContributionId { get; set; }
        public Guid UserId { get; set; }
        public string Content { get; set; }
    }
}
