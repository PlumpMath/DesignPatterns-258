using DesignPatterns.Strategy.ExemploA.Classes;
using System;

namespace DesignPatterns.Strategy.ExemploA
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido pedido1 = new Pedido(new CalculadorDeFretePadrao());
            pedido1.CalculaFrete();

            Pedido pedido2 = new Pedido(new CalculadorDeFreteExpresso());
            pedido2.CalculaFrete();

            Console.ReadKey();
        }
    }
}
