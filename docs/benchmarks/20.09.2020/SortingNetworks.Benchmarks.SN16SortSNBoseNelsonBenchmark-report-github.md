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
| SN_Generic_Comparable |      .NET 4.8 |      .NET 4.8 |     16 | 483.8 ms | 1.21 ms | 1.07 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable |      .NET 4.8 |      .NET 4.8 |     16 | 470.1 ms | 1.21 ms | 1.13 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET 4.8 |      .NET 4.8 |     16 | 703.4 ms | 3.99 ms | 3.73 ms |     - |     - |     - |         - |
| SN_Generic_Comparable | .NET Core 3.1 | .NET Core 3.1 |     16 | 473.6 ms | 2.21 ms | 1.96 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable | .NET Core 3.1 | .NET Core 3.1 |     16 | 469.5 ms | 2.50 ms | 2.08 ms |     - |     - |     - |    1856 B |
|  Insertion_Comparable | .NET Core 3.1 | .NET Core 3.1 |     16 | 515.5 ms | 4.34 ms | 3.62 ms |     - |     - |     - |    1448 B |
| SN_Generic_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     16 | 477.5 ms | 2.88 ms | 2.69 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     16 | 466.5 ms | 1.75 ms | 1.64 ms |     - |     - |     - |         - |
|  Insertion_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     16 | 545.1 ms | 5.25 ms | 4.91 ms |     - |     - |     - |         - |
