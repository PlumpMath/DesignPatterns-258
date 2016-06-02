using System;

namespace DesignerPatterns.Adapter.ExemploA.Classes
{
    /// <summary>
    /// Classe que implementa a interface ITarget conforme a Adaptee.
    /// </summary>
    public class NewAdapter : OldAdaptee, ITarget
    {
        public int Divide(int a, int b)
        {
            return Convert.ToInt16(Math.Round(FuncDivideOriginal(a, b)));
        }
    }
}
