using Microsoft.EntityFrameworkCore;
using SistemaDeTarefa.Data.Map;
using SistemaDeTarefa.Models;

namespace SistemaDeTarefa.Data
{
    public class SistemaTarefaDBContex : DbContext
    {

        public SistemaTarefaDBContex(DbContextOptions<SistemaTarefaDBContex> options)
            : base(options)
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<TarefaModel> Tarefas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new TarefaMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
