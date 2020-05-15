using System; 

namespace LatihanPolymorphism2
{
    class ConvertToJson : IPrinterWindows
    {
        public object JsonConvert { get; private set; }

        public void Convert (Showprint sp)
        {
            string json = jsonConvert(sp);

            Console.WriteLine("Hasil Konversi ke json:\n");
            Console.WriteLine(json);
        }

        private string jsonConvert(Showprint sp)
        {
            throw new NotImplementedException();
        }

        public void convert(Showprint sp)
        {
            throw new NotImplementedException();
        }
    }
}
