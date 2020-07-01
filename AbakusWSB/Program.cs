using System;
using AbakusWSB.Dzialania;

namespace AbakusWSB
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("*** Abakus ***");
            double a = 5;
            double b = 5;

            IDzialanie dodawanie = new Dodawanie();
            dodawanie.DrukujWynik(a, b);


            
        }
    }
}
