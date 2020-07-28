using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_And_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            object o;
            int x = 123;

            //BOXING: CLASSE É CONVERTIDA EM OBJETO
            //coloca um int dentro de um objeto
            o = x;           //Boxing Implicito
            o = (object)x;   //Boxing Explicito

            Console.WriteLine("O objeto o = ", o); // O objeto o = 
            Console.WriteLine("x= " + x);  // x = 123

            //UNBOXING: OBJETO É CONVERTIDO EM CLASSE
            x = (int)o;
            Console.WriteLine("x= " + x);  // x = 123

            long y = 0;           // Declarando Int64 double
                                  //y = (Int64)o;       // Unboxing Explicito para double, da erro de Cast
            y = (Int64)(Int32)o;  // Unboxing e depois convertendo pra double

            Console.WriteLine("o= " + o);  // o = 123
            Console.WriteLine("y= " + x);  // y = 123

            Console.ReadKey();
        }
    }
}
