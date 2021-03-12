using System;
using funkcje;
namespace test
{
    class Program
    {

        static void Main(string[] args)
        {
            //double mojePoleKola = Math.PI * 10 * 10;

            double mojePoleKola = Funkcje.poleKola(10);
            double prostokat = Funkcje.poleprst(10, 5);
            Console.WriteLine("Podaj imie kochasiu:");
            Console.WriteLine(Funkcje.fajnyTeskt(Console.ReadLine()));
            Console.ReadKey();

        }
    }
}
