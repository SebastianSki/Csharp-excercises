using System;

namespace labora
{
    class Program
    {
        static void tabliczka(int w)
        {
            for (int x = 1; x <= w; x++)
            {
                for (int y = 1; y <= w; y++)
                {
                    Console.Write(x * y + "\t");
                }
                Console.WriteLine();
            }
        }

        static bool czy_przestepny(int rok)
        {
            if (rok % 4 == 0 & rok % 100 != 0 || rok % 400 == 0)
                return true;
            else
                return false;
        }

        static int iloczyn(int x, int y)
        {
            int wynik = 1;
            if (y == 0)
               return wynik ;

            wynik = x * iloczyn(x, y - 1);
            return wynik;
        }

        static int silnia(int x)
        {
            int w = 1;

            for (int i = 1; i <= x; i++)
            {
                w = w * i;
            }
            return w;
        }

        static int silnia_rek(int x)
        {
            int wynik = 1;
            if (x == 1)
                return wynik;

            wynik = x * silnia_rek(x - 1);
            return wynik;
        }
        static void Main(string[] args)
        {

            /*
            int[] lata = { 2000, 1900, 2020, 2021 };

            foreach (int el in lata)
            {
                Console.WriteLine("rok {0} jest przestepny: {1}", el, czy_przestepny(el));
            }

                      int i = 100;
                        while (i <= 130)
                        {
                            if (i % 3 == 0)
                                Console.WriteLine(i);
                           i++;
                        }
            
                        for(int i = 100; i <= 130; i++)
                        {
                            if (i % 3 == 0)
                                Console.WriteLine(i);
                        }
                        do
                        {
                            if (i % 3 == 0)
                                Console.WriteLine(i);
                            i++;
                        } while (i <= 130); */

            /*for (int w = 2; w <= 8; w++)
            {   
                Console.WriteLine();
                for (int y = 1; y <= w; y++)
                {
                    for (int x = 1; x <= w; x++)
                    {                
                         Console.Write(x * y + "\t");
                    }
                    Console.WriteLine();
                }
            }
            */

            //silnia


            /* for (int s = 1; s <= 17; s++)
            {

                double w = 1;
                for (int i = 1; i <= s; i++)
                {
                    w = w * i;
                }

                Console.WriteLine("silnia {0} wynosi: {1}", s, w); 

            } // rok przestepny
            /*for (int r = 1900; r <= 2021; r++)
            {
                if (r % 4 == 0 & r % 100 != 0 || r % 400 == 0) 
                    Console.WriteLine(r);
            }

            int r = 1900;
            while (r <= 2021)

            {
                if (r % 4 == 0 & r % 100 != 0 || r % 400 == 0)
                    Console.WriteLine(r);
                r++;

            }

            string rok;

            Console.WriteLine("Napisz proszę rok: (q kończy program)");
            rok = Console.ReadLine();

            while (rok != "q")
            {
                Console.WriteLine("Napisz proszę rok: (q kończy program)");
                rok = Console.ReadLine();
            }

            int rok;
            string tekst;

            do
            {
                Console.WriteLine("wpisz cos, q konczy");
                tekst = Console.ReadLine();

              if  (int.TryParse(tekst, out rok))

                if (rok % 4 == 0 & rok % 100 != 0 || rok % 400 == 0)
                    Console.WriteLine("Rok {0} był przestępny", rok);


            } while (tekst != "q");

            */
            /*int w = 13;

                for (int y = 1; y <= w; y++)

                {
                    for (int x = 1; x <= w; x++)

                    {
                        if ((x > 6 - y) & (x < 6 + y))
                            Console.Write("*");
                        else
                            Console.Write(" ");

                    }
                    Console.WriteLine();              
                }

            int[] tablica = { 3, 6, 2, -2, 4 };

            int sum = 0;
            for (int i = 0; i < tablica.Length; i++)
                sum += tablica[i];
                    Console.WriteLine(sum);
            /* int []tablica2 = {3, 6, 8, 3, 12, 456 ,2 };

             int max = tablica2[0];
             int min = tablica2[0];
             foreach (int el in tablica2)
             {
                 if (el > max)
                     max = el;
                 if (el < min)
                     min = el;
             }

             Console.WriteLine(max - min); 

             int[] tablica3 = new int[10];

             foreach (int el in tablica3)
                 Console.WriteLine(el);

             bool[] tablica4 = new bool[10];
             foreach (bool el in tablica4)
                 Console.WriteLine(el);   
             int[,] tablica5 = new int[10, 10];
             tablica5[5, 5] = 100;


             foreach (int el in tablica5)
                 Console.WriteLine(el); 

            //ćw książka (75) 8.1
            /*int a = 21;
            int b = 5;
            if (a % b == 0)
            {
                Console.WriteLine("Super, llczby {0} i {1} dziela się bez reszty!", a, b);
            }
            else
                Console.WriteLine("Kurde, wybierz inne liczby");*/
            //8.2
            /*  int A = 3, B = 3, C = 7;
             Console.WriteLine("Parametry równania:\n");
             Console.WriteLine("A = " + A + ", B = " + B + ", C = " + C + "\n");

                  if (A == 0)
                  {
                  Console.WriteLine("To nie jest równianie kwadratowe: A = 0!");            
                  }

                  else 
                  {
                      double delta = B * B - 4 * A * C;

                      if (delta < 0)
                      {
                      Console.WriteLine("Delta < 0."); 
                      Console.WriteLine("To równanie nie ma rozwiązania w zbiorze liczb rzeczywistych!");
                      }
                  }
              */
            //8.3
            /*
                        int[] lata = { 1900, 2012, 2007, 2204, 2005, 2016 };

                        int ile = 0;

                        foreach (int el in lata)
                        {

                            if (el % 4 == 0 & el % 100 != 0 || el % 400 == 0)
                                ile++;
                        }
                        Console.WriteLine("Wystąpiło {0} lata przestępnych", ile);
                    */


            /* int[] tab = new int[100];
             int sum = 0;

             for (int i = 0; i < tab.Length; i++)
             {
                 tab[i] = 1002 + i * 3;
             }

             foreach(int el in tab)
             {
                 if (el % 2 == 0)
                     sum += el;              
             }
             Console.WriteLine("suma wynosi:{0}", sum);
            



            Random los = new Random();
            los.Next();

            int[] tablos = new int[1000];
            int podzielne = 0;

            for (int i = 0; i < tablos.Length; i++)
            {
                tablos[i] = los.Next(100, 201);
            }
                
            int max = tablos[0];
            int min = tablos[0];
            
            foreach (int el in tablos)
            {
                if (el > max)
                    max = el;
                if (el < min)
                    min = el;
                if (el % 5 == 0)
                    podzielne++;
            }

            Console.WriteLine("W tablice jest {0} liczb podzielnych prez 5", podzielne);
            Console.WriteLine("Różnica między maks a min wynosi: {0}, max = {1}, min {2}", max - min, max , min);
            */

        }
    }
}
