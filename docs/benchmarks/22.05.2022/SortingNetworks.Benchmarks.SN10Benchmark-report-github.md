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
| BoseNelson_Comparable |   .NET 5.0 |   .NET 5.0 |     10 | 45000000 | 312.3 ms | 1.44 ms | 1.34 ms |  1.00 |    0.00 |   1,448 B |
| BoseNelson_Comparable |   .NET 6.0 |   .NET 6.0 |     10 | 45000000 | 318.4 ms | 5.04 ms | 4.47 ms |  1.02 |    0.01 |     768 B |
| BoseNelson_Comparable | CoreRT 6.0 | CoreRT 6.0 |     10 | 45000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |          |          |         |         |       |         |           |
| BoseNelson_Branchless |   .NET 5.0 |   .NET 5.0 |     10 | 45000000 | 152.2 ms | 0.81 ms | 0.76 ms |  1.00 |    0.00 |         - |
| BoseNelson_Branchless |   .NET 6.0 |   .NET 6.0 |     10 | 45000000 | 152.6 ms | 0.69 ms | 0.64 ms |  1.00 |    0.01 |     480 B |
| BoseNelson_Branchless | CoreRT 6.0 | CoreRT 6.0 |     10 | 45000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |          |          |         |         |       |         |           |
|  BestKnown_Comparable |   .NET 5.0 |   .NET 5.0 |     10 | 45000000 | 313.7 ms | 0.89 ms | 0.83 ms |  1.00 |    0.00 |         - |
|  BestKnown_Comparable |   .NET 6.0 |   .NET 6.0 |     10 | 45000000 | 317.3 ms | 1.78 ms | 1.67 ms |  1.01 |    0.01 |     480 B |
|  BestKnown_Comparable | CoreRT 6.0 | CoreRT 6.0 |     10 | 45000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |          |          |         |         |       |         |           |
|  BestKnown_Branchless |   .NET 5.0 |   .NET 5.0 |     10 | 45000000 | 113.4 ms | 0.16 ms | 0.15 ms |  1.00 |    0.00 |         - |
|  BestKnown_Branchless |   .NET 6.0 |   .NET 6.0 |     10 | 45000000 | 112.5 ms | 0.27 ms | 0.25 ms |  0.99 |    0.00 |     480 B |
|  BestKnown_Branchless | CoreRT 6.0 | CoreRT 6.0 |     10 | 45000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |          |          |         |         |       |         |           |
|  Insertion_Comparable |   .NET 5.0 |   .NET 5.0 |     10 | 45000000 | 392.2 ms | 3.44 ms | 3.22 ms |  1.00 |    0.00 |         - |
|  Insertion_Comparable |   .NET 6.0 |   .NET 6.0 |     10 | 45000000 | 399.2 ms | 3.78 ms | 3.53 ms |  1.02 |    0.01 |     480 B |
|  Insertion_Comparable | CoreRT 6.0 | CoreRT 6.0 |     10 | 45000000 |       NA |      NA |      NA |     ? |       ? |         - |

Benchmarks with issues:
  SN10Benchmark.BoseNelson_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=10, Count=45000000]
  SN10Benchmark.BoseNelson_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=10, Count=45000000]
  SN10Benchmark.BestKnown_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=10, Count=45000000]
  SN10Benchmark.BestKnown_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=10, Count=45000000]
  SN10Benchmark.Insertion_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=10, Count=45000000]
