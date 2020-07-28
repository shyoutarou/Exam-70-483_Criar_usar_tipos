using System;
using System.Collections.Generic;

namespace Generic_Collections
{
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

    class Program
    {
        static void Main(string[] args)
        {
            NodeList<int> nodesOfInt = new NodeList<int>();
            nodesOfInt.AddNode(2);
            nodesOfInt.AddNode(4);
            nodesOfInt.AddNode(6);
            nodesOfInt.AddNode(7);
            nodesOfInt.DeleteNode(7);

            nodesOfInt.ProcessAllNodes(); //2   4   6

            NodeList<string> nodesOfString = new NodeList<string>();
            nodesOfString.AddNode("Lory");
            nodesOfString.AddNode("Julia");
            nodesOfString.AddNode("Lerman");
            nodesOfString.AddNode("James");

            nodesOfString.ProcessAllNodes(); //Lory   Julia   Julia   James

            Console.ReadKey();
        }
    }
}
