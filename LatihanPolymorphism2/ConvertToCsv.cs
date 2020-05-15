using System;
using System.Collections.Generic;
using System.Text;

namespace LatihanPolymorphism2
{
    class ConvertToCsv : IPrinterWindows
    {
        public void Convert(Showprint sp)
        {
            string csv = string.Format("{0}, {1}, {2}", sp.print, sp.nama, sp.printer);

            Console.WriteLine("Hasil konversi ke csv :\n");
            Console.WriteLine(csv);
        }

        public void convert(Showprint sp)
        {
            throw new NotImplementedException();
        }
    }
}
