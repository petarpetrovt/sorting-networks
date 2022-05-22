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
| BoseNelson_Comparable |   .NET 5.0 |   .NET 5.0 |      9 | 50000000 | 324.5 ms | 0.57 ms | 0.51 ms |  1.00 |    0.00 |         - |
| BoseNelson_Comparable |   .NET 6.0 |   .NET 6.0 |      9 | 50000000 | 325.0 ms | 0.67 ms | 0.60 ms |  1.00 |    0.00 |     480 B |
| BoseNelson_Comparable | CoreRT 6.0 | CoreRT 6.0 |      9 | 50000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |          |          |         |         |       |         |           |
| BoseNelson_Branchless |   .NET 5.0 |   .NET 5.0 |      9 | 50000000 | 143.4 ms | 0.09 ms | 0.08 ms |  1.00 |    0.00 |         - |
| BoseNelson_Branchless |   .NET 6.0 |   .NET 6.0 |      9 | 50000000 | 143.2 ms | 0.11 ms | 0.09 ms |  1.00 |    0.00 |     480 B |
| BoseNelson_Branchless | CoreRT 6.0 | CoreRT 6.0 |      9 | 50000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |          |          |         |         |       |         |           |
|  BestKnown_Comparable |   .NET 5.0 |   .NET 5.0 |      9 | 50000000 | 325.7 ms | 0.74 ms | 0.58 ms |  1.00 |    0.00 |         - |
|  BestKnown_Comparable |   .NET 6.0 |   .NET 6.0 |      9 | 50000000 | 325.4 ms | 0.77 ms | 0.68 ms |  1.00 |    0.00 |     480 B |
|  BestKnown_Comparable | CoreRT 6.0 | CoreRT 6.0 |      9 | 50000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |          |          |         |         |       |         |           |
|  BestKnown_Branchless |   .NET 5.0 |   .NET 5.0 |      9 | 50000000 | 118.6 ms | 0.23 ms | 0.21 ms |  1.00 |    0.00 |         - |
|  BestKnown_Branchless |   .NET 6.0 |   .NET 6.0 |      9 | 50000000 | 118.4 ms | 0.35 ms | 0.29 ms |  1.00 |    0.00 |     480 B |
|  BestKnown_Branchless | CoreRT 6.0 | CoreRT 6.0 |      9 | 50000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |          |          |         |         |       |         |           |
|  Insertion_Comparable |   .NET 5.0 |   .NET 5.0 |      9 | 50000000 | 433.5 ms | 3.03 ms | 2.69 ms |  1.00 |    0.00 |         - |
|  Insertion_Comparable |   .NET 6.0 |   .NET 6.0 |      9 | 50000000 | 427.2 ms | 2.93 ms | 2.74 ms |  0.99 |    0.01 |     480 B |
|  Insertion_Comparable | CoreRT 6.0 | CoreRT 6.0 |      9 | 50000000 |       NA |      NA |      NA |     ? |       ? |         - |

Benchmarks with issues:
  SN09Benchmark.BoseNelson_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=9, Count=50000000]
  SN09Benchmark.BoseNelson_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=9, Count=50000000]
  SN09Benchmark.BestKnown_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=9, Count=50000000]
  SN09Benchmark.BestKnown_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=9, Count=50000000]
  SN09Benchmark.Insertion_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=9, Count=50000000]
