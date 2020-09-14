``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.508 (2004/?/20H1)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
  [Host]        : .NET Framework 4.8 (4.8.4220.0), X64 RyuJIT
  .NET 4.8      : .NET Framework 4.8 (4.8.4220.0), X64 RyuJIT
  .NET Core 3.1 : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

InvocationCount=1  UnrollFactor=1  

```
|                          Method |           Job |       Runtime | Length |      Mean |    Error |   StdDev |      Gen 0 | Gen 1 | Gen 2 |  Allocated | Code Size |
|-------------------------------- |-------------- |-------------- |------- |----------:|---------:|---------:|-----------:|------:|------:|-----------:|----------:|
|        SortAscending_Comparable |      .NET 4.8 |      .NET 4.8 |     13 |  20.15 ms | 0.296 ms | 0.247 ms |          - |     - |     - |          - |    1246 B |
|        SortAscending_Comparison |      .NET 4.8 |      .NET 4.8 |     13 | 129.35 ms | 0.600 ms | 0.532 ms | 37000.0000 |     - |     - | 49376440 B |     984 B |
| SortAscending_ComparisonPointer |      .NET 4.8 |      .NET 4.8 |     13 |  67.77 ms | 0.874 ms | 0.818 ms |          - |     - |     - |          - |    1731 B |
|         SortAscending_Insertion |      .NET 4.8 |      .NET 4.8 |     13 |  18.74 ms | 0.374 ms | 0.367 ms |          - |     - |     - |          - |     517 B |
|        SortAscending_Comparable | .NET Core 3.1 | .NET Core 3.1 |     13 |  18.37 ms | 0.162 ms | 0.144 ms |          - |     - |     - |          - |    1246 B |
|        SortAscending_Comparison | .NET Core 3.1 | .NET Core 3.1 |     13 | 135.34 ms | 0.738 ms | 0.655 ms |  5000.0000 |     - |     - | 49230784 B |     990 B |
| SortAscending_ComparisonPointer | .NET Core 3.1 | .NET Core 3.1 |     13 |  76.66 ms | 0.390 ms | 0.346 ms |          - |     - |     - |          - |    1731 B |
|         SortAscending_Insertion | .NET Core 3.1 | .NET Core 3.1 |     13 |  14.02 ms | 0.102 ms | 0.079 ms |          - |     - |     - |          - |     268 B |
