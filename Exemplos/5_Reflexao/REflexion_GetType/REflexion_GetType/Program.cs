using System;

namespace REflexion_GetType
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 42;
            System.Type type = i.GetType(); //System.Int32

            Console.WriteLine(type);

            System.Type myType = typeof(int); //System.Int32

            Console.WriteLine(myType);

            //AssmeblyQualifiedName: System.Int32, mscorlib, Version = 4.0.0.0, Culture = neutral, PublicKeyToken = b77a5c561934e089
            Console.WriteLine("AssmeblyQualifiedName: {0}", myType.AssemblyQualifiedName);
            Console.WriteLine("FullName: {0}", myType.FullName); //FullName: System.Int32
            Console.WriteLine("IsValueType: {0}", myType.IsValueType); //IsValueType: True
            Console.WriteLine("Name: {0}", myType.Name); //Name: Int32
            Console.WriteLine("Namespace: {0}", myType.Namespace); //Namespace: System


            int[,,] myIntArray = new int[5, 6, 7];
            Type myIntArrayType = myIntArray.GetType();
            Console.WriteLine("Array Rank: {0}", myIntArrayType.GetArrayRank());

            Console.ReadKey();
        }
    }
}
