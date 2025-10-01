using System;
using System.Collections.Generic;

namespace CSharpDataStructuresExplorer.Comparisons
{
    /// <summary>
    /// Compare HashSet<T> vs List<T> in C#.
    /// </summary>
    public class HashSetVsList
    {
        public static void Run()
        {
            Console.WriteLine("=============== HASHSET VS LIST =====================");
            var list = new List<int> { 1, 2, 2, 3 };
            var hashSet = new HashSet<int> { 1, 2, 2, 3 };

            Console.WriteLine("[Comparison] Step 1: Initial values");
            Console.WriteLine("[Comparison] List (duplicates allowed): " + string.Join(", ", list));
            Console.WriteLine("[Comparison] HashSet (unique only): " + string.Join(", ", hashSet));

            Console.WriteLine("[Comparison] Step 2: Notes");
            Console.WriteLine("[Comparison] List<T>: Allows duplicates, preserves order, best for index-based access.");
            Console.WriteLine("[Comparison] HashSet<T>: No duplicates, fast lookup, best for set operations.");
            Console.WriteLine("============= END HASHSET VS LIST ===================\n");
        }
    }
}
