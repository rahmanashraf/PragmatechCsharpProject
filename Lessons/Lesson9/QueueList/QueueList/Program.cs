using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("1");
            queue.Enqueue("2");
            queue.Enqueue("3");
            queue.Enqueue("4");
            queue.Enqueue("5");
            queue.Enqueue("6");
            queue.Enqueue("7");
            queue.Enqueue("8");
            queue.Enqueue("9");
            queue.Enqueue("10");
            queue.Enqueue("11");
            queue.Enqueue("12");
            queue.Enqueue("13");
            queue.Enqueue("14");
            queue.Enqueue("11");
            queue.Enqueue("11");

            if (queue.Count>10)
              {
                int say = queue.Count - 9;
                for (int i = 0; i < say; i++)
                {
                    queue.Dequeue();
                    
                }
                queue.Enqueue("10cuteze geldi");
            }

           
            foreach (var item in queue)
            {

                Console.WriteLine(item);
            }








        }
    }
}
