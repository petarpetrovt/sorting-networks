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
|                Method |           Job |       Runtime | Length |      Mean |    Error |   StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |-------------- |-------------- |------- |----------:|---------:|---------:|------:|------:|------:|----------:|
| BoseNelson_Comparable |      .NET 4.8 |      .NET 4.8 |     11 | 283.77 ms | 2.610 ms | 2.441 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |      .NET 4.8 |      .NET 4.8 |     11 | 116.33 ms | 0.286 ms | 0.267 ms |     - |     - |     - |         - |
|  BestKnown_Comparable |      .NET 4.8 |      .NET 4.8 |     11 | 294.50 ms | 3.531 ms | 3.303 ms |     - |     - |     - |         - |
|  BestKnown_Branchless |      .NET 4.8 |      .NET 4.8 |     11 |  94.26 ms | 0.161 ms | 0.142 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET 4.8 |      .NET 4.8 |     11 | 465.63 ms | 2.439 ms | 1.904 ms |     - |     - |     - |         - |
| BoseNelson_Comparable | .NET Core 3.1 | .NET Core 3.1 |     11 | 276.71 ms | 2.021 ms | 1.890 ms |     - |     - |     - |    1856 B |
| BoseNelson_Branchless | .NET Core 3.1 | .NET Core 3.1 |     11 | 118.29 ms | 0.231 ms | 0.205 ms |     - |     - |     - |         - |
|  BestKnown_Comparable | .NET Core 3.1 | .NET Core 3.1 |     11 | 285.13 ms | 0.829 ms | 0.735 ms |     - |     - |     - |    1856 B |
|  BestKnown_Branchless | .NET Core 3.1 | .NET Core 3.1 |     11 |  95.21 ms | 0.697 ms | 0.652 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 3.1 | .NET Core 3.1 |     11 | 338.54 ms | 3.771 ms | 3.343 ms |     - |     - |     - |         - |
| BoseNelson_Comparable | .NET Core 5.0 | .NET Core 5.0 |     11 | 276.02 ms | 0.971 ms | 0.908 ms |     - |     - |     - |         - |
| BoseNelson_Branchless | .NET Core 5.0 | .NET Core 5.0 |     11 | 116.56 ms | 0.435 ms | 0.407 ms |     - |     - |     - |         - |
|  BestKnown_Comparable | .NET Core 5.0 | .NET Core 5.0 |     11 | 281.81 ms | 0.705 ms | 0.660 ms |     - |     - |     - |         - |
|  BestKnown_Branchless | .NET Core 5.0 | .NET Core 5.0 |     11 |  95.76 ms | 0.166 ms | 0.156 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 5.0 | .NET Core 5.0 |     11 | 352.21 ms | 4.761 ms | 4.454 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     11 | 280.65 ms | 3.290 ms | 3.078 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |    CoreRt 3.1 |    CoreRt 3.1 |     11 | 116.99 ms | 0.477 ms | 0.446 ms |     - |     - |     - |         - |
|  BestKnown_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     11 | 281.72 ms | 0.861 ms | 0.806 ms |     - |     - |     - |         - |
|  BestKnown_Branchless |    CoreRt 3.1 |    CoreRt 3.1 |     11 |  95.07 ms | 0.283 ms | 0.264 ms |     - |     - |     - |         - |
|  Insertion_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     11 | 347.63 ms | 6.949 ms | 7.435 ms |     - |     - |     - |         - |
