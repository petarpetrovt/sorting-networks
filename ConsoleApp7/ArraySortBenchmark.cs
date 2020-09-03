namespace ConsoleApp7
{
	using System;
	using System.Runtime.CompilerServices;
	using BenchmarkDotNet.Attributes;

	[MemoryDiagnoser,
		DisassemblyDiagnoser(exportHtml: true, printInstructionAddresses: true, exportCombinedDisassemblyReport: true, exportDiff: true),
		HtmlExporter]
	public class ArraySortBenchmark
	{
		private IPool[] pools;

		[Params(6)]
		public int PoolCount;

		[IterationSetup]
		public void Setup()
		{
			pools = new IPool[PoolCount];

			for (int i = 0; i < PoolCount; i++)
			{
				pools[i] = new Pool();
			}
		}

		[Benchmark]
		public void ArraySort()
		{
			Array.Sort(pools, (pool1, pool2) => pool1.Count.CompareTo(pool2.Count));
		}

		[Benchmark]
		public void ArraySortNetworkV1()
		{
			sort6_sorting_network_v1(pools);
		}

		[Benchmark]
		public void ArraySortNetworkV2()
		{
			sort6_sorting_network_v2(pools);
		}

		public interface IPool
		{
			ref readonly uint Count { get; }
		}

		public class Pool : IPool
		{
			private readonly uint _count;

			public ref readonly uint Count
				=> ref _count;

			public Pool()
			{
				_count = (uint)new Random().Next(0, int.MaxValue / 2);
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static void sort6_sorting_network_v1(IPool[] d)
		{
			SWAP(d, 1, 2);
			SWAP(d, 0, 2);
			SWAP(d, 0, 1);
			SWAP(d, 4, 5);
			SWAP(d, 3, 5);
			SWAP(d, 3, 4);
			SWAP(d, 0, 3);
			SWAP(d, 1, 4);
			SWAP(d, 2, 5);
			SWAP(d, 2, 4);
			SWAP(d, 1, 3);
			SWAP(d, 2, 3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static void sort6_sorting_network_v2(IPool[] array)
		{
			ref IPool d = ref array[0];

			sort3_sorting_network_v2(ref Unsafe.Add(ref d, 0), ref Unsafe.Add(ref d, 1), ref Unsafe.Add(ref d, 2));
			sort3_sorting_network_v2(ref Unsafe.Add(ref d, 3), ref Unsafe.Add(ref d, 4), ref Unsafe.Add(ref d, 5));
			sort2_sorting_network_v2(ref Unsafe.Add(ref d, 0), ref Unsafe.Add(ref d, 3));
			sort2_sorting_network_v2(ref Unsafe.Add(ref d, 2), ref Unsafe.Add(ref d, 5));
			sort4_sorting_network_v2(ref Unsafe.Add(ref d, 1), ref Unsafe.Add(ref d, 2), ref Unsafe.Add(ref d, 3), ref Unsafe.Add(ref d, 4));
		}


		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static void sort4_sorting_network_v2(ref IPool p0, ref IPool p1, ref IPool p2, ref IPool p3)
		{
			sort2_sorting_network_v2(ref p0, ref p1);
			sort2_sorting_network_v2(ref p2, ref p3);
			sort2_sorting_network_v2(ref p0, ref p2);
			sort2_sorting_network_v2(ref p1, ref p3);
			sort2_sorting_network_v2(ref p1, ref p2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static void sort3_sorting_network_v2(ref IPool p0, ref IPool p1, ref IPool p2)
		{
			sort2_sorting_network_v2(ref p0, ref p1);
			sort2_sorting_network_v2(ref p1, ref p2);
			sort2_sorting_network_v2(ref p0, ref p1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		static void sort2_sorting_network_v2(ref IPool p0, ref IPool p1)
		{
			if (p0.Count < p1.Count)
			{
				IPool tmp = p0;
				p0 = p1;
				p1 = tmp;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SWAP(IPool[] d, in int x, in int y)
		{
			if (d[y].Count < d[x].Count)
			{
				IPool tmp = d[x];
				d[x] = d[y];
				d[y] = tmp;
			}
		}
	}
}
