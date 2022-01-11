using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testtask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //Task
            //1.bool a = (3 + 4 * 2 == 2 * 3) && (true + false / 2) ifadəsinin nəticəsi nədir və səbəbini qeyd edin..
            //2.Verilən 4 rəqəmli ədədin rəqəmlərinin cə30i tapan proqram yazın(Nümunə: int a = 1298 Nəticə: 1 + 2 + 9 + 8 = 20)
            //3.Verilən ədədin rəqəmləri arasında olan tək rəqəmləri ekranda göstərən proqram yazın(Nümunə : int a = 1298 Nəticə: 1,9)
            //4.Console.Readline vasitesile ilə istifadəçinin yaşını daxil etməsini istəyin.
            //İstifadəçinin yaşı 30 - dan kiçikdirsə istifadəçinin yaşının kvadratını ekrana çap edin
            //Yaş 30 - 40 aralığındadırsa daxil edilən ədədin son rəqə30i ekrana çap edin
            //Yaş 0 - dan kiçik vəya 100 - dən böyükdürsə ekrana "Düzgün məlumat daxil etməmisiniz" yazdırın
            //5.ay dəyəri daxil edildiyi zaman onun necə gun və hansi fesil olduğunu edən method yazın
            //6.Arrayin en boyuk elementini tapan methiod
            //7.Arrayin en kicik elementini tapan methiod
            //8.Verilən nums =[1, 2, 3, 6, 7, 8, 23, 78, 34, 12]
            //8.1 Tək ədədlərin cə30i tapan metod yazın
            //8.2 Daxilində 3 rəqəmi olan neçə ədəd olduğunu ekrana çap edən metod yazın
            //8.3 Tək ədədləri ayıraraq ayrıca bir massivə yığan metod yazın
            //8.4 Ədədlərin böyükdən kiçiyə doğru sıralayın
            //9. 2 ayrı arreyi birləşdirmək.
            //10.user - ın daxil etdiyi sözün sonuncu hərfini qaytarmaq.
            //11.Verilen sozun ve ya arrayin Lengthi tapan method yazmaq
            #endregion

            //Task1-&& operatorunun bir terefi false olanda ikinci terefi yoxlamaga ehtiac olmur
            //task2
            //Console.WriteLine(ReqemTopla(1298));
            //task3
            //TekTap(1298164512);
            //task4
            //Yastap();
            //task5
            //AyiTap();
            //task6
            //Console.WriteLine(Biggest(15,12,16,25,55,13,26));
            //task7
            //Console.WriteLine(Lowest(15, 12, 16, 25, 55, 13, 26));
            //task8
            //8.1//Console.WriteLine(TekededTopla(1, 2, 3, 6, 7, 8, 23, 78, 34, 12));
            //8.2//Console.WriteLine(UcuTap(1, 2, 3, 6, 7, 8, 23, 78, 34, 12));
            //8.3//Tekayir(1, 2, 3, 6, 7, 8, 23, 78, 34, 12);
            //8.4//SortReverse(1, 2, 3, 6, 7, 8, 23, 78, 34, 12);
            //task9
            //TwoArray(4, 5, 6, 8);
            //task 10
            //Console.WriteLine(LastChar("baki"));
            //task 11
            //Console.WriteLine(LengthTap("Azerbaycan"));
            //LengthTap2("kitab","defter","qelem");

        }


        public static int ReqemTopla(int a)
        {
            int[] result = a.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();
            int b = 0;
            foreach (var reqem in result)
            {
                b += reqem;
            }
            return b;
        }
        public static void TekTap(int a)
        {
            int[] result = a.ToString().Select(o => Convert.ToInt32(o) - 48).ToArray();
            foreach (var reqem in result)
            {
                if (reqem % 2 != 0)
                {
                    Console.WriteLine(reqem);
                }

            }

        }
        public static void Yastap()
        {
            Console.Write("Yasinizi daxil edin: ");
            int yas = Convert.ToInt32(Console.ReadLine());

            if (yas <= 30 && yas > 0)
            {
                Console.WriteLine(yas * yas);

            }
            else if (30 < yas && yas < 40)
            {
                if (yas > 30 && yas < 40)
                {
                    char[] array = yas.ToString().ToArray();
                    Console.WriteLine(array[1]);
                }

            }
            else if (yas >= 40)
            {
                Console.WriteLine("Duzgun melumat daxil etmemisiniz");
            }
            else if (yas <= 0)
            {
                Console.WriteLine("Duzgun melumat daxil etmemisiniz");
            }
        }
        public static int Biggest(params int[] reqemler)
        {
            int biggest = 0;
            foreach (var big in reqemler)
            {
                if (big > biggest)
                {
                    biggest = big;
                }
            }
            return biggest;
        }
        public static int Lowest(params int[] reqemler)
        {
            int temp;
            int size = reqemler.Length;
            for (int i = 0; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (reqemler[i] > reqemler[j])
                    {
                        temp = reqemler[i];
                        reqemler[i] = reqemler[j];
                        reqemler[j] = temp;
                    }
                }
            }
            return reqemler[0];
        }
        public static string LastChar(string soz)
        {
            char[] array = soz.ToCharArray();
            string sozler = "";
            for (int i = array.Length - 1; i < array.Length; i++)
            {
                sozler += array[i];
            }
            return sozler;

        }
        public static int LengthTap(string soz)
        {

            return soz.Length;
        }
        public static void LengthTap2(params string[] soz)
        {
            foreach (var item in soz)
            {

                Console.WriteLine(item);
            }
            Console.WriteLine("uzunlugu ise:" + soz.Length);

        }
        public static void TwoArray(params int[] arr2)
        {
            int[] arr1 = { 1, 2, 3 };
            arr1 = arr1.Concat(arr2).ToArray();
            foreach (var e in arr1)
            {
                Console.WriteLine(e);
            }
        }
        public static int TekededTopla(params int[] reqemler)
        {
            int sum = 0;
            foreach (var reqem in reqemler)
            {
                if (reqem % 2 != 0)
                {
                    sum += reqem;
                }

            }
            return sum;
        }
        public static int UcuTap(params int[] nums)
        {
            int say = 0;
            foreach (var reqem in nums)
            {
                char[] array = reqem.ToString().ToCharArray();
                foreach (var eded in array)
                {
                    if (eded == '3')
                    {
                        say++;
                    }
                }
            }
            return say;
        }
        public static void Tekayir(params int[] reqemler)
        {
            foreach (var reqem in reqemler)
            {
                if (reqem % 2 == 1)
                {
                    Console.WriteLine(reqem);

                }

            }

        }
        public static void SortReverse(params int[] nums)
        {
            Array.Sort(nums);
            Array.Reverse(nums);
            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
        }

        public static void AyiTap()
        {
            Console.WriteLine("ayi daxil edin: ");
            string ayinadi = Console.ReadLine();

            switch (ayinadi)
            {
                case "yanvar":
                    Console.WriteLine("31 gun ve qis fesil");
                    break;

                case "fevral":
                    Console.WriteLine("28 gun ve qis fesil");
                    break;

                case "mart":
                    Console.WriteLine("31 gun ve yaz fesil");
                    break;

                case "aprel":
                    Console.WriteLine("30 gun ve yaz fesil");
                    break;

                case "may":
                    Console.WriteLine("31 gun ve yaz fesil");
                    break;

                case "iyun":
                    Console.WriteLine("30 gun ve yay fesil");
                    break;

                case "iyul":
                    Console.WriteLine("31 gun ve yay fesil");
                    break;

                case "avqust":
                    Console.WriteLine("31 gun ve yay fesil");
                    break;

                case "sentyabr":
                    Console.WriteLine("30 gun ve payiz fesil");
                    break;

                case "oktyabr":
                    Console.WriteLine("31 gun ve payiz fesil");
                    break;

                case "noyabr":
                    Console.WriteLine("30 gun ve payiz fesil");
                    break;

                case "dekabr":
                    Console.WriteLine("31 gun ve qis fesil");
                    break;

                default:
                    Console.WriteLine("No Capitalize please");
                    break;
            }
        }
    }
}
