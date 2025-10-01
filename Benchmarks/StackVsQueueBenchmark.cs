using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace CSharpDataStructuresExplorer.Benchmarks
{
    /// <summary>
    /// Benchmark: Stack<T> vs Queue<T> push/pop and enqueue/dequeue performance.
    /// </summary>
    [MemoryDiagnoser]
    public class StackVsQueueBenchmark
    {
        [Benchmark]
        public void StackPushPop()
        {
            System.Console.WriteLine("[Benchmark] ===== Stack Push/Pop =====");
            var stack = new Stack<int>();
            for (int i = 0; i < 100; i++)
                stack.Push(i);
            for (int i = 0; i < 100; i++)
                stack.Pop();
            System.Console.WriteLine("[Benchmark] Stack Push/Pop complete.");
        }

        [Benchmark]
        public void QueueEnqueueDequeue()
        {
            System.Console.WriteLine("[Benchmark] === Queue Enqueue/Dequeue ===");
            var queue = new Queue<int>();
            for (int i = 0; i < 100; i++)
                queue.Enqueue(i);
            for (int i = 0; i < 100; i++)
                queue.Dequeue();
            System.Console.WriteLine("[Benchmark] Queue Enqueue/Dequeue complete.");
        }
    }
}
