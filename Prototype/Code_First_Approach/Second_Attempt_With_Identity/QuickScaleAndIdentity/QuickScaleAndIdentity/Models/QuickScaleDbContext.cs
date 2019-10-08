using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;


namespace QuickScaleAndIdentity.Models
{
    public class QuickScaleDbContext : DbContext
    {
        public QuickScaleDbContext(DbContextOptions<QuickScaleDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Scale> Scales { get; set; }
        public DbSet<SavedFretBoard> SavedFretBoards { get; set; }
    }
}
