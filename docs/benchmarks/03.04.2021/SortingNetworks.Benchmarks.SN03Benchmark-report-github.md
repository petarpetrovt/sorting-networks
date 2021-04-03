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
|                Method |                Job |            Runtime | Length |     Count |     Mean |   Error |  StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |------------------- |------------------- |------- |---------- |---------:|--------:|--------:|------:|------:|------:|----------:|
| BoseNelson_Comparable |           .NET 5.0 |           .NET 5.0 |      3 | 110000000 | 326.2 ms | 0.92 ms | 0.82 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |           .NET 5.0 |           .NET 5.0 |      3 | 110000000 | 119.1 ms | 2.36 ms | 4.20 ms |     - |     - |     - |         - |
|  Insertion_Comparable |           .NET 5.0 |           .NET 5.0 |      3 | 110000000 | 510.1 ms | 2.85 ms | 2.67 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |           .NET 6.0 |           .NET 6.0 |      3 | 110000000 | 327.9 ms | 0.50 ms | 0.45 ms |     - |     - |     - |     192 B |
| BoseNelson_Branchless |           .NET 6.0 |           .NET 6.0 |      3 | 110000000 | 117.0 ms | 1.98 ms | 1.76 ms |     - |     - |     - |     144 B |
|  Insertion_Comparable |           .NET 6.0 |           .NET 6.0 |      3 | 110000000 | 522.3 ms | 1.56 ms | 1.38 ms |     - |     - |     - |     192 B |
| BoseNelson_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |      3 | 110000000 | 334.3 ms | 2.29 ms | 2.14 ms |     - |     - |     - |   1,336 B |
| BoseNelson_Branchless |      .NET Core 3.1 |      .NET Core 3.1 |      3 | 110000000 | 117.4 ms | 2.32 ms | 2.85 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |      3 | 110000000 | 518.8 ms | 1.56 ms | 1.46 ms |     - |     - |     - |   1,336 B |
| BoseNelson_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |      3 | 110000000 | 336.8 ms | 0.46 ms | 0.39 ms |     - |     - |     - |         - |
| BoseNelson_Branchless | .NET Framework 4.8 | .NET Framework 4.8 |      3 | 110000000 | 116.9 ms | 2.20 ms | 2.06 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |      3 | 110000000 | 614.6 ms | 5.47 ms | 5.11 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |      3 | 110000000 |       NA |      NA |      NA |     - |     - |     - |         - |
| BoseNelson_Branchless |         CoreRT 6.0 |         CoreRT 6.0 |      3 | 110000000 |       NA |      NA |      NA |     - |     - |     - |         - |
|  Insertion_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |      3 | 110000000 |       NA |      NA |      NA |     - |     - |     - |         - |

Benchmarks with issues:
  SN03Benchmark.BoseNelson_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=3, Count=110000000]
  SN03Benchmark.BoseNelson_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=3, Count=110000000]
  SN03Benchmark.Insertion_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=3, Count=110000000]
