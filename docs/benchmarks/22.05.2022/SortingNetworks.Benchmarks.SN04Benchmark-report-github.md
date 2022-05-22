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
| BoseNelson_Comparable |   .NET 5.0 |   .NET 5.0 |      4 | 110000000 | 420.1 ms | 0.72 ms | 0.60 ms |  1.00 |    0.00 |         - |
| BoseNelson_Comparable |   .NET 6.0 |   .NET 6.0 |      4 | 110000000 | 416.0 ms | 0.97 ms | 0.86 ms |  0.99 |    0.00 |     480 B |
| BoseNelson_Comparable | CoreRT 6.0 | CoreRT 6.0 |      4 | 110000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |           |          |         |         |       |         |           |
| BoseNelson_Branchless |   .NET 5.0 |   .NET 5.0 |      4 | 110000000 | 140.3 ms | 0.49 ms | 0.41 ms |  1.00 |    0.00 |         - |
| BoseNelson_Branchless |   .NET 6.0 |   .NET 6.0 |      4 | 110000000 | 140.2 ms | 0.11 ms | 0.09 ms |  1.00 |    0.00 |     480 B |
| BoseNelson_Branchless | CoreRT 6.0 | CoreRT 6.0 |      4 | 110000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |           |          |         |         |       |         |           |
|  Insertion_Comparable |   .NET 5.0 |   .NET 5.0 |      4 | 110000000 | 594.5 ms | 2.85 ms | 2.67 ms |  1.00 |    0.00 |         - |
|  Insertion_Comparable |   .NET 6.0 |   .NET 6.0 |      4 | 110000000 | 598.5 ms | 1.83 ms | 1.71 ms |  1.01 |    0.00 |     480 B |
|  Insertion_Comparable | CoreRT 6.0 | CoreRT 6.0 |      4 | 110000000 |       NA |      NA |      NA |     ? |       ? |         - |

Benchmarks with issues:
  SN04Benchmark.BoseNelson_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=4, Count=110000000]
  SN04Benchmark.BoseNelson_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=4, Count=110000000]
  SN04Benchmark.Insertion_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=4, Count=110000000]
