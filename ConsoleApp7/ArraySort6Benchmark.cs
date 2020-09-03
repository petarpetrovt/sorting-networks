namespace ConsoleApp7
{
	using System.Runtime.CompilerServices;
	using BenchmarkDotNet.Attributes;

	[MemoryDiagnoser,
		DisassemblyDiagnoser(exportHtml: true, printInstructionAddresses: true, exportCombinedDisassemblyReport: true, exportDiff: true),
		HtmlExporter]
	public class ArraySort6Benchmark
	{
		private const int PoolSize = 6;
		private const int Count = 100_000_000;

		private ISortable[] pools;

		[IterationSetup]
		public void Setup()
		{
			pools = new ISortable[Count * PoolSize];

			for (int i = 0; i < Count * PoolSize; i++)
			{
				pools[i] = new Sortable((uint)i);
			}
		}

		[Benchmark]
		public void ArraySortNetworkV1()
		{
			for (int i = 0; i < Count; i += PoolSize)
			{
				ref ISortable p0 = ref Unsafe.Add(ref pools[0], i);

				SortableAlgorithms.sort6_sorting_network_v1(ref p0);
			}
		}

		[Benchmark]
		public void ArraySortNetworkGenericV1()
		{
			for (int i = 0; i < Count; i += PoolSize)
			{
				ref ISortable p0 = ref Unsafe.Add(ref pools[0], i);

				SortableAlgorithms<ISortable>.sort6_sorting_network_v1(ref p0, (x, y) => x.Count.CompareTo(y.Count));
			}
		}

		[Benchmark]
		public void ArraySortNetworkV2()
		{
			for (int i = 0; i < Count; i += PoolSize)
			{
				ref ISortable p0 = ref Unsafe.Add(ref pools[0], i);

				SortableAlgorithms.sort6_sorting_network_v2(ref p0);
			}
		}

		[Benchmark]
		public void ArraySortNetworkGenericV2()
		{
			for (int i = 0; i < Count; i += PoolSize)
			{
				ref ISortable p0 = ref Unsafe.Add(ref pools[0], i);

				SortableAlgorithms<ISortable>.sort6_sorting_network_v2(ref p0, (x, y) => x.Count.CompareTo(y.Count));
			}
		}
	}
}
