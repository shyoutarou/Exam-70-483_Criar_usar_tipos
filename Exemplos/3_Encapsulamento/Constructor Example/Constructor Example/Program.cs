	using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Example
{
    class Program
    {
        static void Main(string[] args)
        {

            AddConstructor ac = new AddConstructor();
           
            
        }
    }


    public class DefConstructor
    {
        public void DoThis()
        {
            Console.WriteLine("DoThis has run...");
        }
    }

    public class AddConstructor
    {
        public AddConstructor()
        {
            // This executes every time a new object is instantiated from this class
            Console.WriteLine("The constructor has been called...");
            
            // You can call a method automatically when an object is created
            // using this class...

            // DoThis();
        }

        public void DoThis()
        {
            Console.WriteLine("DoThis has run...");
        }

        
        
    }

    



}
