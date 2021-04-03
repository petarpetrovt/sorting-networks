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
|                Method |                Job |            Runtime | Length |    Count |     Mean |   Error |  StdDev |   Median | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |------------------- |------------------- |------- |--------- |---------:|--------:|--------:|---------:|------:|------:|------:|----------:|
| BoseNelson_Comparable |           .NET 5.0 |           .NET 5.0 |      5 | 90000000 | 377.1 ms | 0.75 ms | 0.66 ms | 377.2 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |           .NET 5.0 |           .NET 5.0 |      5 | 90000000 | 153.0 ms | 1.36 ms | 1.06 ms | 152.5 ms |     - |     - |     - |         - |
|  Insertion_Comparable |           .NET 5.0 |           .NET 5.0 |      5 | 90000000 | 528.6 ms | 4.77 ms | 4.23 ms | 528.3 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |           .NET 6.0 |           .NET 6.0 |      5 | 90000000 | 378.1 ms | 2.76 ms | 2.44 ms | 377.6 ms |     - |     - |     - |     192 B |
| BoseNelson_Branchless |           .NET 6.0 |           .NET 6.0 |      5 | 90000000 | 156.0 ms | 3.10 ms | 8.48 ms | 150.7 ms |     - |     - |     - |     144 B |
|  Insertion_Comparable |           .NET 6.0 |           .NET 6.0 |      5 | 90000000 | 541.3 ms | 2.82 ms | 2.64 ms | 540.4 ms |     - |     - |     - |     192 B |
| BoseNelson_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |      5 | 90000000 | 393.7 ms | 1.13 ms | 0.94 ms | 393.8 ms |     - |     - |     - |      48 B |
| BoseNelson_Branchless |      .NET Core 3.1 |      .NET Core 3.1 |      5 | 90000000 | 168.6 ms | 0.15 ms | 0.13 ms | 168.5 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |      5 | 90000000 | 532.6 ms | 2.02 ms | 1.89 ms | 532.6 ms |     - |     - |     - |   1,336 B |
| BoseNelson_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |      5 | 90000000 | 399.0 ms | 3.38 ms | 3.00 ms | 399.0 ms |     - |     - |     - |         - |
| BoseNelson_Branchless | .NET Framework 4.8 | .NET Framework 4.8 |      5 | 90000000 | 152.3 ms | 0.40 ms | 0.36 ms | 152.2 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |      5 | 90000000 | 656.6 ms | 3.81 ms | 3.56 ms | 655.9 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |      5 | 90000000 |       NA |      NA |      NA |       NA |     - |     - |     - |         - |
| BoseNelson_Branchless |         CoreRT 6.0 |         CoreRT 6.0 |      5 | 90000000 |       NA |      NA |      NA |       NA |     - |     - |     - |         - |
|  Insertion_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |      5 | 90000000 |       NA |      NA |      NA |       NA |     - |     - |     - |         - |

Benchmarks with issues:
  SN05Benchmark.BoseNelson_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=5, Count=90000000]
  SN05Benchmark.BoseNelson_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=5, Count=90000000]
  SN05Benchmark.Insertion_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=5, Count=90000000]
