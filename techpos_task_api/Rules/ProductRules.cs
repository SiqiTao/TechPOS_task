using System.Reflection;
using techpos_task_api.Entities;
using techpos_task_api.Repository;

namespace techpos_task_api.Rules
{
    public class ProductRules
    {
        // setting a private attribute called _repository
        private readonly IProductRepository _repository;

        // assigning this private attribute that was just set above with a value productRepository
        public ProductRules(IProductRepository productRepository)
        {
            _repository = productRepository;
        }

        // defining a method GetProduct which uses the defined _repository attribute
        public Product? GetProduct(int id)
        { 
            return _repository.GetAll().FirstOrDefault(_ => _.Id == id); 
        }

        public int UpdateProduct(Product product)
        {
            _repository.Update(product);
            return product.Id;
        }

        public int? DeleteProduct(int id) 
        {
            var product = GetProduct(id);
            if (product != null)
            {
                _repository.Delete(id);
                return product.Id;
            }
            return null;
        }

        public int AddProduct(Product product)
        {
            _repository.Insert(product);
            return product.Id;
        }
    }
}
