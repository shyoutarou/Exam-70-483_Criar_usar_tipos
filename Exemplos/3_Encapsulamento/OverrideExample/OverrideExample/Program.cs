using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient p = new Patient();
            p.Examine();  

            Adult a = new Adult();
            a.Examine();

            Child c = new Child();
            c.Examine();

            Patient pa = new Adult();
            pa.Examine();

            Patient pc = new Child();
            pc.Examine();

            Console.ReadKey();
        }
    }

    public class Patient
    {
        public virtual void Examine()
        {
            Console.WriteLine("The patiente has been examinad...");
        }
    }

    public class Adult : Patient
    {
        public void Examine()
        {
            Console.WriteLine("The adult has been examinad...");
        }
    }

    public class Child : Patient
    {
        public override void Examine()
        {
            Console.WriteLine("The child has been examinad...");
        }
    }
}
