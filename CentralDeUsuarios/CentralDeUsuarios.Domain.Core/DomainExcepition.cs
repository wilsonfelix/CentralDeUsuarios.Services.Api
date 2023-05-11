using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralDeUsuarios.Domain.Core
{
    public class DomainExcepition : Exception
    {
        public DomainExcepition(string errorMessage) 
            : base(errorMessage)
        { 
        
        
        
        }
        /// <summary>
        /// Método para testar um condição de erro e disparar uma exceção
        /// </summary>
        /// <param name="hasError">Condição para disparar o erro</param>
        /// <param name="errorMessage">Mensagem de erro</param>
        public static void When(bool hasError, string errorMessage)
        { 
        
        if(hasError) 
                throw new DomainExcepition(errorMessage);
        
        }
    }
}
