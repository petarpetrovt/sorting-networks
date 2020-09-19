namespace SortingNetworks
{
	using System;
	using System.Runtime.CompilerServices;

	partial class SNBestKnown
	{
		/// <summary>
		/// Sorts a collection of 9 elements in ascending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static new void Sort9Ascending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);
			ref var p5 = ref Unsafe.Add(ref p0, 5);
			ref var p6 = ref Unsafe.Add(ref p0, 6);
			ref var p7 = ref Unsafe.Add(ref p0, 7);
			ref var p8 = ref Unsafe.Add(ref p0, 8);

			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p3, ref p4);
			SwapIfGreater(ref p6, ref p7);
			SwapIfGreater(ref p1, ref p2);
			SwapIfGreater(ref p4, ref p5);
			SwapIfGreater(ref p7, ref p8);
			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p3, ref p4);
			SwapIfGreater(ref p6, ref p7);
			SwapIfGreater(ref p0, ref p3);
			SwapIfGreater(ref p3, ref p6);
			SwapIfGreater(ref p0, ref p3);
			SwapIfGreater(ref p1, ref p4);
			SwapIfGreater(ref p4, ref p7);
			SwapIfGreater(ref p1, ref p4);
			SwapIfGreater(ref p2, ref p5);
			SwapIfGreater(ref p5, ref p8);
			SwapIfGreater(ref p2, ref p5);
			SwapIfGreater(ref p1, ref p3);
			SwapIfGreater(ref p5, ref p7);
			SwapIfGreater(ref p2, ref p6);
			SwapIfGreater(ref p4, ref p6);
			SwapIfGreater(ref p2, ref p4);
			SwapIfGreater(ref p2, ref p3);
			SwapIfGreater(ref p5, ref p6);
		}

		/// <summary>
		/// Sorts a collection of 10 elements in ascending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static new void Sort10Ascending<T>(ref T p0)
			where T : IComparable<T>
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

			SwapIfGreater(ref p4, ref p9);
			SwapIfGreater(ref p3, ref p8);
			SwapIfGreater(ref p2, ref p7);
			SwapIfGreater(ref p1, ref p6);
			SwapIfGreater(ref p0, ref p5);
			SwapIfGreater(ref p1, ref p4);
			SwapIfGreater(ref p6, ref p9);
			SwapIfGreater(ref p0, ref p3);
			SwapIfGreater(ref p5, ref p8);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p3, ref p6);
			SwapIfGreater(ref p7, ref p9);
			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p2, ref p4);
			SwapIfGreater(ref p5, ref p7);
			SwapIfGreater(ref p8, ref p9);
			SwapIfGreater(ref p1, ref p2);
			SwapIfGreater(ref p4, ref p6);
			SwapIfGreater(ref p7, ref p8);
			SwapIfGreater(ref p3, ref p5);
			SwapIfGreater(ref p2, ref p5);
			SwapIfGreater(ref p6, ref p8);
			SwapIfGreater(ref p1, ref p3);
			SwapIfGreater(ref p4, ref p7);
			SwapIfGreater(ref p2, ref p3);
			SwapIfGreater(ref p6, ref p7);
			SwapIfGreater(ref p3, ref p4);
			SwapIfGreater(ref p5, ref p6);
			SwapIfGreater(ref p4, ref p5);
		}

		/// <summary>
		/// Sorts a collection of 11 elements in ascending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static new void Sort11Ascending<T>(ref T p0)
			where T : IComparable<T>
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

			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p2, ref p3);
			SwapIfGreater(ref p4, ref p5);
			SwapIfGreater(ref p6, ref p7);
			SwapIfGreater(ref p8, ref p9);
			SwapIfGreater(ref p1, ref p3);
			SwapIfGreater(ref p5, ref p7);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p4, ref p6);
			SwapIfGreater(ref p8, ref p10);
			SwapIfGreater(ref p1, ref p2);
			SwapIfGreater(ref p5, ref p6);
			SwapIfGreater(ref p9, ref p10);
			SwapIfGreater(ref p1, ref p5);
			SwapIfGreater(ref p6, ref p10);
			SwapIfGreater(ref p5, ref p9);
			SwapIfGreater(ref p2, ref p6);
			SwapIfGreater(ref p1, ref p5);
			SwapIfGreater(ref p6, ref p10);
			SwapIfGreater(ref p0, ref p4);
			SwapIfGreater(ref p3, ref p7);
			SwapIfGreater(ref p4, ref p8);
			SwapIfGreater(ref p0, ref p4);
			SwapIfGreater(ref p1, ref p4);
			SwapIfGreater(ref p7, ref p10);
			SwapIfGreater(ref p3, ref p8);
			SwapIfGreater(ref p2, ref p3);
			SwapIfGreater(ref p8, ref p9);
			SwapIfGreater(ref p2, ref p4);
			SwapIfGreater(ref p7, ref p9);
			SwapIfGreater(ref p3, ref p5);
			SwapIfGreater(ref p6, ref p8);
			SwapIfGreater(ref p3, ref p4);
			SwapIfGreater(ref p5, ref p6);
			SwapIfGreater(ref p7, ref p8);
		}

		/// <summary>
		/// Sorts a collection of 12 elements in ascending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static new void Sort12Ascending<T>(ref T p0)
			where T : IComparable<T>
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

			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p2, ref p3);
			SwapIfGreater(ref p4, ref p5);
			SwapIfGreater(ref p6, ref p7);
			SwapIfGreater(ref p8, ref p9);
			SwapIfGreater(ref p10, ref p11);
			SwapIfGreater(ref p1, ref p3);
			SwapIfGreater(ref p5, ref p7);
			SwapIfGreater(ref p9, ref p11);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p4, ref p6);
			SwapIfGreater(ref p8, ref p10);
			SwapIfGreater(ref p1, ref p2);
			SwapIfGreater(ref p5, ref p6);
			SwapIfGreater(ref p9, ref p10);
			SwapIfGreater(ref p1, ref p5);
			SwapIfGreater(ref p6, ref p10);
			SwapIfGreater(ref p5, ref p9);
			SwapIfGreater(ref p2, ref p6);
			SwapIfGreater(ref p1, ref p5);
			SwapIfGreater(ref p6, ref p10);
			SwapIfGreater(ref p0, ref p4);
			SwapIfGreater(ref p7, ref p11);
			SwapIfGreater(ref p3, ref p7);
			SwapIfGreater(ref p4, ref p8);
			SwapIfGreater(ref p0, ref p4);
			SwapIfGreater(ref p7, ref p11);
			SwapIfGreater(ref p1, ref p4);
			SwapIfGreater(ref p7, ref p10);
			SwapIfGreater(ref p3, ref p8);
			SwapIfGreater(ref p2, ref p3);
			SwapIfGreater(ref p8, ref p9);
			SwapIfGreater(ref p2, ref p4);
			SwapIfGreater(ref p7, ref p9);
			SwapIfGreater(ref p3, ref p5);
			SwapIfGreater(ref p6, ref p8);
			SwapIfGreater(ref p3, ref p4);
			SwapIfGreater(ref p5, ref p6);
			SwapIfGreater(ref p7, ref p8);
		}

		/// <summary>
		/// Sorts a collection of 13 elements in ascending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static new void Sort13Ascending<T>(ref T p0)
			where T : IComparable<T>
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

			SwapIfGreater(ref p1, ref p7);
			SwapIfGreater(ref p9, ref p11);
			SwapIfGreater(ref p3, ref p4);
			SwapIfGreater(ref p5, ref p8);
			SwapIfGreater(ref p0, ref p12);
			SwapIfGreater(ref p2, ref p6);
			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p2, ref p3);
			SwapIfGreater(ref p4, ref p6);
			SwapIfGreater(ref p8, ref p11);
			SwapIfGreater(ref p7, ref p12);
			SwapIfGreater(ref p5, ref p9);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p3, ref p7);
			SwapIfGreater(ref p10, ref p11);
			SwapIfGreater(ref p1, ref p4);
			SwapIfGreater(ref p6, ref p12);
			SwapIfGreater(ref p7, ref p8);
			SwapIfGreater(ref p11, ref p12);
			SwapIfGreater(ref p4, ref p9);
			SwapIfGreater(ref p6, ref p10);
			SwapIfGreater(ref p3, ref p4);
			SwapIfGreater(ref p5, ref p6);
			SwapIfGreater(ref p8, ref p9);
			SwapIfGreater(ref p10, ref p11);
			SwapIfGreater(ref p1, ref p7);
			SwapIfGreater(ref p2, ref p6);
			SwapIfGreater(ref p9, ref p11);
			SwapIfGreater(ref p1, ref p3);
			SwapIfGreater(ref p4, ref p7);
			SwapIfGreater(ref p8, ref p10);
			SwapIfGreater(ref p0, ref p5);
			SwapIfGreater(ref p2, ref p5);
			SwapIfGreater(ref p6, ref p8);
			SwapIfGreater(ref p9, ref p10);
			SwapIfGreater(ref p1, ref p2);
			SwapIfGreater(ref p3, ref p5);
			SwapIfGreater(ref p7, ref p8);
			SwapIfGreater(ref p4, ref p6);
			SwapIfGreater(ref p2, ref p3);
			SwapIfGreater(ref p4, ref p5);
			SwapIfGreater(ref p6, ref p7);
			SwapIfGreater(ref p8, ref p9);
			SwapIfGreater(ref p3, ref p4);
			SwapIfGreater(ref p5, ref p6);
		}

		/// <summary>
		/// Sorts a collection of 14 elements in ascending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static new void Sort14Ascending<T>(ref T p0)
			where T : IComparable<T>
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

			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p2, ref p3);
			SwapIfGreater(ref p4, ref p5);
			SwapIfGreater(ref p6, ref p7);
			SwapIfGreater(ref p8, ref p9);
			SwapIfGreater(ref p10, ref p11);
			SwapIfGreater(ref p12, ref p13);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p4, ref p6);
			SwapIfGreater(ref p8, ref p10);
			SwapIfGreater(ref p1, ref p3);
			SwapIfGreater(ref p5, ref p7);
			SwapIfGreater(ref p9, ref p11);
			SwapIfGreater(ref p0, ref p4);
			SwapIfGreater(ref p8, ref p12);
			SwapIfGreater(ref p1, ref p5);
			SwapIfGreater(ref p9, ref p13);
			SwapIfGreater(ref p2, ref p6);
			SwapIfGreater(ref p3, ref p7);
			SwapIfGreater(ref p0, ref p8);
			SwapIfGreater(ref p1, ref p9);
			SwapIfGreater(ref p2, ref p10);
			SwapIfGreater(ref p3, ref p11);
			SwapIfGreater(ref p4, ref p12);
			SwapIfGreater(ref p5, ref p13);
			SwapIfGreater(ref p5, ref p10);
			SwapIfGreater(ref p6, ref p9);
			SwapIfGreater(ref p3, ref p12);
			SwapIfGreater(ref p7, ref p11);
			SwapIfGreater(ref p1, ref p2);
			SwapIfGreater(ref p4, ref p8);
			SwapIfGreater(ref p1, ref p4);
			SwapIfGreater(ref p7, ref p13);
			SwapIfGreater(ref p2, ref p8);
			SwapIfGreater(ref p2, ref p4);
			SwapIfGreater(ref p5, ref p6);
			SwapIfGreater(ref p9, ref p10);
			SwapIfGreater(ref p11, ref p13);
			SwapIfGreater(ref p3, ref p8);
			SwapIfGreater(ref p7, ref p12);
			SwapIfGreater(ref p6, ref p8);
			SwapIfGreater(ref p10, ref p12);
			SwapIfGreater(ref p3, ref p5);
			SwapIfGreater(ref p7, ref p9);
			SwapIfGreater(ref p3, ref p4);
			SwapIfGreater(ref p5, ref p6);
			SwapIfGreater(ref p7, ref p8);
			SwapIfGreater(ref p9, ref p10);
			SwapIfGreater(ref p11, ref p12);
			SwapIfGreater(ref p6, ref p7);
			SwapIfGreater(ref p8, ref p9);
		}

		/// <summary>
		/// Sorts a collection of 15 elements in ascending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static new void Sort15Ascending<T>(ref T p0)
			where T : IComparable<T>
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

			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p2, ref p3);
			SwapIfGreater(ref p4, ref p5);
			SwapIfGreater(ref p6, ref p7);
			SwapIfGreater(ref p8, ref p9);
			SwapIfGreater(ref p10, ref p11);
			SwapIfGreater(ref p12, ref p13);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p4, ref p6);
			SwapIfGreater(ref p8, ref p10);
			SwapIfGreater(ref p12, ref p14);
			SwapIfGreater(ref p1, ref p3);
			SwapIfGreater(ref p5, ref p7);
			SwapIfGreater(ref p9, ref p11);
			SwapIfGreater(ref p0, ref p4);
			SwapIfGreater(ref p8, ref p12);
			SwapIfGreater(ref p1, ref p5);
			SwapIfGreater(ref p9, ref p13);
			SwapIfGreater(ref p2, ref p6);
			SwapIfGreater(ref p10, ref p14);
			SwapIfGreater(ref p3, ref p7);
			SwapIfGreater(ref p0, ref p8);
			SwapIfGreater(ref p1, ref p9);
			SwapIfGreater(ref p2, ref p10);
			SwapIfGreater(ref p3, ref p11);
			SwapIfGreater(ref p4, ref p12);
			SwapIfGreater(ref p5, ref p13);
			SwapIfGreater(ref p6, ref p14);
			SwapIfGreater(ref p5, ref p10);
			SwapIfGreater(ref p6, ref p9);
			SwapIfGreater(ref p3, ref p12);
			SwapIfGreater(ref p13, ref p14);
			SwapIfGreater(ref p7, ref p11);
			SwapIfGreater(ref p1, ref p2);
			SwapIfGreater(ref p4, ref p8);
			SwapIfGreater(ref p1, ref p4);
			SwapIfGreater(ref p7, ref p13);
			SwapIfGreater(ref p2, ref p8);
			SwapIfGreater(ref p11, ref p14);
			SwapIfGreater(ref p2, ref p4);
			SwapIfGreater(ref p5, ref p6);
			SwapIfGreater(ref p9, ref p10);
			SwapIfGreater(ref p11, ref p13);
			SwapIfGreater(ref p3, ref p8);
			SwapIfGreater(ref p7, ref p12);
			SwapIfGreater(ref p6, ref p8);
			SwapIfGreater(ref p10, ref p12);
			SwapIfGreater(ref p3, ref p5);
			SwapIfGreater(ref p7, ref p9);
			SwapIfGreater(ref p3, ref p4);
			SwapIfGreater(ref p5, ref p6);
			SwapIfGreater(ref p7, ref p8);
			SwapIfGreater(ref p9, ref p10);
			SwapIfGreater(ref p11, ref p12);
			SwapIfGreater(ref p6, ref p7);
			SwapIfGreater(ref p8, ref p9);
		}

		/// <summary>
		/// Sorts a collection of 16 elements in ascending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static new void Sort16Ascending<T>(ref T p0)
			where T : IComparable<T>
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

			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p2, ref p3);
			SwapIfGreater(ref p4, ref p5);
			SwapIfGreater(ref p6, ref p7);
			SwapIfGreater(ref p8, ref p9);
			SwapIfGreater(ref p10, ref p11);
			SwapIfGreater(ref p12, ref p13);
			SwapIfGreater(ref p14, ref p15);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p4, ref p6);
			SwapIfGreater(ref p8, ref p10);
			SwapIfGreater(ref p12, ref p14);
			SwapIfGreater(ref p1, ref p3);
			SwapIfGreater(ref p5, ref p7);
			SwapIfGreater(ref p9, ref p11);
			SwapIfGreater(ref p13, ref p15);
			SwapIfGreater(ref p0, ref p4);
			SwapIfGreater(ref p8, ref p12);
			SwapIfGreater(ref p1, ref p5);
			SwapIfGreater(ref p9, ref p13);
			SwapIfGreater(ref p2, ref p6);
			SwapIfGreater(ref p10, ref p14);
			SwapIfGreater(ref p3, ref p7);
			SwapIfGreater(ref p11, ref p15);
			SwapIfGreater(ref p0, ref p8);
			SwapIfGreater(ref p1, ref p9);
			SwapIfGreater(ref p2, ref p10);
			SwapIfGreater(ref p3, ref p11);
			SwapIfGreater(ref p4, ref p12);
			SwapIfGreater(ref p5, ref p13);
			SwapIfGreater(ref p6, ref p14);
			SwapIfGreater(ref p7, ref p15);
			SwapIfGreater(ref p5, ref p10);
			SwapIfGreater(ref p6, ref p9);
			SwapIfGreater(ref p3, ref p12);
			SwapIfGreater(ref p13, ref p14);
			SwapIfGreater(ref p7, ref p11);
			SwapIfGreater(ref p1, ref p2);
			SwapIfGreater(ref p4, ref p8);
			SwapIfGreater(ref p1, ref p4);
			SwapIfGreater(ref p7, ref p13);
			SwapIfGreater(ref p2, ref p8);
			SwapIfGreater(ref p11, ref p14);
			SwapIfGreater(ref p2, ref p4);
			SwapIfGreater(ref p5, ref p6);
			SwapIfGreater(ref p9, ref p10);
			SwapIfGreater(ref p11, ref p13);
			SwapIfGreater(ref p3, ref p8);
			SwapIfGreater(ref p7, ref p12);
			SwapIfGreater(ref p6, ref p8);
			SwapIfGreater(ref p10, ref p12);
			SwapIfGreater(ref p3, ref p5);
			SwapIfGreater(ref p7, ref p9);
			SwapIfGreater(ref p3, ref p4);
			SwapIfGreater(ref p5, ref p6);
			SwapIfGreater(ref p7, ref p8);
			SwapIfGreater(ref p9, ref p10);
			SwapIfGreater(ref p11, ref p12);
			SwapIfGreater(ref p6, ref p7);
			SwapIfGreater(ref p8, ref p9);
		}

		/// <summary>
		/// Sorts a collection of specified number of elements in ascending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="length">the length of the collection</param>
		/// <exception cref="ArgumentOutOfRangeException">collection length is not between <see cref="MinLength"/> and <see cref="MaxLength"/></exception>
		public static new void SortAscending<T>(ref T p0, in int length)
			where T : IComparable<T>
		{
			switch (length)
			{
				case 2: Sort2Ascending(ref p0); break;
				case 3: Sort3Ascending(ref p0); break;
				case 4: Sort4Ascending(ref p0); break;
				case 5: Sort5Ascending(ref p0); break;
				case 6: Sort6Ascending(ref p0); break;
				case 7: Sort7Ascending(ref p0); break;
				case 8: Sort8Ascending(ref p0); break;
				case 9: Sort9Ascending(ref p0); break;
				case 10: Sort10Ascending(ref p0); break;
				case 11: Sort11Ascending(ref p0); break;
				case 12: Sort12Ascending(ref p0); break;
				case 13: Sort13Ascending(ref p0); break;
				case 14: Sort14Ascending(ref p0); break;
				case 15: Sort15Ascending(ref p0); break;
				case 16: Sort16Ascending(ref p0); break;
				case 17: Sort17Ascending(ref p0); break;
				case 18: Sort18Ascending(ref p0); break;
				case 19: Sort19Ascending(ref p0); break;
				case 20: Sort20Ascending(ref p0); break;
				case 21: Sort21Ascending(ref p0); break;
				case 22: Sort22Ascending(ref p0); break;
				case 23: Sort23Ascending(ref p0); break;
				case 24: Sort24Ascending(ref p0); break;
				case 25: Sort25Ascending(ref p0); break;
				case 26: Sort26Ascending(ref p0); break;
				case 27: Sort27Ascending(ref p0); break;
				case 28: Sort28Ascending(ref p0); break;
				case 29: Sort29Ascending(ref p0); break;
				case 30: Sort30Ascending(ref p0); break;
				case 31: Sort31Ascending(ref p0); break;
				case 32: Sort32Ascending(ref p0); break;
				default: throw new ArgumentOutOfRangeException(nameof(length), $"Sorting network length `{length}` must be between `{MinLength}` and `{MaxLength}`.");
			}
		}
	}
}