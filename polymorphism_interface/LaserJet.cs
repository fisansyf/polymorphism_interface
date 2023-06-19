using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_interface
{
    public class LaserJet : IPrinterWindows
    {
        public void Show(Printer printer)
        {
            Console.WriteLine("LaserJet display dimenson : 12*12");
        }
        public void Print(Printer printer)
        {
            Console.WriteLine("LaserJet printer printing....");
        }
    }
}