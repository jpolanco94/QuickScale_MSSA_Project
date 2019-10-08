using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace QuickScale.Models
{
    public class UserIdentityDBContext : IdentityDbContext<AppUser>
    {
        public UserIdentityDBContext(DbContextOptions<UserIdentityDBContext> options)
            : base(options)
        {

        }
    }
}
