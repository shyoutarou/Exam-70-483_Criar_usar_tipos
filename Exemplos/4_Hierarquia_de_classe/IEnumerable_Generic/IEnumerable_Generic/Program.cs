using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace IEnumerable_Generic
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {

        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }

    class myGenericList<T> : IEnumerable<T>
    {
        List<T> list = new List<T>();
        //Get length of list<T>
        public int Length
        {
            get { return list.Count; }
        }
        public void Add(T data)
        {
            list.Add(data);
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in list)
            {
                yield return item;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            //return IEnumerator<T> GetEnumerator()
            return this.GetEnumerator();
        }
    }

    class People : IEnumerable<Person>
    {
        Person[] people;

        public People(Person[] people)
        {
            this.people = people;
        }

        public IEnumerator<Person> GetEnumerator()
        {
            for (int index = 0; index < people.Length; index++)
            {
                yield return people[index];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            myGenericList<Person> people = new myGenericList<Person>();
            people.Add(new Person { Name = "Ali", Age = 22 });
            people.Add(new Person { Name = "Sundus", Age = 21 });
            people.Add(new Person { Name = "Hogi", Age = 12 });

            Console.WriteLine("Total person: {0} \n", people.Length); //Total person: 3
            foreach (Person person in people)
            {
                //Name: Ali Age:22
                //Name: Sundus Age:21
                //Name: Hogi Age:12
                Console.WriteLine("Name:{0} Age:{1}", person.Name, person.Age);
            }

            //mostra como iterar sobre uma coleção sem usar o foreach.
            List<int> numbers = new List<int> { 1, 2, 3, 5, 7, 9 };
            foreach (int value in numbers)
            {
                Console.Write(value + " - "); // 1 - 2 - 3 - 5 - 7 - 9 -
            }

            using (IEnumerator<int> enumerator = numbers.GetEnumerator())
            {
                // 1 - 2 - 3 - 5 - 7 - 9 -
                while (enumerator.MoveNext()) Console.Write(enumerator.Current + " - ");
            }

            using (List<int>.Enumerator enumerator = numbers.GetEnumerator())
            {
                // 1 - 2 - 3 - 5 - 7 - 9 -
                while (enumerator.MoveNext()) Console.Write(enumerator.Current + " - ");
            }


            //Some methods, like Range(), make it easier to create IEnumerable collections.
            IEnumerable<int> result = from value in Enumerable.Range(0, 5)
                                      select value;

            foreach (int value in result)
            {
                //0    1    2    3     4
                Console.WriteLine(value);
            }


            // We can use extension methods on IEnumerable<int>
            Console.WriteLine(result.Average()); // 2
            Console.WriteLine(result.Sum()); // 10
            Console.WriteLine(result.First()); // 0
            Console.WriteLine(result.Last()); // 4
            Console.WriteLine(result.Max()); // 4
            Console.WriteLine(result.Min()); // 0

            // Extension methods can convert IEnumerable<int>
            List<int> list = result.ToList();
            int[] array = result.ToArray();

            int[,] matriz_2D = new int[15, 15];
            matriz_2D[0, 1] = 4;
            matriz_2D[4, 4] = 5;
            matriz_2D[14, 2] = 3;

            int sum = 0;
            foreach (int value in Soma_Matriz2D(matriz_2D))
            {
                sum += value;
            }
            //SUMMED 2D ELEMENTS: 12
            Console.WriteLine("SUMMED 2D ELEMENTS: " + sum);

            Console.ReadKey();
        }

        public static IEnumerable<int> Soma_Matriz2D(int[,] matriz_2D)
        {
            // Use yield return to return all 2D array elements.
            for (int x = 0; x < 15; x++)
            {
                for (int y = 0; y < 15; y++)
                {
                    yield return matriz_2D[x, y];
                }
            }
        }
    }
}
