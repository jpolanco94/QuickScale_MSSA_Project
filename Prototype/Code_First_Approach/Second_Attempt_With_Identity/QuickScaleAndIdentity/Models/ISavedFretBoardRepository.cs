using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickScaleAndIdentity.Models
{
    public class ISavedFretBoardRepository
    {
        IQueryable<SavedFretBoard> SavedFretBoards { get; }
    }
}
