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
| BoseNelson_Comparable |     12 | 36000000 | 273.3 ms |  7.00 ms | 0.38 ms |
| BoseNelson_Branchless |     12 | 36000000 | 145.8 ms |  2.67 ms | 0.15 ms |
|  BestKnown_Comparable |     12 | 36000000 | 282.7 ms |  5.50 ms | 0.30 ms |
|  BestKnown_Branchless |     12 | 36000000 | 108.5 ms |  2.16 ms | 0.12 ms |
|  Insertion_Comparable |     12 | 36000000 | 307.6 ms | 94.74 ms | 5.19 ms |
