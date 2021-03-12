using System;

namespace funkcje
{
    class Funkcje
    {

        public static double poleKola(Single promien)
        {
            return Math.PI * Math.Pow(promien, 2);
        }
        public static double poleprst(Single a, Single b)
        {
            return a * b;
        }
        public static string fajnyTeskt(string imie)
        {
            return string.Format("fajne masz imie {0}", imie);
        }
    }
}
