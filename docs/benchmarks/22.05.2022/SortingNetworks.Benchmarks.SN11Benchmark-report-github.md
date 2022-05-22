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
| BoseNelson_Comparable |   .NET 5.0 |   .NET 5.0 |     11 | 43000000 | 302.4 ms | 1.07 ms | 1.00 ms |  1.00 |    0.00 |         - |
| BoseNelson_Comparable |   .NET 6.0 |   .NET 6.0 |     11 | 43000000 | 308.9 ms | 2.36 ms | 2.21 ms |  1.02 |    0.01 |     480 B |
| BoseNelson_Comparable | CoreRT 6.0 | CoreRT 6.0 |     11 | 43000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |          |          |         |         |       |         |           |
| BoseNelson_Branchless |   .NET 5.0 |   .NET 5.0 |     11 | 43000000 | 148.2 ms | 0.11 ms | 0.10 ms |  1.00 |    0.00 |         - |
| BoseNelson_Branchless |   .NET 6.0 |   .NET 6.0 |     11 | 43000000 | 149.6 ms | 1.02 ms | 0.91 ms |  1.01 |    0.01 |     480 B |
| BoseNelson_Branchless | CoreRT 6.0 | CoreRT 6.0 |     11 | 43000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |          |          |         |         |       |         |           |
|  BestKnown_Comparable |   .NET 5.0 |   .NET 5.0 |     11 | 43000000 | 317.6 ms | 2.12 ms | 1.88 ms |  1.00 |    0.00 |   1,400 B |
|  BestKnown_Comparable |   .NET 6.0 |   .NET 6.0 |     11 | 43000000 | 313.9 ms | 1.11 ms | 0.99 ms |  0.99 |    0.01 |     480 B |
|  BestKnown_Comparable | CoreRT 6.0 | CoreRT 6.0 |     11 | 43000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |          |          |         |         |       |         |           |
|  BestKnown_Branchless |   .NET 5.0 |   .NET 5.0 |     11 | 43000000 | 112.4 ms | 0.35 ms | 0.31 ms |  1.00 |    0.00 |         - |
|  BestKnown_Branchless |   .NET 6.0 |   .NET 6.0 |     11 | 43000000 | 112.1 ms | 0.30 ms | 0.25 ms |  1.00 |    0.00 |     480 B |
|  BestKnown_Branchless | CoreRT 6.0 | CoreRT 6.0 |     11 | 43000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |          |          |         |         |       |         |           |
|  Insertion_Comparable |   .NET 5.0 |   .NET 5.0 |     11 | 43000000 | 382.8 ms | 3.33 ms | 2.95 ms |  1.00 |    0.00 |         - |
|  Insertion_Comparable |   .NET 6.0 |   .NET 6.0 |     11 | 43000000 | 392.1 ms | 5.21 ms | 4.87 ms |  1.02 |    0.01 |     480 B |
|  Insertion_Comparable | CoreRT 6.0 | CoreRT 6.0 |     11 | 43000000 |       NA |      NA |      NA |     ? |       ? |         - |

Benchmarks with issues:
  SN11Benchmark.BoseNelson_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=11, Count=43000000]
  SN11Benchmark.BoseNelson_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=11, Count=43000000]
  SN11Benchmark.BestKnown_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=11, Count=43000000]
  SN11Benchmark.BestKnown_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=11, Count=43000000]
  SN11Benchmark.Insertion_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=11, Count=43000000]
