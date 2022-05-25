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
| BoseNelson_Comparable |     11 | 43000000 | 301.6 ms |  8.93 ms | 0.49 ms |
| BoseNelson_Branchless |     11 | 43000000 | 146.5 ms | 13.31 ms | 0.73 ms |
|  BestKnown_Comparable |     11 | 43000000 | 308.0 ms | 18.57 ms | 1.02 ms |
|  BestKnown_Branchless |     11 | 43000000 | 111.2 ms | 10.73 ms | 0.59 ms |
|  Insertion_Comparable |     11 | 43000000 | 388.0 ms | 38.39 ms | 2.10 ms |
