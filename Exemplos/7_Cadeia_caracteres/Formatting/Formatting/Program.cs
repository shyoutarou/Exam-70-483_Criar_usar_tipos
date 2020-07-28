using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formatting
{
    class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
    }

    class Person
    {
        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

        public string ToString(string format)
        {
            if (string.IsNullOrWhiteSpace(format)) format = "FL";
            format = format.Trim().ToUpperInvariant();
            switch (format)
            {
                case "FL":
                    return FirstName + " " + LastName;
                case "LF":
                    return LastName.ToUpper() + ", " + FirstName;
                case "FSA":
                    return FirstName + " " + LastName + "(" + Age + ")";
                default:
                    throw new FormatException(String.Format(
                        "The '{0}' format string is not supported.", format));
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            decimal inteiro = new int();
            decimal value = 1.23m;
            Employee e = new Employee();
            Console.WriteLine(inteiro); //  0
            Console.WriteLine(value); //  1,23
            Console.WriteLine(value.ToString("0.000000")); // 1,230000
            Console.WriteLine(value.ToString("0,000000")); // 0.000.001
            Console.WriteLine(e); // Formatting.Employee
            Console.WriteLine(e.ToString()); // Formatting.Employee


            Person p = new Person("John", "Doe", 24);

            Console.WriteLine(p); // John Doe
            Console.WriteLine(p.ToString()); // John Doe
            Console.WriteLine(p.ToString("LF")); // DOE, John
            Console.WriteLine(p.ToString("fsa")); // John, Doe(24)


            int a = 1;
            int b = 2;
            string result = string.Format("a: {0}, b: {1}", a, b);
            Console.WriteLine(result); // Displays ‘a: 1, b: 2’

            double cost = 1234.56;
            int costinteiro = (int)cost;
            Console.WriteLine(cost.ToString("C", new CultureInfo("en-US"))); // $1,234.56
            Console.WriteLine(cost.ToString("C")); //R$ 1.234,56

            Console.WriteLine(costinteiro.ToString("D")); //1234
            //D5 = 5 digits will be display 
            Console.WriteLine(costinteiro.ToString("D5")); //01234
            Console.WriteLine(cost.ToString("E")); //1,234560E+003
            Console.WriteLine(cost.ToString("F")); //1234,56
            Console.WriteLine(cost.ToString("N")); //1.234,56
            Console.WriteLine(cost.ToString("P")); //123.456,00 %
            Console.WriteLine(costinteiro.ToString("X")); //4D2



            DateTime d = new DateTime(2013, 4, 22);
            CultureInfo provider = new CultureInfo("en-US");
            Console.WriteLine(d.ToString("d", provider)); // Displays 4/22/2013
            Console.WriteLine(d.ToString("D", provider)); // Displays Monday, April 22, 2013
            Console.WriteLine(d.ToString("M", provider)); // Displays April 22

            // Control Spacing
            string name = "Ali";
            int age = 22;
            //Name Ali | Age         22
            Console.WriteLine("Name {0,10} | Age {1, 10}", name, age);


            // Control Alignment
            //- Ali | end
            Console.WriteLine("- {0,-8} |end", name);


            Console.ReadKey();
        }
    }
}
