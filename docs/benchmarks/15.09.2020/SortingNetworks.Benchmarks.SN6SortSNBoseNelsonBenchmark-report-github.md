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
|        SortAscending_Comparable |      .NET 4.8 |      .NET 4.8 |      6 | 267.9 ms | 4.00 ms | 3.74 ms |           - |     - |     - |           - |
|        SortAscending_Comparison |      .NET 4.8 |      .NET 4.8 |      6 | 651.5 ms | 2.27 ms | 2.12 ms | 408000.0000 |     - |     - | 534916160 B |
| SortAscending_ComparisonPointer |      .NET 4.8 |      .NET 4.8 |      6 | 401.6 ms | 2.50 ms | 2.34 ms |           - |     - |     - |           - |
|         SortAscending_Insertion |      .NET 4.8 |      .NET 4.8 |      6 | 420.9 ms | 1.87 ms | 1.75 ms |           - |     - |     - |           - |
|        SortAscending_Comparable | .NET Core 3.1 | .NET Core 3.1 |      6 | 265.4 ms | 3.02 ms | 2.82 ms |           - |     - |     - |           - |
|        SortAscending_Comparison | .NET Core 3.1 | .NET Core 3.1 |      6 | 686.0 ms | 2.82 ms | 2.63 ms |  63000.0000 |     - |     - | 533333360 B |
| SortAscending_ComparisonPointer | .NET Core 3.1 | .NET Core 3.1 |      6 | 444.6 ms | 1.29 ms | 1.14 ms |           - |     - |     - |           - |
|         SortAscending_Insertion | .NET Core 3.1 | .NET Core 3.1 |      6 | 365.7 ms | 2.37 ms | 2.22 ms |           - |     - |     - |           - |
