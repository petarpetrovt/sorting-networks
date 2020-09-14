``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.508 (2004/?/20H1)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
  [Host]        : .NET Framework 4.8 (4.8.4220.0), X64 RyuJIT
  .NET 4.8      : .NET Framework 4.8 (4.8.4220.0), X64 RyuJIT
  .NET Core 3.1 : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

InvocationCount=1  UnrollFactor=1  

```
|                          Method |           Job |       Runtime | Length |      Mean |    Error |   StdDev | Code Size |      Gen 0 | Gen 1 | Gen 2 |  Allocated |
|-------------------------------- |-------------- |-------------- |------- |----------:|---------:|---------:|----------:|-----------:|------:|------:|-----------:|
|        SortAscending_Comparable |      .NET 4.8 |      .NET 4.8 |     15 |  20.04 ms | 0.142 ms | 0.126 ms |    1932 B |          - |     - |     - |          - |
|        SortAscending_Comparison |      .NET 4.8 |      .NET 4.8 |     15 | 159.22 ms | 0.425 ms | 0.398 ms |    1476 B | 32000.0000 |     - |     - | 42797824 B |
| SortAscending_ComparisonPointer |      .NET 4.8 |      .NET 4.8 |     15 |  74.02 ms | 0.961 ms | 0.899 ms |    2191 B |          - |     - |     - |          - |
|         SortAscending_Insertion |      .NET 4.8 |      .NET 4.8 |     15 |  18.06 ms | 0.100 ms | 0.078 ms |     517 B |          - |     - |     - |          - |
|        SortAscending_Comparable | .NET Core 3.1 | .NET Core 3.1 |     15 |  20.70 ms | 0.398 ms | 0.504 ms |    1932 B |          - |     - |     - |          - |
|        SortAscending_Comparison | .NET Core 3.1 | .NET Core 3.1 |     15 | 149.91 ms | 1.685 ms | 1.576 ms |    1482 B |  5000.0000 |     - |     - | 42666688 B |
| SortAscending_ComparisonPointer | .NET Core 3.1 | .NET Core 3.1 |     15 |  84.45 ms | 1.228 ms | 1.149 ms |    2191 B |          - |     - |     - |          - |
|         SortAscending_Insertion | .NET Core 3.1 | .NET Core 3.1 |     15 |  11.34 ms | 0.118 ms | 0.093 ms |     268 B |          - |     - |     - |          - |
