using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerator_Generic
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class myGenericList<T> : IEnumerable<T>
    {
        T[] list;
        int index = -1;
        public void Add(T obj)
        {
            if (++index < list.Length)
            {
                list[index] = obj;
            }
        }
        public IEnumerator<T> GetEnumerator()
        {
            return new TEnum<T>(list);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public myGenericList(int size)
        {
            list = new T[size];
        }
    }

    //Implement IEnumerator
    class TEnum<T> : IEnumerator<T>
    {
        T[] _list;
        int index = -1;
        public TEnum(T[] objs)
        {
            _list = objs;
        }
        //Return if foreach can iterate to next index or not
        public bool MoveNext()
        {
            return (++index < _list.Length);
        }
        public void Reset()
        {
            index = -1;
        }
        //Get type-safe value of current array's index
        //Its the Implementation of IEnumerator<T>
        public T Current
        {
            get
            {
                return _list[index];
            }
        }
        //It's the implementation of 'IEnumerator'
        object IEnumerator.Current
        {
            get
            {
                //return T Current
                return this.Current;
            }
        }

        // Example variable are used to implement Dispose() 
        bool m_disposed = false;
        IEnumerator<T> m_reader;
        bool m_downcountEnumerators;

        //It's the implementation of IDispose interface
        public void Dispose()
        {
            //Example of code to dispose un-needed resource
            if (!m_disposed)
            {
                // Only dispose the source enumerator if you are doing dynamic partitioning
                if (!m_downcountEnumerators)
                {
                    m_reader.Dispose();
                }
                m_disposed = true;
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            myGenericList<Person> people = new myGenericList<Person>(3);
            people.Add(new Person { Name = "Ali", Age = 22 });
            people.Add(new Person { Name = "Sundus", Age = 21 });
            people.Add(new Person { Name = "Hogi", Age = 12 });

            foreach (var item in people)
            {
                //No need to cast
                Console.WriteLine("Name:{0} Age:{1}", item.Name, item.Age);
            }
        }
    }
}
