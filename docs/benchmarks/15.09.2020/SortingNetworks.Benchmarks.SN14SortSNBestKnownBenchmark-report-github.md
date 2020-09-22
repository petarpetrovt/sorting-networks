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
|        SortAscending_Comparable |      .NET 4.8 |      .NET 4.8 |     14 |   447.4 ms | 2.43 ms | 2.27 ms |           - |     - |     - |           - |
|        SortAscending_Comparison |      .NET 4.8 |      .NET 4.8 |     14 | 1,079.4 ms | 2.40 ms | 2.12 ms | 174000.0000 |     - |     - | 229252048 B |
| SortAscending_ComparisonPointer |      .NET 4.8 |      .NET 4.8 |     14 |   746.2 ms | 2.62 ms | 2.45 ms |           - |     - |     - |           - |
|         SortAscending_Insertion |      .NET 4.8 |      .NET 4.8 |     14 |   654.4 ms | 3.97 ms | 3.72 ms |           - |     - |     - |           - |
|        SortAscending_Comparable | .NET Core 3.1 | .NET Core 3.1 |     14 |   440.1 ms | 2.14 ms | 1.90 ms |           - |     - |     - |      1336 B |
|        SortAscending_Comparison | .NET Core 3.1 | .NET Core 3.1 |     14 | 1,228.5 ms | 2.97 ms | 2.78 ms |  27000.0000 |     - |     - | 228571392 B |
| SortAscending_ComparisonPointer | .NET Core 3.1 | .NET Core 3.1 |     14 |   790.0 ms | 5.55 ms | 5.19 ms |           - |     - |     - |      1336 B |
|         SortAscending_Insertion | .NET Core 3.1 | .NET Core 3.1 |     14 |   499.9 ms | 2.69 ms | 2.52 ms |           - |     - |     - |           - |
