using System;
using System.Diagnostics;
using System.Reflection;

namespace Reflection_DemoAssembly
{
    class A { public int Random { get; set; } }
    class B : A { }

    class Program
    {
        public int Age { get; set; }
        public string Name { get; set; }

        static void Main(string[] args)
        {
            //Get current loaded assembly
            Assembly assembly = Assembly.GetExecutingAssembly();
            //Get Full Name of the current Assembly
            string assemblyName = assembly.FullName;

            //Getall types defined in an assembly
            Type[] types = assembly.GetTypes();
            //Get information of each type
            foreach (Type type in types)
            {
                //Return name of a type and its base type
                Console.WriteLine("Type Name:{0}, Base Type:{1}", type.Name, type.BaseType);

                Lista_Propriedades(type);

                Lista_Metodos(type);

                Lista_Construtores(type);
            }

            AssemblyName[] referencedAssemblyNames = assembly.GetReferencedAssemblies();

            foreach (AssemblyName assemblyRef in referencedAssemblyNames)
            {
                Debug.WriteLine(string.Format("Assembly Name: {0}", assemblyRef.Name));
                Debug.WriteLine(string.Format("Assembly Version: {0}", assemblyRef.Version));

                Console.WriteLine(string.Format("Assembly Name: {0}", assemblyRef.Name));
                Console.WriteLine(string.Format("Assembly Version: {0}", assemblyRef.Version));

                //Assembly Name: mscorlib
                //Assembly Version: 4.0.0.0
                //Assembly Name: System
                //Assembly Version: 4.0.0.0
            }

            //Reflection_DemoAssembly, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
            Console.WriteLine(assemblyName);
            Console.ReadKey();
        }

        public void Show() { }
        public int SqRoot(int i)
        {
            return (i * i);
        }

        public static void Lista_Propriedades(Type type)
        {
            //Get all properties defined in a type
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine("\t{0} has {1} type",
                property.Name, property.PropertyType);
            }
        }

        public static void Lista_Metodos(Type type)
        {
            //Get all non-static methods of a type
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine("\tMethod Name:{0}, Return Type:{1}",

                method.Name, method.ReturnType);
            }
        }

        public static void Lista_Construtores(Type type)
        {
            //Get all non-static constructors of a type
            ConstructorInfo[] myDataTableConstructors = type.GetConstructors();

            if (myDataTableConstructors.Length > 1)
            {
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
            }
        }
    }
}
