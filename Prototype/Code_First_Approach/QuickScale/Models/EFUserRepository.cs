using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickScale.Models
{
    public class EFUserRepository :IUserRepository
    {
        private QuickScaleDBContext context;
        public EFUserRepository(QuickScaleDBContext ctx)
        {
            context = ctx;
        }
        public IQueryable<User> Users => context.Users;

        public User DeleteUser(int userID)
        {
            User dbEntry = context.Users.FirstOrDefault(p => p.UserID == userID);
            if (dbEntry != null)
            {
                context.Users.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
