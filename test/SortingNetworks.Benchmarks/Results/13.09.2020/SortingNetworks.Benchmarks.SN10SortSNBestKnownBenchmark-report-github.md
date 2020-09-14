``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.508 (2004/?/20H1)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
  [Host]        : .NET Framework 4.8 (4.8.4220.0), X64 RyuJIT
  .NET 4.8      : .NET Framework 4.8 (4.8.4220.0), X64 RyuJIT
  .NET Core 3.1 : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

InvocationCount=1  UnrollFactor=1  

```
|                          Method |           Job |       Runtime | Length |      Mean |    Error |   StdDev |      Gen 0 | Gen 1 | Gen 2 |  Allocated | Code Size |
|-------------------------------- |-------------- |-------------- |------- |----------:|---------:|---------:|-----------:|------:|------:|-----------:|----------:|
|        SortAscending_Comparable |      .NET 4.8 |      .NET 4.8 |     10 |  17.53 ms | 0.240 ms | 0.225 ms |          - |     - |     - |          - |     754 B |
|        SortAscending_Comparison |      .NET 4.8 |      .NET 4.8 |     10 | 124.08 ms | 0.825 ms | 0.731 ms | 48000.0000 |     - |     - | 64196736 B |     687 B |
| SortAscending_ComparisonPointer |      .NET 4.8 |      .NET 4.8 |     10 |  57.69 ms | 0.352 ms | 0.329 ms |          - |     - |     - |          - |    1024 B |
|         SortAscending_Insertion |      .NET 4.8 |      .NET 4.8 |     10 |  19.08 ms | 0.156 ms | 0.146 ms |          - |     - |     - |          - |     517 B |
|        SortAscending_Comparable | .NET Core 3.1 | .NET Core 3.1 |     10 |  16.81 ms | 0.137 ms | 0.128 ms |          - |     - |     - |          - |     754 B |
|        SortAscending_Comparison | .NET Core 3.1 | .NET Core 3.1 |     10 | 116.01 ms | 0.693 ms | 0.648 ms |  7000.0000 |     - |     - | 64000000 B |     693 B |
| SortAscending_ComparisonPointer | .NET Core 3.1 | .NET Core 3.1 |     10 |  65.61 ms | 0.614 ms | 0.513 ms |          - |     - |     - |          - |    1024 B |
|         SortAscending_Insertion | .NET Core 3.1 | .NET Core 3.1 |     10 |  14.81 ms | 0.201 ms | 0.188 ms |          - |     - |     - |          - |     268 B |
