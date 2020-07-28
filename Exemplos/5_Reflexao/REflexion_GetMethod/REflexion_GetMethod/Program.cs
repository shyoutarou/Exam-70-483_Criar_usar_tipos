using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace REflexion_GetMethod
{
    class Person
    {
        public double Multiply(double x, double y) { return x * y; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person reflectionExample = new Person();
            Type reflectionExampleType = typeof(Person);

            MethodInfo methodInfo = reflectionExampleType.GetMethod("Multiply");

            double returnValue = (double)methodInfo.Invoke(reflectionExample, new object[] { 4, 5 });


            Debug.Print(string.Format("Return Value: {0}", returnValue));
            Console.WriteLine(string.Format("Invoke Return Value: {0}", returnValue));

            returnValue = (double)reflectionExampleType.InvokeMember("Multiply", BindingFlags.InvokeMethod, null, reflectionExample, new object[] { 4, 5 });

            Debug.Print(string.Format("Return Value: {0}", returnValue));
            Console.WriteLine(string.Format("InvokeMember Return Value: {0}", returnValue));

            Console.ReadKey();
        }
    }
}
