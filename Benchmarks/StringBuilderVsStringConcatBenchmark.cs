using System.Text;
using BenchmarkDotNet.Attributes;

namespace CSharpDataStructuresExplorer.Benchmarks
{
    /// <summary>
    /// Benchmark: StringBuilder vs string concatenation performance.
    /// </summary>
    [MemoryDiagnoser]
    public class StringBuilderVsStringConcatBenchmark
    {
        [Benchmark]
        public void StringConcat()
        {
            System.Console.WriteLine("[Benchmark] ===== String Concatenation =====");
            string result = "";
            for (int i = 0; i < 100; i++)
                result += i.ToString();
            System.Console.WriteLine("[Benchmark] String Concatenation complete.");
        }

        [Benchmark]
        public void StringBuilderAppend()
        {
            System.Console.WriteLine("[Benchmark] === StringBuilder Append ===");
            var sb = new StringBuilder();
            for (int i = 0; i < 100; i++)
                sb.Append(i.ToString());
            System.Console.WriteLine("[Benchmark] StringBuilder Append complete.");
        }
    }
}
