using Microsoft.EntityFrameworkCore;
using ProjetoMVC.Models;

namespace ProjetoMVC.Data
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        { }
        // Referência para a tabela de categorias
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configuração da tabela de categorias
            modelBuilder.Entity<Categoria>().ToTable("Categorias");
            modelBuilder.Entity<Produto>().ToTable("Produtos");
        }

    }
}
