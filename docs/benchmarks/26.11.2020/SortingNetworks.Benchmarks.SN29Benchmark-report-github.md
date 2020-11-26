``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=5.0.100
  [Host]        : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  .NET 4.8      : .NET Framework 4.8 (4.8.4250.0), X64 RyuJIT
  .NET Core 3.1 : .NET Core 3.1.10 (CoreCLR 4.700.20.51601, CoreFX 4.700.20.51901), X64 RyuJIT
  .NET Core 5.0 : .NET Core 5.0.0 (CoreCLR 5.0.20.51904, CoreFX 5.0.20.51904), X64 RyuJIT
  CoreRt 3.1    : .NET 5.0.29408.02 @BuiltBy: dlab14-DDVSOWINAGE075 @Branch: master @Commit: 4ce1c21ac0d4d1a3b7f7a548214966f69ac9f199, X64 AOT

InvocationCount=1  UnrollFactor=1  

```
|                Method |           Job |       Runtime | Length |   Count |     Mean |   Error |  StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |-------------- |-------------- |------- |-------- |---------:|--------:|--------:|------:|------:|------:|----------:|
| BoseNelson_Comparable |      .NET 4.8 |      .NET 4.8 |     29 | 9000000 | 132.1 ms | 0.50 ms | 0.47 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |      .NET 4.8 |      .NET 4.8 |     29 | 9000000 | 248.2 ms | 0.45 ms | 0.40 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET 4.8 |      .NET 4.8 |     29 | 9000000 | 170.7 ms | 0.29 ms | 0.24 ms |     - |     - |     - |         - |
| BoseNelson_Comparable | .NET Core 3.1 | .NET Core 3.1 |     29 | 9000000 | 128.2 ms | 0.25 ms | 0.22 ms |     - |     - |     - |         - |
| BoseNelson_Branchless | .NET Core 3.1 | .NET Core 3.1 |     29 | 9000000 | 261.0 ms | 0.75 ms | 0.66 ms |     - |     - |     - |     496 B |
|  Insertion_Comparable | .NET Core 3.1 | .NET Core 3.1 |     29 | 9000000 | 122.3 ms | 2.32 ms | 2.85 ms |     - |     - |     - |         - |
| BoseNelson_Comparable | .NET Core 5.0 | .NET Core 5.0 |     29 | 9000000 | 128.7 ms | 0.51 ms | 0.46 ms |     - |     - |     - |         - |
| BoseNelson_Branchless | .NET Core 5.0 | .NET Core 5.0 |     29 | 9000000 | 242.9 ms | 0.25 ms | 0.21 ms |     - |     - |     - |      48 B |
|  Insertion_Comparable | .NET Core 5.0 | .NET Core 5.0 |     29 | 9000000 | 129.9 ms | 2.48 ms | 1.93 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     29 | 9000000 | 127.2 ms | 0.09 ms | 0.07 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |    CoreRt 3.1 |    CoreRt 3.1 |     29 | 9000000 | 205.6 ms | 0.16 ms | 0.13 ms |     - |     - |     - |         - |
|  Insertion_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     29 | 9000000 | 124.5 ms | 2.46 ms | 3.37 ms |     - |     - |     - |         - |
