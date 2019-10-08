using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace QuickScaleAndIdentity.Models
{
    public class EFScaleRepository : IScaleRepository
    {
        private QuickScaleDbContext context;

        public EFScaleRepository(QuickScaleDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Scale> Scales => context.Scales;
    }
}
