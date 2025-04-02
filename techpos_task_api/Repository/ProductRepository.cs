using System.Linq.Expressions;
using techpos_task_api.Entities;

namespace techpos_task_api.Repository
{
    public interface IProductRepository
    {
        IQueryable<Product> Get(Expression<Func<Product, bool>> predicate);
        Product GetByIdWithUPC(int id);
        IQueryable<Product> GetAll();
        void Insert(Product entityToInsert);
        void Delete(int id);
        void Delete(Product entityToDelete);
        void Update(Product entityToUpdate);
    }
}
