namespace EspacoVerde.Models
{
    public class Usuario
    {
        public int ID_Usuario { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Status { get; set; }

        // Navegação
        public ICollection<Residuo> Residuos { get; set; }
        public ICollection<Transacao> TransacoesComoComprador { get; set; }
    }
}
