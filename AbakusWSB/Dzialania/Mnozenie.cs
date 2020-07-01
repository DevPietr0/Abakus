using System;
namespace AbakusWSB.Dzialania
{
    public class Mnozenie : IDzialanie
    {
        public Mnozenie()
        {
        }

        public void DrukujWynik(double x, double y)
        {
            Console.WriteLine($"Wynik mnozenia: {Oblicz(x, y)}");
        }

        public double Oblicz(double x, double y)
        {
            return x * y;
        }
    }
}
