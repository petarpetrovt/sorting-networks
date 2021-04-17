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
| BoseNelson_Comparable |           .NET 5.0 |           .NET 5.0 |     28 | 9000000 | 124.8 ms | 0.24 ms | 0.19 ms | 124.8 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |           .NET 5.0 |           .NET 5.0 |     28 | 9000000 | 180.7 ms | 0.66 ms | 0.61 ms | 180.7 ms |     - |     - |     - |         - |
|  Insertion_Comparable |           .NET 5.0 |           .NET 5.0 |     28 | 9000000 | 113.8 ms | 0.38 ms | 0.35 ms | 113.7 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |           .NET 6.0 |           .NET 6.0 |     28 | 9000000 | 124.2 ms | 0.12 ms | 0.10 ms | 124.2 ms |     - |     - |     - |     144 B |
| BoseNelson_Branchless |           .NET 6.0 |           .NET 6.0 |     28 | 9000000 | 172.1 ms | 0.19 ms | 0.16 ms | 172.0 ms |     - |     - |     - |     144 B |
|  Insertion_Comparable |           .NET 6.0 |           .NET 6.0 |     28 | 9000000 | 121.5 ms | 2.41 ms | 5.08 ms | 123.7 ms |     - |     - |     - |     144 B |
| BoseNelson_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |     28 | 9000000 | 124.3 ms | 0.10 ms | 0.09 ms | 124.3 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |      .NET Core 3.1 |      .NET Core 3.1 |     28 | 9000000 | 171.5 ms | 0.23 ms | 0.19 ms | 171.5 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |     28 | 9000000 | 122.2 ms | 2.32 ms | 2.38 ms | 123.0 ms |     - |     - |     - |         - |
| BoseNelson_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |     28 | 9000000 | 129.3 ms | 0.19 ms | 0.17 ms | 129.3 ms |     - |     - |     - |         - |
| BoseNelson_Branchless | .NET Framework 4.8 | .NET Framework 4.8 |     28 | 9000000 | 172.2 ms | 0.15 ms | 0.12 ms | 172.2 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |     28 | 9000000 | 167.6 ms | 0.82 ms | 0.69 ms | 167.6 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |     28 | 9000000 |       NA |      NA |      NA |       NA |     - |     - |     - |         - |
| BoseNelson_Branchless |         CoreRT 6.0 |         CoreRT 6.0 |     28 | 9000000 |       NA |      NA |      NA |       NA |     - |     - |     - |         - |
|  Insertion_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |     28 | 9000000 |       NA |      NA |      NA |       NA |     - |     - |     - |         - |

Benchmarks with issues:
  SN28Benchmark.BoseNelson_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=28, Count=9000000]
  SN28Benchmark.BoseNelson_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=28, Count=9000000]
  SN28Benchmark.Insertion_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=28, Count=9000000]
