using EspacoVerde.Models;
using Microsoft.EntityFrameworkCore;

namespace EspacoVerde.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Residuo> Residuos { get; set; }
        public DbSet<Transacao> Transacoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Residuo>()
                .HasKey(r => r.ID_Residuo);

            // Define a chave primária de Usuario
            modelBuilder.Entity<Usuario>()
                .HasKey(u => u.ID_Usuario);

            // Define a chave primária de Transacao
            modelBuilder.Entity<Transacao>()
                .HasKey(t => t.ID_Transacao);

            // Relacionamento Residuo -> Usuario (FK explícita)
            modelBuilder.Entity<Residuo>()
                .HasOne(r => r.Usuario)
                .WithMany(u => u.Residuos)
                .HasForeignKey(r => r.ID_Usuario);

            // Relacionamento Transacao -> Comprador
            modelBuilder.Entity<Transacao>()
                .HasOne(t => t.Comprador)
                .WithMany(u => u.TransacoesComoComprador)
                .HasForeignKey(t => t.ID_Comprador)
                .OnDelete(DeleteBehavior.Restrict);

            // Relacionamento 1:1 Residuo -> Transacao
            modelBuilder.Entity<Residuo>()
                .HasOne(r => r.Transacao)
                .WithOne(t => t.Residuo)
                .HasForeignKey<Transacao>(t => t.ID_Residuo);


            modelBuilder.Entity<Usuario>().HasData(
                new Usuario { ID_Usuario = 1, RazaoSocial = "Metalúrgica Alfa", CNPJ = "12.345.678/0001-99", Email = "alfa@email.com", Senha = "123", Status = true },
                new Usuario { ID_Usuario = 2, RazaoSocial = "Siderúrgica Beta", CNPJ = "98.765.432/0001-11", Email = "beta@email.com", Senha = "123", Status = true }
            );

            modelBuilder.Entity<Residuo>().HasData(
                new Residuo { ID_Residuo = 1, Nome = "Aço Inox", Quantidade = 100, ID_Usuario = 1, ImgUrl = "aco_Inox.jpeg" },
                new Residuo { ID_Residuo = 2, Nome = "Ferro Fundido", Quantidade = 50, ID_Usuario = 1, ImgUrl = "Ferro_Fundido.jpeg" }
            );


            modelBuilder.Entity<Transacao>().HasData(
                new Transacao
                {
                    ID_Transacao = 1,
                    ID_Residuo = 1,
                    ID_Comprador = 2,
                    Data_Transacao = DateTime.Now,
                    Preco_Final = 1500
                }
            );


        }
    }
}
