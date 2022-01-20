using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeferanAptek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //add metodu derman daxil eden zaman getsin arrayi check etsin
            //eger hemin derman varsa ustune gelsin yoxdursa elave elesin
            //satis metodu azaldsin malin sayini static sekilde
            //Aptek[] dermanlarim = new Aptek[5];

            ////ArrayList dermanlar = new ArrayList();
            ////string[] vesile = {vesile.Length+1 };
            ////string x = "rehman";
            ////foreach (var derman in vesile)
            ////{
            ////    vesile[0] = x;
            ////}
            ////Console.WriteLine(vesile[0]);
            ////T [] newArray = new T [array.Length + 1];
            ////int i;
            ////for (i = 0; i < array.Length; i++)
            ////{
            ////    newArray[i] = array[i];
            ////}
            ////newArray[i] = element;
            ////return newArray;
            ////string[] dermanlar = { "nosba", "aspirin", "lirika" };
            ////int [] saylari=
            //ArrayList dermanlar = new ArrayList();
            //ArrayList saylar = new ArrayList();
            //for (int i = 0; i < 5; i++) 
            //{ 

            //    Console.WriteLine("derman daxil et: ");
            //    string namederman = Console.ReadLine();
            //    Console.WriteLine("sayini daxil et: ");
            //    int saylari = Convert.ToInt32(Console.ReadLine());
            //    dermanlar.Add(namederman);
            //    saylar.Add(saylari);   
            //}
            //for (int j = 0; j < 5; j++)
            //{
            //    Aptek drm = new Aptek(dermanlar[j], saylar[j]);
            //}


            //Added(dermanlar,saylar);

            #endregion

            Aptek[] dermanlar = new Aptek[3];
            for (int i = 0; i < dermanlar.Length; i++)
            {

                Console.WriteLine("derman daxil et: ");
                string namederman = Console.ReadLine();
                Console.WriteLine("sayini daxil et: ");
                int saylari = Convert.ToInt32(Console.ReadLine());

                Aptek dermanobyekti = new Aptek(namederman, saylari);
                dermanlar[i] = dermanobyekti;

            }
            Added(dermanlar);
           


        }
        public static void Added(Aptek[] list)
        {
      
            for (int i = 0; i < list.Length; i++)
            {

                Console.WriteLine("Yeni derman daxil et: ");
                string namederman = Console.ReadLine();
                Console.WriteLine("Yeni darman sayini daxil et: ");
                int saylari = Convert.ToInt32(Console.ReadLine());
                if (list[i].Name != namederman)
                {
                    Array.Resize(ref list, list.Length +1);
                    list[i].Name = namederman;
                    list[i].Count = saylari;
                    Console.WriteLine("yeni derman elave olundu");
                }
                else
                {
                    list[i].Count=list[i].Count + saylari;
                    Console.WriteLine("movcud dermanin sayi artdi");
                }
                Console.WriteLine(list[i].Name+"dermanindan depoda "+list[i].Count );
            }
        }

    }
}
