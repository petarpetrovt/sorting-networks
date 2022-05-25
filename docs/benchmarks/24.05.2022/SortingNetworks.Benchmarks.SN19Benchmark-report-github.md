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
| BoseNelson_Comparable |     19 | 12000000 | 131.1 ms |  6.39 ms | 0.35 ms |
| BoseNelson_Branchless |     19 | 12000000 | 204.0 ms | 53.15 ms | 2.91 ms |
|  Insertion_Comparable |     19 | 12000000 | 138.0 ms | 63.57 ms | 3.48 ms |
