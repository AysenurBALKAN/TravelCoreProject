using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEntityLayer.Concrete
{
   public class Newslatter
    {
        [Key]
        public int NewslatterId { get; set; }
        public string Mail { get; set; }
    }
}
