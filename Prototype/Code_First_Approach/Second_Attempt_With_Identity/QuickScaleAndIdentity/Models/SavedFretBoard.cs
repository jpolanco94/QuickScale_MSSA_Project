using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QuickScaleAndIdentity.Models
{
    public class SavedFretBoard
    {
        [Key]
        public int SavedFretboardID { get; set; }
        public string FirstStringNote { get; set; }
        public string SecondStringNote { get; set; }
        public string ThirdStringNote { get; set; }
        public string FourthStringNote { get; set; }
        public string FifthStringNote { get; set; }
        public string SixthStringNote { get; set; }
        public string RootNote { get; set; }
        public string Mode { get; set; }

        [ForeignKey("Id")]
        public AppUser User { get; set; }
    }
}
