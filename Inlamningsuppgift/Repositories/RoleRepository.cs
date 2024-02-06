using Inlamningsuppgift.Contexts;
using Inlamningsuppgift.Entities;

namespace Inlamningsuppgift.Repositories
{
    internal class RoleRepository : Repo<RoleEntity>
    {
        public RoleRepository(DataContext context) : base(context)
        {
        }
    }


}
