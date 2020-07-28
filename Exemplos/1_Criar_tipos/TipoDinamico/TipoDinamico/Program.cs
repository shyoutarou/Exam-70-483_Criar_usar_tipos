using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoDinamico
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic price = 20;
            Console.WriteLine(price.GetType()); // System.Int32

            dynamic tipo_dinamico = "Ali";
            Console.WriteLine(tipo_dinamico.GetType()); // System.String

            tipo_dinamico = 3.4m;
            Console.WriteLine(tipo_dinamico.GetType()); // System.Decimal

            tipo_dinamico = new double[10];
            Console.WriteLine(tipo_dinamico.GetType()); // System.Double[]

            Console.ReadKey();
        }
    }
}
