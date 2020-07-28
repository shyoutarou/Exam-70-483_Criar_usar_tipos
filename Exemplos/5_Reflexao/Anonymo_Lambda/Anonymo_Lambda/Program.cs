using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymo_Lambda
{
    class Program
    {
        delegate void MyFirstDelegate(string s);
        delegate void MyAnonymousMethod();
        delegate double square(double x);
        delegate bool GreaterThan(double x, double y);

        static void Main(string[] args)
        {
            var myLocalString = "Hello World";

            //Create an anonymous method using the local variable.
            MyAnonymousMethod forward = delegate ()
            {
                Console.WriteLine(string.Format("This is my AnonymousMethod: {0}", myLocalString));
            };
            forward();

            square myLambdaExpression = x => x * x;
            Console.WriteLine("X squared is {0}", myLambdaExpression(5)); // 25

            GreaterThan gt = (x, y) => x > y;
            Console.WriteLine("Is 6 greater than 5. {0}", gt(6, 5)); // True

            //Use a Lambda expression statement with a local variable.
            MyAnonymousMethod myFirstDelegate2 = () =>
            {
                char[] charArray = myLocalString.ToCharArray();
                Array.Reverse(charArray);
                Console.WriteLine(string.Format("This is my string backwards: {0}", new string(charArray)));
            };
            myFirstDelegate2();

            //Use a Lambda expression statement with a parameter.
            MyFirstDelegate myFirstDelegate3 = s =>
            {
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                Console.WriteLine(string.Format("This is my string backwards: {0}", new string(charArray)));
            };
            myFirstDelegate3(myLocalString);

            WriteToConsole(x => Console.WriteLine("Esta é minha string {0}", x), "Olá, mundo");

            Console.ReadKey();
        }

        static void WriteToConsole(MyFirstDelegate myDelegate, string stringToWrite)
        {
            myDelegate(stringToWrite);
        }
    }
}
