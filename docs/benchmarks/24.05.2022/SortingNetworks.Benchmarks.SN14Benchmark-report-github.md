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
| BoseNelson_Comparable |     14 | 22000000 | 176.2 ms |  19.14 ms | 1.05 ms |
| BoseNelson_Branchless |     14 | 22000000 | 203.3 ms | 106.57 ms | 5.84 ms |
|  BestKnown_Comparable |     14 | 22000000 | 190.7 ms |   6.82 ms | 0.37 ms |
|  BestKnown_Branchless |     14 | 22000000 | 122.4 ms |   5.68 ms | 0.31 ms |
|  Insertion_Comparable |     14 | 22000000 | 220.9 ms |  74.15 ms | 4.06 ms |
