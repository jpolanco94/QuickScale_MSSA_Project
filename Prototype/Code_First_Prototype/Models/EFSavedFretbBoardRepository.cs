using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickScaleProtoType.Models
{
    public class EFSavedFretBoardRepository : ISavedFretBoardRepository
    {
        private ApplicationDbContext context;
        public EFSavedFretBoardRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<SavedFretBoard> SavedFretBoards => context.SavedFretBoards;

    }
}
}
