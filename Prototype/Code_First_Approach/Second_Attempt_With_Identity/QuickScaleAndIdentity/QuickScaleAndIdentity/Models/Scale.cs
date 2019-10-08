using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickScaleAndIdentity.Models
{
    public class Scale
    {
        [Key]
        public int ScaleId { get; set; }
        [MaxLength(10)]
        public string RootNote { get; set; }
        [MaxLength(20)]
        public string Mode { get; set; }
    }
}
