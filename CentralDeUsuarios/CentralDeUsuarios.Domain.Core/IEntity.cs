using FluentValidation.Results;

namespace CentralDeUsuarios.Domain.Core
{
    /// <summary>
    /// Interface para definição de tipos de entidade
    /// </summary>
    /// <typeparam name="TKey">Tipo do ID da entidade</typeparam>
    public interface IEntity<TKey>
    {
        /// <summary>
        /// Identificador da entidade
        /// </summary>
        public TKey Id { get; set; }
        /// <summary>
        /// Retorna o resultado da validação da entidade
        /// </summary>
        ValidationResult Validate { get; }

    }
}