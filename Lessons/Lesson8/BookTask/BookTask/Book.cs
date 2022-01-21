using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTask
{
    internal class Book
    {
        public string Name;
        public int Page;
        public int Count;

        public Book(string bookname,int bookpage,int bookcount)
        {
            Name = bookname;
            Page = bookpage;    
            Count = bookcount;  
        }
    }
}
