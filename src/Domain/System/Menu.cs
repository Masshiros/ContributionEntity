using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.System
{
    [Table("Menus")]
    public class Menu : BaseEntity
    {
        [MaxLength(255)] public string Title { get; set; }
        [MaxLength(255)]  public string Url { get; set; }

    }
}
