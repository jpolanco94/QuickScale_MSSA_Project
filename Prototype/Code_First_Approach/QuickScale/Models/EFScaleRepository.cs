using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickScale.Models
{
    public class EFScaleRepository : IScaleRepository
    {
        private QuickScaleDBContext context;
        public EFScaleRepository(QuickScaleDBContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Scale> Scales => context.Scales;
    }
}
