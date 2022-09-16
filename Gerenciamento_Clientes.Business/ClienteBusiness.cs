using Gerenciamento_Clientes.Business.Validations;
using Gerenciamento_Clientes.Common;
using Gerenciamento_Clientes.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_Clientes.Business
{
    public class ClienteBusiness : IClienteBusiness
    {
        private readonly IClienteDataAccess clienteDataAccess;
        private readonly ClienteValidation validation;
        public ClienteBusiness(IClienteDataAccess _clienteDataAccess, ClienteValidation clienteValidation)
        {
            clienteDataAccess = _clienteDataAccess;
            validation = clienteValidation;
        }
        public void Editar(Cliente cliente)
        {
            var result = validation.Validate(cliente);
            if (result.IsValid)
            {
                clienteDataAccess.Editar(cliente);
            }
        }

        public void Excluir(int id)
        {
            clienteDataAccess.Excluir(id);
        }

        public List<Cliente> Listar()
        {
            return clienteDataAccess.Listar();
        }

        public void Registrar(Cliente cliente)
        {
            var result = validation.Validate(cliente);
            if (result.IsValid)
            {
                clienteDataAccess.Registrar(cliente);
            }
        }
    }
}
