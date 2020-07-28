using System;
using System.Collections;
using System.Collections.Generic;

namespace IComparer_Example
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class sortAge : IComparer
    {
        public int Compare(object x, object y)
        {
            Person first = (Person)x;
            Person second = (Person)y;
            return first.Age.CompareTo(second.Age);
        }
    }

    class SortName : IComparer
    {
        public int Compare(object x, object y)
        {
            Person first = (Person)x;
            Person second = (Person)y;
            return first.Name.CompareTo(second.Name);
        }
    }

    class PersonComparer : IComparer<Person>
    {
        // The field to compare. 
        public enum CompareField { Name, Age }
        public CompareField SortBy = CompareField.Name;
        public int Compare(Person x, Person y)
        {
            switch (SortBy)
            {
                case CompareField.Name: return x.Name.CompareTo(y.Name);
                case CompareField.Age: return x.Age.CompareTo(y.Age);
            }
            return x.Name.CompareTo(y.Name);
        }
    }

    class sortAge_Generic : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Age.CompareTo(y.Age);
        }
    }

    class SortName_Generic : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Name.CompareTo(y.Name);
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

    class CarComparer : IComparer<Car>
    {
        // The field to compare. 
        public enum CompareField { Name, MaxMph, Horsepower, Price, }
        public CompareField SortBy = CompareField.Name;
        public int Compare(Car x, Car y)
        {
            switch (SortBy)
            {
                case CompareField.Name: return x.Name.CompareTo(y.Name);
                case CompareField.MaxMph: return x.MaxMph.CompareTo(y.MaxMph);
                case CompareField.Horsepower: return x.Horsepower.CompareTo(y.Horsepower);
                case CompareField.Price: return x.Price.CompareTo(y.Price);
            }
            return x.Name.CompareTo(y.Name);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            ArrayList people = new ArrayList();
            people.Add(new Person { Name = "Sundus", Age = 21 });
            people.Add(new Person { Name = "Ali", Age = 22 });
            people.Add(new Person { Name = "Hogi", Age = 12 });

            var people_array = people.ToArray();
            List<Person> people_list = new List<Person>() {
                new Person { Name = "Sundus", Age = 21 },
                new Person { Name = "Ali", Age = 22 },
                new Person { Name = "Hogi", Age = 12 }
            };

            //people_array.Sort(new sortAge()); Erro, não aceita parâmetro IComparer, só Array
            //people_list.Sort(new sortAge()); Erro, só aceita parâmetro IComparer genárico Person
            //sort list according to age
            people.Sort(new sortAge());
            foreach (Person person in people)
            {
                // 12 Hogi    21 Sundus       22 Ali
                Console.WriteLine(person.Age + " " + person.Name);
            }
            Console.WriteLine();
            //sort list according to name
            people.Sort(new SortName());
            foreach (Person person in people)
            {
                // Ali 22     Hogi 12         Sundus 21
                Console.WriteLine(person.Name + " " + person.Age);
            }

            var arr_per = new Person[]
            {
    new Person { Name = "Sundus", Age = 21 },
    new Person { Name = "Ali", Age = 22 },
    new Person { Name = "Hogi", Age = 12 }
            };

            var sortPerson = "Age";
            PersonComparer per_comparer = new PersonComparer();

            if (sortPerson == "Name")
                per_comparer.SortBy = PersonComparer.CompareField.Name;
            else if (sortPerson == "Age")
                per_comparer.SortBy = PersonComparer.CompareField.Age;
            Array.Sort(arr_per, new sortAge_Generic());
            Array.Sort(arr_per, new SortName_Generic());
            Array.Sort(arr_per, per_comparer);
            // NÃO FUNCIONA COM ARRAYLIST
            //Array.Sort(people, (IComparer<Person>)per_comparer);


            foreach (Person per in people)
            {
                Console.WriteLine("Name:{0}, Age:{1}, Age:{2}",
                per.Name, per.Age);
            }

            var Cars = new Car[]
            {
                new Car() { Name="Bugatti Veyron", MaxMph=253, Horsepower=1001, Price=1700000m},
                new Car() { Name="McLaren F1", MaxMph=240, Horsepower=637, Price=970000m},
                new Car() { Name="Ferrari Enzo", MaxMph=217, Horsepower=660, Price=670000m},
                new Car() { Name="Porsche Carrera GT", MaxMph=205, Horsepower=612, Price=440000m},
            };

            var sortByComboBox = "MaxMph";

            // Make the appropriate comparer. 
            CarComparer comparer = new CarComparer();
            if (sortByComboBox == "Name")
                comparer.SortBy = CarComparer.CompareField.Name;
            else if (sortByComboBox == "MaxMph")
                comparer.SortBy = CarComparer.CompareField.MaxMph;
            else if (sortByComboBox == "Horsepower")
                comparer.SortBy = CarComparer.CompareField.Horsepower;
            else comparer.SortBy = CarComparer.CompareField.Price;

            Array.Sort(Cars, comparer);
            //Cars.Sort(comparer); Só funciona com ArrayList

            foreach (Car car in Cars)
            {
                Console.WriteLine("Name:{0}, MaxMph:{1}, Horsepower:{2}, Price:{3}",
                car.Name, car.MaxMph, car.Horsepower, car.Price);
            }

            Console.ReadKey();
        }
    }
}
