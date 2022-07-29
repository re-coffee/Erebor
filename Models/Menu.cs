using System.ComponentModel.DataAnnotations.Schema;

namespace Erebor.Models
{
    [Table("Menu")]
    public class Menu : Base
    {
        public int IdRole { get; set; }
        public string? Nome { get; set; }
        public string? Controller { get; set; }
        public string? Action { get; set; }
        public bool? UpDel { get; set; }

        [ForeignKey("IdRole")]
        public virtual Role? Role { get; set; }
    }
}
