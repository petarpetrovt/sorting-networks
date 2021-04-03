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
|                Method |                Job |            Runtime | Length |    Count |     Mean |   Error |   StdDev |   Median | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |------------------- |------------------- |------- |--------- |---------:|--------:|---------:|---------:|------:|------:|------:|----------:|
| BoseNelson_Comparable |           .NET 5.0 |           .NET 5.0 |     12 | 36000000 | 266.0 ms | 2.75 ms |  2.57 ms | 266.5 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |           .NET 5.0 |           .NET 5.0 |     12 | 36000000 | 142.6 ms | 0.08 ms |  0.06 ms | 142.6 ms |     - |     - |     - |         - |
|  BestKnown_Comparable |           .NET 5.0 |           .NET 5.0 |     12 | 36000000 | 267.6 ms | 0.67 ms |  0.59 ms | 267.6 ms |     - |     - |     - |      48 B |
|  BestKnown_Branchless |           .NET 5.0 |           .NET 5.0 |     12 | 36000000 | 105.5 ms | 0.49 ms |  0.46 ms | 105.3 ms |     - |     - |     - |         - |
|  Insertion_Comparable |           .NET 5.0 |           .NET 5.0 |     12 | 36000000 | 327.4 ms | 6.53 ms | 15.76 ms | 316.8 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |           .NET 6.0 |           .NET 6.0 |     12 | 36000000 | 262.6 ms | 0.54 ms |  0.51 ms | 262.5 ms |     - |     - |     - |     192 B |
| BoseNelson_Branchless |           .NET 6.0 |           .NET 6.0 |     12 | 36000000 | 143.6 ms | 0.93 ms |  0.87 ms | 143.4 ms |     - |     - |     - |     144 B |
|  BestKnown_Comparable |           .NET 6.0 |           .NET 6.0 |     12 | 36000000 | 271.3 ms | 0.52 ms |  0.48 ms | 271.1 ms |     - |     - |     - |     272 B |
|  BestKnown_Branchless |           .NET 6.0 |           .NET 6.0 |     12 | 36000000 | 106.0 ms | 0.54 ms |  0.51 ms | 105.9 ms |     - |     - |     - |     144 B |
|  Insertion_Comparable |           .NET 6.0 |           .NET 6.0 |     12 | 36000000 | 342.2 ms | 2.34 ms |  2.19 ms | 342.6 ms |     - |     - |     - |     144 B |
| BoseNelson_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |     12 | 36000000 | 262.6 ms | 0.46 ms |  0.41 ms | 262.4 ms |     - |     - |     - |   1,384 B |
| BoseNelson_Branchless |      .NET Core 3.1 |      .NET Core 3.1 |     12 | 36000000 | 142.5 ms | 0.38 ms |  0.35 ms | 142.3 ms |     - |     - |     - |         - |
|  BestKnown_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |     12 | 36000000 | 270.1 ms | 2.21 ms |  2.07 ms | 269.5 ms |     - |     - |     - |   1,336 B |
|  BestKnown_Branchless |      .NET Core 3.1 |      .NET Core 3.1 |     12 | 36000000 | 105.2 ms | 0.07 ms |  0.05 ms | 105.3 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |     12 | 36000000 | 331.2 ms | 3.51 ms |  3.28 ms | 331.5 ms |     - |     - |     - |  14,584 B |
| BoseNelson_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |     12 | 36000000 | 265.3 ms | 1.84 ms |  1.72 ms | 265.3 ms |     - |     - |     - |         - |
| BoseNelson_Branchless | .NET Framework 4.8 | .NET Framework 4.8 |     12 | 36000000 | 143.1 ms | 0.15 ms |  0.12 ms | 143.1 ms |     - |     - |     - |         - |
|  BestKnown_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |     12 | 36000000 | 279.7 ms | 1.39 ms |  1.30 ms | 280.0 ms |     - |     - |     - |         - |
|  BestKnown_Branchless | .NET Framework 4.8 | .NET Framework 4.8 |     12 | 36000000 | 106.1 ms | 0.35 ms |  0.33 ms | 106.0 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |     12 | 36000000 | 423.7 ms | 1.25 ms |  1.17 ms | 424.0 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |     12 | 36000000 |       NA |      NA |       NA |       NA |     - |     - |     - |         - |
| BoseNelson_Branchless |         CoreRT 6.0 |         CoreRT 6.0 |     12 | 36000000 |       NA |      NA |       NA |       NA |     - |     - |     - |         - |
|  BestKnown_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |     12 | 36000000 |       NA |      NA |       NA |       NA |     - |     - |     - |         - |
|  BestKnown_Branchless |         CoreRT 6.0 |         CoreRT 6.0 |     12 | 36000000 |       NA |      NA |       NA |       NA |     - |     - |     - |         - |
|  Insertion_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |     12 | 36000000 |       NA |      NA |       NA |       NA |     - |     - |     - |         - |

Benchmarks with issues:
  SN12Benchmark.BoseNelson_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=12, Count=36000000]
  SN12Benchmark.BoseNelson_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=12, Count=36000000]
  SN12Benchmark.BestKnown_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=12, Count=36000000]
  SN12Benchmark.BestKnown_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=12, Count=36000000]
  SN12Benchmark.Insertion_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=12, Count=36000000]
