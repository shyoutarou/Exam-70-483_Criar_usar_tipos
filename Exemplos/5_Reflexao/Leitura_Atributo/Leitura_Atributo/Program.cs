using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Leitura_Atributo
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            AssemblyName[] assemblyNames = assembly.GetReferencedAssemblies();

            foreach (AssemblyName assemblyName in assemblyNames)
            {
                Debug.WriteLine(string.Format("\nAssembly Name: {0}", assemblyName.FullName));
                Console.WriteLine(string.Format("\nAssembly Name: {0}", assemblyName.FullName));

                Assembly referencedAssembly = Assembly.Load(assemblyName.FullName);

                object[] attributes = referencedAssembly.GetCustomAttributes(false);

                foreach (object attribute in attributes)
                {
                    Debug.WriteLine(string.Format("\nAttribute Name: {0}", attribute.GetType().Name));
                    Console.WriteLine(string.Format("\nAttribute Name: {0}", attribute.GetType().Name));
                    //Get the properties of this attribute
                    PropertyInfo[] properties = attribute.GetType().GetProperties();

                    foreach (PropertyInfo property in properties)
                    {
                        Debug.WriteLine(string.Format("{0} : {1}", property.Name, property.GetValue(attribute)));
                        Console.WriteLine(string.Format("{0} : {1}", property.Name, property.GetValue(attribute)));
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
