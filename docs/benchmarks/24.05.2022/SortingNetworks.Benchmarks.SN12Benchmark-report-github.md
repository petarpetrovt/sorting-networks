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
| BoseNelson_Comparable |     12 | 36000000 | 267.8 ms | 13.57 ms | 0.74 ms |
| BoseNelson_Branchless |     12 | 36000000 | 143.7 ms | 11.84 ms | 0.65 ms |
|  BestKnown_Comparable |     12 | 36000000 | 273.2 ms | 14.27 ms | 0.78 ms |
|  BestKnown_Branchless |     12 | 36000000 | 106.4 ms |  3.06 ms | 0.17 ms |
|  Insertion_Comparable |     12 | 36000000 | 320.9 ms | 36.33 ms | 1.99 ms |
