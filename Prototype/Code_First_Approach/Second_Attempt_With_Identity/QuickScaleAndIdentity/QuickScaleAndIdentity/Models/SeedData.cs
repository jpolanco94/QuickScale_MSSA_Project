using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace QuickScaleAndIdentity.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            QuickScaleDbContext context = app.ApplicationServices.GetRequiredService<QuickScaleDbContext>();
            context.Database.Migrate();
        }
    }
}
