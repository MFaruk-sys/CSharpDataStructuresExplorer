using System;
using System.Collections.Generic;

namespace CSharpDataStructuresExplorer.DataStructures
{
    /// <summary>
    /// List<T> demo: dynamic array, pros and cons, and usage examples.
    /// </summary>
    public class ListDemo
    {
        public static void Run()
        {
            Console.WriteLine("==================== LIST DEMO =====================");
            Console.WriteLine("[ListDemo] Step 1: Initializing list");
            var names = new List<string> { "Alice", "Bob", "Charlie" };
            Console.WriteLine("[ListDemo] Initial list: " + string.Join(", ", names));

            Console.WriteLine("[ListDemo] Step 2: Adding 'Diana'");
            names.Add("Diana");
            Console.WriteLine("[ListDemo] List after add: " + string.Join(", ", names));

            Console.WriteLine("[ListDemo] Step 3: Removing 'Bob'");
            names.Remove("Bob");
            Console.WriteLine("[ListDemo] List after remove: " + string.Join(", ", names));

            Console.WriteLine("[ListDemo] Step 4: Pros and Cons");
            Console.WriteLine("[ListDemo] Pros: Dynamic size, easy add/remove.");
            Console.WriteLine("[ListDemo] Cons: Insert/remove can be slow for large lists.");
            Console.WriteLine("================== END LIST DEMO ===================\n");
        }
    }
}
