namespace SortingNetworks.Benchmarks
{
	using System;
	using System.Runtime.CompilerServices;
	using BenchmarkDotNet.Attributes;

	public class SN8Benchmark : SNBenchmarkBase
	{
		private const int Length = 8;
		private const int N = 10_000_000;

		private int[] _items;

		[IterationSetup]
		public void Setup()
		{
			_items = new int[N * Length];

			for (int i = 0; i < N * Length; i++)
			{
				_items[i] = i;
			}
		}

		[Benchmark]
		public void BoseNelson()
		{
			for (int i = 0; i < N; i += Length)
			{
				ref int p0 = ref Unsafe.Add(ref _items[0], i);

				SNBoseNelson.Sort8Ascending(ref p0);
			}
		}

		[Benchmark]
		public void InsertionSort()
		{
			for (int i = 0; i < N; i += 8)
			{
				Span<int> slice = _items.AsSpan(i, Length);

				PrivateInsertionSort(slice);
			}
		}
	}
}
