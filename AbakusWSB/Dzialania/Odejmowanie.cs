using System;
namespace AbakusWSB.Dzialania
{
    public class Odejmowanie : IDzialanie
    {
        public Odejmowanie()
        {
        }

        public void DrukujWynik(double x, double y)
        {
            Console.WriteLine($"Wynik odejmowania: {Oblicz(x, y)}");
        }

        public double Oblicz(double x, double y)
        {
            return x - y;
        }
    }
}
