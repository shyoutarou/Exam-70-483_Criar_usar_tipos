using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_Example
{
    class Program
    {
        static void Main(string[] args)
        {

            //// Let's look at string concatenation
            string s1 = "This is an example of s1 ";
            s1 = s1 + "string concatenation.";

            //// This will actually cause a new s1 object
            //// to be created and s1 points to this new object
            Console.WriteLine(s1);

            // StringBuilder can actually append data to a string
            StringBuilder sb2 = new StringBuilder("This is an example of sb2 ");
            sb2.Append("string concatenation.");
            Console.WriteLine(sb2);

            // StringBuilder can add a new line to existing text
            // or clear all content
            sb2.AppendLine();
            sb2.Append("Using StringBuilder...");
            Console.WriteLine(sb2);

            // StringBuilder can replace content in the object
            sb2.Replace("StringBuilder", "the StringBuilder class...");
            Console.WriteLine(sb2);

            sb2[0] = 'N';
            sb2[1] = 'Ó';

            Console.WriteLine(sb2);

            Console.ReadKey();

        }
    }
}
