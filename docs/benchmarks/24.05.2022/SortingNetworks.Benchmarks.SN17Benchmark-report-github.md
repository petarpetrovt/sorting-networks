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
| BoseNelson_Comparable |     17 | 13000000 | 123.0 ms |  2.84 ms | 0.16 ms |
| BoseNelson_Branchless |     17 | 13000000 | 154.0 ms | 60.29 ms | 3.30 ms |
|  Insertion_Comparable |     17 | 13000000 | 146.5 ms | 83.69 ms | 4.59 ms |
