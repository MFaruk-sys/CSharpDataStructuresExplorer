using System;
using System.Collections.Generic;

namespace CSharpDataStructuresExplorer.DataStructures
{
    /// <summary>
    /// Dictionary<TKey, TValue> demo: key-value mapping, pros and cons, and usage examples.
    /// </summary>
    public class DictionaryDemo
    {
        public static void Run()
        {
            Console.WriteLine("================= DICTIONARY DEMO ==================");
            Console.WriteLine("[DictionaryDemo] Step 1: Initializing dictionary");
            // Create a dictionary
            var phoneBook = new Dictionary<string, string>
            {
                { "Alice", "555-1234" },
                { "Charlie", "555-5678" }
            };
            Console.WriteLine("[DictionaryDemo] Initial phone book:");
            foreach (var kvp in phoneBook)
                Console.WriteLine($"[DictionaryDemo] {kvp.Key}: {kvp.Value}");

            Console.WriteLine("[DictionaryDemo] Step 2: Adding Bob");
            // Add an entry
            phoneBook["Bob"] = "555-9999";
            Console.WriteLine("[DictionaryDemo] Phone book after add:");
            foreach (var kvp in phoneBook)
                Console.WriteLine($"[DictionaryDemo] {kvp.Key}: {kvp.Value}");

            Console.WriteLine("[DictionaryDemo] Step 3: Lookup Charlie");
            // Lookup by key
            if (phoneBook.TryGetValue("Charlie", out var charlieNum))
                Console.WriteLine($"[DictionaryDemo] Charlie's number: {charlieNum}");

            Console.WriteLine("[DictionaryDemo] Step 4: Pros and Cons");
            // Pros and cons
            Console.WriteLine("[DictionaryDemo] Pros: Fast lookup, key-value mapping.");
            Console.WriteLine("[DictionaryDemo] Cons: Not ordered, keys must be unique.");
            Console.WriteLine("=============== END DICTIONARY DEMO =================\n");
        }
    }
}
