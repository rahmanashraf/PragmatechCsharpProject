using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    enum Currency
    {
        AZN = 1, USD = 2, EURO = 3
    }
    enum PaymentType
    {
        CARD, CASH
    }
    internal class CashRegister
    {
        public double TotalAmount, TotalSalesCount = 0;
        public Currency currency;


        public CashRegister(double am)
        {
            TotalAmount = am;
            currency = Currency.AZN;
            

        }
        public void AddSale(string currenct, double mebleg)
        {
            double cem = 0;
            if (currency == Currency.AZN && (Currency)Enum.Parse(typeof(Currency), currenct) == Currency.AZN || currency == Currency.USD && (Currency)Enum.Parse(typeof(Currency), currenct) == Currency.USD || currency == Currency.EURO && (Currency)Enum.Parse(typeof(Currency), currenct) == Currency.EURO)
            {
                cem = TotalAmount + mebleg;
                Console.WriteLine("Alis verisden sonra SIZIN KASSANIZDAKI TOTAL MEBLEG:"+cem+" "+currency);
            }
            else
            {
                if (currency == Currency.AZN && (Currency)Enum.Parse(typeof(Currency), currenct) == Currency.USD)
                {
                    cem = TotalAmount + (mebleg * 1.70);
                    Console.WriteLine("Alis verisden sonra SIZIN KASSANIZDAKI TOTAL MEBLEG:" + cem + " " + currency);
                }
                else if (currency == Currency.EURO && (Currency)Enum.Parse(typeof(Currency), currenct) == Currency.USD)
                {
                    cem = TotalAmount + (mebleg * 0.87);
                    Console.WriteLine("Alis verisden sonra SIZIN KASSANIZDAKI TOTAL MEBLEG:" + cem + " " + currency);
                }
                else if (currency == Currency.AZN && (Currency)Enum.Parse(typeof(Currency), currenct) == Currency.EURO)
                {
                    cem = TotalAmount + (mebleg * 2);
                    Console.WriteLine("Alis verisden sonra SIZIN KASSANIZDAKI TOTAL MEBLEG:" + cem + " " + currency);
                }
                else if (currency == Currency.EURO && (Currency)Enum.Parse(typeof(Currency), currenct) == Currency.AZN)
                {
                    cem = TotalAmount + (mebleg * 0.50);
                    Console.WriteLine("Alis verisden sonra SIZIN KASSANIZDAKI TOTAL MEBLEG:" + cem + " " + currency);
                }
                else if (currency == Currency.USD && (Currency)Enum.Parse(typeof(Currency), currenct) == Currency.AZN)
                {
                    cem = TotalAmount + (mebleg * 0.58);
                    Console.WriteLine("Alis verisden sonra SIZIN KASSANIZDAKI TOTAL MEBLEG:" + cem + " " + currency);
                }
                else if (currency == Currency.USD && (Currency)Enum.Parse(typeof(Currency), currenct) == Currency.EURO)
                {
                    cem = TotalAmount + (mebleg *1.17);
                    Console.WriteLine("Alis verisden sonra SIZIN KASSANIZDAKI TOTAL MEBLEG:" + cem + " " + currency);
                }

            }
            

        }
        public void RemoveSale(string currenct, double mebleg)
        {
            double cem = 0;
            if (currency == Currency.AZN && (Currency)Enum.Parse(typeof(Currency), currenct) == Currency.AZN || currency == Currency.USD && (Currency)Enum.Parse(typeof(Currency), currenct) == Currency.USD || currency == Currency.EURO && (Currency)Enum.Parse(typeof(Currency), currenct) == Currency.EURO)
            {
                cem = TotalAmount - mebleg;
                Console.WriteLine("Alis verisden sonra SIZIN KASSANIZDAKI TOTAL MEBLEG:" + cem + " " + currency);
            }
            else
            {
                if (currency == Currency.AZN && (Currency)Enum.Parse(typeof(Currency), currenct) == Currency.USD)
                {
                    cem = TotalAmount - (mebleg * 1.70);
                    Console.WriteLine("Alis verisden sonra SIZIN KASSANIZDAKI TOTAL MEBLEG:" + cem + " " + currency);
                }
                else if (currency == Currency.EURO && (Currency)Enum.Parse(typeof(Currency), currenct) == Currency.USD)
                {
                    cem = TotalAmount - (mebleg * 0.87);
                    Console.WriteLine("Alis verisden sonra SIZIN KASSANIZDAKI TOTAL MEBLEG:" + cem + " " + currency);
                }
                else if (currency == Currency.AZN && (Currency)Enum.Parse(typeof(Currency), currenct) == Currency.EURO)
                {
                    cem = TotalAmount - (mebleg * 2);
                    Console.WriteLine("Alis verisden sonra SIZIN KASSANIZDAKI TOTAL MEBLEG:" + cem + " " + currency);
                }
                else if (currency == Currency.EURO && (Currency)Enum.Parse(typeof(Currency), currenct) == Currency.AZN)
                {
                    cem = TotalAmount - (mebleg * 0.50);
                    Console.WriteLine("Alis verisden sonra SIZIN KASSANIZDAKI TOTAL MEBLEG:" + cem + " " + currency);
                }
                else if (currency == Currency.USD && (Currency)Enum.Parse(typeof(Currency), currenct) == Currency.AZN)
                {
                    cem = TotalAmount - (mebleg * 0.58);
                    Console.WriteLine("Alis verisden sonra SIZIN KASSANIZDAKI TOTAL MEBLEG:" + cem + " " + currency);
                }
                else if (currency == Currency.USD && (Currency)Enum.Parse(typeof(Currency), currenct) == Currency.EURO)
                {
                    cem = TotalAmount - (mebleg * 1.17);
                    Console.WriteLine("Alis verisden sonra SIZIN KASSANIZDAKI TOTAL MEBLEG:" + cem + " " + currency);
                }

            }


        }
    }
}    

