using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Implementation_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Mark m = new Mark();
            m.DoThis();

            ((ISecond)m).DoThis();

            // To make it a little more readable
            // you could explicitly implement both interfaces
            ((IFirst)m).DoThis();
            ((ISecond)m).DoThis();
        }
    }

    interface IFirst
    {
        void DoThis();
    }

    interface ISecond
    {
        int DoThis();
    }

    public class Mark : IFirst, ISecond
    {
        public void DoThis()
        {
            Console.WriteLine("Implementation of IFirst.DoThis...");
        }

        int ISecond.DoThis()
        {
            Console.WriteLine("Implementation of ISecond.DoThis...");
            return 6;
        }

        public void Test()
        {
            // add code...
        }

    }
}
