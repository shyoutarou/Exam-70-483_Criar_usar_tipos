using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores
{
    class Access_Publico
    {
        public void Method()
        {
            Console.WriteLine("Método Público");
        }
    }

    class Access_Privado
    {
        private int age = 10;
        public int GetAge()
        {
            return age;
        }
        public void SetAge(int a)
        {
            age = a;
        }
    }


    class Parent
    {
        protected int age;
    }

    class Child : Parent
    {
        public void Display()
        {
            Console.WriteLine("Protect Age is = {0}", age);
            //Console.WriteLine("Age is = {0}", base.age);
        }
    }

    class Parent1
    {
        public string SurName { get; set; }
    }

    class Child1 : Parent1
    {
        private string _name;
        public string Name
        {
            get
            {
                return (_name + " " + base.SurName);
            }
            set
            {
                Name = value;
            }
        }
    }

    class Person
    {
        internal protected int idade = 30;
    }

    class Employee : Person
    {
        public void Display()
        {
            Console.WriteLine("Protect Internar Idade = {0}", base.idade);
        }
    }

    class Program
    {
        class Access_Interno
        {
            internal int age = 20;
        }

        static void Main(string[] args)
        {
            Access_Publico publico = new Access_Publico();
            publico.Method(); // Método Público

            Access_Privado privado = new Access_Privado();
            int age = privado.GetAge();
            Console.WriteLine("Private age = {0}", age); // Private age = 10

            Child filho = new Child();
            filho.Display(); // Protect Age is = 0

            Access_Interno access = new Access_Interno();
            int age_int = access.age;
            Console.WriteLine("Internal age = {0}", age_int); // Internal age = 20

            Person pessoa = new Person();
            int idade = pessoa.idade;
            Console.WriteLine("Protect Internar Idade = {0}", idade); // Protect Internar Idade = 30

            Console.ReadKey();
        }
    }
}
