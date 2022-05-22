``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1706 (21H2)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
.NET SDK=6.0.105
  [Host]   : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  .NET 5.0 : .NET 5.0.17 (5.0.1722.21314), X64 RyuJIT
  .NET 6.0 : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT

InvocationCount=1  UnrollFactor=1  

```
|                Method |        Job |    Runtime | Length |   Count |     Mean |   Error |  StdDev | Ratio | RatioSD | Allocated |
|---------------------- |----------- |----------- |------- |-------- |---------:|--------:|--------:|------:|--------:|----------:|
| BoseNelson_Comparable |   .NET 5.0 |   .NET 5.0 |     28 | 9000000 | 126.8 ms | 0.16 ms | 0.15 ms |  1.00 |    0.00 |         - |
| BoseNelson_Comparable |   .NET 6.0 |   .NET 6.0 |     28 | 9000000 | 126.9 ms | 0.17 ms | 0.16 ms |  1.00 |    0.00 |     480 B |
| BoseNelson_Comparable | CoreRT 6.0 | CoreRT 6.0 |     28 | 9000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |         |          |         |         |       |         |           |
| BoseNelson_Branchless |   .NET 5.0 |   .NET 5.0 |     28 | 9000000 | 180.6 ms | 0.06 ms | 0.06 ms |  1.00 |    0.00 |         - |
| BoseNelson_Branchless |   .NET 6.0 |   .NET 6.0 |     28 | 9000000 | 252.4 ms | 3.49 ms | 2.91 ms |  1.40 |    0.02 |     480 B |
| BoseNelson_Branchless | CoreRT 6.0 | CoreRT 6.0 |     28 | 9000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |         |          |         |         |       |         |           |
|  Insertion_Comparable |   .NET 5.0 |   .NET 5.0 |     28 | 9000000 | 120.6 ms | 2.18 ms | 2.04 ms |  1.00 |    0.00 |         - |
|  Insertion_Comparable |   .NET 6.0 |   .NET 6.0 |     28 | 9000000 | 120.6 ms | 2.37 ms | 4.21 ms |  1.00 |    0.04 |     480 B |
|  Insertion_Comparable | CoreRT 6.0 | CoreRT 6.0 |     28 | 9000000 |       NA |      NA |      NA |     ? |       ? |         - |

Benchmarks with issues:
  SN28Benchmark.BoseNelson_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=28, Count=9000000]
  SN28Benchmark.BoseNelson_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=28, Count=9000000]
  SN28Benchmark.Insertion_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=28, Count=9000000]
