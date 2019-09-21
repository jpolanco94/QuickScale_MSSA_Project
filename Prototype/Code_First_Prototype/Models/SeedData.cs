using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;

namespace QuickScaleProtoType.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices.GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Users.Any())
            {
                context.Users.AddRange(
                    new User
                    {
                        Username = "Guitardude1",
                        Password = "Qwerty123",
                        Email = "guitardude1@yahoo.com"
                    },
                    new User
                    {
                        Username = "Guitardood",
                        Password = "123456",
                        Email = "guitardood4@yahoo.com"
                    }); 
            }
            if (!context.Scales.Any())
            {
                context.Scales.AddRange(
                    new Scale
                    {
                        Key = "A",
                        Mode = "Blues"
                    },
                    new Scale
                    {
                        Key = "B",
                        Mode = "Blues"
                    });
            }
            context.SaveChanges();

        }
    }
}
