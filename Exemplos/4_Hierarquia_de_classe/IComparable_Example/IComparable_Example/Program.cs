using System;
using System.Collections;
using System.Collections.Generic;

namespace IComparable_Example
{
    class Person : IComparable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int CompareTo(object obj)
        {
            if (!(obj is Person))
                throw new ArgumentException("Object is not a Person");

            Person next = (Person)obj;
            return this.Age.CompareTo(next.Age);
        }
    }

    class Person_Generic : IComparable<Person_Generic>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int CompareTo(Person_Generic other)
        {
            return this.Age.CompareTo(other.Age);
        }
    }

    class Car : IComparable
    {
        public string Name { get; set; }
        public int MaxMph { get; set; }
        public int Horsepower { get; set; }
        public decimal Price { get; set; }

        // Compare Cars alphabetically by Name. 
        public int CompareTo(object obj)
        {
            if (!(obj is Car))
                throw new ArgumentException("Object is not a Car");

            Car other = obj as Car;

            return Name.CompareTo(other.Name);
        }
    }

    class Car_Generic : IComparable<Car_Generic>
    {
        public string Name { get; set; }
        public int MaxMph { get; set; }
        public int Horsepower { get; set; }
        public decimal Price { get; set; }

        // Compare Cars alphabetically by Name. 
        public int CompareTo(Car_Generic other)
        {
            return this.Name.CompareTo(other.Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArrayList people_array = new ArrayList(){
            new Person { Name = "Sundus", Age = 21 },
            new Person { Name = "Ali", Age = 22 },
            new Person { Name = "Hogi", Age = 12 },
            };

            //sort list of persons
            people_array.Sort();
            foreach (Person person in people_array)
            {
                //12 Hogi    21 Sundus    22 Ali
                Console.WriteLine(person.Age + " " + person.Name);
            }

            List<Person_Generic> people_list = new List<Person_Generic>();
            people_list.Add(new Person_Generic { Name = "Sundus", Age = 21 });
            people_list.Add(new Person_Generic { Name = "Ali", Age = 22 });
            people_list.Add(new Person_Generic { Name = "Hogi", Age = 12 });
            //sort list of persons
            people_list.Sort();

            foreach (var person in people_list)
            {
                //12 Hogi    21 Sundus    22 Ali
                Console.WriteLine(person.Age + " " + person.Name);
            }

            Console.ReadKey();
        }
    }
}
