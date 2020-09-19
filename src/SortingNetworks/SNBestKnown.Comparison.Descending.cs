namespace SortingNetworks
{
	using System;
	using System.Runtime.CompilerServices;

	partial class SNBestKnown
	{
		/// <summary>
		/// Sorts a collection of 9 elements in descending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		public static new void Sort9Descending<T>(ref T p0, Comparison<T> comparison)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);
			ref var p5 = ref Unsafe.Add(ref p0, 5);
			ref var p6 = ref Unsafe.Add(ref p0, 6);
			ref var p7 = ref Unsafe.Add(ref p0, 7);
			ref var p8 = ref Unsafe.Add(ref p0, 8);

			SwapIfLesser(ref p0, ref p1, comparison);
			SwapIfLesser(ref p3, ref p4, comparison);
			SwapIfLesser(ref p6, ref p7, comparison);
			SwapIfLesser(ref p1, ref p2, comparison);
			SwapIfLesser(ref p4, ref p5, comparison);
			SwapIfLesser(ref p7, ref p8, comparison);
			SwapIfLesser(ref p0, ref p1, comparison);
			SwapIfLesser(ref p3, ref p4, comparison);
			SwapIfLesser(ref p6, ref p7, comparison);
			SwapIfLesser(ref p0, ref p3, comparison);
			SwapIfLesser(ref p3, ref p6, comparison);
			SwapIfLesser(ref p0, ref p3, comparison);
			SwapIfLesser(ref p1, ref p4, comparison);
			SwapIfLesser(ref p4, ref p7, comparison);
			SwapIfLesser(ref p1, ref p4, comparison);
			SwapIfLesser(ref p2, ref p5, comparison);
			SwapIfLesser(ref p5, ref p8, comparison);
			SwapIfLesser(ref p2, ref p5, comparison);
			SwapIfLesser(ref p1, ref p3, comparison);
			SwapIfLesser(ref p5, ref p7, comparison);
			SwapIfLesser(ref p2, ref p6, comparison);
			SwapIfLesser(ref p4, ref p6, comparison);
			SwapIfLesser(ref p2, ref p4, comparison);
			SwapIfLesser(ref p2, ref p3, comparison);
			SwapIfLesser(ref p5, ref p6, comparison);
		}

		/// <summary>
		/// Sorts a collection of 10 elements in descending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		public static new void Sort10Descending<T>(ref T p0, Comparison<T> comparison)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);
			ref var p5 = ref Unsafe.Add(ref p0, 5);
			ref var p6 = ref Unsafe.Add(ref p0, 6);
			ref var p7 = ref Unsafe.Add(ref p0, 7);
			ref var p8 = ref Unsafe.Add(ref p0, 8);
			ref var p9 = ref Unsafe.Add(ref p0, 9);

			SwapIfLesser(ref p4, ref p9, comparison);
			SwapIfLesser(ref p3, ref p8, comparison);
			SwapIfLesser(ref p2, ref p7, comparison);
			SwapIfLesser(ref p1, ref p6, comparison);
			SwapIfLesser(ref p0, ref p5, comparison);
			SwapIfLesser(ref p1, ref p4, comparison);
			SwapIfLesser(ref p6, ref p9, comparison);
			SwapIfLesser(ref p0, ref p3, comparison);
			SwapIfLesser(ref p5, ref p8, comparison);
			SwapIfLesser(ref p0, ref p2, comparison);
			SwapIfLesser(ref p3, ref p6, comparison);
			SwapIfLesser(ref p7, ref p9, comparison);
			SwapIfLesser(ref p0, ref p1, comparison);
			SwapIfLesser(ref p2, ref p4, comparison);
			SwapIfLesser(ref p5, ref p7, comparison);
			SwapIfLesser(ref p8, ref p9, comparison);
			SwapIfLesser(ref p1, ref p2, comparison);
			SwapIfLesser(ref p4, ref p6, comparison);
			SwapIfLesser(ref p7, ref p8, comparison);
			SwapIfLesser(ref p3, ref p5, comparison);
			SwapIfLesser(ref p2, ref p5, comparison);
			SwapIfLesser(ref p6, ref p8, comparison);
			SwapIfLesser(ref p1, ref p3, comparison);
			SwapIfLesser(ref p4, ref p7, comparison);
			SwapIfLesser(ref p2, ref p3, comparison);
			SwapIfLesser(ref p6, ref p7, comparison);
			SwapIfLesser(ref p3, ref p4, comparison);
			SwapIfLesser(ref p5, ref p6, comparison);
			SwapIfLesser(ref p4, ref p5, comparison);
		}

		/// <summary>
		/// Sorts a collection of 11 elements in descending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		public static new void Sort11Descending<T>(ref T p0, Comparison<T> comparison)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);
			ref var p5 = ref Unsafe.Add(ref p0, 5);
			ref var p6 = ref Unsafe.Add(ref p0, 6);
			ref var p7 = ref Unsafe.Add(ref p0, 7);
			ref var p8 = ref Unsafe.Add(ref p0, 8);
			ref var p9 = ref Unsafe.Add(ref p0, 9);
			ref var p10 = ref Unsafe.Add(ref p0, 10);

			SwapIfLesser(ref p0, ref p1, comparison);
			SwapIfLesser(ref p2, ref p3, comparison);
			SwapIfLesser(ref p4, ref p5, comparison);
			SwapIfLesser(ref p6, ref p7, comparison);
			SwapIfLesser(ref p8, ref p9, comparison);
			SwapIfLesser(ref p1, ref p3, comparison);
			SwapIfLesser(ref p5, ref p7, comparison);
			SwapIfLesser(ref p0, ref p2, comparison);
			SwapIfLesser(ref p4, ref p6, comparison);
			SwapIfLesser(ref p8, ref p10, comparison);
			SwapIfLesser(ref p1, ref p2, comparison);
			SwapIfLesser(ref p5, ref p6, comparison);
			SwapIfLesser(ref p9, ref p10, comparison);
			SwapIfLesser(ref p1, ref p5, comparison);
			SwapIfLesser(ref p6, ref p10, comparison);
			SwapIfLesser(ref p5, ref p9, comparison);
			SwapIfLesser(ref p2, ref p6, comparison);
			SwapIfLesser(ref p1, ref p5, comparison);
			SwapIfLesser(ref p6, ref p10, comparison);
			SwapIfLesser(ref p0, ref p4, comparison);
			SwapIfLesser(ref p3, ref p7, comparison);
			SwapIfLesser(ref p4, ref p8, comparison);
			SwapIfLesser(ref p0, ref p4, comparison);
			SwapIfLesser(ref p1, ref p4, comparison);
			SwapIfLesser(ref p7, ref p10, comparison);
			SwapIfLesser(ref p3, ref p8, comparison);
			SwapIfLesser(ref p2, ref p3, comparison);
			SwapIfLesser(ref p8, ref p9, comparison);
			SwapIfLesser(ref p2, ref p4, comparison);
			SwapIfLesser(ref p7, ref p9, comparison);
			SwapIfLesser(ref p3, ref p5, comparison);
			SwapIfLesser(ref p6, ref p8, comparison);
			SwapIfLesser(ref p3, ref p4, comparison);
			SwapIfLesser(ref p5, ref p6, comparison);
			SwapIfLesser(ref p7, ref p8, comparison);
		}

		/// <summary>
		/// Sorts a collection of 12 elements in descending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		public static new void Sort12Descending<T>(ref T p0, Comparison<T> comparison)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);
			ref var p5 = ref Unsafe.Add(ref p0, 5);
			ref var p6 = ref Unsafe.Add(ref p0, 6);
			ref var p7 = ref Unsafe.Add(ref p0, 7);
			ref var p8 = ref Unsafe.Add(ref p0, 8);
			ref var p9 = ref Unsafe.Add(ref p0, 9);
			ref var p10 = ref Unsafe.Add(ref p0, 10);
			ref var p11 = ref Unsafe.Add(ref p0, 11);

			SwapIfLesser(ref p0, ref p1, comparison);
			SwapIfLesser(ref p2, ref p3, comparison);
			SwapIfLesser(ref p4, ref p5, comparison);
			SwapIfLesser(ref p6, ref p7, comparison);
			SwapIfLesser(ref p8, ref p9, comparison);
			SwapIfLesser(ref p10, ref p11, comparison);
			SwapIfLesser(ref p1, ref p3, comparison);
			SwapIfLesser(ref p5, ref p7, comparison);
			SwapIfLesser(ref p9, ref p11, comparison);
			SwapIfLesser(ref p0, ref p2, comparison);
			SwapIfLesser(ref p4, ref p6, comparison);
			SwapIfLesser(ref p8, ref p10, comparison);
			SwapIfLesser(ref p1, ref p2, comparison);
			SwapIfLesser(ref p5, ref p6, comparison);
			SwapIfLesser(ref p9, ref p10, comparison);
			SwapIfLesser(ref p1, ref p5, comparison);
			SwapIfLesser(ref p6, ref p10, comparison);
			SwapIfLesser(ref p5, ref p9, comparison);
			SwapIfLesser(ref p2, ref p6, comparison);
			SwapIfLesser(ref p1, ref p5, comparison);
			SwapIfLesser(ref p6, ref p10, comparison);
			SwapIfLesser(ref p0, ref p4, comparison);
			SwapIfLesser(ref p7, ref p11, comparison);
			SwapIfLesser(ref p3, ref p7, comparison);
			SwapIfLesser(ref p4, ref p8, comparison);
			SwapIfLesser(ref p0, ref p4, comparison);
			SwapIfLesser(ref p7, ref p11, comparison);
			SwapIfLesser(ref p1, ref p4, comparison);
			SwapIfLesser(ref p7, ref p10, comparison);
			SwapIfLesser(ref p3, ref p8, comparison);
			SwapIfLesser(ref p2, ref p3, comparison);
			SwapIfLesser(ref p8, ref p9, comparison);
			SwapIfLesser(ref p2, ref p4, comparison);
			SwapIfLesser(ref p7, ref p9, comparison);
			SwapIfLesser(ref p3, ref p5, comparison);
			SwapIfLesser(ref p6, ref p8, comparison);
			SwapIfLesser(ref p3, ref p4, comparison);
			SwapIfLesser(ref p5, ref p6, comparison);
			SwapIfLesser(ref p7, ref p8, comparison);
		}

		/// <summary>
		/// Sorts a collection of 13 elements in descending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		public static new void Sort13Descending<T>(ref T p0, Comparison<T> comparison)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);
			ref var p5 = ref Unsafe.Add(ref p0, 5);
			ref var p6 = ref Unsafe.Add(ref p0, 6);
			ref var p7 = ref Unsafe.Add(ref p0, 7);
			ref var p8 = ref Unsafe.Add(ref p0, 8);
			ref var p9 = ref Unsafe.Add(ref p0, 9);
			ref var p10 = ref Unsafe.Add(ref p0, 10);
			ref var p11 = ref Unsafe.Add(ref p0, 11);
			ref var p12 = ref Unsafe.Add(ref p0, 12);

			SwapIfLesser(ref p1, ref p7, comparison);
			SwapIfLesser(ref p9, ref p11, comparison);
			SwapIfLesser(ref p3, ref p4, comparison);
			SwapIfLesser(ref p5, ref p8, comparison);
			SwapIfLesser(ref p0, ref p12, comparison);
			SwapIfLesser(ref p2, ref p6, comparison);
			SwapIfLesser(ref p0, ref p1, comparison);
			SwapIfLesser(ref p2, ref p3, comparison);
			SwapIfLesser(ref p4, ref p6, comparison);
			SwapIfLesser(ref p8, ref p11, comparison);
			SwapIfLesser(ref p7, ref p12, comparison);
			SwapIfLesser(ref p5, ref p9, comparison);
			SwapIfLesser(ref p0, ref p2, comparison);
			SwapIfLesser(ref p3, ref p7, comparison);
			SwapIfLesser(ref p10, ref p11, comparison);
			SwapIfLesser(ref p1, ref p4, comparison);
			SwapIfLesser(ref p6, ref p12, comparison);
			SwapIfLesser(ref p7, ref p8, comparison);
			SwapIfLesser(ref p11, ref p12, comparison);
			SwapIfLesser(ref p4, ref p9, comparison);
			SwapIfLesser(ref p6, ref p10, comparison);
			SwapIfLesser(ref p3, ref p4, comparison);
			SwapIfLesser(ref p5, ref p6, comparison);
			SwapIfLesser(ref p8, ref p9, comparison);
			SwapIfLesser(ref p10, ref p11, comparison);
			SwapIfLesser(ref p1, ref p7, comparison);
			SwapIfLesser(ref p2, ref p6, comparison);
			SwapIfLesser(ref p9, ref p11, comparison);
			SwapIfLesser(ref p1, ref p3, comparison);
			SwapIfLesser(ref p4, ref p7, comparison);
			SwapIfLesser(ref p8, ref p10, comparison);
			SwapIfLesser(ref p0, ref p5, comparison);
			SwapIfLesser(ref p2, ref p5, comparison);
			SwapIfLesser(ref p6, ref p8, comparison);
			SwapIfLesser(ref p9, ref p10, comparison);
			SwapIfLesser(ref p1, ref p2, comparison);
			SwapIfLesser(ref p3, ref p5, comparison);
			SwapIfLesser(ref p7, ref p8, comparison);
			SwapIfLesser(ref p4, ref p6, comparison);
			SwapIfLesser(ref p2, ref p3, comparison);
			SwapIfLesser(ref p4, ref p5, comparison);
			SwapIfLesser(ref p6, ref p7, comparison);
			SwapIfLesser(ref p8, ref p9, comparison);
			SwapIfLesser(ref p3, ref p4, comparison);
			SwapIfLesser(ref p5, ref p6, comparison);
		}

		/// <summary>
		/// Sorts a collection of 14 elements in descending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		public static new void Sort14Descending<T>(ref T p0, Comparison<T> comparison)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);
			ref var p5 = ref Unsafe.Add(ref p0, 5);
			ref var p6 = ref Unsafe.Add(ref p0, 6);
			ref var p7 = ref Unsafe.Add(ref p0, 7);
			ref var p8 = ref Unsafe.Add(ref p0, 8);
			ref var p9 = ref Unsafe.Add(ref p0, 9);
			ref var p10 = ref Unsafe.Add(ref p0, 10);
			ref var p11 = ref Unsafe.Add(ref p0, 11);
			ref var p12 = ref Unsafe.Add(ref p0, 12);
			ref var p13 = ref Unsafe.Add(ref p0, 13);

			SwapIfLesser(ref p0, ref p1, comparison);
			SwapIfLesser(ref p2, ref p3, comparison);
			SwapIfLesser(ref p4, ref p5, comparison);
			SwapIfLesser(ref p6, ref p7, comparison);
			SwapIfLesser(ref p8, ref p9, comparison);
			SwapIfLesser(ref p10, ref p11, comparison);
			SwapIfLesser(ref p12, ref p13, comparison);
			SwapIfLesser(ref p0, ref p2, comparison);
			SwapIfLesser(ref p4, ref p6, comparison);
			SwapIfLesser(ref p8, ref p10, comparison);
			SwapIfLesser(ref p1, ref p3, comparison);
			SwapIfLesser(ref p5, ref p7, comparison);
			SwapIfLesser(ref p9, ref p11, comparison);
			SwapIfLesser(ref p0, ref p4, comparison);
			SwapIfLesser(ref p8, ref p12, comparison);
			SwapIfLesser(ref p1, ref p5, comparison);
			SwapIfLesser(ref p9, ref p13, comparison);
			SwapIfLesser(ref p2, ref p6, comparison);
			SwapIfLesser(ref p3, ref p7, comparison);
			SwapIfLesser(ref p0, ref p8, comparison);
			SwapIfLesser(ref p1, ref p9, comparison);
			SwapIfLesser(ref p2, ref p10, comparison);
			SwapIfLesser(ref p3, ref p11, comparison);
			SwapIfLesser(ref p4, ref p12, comparison);
			SwapIfLesser(ref p5, ref p13, comparison);
			SwapIfLesser(ref p5, ref p10, comparison);
			SwapIfLesser(ref p6, ref p9, comparison);
			SwapIfLesser(ref p3, ref p12, comparison);
			SwapIfLesser(ref p7, ref p11, comparison);
			SwapIfLesser(ref p1, ref p2, comparison);
			SwapIfLesser(ref p4, ref p8, comparison);
			SwapIfLesser(ref p1, ref p4, comparison);
			SwapIfLesser(ref p7, ref p13, comparison);
			SwapIfLesser(ref p2, ref p8, comparison);
			SwapIfLesser(ref p2, ref p4, comparison);
			SwapIfLesser(ref p5, ref p6, comparison);
			SwapIfLesser(ref p9, ref p10, comparison);
			SwapIfLesser(ref p11, ref p13, comparison);
			SwapIfLesser(ref p3, ref p8, comparison);
			SwapIfLesser(ref p7, ref p12, comparison);
			SwapIfLesser(ref p6, ref p8, comparison);
			SwapIfLesser(ref p10, ref p12, comparison);
			SwapIfLesser(ref p3, ref p5, comparison);
			SwapIfLesser(ref p7, ref p9, comparison);
			SwapIfLesser(ref p3, ref p4, comparison);
			SwapIfLesser(ref p5, ref p6, comparison);
			SwapIfLesser(ref p7, ref p8, comparison);
			SwapIfLesser(ref p9, ref p10, comparison);
			SwapIfLesser(ref p11, ref p12, comparison);
			SwapIfLesser(ref p6, ref p7, comparison);
			SwapIfLesser(ref p8, ref p9, comparison);
		}

		/// <summary>
		/// Sorts a collection of 15 in descending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		public static new void Sort15Descending<T>(ref T p0, Comparison<T> comparison)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);
			ref var p5 = ref Unsafe.Add(ref p0, 5);
			ref var p6 = ref Unsafe.Add(ref p0, 6);
			ref var p7 = ref Unsafe.Add(ref p0, 7);
			ref var p8 = ref Unsafe.Add(ref p0, 8);
			ref var p9 = ref Unsafe.Add(ref p0, 9);
			ref var p10 = ref Unsafe.Add(ref p0, 10);
			ref var p11 = ref Unsafe.Add(ref p0, 11);
			ref var p12 = ref Unsafe.Add(ref p0, 12);
			ref var p13 = ref Unsafe.Add(ref p0, 13);
			ref var p14 = ref Unsafe.Add(ref p0, 14);

			SwapIfLesser(ref p0, ref p1, comparison);
			SwapIfLesser(ref p2, ref p3, comparison);
			SwapIfLesser(ref p4, ref p5, comparison);
			SwapIfLesser(ref p6, ref p7, comparison);
			SwapIfLesser(ref p8, ref p9, comparison);
			SwapIfLesser(ref p10, ref p11, comparison);
			SwapIfLesser(ref p12, ref p13, comparison);
			SwapIfLesser(ref p0, ref p2, comparison);
			SwapIfLesser(ref p4, ref p6, comparison);
			SwapIfLesser(ref p8, ref p10, comparison);
			SwapIfLesser(ref p12, ref p14, comparison);
			SwapIfLesser(ref p1, ref p3, comparison);
			SwapIfLesser(ref p5, ref p7, comparison);
			SwapIfLesser(ref p9, ref p11, comparison);
			SwapIfLesser(ref p0, ref p4, comparison);
			SwapIfLesser(ref p8, ref p12, comparison);
			SwapIfLesser(ref p1, ref p5, comparison);
			SwapIfLesser(ref p9, ref p13, comparison);
			SwapIfLesser(ref p2, ref p6, comparison);
			SwapIfLesser(ref p10, ref p14, comparison);
			SwapIfLesser(ref p3, ref p7, comparison);
			SwapIfLesser(ref p0, ref p8, comparison);
			SwapIfLesser(ref p1, ref p9, comparison);
			SwapIfLesser(ref p2, ref p10, comparison);
			SwapIfLesser(ref p3, ref p11, comparison);
			SwapIfLesser(ref p4, ref p12, comparison);
			SwapIfLesser(ref p5, ref p13, comparison);
			SwapIfLesser(ref p6, ref p14, comparison);
			SwapIfLesser(ref p5, ref p10, comparison);
			SwapIfLesser(ref p6, ref p9, comparison);
			SwapIfLesser(ref p3, ref p12, comparison);
			SwapIfLesser(ref p13, ref p14, comparison);
			SwapIfLesser(ref p7, ref p11, comparison);
			SwapIfLesser(ref p1, ref p2, comparison);
			SwapIfLesser(ref p4, ref p8, comparison);
			SwapIfLesser(ref p1, ref p4, comparison);
			SwapIfLesser(ref p7, ref p13, comparison);
			SwapIfLesser(ref p2, ref p8, comparison);
			SwapIfLesser(ref p11, ref p14, comparison);
			SwapIfLesser(ref p2, ref p4, comparison);
			SwapIfLesser(ref p5, ref p6, comparison);
			SwapIfLesser(ref p9, ref p10, comparison);
			SwapIfLesser(ref p11, ref p13, comparison);
			SwapIfLesser(ref p3, ref p8, comparison);
			SwapIfLesser(ref p7, ref p12, comparison);
			SwapIfLesser(ref p6, ref p8, comparison);
			SwapIfLesser(ref p10, ref p12, comparison);
			SwapIfLesser(ref p3, ref p5, comparison);
			SwapIfLesser(ref p7, ref p9, comparison);
			SwapIfLesser(ref p3, ref p4, comparison);
			SwapIfLesser(ref p5, ref p6, comparison);
			SwapIfLesser(ref p7, ref p8, comparison);
			SwapIfLesser(ref p9, ref p10, comparison);
			SwapIfLesser(ref p11, ref p12, comparison);
			SwapIfLesser(ref p6, ref p7, comparison);
			SwapIfLesser(ref p8, ref p9, comparison);
		}

		/// <summary>
		/// Sorts a collection of 16 elements in descending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		public static new void Sort16Descending<T>(ref T p0, Comparison<T> comparison)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);
			ref var p5 = ref Unsafe.Add(ref p0, 5);
			ref var p6 = ref Unsafe.Add(ref p0, 6);
			ref var p7 = ref Unsafe.Add(ref p0, 7);
			ref var p8 = ref Unsafe.Add(ref p0, 8);
			ref var p9 = ref Unsafe.Add(ref p0, 9);
			ref var p10 = ref Unsafe.Add(ref p0, 10);
			ref var p11 = ref Unsafe.Add(ref p0, 11);
			ref var p12 = ref Unsafe.Add(ref p0, 12);
			ref var p13 = ref Unsafe.Add(ref p0, 13);
			ref var p14 = ref Unsafe.Add(ref p0, 14);
			ref var p15 = ref Unsafe.Add(ref p0, 15);

			SwapIfLesser(ref p0, ref p1, comparison);
			SwapIfLesser(ref p2, ref p3, comparison);
			SwapIfLesser(ref p4, ref p5, comparison);
			SwapIfLesser(ref p6, ref p7, comparison);
			SwapIfLesser(ref p8, ref p9, comparison);
			SwapIfLesser(ref p10, ref p11, comparison);
			SwapIfLesser(ref p12, ref p13, comparison);
			SwapIfLesser(ref p14, ref p15, comparison);
			SwapIfLesser(ref p0, ref p2, comparison);
			SwapIfLesser(ref p4, ref p6, comparison);
			SwapIfLesser(ref p8, ref p10, comparison);
			SwapIfLesser(ref p12, ref p14, comparison);
			SwapIfLesser(ref p1, ref p3, comparison);
			SwapIfLesser(ref p5, ref p7, comparison);
			SwapIfLesser(ref p9, ref p11, comparison);
			SwapIfLesser(ref p13, ref p15, comparison);
			SwapIfLesser(ref p0, ref p4, comparison);
			SwapIfLesser(ref p8, ref p12, comparison);
			SwapIfLesser(ref p1, ref p5, comparison);
			SwapIfLesser(ref p9, ref p13, comparison);
			SwapIfLesser(ref p2, ref p6, comparison);
			SwapIfLesser(ref p10, ref p14, comparison);
			SwapIfLesser(ref p3, ref p7, comparison);
			SwapIfLesser(ref p11, ref p15, comparison);
			SwapIfLesser(ref p0, ref p8, comparison);
			SwapIfLesser(ref p1, ref p9, comparison);
			SwapIfLesser(ref p2, ref p10, comparison);
			SwapIfLesser(ref p3, ref p11, comparison);
			SwapIfLesser(ref p4, ref p12, comparison);
			SwapIfLesser(ref p5, ref p13, comparison);
			SwapIfLesser(ref p6, ref p14, comparison);
			SwapIfLesser(ref p7, ref p15, comparison);
			SwapIfLesser(ref p5, ref p10, comparison);
			SwapIfLesser(ref p6, ref p9, comparison);
			SwapIfLesser(ref p3, ref p12, comparison);
			SwapIfLesser(ref p13, ref p14, comparison);
			SwapIfLesser(ref p7, ref p11, comparison);
			SwapIfLesser(ref p1, ref p2, comparison);
			SwapIfLesser(ref p4, ref p8, comparison);
			SwapIfLesser(ref p1, ref p4, comparison);
			SwapIfLesser(ref p7, ref p13, comparison);
			SwapIfLesser(ref p2, ref p8, comparison);
			SwapIfLesser(ref p11, ref p14, comparison);
			SwapIfLesser(ref p2, ref p4, comparison);
			SwapIfLesser(ref p5, ref p6, comparison);
			SwapIfLesser(ref p9, ref p10, comparison);
			SwapIfLesser(ref p11, ref p13, comparison);
			SwapIfLesser(ref p3, ref p8, comparison);
			SwapIfLesser(ref p7, ref p12, comparison);
			SwapIfLesser(ref p6, ref p8, comparison);
			SwapIfLesser(ref p10, ref p12, comparison);
			SwapIfLesser(ref p3, ref p5, comparison);
			SwapIfLesser(ref p7, ref p9, comparison);
			SwapIfLesser(ref p3, ref p4, comparison);
			SwapIfLesser(ref p5, ref p6, comparison);
			SwapIfLesser(ref p7, ref p8, comparison);
			SwapIfLesser(ref p9, ref p10, comparison);
			SwapIfLesser(ref p11, ref p12, comparison);
			SwapIfLesser(ref p6, ref p7, comparison);
			SwapIfLesser(ref p8, ref p9, comparison);
		}

		/// <summary>
		/// Sorts a collection of specified number of elements in descending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="length">the length of the collection</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		/// <exception cref="ArgumentNullException">comparison is null</exception>
		/// <exception cref="ArgumentOutOfRangeException">collection length is not between <see cref="MinLength"/> and <see cref="MaxLength"/></exception>
		public static new void SortDescending<T>(ref T p0, in int length, Comparison<T> comparison)
		{
			if (comparison is null)
			{
				throw new ArgumentNullException(nameof(comparison));
			}

			switch (length)
			{
				case 2: Sort2Descending(ref p0, comparison); break;
				case 3: Sort3Descending(ref p0, comparison); break;
				case 4: Sort4Descending(ref p0, comparison); break;
				case 5: Sort5Descending(ref p0, comparison); break;
				case 6: Sort6Descending(ref p0, comparison); break;
				case 7: Sort7Descending(ref p0, comparison); break;
				case 8: Sort8Descending(ref p0, comparison); break;
				case 9: Sort9Descending(ref p0, comparison); break;
				case 10: Sort10Descending(ref p0, comparison); break;
				case 11: Sort11Descending(ref p0, comparison); break;
				case 12: Sort12Descending(ref p0, comparison); break;
				case 13: Sort13Descending(ref p0, comparison); break;
				case 14: Sort14Descending(ref p0, comparison); break;
				case 15: Sort15Descending(ref p0, comparison); break;
				case 16: Sort16Descending(ref p0, comparison); break;
				case 17: Sort17Descending(ref p0, comparison); break;
				case 18: Sort18Descending(ref p0, comparison); break;
				case 19: Sort19Descending(ref p0, comparison); break;
				case 20: Sort20Descending(ref p0, comparison); break;
				case 21: Sort21Descending(ref p0, comparison); break;
				case 22: Sort22Descending(ref p0, comparison); break;
				case 23: Sort23Descending(ref p0, comparison); break;
				case 24: Sort24Descending(ref p0, comparison); break;
				case 25: Sort25Descending(ref p0, comparison); break;
				case 26: Sort26Descending(ref p0, comparison); break;
				case 27: Sort27Descending(ref p0, comparison); break;
				case 28: Sort28Descending(ref p0, comparison); break;
				case 29: Sort29Descending(ref p0, comparison); break;
				case 30: Sort30Descending(ref p0, comparison); break;
				case 31: Sort31Descending(ref p0, comparison); break;
				case 32: Sort32Descending(ref p0, comparison); break;
				default: throw new ArgumentOutOfRangeException(nameof(length), $"Sorting network length `{length}` must be between `{MinLength}` and `{MaxLength}`.");
			}
		}
	}
}