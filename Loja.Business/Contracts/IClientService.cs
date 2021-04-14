using System.Threading.Tasks;
using Loja.Domain.Entities;

namespace Loja.Business.Contracts
{
    public interface IClientService
    {
        Task<Client> Post(Client client);
        Task<Client> Update(Client client, int id);
        Task<bool> Delete(int id);
        Task<Client[]> GetAll();
        Task<Client> GetById(int id);
        Task<Client> GetByCpf(string cpf);
    }
}