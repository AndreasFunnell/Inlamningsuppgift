using Inlamningsuppgift.Contexts;
using Inlamningsuppgift.Entities;

namespace Inlamningsuppgift.Repositories
{
    internal class CustomerRepository : Repo<CustomerEntity>
    {
        public CustomerRepository(DataContext context) : base(context)
        {
        }
    }


}
