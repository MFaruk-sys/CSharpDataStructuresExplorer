using System;

namespace CSharpDataStructuresExplorer.Comparisons
{
    /// <summary>
    /// Compare struct, class, and record types in C#.
    /// </summary>
    public class StructVsClassVsRecord
    {
        public struct MyStruct { public int Value; }
        public class MyClass { public int Value; }
        public record MyRecord(int Value);

        public static void Run()
        {
            Console.WriteLine("============= STRUCT VS CLASS VS RECORD =============");
            var s = new MyStruct { Value = 1 };
            var c = new MyClass { Value = 2 };
            var r = new MyRecord(3);

            Console.WriteLine("[Comparison] Step 1: Values");
            Console.WriteLine($"[Comparison] Struct: {s.Value}");
            Console.WriteLine($"[Comparison] Class: {c.Value}");
            Console.WriteLine($"[Comparison] Record: {r.Value}");

            Console.WriteLine("[Comparison] Step 2: Type notes");
            Console.WriteLine("[Comparison] Struct: Value type, stored on stack, copied by value.");
            Console.WriteLine("[Comparison] Class: Reference type, stored on heap, copied by reference.");
            Console.WriteLine("[Comparison] Record: Reference type, immutable by default, value-based equality.");
            Console.WriteLine("============ END STRUCT VS CLASS VS RECORD ============\n");
        }
    }
}
