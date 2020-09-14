``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.508 (2004/?/20H1)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
  [Host]        : .NET Framework 4.8 (4.8.4220.0), X64 RyuJIT
  .NET 4.8      : .NET Framework 4.8 (4.8.4220.0), X64 RyuJIT
  .NET Core 3.1 : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

InvocationCount=1  UnrollFactor=1  

```
|                          Method |           Job |       Runtime | Length |      Mean |    Error |   StdDev | Code Size |      Gen 0 | Gen 1 | Gen 2 |  Allocated |
|-------------------------------- |-------------- |-------------- |------- |----------:|---------:|---------:|----------:|-----------:|------:|------:|-----------:|
|        SortAscending_Comparable |      .NET 4.8 |      .NET 4.8 |      9 |  12.49 ms | 0.057 ms | 0.051 ms |     652 B |          - |     - |     - |          - |
|        SortAscending_Comparison |      .NET 4.8 |      .NET 4.8 |      9 | 108.46 ms | 1.048 ms | 0.929 ms |     608 B | 54000.0000 |     - |     - | 71324304 B |
| SortAscending_ComparisonPointer |      .NET 4.8 |      .NET 4.8 |      9 |  61.11 ms | 0.366 ms | 0.342 ms |     848 B |          - |     - |     - |          - |
|         SortAscending_Insertion |      .NET 4.8 |      .NET 4.8 |      9 |  19.29 ms | 0.171 ms | 0.160 ms |     517 B |          - |     - |     - |          - |
|        SortAscending_Comparable | .NET Core 3.1 | .NET Core 3.1 |      9 |  13.70 ms | 0.087 ms | 0.081 ms |     652 B |          - |     - |     - |          - |
|        SortAscending_Comparison | .NET Core 3.1 | .NET Core 3.1 |      9 | 111.92 ms | 1.191 ms | 1.114 ms |     614 B |  8000.0000 |     - |     - | 71111168 B |
| SortAscending_ComparisonPointer | .NET Core 3.1 | .NET Core 3.1 |      9 |  61.13 ms | 0.451 ms | 0.422 ms |     848 B |          - |     - |     - |          - |
|         SortAscending_Insertion | .NET Core 3.1 | .NET Core 3.1 |      9 |  12.67 ms | 0.107 ms | 0.095 ms |     268 B |          - |     - |     - |          - |
