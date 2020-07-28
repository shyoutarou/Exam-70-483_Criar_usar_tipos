using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REflexion_Enum
{
    class Program
    {
        private enum MyCustomEnum { Red = 1, White = 2, Blue = 3 }

        static void Main(string[] args)
        {
            Type myCustomEnumType = typeof(MyCustomEnum);

            string[] enumNames = myCustomEnumType.GetEnumNames();

            foreach (string enumName in enumNames)
            {
                Debug.Print(string.Format("Name: {0}", enumName));
                Console.WriteLine(string.Format("Name: {0}", enumName));
            }

            Array enumValues = myCustomEnumType.GetEnumValues();
            foreach (object enumValue in enumValues)
            {
                Debug.Print(string.Format("Enum Value: {0}", enumValue.ToString()));
                Console.WriteLine(string.Format("Enum Value: {0}", enumValue.ToString()));
            }

            for (int i = 1; i <= 3; i++)
            {
                string enumName = myCustomEnumType.GetEnumName(i);
                Debug.Print(string.Format("{0}: {1}", enumName, i));
                Console.WriteLine(string.Format("{0}: {1}", enumName, i));
            }

            Console.ReadKey();
        }
    }
}
