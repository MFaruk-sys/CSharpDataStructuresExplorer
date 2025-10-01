using System;
using System.Collections.Generic;

namespace CSharpDataStructuresExplorer.DataStructures
{
    /// <summary>
    /// SortedDictionary<TKey, TValue> demo: ordered key-value pairs, pros and cons, usage examples.
    /// </summary>
    public class SortedDictionaryDemo
    {
        public static void Run()
        {
            Console.WriteLine("============= SORTEDDICTIONARY DEMO ================");
            Console.WriteLine("[SortedDictionaryDemo] Step 1: Initializing sorted dictionary");
            // Create SortedDictionary
            var sortedDict = new SortedDictionary<int, string>
            {
                { 3, "three" },
                { 1, "one" },
                { 2, "two" }
            };
            Console.WriteLine("[SortedDictionaryDemo] Initial dictionary:");
            foreach (var kvp in sortedDict)
                Console.WriteLine($"[SortedDictionaryDemo] {kvp.Key}: {kvp.Value}");

            Console.WriteLine("[SortedDictionaryDemo] Step 2: Adding 4");
            // Add element
            sortedDict[4] = "four";
            Console.WriteLine("[SortedDictionaryDemo] Dictionary after add:");
            foreach (var kvp in sortedDict)
                Console.WriteLine($"[SortedDictionaryDemo] {kvp.Key}: {kvp.Value}");

            Console.WriteLine("[SortedDictionaryDemo] Step 3: Pros and Cons");
            // Pros and cons
            Console.WriteLine("[SortedDictionaryDemo] Pros: Keys are ordered, fast lookup.");
            Console.WriteLine("[SortedDictionaryDemo] Cons: Insert/remove may be slower than Dictionary.");
            Console.WriteLine("============ END SORTEDDICTIONARY DEMO =============\n");
        }
    }
}
