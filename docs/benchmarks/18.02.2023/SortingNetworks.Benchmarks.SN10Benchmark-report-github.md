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
| BoseNelson_Comparable |     10 | 45000000 | 312.9 ms |  5.21 ms | 0.29 ms |
| BoseNelson_Branchless |     10 | 45000000 | 152.6 ms |  0.71 ms | 0.04 ms |
|  BestKnown_Comparable |     10 | 45000000 | 316.0 ms |  3.30 ms | 0.18 ms |
|  BestKnown_Branchless |     10 | 45000000 | 113.2 ms |  0.46 ms | 0.03 ms |
|  Insertion_Comparable |     10 | 45000000 | 353.4 ms | 13.48 ms | 0.74 ms |
