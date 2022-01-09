using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTImeMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime zaman = DateTime.Now;
            DateTime tarih = zaman.Date;
            int ay = zaman.Month; 
            int gun = zaman.Day;
            int yil = zaman.Year;
            DayOfWeek haftaninGunu = zaman.DayOfWeek;
            int yilinKacinciGunu = zaman.DayOfYear;
            TimeSpan sure = zaman.TimeOfDay;
            int saat = zaman.Hour; 
            int dakika = zaman.Minute;
            int saniye = zaman.Second; 
            int salise = zaman.Millisecond;
            Console.WriteLine("Şuandaki Zaman: {0}", zaman); // tarix gg/ay/il saat/deqiqe/sanie
            Console.WriteLine("Tarih Bilgisi: {0}", tarih); // tarix gg/ay/il saatsiz
            Console.WriteLine("Ay Bilgisi: {0}", ay);   //cari ay reqemle
            Console.WriteLine("Gün Bilgisi: {0}", gun);  //cari gun reqemle
            Console.WriteLine("Yıl Bilgisi: {0}", yil);   //cari il reqemle
            Console.WriteLine("Haftanın Günü: {0}", haftaninGunu);  //cari heftegunu ingilisce STRING
            Console.WriteLine("Yılın Kaçıncı Günü: {0}", yilinKacinciGunu);  //ilin necenci gunu olmasi INTEGER saynan 
            Console.WriteLine("Süre: {0}", sure);   //saat:deqiqe:saniye:salise anliq olaraq
            Console.WriteLine("Saat: {0}", saat);  //saat int 
            Console.WriteLine("Dakika: {0}", dakika);  //deqiqe int
            Console.WriteLine("Saniye: {0}", saniye); //saniye int
            Console.WriteLine("Salise: {0}", salise); ///millisanie int

            DateTime tarix1=DateTime.Now;
            DateTime tarix2 = new DateTime(2008, 5, 1, 8, 30, 52); //elnen datetime yazma terzi budu....burda iki tarixi muqayise elir hansi daha kohnedise birnici daha kohnedise -1 eynidise 0 ikinci daha kohnedisee 1 verir
            int sonuc = DateTime.Compare(tarix2, tarix1);
            Console.WriteLine(sonuc);

            int il = 1995;
            int okt = 10;
            int gunSayisi = DateTime.DaysInMonth(1995, okt); //ayi ili yazirsan hemen ay nece gun olub olacag onu cixarir INT
            Console.WriteLine(gunSayisi);
            bool artikYilMi = DateTime.IsLeapYear(il); //ilin 366 olub olmamasin yoxlub true false verir
            Console.WriteLine(artikYilMi);
        }
    }
}
