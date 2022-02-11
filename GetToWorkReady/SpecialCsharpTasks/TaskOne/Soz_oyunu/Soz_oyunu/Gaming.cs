using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soz_oyunu
{
    class Gaming
    {
        private static int Correct { get; set; }=0;
        private static int Total { get; set; } = 0;
        private static int Score = 0;
        static Dictionary<string, int> ScoreMap { get; set; }
        private static int qerar;
        private static string name;
        public  static string Name {
            get
            {
                return name;
            }
            set
            {
                if (value.Length!=0)
                {
                
                        name += char.ToUpper(value[0])+ value.Substring(1);          
                    
                }
            }
        }
        public static void Go(string []array)
        {
            int qerar = 1;

            while (qerar==1)
            {

                int index = new Random().Next(array.Length);
                Console.WriteLine("Bundan sonra gelen sozu tapin:"+" "+array[index] + "_____");
                
                string answer1 = Console.ReadLine();
                if (answer1==array[index+1])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Duz tapdiniz!+6 bal siz qazandiniz");
                    Score += 6;
                    Correct++;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Come on baby yaparsin sen.Bir herf mennen sene hediyye!:" + " " +  array[index + 1][0] + "_____");
                    string answer2 = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;

                    if (answer2==array[index+1])
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Duz tapdiniz!+4bal siz qazandiniz");
                        Score += 4;
                        Correct++;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Come on baby yaparsin sen.Birdene de herf verirem bax bu 2 oldu bunuda tapmasan get olde day!:" + " "  +array[index+1][0]+ array[index + 1][1] + "_____");
                        string answer3 = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        if (answer3==array[index+1])
                        {
                            Console.ForegroundColor=ConsoleColor.Green;   
                            Console.WriteLine("Duz tapdiniz!+2bal siz qazandiniz");
                            Score += 2;
                            Correct++;
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                        begin:

                            try
                            {
                                
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("COX malsiz kewke olsez.Duz cavab {0}\n Davam etmek ucun 1 e basin bezdizse bawka nese basin", array[index + 1]);
                                Console.ForegroundColor = ConsoleColor.White;
                                qerar = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (Exception hata)
                            {
                                Console.WriteLine("Sehv zad eledin");

                                goto begin;
                            }
                            

                        }
                    }
                }
                
                Total++;
                
            }




        }
        public static void Count(object obj)
        {

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Cox hormetli {name}! neticeleriniz asagidaki kimidir bro");

            Console.WriteLine("Toplam balin: " + Gaming.Score);
            Console.WriteLine("Toplam verdiyin cavab sayi " + Gaming.Total);
            Console.WriteLine("Verdiyin duzgun cavabsayi: " + Gaming.Correct);
            int wrong = Gaming.Total - Gaming.Correct;
            Console.WriteLine("Elediyin mallig sayi: " + wrong);
            qerar = 2;
            
        }
        
    }
}
