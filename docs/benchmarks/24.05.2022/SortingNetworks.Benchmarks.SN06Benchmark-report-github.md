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
| BoseNelson_Comparable |      6 | 85000000 | 411.9 ms | 15.10 ms | 0.83 ms |
| BoseNelson_Branchless |      6 | 85000000 | 170.8 ms | 16.28 ms | 0.89 ms |
|  Insertion_Comparable |      6 | 85000000 | 580.7 ms | 70.68 ms | 3.87 ms |
