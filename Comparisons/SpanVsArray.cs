using System;

namespace CSharpDataStructuresExplorer.Comparisons
{
    /// <summary>
    /// Compare Span<T> vs Array in C#.
    /// </summary>
    public class SpanVsArray
    {
        public static void Run()
        {
            Console.WriteLine("=================== SPAN VS ARRAY ===================");
            int[] array = { 1, 2, 3, 4, 5 };
            Span<int> span = array;

            Console.WriteLine("[Comparison] Step 1: Initial values");
            Console.WriteLine("[Comparison] Array: " + string.Join(", ", array));
            Console.WriteLine("[Comparison] Span: " + string.Join(", ", span.ToArray()));

            Console.WriteLine("[Comparison] Step 2: Mutating values");
            array[0] = 10;
            span[1] = 20;
            Console.WriteLine("[Comparison] Array after mutation: " + string.Join(", ", array));
            Console.WriteLine("[Comparison] Span after mutation: " + string.Join(", ", span.ToArray()));

            Console.WriteLine("[Comparison] Step 3: Notes");
            Console.WriteLine("[Comparison] Span<T> provides safe, fast access to memory regions, can work with stackalloc, slices, and more.");
            Console.WriteLine("[Comparison] Array is a fixed-size, reference type, less flexible for advanced memory scenarios.");
            Console.WriteLine("================ END SPAN VS ARRAY ==================\n");
        }
    }
}
