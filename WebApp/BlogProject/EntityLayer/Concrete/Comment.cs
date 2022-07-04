using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        public int Comment_ID { get; set; }
        public string Comment_Writer { get; set; }
        public string Comment_Title { get; set; }
        public string Comment_Content { get; set; }

        public DateTime Comment_Date { get; set; }
        public bool Comment_Status { get;set; }
    }
}
