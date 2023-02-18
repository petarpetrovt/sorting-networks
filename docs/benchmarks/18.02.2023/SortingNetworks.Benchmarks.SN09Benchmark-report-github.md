``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2604/22H2/2022Update)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.103
  [Host]   : .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
|                Method | Length |    Count |     Mean |    Error |  StdDev |
|---------------------- |------- |--------- |---------:|---------:|--------:|
| BoseNelson_Comparable |      9 | 50000000 | 327.2 ms | 29.38 ms | 1.61 ms |
| BoseNelson_Branchless |      9 | 50000000 | 146.3 ms | 10.31 ms | 0.57 ms |
|  BestKnown_Comparable |      9 | 50000000 | 326.5 ms |  4.61 ms | 0.25 ms |
|  BestKnown_Branchless |      9 | 50000000 | 119.6 ms | 18.98 ms | 1.04 ms |
|  Insertion_Comparable |      9 | 50000000 | 386.1 ms | 90.27 ms | 4.95 ms |
