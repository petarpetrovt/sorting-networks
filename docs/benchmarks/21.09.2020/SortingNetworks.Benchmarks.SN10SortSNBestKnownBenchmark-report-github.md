``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.508 (2004/?/20H1)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
.NET Core SDK=3.1.402
  [Host]        : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  .NET 4.8      : .NET Framework 4.8 (4.8.4220.0), X64 RyuJIT
  .NET Core 3.1 : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  CoreRt 3.1    : .NET 5.0.29316.02 @BuiltBy: dlab14-DDVSOWINAGE075 @Branch: master @Commit: 40be8b7e2598b2ccb827fd90cd30c0e2d4496941, X64 AOT

InvocationCount=1  UnrollFactor=1  

```
|                Method |           Job |       Runtime | Length |     Mean |   Error |  StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |-------------- |-------------- |------- |---------:|--------:|--------:|------:|------:|------:|----------:|
| SN_Generic_Comparable |      .NET 4.8 |      .NET 4.8 |     10 | 366.2 ms | 2.10 ms | 1.75 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable |      .NET 4.8 |      .NET 4.8 |     10 | 344.3 ms | 3.01 ms | 2.82 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET 4.8 |      .NET 4.8 |     10 | 548.7 ms | 0.81 ms | 0.67 ms |     - |     - |     - |         - |
| SN_Generic_Comparable | .NET Core 3.1 | .NET Core 3.1 |     10 | 367.6 ms | 2.47 ms | 2.06 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable | .NET Core 3.1 | .NET Core 3.1 |     10 | 351.2 ms | 4.57 ms | 4.27 ms |     - |     - |     - |   14392 B |
|  Insertion_Comparable | .NET Core 3.1 | .NET Core 3.1 |     10 | 439.8 ms | 4.31 ms | 4.03 ms |     - |     - |     - |         - |
| SN_Generic_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     10 | 362.1 ms | 1.79 ms | 1.39 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     10 | 354.8 ms | 3.71 ms | 3.47 ms |     - |     - |     - |         - |
|  Insertion_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     10 | 437.4 ms | 1.35 ms | 1.05 ms |     - |     - |     - |         - |
