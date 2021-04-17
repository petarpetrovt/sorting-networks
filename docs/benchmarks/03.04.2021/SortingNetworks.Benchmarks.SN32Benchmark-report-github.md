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
| BoseNelson_Comparable |           .NET 5.0 |           .NET 5.0 |     32 | 9000000 | 134.8 ms | 0.29 ms | 0.26 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |           .NET 5.0 |           .NET 5.0 |     32 | 9000000 | 165.2 ms | 0.67 ms | 0.56 ms |     - |     - |     - |         - |
|  Insertion_Comparable |           .NET 5.0 |           .NET 5.0 |     32 | 9000000 | 122.6 ms | 0.25 ms | 0.23 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |           .NET 6.0 |           .NET 6.0 |     32 | 9000000 | 136.1 ms | 0.76 ms | 0.71 ms |     - |     - |     - |     144 B |
| BoseNelson_Branchless |           .NET 6.0 |           .NET 6.0 |     32 | 9000000 | 162.7 ms | 0.83 ms | 0.73 ms |     - |     - |     - |     144 B |
|  Insertion_Comparable |           .NET 6.0 |           .NET 6.0 |     32 | 9000000 | 123.1 ms | 0.51 ms | 0.46 ms |     - |     - |     - |     144 B |
| BoseNelson_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |     32 | 9000000 | 135.1 ms | 0.45 ms | 0.42 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |      .NET Core 3.1 |      .NET Core 3.1 |     32 | 9000000 | 170.5 ms | 1.15 ms | 0.96 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET Core 3.1 |      .NET Core 3.1 |     32 | 9000000 | 131.5 ms | 2.60 ms | 4.75 ms |     - |     - |     - |         - |
| BoseNelson_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |     32 | 9000000 | 138.9 ms | 0.29 ms | 0.26 ms |     - |     - |     - |         - |
| BoseNelson_Branchless | .NET Framework 4.8 | .NET Framework 4.8 |     32 | 9000000 | 161.9 ms | 0.57 ms | 0.53 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Framework 4.8 | .NET Framework 4.8 |     32 | 9000000 | 179.9 ms | 0.53 ms | 0.49 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |     32 | 9000000 |       NA |      NA |      NA |     - |     - |     - |         - |
| BoseNelson_Branchless |         CoreRT 6.0 |         CoreRT 6.0 |     32 | 9000000 |       NA |      NA |      NA |     - |     - |     - |         - |
|  Insertion_Comparable |         CoreRT 6.0 |         CoreRT 6.0 |     32 | 9000000 |       NA |      NA |      NA |     - |     - |     - |         - |

Benchmarks with issues:
  SN32Benchmark.BoseNelson_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=32, Count=9000000]
  SN32Benchmark.BoseNelson_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=32, Count=9000000]
  SN32Benchmark.Insertion_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=32, Count=9000000]
