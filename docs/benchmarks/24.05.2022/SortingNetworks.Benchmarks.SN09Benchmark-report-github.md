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
| BoseNelson_Comparable |      9 | 50000000 | 318.6 ms | 11.69 ms | 0.64 ms |
| BoseNelson_Branchless |      9 | 50000000 | 142.5 ms | 12.84 ms | 0.70 ms |
|  BestKnown_Comparable |      9 | 50000000 | 323.7 ms | 54.11 ms | 2.97 ms |
|  BestKnown_Branchless |      9 | 50000000 | 117.4 ms |  6.55 ms | 0.36 ms |
|  Insertion_Comparable |      9 | 50000000 | 405.3 ms | 45.37 ms | 2.49 ms |
