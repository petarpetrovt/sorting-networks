``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.508 (2004/?/20H1)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=3.1.402
  [Host]        : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  .NET 4.8      : .NET Framework 4.8 (4.8.4220.0), X64 RyuJIT
  .NET Core 3.1 : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

InvocationCount=1  UnrollFactor=1  

```
|                          Method |           Job |       Runtime | Length |     Mean |   Error |  StdDev |        Gen 0 | Gen 1 | Gen 2 |    Allocated |
|-------------------------------- |-------------- |-------------- |------- |---------:|--------:|--------:|-------------:|------:|------:|-------------:|
|        SortAscending_Comparable |      .NET 4.8 |      .NET 4.8 |      2 | 137.9 ms | 0.86 ms | 0.80 ms |            - |     - |     - |            - |
|        SortAscending_Comparison |      .NET 4.8 |      .NET 4.8 |      2 | 318.6 ms | 4.58 ms | 4.06 ms | 1224000.0000 |     - |     - | 1604732096 B |
| SortAscending_ComparisonPointer |      .NET 4.8 |      .NET 4.8 |      2 | 171.0 ms | 0.86 ms | 0.80 ms |            - |     - |     - |            - |
|         SortAscending_Insertion |      .NET 4.8 |      .NET 4.8 |      2 | 263.2 ms | 1.74 ms | 1.54 ms |            - |     - |     - |            - |
|        SortAscending_Comparable | .NET Core 3.1 | .NET Core 3.1 |      2 | 141.4 ms | 0.98 ms | 0.91 ms |            - |     - |     - |            - |
|        SortAscending_Comparison | .NET Core 3.1 | .NET Core 3.1 |      2 | 324.9 ms | 4.93 ms | 4.61 ms |  191000.0000 |     - |     - | 1600001320 B |
| SortAscending_ComparisonPointer | .NET Core 3.1 | .NET Core 3.1 |      2 | 174.1 ms | 1.24 ms | 1.10 ms |            - |     - |     - |            - |
|         SortAscending_Insertion | .NET Core 3.1 | .NET Core 3.1 |      2 | 235.6 ms | 0.87 ms | 0.81 ms |            - |     - |     - |       1336 B |
