#define CONDITION1
//#define CONDITION2
#undef CONDITION2 // Ainda imprime o método
using System;
using System.Diagnostics;
using System.Reflection;

namespace Conditional_Atributo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calling Method1");
            Method1(3);
            Console.WriteLine("Calling Method2");
            Method2();

            Console.WriteLine("Using the Debug class");
            Debug.Listeners.Add(new ConsoleTraceListener());
            Debug.WriteLine("DEBUG is defined");

            //Call methods with reflection
            MethodInfo[] methods = typeof(DLL_Example.ClassTeste).GetMethods(BindingFlags.Static | BindingFlags.Public);
            foreach (MethodInfo method in methods)
            {
                ConditionalAttribute conditional =
                Attribute.GetCustomAttribute(method, typeof(ConditionalAttribute)) as ConditionalAttribute;

                if (conditional != null)
                {
                    //I can get the string of the condition;
                    string conditionString = conditional.ConditionString;

                    //If the method has a ConditionalAttribute
                    if (conditionString != null)
                    {
                        method.Invoke(null, new object[] { conditionString });
                    }
                }
            }

            Console.ReadKey();
        }

        [Conditional("CONDITION1")]
        public static void Method1(int x)
        {
            Console.WriteLine("CONDITION1 is defined");
        }

        [Conditional("CONDITION1"), Conditional("CONDITION2")]
        public static void Method2()
        {
            Console.WriteLine("CONDITION1 or CONDITION2 is defined");
        }
    }
}
/*
Quando compilado como mostrado, o aplicativo produz a seguinte saída.

Calling Method1
CONDITION1 is defined
Calling Method2
CONDITION1 or CONDITION2 is defined
Using the Debug class
DEBUG is defined

Se comentar as declarações define:
Calling Method1
Calling Method2
Using the Debug class
DEBUG is defined
*/
