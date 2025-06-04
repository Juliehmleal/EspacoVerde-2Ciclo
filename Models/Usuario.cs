using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace EspacoVerde.Models
{
    public class Usuario
    {
        [Key]
        public int ID_Usuario { get; set; }
        [Required]
        public string RazaoSocial { get; set; }
        [Required]
        public string CNPJ { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Senha { get; set; }
        public bool Status { get; set; } = true;

        // Navegação
        public ICollection<Residuo> Residuos { get; set; }
        public ICollection<Transacao> TransacoesComoComprador { get; set; }
    }
}
