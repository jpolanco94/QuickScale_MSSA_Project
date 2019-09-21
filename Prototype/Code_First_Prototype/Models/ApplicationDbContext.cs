using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;
using QuickScaleProtoType.Models;



namespace QuickScaleProtoType.Models
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    
        public DbSet<User> Users { get; set; }
        public DbSet<Scale> Scales { get; set; }
        public DbSet<SavedFretBoard> SavedFretBoards { get; set; }
    }
}
