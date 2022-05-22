namespace SortingNetworks;

partial class SNBestKnown
{
	/// <summary>
	/// Sorts a collection of 9 elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	public static new void Sort9DescendingBranchless(ref byte p0)
	{
		ref byte p1 = ref Unsafe.Add(ref p0, 1);
		ref byte p2 = ref Unsafe.Add(ref p0, 2);
		ref byte p3 = ref Unsafe.Add(ref p0, 3);
		ref byte p4 = ref Unsafe.Add(ref p0, 4);
		ref byte p5 = ref Unsafe.Add(ref p0, 5);
		ref byte p6 = ref Unsafe.Add(ref p0, 6);
		ref byte p7 = ref Unsafe.Add(ref p0, 7);
		ref byte p8 = ref Unsafe.Add(ref p0, 8);

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
	/// Sorts a collection of 10 elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	public static new void Sort10DescendingBranchless(ref byte p0)
	{
		ref byte p1 = ref Unsafe.Add(ref p0, 1);
		ref byte p2 = ref Unsafe.Add(ref p0, 2);
		ref byte p3 = ref Unsafe.Add(ref p0, 3);
		ref byte p4 = ref Unsafe.Add(ref p0, 4);
		ref byte p5 = ref Unsafe.Add(ref p0, 5);
		ref byte p6 = ref Unsafe.Add(ref p0, 6);
		ref byte p7 = ref Unsafe.Add(ref p0, 7);
		ref byte p8 = ref Unsafe.Add(ref p0, 8);
		ref byte p9 = ref Unsafe.Add(ref p0, 9);

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
	/// Sorts a collection of 11 elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	public static new void Sort11DescendingBranchless(ref byte p0)
	{
		ref byte p1 = ref Unsafe.Add(ref p0, 1);
		ref byte p2 = ref Unsafe.Add(ref p0, 2);
		ref byte p3 = ref Unsafe.Add(ref p0, 3);
		ref byte p4 = ref Unsafe.Add(ref p0, 4);
		ref byte p5 = ref Unsafe.Add(ref p0, 5);
		ref byte p6 = ref Unsafe.Add(ref p0, 6);
		ref byte p7 = ref Unsafe.Add(ref p0, 7);
		ref byte p8 = ref Unsafe.Add(ref p0, 8);
		ref byte p9 = ref Unsafe.Add(ref p0, 9);
		ref byte p10 = ref Unsafe.Add(ref p0, 10);

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
	/// Sorts a collection of 12 elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	public static new void Sort12DescendingBranchless(ref byte p0)
	{
		ref byte p1 = ref Unsafe.Add(ref p0, 1);
		ref byte p2 = ref Unsafe.Add(ref p0, 2);
		ref byte p3 = ref Unsafe.Add(ref p0, 3);
		ref byte p4 = ref Unsafe.Add(ref p0, 4);
		ref byte p5 = ref Unsafe.Add(ref p0, 5);
		ref byte p6 = ref Unsafe.Add(ref p0, 6);
		ref byte p7 = ref Unsafe.Add(ref p0, 7);
		ref byte p8 = ref Unsafe.Add(ref p0, 8);
		ref byte p9 = ref Unsafe.Add(ref p0, 9);
		ref byte p10 = ref Unsafe.Add(ref p0, 10);
		ref byte p11 = ref Unsafe.Add(ref p0, 11);

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
	/// Sorts a collection of 13 elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	public static new void Sort13DescendingBranchless(ref byte p0)
	{
		ref byte p1 = ref Unsafe.Add(ref p0, 1);
		ref byte p2 = ref Unsafe.Add(ref p0, 2);
		ref byte p3 = ref Unsafe.Add(ref p0, 3);
		ref byte p4 = ref Unsafe.Add(ref p0, 4);
		ref byte p5 = ref Unsafe.Add(ref p0, 5);
		ref byte p6 = ref Unsafe.Add(ref p0, 6);
		ref byte p7 = ref Unsafe.Add(ref p0, 7);
		ref byte p8 = ref Unsafe.Add(ref p0, 8);
		ref byte p9 = ref Unsafe.Add(ref p0, 9);
		ref byte p10 = ref Unsafe.Add(ref p0, 10);
		ref byte p11 = ref Unsafe.Add(ref p0, 11);
		ref byte p12 = ref Unsafe.Add(ref p0, 12);

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
	/// Sorts a collection of 14 elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	public static new void Sort14DescendingBranchless(ref byte p0)
	{
		ref byte p1 = ref Unsafe.Add(ref p0, 1);
		ref byte p2 = ref Unsafe.Add(ref p0, 2);
		ref byte p3 = ref Unsafe.Add(ref p0, 3);
		ref byte p4 = ref Unsafe.Add(ref p0, 4);
		ref byte p5 = ref Unsafe.Add(ref p0, 5);
		ref byte p6 = ref Unsafe.Add(ref p0, 6);
		ref byte p7 = ref Unsafe.Add(ref p0, 7);
		ref byte p8 = ref Unsafe.Add(ref p0, 8);
		ref byte p9 = ref Unsafe.Add(ref p0, 9);
		ref byte p10 = ref Unsafe.Add(ref p0, 10);
		ref byte p11 = ref Unsafe.Add(ref p0, 11);
		ref byte p12 = ref Unsafe.Add(ref p0, 12);
		ref byte p13 = ref Unsafe.Add(ref p0, 13);

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
	/// Sorts a collection of 15 elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	public static new void Sort15DescendingBranchless(ref byte p0)
	{
		ref byte p1 = ref Unsafe.Add(ref p0, 1);
		ref byte p2 = ref Unsafe.Add(ref p0, 2);
		ref byte p3 = ref Unsafe.Add(ref p0, 3);
		ref byte p4 = ref Unsafe.Add(ref p0, 4);
		ref byte p5 = ref Unsafe.Add(ref p0, 5);
		ref byte p6 = ref Unsafe.Add(ref p0, 6);
		ref byte p7 = ref Unsafe.Add(ref p0, 7);
		ref byte p8 = ref Unsafe.Add(ref p0, 8);
		ref byte p9 = ref Unsafe.Add(ref p0, 9);
		ref byte p10 = ref Unsafe.Add(ref p0, 10);
		ref byte p11 = ref Unsafe.Add(ref p0, 11);
		ref byte p12 = ref Unsafe.Add(ref p0, 12);
		ref byte p13 = ref Unsafe.Add(ref p0, 13);
		ref byte p14 = ref Unsafe.Add(ref p0, 14);

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
	/// Sorts a collection of 16 elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	public static new void Sort16DescendingBranchless(ref byte p0)
	{
		ref byte p1 = ref Unsafe.Add(ref p0, 1);
		ref byte p2 = ref Unsafe.Add(ref p0, 2);
		ref byte p3 = ref Unsafe.Add(ref p0, 3);
		ref byte p4 = ref Unsafe.Add(ref p0, 4);
		ref byte p5 = ref Unsafe.Add(ref p0, 5);
		ref byte p6 = ref Unsafe.Add(ref p0, 6);
		ref byte p7 = ref Unsafe.Add(ref p0, 7);
		ref byte p8 = ref Unsafe.Add(ref p0, 8);
		ref byte p9 = ref Unsafe.Add(ref p0, 9);
		ref byte p10 = ref Unsafe.Add(ref p0, 10);
		ref byte p11 = ref Unsafe.Add(ref p0, 11);
		ref byte p12 = ref Unsafe.Add(ref p0, 12);
		ref byte p13 = ref Unsafe.Add(ref p0, 13);
		ref byte p14 = ref Unsafe.Add(ref p0, 14);
		ref byte p15 = ref Unsafe.Add(ref p0, 15);

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
	/// Sorts a collection of 9 elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	public static new void Sort9DescendingBranchless(ref sbyte p0)
	{
		ref sbyte p1 = ref Unsafe.Add(ref p0, 1);
		ref sbyte p2 = ref Unsafe.Add(ref p0, 2);
		ref sbyte p3 = ref Unsafe.Add(ref p0, 3);
		ref sbyte p4 = ref Unsafe.Add(ref p0, 4);
		ref sbyte p5 = ref Unsafe.Add(ref p0, 5);
		ref sbyte p6 = ref Unsafe.Add(ref p0, 6);
		ref sbyte p7 = ref Unsafe.Add(ref p0, 7);
		ref sbyte p8 = ref Unsafe.Add(ref p0, 8);

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
	/// Sorts a collection of 10 elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	public static new void Sort10DescendingBranchless(ref sbyte p0)
	{
		ref sbyte p1 = ref Unsafe.Add(ref p0, 1);
		ref sbyte p2 = ref Unsafe.Add(ref p0, 2);
		ref sbyte p3 = ref Unsafe.Add(ref p0, 3);
		ref sbyte p4 = ref Unsafe.Add(ref p0, 4);
		ref sbyte p5 = ref Unsafe.Add(ref p0, 5);
		ref sbyte p6 = ref Unsafe.Add(ref p0, 6);
		ref sbyte p7 = ref Unsafe.Add(ref p0, 7);
		ref sbyte p8 = ref Unsafe.Add(ref p0, 8);
		ref sbyte p9 = ref Unsafe.Add(ref p0, 9);

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
	/// Sorts a collection of 11 elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	public static new void Sort11DescendingBranchless(ref sbyte p0)
	{
		ref sbyte p1 = ref Unsafe.Add(ref p0, 1);
		ref sbyte p2 = ref Unsafe.Add(ref p0, 2);
		ref sbyte p3 = ref Unsafe.Add(ref p0, 3);
		ref sbyte p4 = ref Unsafe.Add(ref p0, 4);
		ref sbyte p5 = ref Unsafe.Add(ref p0, 5);
		ref sbyte p6 = ref Unsafe.Add(ref p0, 6);
		ref sbyte p7 = ref Unsafe.Add(ref p0, 7);
		ref sbyte p8 = ref Unsafe.Add(ref p0, 8);
		ref sbyte p9 = ref Unsafe.Add(ref p0, 9);
		ref sbyte p10 = ref Unsafe.Add(ref p0, 10);

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
	/// Sorts a collection of 12 elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	public static new void Sort12DescendingBranchless(ref sbyte p0)
	{
		ref sbyte p1 = ref Unsafe.Add(ref p0, 1);
		ref sbyte p2 = ref Unsafe.Add(ref p0, 2);
		ref sbyte p3 = ref Unsafe.Add(ref p0, 3);
		ref sbyte p4 = ref Unsafe.Add(ref p0, 4);
		ref sbyte p5 = ref Unsafe.Add(ref p0, 5);
		ref sbyte p6 = ref Unsafe.Add(ref p0, 6);
		ref sbyte p7 = ref Unsafe.Add(ref p0, 7);
		ref sbyte p8 = ref Unsafe.Add(ref p0, 8);
		ref sbyte p9 = ref Unsafe.Add(ref p0, 9);
		ref sbyte p10 = ref Unsafe.Add(ref p0, 10);
		ref sbyte p11 = ref Unsafe.Add(ref p0, 11);

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
	/// Sorts a collection of 13 elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	public static new void Sort13DescendingBranchless(ref sbyte p0)
	{
		ref sbyte p1 = ref Unsafe.Add(ref p0, 1);
		ref sbyte p2 = ref Unsafe.Add(ref p0, 2);
		ref sbyte p3 = ref Unsafe.Add(ref p0, 3);
		ref sbyte p4 = ref Unsafe.Add(ref p0, 4);
		ref sbyte p5 = ref Unsafe.Add(ref p0, 5);
		ref sbyte p6 = ref Unsafe.Add(ref p0, 6);
		ref sbyte p7 = ref Unsafe.Add(ref p0, 7);
		ref sbyte p8 = ref Unsafe.Add(ref p0, 8);
		ref sbyte p9 = ref Unsafe.Add(ref p0, 9);
		ref sbyte p10 = ref Unsafe.Add(ref p0, 10);
		ref sbyte p11 = ref Unsafe.Add(ref p0, 11);
		ref sbyte p12 = ref Unsafe.Add(ref p0, 12);

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
	/// Sorts a collection of 14 elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	public static new void Sort14DescendingBranchless(ref sbyte p0)
	{
		ref sbyte p1 = ref Unsafe.Add(ref p0, 1);
		ref sbyte p2 = ref Unsafe.Add(ref p0, 2);
		ref sbyte p3 = ref Unsafe.Add(ref p0, 3);
		ref sbyte p4 = ref Unsafe.Add(ref p0, 4);
		ref sbyte p5 = ref Unsafe.Add(ref p0, 5);
		ref sbyte p6 = ref Unsafe.Add(ref p0, 6);
		ref sbyte p7 = ref Unsafe.Add(ref p0, 7);
		ref sbyte p8 = ref Unsafe.Add(ref p0, 8);
		ref sbyte p9 = ref Unsafe.Add(ref p0, 9);
		ref sbyte p10 = ref Unsafe.Add(ref p0, 10);
		ref sbyte p11 = ref Unsafe.Add(ref p0, 11);
		ref sbyte p12 = ref Unsafe.Add(ref p0, 12);
		ref sbyte p13 = ref Unsafe.Add(ref p0, 13);

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
	/// Sorts a collection of 15 elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	public static new void Sort15DescendingBranchless(ref sbyte p0)
	{
		ref sbyte p1 = ref Unsafe.Add(ref p0, 1);
		ref sbyte p2 = ref Unsafe.Add(ref p0, 2);
		ref sbyte p3 = ref Unsafe.Add(ref p0, 3);
		ref sbyte p4 = ref Unsafe.Add(ref p0, 4);
		ref sbyte p5 = ref Unsafe.Add(ref p0, 5);
		ref sbyte p6 = ref Unsafe.Add(ref p0, 6);
		ref sbyte p7 = ref Unsafe.Add(ref p0, 7);
		ref sbyte p8 = ref Unsafe.Add(ref p0, 8);
		ref sbyte p9 = ref Unsafe.Add(ref p0, 9);
		ref sbyte p10 = ref Unsafe.Add(ref p0, 10);
		ref sbyte p11 = ref Unsafe.Add(ref p0, 11);
		ref sbyte p12 = ref Unsafe.Add(ref p0, 12);
		ref sbyte p13 = ref Unsafe.Add(ref p0, 13);
		ref sbyte p14 = ref Unsafe.Add(ref p0, 14);

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
	/// Sorts a collection of 16 elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	public static new void Sort16DescendingBranchless(ref sbyte p0)
	{
		ref sbyte p1 = ref Unsafe.Add(ref p0, 1);
		ref sbyte p2 = ref Unsafe.Add(ref p0, 2);
		ref sbyte p3 = ref Unsafe.Add(ref p0, 3);
		ref sbyte p4 = ref Unsafe.Add(ref p0, 4);
		ref sbyte p5 = ref Unsafe.Add(ref p0, 5);
		ref sbyte p6 = ref Unsafe.Add(ref p0, 6);
		ref sbyte p7 = ref Unsafe.Add(ref p0, 7);
		ref sbyte p8 = ref Unsafe.Add(ref p0, 8);
		ref sbyte p9 = ref Unsafe.Add(ref p0, 9);
		ref sbyte p10 = ref Unsafe.Add(ref p0, 10);
		ref sbyte p11 = ref Unsafe.Add(ref p0, 11);
		ref sbyte p12 = ref Unsafe.Add(ref p0, 12);
		ref sbyte p13 = ref Unsafe.Add(ref p0, 13);
		ref sbyte p14 = ref Unsafe.Add(ref p0, 14);
		ref sbyte p15 = ref Unsafe.Add(ref p0, 15);

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
	/// Sorts a collection of 9 elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	public static new void Sort9DescendingBranchless(ref ushort p0)
	{
		ref ushort p1 = ref Unsafe.Add(ref p0, 1);
		ref ushort p2 = ref Unsafe.Add(ref p0, 2);
		ref ushort p3 = ref Unsafe.Add(ref p0, 3);
		ref ushort p4 = ref Unsafe.Add(ref p0, 4);
		ref ushort p5 = ref Unsafe.Add(ref p0, 5);
		ref ushort p6 = ref Unsafe.Add(ref p0, 6);
		ref ushort p7 = ref Unsafe.Add(ref p0, 7);
		ref ushort p8 = ref Unsafe.Add(ref p0, 8);

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
	/// Sorts a collection of 10 elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	public static new void Sort10DescendingBranchless(ref ushort p0)
	{
		ref ushort p1 = ref Unsafe.Add(ref p0, 1);
		ref ushort p2 = ref Unsafe.Add(ref p0, 2);
		ref ushort p3 = ref Unsafe.Add(ref p0, 3);
		ref ushort p4 = ref Unsafe.Add(ref p0, 4);
		ref ushort p5 = ref Unsafe.Add(ref p0, 5);
		ref ushort p6 = ref Unsafe.Add(ref p0, 6);
		ref ushort p7 = ref Unsafe.Add(ref p0, 7);
		ref ushort p8 = ref Unsafe.Add(ref p0, 8);
		ref ushort p9 = ref Unsafe.Add(ref p0, 9);

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
	/// Sorts a collection of 11 elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	public static new void Sort11DescendingBranchless(ref ushort p0)
	{
		ref ushort p1 = ref Unsafe.Add(ref p0, 1);
		ref ushort p2 = ref Unsafe.Add(ref p0, 2);
		ref ushort p3 = ref Unsafe.Add(ref p0, 3);
		ref ushort p4 = ref Unsafe.Add(ref p0, 4);
		ref ushort p5 = ref Unsafe.Add(ref p0, 5);
		ref ushort p6 = ref Unsafe.Add(ref p0, 6);
		ref ushort p7 = ref Unsafe.Add(ref p0, 7);
		ref ushort p8 = ref Unsafe.Add(ref p0, 8);
		ref ushort p9 = ref Unsafe.Add(ref p0, 9);
		ref ushort p10 = ref Unsafe.Add(ref p0, 10);

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
	/// Sorts a collection of 12 elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	public static new void Sort12DescendingBranchless(ref ushort p0)
	{
		ref ushort p1 = ref Unsafe.Add(ref p0, 1);
		ref ushort p2 = ref Unsafe.Add(ref p0, 2);
		ref ushort p3 = ref Unsafe.Add(ref p0, 3);
		ref ushort p4 = ref Unsafe.Add(ref p0, 4);
		ref ushort p5 = ref Unsafe.Add(ref p0, 5);
		ref ushort p6 = ref Unsafe.Add(ref p0, 6);
		ref ushort p7 = ref Unsafe.Add(ref p0, 7);
		ref ushort p8 = ref Unsafe.Add(ref p0, 8);
		ref ushort p9 = ref Unsafe.Add(ref p0, 9);
		ref ushort p10 = ref Unsafe.Add(ref p0, 10);
		ref ushort p11 = ref Unsafe.Add(ref p0, 11);

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
	/// Sorts a collection of 13 elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	public static new void Sort13DescendingBranchless(ref ushort p0)
	{
		ref ushort p1 = ref Unsafe.Add(ref p0, 1);
		ref ushort p2 = ref Unsafe.Add(ref p0, 2);
		ref ushort p3 = ref Unsafe.Add(ref p0, 3);
		ref ushort p4 = ref Unsafe.Add(ref p0, 4);
		ref ushort p5 = ref Unsafe.Add(ref p0, 5);
		ref ushort p6 = ref Unsafe.Add(ref p0, 6);
		ref ushort p7 = ref Unsafe.Add(ref p0, 7);
		ref ushort p8 = ref Unsafe.Add(ref p0, 8);
		ref ushort p9 = ref Unsafe.Add(ref p0, 9);
		ref ushort p10 = ref Unsafe.Add(ref p0, 10);
		ref ushort p11 = ref Unsafe.Add(ref p0, 11);
		ref ushort p12 = ref Unsafe.Add(ref p0, 12);

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
	/// Sorts a collection of 14 elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	public static new void Sort14DescendingBranchless(ref ushort p0)
	{
		ref ushort p1 = ref Unsafe.Add(ref p0, 1);
		ref ushort p2 = ref Unsafe.Add(ref p0, 2);
		ref ushort p3 = ref Unsafe.Add(ref p0, 3);
		ref ushort p4 = ref Unsafe.Add(ref p0, 4);
		ref ushort p5 = ref Unsafe.Add(ref p0, 5);
		ref ushort p6 = ref Unsafe.Add(ref p0, 6);
		ref ushort p7 = ref Unsafe.Add(ref p0, 7);
		ref ushort p8 = ref Unsafe.Add(ref p0, 8);
		ref ushort p9 = ref Unsafe.Add(ref p0, 9);
		ref ushort p10 = ref Unsafe.Add(ref p0, 10);
		ref ushort p11 = ref Unsafe.Add(ref p0, 11);
		ref ushort p12 = ref Unsafe.Add(ref p0, 12);
		ref ushort p13 = ref Unsafe.Add(ref p0, 13);

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
	/// Sorts a collection of 15 elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	public static new void Sort15DescendingBranchless(ref ushort p0)
	{
		ref ushort p1 = ref Unsafe.Add(ref p0, 1);
		ref ushort p2 = ref Unsafe.Add(ref p0, 2);
		ref ushort p3 = ref Unsafe.Add(ref p0, 3);
		ref ushort p4 = ref Unsafe.Add(ref p0, 4);
		ref ushort p5 = ref Unsafe.Add(ref p0, 5);
		ref ushort p6 = ref Unsafe.Add(ref p0, 6);
		ref ushort p7 = ref Unsafe.Add(ref p0, 7);
		ref ushort p8 = ref Unsafe.Add(ref p0, 8);
		ref ushort p9 = ref Unsafe.Add(ref p0, 9);
		ref ushort p10 = ref Unsafe.Add(ref p0, 10);
		ref ushort p11 = ref Unsafe.Add(ref p0, 11);
		ref ushort p12 = ref Unsafe.Add(ref p0, 12);
		ref ushort p13 = ref Unsafe.Add(ref p0, 13);
		ref ushort p14 = ref Unsafe.Add(ref p0, 14);

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
	/// Sorts a collection of 16 elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	public static new void Sort16DescendingBranchless(ref ushort p0)
	{
		ref ushort p1 = ref Unsafe.Add(ref p0, 1);
		ref ushort p2 = ref Unsafe.Add(ref p0, 2);
		ref ushort p3 = ref Unsafe.Add(ref p0, 3);
		ref ushort p4 = ref Unsafe.Add(ref p0, 4);
		ref ushort p5 = ref Unsafe.Add(ref p0, 5);
		ref ushort p6 = ref Unsafe.Add(ref p0, 6);
		ref ushort p7 = ref Unsafe.Add(ref p0, 7);
		ref ushort p8 = ref Unsafe.Add(ref p0, 8);
		ref ushort p9 = ref Unsafe.Add(ref p0, 9);
		ref ushort p10 = ref Unsafe.Add(ref p0, 10);
		ref ushort p11 = ref Unsafe.Add(ref p0, 11);
		ref ushort p12 = ref Unsafe.Add(ref p0, 12);
		ref ushort p13 = ref Unsafe.Add(ref p0, 13);
		ref ushort p14 = ref Unsafe.Add(ref p0, 14);
		ref ushort p15 = ref Unsafe.Add(ref p0, 15);

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
	/// Sorts a collection of 9 elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	public static new void Sort9DescendingBranchless(ref short p0)
	{
		ref short p1 = ref Unsafe.Add(ref p0, 1);
		ref short p2 = ref Unsafe.Add(ref p0, 2);
		ref short p3 = ref Unsafe.Add(ref p0, 3);
		ref short p4 = ref Unsafe.Add(ref p0, 4);
		ref short p5 = ref Unsafe.Add(ref p0, 5);
		ref short p6 = ref Unsafe.Add(ref p0, 6);
		ref short p7 = ref Unsafe.Add(ref p0, 7);
		ref short p8 = ref Unsafe.Add(ref p0, 8);

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
	/// Sorts a collection of 10 elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	public static new void Sort10DescendingBranchless(ref short p0)
	{
		ref short p1 = ref Unsafe.Add(ref p0, 1);
		ref short p2 = ref Unsafe.Add(ref p0, 2);
		ref short p3 = ref Unsafe.Add(ref p0, 3);
		ref short p4 = ref Unsafe.Add(ref p0, 4);
		ref short p5 = ref Unsafe.Add(ref p0, 5);
		ref short p6 = ref Unsafe.Add(ref p0, 6);
		ref short p7 = ref Unsafe.Add(ref p0, 7);
		ref short p8 = ref Unsafe.Add(ref p0, 8);
		ref short p9 = ref Unsafe.Add(ref p0, 9);

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
	/// Sorts a collection of 11 elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	public static new void Sort11DescendingBranchless(ref short p0)
	{
		ref short p1 = ref Unsafe.Add(ref p0, 1);
		ref short p2 = ref Unsafe.Add(ref p0, 2);
		ref short p3 = ref Unsafe.Add(ref p0, 3);
		ref short p4 = ref Unsafe.Add(ref p0, 4);
		ref short p5 = ref Unsafe.Add(ref p0, 5);
		ref short p6 = ref Unsafe.Add(ref p0, 6);
		ref short p7 = ref Unsafe.Add(ref p0, 7);
		ref short p8 = ref Unsafe.Add(ref p0, 8);
		ref short p9 = ref Unsafe.Add(ref p0, 9);
		ref short p10 = ref Unsafe.Add(ref p0, 10);

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
	/// Sorts a collection of 12 elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	public static new void Sort12DescendingBranchless(ref short p0)
	{
		ref short p1 = ref Unsafe.Add(ref p0, 1);
		ref short p2 = ref Unsafe.Add(ref p0, 2);
		ref short p3 = ref Unsafe.Add(ref p0, 3);
		ref short p4 = ref Unsafe.Add(ref p0, 4);
		ref short p5 = ref Unsafe.Add(ref p0, 5);
		ref short p6 = ref Unsafe.Add(ref p0, 6);
		ref short p7 = ref Unsafe.Add(ref p0, 7);
		ref short p8 = ref Unsafe.Add(ref p0, 8);
		ref short p9 = ref Unsafe.Add(ref p0, 9);
		ref short p10 = ref Unsafe.Add(ref p0, 10);
		ref short p11 = ref Unsafe.Add(ref p0, 11);

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
	/// Sorts a collection of 13 elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	public static new void Sort13DescendingBranchless(ref short p0)
	{
		ref short p1 = ref Unsafe.Add(ref p0, 1);
		ref short p2 = ref Unsafe.Add(ref p0, 2);
		ref short p3 = ref Unsafe.Add(ref p0, 3);
		ref short p4 = ref Unsafe.Add(ref p0, 4);
		ref short p5 = ref Unsafe.Add(ref p0, 5);
		ref short p6 = ref Unsafe.Add(ref p0, 6);
		ref short p7 = ref Unsafe.Add(ref p0, 7);
		ref short p8 = ref Unsafe.Add(ref p0, 8);
		ref short p9 = ref Unsafe.Add(ref p0, 9);
		ref short p10 = ref Unsafe.Add(ref p0, 10);
		ref short p11 = ref Unsafe.Add(ref p0, 11);
		ref short p12 = ref Unsafe.Add(ref p0, 12);

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
	/// Sorts a collection of 14 elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	public static new void Sort14DescendingBranchless(ref short p0)
	{
		ref short p1 = ref Unsafe.Add(ref p0, 1);
		ref short p2 = ref Unsafe.Add(ref p0, 2);
		ref short p3 = ref Unsafe.Add(ref p0, 3);
		ref short p4 = ref Unsafe.Add(ref p0, 4);
		ref short p5 = ref Unsafe.Add(ref p0, 5);
		ref short p6 = ref Unsafe.Add(ref p0, 6);
		ref short p7 = ref Unsafe.Add(ref p0, 7);
		ref short p8 = ref Unsafe.Add(ref p0, 8);
		ref short p9 = ref Unsafe.Add(ref p0, 9);
		ref short p10 = ref Unsafe.Add(ref p0, 10);
		ref short p11 = ref Unsafe.Add(ref p0, 11);
		ref short p12 = ref Unsafe.Add(ref p0, 12);
		ref short p13 = ref Unsafe.Add(ref p0, 13);

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
	/// Sorts a collection of 15 elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	public static new void Sort15DescendingBranchless(ref short p0)
	{
		ref short p1 = ref Unsafe.Add(ref p0, 1);
		ref short p2 = ref Unsafe.Add(ref p0, 2);
		ref short p3 = ref Unsafe.Add(ref p0, 3);
		ref short p4 = ref Unsafe.Add(ref p0, 4);
		ref short p5 = ref Unsafe.Add(ref p0, 5);
		ref short p6 = ref Unsafe.Add(ref p0, 6);
		ref short p7 = ref Unsafe.Add(ref p0, 7);
		ref short p8 = ref Unsafe.Add(ref p0, 8);
		ref short p9 = ref Unsafe.Add(ref p0, 9);
		ref short p10 = ref Unsafe.Add(ref p0, 10);
		ref short p11 = ref Unsafe.Add(ref p0, 11);
		ref short p12 = ref Unsafe.Add(ref p0, 12);
		ref short p13 = ref Unsafe.Add(ref p0, 13);
		ref short p14 = ref Unsafe.Add(ref p0, 14);

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
	/// Sorts a collection of 16 elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	public static new void Sort16DescendingBranchless(ref short p0)
	{
		ref short p1 = ref Unsafe.Add(ref p0, 1);
		ref short p2 = ref Unsafe.Add(ref p0, 2);
		ref short p3 = ref Unsafe.Add(ref p0, 3);
		ref short p4 = ref Unsafe.Add(ref p0, 4);
		ref short p5 = ref Unsafe.Add(ref p0, 5);
		ref short p6 = ref Unsafe.Add(ref p0, 6);
		ref short p7 = ref Unsafe.Add(ref p0, 7);
		ref short p8 = ref Unsafe.Add(ref p0, 8);
		ref short p9 = ref Unsafe.Add(ref p0, 9);
		ref short p10 = ref Unsafe.Add(ref p0, 10);
		ref short p11 = ref Unsafe.Add(ref p0, 11);
		ref short p12 = ref Unsafe.Add(ref p0, 12);
		ref short p13 = ref Unsafe.Add(ref p0, 13);
		ref short p14 = ref Unsafe.Add(ref p0, 14);
		ref short p15 = ref Unsafe.Add(ref p0, 15);

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
	/// Sorts a collection of 9 elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	public static new void Sort9DescendingBranchless(ref uint p0)
	{
		ref uint p1 = ref Unsafe.Add(ref p0, 1);
		ref uint p2 = ref Unsafe.Add(ref p0, 2);
		ref uint p3 = ref Unsafe.Add(ref p0, 3);
		ref uint p4 = ref Unsafe.Add(ref p0, 4);
		ref uint p5 = ref Unsafe.Add(ref p0, 5);
		ref uint p6 = ref Unsafe.Add(ref p0, 6);
		ref uint p7 = ref Unsafe.Add(ref p0, 7);
		ref uint p8 = ref Unsafe.Add(ref p0, 8);

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
	/// Sorts a collection of 10 elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	public static new void Sort10DescendingBranchless(ref uint p0)
	{
		ref uint p1 = ref Unsafe.Add(ref p0, 1);
		ref uint p2 = ref Unsafe.Add(ref p0, 2);
		ref uint p3 = ref Unsafe.Add(ref p0, 3);
		ref uint p4 = ref Unsafe.Add(ref p0, 4);
		ref uint p5 = ref Unsafe.Add(ref p0, 5);
		ref uint p6 = ref Unsafe.Add(ref p0, 6);
		ref uint p7 = ref Unsafe.Add(ref p0, 7);
		ref uint p8 = ref Unsafe.Add(ref p0, 8);
		ref uint p9 = ref Unsafe.Add(ref p0, 9);

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
	/// Sorts a collection of 11 elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	public static new void Sort11DescendingBranchless(ref uint p0)
	{
		ref uint p1 = ref Unsafe.Add(ref p0, 1);
		ref uint p2 = ref Unsafe.Add(ref p0, 2);
		ref uint p3 = ref Unsafe.Add(ref p0, 3);
		ref uint p4 = ref Unsafe.Add(ref p0, 4);
		ref uint p5 = ref Unsafe.Add(ref p0, 5);
		ref uint p6 = ref Unsafe.Add(ref p0, 6);
		ref uint p7 = ref Unsafe.Add(ref p0, 7);
		ref uint p8 = ref Unsafe.Add(ref p0, 8);
		ref uint p9 = ref Unsafe.Add(ref p0, 9);
		ref uint p10 = ref Unsafe.Add(ref p0, 10);

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
	/// Sorts a collection of 12 elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	public static new void Sort12DescendingBranchless(ref uint p0)
	{
		ref uint p1 = ref Unsafe.Add(ref p0, 1);
		ref uint p2 = ref Unsafe.Add(ref p0, 2);
		ref uint p3 = ref Unsafe.Add(ref p0, 3);
		ref uint p4 = ref Unsafe.Add(ref p0, 4);
		ref uint p5 = ref Unsafe.Add(ref p0, 5);
		ref uint p6 = ref Unsafe.Add(ref p0, 6);
		ref uint p7 = ref Unsafe.Add(ref p0, 7);
		ref uint p8 = ref Unsafe.Add(ref p0, 8);
		ref uint p9 = ref Unsafe.Add(ref p0, 9);
		ref uint p10 = ref Unsafe.Add(ref p0, 10);
		ref uint p11 = ref Unsafe.Add(ref p0, 11);

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
	/// Sorts a collection of 13 elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	public static new void Sort13DescendingBranchless(ref uint p0)
	{
		ref uint p1 = ref Unsafe.Add(ref p0, 1);
		ref uint p2 = ref Unsafe.Add(ref p0, 2);
		ref uint p3 = ref Unsafe.Add(ref p0, 3);
		ref uint p4 = ref Unsafe.Add(ref p0, 4);
		ref uint p5 = ref Unsafe.Add(ref p0, 5);
		ref uint p6 = ref Unsafe.Add(ref p0, 6);
		ref uint p7 = ref Unsafe.Add(ref p0, 7);
		ref uint p8 = ref Unsafe.Add(ref p0, 8);
		ref uint p9 = ref Unsafe.Add(ref p0, 9);
		ref uint p10 = ref Unsafe.Add(ref p0, 10);
		ref uint p11 = ref Unsafe.Add(ref p0, 11);
		ref uint p12 = ref Unsafe.Add(ref p0, 12);

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
	/// Sorts a collection of 14 elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	public static new void Sort14DescendingBranchless(ref uint p0)
	{
		ref uint p1 = ref Unsafe.Add(ref p0, 1);
		ref uint p2 = ref Unsafe.Add(ref p0, 2);
		ref uint p3 = ref Unsafe.Add(ref p0, 3);
		ref uint p4 = ref Unsafe.Add(ref p0, 4);
		ref uint p5 = ref Unsafe.Add(ref p0, 5);
		ref uint p6 = ref Unsafe.Add(ref p0, 6);
		ref uint p7 = ref Unsafe.Add(ref p0, 7);
		ref uint p8 = ref Unsafe.Add(ref p0, 8);
		ref uint p9 = ref Unsafe.Add(ref p0, 9);
		ref uint p10 = ref Unsafe.Add(ref p0, 10);
		ref uint p11 = ref Unsafe.Add(ref p0, 11);
		ref uint p12 = ref Unsafe.Add(ref p0, 12);
		ref uint p13 = ref Unsafe.Add(ref p0, 13);

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
	/// Sorts a collection of 15 elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	public static new void Sort15DescendingBranchless(ref uint p0)
	{
		ref uint p1 = ref Unsafe.Add(ref p0, 1);
		ref uint p2 = ref Unsafe.Add(ref p0, 2);
		ref uint p3 = ref Unsafe.Add(ref p0, 3);
		ref uint p4 = ref Unsafe.Add(ref p0, 4);
		ref uint p5 = ref Unsafe.Add(ref p0, 5);
		ref uint p6 = ref Unsafe.Add(ref p0, 6);
		ref uint p7 = ref Unsafe.Add(ref p0, 7);
		ref uint p8 = ref Unsafe.Add(ref p0, 8);
		ref uint p9 = ref Unsafe.Add(ref p0, 9);
		ref uint p10 = ref Unsafe.Add(ref p0, 10);
		ref uint p11 = ref Unsafe.Add(ref p0, 11);
		ref uint p12 = ref Unsafe.Add(ref p0, 12);
		ref uint p13 = ref Unsafe.Add(ref p0, 13);
		ref uint p14 = ref Unsafe.Add(ref p0, 14);

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
	/// Sorts a collection of 16 elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	public static new void Sort16DescendingBranchless(ref uint p0)
	{
		ref uint p1 = ref Unsafe.Add(ref p0, 1);
		ref uint p2 = ref Unsafe.Add(ref p0, 2);
		ref uint p3 = ref Unsafe.Add(ref p0, 3);
		ref uint p4 = ref Unsafe.Add(ref p0, 4);
		ref uint p5 = ref Unsafe.Add(ref p0, 5);
		ref uint p6 = ref Unsafe.Add(ref p0, 6);
		ref uint p7 = ref Unsafe.Add(ref p0, 7);
		ref uint p8 = ref Unsafe.Add(ref p0, 8);
		ref uint p9 = ref Unsafe.Add(ref p0, 9);
		ref uint p10 = ref Unsafe.Add(ref p0, 10);
		ref uint p11 = ref Unsafe.Add(ref p0, 11);
		ref uint p12 = ref Unsafe.Add(ref p0, 12);
		ref uint p13 = ref Unsafe.Add(ref p0, 13);
		ref uint p14 = ref Unsafe.Add(ref p0, 14);
		ref uint p15 = ref Unsafe.Add(ref p0, 15);

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
	/// Sorts a collection of 9 elements in descending order using branchless min/max swap.
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
	/// Sorts a collection of 10 elements in descending order using branchless min/max swap.
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
	/// Sorts a collection of 11 elements in descending order using branchless min/max swap.
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
	/// Sorts a collection of 12 elements in descending order using branchless min/max swap.
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
	/// Sorts a collection of 13 elements in descending order using branchless min/max swap.
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
	/// Sorts a collection of 14 elements in descending order using branchless min/max swap.
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
	/// Sorts a collection of 15 elements in descending order using branchless min/max swap.
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
	/// Sorts a collection of 16 elements in descending order using branchless min/max swap.
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
	/// Sorts a collection of specified number of elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	/// <param name="length">the length of the collection</param>
	/// <exception cref="ArgumentOutOfRangeException">collection length is not between <see cref="MinLength"/> and <see cref="MaxLength"/></exception>
	public static new void SortDescendingBranchless(ref byte p0, in int length)
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

	/// <summary>
	/// Sorts a collection of specified number of elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	/// <param name="length">the length of the collection</param>
	/// <exception cref="ArgumentOutOfRangeException">collection length is not between <see cref="MinLength"/> and <see cref="MaxLength"/></exception>
	public static new void SortDescendingBranchless(ref sbyte p0, in int length)
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

	/// <summary>
	/// Sorts a collection of specified number of elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	/// <param name="length">the length of the collection</param>
	/// <exception cref="ArgumentOutOfRangeException">collection length is not between <see cref="MinLength"/> and <see cref="MaxLength"/></exception>
	public static new void SortDescendingBranchless(ref ushort p0, in int length)
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

	/// <summary>
	/// Sorts a collection of specified number of elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	/// <param name="length">the length of the collection</param>
	/// <exception cref="ArgumentOutOfRangeException">collection length is not between <see cref="MinLength"/> and <see cref="MaxLength"/></exception>
	public static new void SortDescendingBranchless(ref short p0, in int length)
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

	/// <summary>
	/// Sorts a collection of specified number of elements in descending order using branchless min/max swap.
	/// </summary>
	/// <param name="p0">the reference to the first element of the collection</param>
	/// <param name="length">the length of the collection</param>
	/// <exception cref="ArgumentOutOfRangeException">collection length is not between <see cref="MinLength"/> and <see cref="MaxLength"/></exception>
	public static new void SortDescendingBranchless(ref uint p0, in int length)
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

	/// <summary>
	/// Sorts a collection of specified number of elements in descending order using branchless min/max swap.
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