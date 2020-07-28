using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Immutable
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            //Record how much time
            watch.Start();

            string mystring = "test";
            for (int i = 1; i < 100000; i++)
            {
                mystring += i;
            }

            //Stop Recording time
            watch.Stop();
            float miliToSec = watch.ElapsedMilliseconds / 1000;
            Console.WriteLine("Total time: {0}s", miliToSec); // Total time: 19s

            Console.ReadKey();
        }
    }
}
