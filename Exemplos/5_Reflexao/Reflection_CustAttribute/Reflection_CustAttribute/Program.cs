using System;
using System.Linq;
using System.Reflection;

namespace Reflection_CustAttribute
{

    //Tells MyCustomAttribute can only be use on a Class, Method and Property
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method | AttributeTargets.Property)]
    class MyCustomAttribute : Attribute
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public decimal Altura { get; set; }

        public MyCustomAttribute(string name, int age = -1)
        {
            this.Nome = name;
            this.Idade = age;
        }
    }

    //Class, Marked with Custom Attribute
    // [MyCustom(Nome = "Ali Asad", Idade = 30)], usado qdo ñ houver parametros no contrutor
    [MyCustom("Ali Asad")]
    class Person
    {
        //Property, Without Custom Attribute
        public int ID { get; set; }
        [MyCustom("Bob Ross", Idade = 18)] //Property, Marked with Custom Attribute
        public int Age { get; set; }
        //Method, Without Custom Attribute
        public void Bye()
        {
            Console.WriteLine("Bye, world!");
        }
        [MyCustom("Mary Poop", Idade = 30)] //Method, Marked with Custom Attribute
        public void Hi()
        {
            Console.WriteLine("Hi, world!");
        }
    }

    //Class, Without Custom Attribute
    class Machine
    {
        public int ID { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            //Get all types that are marked with 'MyCustomAttribute'
            var types = (from t in assembly.GetTypes()
                         where t.GetCustomAttributes<MyCustomAttribute>().Count() > 0
                         select t);

            foreach (var type in types)
            {
                Console.WriteLine(type.Name);
                //Get all properties which are marked with 'MyCustomAttribute'
                var properties = (from p in type.GetProperties()
                                  where p.GetCustomAttributes<MyCustomAttribute>().Count() > 0
                                  select p);

                foreach (var property in properties)
                {
                    Console.WriteLine("\tProperty Name: {0}", property.Name);
                }
                //Get all methods which are marked with 'MyCustomAttribute'
                var methods = (from m in type.GetMethods()
                               where m.GetCustomAttributes<MyCustomAttribute>().Count() > 0
                               select m);

                foreach (var method in methods)
                {
                    Console.WriteLine("\tMethod Name: {0}()", method.Name);
                }

                //******Retrieve Property Values**********//
                Type vtype = typeof(Person);
                Type atype = typeof(MyCustomAttribute);

                //get the MyCustomAttribute attached with vehivle Person
                MyCustomAttribute developer = (MyCustomAttribute)Attribute.GetCustomAttribute(vtype, atype);
                Console.WriteLine("{0} - {1}", developer.Nome, developer.Idade);

                Console.ReadKey();
            }
        }
    }
}

