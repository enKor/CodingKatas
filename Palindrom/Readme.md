In this solution you can find _IsPalindrome_ methods samples with different implementation to see the performance differences.

Benchmarks:
- BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1889 (21H2)
- Intel Core i7-9850H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
- .NET SDK=6.0.200
- [Host]     : .NET 6.0.2 (6.0.222.6406), X64 RyuJIT  [AttachedDebugger]
- DefaultJob : .NET 6.0.2 (6.0.222.6406), X64 RyuJIT
  


|                            Method |     String To Check |         Mean |      Error |      StdDev |       Median | Ratio | RatioSD |  Gen 0 | Allocated |
|---------------------------------- |-------------------- |-------------:|-----------:|------------:|-------------:|------:|--------:|-------:|----------:|
|              IsPalindrome_ForLoop | dghj(...)jhgd [158] |   104.488 ns |  2.8117 ns |   8.1573 ns |   102.679 ns |  1.00 |    0.00 |      - |         - |
|             IsPalindrome_LoopSpan | dghj(...)jhgd [158] |   296.635 ns |  7.8546 ns |  22.4095 ns |   292.239 ns |  2.85 |    0.27 |      - |         - |
|        IsPalindrome_LoopSubString | dghj(...)jhgd [158] | 1,995.297 ns | 92.4154 ns | 268.1139 ns | 1,932.810 ns | 19.20 |    2.92 | 0.6027 |   3,792 B |
|          IsPalindrome_FullReverse | dghj(...)jhgd [158] | 1,395.061 ns | 27.7854 ns |  76.5289 ns | 1,371.029 ns | 13.38 |    1.09 | 0.2403 |   1,512 B |
|    IsPalindrome_HalfReverseSubstr | dghj(...)jhgd [158] |   722.722 ns | 14.1043 ns |  21.1107 ns |   716.672 ns |  6.48 |    0.55 | 0.2031 |   1,280 B |
|   IsPalindrome_HalfReverseIndexer | dghj(...)jhgd [158] |   746.595 ns | 15.6343 ns |  43.0613 ns |   731.518 ns |  7.17 |    0.74 | 0.2031 |   1,280 B |
|             IsPalindrome_HashCode | dghj(...)jhgd [158] |   329.084 ns |  6.0267 ns |   5.0326 ns |   329.861 ns |  2.88 |    0.18 | 0.1097 |     688 B |
|                                   |                     |              |            |             |              |       |         |        |           |
|              IsPalindrome_ForLoop |               radar |     3.115 ns |  0.0833 ns |   0.1195 ns |     3.069 ns |  1.00 |    0.00 |      - |         - |
|             IsPalindrome_LoopSpan |               radar |     7.209 ns |  0.0550 ns |   0.0487 ns |     7.190 ns |  2.31 |    0.10 |      - |         - |
|        IsPalindrome_LoopSubString |               radar |    46.534 ns |  0.9314 ns |   1.7032 ns |    46.527 ns | 14.94 |    0.87 | 0.0153 |      96 B |
|          IsPalindrome_FullReverse |               radar |   175.690 ns |  3.5348 ns |   8.3320 ns |   171.825 ns | 58.30 |    4.22 | 0.0355 |     224 B |
|    IsPalindrome_HalfReverseSubstr |               radar |   134.408 ns |  3.5094 ns |   9.7245 ns |   132.923 ns | 43.07 |    3.80 | 0.0381 |     240 B |
|   IsPalindrome_HalfReverseIndexer |               radar |   121.231 ns |  2.2064 ns |   2.1670 ns |   120.870 ns | 39.03 |    1.74 | 0.0381 |     240 B |
|             IsPalindrome_HashCode |               radar |    37.575 ns |  0.7429 ns |   1.4313 ns |    37.208 ns | 12.22 |    0.59 | 0.0114 |      72 B |


Legends:
  - ToCheck   : Value of the 'ToCheck' parameter
  - Mean      : Arithmetic mean of all measurements
  - Error     : Half of 99.9% confidence interval
  - StdDev    : Standard deviation of all measurements
  - Median    : Value separating the higher half of all measurements (50th percentile)
  - Ratio     : Mean of the ratio distribution ([Current]/[Baseline])
  - RatioSD   : Standard deviation of the ratio distribution ([Current]/[Baseline])
  - Gen 0     : GC Generation 0 collects per 1000 operations
  - Allocated : Allocated memory per single operation (managed only, inclusive, 1KB = 1024B)
  - 1 ns      : 1 Nanosecond (0.000000001 sec)
