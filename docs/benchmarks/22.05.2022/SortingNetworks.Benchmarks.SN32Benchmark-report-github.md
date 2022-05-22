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
| BoseNelson_Comparable |   .NET 5.0 |   .NET 5.0 |     32 | 9000000 | 137.3 ms | 0.51 ms | 0.46 ms |  1.00 |    0.00 |         - |
| BoseNelson_Comparable |   .NET 6.0 |   .NET 6.0 |     32 | 9000000 | 137.2 ms | 0.17 ms | 0.15 ms |  1.00 |    0.00 |     480 B |
| BoseNelson_Comparable | CoreRT 6.0 | CoreRT 6.0 |     32 | 9000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |         |          |         |         |       |         |           |
| BoseNelson_Branchless |   .NET 5.0 |   .NET 5.0 |     32 | 9000000 | 169.4 ms | 1.01 ms | 0.84 ms |  1.00 |    0.00 |         - |
| BoseNelson_Branchless |   .NET 6.0 |   .NET 6.0 |     32 | 9000000 | 226.1 ms | 1.29 ms | 1.21 ms |  1.34 |    0.01 |     480 B |
| BoseNelson_Branchless | CoreRT 6.0 | CoreRT 6.0 |     32 | 9000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |         |          |         |         |       |         |           |
|  Insertion_Comparable |   .NET 5.0 |   .NET 5.0 |     32 | 9000000 | 123.9 ms | 0.42 ms | 0.35 ms |  1.00 |    0.00 |         - |
|  Insertion_Comparable |   .NET 6.0 |   .NET 6.0 |     32 | 9000000 | 126.3 ms | 2.52 ms | 4.97 ms |  1.01 |    0.05 |     480 B |
|  Insertion_Comparable | CoreRT 6.0 | CoreRT 6.0 |     32 | 9000000 |       NA |      NA |      NA |     ? |       ? |         - |

Benchmarks with issues:
  SN32Benchmark.BoseNelson_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=32, Count=9000000]
  SN32Benchmark.BoseNelson_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=32, Count=9000000]
  SN32Benchmark.Insertion_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=32, Count=9000000]
