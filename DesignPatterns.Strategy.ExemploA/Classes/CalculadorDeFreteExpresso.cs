using System;

namespace DesignPatterns.Strategy.ExemploA.Classes
{
    /// <summary>
    /// Concrete Strategy
    /// </summary>
    public class CalculadorDeFreteExpresso : ICalculadorDeFrete
    {
        public decimal CalculaFretePara(Pedido pedido)
        {
            Console.WriteLine("Calculando frete expresso...");
            return 0;
        }
    }
}
