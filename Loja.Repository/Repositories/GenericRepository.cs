using System.Threading.Tasks;
using Loja.Repository.Contracts;
using Loja.Repository.Data;

namespace Loja.Repository.Repositories
{
    public class GenericRepository : IGenericRepository
    {
        private readonly ClientContext _clientContext;

        public GenericRepository(ClientContext clientContext)
        {
            _clientContext = clientContext;
        }

        public void Delete<T>(T entity) where T : class
        {
            _clientContext.Remove(entity);
        }

        public void Post<T>(T entity) where T : class
        {
            _clientContext.Add(entity);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _clientContext.SaveChangesAsync() > 0 ? true : false;
        }

        public void Update<T>(T entity) where T : class
        {
            _clientContext.Update(entity);
        }
    }
}