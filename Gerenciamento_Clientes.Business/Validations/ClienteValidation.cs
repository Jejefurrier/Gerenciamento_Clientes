using FluentValidation;
using Gerenciamento_Clientes.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_Clientes.Business.Validations
{
    public class ClienteValidation : AbstractValidator<Cliente>
    {
        public ClienteValidation()
        {
            RuleFor(x => x.Nome).MinimumLength(3).WithMessage("O nome do cliente deve ter no minimo 3 digitos!");
            RuleFor(x => x.CPF).MinimumLength(3).WithMessage("O CPF do cliente deve ter no minimo 3 digitos!");
        }
    }
}
