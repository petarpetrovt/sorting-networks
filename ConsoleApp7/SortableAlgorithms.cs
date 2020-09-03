using System.Runtime.CompilerServices;

namespace ConsoleApp7
{
	public static class SortableAlgorithms
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void sort6_sorting_network_v1(ref ISortable p0)
		{
			sort2_sorting_network_v2(ref Unsafe.Add(ref p0, 1), ref Unsafe.Add(ref p0, 2));
			sort2_sorting_network_v2(ref Unsafe.Add(ref p0, 0), ref Unsafe.Add(ref p0, 2));
			sort2_sorting_network_v2(ref Unsafe.Add(ref p0, 0), ref Unsafe.Add(ref p0, 1));
			sort2_sorting_network_v2(ref Unsafe.Add(ref p0, 4), ref Unsafe.Add(ref p0, 5));
			sort2_sorting_network_v2(ref Unsafe.Add(ref p0, 3), ref Unsafe.Add(ref p0, 5));
			sort2_sorting_network_v2(ref Unsafe.Add(ref p0, 3), ref Unsafe.Add(ref p0, 4));
			sort2_sorting_network_v2(ref Unsafe.Add(ref p0, 0), ref Unsafe.Add(ref p0, 3));
			sort2_sorting_network_v2(ref Unsafe.Add(ref p0, 1), ref Unsafe.Add(ref p0, 4));
			sort2_sorting_network_v2(ref Unsafe.Add(ref p0, 2), ref Unsafe.Add(ref p0, 5));
			sort2_sorting_network_v2(ref Unsafe.Add(ref p0, 2), ref Unsafe.Add(ref p0, 4));
			sort2_sorting_network_v2(ref Unsafe.Add(ref p0, 1), ref Unsafe.Add(ref p0, 3));
			sort2_sorting_network_v2(ref Unsafe.Add(ref p0, 2), ref Unsafe.Add(ref p0, 3));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void sort6_sorting_network_v2(ref ISortable p0)
		{
			sort3_sorting_network_v2(ref Unsafe.Add(ref p0, 0), ref Unsafe.Add(ref p0, 1), ref Unsafe.Add(ref p0, 2));
			sort3_sorting_network_v2(ref Unsafe.Add(ref p0, 3), ref Unsafe.Add(ref p0, 4), ref Unsafe.Add(ref p0, 5));
			sort2_sorting_network_v2(ref Unsafe.Add(ref p0, 0), ref Unsafe.Add(ref p0, 3));
			sort2_sorting_network_v2(ref Unsafe.Add(ref p0, 2), ref Unsafe.Add(ref p0, 5));
			sort4_sorting_network_v2(ref Unsafe.Add(ref p0, 1), ref Unsafe.Add(ref p0, 2), ref Unsafe.Add(ref p0, 3), ref Unsafe.Add(ref p0, 4));
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void sort4_sorting_network_v2(ref ISortable p0, ref ISortable p1, ref ISortable p2, ref ISortable p3)
		{
			sort2_sorting_network_v2(ref p0, ref p1);
			sort2_sorting_network_v2(ref p2, ref p3);
			sort2_sorting_network_v2(ref p0, ref p2);
			sort2_sorting_network_v2(ref p1, ref p3);
			sort2_sorting_network_v2(ref p1, ref p2);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void sort3_sorting_network_v2(ref ISortable p0, ref ISortable p1, ref ISortable p2)
		{
			sort2_sorting_network_v2(ref p0, ref p1);
			sort2_sorting_network_v2(ref p1, ref p2);
			sort2_sorting_network_v2(ref p0, ref p1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void sort2_sorting_network_v2(ref ISortable p0, ref ISortable p1)
		{
			if (p0.Count < p1.Count)
			{
				ISortable tmp = p0;
				p0 = p1;
				p1 = tmp;
			}
		}
	}
}
