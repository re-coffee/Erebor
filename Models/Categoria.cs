using System.ComponentModel.DataAnnotations.Schema;

namespace Erebor.Models
{
    [Table("Categoria")]
    public class Categoria : Base
    {
        public string? Titulo { get; set; }
        public string? Descricao { get; set; }
    }
}
