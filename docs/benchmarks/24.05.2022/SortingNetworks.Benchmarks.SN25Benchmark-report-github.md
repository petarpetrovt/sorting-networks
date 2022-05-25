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
| BoseNelson_Comparable |     25 | 10000000 | 140.6 ms | 11.44 ms | 0.63 ms |
| BoseNelson_Branchless |     25 | 10000000 | 201.4 ms | 10.92 ms | 0.60 ms |
|  Insertion_Comparable |     25 | 10000000 | 128.1 ms | 11.07 ms | 0.61 ms |
