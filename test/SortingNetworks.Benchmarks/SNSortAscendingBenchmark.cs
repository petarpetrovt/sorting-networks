namespace SortingNetworks.Benchmarks
{
	using System;
	using BenchmarkDotNet.Attributes;

	public class SNSortAscendingBenchmark : SNBenchmarkBase
	{
		private int[] _items;

		[Params(2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16)]
		public int Length;

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
				Span<int> buffer = _items.AsSpan(0, Length);

				SN.SortAscending(buffer);
			}
		}

		[Benchmark]
		public void SortAscending_Comparison()
		{
			for (int i = 0; i < N; i += Length)
			{
				Span<int> buffer = _items.AsSpan(0, Length);

				SN.SortAscending(buffer, InternalComparison);
			}
		}

		[Benchmark]
		public unsafe void SortAscending_ComparisonPointer()
		{
			for (int i = 0; i < N; i += Length)
			{
				Span<int> buffer = _items.AsSpan(0, Length);

				SN.SortAscending(buffer, &InternalComparison);
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
