``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1706 (21H2)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
.NET SDK=6.0.105
  [Host]   : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  .NET 5.0 : .NET 5.0.17 (5.0.1722.21314), X64 RyuJIT
  .NET 6.0 : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT

InvocationCount=1  UnrollFactor=1  

```
|                Method |        Job |    Runtime | Length |    Count |     Mean |   Error |  StdDev | Ratio | RatioSD | Allocated |
|---------------------- |----------- |----------- |------- |--------- |---------:|--------:|--------:|------:|--------:|----------:|
| BoseNelson_Comparable |   .NET 5.0 |   .NET 5.0 |     20 | 11000000 | 119.9 ms | 0.32 ms | 0.30 ms |  1.00 |    0.00 |         - |
| BoseNelson_Comparable |   .NET 6.0 |   .NET 6.0 |     20 | 11000000 | 121.0 ms | 0.53 ms | 0.49 ms |  1.01 |    0.01 |     480 B |
| BoseNelson_Comparable | CoreRT 6.0 | CoreRT 6.0 |     20 | 11000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |          |          |         |         |       |         |           |
| BoseNelson_Branchless |   .NET 5.0 |   .NET 5.0 |     20 | 11000000 | 202.5 ms | 0.38 ms | 0.35 ms |  1.00 |    0.00 |         - |
| BoseNelson_Branchless |   .NET 6.0 |   .NET 6.0 |     20 | 11000000 | 203.1 ms | 0.06 ms | 0.06 ms |  1.00 |    0.00 |     480 B |
| BoseNelson_Branchless | CoreRT 6.0 | CoreRT 6.0 |     20 | 11000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |          |          |         |         |       |         |           |
|  Insertion_Comparable |   .NET 5.0 |   .NET 5.0 |     20 | 11000000 | 125.3 ms | 1.95 ms | 1.82 ms |  1.00 |    0.00 |         - |
|  Insertion_Comparable |   .NET 6.0 |   .NET 6.0 |     20 | 11000000 | 127.7 ms | 2.50 ms | 3.25 ms |  1.02 |    0.03 |     480 B |
|  Insertion_Comparable | CoreRT 6.0 | CoreRT 6.0 |     20 | 11000000 |       NA |      NA |      NA |     ? |       ? |         - |

Benchmarks with issues:
  SN20Benchmark.BoseNelson_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=20, Count=11000000]
  SN20Benchmark.BoseNelson_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=20, Count=11000000]
  SN20Benchmark.Insertion_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=20, Count=11000000]
