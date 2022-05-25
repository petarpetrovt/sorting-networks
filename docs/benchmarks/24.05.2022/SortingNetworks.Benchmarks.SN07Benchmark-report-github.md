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
| BoseNelson_Comparable |      7 | 85000000 | 465.4 ms | 13.02 ms | 0.71 ms |
| BoseNelson_Branchless |      7 | 85000000 | 191.1 ms |  9.99 ms | 0.55 ms |
|  Insertion_Comparable |      7 | 85000000 | 640.9 ms | 65.45 ms | 3.59 ms |
