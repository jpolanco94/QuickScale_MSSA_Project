using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuickScaleProtoType.Models
{

    public class Scale
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ScaleId { get; set; }
        public string Key { get; set; }
         public string Mode { get; set; }


    }
    
}
