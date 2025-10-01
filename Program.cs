using System;
using CSharpDataStructuresExplorer.DataStructures;
using CSharpDataStructuresExplorer.Comparisons;
using BenchmarkDotNet.Running;
using CSharpDataStructuresExplorer.Benchmarks;

namespace CSharpDataStructuresExplorer
{
    /// <summary>
    /// Main menu runner for all demos and comparisons.
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("C# Data Structures & Comparisons Explorer 🚀\n");
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Run All Benchmarks");
                Console.WriteLine("2. Run All Comparisons");
                Console.WriteLine("3. Run All Data Structure Demos");
                Console.WriteLine("0. Exit");

                Console.Write("Enter your choice: ");
                var input = Console.ReadLine();
                Console.WriteLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("--- Running All Benchmarks ---");
                        Console.WriteLine("(Benchmarks will run in separate processes)");
                        RunBenchmarks();
                        break;
                    case "2":
                        Console.WriteLine("--- Running All Comparisons ---");
                        RunAllComparisons();
                        break;
                    case "3":
                        Console.WriteLine("--- Running All Data Structure Demos ---");
                        RunAllDataStructureDemos();
                        break;
                    case "0":
                        Console.WriteLine("Exiting. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        private static void RunBenchmarks()
        {
            Console.WriteLine("[Benchmarks] Running ListVsLinkedListBenchmark...");
            BenchmarkRunner.Run<ListVsLinkedListBenchmark>();
            Console.WriteLine("[Benchmarks] Running DictionaryVsConcurrentDictionaryBenchmark...");
            BenchmarkRunner.Run<DictionaryVsConcurrentDictionaryBenchmark>();
            Console.WriteLine("[Benchmarks] Running StringBuilderVsStringConcatBenchmark...");
            BenchmarkRunner.Run<StringBuilderVsStringConcatBenchmark>();
            Console.WriteLine("[Benchmarks] Running StackVsQueueBenchmark...");
            BenchmarkRunner.Run<StackVsQueueBenchmark>();
        }

        private static void RunAllComparisons()
        {
            DictionaryVsConcurrentDictionary.Run();
            StructVsClassVsRecord.Run();
            SpanVsArray.Run();
            MemoryVsSpan.Run();
            ListVsLinkedList.Run();
            HashSetVsList.Run();
            ImmutableListVsList.Run();
            RefVsOutVsIn.Run();
            TaskVsThreadVsThreadPool.Run();
            IEnumerableVsIQueryable.Run();
            LockVsSemaphoreSlim.Run();
            StringBuilderVsStringConcat.Run();
        }

        private static void RunAllDataStructureDemos()
        {
            ArrayDemo.Run();
            ListDemo.Run();
            DictionaryDemo.Run();
            HashSetDemo.Run();
            StackDemo.Run();
            QueueDemo.Run();
            LinkedListDemo.Run();
            SortedDictionaryDemo.Run();
        }
    }
}
