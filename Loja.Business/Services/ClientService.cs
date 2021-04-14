using System.Threading.Tasks;
using Loja.Business.Contracts;
using Loja.Domain.Entities;
using Loja.Repository.Contracts;

namespace Loja.Business.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        private readonly IGenericRepository _genericRepository;

        public ClientService(IClientRepository clientRepository, IGenericRepository genericRepository)
        {
            _clientRepository = clientRepository;
            _genericRepository = genericRepository;
        }

        public async Task<Client> Post(Client client)
        {
            _genericRepository.Post<Client>(client);

            if (await _genericRepository.SaveChangesAsync())
            {
                return await _clientRepository.GetById(client.Id);
            }

            return null;
        }
        public async Task<Client> Update(Client model, int id)
        {
            var client = _clientRepository.GetById(id);

            if (client == null)
                return null;

            _genericRepository.Update(client);

            if (await _genericRepository.SaveChangesAsync())
            {
                return await _clientRepository.GetById(client.Id);
            }

            return null;

        }
        public async Task<bool> Delete(int id)
        {
            var clients = _clientRepository.GetById(id);

            if (clients == null)
                return false;

            _genericRepository.Delete(clients);

            var result = await _genericRepository.SaveChangesAsync();

            return result;
        }

        public async Task<Client[]> GetAll() => await _clientRepository.GetAll();
        public async Task<Client> GetByCpf(string cpf) => await _clientRepository.GetByCpf(cpf);
        public async Task<Client> GetById(int id) => await _clientRepository.GetById(id);
        
    }
}