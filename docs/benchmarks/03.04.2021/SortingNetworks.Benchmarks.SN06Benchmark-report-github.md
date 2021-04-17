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
| BoseNelson_Comparable |           .NET 5.0 |           .NET 5.0 |      6 | 85000000 | 418.7 ms |  1.47 ms |  1.30 ms |     - |     - |     - |      48 B |
| BoseNelson_Branchless |           .NET 5.0 |           .NET 5.0 |      6 | 85000000 | 175.2 ms |  3.27 ms |  3.06 ms |     - |     - |     - |         - |
|  Insertion_Comparable |           .NET 5.0 |           .NET 5.0 |      6 | 85000000 | 586.8 ms |  7.48 ms |  6.99 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |           .NET 6.0 |           .NET 6.0 |      6 | 85000000 | 412.4 ms |  0.56 ms |  0.44 ms |     - |     - |     - |     192 B |
| BoseNelson_Branchless |           .NET 6.0 |           .NET 6.0 |      6 | 85000000 | 169.4 ms |  0.51 ms |  0.45 ms |     - |     - |     - |     144 B |
|  Insertion_Comparable |           .NET 6.0 |           .NET 6.0 |      6 | 85000000 | 588.8 ms | 11.60 ms | 11.39 ms |     - |     - |     - |     184 B |
| BoseNelson_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |      6 | 85000000 | 416.8 ms |  1.31 ms |  1.23 ms |     - |     - |     - |      48 B |
| BoseNelson_Branchless |      .NET Core 3.1 |      .NET Core 3.1 |      6 | 85000000 | 191.4 ms |  0.90 ms |  0.84 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |      6 | 85000000 | 580.0 ms |  2.76 ms |  2.30 ms |     - |     - |     - |      48 B |
| BoseNelson_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |      6 | 85000000 | 419.6 ms |  1.56 ms |  1.39 ms |     - |     - |     - |         - |
| BoseNelson_Branchless | .NET Framework 4.8 | .NET Framework 4.8 |      6 | 85000000 | 189.3 ms |  0.17 ms |  0.15 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |      6 | 85000000 | 694.7 ms |  4.31 ms |  3.82 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |      6 | 85000000 |       NA |       NA |       NA |     - |     - |     - |         - |
| BoseNelson_Branchless |         CoreRT 6.0 |         CoreRT 6.0 |      6 | 85000000 |       NA |       NA |       NA |     - |     - |     - |         - |
|  Insertion_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |      6 | 85000000 |       NA |       NA |       NA |     - |     - |     - |         - |

Benchmarks with issues:
  SN06Benchmark.BoseNelson_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=6, Count=85000000]
  SN06Benchmark.BoseNelson_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=6, Count=85000000]
  SN06Benchmark.Insertion_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=6, Count=85000000]
