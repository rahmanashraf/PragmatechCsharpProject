using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskMohtesem
{
    internal class Group
    {
        public int No = 100;
        public string GroupName;
        private int Capacity = 100;

        public Group(string groupName, int capacity)
        {
            GroupName=groupName;
            No++;
            Capacity = capacity;
        }

    }
}
