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
| BoseNelson_Comparable |   .NET 5.0 |   .NET 5.0 |     31 | 9000000 | 140.1 ms | 2.69 ms | 2.99 ms |  1.00 |    0.00 |         - |
| BoseNelson_Comparable |   .NET 6.0 |   .NET 6.0 |     31 | 9000000 | 133.7 ms | 0.43 ms | 0.38 ms |  0.95 |    0.02 |     480 B |
| BoseNelson_Comparable | CoreRT 6.0 | CoreRT 6.0 |     31 | 9000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |         |          |         |         |       |         |           |
| BoseNelson_Branchless |   .NET 5.0 |   .NET 5.0 |     31 | 9000000 | 163.9 ms | 0.32 ms | 0.28 ms |  1.00 |    0.00 |         - |
| BoseNelson_Branchless |   .NET 6.0 |   .NET 6.0 |     31 | 9000000 | 169.4 ms | 0.40 ms | 0.37 ms |  1.03 |    0.00 |     480 B |
| BoseNelson_Branchless | CoreRT 6.0 | CoreRT 6.0 |     31 | 9000000 |       NA |      NA |      NA |     ? |       ? |         - |
|                       |            |            |        |         |          |         |         |       |         |           |
|  Insertion_Comparable |   .NET 5.0 |   .NET 5.0 |     31 | 9000000 | 126.0 ms | 2.37 ms | 2.33 ms |  1.00 |    0.00 |         - |
|  Insertion_Comparable |   .NET 6.0 |   .NET 6.0 |     31 | 9000000 | 126.7 ms | 2.50 ms | 5.38 ms |  0.99 |    0.05 |     480 B |
|  Insertion_Comparable | CoreRT 6.0 | CoreRT 6.0 |     31 | 9000000 |       NA |      NA |      NA |     ? |       ? |         - |

Benchmarks with issues:
  SN31Benchmark.BoseNelson_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=31, Count=9000000]
  SN31Benchmark.BoseNelson_Branchless: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=31, Count=9000000]
  SN31Benchmark.Insertion_Comparable: CoreRT 6.0(Runtime=CoreRT 6.0, InvocationCount=1, UnrollFactor=1) [Length=31, Count=9000000]
