``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.508 (2004/?/20H1)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=3.1.402
  [Host]        : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  .NET 4.8      : .NET Framework 4.8 (4.8.4220.0), X64 RyuJIT
  .NET Core 3.1 : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

InvocationCount=1  UnrollFactor=1  

```
|                          Method |           Job |       Runtime | Length |       Mean |    Error |   StdDev |       Gen 0 | Gen 1 | Gen 2 |   Allocated |
|-------------------------------- |-------------- |-------------- |------- |-----------:|---------:|---------:|------------:|------:|------:|------------:|
|        SortAscending_Comparable |      .NET 4.8 |      .NET 4.8 |     11 |   374.3 ms |  2.02 ms |  1.79 ms |           - |     - |     - |           - |
|        SortAscending_Comparison |      .NET 4.8 |      .NET 4.8 |     11 |   976.3 ms |  3.62 ms |  3.02 ms | 222000.0000 |     - |     - | 291769424 B |
| SortAscending_ComparisonPointer |      .NET 4.8 |      .NET 4.8 |     11 |   611.1 ms |  1.13 ms |  1.00 ms |           - |     - |     - |           - |
|         SortAscending_Insertion |      .NET 4.8 |      .NET 4.8 |     11 |   576.9 ms |  2.21 ms |  1.96 ms |           - |     - |     - |           - |
|        SortAscending_Comparable | .NET Core 3.1 | .NET Core 3.1 |     11 |   372.6 ms |  1.85 ms |  1.73 ms |           - |     - |     - |        48 B |
|        SortAscending_Comparison | .NET Core 3.1 | .NET Core 3.1 |     11 | 1,093.3 ms | 18.97 ms | 26.60 ms |  34000.0000 |     - |     - | 290909056 B |
| SortAscending_ComparisonPointer | .NET Core 3.1 | .NET Core 3.1 |     11 |   673.4 ms |  3.09 ms |  2.89 ms |           - |     - |     - |        48 B |
|         SortAscending_Insertion | .NET Core 3.1 | .NET Core 3.1 |     11 |   476.3 ms |  2.68 ms |  2.51 ms |           - |     - |     - |           - |
