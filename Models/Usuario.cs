using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Erebor.Models
{
    [Table("Usuario")]
    public class Usuario : Base
    {
        public int IdRole { get; set; }
        [Display(Name = "Usuário")]
        [Required(ErrorMessage = "Campo 'Usuário' obrigatório")]
        public string? Nome { get; set; }
        [Required(ErrorMessage = "Campo 'Senha' obrigatório")]
        [DataType(DataType.Password)]
        public string? Senha { get; set; }

        [ForeignKey("IdRole")]
        public virtual Role? Role { get; set; }
        [NotMapped]
        public string? ErroLogin { get; set; }

        //Hash senha
        public void SetSenha(string senha)
        {
            Senha = Crypto.Hash(senha);
        }
        public bool CheckSenha(string senha)
        {
            return string.Equals(Senha, Crypto.Hash(senha));
        }
    }
    public static class Crypto
    {
        public static string Hash(string value)
        {
            return Convert.ToBase64String(
                System.Security.Cryptography.SHA256.Create()
                .ComputeHash(Encoding.UTF8.GetBytes(value)));
        }
    }
}
