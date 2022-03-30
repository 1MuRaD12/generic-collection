using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lemon<char> lemons = new Lemon<char>("Lemon", 'C');
            Console.WriteLine(lemons);

            Pineapple<string> pineapple = new Pineapple<string>("Pineapple", "B3");
            Console.WriteLine(pineapple);

            Apple<string> apple = new Apple<string>("Apple", "B2");
            Console.WriteLine(apple);


            BasketList<string,string> basket = new BasketList<string,string>();
            basket.Add("Apricots", "C");
            basket.Add("Bananas", "A");
            basket.Add("Grapes", "B6");
            basket.Add("Raspberries", "E");
            Console.WriteLine("\nVitamins");
            foreach (var item in basket.getM())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\nfruit");
            foreach (var item in basket.getT())
            {
                Console.WriteLine(item);
            }

            

        }
    }
}
