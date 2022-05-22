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
| BoseNelson_Comparable |   .NET 5.0 |   .NET 5.0 |     26 | 9000000 | 123.5 ms | 0.14 ms | 0.12 ms |  1.00 |    0.00 |         - |
| BoseNelson_Comparable |   .NET 6.0 |   .NET 6.0 |     26 | 9000000 | 125.7 ms | 0.26 ms | 0.24 ms |  1.02 |    0.00 |     480 B |
| BoseNelson_Comparable | CoreRT 6.0 | CoreRT 6.0 |     26 | 9000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |         |          |         |         |       |         |           |
| BoseNelson_Branchless |   .NET 5.0 |   .NET 5.0 |     26 | 9000000 | 258.4 ms | 0.37 ms | 0.33 ms |  1.00 |    0.00 |         - |
| BoseNelson_Branchless |   .NET 6.0 |   .NET 6.0 |     26 | 9000000 | 249.6 ms | 0.57 ms | 0.53 ms |  0.97 |    0.00 |     480 B |
| BoseNelson_Branchless | CoreRT 6.0 | CoreRT 6.0 |     26 | 9000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |         |          |         |         |       |         |           |
|  Insertion_Comparable |   .NET 5.0 |   .NET 5.0 |     26 | 9000000 | 112.0 ms | 0.55 ms | 0.48 ms |  1.00 |    0.00 |         - |
|  Insertion_Comparable |   .NET 6.0 |   .NET 6.0 |     26 | 9000000 | 118.1 ms | 2.32 ms | 4.07 ms |  1.05 |    0.04 |     480 B |
|  Insertion_Comparable | CoreRT 6.0 | CoreRT 6.0 |     26 | 9000000 |       NA |      NA |      NA |     ? |       ? |         - |

Benchmarks with issues:
  SN26Benchmark.BoseNelson_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=26, Count=9000000]
  SN26Benchmark.BoseNelson_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=26, Count=9000000]
  SN26Benchmark.Insertion_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=26, Count=9000000]
