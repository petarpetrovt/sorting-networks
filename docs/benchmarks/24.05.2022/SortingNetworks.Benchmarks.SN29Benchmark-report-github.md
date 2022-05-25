``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1706 (21H2)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
.NET SDK=6.0.300
  [Host]   : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  ShortRun : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
|                Method | Length |   Count |     Mean |    Error |  StdDev |
|---------------------- |------- |-------- |---------:|---------:|--------:|
| BoseNelson_Comparable |     29 | 9000000 | 135.4 ms | 35.75 ms | 1.96 ms |
| BoseNelson_Branchless |     29 | 9000000 | 174.2 ms | 12.17 ms | 0.67 ms |
|  Insertion_Comparable |     29 | 9000000 | 122.7 ms |  3.82 ms | 0.21 ms |
