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
|        SortAscending_Comparable |      .NET 4.8 |      .NET 4.8 |     11 |  18.18 ms | 0.107 ms | 0.100 ms |          - |     - |     - |          - |     971 B |
|        SortAscending_Comparison |      .NET 4.8 |      .NET 4.8 |     11 | 123.80 ms | 1.478 ms | 1.383 ms | 44000.0000 |     - |     - | 58355488 B |     798 B |
| SortAscending_ComparisonPointer |      .NET 4.8 |      .NET 4.8 |     11 |  69.65 ms | 0.376 ms | 0.314 ms |          - |     - |     - |          - |    1237 B |
|         SortAscending_Insertion |      .NET 4.8 |      .NET 4.8 |     11 |  18.99 ms | 0.182 ms | 0.161 ms |          - |     - |     - |          - |     517 B |
|        SortAscending_Comparable | .NET Core 3.1 | .NET Core 3.1 |     11 |  18.38 ms | 0.103 ms | 0.091 ms |          - |     - |     - |          - |     971 B |
|        SortAscending_Comparison | .NET Core 3.1 | .NET Core 3.1 |     11 | 126.73 ms | 0.878 ms | 0.821 ms |  6000.0000 |     - |     - | 58181824 B |     804 B |
| SortAscending_ComparisonPointer | .NET Core 3.1 | .NET Core 3.1 |     11 |  69.23 ms | 0.388 ms | 0.344 ms |          - |     - |     - |          - |    1237 B |
|         SortAscending_Insertion | .NET Core 3.1 | .NET Core 3.1 |     11 |  11.99 ms | 0.103 ms | 0.091 ms |          - |     - |     - |          - |     268 B |
