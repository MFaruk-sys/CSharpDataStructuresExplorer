# CSharpDataStructuresExplorer

A practical C#/.NET 8 project to explore, compare, and benchmark essential data structures and concepts.

## Features
- Demos for core data structures (Array, List, Dictionary, HashSet, Stack, Queue, LinkedList, SortedDictionary)
- Key comparisons (e.g., List vs LinkedList, Struct vs Class vs Record, Dictionary vs ConcurrentDictionary, etc.)
- Performance benchmarks using BenchmarkDotNet
- Simple menu to run all demos, comparisons, or benchmarks

## Usage
1. Build and run the project:
   ```bash
   dotnet run
   ```
2. Choose an option from the menu:
   - Run all benchmarks
   - Run all comparisons
   - Run all data structure demos

## Benchmark Accuracy
To get reliable benchmark results, always run in Release mode:
```bash
dotnet build -c Release
dotnet run -c Release
```

## Why?
- Learn C# data structures and their differences
- Prepare for interviews
- Use as a quick reference
