``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1706 (21H2)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
.NET SDK=6.0.300
  [Host]   : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  ShortRun : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
|                Method | Length |    Count |     Mean |     Error |  StdDev |
|---------------------- |------- |--------- |---------:|----------:|--------:|
| BoseNelson_Comparable |     15 | 21000000 | 174.4 ms |  16.13 ms | 0.88 ms |
| BoseNelson_Branchless |     15 | 21000000 | 205.9 ms | 107.46 ms | 5.89 ms |
|  BestKnown_Comparable |     15 | 21000000 | 195.0 ms |  49.15 ms | 2.69 ms |
|  BestKnown_Branchless |     15 | 21000000 | 142.9 ms |   9.67 ms | 0.53 ms |
|  Insertion_Comparable |     15 | 21000000 | 205.5 ms |  29.40 ms | 1.61 ms |
