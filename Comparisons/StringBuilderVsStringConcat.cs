using System;
using System.Text;

namespace CSharpDataStructuresExplorer.Comparisons
{
    /// <summary>
    /// Compare StringBuilder vs string concatenation in C#.
    /// </summary>
    public class StringBuilderVsStringConcat
    {
        public static void Run()
        {
            Console.WriteLine("======= STRINGBUILDER VS STRING CONCAT =========");
            string concat = "Hello";
            concat += " World";
            concat += "!";

            var sb = new StringBuilder();
            sb.Append("Hello");
            sb.Append(" World");
            sb.Append("!");

            Console.WriteLine("[Comparison] Step 1: String concat result");
            Console.WriteLine($"[Comparison] String concat: {concat}");
            Console.WriteLine("[Comparison] Step 2: StringBuilder result");
            Console.WriteLine($"[Comparison] StringBuilder: {sb}");

            Console.WriteLine("[Comparison] Step 3: Notes");
            Console.WriteLine("[Comparison] StringBuilder: Efficient for many changes, best for loops.");
            Console.WriteLine("[Comparison] String concat: Simple, best for few changes.");
            Console.WriteLine("===== END STRINGBUILDER VS STRING CONCAT =======\n");
        }
    }
}
