``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.508 (2004/?/20H1)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=3.1.402
  [Host]        : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  .NET 4.8      : .NET Framework 4.8 (4.8.4220.0), X64 RyuJIT
  .NET Core 3.1 : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

InvocationCount=1  UnrollFactor=1  

```
|                          Method |           Job |       Runtime | Length |     Mean |   Error |  StdDev |       Gen 0 | Gen 1 | Gen 2 |   Allocated |
|-------------------------------- |-------------- |-------------- |------- |---------:|--------:|--------:|------------:|------:|------:|------------:|
|        SortAscending_Comparable |      .NET 4.8 |      .NET 4.8 |      7 | 288.0 ms | 4.24 ms | 3.97 ms |           - |     - |     - |           - |
|        SortAscending_Comparison |      .NET 4.8 |      .NET 4.8 |      7 | 708.6 ms | 2.33 ms | 2.18 ms | 349000.0000 |     - |     - | 458495992 B |
| SortAscending_ComparisonPointer |      .NET 4.8 |      .NET 4.8 |      7 | 432.7 ms | 1.89 ms | 1.77 ms |           - |     - |     - |           - |
|         SortAscending_Insertion |      .NET 4.8 |      .NET 4.8 |      7 | 460.9 ms | 1.91 ms | 1.79 ms |           - |     - |     - |           - |
|        SortAscending_Comparable | .NET Core 3.1 | .NET Core 3.1 |      7 | 286.0 ms | 2.38 ms | 1.98 ms |           - |     - |     - |        48 B |
|        SortAscending_Comparison | .NET Core 3.1 | .NET Core 3.1 |      7 | 801.7 ms | 3.20 ms | 2.99 ms |  54000.0000 |     - |     - | 457142848 B |
| SortAscending_ComparisonPointer | .NET Core 3.1 | .NET Core 3.1 |      7 | 483.1 ms | 1.42 ms | 1.26 ms |           - |     - |     - |           - |
|         SortAscending_Insertion | .NET Core 3.1 | .NET Core 3.1 |      7 | 391.1 ms | 3.66 ms | 3.42 ms |           - |     - |     - |        48 B |
