namespace SortingNetworks.Benchmarks
{
	using System;
	using BenchmarkDotNet.Attributes;

	[MemoryDiagnoser, DisassemblyDiagnoser(exportCombinedDisassemblyReport: true)]
	public abstract class SNFixedBenchmarkBase : SNBenchmarkBase
	{
		public abstract int Length { get; set; }

		[Benchmark]
		public void SortAscending_Insertion()
		{
			for (int i = 0; i < _iterationItems.Length; i += Length)
			{
				Span<int> slice = _iterationItems.AsSpan(i, Length);

				PrivateInsertionSortAscending(slice);
			}
		}
	}
}
