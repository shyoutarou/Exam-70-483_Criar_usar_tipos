using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICloneable_Example
{
    class Person : ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person Manager { get; set; }

        // Return a clone of this person. 
        public object Clone()
        {
            Person person = new Person();
            person.FirstName = FirstName;
            person.LastName = LastName;
            person.Manager = Manager;
            return person;
        }

        public object DeepClone()
        {
            Person person = new Person();
            person.FirstName = FirstName;
            person.LastName = LastName;
            person.Manager = Manager;
            if (Manager != null)
                person.Manager = (Person)Manager.Clone();
            return person;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person ann = new Person() { FirstName = "Ann", LastName = "Archer", Manager = null };
            Person bob = new Person() { FirstName = "Bob", LastName = "Baker", Manager = ann };
            Person bob2 = (Person)bob.Clone();
        }
    }
}
