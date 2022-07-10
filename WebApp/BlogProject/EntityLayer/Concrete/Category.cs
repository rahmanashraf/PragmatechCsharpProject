using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int Cat_ID  { get; set; }
        public string Cat_Name { get; set; }
        public string Cat_Description { get; set; } 
        public bool Cat_Status { get; set; }

        public List<Blog> Blogs { get; set; }

    }
}
