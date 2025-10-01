using System.Collections.Concurrent;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace CSharpDataStructuresExplorer.Benchmarks
{
    /// <summary>
    /// Benchmark: Dictionary vs ConcurrentDictionary add performance.
    /// </summary>
    [MemoryDiagnoser]
    public class DictionaryVsConcurrentDictionaryBenchmark
    {
        [Benchmark]
        public void DictionaryAdd()
        {
            System.Console.WriteLine("[Benchmark] ===== Dictionary Add =====");
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < 100; i++)
                dict[i] = i;
            System.Console.WriteLine("[Benchmark] Dictionary Add complete.");
        }

        [Benchmark]
        public void ConcurrentDictionaryAdd()
        {
            System.Console.WriteLine("[Benchmark] === ConcurrentDictionary Add ===");
            var concurrentDict = new ConcurrentDictionary<int, int>();
            for (int i = 0; i < 100; i++)
                concurrentDict[i] = i;
            System.Console.WriteLine("[Benchmark] ConcurrentDictionary Add complete.");
        }
    }
}
