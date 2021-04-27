using System.Threading.Tasks;
using Loja.Domain.Entities;

namespace Loja.Repository.Contracts
{
    public interface ICategoryRepository
    {
        Task<Category[]> GetAll();
        Task<Category> GetById(int id);
        Task<Category> GetByName(string name);
    }
}