using System;
using System.Collections.Generic;

namespace Creating_An_Interface
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public interface IStudent
    {
        // The student's list of current courses.
        List<string> Courses { get; set; }

        // Print the student's current grades.
        void PrintGrades();
    }

    public class Student : IStudent
    {
        // Implement IStudent.Courses.
        // The student's list of current courses.
        public List<string> Courses { get; set; }

        // Implement IStudent.PrintGrades.
        // Print the student's current grades.
        public void PrintGrades()
        {
            // Do whatever is necessary...
            Console.WriteLine("Student.PrintGrades");
        }
    }

    // Delegate IStudent to a Student object.
    public class TeachingAssistant2 : IStudent
    {
        // A Student object to handle IStudent.
        private Student MyStudent = new Student();

        public List<string> Courses
        {
            get { return MyStudent.Courses; }
            set { MyStudent.Courses = value; }
        }

        public void PrintGrades()
        {
            MyStudent.PrintGrades();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Machine1 m1 = new Machine1();
            Machine2 m2 = new Machine2();
            Machine3 m3 = new Machine3();

            m1.Start();
            m2.Start();
            m3.Start();

            ((IControls_2)m3).Start();

            Console.ReadKey();
        }
    }

    public class Machine1 : IControls
    {
        public void Start()
        {
            Console.WriteLine("Machine1...Start");
        }
    }

    public class Machine2 : Machine1
    {
        public void On()
        {
            Console.WriteLine("Machine2...On");
        }
    }

    public class Machine3 : IControls, IControls_2
    {
        public void Start()
        {
            Console.WriteLine("Implementation of IControls.Start()...");
        }

        int IControls_2.Start()
        {
            Console.WriteLine("Implementation of IControls_2.Start...");
            return 6;
        }
    }

    interface IControls
    {
        void Start();
    }

    interface IControls_2
    {
        int Start();
    }
}
