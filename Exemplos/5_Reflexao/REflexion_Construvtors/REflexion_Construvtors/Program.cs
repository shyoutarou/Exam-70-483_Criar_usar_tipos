using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace REflexion_Construvtors
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable myDataTable = new DataTable();
            Type myDataTableType = myDataTable.GetType();
            ConstructorInfo[] myDataTableConstructors = myDataTableType.GetConstructors();

            for (int i = 0; i <= myDataTableConstructors.Length - 1; i++)
            {
                ConstructorInfo constructorInfo = myDataTableConstructors[i];
                Debug.Print(string.Format("\nConstructor #{0}", i + 1));
                Console.WriteLine(string.Format("\nConstructor #{0}", i + 1));

                ParameterInfo[] parameters = constructorInfo.GetParameters();
                Debug.Print(string.Format("Number Of Parameters: {0}", parameters.Length));
                Console.WriteLine(string.Format("Number Of Parameters: {0}", parameters.Length));

                foreach (ParameterInfo parameter in parameters)
                {
                    Debug.Print(string.Format("Parameter Name: {0}", parameter.Name));
                    Debug.Print(string.Format("Parameter Type: {0}", parameter.ParameterType.Name));

                    Console.WriteLine(string.Format("Parameter Name: {0}", parameter.Name));
                    Console.WriteLine(string.Format("Parameter Type: {0}", parameter.ParameterType.Name));
                }
            }

            Console.ReadKey();
        }
    }
}
