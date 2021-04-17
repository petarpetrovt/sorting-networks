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
| BoseNelson_Comparable |           .NET 5.0 |           .NET 5.0 |     10 | 45000000 | 304.3 ms | 0.98 ms | 0.92 ms |     - |     - |     - |      48 B |
| BoseNelson_Branchless |           .NET 5.0 |           .NET 5.0 |     10 | 45000000 | 148.8 ms | 0.27 ms | 0.24 ms |     - |     - |     - |         - |
|  BestKnown_Comparable |           .NET 5.0 |           .NET 5.0 |     10 | 45000000 | 304.9 ms | 0.70 ms | 0.62 ms |     - |     - |     - |      48 B |
|  BestKnown_Branchless |           .NET 5.0 |           .NET 5.0 |     10 | 45000000 | 111.3 ms | 0.76 ms | 0.71 ms |     - |     - |     - |         - |
|  Insertion_Comparable |           .NET 5.0 |           .NET 5.0 |     10 | 45000000 | 371.5 ms | 2.92 ms | 2.44 ms |     - |     - |     - |      48 B |
| BoseNelson_Comparable |           .NET 6.0 |           .NET 6.0 |     10 | 45000000 | 319.0 ms | 4.19 ms | 3.92 ms |     - |     - |     - |     144 B |
| BoseNelson_Branchless |           .NET 6.0 |           .NET 6.0 |     10 | 45000000 | 148.7 ms | 0.27 ms | 0.24 ms |     - |     - |     - |     144 B |
|  BestKnown_Comparable |           .NET 6.0 |           .NET 6.0 |     10 | 45000000 | 306.3 ms | 1.04 ms | 0.97 ms |     - |     - |     - |     144 B |
|  BestKnown_Branchless |           .NET 6.0 |           .NET 6.0 |     10 | 45000000 | 110.1 ms | 0.45 ms | 0.37 ms |     - |     - |     - |     144 B |
|  Insertion_Comparable |           .NET 6.0 |           .NET 6.0 |     10 | 45000000 | 398.4 ms | 2.48 ms | 2.32 ms |     - |     - |     - |     192 B |
| BoseNelson_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |     10 | 45000000 | 305.1 ms | 1.46 ms | 1.22 ms |     - |     - |     - |   1,336 B |
| BoseNelson_Branchless |      .NET Core 3.1 |      .NET Core 3.1 |     10 | 45000000 | 148.6 ms | 0.32 ms | 0.28 ms |     - |     - |     - |         - |
|  BestKnown_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |     10 | 45000000 | 309.1 ms | 2.64 ms | 2.47 ms |     - |     - |     - |         - |
|  BestKnown_Branchless |      .NET Core 3.1 |      .NET Core 3.1 |     10 | 45000000 | 110.6 ms | 0.37 ms | 0.34 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |     10 | 45000000 | 385.0 ms | 2.21 ms | 2.07 ms |     - |     - |     - |   1,384 B |
| BoseNelson_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |     10 | 45000000 | 314.8 ms | 2.13 ms | 1.99 ms |     - |     - |     - |         - |
| BoseNelson_Branchless | .NET Framework 4.8 | .NET Framework 4.8 |     10 | 45000000 | 150.5 ms | 0.62 ms | 0.52 ms |     - |     - |     - |         - |
|  BestKnown_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |     10 | 45000000 | 311.8 ms | 3.82 ms | 3.57 ms |     - |     - |     - |         - |
|  BestKnown_Branchless | .NET Framework 4.8 | .NET Framework 4.8 |     10 | 45000000 | 111.0 ms | 0.72 ms | 0.68 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |     10 | 45000000 | 487.0 ms | 3.61 ms | 3.38 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |     10 | 45000000 |       NA |      NA |      NA |     - |     - |     - |         - |
| BoseNelson_Branchless |         CoreRT 6.0 |         CoreRT 6.0 |     10 | 45000000 |       NA |      NA |      NA |     - |     - |     - |         - |
|  BestKnown_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |     10 | 45000000 |       NA |      NA |      NA |     - |     - |     - |         - |
|  BestKnown_Branchless |         CoreRT 6.0 |         CoreRT 6.0 |     10 | 45000000 |       NA |      NA |      NA |     - |     - |     - |         - |
|  Insertion_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |     10 | 45000000 |       NA |      NA |      NA |     - |     - |     - |         - |

Benchmarks with issues:
  SN10Benchmark.BoseNelson_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=10, Count=45000000]
  SN10Benchmark.BoseNelson_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=10, Count=45000000]
  SN10Benchmark.BestKnown_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=10, Count=45000000]
  SN10Benchmark.BestKnown_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=10, Count=45000000]
  SN10Benchmark.Insertion_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=10, Count=45000000]
