``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.508 (2004/?/20H1)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
  [Host]        : .NET Framework 4.8 (4.8.4220.0), X64 RyuJIT
  .NET 4.8      : .NET Framework 4.8 (4.8.4220.0), X64 RyuJIT
  .NET Core 3.1 : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

InvocationCount=1  UnrollFactor=1  

```
|                          Method |           Job |       Runtime | Length |      Mean |     Error |    StdDev |      Gen 0 | Gen 1 | Gen 2 |   Allocated | Code Size |
|-------------------------------- |-------------- |-------------- |------- |----------:|----------:|----------:|-----------:|------:|------:|------------:|----------:|
|        SortAscending_Comparable |      .NET 4.8 |      .NET 4.8 |      6 |  9.273 ms | 0.0793 ms | 0.0742 ms |          - |     - |     - |           - |     369 B |
|        SortAscending_Comparison |      .NET 4.8 |      .NET 4.8 |      6 | 87.550 ms | 0.7125 ms | 0.6665 ms | 81000.0000 |     - |     - | 106986456 B |     386 B |
| SortAscending_ComparisonPointer |      .NET 4.8 |      .NET 4.8 |      6 | 41.613 ms | 0.3326 ms | 0.3111 ms |          - |     - |     - |           - |     435 B |
|         SortAscending_Insertion |      .NET 4.8 |      .NET 4.8 |      6 | 21.529 ms | 0.2274 ms | 0.2128 ms |          - |     - |     - |           - |     517 B |
|        SortAscending_Comparable | .NET Core 3.1 | .NET Core 3.1 |      6 |  9.271 ms | 0.0421 ms | 0.0352 ms |          - |     - |     - |           - |     369 B |
|        SortAscending_Comparison | .NET Core 3.1 | .NET Core 3.1 |      6 | 84.214 ms | 1.6682 ms | 1.6384 ms | 12000.0000 |     - |     - | 106666688 B |     392 B |
| SortAscending_ComparisonPointer | .NET Core 3.1 | .NET Core 3.1 |      6 | 46.825 ms | 0.1674 ms | 0.1484 ms |          - |     - |     - |           - |     435 B |
|         SortAscending_Insertion | .NET Core 3.1 | .NET Core 3.1 |      6 | 14.419 ms | 0.1459 ms | 0.1365 ms |          - |     - |     - |           - |     268 B |
