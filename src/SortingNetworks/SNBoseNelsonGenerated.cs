namespace SortingNetworks
{
	using System;
	using System.Diagnostics;
	using System.Runtime.CompilerServices;

	/// <summary>
	/// Sorting networks implementation using Bose-Nelson algorithm.
	/// </summary>
	/// <remarks>
	/// SWAP macros generated from: https://pages.ripco.net/~jgamble/nw.html
	/// </remarks>
	public class SNBoseNelsonGenerated : SNBase
	{
		/// <inheritdoc/>
		public static void Sort2Ascending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);

			SwapIfGreater(ref p0, ref p1);
		}

		/// <inheritdoc/>
		public static void Sort3Ascending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);

			SwapIfGreater(ref p1, ref p2);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p0, ref p1);
		}

		/// <inheritdoc/>
		public static void Sort4Ascending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);

			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p2, ref p3);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p1, ref p3);
			SwapIfGreater(ref p1, ref p2);
		}

	}
}
