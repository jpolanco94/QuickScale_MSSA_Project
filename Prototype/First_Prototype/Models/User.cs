using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QuickScaleProtoType.Models
{
    public class User
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UserID { get; set; }
        //Just some preliminary data annotations. More will be added to the rest of my columns
        [Required (ErrorMessage ="A username is required")]
        [StringLength (15, MinimumLength =4, ErrorMessage ="Username must be between 4 and 15 characters")]
        public string Username { get; set; }

        public string Password { get; set; }
        public string Email { get; set; }

        //This navigation property was added but commented out becuase I want to
        //find out what the purpose of a navigation property is.
        //public virtual ICollection<SavedFretBoard> SavedFretBoards { get; set; }

    }
}
