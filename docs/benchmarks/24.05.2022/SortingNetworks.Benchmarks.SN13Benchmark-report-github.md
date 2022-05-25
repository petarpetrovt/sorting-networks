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
| BoseNelson_Comparable |     13 | 35000000 | 261.5 ms |  9.81 ms | 0.54 ms |
| BoseNelson_Branchless |     13 | 35000000 | 150.3 ms |  9.50 ms | 0.52 ms |
|  BestKnown_Comparable |     13 | 35000000 | 274.7 ms | 14.02 ms | 0.77 ms |
|  BestKnown_Branchless |     13 | 35000000 | 117.6 ms |  0.48 ms | 0.03 ms |
|  Insertion_Comparable |     13 | 35000000 | 320.4 ms |  8.56 ms | 0.47 ms |
