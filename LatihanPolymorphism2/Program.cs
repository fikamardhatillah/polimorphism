﻿using System;

namespace LatihanPolymorphism2
{
    class Program
    {
        static void Main(string[] args)
        {
            Showprint sp = new Showprint();
            sp.print = "Epson";
            sp.nama = "Canon";
            sp.printer = "LaserJet";

            Console.WriteLine("Pilih Format Konversi Data : ");
            Console.WriteLine("1. Json");
            Console.WriteLine("2. XML");
            Console.WriteLine("3.Csv\n");

            Console.Write("Nomor Format Data [1..3]: ");
            int nomorFormatData = Convert.ToInt32(Console.ReadLine());

            IPrinterWindows convert;

            if (nomorFormatData == 1)
                convert = new ConvertToJson();
            else if (nomorFormatData == 2)
                convert = new ConvertToXML();
            else convert = new ConvertToCsv();

            
            convert.Convert(sp);
            Console.ReadKey();
        }
    }
}
