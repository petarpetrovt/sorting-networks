namespace SortingNetworks.Benchmarks
{
	using System;
	using BenchmarkDotNet.Attributes;

	public class SN2SortAscendingBenchmark : SNBenchmarkBase
	{
		public const int Length = 2;
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
		public void SortAscending_Comparable()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBoseNelson.Sort2Ascending(ref _items[i]);
			}
		}

		[Benchmark]
		public void SortAscending_Comparison()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBoseNelson.Sort2Ascending(ref _items[i], InternalComparison);
			}
		}

		[Benchmark]
		public unsafe void SortAscending_ComparisonPointer()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBoseNelson.Sort2Ascending(ref _items[i], &InternalComparison);
			}
		}

		[Benchmark]
		public void SortAscending_Insertion()
		{
			for (int i = 0; i < N; i += Length)
			{
				Span<int> slice = _items.AsSpan(i, Length);

				PrivateInsertionSortAscending(slice);
			}
		}
	}
}
