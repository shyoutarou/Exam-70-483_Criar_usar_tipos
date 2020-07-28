using System;
using System.Numerics;

namespace ComplexType
{
    class Program
    {
static void Main(string[] args)
{
    long varLong = 931548458140;
    BigInteger fromLong = varLong;
    Console.WriteLine("Número convertido para BigInteger.");
    Console.WriteLine(fromLong);

    var c1 = new Complex(2, 5);
    var c2 = new Complex(4, 7);
    var add = c1 + c2;
    Console.WriteLine("Adição: " + add);
    var sub = c1 - c2;
    Console.WriteLine("Subtração: " + sub);
    var mult = c1 * c2;
    Console.WriteLine("Multiplicação: " + mult);
    var div = c1 / c2;
    Console.WriteLine("Divisão: " + div);

    Console.Read();
}
    }
}
