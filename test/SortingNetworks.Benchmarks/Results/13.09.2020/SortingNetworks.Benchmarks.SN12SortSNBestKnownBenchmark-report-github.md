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
|        SortAscending_Comparable |      .NET 4.8 |      .NET 4.8 |     12 |  18.53 ms | 0.062 ms | 0.052 ms |          - |     - |     - |          - |    1080 B |
|        SortAscending_Comparison |      .NET 4.8 |      .NET 4.8 |     12 | 132.74 ms | 0.948 ms | 0.887 ms | 40000.0000 |     - |     - | 53497280 B |     879 B |
| SortAscending_ComparisonPointer |      .NET 4.8 |      .NET 4.8 |     12 |  63.14 ms | 0.537 ms | 0.502 ms |          - |     - |     - |          - |    1429 B |
|         SortAscending_Insertion |      .NET 4.8 |      .NET 4.8 |     12 |  18.85 ms | 0.225 ms | 0.176 ms |          - |     - |     - |          - |     517 B |
|        SortAscending_Comparable | .NET Core 3.1 | .NET Core 3.1 |     12 |  18.42 ms | 0.126 ms | 0.118 ms |          - |     - |     - |          - |    1080 B |
|        SortAscending_Comparison | .NET Core 3.1 | .NET Core 3.1 |     12 | 121.39 ms | 0.928 ms | 0.868 ms |  6000.0000 |     - |     - | 53333376 B |     885 B |
| SortAscending_ComparisonPointer | .NET Core 3.1 | .NET Core 3.1 |     12 |  72.38 ms | 0.440 ms | 0.412 ms |          - |     - |     - |          - |    1429 B |
|         SortAscending_Insertion | .NET Core 3.1 | .NET Core 3.1 |     12 |  12.03 ms | 0.147 ms | 0.130 ms |          - |     - |     - |          - |     268 B |
