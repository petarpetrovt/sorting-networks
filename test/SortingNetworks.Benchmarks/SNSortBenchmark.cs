namespace SortingNetworks.Benchmarks
{
	using System;
	using BenchmarkDotNet.Attributes;

	public class SNSortBenchmark : SNBenchmarkBase
	{
		[Params(2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16)]
		public int Length;

		[Benchmark]
		public void SortAscending_SN()
		{
			for (int i = 0; i < _iterationItems.Length; i += Length)
			{
				Span<int> buffer = _iterationItems.AsSpan(i, Length);

				SN.SortAscending(buffer);
			}
		}

		[Benchmark]
		public void SortAscending_Insertion()
		{
			for (int i = 0; i < _iterationItems.Length; i += Length)
			{
				Span<int> buffer = _iterationItems.AsSpan(i, Length);

				PrivateInsertionSortAscending(buffer);
			}
		}
	}
}
