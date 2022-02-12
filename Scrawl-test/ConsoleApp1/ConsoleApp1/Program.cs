using System;
using System.Collections.Generic;
class HelloWorld
{
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Hello, if you want to create a virtual card,then first set the amount of money in your card(AZN)");
        Console.ForegroundColor = ConsoleColor.White;
        Esas_card.AddEsasCardPul();
        string contin = "Y";
        while (contin == "Y")
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Now I will list for you what you can do: \nIf you want to create a virtual card, press 1.\nIf you want to see the data of virtual cards, press 2.\nIf you want to see how much money is left in the main card, press 3.\nIf you want to delete a virtual card, press 4.");
            Console.ForegroundColor = ConsoleColor.Red;
            string secim = Console.ReadLine();
            var random2 = new Random();
            Console.ForegroundColor = ConsoleColor.White;
            if (secim == "1" || secim == "Y")
            {
                if (Esas_card.umumipul != 0)
                {
                    Console.WriteLine("How much money do you want to invest in the card: ");
                    int pul = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter how many days your card will be active starting from today: ");
                    double day = Convert.ToDouble(Console.ReadLine());
                    Virual_Card card = new Virual_Card(pul, day);
                    Virual_Card.Cardgebulu(card);
                }
                else
                {
                    Console.WriteLine("You don't have money in your main card, so can't create new virtual card.");
                }
            }
            if (secim == "2")
            {
                Virual_Card.ShowYoirVirtualCard();

            }
            if (secim == "3")
            {
                Esas_card.ShowEsasCardPul();

            }
            if (secim == "4")
            {

                Virual_Card.CardRemove();

            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Do u want continue?(Y/N)\n'if you enter yes,then enter,what u want to do.'");
            contin = Console.ReadLine();

        }
    }
}



public class Virual_Card
{
    string bankkart;
    int mebleq;
    DateTime time;
    static List<Virual_Card> card_yiqan = new List<Virual_Card>();

    public Virual_Card(int pul, double days)
    {
        while (Esas_card.umumipul < pul)
        {
            Console.WriteLine("Your card has less money, please re-enter");
            pul = Convert.ToInt32(Console.ReadLine());
        }
        mebleq = pul;
        Esas_card.umumipul -= mebleq;
        DateTime time2 = DateTime.Now;
        time = time2.AddDays(days);
        var random = new Random();
        for (int i = 0; i < 16; i++)
        {
            bankkart = String.Concat(bankkart, random.Next(10).ToString());
        }
    }
    public static void Cardgebulu(Virual_Card card)
    {
        if (card_yiqan.Count < 5)
        {
            card_yiqan.Add(card);
            Console.WriteLine("Your card will be registered.");
        }
        else
        {
            Console.WriteLine("Sorry, you have already created 5 сards.\nIf you want to create a new one,\nthen delete one of the other cards ");
        }
    }
    public static void CardRemove()
    {
        if (card_yiqan.Count == 0)
        {

            Console.WriteLine("You don't create a card");

        }
        else
        {
            int say = 0;
            Console.WriteLine("Please enter your card number and your card will be deleted");
            string nomresi = Console.ReadLine();
            for (int j = 0; j < card_yiqan.Count; j++)
            {
                say = j + 1;
                if (card_yiqan[j].bankkart == nomresi)
                {
                    Esas_card.umumipul += card_yiqan[j].mebleq;
                    card_yiqan.Remove(card_yiqan[j]);
                    Console.WriteLine("This card was deleted");
                }

            }
            if (say == card_yiqan.Count)
            {
                Console.WriteLine("You entered the wrong card number");
            }
        }
    }

    public static void ShowYoirVirtualCard()
    {
        Console.WriteLine("Here you see your virtual cards number and and the time of their deactivation");
        if (card_yiqan.Count == 0)
        {
            Console.WriteLine("You didn't create a card");

        }
        else
        {
            for (int k = 0; k < card_yiqan.Count; k++)
            {
                int num = k + 1;
                Console.WriteLine(num + ". Number: " + card_yiqan[k].bankkart + "\nTime of the deactivation: " + card_yiqan[k].time + "\nAmount of money: " + card_yiqan[k].mebleq);

            }
        }
    }

}
public static class Esas_card
{
    public static int umumipul;
    public static void AddEsasCardPul()
    {
        umumipul = Convert.ToInt32(Console.ReadLine());
    }
    public static void ShowEsasCardPul()
    {

        Console.WriteLine("On your main сard is " + umumipul + " AZN.");
    }
}