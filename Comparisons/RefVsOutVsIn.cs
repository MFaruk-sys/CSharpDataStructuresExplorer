using System;

namespace CSharpDataStructuresExplorer.Comparisons
{
    /// <summary>
    /// Compare ref, out, and in parameters in C#.
    /// </summary>
    public class RefVsOutVsIn
    {
        public static void Run()
        {
            Console.WriteLine("=============== REF VS OUT VS IN ===============");
            int a = 1, b, c = 3;
            Console.WriteLine("[Comparison] Step 1: Initial values");
            Console.WriteLine($"[Comparison] ref: {a}, out: uninitialized, in: {c}");
            RefMethod(ref a);
            OutMethod(out b);
            InMethod(in c);
            Console.WriteLine("[Comparison] Step 2: After method calls");
            Console.WriteLine($"[Comparison] ref: {a}, out: {b}, in: {c}");

            Console.WriteLine("[Comparison] Step 3: Notes");
            Console.WriteLine("[Comparison] ref: Passes variable by reference, must be initialized.");
            Console.WriteLine("[Comparison] out: Passes variable by reference, must be assigned in method.");
            Console.WriteLine("[Comparison] in: Passes variable by reference, read-only in method.");
            Console.WriteLine("=============== END REF VS OUT VS IN ===============\n");
        }

        static void RefMethod(ref int x) { x += 10; }
        static void OutMethod(out int x) { x = 20; }
        static void InMethod(in int x) { Console.WriteLine($"[Comparison] in param: {x}"); }
    }
}
