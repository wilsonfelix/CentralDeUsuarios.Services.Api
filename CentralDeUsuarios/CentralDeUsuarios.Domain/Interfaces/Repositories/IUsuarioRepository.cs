using CentralDeUsuarios.Domain.Core;
using CentralDeUsuarios.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralDeUsuarios.Domain.Interfaces.Repositories
{
    /// <summary>
    /// Interface de repositório para Usuário
    /// </summary>
    public interface IUsuarioRepository : IBaseRepository<Usuario, Guid>
        
    {
        /// <summary>
        /// Método para consultar 1 usuário por email
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        Usuario GetByEmail(string email);

    }
}
