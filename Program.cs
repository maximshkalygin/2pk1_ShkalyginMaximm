using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shkalygin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Card card = new Card();
            card.Number = 31232132;
            card.Validity = DateTime.Now;
            card.Type = "visa";
            card.ClientFIO = "Шкалыгин Максим";
            card.SecureCode = 443;
            Card card1 = new Card("ШКалыгин Максим");
            card1.Number = 45124123;
            card1.Validity = DateTime.Now;
            card1.Type = "мир";
            card1.SecureCode = 332;
            Card card2 = new Card("ШКалыгин Максим", 220245453);
            card2.Type = "mastercard";
            card2.Number = 78575675;
            card2.Validity = DateTime.Now;
            card2.SecureCode = 990;
            Card card3 = new Card(322);
            card3.Validity = DateTime.Parse("01.01.2025");
            card2.ClientFIO = "ШКалыгин Максим";
            card3.Number = 980797897;
            card3.SecureCode = 668;
            Console.WriteLine(card.GetInfo());
            Console.WriteLine(card1.GetInfo());
            Console.WriteLine(card2.GetInfo());
            Console.WriteLine(card3.GetInfo());
            Console.WriteLine($"Колличество карт {Card.getCount()}");
            Console.WriteLine($"Колличество заканчивающихся карт {Card.getExpaierdCards()}");
        }

    }
}
