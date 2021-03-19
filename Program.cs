using System;
using System.Collections.Generic;
namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            /*// Test with a non-empty list of integers.
            GenericList<int> gll = new GenericList<int>();
            gll.AddNode(5);
            gll.AddNode(4);
            gll.AddNode(3);
            Console.WriteLine(gll.IndexOf(4));
            Console.WriteLine(gll.IndexOf(5));
            Console.WriteLine(gll.IndexOf(3));
            Console.WriteLine(gll.Remove(5));
            Console.WriteLine(gll.Contains(5));
            Console.WriteLine(gll.IndexOf(5));
            Console.WriteLine(gll.count);
            //int intVal = gll.GetFirstAdded();
            // The following line displays 5.
            // Console.WriteLine(intVal);*/
            int[] a = { 8, 3, 10, 1, 6, 5, 18, 7, 12 };
            Tree gll = new Tree(a);
            Console.WriteLine(gll.BinarySearch(3));
            Console.WriteLine(gll.BinarySearch(1));
            Console.WriteLine(gll.BinarySearch(12));
            Console.WriteLine(gll.BinarySearch(8));
            Console.WriteLine(gll.BinarySearch(17));
            Console.WriteLine(gll.BinarySearch(9));
            Console.WriteLine(gll.BinarySearch(4));
            var adjMatrixGraph = new Graph(9, false);
            adjMatrixGraph.AddEdge(0, 8);
            adjMatrixGraph.AddEdge(0, 3);
            adjMatrixGraph.AddEdge(8, 4);
            var adjacent = adjMatrixGraph.GetAdjacentVertices(0);
            foreach (int i in adjacent) Console.WriteLine(i);
        }
    }
}
