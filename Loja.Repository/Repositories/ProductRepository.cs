using System.Threading.Tasks;
using Loja.Domain.Entities;
using Loja.Repository.Contracts;

namespace Loja.Repository.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _context;
        public ProductRepository(ProductContext context)
        {
            _context = context;

        }
        public async Task<Product[]> GetAll() => await _context.Products.AsNoTracking().ToArrayAsync();


        public async Task<Product> GetById(int id) => await _context.Products
            .AsNoTracking()
            .SingleOrDefault(p => p.Id.Equals(id));

    }
}