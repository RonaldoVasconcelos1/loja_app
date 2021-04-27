using System;
using System.Threading.Tasks;
using Loja.Business.Contracts;
using Loja.Domain.Entities;
using Loja.Repository.Contracts;

namespace Loja.Business.Services
{
    public class ProdocutService : IProductService
    {
        private readonly IGenericRepository _crud;
        private readonly IProductRepository _repository;
        public ProdocutService(IGenericRepository crud, IProductRepository repository)
        {
            _repository = repository;
            _crud = crud;

        }
        public async Task<Product> Post(Product product)
        {
            try
            {
                _crud.Post<Product>(product);
                if (await _crud.SaveChangesAsync())
                    return await _repository.GetById(product.Id);

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
          ;
        }

        public async Task<Product> Update(Product model, int id)
        {
            try
            {
                var product = await _repository.GetById(id);

                if (product == null)
                    return null;

                _crud.Update(product);
                if (await _crud.SaveChangesAsync())
                    return await _repository.GetById(product.Id);

                return null;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public async Task<bool> Delete(int id)
        {
            try
            {
                var product = await _repository.GetById(id);

                if (product == null)
                    return false;

                _crud.Delete(product);
                return await _crud.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public async Task<Product[]> GetAll() => await _repository.GetAll() == null ? null : await _repository.GetAll();
        public async Task<Product> GetById(int id) => await _repository.GetById(id) == null ? null : await _repository.GetById(id);
    }
}