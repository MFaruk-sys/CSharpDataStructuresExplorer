using System;

namespace CSharpDataStructuresExplorer.DataStructures
{
    /// <summary>
    /// Array demo: basic usage, pros and cons, and real-world notes.
    /// </summary>
    public class ArrayDemo
    {
        public static void Run()
        {
            Console.WriteLine("==================== ARRAY DEMO ====================");
            Console.WriteLine("[ArrayDemo] Step 1: Initializing array");
            // Define an array
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine("[ArrayDemo] Initial array: " + string.Join(", ", numbers));

            Console.WriteLine("[ArrayDemo] Step 2: Updating index 2 to 42");
            // Update an element
            numbers[2] = 42;
            Console.WriteLine("[ArrayDemo] Updated array: " + string.Join(", ", numbers));

            Console.WriteLine("[ArrayDemo] Step 3: Pros and Cons");
            // Pros and cons
            Console.WriteLine("[ArrayDemo] Pros: Fixed size, fast access.");
            Console.WriteLine("[ArrayDemo] Cons: Size cannot change, insert/remove is hard.");
            Console.WriteLine("================== END ARRAY DEMO ==================\n");
        }
    }
}
