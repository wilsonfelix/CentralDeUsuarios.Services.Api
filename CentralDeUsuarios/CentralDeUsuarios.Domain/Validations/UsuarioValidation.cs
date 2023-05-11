using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralDeUsuarios.Domain.Entities;
using FluentValidation;
using FluentValidation.Validators;

namespace CentralDeUsuarios.Domain.Validations
{
    /// <summary>
    /// Classe para validação da entidade Usuário
    /// </summary>
    public class UsuarioValidation : AbstractValidator<Usuario>
    {
        
        public UsuarioValidation()
        {

            RuleFor(u => u.Id)
                .NotEmpty()
                .WithMessage("'{u}' é obrigatório, mas está vazio.");
            RuleFor(u => u.Nome)
                .NotEmpty().WithMessage("'{u}' é requerido, mas está vazio.")
                .MinimumLength(6).WithMessage("'{u}' de usuário deve ter no mínimo 6.")
                .MaximumLength(150).WithMessage("'{u}' de usuário deve ter no máximo 150.");
                //.Must(pass => !blacklistedWords.Any(word => pass.IndexOf(word, StringComparison.OrdinalIgnoreCase) >= 0)).WithMessage("'{PropertyName}' contains a word that is not allowed.");
            RuleFor(u => u.Email)
                .NotEmpty().WithMessage("'{u}' é obrigatório, mas está vazio.")
                .EmailAddress().WithMessage("'{u}' é inválido.");
            RuleFor(u => u.Email2).Equal(u => u.Email)
                .WithMessage("Os campos de email não são iguais, por favor verificar.");
            RuleFor(u => u.Senha)
                .NotEmpty().WithMessage("'{u}' é requerido, mas está vazio.")
                .MinimumLength(6).WithMessage("'{u}' deve ter no mínimo 6.")
                .MaximumLength(12).WithMessage("'{u}' deve ter no máximo 12.")
                .Matches(@"[A-Z]").WithMessage("'{u}' deve conter uma ou mais letras maiúsculas.")
                .Matches(@"[a-z]").WithMessage("'{u}' deve conter uma ou mais letras minúsculas.")
                .Matches(@"[0-9]").WithMessage("'{u}' deve conter um ou mais números.")
                .Matches(@"[][""!@$%^&*(){}:;<>,.?/+_=|'~\\-]").WithMessage("'{u}' deve conter um ou mais caracteres especiais.")
                .Matches(@"^[^£# “”]*$").WithMessage("'{u}' não deve conter os seguintes caracteres £ # “” ou espaços.");
            RuleFor(u => u.Senha2).Equal(u => u.Senha)
                .WithMessage("Os campos de senha não são iguais, por favor verificar.");


        }

    }
}
