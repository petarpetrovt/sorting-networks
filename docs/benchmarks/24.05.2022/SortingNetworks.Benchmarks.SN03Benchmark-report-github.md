``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1706 (21H2)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
.NET SDK=6.0.300
  [Host]   : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  ShortRun : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
|                Method | Length |     Count |     Mean |    Error |  StdDev |
|---------------------- |------- |---------- |---------:|---------:|--------:|
| BoseNelson_Comparable |      3 | 110000000 | 338.4 ms | 16.37 ms | 0.90 ms |
| BoseNelson_Branchless |      3 | 110000000 | 119.3 ms | 60.20 ms | 3.30 ms |
|  Insertion_Comparable |      3 | 110000000 | 518.0 ms | 39.22 ms | 2.15 ms |
