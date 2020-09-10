namespace SortingNetworks.Benchmarks
{
	using System;
	using BenchmarkDotNet.Attributes;
	using BenchmarkDotNet.Jobs;

	[SimpleJob(RuntimeMoniker.NetCoreApp30)]
	[SimpleJob(RuntimeMoniker.NetCoreApp31)]
	[MemoryDiagnoser, DisassemblyDiagnoser(exportCombinedDisassemblyReport: true)]
	public abstract class SNBenchmarkBase
	{
		protected static void PrivateInsertionSort<T>(Span<T> span)
			where T : IComparable<T>
		{
			int length = span.Length;

			for (int i = 1; i < length; ++i)
			{
				T key = span[i];
				int j = i - 1;

				while (j >= 0 && span[j].CompareTo(key) > 0)
				{
					span[j + 1] = span[j];
					j -= 1;
				}

				span[j + 1] = key;
			}
		}
	}
}
