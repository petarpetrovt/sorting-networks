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
|                Method |                Job |            Runtime | Length |    Count |     Mean |   Error |  StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |------------------- |------------------- |------- |--------- |---------:|--------:|--------:|------:|------:|------:|----------:|
| BoseNelson_Comparable |           .NET 5.0 |           .NET 5.0 |     13 | 35000000 | 260.3 ms | 0.44 ms | 0.41 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |           .NET 5.0 |           .NET 5.0 |     13 | 35000000 | 152.4 ms | 1.03 ms | 0.96 ms |     - |     - |     - |         - |
|  BestKnown_Comparable |           .NET 5.0 |           .NET 5.0 |     13 | 35000000 | 275.0 ms | 0.56 ms | 0.49 ms |     - |     - |     - |         - |
|  BestKnown_Branchless |           .NET 5.0 |           .NET 5.0 |     13 | 35000000 | 118.1 ms | 0.20 ms | 0.18 ms |     - |     - |     - |         - |
|  Insertion_Comparable |           .NET 5.0 |           .NET 5.0 |     13 | 35000000 | 318.7 ms | 3.67 ms | 3.26 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |           .NET 6.0 |           .NET 6.0 |     13 | 35000000 | 259.0 ms | 0.29 ms | 0.26 ms |     - |     - |     - |     192 B |
| BoseNelson_Branchless |           .NET 6.0 |           .NET 6.0 |     13 | 35000000 | 153.3 ms | 0.26 ms | 0.24 ms |     - |     - |     - |     144 B |
|  BestKnown_Comparable |           .NET 6.0 |           .NET 6.0 |     13 | 35000000 | 273.0 ms | 1.76 ms | 1.65 ms |     - |     - |     - |     144 B |
|  BestKnown_Branchless |           .NET 6.0 |           .NET 6.0 |     13 | 35000000 | 118.1 ms | 0.24 ms | 0.18 ms |     - |     - |     - |     144 B |
|  Insertion_Comparable |           .NET 6.0 |           .NET 6.0 |     13 | 35000000 | 347.3 ms | 3.04 ms | 2.85 ms |     - |     - |     - |     144 B |
| BoseNelson_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |     13 | 35000000 | 261.2 ms | 0.67 ms | 0.62 ms |     - |     - |     - |   1,384 B |
| BoseNelson_Branchless |      .NET Core 3.1 |      .NET Core 3.1 |     13 | 35000000 | 151.5 ms | 0.27 ms | 0.22 ms |     - |     - |     - |         - |
|  BestKnown_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |     13 | 35000000 | 271.5 ms | 0.39 ms | 0.33 ms |     - |     - |     - |   1,384 B |
|  BestKnown_Branchless |      .NET Core 3.1 |      .NET Core 3.1 |     13 | 35000000 | 118.4 ms | 0.34 ms | 0.28 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |     13 | 35000000 | 330.7 ms | 2.00 ms | 1.77 ms |     - |     - |     - |         - |
| BoseNelson_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |     13 | 35000000 | 271.2 ms | 2.14 ms | 2.00 ms |     - |     - |     - |         - |
| BoseNelson_Branchless | .NET Framework 4.8 | .NET Framework 4.8 |     13 | 35000000 | 152.8 ms | 0.13 ms | 0.11 ms |     - |     - |     - |         - |
|  BestKnown_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |     13 | 35000000 | 280.0 ms | 1.91 ms | 1.79 ms |     - |     - |     - |         - |
|  BestKnown_Branchless | .NET Framework 4.8 | .NET Framework 4.8 |     13 | 35000000 | 118.6 ms | 0.16 ms | 0.14 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |     13 | 35000000 | 427.3 ms | 1.66 ms | 1.47 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |     13 | 35000000 |       NA |      NA |      NA |     - |     - |     - |         - |
| BoseNelson_Branchless |         CoreRT 6.0 |         CoreRT 6.0 |     13 | 35000000 |       NA |      NA |      NA |     - |     - |     - |         - |
|  BestKnown_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |     13 | 35000000 |       NA |      NA |      NA |     - |     - |     - |         - |
|  BestKnown_Branchless |         CoreRT 6.0 |         CoreRT 6.0 |     13 | 35000000 |       NA |      NA |      NA |     - |     - |     - |         - |
|  Insertion_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |     13 | 35000000 |       NA |      NA |      NA |     - |     - |     - |         - |

Benchmarks with issues:
  SN13Benchmark.BoseNelson_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=13, Count=35000000]
  SN13Benchmark.BoseNelson_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=13, Count=35000000]
  SN13Benchmark.BestKnown_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=13, Count=35000000]
  SN13Benchmark.BestKnown_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=13, Count=35000000]
  SN13Benchmark.Insertion_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=13, Count=35000000]
