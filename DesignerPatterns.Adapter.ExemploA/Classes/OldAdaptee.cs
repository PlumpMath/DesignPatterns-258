namespace DesignerPatterns.Adapter.ExemploA.Classes
{
    /// <summary>
    /// Classe original : Implementação que necessita de uma adaptação para que o Cliente possa utilizar.
    /// Classe que deve ser adaptada.
    /// </summary>
    public class OldAdaptee
    {
        public double FuncDivideOriginal(double a, double b)
        {
            return a / b;
        }
    }
}
