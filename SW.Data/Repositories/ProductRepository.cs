using SW.Data.Infrastructure;
using SW.Model.Models;

namespace SW.Data.Repositories
{
    public interface IProductRepository
    {

    }

    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}