using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        [Key]
        public int Writer_ID { get; set; }
        public string Writer_Name { get; set; } 
        public string Writer_About { get; set; }
        public string Writer_Image { get; set; }
        public string Writer_Mail { get; set; }
        public string Writer_Password { get; set; }
        public string Writer_Status { get; set; }
    }
}
