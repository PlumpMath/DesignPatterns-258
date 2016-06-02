using System;

namespace DesignPatterns.Strategy.ExemploA.Classes
{
    /// <summary>
    /// Concrete Strategy
    /// </summary>
    public class CalculadorDeFretePadrao : ICalculadorDeFrete
    {
        public decimal CalculaFretePara(Pedido pedido)
        {
            Console.WriteLine("Calculando frete padrão...");
            return 0;
        }
    }
}
