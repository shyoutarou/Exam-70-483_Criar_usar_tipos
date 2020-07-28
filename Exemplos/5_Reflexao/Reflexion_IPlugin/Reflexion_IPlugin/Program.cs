using System;
using System.Linq;
using System.Reflection;

namespace Reflexion_IPlugin
{
    class A { public int Random { get; set; } }
    class B : A { }

    class Program
    {
        public interface IPlugin
        {
            string Name { get; }
            string Description { get; }
            bool Load(Program application);
        }

        public class MyPlugin : IPlugin
        {
            public string Name
            {
                get { return "MyPlugin"; }
            }
            public string Description
            {
                get { return "My Sample Plugin"; }
            }
            public bool Load(Program application)
            {
                return true;
            }
        }

        static void Main(string[] args)
        {
            //Get current loaded assembly
            Assembly assembly = Assembly.GetExecutingAssembly();
            Assembly pluginAssembly = Assembly.Load("Reflexion_IPlugin");

            Console.WriteLine(assembly.FullName == pluginAssembly.FullName);// True

            var DLL_type = from type in assembly.GetTypes()
                           where typeof(IPlugin).IsAssignableFrom(type) && !type.IsInterface
                           select type;

            foreach (Type pluginType in DLL_type)
            {
                IPlugin plugin = Activator.CreateInstance(pluginType) as IPlugin;

                if (plugin != null)
                    Console.WriteLine(plugin.Name + " - " + plugin.Description); // MyPlugin - My Sample Plugin
            }

            Console.ReadKey();
        }
    }
}
