``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1706 (21H2)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
.NET SDK=6.0.300
  [Host]   : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  ShortRun : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
|                Method | Length |     Count |     Mean |     Error |  StdDev |
|---------------------- |------- |---------- |---------:|----------:|--------:|
| BoseNelson_Comparable |      2 | 110000000 | 270.9 ms |  10.40 ms | 0.57 ms |
| BoseNelson_Branchless |      2 | 110000000 | 119.5 ms |   8.94 ms | 0.49 ms |
|  Insertion_Comparable |      2 | 110000000 | 446.7 ms | 150.36 ms | 8.24 ms |
