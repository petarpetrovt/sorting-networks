``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2604/22H2/2022Update)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.103
  [Host]   : .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
|                Method | Length |    Count |     Mean |     Error |   StdDev |
|---------------------- |------- |--------- |---------:|----------:|---------:|
| BoseNelson_Comparable |     16 | 21000000 | 191.6 ms |  44.07 ms |  2.42 ms |
| BoseNelson_Branchless |     16 | 21000000 | 195.9 ms |  52.68 ms |  2.89 ms |
|  BestKnown_Comparable |     16 | 21000000 | 207.3 ms |   3.44 ms |  0.19 ms |
|  BestKnown_Branchless |     16 | 21000000 | 149.1 ms |   8.84 ms |  0.48 ms |
|  Insertion_Comparable |     16 | 21000000 | 211.9 ms | 253.10 ms | 13.87 ms |
