using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickScaleProtoType.Models
{
    public class EFQuickScaleRepository : IUserRepository, IScaleRepository, 
    {
        private ApplicationDbContext context;
        public EFQuickScaleRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<User> Users => context.Users;
        public IQueryable<SavedFretBoard> SavedFretBoards => context.SavedFretBoards;
        public IQueryable<Scale> Scales => context.Scales;    
    }
}
