using ApiBaseReceitas.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiBaseReceitas.Infrastructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext() { }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<CategoriaIngrediente> CategoriaIngrediente { get; set; }
        public DbSet<Ingrediente> Ingrediente { get; set; }
        public DbSet<ModoPreparo> ModoPreparo { get; set; }
        public DbSet<Montagem> Montagem { get; set; }
        public DbSet<Receita> Receita { get; set; }    
    }
}
