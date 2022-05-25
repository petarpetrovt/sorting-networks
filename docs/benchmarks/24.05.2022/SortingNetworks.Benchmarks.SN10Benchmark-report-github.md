``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1706 (21H2)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
.NET SDK=6.0.300
  [Host]   : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  ShortRun : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
|                Method | Length |    Count |     Mean |    Error |  StdDev |
|---------------------- |------- |--------- |---------:|---------:|--------:|
| BoseNelson_Comparable |     10 | 45000000 | 308.8 ms |  1.81 ms | 0.10 ms |
| BoseNelson_Branchless |     10 | 45000000 | 150.1 ms | 12.51 ms | 0.69 ms |
|  BestKnown_Comparable |     10 | 45000000 | 308.0 ms | 19.56 ms | 1.07 ms |
|  BestKnown_Branchless |     10 | 45000000 | 111.3 ms | 11.06 ms | 0.61 ms |
|  Insertion_Comparable |     10 | 45000000 | 398.6 ms | 46.26 ms | 2.54 ms |
