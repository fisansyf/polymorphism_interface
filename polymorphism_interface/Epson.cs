using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_interface
{
    public class Epson : IPrinterWindows
    {
        public void Show(Printer printer)
        {
            Console.WriteLine("Epson display dimenson : 10*11");
        }
        public void Print(Printer printer) 
        {
            Console.WriteLine("Epson printer printing....");
        }
    }
}