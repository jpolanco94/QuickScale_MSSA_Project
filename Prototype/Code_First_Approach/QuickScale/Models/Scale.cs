using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickScale.Models
{
    public class Scale
    {
        [Key]
        public int ScaleID { get; set; }
        public string RootNote { get; set; }
        public string Mode { get; set; }
    }
}
