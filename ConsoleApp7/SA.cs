using System.Runtime.CompilerServices;

namespace ConsoleApp7
{
	public static class SA
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void sort6_sorting_network_v1_inlined_full_optimized(ref ISortable p0)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);

			if (p1.Count < p2.Count)
			{
				ISortable tmp = p1;
				p1 = p2;
				p2 = tmp;
			}

			if (p0.Count < p2.Count)
			{
				ISortable tmp = p0;
				p0 = p2;
				p2 = tmp;
			}

			if (p0.Count < p1.Count)
			{
				ISortable tmp = p0;
				p0 = p1;
				p1 = tmp;
			}

			ref var p4 = ref Unsafe.Add(ref p0, 4);
			ref var p5 = ref Unsafe.Add(ref p0, 5);

			if (p4.Count < p5.Count)
			{
				ISortable tmp = p4;
				p4 = p5;
				p5 = tmp;
			}

			ref var p3 = ref Unsafe.Add(ref p0, 3);
			if (p3.Count < p5.Count)
			{
				ISortable tmp = p3;
				p3 = p5;
				p5 = tmp;
			}

			if (p3.Count < p4.Count)
			{
				ISortable tmp = p3;
				p3 = p4;
				p4 = tmp;
			}

			if (p0.Count < p3.Count)
			{
				ISortable tmp = p0;
				p0 = p3;
				p3 = tmp;
			}

			if (p1.Count < p4.Count)
			{
				ISortable tmp = p1;
				p1 = p4;
				p4 = tmp;
			}

			if (p2.Count < p5.Count)
			{
				ISortable tmp = p2;
				p2 = p5;
				p5 = tmp;
			}

			if (p2.Count < p4.Count)
			{
				ISortable tmp = p2;
				p2 = p4;
				p4 = tmp;
			}

			if (p1.Count < p3.Count)
			{
				ISortable tmp = p1;
				p1 = p3;
				p3 = tmp;
			}

			if (p2.Count < p3.Count)
			{
				ISortable tmp = p2;
				p2 = p3;
				p3 = tmp;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void sort6_sorting_network_v1_inlined_full(ref ISortable p0)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);
			ref var p5 = ref Unsafe.Add(ref p0, 5);

			if (p1.Count < p2.Count)
			{
				ISortable tmp = p1;
				p1 = p2;
				p2 = tmp;
			}

			if (p0.Count < p2.Count)
			{
				ISortable tmp = p0;
				p0 = p2;
				p2 = tmp;
			}

			if (p0.Count < p1.Count)
			{
				ISortable tmp = p0;
				p0 = p1;
				p1 = tmp;
			}

			if (p4.Count < p5.Count)
			{
				ISortable tmp = p4;
				p4 = p5;
				p5 = tmp;
			}

			if (p3.Count < p5.Count)
			{
				ISortable tmp = p3;
				p3 = p5;
				p5 = tmp;
			}

			if (p3.Count < p4.Count)
			{
				ISortable tmp = p3;
				p3 = p4;
				p4 = tmp;
			}

			if (p0.Count < p3.Count)
			{
				ISortable tmp = p0;
				p0 = p3;
				p3 = tmp;
			}

			if (p1.Count < p4.Count)
			{
				ISortable tmp = p1;
				p1 = p4;
				p4 = tmp;
			}

			if (p2.Count < p5.Count)
			{
				ISortable tmp = p2;
				p2 = p5;
				p5 = tmp;
			}

			if (p2.Count < p4.Count)
			{
				ISortable tmp = p2;
				p2 = p4;
				p4 = tmp;
			}

			if (p1.Count < p3.Count)
			{
				ISortable tmp = p1;
				p1 = p3;
				p3 = tmp;
			}

			if (p2.Count < p3.Count)
			{
				ISortable tmp = p2;
				p2 = p3;
				p3 = tmp;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void sort6_sorting_network_v1_inlined_half(ref ISortable p0)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);
			ref var p5 = ref Unsafe.Add(ref p0, 5);

			sort2_sorting_network_v2(ref p1, ref p2);
			sort2_sorting_network_v2(ref p0, ref p2);
			sort2_sorting_network_v2(ref p0, ref p1);
			sort2_sorting_network_v2(ref p4, ref p5);
			sort2_sorting_network_v2(ref p3, ref p5);
			sort2_sorting_network_v2(ref p3, ref p4);
			sort2_sorting_network_v2(ref p0, ref p3);
			sort2_sorting_network_v2(ref p1, ref p4);
			sort2_sorting_network_v2(ref p2, ref p5);
			sort2_sorting_network_v2(ref p2, ref p4);
			sort2_sorting_network_v2(ref p1, ref p3);
			sort2_sorting_network_v2(ref p2, ref p3);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void sort2_sorting_network_v2(ref ISortable x0, ref ISortable x1)
		{
			if (x0.Count < x1.Count)
			{
				ISortable tmp = x0;
				x0 = x1;
				x1 = tmp;
			}
		}
	}
}
