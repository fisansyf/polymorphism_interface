using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();

            Console.WriteLine("Pilih Printer : ");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet");

            Console.Write("Nomor berapa yang kamu pilih 1..3 : ");
            int pilihan = Convert.ToInt32(Console.ReadLine());
            printer.Merk = pilihan;

            //deklarasi
            IPrinterWindows cetak;

            //pengkondisian
            if (printer.Merk == 1)
                cetak = new Epson();
            else if (printer.Merk == 2)
                cetak = new Canon();
            else if (printer.Merk == 3)
                cetak = new LaserJet();
            else
                cetak = new Salah();

            cetak.Show(printer);
            cetak.Print(printer);

            Console.ReadKey();
        }
    }
}