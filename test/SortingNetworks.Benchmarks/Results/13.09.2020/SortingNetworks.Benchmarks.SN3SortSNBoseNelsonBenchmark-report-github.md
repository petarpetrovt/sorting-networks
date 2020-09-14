``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.508 (2004/?/20H1)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
  [Host]        : .NET Framework 4.8 (4.8.4220.0), X64 RyuJIT
  .NET 4.8      : .NET Framework 4.8 (4.8.4220.0), X64 RyuJIT
  .NET Core 3.1 : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

InvocationCount=1  UnrollFactor=1  

```
|                          Method |           Job |       Runtime | Length |     Mean |    Error |   StdDev |   Median |       Gen 0 | Gen 1 | Gen 2 |   Allocated | Code Size |
|-------------------------------- |-------------- |-------------- |------- |---------:|---------:|---------:|---------:|------------:|------:|------:|------------:|----------:|
|        SortAscending_Comparable |      .NET 4.8 |      .NET 4.8 |      3 | 10.90 ms | 0.044 ms | 0.039 ms | 10.91 ms |           - |     - |     - |           - |     148 B |
|        SortAscending_Comparison |      .NET 4.8 |      .NET 4.8 |      3 | 59.69 ms | 0.540 ms | 0.451 ms | 59.67 ms | 163000.0000 |     - |     - | 213964808 B |     236 B |
| SortAscending_ComparisonPointer |      .NET 4.8 |      .NET 4.8 |      3 | 25.40 ms | 0.124 ms | 0.116 ms | 25.40 ms |           - |     - |     - |           - |     195 B |
|         SortAscending_Insertion |      .NET 4.8 |      .NET 4.8 |      3 | 24.69 ms | 0.453 ms | 0.423 ms | 24.63 ms |           - |     - |     - |           - |     517 B |
|        SortAscending_Comparable | .NET Core 3.1 | .NET Core 3.1 |      3 | 10.92 ms | 0.020 ms | 0.019 ms | 10.92 ms |           - |     - |     - |           - |     148 B |
|        SortAscending_Comparison | .NET Core 3.1 | .NET Core 3.1 |      3 | 60.61 ms | 1.037 ms | 0.919 ms | 60.70 ms |  25000.0000 |     - |     - | 213333376 B |     242 B |
| SortAscending_ComparisonPointer | .NET Core 3.1 | .NET Core 3.1 |      3 | 27.74 ms | 0.110 ms | 0.092 ms | 27.77 ms |           - |     - |     - |           - |     195 B |
|         SortAscending_Insertion | .NET Core 3.1 | .NET Core 3.1 |      3 | 20.66 ms | 0.413 ms | 0.880 ms | 20.99 ms |           - |     - |     - |           - |     268 B |
