using System;
using System.Collections.Generic;

namespace CSharpDataStructuresExplorer.DataStructures
{
    /// <summary>
    /// LinkedList<T> demo: node-based structure, pros and cons, usage examples.
    /// </summary>
    public class LinkedListDemo
    {
        public static void Run()
        {
            Console.WriteLine("================= LINKEDLIST DEMO ==================");
            Console.WriteLine("[LinkedListDemo] Step 1: Initializing linked list");
            // Create LinkedList
            var linkedList = new LinkedList<int>();
            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            Console.WriteLine("[LinkedListDemo] Initial list: " + string.Join(", ", linkedList));

            Console.WriteLine("[LinkedListDemo] Step 2: Adding 0 to beginning");
            // Add to beginning/end
            linkedList.AddFirst(0);
            Console.WriteLine("[LinkedListDemo] List after add: " + string.Join(", ", linkedList));

            Console.WriteLine("[LinkedListDemo] Step 3: Removing 2");
            // Remove element
            linkedList.Remove(2);
            Console.WriteLine("[LinkedListDemo] List after remove: " + string.Join(", ", linkedList));

            Console.WriteLine("[LinkedListDemo] Step 4: Pros and Cons");
            // Pros and cons
            Console.WriteLine("[LinkedListDemo] Pros: Easy insert/remove, node-based structure.");
            Console.WriteLine("[LinkedListDemo] Cons: Slow random access, higher memory usage.");
            Console.WriteLine("=============== END LINKEDLIST DEMO =================\n");
        }
    }
}
