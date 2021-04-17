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
|                Method |                Job |            Runtime | Length |   Count |     Mean |   Error |  StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |------------------- |------------------- |------- |-------- |---------:|--------:|--------:|------:|------:|------:|----------:|
| BoseNelson_Comparable |           .NET 5.0 |           .NET 5.0 |     26 | 9000000 | 122.8 ms | 0.41 ms | 0.36 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |           .NET 5.0 |           .NET 5.0 |     26 | 9000000 | 247.5 ms | 0.57 ms | 0.53 ms |     - |     - |     - |      48 B |
|  Insertion_Comparable |           .NET 5.0 |           .NET 5.0 |     26 | 9000000 | 109.5 ms | 0.46 ms | 0.43 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |           .NET 6.0 |           .NET 6.0 |     26 | 9000000 | 123.5 ms | 0.29 ms | 0.26 ms |     - |     - |     - |     144 B |
| BoseNelson_Branchless |           .NET 6.0 |           .NET 6.0 |     26 | 9000000 | 247.0 ms | 0.76 ms | 0.71 ms |     - |     - |     - |     144 B |
|  Insertion_Comparable |           .NET 6.0 |           .NET 6.0 |     26 | 9000000 | 118.5 ms | 2.32 ms | 3.55 ms |     - |     - |     - |     144 B |
| BoseNelson_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |     26 | 9000000 | 122.9 ms | 0.26 ms | 0.23 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |      .NET Core 3.1 |      .NET Core 3.1 |     26 | 9000000 | 254.7 ms | 2.50 ms | 2.34 ms |     - |     - |     - |      48 B |
|  Insertion_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |     26 | 9000000 | 118.7 ms | 2.06 ms | 1.92 ms |     - |     - |     - |         - |
| BoseNelson_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |     26 | 9000000 | 128.5 ms | 0.33 ms | 0.31 ms |     - |     - |     - |         - |
| BoseNelson_Branchless | .NET Framework 4.8 | .NET Framework 4.8 |     26 | 9000000 | 255.2 ms | 0.57 ms | 0.53 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |     26 | 9000000 | 158.5 ms | 0.46 ms | 0.40 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |     26 | 9000000 |       NA |      NA |      NA |     - |     - |     - |         - |
| BoseNelson_Branchless |         CoreRT 6.0 |         CoreRT 6.0 |     26 | 9000000 |       NA |      NA |      NA |     - |     - |     - |         - |
|  Insertion_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |     26 | 9000000 |       NA |      NA |      NA |     - |     - |     - |         - |

Benchmarks with issues:
  SN26Benchmark.BoseNelson_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=26, Count=9000000]
  SN26Benchmark.BoseNelson_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=26, Count=9000000]
  SN26Benchmark.Insertion_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=26, Count=9000000]
