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
|        SortAscending_Comparable |      .NET 4.8 |      .NET 4.8 |      5 | 237.9 ms | 2.13 ms | 1.99 ms |           - |     - |     - |           - |
|        SortAscending_Comparison |      .NET 4.8 |      .NET 4.8 |      5 | 567.9 ms | 2.09 ms | 1.86 ms | 489000.0000 |     - |     - | 641894424 B |
| SortAscending_ComparisonPointer |      .NET 4.8 |      .NET 4.8 |      5 | 350.5 ms | 2.29 ms | 2.03 ms |           - |     - |     - |           - |
|         SortAscending_Insertion |      .NET 4.8 |      .NET 4.8 |      5 | 383.8 ms | 1.31 ms | 1.23 ms |           - |     - |     - |           - |
|        SortAscending_Comparable | .NET Core 3.1 | .NET Core 3.1 |      5 | 239.5 ms | 4.63 ms | 4.33 ms |           - |     - |     - |      1384 B |
|        SortAscending_Comparison | .NET Core 3.1 | .NET Core 3.1 |      5 | 661.3 ms | 4.85 ms | 4.54 ms |  76000.0000 |     - |     - | 639999936 B |
| SortAscending_ComparisonPointer | .NET Core 3.1 | .NET Core 3.1 |      5 | 397.5 ms | 1.19 ms | 1.05 ms |           - |     - |     - |        48 B |
|         SortAscending_Insertion | .NET Core 3.1 | .NET Core 3.1 |      5 | 316.4 ms | 2.11 ms | 1.98 ms |           - |     - |     - |      1384 B |
