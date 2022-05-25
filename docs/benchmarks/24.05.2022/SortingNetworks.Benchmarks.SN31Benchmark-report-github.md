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
| BoseNelson_Comparable |     31 | 9000000 | 134.8 ms |  8.70 ms | 0.48 ms |
| BoseNelson_Branchless |     31 | 9000000 | 168.1 ms | 41.11 ms | 2.25 ms |
|  Insertion_Comparable |     31 | 9000000 | 132.8 ms | 13.51 ms | 0.74 ms |
