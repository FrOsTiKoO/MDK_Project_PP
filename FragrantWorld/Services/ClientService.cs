using FragrantWorld.DatabaseContext;
using FragrantWorld.Interface;
using FragrantWorld.Mode1s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FragrantWorld.Services
{
    public class ClientService : IClientService
    {
        private readonly AppDbContext _context;

        public ClientService(AppDbContext context)
        {
            _context = context;
        }
        public List<Client> GetAllClients()
        {
            return _context.Clients.ToList();
        }
    }
}
