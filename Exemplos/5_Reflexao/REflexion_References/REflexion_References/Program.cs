using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace REflexion_References
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly myAssembly = Assembly.Load("System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089");

            AssemblyName[] referencedAssemblyNames = myAssembly.GetReferencedAssemblies();

            foreach (AssemblyName assemblyName in referencedAssemblyNames)
            {
                Debug.WriteLine(string.Format("Assembly Name: {0}", assemblyName.Name));
                Debug.WriteLine(string.Format("Assembly Version: {0}", assemblyName.Version));

                Console.WriteLine(string.Format("Assembly Name: {0}", assemblyName.Name));
                Console.WriteLine(string.Format("Assembly Version: {0}", assemblyName.Version));
            }

            Console.ReadKey();
        }
    }
}
