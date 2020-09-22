``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.508 (2004/?/20H1)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=3.1.402
  [Host]        : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  .NET 4.8      : .NET Framework 4.8 (4.8.4220.0), X64 RyuJIT
  .NET Core 3.1 : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

InvocationCount=1  UnrollFactor=1  

```
|                          Method |           Job |       Runtime | Length |     Mean |   Error |  StdDev |       Gen 0 | Gen 1 | Gen 2 |    Allocated |
|-------------------------------- |-------------- |-------------- |------- |---------:|--------:|--------:|------------:|------:|------:|-------------:|
|        SortAscending_Comparable |      .NET 4.8 |      .NET 4.8 |      3 | 187.4 ms | 3.64 ms | 3.40 ms |           - |     - |     - |            - |
|        SortAscending_Comparison |      .NET 4.8 |      .NET 4.8 |      3 | 412.3 ms | 1.04 ms | 0.97 ms | 816000.0000 |     - |     - | 1069824128 B |
| SortAscending_ComparisonPointer |      .NET 4.8 |      .NET 4.8 |      3 | 244.0 ms | 2.67 ms | 2.37 ms |           - |     - |     - |            - |
|         SortAscending_Insertion |      .NET 4.8 |      .NET 4.8 |      3 | 312.2 ms | 2.28 ms | 2.14 ms |           - |     - |     - |            - |
|        SortAscending_Comparable | .NET Core 3.1 | .NET Core 3.1 |      3 | 186.5 ms | 3.60 ms | 3.85 ms |           - |     - |     - |        560 B |
|        SortAscending_Comparison | .NET Core 3.1 | .NET Core 3.1 |      3 | 441.4 ms | 3.65 ms | 3.41 ms | 127000.0000 |     - |     - | 1066666624 B |
| SortAscending_ComparisonPointer | .NET Core 3.1 | .NET Core 3.1 |      3 | 250.2 ms | 1.54 ms | 1.44 ms |           - |     - |     - |       1336 B |
|         SortAscending_Insertion | .NET Core 3.1 | .NET Core 3.1 |      3 | 269.5 ms | 2.44 ms | 2.28 ms |           - |     - |     - |       1384 B |
