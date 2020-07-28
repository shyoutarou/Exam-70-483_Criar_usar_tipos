using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace StringReader_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            //'@' It's a verbatim string literal. It ignores escape sequence
            string text = @"Hi I'm Ali Asad.
            I can help you in C# Certification Exam.
            I've helped many individuals like you in their exam prep.
            I believe if we work together, you can become:
            Microsoft Certified Professional & Specialist in C#";
            StringReader reader = new StringReader(text);
            int currentLine = 0;
            string line = "";
            //return each line of string to 'line'
            while ((line = reader.ReadLine()) != null)
            {
                Console.WriteLine("line{0}: {1}", ++currentLine, line.Trim());
            }

            var stringWriter = new StringWriter();
            using (XmlWriter writer = XmlWriter.Create(stringWriter))
            {
                writer.WriteStartElement("book");
                writer.WriteElementString("price", "19.95");
                writer.WriteEndElement();
                writer.Flush();
            }
            string xml = stringWriter.ToString();

            var stringReader = new StringReader(xml);
            using (XmlReader readerxml = XmlReader.Create(stringReader))
            {
                readerxml.ReadToFollowing("price");

                // Make sure that you read the decimal part correctly
                decimal price = decimal.Parse(readerxml.ReadInnerXml(), new CultureInfo("en-US"));
                Console.WriteLine(price); //19,95
            }
            Console.ReadKey();
        }
    }
}
