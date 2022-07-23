using System.ComponentModel.DataAnnotations;

namespace Erebor.Models
{
    public class Base
    {
        [Key]
        public virtual int Id { get; set; }
        public virtual bool Ativo { get; set; }
        public virtual DateTime DataInsercao { get; set; }
    }
}
