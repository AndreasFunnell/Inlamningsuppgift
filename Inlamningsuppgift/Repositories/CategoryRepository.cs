using Inlamningsuppgift.Contexts;
using Inlamningsuppgift.Entities;

namespace Inlamningsuppgift.Repositories
{
    internal class CategoryRepository : Repo<CategoryEntity>
    {
        public CategoryRepository(DataContext context) : base(context)
        {
        }
    }


}
