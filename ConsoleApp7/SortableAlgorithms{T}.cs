using System;
using System.Runtime.CompilerServices;

namespace ConsoleApp7
{
	public static class SortableAlgorithms<T>
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void sort6_sorting_network_v1(ref T p0, Comparison<T> comparison)
		{
			sort2_sorting_network_v2(ref Unsafe.Add(ref p0, 1), ref Unsafe.Add(ref p0, 2), comparison);
			sort2_sorting_network_v2(ref Unsafe.Add(ref p0, 0), ref Unsafe.Add(ref p0, 2), comparison);
			sort2_sorting_network_v2(ref Unsafe.Add(ref p0, 0), ref Unsafe.Add(ref p0, 1), comparison);
			sort2_sorting_network_v2(ref Unsafe.Add(ref p0, 4), ref Unsafe.Add(ref p0, 5), comparison);
			sort2_sorting_network_v2(ref Unsafe.Add(ref p0, 3), ref Unsafe.Add(ref p0, 5), comparison);
			sort2_sorting_network_v2(ref Unsafe.Add(ref p0, 3), ref Unsafe.Add(ref p0, 4), comparison);
			sort2_sorting_network_v2(ref Unsafe.Add(ref p0, 0), ref Unsafe.Add(ref p0, 3), comparison);
			sort2_sorting_network_v2(ref Unsafe.Add(ref p0, 1), ref Unsafe.Add(ref p0, 4), comparison);
			sort2_sorting_network_v2(ref Unsafe.Add(ref p0, 2), ref Unsafe.Add(ref p0, 5), comparison);
			sort2_sorting_network_v2(ref Unsafe.Add(ref p0, 2), ref Unsafe.Add(ref p0, 4), comparison);
			sort2_sorting_network_v2(ref Unsafe.Add(ref p0, 1), ref Unsafe.Add(ref p0, 3), comparison);
			sort2_sorting_network_v2(ref Unsafe.Add(ref p0, 2), ref Unsafe.Add(ref p0, 3), comparison);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void sort6_sorting_network_v2(ref T p0, Comparison<T> comparison)
		{
			sort3_sorting_network_v2(ref Unsafe.Add(ref p0, 0), ref Unsafe.Add(ref p0, 1), ref Unsafe.Add(ref p0, 2), comparison);
			sort3_sorting_network_v2(ref Unsafe.Add(ref p0, 3), ref Unsafe.Add(ref p0, 4), ref Unsafe.Add(ref p0, 5), comparison);
			sort2_sorting_network_v2(ref Unsafe.Add(ref p0, 0), ref Unsafe.Add(ref p0, 3), comparison);
			sort2_sorting_network_v2(ref Unsafe.Add(ref p0, 2), ref Unsafe.Add(ref p0, 5), comparison);
			sort4_sorting_network_v2(ref Unsafe.Add(ref p0, 1), ref Unsafe.Add(ref p0, 2), ref Unsafe.Add(ref p0, 3), ref Unsafe.Add(ref p0, 4), comparison);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void sort4_sorting_network_v2(ref T p0, ref T p1, ref T p2, ref T p3, Comparison<T> comparison)
		{
			sort2_sorting_network_v2(ref p0, ref p1, comparison);
			sort2_sorting_network_v2(ref p2, ref p3, comparison);
			sort2_sorting_network_v2(ref p0, ref p2, comparison);
			sort2_sorting_network_v2(ref p1, ref p3, comparison);
			sort2_sorting_network_v2(ref p1, ref p2, comparison);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void sort3_sorting_network_v2(ref T p0, ref T p1, ref T p2, Comparison<T> comparison)
		{
			sort2_sorting_network_v2(ref p0, ref p1, comparison);
			sort2_sorting_network_v2(ref p1, ref p2, comparison);
			sort2_sorting_network_v2(ref p0, ref p1, comparison);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void sort2_sorting_network_v2(ref T p0, ref T p1, Comparison<T> comparison)
		{
			if (comparison.Invoke(p0, p1) < 0)
			{
				T tmp = p0;
				p0 = p1;
				p1 = tmp;
			}
		}
	}
}
