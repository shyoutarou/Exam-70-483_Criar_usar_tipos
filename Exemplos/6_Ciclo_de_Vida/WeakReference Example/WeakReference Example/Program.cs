using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace WeakReference_Example
{
    class Program
    {

        static WeakReference _weak;
        static WeakReference _weak_list;
        static void Main(string[] args)
        {
            _weak = new WeakReference(new StringBuilder("perls"));

            // See if weak reference is alive.
            if (_weak.IsAlive)
                Console.WriteLine((_weak.Target as StringBuilder).ToString());

            // Invoke GC.Collect.
            GC.Collect();

            // Check alive.
            if (_weak.IsAlive)
            {
                Console.Write("stillAlive: ");
                Console.WriteLine((_weak.Target as StringBuilder).ToString());
            }






            //// Create the cache.
            //int cacheSize = 50;
            //Random r = new Random();
            //Cache c = new Cache(cacheSize);

            //string DataName = "";
            //GC.Collect(0);

            //// Randomly access objects in the cache.
            //for (int i = 0; i < c.Count; i++)
            //{
            //    int index = r.Next(c.Count);

            //    // Access the object by getting a property value.
            //    DataName = c[index].Name;
            //}
            //// Show results.
            //double regenPercent = c.RegenerationCount / (double)c.Count;
            //Console.WriteLine("Cache size: {0}, Regenerated: {1:P2}%", c.Count, regenPercent);



            Run();


            Console.ReadKey();
        }


        public static void Run()
        {

            object result = GetData();

            // Check alive.
            if (_weak_list.IsAlive)
            {
                foreach (int num in result as IEnumerable<int>)
                {
                    Console.WriteLine(num);
                }
            }

            //Uncommenting this line will make data.Target null
            GC.Collect();
            GC.WaitForPendingFinalizers();
            //Thread.Sleep(100000);

            result = GetData();

            // Check alive.
            if (_weak_list.IsAlive)
            {
                foreach (int num in result as IEnumerable<int>)
                {
                    Console.WriteLine(num);
                }
            }
        }

        private static object GetData()
        {
            if (_weak_list == null)
            {
                _weak_list = new WeakReference(LoadLargeList());
            }
            if (_weak_list.Target == null)
            {
                _weak_list.Target = LoadLargeList();
            }
            return _weak_list.Target;
        }

        private static object LoadLargeList()
        {
            IEnumerable<int> squares = Enumerable.Range(1, 10).Select(x => x * x);

            return squares;
        }

        public class Cache
        {
            // Dictionary to contain the cache.
            static Dictionary<int, WeakReference> _cache;

            // Track the number of times an object is regenerated.
            int regenCount = 0;

            public Cache(int count)
            {
                _cache = new Dictionary<int, WeakReference>();

                // Add objects with a short weak reference to the cache.
                for (int i = 0; i < count; i++)
                {
                    _cache.Add(i, new WeakReference(new Data(i), false));
                }
            }

            // Number of items in the cache.
            public int Count
            {
                get { return _cache.Count; }
            }

            // Number of times an object needs to be regenerated.
            public int RegenerationCount
            {
                get { return regenCount; }
            }

            // Retrieve a data object from the cache.
            public Data this[int index]
            {
                get
                {
                    Data d = _cache[index].Target as Data;
                    if (d == null)
                    {
                        // If the object was reclaimed, generate a new one.
                        Console.WriteLine("Regenerate object at {0}: Yes", index);
                        d = new Data(index);
                        _cache[index].Target = d;
                        regenCount++;
                    }
                    else
                    {
                        // Object was obtained with the weak reference.
                        Console.WriteLine("Regenerate object at {0}: No", index);
                    }

                    return d;
                }
            }
        }

        // This class creates byte arrays to simulate data.
        public class Data
        {
            private byte[] _data;
            private string _name;

            public Data(int size)
            {
                _data = new byte[size * 1024];
                _name = size.ToString();
            }

            // Simple property.
            public string Name
            {
                get { return _name; }
            }
        }
    }
}
