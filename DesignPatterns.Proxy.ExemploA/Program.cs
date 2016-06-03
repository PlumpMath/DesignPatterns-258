using DesignPatterns.Proxy.ExemploA.ProxyA;
using System;

namespace DesignPatterns.Proxy.ExemploA
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculoProxy _calculoproxy = new CalculoProxy();
            Console.WriteLine("Resultado da soma: {0}", _calculoproxy.Somar(2 , 5));
            Console.WriteLine("Resultado da subtração: {0}", _calculoproxy.Subtrair(2, 5));
            Console.WriteLine("Resultado da multipliação: {0}", _calculoproxy.Multiplicar(2, 5));
            Console.WriteLine("Resultado da divisão: {0}", _calculoproxy.Dividir(2, 5));
            Console.ReadKey();
        }
    }
}
