using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_interface
{
    public class Salah : IPrinterWindows
    {
        public void Show(Printer printer)
        {
            Console.WriteLine("display dimenson : not detected");
        }
        public void Print(Printer printer)
        {
            Console.WriteLine("printer not detected");
        }
    }
}