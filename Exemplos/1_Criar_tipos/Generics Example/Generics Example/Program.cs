using System;

namespace Generics_Example
{

    // We use < > to specify Parameter type 
    public class GFG<T>
    {
        // private data members 
        private T data;

        // using properties 
        public T value
        {
            // using accessors 
            get
            {
                return this.data;
            }
            set
            {
                this.data = value;
            }
        }

        // Generics method 
        public void Display<TypeOfValue>(string msg, TypeOfValue value)
        {
            Console.WriteLine("{0}:{1}", msg, value);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            long z = 7;
            int x = 7;

            //MAS SE...
            //x = z;

            double y = 12.6;
            x = (int)y;

            // instance of string type 
            GFG<string> name = new GFG<string>();
            name.value = "GeeksforGeeks";

            // instance of float type 
            GFG<float> version = new GFG<float>();
            version.value = 5.0F;

            Console.WriteLine(name.value); //GeeksforGeeks

            Console.WriteLine(version.value); //5

            // calling Generics method 
            name.Display<int>("Integer", 122); //Integer: 122
            name.Display<char>("Character", 'H'); //Character: H
            version.Display<double>("Decimal", 255.67); // Decimal:255,67


            int[] arrInts = new int[] { 2, 5, 4, 7, 6, 7, 1, 3, 9, 8 };
            char[] arrChar = new char[] { 'f', 'a', 'r', 'c', 'h' };
            // Sorting: integer Sort 
            for (int i = 0; i < arrInts.Length; i++)
            {
                for (int j = i + 1; j < arrInts.Length; j++)
                {
                    if (arrInts[i] > arrInts[j])
                    {
                        Swap<int>(ref arrInts[i], ref arrInts[j]);
                    }
                }

            }

            // Sorting: character Sort 
            for (int i = 0; i < arrChar.Length; i++)
            {
                for (int j = i + 1; j < arrChar.Length; j++)
                {
                    if (arrChar[i] > arrChar[j])
                    {
                        Swap<char>(ref arrChar[i], ref arrChar[j]);
                    }
                }
            }

            MethodsExample methods = new MethodsExample();

            //Call generic method which has single generic type
            methods.GenericMethodArgs<int>(10); //10
            int FromSingle = methods.ReturnFromGenericMethodArgs<int>(10);
            Console.WriteLine(FromSingle + "\n"); //10
                                                  //Call generic method which has multiple generic type
            methods.MultipleGenericMethodArgs<string, int>("Exam", 70483); //Exam: 70483
            int FromMultiple = methods.ReturnFromMultipleGenericMethodArgs<string, int>("Exam: ");
            Console.WriteLine(FromMultiple); //0

            Console.ReadKey();
        }

        // example of generic method with type parameters
        public static void Swap<T>(ref T valueOne, ref T valueTwo)
        {
            T temp = valueOne;
            valueOne = valueTwo;
            valueTwo = temp;
        }
    }

    class MethodsExample
    {

        public void GenericMethodArgs<T>(T first)
        {
            Console.WriteLine(first);
        }
        public T ReturnFromGenericMethodArgs<T>(T first)
        {
            return first;
        }
        public void MultipleGenericMethodArgs<T, U>(T first, U second)
        {
            Console.WriteLine("{0}: {1}", first, second);
        }
        public U ReturnFromMultipleGenericMethodArgs<T, U>(T first)
        {
            U temp = default(U);
            return temp;
        }
    }
}
