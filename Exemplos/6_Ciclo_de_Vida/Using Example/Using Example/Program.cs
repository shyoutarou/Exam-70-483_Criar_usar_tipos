using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_Example
{
    class myClass : IDisposable
    {
        public StreamReader reader;
        public void Dispose()
        {
            //Cleanup unmanaged resources
            if (reader != null)
                reader.Dispose();
            GC.SuppressFinalize(this);
            Console.WriteLine("Disposed");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            using (myClass obj = new myClass()) { }
            Console.WriteLine("End");
        }
    }
}
