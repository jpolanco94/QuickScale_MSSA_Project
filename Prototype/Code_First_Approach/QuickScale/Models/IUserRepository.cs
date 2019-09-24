using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickScale.Models
{
    public interface IUserRepository
    {
        IQueryable<User> Users { get; }
    }
}
