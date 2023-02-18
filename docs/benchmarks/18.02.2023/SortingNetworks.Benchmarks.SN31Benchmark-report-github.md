``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2604/22H2/2022Update)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.103
  [Host]   : .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
|                Method | Length |   Count |     Mean |    Error |  StdDev |
|---------------------- |------- |-------- |---------:|---------:|--------:|
| BoseNelson_Comparable |     31 | 9000000 | 136.7 ms |  4.90 ms | 0.27 ms |
| BoseNelson_Branchless |     31 | 9000000 | 167.2 ms | 66.20 ms | 3.63 ms |
|  Insertion_Comparable |     31 | 9000000 | 107.3 ms |  0.57 ms | 0.03 ms |
