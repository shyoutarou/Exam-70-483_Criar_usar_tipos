using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading
{
    class Distance_Unitary
    {
        public int meter { get; set; }
        public static Distance_Unitary operator ++(Distance_Unitary dis)
        {
            dis.meter += 1;
            return dis;
        }
    }

    class Student_Binary
    {
        public int Marks { get; set; }
        // + Operator Overloading Method
        public static Student_Binary operator +(Student_Binary s1, Student_Binary s2)
        {
            Student_Binary std = new Student_Binary();
            std.Marks = s1.Marks + s2.Marks;
            return std;
        }
    }

    class Distance_Compare
    {
        public int meter { get; set; }
        public static bool operator <(Distance_Compare d1, Distance_Compare d2)
        {
            return (d1.meter < d2.meter);
        }
        public static bool operator >(Distance_Compare d1, Distance_Compare d2)
        {
            return (d1.meter > d2.meter);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Distance_Unitary distance = new Distance_Unitary();
            distance.meter = 5;
            distance++;
            Console.WriteLine(distance.meter); // 6


            Student_Binary s1 = new Student_Binary { Marks = 10 };
            Student_Binary s2 = new Student_Binary { Marks = 20 };
            Student_Binary s3 = s1 + s2;
            Console.WriteLine(s3.Marks); // 30

            Distance_Compare d1 = new Distance_Compare { meter = 10 };
            Distance_Compare d2 = new Distance_Compare { meter = 20 };
            if (d1 < d2) Console.WriteLine("d1 is less than d2");
            else if (d2 < d1) Console.WriteLine("d2 is less than d1");

            Console.ReadKey();
        }
    }
}
