``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.508 (2004/?/20H1)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=3.1.402
  [Host]        : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  .NET 4.8      : .NET Framework 4.8 (4.8.4220.0), X64 RyuJIT
  .NET Core 3.1 : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

InvocationCount=1  UnrollFactor=1  

```
|                          Method |           Job |       Runtime | Length |     Mean |   Error |  StdDev |       Gen 0 | Gen 1 | Gen 2 |   Allocated |
|-------------------------------- |-------------- |-------------- |------- |---------:|--------:|--------:|------------:|------:|------:|------------:|
|        SortAscending_Comparable |      .NET 4.8 |      .NET 4.8 |      4 | 219.3 ms | 4.12 ms | 4.23 ms |           - |     - |     - |           - |
|        SortAscending_Comparison |      .NET 4.8 |      .NET 4.8 |      4 | 487.4 ms | 6.17 ms | 5.77 ms | 612000.0000 |     - |     - | 802370144 B |
| SortAscending_ComparisonPointer |      .NET 4.8 |      .NET 4.8 |      4 | 291.5 ms | 2.09 ms | 1.96 ms |           - |     - |     - |           - |
|         SortAscending_Insertion |      .NET 4.8 |      .NET 4.8 |      4 | 347.7 ms | 2.38 ms | 2.22 ms |           - |     - |     - |           - |
|        SortAscending_Comparable | .NET Core 3.1 | .NET Core 3.1 |      4 | 214.0 ms | 2.11 ms | 1.98 ms |           - |     - |     - |           - |
|        SortAscending_Comparison | .NET Core 3.1 | .NET Core 3.1 |      4 | 507.4 ms | 3.34 ms | 3.12 ms |  95000.0000 |     - |     - | 799999936 B |
| SortAscending_ComparisonPointer | .NET Core 3.1 | .NET Core 3.1 |      4 | 324.9 ms | 2.08 ms | 1.94 ms |           - |     - |     - |           - |
|         SortAscending_Insertion | .NET Core 3.1 | .NET Core 3.1 |      4 | 294.0 ms | 2.08 ms | 1.94 ms |           - |     - |     - |      1448 B |
