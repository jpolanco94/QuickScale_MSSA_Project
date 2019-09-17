using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace QuickScaleProtoType.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if(!context.Users.Any())
            {
                context.Users.AddRange(
                    new User
                    {
                        Username = "guitardude",
                        Password = "qwerty",
                        Email = "guitardude@yahoo.com"
                    },
                    new User
                    {
                        Username = "guitardude60",
                        Password = "qwerty123",
                        Email = "guitardude60@yahoo.com"
                    }
                    );
                context.SaveChanges();
            }
        }
        
    }
}
