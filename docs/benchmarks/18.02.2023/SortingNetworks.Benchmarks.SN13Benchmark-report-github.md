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
| BoseNelson_Comparable |     13 | 35000000 | 269.2 ms |  4.72 ms | 0.26 ms |
| BoseNelson_Branchless |     13 | 35000000 | 155.9 ms | 95.86 ms | 5.25 ms |
|  BestKnown_Comparable |     13 | 35000000 | 286.3 ms |  4.62 ms | 0.25 ms |
|  BestKnown_Branchless |     13 | 35000000 | 119.9 ms |  3.58 ms | 0.20 ms |
|  Insertion_Comparable |     13 | 35000000 | 294.7 ms | 14.64 ms | 0.80 ms |
