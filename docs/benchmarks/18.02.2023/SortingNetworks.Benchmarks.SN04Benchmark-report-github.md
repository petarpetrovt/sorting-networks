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
| BoseNelson_Comparable |      4 | 110000000 | 452.0 ms | 16.14 ms | 0.88 ms |
| BoseNelson_Branchless |      4 | 110000000 | 141.2 ms | 16.78 ms | 0.92 ms |
|  Insertion_Comparable |      4 | 110000000 | 607.8 ms | 26.71 ms | 1.46 ms |
