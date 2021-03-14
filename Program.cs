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
            char[] a = {'F','B','G','I','A','D','H','C','E'};
            Tree gll = new Tree(a);
            Console.WriteLine(gll.BinarySearch('f'));
            Console.WriteLine(gll.BinarySearch('F'));
            Console.WriteLine(gll.BinarySearch('T'));
            Console.WriteLine(gll.BinarySearch('H'));
            gll.Remove('B');
            Console.WriteLine(gll.BinarySearch('B'));
            gll.Inorder();
            Console.WriteLine();
            gll.Postorder();
            Console.WriteLine();
            gll.Preorder();
        }
    }
}
