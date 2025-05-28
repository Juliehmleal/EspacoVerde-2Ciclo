using System.ComponentModel.DataAnnotations.Schema;

namespace EspacoVerde.Models
{
    public class Residuo
    {
        public int ID_Residuo { get; set; }
        public int ID_Usuario { get; set; }
        public string Nome { get; set; }
        public decimal Quantidade { get; set; }

        [NotMapped]
        public IFormFile? ImageFile { get; set; }
        public string ImgUrl { get; set; } = "https://via.placeholder.com/150";

        // Navegação
        public Usuario Usuario { get; set; }
        public Transacao Transacao { get; set; }
    }
}
