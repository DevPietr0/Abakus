using System;
namespace AbakusWSB.Dzialania
{
    public class Dodawanie : IDzialanie
    {
        public Dodawanie()
        {
        }

        public void DrukujWynik(double x, double y)
        {
            Console.WriteLine($"Wynik dodawania: {Oblicz(x, y)}");
        }

        public double Oblicz(double x, double y)
        {
            return x + y;
        }

        public void PobierzDane()
        {
            Console.WriteLine("Podaj dane:");
        }
    }
}
