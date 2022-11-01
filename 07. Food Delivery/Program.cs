using System;

namespace _07._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // input
            int chikenMenuCount = int.Parse(Console.ReadLine());
            int fishMenuCount = int.Parse(Console.ReadLine());
            int vegeterianMenuCount = int.Parse(Console.ReadLine());
            // calculate
            double chikenMenuPrice = chikenMenuCount * 10.35;
            double fishMenuPrice = fishMenuCount * 12.40;
            double vegeterianMenuPrice = vegeterianMenuCount * 8.15;
            double totalMenuPrice = chikenMenuPrice + fishMenuPrice + vegeterianMenuPrice;
            double dessertPrice = totalMenuPrice * 0.2;
            // output
            Console.WriteLine(totalMenuPrice + dessertPrice + 2.50);


        }
    }
}
