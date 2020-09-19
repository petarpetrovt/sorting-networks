namespace SortingNetworks
{
	using System;
	using System.Runtime.CompilerServices;

	partial class SNBoseNelsonGenerated
	{
		/// <summary>
		/// Sorts a collection of 2 elements in ascending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		public static void Sort2Ascending<T>(ref T p0, Comparison<T> comparison)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);

			SwapIfGreater(ref p0, ref p1, comparison);
		}

		/// <summary>
		/// Sorts a collection of 2 elements in descending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		public static void Sort2Descending<T>(ref T p0, Comparison<T> comparison)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);

			SwapIfLesser(ref p0, ref p1, comparison);
		}

		/// <summary>
		/// Sorts a collection of 3 elements in ascending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		public static void Sort3Ascending<T>(ref T p0, Comparison<T> comparison)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);

			SwapIfGreater(ref p1, ref p2, comparison);
			SwapIfGreater(ref p0, ref p2, comparison);
			SwapIfGreater(ref p0, ref p1, comparison);
		}

		/// <summary>
		/// Sorts a collection of 3 elements in descending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		public static void Sort3Descending<T>(ref T p0, Comparison<T> comparison)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);

			SwapIfLesser(ref p1, ref p2, comparison);
			SwapIfLesser(ref p0, ref p2, comparison);
			SwapIfLesser(ref p0, ref p1, comparison);
		}

		/// <summary>
		/// Sorts a collection of 4 elements in ascending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		public static void Sort4Ascending<T>(ref T p0, Comparison<T> comparison)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);

			SwapIfGreater(ref p0, ref p1, comparison);
			SwapIfGreater(ref p2, ref p3, comparison);
			SwapIfGreater(ref p0, ref p2, comparison);
			SwapIfGreater(ref p1, ref p3, comparison);
			SwapIfGreater(ref p1, ref p2, comparison);
		}

		/// <summary>
		/// Sorts a collection of 4 elements in descending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		public static void Sort4Descending<T>(ref T p0, Comparison<T> comparison)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);

			SwapIfLesser(ref p0, ref p1, comparison);
			SwapIfLesser(ref p2, ref p3, comparison);
			SwapIfLesser(ref p0, ref p2, comparison);
			SwapIfLesser(ref p1, ref p3, comparison);
			SwapIfLesser(ref p1, ref p2, comparison);
		}

		/// <summary>
		/// Sorts a collection of 5 elements in ascending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		public static void Sort5Ascending<T>(ref T p0, Comparison<T> comparison)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);

			SwapIfGreater(ref p0, ref p1, comparison);
			SwapIfGreater(ref p3, ref p4, comparison);
			SwapIfGreater(ref p2, ref p4, comparison);
			SwapIfGreater(ref p2, ref p3, comparison);
			SwapIfGreater(ref p0, ref p3, comparison);
			SwapIfGreater(ref p0, ref p2, comparison);
			SwapIfGreater(ref p1, ref p4, comparison);
			SwapIfGreater(ref p1, ref p3, comparison);
			SwapIfGreater(ref p1, ref p2, comparison);
		}

		/// <summary>
		/// Sorts a collection of 5 elements in descending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		public static void Sort5Descending<T>(ref T p0, Comparison<T> comparison)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);

			SwapIfLesser(ref p0, ref p1, comparison);
			SwapIfLesser(ref p3, ref p4, comparison);
			SwapIfLesser(ref p2, ref p4, comparison);
			SwapIfLesser(ref p2, ref p3, comparison);
			SwapIfLesser(ref p0, ref p3, comparison);
			SwapIfLesser(ref p0, ref p2, comparison);
			SwapIfLesser(ref p1, ref p4, comparison);
			SwapIfLesser(ref p1, ref p3, comparison);
			SwapIfLesser(ref p1, ref p2, comparison);
		}

	}
}