using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient p = new Patient();
            p.Examine("Bob");  // use the Patient functionalities

            Child c = new Child();
            c.Examine("Billy");  // Use both Patient and Child functionalities
            c.Innoculate();

            //Testes Construtores
            Child cctor = new Child("Daryl", "Hall");
            Patient pctor = new Patient("Darius", "Rucker", "M", 68);

            Console.ReadKey();

        }
    }

    public class Patient
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public long SSN { get; set; }

        public Patient()
        {

        }

        public Patient(string FirstName, string LastName, string Gender)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Gender = Gender;
        }

        public Patient(string FirstName, string LastName, string Gender, int Age) : this(FirstName, LastName, Gender)
        {
            this.Age = Age;
        }

        public Patient(string FirstName, string LastName)
        {
            // Validate the first and last names. 
            if ((FirstName == null) || (FirstName.Length < 1))
                throw new ArgumentOutOfRangeException("firstName", FirstName, "FirstName must not be null or blank.");
            if ((LastName == null) || (LastName.Length < 1))
                throw new ArgumentOutOfRangeException("lastName", LastName, "LastName must not be null or blank.");

            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public void Examine(string pname)
        {
            // Add code for patient examination...
            Console.WriteLine("Exmination of " + pname + " completed...");
        }

        public void Billing(long ssn)
        {
            // Add code to retrive patient billing/balance info
            Console.WriteLine("Billing completed...");
        }
    }

    public class Child : Patient  // Use colon to establish inheritance from Patient
    {
        public string Nome_Pai { get; set; }

        public Child()
        {

        }

        public Child(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public Child(string firstName, string lastName, string nomepai)
            : this(firstName, lastName)
        {
            Nome_Pai = nomepai;
        }

        public void Innoculate()
        {
            // Add code to record innoculation
            Console.WriteLine("Child has been innoculated...");
        }
    }
}
