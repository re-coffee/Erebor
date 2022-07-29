using System.ComponentModel.DataAnnotations.Schema;

namespace Erebor.Models
{
    [Table("Role")]
    public class Role : Base
    {
        public string? Sigla { get; set; }
        public string? Descricao { get; set; }
        public List<Menu>? Menus { get; }
    }
}
