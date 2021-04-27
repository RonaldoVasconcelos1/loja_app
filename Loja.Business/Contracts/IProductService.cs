using System.Threading.Tasks;
using Loja.Domain.Entities;

namespace Loja.Business.Contracts
{
    public interface IProductService
    {
        Task<Product> Post(Product product);
        Task<Product> Update(Product product, int id);
        Task<bool> Delete(int id);
        Task<Product[]> GetAll();
        Task<Product> GetById(int id);
    }
}