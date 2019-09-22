using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickScaleProtoType.Models
{
    interface IScaleRepository
    {
        IQueryable<Scale> Scales { get; }
    }
}
