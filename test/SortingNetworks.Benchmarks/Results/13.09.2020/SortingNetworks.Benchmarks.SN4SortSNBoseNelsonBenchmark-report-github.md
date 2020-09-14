``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.508 (2004/?/20H1)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
  [Host]        : .NET Framework 4.8 (4.8.4220.0), X64 RyuJIT
  .NET 4.8      : .NET Framework 4.8 (4.8.4220.0), X64 RyuJIT
  .NET Core 3.1 : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

InvocationCount=1  UnrollFactor=1  

```
|                          Method |           Job |       Runtime | Length |      Mean |     Error |    StdDev |    Median |       Gen 0 | Gen 1 | Gen 2 |   Allocated | Code Size |
|-------------------------------- |-------------- |-------------- |------- |----------:|----------:|----------:|----------:|------------:|------:|------:|------------:|----------:|
|        SortAscending_Comparable |      .NET 4.8 |      .NET 4.8 |      4 |  9.887 ms | 0.0712 ms | 0.0631 ms |  9.869 ms |           - |     - |     - |           - |     199 B |
|        SortAscending_Comparison |      .NET 4.8 |      .NET 4.8 |      4 | 67.127 ms | 1.2706 ms | 1.1885 ms | 67.144 ms | 122000.0000 |     - |     - | 160475632 B |     272 B |
| SortAscending_ComparisonPointer |      .NET 4.8 |      .NET 4.8 |      4 | 28.269 ms | 0.5358 ms | 0.5011 ms | 28.310 ms |           - |     - |     - |           - |     248 B |
|         SortAscending_Insertion |      .NET 4.8 |      .NET 4.8 |      4 | 23.181 ms | 0.2571 ms | 0.2280 ms | 23.183 ms |           - |     - |     - |           - |     517 B |
|        SortAscending_Comparable | .NET Core 3.1 | .NET Core 3.1 |      4 | 14.762 ms | 0.5429 ms | 1.6006 ms | 15.512 ms |           - |     - |     - |           - |     199 B |
|        SortAscending_Comparison | .NET Core 3.1 | .NET Core 3.1 |      4 | 63.944 ms | 0.6553 ms | 0.5472 ms | 64.022 ms |  19000.0000 |     - |     - | 160000000 B |     278 B |
| SortAscending_ComparisonPointer | .NET Core 3.1 | .NET Core 3.1 |      4 | 30.570 ms | 0.0455 ms | 0.0403 ms | 30.577 ms |           - |     - |     - |           - |     248 B |
|         SortAscending_Insertion | .NET Core 3.1 | .NET Core 3.1 |      4 | 16.003 ms | 0.1172 ms | 0.0978 ms | 15.984 ms |           - |     - |     - |           - |     268 B |
