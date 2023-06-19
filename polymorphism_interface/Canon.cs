using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_interface
{
    public class Canon : IPrinterWindows
    {
        public void Show(Printer printer)
        {
            Console.WriteLine("Canon display dimenson : 9.5*12");
        }
        public void Print(Printer printer)
        {
            Console.WriteLine("Canon printer printing....");
        }
    }
}