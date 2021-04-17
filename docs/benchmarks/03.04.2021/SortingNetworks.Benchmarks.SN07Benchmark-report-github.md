``` ini

BenchmarkDotNet=v0.12.1.1521-nightly, OS=Windows 10.0.19042.867 (20H2/October2020Update)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
.NET SDK=6.0.100-preview.2.21155.3
  [Host]             : .NET 6.0.0 (6.0.21.15406), X64 RyuJIT
  .NET 5.0           : .NET 5.0.4 (5.0.421.11614), X64 RyuJIT
  .NET 6.0           : .NET 6.0.0 (6.0.21.15406), X64 RyuJIT
  .NET Core 3.1      : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT
  .NET Framework 4.8 : .NET Framework 4.8 (4.8.4300.0), X64 RyuJIT

InvocationCount=1  UnrollFactor=1  

```
|                Method |                Job |            Runtime | Length |    Count |     Mean |    Error |   StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |------------------- |------------------- |------- |--------- |---------:|---------:|---------:|------:|------:|------:|----------:|
| BoseNelson_Comparable |           .NET 5.0 |           .NET 5.0 |      7 | 85000000 | 443.8 ms |  3.05 ms |  2.85 ms |     - |     - |     - |      48 B |
| BoseNelson_Branchless |           .NET 5.0 |           .NET 5.0 |      7 | 85000000 | 187.2 ms |  0.42 ms |  0.37 ms |     - |     - |     - |         - |
|  Insertion_Comparable |           .NET 5.0 |           .NET 5.0 |      7 | 85000000 | 620.0 ms |  2.98 ms |  2.49 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |           .NET 6.0 |           .NET 6.0 |      7 | 85000000 | 464.4 ms |  1.54 ms |  1.29 ms |     - |     - |     - |     272 B |
| BoseNelson_Branchless |           .NET 6.0 |           .NET 6.0 |      7 | 85000000 | 186.9 ms |  0.74 ms |  0.66 ms |     - |     - |     - |     144 B |
|  Insertion_Comparable |           .NET 6.0 |           .NET 6.0 |      7 | 85000000 | 647.9 ms | 12.54 ms | 13.94 ms |     - |     - |     - |     800 B |
| BoseNelson_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |      7 | 85000000 | 448.5 ms |  0.86 ms |  0.72 ms |     - |     - |     - |   1,384 B |
| BoseNelson_Branchless |      .NET Core 3.1 |      .NET Core 3.1 |      7 | 85000000 | 187.0 ms |  0.17 ms |  0.13 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |      7 | 85000000 | 638.2 ms |  3.31 ms |  3.10 ms |     - |     - |     - |         - |
| BoseNelson_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |      7 | 85000000 | 476.8 ms |  9.28 ms |  8.68 ms |     - |     - |     - |         - |
| BoseNelson_Branchless | .NET Framework 4.8 | .NET Framework 4.8 |      7 | 85000000 | 187.2 ms |  0.36 ms |  0.33 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |      7 | 85000000 | 764.3 ms |  8.37 ms |  7.83 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |      7 | 85000000 |       NA |       NA |       NA |     - |     - |     - |         - |
| BoseNelson_Branchless |         CoreRT 6.0 |         CoreRT 6.0 |      7 | 85000000 |       NA |       NA |       NA |     - |     - |     - |         - |
|  Insertion_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |      7 | 85000000 |       NA |       NA |       NA |     - |     - |     - |         - |

Benchmarks with issues:
  SN07Benchmark.BoseNelson_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=7, Count=85000000]
  SN07Benchmark.BoseNelson_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=7, Count=85000000]
  SN07Benchmark.Insertion_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=7, Count=85000000]
