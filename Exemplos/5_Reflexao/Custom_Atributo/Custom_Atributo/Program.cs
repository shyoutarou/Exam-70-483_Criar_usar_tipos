using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Atributo
{
    [System.AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    class MyCustomAttribute : System.Attribute
    {
        public enum MyCustomAttributeEnum
        {
            Red,
            White,
            Blue
        }

        public bool Property1 { get; set; }
        public string Property2 { get; set; }
        public MyCustomAttributeEnum Property3 { get; set; }
    }

    [MyCustom(Property1 = true, Property2 = "Hello World", Property3 = MyCustomAttribute.MyCustomAttributeEnum.Red)]
    class MyTestClass
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            Type myTestClassType = typeof(MyTestClass);

            MyCustomAttribute attribute = (MyCustomAttribute)myTestClassType.GetCustomAttribute(typeof(MyCustomAttribute), false);

            Console.WriteLine(string.Format("Property1: {0}", attribute.Property1)); //Property1: True
            Console.WriteLine(string.Format("Property2: {0}", attribute.Property2)); //Property2: Hello World
            Console.WriteLine(string.Format("Property3: {0}", attribute.Property3)); //Property3: Red
            Console.ReadKey();
        }
    }
}
