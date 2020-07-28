using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEquatable_Example
{
    class Person : IEquatable<Person>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public bool Equals(Person other)
        {
            if ((FirstName == other.FirstName) && (LastName == other.LastName))
                return true;
            else return false;
        }

        public override bool Equals(object obj)
        {
            Person other = (Person)obj;
            return this.Equals(other);
        }

        public override int GetHashCode()
        {
            //custom implementation of hashcode
            string hash = this.FirstName + this.LastName;
            return hash.GetHashCode();
        }

        public static bool operator ==(Person person1, Person person2)
        {
            if (((object)person1) == null || ((object)person2) == null)
                return Object.Equals(person1, person2);
            return person1.Equals(person2);
        }

        public static bool operator !=(Person person1, Person person2)
        {
            if (((object)person1) == null || ((object)person2) == null)
                return !Object.Equals(person1, person2);
            return !(person1.Equals(person2));
        }
    }

    class Person_Equals : IEquatable<Person_Equals>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public bool Equals(Person_Equals other)
        {
            return ((FirstName == other.FirstName) && (LastName == other.LastName));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person() { Age = 21, FirstName = "Ali", LastName = "Dali" };
            Person person2 = new Person() { Age = 45, FirstName = "Ali", LastName = "Dali" };
            Console.WriteLine(person1 == person2); // True

            List<Person> People = new List<Person>();
            People.Add(person1);

            if (People.Contains(person2)) // True
                Console.WriteLine("The list already contains this person.");
            else People.Add(person2);

            Console.ReadKey();
        }
    }
}
