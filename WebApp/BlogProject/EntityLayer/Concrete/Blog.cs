using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        public int Blog_ID { get; set; }
        public string Blog_Title { get; set; }   
        public string Blog_Content { get; set; }
        public string Blog_ThumbnailImage { get; set; }
        public string Blog_Image { get; set; }
        public DateTime Blog_CreateDate { get; set; }
        public bool Blog_Status { get; set; }   

    }
}
