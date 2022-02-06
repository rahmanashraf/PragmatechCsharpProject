using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetterSetter
{
    internal class Student
    {
        private int kilo; //field
        
    public int Kilo { 
            get 
            {
                return kilo; 
            }
            set
            {
                if (value<0)
                {
                    this.kilo = 0;
                }
                else
                {
                    this.kilo = value;
                }
            }
        }
    }
}
