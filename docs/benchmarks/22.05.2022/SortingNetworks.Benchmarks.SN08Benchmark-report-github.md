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
| BoseNelson_Comparable |   .NET 5.0 |   .NET 5.0 |      8 | 55000000 | 341.6 ms | 0.99 ms | 0.93 ms |  1.00 |    0.00 |         - |
| BoseNelson_Comparable |   .NET 6.0 |   .NET 6.0 |      8 | 55000000 | 338.3 ms | 1.68 ms | 1.57 ms |  0.99 |    0.01 |     480 B |
| BoseNelson_Comparable | CoreRT 6.0 | CoreRT 6.0 |      8 | 55000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |          |          |         |         |       |         |           |
| BoseNelson_Branchless |   .NET 5.0 |   .NET 5.0 |      8 | 55000000 | 123.3 ms | 0.18 ms | 0.16 ms |  1.00 |    0.00 |         - |
| BoseNelson_Branchless |   .NET 6.0 |   .NET 6.0 |      8 | 55000000 | 122.8 ms | 0.09 ms | 0.09 ms |  1.00 |    0.00 |     480 B |
| BoseNelson_Branchless | CoreRT 6.0 | CoreRT 6.0 |      8 | 55000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |          |          |         |         |       |         |           |
|  Insertion_Comparable |   .NET 5.0 |   .NET 5.0 |      8 | 55000000 | 439.2 ms | 3.17 ms | 2.96 ms |  1.00 |    0.00 |         - |
|  Insertion_Comparable |   .NET 6.0 |   .NET 6.0 |      8 | 55000000 | 448.1 ms | 2.41 ms | 2.26 ms |  1.02 |    0.01 |     480 B |
|  Insertion_Comparable | CoreRT 6.0 | CoreRT 6.0 |      8 | 55000000 |       NA |      NA |      NA |     ? |       ? |         - |

Benchmarks with issues:
  SN08Benchmark.BoseNelson_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=8, Count=55000000]
  SN08Benchmark.BoseNelson_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=8, Count=55000000]
  SN08Benchmark.Insertion_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=8, Count=55000000]
