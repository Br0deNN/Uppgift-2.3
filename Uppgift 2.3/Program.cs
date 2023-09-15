using System;
namespace Uppgift_2._3
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Hur många dagar vill du hyra bilen?");
            string dagarText = Console.ReadLine();
            double dagar = double.Parse(dagarText);
            Console.WriteLine("Hur många kilometer vill du köra?");
            string kmText = Console.ReadLine(); 
            double km = double.Parse(kmText);
            double total = 300 + (km * 1) + (500 * dagar) - 500;
            Console.WriteLine("Den totala kostande blir " + total);
            Console.ReadKey();  
        }
    }
}