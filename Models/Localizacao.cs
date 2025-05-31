namespace EspacoVerde.Models
{
    public class Localizacao
    {
        public int ID_Localizacao { get; set; }

        public string Cidade { get; set; }
        public string Estado { get; set; }

        // Navegação inversa
        public ICollection<Residuo> Residuos { get; set; }
    }
}
