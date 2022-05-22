namespace SortingNetworks;

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
		if (comparison is null)
		{
			ThrowHelper.ArgumentNull(nameof(comparison));
		}

		ref T p1 = ref Unsafe.Add(ref p0, 1);
		ref T p2 = ref Unsafe.Add(ref p0, 2);
		ref T p3 = ref Unsafe.Add(ref p0, 3);
		ref T p4 = ref Unsafe.Add(ref p0, 4);
		ref T p5 = ref Unsafe.Add(ref p0, 5);
		ref T p6 = ref Unsafe.Add(ref p0, 6);
		ref T p7 = ref Unsafe.Add(ref p0, 7);
		ref T p8 = ref Unsafe.Add(ref p0, 8);

		T temp;
		if (comparison.Invoke(p0, p1) < 0) { temp = p0; p0 = p1; p1 = temp; }
		if (comparison.Invoke(p3, p4) < 0) { temp = p3; p3 = p4; p4 = temp; }
		if (comparison.Invoke(p6, p7) < 0) { temp = p6; p6 = p7; p7 = temp; }
		if (comparison.Invoke(p1, p2) < 0) { temp = p1; p1 = p2; p2 = temp; }
		if (comparison.Invoke(p4, p5) < 0) { temp = p4; p4 = p5; p5 = temp; }
		if (comparison.Invoke(p7, p8) < 0) { temp = p7; p7 = p8; p8 = temp; }
		if (comparison.Invoke(p0, p1) < 0) { temp = p0; p0 = p1; p1 = temp; }
		if (comparison.Invoke(p3, p4) < 0) { temp = p3; p3 = p4; p4 = temp; }
		if (comparison.Invoke(p6, p7) < 0) { temp = p6; p6 = p7; p7 = temp; }
		if (comparison.Invoke(p2, p5) < 0) { temp = p2; p2 = p5; p5 = temp; }
		if (comparison.Invoke(p0, p3) < 0) { temp = p0; p0 = p3; p3 = temp; }
		if (comparison.Invoke(p1, p4) < 0) { temp = p1; p1 = p4; p4 = temp; }
		if (comparison.Invoke(p5, p8) < 0) { temp = p5; p5 = p8; p8 = temp; }
		if (comparison.Invoke(p3, p6) < 0) { temp = p3; p3 = p6; p6 = temp; }
		if (comparison.Invoke(p4, p7) < 0) { temp = p4; p4 = p7; p7 = temp; }
		if (comparison.Invoke(p2, p5) < 0) { temp = p2; p2 = p5; p5 = temp; }
		if (comparison.Invoke(p0, p3) < 0) { temp = p0; p0 = p3; p3 = temp; }
		if (comparison.Invoke(p1, p4) < 0) { temp = p1; p1 = p4; p4 = temp; }
		if (comparison.Invoke(p5, p7) < 0) { temp = p5; p5 = p7; p7 = temp; }
		if (comparison.Invoke(p2, p6) < 0) { temp = p2; p2 = p6; p6 = temp; }
		if (comparison.Invoke(p1, p3) < 0) { temp = p1; p1 = p3; p3 = temp; }
		if (comparison.Invoke(p4, p6) < 0) { temp = p4; p4 = p6; p6 = temp; }
		if (comparison.Invoke(p2, p4) < 0) { temp = p2; p2 = p4; p4 = temp; }
		if (comparison.Invoke(p5, p6) < 0) { temp = p5; p5 = p6; p6 = temp; }
		if (comparison.Invoke(p2, p3) < 0) { temp = p2; p2 = p3; p3 = temp; }
	}

	/// <summary>
	/// Sorts a collection of 10 elements in descending order using the specified <see cref="Comparison{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements of the collection.</typeparam>
	/// <param name="p0">the reference to the first element of the collection</param>
	/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
	public static new void Sort10Descending<T>(ref T p0, Comparison<T> comparison)
	{
		if (comparison is null)
		{
			ThrowHelper.ArgumentNull(nameof(comparison));
		}

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
		if (comparison.Invoke(p4, p9) < 0) { temp = p4; p4 = p9; p9 = temp; }
		if (comparison.Invoke(p3, p8) < 0) { temp = p3; p3 = p8; p8 = temp; }
		if (comparison.Invoke(p2, p7) < 0) { temp = p2; p2 = p7; p7 = temp; }
		if (comparison.Invoke(p1, p6) < 0) { temp = p1; p1 = p6; p6 = temp; }
		if (comparison.Invoke(p0, p5) < 0) { temp = p0; p0 = p5; p5 = temp; }
		if (comparison.Invoke(p1, p4) < 0) { temp = p1; p1 = p4; p4 = temp; }
		if (comparison.Invoke(p6, p9) < 0) { temp = p6; p6 = p9; p9 = temp; }
		if (comparison.Invoke(p0, p3) < 0) { temp = p0; p0 = p3; p3 = temp; }
		if (comparison.Invoke(p5, p8) < 0) { temp = p5; p5 = p8; p8 = temp; }
		if (comparison.Invoke(p0, p2) < 0) { temp = p0; p0 = p2; p2 = temp; }
		if (comparison.Invoke(p3, p6) < 0) { temp = p3; p3 = p6; p6 = temp; }
		if (comparison.Invoke(p7, p9) < 0) { temp = p7; p7 = p9; p9 = temp; }
		if (comparison.Invoke(p0, p1) < 0) { temp = p0; p0 = p1; p1 = temp; }
		if (comparison.Invoke(p2, p4) < 0) { temp = p2; p2 = p4; p4 = temp; }
		if (comparison.Invoke(p5, p7) < 0) { temp = p5; p5 = p7; p7 = temp; }
		if (comparison.Invoke(p8, p9) < 0) { temp = p8; p8 = p9; p9 = temp; }
		if (comparison.Invoke(p1, p2) < 0) { temp = p1; p1 = p2; p2 = temp; }
		if (comparison.Invoke(p4, p6) < 0) { temp = p4; p4 = p6; p6 = temp; }
		if (comparison.Invoke(p7, p8) < 0) { temp = p7; p7 = p8; p8 = temp; }
		if (comparison.Invoke(p3, p5) < 0) { temp = p3; p3 = p5; p5 = temp; }
		if (comparison.Invoke(p2, p5) < 0) { temp = p2; p2 = p5; p5 = temp; }
		if (comparison.Invoke(p6, p8) < 0) { temp = p6; p6 = p8; p8 = temp; }
		if (comparison.Invoke(p1, p3) < 0) { temp = p1; p1 = p3; p3 = temp; }
		if (comparison.Invoke(p4, p7) < 0) { temp = p4; p4 = p7; p7 = temp; }
		if (comparison.Invoke(p2, p3) < 0) { temp = p2; p2 = p3; p3 = temp; }
		if (comparison.Invoke(p6, p7) < 0) { temp = p6; p6 = p7; p7 = temp; }
		if (comparison.Invoke(p3, p4) < 0) { temp = p3; p3 = p4; p4 = temp; }
		if (comparison.Invoke(p5, p6) < 0) { temp = p5; p5 = p6; p6 = temp; }
		if (comparison.Invoke(p4, p5) < 0) { temp = p4; p4 = p5; p5 = temp; }
	}

	/// <summary>
	/// Sorts a collection of 11 elements in descending order using the specified <see cref="Comparison{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements of the collection.</typeparam>
	/// <param name="p0">the reference to the first element of the collection</param>
	/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
	public static new void Sort11Descending<T>(ref T p0, Comparison<T> comparison)
	{
		if (comparison is null)
		{
			ThrowHelper.ArgumentNull(nameof(comparison));
		}

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
		if (comparison.Invoke(p0, p1) < 0) { temp = p0; p0 = p1; p1 = temp; }
		if (comparison.Invoke(p2, p3) < 0) { temp = p2; p2 = p3; p3 = temp; }
		if (comparison.Invoke(p4, p5) < 0) { temp = p4; p4 = p5; p5 = temp; }
		if (comparison.Invoke(p6, p7) < 0) { temp = p6; p6 = p7; p7 = temp; }
		if (comparison.Invoke(p8, p9) < 0) { temp = p8; p8 = p9; p9 = temp; }
		if (comparison.Invoke(p1, p3) < 0) { temp = p1; p1 = p3; p3 = temp; }
		if (comparison.Invoke(p5, p7) < 0) { temp = p5; p5 = p7; p7 = temp; }
		if (comparison.Invoke(p0, p2) < 0) { temp = p0; p0 = p2; p2 = temp; }
		if (comparison.Invoke(p4, p6) < 0) { temp = p4; p4 = p6; p6 = temp; }
		if (comparison.Invoke(p8, p10) < 0) { temp = p8; p8 = p10; p10 = temp; }
		if (comparison.Invoke(p1, p2) < 0) { temp = p1; p1 = p2; p2 = temp; }
		if (comparison.Invoke(p5, p6) < 0) { temp = p5; p5 = p6; p6 = temp; }
		if (comparison.Invoke(p9, p10) < 0) { temp = p9; p9 = p10; p10 = temp; }
		if (comparison.Invoke(p0, p4) < 0) { temp = p0; p0 = p4; p4 = temp; }
		if (comparison.Invoke(p3, p7) < 0) { temp = p3; p3 = p7; p7 = temp; }
		if (comparison.Invoke(p1, p5) < 0) { temp = p1; p1 = p5; p5 = temp; }
		if (comparison.Invoke(p6, p10) < 0) { temp = p6; p6 = p10; p10 = temp; }
		if (comparison.Invoke(p4, p8) < 0) { temp = p4; p4 = p8; p8 = temp; }
		if (comparison.Invoke(p5, p9) < 0) { temp = p5; p5 = p9; p9 = temp; }
		if (comparison.Invoke(p2, p6) < 0) { temp = p2; p2 = p6; p6 = temp; }
		if (comparison.Invoke(p0, p4) < 0) { temp = p0; p0 = p4; p4 = temp; }
		if (comparison.Invoke(p3, p8) < 0) { temp = p3; p3 = p8; p8 = temp; }
		if (comparison.Invoke(p1, p5) < 0) { temp = p1; p1 = p5; p5 = temp; }
		if (comparison.Invoke(p6, p10) < 0) { temp = p6; p6 = p10; p10 = temp; }
		if (comparison.Invoke(p2, p3) < 0) { temp = p2; p2 = p3; p3 = temp; }
		if (comparison.Invoke(p8, p9) < 0) { temp = p8; p8 = p9; p9 = temp; }
		if (comparison.Invoke(p1, p4) < 0) { temp = p1; p1 = p4; p4 = temp; }
		if (comparison.Invoke(p7, p10) < 0) { temp = p7; p7 = p10; p10 = temp; }
		if (comparison.Invoke(p3, p5) < 0) { temp = p3; p3 = p5; p5 = temp; }
		if (comparison.Invoke(p6, p8) < 0) { temp = p6; p6 = p8; p8 = temp; }
		if (comparison.Invoke(p2, p4) < 0) { temp = p2; p2 = p4; p4 = temp; }
		if (comparison.Invoke(p7, p9) < 0) { temp = p7; p7 = p9; p9 = temp; }
		if (comparison.Invoke(p5, p6) < 0) { temp = p5; p5 = p6; p6 = temp; }
		if (comparison.Invoke(p3, p4) < 0) { temp = p3; p3 = p4; p4 = temp; }
		if (comparison.Invoke(p7, p8) < 0) { temp = p7; p7 = p8; p8 = temp; }
	}

	/// <summary>
	/// Sorts a collection of 12 elements in descending order using the specified <see cref="Comparison{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements of the collection.</typeparam>
	/// <param name="p0">the reference to the first element of the collection</param>
	/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
	public static new void Sort12Descending<T>(ref T p0, Comparison<T> comparison)
	{
		if (comparison is null)
		{
			ThrowHelper.ArgumentNull(nameof(comparison));
		}

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
		if (comparison.Invoke(p0, p1) < 0) { temp = p0; p0 = p1; p1 = temp; }
		if (comparison.Invoke(p2, p3) < 0) { temp = p2; p2 = p3; p3 = temp; }
		if (comparison.Invoke(p4, p5) < 0) { temp = p4; p4 = p5; p5 = temp; }
		if (comparison.Invoke(p6, p7) < 0) { temp = p6; p6 = p7; p7 = temp; }
		if (comparison.Invoke(p8, p9) < 0) { temp = p8; p8 = p9; p9 = temp; }
		if (comparison.Invoke(p10, p11) < 0) { temp = p10; p10 = p11; p11 = temp; }
		if (comparison.Invoke(p1, p3) < 0) { temp = p1; p1 = p3; p3 = temp; }
		if (comparison.Invoke(p5, p7) < 0) { temp = p5; p5 = p7; p7 = temp; }
		if (comparison.Invoke(p9, p11) < 0) { temp = p9; p9 = p11; p11 = temp; }
		if (comparison.Invoke(p0, p2) < 0) { temp = p0; p0 = p2; p2 = temp; }
		if (comparison.Invoke(p4, p6) < 0) { temp = p4; p4 = p6; p6 = temp; }
		if (comparison.Invoke(p8, p10) < 0) { temp = p8; p8 = p10; p10 = temp; }
		if (comparison.Invoke(p1, p2) < 0) { temp = p1; p1 = p2; p2 = temp; }
		if (comparison.Invoke(p5, p6) < 0) { temp = p5; p5 = p6; p6 = temp; }
		if (comparison.Invoke(p9, p10) < 0) { temp = p9; p9 = p10; p10 = temp; }
		if (comparison.Invoke(p0, p4) < 0) { temp = p0; p0 = p4; p4 = temp; }
		if (comparison.Invoke(p7, p11) < 0) { temp = p7; p7 = p11; p11 = temp; }
		if (comparison.Invoke(p1, p5) < 0) { temp = p1; p1 = p5; p5 = temp; }
		if (comparison.Invoke(p6, p10) < 0) { temp = p6; p6 = p10; p10 = temp; }
		if (comparison.Invoke(p3, p7) < 0) { temp = p3; p3 = p7; p7 = temp; }
		if (comparison.Invoke(p4, p8) < 0) { temp = p4; p4 = p8; p8 = temp; }
		if (comparison.Invoke(p5, p9) < 0) { temp = p5; p5 = p9; p9 = temp; }
		if (comparison.Invoke(p2, p6) < 0) { temp = p2; p2 = p6; p6 = temp; }
		if (comparison.Invoke(p0, p4) < 0) { temp = p0; p0 = p4; p4 = temp; }
		if (comparison.Invoke(p7, p11) < 0) { temp = p7; p7 = p11; p11 = temp; }
		if (comparison.Invoke(p3, p8) < 0) { temp = p3; p3 = p8; p8 = temp; }
		if (comparison.Invoke(p1, p5) < 0) { temp = p1; p1 = p5; p5 = temp; }
		if (comparison.Invoke(p6, p10) < 0) { temp = p6; p6 = p10; p10 = temp; }
		if (comparison.Invoke(p2, p3) < 0) { temp = p2; p2 = p3; p3 = temp; }
		if (comparison.Invoke(p8, p9) < 0) { temp = p8; p8 = p9; p9 = temp; }
		if (comparison.Invoke(p1, p4) < 0) { temp = p1; p1 = p4; p4 = temp; }
		if (comparison.Invoke(p7, p10) < 0) { temp = p7; p7 = p10; p10 = temp; }
		if (comparison.Invoke(p3, p5) < 0) { temp = p3; p3 = p5; p5 = temp; }
		if (comparison.Invoke(p6, p8) < 0) { temp = p6; p6 = p8; p8 = temp; }
		if (comparison.Invoke(p2, p4) < 0) { temp = p2; p2 = p4; p4 = temp; }
		if (comparison.Invoke(p7, p9) < 0) { temp = p7; p7 = p9; p9 = temp; }
		if (comparison.Invoke(p5, p6) < 0) { temp = p5; p5 = p6; p6 = temp; }
		if (comparison.Invoke(p3, p4) < 0) { temp = p3; p3 = p4; p4 = temp; }
		if (comparison.Invoke(p7, p8) < 0) { temp = p7; p7 = p8; p8 = temp; }
	}

	/// <summary>
	/// Sorts a collection of 13 elements in descending order using the specified <see cref="Comparison{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements of the collection.</typeparam>
	/// <param name="p0">the reference to the first element of the collection</param>
	/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
	public static new void Sort13Descending<T>(ref T p0, Comparison<T> comparison)
	{
		if (comparison is null)
		{
			ThrowHelper.ArgumentNull(nameof(comparison));
		}

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
		if (comparison.Invoke(p1, p7) < 0) { temp = p1; p1 = p7; p7 = temp; }
		if (comparison.Invoke(p9, p11) < 0) { temp = p9; p9 = p11; p11 = temp; }
		if (comparison.Invoke(p3, p4) < 0) { temp = p3; p3 = p4; p4 = temp; }
		if (comparison.Invoke(p5, p8) < 0) { temp = p5; p5 = p8; p8 = temp; }
		if (comparison.Invoke(p0, p12) < 0) { temp = p0; p0 = p12; p12 = temp; }
		if (comparison.Invoke(p2, p6) < 0) { temp = p2; p2 = p6; p6 = temp; }
		if (comparison.Invoke(p0, p1) < 0) { temp = p0; p0 = p1; p1 = temp; }
		if (comparison.Invoke(p2, p3) < 0) { temp = p2; p2 = p3; p3 = temp; }
		if (comparison.Invoke(p4, p6) < 0) { temp = p4; p4 = p6; p6 = temp; }
		if (comparison.Invoke(p8, p11) < 0) { temp = p8; p8 = p11; p11 = temp; }
		if (comparison.Invoke(p7, p12) < 0) { temp = p7; p7 = p12; p12 = temp; }
		if (comparison.Invoke(p5, p9) < 0) { temp = p5; p5 = p9; p9 = temp; }
		if (comparison.Invoke(p0, p2) < 0) { temp = p0; p0 = p2; p2 = temp; }
		if (comparison.Invoke(p3, p7) < 0) { temp = p3; p3 = p7; p7 = temp; }
		if (comparison.Invoke(p10, p11) < 0) { temp = p10; p10 = p11; p11 = temp; }
		if (comparison.Invoke(p1, p4) < 0) { temp = p1; p1 = p4; p4 = temp; }
		if (comparison.Invoke(p6, p12) < 0) { temp = p6; p6 = p12; p12 = temp; }
		if (comparison.Invoke(p7, p8) < 0) { temp = p7; p7 = p8; p8 = temp; }
		if (comparison.Invoke(p11, p12) < 0) { temp = p11; p11 = p12; p12 = temp; }
		if (comparison.Invoke(p4, p9) < 0) { temp = p4; p4 = p9; p9 = temp; }
		if (comparison.Invoke(p6, p10) < 0) { temp = p6; p6 = p10; p10 = temp; }
		if (comparison.Invoke(p3, p4) < 0) { temp = p3; p3 = p4; p4 = temp; }
		if (comparison.Invoke(p5, p6) < 0) { temp = p5; p5 = p6; p6 = temp; }
		if (comparison.Invoke(p8, p9) < 0) { temp = p8; p8 = p9; p9 = temp; }
		if (comparison.Invoke(p10, p11) < 0) { temp = p10; p10 = p11; p11 = temp; }
		if (comparison.Invoke(p1, p7) < 0) { temp = p1; p1 = p7; p7 = temp; }
		if (comparison.Invoke(p2, p6) < 0) { temp = p2; p2 = p6; p6 = temp; }
		if (comparison.Invoke(p9, p11) < 0) { temp = p9; p9 = p11; p11 = temp; }
		if (comparison.Invoke(p1, p3) < 0) { temp = p1; p1 = p3; p3 = temp; }
		if (comparison.Invoke(p4, p7) < 0) { temp = p4; p4 = p7; p7 = temp; }
		if (comparison.Invoke(p8, p10) < 0) { temp = p8; p8 = p10; p10 = temp; }
		if (comparison.Invoke(p0, p5) < 0) { temp = p0; p0 = p5; p5 = temp; }
		if (comparison.Invoke(p2, p5) < 0) { temp = p2; p2 = p5; p5 = temp; }
		if (comparison.Invoke(p6, p8) < 0) { temp = p6; p6 = p8; p8 = temp; }
		if (comparison.Invoke(p9, p10) < 0) { temp = p9; p9 = p10; p10 = temp; }
		if (comparison.Invoke(p1, p2) < 0) { temp = p1; p1 = p2; p2 = temp; }
		if (comparison.Invoke(p3, p5) < 0) { temp = p3; p3 = p5; p5 = temp; }
		if (comparison.Invoke(p7, p8) < 0) { temp = p7; p7 = p8; p8 = temp; }
		if (comparison.Invoke(p4, p6) < 0) { temp = p4; p4 = p6; p6 = temp; }
		if (comparison.Invoke(p2, p3) < 0) { temp = p2; p2 = p3; p3 = temp; }
		if (comparison.Invoke(p4, p5) < 0) { temp = p4; p4 = p5; p5 = temp; }
		if (comparison.Invoke(p6, p7) < 0) { temp = p6; p6 = p7; p7 = temp; }
		if (comparison.Invoke(p8, p9) < 0) { temp = p8; p8 = p9; p9 = temp; }
		if (comparison.Invoke(p3, p4) < 0) { temp = p3; p3 = p4; p4 = temp; }
		if (comparison.Invoke(p5, p6) < 0) { temp = p5; p5 = p6; p6 = temp; }
	}

	/// <summary>
	/// Sorts a collection of 14 elements in descending order using the specified <see cref="Comparison{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements of the collection.</typeparam>
	/// <param name="p0">the reference to the first element of the collection</param>
	/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
	public static new void Sort14Descending<T>(ref T p0, Comparison<T> comparison)
	{
		if (comparison is null)
		{
			ThrowHelper.ArgumentNull(nameof(comparison));
		}

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
		if (comparison.Invoke(p0, p1) < 0) { temp = p0; p0 = p1; p1 = temp; }
		if (comparison.Invoke(p2, p3) < 0) { temp = p2; p2 = p3; p3 = temp; }
		if (comparison.Invoke(p4, p5) < 0) { temp = p4; p4 = p5; p5 = temp; }
		if (comparison.Invoke(p6, p7) < 0) { temp = p6; p6 = p7; p7 = temp; }
		if (comparison.Invoke(p8, p9) < 0) { temp = p8; p8 = p9; p9 = temp; }
		if (comparison.Invoke(p10, p11) < 0) { temp = p10; p10 = p11; p11 = temp; }
		if (comparison.Invoke(p12, p13) < 0) { temp = p12; p12 = p13; p13 = temp; }
		if (comparison.Invoke(p0, p2) < 0) { temp = p0; p0 = p2; p2 = temp; }
		if (comparison.Invoke(p4, p6) < 0) { temp = p4; p4 = p6; p6 = temp; }
		if (comparison.Invoke(p8, p10) < 0) { temp = p8; p8 = p10; p10 = temp; }
		if (comparison.Invoke(p1, p3) < 0) { temp = p1; p1 = p3; p3 = temp; }
		if (comparison.Invoke(p5, p7) < 0) { temp = p5; p5 = p7; p7 = temp; }
		if (comparison.Invoke(p9, p11) < 0) { temp = p9; p9 = p11; p11 = temp; }
		if (comparison.Invoke(p0, p4) < 0) { temp = p0; p0 = p4; p4 = temp; }
		if (comparison.Invoke(p8, p12) < 0) { temp = p8; p8 = p12; p12 = temp; }
		if (comparison.Invoke(p1, p5) < 0) { temp = p1; p1 = p5; p5 = temp; }
		if (comparison.Invoke(p9, p13) < 0) { temp = p9; p9 = p13; p13 = temp; }
		if (comparison.Invoke(p2, p6) < 0) { temp = p2; p2 = p6; p6 = temp; }
		if (comparison.Invoke(p3, p7) < 0) { temp = p3; p3 = p7; p7 = temp; }
		if (comparison.Invoke(p0, p8) < 0) { temp = p0; p0 = p8; p8 = temp; }
		if (comparison.Invoke(p1, p9) < 0) { temp = p1; p1 = p9; p9 = temp; }
		if (comparison.Invoke(p2, p10) < 0) { temp = p2; p2 = p10; p10 = temp; }
		if (comparison.Invoke(p3, p11) < 0) { temp = p3; p3 = p11; p11 = temp; }
		if (comparison.Invoke(p4, p12) < 0) { temp = p4; p4 = p12; p12 = temp; }
		if (comparison.Invoke(p5, p13) < 0) { temp = p5; p5 = p13; p13 = temp; }
		if (comparison.Invoke(p5, p10) < 0) { temp = p5; p5 = p10; p10 = temp; }
		if (comparison.Invoke(p6, p9) < 0) { temp = p6; p6 = p9; p9 = temp; }
		if (comparison.Invoke(p3, p12) < 0) { temp = p3; p3 = p12; p12 = temp; }
		if (comparison.Invoke(p7, p11) < 0) { temp = p7; p7 = p11; p11 = temp; }
		if (comparison.Invoke(p1, p2) < 0) { temp = p1; p1 = p2; p2 = temp; }
		if (comparison.Invoke(p4, p8) < 0) { temp = p4; p4 = p8; p8 = temp; }
		if (comparison.Invoke(p1, p4) < 0) { temp = p1; p1 = p4; p4 = temp; }
		if (comparison.Invoke(p7, p13) < 0) { temp = p7; p7 = p13; p13 = temp; }
		if (comparison.Invoke(p2, p8) < 0) { temp = p2; p2 = p8; p8 = temp; }
		if (comparison.Invoke(p5, p6) < 0) { temp = p5; p5 = p6; p6 = temp; }
		if (comparison.Invoke(p9, p10) < 0) { temp = p9; p9 = p10; p10 = temp; }
		if (comparison.Invoke(p2, p4) < 0) { temp = p2; p2 = p4; p4 = temp; }
		if (comparison.Invoke(p11, p13) < 0) { temp = p11; p11 = p13; p13 = temp; }
		if (comparison.Invoke(p3, p8) < 0) { temp = p3; p3 = p8; p8 = temp; }
		if (comparison.Invoke(p7, p12) < 0) { temp = p7; p7 = p12; p12 = temp; }
		if (comparison.Invoke(p6, p8) < 0) { temp = p6; p6 = p8; p8 = temp; }
		if (comparison.Invoke(p10, p12) < 0) { temp = p10; p10 = p12; p12 = temp; }
		if (comparison.Invoke(p3, p5) < 0) { temp = p3; p3 = p5; p5 = temp; }
		if (comparison.Invoke(p7, p9) < 0) { temp = p7; p7 = p9; p9 = temp; }
		if (comparison.Invoke(p3, p4) < 0) { temp = p3; p3 = p4; p4 = temp; }
		if (comparison.Invoke(p5, p6) < 0) { temp = p5; p5 = p6; p6 = temp; }
		if (comparison.Invoke(p7, p8) < 0) { temp = p7; p7 = p8; p8 = temp; }
		if (comparison.Invoke(p9, p10) < 0) { temp = p9; p9 = p10; p10 = temp; }
		if (comparison.Invoke(p11, p12) < 0) { temp = p11; p11 = p12; p12 = temp; }
		if (comparison.Invoke(p6, p7) < 0) { temp = p6; p6 = p7; p7 = temp; }
		if (comparison.Invoke(p8, p9) < 0) { temp = p8; p8 = p9; p9 = temp; }
	}

	/// <summary>
	/// Sorts a collection of 15 elements in descending order using the specified <see cref="Comparison{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements of the collection.</typeparam>
	/// <param name="p0">the reference to the first element of the collection</param>
	/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
	public static new void Sort15Descending<T>(ref T p0, Comparison<T> comparison)
	{
		if (comparison is null)
		{
			ThrowHelper.ArgumentNull(nameof(comparison));
		}

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
		if (comparison.Invoke(p0, p1) < 0) { temp = p0; p0 = p1; p1 = temp; }
		if (comparison.Invoke(p2, p3) < 0) { temp = p2; p2 = p3; p3 = temp; }
		if (comparison.Invoke(p4, p5) < 0) { temp = p4; p4 = p5; p5 = temp; }
		if (comparison.Invoke(p6, p7) < 0) { temp = p6; p6 = p7; p7 = temp; }
		if (comparison.Invoke(p8, p9) < 0) { temp = p8; p8 = p9; p9 = temp; }
		if (comparison.Invoke(p10, p11) < 0) { temp = p10; p10 = p11; p11 = temp; }
		if (comparison.Invoke(p12, p13) < 0) { temp = p12; p12 = p13; p13 = temp; }
		if (comparison.Invoke(p0, p2) < 0) { temp = p0; p0 = p2; p2 = temp; }
		if (comparison.Invoke(p4, p6) < 0) { temp = p4; p4 = p6; p6 = temp; }
		if (comparison.Invoke(p8, p10) < 0) { temp = p8; p8 = p10; p10 = temp; }
		if (comparison.Invoke(p12, p14) < 0) { temp = p12; p12 = p14; p14 = temp; }
		if (comparison.Invoke(p1, p3) < 0) { temp = p1; p1 = p3; p3 = temp; }
		if (comparison.Invoke(p5, p7) < 0) { temp = p5; p5 = p7; p7 = temp; }
		if (comparison.Invoke(p9, p11) < 0) { temp = p9; p9 = p11; p11 = temp; }
		if (comparison.Invoke(p0, p4) < 0) { temp = p0; p0 = p4; p4 = temp; }
		if (comparison.Invoke(p8, p12) < 0) { temp = p8; p8 = p12; p12 = temp; }
		if (comparison.Invoke(p1, p5) < 0) { temp = p1; p1 = p5; p5 = temp; }
		if (comparison.Invoke(p9, p13) < 0) { temp = p9; p9 = p13; p13 = temp; }
		if (comparison.Invoke(p2, p6) < 0) { temp = p2; p2 = p6; p6 = temp; }
		if (comparison.Invoke(p10, p14) < 0) { temp = p10; p10 = p14; p14 = temp; }
		if (comparison.Invoke(p3, p7) < 0) { temp = p3; p3 = p7; p7 = temp; }
		if (comparison.Invoke(p0, p8) < 0) { temp = p0; p0 = p8; p8 = temp; }
		if (comparison.Invoke(p1, p9) < 0) { temp = p1; p1 = p9; p9 = temp; }
		if (comparison.Invoke(p2, p10) < 0) { temp = p2; p2 = p10; p10 = temp; }
		if (comparison.Invoke(p3, p11) < 0) { temp = p3; p3 = p11; p11 = temp; }
		if (comparison.Invoke(p4, p12) < 0) { temp = p4; p4 = p12; p12 = temp; }
		if (comparison.Invoke(p5, p13) < 0) { temp = p5; p5 = p13; p13 = temp; }
		if (comparison.Invoke(p6, p14) < 0) { temp = p6; p6 = p14; p14 = temp; }
		if (comparison.Invoke(p5, p10) < 0) { temp = p5; p5 = p10; p10 = temp; }
		if (comparison.Invoke(p6, p9) < 0) { temp = p6; p6 = p9; p9 = temp; }
		if (comparison.Invoke(p3, p12) < 0) { temp = p3; p3 = p12; p12 = temp; }
		if (comparison.Invoke(p13, p14) < 0) { temp = p13; p13 = p14; p14 = temp; }
		if (comparison.Invoke(p7, p11) < 0) { temp = p7; p7 = p11; p11 = temp; }
		if (comparison.Invoke(p1, p2) < 0) { temp = p1; p1 = p2; p2 = temp; }
		if (comparison.Invoke(p4, p8) < 0) { temp = p4; p4 = p8; p8 = temp; }
		if (comparison.Invoke(p1, p4) < 0) { temp = p1; p1 = p4; p4 = temp; }
		if (comparison.Invoke(p7, p13) < 0) { temp = p7; p7 = p13; p13 = temp; }
		if (comparison.Invoke(p2, p8) < 0) { temp = p2; p2 = p8; p8 = temp; }
		if (comparison.Invoke(p11, p14) < 0) { temp = p11; p11 = p14; p14 = temp; }
		if (comparison.Invoke(p5, p6) < 0) { temp = p5; p5 = p6; p6 = temp; }
		if (comparison.Invoke(p9, p10) < 0) { temp = p9; p9 = p10; p10 = temp; }
		if (comparison.Invoke(p2, p4) < 0) { temp = p2; p2 = p4; p4 = temp; }
		if (comparison.Invoke(p11, p13) < 0) { temp = p11; p11 = p13; p13 = temp; }
		if (comparison.Invoke(p3, p8) < 0) { temp = p3; p3 = p8; p8 = temp; }
		if (comparison.Invoke(p7, p12) < 0) { temp = p7; p7 = p12; p12 = temp; }
		if (comparison.Invoke(p6, p8) < 0) { temp = p6; p6 = p8; p8 = temp; }
		if (comparison.Invoke(p10, p12) < 0) { temp = p10; p10 = p12; p12 = temp; }
		if (comparison.Invoke(p3, p5) < 0) { temp = p3; p3 = p5; p5 = temp; }
		if (comparison.Invoke(p7, p9) < 0) { temp = p7; p7 = p9; p9 = temp; }
		if (comparison.Invoke(p3, p4) < 0) { temp = p3; p3 = p4; p4 = temp; }
		if (comparison.Invoke(p5, p6) < 0) { temp = p5; p5 = p6; p6 = temp; }
		if (comparison.Invoke(p7, p8) < 0) { temp = p7; p7 = p8; p8 = temp; }
		if (comparison.Invoke(p9, p10) < 0) { temp = p9; p9 = p10; p10 = temp; }
		if (comparison.Invoke(p11, p12) < 0) { temp = p11; p11 = p12; p12 = temp; }
		if (comparison.Invoke(p6, p7) < 0) { temp = p6; p6 = p7; p7 = temp; }
		if (comparison.Invoke(p8, p9) < 0) { temp = p8; p8 = p9; p9 = temp; }
	}

	/// <summary>
	/// Sorts a collection of 16 elements in descending order using the specified <see cref="Comparison{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements of the collection.</typeparam>
	/// <param name="p0">the reference to the first element of the collection</param>
	/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
	public static new void Sort16Descending<T>(ref T p0, Comparison<T> comparison)
	{
		if (comparison is null)
		{
			ThrowHelper.ArgumentNull(nameof(comparison));
		}

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
		if (comparison.Invoke(p0, p1) < 0) { temp = p0; p0 = p1; p1 = temp; }
		if (comparison.Invoke(p2, p3) < 0) { temp = p2; p2 = p3; p3 = temp; }
		if (comparison.Invoke(p4, p5) < 0) { temp = p4; p4 = p5; p5 = temp; }
		if (comparison.Invoke(p6, p7) < 0) { temp = p6; p6 = p7; p7 = temp; }
		if (comparison.Invoke(p8, p9) < 0) { temp = p8; p8 = p9; p9 = temp; }
		if (comparison.Invoke(p10, p11) < 0) { temp = p10; p10 = p11; p11 = temp; }
		if (comparison.Invoke(p12, p13) < 0) { temp = p12; p12 = p13; p13 = temp; }
		if (comparison.Invoke(p14, p15) < 0) { temp = p14; p14 = p15; p15 = temp; }
		if (comparison.Invoke(p0, p2) < 0) { temp = p0; p0 = p2; p2 = temp; }
		if (comparison.Invoke(p4, p6) < 0) { temp = p4; p4 = p6; p6 = temp; }
		if (comparison.Invoke(p8, p10) < 0) { temp = p8; p8 = p10; p10 = temp; }
		if (comparison.Invoke(p12, p14) < 0) { temp = p12; p12 = p14; p14 = temp; }
		if (comparison.Invoke(p1, p3) < 0) { temp = p1; p1 = p3; p3 = temp; }
		if (comparison.Invoke(p5, p7) < 0) { temp = p5; p5 = p7; p7 = temp; }
		if (comparison.Invoke(p9, p11) < 0) { temp = p9; p9 = p11; p11 = temp; }
		if (comparison.Invoke(p13, p15) < 0) { temp = p13; p13 = p15; p15 = temp; }
		if (comparison.Invoke(p0, p4) < 0) { temp = p0; p0 = p4; p4 = temp; }
		if (comparison.Invoke(p8, p12) < 0) { temp = p8; p8 = p12; p12 = temp; }
		if (comparison.Invoke(p1, p5) < 0) { temp = p1; p1 = p5; p5 = temp; }
		if (comparison.Invoke(p9, p13) < 0) { temp = p9; p9 = p13; p13 = temp; }
		if (comparison.Invoke(p2, p6) < 0) { temp = p2; p2 = p6; p6 = temp; }
		if (comparison.Invoke(p10, p14) < 0) { temp = p10; p10 = p14; p14 = temp; }
		if (comparison.Invoke(p3, p7) < 0) { temp = p3; p3 = p7; p7 = temp; }
		if (comparison.Invoke(p11, p15) < 0) { temp = p11; p11 = p15; p15 = temp; }
		if (comparison.Invoke(p0, p8) < 0) { temp = p0; p0 = p8; p8 = temp; }
		if (comparison.Invoke(p1, p9) < 0) { temp = p1; p1 = p9; p9 = temp; }
		if (comparison.Invoke(p2, p10) < 0) { temp = p2; p2 = p10; p10 = temp; }
		if (comparison.Invoke(p3, p11) < 0) { temp = p3; p3 = p11; p11 = temp; }
		if (comparison.Invoke(p4, p12) < 0) { temp = p4; p4 = p12; p12 = temp; }
		if (comparison.Invoke(p5, p13) < 0) { temp = p5; p5 = p13; p13 = temp; }
		if (comparison.Invoke(p6, p14) < 0) { temp = p6; p6 = p14; p14 = temp; }
		if (comparison.Invoke(p7, p15) < 0) { temp = p7; p7 = p15; p15 = temp; }
		if (comparison.Invoke(p5, p10) < 0) { temp = p5; p5 = p10; p10 = temp; }
		if (comparison.Invoke(p6, p9) < 0) { temp = p6; p6 = p9; p9 = temp; }
		if (comparison.Invoke(p3, p12) < 0) { temp = p3; p3 = p12; p12 = temp; }
		if (comparison.Invoke(p13, p14) < 0) { temp = p13; p13 = p14; p14 = temp; }
		if (comparison.Invoke(p7, p11) < 0) { temp = p7; p7 = p11; p11 = temp; }
		if (comparison.Invoke(p1, p2) < 0) { temp = p1; p1 = p2; p2 = temp; }
		if (comparison.Invoke(p4, p8) < 0) { temp = p4; p4 = p8; p8 = temp; }
		if (comparison.Invoke(p1, p4) < 0) { temp = p1; p1 = p4; p4 = temp; }
		if (comparison.Invoke(p7, p13) < 0) { temp = p7; p7 = p13; p13 = temp; }
		if (comparison.Invoke(p2, p8) < 0) { temp = p2; p2 = p8; p8 = temp; }
		if (comparison.Invoke(p11, p14) < 0) { temp = p11; p11 = p14; p14 = temp; }
		if (comparison.Invoke(p5, p6) < 0) { temp = p5; p5 = p6; p6 = temp; }
		if (comparison.Invoke(p9, p10) < 0) { temp = p9; p9 = p10; p10 = temp; }
		if (comparison.Invoke(p2, p4) < 0) { temp = p2; p2 = p4; p4 = temp; }
		if (comparison.Invoke(p11, p13) < 0) { temp = p11; p11 = p13; p13 = temp; }
		if (comparison.Invoke(p3, p8) < 0) { temp = p3; p3 = p8; p8 = temp; }
		if (comparison.Invoke(p7, p12) < 0) { temp = p7; p7 = p12; p12 = temp; }
		if (comparison.Invoke(p6, p8) < 0) { temp = p6; p6 = p8; p8 = temp; }
		if (comparison.Invoke(p10, p12) < 0) { temp = p10; p10 = p12; p12 = temp; }
		if (comparison.Invoke(p3, p5) < 0) { temp = p3; p3 = p5; p5 = temp; }
		if (comparison.Invoke(p7, p9) < 0) { temp = p7; p7 = p9; p9 = temp; }
		if (comparison.Invoke(p3, p4) < 0) { temp = p3; p3 = p4; p4 = temp; }
		if (comparison.Invoke(p5, p6) < 0) { temp = p5; p5 = p6; p6 = temp; }
		if (comparison.Invoke(p7, p8) < 0) { temp = p7; p7 = p8; p8 = temp; }
		if (comparison.Invoke(p9, p10) < 0) { temp = p9; p9 = p10; p10 = temp; }
		if (comparison.Invoke(p11, p12) < 0) { temp = p11; p11 = p12; p12 = temp; }
		if (comparison.Invoke(p6, p7) < 0) { temp = p6; p6 = p7; p7 = temp; }
		if (comparison.Invoke(p8, p9) < 0) { temp = p8; p8 = p9; p9 = temp; }
	}

	/// <summary>
	/// Sorts a collection of specified number of elements in descending order using the specified <see cref="Comparison{T}"/>.
	/// </summary>
	/// <typeparam name="T">The type of the elements of the collection.</typeparam>
	/// <param name="p0">the reference to the first element of the collection</param>
	/// <param name="length">the length of the collection</param>
	/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
	/// <exception cref="ArgumentOutOfRangeException">collection length is not between <see cref="MinLength"/> and <see cref="MaxLength"/></exception>
	public static new void SortDescending<T>(ref T p0, in int length, Comparison<T> comparison)
		where T : IComparable<T>
	{
		if (comparison is null)
		{
			ThrowHelper.ArgumentNull(nameof(comparison));
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
			default:
				{
					ThrowHelper.ArrayArgumentOutOfRange(nameof(length), length, MinLength, MaxLength);
					break;
				}
		}
	}
}