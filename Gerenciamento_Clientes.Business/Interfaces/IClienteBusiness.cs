using Gerenciamento_Clientes.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_Clientes.Business
{
    public interface IClienteBusiness
    {
        public void Registrar(Cliente cliente);

        public void Editar(Cliente cliente);

        public void Excluir(int id);
        public List<Cliente> Listar();
    }
}
