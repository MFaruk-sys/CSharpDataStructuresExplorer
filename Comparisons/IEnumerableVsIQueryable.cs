using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpDataStructuresExplorer.Comparisons
{
    /// <summary>
    /// Compare IEnumerable vs IQueryable in C#.
    /// </summary>
    public class IEnumerableVsIQueryable
    {
        public static void Run()
        {
            Console.WriteLine("========== IENUMERABLE VS IQUERYABLE ===========");
            IEnumerable<int> enumerable = new List<int> { 1, 2, 3 };
            IQueryable<int> queryable = enumerable.AsQueryable();

            Console.WriteLine("[Comparison] Step 1: IEnumerable");
            Console.WriteLine("[Comparison] IEnumerable: In-memory, LINQ executed locally.");
            Console.WriteLine("[Comparison] Step 2: IQueryable");
            Console.WriteLine("[Comparison] IQueryable: Remote query, LINQ translated to provider (e.g., SQL).\n");
            Console.WriteLine("======= END IENUMERABLE VS IQUERYABLE ===========\n");
        }
    }
}
