``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2604/22H2/2022Update)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.103
  [Host]   : .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
|                Method | Length |    Count |     Mean |   Error |  StdDev |
|---------------------- |------- |--------- |---------:|--------:|--------:|
| BoseNelson_Comparable |     23 | 10000000 | 128.8 ms | 5.01 ms | 0.27 ms |
| BoseNelson_Branchless |     23 | 10000000 | 213.3 ms | 6.10 ms | 0.33 ms |
|  Insertion_Comparable |     23 | 10000000 | 105.3 ms | 7.42 ms | 0.41 ms |
