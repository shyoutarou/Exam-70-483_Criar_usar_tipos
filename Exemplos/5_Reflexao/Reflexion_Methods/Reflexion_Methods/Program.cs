using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflexion_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assembly myAssembly = Assembly.GetExecutingAssembly();
            Assembly myAssembly = Assembly.Load("System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089");
            //Assembly myAssembly = Assembly.Load("System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089");

            //DataTable dt = (DataTable)myAssembly.CreateInstance("System.Data.DataTable");
            var DLL_type = from type in myAssembly.GetTypes()
                           select type;

            foreach (Type pluginType in DLL_type)
            {
                //var dt = myAssembly.CreateInstance(pluginType);

                var dt = Activator.CreateInstance(pluginType);

                if (dt != null)
                {
                    if (dt is DataTable)
                    {
                        dt = dt as DataTable; 
                        Console.WriteLine("Number of rows: {0}", dt);
                    }
                }
            }






            Type[] myAssemblysTypes = myAssembly.GetTypes();

            foreach (Type myType in myAssemblysTypes)
            {
                Debug.WriteLine(string.Format("myType Name: {0}", myType.Name));
                Console.WriteLine(string.Format("myType Name: {0}", myType.Name));
            }


            Module[] myAssemblysModules = myAssembly.GetModules();

            foreach (Module myModule in myAssemblysModules)
            {
                Debug.WriteLine(string.Format("myModule Name: {0}", myModule.Name));
                Console.WriteLine(string.Format("myModule Name: {0}", myModule.Name));
            }

            Console.ReadKey();
        }
    }
}
