``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.508 (2004/?/20H1)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
  [Host]        : .NET Framework 4.8 (4.8.4220.0), X64 RyuJIT
  .NET 4.8      : .NET Framework 4.8 (4.8.4220.0), X64 RyuJIT
  .NET Core 3.1 : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

InvocationCount=1  UnrollFactor=1  

```
|                          Method |           Job |       Runtime | Length |      Mean |     Error |    StdDev |    Median | Code Size |       Gen 0 | Gen 1 | Gen 2 |   Allocated |
|-------------------------------- |-------------- |-------------- |------- |----------:|----------:|----------:|----------:|----------:|------------:|------:|------:|------------:|
|        SortAscending_Comparable |      .NET 4.8 |      .NET 4.8 |      2 |  8.267 ms | 0.0365 ms | 0.0324 ms |  8.270 ms |      90 B |           - |     - |     - |           - |
|        SortAscending_Comparison |      .NET 4.8 |      .NET 4.8 |      2 | 53.111 ms | 0.7275 ms | 0.6075 ms | 53.074 ms |     216 B | 244000.0000 |     - |     - | 320951264 B |
| SortAscending_ComparisonPointer |      .NET 4.8 |      .NET 4.8 |      2 | 18.345 ms | 0.3792 ms | 1.1181 ms | 17.552 ms |     128 B |           - |     - |     - |           - |
|         SortAscending_Insertion |      .NET 4.8 |      .NET 4.8 |      2 | 31.523 ms | 0.6084 ms | 0.5691 ms | 31.727 ms |     517 B |           - |     - |     - |           - |
|        SortAscending_Comparable | .NET Core 3.1 | .NET Core 3.1 |      2 |  8.397 ms | 0.1304 ms | 0.1220 ms |  8.420 ms |      90 B |           - |     - |     - |           - |
|        SortAscending_Comparison | .NET Core 3.1 | .NET Core 3.1 |      2 | 48.974 ms | 0.8839 ms | 0.7381 ms | 49.311 ms |     219 B |  38000.0000 |     - |     - | 320000000 B |
| SortAscending_ComparisonPointer | .NET Core 3.1 | .NET Core 3.1 |      2 | 16.270 ms | 0.0336 ms | 0.0280 ms | 16.274 ms |     128 B |           - |     - |     - |           - |
|         SortAscending_Insertion | .NET Core 3.1 | .NET Core 3.1 |      2 | 27.083 ms | 0.3402 ms | 0.3183 ms | 27.124 ms |     268 B |           - |     - |     - |           - |
