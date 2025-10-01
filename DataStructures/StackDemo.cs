using System;
using System.Collections.Generic;

namespace CSharpDataStructuresExplorer.DataStructures
{
    /// <summary>
    /// Stack<T> demo: LIFO (Last-In-First-Out), pros and cons, usage examples.
    /// </summary>
    public class StackDemo
    {
        public static void Run()
        {
            Console.WriteLine("==================== STACK DEMO ====================");
            Console.WriteLine("[StackDemo] Step 1: Initializing stack");
            // Create a stack
            var stack = new Stack<string>();
            stack.Push("first");
            stack.Push("middle");
            stack.Push("last");
            Console.WriteLine("[StackDemo] Stack after pushes: " + string.Join(", ", stack));

            Console.WriteLine("[StackDemo] Step 2: Popping top element");
            // Remove top element
            var removed = stack.Pop();
            Console.WriteLine($"[StackDemo] Popped: {removed}");
            Console.WriteLine("[StackDemo] Stack after pop: " + string.Join(", ", stack));

            Console.WriteLine("[StackDemo] Step 3: Pros and Cons");
            // Pros and cons
            Console.WriteLine("[StackDemo] Pros: Fast push/pop, LIFO operations.");
            Console.WriteLine("[StackDemo] Cons: Only top element accessible.");
            Console.WriteLine("================== END STACK DEMO ==================\n");
        }
    }
}
