using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient p = new Patient();
            p.CheckBilling();
            p.CheckBilling(2, 3);
            p.CheckBilling("Mark", 25);

            Child c = new Child();
            c.CheckBilling();
            c.CheckBilling(4, 4);
            c.CheckBilling("Mark", "Long");
        }
    }

    public class Patient
    {
        public string firstName;
        public string lastName;
        public int idade;
        public string endereco;

        public Patient()
        {

        }

        public Patient(string first, string last)
        {
            this.firstName = first;
            this.lastName = last;
        }

        public Patient(string first, string last, int age, string adress)
        {
            this.firstName = first;
            this.lastName = last;
            this.idade = age;
            this.endereco = adress;
        }

        public void CheckBilling()
        {
            Console.WriteLine("Patient: The billing has been checked...");
        }

        public void CheckBilling(int a, int b)
        {
            Console.WriteLine("Patient: The billing has been checked using two submitted integers...");
        }

        public void CheckBilling(string a, int b)
        {
            Console.WriteLine("Patient: The billing has been checked using a submitted string and integer...");
        }
    }

    public class Child : Patient
    {
        public void CheckBilling(string a, string b)
        {
            Console.WriteLine("Child: The billing has been checked using a submitted two strings...");
        }
    }
}
