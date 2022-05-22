``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1706 (21H2)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
.NET SDK=6.0.105
  [Host]   : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  .NET 5.0 : .NET 5.0.17 (5.0.1722.21314), X64 RyuJIT
  .NET 6.0 : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT

InvocationCount=1  UnrollFactor=1  

```
|                Method |        Job |    Runtime | Length |     Count |     Mean |   Error |  StdDev | Ratio | RatioSD | Allocated |
|---------------------- |----------- |----------- |------- |---------- |---------:|--------:|--------:|------:|--------:|----------:|
| BoseNelson_Comparable |   .NET 5.0 |   .NET 5.0 |      3 | 110000000 | 339.9 ms | 0.88 ms | 0.83 ms |  1.00 |    0.00 |         - |
| BoseNelson_Comparable |   .NET 6.0 |   .NET 6.0 |      3 | 110000000 | 334.1 ms | 1.18 ms | 1.04 ms |  0.98 |    0.00 |     480 B |
| BoseNelson_Comparable | CoreRT 6.0 | CoreRT 6.0 |      3 | 110000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |           |          |         |         |       |         |           |
| BoseNelson_Branchless |   .NET 5.0 |   .NET 5.0 |      3 | 110000000 | 116.4 ms | 1.17 ms | 1.03 ms |  1.00 |    0.00 |         - |
| BoseNelson_Branchless |   .NET 6.0 |   .NET 6.0 |      3 | 110000000 | 116.5 ms | 0.81 ms | 0.72 ms |  1.00 |    0.01 |     480 B |
| BoseNelson_Branchless | CoreRT 6.0 | CoreRT 6.0 |      3 | 110000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |           |          |         |         |       |         |           |
|  Insertion_Comparable |   .NET 5.0 |   .NET 5.0 |      3 | 110000000 | 520.5 ms | 2.72 ms | 2.55 ms |  1.00 |    0.00 |         - |
|  Insertion_Comparable |   .NET 6.0 |   .NET 6.0 |      3 | 110000000 | 523.8 ms | 2.02 ms | 1.89 ms |  1.01 |    0.00 |     480 B |
|  Insertion_Comparable | CoreRT 6.0 | CoreRT 6.0 |      3 | 110000000 |       NA |      NA |      NA |     ? |       ? |         - |

Benchmarks with issues:
  SN03Benchmark.BoseNelson_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=3, Count=110000000]
  SN03Benchmark.BoseNelson_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=3, Count=110000000]
  SN03Benchmark.Insertion_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=3, Count=110000000]
