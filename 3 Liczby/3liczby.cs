using System;

namespace _3_liczby
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 36;
            int b = 6;
            int c = 36;

           
            if(a > b){
                if (a > c)
                    Console.WriteLine("liczba a ma największą wartość");
                else if (a == c)
                    Console.WriteLine("liczby a i c są równe i mają największą wartość");
                else
                    Console.WriteLine("liczba c ma największą wartość");

            }else if(a == b){
                if(c > a)
                    Console.WriteLine("liczba c ma największą wartość");
                else if(c == a)
                    Console.WriteLine("liczby a, b i c są równe, wszystkie mają największą wartość");
                else
                    Console.WriteLine("liczby a i b są równe i mają największą wartość ");
                
            }else{
                if (b > c)
                    Console.WriteLine("liczba b ma największą wartość");
                else if (b == c)
                    Console.WriteLine("liczby b i c są równe i mają największą wartość");
                else
                    Console.WriteLine("liczba c ma największą wartość");
            }
        }
    }
}
