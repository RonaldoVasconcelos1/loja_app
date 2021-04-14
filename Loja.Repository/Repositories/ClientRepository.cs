using System.Linq;
using System.Threading.Tasks;
using Loja.Domain.Entities;
using Loja.Repository.Contracts;
using Loja.Repository.Data;
using Microsoft.EntityFrameworkCore;

namespace Loja.Repository.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly ClientContext _clientContext;

        public ClientRepository(ClientContext clientContext)
        {
            _clientContext = clientContext;
        }
        // public async Task<Client[]> GetAll() => await _clientContext.Clients.AsQueryable().ToArrayAsync();
        public async Task<Client[]> GetAll() => await _clientContext.Clients.ToArrayAsync();
        public async Task<Client> GetByCpf(string cpf) => await _clientContext.Clients.FirstOrDefaultAsync(x => x.Cpf == cpf);
        public async Task<Client> GetById(int id) => await _clientContext.Clients.FirstOrDefaultAsync(x => x.Id == id);
    }
}