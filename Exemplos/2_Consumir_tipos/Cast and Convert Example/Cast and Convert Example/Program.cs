using System;
using System.Net.Http;

namespace Cast_and_Convert_Example
{
    public class Person { }
    public class Employee : Person { }
    public class Manager : Person { }

    class Program
    {
        static void Main(string[] args)
        {

            // This is an implicit conversion
            // because the long data type is larger
            // than the int data type...
            // No possible loss of data

            int num = 2147483647;
            long bigNum = num;

            //implicit conversion from a reference type to one of its base types
            HttpClient client = new HttpClient();
            object o = client;
            IDisposable dc = client;


            // This requires an explicit conversion 
            int i = 5;
            double d = 10.5;
            //i = d;  // Cannot implicitly convert decimal to int
            i = (int)d;
            Console.WriteLine("The double variable d converted to int: " + i);


            // Cast or Convert.To ?

            int x = 7;
            double y = 12.6;
            x = (int)y;
            Console.WriteLine("y casted to an int: " + x);

            int xx = 7;
            double yy = 12.6;
            xx = Convert.ToInt32(yy); // Convert.To rounds the converted decimal up
            Console.WriteLine("yy converted to Int:" + xx);

            //int x = 7;
            //double y = 12.6;
            //double yy = 12.6;

            ////CAST: IGNORA AS CASAS DECIMAIS(.6)
            ////RESULTADO: 12
            //x = (int)y;
            ////CONVERT: ARREDONDA PARA CIMA/BAIXO O VALOR
            ////RESULTADO: 13
            //xx = Convert.ToInt32(yy); 

            // Using Convert with string
            string str = "123";
            int r;
            //r = str; // ERROR can't convert string to int
            //r = (int)str; // ERROR can't convert string to int

            r = Convert.ToInt32(str);

            Console.WriteLine("Using Convert.To to convert string to int: " + r);

            // Using AS operator
            Person person = new Employee();
            //convert explicitly from type A to B
            Employee employe = person as Employee;

            // Implicit cast to an array of Persons
            Employee[] employes = new Employee[10];
            Person[] persons = employes;

            // Explicit cast back to an array of Employees
            employes = (Employee[])persons;
            employes = persons as Employee[];

            if (persons is Employee[])
            { // Treat them as Employees. ...
            }

            // After this as statement, managers is null.
            Manager[] managers = persons as Manager[];

            // This cast fails at run time because the array
            // holds Employees not Managers. 
            managers = (Manager[])persons;

            Console.ReadKey();
        }
    }
}
