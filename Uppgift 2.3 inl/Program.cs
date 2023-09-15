using System;

namespace Uppgift_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hur många kilometer ska du köra?");
            int km =int.Parse(Console.ReadLine());
            Console.WriteLine("Hur många dagar ska du ha den?");
            int dagar = int.Parse(Console.ReadLine());
            Console.WriteLine("Det kommer kosta" + (300 + km + (dagar * 500) - 500) + "kr");
        }

    }


}