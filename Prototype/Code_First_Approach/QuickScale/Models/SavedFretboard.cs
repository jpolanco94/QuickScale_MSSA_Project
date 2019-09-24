using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace QuickScale.Models
{
    public class SavedFretboard
    {
        [Key]
        public int SavedFretboardID { get; set; }
        public int NumberOfStrings { get; set; }
        public int NumberOfFrets { get; set; }
        public string FirstStringNote { get; set; }
        public string SecondStringNote { get; set; }
        public string ThirdStringNote { get; set; }
        public string FourthStringNote { get; set; }
        public string FifthStringNote { get; set; }
        public string SixthStringNote { get; set; }
        public string SeventhtringNote { get; set; }
        public string EighthStringNote { get; set; }
        public string NinthStringNote { get; set; }
        public string TenthStringNote { get; set; }

        [ForeignKey("UserID")]
        public User User { get; set; }
        [ForeignKey("ScaleID")]
        public Scale Scale { get; set; }
    }
}
