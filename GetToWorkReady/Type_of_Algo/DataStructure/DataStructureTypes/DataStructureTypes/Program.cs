using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stck = new Stack<int>();
            stck.Push(1);
            stck.Push(2);
            stck.Push(3);
            stck.Pop();

            Queue<int> que = new Queue<int>();

            que.Enqueue(1);
            que.Enqueue(2);
            que.Enqueue(3);
            que.Enqueue(4);
            que.Dequeue();

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);


            HashSet<int> set = new HashSet<int>();
            set.Add(1);
            set.Add(2);
            set.Add(3);
            set.Add(4);

            SortedDictionary<int, string> dict = new SortedDictionary<int, string>();


            dict.Add(1, "salam");
            dict.Add(2, "netersen");

            Dictionary<int, string> dict2 = new Dictionary<int, string>();

            dict2.Add(1, "REhman");
            dict2.Add(2, "AShrafov");
            dict2.Add(3, "Imran");
            dict2.Add(4, "Eli");
            dict2.Add(5, "Veli");
            dict2.Add(6, "Asif");


            int i = 0;
            begin:
            i = i + 1;
            Console.WriteLine( dict2[i]);

            if (i < dict2.Count)
            {
                goto begin;
            }
            

        }     
    }
}
