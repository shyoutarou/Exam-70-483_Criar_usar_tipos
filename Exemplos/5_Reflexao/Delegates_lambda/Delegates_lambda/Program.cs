using System;
using System.IO;

namespace Delegates_lambda
{
    public class LambdaExpression
    {
        public static void WriteToConsoleForward(string stringToWrite)
        {
            Console.WriteLine("This is my string: {0}", stringToWrite);
        }

        public static void WriteToConsoleBackwards(string stringToWrite)
        {
            char[] charArray = stringToWrite.ToCharArray();
            Array.Reverse(charArray);

            Console.WriteLine(string.Format("Write backwards: {0}", new string(charArray)));
        }
    }

    class Program
    {
        delegate void MyFirstDelegate(string s);
        public delegate void Del();
        public delegate TextWriter CovarianceDel();
        public delegate void ContravarianceDel(StreamWriter tw);

        static void Main(string[] args)
        {
            var myLocalString = "Hello World";

            //Call the function using a delegate.                       
            MyFirstDelegate myFirstDelegate = new MyFirstDelegate(LambdaExpression.WriteToConsoleForward);
            myFirstDelegate(myLocalString); // This is my string: Hello World

            WriteToConsole(LambdaExpression.WriteToConsoleForward, myLocalString); // This is my string: Hello World
            WriteToConsole(LambdaExpression.WriteToConsoleBackwards, myLocalString); // Write backwards: dlroW olleH

            MyFirstDelegate myFirstDelegate2 = LambdaExpression.WriteToConsoleForward;
            myFirstDelegate2 += LambdaExpression.WriteToConsoleBackwards;
            myFirstDelegate2(myLocalString);


            Del d = MethodOne;
            d += MethodTwo;
            d(); //MethodOne    MethodTwo


            CovarianceDel del_covarinace;
            del_covarinace = MethodStream;
            del_covarinace = MethodString;
            var retorno = del_covarinace();

            ContravarianceDel del_contravariance = DoSomething;
            del_contravariance((StreamWriter)retorno);

            Console.ReadKey();
        }

        public static StreamWriter MethodStream() { return null; }
        public static StringWriter MethodString() { return null; }
        public static void DoSomething(TextWriter tw) { }



        static void WriteToConsole(MyFirstDelegate myDelegate, string stringToWrite)
        {
            myDelegate(stringToWrite);
        }

        public static void MethodOne()
        {
            Console.WriteLine("MethodOne");
        }
        public static void MethodTwo()
        {
            Console.WriteLine("MethodTwo");
        }
    }
}
