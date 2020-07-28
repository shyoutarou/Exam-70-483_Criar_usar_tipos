using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serializable_Atributo
{
    [Serializable]
    class Person
    {
        public string Name { get; set; }
        public int Idade { get; set; }
        public double Altura { get; set; }

        // A field that is not serialized.
        [NonSerialized()] public string Endereco;

        public Person()
        {
            Name = "Bob";
            Idade = 11;
            Altura = 1.74159265;
            Endereco = "Avenida Brasil";
        }

        public void Print()
        {
            Console.WriteLine("Name = '{0}'", Name);
            Console.WriteLine("Idade = '{0}'", Idade);
            Console.WriteLine("Altura = '{0}'", Altura);
            Console.WriteLine("NonSerialized Endereco = '{0}'", Endereco);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creates a new TestSimpleObject object.
            Person obj = new Person();

            Console.WriteLine("Before serialization the object contains: ");
            obj.Print();

            // Opens a file and serializes the object into it in binary format.
            Stream stream = File.Open("data.xml", FileMode.Create);

            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
            stream.Close();

            // Empties obj.
            obj = null;

            // Opens file "data.xml" and deserializes the object from it.
            stream = File.Open("data.xml", FileMode.Open);
            formatter = new BinaryFormatter();

            obj = (Person)formatter.Deserialize(stream);
            stream.Close();

            Console.WriteLine("");
            Console.WriteLine("After deserialization the object contains: ");
            obj.Print();

            if (Attribute.IsDefined(typeof(Person), typeof(SerializableAttribute)))
            {
                Console.WriteLine("Attribute.IsDefined as SerializableAttribute");
            }

            //Before serialization the object contains:
            //Name = 'Bob'
            //Idade = '11'
            //Altura = '1,74159265'
            //NonSerialized Endereco = 'Avenida Brasil'

            //After deserialization the object contains:
            //Name = 'Bob'
            //Idade = '11'
            //Altura = '1,74159265'
            //NonSerialized Endereco = ''

            Console.ReadKey();
        }
    }
}
