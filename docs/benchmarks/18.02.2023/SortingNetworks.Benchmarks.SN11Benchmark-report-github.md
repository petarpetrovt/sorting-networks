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
| BoseNelson_Comparable |     11 | 43000000 | 305.4 ms |   1.36 ms |  0.07 ms |
| BoseNelson_Branchless |     11 | 43000000 | 149.7 ms |   2.72 ms |  0.15 ms |
|  BestKnown_Comparable |     11 | 43000000 | 320.7 ms |   7.68 ms |  0.42 ms |
|  BestKnown_Branchless |     11 | 43000000 | 113.0 ms |   3.84 ms |  0.21 ms |
|  Insertion_Comparable |     11 | 43000000 | 364.6 ms | 191.96 ms | 10.52 ms |
