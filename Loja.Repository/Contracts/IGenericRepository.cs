using System.Threading.Tasks;

namespace Loja.Repository.Contracts
{
    public interface IGenericRepository
    {
        void Post<T>(T entity) where T : class;

        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveChangesAsync();
    }
}