using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int Contact_ID { get; set; }
        public string Contact_UserName { get; set; }
        public string Contact_Mail { get; set; }
        public string Contact_Subject { get; set; }

        public string Contact_Message { get; set; }
        public DateTime Contact_Date { get; set; }
        public bool Contact_Status { get; set; }


    }
}
