using System;
using System.Collections.Generic;
using AbakusWSB.Dzialania;

namespace AbakusWSB
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("*** Abakus ***");

            List<IDzialanie> dzialania = new List<IDzialanie>()
            {
                new Dodawanie(),
                new Odejmowanie(),
                new Mnozenie(),
                new Dzielenie(),
            };

            Console.WriteLine("Podaj pierwsza liczbe: ");
            string aStr = Console.ReadLine();

            Console.WriteLine("Podaj druga liczbe: ");
            string bStr = Console.ReadLine();


            foreach (var dzialanie in dzialania)
            {
                dzialanie.DrukujWynik(a, b);
            }         
        }
    }
}
