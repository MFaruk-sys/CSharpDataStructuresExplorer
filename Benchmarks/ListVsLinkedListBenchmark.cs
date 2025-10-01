using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace CSharpDataStructuresExplorer.Benchmarks
{
    /// <summary>
    /// Benchmark: List<T> vs LinkedList<T> add/remove performance.
    /// </summary>
    [MemoryDiagnoser]
    public class ListVsLinkedListBenchmark
    {
        private List<int>? _list;
        private LinkedList<int>? _linkedList;

        [GlobalSetup]
        public void Setup()
        {
            _list = new List<int>();
            _linkedList = new LinkedList<int>();
        }

        [Benchmark]
        public void List_AddRemove()
        {
            // Caption for benchmark
            System.Console.WriteLine("[Benchmark] ===== List<T> Add/Remove =====");
            for (int i = 0; i < 100; i++)
                _list!.Add(i);
            for (int i = 0; i < 100; i++)
                _list!.Remove(i);
            System.Console.WriteLine("[Benchmark] List<T> Add/Remove complete.");
        }

        [Benchmark]
        public void LinkedList_AddRemove()
        {
            System.Console.WriteLine("[Benchmark] === LinkedList<T> Add/Remove ===");
            for (int i = 0; i < 100; i++)
                _linkedList!.AddLast(i);
            for (int i = 0; i < 100; i++)
                _linkedList!.Remove(i);
            System.Console.WriteLine("[Benchmark] LinkedList<T> Add/Remove complete.");
        }
    }
}
