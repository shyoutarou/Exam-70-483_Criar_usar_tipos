using System;
using System.Collections.Generic;

namespace Generic_Restricao_Metod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rstrição class
            string s1 = "target";
            System.Text.StringBuilder sb = new System.Text.StringBuilder("target");
            string s2 = sb.ToString();
            OpEqualsTest<string>(s1, s2);

            ////Restrição delegate, C# 7.3 para cima
            //Action first = () => Console.WriteLine("this");
            //Action second = () => Console.WriteLine("that");

            //var combined = first.TypeSafeCombine(second);
            //combined();

            //Func<bool> test = () => true;
            //// Combine signature ensures combined delegates must
            //// have the same type.
            ////var badCombined = first.TypeSafeCombine(test);

            ////Restrição Enum, C# 7.3 para cima


            Console.ReadKey();
        }

        public static void OpEqualsTest<T>(T s, T t) where T : class
        {
            System.Console.WriteLine(s == t);
        }

        public static Dictionary<int, string> EnumNamedValues<T>() where T : Enum
        {
            var result = new Dictionary<int, string>();
            var values = Enum.GetValues(typeof(T));

            foreach (int item in values)
                result.Add(item, Enum.GetName(typeof(T), item));
            return result;
        }

        public static TDelegate TypeSafeCombine<TDelegate>(TDelegate source, TDelegate target) where TDelegate : Delegate
        => Delegate.Combine(source, target) as TDelegate;

        //unsafe public static byte[] ToByteArray<T>(this T argument) where T : unmanaged
        //{
        //    var size = sizeof(T);
        //    var result = new Byte[size];
        //    Byte* p = (byte*)&argument;
        //    for (var i = 0; i < size; i++)
        //        result[i] = *p++;
        //    return result;
        //}
    }
}
