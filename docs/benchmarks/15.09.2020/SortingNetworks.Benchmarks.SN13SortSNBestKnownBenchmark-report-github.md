``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.508 (2004/?/20H1)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=3.1.402
  [Host]        : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  .NET 4.8      : .NET Framework 4.8 (4.8.4220.0), X64 RyuJIT
  .NET Core 3.1 : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

InvocationCount=1  UnrollFactor=1  

```
|                          Method |           Job |       Runtime | Length |       Mean |   Error |  StdDev |       Gen 0 | Gen 1 | Gen 2 |   Allocated |
|-------------------------------- |-------------- |-------------- |------- |-----------:|--------:|--------:|------------:|------:|------:|------------:|
|        SortAscending_Comparable |      .NET 4.8 |      .NET 4.8 |     13 |   407.3 ms | 2.85 ms | 2.66 ms |           - |     - |     - |           - |
|        SortAscending_Comparison |      .NET 4.8 |      .NET 4.8 |     13 | 1,024.6 ms | 6.50 ms | 5.76 ms | 188000.0000 |     - |     - | 246882464 B |
| SortAscending_ComparisonPointer |      .NET 4.8 |      .NET 4.8 |     13 |   678.3 ms | 1.66 ms | 1.55 ms |           - |     - |     - |           - |
|         SortAscending_Insertion |      .NET 4.8 |      .NET 4.8 |     13 |   628.4 ms | 4.24 ms | 3.54 ms |           - |     - |     - |           - |
|        SortAscending_Comparable | .NET Core 3.1 | .NET Core 3.1 |     13 |   402.7 ms | 2.22 ms | 2.08 ms |           - |     - |     - |      1336 B |
|        SortAscending_Comparison | .NET Core 3.1 | .NET Core 3.1 |     13 | 1,118.7 ms | 3.43 ms | 3.04 ms |  29000.0000 |     - |     - | 246153792 B |
| SortAscending_ComparisonPointer | .NET Core 3.1 | .NET Core 3.1 |     13 |   724.1 ms | 2.19 ms | 2.05 ms |           - |     - |     - |           - |
|         SortAscending_Insertion | .NET Core 3.1 | .NET Core 3.1 |     13 |   485.7 ms | 1.97 ms | 1.84 ms |           - |     - |     - |      1336 B |
