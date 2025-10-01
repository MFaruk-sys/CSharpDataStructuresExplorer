using System;
using System.Collections.Generic;

namespace CSharpDataStructuresExplorer.Comparisons
{
    /// <summary>
    /// Compare List<T> vs LinkedList<T> in C#.
    /// </summary>
    public class ListVsLinkedList
    {
        public static void Run()
        {
            Console.WriteLine("=============== LIST VS LINKEDLIST ==================");
            var list = new List<int> { 1, 2, 3 };
            var linkedList = new LinkedList<int>();
            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);

            Console.WriteLine("[Comparison] Step 1: Initial values");
            Console.WriteLine("[Comparison] List: " + string.Join(", ", list));
            Console.WriteLine("[Comparison] LinkedList: " + string.Join(", ", linkedList));

            Console.WriteLine("[Comparison] Step 2: Notes");
            Console.WriteLine("[Comparison] List<T>: Fast random access, dynamic array, best for index-based operations.");
            Console.WriteLine("[Comparison] LinkedList<T>: Fast insert/remove at ends, best for frequent insert/remove, slow random access.");
            Console.WriteLine("============= END LIST VS LINKEDLIST ================\n");
        }
    }
}
