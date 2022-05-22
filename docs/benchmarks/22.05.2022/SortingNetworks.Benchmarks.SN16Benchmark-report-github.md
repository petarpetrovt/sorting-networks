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
| BoseNelson_Comparable |   .NET 5.0 |   .NET 5.0 |     16 | 21000000 | 189.0 ms | 0.34 ms | 0.30 ms |  1.00 |    0.00 |         - |
| BoseNelson_Comparable |   .NET 6.0 |   .NET 6.0 |     16 | 21000000 | 188.6 ms | 0.87 ms | 0.78 ms |  1.00 |    0.00 |     480 B |
| BoseNelson_Comparable | CoreRT 6.0 | CoreRT 6.0 |     16 | 21000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |          |          |         |         |       |         |           |
| BoseNelson_Branchless |   .NET 5.0 |   .NET 5.0 |     16 | 21000000 | 190.2 ms | 0.99 ms | 0.88 ms |  1.00 |    0.00 |         - |
| BoseNelson_Branchless |   .NET 6.0 |   .NET 6.0 |     16 | 21000000 | 189.2 ms | 0.37 ms | 0.31 ms |  0.99 |    0.00 |     480 B |
| BoseNelson_Branchless | CoreRT 6.0 | CoreRT 6.0 |     16 | 21000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |          |          |         |         |       |         |           |
|  BestKnown_Comparable |   .NET 5.0 |   .NET 5.0 |     16 | 21000000 | 210.9 ms | 3.46 ms | 3.24 ms |  1.00 |    0.00 |         - |
|  BestKnown_Comparable |   .NET 6.0 |   .NET 6.0 |     16 | 21000000 | 205.7 ms | 1.69 ms | 1.58 ms |  0.98 |    0.02 |     480 B |
|  BestKnown_Comparable | CoreRT 6.0 | CoreRT 6.0 |     16 | 21000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |          |          |         |         |       |         |           |
|  BestKnown_Branchless |   .NET 5.0 |   .NET 5.0 |     16 | 21000000 | 150.8 ms | 0.31 ms | 0.28 ms |  1.00 |    0.00 |         - |
|  BestKnown_Branchless |   .NET 6.0 |   .NET 6.0 |     16 | 21000000 | 150.0 ms | 0.95 ms | 0.80 ms |  0.99 |    0.01 |     480 B |
|  BestKnown_Branchless | CoreRT 6.0 | CoreRT 6.0 |     16 | 21000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |          |          |         |         |       |         |           |
|  Insertion_Comparable |   .NET 5.0 |   .NET 5.0 |     16 | 21000000 | 218.6 ms | 1.92 ms | 1.80 ms |  1.00 |    0.00 |         - |
|  Insertion_Comparable |   .NET 6.0 |   .NET 6.0 |     16 | 21000000 | 223.9 ms | 3.02 ms | 2.83 ms |  1.02 |    0.01 |     480 B |
|  Insertion_Comparable | CoreRT 6.0 | CoreRT 6.0 |     16 | 21000000 |       NA |      NA |      NA |     ? |       ? |         - |

Benchmarks with issues:
  SN16Benchmark.BoseNelson_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=16, Count=21000000]
  SN16Benchmark.BoseNelson_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=16, Count=21000000]
  SN16Benchmark.BestKnown_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=16, Count=21000000]
  SN16Benchmark.BestKnown_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=16, Count=21000000]
  SN16Benchmark.Insertion_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=16, Count=21000000]
