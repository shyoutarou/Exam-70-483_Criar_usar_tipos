using System;
using System.Reflection;

namespace Reflection_Get_Private
{
    class Person
    {
        public static string company = "Microsoft";

        private int Age { get; set; }
        private string FirstName { get; set; }
        public Person(int age, string name)
        {
            this.Age = age;
            this.FirstName = name;
        }

        private string _privateField = "Hello";

        public string PrivateField
        {
            get { return _privateField; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var personobj = new Person(21, "Sundus");
            var personobj2 = new Person(22, "Ali");
            //Store Metadata of Person Type in Type's Object
            //return Type of 'Person' class
            Type persontype = personobj.GetType();
            //Pass BindingFlags to specify what kind of data member you want.
            //NonPublic = Private  || Non-Static = Instance
            PropertyInfo[] props = persontype.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (PropertyInfo prop in props)
            {
                //Age = 21
                //FirstName = Sundus
                Console.WriteLine("{0} = {1}", prop.Name, prop.GetValue(personobj));
            }

            //BindingFlags.Static = Static Member || BindingFlags.Public = Public Membe
            FieldInfo[] fields = persontype.GetFields(BindingFlags.Public |
                BindingFlags.Instance |
                BindingFlags.Static |
                BindingFlags.NonPublic |
                BindingFlags.FlattenHierarchy);

            foreach (FieldInfo field in fields)
            {
                //< Age > k__BackingField = 21
                //< FirstName > k__BackingField = Sundus
                //_privateField = Hello
                //company = Microsoft
                Console.WriteLine("{0} = {1}", field.Name, field.GetValue(personobj));
            }

            Type personsetprivate = typeof(Person);

            var setvalue = personsetprivate.GetField("_privateField", BindingFlags.NonPublic | BindingFlags.Instance);
            setvalue.SetValue(personobj, "My New Value");

            //Private Field Value: My New Value
            Console.WriteLine(string.Format("Private Field Value: {0}", personobj.PrivateField));

            Console.ReadKey();
        }
    }
}
