using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickScale.Models
{
    public class EFSavedFretboardRepository : ISavedFretboardRepository
    {
        private QuickScaleDBContext context;
        public EFSavedFretboardRepository(QuickScaleDBContext ctx)
        {
            context = ctx;
        }
        public IQueryable<SavedFretboard> SavedFretboards => context.SavedFretboards;
    }
}
