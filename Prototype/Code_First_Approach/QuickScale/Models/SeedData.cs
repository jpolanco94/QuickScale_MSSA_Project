using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace QuickScale.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            QuickScaleDBContext context = app.ApplicationServices.GetRequiredService<QuickScaleDBContext>();
            context.Database.Migrate();
            //if (!context.Users.Any())
            //{
            //    context.Users.AddRange(
            //        new User
            //        {
            //            Username = "dood",
            //            Password = "qwerty",
            //            Email = "fakeemail@fakeemail.com"
            //        },
            //        new User
            //        {
            //            Username = "dude",
            //            Password = "qwerty123",
            //            Email = "fakeemail123@fakeemail.com"
            //        });
            //    context.SaveChanges();
            //}
            //if (!context.Scales.Any())
            //{
            //    context.Scales.AddRange(
            //        new Scale
            //        {
            //            RootNote = "A",
            //            Mode = "Blues"
            //        },
            //        new Scale
            //        {
            //            RootNote = "C#",
            //            Mode = "Lydian"
            //        });
            //    context.SaveChanges();
            //}
            //if (!context.SavedFretboards.Any())
            //{
            //    context.SavedFretboards.AddRange(
            //        new SavedFretboard
            //        {
            //            NumberOfFrets = 12,
            //            NumberOfStrings = 6,
            //            FirstStringNote = "E",
            //            SecondStringNote = "A",
            //            ThirdStringNote = "D",
            //            FourthStringNote = "G",
            //            FifthStringNote = "A",
            //            SixthStringNote = "E",
            //            SeventhtringNote = null,
            //            EighthStringNote = null,
            //            NinthStringNote = null,
            //            TenthStringNote = null
            //        },
            //        new SavedFretboard
            //        {
            //            NumberOfFrets = 17,
            //            NumberOfStrings = 10,
            //            FirstStringNote = "E",
            //            SecondStringNote = "B",
            //            ThirdStringNote = "G",
            //            FourthStringNote = "D",
            //            FifthStringNote = "A",
            //            SixthStringNote = "E",
            //            SeventhtringNote = "B",
            //            EighthStringNote = "G",
            //            NinthStringNote = "D",
            //            TenthStringNote = "A"
            //        });
            //    context.SaveChanges();
            //}
        }
    }
}
