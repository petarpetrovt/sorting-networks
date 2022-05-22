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
| BoseNelson_Comparable |   .NET 5.0 |   .NET 5.0 |     24 | 10000000 | 133.0 ms | 0.12 ms | 0.10 ms |  1.00 |    0.00 |         - |
| BoseNelson_Comparable |   .NET 6.0 |   .NET 6.0 |     24 | 10000000 | 132.9 ms | 0.09 ms | 0.07 ms |  1.00 |    0.00 |     480 B |
| BoseNelson_Comparable | CoreRT 6.0 | CoreRT 6.0 |     24 | 10000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |          |          |         |         |       |         |           |
| BoseNelson_Branchless |   .NET 5.0 |   .NET 5.0 |     24 | 10000000 | 195.4 ms | 0.09 ms | 0.09 ms |  1.00 |    0.00 |         - |
| BoseNelson_Branchless |   .NET 6.0 |   .NET 6.0 |     24 | 10000000 | 205.5 ms | 0.12 ms | 0.11 ms |  1.05 |    0.00 |     480 B |
| BoseNelson_Branchless | CoreRT 6.0 | CoreRT 6.0 |     24 | 10000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |          |          |         |         |       |         |           |
|  Insertion_Comparable |   .NET 5.0 |   .NET 5.0 |     24 | 10000000 | 120.3 ms | 1.14 ms | 1.07 ms |  1.00 |    0.00 |         - |
|  Insertion_Comparable |   .NET 6.0 |   .NET 6.0 |     24 | 10000000 | 127.7 ms | 2.49 ms | 3.88 ms |  1.05 |    0.04 |     480 B |
|  Insertion_Comparable | CoreRT 6.0 | CoreRT 6.0 |     24 | 10000000 |       NA |      NA |      NA |     ? |       ? |         - |

Benchmarks with issues:
  SN24Benchmark.BoseNelson_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=24, Count=10000000]
  SN24Benchmark.BoseNelson_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=24, Count=10000000]
  SN24Benchmark.Insertion_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=24, Count=10000000]
