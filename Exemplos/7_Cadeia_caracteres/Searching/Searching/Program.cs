using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Searching
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "<mycustominput>";
            int indexOfp = value.IndexOf('y'); // 2
            Console.WriteLine(indexOfp); // 1

            int lastIndexOfm = value.LastIndexOf('m');  // 8
            Console.WriteLine(lastIndexOfm); // 7

            if (value.StartsWith("<")) { }
            if (value.EndsWith(">")) { }

            string subString = value.Substring(3, 6);  // ‘custom’
            Console.WriteLine(subString); // Returns ‘custom’

            string pattern = "(Mr\\.? |Mrs\\.? |Miss |Ms\\.? )";
            string[] names = { "Mr. Henry Hunt", "Ms. Sara Samuels", "Abraham Adams", "Ms. Nicole Norris" };
            foreach (string name in names)
                Console.WriteLine(Regex.Replace(name, pattern, String.Empty));

            //Henry Hunt
            //Sara Samuels
            //Abraham Adams
            //Nicole Norris
            Console.ReadKey();


        }
    }
}
