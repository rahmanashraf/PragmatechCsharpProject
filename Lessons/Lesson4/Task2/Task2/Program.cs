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

            {
                #region
                //Task
                //1.bool a = (3 + 4 * 2 == 2 * 3) && (true + false / 2) ifadəsinin nəticəsi nədir və səbəbini qeyd edin..
                //2.Verilən 4 rəqəmli ədədin rəqəmlərinin cəmini tapan proqram yazın(Nümunə: int a = 1298 Nəticə: 1 + 2 + 9 + 8 = 20)
                //3.Verilən ədədin rəqəmləri arasında olan tək rəqəmləri ekranda göstərən proqram yazın(Nümunə : int a = 1298 Nəticə: 1,9)
                //4.Console.Readline vasitesile ilə istifadəçinin yaşını daxil etməsini istəyin.
                //İstifadəçinin yaşı 30 - dan kiçikdirsə istifadəçinin yaşının kvadratını ekrana çap edin
                //Yaş 30 - 40 aralığındadırsa daxil edilən ədədin son rəqəmini ekrana çap edin
                //Yaş 0 - dan kiçik vəya 100 - dən böyükdürsə ekrana "Düzgün məlumat daxil etməmisiniz" yazdırın
                //5.ay dəyəri daxil edildiyi zaman onun necə gun və hansi fesil olduğunu edən method yazın
                //6.Arrayin en boyuk elementini tapan methiod
                //7.Arrayin en kicik elementini tapan methiod
                //8.Verilən nums =[1, 2, 3, 6, 7, 8, 23, 78, 34, 12]
                //8.1 Tək ədədlərin cəmini tapan metod yazın
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
                

            }
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
    }
}
