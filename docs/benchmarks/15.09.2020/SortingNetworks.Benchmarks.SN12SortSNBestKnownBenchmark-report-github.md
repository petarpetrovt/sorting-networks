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
|        SortAscending_Comparable |      .NET 4.8 |      .NET 4.8 |     12 |   392.6 ms |  2.28 ms |  2.13 ms |           - |     - |     - |           - |
|        SortAscending_Comparison |      .NET 4.8 |      .NET 4.8 |     12 | 1,028.7 ms | 14.11 ms | 12.51 ms | 204000.0000 |     - |     - | 267462176 B |
| SortAscending_ComparisonPointer |      .NET 4.8 |      .NET 4.8 |     12 |   637.9 ms |  1.88 ms |  1.75 ms |           - |     - |     - |           - |
|         SortAscending_Insertion |      .NET 4.8 |      .NET 4.8 |     12 |   603.7 ms |  1.96 ms |  1.64 ms |           - |     - |     - |           - |
|        SortAscending_Comparable | .NET Core 3.1 | .NET Core 3.1 |     12 |   386.8 ms |  1.75 ms |  1.46 ms |           - |     - |     - |        48 B |
|        SortAscending_Comparison | .NET Core 3.1 | .NET Core 3.1 |     12 | 1,076.7 ms |  9.77 ms |  9.14 ms |  31000.0000 |     - |     - | 266666624 B |
| SortAscending_ComparisonPointer | .NET Core 3.1 | .NET Core 3.1 |     12 |   682.9 ms |  1.55 ms |  1.45 ms |           - |     - |     - |           - |
|         SortAscending_Insertion | .NET Core 3.1 | .NET Core 3.1 |     12 |   492.7 ms |  4.02 ms |  3.57 ms |           - |     - |     - |           - |
