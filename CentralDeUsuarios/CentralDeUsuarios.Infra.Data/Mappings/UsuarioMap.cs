using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralDeUsuarios.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CentralDeUsuarios.Infra.Data.Mappings
{
    /// <summary>
    /// Classe de mapeamento ORM da entidade usuário
    /// </summary>
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
                
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasIndex(u => u.Email).IsUnique();
            //builder.HasIndex(u => u.Email2).IsUnique();
        }
    }
}
