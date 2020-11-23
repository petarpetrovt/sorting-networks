namespace SortingNetworks
{
	using System;
	using System.Runtime.CompilerServices;

	partial class SNBestKnown
	{
		/// <summary>
		/// Sorts a collection of 9 elements in descending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static new void Sort9DescendingBranchless(ref int p0)
		{
			ref int p1 = ref Unsafe.Add(ref p0, 1);
			ref int p2 = ref Unsafe.Add(ref p0, 2);
			ref int p3 = ref Unsafe.Add(ref p0, 3);
			ref int p4 = ref Unsafe.Add(ref p0, 4);
			ref int p5 = ref Unsafe.Add(ref p0, 5);
			ref int p6 = ref Unsafe.Add(ref p0, 6);
			ref int p7 = ref Unsafe.Add(ref p0, 7);
			ref int p8 = ref Unsafe.Add(ref p0, 8);

			SwapBranchlessLessThan(ref p0, ref p1);
			SwapBranchlessLessThan(ref p3, ref p4);
			SwapBranchlessLessThan(ref p6, ref p7);
			SwapBranchlessLessThan(ref p1, ref p2);
			SwapBranchlessLessThan(ref p4, ref p5);
			SwapBranchlessLessThan(ref p7, ref p8);
			SwapBranchlessLessThan(ref p0, ref p1);
			SwapBranchlessLessThan(ref p3, ref p4);
			SwapBranchlessLessThan(ref p6, ref p7);
			SwapBranchlessLessThan(ref p2, ref p5);
			SwapBranchlessLessThan(ref p0, ref p3);
			SwapBranchlessLessThan(ref p1, ref p4);
			SwapBranchlessLessThan(ref p5, ref p8);
			SwapBranchlessLessThan(ref p3, ref p6);
			SwapBranchlessLessThan(ref p4, ref p7);
			SwapBranchlessLessThan(ref p2, ref p5);
			SwapBranchlessLessThan(ref p0, ref p3);
			SwapBranchlessLessThan(ref p1, ref p4);
			SwapBranchlessLessThan(ref p5, ref p7);
			SwapBranchlessLessThan(ref p2, ref p6);
			SwapBranchlessLessThan(ref p1, ref p3);
			SwapBranchlessLessThan(ref p4, ref p6);
			SwapBranchlessLessThan(ref p2, ref p4);
			SwapBranchlessLessThan(ref p5, ref p6);
			SwapBranchlessLessThan(ref p2, ref p3);
		}

		/// <summary>
		/// Sorts a collection of 10 elements in descending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static new void Sort10DescendingBranchless(ref int p0)
		{
			ref int p1 = ref Unsafe.Add(ref p0, 1);
			ref int p2 = ref Unsafe.Add(ref p0, 2);
			ref int p3 = ref Unsafe.Add(ref p0, 3);
			ref int p4 = ref Unsafe.Add(ref p0, 4);
			ref int p5 = ref Unsafe.Add(ref p0, 5);
			ref int p6 = ref Unsafe.Add(ref p0, 6);
			ref int p7 = ref Unsafe.Add(ref p0, 7);
			ref int p8 = ref Unsafe.Add(ref p0, 8);
			ref int p9 = ref Unsafe.Add(ref p0, 9);

			SwapBranchlessLessThan(ref p4, ref p9);
			SwapBranchlessLessThan(ref p3, ref p8);
			SwapBranchlessLessThan(ref p2, ref p7);
			SwapBranchlessLessThan(ref p1, ref p6);
			SwapBranchlessLessThan(ref p0, ref p5);
			SwapBranchlessLessThan(ref p1, ref p4);
			SwapBranchlessLessThan(ref p6, ref p9);
			SwapBranchlessLessThan(ref p0, ref p3);
			SwapBranchlessLessThan(ref p5, ref p8);
			SwapBranchlessLessThan(ref p0, ref p2);
			SwapBranchlessLessThan(ref p3, ref p6);
			SwapBranchlessLessThan(ref p7, ref p9);
			SwapBranchlessLessThan(ref p0, ref p1);
			SwapBranchlessLessThan(ref p2, ref p4);
			SwapBranchlessLessThan(ref p5, ref p7);
			SwapBranchlessLessThan(ref p8, ref p9);
			SwapBranchlessLessThan(ref p1, ref p2);
			SwapBranchlessLessThan(ref p4, ref p6);
			SwapBranchlessLessThan(ref p7, ref p8);
			SwapBranchlessLessThan(ref p3, ref p5);
			SwapBranchlessLessThan(ref p2, ref p5);
			SwapBranchlessLessThan(ref p6, ref p8);
			SwapBranchlessLessThan(ref p1, ref p3);
			SwapBranchlessLessThan(ref p4, ref p7);
			SwapBranchlessLessThan(ref p2, ref p3);
			SwapBranchlessLessThan(ref p6, ref p7);
			SwapBranchlessLessThan(ref p3, ref p4);
			SwapBranchlessLessThan(ref p5, ref p6);
			SwapBranchlessLessThan(ref p4, ref p5);
		}

		/// <summary>
		/// Sorts a collection of 11 elements in descending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static new void Sort11DescendingBranchless(ref int p0)
		{
			ref int p1 = ref Unsafe.Add(ref p0, 1);
			ref int p2 = ref Unsafe.Add(ref p0, 2);
			ref int p3 = ref Unsafe.Add(ref p0, 3);
			ref int p4 = ref Unsafe.Add(ref p0, 4);
			ref int p5 = ref Unsafe.Add(ref p0, 5);
			ref int p6 = ref Unsafe.Add(ref p0, 6);
			ref int p7 = ref Unsafe.Add(ref p0, 7);
			ref int p8 = ref Unsafe.Add(ref p0, 8);
			ref int p9 = ref Unsafe.Add(ref p0, 9);
			ref int p10 = ref Unsafe.Add(ref p0, 10);

			SwapBranchlessLessThan(ref p0, ref p1);
			SwapBranchlessLessThan(ref p2, ref p3);
			SwapBranchlessLessThan(ref p4, ref p5);
			SwapBranchlessLessThan(ref p6, ref p7);
			SwapBranchlessLessThan(ref p8, ref p9);
			SwapBranchlessLessThan(ref p1, ref p3);
			SwapBranchlessLessThan(ref p5, ref p7);
			SwapBranchlessLessThan(ref p0, ref p2);
			SwapBranchlessLessThan(ref p4, ref p6);
			SwapBranchlessLessThan(ref p8, ref p10);
			SwapBranchlessLessThan(ref p1, ref p2);
			SwapBranchlessLessThan(ref p5, ref p6);
			SwapBranchlessLessThan(ref p9, ref p10);
			SwapBranchlessLessThan(ref p0, ref p4);
			SwapBranchlessLessThan(ref p3, ref p7);
			SwapBranchlessLessThan(ref p1, ref p5);
			SwapBranchlessLessThan(ref p6, ref p10);
			SwapBranchlessLessThan(ref p4, ref p8);
			SwapBranchlessLessThan(ref p5, ref p9);
			SwapBranchlessLessThan(ref p2, ref p6);
			SwapBranchlessLessThan(ref p0, ref p4);
			SwapBranchlessLessThan(ref p3, ref p8);
			SwapBranchlessLessThan(ref p1, ref p5);
			SwapBranchlessLessThan(ref p6, ref p10);
			SwapBranchlessLessThan(ref p2, ref p3);
			SwapBranchlessLessThan(ref p8, ref p9);
			SwapBranchlessLessThan(ref p1, ref p4);
			SwapBranchlessLessThan(ref p7, ref p10);
			SwapBranchlessLessThan(ref p3, ref p5);
			SwapBranchlessLessThan(ref p6, ref p8);
			SwapBranchlessLessThan(ref p2, ref p4);
			SwapBranchlessLessThan(ref p7, ref p9);
			SwapBranchlessLessThan(ref p5, ref p6);
			SwapBranchlessLessThan(ref p3, ref p4);
			SwapBranchlessLessThan(ref p7, ref p8);
		}

		/// <summary>
		/// Sorts a collection of 12 elements in descending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static new void Sort12DescendingBranchless(ref int p0)
		{
			ref int p1 = ref Unsafe.Add(ref p0, 1);
			ref int p2 = ref Unsafe.Add(ref p0, 2);
			ref int p3 = ref Unsafe.Add(ref p0, 3);
			ref int p4 = ref Unsafe.Add(ref p0, 4);
			ref int p5 = ref Unsafe.Add(ref p0, 5);
			ref int p6 = ref Unsafe.Add(ref p0, 6);
			ref int p7 = ref Unsafe.Add(ref p0, 7);
			ref int p8 = ref Unsafe.Add(ref p0, 8);
			ref int p9 = ref Unsafe.Add(ref p0, 9);
			ref int p10 = ref Unsafe.Add(ref p0, 10);
			ref int p11 = ref Unsafe.Add(ref p0, 11);

			SwapBranchlessLessThan(ref p0, ref p1);
			SwapBranchlessLessThan(ref p2, ref p3);
			SwapBranchlessLessThan(ref p4, ref p5);
			SwapBranchlessLessThan(ref p6, ref p7);
			SwapBranchlessLessThan(ref p8, ref p9);
			SwapBranchlessLessThan(ref p10, ref p11);
			SwapBranchlessLessThan(ref p1, ref p3);
			SwapBranchlessLessThan(ref p5, ref p7);
			SwapBranchlessLessThan(ref p9, ref p11);
			SwapBranchlessLessThan(ref p0, ref p2);
			SwapBranchlessLessThan(ref p4, ref p6);
			SwapBranchlessLessThan(ref p8, ref p10);
			SwapBranchlessLessThan(ref p1, ref p2);
			SwapBranchlessLessThan(ref p5, ref p6);
			SwapBranchlessLessThan(ref p9, ref p10);
			SwapBranchlessLessThan(ref p0, ref p4);
			SwapBranchlessLessThan(ref p7, ref p11);
			SwapBranchlessLessThan(ref p1, ref p5);
			SwapBranchlessLessThan(ref p6, ref p10);
			SwapBranchlessLessThan(ref p3, ref p7);
			SwapBranchlessLessThan(ref p4, ref p8);
			SwapBranchlessLessThan(ref p5, ref p9);
			SwapBranchlessLessThan(ref p2, ref p6);
			SwapBranchlessLessThan(ref p0, ref p4);
			SwapBranchlessLessThan(ref p7, ref p11);
			SwapBranchlessLessThan(ref p3, ref p8);
			SwapBranchlessLessThan(ref p1, ref p5);
			SwapBranchlessLessThan(ref p6, ref p10);
			SwapBranchlessLessThan(ref p2, ref p3);
			SwapBranchlessLessThan(ref p8, ref p9);
			SwapBranchlessLessThan(ref p1, ref p4);
			SwapBranchlessLessThan(ref p7, ref p10);
			SwapBranchlessLessThan(ref p3, ref p5);
			SwapBranchlessLessThan(ref p6, ref p8);
			SwapBranchlessLessThan(ref p2, ref p4);
			SwapBranchlessLessThan(ref p7, ref p9);
			SwapBranchlessLessThan(ref p5, ref p6);
			SwapBranchlessLessThan(ref p3, ref p4);
			SwapBranchlessLessThan(ref p7, ref p8);
		}

		/// <summary>
		/// Sorts a collection of 13 elements in descending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static new void Sort13DescendingBranchless(ref int p0)
		{
			ref int p1 = ref Unsafe.Add(ref p0, 1);
			ref int p2 = ref Unsafe.Add(ref p0, 2);
			ref int p3 = ref Unsafe.Add(ref p0, 3);
			ref int p4 = ref Unsafe.Add(ref p0, 4);
			ref int p5 = ref Unsafe.Add(ref p0, 5);
			ref int p6 = ref Unsafe.Add(ref p0, 6);
			ref int p7 = ref Unsafe.Add(ref p0, 7);
			ref int p8 = ref Unsafe.Add(ref p0, 8);
			ref int p9 = ref Unsafe.Add(ref p0, 9);
			ref int p10 = ref Unsafe.Add(ref p0, 10);
			ref int p11 = ref Unsafe.Add(ref p0, 11);
			ref int p12 = ref Unsafe.Add(ref p0, 12);

			SwapBranchlessLessThan(ref p1, ref p7);
			SwapBranchlessLessThan(ref p9, ref p11);
			SwapBranchlessLessThan(ref p3, ref p4);
			SwapBranchlessLessThan(ref p5, ref p8);
			SwapBranchlessLessThan(ref p0, ref p12);
			SwapBranchlessLessThan(ref p2, ref p6);
			SwapBranchlessLessThan(ref p0, ref p1);
			SwapBranchlessLessThan(ref p2, ref p3);
			SwapBranchlessLessThan(ref p4, ref p6);
			SwapBranchlessLessThan(ref p8, ref p11);
			SwapBranchlessLessThan(ref p7, ref p12);
			SwapBranchlessLessThan(ref p5, ref p9);
			SwapBranchlessLessThan(ref p0, ref p2);
			SwapBranchlessLessThan(ref p3, ref p7);
			SwapBranchlessLessThan(ref p10, ref p11);
			SwapBranchlessLessThan(ref p1, ref p4);
			SwapBranchlessLessThan(ref p6, ref p12);
			SwapBranchlessLessThan(ref p7, ref p8);
			SwapBranchlessLessThan(ref p11, ref p12);
			SwapBranchlessLessThan(ref p4, ref p9);
			SwapBranchlessLessThan(ref p6, ref p10);
			SwapBranchlessLessThan(ref p3, ref p4);
			SwapBranchlessLessThan(ref p5, ref p6);
			SwapBranchlessLessThan(ref p8, ref p9);
			SwapBranchlessLessThan(ref p10, ref p11);
			SwapBranchlessLessThan(ref p1, ref p7);
			SwapBranchlessLessThan(ref p2, ref p6);
			SwapBranchlessLessThan(ref p9, ref p11);
			SwapBranchlessLessThan(ref p1, ref p3);
			SwapBranchlessLessThan(ref p4, ref p7);
			SwapBranchlessLessThan(ref p8, ref p10);
			SwapBranchlessLessThan(ref p0, ref p5);
			SwapBranchlessLessThan(ref p2, ref p5);
			SwapBranchlessLessThan(ref p6, ref p8);
			SwapBranchlessLessThan(ref p9, ref p10);
			SwapBranchlessLessThan(ref p1, ref p2);
			SwapBranchlessLessThan(ref p3, ref p5);
			SwapBranchlessLessThan(ref p7, ref p8);
			SwapBranchlessLessThan(ref p4, ref p6);
			SwapBranchlessLessThan(ref p2, ref p3);
			SwapBranchlessLessThan(ref p4, ref p5);
			SwapBranchlessLessThan(ref p6, ref p7);
			SwapBranchlessLessThan(ref p8, ref p9);
			SwapBranchlessLessThan(ref p3, ref p4);
			SwapBranchlessLessThan(ref p5, ref p6);
		}

		/// <summary>
		/// Sorts a collection of 14 elements in descending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static new void Sort14DescendingBranchless(ref int p0)
		{
			ref int p1 = ref Unsafe.Add(ref p0, 1);
			ref int p2 = ref Unsafe.Add(ref p0, 2);
			ref int p3 = ref Unsafe.Add(ref p0, 3);
			ref int p4 = ref Unsafe.Add(ref p0, 4);
			ref int p5 = ref Unsafe.Add(ref p0, 5);
			ref int p6 = ref Unsafe.Add(ref p0, 6);
			ref int p7 = ref Unsafe.Add(ref p0, 7);
			ref int p8 = ref Unsafe.Add(ref p0, 8);
			ref int p9 = ref Unsafe.Add(ref p0, 9);
			ref int p10 = ref Unsafe.Add(ref p0, 10);
			ref int p11 = ref Unsafe.Add(ref p0, 11);
			ref int p12 = ref Unsafe.Add(ref p0, 12);
			ref int p13 = ref Unsafe.Add(ref p0, 13);

			SwapBranchlessLessThan(ref p0, ref p1);
			SwapBranchlessLessThan(ref p2, ref p3);
			SwapBranchlessLessThan(ref p4, ref p5);
			SwapBranchlessLessThan(ref p6, ref p7);
			SwapBranchlessLessThan(ref p8, ref p9);
			SwapBranchlessLessThan(ref p10, ref p11);
			SwapBranchlessLessThan(ref p12, ref p13);
			SwapBranchlessLessThan(ref p0, ref p2);
			SwapBranchlessLessThan(ref p4, ref p6);
			SwapBranchlessLessThan(ref p8, ref p10);
			SwapBranchlessLessThan(ref p1, ref p3);
			SwapBranchlessLessThan(ref p5, ref p7);
			SwapBranchlessLessThan(ref p9, ref p11);
			SwapBranchlessLessThan(ref p0, ref p4);
			SwapBranchlessLessThan(ref p8, ref p12);
			SwapBranchlessLessThan(ref p1, ref p5);
			SwapBranchlessLessThan(ref p9, ref p13);
			SwapBranchlessLessThan(ref p2, ref p6);
			SwapBranchlessLessThan(ref p3, ref p7);
			SwapBranchlessLessThan(ref p0, ref p8);
			SwapBranchlessLessThan(ref p1, ref p9);
			SwapBranchlessLessThan(ref p2, ref p10);
			SwapBranchlessLessThan(ref p3, ref p11);
			SwapBranchlessLessThan(ref p4, ref p12);
			SwapBranchlessLessThan(ref p5, ref p13);
			SwapBranchlessLessThan(ref p5, ref p10);
			SwapBranchlessLessThan(ref p6, ref p9);
			SwapBranchlessLessThan(ref p3, ref p12);
			SwapBranchlessLessThan(ref p7, ref p11);
			SwapBranchlessLessThan(ref p1, ref p2);
			SwapBranchlessLessThan(ref p4, ref p8);
			SwapBranchlessLessThan(ref p1, ref p4);
			SwapBranchlessLessThan(ref p7, ref p13);
			SwapBranchlessLessThan(ref p2, ref p8);
			SwapBranchlessLessThan(ref p5, ref p6);
			SwapBranchlessLessThan(ref p9, ref p10);
			SwapBranchlessLessThan(ref p2, ref p4);
			SwapBranchlessLessThan(ref p11, ref p13);
			SwapBranchlessLessThan(ref p3, ref p8);
			SwapBranchlessLessThan(ref p7, ref p12);
			SwapBranchlessLessThan(ref p6, ref p8);
			SwapBranchlessLessThan(ref p10, ref p12);
			SwapBranchlessLessThan(ref p3, ref p5);
			SwapBranchlessLessThan(ref p7, ref p9);
			SwapBranchlessLessThan(ref p3, ref p4);
			SwapBranchlessLessThan(ref p5, ref p6);
			SwapBranchlessLessThan(ref p7, ref p8);
			SwapBranchlessLessThan(ref p9, ref p10);
			SwapBranchlessLessThan(ref p11, ref p12);
			SwapBranchlessLessThan(ref p6, ref p7);
			SwapBranchlessLessThan(ref p8, ref p9);
		}

		/// <summary>
		/// Sorts a collection of 15 elements in descending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static new void Sort15DescendingBranchless(ref int p0)
		{
			ref int p1 = ref Unsafe.Add(ref p0, 1);
			ref int p2 = ref Unsafe.Add(ref p0, 2);
			ref int p3 = ref Unsafe.Add(ref p0, 3);
			ref int p4 = ref Unsafe.Add(ref p0, 4);
			ref int p5 = ref Unsafe.Add(ref p0, 5);
			ref int p6 = ref Unsafe.Add(ref p0, 6);
			ref int p7 = ref Unsafe.Add(ref p0, 7);
			ref int p8 = ref Unsafe.Add(ref p0, 8);
			ref int p9 = ref Unsafe.Add(ref p0, 9);
			ref int p10 = ref Unsafe.Add(ref p0, 10);
			ref int p11 = ref Unsafe.Add(ref p0, 11);
			ref int p12 = ref Unsafe.Add(ref p0, 12);
			ref int p13 = ref Unsafe.Add(ref p0, 13);
			ref int p14 = ref Unsafe.Add(ref p0, 14);

			SwapBranchlessLessThan(ref p0, ref p1);
			SwapBranchlessLessThan(ref p2, ref p3);
			SwapBranchlessLessThan(ref p4, ref p5);
			SwapBranchlessLessThan(ref p6, ref p7);
			SwapBranchlessLessThan(ref p8, ref p9);
			SwapBranchlessLessThan(ref p10, ref p11);
			SwapBranchlessLessThan(ref p12, ref p13);
			SwapBranchlessLessThan(ref p0, ref p2);
			SwapBranchlessLessThan(ref p4, ref p6);
			SwapBranchlessLessThan(ref p8, ref p10);
			SwapBranchlessLessThan(ref p12, ref p14);
			SwapBranchlessLessThan(ref p1, ref p3);
			SwapBranchlessLessThan(ref p5, ref p7);
			SwapBranchlessLessThan(ref p9, ref p11);
			SwapBranchlessLessThan(ref p0, ref p4);
			SwapBranchlessLessThan(ref p8, ref p12);
			SwapBranchlessLessThan(ref p1, ref p5);
			SwapBranchlessLessThan(ref p9, ref p13);
			SwapBranchlessLessThan(ref p2, ref p6);
			SwapBranchlessLessThan(ref p10, ref p14);
			SwapBranchlessLessThan(ref p3, ref p7);
			SwapBranchlessLessThan(ref p0, ref p8);
			SwapBranchlessLessThan(ref p1, ref p9);
			SwapBranchlessLessThan(ref p2, ref p10);
			SwapBranchlessLessThan(ref p3, ref p11);
			SwapBranchlessLessThan(ref p4, ref p12);
			SwapBranchlessLessThan(ref p5, ref p13);
			SwapBranchlessLessThan(ref p6, ref p14);
			SwapBranchlessLessThan(ref p5, ref p10);
			SwapBranchlessLessThan(ref p6, ref p9);
			SwapBranchlessLessThan(ref p3, ref p12);
			SwapBranchlessLessThan(ref p13, ref p14);
			SwapBranchlessLessThan(ref p7, ref p11);
			SwapBranchlessLessThan(ref p1, ref p2);
			SwapBranchlessLessThan(ref p4, ref p8);
			SwapBranchlessLessThan(ref p1, ref p4);
			SwapBranchlessLessThan(ref p7, ref p13);
			SwapBranchlessLessThan(ref p2, ref p8);
			SwapBranchlessLessThan(ref p11, ref p14);
			SwapBranchlessLessThan(ref p5, ref p6);
			SwapBranchlessLessThan(ref p9, ref p10);
			SwapBranchlessLessThan(ref p2, ref p4);
			SwapBranchlessLessThan(ref p11, ref p13);
			SwapBranchlessLessThan(ref p3, ref p8);
			SwapBranchlessLessThan(ref p7, ref p12);
			SwapBranchlessLessThan(ref p6, ref p8);
			SwapBranchlessLessThan(ref p10, ref p12);
			SwapBranchlessLessThan(ref p3, ref p5);
			SwapBranchlessLessThan(ref p7, ref p9);
			SwapBranchlessLessThan(ref p3, ref p4);
			SwapBranchlessLessThan(ref p5, ref p6);
			SwapBranchlessLessThan(ref p7, ref p8);
			SwapBranchlessLessThan(ref p9, ref p10);
			SwapBranchlessLessThan(ref p11, ref p12);
			SwapBranchlessLessThan(ref p6, ref p7);
			SwapBranchlessLessThan(ref p8, ref p9);
		}

		/// <summary>
		/// Sorts a collection of 16 elements in descending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static new void Sort16DescendingBranchless(ref int p0)
		{
			ref int p1 = ref Unsafe.Add(ref p0, 1);
			ref int p2 = ref Unsafe.Add(ref p0, 2);
			ref int p3 = ref Unsafe.Add(ref p0, 3);
			ref int p4 = ref Unsafe.Add(ref p0, 4);
			ref int p5 = ref Unsafe.Add(ref p0, 5);
			ref int p6 = ref Unsafe.Add(ref p0, 6);
			ref int p7 = ref Unsafe.Add(ref p0, 7);
			ref int p8 = ref Unsafe.Add(ref p0, 8);
			ref int p9 = ref Unsafe.Add(ref p0, 9);
			ref int p10 = ref Unsafe.Add(ref p0, 10);
			ref int p11 = ref Unsafe.Add(ref p0, 11);
			ref int p12 = ref Unsafe.Add(ref p0, 12);
			ref int p13 = ref Unsafe.Add(ref p0, 13);
			ref int p14 = ref Unsafe.Add(ref p0, 14);
			ref int p15 = ref Unsafe.Add(ref p0, 15);

			SwapBranchlessLessThan(ref p0, ref p1);
			SwapBranchlessLessThan(ref p2, ref p3);
			SwapBranchlessLessThan(ref p4, ref p5);
			SwapBranchlessLessThan(ref p6, ref p7);
			SwapBranchlessLessThan(ref p8, ref p9);
			SwapBranchlessLessThan(ref p10, ref p11);
			SwapBranchlessLessThan(ref p12, ref p13);
			SwapBranchlessLessThan(ref p14, ref p15);
			SwapBranchlessLessThan(ref p0, ref p2);
			SwapBranchlessLessThan(ref p4, ref p6);
			SwapBranchlessLessThan(ref p8, ref p10);
			SwapBranchlessLessThan(ref p12, ref p14);
			SwapBranchlessLessThan(ref p1, ref p3);
			SwapBranchlessLessThan(ref p5, ref p7);
			SwapBranchlessLessThan(ref p9, ref p11);
			SwapBranchlessLessThan(ref p13, ref p15);
			SwapBranchlessLessThan(ref p0, ref p4);
			SwapBranchlessLessThan(ref p8, ref p12);
			SwapBranchlessLessThan(ref p1, ref p5);
			SwapBranchlessLessThan(ref p9, ref p13);
			SwapBranchlessLessThan(ref p2, ref p6);
			SwapBranchlessLessThan(ref p10, ref p14);
			SwapBranchlessLessThan(ref p3, ref p7);
			SwapBranchlessLessThan(ref p11, ref p15);
			SwapBranchlessLessThan(ref p0, ref p8);
			SwapBranchlessLessThan(ref p1, ref p9);
			SwapBranchlessLessThan(ref p2, ref p10);
			SwapBranchlessLessThan(ref p3, ref p11);
			SwapBranchlessLessThan(ref p4, ref p12);
			SwapBranchlessLessThan(ref p5, ref p13);
			SwapBranchlessLessThan(ref p6, ref p14);
			SwapBranchlessLessThan(ref p7, ref p15);
			SwapBranchlessLessThan(ref p5, ref p10);
			SwapBranchlessLessThan(ref p6, ref p9);
			SwapBranchlessLessThan(ref p3, ref p12);
			SwapBranchlessLessThan(ref p13, ref p14);
			SwapBranchlessLessThan(ref p7, ref p11);
			SwapBranchlessLessThan(ref p1, ref p2);
			SwapBranchlessLessThan(ref p4, ref p8);
			SwapBranchlessLessThan(ref p1, ref p4);
			SwapBranchlessLessThan(ref p7, ref p13);
			SwapBranchlessLessThan(ref p2, ref p8);
			SwapBranchlessLessThan(ref p11, ref p14);
			SwapBranchlessLessThan(ref p5, ref p6);
			SwapBranchlessLessThan(ref p9, ref p10);
			SwapBranchlessLessThan(ref p2, ref p4);
			SwapBranchlessLessThan(ref p11, ref p13);
			SwapBranchlessLessThan(ref p3, ref p8);
			SwapBranchlessLessThan(ref p7, ref p12);
			SwapBranchlessLessThan(ref p6, ref p8);
			SwapBranchlessLessThan(ref p10, ref p12);
			SwapBranchlessLessThan(ref p3, ref p5);
			SwapBranchlessLessThan(ref p7, ref p9);
			SwapBranchlessLessThan(ref p3, ref p4);
			SwapBranchlessLessThan(ref p5, ref p6);
			SwapBranchlessLessThan(ref p7, ref p8);
			SwapBranchlessLessThan(ref p9, ref p10);
			SwapBranchlessLessThan(ref p11, ref p12);
			SwapBranchlessLessThan(ref p6, ref p7);
			SwapBranchlessLessThan(ref p8, ref p9);
		}

		/// <summary>
		/// Sorts a collection of specified number of elements in descending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="length">the length of the collection</param>
		/// <exception cref="ArgumentOutOfRangeException">collection length is not between <see cref="MinLength"/> and <see cref="MaxLength"/></exception>
		public static new void SortDescendingBranchless(ref int p0, in int length)
		{
			switch (length)
			{
				case 2: Sort2DescendingBranchless(ref p0); break;
				case 3: Sort3DescendingBranchless(ref p0); break;
				case 4: Sort4DescendingBranchless(ref p0); break;
				case 5: Sort5DescendingBranchless(ref p0); break;
				case 6: Sort6DescendingBranchless(ref p0); break;
				case 7: Sort7DescendingBranchless(ref p0); break;
				case 8: Sort8DescendingBranchless(ref p0); break;
				case 9: Sort9DescendingBranchless(ref p0); break;
				case 10: Sort10DescendingBranchless(ref p0); break;
				case 11: Sort11DescendingBranchless(ref p0); break;
				case 12: Sort12DescendingBranchless(ref p0); break;
				case 13: Sort13DescendingBranchless(ref p0); break;
				case 14: Sort14DescendingBranchless(ref p0); break;
				case 15: Sort15DescendingBranchless(ref p0); break;
				case 16: Sort16DescendingBranchless(ref p0); break;
				case 17: Sort17DescendingBranchless(ref p0); break;
				case 18: Sort18DescendingBranchless(ref p0); break;
				case 19: Sort19DescendingBranchless(ref p0); break;
				case 20: Sort20DescendingBranchless(ref p0); break;
				case 21: Sort21DescendingBranchless(ref p0); break;
				case 22: Sort22DescendingBranchless(ref p0); break;
				case 23: Sort23DescendingBranchless(ref p0); break;
				case 24: Sort24DescendingBranchless(ref p0); break;
				case 25: Sort25DescendingBranchless(ref p0); break;
				case 26: Sort26DescendingBranchless(ref p0); break;
				case 27: Sort27DescendingBranchless(ref p0); break;
				case 28: Sort28DescendingBranchless(ref p0); break;
				case 29: Sort29DescendingBranchless(ref p0); break;
				case 30: Sort30DescendingBranchless(ref p0); break;
				case 31: Sort31DescendingBranchless(ref p0); break;
				case 32: Sort32DescendingBranchless(ref p0); break;
				default:
					{
						ThrowHelper.ArrayArgumentOutOfRange(nameof(length), length, MinLength, MaxLength);
						break;
					}
			}
		}
	}
}