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
|                Method |                Job |            Runtime | Length |   Count |     Mean |   Error |  StdDev |   Median | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |------------------- |------------------- |------- |-------- |---------:|--------:|--------:|---------:|------:|------:|------:|----------:|
| BoseNelson_Comparable |           .NET 5.0 |           .NET 5.0 |     27 | 9000000 | 124.2 ms | 0.18 ms | 0.16 ms | 124.2 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |           .NET 5.0 |           .NET 5.0 |     27 | 9000000 | 237.1 ms | 2.04 ms | 1.91 ms | 237.3 ms |     - |     - |     - |      48 B |
|  Insertion_Comparable |           .NET 5.0 |           .NET 5.0 |     27 | 9000000 | 111.6 ms | 0.15 ms | 0.12 ms | 111.6 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |           .NET 6.0 |           .NET 6.0 |     27 | 9000000 | 123.8 ms | 0.29 ms | 0.24 ms | 123.7 ms |     - |     - |     - |     144 B |
| BoseNelson_Branchless |           .NET 6.0 |           .NET 6.0 |     27 | 9000000 | 236.6 ms | 1.50 ms | 1.33 ms | 236.9 ms |     - |     - |     - |     144 B |
|  Insertion_Comparable |           .NET 6.0 |           .NET 6.0 |     27 | 9000000 | 120.4 ms | 2.40 ms | 5.17 ms | 122.8 ms |     - |     - |     - |     144 B |
| BoseNelson_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |     27 | 9000000 | 124.4 ms | 0.33 ms | 0.29 ms | 124.3 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |      .NET Core 3.1 |      .NET Core 3.1 |     27 | 9000000 | 240.1 ms | 0.61 ms | 0.57 ms | 240.1 ms |     - |     - |     - |      48 B |
|  Insertion_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |     27 | 9000000 | 120.1 ms | 2.32 ms | 2.39 ms | 120.5 ms |     - |     - |     - |         - |
| BoseNelson_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |     27 | 9000000 | 130.2 ms | 0.26 ms | 0.23 ms | 130.3 ms |     - |     - |     - |         - |
| BoseNelson_Branchless | .NET Framework 4.8 | .NET Framework 4.8 |     27 | 9000000 | 239.2 ms | 0.56 ms | 0.50 ms | 239.2 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |     27 | 9000000 | 162.2 ms | 0.58 ms | 0.52 ms | 162.1 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |     27 | 9000000 |       NA |      NA |      NA |       NA |     - |     - |     - |         - |
| BoseNelson_Branchless |         CoreRT 6.0 |         CoreRT 6.0 |     27 | 9000000 |       NA |      NA |      NA |       NA |     - |     - |     - |         - |
|  Insertion_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |     27 | 9000000 |       NA |      NA |      NA |       NA |     - |     - |     - |         - |

Benchmarks with issues:
  SN27Benchmark.BoseNelson_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=27, Count=9000000]
  SN27Benchmark.BoseNelson_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=27, Count=9000000]
  SN27Benchmark.Insertion_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=27, Count=9000000]
