using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace CSharpDataStructuresExplorer.Comparisons
{
    /// <summary>
    /// Compare ImmutableList<T> vs List<T> in C#.
    /// </summary>
    public class ImmutableListVsList
    {
        public static void Run()
        {
            Console.WriteLine("=========== IMMUTABLELIST VS LIST ============");
            var list = new List<int> { 1, 2, 3 };
            var immutableList = ImmutableList.Create(1, 2, 3);

            Console.WriteLine("[Comparison] Step 1: Initial values");
            Console.WriteLine("[Comparison] List: " + string.Join(", ", list));
            Console.WriteLine("[Comparison] ImmutableList: " + string.Join(", ", immutableList));

            Console.WriteLine("[Comparison] Step 2: Adding 4");
            list.Add(4);
            var newImmutableList = immutableList.Add(4);
            Console.WriteLine("[Comparison] List after add: " + string.Join(", ", list));
            Console.WriteLine("[Comparison] ImmutableList after add: " + string.Join(", ", newImmutableList));

            Console.WriteLine("[Comparison] Step 3: Notes");
            Console.WriteLine("[Comparison] List<T>: Mutable, fast, best for frequent changes.");
            Console.WriteLine("[Comparison] ImmutableList<T>: Immutable, thread-safe, best for functional programming and concurrency.");
            Console.WriteLine("========== END IMMUTABLELIST VS LIST ===========\n");
        }
    }
}
