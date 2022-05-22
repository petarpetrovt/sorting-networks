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
| BoseNelson_Comparable |   .NET 5.0 |   .NET 5.0 |     14 | 22000000 | 179.4 ms | 0.17 ms | 0.15 ms |  1.00 |    0.00 |         - |
| BoseNelson_Comparable |   .NET 6.0 |   .NET 6.0 |     14 | 22000000 | 179.0 ms | 2.23 ms | 1.98 ms |  1.00 |    0.01 |     480 B |
| BoseNelson_Comparable | CoreRT 6.0 | CoreRT 6.0 |     14 | 22000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |          |          |         |         |       |         |           |
| BoseNelson_Branchless |   .NET 5.0 |   .NET 5.0 |     14 | 22000000 | 207.0 ms | 0.15 ms | 0.14 ms |  1.00 |    0.00 |         - |
| BoseNelson_Branchless |   .NET 6.0 |   .NET 6.0 |     14 | 22000000 | 199.5 ms | 0.67 ms | 0.59 ms |  0.96 |    0.00 |     480 B |
| BoseNelson_Branchless | CoreRT 6.0 | CoreRT 6.0 |     14 | 22000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |          |          |         |         |       |         |           |
|  BestKnown_Comparable |   .NET 5.0 |   .NET 5.0 |     14 | 22000000 | 189.6 ms | 0.28 ms | 0.26 ms |  1.00 |    0.00 |         - |
|  BestKnown_Comparable |   .NET 6.0 |   .NET 6.0 |     14 | 22000000 | 193.1 ms | 0.59 ms | 0.55 ms |  1.02 |    0.00 |     480 B |
|  BestKnown_Comparable | CoreRT 6.0 | CoreRT 6.0 |     14 | 22000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |          |          |         |         |       |         |           |
|  BestKnown_Branchless |   .NET 5.0 |   .NET 5.0 |     14 | 22000000 | 124.7 ms | 0.06 ms | 0.06 ms |  1.00 |    0.00 |         - |
|  BestKnown_Branchless |   .NET 6.0 |   .NET 6.0 |     14 | 22000000 | 123.5 ms | 0.36 ms | 0.33 ms |  0.99 |    0.00 |     480 B |
|  BestKnown_Branchless | CoreRT 6.0 | CoreRT 6.0 |     14 | 22000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |          |          |         |         |       |         |           |
|  Insertion_Comparable |   .NET 5.0 |   .NET 5.0 |     14 | 22000000 | 217.4 ms | 1.20 ms | 1.12 ms |  1.00 |    0.00 |         - |
|  Insertion_Comparable |   .NET 6.0 |   .NET 6.0 |     14 | 22000000 | 219.4 ms | 3.90 ms | 5.34 ms |  1.01 |    0.03 |     480 B |
|  Insertion_Comparable | CoreRT 6.0 | CoreRT 6.0 |     14 | 22000000 |       NA |      NA |      NA |     ? |       ? |         - |

Benchmarks with issues:
  SN14Benchmark.BoseNelson_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=14, Count=22000000]
  SN14Benchmark.BoseNelson_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=14, Count=22000000]
  SN14Benchmark.BestKnown_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=14, Count=22000000]
  SN14Benchmark.BestKnown_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=14, Count=22000000]
  SN14Benchmark.Insertion_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=14, Count=22000000]
