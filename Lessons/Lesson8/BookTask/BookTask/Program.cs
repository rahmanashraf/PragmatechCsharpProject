using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Asagidaki memberlerden ibaret Book class-i yaradirsiniz:
            //Name PageCount
            //ps: name ve count deyerleri teyin olunmammis Book obyekti yaranmamalidir.PageCount deyeri 10-dan kicik ola bilmez ve Name deyerinin uzunlugu 3-den qisa ola bilmez Main hissesinde 10 kitabliq Book arryi olsun(Array.Resize la isleye bilsez ne gozel).Kitab deyerleri console-dan daxil edilsin ve yaradilsin, array-e elave edilsin.Sonda arraydeki kitablarin Name ve PageCount deyerleri console penceresinde gosterilsin
            //Proyektin icra olunma prosesi: Layine run lunduqda consoleda Book yaratmaq ucun lazimli deyrleri istemelidi ve onun esasinda bir book obyekti yaranib book array-ine set olunmalidi ve bu proses 10 defe tekrarlanmalidir, cunki arrayimizin olcusu 10-dur.Ve yanlis melumat daxil etdiyimiz zaman bize daxil etdiyimiz deyerin dogru olmadigini console-a yazdirmali ve hemin deyeri yeniden daxil etmeyimizi istemelidir.(Misalcun book name ucun condole-dan daxil etdiyim deyerin uzunlugu 3-den qisa olarsa console-da Yanlis deyer daxil etdiyimi , kitab adinin 3den kicik ola bilmeyeceyini yazmalidir ve daha sonra menden yeniden kitab adi ucun deyer yazmagimi istemelidir ta ki dogru deyer daxil edilene qeder)
        }
}
}
