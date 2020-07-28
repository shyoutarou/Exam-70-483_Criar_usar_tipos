using System;

namespace Overload_Types
{
    class Calculator
    {
        public void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Sum of ints = {0}", result);
        }
        public void Add(string a, string b)
        {
            string result = a + b;
            Console.WriteLine("Sum of strings = {0}", result);
        }
    }

    class Person
    {
        public decimal salario;
        public string endereco;

        public Person()
        {

        }

        public Person(decimal salario)
        {
            this.salario = salario;
        }

        public Person(decimal sal, string end)
        {
            this.salario = sal;
            this.endereco = end;
        }

        public void Show(string name)
        {
            Console.WriteLine("Name = {0}", name);
        }

        public void Show(string name, int age)
        {
            Console.WriteLine("Name = {0} - Age = {1}", name, age);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            cal.Add(1, 2); // Sum of ints = 3
            cal.Add("C", "Sharp"); // Sum of strings = CSharp

            Person per = new Person();
            per.Show("Ali"); // Name = Ali
            per.Show("Ali", 22); // Name = Ali - Age = 22

            Person per2 = new Person(150);
            Person per3 = new Person(50, "Rua Jacu");

            Console.ReadKey();
        }
    }
}
