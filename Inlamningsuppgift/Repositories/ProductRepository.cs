using Inlamningsuppgift.Contexts;
using Inlamningsuppgift.Entities;

namespace Inlamningsuppgift.Repositories
{
    internal class ProductRepository : Repo<ProductEntity>
    {
        public ProductRepository(DataContext context) : base(context)
        {
        }
    }


}
