``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1706 (21H2)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
.NET SDK=6.0.300
  [Host]   : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  ShortRun : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT

Job=ShortRun  InvocationCount=1  IterationCount=3  
LaunchCount=1  UnrollFactor=1  WarmupCount=3  

```
|                Method | Length |    Count |     Mean |    Error |  StdDev |
|---------------------- |------- |--------- |---------:|---------:|--------:|
| BoseNelson_Comparable |     24 | 10000000 | 137.6 ms | 10.65 ms | 0.58 ms |
| BoseNelson_Branchless |     24 | 10000000 | 208.9 ms |  5.54 ms | 0.30 ms |
|  Insertion_Comparable |     24 | 10000000 | 131.9 ms | 11.69 ms | 0.64 ms |
