using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickScaleAndIdentity.Models
{
    public class EFUserRepository : IUserRepository
    {
        QuickScaleDbContext context;

        public EFUserRepository(QuickScaleDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<User> Users => context.Users;
    }
}
