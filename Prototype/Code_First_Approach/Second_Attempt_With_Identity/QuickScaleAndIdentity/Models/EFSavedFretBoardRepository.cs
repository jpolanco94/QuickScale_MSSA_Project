using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickScaleAndIdentity.Models
{
    public class EFSavedFretBoardRepository : ISavedFretBoardRepository
    {
        private AppIdentityDbContext context;

        public EFSavedFretBoardRepository(AppIdentityDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<SavedFretBoard> SavedFretBoards => context.SavedFretBoards;
    }
}
