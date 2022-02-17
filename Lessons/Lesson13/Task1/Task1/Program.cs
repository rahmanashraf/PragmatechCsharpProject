using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    interface IFigure
    {
        void CalculateArea();
        void CalculatePerimeter();

    }
    class Rectangle : IFigure
    {
        public void CalculateArea()
        {
            throw new NotImplementedException();
        }

        public void CalculatePerimeter()
        {
            throw new NotImplementedException();
        }
    }
    class Circle : IFigure
    {
        public void CalculateArea()
        {
            throw new NotImplementedException();
        }

        public void CalculatePerimeter()
        {
            throw new NotImplementedException();
        }
    }
    class Triangle : IFigure
    {
        public void CalculateArea()
        {
            throw new NotImplementedException();
        }

        public void CalculatePerimeter()
        {
            throw new NotImplementedException();
        }
    }
    class Square : IFigure
    {
        public void CalculateArea()
        {
            throw new NotImplementedException();
        }

        public void CalculatePerimeter()
        {
            throw new NotImplementedException();
        }
    }
}
