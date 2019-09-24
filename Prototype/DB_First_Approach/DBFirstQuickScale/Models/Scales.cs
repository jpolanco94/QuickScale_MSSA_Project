using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DBFirstQuickScale.Models
{
    public class Scales
    {
        [Key]
        public int scaleID { get; set; }
        public string scaleKey { get; set; }
        public string scaleMode { get; set; }
    }
}
