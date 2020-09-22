``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.508 (2004/?/20H1)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=3.1.402
  [Host]        : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  .NET 4.8      : .NET Framework 4.8 (4.8.4220.0), X64 RyuJIT
  .NET Core 3.1 : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

InvocationCount=1  UnrollFactor=1  

```
|                          Method |           Job |       Runtime | Length |     Mean |    Error |   StdDev |       Gen 0 | Gen 1 | Gen 2 |   Allocated |
|-------------------------------- |-------------- |-------------- |------- |---------:|---------:|---------:|------------:|------:|------:|------------:|
|        SortAscending_Comparable |      .NET 4.8 |      .NET 4.8 |     10 | 349.2 ms |  3.57 ms |  3.34 ms |           - |     - |     - |           - |
|        SortAscending_Comparison |      .NET 4.8 |      .NET 4.8 |     10 | 887.0 ms |  3.08 ms |  2.41 ms | 244000.0000 |     - |     - | 320951264 B |
| SortAscending_ComparisonPointer |      .NET 4.8 |      .NET 4.8 |     10 | 556.5 ms |  2.31 ms |  1.93 ms |           - |     - |     - |           - |
|         SortAscending_Insertion |      .NET 4.8 |      .NET 4.8 |     10 | 552.7 ms |  2.25 ms |  2.10 ms |           - |     - |     - |           - |
|        SortAscending_Comparable | .NET Core 3.1 | .NET Core 3.1 |     10 | 349.2 ms |  3.78 ms |  3.53 ms |           - |     - |     - |           - |
|        SortAscending_Comparison | .NET Core 3.1 | .NET Core 3.1 |     10 | 974.7 ms | 12.88 ms | 11.42 ms |  38000.0000 |     - |     - | 320001272 B |
| SortAscending_ComparisonPointer | .NET Core 3.1 | .NET Core 3.1 |     10 | 595.3 ms |  1.78 ms |  1.67 ms |           - |     - |     - |           - |
|         SortAscending_Insertion | .NET Core 3.1 | .NET Core 3.1 |     10 | 458.1 ms |  4.73 ms |  4.42 ms |           - |     - |     - |       504 B |
