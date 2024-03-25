using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEntityLayer.Concrete
{
   public class Guide
    {
        [Key]
        public int GuideId { get; set; }
        public string GuideName { get; set; }
        public string Description { get; set; }
        public string image { get; set; }
        public string TwitterUrl { get; set; }
        public string InstagramUrl { get; set; }
        public bool Status { get; set; }
    }
}
