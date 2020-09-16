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
|        SortAscending_Comparable |      .NET 4.8 |      .NET 4.8 |      8 | 317.2 ms | 4.23 ms | 3.96 ms |           - |     - |     - |           - |
|        SortAscending_Comparison |      .NET 4.8 |      .NET 4.8 |      8 | 760.0 ms | 2.25 ms | 1.75 ms | 306000.0000 |     - |     - | 401189168 B |
| SortAscending_ComparisonPointer |      .NET 4.8 |      .NET 4.8 |      8 | 471.9 ms | 2.63 ms | 2.46 ms |           - |     - |     - |           - |
|         SortAscending_Insertion |      .NET 4.8 |      .NET 4.8 |      8 | 495.6 ms | 1.82 ms | 1.71 ms |           - |     - |     - |           - |
|        SortAscending_Comparable | .NET Core 3.1 | .NET Core 3.1 |      8 | 315.1 ms | 4.35 ms | 4.07 ms |           - |     - |     - |      1336 B |
|        SortAscending_Comparison | .NET Core 3.1 | .NET Core 3.1 |      8 | 859.7 ms | 8.86 ms | 8.28 ms |  47000.0000 |     - |     - | 399999936 B |
| SortAscending_ComparisonPointer | .NET Core 3.1 | .NET Core 3.1 |      8 | 527.5 ms | 1.64 ms | 1.53 ms |           - |     - |     - |        48 B |
|         SortAscending_Insertion | .NET Core 3.1 | .NET Core 3.1 |      8 | 418.1 ms | 3.00 ms | 2.66 ms |           - |     - |     - |      1336 B |
