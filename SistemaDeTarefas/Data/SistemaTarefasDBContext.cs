using Microsoft.EntityFrameworkCore; //Utilizando DbContext do EF Core
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using SistemaDeTarefas.Data.Map;
using SistemaDeTarefas.Models; //Utilizando os models para criar as entidades do banco de dados

namespace SistemaDeTarefas.Data
{
    public class SistemaTarefasDBContext : DbContext //DbContext do meu Sistema de Tarefas está herdando do Db Context de EF Core
    {
        //Construtor do DbContext configurado para ser utilizado no restante da aplicação
        public SistemaTarefasDBContext(DbContextOptions<SistemaTarefasDBContext> options)
            : base(options) 
        {
            
        }

        public DbSet<UsuarioModel> Usuarios { get; set; } //Tabela Usuarios que será criada via ORM do EF Core 

        public DbSet<TarefaModel> Tarefas { get; set; } //Tabela Tarefas que será criada via ORM do EF Core 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new TarefaMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
