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
| BoseNelson_Comparable |     22 | 10000000 | 126.6 ms | 19.72 ms | 1.08 ms |
| BoseNelson_Branchless |     22 | 10000000 | 207.8 ms | 33.77 ms | 1.85 ms |
|  Insertion_Comparable |     22 | 10000000 | 127.3 ms | 23.43 ms | 1.28 ms |
