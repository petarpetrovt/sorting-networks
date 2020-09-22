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
|                Method |           Job |       Runtime | Length |       Mean |   Error |  StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------- |-------------- |-------------- |------- |-----------:|--------:|--------:|------:|------:|------:|----------:|
| SN_Generic_Comparable |      .NET 4.8 |      .NET 4.8 |     31 |   859.4 ms | 1.30 ms | 1.22 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable |      .NET 4.8 |      .NET 4.8 |     31 |   870.7 ms | 3.38 ms | 3.16 ms |     - |     - |     - |         - |
|  Insertion_Comparable |      .NET 4.8 |      .NET 4.8 |     31 | 1,015.5 ms | 3.40 ms | 3.18 ms |     - |     - |     - |         - |
| SN_Generic_Comparable | .NET Core 3.1 | .NET Core 3.1 |     31 | 1,101.8 ms | 2.03 ms | 1.90 ms |     - |     - |     - |    1856 B |
|   SN_Fixed_Comparable | .NET Core 3.1 | .NET Core 3.1 |     31 | 1,079.2 ms | 1.57 ms | 1.47 ms |     - |     - |     - |    1384 B |
|  Insertion_Comparable | .NET Core 3.1 | .NET Core 3.1 |     31 |   685.1 ms | 7.95 ms | 7.43 ms |     - |     - |     - |    1336 B |
| SN_Generic_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     31 |   993.5 ms | 1.12 ms | 1.00 ms |     - |     - |     - |         - |
|   SN_Fixed_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     31 |   990.6 ms | 0.91 ms | 0.85 ms |     - |     - |     - |         - |
|  Insertion_Comparable |    CoreRt 3.1 |    CoreRt 3.1 |     31 |   736.6 ms | 7.96 ms | 7.44 ms |     - |     - |     - |         - |
