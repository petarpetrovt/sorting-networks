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
| BoseNelson_Comparable |     18 | 12000000 | 129.1 ms | 36.82 ms | 2.02 ms |
| BoseNelson_Branchless |     18 | 12000000 | 178.9 ms |  2.54 ms | 0.14 ms |
|  Insertion_Comparable |     18 | 12000000 | 136.0 ms | 37.43 ms | 2.05 ms |
