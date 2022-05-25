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
| BoseNelson_Comparable |      8 | 55000000 | 333.4 ms |  7.91 ms | 0.43 ms |
| BoseNelson_Branchless |      8 | 55000000 | 122.8 ms | 15.58 ms | 0.85 ms |
|  Insertion_Comparable |      8 | 55000000 | 444.0 ms | 32.97 ms | 1.81 ms |
