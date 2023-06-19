using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_interface
{
    interface IPrinterWindows
    {
        //method abstract
        void Show(Printer printer);
        void Print(Printer printer);
    }
}