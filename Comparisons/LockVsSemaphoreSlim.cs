using System;
using System.Threading;

namespace CSharpDataStructuresExplorer.Comparisons
{
    /// <summary>
    /// Compare lock vs SemaphoreSlim in C#.
    /// </summary>
    public class LockVsSemaphoreSlim
    {
        private static readonly object _lockObj = new object();
        private static readonly SemaphoreSlim _semaphore = new SemaphoreSlim(1);

        public static void Run()
        {
            Console.WriteLine("=========== LOCK VS SEMAPHORESLIM ===========");
            // lock
            Console.WriteLine("[Comparison] Step 1: Using lock");
            lock (_lockObj)
            {
                Console.WriteLine("[Comparison] Inside lock block");
            }
            // SemaphoreSlim
            Console.WriteLine("[Comparison] Step 2: Using SemaphoreSlim");
            _semaphore.Wait();
            try
            {
                Console.WriteLine("[Comparison] Inside SemaphoreSlim block");
            }
            finally
            {
                _semaphore.Release();
            }

            Console.WriteLine("[Comparison] Step 3: Notes");
            Console.WriteLine("[Comparison] lock: Simple, fast, only for single process/thread sync.");
            Console.WriteLine("[Comparison] SemaphoreSlim: More flexible, async support, can limit concurrency.");
            Console.WriteLine("======= END LOCK VS SEMAPHORESLIM ===========\n");
        }
    }
}
