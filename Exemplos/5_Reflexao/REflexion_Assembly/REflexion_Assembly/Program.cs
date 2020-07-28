using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace REflexion_Assembly
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Get current loaded assembly
            //Assembly assembly = Assembly.GetExecutingAssembly();
            ////Get Full Name of the current Assembly
            //string assemblyName = assembly.FullName;

            Assembly myAssembly = Assembly.Load("System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089");

            Debug.WriteLine(string.Format("CodeBase: {0}", myAssembly.CodeBase));
            Debug.WriteLine(string.Format("FullName: {0}", myAssembly.FullName));
            Debug.WriteLine(string.Format("GlobalAssemblyCache: {0}", myAssembly.GlobalAssemblyCache));
            Debug.WriteLine(string.Format("ImageRuntimeVersion: {0}", myAssembly.ImageRuntimeVersion));
            Debug.WriteLine(string.Format("Location: {0}", myAssembly.Location));

            Console.WriteLine(string.Format("CodeBase: {0}", myAssembly.CodeBase));
            Console.WriteLine(string.Format("FullName: {0}", myAssembly.FullName));
            Console.WriteLine(string.Format("GlobalAssemblyCache: {0}", myAssembly.GlobalAssemblyCache));
            Console.WriteLine(string.Format("ImageRuntimeVersion: {0}", myAssembly.ImageRuntimeVersion));
            Console.WriteLine(string.Format("Location: {0}", myAssembly.Location));

            Console.ReadKey();
        }
    }
}
