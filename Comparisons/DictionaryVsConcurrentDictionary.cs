using System;
using System.Collections.Concurrent;
using System.Collections.Generic;

namespace CSharpDataStructuresExplorer.Comparisons
{
    /// <summary>
    /// Compare Dictionary<TKey, TValue> vs ConcurrentDictionary<TKey, TValue>.
    /// </summary>
    public class DictionaryVsConcurrentDictionary
    {
        public static void Run()
        {
            Console.WriteLine("========== DICTIONARY VS CONCURRENTDICTIONARY ==========");
            var dict = new Dictionary<string, int>();
            var concurrentDict = new ConcurrentDictionary<string, int>();

            Console.WriteLine("[Comparison] Step 1: Adding key 'A' to both");
            dict["A"] = 1;
            concurrentDict["A"] = 1;

            Console.WriteLine($"[Comparison] Dictionary['A']: {dict["A"]}");
            Console.WriteLine($"[Comparison] ConcurrentDictionary['A']: {concurrentDict["A"]}");

            Console.WriteLine("[Comparison] Step 2: Thread safety notes");
            Console.WriteLine("[Comparison] Dictionary is NOT thread-safe.");
            Console.WriteLine("[Comparison] ConcurrentDictionary is thread-safe and suitable for multi-threaded scenarios.");
            Console.WriteLine("======= END DICTIONARY VS CONCURRENTDICTIONARY =======\n");
        }
    }
}
