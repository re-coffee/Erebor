using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Erebor.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        public int IdContrato { get; set; }
        public int IdServidorBanco { get; set; }
        public string? Nome { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataInsercao { get; set; }

        [ForeignKey("IdContrato")]
        public virtual Contrato? Contrato { get; set; }


        [ForeignKey("IdServidorBanco")]
        public virtual Servidor? ServidorBanco { get; set; }
        public virtual ICollection<Servico>? Servicos { get; set; }
    }   
}
