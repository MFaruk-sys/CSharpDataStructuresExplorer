using System;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpDataStructuresExplorer.Comparisons
{
    /// <summary>
    /// Compare Task, Thread, and ThreadPool in C#.
    /// </summary>
    public class TaskVsThreadVsThreadPool
    {
        public static void Run()
        {
            Console.WriteLine("========== TASK VS THREAD VS THREADPOOL ==========");
            // Task
            Console.WriteLine("[Comparison] Step 1: Running Task");
            Task.Run(() => Console.WriteLine("[Comparison] Task running"));
            // Thread
            Console.WriteLine("[Comparison] Step 2: Running Thread");
            new Thread(() => Console.WriteLine("[Comparison] Thread running")).Start();
            // ThreadPool
            Console.WriteLine("[Comparison] Step 3: Running ThreadPool");
            ThreadPool.QueueUserWorkItem(_ => Console.WriteLine("[Comparison] ThreadPool running"));

            Console.WriteLine("[Comparison] Step 4: Notes");
            Console.WriteLine("[Comparison] Task: High-level, supports async/await, best for parallelism.");
            Console.WriteLine("[Comparison] Thread: Low-level, manual control, best for custom threading.");
            Console.WriteLine("[Comparison] ThreadPool: Managed pool, best for short-lived, frequent tasks.");
            Console.WriteLine("======= END TASK VS THREAD VS THREADPOOL ========\n");
        }
    }
}
