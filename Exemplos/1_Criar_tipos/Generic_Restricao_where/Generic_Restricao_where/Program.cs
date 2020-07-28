using System;
using System.Collections.Generic;

namespace Generic_Restricao_where
{
    public class Base { }
    class Test<T, U>
        where U : struct
        where T : Base, new()
    { }

    class EmployeeList<T> where T : Employee, IEmployee, System.IComparable<T>, new()
    {
        // ...
    }

    public interface IEmployee { }

    public class Employee : IEmployee
    {
        public Employee() { }

        public Employee(string s, int i) { this.Name = s; this.ID = i; }
        public string Name { get; set; }
        public int ID { get; set; }
    }

    public class Customer : Base
    {
        public Customer(string customerName) { }
    }

    public class NodeListMult<T, U> where T : U
    {
        public void DoWork(T subClass, U baseClass)
        {
        }
    }

    public class NodeList<T>
    {
        private List<T> nodes;

        public NodeList()
        {
            this.nodes = new List<T>();
        }

        public void AddNode(T newNode)
        {
            nodes.Add(newNode);
        }

        public void DeleteNode(T nodeToRemove)
        {
            nodes.Remove(nodeToRemove);
        }

        public void ProcessAllNodes()
        {
            foreach (var node in nodes)
            {
                Console.WriteLine(node.ToString());
            }
        }
    }

    public class GenericList<T> where T : Employee
    {
        private class Node
        {
            public Node(T t) { this.Next = null; this.Data = t; }
            public Node Next { get; set; }
            public T Data { get; set; }
        }

        private Node head;

        public void AddHead(T t)
        {
            Node n = new Node(t) { Next = head };
            head = n;
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node current = head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public T FindFirstOccurrence(string s)
        {
            Node current = head;
            T t = null;

            while (current != null)
            {
                //The constraint enables access to the Name property.
                if (current.Data.Name == s)
                {
                    t = current.Data;
                    break;
                }
                else
                {
                    current = current.Next;
                }
            }
            return t;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            NodeListMult<Employee, IEmployee> employeeNodesmult = new NodeListMult<Employee, IEmployee>();
            NodeListMult<Customer, Base> employeeNodesbase = new NodeListMult<Customer, Base>();
            NodeListMult<Customer, Customer> employeeNodescust = new NodeListMult<Customer, Customer>();

            NodeList<Employee> employeeNodes = new NodeList<Employee>(); //No Error, as Emplyoee implements the IEmployee interface
            NodeList<Customer> customerNodes = new NodeList<Customer>(); //Error, as Customer does not implements the IEmployee interface

            NodeList<int> nodesOfInt = new NodeList<int>();
            nodesOfInt.AddNode(2);
            nodesOfInt.AddNode(4);
            nodesOfInt.AddNode(6);
            nodesOfInt.AddNode(7);
            nodesOfInt.DeleteNode(7);

            nodesOfInt.ProcessAllNodes();

            NodeList<string> nodesOfString = new NodeList<string>();
            nodesOfString.AddNode("Lory");
            nodesOfString.AddNode("Julia");
            nodesOfString.AddNode("Lerman");
            nodesOfString.AddNode("James");

            nodesOfString.ProcessAllNodes();

            Console.ReadKey();
        }
    }
}
