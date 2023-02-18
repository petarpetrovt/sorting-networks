``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2604/22H2/2022Update)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.103
  [Host]   : .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
|                Method | Length |   Count |     Mean |     Error |   StdDev |
|---------------------- |------- |-------- |---------:|----------:|---------:|
| BoseNelson_Comparable |     30 | 9000000 | 132.4 ms |   5.67 ms |  0.31 ms |
| BoseNelson_Branchless |     30 | 9000000 | 167.8 ms |   5.45 ms |  0.30 ms |
|  Insertion_Comparable |     30 | 9000000 | 125.0 ms | 187.19 ms | 10.26 ms |
