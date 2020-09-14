``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.508 (2004/?/20H1)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
  [Host]        : .NET Framework 4.8 (4.8.4220.0), X64 RyuJIT
  .NET 4.8      : .NET Framework 4.8 (4.8.4220.0), X64 RyuJIT
  .NET Core 3.1 : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

InvocationCount=1  UnrollFactor=1  

```
|                          Method |           Job |       Runtime | Length |      Mean |    Error |   StdDev | Code Size |      Gen 0 | Gen 1 | Gen 2 |  Allocated |
|-------------------------------- |-------------- |-------------- |------- |----------:|---------:|---------:|----------:|-----------:|------:|------:|-----------:|
|        SortAscending_Comparable |      .NET 4.8 |      .NET 4.8 |     16 |  21.00 ms | 0.278 ms | 0.232 ms |    2262 B |          - |     - |     - |          - |
|        SortAscending_Comparison |      .NET 4.8 |      .NET 4.8 |     16 | 156.62 ms | 1.278 ms | 1.133 ms |    1579 B | 30000.0000 |     - |     - | 40118864 B |
| SortAscending_ComparisonPointer |      .NET 4.8 |      .NET 4.8 |     16 |  75.25 ms | 1.276 ms | 1.193 ms |    2403 B |          - |     - |     - |          - |
|         SortAscending_Insertion |      .NET 4.8 |      .NET 4.8 |     16 |  18.63 ms | 0.349 ms | 0.273 ms |     517 B |          - |     - |     - |          - |
|        SortAscending_Comparable | .NET Core 3.1 | .NET Core 3.1 |     16 |  21.34 ms | 0.244 ms | 0.217 ms |    2262 B |          - |     - |     - |          - |
|        SortAscending_Comparison | .NET Core 3.1 | .NET Core 3.1 |     16 | 148.17 ms | 0.748 ms | 0.663 ms |    1585 B |  4000.0000 |     - |     - | 40000000 B |
| SortAscending_ComparisonPointer | .NET Core 3.1 | .NET Core 3.1 |     16 |  86.00 ms | 0.990 ms | 0.878 ms |    2403 B |          - |     - |     - |          - |
|         SortAscending_Insertion | .NET Core 3.1 | .NET Core 3.1 |     16 |  11.23 ms | 0.124 ms | 0.104 ms |     268 B |          - |     - |     - |          - |
