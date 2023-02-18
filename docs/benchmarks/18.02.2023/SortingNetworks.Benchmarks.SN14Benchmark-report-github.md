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
| BoseNelson_Comparable |     14 | 22000000 | 182.0 ms |  8.66 ms | 0.47 ms |
| BoseNelson_Branchless |     14 | 22000000 | 199.3 ms |  3.77 ms | 0.21 ms |
|  BestKnown_Comparable |     14 | 22000000 | 192.4 ms |  4.25 ms | 0.23 ms |
|  BestKnown_Branchless |     14 | 22000000 | 124.1 ms |  0.44 ms | 0.02 ms |
|  Insertion_Comparable |     14 | 22000000 | 192.9 ms | 75.45 ms | 4.14 ms |
