using System;
using System.Collections.Generic;

namespace CSharpDataStructuresExplorer.DataStructures
{
    /// <summary>
    /// Queue<T> demo: FIFO (First-In-First-Out), pros and cons, usage examples.
    /// </summary>
    public class QueueDemo
    {
        public static void Run()
        {
            Console.WriteLine("==================== QUEUE DEMO ====================");
            Console.WriteLine("[QueueDemo] Step 1: Initializing queue");
            // Create a queue
            var queue = new Queue<string>();
            queue.Enqueue("first");
            queue.Enqueue("middle");
            queue.Enqueue("last");
            Console.WriteLine("[QueueDemo] Queue after enqueues: " + string.Join(", ", queue));

            Console.WriteLine("[QueueDemo] Step 2: Dequeuing front element");
            // Remove front element
            var removed = queue.Dequeue();
            Console.WriteLine($"[QueueDemo] Dequeued: {removed}");
            Console.WriteLine("[QueueDemo] Queue after dequeue: " + string.Join(", ", queue));

            Console.WriteLine("[QueueDemo] Step 3: Pros and Cons");
            // Pros and cons
            Console.WriteLine("[QueueDemo] Pros: Fast enqueue/dequeue, FIFO operations.");
            Console.WriteLine("[QueueDemo] Cons: Only front element accessible.");
            Console.WriteLine("================== END QUEUE DEMO ==================\n");
        }
    }
}
