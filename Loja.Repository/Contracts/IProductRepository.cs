using System.Threading.Tasks;
using Loja.Domain.Entities;

namespace Loja.Repository.Contracts
{
    public interface IProductRepository
    {
        Task<Product[]> GetAll();
        Task<Product> GetById(int id);
    }
}