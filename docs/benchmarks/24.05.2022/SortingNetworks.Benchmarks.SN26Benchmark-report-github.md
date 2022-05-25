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
| BoseNelson_Comparable |     26 | 9000000 | 128.6 ms |  6.30 ms | 0.35 ms |
| BoseNelson_Branchless |     26 | 9000000 | 254.5 ms | 10.82 ms | 0.59 ms |
|  Insertion_Comparable |     26 | 9000000 | 123.1 ms | 39.76 ms | 2.18 ms |
