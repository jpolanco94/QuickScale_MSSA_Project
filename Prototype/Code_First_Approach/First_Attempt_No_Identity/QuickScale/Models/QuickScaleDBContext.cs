using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;

namespace QuickScale.Models
{
    public class QuickScaleDBContext : DbContext
    {
        public QuickScaleDBContext(DbContextOptions<QuickScaleDBContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Scale> Scales { get; set; }
        public DbSet<SavedFretboard> SavedFretboards {get; set;}
    }
}
