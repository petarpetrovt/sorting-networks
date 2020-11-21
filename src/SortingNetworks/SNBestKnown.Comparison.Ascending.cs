namespace SortingNetworks
{
	using System;
	using System.Runtime.CompilerServices;

	partial class SNBestKnown
	{
		/// <summary>
		/// Sorts a collection of 9 elements in ascending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		public static new void Sort9Ascending<T>(ref T p0, Comparison<T> comparison)
		{
			ThrowHelper.NotNull(comparison, nameof(comparison));

			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);
			ref var p5 = ref Unsafe.Add(ref p0, 5);
			ref var p6 = ref Unsafe.Add(ref p0, 6);
			ref var p7 = ref Unsafe.Add(ref p0, 7);
			ref var p8 = ref Unsafe.Add(ref p0, 8);

			T temp;
			if (comparison.Invoke(p0, p1) > 0) { temp = p0; p0 = p1; p1 = temp; }
			if (comparison.Invoke(p3, p4) > 0) { temp = p3; p3 = p4; p4 = temp; }
			if (comparison.Invoke(p6, p7) > 0) { temp = p6; p6 = p7; p7 = temp; }
			if (comparison.Invoke(p1, p2) > 0) { temp = p1; p1 = p2; p2 = temp; }
			if (comparison.Invoke(p4, p5) > 0) { temp = p4; p4 = p5; p5 = temp; }
			if (comparison.Invoke(p7, p8) > 0) { temp = p7; p7 = p8; p8 = temp; }
			if (comparison.Invoke(p0, p1) > 0) { temp = p0; p0 = p1; p1 = temp; }
			if (comparison.Invoke(p3, p4) > 0) { temp = p3; p3 = p4; p4 = temp; }
			if (comparison.Invoke(p6, p7) > 0) { temp = p6; p6 = p7; p7 = temp; }
			if (comparison.Invoke(p2, p5) > 0) { temp = p2; p2 = p5; p5 = temp; }
			if (comparison.Invoke(p0, p3) > 0) { temp = p0; p0 = p3; p3 = temp; }
			if (comparison.Invoke(p1, p4) > 0) { temp = p1; p1 = p4; p4 = temp; }
			if (comparison.Invoke(p5, p8) > 0) { temp = p5; p5 = p8; p8 = temp; }
			if (comparison.Invoke(p3, p6) > 0) { temp = p3; p3 = p6; p6 = temp; }
			if (comparison.Invoke(p4, p7) > 0) { temp = p4; p4 = p7; p7 = temp; }
			if (comparison.Invoke(p2, p5) > 0) { temp = p2; p2 = p5; p5 = temp; }
			if (comparison.Invoke(p0, p3) > 0) { temp = p0; p0 = p3; p3 = temp; }
			if (comparison.Invoke(p1, p4) > 0) { temp = p1; p1 = p4; p4 = temp; }
			if (comparison.Invoke(p5, p7) > 0) { temp = p5; p5 = p7; p7 = temp; }
			if (comparison.Invoke(p2, p6) > 0) { temp = p2; p2 = p6; p6 = temp; }
			if (comparison.Invoke(p1, p3) > 0) { temp = p1; p1 = p3; p3 = temp; }
			if (comparison.Invoke(p4, p6) > 0) { temp = p4; p4 = p6; p6 = temp; }
			if (comparison.Invoke(p2, p4) > 0) { temp = p2; p2 = p4; p4 = temp; }
			if (comparison.Invoke(p5, p6) > 0) { temp = p5; p5 = p6; p6 = temp; }
			if (comparison.Invoke(p2, p3) > 0) { temp = p2; p2 = p3; p3 = temp; }
		}

		/// <summary>
		/// Sorts a collection of 10 elements in ascending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		public static new void Sort10Ascending<T>(ref T p0, Comparison<T> comparison)
		{
			ThrowHelper.NotNull(comparison, nameof(comparison));

			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);
			ref var p5 = ref Unsafe.Add(ref p0, 5);
			ref var p6 = ref Unsafe.Add(ref p0, 6);
			ref var p7 = ref Unsafe.Add(ref p0, 7);
			ref var p8 = ref Unsafe.Add(ref p0, 8);
			ref var p9 = ref Unsafe.Add(ref p0, 9);

			T temp;
			if (comparison.Invoke(p4, p9) > 0) { temp = p4; p4 = p9; p9 = temp; }
			if (comparison.Invoke(p3, p8) > 0) { temp = p3; p3 = p8; p8 = temp; }
			if (comparison.Invoke(p2, p7) > 0) { temp = p2; p2 = p7; p7 = temp; }
			if (comparison.Invoke(p1, p6) > 0) { temp = p1; p1 = p6; p6 = temp; }
			if (comparison.Invoke(p0, p5) > 0) { temp = p0; p0 = p5; p5 = temp; }
			if (comparison.Invoke(p1, p4) > 0) { temp = p1; p1 = p4; p4 = temp; }
			if (comparison.Invoke(p6, p9) > 0) { temp = p6; p6 = p9; p9 = temp; }
			if (comparison.Invoke(p0, p3) > 0) { temp = p0; p0 = p3; p3 = temp; }
			if (comparison.Invoke(p5, p8) > 0) { temp = p5; p5 = p8; p8 = temp; }
			if (comparison.Invoke(p0, p2) > 0) { temp = p0; p0 = p2; p2 = temp; }
			if (comparison.Invoke(p3, p6) > 0) { temp = p3; p3 = p6; p6 = temp; }
			if (comparison.Invoke(p7, p9) > 0) { temp = p7; p7 = p9; p9 = temp; }
			if (comparison.Invoke(p0, p1) > 0) { temp = p0; p0 = p1; p1 = temp; }
			if (comparison.Invoke(p2, p4) > 0) { temp = p2; p2 = p4; p4 = temp; }
			if (comparison.Invoke(p5, p7) > 0) { temp = p5; p5 = p7; p7 = temp; }
			if (comparison.Invoke(p8, p9) > 0) { temp = p8; p8 = p9; p9 = temp; }
			if (comparison.Invoke(p1, p2) > 0) { temp = p1; p1 = p2; p2 = temp; }
			if (comparison.Invoke(p4, p6) > 0) { temp = p4; p4 = p6; p6 = temp; }
			if (comparison.Invoke(p7, p8) > 0) { temp = p7; p7 = p8; p8 = temp; }
			if (comparison.Invoke(p3, p5) > 0) { temp = p3; p3 = p5; p5 = temp; }
			if (comparison.Invoke(p2, p5) > 0) { temp = p2; p2 = p5; p5 = temp; }
			if (comparison.Invoke(p6, p8) > 0) { temp = p6; p6 = p8; p8 = temp; }
			if (comparison.Invoke(p1, p3) > 0) { temp = p1; p1 = p3; p3 = temp; }
			if (comparison.Invoke(p4, p7) > 0) { temp = p4; p4 = p7; p7 = temp; }
			if (comparison.Invoke(p2, p3) > 0) { temp = p2; p2 = p3; p3 = temp; }
			if (comparison.Invoke(p6, p7) > 0) { temp = p6; p6 = p7; p7 = temp; }
			if (comparison.Invoke(p3, p4) > 0) { temp = p3; p3 = p4; p4 = temp; }
			if (comparison.Invoke(p5, p6) > 0) { temp = p5; p5 = p6; p6 = temp; }
			if (comparison.Invoke(p4, p5) > 0) { temp = p4; p4 = p5; p5 = temp; }
		}

		/// <summary>
		/// Sorts a collection of 11 elements in ascending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		public static new void Sort11Ascending<T>(ref T p0, Comparison<T> comparison)
		{
			ThrowHelper.NotNull(comparison, nameof(comparison));

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

			T temp;
			if (comparison.Invoke(p0, p1) > 0) { temp = p0; p0 = p1; p1 = temp; }
			if (comparison.Invoke(p2, p3) > 0) { temp = p2; p2 = p3; p3 = temp; }
			if (comparison.Invoke(p4, p5) > 0) { temp = p4; p4 = p5; p5 = temp; }
			if (comparison.Invoke(p6, p7) > 0) { temp = p6; p6 = p7; p7 = temp; }
			if (comparison.Invoke(p8, p9) > 0) { temp = p8; p8 = p9; p9 = temp; }
			if (comparison.Invoke(p1, p3) > 0) { temp = p1; p1 = p3; p3 = temp; }
			if (comparison.Invoke(p5, p7) > 0) { temp = p5; p5 = p7; p7 = temp; }
			if (comparison.Invoke(p0, p2) > 0) { temp = p0; p0 = p2; p2 = temp; }
			if (comparison.Invoke(p4, p6) > 0) { temp = p4; p4 = p6; p6 = temp; }
			if (comparison.Invoke(p8, p10) > 0) { temp = p8; p8 = p10; p10 = temp; }
			if (comparison.Invoke(p1, p2) > 0) { temp = p1; p1 = p2; p2 = temp; }
			if (comparison.Invoke(p5, p6) > 0) { temp = p5; p5 = p6; p6 = temp; }
			if (comparison.Invoke(p9, p10) > 0) { temp = p9; p9 = p10; p10 = temp; }
			if (comparison.Invoke(p0, p4) > 0) { temp = p0; p0 = p4; p4 = temp; }
			if (comparison.Invoke(p3, p7) > 0) { temp = p3; p3 = p7; p7 = temp; }
			if (comparison.Invoke(p1, p5) > 0) { temp = p1; p1 = p5; p5 = temp; }
			if (comparison.Invoke(p6, p10) > 0) { temp = p6; p6 = p10; p10 = temp; }
			if (comparison.Invoke(p4, p8) > 0) { temp = p4; p4 = p8; p8 = temp; }
			if (comparison.Invoke(p5, p9) > 0) { temp = p5; p5 = p9; p9 = temp; }
			if (comparison.Invoke(p2, p6) > 0) { temp = p2; p2 = p6; p6 = temp; }
			if (comparison.Invoke(p0, p4) > 0) { temp = p0; p0 = p4; p4 = temp; }
			if (comparison.Invoke(p3, p8) > 0) { temp = p3; p3 = p8; p8 = temp; }
			if (comparison.Invoke(p1, p5) > 0) { temp = p1; p1 = p5; p5 = temp; }
			if (comparison.Invoke(p6, p10) > 0) { temp = p6; p6 = p10; p10 = temp; }
			if (comparison.Invoke(p2, p3) > 0) { temp = p2; p2 = p3; p3 = temp; }
			if (comparison.Invoke(p8, p9) > 0) { temp = p8; p8 = p9; p9 = temp; }
			if (comparison.Invoke(p1, p4) > 0) { temp = p1; p1 = p4; p4 = temp; }
			if (comparison.Invoke(p7, p10) > 0) { temp = p7; p7 = p10; p10 = temp; }
			if (comparison.Invoke(p3, p5) > 0) { temp = p3; p3 = p5; p5 = temp; }
			if (comparison.Invoke(p6, p8) > 0) { temp = p6; p6 = p8; p8 = temp; }
			if (comparison.Invoke(p2, p4) > 0) { temp = p2; p2 = p4; p4 = temp; }
			if (comparison.Invoke(p7, p9) > 0) { temp = p7; p7 = p9; p9 = temp; }
			if (comparison.Invoke(p5, p6) > 0) { temp = p5; p5 = p6; p6 = temp; }
			if (comparison.Invoke(p3, p4) > 0) { temp = p3; p3 = p4; p4 = temp; }
			if (comparison.Invoke(p7, p8) > 0) { temp = p7; p7 = p8; p8 = temp; }
		}

		/// <summary>
		/// Sorts a collection of 12 elements in ascending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		public static new void Sort12Ascending<T>(ref T p0, Comparison<T> comparison)
		{
			ThrowHelper.NotNull(comparison, nameof(comparison));

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

			T temp;
			if (comparison.Invoke(p0, p1) > 0) { temp = p0; p0 = p1; p1 = temp; }
			if (comparison.Invoke(p2, p3) > 0) { temp = p2; p2 = p3; p3 = temp; }
			if (comparison.Invoke(p4, p5) > 0) { temp = p4; p4 = p5; p5 = temp; }
			if (comparison.Invoke(p6, p7) > 0) { temp = p6; p6 = p7; p7 = temp; }
			if (comparison.Invoke(p8, p9) > 0) { temp = p8; p8 = p9; p9 = temp; }
			if (comparison.Invoke(p10, p11) > 0) { temp = p10; p10 = p11; p11 = temp; }
			if (comparison.Invoke(p1, p3) > 0) { temp = p1; p1 = p3; p3 = temp; }
			if (comparison.Invoke(p5, p7) > 0) { temp = p5; p5 = p7; p7 = temp; }
			if (comparison.Invoke(p9, p11) > 0) { temp = p9; p9 = p11; p11 = temp; }
			if (comparison.Invoke(p0, p2) > 0) { temp = p0; p0 = p2; p2 = temp; }
			if (comparison.Invoke(p4, p6) > 0) { temp = p4; p4 = p6; p6 = temp; }
			if (comparison.Invoke(p8, p10) > 0) { temp = p8; p8 = p10; p10 = temp; }
			if (comparison.Invoke(p1, p2) > 0) { temp = p1; p1 = p2; p2 = temp; }
			if (comparison.Invoke(p5, p6) > 0) { temp = p5; p5 = p6; p6 = temp; }
			if (comparison.Invoke(p9, p10) > 0) { temp = p9; p9 = p10; p10 = temp; }
			if (comparison.Invoke(p0, p4) > 0) { temp = p0; p0 = p4; p4 = temp; }
			if (comparison.Invoke(p7, p11) > 0) { temp = p7; p7 = p11; p11 = temp; }
			if (comparison.Invoke(p1, p5) > 0) { temp = p1; p1 = p5; p5 = temp; }
			if (comparison.Invoke(p6, p10) > 0) { temp = p6; p6 = p10; p10 = temp; }
			if (comparison.Invoke(p3, p7) > 0) { temp = p3; p3 = p7; p7 = temp; }
			if (comparison.Invoke(p4, p8) > 0) { temp = p4; p4 = p8; p8 = temp; }
			if (comparison.Invoke(p5, p9) > 0) { temp = p5; p5 = p9; p9 = temp; }
			if (comparison.Invoke(p2, p6) > 0) { temp = p2; p2 = p6; p6 = temp; }
			if (comparison.Invoke(p0, p4) > 0) { temp = p0; p0 = p4; p4 = temp; }
			if (comparison.Invoke(p7, p11) > 0) { temp = p7; p7 = p11; p11 = temp; }
			if (comparison.Invoke(p3, p8) > 0) { temp = p3; p3 = p8; p8 = temp; }
			if (comparison.Invoke(p1, p5) > 0) { temp = p1; p1 = p5; p5 = temp; }
			if (comparison.Invoke(p6, p10) > 0) { temp = p6; p6 = p10; p10 = temp; }
			if (comparison.Invoke(p2, p3) > 0) { temp = p2; p2 = p3; p3 = temp; }
			if (comparison.Invoke(p8, p9) > 0) { temp = p8; p8 = p9; p9 = temp; }
			if (comparison.Invoke(p1, p4) > 0) { temp = p1; p1 = p4; p4 = temp; }
			if (comparison.Invoke(p7, p10) > 0) { temp = p7; p7 = p10; p10 = temp; }
			if (comparison.Invoke(p3, p5) > 0) { temp = p3; p3 = p5; p5 = temp; }
			if (comparison.Invoke(p6, p8) > 0) { temp = p6; p6 = p8; p8 = temp; }
			if (comparison.Invoke(p2, p4) > 0) { temp = p2; p2 = p4; p4 = temp; }
			if (comparison.Invoke(p7, p9) > 0) { temp = p7; p7 = p9; p9 = temp; }
			if (comparison.Invoke(p5, p6) > 0) { temp = p5; p5 = p6; p6 = temp; }
			if (comparison.Invoke(p3, p4) > 0) { temp = p3; p3 = p4; p4 = temp; }
			if (comparison.Invoke(p7, p8) > 0) { temp = p7; p7 = p8; p8 = temp; }
		}

		/// <summary>
		/// Sorts a collection of 13 elements in ascending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		public static new void Sort13Ascending<T>(ref T p0, Comparison<T> comparison)
		{
			ThrowHelper.NotNull(comparison, nameof(comparison));

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

			T temp;
			if (comparison.Invoke(p1, p7) > 0) { temp = p1; p1 = p7; p7 = temp; }
			if (comparison.Invoke(p9, p11) > 0) { temp = p9; p9 = p11; p11 = temp; }
			if (comparison.Invoke(p3, p4) > 0) { temp = p3; p3 = p4; p4 = temp; }
			if (comparison.Invoke(p5, p8) > 0) { temp = p5; p5 = p8; p8 = temp; }
			if (comparison.Invoke(p0, p12) > 0) { temp = p0; p0 = p12; p12 = temp; }
			if (comparison.Invoke(p2, p6) > 0) { temp = p2; p2 = p6; p6 = temp; }
			if (comparison.Invoke(p0, p1) > 0) { temp = p0; p0 = p1; p1 = temp; }
			if (comparison.Invoke(p2, p3) > 0) { temp = p2; p2 = p3; p3 = temp; }
			if (comparison.Invoke(p4, p6) > 0) { temp = p4; p4 = p6; p6 = temp; }
			if (comparison.Invoke(p8, p11) > 0) { temp = p8; p8 = p11; p11 = temp; }
			if (comparison.Invoke(p7, p12) > 0) { temp = p7; p7 = p12; p12 = temp; }
			if (comparison.Invoke(p5, p9) > 0) { temp = p5; p5 = p9; p9 = temp; }
			if (comparison.Invoke(p0, p2) > 0) { temp = p0; p0 = p2; p2 = temp; }
			if (comparison.Invoke(p3, p7) > 0) { temp = p3; p3 = p7; p7 = temp; }
			if (comparison.Invoke(p10, p11) > 0) { temp = p10; p10 = p11; p11 = temp; }
			if (comparison.Invoke(p1, p4) > 0) { temp = p1; p1 = p4; p4 = temp; }
			if (comparison.Invoke(p6, p12) > 0) { temp = p6; p6 = p12; p12 = temp; }
			if (comparison.Invoke(p7, p8) > 0) { temp = p7; p7 = p8; p8 = temp; }
			if (comparison.Invoke(p11, p12) > 0) { temp = p11; p11 = p12; p12 = temp; }
			if (comparison.Invoke(p4, p9) > 0) { temp = p4; p4 = p9; p9 = temp; }
			if (comparison.Invoke(p6, p10) > 0) { temp = p6; p6 = p10; p10 = temp; }
			if (comparison.Invoke(p3, p4) > 0) { temp = p3; p3 = p4; p4 = temp; }
			if (comparison.Invoke(p5, p6) > 0) { temp = p5; p5 = p6; p6 = temp; }
			if (comparison.Invoke(p8, p9) > 0) { temp = p8; p8 = p9; p9 = temp; }
			if (comparison.Invoke(p10, p11) > 0) { temp = p10; p10 = p11; p11 = temp; }
			if (comparison.Invoke(p1, p7) > 0) { temp = p1; p1 = p7; p7 = temp; }
			if (comparison.Invoke(p2, p6) > 0) { temp = p2; p2 = p6; p6 = temp; }
			if (comparison.Invoke(p9, p11) > 0) { temp = p9; p9 = p11; p11 = temp; }
			if (comparison.Invoke(p1, p3) > 0) { temp = p1; p1 = p3; p3 = temp; }
			if (comparison.Invoke(p4, p7) > 0) { temp = p4; p4 = p7; p7 = temp; }
			if (comparison.Invoke(p8, p10) > 0) { temp = p8; p8 = p10; p10 = temp; }
			if (comparison.Invoke(p0, p5) > 0) { temp = p0; p0 = p5; p5 = temp; }
			if (comparison.Invoke(p2, p5) > 0) { temp = p2; p2 = p5; p5 = temp; }
			if (comparison.Invoke(p6, p8) > 0) { temp = p6; p6 = p8; p8 = temp; }
			if (comparison.Invoke(p9, p10) > 0) { temp = p9; p9 = p10; p10 = temp; }
			if (comparison.Invoke(p1, p2) > 0) { temp = p1; p1 = p2; p2 = temp; }
			if (comparison.Invoke(p3, p5) > 0) { temp = p3; p3 = p5; p5 = temp; }
			if (comparison.Invoke(p7, p8) > 0) { temp = p7; p7 = p8; p8 = temp; }
			if (comparison.Invoke(p4, p6) > 0) { temp = p4; p4 = p6; p6 = temp; }
			if (comparison.Invoke(p2, p3) > 0) { temp = p2; p2 = p3; p3 = temp; }
			if (comparison.Invoke(p4, p5) > 0) { temp = p4; p4 = p5; p5 = temp; }
			if (comparison.Invoke(p6, p7) > 0) { temp = p6; p6 = p7; p7 = temp; }
			if (comparison.Invoke(p8, p9) > 0) { temp = p8; p8 = p9; p9 = temp; }
			if (comparison.Invoke(p3, p4) > 0) { temp = p3; p3 = p4; p4 = temp; }
			if (comparison.Invoke(p5, p6) > 0) { temp = p5; p5 = p6; p6 = temp; }
		}

		/// <summary>
		/// Sorts a collection of 14 elements in ascending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		public static new void Sort14Ascending<T>(ref T p0, Comparison<T> comparison)
		{
			ThrowHelper.NotNull(comparison, nameof(comparison));

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

			T temp;
			if (comparison.Invoke(p0, p1) > 0) { temp = p0; p0 = p1; p1 = temp; }
			if (comparison.Invoke(p2, p3) > 0) { temp = p2; p2 = p3; p3 = temp; }
			if (comparison.Invoke(p4, p5) > 0) { temp = p4; p4 = p5; p5 = temp; }
			if (comparison.Invoke(p6, p7) > 0) { temp = p6; p6 = p7; p7 = temp; }
			if (comparison.Invoke(p8, p9) > 0) { temp = p8; p8 = p9; p9 = temp; }
			if (comparison.Invoke(p10, p11) > 0) { temp = p10; p10 = p11; p11 = temp; }
			if (comparison.Invoke(p12, p13) > 0) { temp = p12; p12 = p13; p13 = temp; }
			if (comparison.Invoke(p0, p2) > 0) { temp = p0; p0 = p2; p2 = temp; }
			if (comparison.Invoke(p4, p6) > 0) { temp = p4; p4 = p6; p6 = temp; }
			if (comparison.Invoke(p8, p10) > 0) { temp = p8; p8 = p10; p10 = temp; }
			if (comparison.Invoke(p1, p3) > 0) { temp = p1; p1 = p3; p3 = temp; }
			if (comparison.Invoke(p5, p7) > 0) { temp = p5; p5 = p7; p7 = temp; }
			if (comparison.Invoke(p9, p11) > 0) { temp = p9; p9 = p11; p11 = temp; }
			if (comparison.Invoke(p0, p4) > 0) { temp = p0; p0 = p4; p4 = temp; }
			if (comparison.Invoke(p8, p12) > 0) { temp = p8; p8 = p12; p12 = temp; }
			if (comparison.Invoke(p1, p5) > 0) { temp = p1; p1 = p5; p5 = temp; }
			if (comparison.Invoke(p9, p13) > 0) { temp = p9; p9 = p13; p13 = temp; }
			if (comparison.Invoke(p2, p6) > 0) { temp = p2; p2 = p6; p6 = temp; }
			if (comparison.Invoke(p3, p7) > 0) { temp = p3; p3 = p7; p7 = temp; }
			if (comparison.Invoke(p0, p8) > 0) { temp = p0; p0 = p8; p8 = temp; }
			if (comparison.Invoke(p1, p9) > 0) { temp = p1; p1 = p9; p9 = temp; }
			if (comparison.Invoke(p2, p10) > 0) { temp = p2; p2 = p10; p10 = temp; }
			if (comparison.Invoke(p3, p11) > 0) { temp = p3; p3 = p11; p11 = temp; }
			if (comparison.Invoke(p4, p12) > 0) { temp = p4; p4 = p12; p12 = temp; }
			if (comparison.Invoke(p5, p13) > 0) { temp = p5; p5 = p13; p13 = temp; }
			if (comparison.Invoke(p5, p10) > 0) { temp = p5; p5 = p10; p10 = temp; }
			if (comparison.Invoke(p6, p9) > 0) { temp = p6; p6 = p9; p9 = temp; }
			if (comparison.Invoke(p3, p12) > 0) { temp = p3; p3 = p12; p12 = temp; }
			if (comparison.Invoke(p7, p11) > 0) { temp = p7; p7 = p11; p11 = temp; }
			if (comparison.Invoke(p1, p2) > 0) { temp = p1; p1 = p2; p2 = temp; }
			if (comparison.Invoke(p4, p8) > 0) { temp = p4; p4 = p8; p8 = temp; }
			if (comparison.Invoke(p1, p4) > 0) { temp = p1; p1 = p4; p4 = temp; }
			if (comparison.Invoke(p7, p13) > 0) { temp = p7; p7 = p13; p13 = temp; }
			if (comparison.Invoke(p2, p8) > 0) { temp = p2; p2 = p8; p8 = temp; }
			if (comparison.Invoke(p5, p6) > 0) { temp = p5; p5 = p6; p6 = temp; }
			if (comparison.Invoke(p9, p10) > 0) { temp = p9; p9 = p10; p10 = temp; }
			if (comparison.Invoke(p2, p4) > 0) { temp = p2; p2 = p4; p4 = temp; }
			if (comparison.Invoke(p11, p13) > 0) { temp = p11; p11 = p13; p13 = temp; }
			if (comparison.Invoke(p3, p8) > 0) { temp = p3; p3 = p8; p8 = temp; }
			if (comparison.Invoke(p7, p12) > 0) { temp = p7; p7 = p12; p12 = temp; }
			if (comparison.Invoke(p6, p8) > 0) { temp = p6; p6 = p8; p8 = temp; }
			if (comparison.Invoke(p10, p12) > 0) { temp = p10; p10 = p12; p12 = temp; }
			if (comparison.Invoke(p3, p5) > 0) { temp = p3; p3 = p5; p5 = temp; }
			if (comparison.Invoke(p7, p9) > 0) { temp = p7; p7 = p9; p9 = temp; }
			if (comparison.Invoke(p3, p4) > 0) { temp = p3; p3 = p4; p4 = temp; }
			if (comparison.Invoke(p5, p6) > 0) { temp = p5; p5 = p6; p6 = temp; }
			if (comparison.Invoke(p7, p8) > 0) { temp = p7; p7 = p8; p8 = temp; }
			if (comparison.Invoke(p9, p10) > 0) { temp = p9; p9 = p10; p10 = temp; }
			if (comparison.Invoke(p11, p12) > 0) { temp = p11; p11 = p12; p12 = temp; }
			if (comparison.Invoke(p6, p7) > 0) { temp = p6; p6 = p7; p7 = temp; }
			if (comparison.Invoke(p8, p9) > 0) { temp = p8; p8 = p9; p9 = temp; }
		}

		/// <summary>
		/// Sorts a collection of 15 elements in ascending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		public static new void Sort15Ascending<T>(ref T p0, Comparison<T> comparison)
		{
			ThrowHelper.NotNull(comparison, nameof(comparison));

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

			T temp;
			if (comparison.Invoke(p0, p1) > 0) { temp = p0; p0 = p1; p1 = temp; }
			if (comparison.Invoke(p2, p3) > 0) { temp = p2; p2 = p3; p3 = temp; }
			if (comparison.Invoke(p4, p5) > 0) { temp = p4; p4 = p5; p5 = temp; }
			if (comparison.Invoke(p6, p7) > 0) { temp = p6; p6 = p7; p7 = temp; }
			if (comparison.Invoke(p8, p9) > 0) { temp = p8; p8 = p9; p9 = temp; }
			if (comparison.Invoke(p10, p11) > 0) { temp = p10; p10 = p11; p11 = temp; }
			if (comparison.Invoke(p12, p13) > 0) { temp = p12; p12 = p13; p13 = temp; }
			if (comparison.Invoke(p0, p2) > 0) { temp = p0; p0 = p2; p2 = temp; }
			if (comparison.Invoke(p4, p6) > 0) { temp = p4; p4 = p6; p6 = temp; }
			if (comparison.Invoke(p8, p10) > 0) { temp = p8; p8 = p10; p10 = temp; }
			if (comparison.Invoke(p12, p14) > 0) { temp = p12; p12 = p14; p14 = temp; }
			if (comparison.Invoke(p1, p3) > 0) { temp = p1; p1 = p3; p3 = temp; }
			if (comparison.Invoke(p5, p7) > 0) { temp = p5; p5 = p7; p7 = temp; }
			if (comparison.Invoke(p9, p11) > 0) { temp = p9; p9 = p11; p11 = temp; }
			if (comparison.Invoke(p0, p4) > 0) { temp = p0; p0 = p4; p4 = temp; }
			if (comparison.Invoke(p8, p12) > 0) { temp = p8; p8 = p12; p12 = temp; }
			if (comparison.Invoke(p1, p5) > 0) { temp = p1; p1 = p5; p5 = temp; }
			if (comparison.Invoke(p9, p13) > 0) { temp = p9; p9 = p13; p13 = temp; }
			if (comparison.Invoke(p2, p6) > 0) { temp = p2; p2 = p6; p6 = temp; }
			if (comparison.Invoke(p10, p14) > 0) { temp = p10; p10 = p14; p14 = temp; }
			if (comparison.Invoke(p3, p7) > 0) { temp = p3; p3 = p7; p7 = temp; }
			if (comparison.Invoke(p0, p8) > 0) { temp = p0; p0 = p8; p8 = temp; }
			if (comparison.Invoke(p1, p9) > 0) { temp = p1; p1 = p9; p9 = temp; }
			if (comparison.Invoke(p2, p10) > 0) { temp = p2; p2 = p10; p10 = temp; }
			if (comparison.Invoke(p3, p11) > 0) { temp = p3; p3 = p11; p11 = temp; }
			if (comparison.Invoke(p4, p12) > 0) { temp = p4; p4 = p12; p12 = temp; }
			if (comparison.Invoke(p5, p13) > 0) { temp = p5; p5 = p13; p13 = temp; }
			if (comparison.Invoke(p6, p14) > 0) { temp = p6; p6 = p14; p14 = temp; }
			if (comparison.Invoke(p5, p10) > 0) { temp = p5; p5 = p10; p10 = temp; }
			if (comparison.Invoke(p6, p9) > 0) { temp = p6; p6 = p9; p9 = temp; }
			if (comparison.Invoke(p3, p12) > 0) { temp = p3; p3 = p12; p12 = temp; }
			if (comparison.Invoke(p13, p14) > 0) { temp = p13; p13 = p14; p14 = temp; }
			if (comparison.Invoke(p7, p11) > 0) { temp = p7; p7 = p11; p11 = temp; }
			if (comparison.Invoke(p1, p2) > 0) { temp = p1; p1 = p2; p2 = temp; }
			if (comparison.Invoke(p4, p8) > 0) { temp = p4; p4 = p8; p8 = temp; }
			if (comparison.Invoke(p1, p4) > 0) { temp = p1; p1 = p4; p4 = temp; }
			if (comparison.Invoke(p7, p13) > 0) { temp = p7; p7 = p13; p13 = temp; }
			if (comparison.Invoke(p2, p8) > 0) { temp = p2; p2 = p8; p8 = temp; }
			if (comparison.Invoke(p11, p14) > 0) { temp = p11; p11 = p14; p14 = temp; }
			if (comparison.Invoke(p5, p6) > 0) { temp = p5; p5 = p6; p6 = temp; }
			if (comparison.Invoke(p9, p10) > 0) { temp = p9; p9 = p10; p10 = temp; }
			if (comparison.Invoke(p2, p4) > 0) { temp = p2; p2 = p4; p4 = temp; }
			if (comparison.Invoke(p11, p13) > 0) { temp = p11; p11 = p13; p13 = temp; }
			if (comparison.Invoke(p3, p8) > 0) { temp = p3; p3 = p8; p8 = temp; }
			if (comparison.Invoke(p7, p12) > 0) { temp = p7; p7 = p12; p12 = temp; }
			if (comparison.Invoke(p6, p8) > 0) { temp = p6; p6 = p8; p8 = temp; }
			if (comparison.Invoke(p10, p12) > 0) { temp = p10; p10 = p12; p12 = temp; }
			if (comparison.Invoke(p3, p5) > 0) { temp = p3; p3 = p5; p5 = temp; }
			if (comparison.Invoke(p7, p9) > 0) { temp = p7; p7 = p9; p9 = temp; }
			if (comparison.Invoke(p3, p4) > 0) { temp = p3; p3 = p4; p4 = temp; }
			if (comparison.Invoke(p5, p6) > 0) { temp = p5; p5 = p6; p6 = temp; }
			if (comparison.Invoke(p7, p8) > 0) { temp = p7; p7 = p8; p8 = temp; }
			if (comparison.Invoke(p9, p10) > 0) { temp = p9; p9 = p10; p10 = temp; }
			if (comparison.Invoke(p11, p12) > 0) { temp = p11; p11 = p12; p12 = temp; }
			if (comparison.Invoke(p6, p7) > 0) { temp = p6; p6 = p7; p7 = temp; }
			if (comparison.Invoke(p8, p9) > 0) { temp = p8; p8 = p9; p9 = temp; }
		}

		/// <summary>
		/// Sorts a collection of 16 elements in ascending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		public static new void Sort16Ascending<T>(ref T p0, Comparison<T> comparison)
		{
			ThrowHelper.NotNull(comparison, nameof(comparison));

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

			T temp;
			if (comparison.Invoke(p0, p1) > 0) { temp = p0; p0 = p1; p1 = temp; }
			if (comparison.Invoke(p2, p3) > 0) { temp = p2; p2 = p3; p3 = temp; }
			if (comparison.Invoke(p4, p5) > 0) { temp = p4; p4 = p5; p5 = temp; }
			if (comparison.Invoke(p6, p7) > 0) { temp = p6; p6 = p7; p7 = temp; }
			if (comparison.Invoke(p8, p9) > 0) { temp = p8; p8 = p9; p9 = temp; }
			if (comparison.Invoke(p10, p11) > 0) { temp = p10; p10 = p11; p11 = temp; }
			if (comparison.Invoke(p12, p13) > 0) { temp = p12; p12 = p13; p13 = temp; }
			if (comparison.Invoke(p14, p15) > 0) { temp = p14; p14 = p15; p15 = temp; }
			if (comparison.Invoke(p0, p2) > 0) { temp = p0; p0 = p2; p2 = temp; }
			if (comparison.Invoke(p4, p6) > 0) { temp = p4; p4 = p6; p6 = temp; }
			if (comparison.Invoke(p8, p10) > 0) { temp = p8; p8 = p10; p10 = temp; }
			if (comparison.Invoke(p12, p14) > 0) { temp = p12; p12 = p14; p14 = temp; }
			if (comparison.Invoke(p1, p3) > 0) { temp = p1; p1 = p3; p3 = temp; }
			if (comparison.Invoke(p5, p7) > 0) { temp = p5; p5 = p7; p7 = temp; }
			if (comparison.Invoke(p9, p11) > 0) { temp = p9; p9 = p11; p11 = temp; }
			if (comparison.Invoke(p13, p15) > 0) { temp = p13; p13 = p15; p15 = temp; }
			if (comparison.Invoke(p0, p4) > 0) { temp = p0; p0 = p4; p4 = temp; }
			if (comparison.Invoke(p8, p12) > 0) { temp = p8; p8 = p12; p12 = temp; }
			if (comparison.Invoke(p1, p5) > 0) { temp = p1; p1 = p5; p5 = temp; }
			if (comparison.Invoke(p9, p13) > 0) { temp = p9; p9 = p13; p13 = temp; }
			if (comparison.Invoke(p2, p6) > 0) { temp = p2; p2 = p6; p6 = temp; }
			if (comparison.Invoke(p10, p14) > 0) { temp = p10; p10 = p14; p14 = temp; }
			if (comparison.Invoke(p3, p7) > 0) { temp = p3; p3 = p7; p7 = temp; }
			if (comparison.Invoke(p11, p15) > 0) { temp = p11; p11 = p15; p15 = temp; }
			if (comparison.Invoke(p0, p8) > 0) { temp = p0; p0 = p8; p8 = temp; }
			if (comparison.Invoke(p1, p9) > 0) { temp = p1; p1 = p9; p9 = temp; }
			if (comparison.Invoke(p2, p10) > 0) { temp = p2; p2 = p10; p10 = temp; }
			if (comparison.Invoke(p3, p11) > 0) { temp = p3; p3 = p11; p11 = temp; }
			if (comparison.Invoke(p4, p12) > 0) { temp = p4; p4 = p12; p12 = temp; }
			if (comparison.Invoke(p5, p13) > 0) { temp = p5; p5 = p13; p13 = temp; }
			if (comparison.Invoke(p6, p14) > 0) { temp = p6; p6 = p14; p14 = temp; }
			if (comparison.Invoke(p7, p15) > 0) { temp = p7; p7 = p15; p15 = temp; }
			if (comparison.Invoke(p5, p10) > 0) { temp = p5; p5 = p10; p10 = temp; }
			if (comparison.Invoke(p6, p9) > 0) { temp = p6; p6 = p9; p9 = temp; }
			if (comparison.Invoke(p3, p12) > 0) { temp = p3; p3 = p12; p12 = temp; }
			if (comparison.Invoke(p13, p14) > 0) { temp = p13; p13 = p14; p14 = temp; }
			if (comparison.Invoke(p7, p11) > 0) { temp = p7; p7 = p11; p11 = temp; }
			if (comparison.Invoke(p1, p2) > 0) { temp = p1; p1 = p2; p2 = temp; }
			if (comparison.Invoke(p4, p8) > 0) { temp = p4; p4 = p8; p8 = temp; }
			if (comparison.Invoke(p1, p4) > 0) { temp = p1; p1 = p4; p4 = temp; }
			if (comparison.Invoke(p7, p13) > 0) { temp = p7; p7 = p13; p13 = temp; }
			if (comparison.Invoke(p2, p8) > 0) { temp = p2; p2 = p8; p8 = temp; }
			if (comparison.Invoke(p11, p14) > 0) { temp = p11; p11 = p14; p14 = temp; }
			if (comparison.Invoke(p5, p6) > 0) { temp = p5; p5 = p6; p6 = temp; }
			if (comparison.Invoke(p9, p10) > 0) { temp = p9; p9 = p10; p10 = temp; }
			if (comparison.Invoke(p2, p4) > 0) { temp = p2; p2 = p4; p4 = temp; }
			if (comparison.Invoke(p11, p13) > 0) { temp = p11; p11 = p13; p13 = temp; }
			if (comparison.Invoke(p3, p8) > 0) { temp = p3; p3 = p8; p8 = temp; }
			if (comparison.Invoke(p7, p12) > 0) { temp = p7; p7 = p12; p12 = temp; }
			if (comparison.Invoke(p6, p8) > 0) { temp = p6; p6 = p8; p8 = temp; }
			if (comparison.Invoke(p10, p12) > 0) { temp = p10; p10 = p12; p12 = temp; }
			if (comparison.Invoke(p3, p5) > 0) { temp = p3; p3 = p5; p5 = temp; }
			if (comparison.Invoke(p7, p9) > 0) { temp = p7; p7 = p9; p9 = temp; }
			if (comparison.Invoke(p3, p4) > 0) { temp = p3; p3 = p4; p4 = temp; }
			if (comparison.Invoke(p5, p6) > 0) { temp = p5; p5 = p6; p6 = temp; }
			if (comparison.Invoke(p7, p8) > 0) { temp = p7; p7 = p8; p8 = temp; }
			if (comparison.Invoke(p9, p10) > 0) { temp = p9; p9 = p10; p10 = temp; }
			if (comparison.Invoke(p11, p12) > 0) { temp = p11; p11 = p12; p12 = temp; }
			if (comparison.Invoke(p6, p7) > 0) { temp = p6; p6 = p7; p7 = temp; }
			if (comparison.Invoke(p8, p9) > 0) { temp = p8; p8 = p9; p9 = temp; }
		}


		/// <summary>
		/// Sorts a collection of specified number of elements in ascending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="length">the length of the collection</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		/// <exception cref="ArgumentOutOfRangeException">collection length is not between <see cref="MinLength"/> and <see cref="MaxLength"/></exception>
		public static new void SortAscending<T>(ref T p0, in int length, Comparison<T> comparison)
			where T : IComparable<T>
		{
			ThrowHelper.NotNull(comparison, nameof(comparison));

			switch (length)
			{
				case 2: Sort2Ascending(ref p0, comparison); break;
				case 3: Sort3Ascending(ref p0, comparison); break;
				case 4: Sort4Ascending(ref p0, comparison); break;
				case 5: Sort5Ascending(ref p0, comparison); break;
				case 6: Sort6Ascending(ref p0, comparison); break;
				case 7: Sort7Ascending(ref p0, comparison); break;
				case 8: Sort8Ascending(ref p0, comparison); break;
				case 9: Sort9Ascending(ref p0, comparison); break;
				case 10: Sort10Ascending(ref p0, comparison); break;
				case 11: Sort11Ascending(ref p0, comparison); break;
				case 12: Sort12Ascending(ref p0, comparison); break;
				case 13: Sort13Ascending(ref p0, comparison); break;
				case 14: Sort14Ascending(ref p0, comparison); break;
				case 15: Sort15Ascending(ref p0, comparison); break;
				case 16: Sort16Ascending(ref p0, comparison); break;
				case 17: Sort17Ascending(ref p0, comparison); break;
				case 18: Sort18Ascending(ref p0, comparison); break;
				case 19: Sort19Ascending(ref p0, comparison); break;
				case 20: Sort20Ascending(ref p0, comparison); break;
				case 21: Sort21Ascending(ref p0, comparison); break;
				case 22: Sort22Ascending(ref p0, comparison); break;
				case 23: Sort23Ascending(ref p0, comparison); break;
				case 24: Sort24Ascending(ref p0, comparison); break;
				case 25: Sort25Ascending(ref p0, comparison); break;
				case 26: Sort26Ascending(ref p0, comparison); break;
				case 27: Sort27Ascending(ref p0, comparison); break;
				case 28: Sort28Ascending(ref p0, comparison); break;
				case 29: Sort29Ascending(ref p0, comparison); break;
				case 30: Sort30Ascending(ref p0, comparison); break;
				case 31: Sort31Ascending(ref p0, comparison); break;
				case 32: Sort32Ascending(ref p0, comparison); break;
				default: throw new ArgumentOutOfRangeException(nameof(length), $"Sorting network length `{length}` must be between `{MinLength}` and `{MaxLength}`.");
			}
		}
	}
}