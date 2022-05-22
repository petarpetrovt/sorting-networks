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
| BoseNelson_Comparable |   .NET 5.0 |   .NET 5.0 |     15 | 21000000 | 175.6 ms | 0.23 ms | 0.18 ms |  1.00 |    0.00 |         - |
| BoseNelson_Comparable |   .NET 6.0 |   .NET 6.0 |     15 | 21000000 | 178.8 ms | 1.90 ms | 1.78 ms |  1.02 |    0.01 |     480 B |
| BoseNelson_Comparable | CoreRT 6.0 | CoreRT 6.0 |     15 | 21000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |          |          |         |         |       |         |           |
| BoseNelson_Branchless |   .NET 5.0 |   .NET 5.0 |     15 | 21000000 | 205.2 ms | 1.62 ms | 1.51 ms |  1.00 |    0.00 |         - |
| BoseNelson_Branchless |   .NET 6.0 |   .NET 6.0 |     15 | 21000000 | 212.2 ms | 1.12 ms | 0.99 ms |  1.03 |    0.01 |     480 B |
| BoseNelson_Branchless | CoreRT 6.0 | CoreRT 6.0 |     15 | 21000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |          |          |         |         |       |         |           |
|  BestKnown_Comparable |   .NET 5.0 |   .NET 5.0 |     15 | 21000000 | 198.1 ms | 2.36 ms | 2.21 ms |  1.00 |    0.00 |         - |
|  BestKnown_Comparable |   .NET 6.0 |   .NET 6.0 |     15 | 21000000 | 193.9 ms | 0.26 ms | 0.23 ms |  0.98 |    0.01 |     480 B |
|  BestKnown_Comparable | CoreRT 6.0 | CoreRT 6.0 |     15 | 21000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |          |          |         |         |       |         |           |
|  BestKnown_Branchless |   .NET 5.0 |   .NET 5.0 |     15 | 21000000 | 148.6 ms | 2.34 ms | 2.07 ms |  1.00 |    0.00 |         - |
|  BestKnown_Branchless |   .NET 6.0 |   .NET 6.0 |     15 | 21000000 | 146.6 ms | 1.25 ms | 1.11 ms |  0.99 |    0.01 |     480 B |
|  BestKnown_Branchless | CoreRT 6.0 | CoreRT 6.0 |     15 | 21000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |          |          |         |         |       |         |           |
|  Insertion_Comparable |   .NET 5.0 |   .NET 5.0 |     15 | 21000000 | 214.3 ms | 1.25 ms | 1.17 ms |  1.00 |    0.00 |         - |
|  Insertion_Comparable |   .NET 6.0 |   .NET 6.0 |     15 | 21000000 | 213.2 ms | 4.20 ms | 5.61 ms |  0.99 |    0.03 |     480 B |
|  Insertion_Comparable | CoreRT 6.0 | CoreRT 6.0 |     15 | 21000000 |       NA |      NA |      NA |     ? |       ? |         - |

Benchmarks with issues:
  SN15Benchmark.BoseNelson_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=15, Count=21000000]
  SN15Benchmark.BoseNelson_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=15, Count=21000000]
  SN15Benchmark.BestKnown_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=15, Count=21000000]
  SN15Benchmark.BestKnown_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=15, Count=21000000]
  SN15Benchmark.Insertion_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=15, Count=21000000]