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
|                Method |           Job |       Runtime | Length |   Count |     Mean |   Error |  StdDev |   Median | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |-------------- |-------------- |------- |-------- |---------:|--------:|--------:|---------:|------:|------:|------:|----------:|
| BoseNelson_Comparable |      .NET 4.8 |      .NET 4.8 |     32 | 9000000 | 139.0 ms | 0.45 ms | 0.40 ms | 139.0 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |      .NET 4.8 |      .NET 4.8 |     32 | 9000000 | 162.9 ms | 1.49 ms | 1.40 ms | 163.0 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET 4.8 |      .NET 4.8 |     32 | 9000000 | 181.0 ms | 0.20 ms | 0.18 ms | 181.0 ms |     - |     - |     - |         - |
| BoseNelson_Comparable | .NET Core 3.1 | .NET Core 3.1 |     32 | 9000000 | 133.8 ms | 0.23 ms | 0.21 ms | 133.9 ms |     - |     - |     - |         - |
| BoseNelson_Branchless | .NET Core 3.1 | .NET Core 3.1 |     32 | 9000000 | 161.9 ms | 1.33 ms | 1.25 ms | 161.5 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 3.1 | .NET Core 3.1 |     32 | 9000000 | 126.8 ms | 2.50 ms | 3.51 ms | 128.1 ms |     - |     - |     - |         - |
| BoseNelson_Comparable | .NET Core 5.0 | .NET Core 5.0 |     32 | 9000000 | 133.3 ms | 0.14 ms | 0.11 ms | 133.3 ms |     - |     - |     - |         - |
| BoseNelson_Branchless | .NET Core 5.0 | .NET Core 5.0 |     32 | 9000000 | 162.5 ms | 1.34 ms | 1.25 ms | 162.5 ms |     - |     - |     - |         - |
|  Insertion_Comparable | .NET Core 5.0 | .NET Core 5.0 |     32 | 9000000 | 135.6 ms | 2.70 ms | 5.65 ms | 137.0 ms |     - |     - |     - |         - |
| BoseNelson_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     32 | 9000000 | 132.2 ms | 0.04 ms | 0.03 ms | 132.2 ms |     - |     - |     - |         - |
| BoseNelson_Branchless |    CoreRt 3.1 |    CoreRt 3.1 |     32 | 9000000 | 154.9 ms | 0.59 ms | 0.55 ms | 155.0 ms |     - |     - |     - |         - |
|  Insertion_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     32 | 9000000 | 128.9 ms | 2.57 ms | 7.16 ms | 133.1 ms |     - |     - |     - |         - |
