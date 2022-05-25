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
| BoseNelson_Comparable |      5 | 90000000 | 376.3 ms | 43.19 ms | 2.37 ms |
| BoseNelson_Branchless |      5 | 90000000 | 151.0 ms |  8.24 ms | 0.45 ms |
|  Insertion_Comparable |      5 | 90000000 | 552.5 ms | 58.59 ms | 3.21 ms |
