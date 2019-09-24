using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickScaleProtoType.Models
{
    public class EFScaleRepository : IScaleRepository
    {
        private ApplicationDbContext context;
        public EFScaleRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Scale> Scales => context.Scales;

    }
}
