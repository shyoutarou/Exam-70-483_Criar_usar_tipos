using System;

namespace Extension_Method_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "Hello";
            var z = 1;

            Console.WriteLine(z + " é par? " + z.Eh_Par());
            Console.WriteLine(y + " is captalized? " + y.IsCap());

            Console.ReadKey();
        }
    }
    
    public static class StringCap
    {
        public static bool IsCap(this string s)
        {
            if (string.IsNullOrEmpty(s)) return false;
            return char.IsUpper(s[0]);
        }

        public static bool Eh_Par(this int s)
        {
            if (s % 2 == 0) return true;
            return false;
        }
    }

}








