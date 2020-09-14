# benchmarks

## Generic overload

``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.508 (2004/?/20H1)
AMD Ryzen 7 3700X, 1 CPU, 16 logical and 8 physical cores
  [Host]        : .NET Framework 4.8 (4.8.4220.0), X64 RyuJIT
  .NET 4.8      : .NET Framework 4.8 (4.8.4220.0), X64 RyuJIT
  .NET Core 3.1 : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

InvocationCount=1  UnrollFactor=1  

```
|                  Method |           Job |       Runtime | Length |      Mean |    Error |   StdDev |    Median | Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------ |-------------- |-------------- |------- |----------:|---------:|---------:|----------:|------:|------:|------:|----------:|
|        **SortAscending_SN** |      **.NET 4.8** |      **.NET 4.8** |      **2** |  **24.64 ms** | **0.951 ms** | **2.805 ms** |  **25.18 ms** |     **-** |     **-** |     **-** |         **-** |
| SortAscending_Insertion |      .NET 4.8 |      .NET 4.8 |      2 |  31.04 ms | 0.592 ms | 0.553 ms |  31.20 ms |     - |     - |     - |         - |
|        SortAscending_SN | .NET Core 3.1 | .NET Core 3.1 |      2 |  26.33 ms | 0.542 ms | 1.598 ms |  26.91 ms |     - |     - |     - |         - |
| SortAscending_Insertion | .NET Core 3.1 | .NET Core 3.1 |      2 |  25.47 ms | 0.476 ms | 0.445 ms |  25.55 ms |     - |     - |     - |         - |
|        **SortAscending_SN** |      **.NET 4.8** |      **.NET 4.8** |      **3** |  **23.70 ms** | **0.268 ms** | **0.251 ms** |  **23.71 ms** |     **-** |     **-** |     **-** |         **-** |
| SortAscending_Insertion |      .NET 4.8 |      .NET 4.8 |      3 |  35.32 ms | 0.671 ms | 1.294 ms |  35.27 ms |     - |     - |     - |         - |
|        SortAscending_SN | .NET Core 3.1 | .NET Core 3.1 |      3 |  23.46 ms | 0.147 ms | 0.137 ms |  23.47 ms |     - |     - |     - |         - |
| SortAscending_Insertion | .NET Core 3.1 | .NET Core 3.1 |      3 |  21.73 ms | 0.365 ms | 0.342 ms |  21.73 ms |     - |     - |     - |         - |
|        **SortAscending_SN** |      **.NET 4.8** |      **.NET 4.8** |      **4** |  **20.28 ms** | **0.170 ms** | **0.159 ms** |  **20.25 ms** |     **-** |     **-** |     **-** |         **-** |
| SortAscending_Insertion |      .NET 4.8 |      .NET 4.8 |      4 |  42.19 ms | 0.349 ms | 0.326 ms |  42.14 ms |     - |     - |     - |         - |
|        SortAscending_SN | .NET Core 3.1 | .NET Core 3.1 |      4 |  20.94 ms | 0.115 ms | 0.108 ms |  20.93 ms |     - |     - |     - |         - |
| SortAscending_Insertion | .NET Core 3.1 | .NET Core 3.1 |      4 |  23.65 ms | 0.189 ms | 0.167 ms |  23.66 ms |     - |     - |     - |         - |
|        **SortAscending_SN** |      **.NET 4.8** |      **.NET 4.8** |      **5** |  **22.24 ms** | **0.139 ms** | **0.130 ms** |  **22.26 ms** |     **-** |     **-** |     **-** |         **-** |
| SortAscending_Insertion |      .NET 4.8 |      .NET 4.8 |      5 |  54.29 ms | 1.067 ms | 1.142 ms |  54.26 ms |     - |     - |     - |         - |
|        SortAscending_SN | .NET Core 3.1 | .NET Core 3.1 |      5 |  21.86 ms | 0.085 ms | 0.079 ms |  21.89 ms |     - |     - |     - |         - |
| SortAscending_Insertion | .NET Core 3.1 | .NET Core 3.1 |      5 |  26.49 ms | 0.501 ms | 0.536 ms |  26.51 ms |     - |     - |     - |         - |
|        **SortAscending_SN** |      **.NET 4.8** |      **.NET 4.8** |      **6** |  **19.84 ms** | **0.130 ms** | **0.122 ms** |  **19.83 ms** |     **-** |     **-** |     **-** |         **-** |
| SortAscending_Insertion |      .NET 4.8 |      .NET 4.8 |      6 |  61.46 ms | 0.298 ms | 0.279 ms |  61.45 ms |     - |     - |     - |         - |
|        SortAscending_SN | .NET Core 3.1 | .NET Core 3.1 |      6 |  19.83 ms | 0.118 ms | 0.111 ms |  19.79 ms |     - |     - |     - |         - |
| SortAscending_Insertion | .NET Core 3.1 | .NET Core 3.1 |      6 |  30.04 ms | 0.340 ms | 0.318 ms |  30.04 ms |     - |     - |     - |         - |
|        **SortAscending_SN** |      **.NET 4.8** |      **.NET 4.8** |      **7** |  **20.64 ms** | **0.125 ms** | **0.117 ms** |  **20.60 ms** |     **-** |     **-** |     **-** |         **-** |
| SortAscending_Insertion |      .NET 4.8 |      .NET 4.8 |      7 |  71.01 ms | 0.422 ms | 0.374 ms |  70.96 ms |     - |     - |     - |         - |
|        SortAscending_SN | .NET Core 3.1 | .NET Core 3.1 |      7 |  20.32 ms | 0.112 ms | 0.105 ms |  20.30 ms |     - |     - |     - |         - |
| SortAscending_Insertion | .NET Core 3.1 | .NET Core 3.1 |      7 |  33.17 ms | 0.523 ms | 0.464 ms |  33.02 ms |     - |     - |     - |         - |
|        **SortAscending_SN** |      **.NET 4.8** |      **.NET 4.8** |      **8** |  **19.01 ms** | **0.118 ms** | **0.105 ms** |  **19.06 ms** |     **-** |     **-** |     **-** |         **-** |
| SortAscending_Insertion |      .NET 4.8 |      .NET 4.8 |      8 |  81.57 ms | 0.498 ms | 0.466 ms |  81.46 ms |     - |     - |     - |         - |
|        SortAscending_SN | .NET Core 3.1 | .NET Core 3.1 |      8 |  18.31 ms | 0.117 ms | 0.109 ms |  18.36 ms |     - |     - |     - |         - |
| SortAscending_Insertion | .NET Core 3.1 | .NET Core 3.1 |      8 |  37.07 ms | 0.149 ms | 0.132 ms |  37.08 ms |     - |     - |     - |         - |
|        **SortAscending_SN** |      **.NET 4.8** |      **.NET 4.8** |      **9** |  **20.44 ms** | **0.063 ms** | **0.049 ms** |  **20.44 ms** |     **-** |     **-** |     **-** |         **-** |
| SortAscending_Insertion |      .NET 4.8 |      .NET 4.8 |      9 |  88.79 ms | 0.687 ms | 0.609 ms |  88.82 ms |     - |     - |     - |         - |
|        SortAscending_SN | .NET Core 3.1 | .NET Core 3.1 |      9 |  20.45 ms | 0.118 ms | 0.111 ms |  20.42 ms |     - |     - |     - |         - |
| SortAscending_Insertion | .NET Core 3.1 | .NET Core 3.1 |      9 |  39.79 ms | 0.368 ms | 0.326 ms |  39.67 ms |     - |     - |     - |         - |
|        **SortAscending_SN** |      **.NET 4.8** |      **.NET 4.8** |     **10** |  **17.81 ms** | **0.071 ms** | **0.059 ms** |  **17.79 ms** |     **-** |     **-** |     **-** |         **-** |
| SortAscending_Insertion |      .NET 4.8 |      .NET 4.8 |     10 |  97.53 ms | 0.876 ms | 0.819 ms |  97.28 ms |     - |     - |     - |         - |
|        SortAscending_SN | .NET Core 3.1 | .NET Core 3.1 |     10 |  17.54 ms | 0.107 ms | 0.100 ms |  17.53 ms |     - |     - |     - |         - |
| SortAscending_Insertion | .NET Core 3.1 | .NET Core 3.1 |     10 |  43.73 ms | 0.432 ms | 0.404 ms |  43.54 ms |     - |     - |     - |         - |
|        **SortAscending_SN** |      **.NET 4.8** |      **.NET 4.8** |     **11** |  **21.81 ms** | **0.121 ms** | **0.113 ms** |  **21.80 ms** |     **-** |     **-** |     **-** |         **-** |
| SortAscending_Insertion |      .NET 4.8 |      .NET 4.8 |     11 | 105.58 ms | 0.567 ms | 0.531 ms | 105.66 ms |     - |     - |     - |         - |
|        SortAscending_SN | .NET Core 3.1 | .NET Core 3.1 |     11 |  21.48 ms | 0.143 ms | 0.134 ms |  21.47 ms |     - |     - |     - |         - |
| SortAscending_Insertion | .NET Core 3.1 | .NET Core 3.1 |     11 |  47.43 ms | 0.540 ms | 0.505 ms |  47.31 ms |     - |     - |     - |         - |
|        **SortAscending_SN** |      **.NET 4.8** |      **.NET 4.8** |     **12** |  **20.03 ms** | **0.111 ms** | **0.104 ms** |  **20.01 ms** |     **-** |     **-** |     **-** |         **-** |
| SortAscending_Insertion |      .NET 4.8 |      .NET 4.8 |     12 | 114.35 ms | 0.680 ms | 0.636 ms | 114.44 ms |     - |     - |     - |         - |
|        SortAscending_SN | .NET Core 3.1 | .NET Core 3.1 |     12 |  19.71 ms | 0.143 ms | 0.127 ms |  19.70 ms |     - |     - |     - |         - |
| SortAscending_Insertion | .NET Core 3.1 | .NET Core 3.1 |     12 |  51.58 ms | 0.293 ms | 0.274 ms |  51.58 ms |     - |     - |     - |         - |
|        **SortAscending_SN** |      **.NET 4.8** |      **.NET 4.8** |     **13** |  **20.31 ms** | **0.149 ms** | **0.139 ms** |  **20.26 ms** |     **-** |     **-** |     **-** |         **-** |
| SortAscending_Insertion |      .NET 4.8 |      .NET 4.8 |     13 | 122.90 ms | 0.596 ms | 0.528 ms | 122.88 ms |     - |     - |     - |         - |
|        SortAscending_SN | .NET Core 3.1 | .NET Core 3.1 |     13 |  19.95 ms | 0.108 ms | 0.101 ms |  19.94 ms |     - |     - |     - |         - |
| SortAscending_Insertion | .NET Core 3.1 | .NET Core 3.1 |     13 |  54.87 ms | 0.486 ms | 0.431 ms |  54.71 ms |     - |     - |     - |         - |
|        **SortAscending_SN** |      **.NET 4.8** |      **.NET 4.8** |     **14** |  **24.17 ms** | **0.155 ms** | **0.137 ms** |  **24.15 ms** |     **-** |     **-** |     **-** |         **-** |
| SortAscending_Insertion |      .NET 4.8 |      .NET 4.8 |     14 | 136.99 ms | 0.842 ms | 0.746 ms | 137.13 ms |     - |     - |     - |         - |
|        SortAscending_SN | .NET Core 3.1 | .NET Core 3.1 |     14 |  23.79 ms | 0.137 ms | 0.122 ms |  23.78 ms |     - |     - |     - |         - |
| SortAscending_Insertion | .NET Core 3.1 | .NET Core 3.1 |     14 |  58.93 ms | 0.419 ms | 0.371 ms |  58.85 ms |     - |     - |     - |         - |
|        **SortAscending_SN** |      **.NET 4.8** |      **.NET 4.8** |     **15** |  **25.86 ms** | **0.157 ms** | **0.147 ms** |  **25.80 ms** |     **-** |     **-** |     **-** |         **-** |
| SortAscending_Insertion |      .NET 4.8 |      .NET 4.8 |     15 | 148.79 ms | 1.444 ms | 1.206 ms | 148.54 ms |     - |     - |     - |         - |
|        SortAscending_SN | .NET Core 3.1 | .NET Core 3.1 |     15 |  25.85 ms | 0.135 ms | 0.127 ms |  25.82 ms |     - |     - |     - |         - |
| SortAscending_Insertion | .NET Core 3.1 | .NET Core 3.1 |     15 |  62.06 ms | 0.337 ms | 0.315 ms |  61.97 ms |     - |     - |     - |         - |
|        **SortAscending_SN** |      **.NET 4.8** |      **.NET 4.8** |     **16** |  **25.20 ms** | **0.174 ms** | **0.163 ms** |  **25.10 ms** |     **-** |     **-** |     **-** |         **-** |
| SortAscending_Insertion |      .NET 4.8 |      .NET 4.8 |     16 | 159.74 ms | 1.097 ms | 0.916 ms | 159.45 ms |     - |     - |     - |         - |
|        SortAscending_SN | .NET Core 3.1 | .NET Core 3.1 |     16 |  24.91 ms | 0.144 ms | 0.135 ms |  24.87 ms |     - |     - |     - |         - |
| SortAscending_Insertion | .NET Core 3.1 | .NET Core 3.1 |     16 |  66.31 ms | 0.499 ms | 0.442 ms |  66.17 ms |     - |     - |     - |         - |

## Specific

| Length | Link |
| ------ | ---- |
| 02 | [link](13.09.2020/SortingNetworks.Benchmarks.SN2SortSNBoseNelsonBenchmark-report-github.md)  |
| 03 | [link](13.09.2020/SortingNetworks.Benchmarks.SN3SortSNBoseNelsonBenchmark-report-github.md)  |
| 04 | [link](13.09.2020/SortingNetworks.Benchmarks.SN4SortSNBoseNelsonBenchmark-report-github.md)  |
| 05 | [link](13.09.2020/SortingNetworks.Benchmarks.SN5SortSNBoseNelsonBenchmark-report-github.md)  |
| 06 | [link](13.09.2020/SortingNetworks.Benchmarks.SN6SortSNBoseNelsonBenchmark-report-github.md)  |
| 07 | [link](13.09.2020/SortingNetworks.Benchmarks.SN7SortSNBoseNelsonBenchmark-report-github.md)  |
| 08 | [link](13.09.2020/SortingNetworks.Benchmarks.SN8SortSNBoseNelsonBenchmark-report-github.md)  |
| 09 | [link](13.09.2020/SortingNetworks.Benchmarks.SN9SortSNBestKnownBenchmark-report-github.md)	  |
| 10 | [link](13.09.2020/SortingNetworks.Benchmarks.SN10SortSNBestKnownBenchmark-report-github.md) |
| 11 | [link](13.09.2020/SortingNetworks.Benchmarks.SN11SortSNBestKnownBenchmark-report-github.md) |
| 12 | [link](13.09.2020/SortingNetworks.Benchmarks.SN12SortSNBestKnownBenchmark-report-github.md) |
| 13 | [link](13.09.2020/SortingNetworks.Benchmarks.SN13SortSNBestKnownBenchmark-report-github.md) |
| 14 | [link](13.09.2020/SortingNetworks.Benchmarks.SN14SortSNBestKnownBenchmark-report-github.md) |
| 15 | [link](13.09.2020/SortingNetworks.Benchmarks.SN15SortSNBestKnownBenchmark-report-github.md) |
| 16 | [link](13.09.2020/SortingNetworks.Benchmarks.SN16SortSNBestKnownBenchmark-report-github.md) |