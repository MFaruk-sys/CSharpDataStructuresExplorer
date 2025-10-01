using System;

namespace CSharpDataStructuresExplorer.Comparisons
{
    /// <summary>
    /// Compare Memory<T> vs Span<T> in C#.
    /// </summary>
    public class MemoryVsSpan
    {
        public static void Run()
        {
            Console.WriteLine("================= MEMORY VS SPAN ====================");
            int[] array = { 1, 2, 3, 4, 5 };
            Memory<int> memory = array;
            Span<int> span = array;

            Console.WriteLine("[Comparison] Step 1: Initial values");
            Console.WriteLine("[Comparison] Span: " + string.Join(", ", span.ToArray()));
            Console.WriteLine("[Comparison] Memory: " + string.Join(", ", memory.Span.ToArray()));

            Console.WriteLine("[Comparison] Step 2: Mutating values");
            span[0] = 42;
            memory.Span[1] = 99;
            Console.WriteLine("[Comparison] Span after mutation: " + string.Join(", ", span.ToArray()));
            Console.WriteLine("[Comparison] Memory after mutation: " + string.Join(", ", memory.Span.ToArray()));

            Console.WriteLine("[Comparison] Step 3: Notes");
            Console.WriteLine("[Comparison] Span<T> is stack-only, fast, not storable in fields/classes.");
            Console.WriteLine("[Comparison] Memory<T> is heap-based, can be stored, used for async scenarios.");
            Console.WriteLine("=============== END MEMORY VS SPAN ==================\n");
        }
    }
}
