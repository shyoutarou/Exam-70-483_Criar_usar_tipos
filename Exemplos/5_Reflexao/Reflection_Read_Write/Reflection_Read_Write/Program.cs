using System;
using System.Reflection;

namespace Reflection_Read_Write
{
    class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; }

        public int Show()
        {
            Console.WriteLine("FirstName = {0} - Age = {1}", FirstName, Age);
            return Age;
        }

        public double Multiply(double x, double y) { return x * y; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var personobj = new Person { FirstName = "Sundus", Age = 21 };
            var personobj2 = new Person { FirstName = "Ali", Age = 22 };

            //Store Metadata of Person Type in Type's Object
            //return Type of 'Person' class
            Type persontype = typeof(Person);
            persontype = personobj.GetType();

            //Specify which property information is required
            //Return metadata of specified property
            PropertyInfo nameproperty = persontype.GetProperty("FirstName");

            //Specify 'instance' (personobj) of 'Type' (Person)
            //Whose 'property' (nameproperty) value is about to change
            nameproperty.SetValue(personobj, "Lakhtey");

            //Specify 'instance' (personobj) of 'Type' (Person)
            //Whose 'property' (nameproperty) value is required
            var value = nameproperty.GetValue(personobj);
            Console.WriteLine("{0} = {1}", nameproperty.Name, value); //FirstName = Lakhtey

            //Specify which method's information is required
            //Return metadata of specified method
            MethodInfo methodinfo = persontype.GetMethod("Show");

            //Provide instance (personobj) name whose method is about to invoke
            //pass parameter value 'null' if specified method has parameter
            var returnValue = methodinfo.Invoke(personobj, null);
            Console.WriteLine("Age = {0}", returnValue); // Age = 21

            returnValue = (double)persontype.InvokeMember("Multiply", BindingFlags.InvokeMethod, null, personobj, new object[] { 4, 5 });
            Console.WriteLine(string.Format("InvokeMember Return Value: {0}", returnValue)); // InvokeMember Return Value: 20

            Console.ReadKey();
        }
    }
}
