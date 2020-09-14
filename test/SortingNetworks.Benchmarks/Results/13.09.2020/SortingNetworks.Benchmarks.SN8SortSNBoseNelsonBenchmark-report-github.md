``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.508 (2004/?/20H1)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
  [Host]        : .NET Framework 4.8 (4.8.4220.0), X64 RyuJIT
  .NET 4.8      : .NET Framework 4.8 (4.8.4220.0), X64 RyuJIT
  .NET Core 3.1 : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

InvocationCount=1  UnrollFactor=1  

```
|                          Method |           Job |       Runtime | Length |     Mean |    Error |   StdDev |      Gen 0 | Gen 1 | Gen 2 |  Allocated | Code Size |
|-------------------------------- |-------------- |-------------- |------- |---------:|---------:|---------:|-----------:|------:|------:|-----------:|----------:|
|        SortAscending_Comparable |      .NET 4.8 |      .NET 4.8 |      8 | 11.01 ms | 0.189 ms | 0.147 ms |          - |     - |     - |          - |     521 B |
|        SortAscending_Comparison |      .NET 4.8 |      .NET 4.8 |      8 | 98.49 ms | 0.686 ms | 0.642 ms | 61000.0000 |     - |     - | 80237816 B |     507 B |
| SortAscending_ComparisonPointer |      .NET 4.8 |      .NET 4.8 |      8 | 47.43 ms | 0.484 ms | 0.452 ms |          - |     - |     - |          - |     664 B |
|         SortAscending_Insertion |      .NET 4.8 |      .NET 4.8 |      8 | 20.28 ms | 0.136 ms | 0.120 ms |          - |     - |     - |          - |     517 B |
|        SortAscending_Comparable | .NET Core 3.1 | .NET Core 3.1 |      8 | 10.87 ms | 0.079 ms | 0.074 ms |          - |     - |     - |          - |     521 B |
|        SortAscending_Comparison | .NET Core 3.1 | .NET Core 3.1 |      8 | 97.81 ms | 0.973 ms | 0.910 ms |  9000.0000 |     - |     - | 80000000 B |     513 B |
| SortAscending_ComparisonPointer | .NET Core 3.1 | .NET Core 3.1 |      8 | 53.15 ms | 0.392 ms | 0.348 ms |          - |     - |     - |          - |     664 B |
|         SortAscending_Insertion | .NET Core 3.1 | .NET Core 3.1 |      8 | 12.81 ms | 0.062 ms | 0.052 ms |          - |     - |     - |          - |     268 B |
