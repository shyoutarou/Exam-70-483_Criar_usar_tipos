using System;
using System.Reflection;

namespace TipoNulavel
{
    public class Example
    {
        public int? MyMethod()
        {
            return 0;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            bool? isMarried = null;
            isMarried = true;
            bool casado = isMarried ?? false;

            Nullable<int> idade = null;
            int Age = idade ?? 3;


            int? i = null;
            int j = 10;

            if (i.HasValue) Console.WriteLine(i.Value); // or Console.WriteLine(i)
            else Console.WriteLine("Null");

            if (i < j) Console.WriteLine("i < j");
            else if (i > 10) Console.WriteLine("i > j");
            else if (i == 10) Console.WriteLine("i == j");
            else Console.WriteLine("Could not compare");

            if (Nullable.Compare<int>(i, j) < 0) Console.WriteLine("i < j");
            else if (Nullable.Compare<int>(i, j) > 0) Console.WriteLine("i > j");
            else Console.WriteLine("i = j");

            Enum[] enumValues = { ConsoleColor.Red, DayOfWeek.Monday, MidpointRounding.ToEven,
                        PlatformID.Win32NT,DateTimeKind.Utc, StringComparison.Ordinal };
            Console.WriteLine("{0,-10} {1, 18}   {2,15}\n", "Member", "Enumeration", "Underlying Type");
            foreach (var enumValue in enumValues) DisplayEnumInfo(enumValue);

            Type t = typeof(Example);
            MethodInfo mi = t.GetMethod("MyMethod");
            Type retval = mi.ReturnType;
            //Return value type...System.Nullable`1[System.Int32]
            Console.WriteLine("Return value type ... {0}", retval);
            Type answer = Nullable.GetUnderlyingType(retval);
            //Underlying type ..... System.Int32
            Console.WriteLine("Underlying type ..... {0}", answer);


            Console.WriteLine(casado);
            Console.ReadKey();
        }

        static void DisplayEnumInfo(Enum enumValue)
        {
            Type enumType = enumValue.GetType();
            Type underlyingType = Enum.GetUnderlyingType(enumType);
            Console.WriteLine("{0,-10} {1, 18}   {2,15}", enumValue, enumType.Name, underlyingType.Name);
            /*Member            Enumeration   Underlying Type

            Red              ConsoleColor             Int32
            Monday              DayOfWeek             Int32
            ToEven       MidpointRounding             Int32
            Win32NT            PlatformID             Int32
            Utc              DateTimeKind             Int32
            Ordinal      StringComparison             Int32*/
        }
    }
}
