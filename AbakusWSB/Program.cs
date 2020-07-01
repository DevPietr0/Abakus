using System;
using System.Collections.Generic;
using AbakusWSB.Dzialania;

namespace AbakusWSB
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<IDzialanie> dzialania = new List<IDzialanie>()
            {
                new Dodawanie(),
                new Odejmowanie(),
                new Mnozenie(),
                new Dzielenie(),
            };

            Console.WriteLine("*** Abakus ***");
            double a = 5;
            double b = 5;

            foreach (var dzialanie in dzialania)
            {
                dzialanie.DrukujWynik(a, b);
            }         
        }
    }
}
