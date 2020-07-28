using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c[1] = "Mercedes";
            c[2] = "Dodge";
            c[3] = "Chevrolet";

            Console.WriteLine("Car 1 is: " + c[1]); //Car 1 is: Mercedes
            Console.WriteLine("Car 2 is: " + c[2]); //Car 2 is: Dodge
            Console.WriteLine("Car 3 is: " + c[3]); //Car 3 is: Chevrolet

            Temperature temp = new Temperature();
            float todayTemp = temp[1]; //read
            Console.WriteLine(todayTemp); //40
            temp[1] = -5.0F; //Please set value greater than 0
            temp[1] = 10.0F;
            Console.WriteLine(temp[1]); //10
            Console.ReadKey();
        }
    }

    public class Car
    {
        string[] car = new string[40];

        public string this[int carNum]
        {
            get
            {
                if (carNum >= 0 && carNum < car.Length)
                    return car[carNum];
                return "Out of index range";
            }
            set
            {
                if (carNum >= 0 && carNum < car.Length)
                    car[carNum] = value;
            }
        }
    }

    class Temperature
    {
        //declare private array of float type.
        private float[] weekTemp = { 47.5F, 40.0F, 52.5F, 45.5F, 48.0F, 38.0F, 35.7F };
        //use float indexer, to encapsulate weekTemp
        public float this[int index]
        {
            get
            {
                if (index >= 0 && index < weekTemp.Length)
                {
                    return weekTemp[index];
                }
                else return 0;
            }
            set
            {
                if (value > 0) weekTemp[index] = value;
                else Console.WriteLine("Please set value greater than 0");
            }
        }
    }
}
