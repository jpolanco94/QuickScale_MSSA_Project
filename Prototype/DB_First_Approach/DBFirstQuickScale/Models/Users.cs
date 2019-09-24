using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DBFirstQuickScale.Models
{
    public class Users
    {
        [Key]
        public int userID { get; set; }
        public string username { get; set; }
        public string userPassword { get; set; }
        public string email { get; set; }
    }
}
