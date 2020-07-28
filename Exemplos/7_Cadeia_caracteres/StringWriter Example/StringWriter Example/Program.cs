using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace StringWriter_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder();
            StringWriter swriter = new StringWriter(builder);
            swriter.Write("Ali Asad");

            //Ali Asad
            Console.WriteLine(builder.ToString());

            var stringWriter = new StringWriter();
            using (XmlWriter writer = XmlWriter.Create(stringWriter))
            {
                writer.WriteStartElement("book");
                writer.WriteElementString("price", "19.95");
                writer.WriteEndElement();
                writer.Flush();
            }
            string xml = stringWriter.ToString();
            //<?xml version="1.0" encoding="utf-16"?><book><price>19.95</price></book>
            Console.WriteLine(xml);
            Console.ReadKey();
        }
    }
}
