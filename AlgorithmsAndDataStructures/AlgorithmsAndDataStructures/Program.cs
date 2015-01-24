using System;
using AlgorithmsAndDataStructures.LinkedList;

namespace AlgorithmsAndDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            

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
