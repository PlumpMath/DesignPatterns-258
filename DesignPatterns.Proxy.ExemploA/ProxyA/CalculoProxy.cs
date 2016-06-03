using System;
using DesignPatterns.Proxy.ExemploA.Domain;
using DesignPatterns.Proxy.ExemploA.Interface;

namespace DesignPatterns.Proxy.ExemploA.ProxyA
{
    public class CalculoProxy : ICalculo
    {
        private Calculo _calculo = new Calculo();

        public double Dividir(int x, int y)
        {
            return _calculo.Dividir(x, y);
        }

        public double Multiplicar(int x, int y)
        {
            return _calculo.Multiplicar(x, y);
        }

        public double Somar(int x, int y)
        {
            return _calculo.Somar(x, y);
        }

        public double Subtrair(int x, int y)
        {
            return _calculo.Subtrair(x, y);
        }
    }
}
