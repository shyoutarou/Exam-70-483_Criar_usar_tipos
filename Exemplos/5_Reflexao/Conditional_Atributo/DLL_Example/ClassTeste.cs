#define CONDITION1
//#define CONDITION2
#undef CONDITION2 // Ainda imprime o método

using System;
using System.Diagnostics;

namespace DLL_Example
{

    class A { public int Random { get; set; } }
    class B : A { }

public class ClassTeste
{
    [ConditionalAttribute("CONDITION1")]
    public static void MetodoVoid(string txt)
    {
        Debug.WriteLine("DEBUG method.Invoke.MetodoVoid: " + txt);
    }
}
}
