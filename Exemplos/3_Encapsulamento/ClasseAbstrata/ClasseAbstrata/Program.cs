using System;

namespace ClasseAbstrata
{
    abstract class Vehicle
    {
        protected int wheels;
        public int Wheels
        {
            get { return wheels; }
        }
    }

    class Bike : Vehicle
    {
        public Bike()
        {
            base.wheels = 2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Bike();
            Console.WriteLine(vehicle.Wheels); //2
            Console.ReadKey();
        }
    }
}
