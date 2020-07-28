using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            var hello = new char[] { 'H', 'e', 'l', 'l', 'o', '!' };
            string ctor1 = new string(hello);
            Console.WriteLine(ctor1); //Hello!


            string ctor2 = new string(hello, 0, 4);
            Console.WriteLine(ctor2); //Hell

            for (int i = 1; i <= 10; i++)
            {
                string ctor3 = new string(' ', 4 * i);
                Console.WriteLine(ctor3 + i.ToString());
            }

            var vazio = String.Empty;
            var comprimento = ctor1.Length;
            var index_leitura = ctor1[4];

            var text = "text em maiuscula e minusculas";

            char[] characters = text.ToCharArray();
            for (int i = 0; i < characters.Length; i++)
                if (i % 2 == 0) characters[i] = char.ToUpper(characters[i]);
                else characters[i] = char.ToLower(characters[i]);

            text = new string(characters);
            Console.WriteLine(text); //TeXt eM MaIuScUlA E MiNuScUlAs


            text = "The quick brown fox jumps over the lazy dog.";
            int[] counts = new int[26];
            text = text.ToUpper();
            foreach (char ch in text)
            {
                Console.Write(ch + " - ");
                if (char.IsLetter(ch))
                {
                    int index = (int)ch - (int)'A';
                    counts[index]++;
                }
            }





            Console.ReadKey();
        }
    }
}
