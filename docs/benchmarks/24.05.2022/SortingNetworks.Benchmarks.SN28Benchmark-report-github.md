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
| BoseNelson_Comparable |     28 | 9000000 | 129.9 ms | 24.79 ms | 1.36 ms |
| BoseNelson_Branchless |     28 | 9000000 | 250.9 ms | 27.31 ms | 1.50 ms |
|  Insertion_Comparable |     28 | 9000000 | 128.2 ms | 16.64 ms | 0.91 ms |
