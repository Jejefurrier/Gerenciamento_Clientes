using Gerenciamento_Clientes.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_Clientes.DataAccess
{
    public interface IClienteDataAccess
    {
        public void Registrar(Cliente cliente);

        public void Editar(Cliente cliente);

        public void Excluir(int id);
        public List<Cliente> Listar();
    }
}
