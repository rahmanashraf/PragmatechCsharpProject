using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int About_ID { get; set; }
        public string About_Details1 { get; set; }
        public string About_Details2 { get; set; }
        public string About_Image1 { get; set; }
        public string About_Image2 { get; set; }
        public string About_MapLoc { get; set; }
        public bool About_Status { get; set; }
    }
}
