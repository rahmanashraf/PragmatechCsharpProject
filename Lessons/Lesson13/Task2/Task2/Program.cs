using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate calc=new Calculate();

            Console.WriteLine($"{calc.Bolme(30, 2, 5)}\n{calc.Vur(30, 2, 5)}\n{calc.Cix(30, 2, 5)}\n{calc.Topla(30, 2, 5)} ");
        }
    }
    interface ISum
    {
        double Topla(params double[] numbers);
    }
    interface IDivide
    {
        double Bolme(params double[] numbers);
    }
    interface IDifference
    {
        double Cix(params double[] numbers);
    }
    interface IMultiple
    {
        double Vur(params double[] numbers);
    }
    public class Calculate : IDivide, IDifference, IMultiple, ISum
    {
        public double Bolme(params double[] numbers)
        {
            double sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                for (int k = 0; k < numbers.Length; k++)
                {
                    numbers[k] = numbers[k] / sum;
                }
                    
                
            }
            return sum;
        }

        public double Cix(params double[] numbers)
        {
            double cavab = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                
                cavab -= numbers[i];

            }
            return cavab;
        }

        public double Topla(params double[] numbers)
        {
            double cavab = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                cavab += numbers[i];
            }
            return cavab;
        }

        public double Vur(params double[] numbers)
        {
            double cavab = 0;
            
            for (int i = 0; i < numbers.Length; i++)
            {

                cavab *= numbers[i];
            }
            return cavab;
        }
    }

}
