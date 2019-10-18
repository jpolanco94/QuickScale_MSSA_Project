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
        [MaxLength(5)]
        public string FirstStringNote { get; set; }
        [MaxLength(5)]
        public string SecondStringNote { get; set; }
        [MaxLength(5)]
        public string ThirdStringNote { get; set; }
        [MaxLength(5)]
        public string FourthStringNote { get; set; }
        [MaxLength(5)]
        public string FifthStringNote { get; set; }
        [MaxLength(5)]
        public string SixthStringNote { get; set; }
        [MaxLength(5)]
        public string RootNote { get; set; }
        [MaxLength(25)]
        public string Mode { get; set; }
        public string Id { get; set; }
        public string Username { get; set; }
    }
}
