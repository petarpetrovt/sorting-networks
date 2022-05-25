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
| BoseNelson_Comparable |     16 | 21000000 | 185.6 ms | 15.50 ms | 0.85 ms |
| BoseNelson_Branchless |     16 | 21000000 | 194.4 ms | 11.17 ms | 0.61 ms |
|  BestKnown_Comparable |     16 | 21000000 | 202.2 ms | 15.69 ms | 0.86 ms |
|  BestKnown_Branchless |     16 | 21000000 | 152.7 ms | 95.01 ms | 5.21 ms |
|  Insertion_Comparable |     16 | 21000000 | 209.7 ms | 10.01 ms | 0.55 ms |
