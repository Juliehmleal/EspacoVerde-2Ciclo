
using EspacoVerde.Models;
using Microsoft.EntityFrameworkCore;

namespace EspacoVerde.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Residuo> Residuos { get; set; }
        public DbSet<Transacao> Transacoes { get; set; }
        public DbSet<Localizacao> Localizacoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Localizacao>()
                .HasKey(l => l.ID_Localizacao);

            modelBuilder.Entity<Residuo>()
                .HasKey(r => r.ID_Residuo);

            modelBuilder.Entity<Usuario>()
                .HasKey(u => u.ID_Usuario);

            modelBuilder.Entity<Transacao>()
                .HasKey(t => t.ID_Transacao);

            modelBuilder.Entity<Residuo>()
                .HasOne(r => r.Usuario)
                .WithMany(u => u.Residuos)
                .HasForeignKey(r => r.ID_Usuario);

            modelBuilder.Entity<Residuo>()
                .HasOne(r => r.Localizacao)
                .WithMany(l => l.Residuos)
                .HasForeignKey(r => r.ID_Localizacao);

            modelBuilder.Entity<Transacao>()
                .HasOne(t => t.Comprador)
                .WithMany(u => u.TransacoesComoComprador)
                .HasForeignKey(t => t.ID_Comprador)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Residuo>()
                .HasOne(r => r.Transacao)
                .WithOne(t => t.Residuo)
                .HasForeignKey<Transacao>(t => t.ID_Residuo);

            modelBuilder.Entity<Usuario>().HasData(
                new Usuario { ID_Usuario = 1, RazaoSocial = "Metalúrgica Alfa", CNPJ = "12.345.678/0001-99", Email = "alfa@email.com", Senha = "123", Status = true },
                new Usuario { ID_Usuario = 2, RazaoSocial = "Siderúrgica Beta", CNPJ = "98.765.432/0001-11", Email = "beta@email.com", Senha = "123", Status = true }
            );

            modelBuilder.Entity<Localizacao>().HasData(
                new Localizacao { ID_Localizacao = 1, Cidade = "Araraquara", Estado = "SP" },
                new Localizacao { ID_Localizacao = 2, Cidade = "Matão", Estado = "SP" },
                new Localizacao { ID_Localizacao = 3, Cidade = "São Carlos", Estado = "SP" },
                new Localizacao { ID_Localizacao = 4, Cidade = "Ribeirão Preto", Estado = "SP" }
            );

            modelBuilder.Entity<Residuo>().HasData(
                new Residuo { ID_Residuo = 1, Nome = "Aço Inox", Quantidade = 100, PrecoKg = 5.50m, ID_Usuario = 1, ID_Localizacao = 1, ImgUrl = "aco_inox.webp" },
                new Residuo { ID_Residuo = 2, Nome = "Ferro Fundido", Quantidade = 50, PrecoKg = 1.20m, ID_Usuario = 1, ID_Localizacao = 2, ImgUrl = "ferro_fundido.webp" },
                new Residuo { ID_Residuo = 3, Nome = "Alumínio", Quantidade = 75, PrecoKg = 3.80m, ID_Usuario = 1, ID_Localizacao = 3, ImgUrl = "aluminio.webp" },
                new Residuo { ID_Residuo = 4, Nome = "Cobre", Quantidade = 30, PrecoKg = 8.20m, ID_Usuario = 1, ID_Localizacao = 4, ImgUrl = "cobre.webp" },
                new Residuo { ID_Residuo = 5, Nome = "Latão", Quantidade = 60, PrecoKg = 4.50m, ID_Usuario = 1, ID_Localizacao = 1, ImgUrl = "latao.webp" },
                new Residuo { ID_Residuo = 6, Nome = "Zinco", Quantidade = 40, PrecoKg = 2.10m, ID_Usuario = 1, ID_Localizacao = 2, ImgUrl = "zinco.webp" },
                new Residuo { ID_Residuo = 7, Nome = "Chumbo", Quantidade = 25, PrecoKg = 1.80m, ID_Usuario = 1, ID_Localizacao = 3, ImgUrl = "chumbo.webp" },
                //new Residuo { ID_Residuo = 8, Nome = "Estanho", Quantidade = 15, PrecoKg = 9.50m, ID_Usuario = 1, ID_Localizacao = 4, ImgUrl = "estanho.webp" },
                new Residuo { ID_Residuo = 9, Nome = "Níquel", Quantidade = 10, PrecoKg = 12.00m, ID_Usuario = 1, ID_Localizacao = 1, ImgUrl = "niquel.webp" },
                new Residuo { ID_Residuo = 10, Nome = "Titânio", Quantidade = 5, PrecoKg = 25.00m, ID_Usuario = 1, ID_Localizacao = 2, ImgUrl = "titanio.webp" },
                new Residuo { ID_Residuo = 11, Nome = "Bronze", Quantidade = 12, PrecoKg = 6.80m, ID_Usuario = 1, ID_Localizacao = 3, ImgUrl = "bronze.webp" },
                new Residuo { ID_Residuo = 12, Nome = "Aço Carbono", Quantidade = 22, PrecoKg = 0.90m, ID_Usuario = 1, ID_Localizacao = 4, ImgUrl = "aco_carbono.webp" },
                new Residuo { ID_Residuo = 13, Nome = "Magnésio", Quantidade = 18, PrecoKg = 4.20m, ID_Usuario = 1, ID_Localizacao = 1, ImgUrl = "magnesio.webp" },
                new Residuo { ID_Residuo = 14, Nome = "Cromo", Quantidade = 16, PrecoKg = 7.10m, ID_Usuario = 1, ID_Localizacao = 2, ImgUrl = "cromo.webp" },
                new Residuo { ID_Residuo = 15, Nome = "Manganês", Quantidade = 20, PrecoKg = 1.50m, ID_Usuario = 1, ID_Localizacao = 3, ImgUrl = "manganes.webp" },
                //new Residuo { ID_Residuo = 16, Nome = "Tungstênio", Quantidade = 3, PrecoKg = 30.00m, ID_Usuario = 1, ID_Localizacao = 4, ImgUrl = "tungstenio.webp" },
                new Residuo { ID_Residuo = 17, Nome = "Molibdênio", Quantidade = 2, PrecoKg = 28.00m, ID_Usuario = 1, ID_Localizacao = 1, ImgUrl = "molibdenio.webp" },
                new Residuo { ID_Residuo = 18, Nome = "Vanádio", Quantidade = 7, PrecoKg = 15.50m, ID_Usuario = 1, ID_Localizacao = 2, ImgUrl = "vanadio.webp" },
                new Residuo { ID_Residuo = 19, Nome = "Aço Inox", Quantidade = 15, PrecoKg = 5.70m, ID_Usuario = 1, ID_Localizacao = 3, ImgUrl = "aco_inox.webp" },
                new Residuo { ID_Residuo = 20, Nome = "Alumínio", Quantidade = 50, PrecoKg = 4.00m, ID_Usuario = 1, ID_Localizacao = 4, ImgUrl = "aluminio.webp" }
            );

            modelBuilder.Entity<Transacao>().HasData(
                new Transacao
                {
                    ID_Transacao = 1,
                    ID_Residuo = 1,
                    ID_Comprador = 2,
                    Data_Transacao = DateTime.Now,
                    Preco_Final = 550 // 100 kg * 5.50 Preço/Kg
                }
            );
        }
    }
}