namespace SortingNetworks.Benchmarks
{
	using System.Runtime.CompilerServices;
	using BenchmarkDotNet.Attributes;
	using BenchmarkDotNet.Jobs;

	[SimpleJob(RuntimeMoniker.NetCoreApp31)]
	[SimpleJob(RuntimeMoniker.NetCoreApp50)]
	[MemoryDiagnoser, DisassemblyDiagnoser(exportCombinedDisassemblyReport: true)]
	public class SortingBenchmark
	{
		private const int N = 1_000_000;
		private int[] sortables;

		[IterationSetup]
		public void Setup()
		{
			sortables = new int[N * 10];

			for (int i = 0; i < N * 10; i++)
			{
				sortables[i] = i;
			}
		}

		[Benchmark]
		public void SA8()
		{
			for (int i = 0; i < N; i += 8)
			{
				ref int p0 = ref Unsafe.Add(ref sortables[0], i);

				SN.Sort8(ref p0);
			}
		}
	}
}
