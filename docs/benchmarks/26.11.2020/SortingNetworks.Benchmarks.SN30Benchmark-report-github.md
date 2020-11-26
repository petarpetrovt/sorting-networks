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
| BoseNelson_Comparable |      .NET 4.8 |      .NET 4.8 |     30 | 9000000 | 133.9 ms | 0.43 ms | 0.40 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |      .NET 4.8 |      .NET 4.8 |     30 | 9000000 | 171.5 ms | 0.52 ms | 0.44 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET 4.8 |      .NET 4.8 |     30 | 9000000 | 174.0 ms | 0.22 ms | 0.19 ms |     - |     - |     - |         - |
| BoseNelson_Comparable | .NET Core 3.1 | .NET Core 3.1 |     30 | 9000000 | 132.4 ms | 0.88 ms | 0.78 ms |     - |     - |     - |         - |
| BoseNelson_Branchless | .NET Core 3.1 | .NET Core 3.1 |     30 | 9000000 | 163.9 ms | 0.15 ms | 0.12 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 3.1 | .NET Core 3.1 |     30 | 9000000 | 122.8 ms | 2.45 ms | 3.27 ms |     - |     - |     - |         - |
| BoseNelson_Comparable | .NET Core 5.0 | .NET Core 5.0 |     30 | 9000000 | 129.1 ms | 0.51 ms | 0.48 ms |     - |     - |     - |         - |
| BoseNelson_Branchless | .NET Core 5.0 | .NET Core 5.0 |     30 | 9000000 | 163.9 ms | 0.18 ms | 0.15 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 5.0 | .NET Core 5.0 |     30 | 9000000 | 131.4 ms | 1.95 ms | 1.83 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     30 | 9000000 | 128.3 ms | 0.13 ms | 0.11 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |    CoreRt 3.1 |    CoreRt 3.1 |     30 | 9000000 | 160.5 ms | 0.26 ms | 0.23 ms |     - |     - |     - |         - |
|  Insertion_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     30 | 9000000 | 128.0 ms | 2.40 ms | 2.25 ms |     - |     - |     - |         - |
