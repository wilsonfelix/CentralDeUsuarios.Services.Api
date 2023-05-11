using CentralDeUsuarios.Domain.Entities;
using CentralDeUsuarios.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralDeUsuarios.Infra.Data.Contexts
{
    /// <summary>
    /// Classe de contesto do banco de dados
    /// </summary>
    public class SqlServerContext : DbContext
    {
        /// <summary>
        /// Método para definir a connectionstring do projeto
        /// </summary>
        /// <param name="optionsBuilder"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.,1433;Initial Catalog=DB_CentralDeUsuários;Persist Security Info=True;User ID=servico;Password=P@ssw0rd;Pooling=False;TrustServerCertificate=True");
        }

        /// <summary>
        /// Método para adicionar cada classe de mapeamento
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
        }
        /// <summary>
        /// Propriedade para fornecer os métodos que
        /// serão utilizados no repositório de usuários
        /// </summary>
        public DbSet<Usuario> Usuario { get; set; }

    }
}
