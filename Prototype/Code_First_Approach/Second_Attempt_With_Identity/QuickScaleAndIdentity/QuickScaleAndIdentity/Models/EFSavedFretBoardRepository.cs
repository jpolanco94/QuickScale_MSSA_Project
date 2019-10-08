using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickScaleAndIdentity.Models
{
    public class EFSavedFretBoardRepository : ISavedFretBoardRepository
    {
        private QuickScaleDbContext context;

        public EFSavedFretBoardRepository(QuickScaleDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<SavedFretBoard> SavedFretBoards => context.SavedFretBoards;
    }
}
