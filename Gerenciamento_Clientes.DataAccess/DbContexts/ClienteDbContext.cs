using Gerenciamento_Clientes.Common;
using Microsoft.EntityFrameworkCore;

namespace Gerenciamento_Clientes.DataAccess.DbContexts
{
    public class ClienteDbContext : DbContext
    {

        public ClienteDbContext(DbContextOptions<ClienteDbContext> options) : base(options)
        {

        }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
