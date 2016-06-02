namespace DesignPatterns.Strategy.ExemploA.Classes
{
    /// <summary>
    /// Strategy base
    /// </summary>
    public interface ICalculadorDeFrete
    {
        decimal CalculaFretePara(Pedido pedido); 
    }
}