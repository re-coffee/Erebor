using System.ComponentModel.DataAnnotations.Schema;

namespace Erebor.Models
{
    [Table("Contrato")]
    public class Contrato : Base
    {
        public string? Titulo { get; set; }
    }
}
