using System;
namespace AbakusWSB
{
    public interface IDzialanie
    {
        public double Oblicz(double x, double y);
        public void DrukujWynik(double x, double y);
    }
}
