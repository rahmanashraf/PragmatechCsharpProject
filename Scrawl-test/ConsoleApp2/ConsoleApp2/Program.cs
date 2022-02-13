using System;

class HelloWorld
{
    static void Main()
    {
        EsasCard card = new EsasCard();
        VirtualCard virtualCard = new VirtualCard();
        card.Num = " ";
        virtualCard.Num = " ";
        Console.WriteLine(card.Num);
        
        Console.WriteLine(virtualCard.Num);

    }
}

abstract class Card
{
    string num;
    public string Num
    {
        get { return num; }
        set
        {
            var random = new Random();
            for (int i = 0; i < 16; i++)
            {
                value = String.Concat(num, random.Next(10).ToString());
                num = value;
            }
           
            
        }
    }
}

class EsasCard : Card
{

}

class VirtualCard : Card
{

}