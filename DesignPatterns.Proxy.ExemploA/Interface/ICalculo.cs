namespace DesignPatterns.Proxy.ExemploA.Interface
{
    public interface ICalculo
    {
        double Somar(int x, int y);
        double Subtrair(int x, int y);
        double Multiplicar(int x, int y);
        double Dividir(int x, int y);
    }
}
