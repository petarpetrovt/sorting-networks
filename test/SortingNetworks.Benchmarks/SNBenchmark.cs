namespace SortingNetworks.Benchmarks
{
	using System;
	using BenchmarkDotNet.Attributes;
	using BenchmarkDotNet.Jobs;

	[SimpleJob(RuntimeMoniker.NetCoreApp31)]
	[SimpleJob(RuntimeMoniker.NetCoreApp50)]
	[MemoryDiagnoser, DisassemblyDiagnoser(exportCombinedDisassemblyReport: true)]
	public abstract class SNBenchmark
	{
		protected static void PrivateInsertionSort<T>(Span<T> span)
			where T : IComparable<T>
		{
			int length = span.Length;

			for (int i = 1; i < length; ++i)
			{
				T key = span[i];
				int j = i - 1;

				// Move elements of arr[0..i-1], 
				// that are greater than key, 
				// to one position ahead of 
				// their current position 
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
