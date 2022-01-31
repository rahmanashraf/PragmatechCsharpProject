using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Test
{
    internal class Human
    {
        private string ad;
        protected string soyad;
        public string fullname;
        public string AD
        {
            get 
            { 
                return ad; 
             
            }

            set 
            { 
                ad = value;
            }
        }
    }
}
