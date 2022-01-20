using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Aptek[] array = new Aptek[3];
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Adini dahil et: ");
            string name = Console.ReadLine();
            Console.WriteLine("Sayini dahil et: ");
            int count = Convert.ToInt32(Console.ReadLine());
            Aptek derman = new Aptek(name, count);
            array[i] = derman;
        }
        Add(ref array);
        foreach (var item in array)
        {
            Console.WriteLine("Derman adi: " + item.Name + ", sayi: " + item.Count);
        }
    }
    public static void Add(ref Aptek[] array)
    {
        int say = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Teze dermanin adini dahil et: ");
            string name = Console.ReadLine();
            Console.WriteLine("Teze dermanin sayini dahil et: ");
            int count = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j].Name == name)
                {
                    array[j].Count += count;
                }
                else
                {
                    say += 1;
                }
            }
            if (say == array.Length)
            {
                Array.Resize(ref array, array.Length + 1);
                Aptek obyekt = new Aptek(name, count);
                array[array.Length - 1] = obyekt;
                Console.WriteLine("Teze derman : " + array[array.Length - 1].Name);
            }

            say = 0;
        }
    }
}



public class Aptek
{
    public string Name;
    public int Count;
    public Aptek(string name, int count)
    {
        Name = name;
        Count = count;
    }
}