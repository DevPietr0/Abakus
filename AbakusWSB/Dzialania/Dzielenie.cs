using System;
namespace AbakusWSB.Dzialania
{
    public class Dzielenie : IDzialanie
    {
        public Dzielenie()
        {
        }

        public void DrukujWynik(double x, double y)
        {
            Console.WriteLine($"Wynik dzielenia: {Oblicz(x, y)}");
        }

        public double Oblicz(double x, double y)
        {
            return x / y;
        }
    }
}
