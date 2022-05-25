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
| BoseNelson_Comparable |     20 | 11000000 | 122.7 ms |  5.36 ms | 0.29 ms |
| BoseNelson_Branchless |     20 | 11000000 | 203.8 ms | 46.41 ms | 2.54 ms |
|  Insertion_Comparable |     20 | 11000000 | 133.3 ms | 59.28 ms | 3.25 ms |
