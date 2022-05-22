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
| BoseNelson_Comparable |   .NET 5.0 |   .NET 5.0 |      2 | 110000000 | 267.2 ms | 0.40 ms | 0.36 ms |  1.00 |    0.00 |         - |
| BoseNelson_Comparable |   .NET 6.0 |   .NET 6.0 |      2 | 110000000 | 274.9 ms | 0.18 ms | 0.16 ms |  1.03 |    0.00 |     480 B |
| BoseNelson_Comparable | CoreRT 6.0 | CoreRT 6.0 |      2 | 110000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |           |          |         |         |       |         |           |
| BoseNelson_Branchless |   .NET 5.0 |   .NET 5.0 |      2 | 110000000 | 120.9 ms | 0.30 ms | 0.27 ms |  1.00 |    0.00 |         - |
| BoseNelson_Branchless |   .NET 6.0 |   .NET 6.0 |      2 | 110000000 | 120.3 ms | 1.07 ms | 0.94 ms |  1.00 |    0.01 |     480 B |
| BoseNelson_Branchless | CoreRT 6.0 | CoreRT 6.0 |      2 | 110000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |           |          |         |         |       |         |           |
|  Insertion_Comparable |   .NET 5.0 |   .NET 5.0 |      2 | 110000000 | 458.0 ms | 1.44 ms | 1.35 ms |  1.00 |    0.00 |         - |
|  Insertion_Comparable |   .NET 6.0 |   .NET 6.0 |      2 | 110000000 | 458.8 ms | 1.09 ms | 1.02 ms |  1.00 |    0.00 |     480 B |
|  Insertion_Comparable | CoreRT 6.0 | CoreRT 6.0 |      2 | 110000000 |       NA |      NA |      NA |     ? |       ? |         - |

Benchmarks with issues:
  SN02Benchmark.BoseNelson_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=2, Count=110000000]
  SN02Benchmark.BoseNelson_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=2, Count=110000000]
  SN02Benchmark.Insertion_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=2, Count=110000000]
