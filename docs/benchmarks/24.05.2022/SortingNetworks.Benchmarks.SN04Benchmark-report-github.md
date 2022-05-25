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
| BoseNelson_Comparable |      4 | 110000000 | 426.5 ms | 24.72 ms | 1.36 ms |
| BoseNelson_Branchless |      4 | 110000000 | 137.8 ms | 17.59 ms | 0.96 ms |
|  Insertion_Comparable |      4 | 110000000 | 605.1 ms | 42.73 ms | 2.34 ms |
