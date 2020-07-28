	using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Static_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Notice we don't need to instantiate the Math object to call the Round method
            // The Math class is static
            double r = Math.Round(35.3);
            Console.WriteLine(r);

            // An instiantiated object will not see the Accelerate method because it is static
            Car c = new Car();
   
            // The Car class exposes the static Accelerate method, but not the Stop method
            Car.Accelerate();

            c.SlowDown();

       

            


        }
    }

    // Create the car class with a static method Accelearate and a non-static stop method
    public class Car
    {
        public static void Accelerate()
        {
            Console.WriteLine("Car is accelerating");

        }

        public void SlowDown()
        {
            Console.WriteLine("Car is slowing down...");
        }
    }
}
