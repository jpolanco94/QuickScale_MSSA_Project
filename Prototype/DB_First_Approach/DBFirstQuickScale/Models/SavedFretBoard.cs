using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DBFirstQuickScale.Models
{
    public class SavedFretBoard
    {
        [Key]
        public int fretboardID { get; set; }
        public int numberOfFrets { get; set; }
        public int numberOfStrings { get; set; }
        public string firstStringNote { get; set; }
        public string secondStringNote { get; set; }
        public string thirdStringNote { get; set; }
        public string fourthStringNote { get; set; }
        public string fifthStringNote { get; set; }
        public string sixthStringNote { get; set; }
        public string seventhStringNote { get; set; }
        public string eightStringNote { get; set; }
    }
}
