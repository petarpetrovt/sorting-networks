``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.2604/22H2/2022Update)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
.NET SDK=7.0.103
  [Host]   : .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX2
  ShortRun : .NET 7.0.3 (7.0.323.6910), X64 RyuJIT AVX2

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
|                Method | Length |    Count |     Mean |     Error |  StdDev |
|---------------------- |------- |--------- |---------:|----------:|--------:|
| BoseNelson_Comparable |     24 | 10000000 | 136.4 ms |  39.24 ms | 2.15 ms |
| BoseNelson_Branchless |     24 | 10000000 | 207.4 ms |   2.22 ms | 0.12 ms |
|  Insertion_Comparable |     24 | 10000000 | 122.4 ms | 101.12 ms | 5.54 ms |
