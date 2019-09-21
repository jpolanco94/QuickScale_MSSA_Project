using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickScaleProtoType.Models
{
    public interface IQuickScaleRepository
    {
        IQueryable<User> Users { get; }
        IQueryable<SavedFretBoard> SavedFretBoards { get; }
        IQueryable<Scale> Scales { get; }
    }
}
