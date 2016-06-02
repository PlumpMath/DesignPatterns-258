using DesignerPatterns.Adapter.ExemploA.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPatterns.Adapter.ExemploA
{
    class Program
    {
        static void Main(string[] args)
        {
            OldAdaptee _adaptee = new OldAdaptee();
            Console.WriteLine("Original: {0}", _adaptee.FuncDivideOriginal(9, 4));

            ITarget _adapter = new NewAdapter();
            Console.WriteLine("Novo: {0}", _adapter.Divide(9, 4));

            Console.ReadKey();
        }
    }
}
