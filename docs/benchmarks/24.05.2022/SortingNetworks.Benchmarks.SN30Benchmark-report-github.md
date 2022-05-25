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
| BoseNelson_Comparable |     30 | 9000000 | 138.6 ms | 17.09 ms | 0.94 ms |
| BoseNelson_Branchless |     30 | 9000000 | 175.6 ms | 58.58 ms | 3.21 ms |
|  Insertion_Comparable |     30 | 9000000 | 132.2 ms | 21.77 ms | 1.19 ms |
