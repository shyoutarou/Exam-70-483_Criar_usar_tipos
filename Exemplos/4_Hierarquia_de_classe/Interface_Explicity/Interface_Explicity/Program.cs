using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Explicity
{
    interface IEnglish
    {
        int Marks { get; }
    }
    interface IMath
    {
        int Marks { get; }
    }
    class Student : IEnglish, IMath
    {
        int english = 10;
        int math = 9;
        int IMath.Marks
        {
            get
            {
                return english;
            }
        }

        int IEnglish.Marks
        {
            get
            {
                return math;
            }
        }
    }


    interface ILeft
    {
        void Move();
    }
    interface IRight
    {
        void Move();
    }
    class MoveableOject : ILeft, IRight
    {
        void ILeft.Move() { }
        void IRight.Move() { }
    }


    interface IInterfaceA
    {
        void MyMethod();
    }
    class Implementation : IInterfaceA
    {
        void IInterfaceA.MyMethod() { }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Student std = new Student();
            int english = ((IEnglish)std).Marks;
            int math = ((IMath)std).Marks;
            // English Marks = 9 Math Marks = 10
            Console.WriteLine("English Marks = {0} Math Marks = {1}", english, math);

            Console.ReadKey();
        }
    }
}
