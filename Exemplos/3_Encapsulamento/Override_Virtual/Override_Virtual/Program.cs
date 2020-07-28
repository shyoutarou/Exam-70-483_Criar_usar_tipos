using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Override_Virtual
{
    class Vehicle
    {
        public virtual void Run()
        {
            Console.WriteLine("Run Vehicle");
        }
    }

    class Bike : Vehicle
    {
        public override void Run()
        {
            Console.WriteLine("Bike Run");
        }
    }


    abstract class Vehicle_Abs
    {
        public abstract void Run();

        protected int wheels;
        public int Wheels
        {
            get { return wheels; }
        }
    }

    class Bike_Abs : Vehicle_Abs
    {
        public Bike_Abs()
        {
            base.wheels = 2;
        }

        public override void Run()
        {
            Console.WriteLine("Run Bike_Abs");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Pode ser instanciado, pois só método é virtual
            Vehicle vei_inst = new Vehicle();
            vei_inst.Run(); // Bike Run

            Vehicle vc = new Bike();
            vc.Run(); // Bike Run

            //Não podeser instanciada, classe abstrata
            //Vehicle_Abs vei_inst = new Vehicle_Abs();
            Vehicle_Abs vc_abs = new Bike_Abs();
            vc_abs.Run(); // Run Bike_Abs
            Console.WriteLine(vc_abs.Wheels); //2

            Console.ReadKey();
        }
    }
}
