using System;
using System.Collections.Generic;

namespace CSharpDataStructuresExplorer.DataStructures
{
    /// <summary>
    /// HashSet<T> demo: unique elements, set operations, pros and cons.
    /// </summary>
    public class HashSetDemo
    {
        public static void Run()
        {
            Console.WriteLine("=================== HASHSET DEMO ===================");
            Console.WriteLine("[HashSetDemo] Step 1: Initializing set");
            // Create a HashSet
            var set = new HashSet<int> { 1, 2, 3, 3, 4 };
            Console.WriteLine("[HashSetDemo] Initial set: " + string.Join(", ", set));

            Console.WriteLine("[HashSetDemo] Step 2: Adding 5");
            // Add an element
            set.Add(5);
            Console.WriteLine("[HashSetDemo] Set after add: " + string.Join(", ", set));

            Console.WriteLine("[HashSetDemo] Step 3: Intersecting with {3, 4, 5, 6}");
            // Intersection
            var otherSet = new HashSet<int> { 3, 4, 5, 6 };
            set.IntersectWith(otherSet);
            Console.WriteLine("[HashSetDemo] Set after intersection: " + string.Join(", ", set));

            Console.WriteLine("[HashSetDemo] Step 4: Pros and Cons");
            // Pros and cons
            Console.WriteLine("[HashSetDemo] Pros: Unique elements, fast lookup.");
            Console.WriteLine("[HashSetDemo] Cons: Not ordered, can use more memory.");
            Console.WriteLine("================ END HASHSET DEMO ==================\n");
        }
    }
}
