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
|        SortAscending_Comparable |      .NET 4.8 |      .NET 4.8 |     16 |   491.0 ms | 2.57 ms | 2.40 ms |           - |     - |     - |           - |
|        SortAscending_Comparison |      .NET 4.8 |      .NET 4.8 |     16 | 1,181.5 ms | 2.67 ms | 2.23 ms | 153000.0000 |     - |     - | 200594584 B |
| SortAscending_ComparisonPointer |      .NET 4.8 |      .NET 4.8 |     16 |   779.4 ms | 2.41 ms | 2.25 ms |           - |     - |     - |           - |
|         SortAscending_Insertion |      .NET 4.8 |      .NET 4.8 |     16 |   696.9 ms | 4.31 ms | 4.03 ms |           - |     - |     - |           - |
|        SortAscending_Comparable | .NET Core 3.1 | .NET Core 3.1 |     16 |   488.9 ms | 2.13 ms | 1.99 ms |           - |     - |     - |      1336 B |
|        SortAscending_Comparison | .NET Core 3.1 | .NET Core 3.1 |     16 | 1,232.5 ms | 2.58 ms | 2.29 ms |  23000.0000 |     - |     - | 199999984 B |
| SortAscending_ComparisonPointer | .NET Core 3.1 | .NET Core 3.1 |     16 |   831.0 ms | 5.25 ms | 4.92 ms |           - |     - |     - |      1336 B |
|         SortAscending_Insertion | .NET Core 3.1 | .NET Core 3.1 |     16 |   525.9 ms | 1.82 ms | 1.70 ms |           - |     - |     - |           - |
