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
|        SortAscending_Comparable |      .NET 4.8 |      .NET 4.8 |     14 |  19.67 ms | 0.120 ms | 0.106 ms |          - |     - |     - |          - |    1573 B |
|        SortAscending_Comparison |      .NET 4.8 |      .NET 4.8 |     14 | 135.61 ms | 1.126 ms | 1.053 ms | 34000.0000 |     - |     - | 45853616 B |    1109 B |
| SortAscending_ComparisonPointer |      .NET 4.8 |      .NET 4.8 |     14 |  75.02 ms | 1.473 ms | 1.696 ms |          - |     - |     - |          - |    1926 B |
|         SortAscending_Insertion |      .NET 4.8 |      .NET 4.8 |     14 |  18.24 ms | 0.171 ms | 0.152 ms |          - |     - |     - |          - |     517 B |
|        SortAscending_Comparable | .NET Core 3.1 | .NET Core 3.1 |     14 |  20.82 ms | 0.377 ms | 0.334 ms |          - |     - |     - |          - |    1573 B |
|        SortAscending_Comparison | .NET Core 3.1 | .NET Core 3.1 |     14 | 144.83 ms | 1.024 ms | 0.958 ms |  5000.0000 |     - |     - | 45714304 B |    1115 B |
| SortAscending_ComparisonPointer | .NET Core 3.1 | .NET Core 3.1 |     14 |  82.71 ms | 1.484 ms | 1.457 ms |          - |     - |     - |          - |    1926 B |
|         SortAscending_Insertion | .NET Core 3.1 | .NET Core 3.1 |     14 |  12.12 ms | 0.233 ms | 0.319 ms |          - |     - |     - |          - |     268 B |
