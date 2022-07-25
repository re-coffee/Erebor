using System.ComponentModel.DataAnnotations.Schema;

namespace Erebor.Models
{
    [Table("Servico")]
    public class Servico : Base
    {
        public int IdCliente { get; set; }
        public int IdServidor { get; set; }
        public string? Nome { get; set; }
        public string? Descricao { get; set; }
        public string? Caminho { get; set; }
        public int Porta { get; set; }
        public string? Regedit { get; set; }

        [ForeignKey("IdCliente")]
        public virtual Cliente? Cliente { get; set; }


        [ForeignKey("IdServidor")]
        public virtual Servidor? Servidor { get; set; }
    }
}
