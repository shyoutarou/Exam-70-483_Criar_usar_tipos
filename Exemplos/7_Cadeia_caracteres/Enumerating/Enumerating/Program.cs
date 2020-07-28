using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerating
{
    class Program
    {
        static void Main(string[] args)
        {
            string valueenum = "My Custom Value";
            foreach (char c in valueenum)
                Console.WriteLine(c);

            foreach (string word in "My sentence separated by spaces".Split(' '))
            {
                Console.WriteLine(word);
            }

            StringBuilder letters = new StringBuilder("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            StringBuilder line = new StringBuilder();
            // Create the result StringBuilder. 
            StringBuilder result = new StringBuilder();
            // Loop over the letters. 
            for (int i = 0; i < 26; i++)
            {
                // Add the next letter to line. 
                line.Append(letters[i]);
                // Add line to the result. 
                result.AppendLine(line.ToString());
            }

            Console.WriteLine(result);


            string value = "<mycustominput>";

            string cloned = value.Clone() as string;
            Console.WriteLine(cloned); //< mycustominput >

            string value2 = "Ali";
            if ((value.CompareTo(value2)) == 0)
                Console.WriteLine("both text are same");
            else
                Console.WriteLine("both text aren't same"); //both text aren't same


            Console.WriteLine(value.Equals(value2)); //False
            Console.WriteLine(value.IndexOf('t')); //6
            Console.WriteLine(value2.ToLower()); //ali
            Console.WriteLine(value.ToUpper()); //<MYCUSTOMINPUT>
            Console.WriteLine(value2.Insert(3, " Asad")); //Ali Asad

            Console.WriteLine(value.LastIndexOf('m')); //8

            Console.WriteLine(value.Remove(3)); //<my
            Console.WriteLine(value2.Replace("Ali", "Asad")); //Asad

            string text1 = "ali asad";
            string[] subString = text1.Split(' ');
            foreach (var item in subString)
                Console.WriteLine(item); //ali
                                         //asad

            Console.WriteLine(value2.StartsWith("Al")); //True
            Console.WriteLine(value.Substring(2, 5)); //ycust

            char[] chArray = value2.ToCharArray();
            foreach (var item in chArray)
                Console.WriteLine(item);//A
                                        //l
                                        //i

            string text2 = "  ali   ";
            Console.WriteLine("{0} {1}", text2.Trim().Length, text2.Trim());

            Console.ReadKey();
        }
    }
}
