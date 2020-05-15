using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace LatihanPolymorphism2
{
    class ConvertToXML : IPrinterWindows
    {
        public void Convert(Showprint sp)
        {
            using (StringWriter writer = new StringWriter())
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Showprint));
                serializer.Serialize(writer, sp);

                string xml = writer.ToString();

                Console.WriteLine("Hasil konversi ke XML :\n");
                Console.WriteLine(xml);
            }
        }

        public void convert(Showprint sp)
        {
            throw new NotImplementedException();
        }
    }
}
