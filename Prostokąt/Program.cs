using System;

public class LiczbaCal
{
    int x;

    void Wyswietl()
    {
        Console.WriteLine("Liczba całkowita = " + x);
    }

    int PobierzLiczbe()
    {
        return x;
    }

}
namespace prostokat
{
    class Punkt
    {
        int x;
        int y;


        int PobierzX()
        {
            return x;
        }

        int PobierzY()
        {
            return y;
        }

        void Wyswietl()
        {
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
        }


        static void Main()
        {
            Punkt a = new Punkt();
            Punkt b = new Punkt();
            Punkt c = new Punkt();
            Punkt d = new Punkt();



            a.x = 6;
            a.y = 6;
            b.x = 6;
            b.y = 2;
            c.x = 9;
            c.y = 2;
            d.x = 9;
            d.y = 6;

            int bokd = a.y - b.y;
            int bokk = a.x - d.x;

            a.Wyswietl();
            b.Wyswietl();
            c.Wyswietl();
            d.Wyswietl();


            if (bokd > bokk && a.y == d.y && b.y == c.y && a.x == b.x && c.x == d.x)
                Console.WriteLine("Wygląda na to, że te punkty tworzą prostokąt");
            else
                Console.WriteLine("Niestety te punkty nie stworzą prostokątu");

        }
    }
}