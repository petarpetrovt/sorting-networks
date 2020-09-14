``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.508 (2004/?/20H1)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
  [Host]        : .NET Framework 4.8 (4.8.4220.0), X64 RyuJIT
  .NET 4.8      : .NET Framework 4.8 (4.8.4220.0), X64 RyuJIT
  .NET Core 3.1 : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

InvocationCount=1  UnrollFactor=1  

```
|                          Method |           Job |       Runtime | Length |      Mean |     Error |    StdDev |      Gen 0 | Gen 1 | Gen 2 |  Allocated | Code Size |
|-------------------------------- |-------------- |-------------- |------- |----------:|----------:|----------:|-----------:|------:|------:|-----------:|----------:|
|        SortAscending_Comparable |      .NET 4.8 |      .NET 4.8 |      7 | 10.354 ms | 0.0531 ms | 0.0497 ms |          - |     - |     - |          - |     447 B |
|        SortAscending_Comparison |      .NET 4.8 |      .NET 4.8 |      7 | 96.457 ms | 0.6634 ms | 0.5881 ms | 69000.0000 |     - |     - | 91699128 B |     450 B |
| SortAscending_ComparisonPointer |      .NET 4.8 |      .NET 4.8 |      7 | 46.793 ms | 0.4124 ms | 0.3857 ms |          - |     - |     - |          - |     551 B |
|         SortAscending_Insertion |      .NET 4.8 |      .NET 4.8 |      7 | 20.074 ms | 0.1011 ms | 0.0845 ms |          - |     - |     - |          - |     517 B |
|        SortAscending_Comparable | .NET Core 3.1 | .NET Core 3.1 |      7 |  9.672 ms | 0.0758 ms | 0.0709 ms |          - |     - |     - |          - |     447 B |
|        SortAscending_Comparison | .NET Core 3.1 | .NET Core 3.1 |      7 | 95.434 ms | 0.6332 ms | 0.5613 ms | 10000.0000 |     - |     - | 91428608 B |     456 B |
| SortAscending_ComparisonPointer | .NET Core 3.1 | .NET Core 3.1 |      7 | 51.379 ms | 0.2536 ms | 0.2372 ms |          - |     - |     - |          - |     551 B |
|         SortAscending_Insertion | .NET Core 3.1 | .NET Core 3.1 |      7 | 13.624 ms | 0.0808 ms | 0.0716 ms |          - |     - |     - |          - |     268 B |
