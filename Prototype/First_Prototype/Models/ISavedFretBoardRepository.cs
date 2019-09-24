using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickScaleProtoType.Models
{
    interface ISavedFretBoardRepository
    {
        IQueryable<SavedFretBoard> SavedFretBoards { get; }
    }
}
