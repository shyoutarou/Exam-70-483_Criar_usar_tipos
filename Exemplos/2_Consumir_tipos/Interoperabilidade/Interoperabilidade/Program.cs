using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Interoperabilidade
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the long file name.
            string longName = @"C:\Users\RICARDO\Documents";
            // Allocate a buffer to hold the result.
            //char[] buffer = new char[1024];
            //Com  MarshalAs, StringBuilder
            var shortName = new StringBuilder();
            long length = GetShortPathName(longName, shortName, 1024);

            // Get the short name.
            //string shortName = sb;
            Console.WriteLine(shortName); // C:\Users\RICARDO\DOCUME~1

            //shortName = shortName.Substring(0, (int)length);
            //Console.WriteLine(shortName);// C:\Users\RICARDO\DOCUME~1

            Console.ReadKey();
        }

        //[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        //static extern uint GetShortPathName(string lpszLongPath, char[] lpszShortPath, int cchBuffer);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern uint GetShortPathName([MarshalAs(UnmanagedType.LPTStr)] string lpszLongPath,
            [MarshalAs(UnmanagedType.LPTStr)] StringBuilder lpszShortPath, uint cchBuffer);
    }
}
