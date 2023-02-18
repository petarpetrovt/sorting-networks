``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2604/22H2/2022Update)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.103
  [Host]   : .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
|                Method | Length |     Count |     Mean |    Error |  StdDev |
|---------------------- |------- |---------- |---------:|---------:|--------:|
| BoseNelson_Comparable |      2 | 110000000 | 290.1 ms | 12.04 ms | 0.66 ms |
| BoseNelson_Branchless |      2 | 110000000 | 130.5 ms | 12.70 ms | 0.70 ms |
|  Insertion_Comparable |      2 | 110000000 | 461.0 ms |  2.01 ms | 0.11 ms |
