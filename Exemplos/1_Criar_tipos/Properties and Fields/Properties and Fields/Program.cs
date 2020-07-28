using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_and_Fields
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            // Assigning a value calls the set accessor
            p.Age = 41;

            Student_Full std = new Student_Full();
            std.Age = 10;

            // Reading a value calls the get accessor
            Console.WriteLine("p.Age= " + p.Age);

            Console.ReadKey();
        }
    }

    //Define and use full property
    class Student_Full
    {
        private int age;
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
    }

    class Student_Auto
    {
        public int Age { get; set; }
    }

    public class Person
    {
        //CAMPO: PRIVATE
        private int age;

        //PROPRIEDADE: PUBLIC
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if ((value > 0) && (value < 15))
                {
                    age = value;
                }
                else
                {
                    throw new Exception("Age cannot be over 15...");
                }
            }
        }

        public int Weight { get; set; }
    }
}
