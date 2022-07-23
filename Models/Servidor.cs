using System.ComponentModel.DataAnnotations.Schema;

namespace Erebor.Models
{
    [Table("Servidor")]
    public class Servidor : Base
    {
        public int IdCategoria { get; set; }
        public string? Hostname { get; set; }
        public string? Ip { get; set; }
        public int Porta { get; set; }

        [ForeignKey("IdCategoria")]
        public virtual Categoria? Categoria { get; set; }
    }
}
