namespace DesignPatterns.Strategy.ExemploA.Classes
{
    /// <summary>
    /// Context
    /// </summary>
    public class Pedido
    {
        // utilizando composição: o pedido mantém uma referência (passada em seu construtor)
        // para a Strategy base, normalmente uma interface ou classe abstrata

        private ICalculadorDeFrete _calculadorDeFrete;

        public Pedido(ICalculadorDeFrete calculadorDeFrete)
        {
            _calculadorDeFrete = calculadorDeFrete;
        }

        public decimal CalculaFrete()
        {
            // delegando o cálculo do frete para o objeto Strategy configurado
            return _calculadorDeFrete.CalculaFretePara(this);
        }
    }
}
