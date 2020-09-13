namespace SortingNetworks.Benchmarks
{
	using System;
	using BenchmarkDotNet.Attributes;

	[MemoryDiagnoser, DisassemblyDiagnoser(exportCombinedDisassemblyReport: true)]
	public abstract class SNFixedBenchmarkBase : SNBenchmarkBase
	{
		public abstract int Length { get; set; }

		protected int[] Items;

		[IterationSetup]
		public void Setup()
		{
			Items = new int[N * Length];

			for (int i = 0; i < N * Length; i++)
			{
				Items[i] = i;
			}
		}

		[Benchmark]
		public void SortAscending_Insertion()
		{
			for (int i = 0; i < N; i += Length)
			{
				Span<int> slice = Items.AsSpan(i, Length);

				PrivateInsertionSortAscending(slice);
			}
		}
	}
}
