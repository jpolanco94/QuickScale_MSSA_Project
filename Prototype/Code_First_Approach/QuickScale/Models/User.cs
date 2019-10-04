using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace QuickScale.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }
        [MaxLength(15)]
        public string Username {get;set;}
        public string Password { get; set; }
        public string Email { get; set; }

    }
}
