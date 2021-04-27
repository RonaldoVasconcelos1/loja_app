using System.Threading.Tasks;
using Loja.Domain.Entities;
using Loja.Repository.Contracts;

namespace Loja.Repository.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public Task<Category[]> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<Category> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Category> GetByName(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}