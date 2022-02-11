using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterCard
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Card card1=new Card(43323425253322529,1000,50);
                 
            card1.AddVirtualCard();
            card1.AddVirtualCard();
            card1.AddVirtualCard();
            card1.AddVirtualCard();
            card1.AddVirtualCard();


            Console.WriteLine(card1.Money);


        }
    }
}
