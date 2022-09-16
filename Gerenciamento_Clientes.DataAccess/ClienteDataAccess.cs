using Gerenciamento_Clientes.Common;
using Gerenciamento_Clientes.DataAccess.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerenciamento_Clientes.DataAccess
{
    public class ClienteDataAccess : IClienteDataAccess
    {
        private readonly ClienteDbContext db;
        public ClienteDataAccess(ClienteDbContext clienteDbContext)
        {
            db = clienteDbContext;
        }
        public void Editar(Cliente cliente)
        {
            db.Clientes.Update(cliente);
            db.SaveChangesAsync();
        }

        public void Excluir(int id)
        {
            db.Clientes.Remove(db.Clientes.Where(x => x.Id == id).FirstOrDefault());
            db.SaveChangesAsync();
        }

        public List<Cliente> Listar()
        {
            return db.Clientes.ToList();
        }

        public void Registrar(Cliente cliente)
        {
            db.Clientes.Add(cliente);
            db.SaveChangesAsync();
        }
    }
}
