``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.508 (2004/?/20H1)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
  [Host]        : .NET Framework 4.8 (4.8.4220.0), X64 RyuJIT
  .NET 4.8      : .NET Framework 4.8 (4.8.4220.0), X64 RyuJIT
  .NET Core 3.1 : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

InvocationCount=1  UnrollFactor=1  

```
|                          Method |           Job |       Runtime | Length |      Mean |     Error |    StdDev |      Gen 0 | Gen 1 | Gen 2 |   Allocated | Code Size |
|-------------------------------- |-------------- |-------------- |------- |----------:|----------:|----------:|-----------:|------:|------:|------------:|----------:|
|        SortAscending_Comparable |      .NET 4.8 |      .NET 4.8 |      5 |  9.731 ms | 0.0661 ms | 0.0586 ms |          - |     - |     - |           - |     300 B |
|        SortAscending_Comparison |      .NET 4.8 |      .NET 4.8 |      5 | 83.666 ms | 1.2815 ms | 1.1987 ms | 97000.0000 |     - |     - | 128385368 B |     336 B |
| SortAscending_ComparisonPointer |      .NET 4.8 |      .NET 4.8 |      5 | 38.258 ms | 0.2653 ms | 0.2482 ms |          - |     - |     - |           - |     346 B |
|         SortAscending_Insertion |      .NET 4.8 |      .NET 4.8 |      5 | 21.969 ms | 0.2537 ms | 0.2373 ms |          - |     - |     - |           - |     517 B |
|        SortAscending_Comparable | .NET Core 3.1 | .NET Core 3.1 |      5 |  9.714 ms | 0.0487 ms | 0.0432 ms |          - |     - |     - |           - |     300 B |
|        SortAscending_Comparison | .NET Core 3.1 | .NET Core 3.1 |      5 | 81.114 ms | 1.1909 ms | 1.1140 ms | 15000.0000 |     - |     - | 128000000 B |     342 B |
| SortAscending_ComparisonPointer | .NET Core 3.1 | .NET Core 3.1 |      5 | 43.523 ms | 0.3131 ms | 0.2929 ms |          - |     - |     - |           - |     346 B |
|         SortAscending_Insertion | .NET Core 3.1 | .NET Core 3.1 |      5 | 14.583 ms | 0.0577 ms | 0.0511 ms |          - |     - |     - |           - |     268 B |
