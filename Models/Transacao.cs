namespace EspacoVerde.Models
{
    public class Transacao
    {
        public int ID_Transacao { get; set; }
        public int ID_Residuo { get; set; }
        public int ID_Comprador { get; set; }
        public DateTime Data_Transacao { get; set; }
        public decimal Preco_Final { get; set; }

        // Navegação
        public Residuo Residuo { get; set; }
        public Usuario Comprador { get; set; }
    }
}
