namespace SortingNetworks;

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
		ref T p1 = ref Unsafe.Add(ref p0, 1);
		ref T p2 = ref Unsafe.Add(ref p0, 2);
		ref T p3 = ref Unsafe.Add(ref p0, 3);
		ref T p4 = ref Unsafe.Add(ref p0, 4);
		ref T p5 = ref Unsafe.Add(ref p0, 5);
		ref T p6 = ref Unsafe.Add(ref p0, 6);
		ref T p7 = ref Unsafe.Add(ref p0, 7);
		ref T p8 = ref Unsafe.Add(ref p0, 8);

		T temp;
		if (GreaterThan(ref p0, ref p1)) { temp = p0; p0 = p1; p1 = temp; }
			if (GreaterThan(ref p3, ref p4)) { temp = p3; p3 = p4; p4 = temp; }
			if (GreaterThan(ref p6, ref p7)) { temp = p6; p6 = p7; p7 = temp; }
			if (GreaterThan(ref p1, ref p2)) { temp = p1; p1 = p2; p2 = temp; }
			if (GreaterThan(ref p4, ref p5)) { temp = p4; p4 = p5; p5 = temp; }
			if (GreaterThan(ref p7, ref p8)) { temp = p7; p7 = p8; p8 = temp; }
			if (GreaterThan(ref p0, ref p1)) { temp = p0; p0 = p1; p1 = temp; }
			if (GreaterThan(ref p3, ref p4)) { temp = p3; p3 = p4; p4 = temp; }
			if (GreaterThan(ref p6, ref p7)) { temp = p6; p6 = p7; p7 = temp; }
			if (GreaterThan(ref p2, ref p5)) { temp = p2; p2 = p5; p5 = temp; }
			if (GreaterThan(ref p0, ref p3)) { temp = p0; p0 = p3; p3 = temp; }
			if (GreaterThan(ref p1, ref p4)) { temp = p1; p1 = p4; p4 = temp; }
			if (GreaterThan(ref p5, ref p8)) { temp = p5; p5 = p8; p8 = temp; }
			if (GreaterThan(ref p3, ref p6)) { temp = p3; p3 = p6; p6 = temp; }
			if (GreaterThan(ref p4, ref p7)) { temp = p4; p4 = p7; p7 = temp; }
			if (GreaterThan(ref p2, ref p5)) { temp = p2; p2 = p5; p5 = temp; }
			if (GreaterThan(ref p0, ref p3)) { temp = p0; p0 = p3; p3 = temp; }
			if (GreaterThan(ref p1, ref p4)) { temp = p1; p1 = p4; p4 = temp; }
			if (GreaterThan(ref p5, ref p7)) { temp = p5; p5 = p7; p7 = temp; }
			if (GreaterThan(ref p2, ref p6)) { temp = p2; p2 = p6; p6 = temp; }
			if (GreaterThan(ref p1, ref p3)) { temp = p1; p1 = p3; p3 = temp; }
			if (GreaterThan(ref p4, ref p6)) { temp = p4; p4 = p6; p6 = temp; }
			if (GreaterThan(ref p2, ref p4)) { temp = p2; p2 = p4; p4 = temp; }
			if (GreaterThan(ref p5, ref p6)) { temp = p5; p5 = p6; p6 = temp; }
			if (GreaterThan(ref p2, ref p3)) { temp = p2; p2 = p3; p3 = temp; }
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
		ref T p1 = ref Unsafe.Add(ref p0, 1);
		ref T p2 = ref Unsafe.Add(ref p0, 2);
		ref T p3 = ref Unsafe.Add(ref p0, 3);
		ref T p4 = ref Unsafe.Add(ref p0, 4);
		ref T p5 = ref Unsafe.Add(ref p0, 5);
		ref T p6 = ref Unsafe.Add(ref p0, 6);
		ref T p7 = ref Unsafe.Add(ref p0, 7);
		ref T p8 = ref Unsafe.Add(ref p0, 8);
		ref T p9 = ref Unsafe.Add(ref p0, 9);

		T temp;
		if (GreaterThan(ref p4, ref p9)) { temp = p4; p4 = p9; p9 = temp; }
			if (GreaterThan(ref p3, ref p8)) { temp = p3; p3 = p8; p8 = temp; }
			if (GreaterThan(ref p2, ref p7)) { temp = p2; p2 = p7; p7 = temp; }
			if (GreaterThan(ref p1, ref p6)) { temp = p1; p1 = p6; p6 = temp; }
			if (GreaterThan(ref p0, ref p5)) { temp = p0; p0 = p5; p5 = temp; }
			if (GreaterThan(ref p1, ref p4)) { temp = p1; p1 = p4; p4 = temp; }
			if (GreaterThan(ref p6, ref p9)) { temp = p6; p6 = p9; p9 = temp; }
			if (GreaterThan(ref p0, ref p3)) { temp = p0; p0 = p3; p3 = temp; }
			if (GreaterThan(ref p5, ref p8)) { temp = p5; p5 = p8; p8 = temp; }
			if (GreaterThan(ref p0, ref p2)) { temp = p0; p0 = p2; p2 = temp; }
			if (GreaterThan(ref p3, ref p6)) { temp = p3; p3 = p6; p6 = temp; }
			if (GreaterThan(ref p7, ref p9)) { temp = p7; p7 = p9; p9 = temp; }
			if (GreaterThan(ref p0, ref p1)) { temp = p0; p0 = p1; p1 = temp; }
			if (GreaterThan(ref p2, ref p4)) { temp = p2; p2 = p4; p4 = temp; }
			if (GreaterThan(ref p5, ref p7)) { temp = p5; p5 = p7; p7 = temp; }
			if (GreaterThan(ref p8, ref p9)) { temp = p8; p8 = p9; p9 = temp; }
			if (GreaterThan(ref p1, ref p2)) { temp = p1; p1 = p2; p2 = temp; }
			if (GreaterThan(ref p4, ref p6)) { temp = p4; p4 = p6; p6 = temp; }
			if (GreaterThan(ref p7, ref p8)) { temp = p7; p7 = p8; p8 = temp; }
			if (GreaterThan(ref p3, ref p5)) { temp = p3; p3 = p5; p5 = temp; }
			if (GreaterThan(ref p2, ref p5)) { temp = p2; p2 = p5; p5 = temp; }
			if (GreaterThan(ref p6, ref p8)) { temp = p6; p6 = p8; p8 = temp; }
			if (GreaterThan(ref p1, ref p3)) { temp = p1; p1 = p3; p3 = temp; }
			if (GreaterThan(ref p4, ref p7)) { temp = p4; p4 = p7; p7 = temp; }
			if (GreaterThan(ref p2, ref p3)) { temp = p2; p2 = p3; p3 = temp; }
			if (GreaterThan(ref p6, ref p7)) { temp = p6; p6 = p7; p7 = temp; }
			if (GreaterThan(ref p3, ref p4)) { temp = p3; p3 = p4; p4 = temp; }
			if (GreaterThan(ref p5, ref p6)) { temp = p5; p5 = p6; p6 = temp; }
			if (GreaterThan(ref p4, ref p5)) { temp = p4; p4 = p5; p5 = temp; }
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
		ref T p1 = ref Unsafe.Add(ref p0, 1);
		ref T p2 = ref Unsafe.Add(ref p0, 2);
		ref T p3 = ref Unsafe.Add(ref p0, 3);
		ref T p4 = ref Unsafe.Add(ref p0, 4);
		ref T p5 = ref Unsafe.Add(ref p0, 5);
		ref T p6 = ref Unsafe.Add(ref p0, 6);
		ref T p7 = ref Unsafe.Add(ref p0, 7);
		ref T p8 = ref Unsafe.Add(ref p0, 8);
		ref T p9 = ref Unsafe.Add(ref p0, 9);
		ref T p10 = ref Unsafe.Add(ref p0, 10);

		T temp;
		if (GreaterThan(ref p0, ref p1)) { temp = p0; p0 = p1; p1 = temp; }
			if (GreaterThan(ref p2, ref p3)) { temp = p2; p2 = p3; p3 = temp; }
			if (GreaterThan(ref p4, ref p5)) { temp = p4; p4 = p5; p5 = temp; }
			if (GreaterThan(ref p6, ref p7)) { temp = p6; p6 = p7; p7 = temp; }
			if (GreaterThan(ref p8, ref p9)) { temp = p8; p8 = p9; p9 = temp; }
			if (GreaterThan(ref p1, ref p3)) { temp = p1; p1 = p3; p3 = temp; }
			if (GreaterThan(ref p5, ref p7)) { temp = p5; p5 = p7; p7 = temp; }
			if (GreaterThan(ref p0, ref p2)) { temp = p0; p0 = p2; p2 = temp; }
			if (GreaterThan(ref p4, ref p6)) { temp = p4; p4 = p6; p6 = temp; }
			if (GreaterThan(ref p8, ref p10)) { temp = p8; p8 = p10; p10 = temp; }
			if (GreaterThan(ref p1, ref p2)) { temp = p1; p1 = p2; p2 = temp; }
			if (GreaterThan(ref p5, ref p6)) { temp = p5; p5 = p6; p6 = temp; }
			if (GreaterThan(ref p9, ref p10)) { temp = p9; p9 = p10; p10 = temp; }
			if (GreaterThan(ref p0, ref p4)) { temp = p0; p0 = p4; p4 = temp; }
			if (GreaterThan(ref p3, ref p7)) { temp = p3; p3 = p7; p7 = temp; }
			if (GreaterThan(ref p1, ref p5)) { temp = p1; p1 = p5; p5 = temp; }
			if (GreaterThan(ref p6, ref p10)) { temp = p6; p6 = p10; p10 = temp; }
			if (GreaterThan(ref p4, ref p8)) { temp = p4; p4 = p8; p8 = temp; }
			if (GreaterThan(ref p5, ref p9)) { temp = p5; p5 = p9; p9 = temp; }
			if (GreaterThan(ref p2, ref p6)) { temp = p2; p2 = p6; p6 = temp; }
			if (GreaterThan(ref p0, ref p4)) { temp = p0; p0 = p4; p4 = temp; }
			if (GreaterThan(ref p3, ref p8)) { temp = p3; p3 = p8; p8 = temp; }
			if (GreaterThan(ref p1, ref p5)) { temp = p1; p1 = p5; p5 = temp; }
			if (GreaterThan(ref p6, ref p10)) { temp = p6; p6 = p10; p10 = temp; }
			if (GreaterThan(ref p2, ref p3)) { temp = p2; p2 = p3; p3 = temp; }
			if (GreaterThan(ref p8, ref p9)) { temp = p8; p8 = p9; p9 = temp; }
			if (GreaterThan(ref p1, ref p4)) { temp = p1; p1 = p4; p4 = temp; }
			if (GreaterThan(ref p7, ref p10)) { temp = p7; p7 = p10; p10 = temp; }
			if (GreaterThan(ref p3, ref p5)) { temp = p3; p3 = p5; p5 = temp; }
			if (GreaterThan(ref p6, ref p8)) { temp = p6; p6 = p8; p8 = temp; }
			if (GreaterThan(ref p2, ref p4)) { temp = p2; p2 = p4; p4 = temp; }
			if (GreaterThan(ref p7, ref p9)) { temp = p7; p7 = p9; p9 = temp; }
			if (GreaterThan(ref p5, ref p6)) { temp = p5; p5 = p6; p6 = temp; }
			if (GreaterThan(ref p3, ref p4)) { temp = p3; p3 = p4; p4 = temp; }
			if (GreaterThan(ref p7, ref p8)) { temp = p7; p7 = p8; p8 = temp; }
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
		ref T p1 = ref Unsafe.Add(ref p0, 1);
		ref T p2 = ref Unsafe.Add(ref p0, 2);
		ref T p3 = ref Unsafe.Add(ref p0, 3);
		ref T p4 = ref Unsafe.Add(ref p0, 4);
		ref T p5 = ref Unsafe.Add(ref p0, 5);
		ref T p6 = ref Unsafe.Add(ref p0, 6);
		ref T p7 = ref Unsafe.Add(ref p0, 7);
		ref T p8 = ref Unsafe.Add(ref p0, 8);
		ref T p9 = ref Unsafe.Add(ref p0, 9);
		ref T p10 = ref Unsafe.Add(ref p0, 10);
		ref T p11 = ref Unsafe.Add(ref p0, 11);

		T temp;
		if (GreaterThan(ref p0, ref p1)) { temp = p0; p0 = p1; p1 = temp; }
			if (GreaterThan(ref p2, ref p3)) { temp = p2; p2 = p3; p3 = temp; }
			if (GreaterThan(ref p4, ref p5)) { temp = p4; p4 = p5; p5 = temp; }
			if (GreaterThan(ref p6, ref p7)) { temp = p6; p6 = p7; p7 = temp; }
			if (GreaterThan(ref p8, ref p9)) { temp = p8; p8 = p9; p9 = temp; }
			if (GreaterThan(ref p10, ref p11)) { temp = p10; p10 = p11; p11 = temp; }
			if (GreaterThan(ref p1, ref p3)) { temp = p1; p1 = p3; p3 = temp; }
			if (GreaterThan(ref p5, ref p7)) { temp = p5; p5 = p7; p7 = temp; }
			if (GreaterThan(ref p9, ref p11)) { temp = p9; p9 = p11; p11 = temp; }
			if (GreaterThan(ref p0, ref p2)) { temp = p0; p0 = p2; p2 = temp; }
			if (GreaterThan(ref p4, ref p6)) { temp = p4; p4 = p6; p6 = temp; }
			if (GreaterThan(ref p8, ref p10)) { temp = p8; p8 = p10; p10 = temp; }
			if (GreaterThan(ref p1, ref p2)) { temp = p1; p1 = p2; p2 = temp; }
			if (GreaterThan(ref p5, ref p6)) { temp = p5; p5 = p6; p6 = temp; }
			if (GreaterThan(ref p9, ref p10)) { temp = p9; p9 = p10; p10 = temp; }
			if (GreaterThan(ref p0, ref p4)) { temp = p0; p0 = p4; p4 = temp; }
			if (GreaterThan(ref p7, ref p11)) { temp = p7; p7 = p11; p11 = temp; }
			if (GreaterThan(ref p1, ref p5)) { temp = p1; p1 = p5; p5 = temp; }
			if (GreaterThan(ref p6, ref p10)) { temp = p6; p6 = p10; p10 = temp; }
			if (GreaterThan(ref p3, ref p7)) { temp = p3; p3 = p7; p7 = temp; }
			if (GreaterThan(ref p4, ref p8)) { temp = p4; p4 = p8; p8 = temp; }
			if (GreaterThan(ref p5, ref p9)) { temp = p5; p5 = p9; p9 = temp; }
			if (GreaterThan(ref p2, ref p6)) { temp = p2; p2 = p6; p6 = temp; }
			if (GreaterThan(ref p0, ref p4)) { temp = p0; p0 = p4; p4 = temp; }
			if (GreaterThan(ref p7, ref p11)) { temp = p7; p7 = p11; p11 = temp; }
			if (GreaterThan(ref p3, ref p8)) { temp = p3; p3 = p8; p8 = temp; }
			if (GreaterThan(ref p1, ref p5)) { temp = p1; p1 = p5; p5 = temp; }
			if (GreaterThan(ref p6, ref p10)) { temp = p6; p6 = p10; p10 = temp; }
			if (GreaterThan(ref p2, ref p3)) { temp = p2; p2 = p3; p3 = temp; }
			if (GreaterThan(ref p8, ref p9)) { temp = p8; p8 = p9; p9 = temp; }
			if (GreaterThan(ref p1, ref p4)) { temp = p1; p1 = p4; p4 = temp; }
			if (GreaterThan(ref p7, ref p10)) { temp = p7; p7 = p10; p10 = temp; }
			if (GreaterThan(ref p3, ref p5)) { temp = p3; p3 = p5; p5 = temp; }
			if (GreaterThan(ref p6, ref p8)) { temp = p6; p6 = p8; p8 = temp; }
			if (GreaterThan(ref p2, ref p4)) { temp = p2; p2 = p4; p4 = temp; }
			if (GreaterThan(ref p7, ref p9)) { temp = p7; p7 = p9; p9 = temp; }
			if (GreaterThan(ref p5, ref p6)) { temp = p5; p5 = p6; p6 = temp; }
			if (GreaterThan(ref p3, ref p4)) { temp = p3; p3 = p4; p4 = temp; }
			if (GreaterThan(ref p7, ref p8)) { temp = p7; p7 = p8; p8 = temp; }
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
		ref T p1 = ref Unsafe.Add(ref p0, 1);
		ref T p2 = ref Unsafe.Add(ref p0, 2);
		ref T p3 = ref Unsafe.Add(ref p0, 3);
		ref T p4 = ref Unsafe.Add(ref p0, 4);
		ref T p5 = ref Unsafe.Add(ref p0, 5);
		ref T p6 = ref Unsafe.Add(ref p0, 6);
		ref T p7 = ref Unsafe.Add(ref p0, 7);
		ref T p8 = ref Unsafe.Add(ref p0, 8);
		ref T p9 = ref Unsafe.Add(ref p0, 9);
		ref T p10 = ref Unsafe.Add(ref p0, 10);
		ref T p11 = ref Unsafe.Add(ref p0, 11);
		ref T p12 = ref Unsafe.Add(ref p0, 12);

		T temp;
		if (GreaterThan(ref p1, ref p7)) { temp = p1; p1 = p7; p7 = temp; }
			if (GreaterThan(ref p9, ref p11)) { temp = p9; p9 = p11; p11 = temp; }
			if (GreaterThan(ref p3, ref p4)) { temp = p3; p3 = p4; p4 = temp; }
			if (GreaterThan(ref p5, ref p8)) { temp = p5; p5 = p8; p8 = temp; }
			if (GreaterThan(ref p0, ref p12)) { temp = p0; p0 = p12; p12 = temp; }
			if (GreaterThan(ref p2, ref p6)) { temp = p2; p2 = p6; p6 = temp; }
			if (GreaterThan(ref p0, ref p1)) { temp = p0; p0 = p1; p1 = temp; }
			if (GreaterThan(ref p2, ref p3)) { temp = p2; p2 = p3; p3 = temp; }
			if (GreaterThan(ref p4, ref p6)) { temp = p4; p4 = p6; p6 = temp; }
			if (GreaterThan(ref p8, ref p11)) { temp = p8; p8 = p11; p11 = temp; }
			if (GreaterThan(ref p7, ref p12)) { temp = p7; p7 = p12; p12 = temp; }
			if (GreaterThan(ref p5, ref p9)) { temp = p5; p5 = p9; p9 = temp; }
			if (GreaterThan(ref p0, ref p2)) { temp = p0; p0 = p2; p2 = temp; }
			if (GreaterThan(ref p3, ref p7)) { temp = p3; p3 = p7; p7 = temp; }
			if (GreaterThan(ref p10, ref p11)) { temp = p10; p10 = p11; p11 = temp; }
			if (GreaterThan(ref p1, ref p4)) { temp = p1; p1 = p4; p4 = temp; }
			if (GreaterThan(ref p6, ref p12)) { temp = p6; p6 = p12; p12 = temp; }
			if (GreaterThan(ref p7, ref p8)) { temp = p7; p7 = p8; p8 = temp; }
			if (GreaterThan(ref p11, ref p12)) { temp = p11; p11 = p12; p12 = temp; }
			if (GreaterThan(ref p4, ref p9)) { temp = p4; p4 = p9; p9 = temp; }
			if (GreaterThan(ref p6, ref p10)) { temp = p6; p6 = p10; p10 = temp; }
			if (GreaterThan(ref p3, ref p4)) { temp = p3; p3 = p4; p4 = temp; }
			if (GreaterThan(ref p5, ref p6)) { temp = p5; p5 = p6; p6 = temp; }
			if (GreaterThan(ref p8, ref p9)) { temp = p8; p8 = p9; p9 = temp; }
			if (GreaterThan(ref p10, ref p11)) { temp = p10; p10 = p11; p11 = temp; }
			if (GreaterThan(ref p1, ref p7)) { temp = p1; p1 = p7; p7 = temp; }
			if (GreaterThan(ref p2, ref p6)) { temp = p2; p2 = p6; p6 = temp; }
			if (GreaterThan(ref p9, ref p11)) { temp = p9; p9 = p11; p11 = temp; }
			if (GreaterThan(ref p1, ref p3)) { temp = p1; p1 = p3; p3 = temp; }
			if (GreaterThan(ref p4, ref p7)) { temp = p4; p4 = p7; p7 = temp; }
			if (GreaterThan(ref p8, ref p10)) { temp = p8; p8 = p10; p10 = temp; }
			if (GreaterThan(ref p0, ref p5)) { temp = p0; p0 = p5; p5 = temp; }
			if (GreaterThan(ref p2, ref p5)) { temp = p2; p2 = p5; p5 = temp; }
			if (GreaterThan(ref p6, ref p8)) { temp = p6; p6 = p8; p8 = temp; }
			if (GreaterThan(ref p9, ref p10)) { temp = p9; p9 = p10; p10 = temp; }
			if (GreaterThan(ref p1, ref p2)) { temp = p1; p1 = p2; p2 = temp; }
			if (GreaterThan(ref p3, ref p5)) { temp = p3; p3 = p5; p5 = temp; }
			if (GreaterThan(ref p7, ref p8)) { temp = p7; p7 = p8; p8 = temp; }
			if (GreaterThan(ref p4, ref p6)) { temp = p4; p4 = p6; p6 = temp; }
			if (GreaterThan(ref p2, ref p3)) { temp = p2; p2 = p3; p3 = temp; }
			if (GreaterThan(ref p4, ref p5)) { temp = p4; p4 = p5; p5 = temp; }
			if (GreaterThan(ref p6, ref p7)) { temp = p6; p6 = p7; p7 = temp; }
			if (GreaterThan(ref p8, ref p9)) { temp = p8; p8 = p9; p9 = temp; }
			if (GreaterThan(ref p3, ref p4)) { temp = p3; p3 = p4; p4 = temp; }
			if (GreaterThan(ref p5, ref p6)) { temp = p5; p5 = p6; p6 = temp; }
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
		ref T p1 = ref Unsafe.Add(ref p0, 1);
		ref T p2 = ref Unsafe.Add(ref p0, 2);
		ref T p3 = ref Unsafe.Add(ref p0, 3);
		ref T p4 = ref Unsafe.Add(ref p0, 4);
		ref T p5 = ref Unsafe.Add(ref p0, 5);
		ref T p6 = ref Unsafe.Add(ref p0, 6);
		ref T p7 = ref Unsafe.Add(ref p0, 7);
		ref T p8 = ref Unsafe.Add(ref p0, 8);
		ref T p9 = ref Unsafe.Add(ref p0, 9);
		ref T p10 = ref Unsafe.Add(ref p0, 10);
		ref T p11 = ref Unsafe.Add(ref p0, 11);
		ref T p12 = ref Unsafe.Add(ref p0, 12);
		ref T p13 = ref Unsafe.Add(ref p0, 13);

		T temp;
		if (GreaterThan(ref p0, ref p1)) { temp = p0; p0 = p1; p1 = temp; }
			if (GreaterThan(ref p2, ref p3)) { temp = p2; p2 = p3; p3 = temp; }
			if (GreaterThan(ref p4, ref p5)) { temp = p4; p4 = p5; p5 = temp; }
			if (GreaterThan(ref p6, ref p7)) { temp = p6; p6 = p7; p7 = temp; }
			if (GreaterThan(ref p8, ref p9)) { temp = p8; p8 = p9; p9 = temp; }
			if (GreaterThan(ref p10, ref p11)) { temp = p10; p10 = p11; p11 = temp; }
			if (GreaterThan(ref p12, ref p13)) { temp = p12; p12 = p13; p13 = temp; }
			if (GreaterThan(ref p0, ref p2)) { temp = p0; p0 = p2; p2 = temp; }
			if (GreaterThan(ref p4, ref p6)) { temp = p4; p4 = p6; p6 = temp; }
			if (GreaterThan(ref p8, ref p10)) { temp = p8; p8 = p10; p10 = temp; }
			if (GreaterThan(ref p1, ref p3)) { temp = p1; p1 = p3; p3 = temp; }
			if (GreaterThan(ref p5, ref p7)) { temp = p5; p5 = p7; p7 = temp; }
			if (GreaterThan(ref p9, ref p11)) { temp = p9; p9 = p11; p11 = temp; }
			if (GreaterThan(ref p0, ref p4)) { temp = p0; p0 = p4; p4 = temp; }
			if (GreaterThan(ref p8, ref p12)) { temp = p8; p8 = p12; p12 = temp; }
			if (GreaterThan(ref p1, ref p5)) { temp = p1; p1 = p5; p5 = temp; }
			if (GreaterThan(ref p9, ref p13)) { temp = p9; p9 = p13; p13 = temp; }
			if (GreaterThan(ref p2, ref p6)) { temp = p2; p2 = p6; p6 = temp; }
			if (GreaterThan(ref p3, ref p7)) { temp = p3; p3 = p7; p7 = temp; }
			if (GreaterThan(ref p0, ref p8)) { temp = p0; p0 = p8; p8 = temp; }
			if (GreaterThan(ref p1, ref p9)) { temp = p1; p1 = p9; p9 = temp; }
			if (GreaterThan(ref p2, ref p10)) { temp = p2; p2 = p10; p10 = temp; }
			if (GreaterThan(ref p3, ref p11)) { temp = p3; p3 = p11; p11 = temp; }
			if (GreaterThan(ref p4, ref p12)) { temp = p4; p4 = p12; p12 = temp; }
			if (GreaterThan(ref p5, ref p13)) { temp = p5; p5 = p13; p13 = temp; }
			if (GreaterThan(ref p5, ref p10)) { temp = p5; p5 = p10; p10 = temp; }
			if (GreaterThan(ref p6, ref p9)) { temp = p6; p6 = p9; p9 = temp; }
			if (GreaterThan(ref p3, ref p12)) { temp = p3; p3 = p12; p12 = temp; }
			if (GreaterThan(ref p7, ref p11)) { temp = p7; p7 = p11; p11 = temp; }
			if (GreaterThan(ref p1, ref p2)) { temp = p1; p1 = p2; p2 = temp; }
			if (GreaterThan(ref p4, ref p8)) { temp = p4; p4 = p8; p8 = temp; }
			if (GreaterThan(ref p1, ref p4)) { temp = p1; p1 = p4; p4 = temp; }
			if (GreaterThan(ref p7, ref p13)) { temp = p7; p7 = p13; p13 = temp; }
			if (GreaterThan(ref p2, ref p8)) { temp = p2; p2 = p8; p8 = temp; }
			if (GreaterThan(ref p5, ref p6)) { temp = p5; p5 = p6; p6 = temp; }
			if (GreaterThan(ref p9, ref p10)) { temp = p9; p9 = p10; p10 = temp; }
			if (GreaterThan(ref p2, ref p4)) { temp = p2; p2 = p4; p4 = temp; }
			if (GreaterThan(ref p11, ref p13)) { temp = p11; p11 = p13; p13 = temp; }
			if (GreaterThan(ref p3, ref p8)) { temp = p3; p3 = p8; p8 = temp; }
			if (GreaterThan(ref p7, ref p12)) { temp = p7; p7 = p12; p12 = temp; }
			if (GreaterThan(ref p6, ref p8)) { temp = p6; p6 = p8; p8 = temp; }
			if (GreaterThan(ref p10, ref p12)) { temp = p10; p10 = p12; p12 = temp; }
			if (GreaterThan(ref p3, ref p5)) { temp = p3; p3 = p5; p5 = temp; }
			if (GreaterThan(ref p7, ref p9)) { temp = p7; p7 = p9; p9 = temp; }
			if (GreaterThan(ref p3, ref p4)) { temp = p3; p3 = p4; p4 = temp; }
			if (GreaterThan(ref p5, ref p6)) { temp = p5; p5 = p6; p6 = temp; }
			if (GreaterThan(ref p7, ref p8)) { temp = p7; p7 = p8; p8 = temp; }
			if (GreaterThan(ref p9, ref p10)) { temp = p9; p9 = p10; p10 = temp; }
			if (GreaterThan(ref p11, ref p12)) { temp = p11; p11 = p12; p12 = temp; }
			if (GreaterThan(ref p6, ref p7)) { temp = p6; p6 = p7; p7 = temp; }
			if (GreaterThan(ref p8, ref p9)) { temp = p8; p8 = p9; p9 = temp; }
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
		ref T p1 = ref Unsafe.Add(ref p0, 1);
		ref T p2 = ref Unsafe.Add(ref p0, 2);
		ref T p3 = ref Unsafe.Add(ref p0, 3);
		ref T p4 = ref Unsafe.Add(ref p0, 4);
		ref T p5 = ref Unsafe.Add(ref p0, 5);
		ref T p6 = ref Unsafe.Add(ref p0, 6);
		ref T p7 = ref Unsafe.Add(ref p0, 7);
		ref T p8 = ref Unsafe.Add(ref p0, 8);
		ref T p9 = ref Unsafe.Add(ref p0, 9);
		ref T p10 = ref Unsafe.Add(ref p0, 10);
		ref T p11 = ref Unsafe.Add(ref p0, 11);
		ref T p12 = ref Unsafe.Add(ref p0, 12);
		ref T p13 = ref Unsafe.Add(ref p0, 13);
		ref T p14 = ref Unsafe.Add(ref p0, 14);

		T temp;
		if (GreaterThan(ref p0, ref p1)) { temp = p0; p0 = p1; p1 = temp; }
			if (GreaterThan(ref p2, ref p3)) { temp = p2; p2 = p3; p3 = temp; }
			if (GreaterThan(ref p4, ref p5)) { temp = p4; p4 = p5; p5 = temp; }
			if (GreaterThan(ref p6, ref p7)) { temp = p6; p6 = p7; p7 = temp; }
			if (GreaterThan(ref p8, ref p9)) { temp = p8; p8 = p9; p9 = temp; }
			if (GreaterThan(ref p10, ref p11)) { temp = p10; p10 = p11; p11 = temp; }
			if (GreaterThan(ref p12, ref p13)) { temp = p12; p12 = p13; p13 = temp; }
			if (GreaterThan(ref p0, ref p2)) { temp = p0; p0 = p2; p2 = temp; }
			if (GreaterThan(ref p4, ref p6)) { temp = p4; p4 = p6; p6 = temp; }
			if (GreaterThan(ref p8, ref p10)) { temp = p8; p8 = p10; p10 = temp; }
			if (GreaterThan(ref p12, ref p14)) { temp = p12; p12 = p14; p14 = temp; }
			if (GreaterThan(ref p1, ref p3)) { temp = p1; p1 = p3; p3 = temp; }
			if (GreaterThan(ref p5, ref p7)) { temp = p5; p5 = p7; p7 = temp; }
			if (GreaterThan(ref p9, ref p11)) { temp = p9; p9 = p11; p11 = temp; }
			if (GreaterThan(ref p0, ref p4)) { temp = p0; p0 = p4; p4 = temp; }
			if (GreaterThan(ref p8, ref p12)) { temp = p8; p8 = p12; p12 = temp; }
			if (GreaterThan(ref p1, ref p5)) { temp = p1; p1 = p5; p5 = temp; }
			if (GreaterThan(ref p9, ref p13)) { temp = p9; p9 = p13; p13 = temp; }
			if (GreaterThan(ref p2, ref p6)) { temp = p2; p2 = p6; p6 = temp; }
			if (GreaterThan(ref p10, ref p14)) { temp = p10; p10 = p14; p14 = temp; }
			if (GreaterThan(ref p3, ref p7)) { temp = p3; p3 = p7; p7 = temp; }
			if (GreaterThan(ref p0, ref p8)) { temp = p0; p0 = p8; p8 = temp; }
			if (GreaterThan(ref p1, ref p9)) { temp = p1; p1 = p9; p9 = temp; }
			if (GreaterThan(ref p2, ref p10)) { temp = p2; p2 = p10; p10 = temp; }
			if (GreaterThan(ref p3, ref p11)) { temp = p3; p3 = p11; p11 = temp; }
			if (GreaterThan(ref p4, ref p12)) { temp = p4; p4 = p12; p12 = temp; }
			if (GreaterThan(ref p5, ref p13)) { temp = p5; p5 = p13; p13 = temp; }
			if (GreaterThan(ref p6, ref p14)) { temp = p6; p6 = p14; p14 = temp; }
			if (GreaterThan(ref p5, ref p10)) { temp = p5; p5 = p10; p10 = temp; }
			if (GreaterThan(ref p6, ref p9)) { temp = p6; p6 = p9; p9 = temp; }
			if (GreaterThan(ref p3, ref p12)) { temp = p3; p3 = p12; p12 = temp; }
			if (GreaterThan(ref p13, ref p14)) { temp = p13; p13 = p14; p14 = temp; }
			if (GreaterThan(ref p7, ref p11)) { temp = p7; p7 = p11; p11 = temp; }
			if (GreaterThan(ref p1, ref p2)) { temp = p1; p1 = p2; p2 = temp; }
			if (GreaterThan(ref p4, ref p8)) { temp = p4; p4 = p8; p8 = temp; }
			if (GreaterThan(ref p1, ref p4)) { temp = p1; p1 = p4; p4 = temp; }
			if (GreaterThan(ref p7, ref p13)) { temp = p7; p7 = p13; p13 = temp; }
			if (GreaterThan(ref p2, ref p8)) { temp = p2; p2 = p8; p8 = temp; }
			if (GreaterThan(ref p11, ref p14)) { temp = p11; p11 = p14; p14 = temp; }
			if (GreaterThan(ref p5, ref p6)) { temp = p5; p5 = p6; p6 = temp; }
			if (GreaterThan(ref p9, ref p10)) { temp = p9; p9 = p10; p10 = temp; }
			if (GreaterThan(ref p2, ref p4)) { temp = p2; p2 = p4; p4 = temp; }
			if (GreaterThan(ref p11, ref p13)) { temp = p11; p11 = p13; p13 = temp; }
			if (GreaterThan(ref p3, ref p8)) { temp = p3; p3 = p8; p8 = temp; }
			if (GreaterThan(ref p7, ref p12)) { temp = p7; p7 = p12; p12 = temp; }
			if (GreaterThan(ref p6, ref p8)) { temp = p6; p6 = p8; p8 = temp; }
			if (GreaterThan(ref p10, ref p12)) { temp = p10; p10 = p12; p12 = temp; }
			if (GreaterThan(ref p3, ref p5)) { temp = p3; p3 = p5; p5 = temp; }
			if (GreaterThan(ref p7, ref p9)) { temp = p7; p7 = p9; p9 = temp; }
			if (GreaterThan(ref p3, ref p4)) { temp = p3; p3 = p4; p4 = temp; }
			if (GreaterThan(ref p5, ref p6)) { temp = p5; p5 = p6; p6 = temp; }
			if (GreaterThan(ref p7, ref p8)) { temp = p7; p7 = p8; p8 = temp; }
			if (GreaterThan(ref p9, ref p10)) { temp = p9; p9 = p10; p10 = temp; }
			if (GreaterThan(ref p11, ref p12)) { temp = p11; p11 = p12; p12 = temp; }
			if (GreaterThan(ref p6, ref p7)) { temp = p6; p6 = p7; p7 = temp; }
			if (GreaterThan(ref p8, ref p9)) { temp = p8; p8 = p9; p9 = temp; }
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
		ref T p1 = ref Unsafe.Add(ref p0, 1);
		ref T p2 = ref Unsafe.Add(ref p0, 2);
		ref T p3 = ref Unsafe.Add(ref p0, 3);
		ref T p4 = ref Unsafe.Add(ref p0, 4);
		ref T p5 = ref Unsafe.Add(ref p0, 5);
		ref T p6 = ref Unsafe.Add(ref p0, 6);
		ref T p7 = ref Unsafe.Add(ref p0, 7);
		ref T p8 = ref Unsafe.Add(ref p0, 8);
		ref T p9 = ref Unsafe.Add(ref p0, 9);
		ref T p10 = ref Unsafe.Add(ref p0, 10);
		ref T p11 = ref Unsafe.Add(ref p0, 11);
		ref T p12 = ref Unsafe.Add(ref p0, 12);
		ref T p13 = ref Unsafe.Add(ref p0, 13);
		ref T p14 = ref Unsafe.Add(ref p0, 14);
		ref T p15 = ref Unsafe.Add(ref p0, 15);

		T temp;
		if (GreaterThan(ref p0, ref p1)) { temp = p0; p0 = p1; p1 = temp; }
			if (GreaterThan(ref p2, ref p3)) { temp = p2; p2 = p3; p3 = temp; }
			if (GreaterThan(ref p4, ref p5)) { temp = p4; p4 = p5; p5 = temp; }
			if (GreaterThan(ref p6, ref p7)) { temp = p6; p6 = p7; p7 = temp; }
			if (GreaterThan(ref p8, ref p9)) { temp = p8; p8 = p9; p9 = temp; }
			if (GreaterThan(ref p10, ref p11)) { temp = p10; p10 = p11; p11 = temp; }
			if (GreaterThan(ref p12, ref p13)) { temp = p12; p12 = p13; p13 = temp; }
			if (GreaterThan(ref p14, ref p15)) { temp = p14; p14 = p15; p15 = temp; }
			if (GreaterThan(ref p0, ref p2)) { temp = p0; p0 = p2; p2 = temp; }
			if (GreaterThan(ref p4, ref p6)) { temp = p4; p4 = p6; p6 = temp; }
			if (GreaterThan(ref p8, ref p10)) { temp = p8; p8 = p10; p10 = temp; }
			if (GreaterThan(ref p12, ref p14)) { temp = p12; p12 = p14; p14 = temp; }
			if (GreaterThan(ref p1, ref p3)) { temp = p1; p1 = p3; p3 = temp; }
			if (GreaterThan(ref p5, ref p7)) { temp = p5; p5 = p7; p7 = temp; }
			if (GreaterThan(ref p9, ref p11)) { temp = p9; p9 = p11; p11 = temp; }
			if (GreaterThan(ref p13, ref p15)) { temp = p13; p13 = p15; p15 = temp; }
			if (GreaterThan(ref p0, ref p4)) { temp = p0; p0 = p4; p4 = temp; }
			if (GreaterThan(ref p8, ref p12)) { temp = p8; p8 = p12; p12 = temp; }
			if (GreaterThan(ref p1, ref p5)) { temp = p1; p1 = p5; p5 = temp; }
			if (GreaterThan(ref p9, ref p13)) { temp = p9; p9 = p13; p13 = temp; }
			if (GreaterThan(ref p2, ref p6)) { temp = p2; p2 = p6; p6 = temp; }
			if (GreaterThan(ref p10, ref p14)) { temp = p10; p10 = p14; p14 = temp; }
			if (GreaterThan(ref p3, ref p7)) { temp = p3; p3 = p7; p7 = temp; }
			if (GreaterThan(ref p11, ref p15)) { temp = p11; p11 = p15; p15 = temp; }
			if (GreaterThan(ref p0, ref p8)) { temp = p0; p0 = p8; p8 = temp; }
			if (GreaterThan(ref p1, ref p9)) { temp = p1; p1 = p9; p9 = temp; }
			if (GreaterThan(ref p2, ref p10)) { temp = p2; p2 = p10; p10 = temp; }
			if (GreaterThan(ref p3, ref p11)) { temp = p3; p3 = p11; p11 = temp; }
			if (GreaterThan(ref p4, ref p12)) { temp = p4; p4 = p12; p12 = temp; }
			if (GreaterThan(ref p5, ref p13)) { temp = p5; p5 = p13; p13 = temp; }
			if (GreaterThan(ref p6, ref p14)) { temp = p6; p6 = p14; p14 = temp; }
			if (GreaterThan(ref p7, ref p15)) { temp = p7; p7 = p15; p15 = temp; }
			if (GreaterThan(ref p5, ref p10)) { temp = p5; p5 = p10; p10 = temp; }
			if (GreaterThan(ref p6, ref p9)) { temp = p6; p6 = p9; p9 = temp; }
			if (GreaterThan(ref p3, ref p12)) { temp = p3; p3 = p12; p12 = temp; }
			if (GreaterThan(ref p13, ref p14)) { temp = p13; p13 = p14; p14 = temp; }
			if (GreaterThan(ref p7, ref p11)) { temp = p7; p7 = p11; p11 = temp; }
			if (GreaterThan(ref p1, ref p2)) { temp = p1; p1 = p2; p2 = temp; }
			if (GreaterThan(ref p4, ref p8)) { temp = p4; p4 = p8; p8 = temp; }
			if (GreaterThan(ref p1, ref p4)) { temp = p1; p1 = p4; p4 = temp; }
			if (GreaterThan(ref p7, ref p13)) { temp = p7; p7 = p13; p13 = temp; }
			if (GreaterThan(ref p2, ref p8)) { temp = p2; p2 = p8; p8 = temp; }
			if (GreaterThan(ref p11, ref p14)) { temp = p11; p11 = p14; p14 = temp; }
			if (GreaterThan(ref p5, ref p6)) { temp = p5; p5 = p6; p6 = temp; }
			if (GreaterThan(ref p9, ref p10)) { temp = p9; p9 = p10; p10 = temp; }
			if (GreaterThan(ref p2, ref p4)) { temp = p2; p2 = p4; p4 = temp; }
			if (GreaterThan(ref p11, ref p13)) { temp = p11; p11 = p13; p13 = temp; }
			if (GreaterThan(ref p3, ref p8)) { temp = p3; p3 = p8; p8 = temp; }
			if (GreaterThan(ref p7, ref p12)) { temp = p7; p7 = p12; p12 = temp; }
			if (GreaterThan(ref p6, ref p8)) { temp = p6; p6 = p8; p8 = temp; }
			if (GreaterThan(ref p10, ref p12)) { temp = p10; p10 = p12; p12 = temp; }
			if (GreaterThan(ref p3, ref p5)) { temp = p3; p3 = p5; p5 = temp; }
			if (GreaterThan(ref p7, ref p9)) { temp = p7; p7 = p9; p9 = temp; }
			if (GreaterThan(ref p3, ref p4)) { temp = p3; p3 = p4; p4 = temp; }
			if (GreaterThan(ref p5, ref p6)) { temp = p5; p5 = p6; p6 = temp; }
			if (GreaterThan(ref p7, ref p8)) { temp = p7; p7 = p8; p8 = temp; }
			if (GreaterThan(ref p9, ref p10)) { temp = p9; p9 = p10; p10 = temp; }
			if (GreaterThan(ref p11, ref p12)) { temp = p11; p11 = p12; p12 = temp; }
			if (GreaterThan(ref p6, ref p7)) { temp = p6; p6 = p7; p7 = temp; }
			if (GreaterThan(ref p8, ref p9)) { temp = p8; p8 = p9; p9 = temp; }
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
			default:
				{
					ThrowHelper.ArrayArgumentOutOfRange(nameof(length), length, MinLength, MaxLength);
					break;
				}
		}
	}
}