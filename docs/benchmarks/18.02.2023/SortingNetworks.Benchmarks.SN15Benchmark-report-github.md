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
| BoseNelson_Comparable |     15 | 21000000 | 175.0 ms |  4.62 ms | 0.25 ms |
| BoseNelson_Branchless |     15 | 21000000 | 204.9 ms | 65.68 ms | 3.60 ms |
|  BestKnown_Comparable |     15 | 21000000 | 195.5 ms |  4.91 ms | 0.27 ms |
|  BestKnown_Branchless |     15 | 21000000 | 145.2 ms |  4.03 ms | 0.22 ms |
|  Insertion_Comparable |     15 | 21000000 | 191.5 ms | 37.56 ms | 2.06 ms |
