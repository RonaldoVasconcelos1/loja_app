using System.Threading.Tasks;
using Loja.Domain.Entities;

namespace Loja.Repository.Contracts
{
    public interface IClientRepository
    {
        Task<Client[]> GetAll();
        Task<Client> GetById(int id);
        Task<Client> GetByCpf(string cpf);
    }
}