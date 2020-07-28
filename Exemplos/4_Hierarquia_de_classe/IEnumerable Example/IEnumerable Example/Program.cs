using System;
using System.Collections;

namespace IEnumerable_Example
{
    class myArrayList : IEnumerable
    {
        object[] array = new object[4];
        int index = -1;
        public void Add(object o)
        {
            if (++index < array.Length)
            {
                array[index] = o;
            }
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return array[i];
            }
        }
    }

    // Let's create a class with an indexer
    public class Index_ComYield : IEnumerable
    {
        string[] car = new string[3];

        public string this[int carNum]
        {
            get { return car[carNum]; }
            set { car[carNum] = value; }
        }

        // This is our enumerator It implments the IEnumerable interface
        public IEnumerator GetEnumerator()
        {
            foreach (string c in car)
            {
                yield return c;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            myArrayList list = new myArrayList();
            //stores object data in myArraylist
            list.Add("Ali");
            list.Add(22);
            list.Add("Sundus");
            list.Add(21);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Index_ComYield c = new Index_ComYield();
            c[0] = "Chevrolet";
            c[1] = "Mercedes";
            c[2] = "Dodge";

            // Se a classe Index_ComYield não implemntar IEnumerable
            // com o método GetEnumerator Dá erro no foreach
            foreach (string car in c)
            {
                Console.WriteLine(car);
            }

            Console.ReadKey();
        }
    }
}
