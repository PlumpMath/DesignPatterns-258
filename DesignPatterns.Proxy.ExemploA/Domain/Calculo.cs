using System;
using DesignPatterns.Proxy.ExemploA.Interface;

namespace DesignPatterns.Proxy.ExemploA.Domain
{
    class Calculo : ICalculo
    {
        #region ICalculo member
        public double Dividir(int x, int y)
        {
            return x / y;
        }

        public double Multiplicar(int x, int y)
        {
            return x * y;
        }

        public double Somar(int x, int y)
        {
            return x + y;
        }

        public double Subtrair(int x, int y)
        {
            return x - y;
        }
        #endregion
    }
}
