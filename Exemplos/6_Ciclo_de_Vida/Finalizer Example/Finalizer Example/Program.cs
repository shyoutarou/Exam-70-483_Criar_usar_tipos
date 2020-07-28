using System;
using System.IO;

namespace Finalizer_Example
{



    public class SomeType
    {
        ~SomeType()
        {
            // This code is called when the finalize method executes
        }
    }

    public interface IDisposable
    {
        void Dispose();
    }

    class Program
    {

        static void Main(string[] args)
        {


            using (StreamWriter sw = File.CreateText("temp.dat")) { }
            StreamWriter stream = File.CreateText("temp.dat");
            stream.Write("some data");
            File.Delete("temp.dat"); // Throws an IOException because the file is already open.

            stream.Dispose();

            GC.Collect();
            GC.WaitForPendingFinalizers();
            File.Delete("temp.dat");

        }
    }
}
