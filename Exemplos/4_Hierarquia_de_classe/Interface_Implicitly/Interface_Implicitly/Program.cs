using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Implicitly
{
    interface IVehicle
    {
        int Wheels { get; }
    }

    class Bike : IVehicle
    {
        private int wheels;
        public int Wheels
        {
            get
            {
                return wheels;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IVehicle vehicle = new Bike();
            Console.WriteLine(vehicle.Wheels); //0
            Console.ReadKey();
        }
    }
}
