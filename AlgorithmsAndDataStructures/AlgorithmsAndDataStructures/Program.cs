using System;
using AlgorithmsAndDataStructures.LinkedList;

namespace AlgorithmsAndDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            // AT FIRST USE THE .NET FRAMEWORK LINKEDLIST CLASS
            System.Collections.Generic.LinkedList<int> list = new System.Collections.Generic.LinkedList<int>();
            list.AddLast(3);
            list.AddLast(5);
            list.AddLast(7);

            foreach (var value in list)
            {
                Console.WriteLine(value);
            }

            // +-----+------+
            // |  3  | null +
            // +-----+------+
            Node first = new Node {Value = 3};

            // +-----+------+
            // |  5  | null +
            // +-----+------+
            Node middle = new Node() {Value = 5};

            // +-----+------+    +-----+------+
            // |  3  |  *---+--->|  5  | null +
            // +-----+------+    +-----+------+
            first.Next = middle;

            // +-----+------+    +-----+------+   +-----+------+
            // |  3  |  *---+--->|  5  | null +   |  7  | null +
            // +-----+------+    +-----+------+   +-----+------+
            Node last = new Node{Value = 7};

            // +-----+------+    +-----+------+   +-----+------+
            // |  3  |  *---+--->|  5  |  *---+-->|  7  | null +
            // +-----+------+    +-----+------+   +-----+------+ 
             middle.Next = last;   
            PrintList(first);
        }

        private static void PrintList(Node firstNode)
        {
            while (firstNode != null)
            {
                Console.WriteLine(firstNode.Value);
                firstNode = firstNode.Next;
            }
        }
    }
}
