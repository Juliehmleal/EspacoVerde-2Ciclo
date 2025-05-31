using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EspacoVerde.Models
{
    public class Residuo
    {
        public int ID_Residuo { get; set; }

        public int ID_Usuario { get; set; }

        [Required(ErrorMessage = "A localização é obrigatória")]
        public int ID_Localizacao { get; set; }

        [Required(ErrorMessage = "O nome do material é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A quantidade é obrigatória")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Quantidade deve ser maior que zero")]
        public decimal Quantidade { get; set; }

        [Required(ErrorMessage = "O preço por kg é obrigatório")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Preço por Kg deve ser maior que zero")]
        public decimal PrecoKg { get; set; } 

        [NotMapped]
        public IFormFile? ImageFile { get; set; }

        public string ImgUrl { get; set; } = "https://via.placeholder.com/150";

        // Navegação
        public Usuario Usuario { get; set; }
        public Transacao Transacao { get; set; }
        public Localizacao Localizacao { get; set; }
    }

}
