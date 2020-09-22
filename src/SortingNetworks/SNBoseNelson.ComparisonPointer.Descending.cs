namespace SortingNetworks
{
	using System;
	using System.Runtime.CompilerServices;

	partial class SNBoseNelson
	{
		/// <summary>
		/// Sorts a collection of 2 elements in descending order using the specified function pointer.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparisonPointer">The function pointer to use when comparing elements.</param>
		public unsafe static void Sort2Descending<T>(ref T p0, delegate* managed<T, T, int> comparisonPointer)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);

			T temp;
			if (comparisonPointer(p0, p1) < 0) { temp = p0; p0 = p1; p1 = temp; }
		}

		/// <summary>
		/// Sorts a collection of 3 elements in descending order using the specified function pointer.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparisonPointer">The function pointer to use when comparing elements.</param>
		public unsafe static void Sort3Descending<T>(ref T p0, delegate* managed<T, T, int> comparisonPointer)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);

			T temp;
			if (comparisonPointer(p1, p2) < 0) { temp = p1; p1 = p2; p2 = temp; }
			if (comparisonPointer(p0, p2) < 0) { temp = p0; p0 = p2; p2 = temp; }
			if (comparisonPointer(p0, p1) < 0) { temp = p0; p0 = p1; p1 = temp; }
		}

		/// <summary>
		/// Sorts a collection of 4 elements in descending order using the specified function pointer.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparisonPointer">The function pointer to use when comparing elements.</param>
		public unsafe static void Sort4Descending<T>(ref T p0, delegate* managed<T, T, int> comparisonPointer)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);

			T temp;
			if (comparisonPointer(p0, p1) < 0) { temp = p0; p0 = p1; p1 = temp; }
			if (comparisonPointer(p2, p3) < 0) { temp = p2; p2 = p3; p3 = temp; }
			if (comparisonPointer(p0, p2) < 0) { temp = p0; p0 = p2; p2 = temp; }
			if (comparisonPointer(p1, p3) < 0) { temp = p1; p1 = p3; p3 = temp; }
			if (comparisonPointer(p1, p2) < 0) { temp = p1; p1 = p2; p2 = temp; }
		}

		/// <summary>
		/// Sorts a collection of 5 elements in descending order using the specified function pointer.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparisonPointer">The function pointer to use when comparing elements.</param>
		public unsafe static void Sort5Descending<T>(ref T p0, delegate* managed<T, T, int> comparisonPointer)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);

			T temp;
			if (comparisonPointer(p0, p1) < 0) { temp = p0; p0 = p1; p1 = temp; }
			if (comparisonPointer(p3, p4) < 0) { temp = p3; p3 = p4; p4 = temp; }
			if (comparisonPointer(p2, p4) < 0) { temp = p2; p2 = p4; p4 = temp; }
			if (comparisonPointer(p2, p3) < 0) { temp = p2; p2 = p3; p3 = temp; }
			if (comparisonPointer(p0, p3) < 0) { temp = p0; p0 = p3; p3 = temp; }
			if (comparisonPointer(p0, p2) < 0) { temp = p0; p0 = p2; p2 = temp; }
			if (comparisonPointer(p1, p4) < 0) { temp = p1; p1 = p4; p4 = temp; }
			if (comparisonPointer(p1, p3) < 0) { temp = p1; p1 = p3; p3 = temp; }
			if (comparisonPointer(p1, p2) < 0) { temp = p1; p1 = p2; p2 = temp; }
		}

		/// <summary>
		/// Sorts a collection of 6 elements in descending order using the specified function pointer.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparisonPointer">The function pointer to use when comparing elements.</param>
		public unsafe static void Sort6Descending<T>(ref T p0, delegate* managed<T, T, int> comparisonPointer)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);
			ref var p5 = ref Unsafe.Add(ref p0, 5);

			T temp;
			if (comparisonPointer(p1, p2) < 0) { temp = p1; p1 = p2; p2 = temp; }
			if (comparisonPointer(p0, p2) < 0) { temp = p0; p0 = p2; p2 = temp; }
			if (comparisonPointer(p0, p1) < 0) { temp = p0; p0 = p1; p1 = temp; }
			if (comparisonPointer(p4, p5) < 0) { temp = p4; p4 = p5; p5 = temp; }
			if (comparisonPointer(p3, p5) < 0) { temp = p3; p3 = p5; p5 = temp; }
			if (comparisonPointer(p3, p4) < 0) { temp = p3; p3 = p4; p4 = temp; }
			if (comparisonPointer(p0, p4) < 0) { temp = p0; p0 = p4; p4 = temp; }
			if (comparisonPointer(p0, p3) < 0) { temp = p0; p0 = p3; p3 = temp; }
			if (comparisonPointer(p1, p5) < 0) { temp = p1; p1 = p5; p5 = temp; }
			if (comparisonPointer(p2, p5) < 0) { temp = p2; p2 = p5; p5 = temp; }
			if (comparisonPointer(p1, p3) < 0) { temp = p1; p1 = p3; p3 = temp; }
			if (comparisonPointer(p2, p4) < 0) { temp = p2; p2 = p4; p4 = temp; }
			if (comparisonPointer(p2, p3) < 0) { temp = p2; p2 = p3; p3 = temp; }
		}

		/// <summary>
		/// Sorts a collection of 7 elements in descending order using the specified function pointer.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparisonPointer">The function pointer to use when comparing elements.</param>
		public unsafe static void Sort7Descending<T>(ref T p0, delegate* managed<T, T, int> comparisonPointer)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);
			ref var p5 = ref Unsafe.Add(ref p0, 5);
			ref var p6 = ref Unsafe.Add(ref p0, 6);

			T temp;
			if (comparisonPointer(p1, p2) < 0) { temp = p1; p1 = p2; p2 = temp; }
			if (comparisonPointer(p0, p2) < 0) { temp = p0; p0 = p2; p2 = temp; }
			if (comparisonPointer(p0, p1) < 0) { temp = p0; p0 = p1; p1 = temp; }
			if (comparisonPointer(p3, p4) < 0) { temp = p3; p3 = p4; p4 = temp; }
			if (comparisonPointer(p5, p6) < 0) { temp = p5; p5 = p6; p6 = temp; }
			if (comparisonPointer(p3, p5) < 0) { temp = p3; p3 = p5; p5 = temp; }
			if (comparisonPointer(p4, p6) < 0) { temp = p4; p4 = p6; p6 = temp; }
			if (comparisonPointer(p4, p5) < 0) { temp = p4; p4 = p5; p5 = temp; }
			if (comparisonPointer(p0, p4) < 0) { temp = p0; p0 = p4; p4 = temp; }
			if (comparisonPointer(p0, p3) < 0) { temp = p0; p0 = p3; p3 = temp; }
			if (comparisonPointer(p1, p5) < 0) { temp = p1; p1 = p5; p5 = temp; }
			if (comparisonPointer(p2, p6) < 0) { temp = p2; p2 = p6; p6 = temp; }
			if (comparisonPointer(p2, p5) < 0) { temp = p2; p2 = p5; p5 = temp; }
			if (comparisonPointer(p1, p3) < 0) { temp = p1; p1 = p3; p3 = temp; }
			if (comparisonPointer(p2, p4) < 0) { temp = p2; p2 = p4; p4 = temp; }
			if (comparisonPointer(p2, p3) < 0) { temp = p2; p2 = p3; p3 = temp; }
		}

		/// <summary>
		/// Sorts a collection of 8 elements in descending order using the specified function pointer.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparisonPointer">The function pointer to use when comparing elements.</param>
		public unsafe static void Sort8Descending<T>(ref T p0, delegate* managed<T, T, int> comparisonPointer)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);
			ref var p5 = ref Unsafe.Add(ref p0, 5);
			ref var p6 = ref Unsafe.Add(ref p0, 6);
			ref var p7 = ref Unsafe.Add(ref p0, 7);

			T temp;
			if (comparisonPointer(p0, p1) < 0) { temp = p0; p0 = p1; p1 = temp; }
			if (comparisonPointer(p2, p3) < 0) { temp = p2; p2 = p3; p3 = temp; }
			if (comparisonPointer(p0, p2) < 0) { temp = p0; p0 = p2; p2 = temp; }
			if (comparisonPointer(p1, p3) < 0) { temp = p1; p1 = p3; p3 = temp; }
			if (comparisonPointer(p1, p2) < 0) { temp = p1; p1 = p2; p2 = temp; }
			if (comparisonPointer(p4, p5) < 0) { temp = p4; p4 = p5; p5 = temp; }
			if (comparisonPointer(p6, p7) < 0) { temp = p6; p6 = p7; p7 = temp; }
			if (comparisonPointer(p4, p6) < 0) { temp = p4; p4 = p6; p6 = temp; }
			if (comparisonPointer(p5, p7) < 0) { temp = p5; p5 = p7; p7 = temp; }
			if (comparisonPointer(p5, p6) < 0) { temp = p5; p5 = p6; p6 = temp; }
			if (comparisonPointer(p0, p4) < 0) { temp = p0; p0 = p4; p4 = temp; }
			if (comparisonPointer(p1, p5) < 0) { temp = p1; p1 = p5; p5 = temp; }
			if (comparisonPointer(p1, p4) < 0) { temp = p1; p1 = p4; p4 = temp; }
			if (comparisonPointer(p2, p6) < 0) { temp = p2; p2 = p6; p6 = temp; }
			if (comparisonPointer(p3, p7) < 0) { temp = p3; p3 = p7; p7 = temp; }
			if (comparisonPointer(p3, p6) < 0) { temp = p3; p3 = p6; p6 = temp; }
			if (comparisonPointer(p2, p4) < 0) { temp = p2; p2 = p4; p4 = temp; }
			if (comparisonPointer(p3, p5) < 0) { temp = p3; p3 = p5; p5 = temp; }
			if (comparisonPointer(p3, p4) < 0) { temp = p3; p3 = p4; p4 = temp; }
		}

		/// <summary>
		/// Sorts a collection of 9 elements in descending order using the specified function pointer.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparisonPointer">The function pointer to use when comparing elements.</param>
		public unsafe static void Sort9Descending<T>(ref T p0, delegate* managed<T, T, int> comparisonPointer)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);
			ref var p5 = ref Unsafe.Add(ref p0, 5);
			ref var p6 = ref Unsafe.Add(ref p0, 6);
			ref var p7 = ref Unsafe.Add(ref p0, 7);
			ref var p8 = ref Unsafe.Add(ref p0, 8);

			T temp;
			if (comparisonPointer(p0, p1) < 0) { temp = p0; p0 = p1; p1 = temp; }
			if (comparisonPointer(p2, p3) < 0) { temp = p2; p2 = p3; p3 = temp; }
			if (comparisonPointer(p0, p2) < 0) { temp = p0; p0 = p2; p2 = temp; }
			if (comparisonPointer(p1, p3) < 0) { temp = p1; p1 = p3; p3 = temp; }
			if (comparisonPointer(p1, p2) < 0) { temp = p1; p1 = p2; p2 = temp; }
			if (comparisonPointer(p4, p5) < 0) { temp = p4; p4 = p5; p5 = temp; }
			if (comparisonPointer(p7, p8) < 0) { temp = p7; p7 = p8; p8 = temp; }
			if (comparisonPointer(p6, p8) < 0) { temp = p6; p6 = p8; p8 = temp; }
			if (comparisonPointer(p6, p7) < 0) { temp = p6; p6 = p7; p7 = temp; }
			if (comparisonPointer(p4, p7) < 0) { temp = p4; p4 = p7; p7 = temp; }
			if (comparisonPointer(p4, p6) < 0) { temp = p4; p4 = p6; p6 = temp; }
			if (comparisonPointer(p5, p8) < 0) { temp = p5; p5 = p8; p8 = temp; }
			if (comparisonPointer(p5, p7) < 0) { temp = p5; p5 = p7; p7 = temp; }
			if (comparisonPointer(p5, p6) < 0) { temp = p5; p5 = p6; p6 = temp; }
			if (comparisonPointer(p0, p5) < 0) { temp = p0; p0 = p5; p5 = temp; }
			if (comparisonPointer(p0, p4) < 0) { temp = p0; p0 = p4; p4 = temp; }
			if (comparisonPointer(p1, p6) < 0) { temp = p1; p1 = p6; p6 = temp; }
			if (comparisonPointer(p1, p5) < 0) { temp = p1; p1 = p5; p5 = temp; }
			if (comparisonPointer(p1, p4) < 0) { temp = p1; p1 = p4; p4 = temp; }
			if (comparisonPointer(p2, p7) < 0) { temp = p2; p2 = p7; p7 = temp; }
			if (comparisonPointer(p3, p8) < 0) { temp = p3; p3 = p8; p8 = temp; }
			if (comparisonPointer(p3, p7) < 0) { temp = p3; p3 = p7; p7 = temp; }
			if (comparisonPointer(p2, p5) < 0) { temp = p2; p2 = p5; p5 = temp; }
			if (comparisonPointer(p2, p4) < 0) { temp = p2; p2 = p4; p4 = temp; }
			if (comparisonPointer(p3, p6) < 0) { temp = p3; p3 = p6; p6 = temp; }
			if (comparisonPointer(p3, p5) < 0) { temp = p3; p3 = p5; p5 = temp; }
			if (comparisonPointer(p3, p4) < 0) { temp = p3; p3 = p4; p4 = temp; }
		}

		/// <summary>
		/// Sorts a collection of 10 elements in descending order using the specified function pointer.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparisonPointer">The function pointer to use when comparing elements.</param>
		public unsafe static void Sort10Descending<T>(ref T p0, delegate* managed<T, T, int> comparisonPointer)
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

			T temp;
			if (comparisonPointer(p0, p1) < 0) { temp = p0; p0 = p1; p1 = temp; }
			if (comparisonPointer(p3, p4) < 0) { temp = p3; p3 = p4; p4 = temp; }
			if (comparisonPointer(p2, p4) < 0) { temp = p2; p2 = p4; p4 = temp; }
			if (comparisonPointer(p2, p3) < 0) { temp = p2; p2 = p3; p3 = temp; }
			if (comparisonPointer(p0, p3) < 0) { temp = p0; p0 = p3; p3 = temp; }
			if (comparisonPointer(p0, p2) < 0) { temp = p0; p0 = p2; p2 = temp; }
			if (comparisonPointer(p1, p4) < 0) { temp = p1; p1 = p4; p4 = temp; }
			if (comparisonPointer(p1, p3) < 0) { temp = p1; p1 = p3; p3 = temp; }
			if (comparisonPointer(p1, p2) < 0) { temp = p1; p1 = p2; p2 = temp; }
			if (comparisonPointer(p5, p6) < 0) { temp = p5; p5 = p6; p6 = temp; }
			if (comparisonPointer(p8, p9) < 0) { temp = p8; p8 = p9; p9 = temp; }
			if (comparisonPointer(p7, p9) < 0) { temp = p7; p7 = p9; p9 = temp; }
			if (comparisonPointer(p7, p8) < 0) { temp = p7; p7 = p8; p8 = temp; }
			if (comparisonPointer(p5, p8) < 0) { temp = p5; p5 = p8; p8 = temp; }
			if (comparisonPointer(p5, p7) < 0) { temp = p5; p5 = p7; p7 = temp; }
			if (comparisonPointer(p6, p9) < 0) { temp = p6; p6 = p9; p9 = temp; }
			if (comparisonPointer(p6, p8) < 0) { temp = p6; p6 = p8; p8 = temp; }
			if (comparisonPointer(p6, p7) < 0) { temp = p6; p6 = p7; p7 = temp; }
			if (comparisonPointer(p0, p6) < 0) { temp = p0; p0 = p6; p6 = temp; }
			if (comparisonPointer(p0, p5) < 0) { temp = p0; p0 = p5; p5 = temp; }
			if (comparisonPointer(p1, p7) < 0) { temp = p1; p1 = p7; p7 = temp; }
			if (comparisonPointer(p1, p6) < 0) { temp = p1; p1 = p6; p6 = temp; }
			if (comparisonPointer(p1, p5) < 0) { temp = p1; p1 = p5; p5 = temp; }
			if (comparisonPointer(p2, p8) < 0) { temp = p2; p2 = p8; p8 = temp; }
			if (comparisonPointer(p3, p9) < 0) { temp = p3; p3 = p9; p9 = temp; }
			if (comparisonPointer(p4, p9) < 0) { temp = p4; p4 = p9; p9 = temp; }
			if (comparisonPointer(p3, p8) < 0) { temp = p3; p3 = p8; p8 = temp; }
			if (comparisonPointer(p4, p8) < 0) { temp = p4; p4 = p8; p8 = temp; }
			if (comparisonPointer(p2, p6) < 0) { temp = p2; p2 = p6; p6 = temp; }
			if (comparisonPointer(p2, p5) < 0) { temp = p2; p2 = p5; p5 = temp; }
			if (comparisonPointer(p3, p7) < 0) { temp = p3; p3 = p7; p7 = temp; }
			if (comparisonPointer(p4, p7) < 0) { temp = p4; p4 = p7; p7 = temp; }
			if (comparisonPointer(p3, p5) < 0) { temp = p3; p3 = p5; p5 = temp; }
			if (comparisonPointer(p4, p6) < 0) { temp = p4; p4 = p6; p6 = temp; }
			if (comparisonPointer(p4, p5) < 0) { temp = p4; p4 = p5; p5 = temp; }
		}

		/// <summary>
		/// Sorts a collection of 11 elements in descending order using the specified function pointer.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparisonPointer">The function pointer to use when comparing elements.</param>
		public unsafe static void Sort11Descending<T>(ref T p0, delegate* managed<T, T, int> comparisonPointer)
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

			T temp;
			if (comparisonPointer(p0, p1) < 0) { temp = p0; p0 = p1; p1 = temp; }
			if (comparisonPointer(p3, p4) < 0) { temp = p3; p3 = p4; p4 = temp; }
			if (comparisonPointer(p2, p4) < 0) { temp = p2; p2 = p4; p4 = temp; }
			if (comparisonPointer(p2, p3) < 0) { temp = p2; p2 = p3; p3 = temp; }
			if (comparisonPointer(p0, p3) < 0) { temp = p0; p0 = p3; p3 = temp; }
			if (comparisonPointer(p0, p2) < 0) { temp = p0; p0 = p2; p2 = temp; }
			if (comparisonPointer(p1, p4) < 0) { temp = p1; p1 = p4; p4 = temp; }
			if (comparisonPointer(p1, p3) < 0) { temp = p1; p1 = p3; p3 = temp; }
			if (comparisonPointer(p1, p2) < 0) { temp = p1; p1 = p2; p2 = temp; }
			if (comparisonPointer(p6, p7) < 0) { temp = p6; p6 = p7; p7 = temp; }
			if (comparisonPointer(p5, p7) < 0) { temp = p5; p5 = p7; p7 = temp; }
			if (comparisonPointer(p5, p6) < 0) { temp = p5; p5 = p6; p6 = temp; }
			if (comparisonPointer(p9, p10) < 0) { temp = p9; p9 = p10; p10 = temp; }
			if (comparisonPointer(p8, p10) < 0) { temp = p8; p8 = p10; p10 = temp; }
			if (comparisonPointer(p8, p9) < 0) { temp = p8; p8 = p9; p9 = temp; }
			if (comparisonPointer(p5, p9) < 0) { temp = p5; p5 = p9; p9 = temp; }
			if (comparisonPointer(p5, p8) < 0) { temp = p5; p5 = p8; p8 = temp; }
			if (comparisonPointer(p6, p10) < 0) { temp = p6; p6 = p10; p10 = temp; }
			if (comparisonPointer(p7, p10) < 0) { temp = p7; p7 = p10; p10 = temp; }
			if (comparisonPointer(p6, p8) < 0) { temp = p6; p6 = p8; p8 = temp; }
			if (comparisonPointer(p7, p9) < 0) { temp = p7; p7 = p9; p9 = temp; }
			if (comparisonPointer(p7, p8) < 0) { temp = p7; p7 = p8; p8 = temp; }
			if (comparisonPointer(p0, p6) < 0) { temp = p0; p0 = p6; p6 = temp; }
			if (comparisonPointer(p0, p5) < 0) { temp = p0; p0 = p5; p5 = temp; }
			if (comparisonPointer(p1, p7) < 0) { temp = p1; p1 = p7; p7 = temp; }
			if (comparisonPointer(p1, p6) < 0) { temp = p1; p1 = p6; p6 = temp; }
			if (comparisonPointer(p1, p5) < 0) { temp = p1; p1 = p5; p5 = temp; }
			if (comparisonPointer(p2, p9) < 0) { temp = p2; p2 = p9; p9 = temp; }
			if (comparisonPointer(p2, p8) < 0) { temp = p2; p2 = p8; p8 = temp; }
			if (comparisonPointer(p3, p10) < 0) { temp = p3; p3 = p10; p10 = temp; }
			if (comparisonPointer(p4, p10) < 0) { temp = p4; p4 = p10; p10 = temp; }
			if (comparisonPointer(p3, p8) < 0) { temp = p3; p3 = p8; p8 = temp; }
			if (comparisonPointer(p4, p9) < 0) { temp = p4; p4 = p9; p9 = temp; }
			if (comparisonPointer(p4, p8) < 0) { temp = p4; p4 = p8; p8 = temp; }
			if (comparisonPointer(p2, p6) < 0) { temp = p2; p2 = p6; p6 = temp; }
			if (comparisonPointer(p2, p5) < 0) { temp = p2; p2 = p5; p5 = temp; }
			if (comparisonPointer(p3, p7) < 0) { temp = p3; p3 = p7; p7 = temp; }
			if (comparisonPointer(p4, p7) < 0) { temp = p4; p4 = p7; p7 = temp; }
			if (comparisonPointer(p3, p5) < 0) { temp = p3; p3 = p5; p5 = temp; }
			if (comparisonPointer(p4, p6) < 0) { temp = p4; p4 = p6; p6 = temp; }
			if (comparisonPointer(p4, p5) < 0) { temp = p4; p4 = p5; p5 = temp; }
		}

		/// <summary>
		/// Sorts a collection of 12 elements in descending order using the specified function pointer.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparisonPointer">The function pointer to use when comparing elements.</param>
		public unsafe static void Sort12Descending<T>(ref T p0, delegate* managed<T, T, int> comparisonPointer)
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

			T temp;
			if (comparisonPointer(p1, p2) < 0) { temp = p1; p1 = p2; p2 = temp; }
			if (comparisonPointer(p0, p2) < 0) { temp = p0; p0 = p2; p2 = temp; }
			if (comparisonPointer(p0, p1) < 0) { temp = p0; p0 = p1; p1 = temp; }
			if (comparisonPointer(p4, p5) < 0) { temp = p4; p4 = p5; p5 = temp; }
			if (comparisonPointer(p3, p5) < 0) { temp = p3; p3 = p5; p5 = temp; }
			if (comparisonPointer(p3, p4) < 0) { temp = p3; p3 = p4; p4 = temp; }
			if (comparisonPointer(p0, p4) < 0) { temp = p0; p0 = p4; p4 = temp; }
			if (comparisonPointer(p0, p3) < 0) { temp = p0; p0 = p3; p3 = temp; }
			if (comparisonPointer(p1, p5) < 0) { temp = p1; p1 = p5; p5 = temp; }
			if (comparisonPointer(p2, p5) < 0) { temp = p2; p2 = p5; p5 = temp; }
			if (comparisonPointer(p1, p3) < 0) { temp = p1; p1 = p3; p3 = temp; }
			if (comparisonPointer(p2, p4) < 0) { temp = p2; p2 = p4; p4 = temp; }
			if (comparisonPointer(p2, p3) < 0) { temp = p2; p2 = p3; p3 = temp; }
			if (comparisonPointer(p7, p8) < 0) { temp = p7; p7 = p8; p8 = temp; }
			if (comparisonPointer(p6, p8) < 0) { temp = p6; p6 = p8; p8 = temp; }
			if (comparisonPointer(p6, p7) < 0) { temp = p6; p6 = p7; p7 = temp; }
			if (comparisonPointer(p10, p11) < 0) { temp = p10; p10 = p11; p11 = temp; }
			if (comparisonPointer(p9, p11) < 0) { temp = p9; p9 = p11; p11 = temp; }
			if (comparisonPointer(p9, p10) < 0) { temp = p9; p9 = p10; p10 = temp; }
			if (comparisonPointer(p6, p10) < 0) { temp = p6; p6 = p10; p10 = temp; }
			if (comparisonPointer(p6, p9) < 0) { temp = p6; p6 = p9; p9 = temp; }
			if (comparisonPointer(p7, p11) < 0) { temp = p7; p7 = p11; p11 = temp; }
			if (comparisonPointer(p8, p11) < 0) { temp = p8; p8 = p11; p11 = temp; }
			if (comparisonPointer(p7, p9) < 0) { temp = p7; p7 = p9; p9 = temp; }
			if (comparisonPointer(p8, p10) < 0) { temp = p8; p8 = p10; p10 = temp; }
			if (comparisonPointer(p8, p9) < 0) { temp = p8; p8 = p9; p9 = temp; }
			if (comparisonPointer(p0, p7) < 0) { temp = p0; p0 = p7; p7 = temp; }
			if (comparisonPointer(p0, p6) < 0) { temp = p0; p0 = p6; p6 = temp; }
			if (comparisonPointer(p1, p8) < 0) { temp = p1; p1 = p8; p8 = temp; }
			if (comparisonPointer(p2, p8) < 0) { temp = p2; p2 = p8; p8 = temp; }
			if (comparisonPointer(p1, p6) < 0) { temp = p1; p1 = p6; p6 = temp; }
			if (comparisonPointer(p2, p7) < 0) { temp = p2; p2 = p7; p7 = temp; }
			if (comparisonPointer(p2, p6) < 0) { temp = p2; p2 = p6; p6 = temp; }
			if (comparisonPointer(p3, p10) < 0) { temp = p3; p3 = p10; p10 = temp; }
			if (comparisonPointer(p3, p9) < 0) { temp = p3; p3 = p9; p9 = temp; }
			if (comparisonPointer(p4, p11) < 0) { temp = p4; p4 = p11; p11 = temp; }
			if (comparisonPointer(p5, p11) < 0) { temp = p5; p5 = p11; p11 = temp; }
			if (comparisonPointer(p4, p9) < 0) { temp = p4; p4 = p9; p9 = temp; }
			if (comparisonPointer(p5, p10) < 0) { temp = p5; p5 = p10; p10 = temp; }
			if (comparisonPointer(p5, p9) < 0) { temp = p5; p5 = p9; p9 = temp; }
			if (comparisonPointer(p3, p7) < 0) { temp = p3; p3 = p7; p7 = temp; }
			if (comparisonPointer(p3, p6) < 0) { temp = p3; p3 = p6; p6 = temp; }
			if (comparisonPointer(p4, p8) < 0) { temp = p4; p4 = p8; p8 = temp; }
			if (comparisonPointer(p5, p8) < 0) { temp = p5; p5 = p8; p8 = temp; }
			if (comparisonPointer(p4, p6) < 0) { temp = p4; p4 = p6; p6 = temp; }
			if (comparisonPointer(p5, p7) < 0) { temp = p5; p5 = p7; p7 = temp; }
			if (comparisonPointer(p5, p6) < 0) { temp = p5; p5 = p6; p6 = temp; }
		}

		/// <summary>
		/// Sorts a collection of 13 elements in descending order using the specified function pointer.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparisonPointer">The function pointer to use when comparing elements.</param>
		public unsafe static void Sort13Descending<T>(ref T p0, delegate* managed<T, T, int> comparisonPointer)
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

			T temp;
			if (comparisonPointer(p1, p2) < 0) { temp = p1; p1 = p2; p2 = temp; }
			if (comparisonPointer(p0, p2) < 0) { temp = p0; p0 = p2; p2 = temp; }
			if (comparisonPointer(p0, p1) < 0) { temp = p0; p0 = p1; p1 = temp; }
			if (comparisonPointer(p4, p5) < 0) { temp = p4; p4 = p5; p5 = temp; }
			if (comparisonPointer(p3, p5) < 0) { temp = p3; p3 = p5; p5 = temp; }
			if (comparisonPointer(p3, p4) < 0) { temp = p3; p3 = p4; p4 = temp; }
			if (comparisonPointer(p0, p4) < 0) { temp = p0; p0 = p4; p4 = temp; }
			if (comparisonPointer(p0, p3) < 0) { temp = p0; p0 = p3; p3 = temp; }
			if (comparisonPointer(p1, p5) < 0) { temp = p1; p1 = p5; p5 = temp; }
			if (comparisonPointer(p2, p5) < 0) { temp = p2; p2 = p5; p5 = temp; }
			if (comparisonPointer(p1, p3) < 0) { temp = p1; p1 = p3; p3 = temp; }
			if (comparisonPointer(p2, p4) < 0) { temp = p2; p2 = p4; p4 = temp; }
			if (comparisonPointer(p2, p3) < 0) { temp = p2; p2 = p3; p3 = temp; }
			if (comparisonPointer(p7, p8) < 0) { temp = p7; p7 = p8; p8 = temp; }
			if (comparisonPointer(p6, p8) < 0) { temp = p6; p6 = p8; p8 = temp; }
			if (comparisonPointer(p6, p7) < 0) { temp = p6; p6 = p7; p7 = temp; }
			if (comparisonPointer(p9, p10) < 0) { temp = p9; p9 = p10; p10 = temp; }
			if (comparisonPointer(p11, p12) < 0) { temp = p11; p11 = p12; p12 = temp; }
			if (comparisonPointer(p9, p11) < 0) { temp = p9; p9 = p11; p11 = temp; }
			if (comparisonPointer(p10, p12) < 0) { temp = p10; p10 = p12; p12 = temp; }
			if (comparisonPointer(p10, p11) < 0) { temp = p10; p10 = p11; p11 = temp; }
			if (comparisonPointer(p6, p10) < 0) { temp = p6; p6 = p10; p10 = temp; }
			if (comparisonPointer(p6, p9) < 0) { temp = p6; p6 = p9; p9 = temp; }
			if (comparisonPointer(p7, p11) < 0) { temp = p7; p7 = p11; p11 = temp; }
			if (comparisonPointer(p8, p12) < 0) { temp = p8; p8 = p12; p12 = temp; }
			if (comparisonPointer(p8, p11) < 0) { temp = p8; p8 = p11; p11 = temp; }
			if (comparisonPointer(p7, p9) < 0) { temp = p7; p7 = p9; p9 = temp; }
			if (comparisonPointer(p8, p10) < 0) { temp = p8; p8 = p10; p10 = temp; }
			if (comparisonPointer(p8, p9) < 0) { temp = p8; p8 = p9; p9 = temp; }
			if (comparisonPointer(p0, p7) < 0) { temp = p0; p0 = p7; p7 = temp; }
			if (comparisonPointer(p0, p6) < 0) { temp = p0; p0 = p6; p6 = temp; }
			if (comparisonPointer(p1, p8) < 0) { temp = p1; p1 = p8; p8 = temp; }
			if (comparisonPointer(p2, p9) < 0) { temp = p2; p2 = p9; p9 = temp; }
			if (comparisonPointer(p2, p8) < 0) { temp = p2; p2 = p8; p8 = temp; }
			if (comparisonPointer(p1, p6) < 0) { temp = p1; p1 = p6; p6 = temp; }
			if (comparisonPointer(p2, p7) < 0) { temp = p2; p2 = p7; p7 = temp; }
			if (comparisonPointer(p2, p6) < 0) { temp = p2; p2 = p6; p6 = temp; }
			if (comparisonPointer(p3, p11) < 0) { temp = p3; p3 = p11; p11 = temp; }
			if (comparisonPointer(p3, p10) < 0) { temp = p3; p3 = p10; p10 = temp; }
			if (comparisonPointer(p4, p12) < 0) { temp = p4; p4 = p12; p12 = temp; }
			if (comparisonPointer(p5, p12) < 0) { temp = p5; p5 = p12; p12 = temp; }
			if (comparisonPointer(p4, p10) < 0) { temp = p4; p4 = p10; p10 = temp; }
			if (comparisonPointer(p5, p11) < 0) { temp = p5; p5 = p11; p11 = temp; }
			if (comparisonPointer(p5, p10) < 0) { temp = p5; p5 = p10; p10 = temp; }
			if (comparisonPointer(p3, p7) < 0) { temp = p3; p3 = p7; p7 = temp; }
			if (comparisonPointer(p3, p6) < 0) { temp = p3; p3 = p6; p6 = temp; }
			if (comparisonPointer(p4, p8) < 0) { temp = p4; p4 = p8; p8 = temp; }
			if (comparisonPointer(p5, p9) < 0) { temp = p5; p5 = p9; p9 = temp; }
			if (comparisonPointer(p5, p8) < 0) { temp = p5; p5 = p8; p8 = temp; }
			if (comparisonPointer(p4, p6) < 0) { temp = p4; p4 = p6; p6 = temp; }
			if (comparisonPointer(p5, p7) < 0) { temp = p5; p5 = p7; p7 = temp; }
			if (comparisonPointer(p5, p6) < 0) { temp = p5; p5 = p6; p6 = temp; }
		}

		/// <summary>
		/// Sorts a collection of 14 elements in descending order using the specified function pointer.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparisonPointer">The function pointer to use when comparing elements.</param>
		public unsafe static void Sort14Descending<T>(ref T p0, delegate* managed<T, T, int> comparisonPointer)
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

			T temp;
			if (comparisonPointer(p1, p2) < 0) { temp = p1; p1 = p2; p2 = temp; }
			if (comparisonPointer(p0, p2) < 0) { temp = p0; p0 = p2; p2 = temp; }
			if (comparisonPointer(p0, p1) < 0) { temp = p0; p0 = p1; p1 = temp; }
			if (comparisonPointer(p3, p4) < 0) { temp = p3; p3 = p4; p4 = temp; }
			if (comparisonPointer(p5, p6) < 0) { temp = p5; p5 = p6; p6 = temp; }
			if (comparisonPointer(p3, p5) < 0) { temp = p3; p3 = p5; p5 = temp; }
			if (comparisonPointer(p4, p6) < 0) { temp = p4; p4 = p6; p6 = temp; }
			if (comparisonPointer(p4, p5) < 0) { temp = p4; p4 = p5; p5 = temp; }
			if (comparisonPointer(p0, p4) < 0) { temp = p0; p0 = p4; p4 = temp; }
			if (comparisonPointer(p0, p3) < 0) { temp = p0; p0 = p3; p3 = temp; }
			if (comparisonPointer(p1, p5) < 0) { temp = p1; p1 = p5; p5 = temp; }
			if (comparisonPointer(p2, p6) < 0) { temp = p2; p2 = p6; p6 = temp; }
			if (comparisonPointer(p2, p5) < 0) { temp = p2; p2 = p5; p5 = temp; }
			if (comparisonPointer(p1, p3) < 0) { temp = p1; p1 = p3; p3 = temp; }
			if (comparisonPointer(p2, p4) < 0) { temp = p2; p2 = p4; p4 = temp; }
			if (comparisonPointer(p2, p3) < 0) { temp = p2; p2 = p3; p3 = temp; }
			if (comparisonPointer(p8, p9) < 0) { temp = p8; p8 = p9; p9 = temp; }
			if (comparisonPointer(p7, p9) < 0) { temp = p7; p7 = p9; p9 = temp; }
			if (comparisonPointer(p7, p8) < 0) { temp = p7; p7 = p8; p8 = temp; }
			if (comparisonPointer(p10, p11) < 0) { temp = p10; p10 = p11; p11 = temp; }
			if (comparisonPointer(p12, p13) < 0) { temp = p12; p12 = p13; p13 = temp; }
			if (comparisonPointer(p10, p12) < 0) { temp = p10; p10 = p12; p12 = temp; }
			if (comparisonPointer(p11, p13) < 0) { temp = p11; p11 = p13; p13 = temp; }
			if (comparisonPointer(p11, p12) < 0) { temp = p11; p11 = p12; p12 = temp; }
			if (comparisonPointer(p7, p11) < 0) { temp = p7; p7 = p11; p11 = temp; }
			if (comparisonPointer(p7, p10) < 0) { temp = p7; p7 = p10; p10 = temp; }
			if (comparisonPointer(p8, p12) < 0) { temp = p8; p8 = p12; p12 = temp; }
			if (comparisonPointer(p9, p13) < 0) { temp = p9; p9 = p13; p13 = temp; }
			if (comparisonPointer(p9, p12) < 0) { temp = p9; p9 = p12; p12 = temp; }
			if (comparisonPointer(p8, p10) < 0) { temp = p8; p8 = p10; p10 = temp; }
			if (comparisonPointer(p9, p11) < 0) { temp = p9; p9 = p11; p11 = temp; }
			if (comparisonPointer(p9, p10) < 0) { temp = p9; p9 = p10; p10 = temp; }
			if (comparisonPointer(p0, p8) < 0) { temp = p0; p0 = p8; p8 = temp; }
			if (comparisonPointer(p0, p7) < 0) { temp = p0; p0 = p7; p7 = temp; }
			if (comparisonPointer(p1, p9) < 0) { temp = p1; p1 = p9; p9 = temp; }
			if (comparisonPointer(p2, p10) < 0) { temp = p2; p2 = p10; p10 = temp; }
			if (comparisonPointer(p2, p9) < 0) { temp = p2; p2 = p9; p9 = temp; }
			if (comparisonPointer(p1, p7) < 0) { temp = p1; p1 = p7; p7 = temp; }
			if (comparisonPointer(p2, p8) < 0) { temp = p2; p2 = p8; p8 = temp; }
			if (comparisonPointer(p2, p7) < 0) { temp = p2; p2 = p7; p7 = temp; }
			if (comparisonPointer(p3, p11) < 0) { temp = p3; p3 = p11; p11 = temp; }
			if (comparisonPointer(p4, p12) < 0) { temp = p4; p4 = p12; p12 = temp; }
			if (comparisonPointer(p4, p11) < 0) { temp = p4; p4 = p11; p11 = temp; }
			if (comparisonPointer(p5, p13) < 0) { temp = p5; p5 = p13; p13 = temp; }
			if (comparisonPointer(p6, p13) < 0) { temp = p6; p6 = p13; p13 = temp; }
			if (comparisonPointer(p5, p11) < 0) { temp = p5; p5 = p11; p11 = temp; }
			if (comparisonPointer(p6, p12) < 0) { temp = p6; p6 = p12; p12 = temp; }
			if (comparisonPointer(p6, p11) < 0) { temp = p6; p6 = p11; p11 = temp; }
			if (comparisonPointer(p3, p7) < 0) { temp = p3; p3 = p7; p7 = temp; }
			if (comparisonPointer(p4, p8) < 0) { temp = p4; p4 = p8; p8 = temp; }
			if (comparisonPointer(p4, p7) < 0) { temp = p4; p4 = p7; p7 = temp; }
			if (comparisonPointer(p5, p9) < 0) { temp = p5; p5 = p9; p9 = temp; }
			if (comparisonPointer(p6, p10) < 0) { temp = p6; p6 = p10; p10 = temp; }
			if (comparisonPointer(p6, p9) < 0) { temp = p6; p6 = p9; p9 = temp; }
			if (comparisonPointer(p5, p7) < 0) { temp = p5; p5 = p7; p7 = temp; }
			if (comparisonPointer(p6, p8) < 0) { temp = p6; p6 = p8; p8 = temp; }
			if (comparisonPointer(p6, p7) < 0) { temp = p6; p6 = p7; p7 = temp; }
		}

		/// <summary>
		/// Sorts a collection of 15 elements in descending order using the specified function pointer.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparisonPointer">The function pointer to use when comparing elements.</param>
		public unsafe static void Sort15Descending<T>(ref T p0, delegate* managed<T, T, int> comparisonPointer)
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

			T temp;
			if (comparisonPointer(p1, p2) < 0) { temp = p1; p1 = p2; p2 = temp; }
			if (comparisonPointer(p0, p2) < 0) { temp = p0; p0 = p2; p2 = temp; }
			if (comparisonPointer(p0, p1) < 0) { temp = p0; p0 = p1; p1 = temp; }
			if (comparisonPointer(p3, p4) < 0) { temp = p3; p3 = p4; p4 = temp; }
			if (comparisonPointer(p5, p6) < 0) { temp = p5; p5 = p6; p6 = temp; }
			if (comparisonPointer(p3, p5) < 0) { temp = p3; p3 = p5; p5 = temp; }
			if (comparisonPointer(p4, p6) < 0) { temp = p4; p4 = p6; p6 = temp; }
			if (comparisonPointer(p4, p5) < 0) { temp = p4; p4 = p5; p5 = temp; }
			if (comparisonPointer(p0, p4) < 0) { temp = p0; p0 = p4; p4 = temp; }
			if (comparisonPointer(p0, p3) < 0) { temp = p0; p0 = p3; p3 = temp; }
			if (comparisonPointer(p1, p5) < 0) { temp = p1; p1 = p5; p5 = temp; }
			if (comparisonPointer(p2, p6) < 0) { temp = p2; p2 = p6; p6 = temp; }
			if (comparisonPointer(p2, p5) < 0) { temp = p2; p2 = p5; p5 = temp; }
			if (comparisonPointer(p1, p3) < 0) { temp = p1; p1 = p3; p3 = temp; }
			if (comparisonPointer(p2, p4) < 0) { temp = p2; p2 = p4; p4 = temp; }
			if (comparisonPointer(p2, p3) < 0) { temp = p2; p2 = p3; p3 = temp; }
			if (comparisonPointer(p7, p8) < 0) { temp = p7; p7 = p8; p8 = temp; }
			if (comparisonPointer(p9, p10) < 0) { temp = p9; p9 = p10; p10 = temp; }
			if (comparisonPointer(p7, p9) < 0) { temp = p7; p7 = p9; p9 = temp; }
			if (comparisonPointer(p8, p10) < 0) { temp = p8; p8 = p10; p10 = temp; }
			if (comparisonPointer(p8, p9) < 0) { temp = p8; p8 = p9; p9 = temp; }
			if (comparisonPointer(p11, p12) < 0) { temp = p11; p11 = p12; p12 = temp; }
			if (comparisonPointer(p13, p14) < 0) { temp = p13; p13 = p14; p14 = temp; }
			if (comparisonPointer(p11, p13) < 0) { temp = p11; p11 = p13; p13 = temp; }
			if (comparisonPointer(p12, p14) < 0) { temp = p12; p12 = p14; p14 = temp; }
			if (comparisonPointer(p12, p13) < 0) { temp = p12; p12 = p13; p13 = temp; }
			if (comparisonPointer(p7, p11) < 0) { temp = p7; p7 = p11; p11 = temp; }
			if (comparisonPointer(p8, p12) < 0) { temp = p8; p8 = p12; p12 = temp; }
			if (comparisonPointer(p8, p11) < 0) { temp = p8; p8 = p11; p11 = temp; }
			if (comparisonPointer(p9, p13) < 0) { temp = p9; p9 = p13; p13 = temp; }
			if (comparisonPointer(p10, p14) < 0) { temp = p10; p10 = p14; p14 = temp; }
			if (comparisonPointer(p10, p13) < 0) { temp = p10; p10 = p13; p13 = temp; }
			if (comparisonPointer(p9, p11) < 0) { temp = p9; p9 = p11; p11 = temp; }
			if (comparisonPointer(p10, p12) < 0) { temp = p10; p10 = p12; p12 = temp; }
			if (comparisonPointer(p10, p11) < 0) { temp = p10; p10 = p11; p11 = temp; }
			if (comparisonPointer(p0, p8) < 0) { temp = p0; p0 = p8; p8 = temp; }
			if (comparisonPointer(p0, p7) < 0) { temp = p0; p0 = p7; p7 = temp; }
			if (comparisonPointer(p1, p9) < 0) { temp = p1; p1 = p9; p9 = temp; }
			if (comparisonPointer(p2, p10) < 0) { temp = p2; p2 = p10; p10 = temp; }
			if (comparisonPointer(p2, p9) < 0) { temp = p2; p2 = p9; p9 = temp; }
			if (comparisonPointer(p1, p7) < 0) { temp = p1; p1 = p7; p7 = temp; }
			if (comparisonPointer(p2, p8) < 0) { temp = p2; p2 = p8; p8 = temp; }
			if (comparisonPointer(p2, p7) < 0) { temp = p2; p2 = p7; p7 = temp; }
			if (comparisonPointer(p3, p11) < 0) { temp = p3; p3 = p11; p11 = temp; }
			if (comparisonPointer(p4, p12) < 0) { temp = p4; p4 = p12; p12 = temp; }
			if (comparisonPointer(p4, p11) < 0) { temp = p4; p4 = p11; p11 = temp; }
			if (comparisonPointer(p5, p13) < 0) { temp = p5; p5 = p13; p13 = temp; }
			if (comparisonPointer(p6, p14) < 0) { temp = p6; p6 = p14; p14 = temp; }
			if (comparisonPointer(p6, p13) < 0) { temp = p6; p6 = p13; p13 = temp; }
			if (comparisonPointer(p5, p11) < 0) { temp = p5; p5 = p11; p11 = temp; }
			if (comparisonPointer(p6, p12) < 0) { temp = p6; p6 = p12; p12 = temp; }
			if (comparisonPointer(p6, p11) < 0) { temp = p6; p6 = p11; p11 = temp; }
			if (comparisonPointer(p3, p7) < 0) { temp = p3; p3 = p7; p7 = temp; }
			if (comparisonPointer(p4, p8) < 0) { temp = p4; p4 = p8; p8 = temp; }
			if (comparisonPointer(p4, p7) < 0) { temp = p4; p4 = p7; p7 = temp; }
			if (comparisonPointer(p5, p9) < 0) { temp = p5; p5 = p9; p9 = temp; }
			if (comparisonPointer(p6, p10) < 0) { temp = p6; p6 = p10; p10 = temp; }
			if (comparisonPointer(p6, p9) < 0) { temp = p6; p6 = p9; p9 = temp; }
			if (comparisonPointer(p5, p7) < 0) { temp = p5; p5 = p7; p7 = temp; }
			if (comparisonPointer(p6, p8) < 0) { temp = p6; p6 = p8; p8 = temp; }
			if (comparisonPointer(p6, p7) < 0) { temp = p6; p6 = p7; p7 = temp; }
		}

		/// <summary>
		/// Sorts a collection of 16 elements in descending order using the specified function pointer.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparisonPointer">The function pointer to use when comparing elements.</param>
		public unsafe static void Sort16Descending<T>(ref T p0, delegate* managed<T, T, int> comparisonPointer)
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

			T temp;
			if (comparisonPointer(p0, p1) < 0) { temp = p0; p0 = p1; p1 = temp; }
			if (comparisonPointer(p2, p3) < 0) { temp = p2; p2 = p3; p3 = temp; }
			if (comparisonPointer(p0, p2) < 0) { temp = p0; p0 = p2; p2 = temp; }
			if (comparisonPointer(p1, p3) < 0) { temp = p1; p1 = p3; p3 = temp; }
			if (comparisonPointer(p1, p2) < 0) { temp = p1; p1 = p2; p2 = temp; }
			if (comparisonPointer(p4, p5) < 0) { temp = p4; p4 = p5; p5 = temp; }
			if (comparisonPointer(p6, p7) < 0) { temp = p6; p6 = p7; p7 = temp; }
			if (comparisonPointer(p4, p6) < 0) { temp = p4; p4 = p6; p6 = temp; }
			if (comparisonPointer(p5, p7) < 0) { temp = p5; p5 = p7; p7 = temp; }
			if (comparisonPointer(p5, p6) < 0) { temp = p5; p5 = p6; p6 = temp; }
			if (comparisonPointer(p0, p4) < 0) { temp = p0; p0 = p4; p4 = temp; }
			if (comparisonPointer(p1, p5) < 0) { temp = p1; p1 = p5; p5 = temp; }
			if (comparisonPointer(p1, p4) < 0) { temp = p1; p1 = p4; p4 = temp; }
			if (comparisonPointer(p2, p6) < 0) { temp = p2; p2 = p6; p6 = temp; }
			if (comparisonPointer(p3, p7) < 0) { temp = p3; p3 = p7; p7 = temp; }
			if (comparisonPointer(p3, p6) < 0) { temp = p3; p3 = p6; p6 = temp; }
			if (comparisonPointer(p2, p4) < 0) { temp = p2; p2 = p4; p4 = temp; }
			if (comparisonPointer(p3, p5) < 0) { temp = p3; p3 = p5; p5 = temp; }
			if (comparisonPointer(p3, p4) < 0) { temp = p3; p3 = p4; p4 = temp; }
			if (comparisonPointer(p8, p9) < 0) { temp = p8; p8 = p9; p9 = temp; }
			if (comparisonPointer(p10, p11) < 0) { temp = p10; p10 = p11; p11 = temp; }
			if (comparisonPointer(p8, p10) < 0) { temp = p8; p8 = p10; p10 = temp; }
			if (comparisonPointer(p9, p11) < 0) { temp = p9; p9 = p11; p11 = temp; }
			if (comparisonPointer(p9, p10) < 0) { temp = p9; p9 = p10; p10 = temp; }
			if (comparisonPointer(p12, p13) < 0) { temp = p12; p12 = p13; p13 = temp; }
			if (comparisonPointer(p14, p15) < 0) { temp = p14; p14 = p15; p15 = temp; }
			if (comparisonPointer(p12, p14) < 0) { temp = p12; p12 = p14; p14 = temp; }
			if (comparisonPointer(p13, p15) < 0) { temp = p13; p13 = p15; p15 = temp; }
			if (comparisonPointer(p13, p14) < 0) { temp = p13; p13 = p14; p14 = temp; }
			if (comparisonPointer(p8, p12) < 0) { temp = p8; p8 = p12; p12 = temp; }
			if (comparisonPointer(p9, p13) < 0) { temp = p9; p9 = p13; p13 = temp; }
			if (comparisonPointer(p9, p12) < 0) { temp = p9; p9 = p12; p12 = temp; }
			if (comparisonPointer(p10, p14) < 0) { temp = p10; p10 = p14; p14 = temp; }
			if (comparisonPointer(p11, p15) < 0) { temp = p11; p11 = p15; p15 = temp; }
			if (comparisonPointer(p11, p14) < 0) { temp = p11; p11 = p14; p14 = temp; }
			if (comparisonPointer(p10, p12) < 0) { temp = p10; p10 = p12; p12 = temp; }
			if (comparisonPointer(p11, p13) < 0) { temp = p11; p11 = p13; p13 = temp; }
			if (comparisonPointer(p11, p12) < 0) { temp = p11; p11 = p12; p12 = temp; }
			if (comparisonPointer(p0, p8) < 0) { temp = p0; p0 = p8; p8 = temp; }
			if (comparisonPointer(p1, p9) < 0) { temp = p1; p1 = p9; p9 = temp; }
			if (comparisonPointer(p1, p8) < 0) { temp = p1; p1 = p8; p8 = temp; }
			if (comparisonPointer(p2, p10) < 0) { temp = p2; p2 = p10; p10 = temp; }
			if (comparisonPointer(p3, p11) < 0) { temp = p3; p3 = p11; p11 = temp; }
			if (comparisonPointer(p3, p10) < 0) { temp = p3; p3 = p10; p10 = temp; }
			if (comparisonPointer(p2, p8) < 0) { temp = p2; p2 = p8; p8 = temp; }
			if (comparisonPointer(p3, p9) < 0) { temp = p3; p3 = p9; p9 = temp; }
			if (comparisonPointer(p3, p8) < 0) { temp = p3; p3 = p8; p8 = temp; }
			if (comparisonPointer(p4, p12) < 0) { temp = p4; p4 = p12; p12 = temp; }
			if (comparisonPointer(p5, p13) < 0) { temp = p5; p5 = p13; p13 = temp; }
			if (comparisonPointer(p5, p12) < 0) { temp = p5; p5 = p12; p12 = temp; }
			if (comparisonPointer(p6, p14) < 0) { temp = p6; p6 = p14; p14 = temp; }
			if (comparisonPointer(p7, p15) < 0) { temp = p7; p7 = p15; p15 = temp; }
			if (comparisonPointer(p7, p14) < 0) { temp = p7; p7 = p14; p14 = temp; }
			if (comparisonPointer(p6, p12) < 0) { temp = p6; p6 = p12; p12 = temp; }
			if (comparisonPointer(p7, p13) < 0) { temp = p7; p7 = p13; p13 = temp; }
			if (comparisonPointer(p7, p12) < 0) { temp = p7; p7 = p12; p12 = temp; }
			if (comparisonPointer(p4, p8) < 0) { temp = p4; p4 = p8; p8 = temp; }
			if (comparisonPointer(p5, p9) < 0) { temp = p5; p5 = p9; p9 = temp; }
			if (comparisonPointer(p5, p8) < 0) { temp = p5; p5 = p8; p8 = temp; }
			if (comparisonPointer(p6, p10) < 0) { temp = p6; p6 = p10; p10 = temp; }
			if (comparisonPointer(p7, p11) < 0) { temp = p7; p7 = p11; p11 = temp; }
			if (comparisonPointer(p7, p10) < 0) { temp = p7; p7 = p10; p10 = temp; }
			if (comparisonPointer(p6, p8) < 0) { temp = p6; p6 = p8; p8 = temp; }
			if (comparisonPointer(p7, p9) < 0) { temp = p7; p7 = p9; p9 = temp; }
			if (comparisonPointer(p7, p8) < 0) { temp = p7; p7 = p8; p8 = temp; }
		}

		/// <summary>
		/// Sorts a collection of 17 elements in descending order using the specified function pointer.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparisonPointer">The function pointer to use when comparing elements.</param>
		public unsafe static void Sort17Descending<T>(ref T p0, delegate* managed<T, T, int> comparisonPointer)
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
			ref var p16 = ref Unsafe.Add(ref p0, 16);

			T temp;
			if (comparisonPointer(p0, p1) < 0) { temp = p0; p0 = p1; p1 = temp; }
			if (comparisonPointer(p2, p3) < 0) { temp = p2; p2 = p3; p3 = temp; }
			if (comparisonPointer(p0, p2) < 0) { temp = p0; p0 = p2; p2 = temp; }
			if (comparisonPointer(p1, p3) < 0) { temp = p1; p1 = p3; p3 = temp; }
			if (comparisonPointer(p1, p2) < 0) { temp = p1; p1 = p2; p2 = temp; }
			if (comparisonPointer(p4, p5) < 0) { temp = p4; p4 = p5; p5 = temp; }
			if (comparisonPointer(p6, p7) < 0) { temp = p6; p6 = p7; p7 = temp; }
			if (comparisonPointer(p4, p6) < 0) { temp = p4; p4 = p6; p6 = temp; }
			if (comparisonPointer(p5, p7) < 0) { temp = p5; p5 = p7; p7 = temp; }
			if (comparisonPointer(p5, p6) < 0) { temp = p5; p5 = p6; p6 = temp; }
			if (comparisonPointer(p0, p4) < 0) { temp = p0; p0 = p4; p4 = temp; }
			if (comparisonPointer(p1, p5) < 0) { temp = p1; p1 = p5; p5 = temp; }
			if (comparisonPointer(p1, p4) < 0) { temp = p1; p1 = p4; p4 = temp; }
			if (comparisonPointer(p2, p6) < 0) { temp = p2; p2 = p6; p6 = temp; }
			if (comparisonPointer(p3, p7) < 0) { temp = p3; p3 = p7; p7 = temp; }
			if (comparisonPointer(p3, p6) < 0) { temp = p3; p3 = p6; p6 = temp; }
			if (comparisonPointer(p2, p4) < 0) { temp = p2; p2 = p4; p4 = temp; }
			if (comparisonPointer(p3, p5) < 0) { temp = p3; p3 = p5; p5 = temp; }
			if (comparisonPointer(p3, p4) < 0) { temp = p3; p3 = p4; p4 = temp; }
			if (comparisonPointer(p8, p9) < 0) { temp = p8; p8 = p9; p9 = temp; }
			if (comparisonPointer(p10, p11) < 0) { temp = p10; p10 = p11; p11 = temp; }
			if (comparisonPointer(p8, p10) < 0) { temp = p8; p8 = p10; p10 = temp; }
			if (comparisonPointer(p9, p11) < 0) { temp = p9; p9 = p11; p11 = temp; }
			if (comparisonPointer(p9, p10) < 0) { temp = p9; p9 = p10; p10 = temp; }
			if (comparisonPointer(p12, p13) < 0) { temp = p12; p12 = p13; p13 = temp; }
			if (comparisonPointer(p15, p16) < 0) { temp = p15; p15 = p16; p16 = temp; }
			if (comparisonPointer(p14, p16) < 0) { temp = p14; p14 = p16; p16 = temp; }
			if (comparisonPointer(p14, p15) < 0) { temp = p14; p14 = p15; p15 = temp; }
			if (comparisonPointer(p12, p15) < 0) { temp = p12; p12 = p15; p15 = temp; }
			if (comparisonPointer(p12, p14) < 0) { temp = p12; p12 = p14; p14 = temp; }
			if (comparisonPointer(p13, p16) < 0) { temp = p13; p13 = p16; p16 = temp; }
			if (comparisonPointer(p13, p15) < 0) { temp = p13; p13 = p15; p15 = temp; }
			if (comparisonPointer(p13, p14) < 0) { temp = p13; p13 = p14; p14 = temp; }
			if (comparisonPointer(p8, p13) < 0) { temp = p8; p8 = p13; p13 = temp; }
			if (comparisonPointer(p8, p12) < 0) { temp = p8; p8 = p12; p12 = temp; }
			if (comparisonPointer(p9, p14) < 0) { temp = p9; p9 = p14; p14 = temp; }
			if (comparisonPointer(p9, p13) < 0) { temp = p9; p9 = p13; p13 = temp; }
			if (comparisonPointer(p9, p12) < 0) { temp = p9; p9 = p12; p12 = temp; }
			if (comparisonPointer(p10, p15) < 0) { temp = p10; p10 = p15; p15 = temp; }
			if (comparisonPointer(p11, p16) < 0) { temp = p11; p11 = p16; p16 = temp; }
			if (comparisonPointer(p11, p15) < 0) { temp = p11; p11 = p15; p15 = temp; }
			if (comparisonPointer(p10, p13) < 0) { temp = p10; p10 = p13; p13 = temp; }
			if (comparisonPointer(p10, p12) < 0) { temp = p10; p10 = p12; p12 = temp; }
			if (comparisonPointer(p11, p14) < 0) { temp = p11; p11 = p14; p14 = temp; }
			if (comparisonPointer(p11, p13) < 0) { temp = p11; p11 = p13; p13 = temp; }
			if (comparisonPointer(p11, p12) < 0) { temp = p11; p11 = p12; p12 = temp; }
			if (comparisonPointer(p0, p9) < 0) { temp = p0; p0 = p9; p9 = temp; }
			if (comparisonPointer(p0, p8) < 0) { temp = p0; p0 = p8; p8 = temp; }
			if (comparisonPointer(p1, p10) < 0) { temp = p1; p1 = p10; p10 = temp; }
			if (comparisonPointer(p1, p9) < 0) { temp = p1; p1 = p9; p9 = temp; }
			if (comparisonPointer(p1, p8) < 0) { temp = p1; p1 = p8; p8 = temp; }
			if (comparisonPointer(p2, p11) < 0) { temp = p2; p2 = p11; p11 = temp; }
			if (comparisonPointer(p3, p12) < 0) { temp = p3; p3 = p12; p12 = temp; }
			if (comparisonPointer(p3, p11) < 0) { temp = p3; p3 = p11; p11 = temp; }
			if (comparisonPointer(p2, p9) < 0) { temp = p2; p2 = p9; p9 = temp; }
			if (comparisonPointer(p2, p8) < 0) { temp = p2; p2 = p8; p8 = temp; }
			if (comparisonPointer(p3, p10) < 0) { temp = p3; p3 = p10; p10 = temp; }
			if (comparisonPointer(p3, p9) < 0) { temp = p3; p3 = p9; p9 = temp; }
			if (comparisonPointer(p3, p8) < 0) { temp = p3; p3 = p8; p8 = temp; }
			if (comparisonPointer(p4, p13) < 0) { temp = p4; p4 = p13; p13 = temp; }
			if (comparisonPointer(p5, p14) < 0) { temp = p5; p5 = p14; p14 = temp; }
			if (comparisonPointer(p5, p13) < 0) { temp = p5; p5 = p13; p13 = temp; }
			if (comparisonPointer(p6, p15) < 0) { temp = p6; p6 = p15; p15 = temp; }
			if (comparisonPointer(p7, p16) < 0) { temp = p7; p7 = p16; p16 = temp; }
			if (comparisonPointer(p7, p15) < 0) { temp = p7; p7 = p15; p15 = temp; }
			if (comparisonPointer(p6, p13) < 0) { temp = p6; p6 = p13; p13 = temp; }
			if (comparisonPointer(p7, p14) < 0) { temp = p7; p7 = p14; p14 = temp; }
			if (comparisonPointer(p7, p13) < 0) { temp = p7; p7 = p13; p13 = temp; }
			if (comparisonPointer(p4, p9) < 0) { temp = p4; p4 = p9; p9 = temp; }
			if (comparisonPointer(p4, p8) < 0) { temp = p4; p4 = p8; p8 = temp; }
			if (comparisonPointer(p5, p10) < 0) { temp = p5; p5 = p10; p10 = temp; }
			if (comparisonPointer(p5, p9) < 0) { temp = p5; p5 = p9; p9 = temp; }
			if (comparisonPointer(p5, p8) < 0) { temp = p5; p5 = p8; p8 = temp; }
			if (comparisonPointer(p6, p11) < 0) { temp = p6; p6 = p11; p11 = temp; }
			if (comparisonPointer(p7, p12) < 0) { temp = p7; p7 = p12; p12 = temp; }
			if (comparisonPointer(p7, p11) < 0) { temp = p7; p7 = p11; p11 = temp; }
			if (comparisonPointer(p6, p9) < 0) { temp = p6; p6 = p9; p9 = temp; }
			if (comparisonPointer(p6, p8) < 0) { temp = p6; p6 = p8; p8 = temp; }
			if (comparisonPointer(p7, p10) < 0) { temp = p7; p7 = p10; p10 = temp; }
			if (comparisonPointer(p7, p9) < 0) { temp = p7; p7 = p9; p9 = temp; }
			if (comparisonPointer(p7, p8) < 0) { temp = p7; p7 = p8; p8 = temp; }
		}

		/// <summary>
		/// Sorts a collection of 18 elements in descending order using the specified function pointer.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparisonPointer">The function pointer to use when comparing elements.</param>
		public unsafe static void Sort18Descending<T>(ref T p0, delegate* managed<T, T, int> comparisonPointer)
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
			ref var p16 = ref Unsafe.Add(ref p0, 16);
			ref var p17 = ref Unsafe.Add(ref p0, 17);

			T temp;
			if (comparisonPointer(p0, p1) < 0) { temp = p0; p0 = p1; p1 = temp; }
			if (comparisonPointer(p2, p3) < 0) { temp = p2; p2 = p3; p3 = temp; }
			if (comparisonPointer(p0, p2) < 0) { temp = p0; p0 = p2; p2 = temp; }
			if (comparisonPointer(p1, p3) < 0) { temp = p1; p1 = p3; p3 = temp; }
			if (comparisonPointer(p1, p2) < 0) { temp = p1; p1 = p2; p2 = temp; }
			if (comparisonPointer(p4, p5) < 0) { temp = p4; p4 = p5; p5 = temp; }
			if (comparisonPointer(p7, p8) < 0) { temp = p7; p7 = p8; p8 = temp; }
			if (comparisonPointer(p6, p8) < 0) { temp = p6; p6 = p8; p8 = temp; }
			if (comparisonPointer(p6, p7) < 0) { temp = p6; p6 = p7; p7 = temp; }
			if (comparisonPointer(p4, p7) < 0) { temp = p4; p4 = p7; p7 = temp; }
			if (comparisonPointer(p4, p6) < 0) { temp = p4; p4 = p6; p6 = temp; }
			if (comparisonPointer(p5, p8) < 0) { temp = p5; p5 = p8; p8 = temp; }
			if (comparisonPointer(p5, p7) < 0) { temp = p5; p5 = p7; p7 = temp; }
			if (comparisonPointer(p5, p6) < 0) { temp = p5; p5 = p6; p6 = temp; }
			if (comparisonPointer(p0, p5) < 0) { temp = p0; p0 = p5; p5 = temp; }
			if (comparisonPointer(p0, p4) < 0) { temp = p0; p0 = p4; p4 = temp; }
			if (comparisonPointer(p1, p6) < 0) { temp = p1; p1 = p6; p6 = temp; }
			if (comparisonPointer(p1, p5) < 0) { temp = p1; p1 = p5; p5 = temp; }
			if (comparisonPointer(p1, p4) < 0) { temp = p1; p1 = p4; p4 = temp; }
			if (comparisonPointer(p2, p7) < 0) { temp = p2; p2 = p7; p7 = temp; }
			if (comparisonPointer(p3, p8) < 0) { temp = p3; p3 = p8; p8 = temp; }
			if (comparisonPointer(p3, p7) < 0) { temp = p3; p3 = p7; p7 = temp; }
			if (comparisonPointer(p2, p5) < 0) { temp = p2; p2 = p5; p5 = temp; }
			if (comparisonPointer(p2, p4) < 0) { temp = p2; p2 = p4; p4 = temp; }
			if (comparisonPointer(p3, p6) < 0) { temp = p3; p3 = p6; p6 = temp; }
			if (comparisonPointer(p3, p5) < 0) { temp = p3; p3 = p5; p5 = temp; }
			if (comparisonPointer(p3, p4) < 0) { temp = p3; p3 = p4; p4 = temp; }
			if (comparisonPointer(p9, p10) < 0) { temp = p9; p9 = p10; p10 = temp; }
			if (comparisonPointer(p11, p12) < 0) { temp = p11; p11 = p12; p12 = temp; }
			if (comparisonPointer(p9, p11) < 0) { temp = p9; p9 = p11; p11 = temp; }
			if (comparisonPointer(p10, p12) < 0) { temp = p10; p10 = p12; p12 = temp; }
			if (comparisonPointer(p10, p11) < 0) { temp = p10; p10 = p11; p11 = temp; }
			if (comparisonPointer(p13, p14) < 0) { temp = p13; p13 = p14; p14 = temp; }
			if (comparisonPointer(p16, p17) < 0) { temp = p16; p16 = p17; p17 = temp; }
			if (comparisonPointer(p15, p17) < 0) { temp = p15; p15 = p17; p17 = temp; }
			if (comparisonPointer(p15, p16) < 0) { temp = p15; p15 = p16; p16 = temp; }
			if (comparisonPointer(p13, p16) < 0) { temp = p13; p13 = p16; p16 = temp; }
			if (comparisonPointer(p13, p15) < 0) { temp = p13; p13 = p15; p15 = temp; }
			if (comparisonPointer(p14, p17) < 0) { temp = p14; p14 = p17; p17 = temp; }
			if (comparisonPointer(p14, p16) < 0) { temp = p14; p14 = p16; p16 = temp; }
			if (comparisonPointer(p14, p15) < 0) { temp = p14; p14 = p15; p15 = temp; }
			if (comparisonPointer(p9, p14) < 0) { temp = p9; p9 = p14; p14 = temp; }
			if (comparisonPointer(p9, p13) < 0) { temp = p9; p9 = p13; p13 = temp; }
			if (comparisonPointer(p10, p15) < 0) { temp = p10; p10 = p15; p15 = temp; }
			if (comparisonPointer(p10, p14) < 0) { temp = p10; p10 = p14; p14 = temp; }
			if (comparisonPointer(p10, p13) < 0) { temp = p10; p10 = p13; p13 = temp; }
			if (comparisonPointer(p11, p16) < 0) { temp = p11; p11 = p16; p16 = temp; }
			if (comparisonPointer(p12, p17) < 0) { temp = p12; p12 = p17; p17 = temp; }
			if (comparisonPointer(p12, p16) < 0) { temp = p12; p12 = p16; p16 = temp; }
			if (comparisonPointer(p11, p14) < 0) { temp = p11; p11 = p14; p14 = temp; }
			if (comparisonPointer(p11, p13) < 0) { temp = p11; p11 = p13; p13 = temp; }
			if (comparisonPointer(p12, p15) < 0) { temp = p12; p12 = p15; p15 = temp; }
			if (comparisonPointer(p12, p14) < 0) { temp = p12; p12 = p14; p14 = temp; }
			if (comparisonPointer(p12, p13) < 0) { temp = p12; p12 = p13; p13 = temp; }
			if (comparisonPointer(p0, p10) < 0) { temp = p0; p0 = p10; p10 = temp; }
			if (comparisonPointer(p0, p9) < 0) { temp = p0; p0 = p9; p9 = temp; }
			if (comparisonPointer(p1, p11) < 0) { temp = p1; p1 = p11; p11 = temp; }
			if (comparisonPointer(p1, p10) < 0) { temp = p1; p1 = p10; p10 = temp; }
			if (comparisonPointer(p1, p9) < 0) { temp = p1; p1 = p9; p9 = temp; }
			if (comparisonPointer(p2, p12) < 0) { temp = p2; p2 = p12; p12 = temp; }
			if (comparisonPointer(p3, p13) < 0) { temp = p3; p3 = p13; p13 = temp; }
			if (comparisonPointer(p3, p12) < 0) { temp = p3; p3 = p12; p12 = temp; }
			if (comparisonPointer(p2, p10) < 0) { temp = p2; p2 = p10; p10 = temp; }
			if (comparisonPointer(p2, p9) < 0) { temp = p2; p2 = p9; p9 = temp; }
			if (comparisonPointer(p3, p11) < 0) { temp = p3; p3 = p11; p11 = temp; }
			if (comparisonPointer(p3, p10) < 0) { temp = p3; p3 = p10; p10 = temp; }
			if (comparisonPointer(p3, p9) < 0) { temp = p3; p3 = p9; p9 = temp; }
			if (comparisonPointer(p4, p14) < 0) { temp = p4; p4 = p14; p14 = temp; }
			if (comparisonPointer(p5, p15) < 0) { temp = p5; p5 = p15; p15 = temp; }
			if (comparisonPointer(p5, p14) < 0) { temp = p5; p5 = p14; p14 = temp; }
			if (comparisonPointer(p6, p16) < 0) { temp = p6; p6 = p16; p16 = temp; }
			if (comparisonPointer(p7, p17) < 0) { temp = p7; p7 = p17; p17 = temp; }
			if (comparisonPointer(p8, p17) < 0) { temp = p8; p8 = p17; p17 = temp; }
			if (comparisonPointer(p7, p16) < 0) { temp = p7; p7 = p16; p16 = temp; }
			if (comparisonPointer(p8, p16) < 0) { temp = p8; p8 = p16; p16 = temp; }
			if (comparisonPointer(p6, p14) < 0) { temp = p6; p6 = p14; p14 = temp; }
			if (comparisonPointer(p7, p15) < 0) { temp = p7; p7 = p15; p15 = temp; }
			if (comparisonPointer(p8, p15) < 0) { temp = p8; p8 = p15; p15 = temp; }
			if (comparisonPointer(p7, p14) < 0) { temp = p7; p7 = p14; p14 = temp; }
			if (comparisonPointer(p8, p14) < 0) { temp = p8; p8 = p14; p14 = temp; }
			if (comparisonPointer(p4, p10) < 0) { temp = p4; p4 = p10; p10 = temp; }
			if (comparisonPointer(p4, p9) < 0) { temp = p4; p4 = p9; p9 = temp; }
			if (comparisonPointer(p5, p11) < 0) { temp = p5; p5 = p11; p11 = temp; }
			if (comparisonPointer(p5, p10) < 0) { temp = p5; p5 = p10; p10 = temp; }
			if (comparisonPointer(p5, p9) < 0) { temp = p5; p5 = p9; p9 = temp; }
			if (comparisonPointer(p6, p12) < 0) { temp = p6; p6 = p12; p12 = temp; }
			if (comparisonPointer(p7, p13) < 0) { temp = p7; p7 = p13; p13 = temp; }
			if (comparisonPointer(p8, p13) < 0) { temp = p8; p8 = p13; p13 = temp; }
			if (comparisonPointer(p7, p12) < 0) { temp = p7; p7 = p12; p12 = temp; }
			if (comparisonPointer(p8, p12) < 0) { temp = p8; p8 = p12; p12 = temp; }
			if (comparisonPointer(p6, p10) < 0) { temp = p6; p6 = p10; p10 = temp; }
			if (comparisonPointer(p6, p9) < 0) { temp = p6; p6 = p9; p9 = temp; }
			if (comparisonPointer(p7, p11) < 0) { temp = p7; p7 = p11; p11 = temp; }
			if (comparisonPointer(p8, p11) < 0) { temp = p8; p8 = p11; p11 = temp; }
			if (comparisonPointer(p7, p9) < 0) { temp = p7; p7 = p9; p9 = temp; }
			if (comparisonPointer(p8, p10) < 0) { temp = p8; p8 = p10; p10 = temp; }
			if (comparisonPointer(p8, p9) < 0) { temp = p8; p8 = p9; p9 = temp; }
		}

		/// <summary>
		/// Sorts a collection of 19 elements in descending order using the specified function pointer.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparisonPointer">The function pointer to use when comparing elements.</param>
		public unsafe static void Sort19Descending<T>(ref T p0, delegate* managed<T, T, int> comparisonPointer)
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
			ref var p16 = ref Unsafe.Add(ref p0, 16);
			ref var p17 = ref Unsafe.Add(ref p0, 17);
			ref var p18 = ref Unsafe.Add(ref p0, 18);

			T temp;
			if (comparisonPointer(p0, p1) < 0) { temp = p0; p0 = p1; p1 = temp; }
			if (comparisonPointer(p2, p3) < 0) { temp = p2; p2 = p3; p3 = temp; }
			if (comparisonPointer(p0, p2) < 0) { temp = p0; p0 = p2; p2 = temp; }
			if (comparisonPointer(p1, p3) < 0) { temp = p1; p1 = p3; p3 = temp; }
			if (comparisonPointer(p1, p2) < 0) { temp = p1; p1 = p2; p2 = temp; }
			if (comparisonPointer(p4, p5) < 0) { temp = p4; p4 = p5; p5 = temp; }
			if (comparisonPointer(p7, p8) < 0) { temp = p7; p7 = p8; p8 = temp; }
			if (comparisonPointer(p6, p8) < 0) { temp = p6; p6 = p8; p8 = temp; }
			if (comparisonPointer(p6, p7) < 0) { temp = p6; p6 = p7; p7 = temp; }
			if (comparisonPointer(p4, p7) < 0) { temp = p4; p4 = p7; p7 = temp; }
			if (comparisonPointer(p4, p6) < 0) { temp = p4; p4 = p6; p6 = temp; }
			if (comparisonPointer(p5, p8) < 0) { temp = p5; p5 = p8; p8 = temp; }
			if (comparisonPointer(p5, p7) < 0) { temp = p5; p5 = p7; p7 = temp; }
			if (comparisonPointer(p5, p6) < 0) { temp = p5; p5 = p6; p6 = temp; }
			if (comparisonPointer(p0, p5) < 0) { temp = p0; p0 = p5; p5 = temp; }
			if (comparisonPointer(p0, p4) < 0) { temp = p0; p0 = p4; p4 = temp; }
			if (comparisonPointer(p1, p6) < 0) { temp = p1; p1 = p6; p6 = temp; }
			if (comparisonPointer(p1, p5) < 0) { temp = p1; p1 = p5; p5 = temp; }
			if (comparisonPointer(p1, p4) < 0) { temp = p1; p1 = p4; p4 = temp; }
			if (comparisonPointer(p2, p7) < 0) { temp = p2; p2 = p7; p7 = temp; }
			if (comparisonPointer(p3, p8) < 0) { temp = p3; p3 = p8; p8 = temp; }
			if (comparisonPointer(p3, p7) < 0) { temp = p3; p3 = p7; p7 = temp; }
			if (comparisonPointer(p2, p5) < 0) { temp = p2; p2 = p5; p5 = temp; }
			if (comparisonPointer(p2, p4) < 0) { temp = p2; p2 = p4; p4 = temp; }
			if (comparisonPointer(p3, p6) < 0) { temp = p3; p3 = p6; p6 = temp; }
			if (comparisonPointer(p3, p5) < 0) { temp = p3; p3 = p5; p5 = temp; }
			if (comparisonPointer(p3, p4) < 0) { temp = p3; p3 = p4; p4 = temp; }
			if (comparisonPointer(p9, p10) < 0) { temp = p9; p9 = p10; p10 = temp; }
			if (comparisonPointer(p12, p13) < 0) { temp = p12; p12 = p13; p13 = temp; }
			if (comparisonPointer(p11, p13) < 0) { temp = p11; p11 = p13; p13 = temp; }
			if (comparisonPointer(p11, p12) < 0) { temp = p11; p11 = p12; p12 = temp; }
			if (comparisonPointer(p9, p12) < 0) { temp = p9; p9 = p12; p12 = temp; }
			if (comparisonPointer(p9, p11) < 0) { temp = p9; p9 = p11; p11 = temp; }
			if (comparisonPointer(p10, p13) < 0) { temp = p10; p10 = p13; p13 = temp; }
			if (comparisonPointer(p10, p12) < 0) { temp = p10; p10 = p12; p12 = temp; }
			if (comparisonPointer(p10, p11) < 0) { temp = p10; p10 = p11; p11 = temp; }
			if (comparisonPointer(p14, p15) < 0) { temp = p14; p14 = p15; p15 = temp; }
			if (comparisonPointer(p17, p18) < 0) { temp = p17; p17 = p18; p18 = temp; }
			if (comparisonPointer(p16, p18) < 0) { temp = p16; p16 = p18; p18 = temp; }
			if (comparisonPointer(p16, p17) < 0) { temp = p16; p16 = p17; p17 = temp; }
			if (comparisonPointer(p14, p17) < 0) { temp = p14; p14 = p17; p17 = temp; }
			if (comparisonPointer(p14, p16) < 0) { temp = p14; p14 = p16; p16 = temp; }
			if (comparisonPointer(p15, p18) < 0) { temp = p15; p15 = p18; p18 = temp; }
			if (comparisonPointer(p15, p17) < 0) { temp = p15; p15 = p17; p17 = temp; }
			if (comparisonPointer(p15, p16) < 0) { temp = p15; p15 = p16; p16 = temp; }
			if (comparisonPointer(p9, p15) < 0) { temp = p9; p9 = p15; p15 = temp; }
			if (comparisonPointer(p9, p14) < 0) { temp = p9; p9 = p14; p14 = temp; }
			if (comparisonPointer(p10, p16) < 0) { temp = p10; p10 = p16; p16 = temp; }
			if (comparisonPointer(p10, p15) < 0) { temp = p10; p10 = p15; p15 = temp; }
			if (comparisonPointer(p10, p14) < 0) { temp = p10; p10 = p14; p14 = temp; }
			if (comparisonPointer(p11, p17) < 0) { temp = p11; p11 = p17; p17 = temp; }
			if (comparisonPointer(p12, p18) < 0) { temp = p12; p12 = p18; p18 = temp; }
			if (comparisonPointer(p13, p18) < 0) { temp = p13; p13 = p18; p18 = temp; }
			if (comparisonPointer(p12, p17) < 0) { temp = p12; p12 = p17; p17 = temp; }
			if (comparisonPointer(p13, p17) < 0) { temp = p13; p13 = p17; p17 = temp; }
			if (comparisonPointer(p11, p15) < 0) { temp = p11; p11 = p15; p15 = temp; }
			if (comparisonPointer(p11, p14) < 0) { temp = p11; p11 = p14; p14 = temp; }
			if (comparisonPointer(p12, p16) < 0) { temp = p12; p12 = p16; p16 = temp; }
			if (comparisonPointer(p13, p16) < 0) { temp = p13; p13 = p16; p16 = temp; }
			if (comparisonPointer(p12, p14) < 0) { temp = p12; p12 = p14; p14 = temp; }
			if (comparisonPointer(p13, p15) < 0) { temp = p13; p13 = p15; p15 = temp; }
			if (comparisonPointer(p13, p14) < 0) { temp = p13; p13 = p14; p14 = temp; }
			if (comparisonPointer(p0, p10) < 0) { temp = p0; p0 = p10; p10 = temp; }
			if (comparisonPointer(p0, p9) < 0) { temp = p0; p0 = p9; p9 = temp; }
			if (comparisonPointer(p1, p11) < 0) { temp = p1; p1 = p11; p11 = temp; }
			if (comparisonPointer(p1, p10) < 0) { temp = p1; p1 = p10; p10 = temp; }
			if (comparisonPointer(p1, p9) < 0) { temp = p1; p1 = p9; p9 = temp; }
			if (comparisonPointer(p2, p12) < 0) { temp = p2; p2 = p12; p12 = temp; }
			if (comparisonPointer(p3, p13) < 0) { temp = p3; p3 = p13; p13 = temp; }
			if (comparisonPointer(p3, p12) < 0) { temp = p3; p3 = p12; p12 = temp; }
			if (comparisonPointer(p2, p10) < 0) { temp = p2; p2 = p10; p10 = temp; }
			if (comparisonPointer(p2, p9) < 0) { temp = p2; p2 = p9; p9 = temp; }
			if (comparisonPointer(p3, p11) < 0) { temp = p3; p3 = p11; p11 = temp; }
			if (comparisonPointer(p3, p10) < 0) { temp = p3; p3 = p10; p10 = temp; }
			if (comparisonPointer(p3, p9) < 0) { temp = p3; p3 = p9; p9 = temp; }
			if (comparisonPointer(p4, p15) < 0) { temp = p4; p4 = p15; p15 = temp; }
			if (comparisonPointer(p4, p14) < 0) { temp = p4; p4 = p14; p14 = temp; }
			if (comparisonPointer(p5, p16) < 0) { temp = p5; p5 = p16; p16 = temp; }
			if (comparisonPointer(p5, p15) < 0) { temp = p5; p5 = p15; p15 = temp; }
			if (comparisonPointer(p5, p14) < 0) { temp = p5; p5 = p14; p14 = temp; }
			if (comparisonPointer(p6, p17) < 0) { temp = p6; p6 = p17; p17 = temp; }
			if (comparisonPointer(p7, p18) < 0) { temp = p7; p7 = p18; p18 = temp; }
			if (comparisonPointer(p8, p18) < 0) { temp = p8; p8 = p18; p18 = temp; }
			if (comparisonPointer(p7, p17) < 0) { temp = p7; p7 = p17; p17 = temp; }
			if (comparisonPointer(p8, p17) < 0) { temp = p8; p8 = p17; p17 = temp; }
			if (comparisonPointer(p6, p15) < 0) { temp = p6; p6 = p15; p15 = temp; }
			if (comparisonPointer(p6, p14) < 0) { temp = p6; p6 = p14; p14 = temp; }
			if (comparisonPointer(p7, p16) < 0) { temp = p7; p7 = p16; p16 = temp; }
			if (comparisonPointer(p8, p16) < 0) { temp = p8; p8 = p16; p16 = temp; }
			if (comparisonPointer(p7, p14) < 0) { temp = p7; p7 = p14; p14 = temp; }
			if (comparisonPointer(p8, p15) < 0) { temp = p8; p8 = p15; p15 = temp; }
			if (comparisonPointer(p8, p14) < 0) { temp = p8; p8 = p14; p14 = temp; }
			if (comparisonPointer(p4, p10) < 0) { temp = p4; p4 = p10; p10 = temp; }
			if (comparisonPointer(p4, p9) < 0) { temp = p4; p4 = p9; p9 = temp; }
			if (comparisonPointer(p5, p11) < 0) { temp = p5; p5 = p11; p11 = temp; }
			if (comparisonPointer(p5, p10) < 0) { temp = p5; p5 = p10; p10 = temp; }
			if (comparisonPointer(p5, p9) < 0) { temp = p5; p5 = p9; p9 = temp; }
			if (comparisonPointer(p6, p12) < 0) { temp = p6; p6 = p12; p12 = temp; }
			if (comparisonPointer(p7, p13) < 0) { temp = p7; p7 = p13; p13 = temp; }
			if (comparisonPointer(p8, p13) < 0) { temp = p8; p8 = p13; p13 = temp; }
			if (comparisonPointer(p7, p12) < 0) { temp = p7; p7 = p12; p12 = temp; }
			if (comparisonPointer(p8, p12) < 0) { temp = p8; p8 = p12; p12 = temp; }
			if (comparisonPointer(p6, p10) < 0) { temp = p6; p6 = p10; p10 = temp; }
			if (comparisonPointer(p6, p9) < 0) { temp = p6; p6 = p9; p9 = temp; }
			if (comparisonPointer(p7, p11) < 0) { temp = p7; p7 = p11; p11 = temp; }
			if (comparisonPointer(p8, p11) < 0) { temp = p8; p8 = p11; p11 = temp; }
			if (comparisonPointer(p7, p9) < 0) { temp = p7; p7 = p9; p9 = temp; }
			if (comparisonPointer(p8, p10) < 0) { temp = p8; p8 = p10; p10 = temp; }
			if (comparisonPointer(p8, p9) < 0) { temp = p8; p8 = p9; p9 = temp; }
		}

		/// <summary>
		/// Sorts a collection of 20 elements in descending order using the specified function pointer.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparisonPointer">The function pointer to use when comparing elements.</param>
		public unsafe static void Sort20Descending<T>(ref T p0, delegate* managed<T, T, int> comparisonPointer)
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
			ref var p16 = ref Unsafe.Add(ref p0, 16);
			ref var p17 = ref Unsafe.Add(ref p0, 17);
			ref var p18 = ref Unsafe.Add(ref p0, 18);
			ref var p19 = ref Unsafe.Add(ref p0, 19);

			T temp;
			if (comparisonPointer(p0, p1) < 0) { temp = p0; p0 = p1; p1 = temp; }
			if (comparisonPointer(p3, p4) < 0) { temp = p3; p3 = p4; p4 = temp; }
			if (comparisonPointer(p2, p4) < 0) { temp = p2; p2 = p4; p4 = temp; }
			if (comparisonPointer(p2, p3) < 0) { temp = p2; p2 = p3; p3 = temp; }
			if (comparisonPointer(p0, p3) < 0) { temp = p0; p0 = p3; p3 = temp; }
			if (comparisonPointer(p0, p2) < 0) { temp = p0; p0 = p2; p2 = temp; }
			if (comparisonPointer(p1, p4) < 0) { temp = p1; p1 = p4; p4 = temp; }
			if (comparisonPointer(p1, p3) < 0) { temp = p1; p1 = p3; p3 = temp; }
			if (comparisonPointer(p1, p2) < 0) { temp = p1; p1 = p2; p2 = temp; }
			if (comparisonPointer(p5, p6) < 0) { temp = p5; p5 = p6; p6 = temp; }
			if (comparisonPointer(p8, p9) < 0) { temp = p8; p8 = p9; p9 = temp; }
			if (comparisonPointer(p7, p9) < 0) { temp = p7; p7 = p9; p9 = temp; }
			if (comparisonPointer(p7, p8) < 0) { temp = p7; p7 = p8; p8 = temp; }
			if (comparisonPointer(p5, p8) < 0) { temp = p5; p5 = p8; p8 = temp; }
			if (comparisonPointer(p5, p7) < 0) { temp = p5; p5 = p7; p7 = temp; }
			if (comparisonPointer(p6, p9) < 0) { temp = p6; p6 = p9; p9 = temp; }
			if (comparisonPointer(p6, p8) < 0) { temp = p6; p6 = p8; p8 = temp; }
			if (comparisonPointer(p6, p7) < 0) { temp = p6; p6 = p7; p7 = temp; }
			if (comparisonPointer(p0, p6) < 0) { temp = p0; p0 = p6; p6 = temp; }
			if (comparisonPointer(p0, p5) < 0) { temp = p0; p0 = p5; p5 = temp; }
			if (comparisonPointer(p1, p7) < 0) { temp = p1; p1 = p7; p7 = temp; }
			if (comparisonPointer(p1, p6) < 0) { temp = p1; p1 = p6; p6 = temp; }
			if (comparisonPointer(p1, p5) < 0) { temp = p1; p1 = p5; p5 = temp; }
			if (comparisonPointer(p2, p8) < 0) { temp = p2; p2 = p8; p8 = temp; }
			if (comparisonPointer(p3, p9) < 0) { temp = p3; p3 = p9; p9 = temp; }
			if (comparisonPointer(p4, p9) < 0) { temp = p4; p4 = p9; p9 = temp; }
			if (comparisonPointer(p3, p8) < 0) { temp = p3; p3 = p8; p8 = temp; }
			if (comparisonPointer(p4, p8) < 0) { temp = p4; p4 = p8; p8 = temp; }
			if (comparisonPointer(p2, p6) < 0) { temp = p2; p2 = p6; p6 = temp; }
			if (comparisonPointer(p2, p5) < 0) { temp = p2; p2 = p5; p5 = temp; }
			if (comparisonPointer(p3, p7) < 0) { temp = p3; p3 = p7; p7 = temp; }
			if (comparisonPointer(p4, p7) < 0) { temp = p4; p4 = p7; p7 = temp; }
			if (comparisonPointer(p3, p5) < 0) { temp = p3; p3 = p5; p5 = temp; }
			if (comparisonPointer(p4, p6) < 0) { temp = p4; p4 = p6; p6 = temp; }
			if (comparisonPointer(p4, p5) < 0) { temp = p4; p4 = p5; p5 = temp; }
			if (comparisonPointer(p10, p11) < 0) { temp = p10; p10 = p11; p11 = temp; }
			if (comparisonPointer(p13, p14) < 0) { temp = p13; p13 = p14; p14 = temp; }
			if (comparisonPointer(p12, p14) < 0) { temp = p12; p12 = p14; p14 = temp; }
			if (comparisonPointer(p12, p13) < 0) { temp = p12; p12 = p13; p13 = temp; }
			if (comparisonPointer(p10, p13) < 0) { temp = p10; p10 = p13; p13 = temp; }
			if (comparisonPointer(p10, p12) < 0) { temp = p10; p10 = p12; p12 = temp; }
			if (comparisonPointer(p11, p14) < 0) { temp = p11; p11 = p14; p14 = temp; }
			if (comparisonPointer(p11, p13) < 0) { temp = p11; p11 = p13; p13 = temp; }
			if (comparisonPointer(p11, p12) < 0) { temp = p11; p11 = p12; p12 = temp; }
			if (comparisonPointer(p15, p16) < 0) { temp = p15; p15 = p16; p16 = temp; }
			if (comparisonPointer(p18, p19) < 0) { temp = p18; p18 = p19; p19 = temp; }
			if (comparisonPointer(p17, p19) < 0) { temp = p17; p17 = p19; p19 = temp; }
			if (comparisonPointer(p17, p18) < 0) { temp = p17; p17 = p18; p18 = temp; }
			if (comparisonPointer(p15, p18) < 0) { temp = p15; p15 = p18; p18 = temp; }
			if (comparisonPointer(p15, p17) < 0) { temp = p15; p15 = p17; p17 = temp; }
			if (comparisonPointer(p16, p19) < 0) { temp = p16; p16 = p19; p19 = temp; }
			if (comparisonPointer(p16, p18) < 0) { temp = p16; p16 = p18; p18 = temp; }
			if (comparisonPointer(p16, p17) < 0) { temp = p16; p16 = p17; p17 = temp; }
			if (comparisonPointer(p10, p16) < 0) { temp = p10; p10 = p16; p16 = temp; }
			if (comparisonPointer(p10, p15) < 0) { temp = p10; p10 = p15; p15 = temp; }
			if (comparisonPointer(p11, p17) < 0) { temp = p11; p11 = p17; p17 = temp; }
			if (comparisonPointer(p11, p16) < 0) { temp = p11; p11 = p16; p16 = temp; }
			if (comparisonPointer(p11, p15) < 0) { temp = p11; p11 = p15; p15 = temp; }
			if (comparisonPointer(p12, p18) < 0) { temp = p12; p12 = p18; p18 = temp; }
			if (comparisonPointer(p13, p19) < 0) { temp = p13; p13 = p19; p19 = temp; }
			if (comparisonPointer(p14, p19) < 0) { temp = p14; p14 = p19; p19 = temp; }
			if (comparisonPointer(p13, p18) < 0) { temp = p13; p13 = p18; p18 = temp; }
			if (comparisonPointer(p14, p18) < 0) { temp = p14; p14 = p18; p18 = temp; }
			if (comparisonPointer(p12, p16) < 0) { temp = p12; p12 = p16; p16 = temp; }
			if (comparisonPointer(p12, p15) < 0) { temp = p12; p12 = p15; p15 = temp; }
			if (comparisonPointer(p13, p17) < 0) { temp = p13; p13 = p17; p17 = temp; }
			if (comparisonPointer(p14, p17) < 0) { temp = p14; p14 = p17; p17 = temp; }
			if (comparisonPointer(p13, p15) < 0) { temp = p13; p13 = p15; p15 = temp; }
			if (comparisonPointer(p14, p16) < 0) { temp = p14; p14 = p16; p16 = temp; }
			if (comparisonPointer(p14, p15) < 0) { temp = p14; p14 = p15; p15 = temp; }
			if (comparisonPointer(p0, p11) < 0) { temp = p0; p0 = p11; p11 = temp; }
			if (comparisonPointer(p0, p10) < 0) { temp = p0; p0 = p10; p10 = temp; }
			if (comparisonPointer(p1, p12) < 0) { temp = p1; p1 = p12; p12 = temp; }
			if (comparisonPointer(p1, p11) < 0) { temp = p1; p1 = p11; p11 = temp; }
			if (comparisonPointer(p1, p10) < 0) { temp = p1; p1 = p10; p10 = temp; }
			if (comparisonPointer(p2, p13) < 0) { temp = p2; p2 = p13; p13 = temp; }
			if (comparisonPointer(p3, p14) < 0) { temp = p3; p3 = p14; p14 = temp; }
			if (comparisonPointer(p4, p14) < 0) { temp = p4; p4 = p14; p14 = temp; }
			if (comparisonPointer(p3, p13) < 0) { temp = p3; p3 = p13; p13 = temp; }
			if (comparisonPointer(p4, p13) < 0) { temp = p4; p4 = p13; p13 = temp; }
			if (comparisonPointer(p2, p11) < 0) { temp = p2; p2 = p11; p11 = temp; }
			if (comparisonPointer(p2, p10) < 0) { temp = p2; p2 = p10; p10 = temp; }
			if (comparisonPointer(p3, p12) < 0) { temp = p3; p3 = p12; p12 = temp; }
			if (comparisonPointer(p4, p12) < 0) { temp = p4; p4 = p12; p12 = temp; }
			if (comparisonPointer(p3, p10) < 0) { temp = p3; p3 = p10; p10 = temp; }
			if (comparisonPointer(p4, p11) < 0) { temp = p4; p4 = p11; p11 = temp; }
			if (comparisonPointer(p4, p10) < 0) { temp = p4; p4 = p10; p10 = temp; }
			if (comparisonPointer(p5, p16) < 0) { temp = p5; p5 = p16; p16 = temp; }
			if (comparisonPointer(p5, p15) < 0) { temp = p5; p5 = p15; p15 = temp; }
			if (comparisonPointer(p6, p17) < 0) { temp = p6; p6 = p17; p17 = temp; }
			if (comparisonPointer(p6, p16) < 0) { temp = p6; p6 = p16; p16 = temp; }
			if (comparisonPointer(p6, p15) < 0) { temp = p6; p6 = p15; p15 = temp; }
			if (comparisonPointer(p7, p18) < 0) { temp = p7; p7 = p18; p18 = temp; }
			if (comparisonPointer(p8, p19) < 0) { temp = p8; p8 = p19; p19 = temp; }
			if (comparisonPointer(p9, p19) < 0) { temp = p9; p9 = p19; p19 = temp; }
			if (comparisonPointer(p8, p18) < 0) { temp = p8; p8 = p18; p18 = temp; }
			if (comparisonPointer(p9, p18) < 0) { temp = p9; p9 = p18; p18 = temp; }
			if (comparisonPointer(p7, p16) < 0) { temp = p7; p7 = p16; p16 = temp; }
			if (comparisonPointer(p7, p15) < 0) { temp = p7; p7 = p15; p15 = temp; }
			if (comparisonPointer(p8, p17) < 0) { temp = p8; p8 = p17; p17 = temp; }
			if (comparisonPointer(p9, p17) < 0) { temp = p9; p9 = p17; p17 = temp; }
			if (comparisonPointer(p8, p15) < 0) { temp = p8; p8 = p15; p15 = temp; }
			if (comparisonPointer(p9, p16) < 0) { temp = p9; p9 = p16; p16 = temp; }
			if (comparisonPointer(p9, p15) < 0) { temp = p9; p9 = p15; p15 = temp; }
			if (comparisonPointer(p5, p11) < 0) { temp = p5; p5 = p11; p11 = temp; }
			if (comparisonPointer(p5, p10) < 0) { temp = p5; p5 = p10; p10 = temp; }
			if (comparisonPointer(p6, p12) < 0) { temp = p6; p6 = p12; p12 = temp; }
			if (comparisonPointer(p6, p11) < 0) { temp = p6; p6 = p11; p11 = temp; }
			if (comparisonPointer(p6, p10) < 0) { temp = p6; p6 = p10; p10 = temp; }
			if (comparisonPointer(p7, p13) < 0) { temp = p7; p7 = p13; p13 = temp; }
			if (comparisonPointer(p8, p14) < 0) { temp = p8; p8 = p14; p14 = temp; }
			if (comparisonPointer(p9, p14) < 0) { temp = p9; p9 = p14; p14 = temp; }
			if (comparisonPointer(p8, p13) < 0) { temp = p8; p8 = p13; p13 = temp; }
			if (comparisonPointer(p9, p13) < 0) { temp = p9; p9 = p13; p13 = temp; }
			if (comparisonPointer(p7, p11) < 0) { temp = p7; p7 = p11; p11 = temp; }
			if (comparisonPointer(p7, p10) < 0) { temp = p7; p7 = p10; p10 = temp; }
			if (comparisonPointer(p8, p12) < 0) { temp = p8; p8 = p12; p12 = temp; }
			if (comparisonPointer(p9, p12) < 0) { temp = p9; p9 = p12; p12 = temp; }
			if (comparisonPointer(p8, p10) < 0) { temp = p8; p8 = p10; p10 = temp; }
			if (comparisonPointer(p9, p11) < 0) { temp = p9; p9 = p11; p11 = temp; }
			if (comparisonPointer(p9, p10) < 0) { temp = p9; p9 = p10; p10 = temp; }
		}

		/// <summary>
		/// Sorts a collection of 21 elements in descending order using the specified function pointer.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparisonPointer">The function pointer to use when comparing elements.</param>
		public unsafe static void Sort21Descending<T>(ref T p0, delegate* managed<T, T, int> comparisonPointer)
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
			ref var p16 = ref Unsafe.Add(ref p0, 16);
			ref var p17 = ref Unsafe.Add(ref p0, 17);
			ref var p18 = ref Unsafe.Add(ref p0, 18);
			ref var p19 = ref Unsafe.Add(ref p0, 19);
			ref var p20 = ref Unsafe.Add(ref p0, 20);

			T temp;
			if (comparisonPointer(p0, p1) < 0) { temp = p0; p0 = p1; p1 = temp; }
			if (comparisonPointer(p3, p4) < 0) { temp = p3; p3 = p4; p4 = temp; }
			if (comparisonPointer(p2, p4) < 0) { temp = p2; p2 = p4; p4 = temp; }
			if (comparisonPointer(p2, p3) < 0) { temp = p2; p2 = p3; p3 = temp; }
			if (comparisonPointer(p0, p3) < 0) { temp = p0; p0 = p3; p3 = temp; }
			if (comparisonPointer(p0, p2) < 0) { temp = p0; p0 = p2; p2 = temp; }
			if (comparisonPointer(p1, p4) < 0) { temp = p1; p1 = p4; p4 = temp; }
			if (comparisonPointer(p1, p3) < 0) { temp = p1; p1 = p3; p3 = temp; }
			if (comparisonPointer(p1, p2) < 0) { temp = p1; p1 = p2; p2 = temp; }
			if (comparisonPointer(p5, p6) < 0) { temp = p5; p5 = p6; p6 = temp; }
			if (comparisonPointer(p8, p9) < 0) { temp = p8; p8 = p9; p9 = temp; }
			if (comparisonPointer(p7, p9) < 0) { temp = p7; p7 = p9; p9 = temp; }
			if (comparisonPointer(p7, p8) < 0) { temp = p7; p7 = p8; p8 = temp; }
			if (comparisonPointer(p5, p8) < 0) { temp = p5; p5 = p8; p8 = temp; }
			if (comparisonPointer(p5, p7) < 0) { temp = p5; p5 = p7; p7 = temp; }
			if (comparisonPointer(p6, p9) < 0) { temp = p6; p6 = p9; p9 = temp; }
			if (comparisonPointer(p6, p8) < 0) { temp = p6; p6 = p8; p8 = temp; }
			if (comparisonPointer(p6, p7) < 0) { temp = p6; p6 = p7; p7 = temp; }
			if (comparisonPointer(p0, p6) < 0) { temp = p0; p0 = p6; p6 = temp; }
			if (comparisonPointer(p0, p5) < 0) { temp = p0; p0 = p5; p5 = temp; }
			if (comparisonPointer(p1, p7) < 0) { temp = p1; p1 = p7; p7 = temp; }
			if (comparisonPointer(p1, p6) < 0) { temp = p1; p1 = p6; p6 = temp; }
			if (comparisonPointer(p1, p5) < 0) { temp = p1; p1 = p5; p5 = temp; }
			if (comparisonPointer(p2, p8) < 0) { temp = p2; p2 = p8; p8 = temp; }
			if (comparisonPointer(p3, p9) < 0) { temp = p3; p3 = p9; p9 = temp; }
			if (comparisonPointer(p4, p9) < 0) { temp = p4; p4 = p9; p9 = temp; }
			if (comparisonPointer(p3, p8) < 0) { temp = p3; p3 = p8; p8 = temp; }
			if (comparisonPointer(p4, p8) < 0) { temp = p4; p4 = p8; p8 = temp; }
			if (comparisonPointer(p2, p6) < 0) { temp = p2; p2 = p6; p6 = temp; }
			if (comparisonPointer(p2, p5) < 0) { temp = p2; p2 = p5; p5 = temp; }
			if (comparisonPointer(p3, p7) < 0) { temp = p3; p3 = p7; p7 = temp; }
			if (comparisonPointer(p4, p7) < 0) { temp = p4; p4 = p7; p7 = temp; }
			if (comparisonPointer(p3, p5) < 0) { temp = p3; p3 = p5; p5 = temp; }
			if (comparisonPointer(p4, p6) < 0) { temp = p4; p4 = p6; p6 = temp; }
			if (comparisonPointer(p4, p5) < 0) { temp = p4; p4 = p5; p5 = temp; }
			if (comparisonPointer(p10, p11) < 0) { temp = p10; p10 = p11; p11 = temp; }
			if (comparisonPointer(p13, p14) < 0) { temp = p13; p13 = p14; p14 = temp; }
			if (comparisonPointer(p12, p14) < 0) { temp = p12; p12 = p14; p14 = temp; }
			if (comparisonPointer(p12, p13) < 0) { temp = p12; p12 = p13; p13 = temp; }
			if (comparisonPointer(p10, p13) < 0) { temp = p10; p10 = p13; p13 = temp; }
			if (comparisonPointer(p10, p12) < 0) { temp = p10; p10 = p12; p12 = temp; }
			if (comparisonPointer(p11, p14) < 0) { temp = p11; p11 = p14; p14 = temp; }
			if (comparisonPointer(p11, p13) < 0) { temp = p11; p11 = p13; p13 = temp; }
			if (comparisonPointer(p11, p12) < 0) { temp = p11; p11 = p12; p12 = temp; }
			if (comparisonPointer(p16, p17) < 0) { temp = p16; p16 = p17; p17 = temp; }
			if (comparisonPointer(p15, p17) < 0) { temp = p15; p15 = p17; p17 = temp; }
			if (comparisonPointer(p15, p16) < 0) { temp = p15; p15 = p16; p16 = temp; }
			if (comparisonPointer(p19, p20) < 0) { temp = p19; p19 = p20; p20 = temp; }
			if (comparisonPointer(p18, p20) < 0) { temp = p18; p18 = p20; p20 = temp; }
			if (comparisonPointer(p18, p19) < 0) { temp = p18; p18 = p19; p19 = temp; }
			if (comparisonPointer(p15, p19) < 0) { temp = p15; p15 = p19; p19 = temp; }
			if (comparisonPointer(p15, p18) < 0) { temp = p15; p15 = p18; p18 = temp; }
			if (comparisonPointer(p16, p20) < 0) { temp = p16; p16 = p20; p20 = temp; }
			if (comparisonPointer(p17, p20) < 0) { temp = p17; p17 = p20; p20 = temp; }
			if (comparisonPointer(p16, p18) < 0) { temp = p16; p16 = p18; p18 = temp; }
			if (comparisonPointer(p17, p19) < 0) { temp = p17; p17 = p19; p19 = temp; }
			if (comparisonPointer(p17, p18) < 0) { temp = p17; p17 = p18; p18 = temp; }
			if (comparisonPointer(p10, p16) < 0) { temp = p10; p10 = p16; p16 = temp; }
			if (comparisonPointer(p10, p15) < 0) { temp = p10; p10 = p15; p15 = temp; }
			if (comparisonPointer(p11, p17) < 0) { temp = p11; p11 = p17; p17 = temp; }
			if (comparisonPointer(p11, p16) < 0) { temp = p11; p11 = p16; p16 = temp; }
			if (comparisonPointer(p11, p15) < 0) { temp = p11; p11 = p15; p15 = temp; }
			if (comparisonPointer(p12, p19) < 0) { temp = p12; p12 = p19; p19 = temp; }
			if (comparisonPointer(p12, p18) < 0) { temp = p12; p12 = p18; p18 = temp; }
			if (comparisonPointer(p13, p20) < 0) { temp = p13; p13 = p20; p20 = temp; }
			if (comparisonPointer(p14, p20) < 0) { temp = p14; p14 = p20; p20 = temp; }
			if (comparisonPointer(p13, p18) < 0) { temp = p13; p13 = p18; p18 = temp; }
			if (comparisonPointer(p14, p19) < 0) { temp = p14; p14 = p19; p19 = temp; }
			if (comparisonPointer(p14, p18) < 0) { temp = p14; p14 = p18; p18 = temp; }
			if (comparisonPointer(p12, p16) < 0) { temp = p12; p12 = p16; p16 = temp; }
			if (comparisonPointer(p12, p15) < 0) { temp = p12; p12 = p15; p15 = temp; }
			if (comparisonPointer(p13, p17) < 0) { temp = p13; p13 = p17; p17 = temp; }
			if (comparisonPointer(p14, p17) < 0) { temp = p14; p14 = p17; p17 = temp; }
			if (comparisonPointer(p13, p15) < 0) { temp = p13; p13 = p15; p15 = temp; }
			if (comparisonPointer(p14, p16) < 0) { temp = p14; p14 = p16; p16 = temp; }
			if (comparisonPointer(p14, p15) < 0) { temp = p14; p14 = p15; p15 = temp; }
			if (comparisonPointer(p0, p11) < 0) { temp = p0; p0 = p11; p11 = temp; }
			if (comparisonPointer(p0, p10) < 0) { temp = p0; p0 = p10; p10 = temp; }
			if (comparisonPointer(p1, p12) < 0) { temp = p1; p1 = p12; p12 = temp; }
			if (comparisonPointer(p1, p11) < 0) { temp = p1; p1 = p11; p11 = temp; }
			if (comparisonPointer(p1, p10) < 0) { temp = p1; p1 = p10; p10 = temp; }
			if (comparisonPointer(p2, p14) < 0) { temp = p2; p2 = p14; p14 = temp; }
			if (comparisonPointer(p2, p13) < 0) { temp = p2; p2 = p13; p13 = temp; }
			if (comparisonPointer(p3, p15) < 0) { temp = p3; p3 = p15; p15 = temp; }
			if (comparisonPointer(p4, p15) < 0) { temp = p4; p4 = p15; p15 = temp; }
			if (comparisonPointer(p3, p13) < 0) { temp = p3; p3 = p13; p13 = temp; }
			if (comparisonPointer(p4, p14) < 0) { temp = p4; p4 = p14; p14 = temp; }
			if (comparisonPointer(p4, p13) < 0) { temp = p4; p4 = p13; p13 = temp; }
			if (comparisonPointer(p2, p11) < 0) { temp = p2; p2 = p11; p11 = temp; }
			if (comparisonPointer(p2, p10) < 0) { temp = p2; p2 = p10; p10 = temp; }
			if (comparisonPointer(p3, p12) < 0) { temp = p3; p3 = p12; p12 = temp; }
			if (comparisonPointer(p4, p12) < 0) { temp = p4; p4 = p12; p12 = temp; }
			if (comparisonPointer(p3, p10) < 0) { temp = p3; p3 = p10; p10 = temp; }
			if (comparisonPointer(p4, p11) < 0) { temp = p4; p4 = p11; p11 = temp; }
			if (comparisonPointer(p4, p10) < 0) { temp = p4; p4 = p10; p10 = temp; }
			if (comparisonPointer(p5, p17) < 0) { temp = p5; p5 = p17; p17 = temp; }
			if (comparisonPointer(p5, p16) < 0) { temp = p5; p5 = p16; p16 = temp; }
			if (comparisonPointer(p6, p18) < 0) { temp = p6; p6 = p18; p18 = temp; }
			if (comparisonPointer(p6, p17) < 0) { temp = p6; p6 = p17; p17 = temp; }
			if (comparisonPointer(p6, p16) < 0) { temp = p6; p6 = p16; p16 = temp; }
			if (comparisonPointer(p7, p19) < 0) { temp = p7; p7 = p19; p19 = temp; }
			if (comparisonPointer(p8, p20) < 0) { temp = p8; p8 = p20; p20 = temp; }
			if (comparisonPointer(p9, p20) < 0) { temp = p9; p9 = p20; p20 = temp; }
			if (comparisonPointer(p8, p19) < 0) { temp = p8; p8 = p19; p19 = temp; }
			if (comparisonPointer(p9, p19) < 0) { temp = p9; p9 = p19; p19 = temp; }
			if (comparisonPointer(p7, p17) < 0) { temp = p7; p7 = p17; p17 = temp; }
			if (comparisonPointer(p7, p16) < 0) { temp = p7; p7 = p16; p16 = temp; }
			if (comparisonPointer(p8, p18) < 0) { temp = p8; p8 = p18; p18 = temp; }
			if (comparisonPointer(p9, p18) < 0) { temp = p9; p9 = p18; p18 = temp; }
			if (comparisonPointer(p8, p16) < 0) { temp = p8; p8 = p16; p16 = temp; }
			if (comparisonPointer(p9, p17) < 0) { temp = p9; p9 = p17; p17 = temp; }
			if (comparisonPointer(p9, p16) < 0) { temp = p9; p9 = p16; p16 = temp; }
			if (comparisonPointer(p5, p11) < 0) { temp = p5; p5 = p11; p11 = temp; }
			if (comparisonPointer(p5, p10) < 0) { temp = p5; p5 = p10; p10 = temp; }
			if (comparisonPointer(p6, p12) < 0) { temp = p6; p6 = p12; p12 = temp; }
			if (comparisonPointer(p6, p11) < 0) { temp = p6; p6 = p11; p11 = temp; }
			if (comparisonPointer(p6, p10) < 0) { temp = p6; p6 = p10; p10 = temp; }
			if (comparisonPointer(p7, p14) < 0) { temp = p7; p7 = p14; p14 = temp; }
			if (comparisonPointer(p7, p13) < 0) { temp = p7; p7 = p13; p13 = temp; }
			if (comparisonPointer(p8, p15) < 0) { temp = p8; p8 = p15; p15 = temp; }
			if (comparisonPointer(p9, p15) < 0) { temp = p9; p9 = p15; p15 = temp; }
			if (comparisonPointer(p8, p13) < 0) { temp = p8; p8 = p13; p13 = temp; }
			if (comparisonPointer(p9, p14) < 0) { temp = p9; p9 = p14; p14 = temp; }
			if (comparisonPointer(p9, p13) < 0) { temp = p9; p9 = p13; p13 = temp; }
			if (comparisonPointer(p7, p11) < 0) { temp = p7; p7 = p11; p11 = temp; }
			if (comparisonPointer(p7, p10) < 0) { temp = p7; p7 = p10; p10 = temp; }
			if (comparisonPointer(p8, p12) < 0) { temp = p8; p8 = p12; p12 = temp; }
			if (comparisonPointer(p9, p12) < 0) { temp = p9; p9 = p12; p12 = temp; }
			if (comparisonPointer(p8, p10) < 0) { temp = p8; p8 = p10; p10 = temp; }
			if (comparisonPointer(p9, p11) < 0) { temp = p9; p9 = p11; p11 = temp; }
			if (comparisonPointer(p9, p10) < 0) { temp = p9; p9 = p10; p10 = temp; }
		}

		/// <summary>
		/// Sorts a collection of 22 elements in descending order using the specified function pointer.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparisonPointer">The function pointer to use when comparing elements.</param>
		public unsafe static void Sort22Descending<T>(ref T p0, delegate* managed<T, T, int> comparisonPointer)
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
			ref var p16 = ref Unsafe.Add(ref p0, 16);
			ref var p17 = ref Unsafe.Add(ref p0, 17);
			ref var p18 = ref Unsafe.Add(ref p0, 18);
			ref var p19 = ref Unsafe.Add(ref p0, 19);
			ref var p20 = ref Unsafe.Add(ref p0, 20);
			ref var p21 = ref Unsafe.Add(ref p0, 21);

			T temp;
			if (comparisonPointer(p0, p1) < 0) { temp = p0; p0 = p1; p1 = temp; }
			if (comparisonPointer(p3, p4) < 0) { temp = p3; p3 = p4; p4 = temp; }
			if (comparisonPointer(p2, p4) < 0) { temp = p2; p2 = p4; p4 = temp; }
			if (comparisonPointer(p2, p3) < 0) { temp = p2; p2 = p3; p3 = temp; }
			if (comparisonPointer(p0, p3) < 0) { temp = p0; p0 = p3; p3 = temp; }
			if (comparisonPointer(p0, p2) < 0) { temp = p0; p0 = p2; p2 = temp; }
			if (comparisonPointer(p1, p4) < 0) { temp = p1; p1 = p4; p4 = temp; }
			if (comparisonPointer(p1, p3) < 0) { temp = p1; p1 = p3; p3 = temp; }
			if (comparisonPointer(p1, p2) < 0) { temp = p1; p1 = p2; p2 = temp; }
			if (comparisonPointer(p6, p7) < 0) { temp = p6; p6 = p7; p7 = temp; }
			if (comparisonPointer(p5, p7) < 0) { temp = p5; p5 = p7; p7 = temp; }
			if (comparisonPointer(p5, p6) < 0) { temp = p5; p5 = p6; p6 = temp; }
			if (comparisonPointer(p9, p10) < 0) { temp = p9; p9 = p10; p10 = temp; }
			if (comparisonPointer(p8, p10) < 0) { temp = p8; p8 = p10; p10 = temp; }
			if (comparisonPointer(p8, p9) < 0) { temp = p8; p8 = p9; p9 = temp; }
			if (comparisonPointer(p5, p9) < 0) { temp = p5; p5 = p9; p9 = temp; }
			if (comparisonPointer(p5, p8) < 0) { temp = p5; p5 = p8; p8 = temp; }
			if (comparisonPointer(p6, p10) < 0) { temp = p6; p6 = p10; p10 = temp; }
			if (comparisonPointer(p7, p10) < 0) { temp = p7; p7 = p10; p10 = temp; }
			if (comparisonPointer(p6, p8) < 0) { temp = p6; p6 = p8; p8 = temp; }
			if (comparisonPointer(p7, p9) < 0) { temp = p7; p7 = p9; p9 = temp; }
			if (comparisonPointer(p7, p8) < 0) { temp = p7; p7 = p8; p8 = temp; }
			if (comparisonPointer(p0, p6) < 0) { temp = p0; p0 = p6; p6 = temp; }
			if (comparisonPointer(p0, p5) < 0) { temp = p0; p0 = p5; p5 = temp; }
			if (comparisonPointer(p1, p7) < 0) { temp = p1; p1 = p7; p7 = temp; }
			if (comparisonPointer(p1, p6) < 0) { temp = p1; p1 = p6; p6 = temp; }
			if (comparisonPointer(p1, p5) < 0) { temp = p1; p1 = p5; p5 = temp; }
			if (comparisonPointer(p2, p9) < 0) { temp = p2; p2 = p9; p9 = temp; }
			if (comparisonPointer(p2, p8) < 0) { temp = p2; p2 = p8; p8 = temp; }
			if (comparisonPointer(p3, p10) < 0) { temp = p3; p3 = p10; p10 = temp; }
			if (comparisonPointer(p4, p10) < 0) { temp = p4; p4 = p10; p10 = temp; }
			if (comparisonPointer(p3, p8) < 0) { temp = p3; p3 = p8; p8 = temp; }
			if (comparisonPointer(p4, p9) < 0) { temp = p4; p4 = p9; p9 = temp; }
			if (comparisonPointer(p4, p8) < 0) { temp = p4; p4 = p8; p8 = temp; }
			if (comparisonPointer(p2, p6) < 0) { temp = p2; p2 = p6; p6 = temp; }
			if (comparisonPointer(p2, p5) < 0) { temp = p2; p2 = p5; p5 = temp; }
			if (comparisonPointer(p3, p7) < 0) { temp = p3; p3 = p7; p7 = temp; }
			if (comparisonPointer(p4, p7) < 0) { temp = p4; p4 = p7; p7 = temp; }
			if (comparisonPointer(p3, p5) < 0) { temp = p3; p3 = p5; p5 = temp; }
			if (comparisonPointer(p4, p6) < 0) { temp = p4; p4 = p6; p6 = temp; }
			if (comparisonPointer(p4, p5) < 0) { temp = p4; p4 = p5; p5 = temp; }
			if (comparisonPointer(p11, p12) < 0) { temp = p11; p11 = p12; p12 = temp; }
			if (comparisonPointer(p14, p15) < 0) { temp = p14; p14 = p15; p15 = temp; }
			if (comparisonPointer(p13, p15) < 0) { temp = p13; p13 = p15; p15 = temp; }
			if (comparisonPointer(p13, p14) < 0) { temp = p13; p13 = p14; p14 = temp; }
			if (comparisonPointer(p11, p14) < 0) { temp = p11; p11 = p14; p14 = temp; }
			if (comparisonPointer(p11, p13) < 0) { temp = p11; p11 = p13; p13 = temp; }
			if (comparisonPointer(p12, p15) < 0) { temp = p12; p12 = p15; p15 = temp; }
			if (comparisonPointer(p12, p14) < 0) { temp = p12; p12 = p14; p14 = temp; }
			if (comparisonPointer(p12, p13) < 0) { temp = p12; p12 = p13; p13 = temp; }
			if (comparisonPointer(p17, p18) < 0) { temp = p17; p17 = p18; p18 = temp; }
			if (comparisonPointer(p16, p18) < 0) { temp = p16; p16 = p18; p18 = temp; }
			if (comparisonPointer(p16, p17) < 0) { temp = p16; p16 = p17; p17 = temp; }
			if (comparisonPointer(p20, p21) < 0) { temp = p20; p20 = p21; p21 = temp; }
			if (comparisonPointer(p19, p21) < 0) { temp = p19; p19 = p21; p21 = temp; }
			if (comparisonPointer(p19, p20) < 0) { temp = p19; p19 = p20; p20 = temp; }
			if (comparisonPointer(p16, p20) < 0) { temp = p16; p16 = p20; p20 = temp; }
			if (comparisonPointer(p16, p19) < 0) { temp = p16; p16 = p19; p19 = temp; }
			if (comparisonPointer(p17, p21) < 0) { temp = p17; p17 = p21; p21 = temp; }
			if (comparisonPointer(p18, p21) < 0) { temp = p18; p18 = p21; p21 = temp; }
			if (comparisonPointer(p17, p19) < 0) { temp = p17; p17 = p19; p19 = temp; }
			if (comparisonPointer(p18, p20) < 0) { temp = p18; p18 = p20; p20 = temp; }
			if (comparisonPointer(p18, p19) < 0) { temp = p18; p18 = p19; p19 = temp; }
			if (comparisonPointer(p11, p17) < 0) { temp = p11; p11 = p17; p17 = temp; }
			if (comparisonPointer(p11, p16) < 0) { temp = p11; p11 = p16; p16 = temp; }
			if (comparisonPointer(p12, p18) < 0) { temp = p12; p12 = p18; p18 = temp; }
			if (comparisonPointer(p12, p17) < 0) { temp = p12; p12 = p17; p17 = temp; }
			if (comparisonPointer(p12, p16) < 0) { temp = p12; p12 = p16; p16 = temp; }
			if (comparisonPointer(p13, p20) < 0) { temp = p13; p13 = p20; p20 = temp; }
			if (comparisonPointer(p13, p19) < 0) { temp = p13; p13 = p19; p19 = temp; }
			if (comparisonPointer(p14, p21) < 0) { temp = p14; p14 = p21; p21 = temp; }
			if (comparisonPointer(p15, p21) < 0) { temp = p15; p15 = p21; p21 = temp; }
			if (comparisonPointer(p14, p19) < 0) { temp = p14; p14 = p19; p19 = temp; }
			if (comparisonPointer(p15, p20) < 0) { temp = p15; p15 = p20; p20 = temp; }
			if (comparisonPointer(p15, p19) < 0) { temp = p15; p15 = p19; p19 = temp; }
			if (comparisonPointer(p13, p17) < 0) { temp = p13; p13 = p17; p17 = temp; }
			if (comparisonPointer(p13, p16) < 0) { temp = p13; p13 = p16; p16 = temp; }
			if (comparisonPointer(p14, p18) < 0) { temp = p14; p14 = p18; p18 = temp; }
			if (comparisonPointer(p15, p18) < 0) { temp = p15; p15 = p18; p18 = temp; }
			if (comparisonPointer(p14, p16) < 0) { temp = p14; p14 = p16; p16 = temp; }
			if (comparisonPointer(p15, p17) < 0) { temp = p15; p15 = p17; p17 = temp; }
			if (comparisonPointer(p15, p16) < 0) { temp = p15; p15 = p16; p16 = temp; }
			if (comparisonPointer(p0, p12) < 0) { temp = p0; p0 = p12; p12 = temp; }
			if (comparisonPointer(p0, p11) < 0) { temp = p0; p0 = p11; p11 = temp; }
			if (comparisonPointer(p1, p13) < 0) { temp = p1; p1 = p13; p13 = temp; }
			if (comparisonPointer(p1, p12) < 0) { temp = p1; p1 = p12; p12 = temp; }
			if (comparisonPointer(p1, p11) < 0) { temp = p1; p1 = p11; p11 = temp; }
			if (comparisonPointer(p2, p15) < 0) { temp = p2; p2 = p15; p15 = temp; }
			if (comparisonPointer(p2, p14) < 0) { temp = p2; p2 = p14; p14 = temp; }
			if (comparisonPointer(p3, p16) < 0) { temp = p3; p3 = p16; p16 = temp; }
			if (comparisonPointer(p4, p16) < 0) { temp = p4; p4 = p16; p16 = temp; }
			if (comparisonPointer(p3, p14) < 0) { temp = p3; p3 = p14; p14 = temp; }
			if (comparisonPointer(p4, p15) < 0) { temp = p4; p4 = p15; p15 = temp; }
			if (comparisonPointer(p4, p14) < 0) { temp = p4; p4 = p14; p14 = temp; }
			if (comparisonPointer(p2, p12) < 0) { temp = p2; p2 = p12; p12 = temp; }
			if (comparisonPointer(p2, p11) < 0) { temp = p2; p2 = p11; p11 = temp; }
			if (comparisonPointer(p3, p13) < 0) { temp = p3; p3 = p13; p13 = temp; }
			if (comparisonPointer(p4, p13) < 0) { temp = p4; p4 = p13; p13 = temp; }
			if (comparisonPointer(p3, p11) < 0) { temp = p3; p3 = p11; p11 = temp; }
			if (comparisonPointer(p4, p12) < 0) { temp = p4; p4 = p12; p12 = temp; }
			if (comparisonPointer(p4, p11) < 0) { temp = p4; p4 = p11; p11 = temp; }
			if (comparisonPointer(p5, p18) < 0) { temp = p5; p5 = p18; p18 = temp; }
			if (comparisonPointer(p5, p17) < 0) { temp = p5; p5 = p17; p17 = temp; }
			if (comparisonPointer(p6, p19) < 0) { temp = p6; p6 = p19; p19 = temp; }
			if (comparisonPointer(p7, p19) < 0) { temp = p7; p7 = p19; p19 = temp; }
			if (comparisonPointer(p6, p17) < 0) { temp = p6; p6 = p17; p17 = temp; }
			if (comparisonPointer(p7, p18) < 0) { temp = p7; p7 = p18; p18 = temp; }
			if (comparisonPointer(p7, p17) < 0) { temp = p7; p7 = p17; p17 = temp; }
			if (comparisonPointer(p8, p20) < 0) { temp = p8; p8 = p20; p20 = temp; }
			if (comparisonPointer(p9, p21) < 0) { temp = p9; p9 = p21; p21 = temp; }
			if (comparisonPointer(p10, p21) < 0) { temp = p10; p10 = p21; p21 = temp; }
			if (comparisonPointer(p9, p20) < 0) { temp = p9; p9 = p20; p20 = temp; }
			if (comparisonPointer(p10, p20) < 0) { temp = p10; p10 = p20; p20 = temp; }
			if (comparisonPointer(p8, p18) < 0) { temp = p8; p8 = p18; p18 = temp; }
			if (comparisonPointer(p8, p17) < 0) { temp = p8; p8 = p17; p17 = temp; }
			if (comparisonPointer(p9, p19) < 0) { temp = p9; p9 = p19; p19 = temp; }
			if (comparisonPointer(p10, p19) < 0) { temp = p10; p10 = p19; p19 = temp; }
			if (comparisonPointer(p9, p17) < 0) { temp = p9; p9 = p17; p17 = temp; }
			if (comparisonPointer(p10, p18) < 0) { temp = p10; p10 = p18; p18 = temp; }
			if (comparisonPointer(p10, p17) < 0) { temp = p10; p10 = p17; p17 = temp; }
			if (comparisonPointer(p5, p12) < 0) { temp = p5; p5 = p12; p12 = temp; }
			if (comparisonPointer(p5, p11) < 0) { temp = p5; p5 = p11; p11 = temp; }
			if (comparisonPointer(p6, p13) < 0) { temp = p6; p6 = p13; p13 = temp; }
			if (comparisonPointer(p7, p13) < 0) { temp = p7; p7 = p13; p13 = temp; }
			if (comparisonPointer(p6, p11) < 0) { temp = p6; p6 = p11; p11 = temp; }
			if (comparisonPointer(p7, p12) < 0) { temp = p7; p7 = p12; p12 = temp; }
			if (comparisonPointer(p7, p11) < 0) { temp = p7; p7 = p11; p11 = temp; }
			if (comparisonPointer(p8, p15) < 0) { temp = p8; p8 = p15; p15 = temp; }
			if (comparisonPointer(p8, p14) < 0) { temp = p8; p8 = p14; p14 = temp; }
			if (comparisonPointer(p9, p16) < 0) { temp = p9; p9 = p16; p16 = temp; }
			if (comparisonPointer(p10, p16) < 0) { temp = p10; p10 = p16; p16 = temp; }
			if (comparisonPointer(p9, p14) < 0) { temp = p9; p9 = p14; p14 = temp; }
			if (comparisonPointer(p10, p15) < 0) { temp = p10; p10 = p15; p15 = temp; }
			if (comparisonPointer(p10, p14) < 0) { temp = p10; p10 = p14; p14 = temp; }
			if (comparisonPointer(p8, p12) < 0) { temp = p8; p8 = p12; p12 = temp; }
			if (comparisonPointer(p8, p11) < 0) { temp = p8; p8 = p11; p11 = temp; }
			if (comparisonPointer(p9, p13) < 0) { temp = p9; p9 = p13; p13 = temp; }
			if (comparisonPointer(p10, p13) < 0) { temp = p10; p10 = p13; p13 = temp; }
			if (comparisonPointer(p9, p11) < 0) { temp = p9; p9 = p11; p11 = temp; }
			if (comparisonPointer(p10, p12) < 0) { temp = p10; p10 = p12; p12 = temp; }
			if (comparisonPointer(p10, p11) < 0) { temp = p10; p10 = p11; p11 = temp; }
		}

		/// <summary>
		/// Sorts a collection of 23 elements in descending order using the specified function pointer.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparisonPointer">The function pointer to use when comparing elements.</param>
		public unsafe static void Sort23Descending<T>(ref T p0, delegate* managed<T, T, int> comparisonPointer)
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
			ref var p16 = ref Unsafe.Add(ref p0, 16);
			ref var p17 = ref Unsafe.Add(ref p0, 17);
			ref var p18 = ref Unsafe.Add(ref p0, 18);
			ref var p19 = ref Unsafe.Add(ref p0, 19);
			ref var p20 = ref Unsafe.Add(ref p0, 20);
			ref var p21 = ref Unsafe.Add(ref p0, 21);
			ref var p22 = ref Unsafe.Add(ref p0, 22);

			T temp;
			if (comparisonPointer(p0, p1) < 0) { temp = p0; p0 = p1; p1 = temp; }
			if (comparisonPointer(p3, p4) < 0) { temp = p3; p3 = p4; p4 = temp; }
			if (comparisonPointer(p2, p4) < 0) { temp = p2; p2 = p4; p4 = temp; }
			if (comparisonPointer(p2, p3) < 0) { temp = p2; p2 = p3; p3 = temp; }
			if (comparisonPointer(p0, p3) < 0) { temp = p0; p0 = p3; p3 = temp; }
			if (comparisonPointer(p0, p2) < 0) { temp = p0; p0 = p2; p2 = temp; }
			if (comparisonPointer(p1, p4) < 0) { temp = p1; p1 = p4; p4 = temp; }
			if (comparisonPointer(p1, p3) < 0) { temp = p1; p1 = p3; p3 = temp; }
			if (comparisonPointer(p1, p2) < 0) { temp = p1; p1 = p2; p2 = temp; }
			if (comparisonPointer(p6, p7) < 0) { temp = p6; p6 = p7; p7 = temp; }
			if (comparisonPointer(p5, p7) < 0) { temp = p5; p5 = p7; p7 = temp; }
			if (comparisonPointer(p5, p6) < 0) { temp = p5; p5 = p6; p6 = temp; }
			if (comparisonPointer(p9, p10) < 0) { temp = p9; p9 = p10; p10 = temp; }
			if (comparisonPointer(p8, p10) < 0) { temp = p8; p8 = p10; p10 = temp; }
			if (comparisonPointer(p8, p9) < 0) { temp = p8; p8 = p9; p9 = temp; }
			if (comparisonPointer(p5, p9) < 0) { temp = p5; p5 = p9; p9 = temp; }
			if (comparisonPointer(p5, p8) < 0) { temp = p5; p5 = p8; p8 = temp; }
			if (comparisonPointer(p6, p10) < 0) { temp = p6; p6 = p10; p10 = temp; }
			if (comparisonPointer(p7, p10) < 0) { temp = p7; p7 = p10; p10 = temp; }
			if (comparisonPointer(p6, p8) < 0) { temp = p6; p6 = p8; p8 = temp; }
			if (comparisonPointer(p7, p9) < 0) { temp = p7; p7 = p9; p9 = temp; }
			if (comparisonPointer(p7, p8) < 0) { temp = p7; p7 = p8; p8 = temp; }
			if (comparisonPointer(p0, p6) < 0) { temp = p0; p0 = p6; p6 = temp; }
			if (comparisonPointer(p0, p5) < 0) { temp = p0; p0 = p5; p5 = temp; }
			if (comparisonPointer(p1, p7) < 0) { temp = p1; p1 = p7; p7 = temp; }
			if (comparisonPointer(p1, p6) < 0) { temp = p1; p1 = p6; p6 = temp; }
			if (comparisonPointer(p1, p5) < 0) { temp = p1; p1 = p5; p5 = temp; }
			if (comparisonPointer(p2, p9) < 0) { temp = p2; p2 = p9; p9 = temp; }
			if (comparisonPointer(p2, p8) < 0) { temp = p2; p2 = p8; p8 = temp; }
			if (comparisonPointer(p3, p10) < 0) { temp = p3; p3 = p10; p10 = temp; }
			if (comparisonPointer(p4, p10) < 0) { temp = p4; p4 = p10; p10 = temp; }
			if (comparisonPointer(p3, p8) < 0) { temp = p3; p3 = p8; p8 = temp; }
			if (comparisonPointer(p4, p9) < 0) { temp = p4; p4 = p9; p9 = temp; }
			if (comparisonPointer(p4, p8) < 0) { temp = p4; p4 = p8; p8 = temp; }
			if (comparisonPointer(p2, p6) < 0) { temp = p2; p2 = p6; p6 = temp; }
			if (comparisonPointer(p2, p5) < 0) { temp = p2; p2 = p5; p5 = temp; }
			if (comparisonPointer(p3, p7) < 0) { temp = p3; p3 = p7; p7 = temp; }
			if (comparisonPointer(p4, p7) < 0) { temp = p4; p4 = p7; p7 = temp; }
			if (comparisonPointer(p3, p5) < 0) { temp = p3; p3 = p5; p5 = temp; }
			if (comparisonPointer(p4, p6) < 0) { temp = p4; p4 = p6; p6 = temp; }
			if (comparisonPointer(p4, p5) < 0) { temp = p4; p4 = p5; p5 = temp; }
			if (comparisonPointer(p12, p13) < 0) { temp = p12; p12 = p13; p13 = temp; }
			if (comparisonPointer(p11, p13) < 0) { temp = p11; p11 = p13; p13 = temp; }
			if (comparisonPointer(p11, p12) < 0) { temp = p11; p11 = p12; p12 = temp; }
			if (comparisonPointer(p15, p16) < 0) { temp = p15; p15 = p16; p16 = temp; }
			if (comparisonPointer(p14, p16) < 0) { temp = p14; p14 = p16; p16 = temp; }
			if (comparisonPointer(p14, p15) < 0) { temp = p14; p14 = p15; p15 = temp; }
			if (comparisonPointer(p11, p15) < 0) { temp = p11; p11 = p15; p15 = temp; }
			if (comparisonPointer(p11, p14) < 0) { temp = p11; p11 = p14; p14 = temp; }
			if (comparisonPointer(p12, p16) < 0) { temp = p12; p12 = p16; p16 = temp; }
			if (comparisonPointer(p13, p16) < 0) { temp = p13; p13 = p16; p16 = temp; }
			if (comparisonPointer(p12, p14) < 0) { temp = p12; p12 = p14; p14 = temp; }
			if (comparisonPointer(p13, p15) < 0) { temp = p13; p13 = p15; p15 = temp; }
			if (comparisonPointer(p13, p14) < 0) { temp = p13; p13 = p14; p14 = temp; }
			if (comparisonPointer(p18, p19) < 0) { temp = p18; p18 = p19; p19 = temp; }
			if (comparisonPointer(p17, p19) < 0) { temp = p17; p17 = p19; p19 = temp; }
			if (comparisonPointer(p17, p18) < 0) { temp = p17; p17 = p18; p18 = temp; }
			if (comparisonPointer(p21, p22) < 0) { temp = p21; p21 = p22; p22 = temp; }
			if (comparisonPointer(p20, p22) < 0) { temp = p20; p20 = p22; p22 = temp; }
			if (comparisonPointer(p20, p21) < 0) { temp = p20; p20 = p21; p21 = temp; }
			if (comparisonPointer(p17, p21) < 0) { temp = p17; p17 = p21; p21 = temp; }
			if (comparisonPointer(p17, p20) < 0) { temp = p17; p17 = p20; p20 = temp; }
			if (comparisonPointer(p18, p22) < 0) { temp = p18; p18 = p22; p22 = temp; }
			if (comparisonPointer(p19, p22) < 0) { temp = p19; p19 = p22; p22 = temp; }
			if (comparisonPointer(p18, p20) < 0) { temp = p18; p18 = p20; p20 = temp; }
			if (comparisonPointer(p19, p21) < 0) { temp = p19; p19 = p21; p21 = temp; }
			if (comparisonPointer(p19, p20) < 0) { temp = p19; p19 = p20; p20 = temp; }
			if (comparisonPointer(p11, p18) < 0) { temp = p11; p11 = p18; p18 = temp; }
			if (comparisonPointer(p11, p17) < 0) { temp = p11; p11 = p17; p17 = temp; }
			if (comparisonPointer(p12, p19) < 0) { temp = p12; p12 = p19; p19 = temp; }
			if (comparisonPointer(p13, p19) < 0) { temp = p13; p13 = p19; p19 = temp; }
			if (comparisonPointer(p12, p17) < 0) { temp = p12; p12 = p17; p17 = temp; }
			if (comparisonPointer(p13, p18) < 0) { temp = p13; p13 = p18; p18 = temp; }
			if (comparisonPointer(p13, p17) < 0) { temp = p13; p13 = p17; p17 = temp; }
			if (comparisonPointer(p14, p21) < 0) { temp = p14; p14 = p21; p21 = temp; }
			if (comparisonPointer(p14, p20) < 0) { temp = p14; p14 = p20; p20 = temp; }
			if (comparisonPointer(p15, p22) < 0) { temp = p15; p15 = p22; p22 = temp; }
			if (comparisonPointer(p16, p22) < 0) { temp = p16; p16 = p22; p22 = temp; }
			if (comparisonPointer(p15, p20) < 0) { temp = p15; p15 = p20; p20 = temp; }
			if (comparisonPointer(p16, p21) < 0) { temp = p16; p16 = p21; p21 = temp; }
			if (comparisonPointer(p16, p20) < 0) { temp = p16; p16 = p20; p20 = temp; }
			if (comparisonPointer(p14, p18) < 0) { temp = p14; p14 = p18; p18 = temp; }
			if (comparisonPointer(p14, p17) < 0) { temp = p14; p14 = p17; p17 = temp; }
			if (comparisonPointer(p15, p19) < 0) { temp = p15; p15 = p19; p19 = temp; }
			if (comparisonPointer(p16, p19) < 0) { temp = p16; p16 = p19; p19 = temp; }
			if (comparisonPointer(p15, p17) < 0) { temp = p15; p15 = p17; p17 = temp; }
			if (comparisonPointer(p16, p18) < 0) { temp = p16; p16 = p18; p18 = temp; }
			if (comparisonPointer(p16, p17) < 0) { temp = p16; p16 = p17; p17 = temp; }
			if (comparisonPointer(p0, p12) < 0) { temp = p0; p0 = p12; p12 = temp; }
			if (comparisonPointer(p0, p11) < 0) { temp = p0; p0 = p11; p11 = temp; }
			if (comparisonPointer(p1, p13) < 0) { temp = p1; p1 = p13; p13 = temp; }
			if (comparisonPointer(p1, p12) < 0) { temp = p1; p1 = p12; p12 = temp; }
			if (comparisonPointer(p1, p11) < 0) { temp = p1; p1 = p11; p11 = temp; }
			if (comparisonPointer(p2, p15) < 0) { temp = p2; p2 = p15; p15 = temp; }
			if (comparisonPointer(p2, p14) < 0) { temp = p2; p2 = p14; p14 = temp; }
			if (comparisonPointer(p3, p16) < 0) { temp = p3; p3 = p16; p16 = temp; }
			if (comparisonPointer(p4, p16) < 0) { temp = p4; p4 = p16; p16 = temp; }
			if (comparisonPointer(p3, p14) < 0) { temp = p3; p3 = p14; p14 = temp; }
			if (comparisonPointer(p4, p15) < 0) { temp = p4; p4 = p15; p15 = temp; }
			if (comparisonPointer(p4, p14) < 0) { temp = p4; p4 = p14; p14 = temp; }
			if (comparisonPointer(p2, p12) < 0) { temp = p2; p2 = p12; p12 = temp; }
			if (comparisonPointer(p2, p11) < 0) { temp = p2; p2 = p11; p11 = temp; }
			if (comparisonPointer(p3, p13) < 0) { temp = p3; p3 = p13; p13 = temp; }
			if (comparisonPointer(p4, p13) < 0) { temp = p4; p4 = p13; p13 = temp; }
			if (comparisonPointer(p3, p11) < 0) { temp = p3; p3 = p11; p11 = temp; }
			if (comparisonPointer(p4, p12) < 0) { temp = p4; p4 = p12; p12 = temp; }
			if (comparisonPointer(p4, p11) < 0) { temp = p4; p4 = p11; p11 = temp; }
			if (comparisonPointer(p5, p18) < 0) { temp = p5; p5 = p18; p18 = temp; }
			if (comparisonPointer(p5, p17) < 0) { temp = p5; p5 = p17; p17 = temp; }
			if (comparisonPointer(p6, p19) < 0) { temp = p6; p6 = p19; p19 = temp; }
			if (comparisonPointer(p7, p19) < 0) { temp = p7; p7 = p19; p19 = temp; }
			if (comparisonPointer(p6, p17) < 0) { temp = p6; p6 = p17; p17 = temp; }
			if (comparisonPointer(p7, p18) < 0) { temp = p7; p7 = p18; p18 = temp; }
			if (comparisonPointer(p7, p17) < 0) { temp = p7; p7 = p17; p17 = temp; }
			if (comparisonPointer(p8, p21) < 0) { temp = p8; p8 = p21; p21 = temp; }
			if (comparisonPointer(p8, p20) < 0) { temp = p8; p8 = p20; p20 = temp; }
			if (comparisonPointer(p9, p22) < 0) { temp = p9; p9 = p22; p22 = temp; }
			if (comparisonPointer(p10, p22) < 0) { temp = p10; p10 = p22; p22 = temp; }
			if (comparisonPointer(p9, p20) < 0) { temp = p9; p9 = p20; p20 = temp; }
			if (comparisonPointer(p10, p21) < 0) { temp = p10; p10 = p21; p21 = temp; }
			if (comparisonPointer(p10, p20) < 0) { temp = p10; p10 = p20; p20 = temp; }
			if (comparisonPointer(p8, p18) < 0) { temp = p8; p8 = p18; p18 = temp; }
			if (comparisonPointer(p8, p17) < 0) { temp = p8; p8 = p17; p17 = temp; }
			if (comparisonPointer(p9, p19) < 0) { temp = p9; p9 = p19; p19 = temp; }
			if (comparisonPointer(p10, p19) < 0) { temp = p10; p10 = p19; p19 = temp; }
			if (comparisonPointer(p9, p17) < 0) { temp = p9; p9 = p17; p17 = temp; }
			if (comparisonPointer(p10, p18) < 0) { temp = p10; p10 = p18; p18 = temp; }
			if (comparisonPointer(p10, p17) < 0) { temp = p10; p10 = p17; p17 = temp; }
			if (comparisonPointer(p5, p12) < 0) { temp = p5; p5 = p12; p12 = temp; }
			if (comparisonPointer(p5, p11) < 0) { temp = p5; p5 = p11; p11 = temp; }
			if (comparisonPointer(p6, p13) < 0) { temp = p6; p6 = p13; p13 = temp; }
			if (comparisonPointer(p7, p13) < 0) { temp = p7; p7 = p13; p13 = temp; }
			if (comparisonPointer(p6, p11) < 0) { temp = p6; p6 = p11; p11 = temp; }
			if (comparisonPointer(p7, p12) < 0) { temp = p7; p7 = p12; p12 = temp; }
			if (comparisonPointer(p7, p11) < 0) { temp = p7; p7 = p11; p11 = temp; }
			if (comparisonPointer(p8, p15) < 0) { temp = p8; p8 = p15; p15 = temp; }
			if (comparisonPointer(p8, p14) < 0) { temp = p8; p8 = p14; p14 = temp; }
			if (comparisonPointer(p9, p16) < 0) { temp = p9; p9 = p16; p16 = temp; }
			if (comparisonPointer(p10, p16) < 0) { temp = p10; p10 = p16; p16 = temp; }
			if (comparisonPointer(p9, p14) < 0) { temp = p9; p9 = p14; p14 = temp; }
			if (comparisonPointer(p10, p15) < 0) { temp = p10; p10 = p15; p15 = temp; }
			if (comparisonPointer(p10, p14) < 0) { temp = p10; p10 = p14; p14 = temp; }
			if (comparisonPointer(p8, p12) < 0) { temp = p8; p8 = p12; p12 = temp; }
			if (comparisonPointer(p8, p11) < 0) { temp = p8; p8 = p11; p11 = temp; }
			if (comparisonPointer(p9, p13) < 0) { temp = p9; p9 = p13; p13 = temp; }
			if (comparisonPointer(p10, p13) < 0) { temp = p10; p10 = p13; p13 = temp; }
			if (comparisonPointer(p9, p11) < 0) { temp = p9; p9 = p11; p11 = temp; }
			if (comparisonPointer(p10, p12) < 0) { temp = p10; p10 = p12; p12 = temp; }
			if (comparisonPointer(p10, p11) < 0) { temp = p10; p10 = p11; p11 = temp; }
		}

		/// <summary>
		/// Sorts a collection of 24 elements in descending order using the specified function pointer.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparisonPointer">The function pointer to use when comparing elements.</param>
		public unsafe static void Sort24Descending<T>(ref T p0, delegate* managed<T, T, int> comparisonPointer)
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
			ref var p16 = ref Unsafe.Add(ref p0, 16);
			ref var p17 = ref Unsafe.Add(ref p0, 17);
			ref var p18 = ref Unsafe.Add(ref p0, 18);
			ref var p19 = ref Unsafe.Add(ref p0, 19);
			ref var p20 = ref Unsafe.Add(ref p0, 20);
			ref var p21 = ref Unsafe.Add(ref p0, 21);
			ref var p22 = ref Unsafe.Add(ref p0, 22);
			ref var p23 = ref Unsafe.Add(ref p0, 23);

			T temp;
			if (comparisonPointer(p1, p2) < 0) { temp = p1; p1 = p2; p2 = temp; }
			if (comparisonPointer(p0, p2) < 0) { temp = p0; p0 = p2; p2 = temp; }
			if (comparisonPointer(p0, p1) < 0) { temp = p0; p0 = p1; p1 = temp; }
			if (comparisonPointer(p4, p5) < 0) { temp = p4; p4 = p5; p5 = temp; }
			if (comparisonPointer(p3, p5) < 0) { temp = p3; p3 = p5; p5 = temp; }
			if (comparisonPointer(p3, p4) < 0) { temp = p3; p3 = p4; p4 = temp; }
			if (comparisonPointer(p0, p4) < 0) { temp = p0; p0 = p4; p4 = temp; }
			if (comparisonPointer(p0, p3) < 0) { temp = p0; p0 = p3; p3 = temp; }
			if (comparisonPointer(p1, p5) < 0) { temp = p1; p1 = p5; p5 = temp; }
			if (comparisonPointer(p2, p5) < 0) { temp = p2; p2 = p5; p5 = temp; }
			if (comparisonPointer(p1, p3) < 0) { temp = p1; p1 = p3; p3 = temp; }
			if (comparisonPointer(p2, p4) < 0) { temp = p2; p2 = p4; p4 = temp; }
			if (comparisonPointer(p2, p3) < 0) { temp = p2; p2 = p3; p3 = temp; }
			if (comparisonPointer(p7, p8) < 0) { temp = p7; p7 = p8; p8 = temp; }
			if (comparisonPointer(p6, p8) < 0) { temp = p6; p6 = p8; p8 = temp; }
			if (comparisonPointer(p6, p7) < 0) { temp = p6; p6 = p7; p7 = temp; }
			if (comparisonPointer(p10, p11) < 0) { temp = p10; p10 = p11; p11 = temp; }
			if (comparisonPointer(p9, p11) < 0) { temp = p9; p9 = p11; p11 = temp; }
			if (comparisonPointer(p9, p10) < 0) { temp = p9; p9 = p10; p10 = temp; }
			if (comparisonPointer(p6, p10) < 0) { temp = p6; p6 = p10; p10 = temp; }
			if (comparisonPointer(p6, p9) < 0) { temp = p6; p6 = p9; p9 = temp; }
			if (comparisonPointer(p7, p11) < 0) { temp = p7; p7 = p11; p11 = temp; }
			if (comparisonPointer(p8, p11) < 0) { temp = p8; p8 = p11; p11 = temp; }
			if (comparisonPointer(p7, p9) < 0) { temp = p7; p7 = p9; p9 = temp; }
			if (comparisonPointer(p8, p10) < 0) { temp = p8; p8 = p10; p10 = temp; }
			if (comparisonPointer(p8, p9) < 0) { temp = p8; p8 = p9; p9 = temp; }
			if (comparisonPointer(p0, p7) < 0) { temp = p0; p0 = p7; p7 = temp; }
			if (comparisonPointer(p0, p6) < 0) { temp = p0; p0 = p6; p6 = temp; }
			if (comparisonPointer(p1, p8) < 0) { temp = p1; p1 = p8; p8 = temp; }
			if (comparisonPointer(p2, p8) < 0) { temp = p2; p2 = p8; p8 = temp; }
			if (comparisonPointer(p1, p6) < 0) { temp = p1; p1 = p6; p6 = temp; }
			if (comparisonPointer(p2, p7) < 0) { temp = p2; p2 = p7; p7 = temp; }
			if (comparisonPointer(p2, p6) < 0) { temp = p2; p2 = p6; p6 = temp; }
			if (comparisonPointer(p3, p10) < 0) { temp = p3; p3 = p10; p10 = temp; }
			if (comparisonPointer(p3, p9) < 0) { temp = p3; p3 = p9; p9 = temp; }
			if (comparisonPointer(p4, p11) < 0) { temp = p4; p4 = p11; p11 = temp; }
			if (comparisonPointer(p5, p11) < 0) { temp = p5; p5 = p11; p11 = temp; }
			if (comparisonPointer(p4, p9) < 0) { temp = p4; p4 = p9; p9 = temp; }
			if (comparisonPointer(p5, p10) < 0) { temp = p5; p5 = p10; p10 = temp; }
			if (comparisonPointer(p5, p9) < 0) { temp = p5; p5 = p9; p9 = temp; }
			if (comparisonPointer(p3, p7) < 0) { temp = p3; p3 = p7; p7 = temp; }
			if (comparisonPointer(p3, p6) < 0) { temp = p3; p3 = p6; p6 = temp; }
			if (comparisonPointer(p4, p8) < 0) { temp = p4; p4 = p8; p8 = temp; }
			if (comparisonPointer(p5, p8) < 0) { temp = p5; p5 = p8; p8 = temp; }
			if (comparisonPointer(p4, p6) < 0) { temp = p4; p4 = p6; p6 = temp; }
			if (comparisonPointer(p5, p7) < 0) { temp = p5; p5 = p7; p7 = temp; }
			if (comparisonPointer(p5, p6) < 0) { temp = p5; p5 = p6; p6 = temp; }
			if (comparisonPointer(p13, p14) < 0) { temp = p13; p13 = p14; p14 = temp; }
			if (comparisonPointer(p12, p14) < 0) { temp = p12; p12 = p14; p14 = temp; }
			if (comparisonPointer(p12, p13) < 0) { temp = p12; p12 = p13; p13 = temp; }
			if (comparisonPointer(p16, p17) < 0) { temp = p16; p16 = p17; p17 = temp; }
			if (comparisonPointer(p15, p17) < 0) { temp = p15; p15 = p17; p17 = temp; }
			if (comparisonPointer(p15, p16) < 0) { temp = p15; p15 = p16; p16 = temp; }
			if (comparisonPointer(p12, p16) < 0) { temp = p12; p12 = p16; p16 = temp; }
			if (comparisonPointer(p12, p15) < 0) { temp = p12; p12 = p15; p15 = temp; }
			if (comparisonPointer(p13, p17) < 0) { temp = p13; p13 = p17; p17 = temp; }
			if (comparisonPointer(p14, p17) < 0) { temp = p14; p14 = p17; p17 = temp; }
			if (comparisonPointer(p13, p15) < 0) { temp = p13; p13 = p15; p15 = temp; }
			if (comparisonPointer(p14, p16) < 0) { temp = p14; p14 = p16; p16 = temp; }
			if (comparisonPointer(p14, p15) < 0) { temp = p14; p14 = p15; p15 = temp; }
			if (comparisonPointer(p19, p20) < 0) { temp = p19; p19 = p20; p20 = temp; }
			if (comparisonPointer(p18, p20) < 0) { temp = p18; p18 = p20; p20 = temp; }
			if (comparisonPointer(p18, p19) < 0) { temp = p18; p18 = p19; p19 = temp; }
			if (comparisonPointer(p22, p23) < 0) { temp = p22; p22 = p23; p23 = temp; }
			if (comparisonPointer(p21, p23) < 0) { temp = p21; p21 = p23; p23 = temp; }
			if (comparisonPointer(p21, p22) < 0) { temp = p21; p21 = p22; p22 = temp; }
			if (comparisonPointer(p18, p22) < 0) { temp = p18; p18 = p22; p22 = temp; }
			if (comparisonPointer(p18, p21) < 0) { temp = p18; p18 = p21; p21 = temp; }
			if (comparisonPointer(p19, p23) < 0) { temp = p19; p19 = p23; p23 = temp; }
			if (comparisonPointer(p20, p23) < 0) { temp = p20; p20 = p23; p23 = temp; }
			if (comparisonPointer(p19, p21) < 0) { temp = p19; p19 = p21; p21 = temp; }
			if (comparisonPointer(p20, p22) < 0) { temp = p20; p20 = p22; p22 = temp; }
			if (comparisonPointer(p20, p21) < 0) { temp = p20; p20 = p21; p21 = temp; }
			if (comparisonPointer(p12, p19) < 0) { temp = p12; p12 = p19; p19 = temp; }
			if (comparisonPointer(p12, p18) < 0) { temp = p12; p12 = p18; p18 = temp; }
			if (comparisonPointer(p13, p20) < 0) { temp = p13; p13 = p20; p20 = temp; }
			if (comparisonPointer(p14, p20) < 0) { temp = p14; p14 = p20; p20 = temp; }
			if (comparisonPointer(p13, p18) < 0) { temp = p13; p13 = p18; p18 = temp; }
			if (comparisonPointer(p14, p19) < 0) { temp = p14; p14 = p19; p19 = temp; }
			if (comparisonPointer(p14, p18) < 0) { temp = p14; p14 = p18; p18 = temp; }
			if (comparisonPointer(p15, p22) < 0) { temp = p15; p15 = p22; p22 = temp; }
			if (comparisonPointer(p15, p21) < 0) { temp = p15; p15 = p21; p21 = temp; }
			if (comparisonPointer(p16, p23) < 0) { temp = p16; p16 = p23; p23 = temp; }
			if (comparisonPointer(p17, p23) < 0) { temp = p17; p17 = p23; p23 = temp; }
			if (comparisonPointer(p16, p21) < 0) { temp = p16; p16 = p21; p21 = temp; }
			if (comparisonPointer(p17, p22) < 0) { temp = p17; p17 = p22; p22 = temp; }
			if (comparisonPointer(p17, p21) < 0) { temp = p17; p17 = p21; p21 = temp; }
			if (comparisonPointer(p15, p19) < 0) { temp = p15; p15 = p19; p19 = temp; }
			if (comparisonPointer(p15, p18) < 0) { temp = p15; p15 = p18; p18 = temp; }
			if (comparisonPointer(p16, p20) < 0) { temp = p16; p16 = p20; p20 = temp; }
			if (comparisonPointer(p17, p20) < 0) { temp = p17; p17 = p20; p20 = temp; }
			if (comparisonPointer(p16, p18) < 0) { temp = p16; p16 = p18; p18 = temp; }
			if (comparisonPointer(p17, p19) < 0) { temp = p17; p17 = p19; p19 = temp; }
			if (comparisonPointer(p17, p18) < 0) { temp = p17; p17 = p18; p18 = temp; }
			if (comparisonPointer(p0, p13) < 0) { temp = p0; p0 = p13; p13 = temp; }
			if (comparisonPointer(p0, p12) < 0) { temp = p0; p0 = p12; p12 = temp; }
			if (comparisonPointer(p1, p14) < 0) { temp = p1; p1 = p14; p14 = temp; }
			if (comparisonPointer(p2, p14) < 0) { temp = p2; p2 = p14; p14 = temp; }
			if (comparisonPointer(p1, p12) < 0) { temp = p1; p1 = p12; p12 = temp; }
			if (comparisonPointer(p2, p13) < 0) { temp = p2; p2 = p13; p13 = temp; }
			if (comparisonPointer(p2, p12) < 0) { temp = p2; p2 = p12; p12 = temp; }
			if (comparisonPointer(p3, p16) < 0) { temp = p3; p3 = p16; p16 = temp; }
			if (comparisonPointer(p3, p15) < 0) { temp = p3; p3 = p15; p15 = temp; }
			if (comparisonPointer(p4, p17) < 0) { temp = p4; p4 = p17; p17 = temp; }
			if (comparisonPointer(p5, p17) < 0) { temp = p5; p5 = p17; p17 = temp; }
			if (comparisonPointer(p4, p15) < 0) { temp = p4; p4 = p15; p15 = temp; }
			if (comparisonPointer(p5, p16) < 0) { temp = p5; p5 = p16; p16 = temp; }
			if (comparisonPointer(p5, p15) < 0) { temp = p5; p5 = p15; p15 = temp; }
			if (comparisonPointer(p3, p13) < 0) { temp = p3; p3 = p13; p13 = temp; }
			if (comparisonPointer(p3, p12) < 0) { temp = p3; p3 = p12; p12 = temp; }
			if (comparisonPointer(p4, p14) < 0) { temp = p4; p4 = p14; p14 = temp; }
			if (comparisonPointer(p5, p14) < 0) { temp = p5; p5 = p14; p14 = temp; }
			if (comparisonPointer(p4, p12) < 0) { temp = p4; p4 = p12; p12 = temp; }
			if (comparisonPointer(p5, p13) < 0) { temp = p5; p5 = p13; p13 = temp; }
			if (comparisonPointer(p5, p12) < 0) { temp = p5; p5 = p12; p12 = temp; }
			if (comparisonPointer(p6, p19) < 0) { temp = p6; p6 = p19; p19 = temp; }
			if (comparisonPointer(p6, p18) < 0) { temp = p6; p6 = p18; p18 = temp; }
			if (comparisonPointer(p7, p20) < 0) { temp = p7; p7 = p20; p20 = temp; }
			if (comparisonPointer(p8, p20) < 0) { temp = p8; p8 = p20; p20 = temp; }
			if (comparisonPointer(p7, p18) < 0) { temp = p7; p7 = p18; p18 = temp; }
			if (comparisonPointer(p8, p19) < 0) { temp = p8; p8 = p19; p19 = temp; }
			if (comparisonPointer(p8, p18) < 0) { temp = p8; p8 = p18; p18 = temp; }
			if (comparisonPointer(p9, p22) < 0) { temp = p9; p9 = p22; p22 = temp; }
			if (comparisonPointer(p9, p21) < 0) { temp = p9; p9 = p21; p21 = temp; }
			if (comparisonPointer(p10, p23) < 0) { temp = p10; p10 = p23; p23 = temp; }
			if (comparisonPointer(p11, p23) < 0) { temp = p11; p11 = p23; p23 = temp; }
			if (comparisonPointer(p10, p21) < 0) { temp = p10; p10 = p21; p21 = temp; }
			if (comparisonPointer(p11, p22) < 0) { temp = p11; p11 = p22; p22 = temp; }
			if (comparisonPointer(p11, p21) < 0) { temp = p11; p11 = p21; p21 = temp; }
			if (comparisonPointer(p9, p19) < 0) { temp = p9; p9 = p19; p19 = temp; }
			if (comparisonPointer(p9, p18) < 0) { temp = p9; p9 = p18; p18 = temp; }
			if (comparisonPointer(p10, p20) < 0) { temp = p10; p10 = p20; p20 = temp; }
			if (comparisonPointer(p11, p20) < 0) { temp = p11; p11 = p20; p20 = temp; }
			if (comparisonPointer(p10, p18) < 0) { temp = p10; p10 = p18; p18 = temp; }
			if (comparisonPointer(p11, p19) < 0) { temp = p11; p11 = p19; p19 = temp; }
			if (comparisonPointer(p11, p18) < 0) { temp = p11; p11 = p18; p18 = temp; }
			if (comparisonPointer(p6, p13) < 0) { temp = p6; p6 = p13; p13 = temp; }
			if (comparisonPointer(p6, p12) < 0) { temp = p6; p6 = p12; p12 = temp; }
			if (comparisonPointer(p7, p14) < 0) { temp = p7; p7 = p14; p14 = temp; }
			if (comparisonPointer(p8, p14) < 0) { temp = p8; p8 = p14; p14 = temp; }
			if (comparisonPointer(p7, p12) < 0) { temp = p7; p7 = p12; p12 = temp; }
			if (comparisonPointer(p8, p13) < 0) { temp = p8; p8 = p13; p13 = temp; }
			if (comparisonPointer(p8, p12) < 0) { temp = p8; p8 = p12; p12 = temp; }
			if (comparisonPointer(p9, p16) < 0) { temp = p9; p9 = p16; p16 = temp; }
			if (comparisonPointer(p9, p15) < 0) { temp = p9; p9 = p15; p15 = temp; }
			if (comparisonPointer(p10, p17) < 0) { temp = p10; p10 = p17; p17 = temp; }
			if (comparisonPointer(p11, p17) < 0) { temp = p11; p11 = p17; p17 = temp; }
			if (comparisonPointer(p10, p15) < 0) { temp = p10; p10 = p15; p15 = temp; }
			if (comparisonPointer(p11, p16) < 0) { temp = p11; p11 = p16; p16 = temp; }
			if (comparisonPointer(p11, p15) < 0) { temp = p11; p11 = p15; p15 = temp; }
			if (comparisonPointer(p9, p13) < 0) { temp = p9; p9 = p13; p13 = temp; }
			if (comparisonPointer(p9, p12) < 0) { temp = p9; p9 = p12; p12 = temp; }
			if (comparisonPointer(p10, p14) < 0) { temp = p10; p10 = p14; p14 = temp; }
			if (comparisonPointer(p11, p14) < 0) { temp = p11; p11 = p14; p14 = temp; }
			if (comparisonPointer(p10, p12) < 0) { temp = p10; p10 = p12; p12 = temp; }
			if (comparisonPointer(p11, p13) < 0) { temp = p11; p11 = p13; p13 = temp; }
			if (comparisonPointer(p11, p12) < 0) { temp = p11; p11 = p12; p12 = temp; }
		}

		/// <summary>
		/// Sorts a collection of 25 elements in descending order using the specified function pointer.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparisonPointer">The function pointer to use when comparing elements.</param>
		public unsafe static void Sort25Descending<T>(ref T p0, delegate* managed<T, T, int> comparisonPointer)
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
			ref var p16 = ref Unsafe.Add(ref p0, 16);
			ref var p17 = ref Unsafe.Add(ref p0, 17);
			ref var p18 = ref Unsafe.Add(ref p0, 18);
			ref var p19 = ref Unsafe.Add(ref p0, 19);
			ref var p20 = ref Unsafe.Add(ref p0, 20);
			ref var p21 = ref Unsafe.Add(ref p0, 21);
			ref var p22 = ref Unsafe.Add(ref p0, 22);
			ref var p23 = ref Unsafe.Add(ref p0, 23);
			ref var p24 = ref Unsafe.Add(ref p0, 24);

			T temp;
			if (comparisonPointer(p1, p2) < 0) { temp = p1; p1 = p2; p2 = temp; }
			if (comparisonPointer(p0, p2) < 0) { temp = p0; p0 = p2; p2 = temp; }
			if (comparisonPointer(p0, p1) < 0) { temp = p0; p0 = p1; p1 = temp; }
			if (comparisonPointer(p4, p5) < 0) { temp = p4; p4 = p5; p5 = temp; }
			if (comparisonPointer(p3, p5) < 0) { temp = p3; p3 = p5; p5 = temp; }
			if (comparisonPointer(p3, p4) < 0) { temp = p3; p3 = p4; p4 = temp; }
			if (comparisonPointer(p0, p4) < 0) { temp = p0; p0 = p4; p4 = temp; }
			if (comparisonPointer(p0, p3) < 0) { temp = p0; p0 = p3; p3 = temp; }
			if (comparisonPointer(p1, p5) < 0) { temp = p1; p1 = p5; p5 = temp; }
			if (comparisonPointer(p2, p5) < 0) { temp = p2; p2 = p5; p5 = temp; }
			if (comparisonPointer(p1, p3) < 0) { temp = p1; p1 = p3; p3 = temp; }
			if (comparisonPointer(p2, p4) < 0) { temp = p2; p2 = p4; p4 = temp; }
			if (comparisonPointer(p2, p3) < 0) { temp = p2; p2 = p3; p3 = temp; }
			if (comparisonPointer(p7, p8) < 0) { temp = p7; p7 = p8; p8 = temp; }
			if (comparisonPointer(p6, p8) < 0) { temp = p6; p6 = p8; p8 = temp; }
			if (comparisonPointer(p6, p7) < 0) { temp = p6; p6 = p7; p7 = temp; }
			if (comparisonPointer(p10, p11) < 0) { temp = p10; p10 = p11; p11 = temp; }
			if (comparisonPointer(p9, p11) < 0) { temp = p9; p9 = p11; p11 = temp; }
			if (comparisonPointer(p9, p10) < 0) { temp = p9; p9 = p10; p10 = temp; }
			if (comparisonPointer(p6, p10) < 0) { temp = p6; p6 = p10; p10 = temp; }
			if (comparisonPointer(p6, p9) < 0) { temp = p6; p6 = p9; p9 = temp; }
			if (comparisonPointer(p7, p11) < 0) { temp = p7; p7 = p11; p11 = temp; }
			if (comparisonPointer(p8, p11) < 0) { temp = p8; p8 = p11; p11 = temp; }
			if (comparisonPointer(p7, p9) < 0) { temp = p7; p7 = p9; p9 = temp; }
			if (comparisonPointer(p8, p10) < 0) { temp = p8; p8 = p10; p10 = temp; }
			if (comparisonPointer(p8, p9) < 0) { temp = p8; p8 = p9; p9 = temp; }
			if (comparisonPointer(p0, p7) < 0) { temp = p0; p0 = p7; p7 = temp; }
			if (comparisonPointer(p0, p6) < 0) { temp = p0; p0 = p6; p6 = temp; }
			if (comparisonPointer(p1, p8) < 0) { temp = p1; p1 = p8; p8 = temp; }
			if (comparisonPointer(p2, p8) < 0) { temp = p2; p2 = p8; p8 = temp; }
			if (comparisonPointer(p1, p6) < 0) { temp = p1; p1 = p6; p6 = temp; }
			if (comparisonPointer(p2, p7) < 0) { temp = p2; p2 = p7; p7 = temp; }
			if (comparisonPointer(p2, p6) < 0) { temp = p2; p2 = p6; p6 = temp; }
			if (comparisonPointer(p3, p10) < 0) { temp = p3; p3 = p10; p10 = temp; }
			if (comparisonPointer(p3, p9) < 0) { temp = p3; p3 = p9; p9 = temp; }
			if (comparisonPointer(p4, p11) < 0) { temp = p4; p4 = p11; p11 = temp; }
			if (comparisonPointer(p5, p11) < 0) { temp = p5; p5 = p11; p11 = temp; }
			if (comparisonPointer(p4, p9) < 0) { temp = p4; p4 = p9; p9 = temp; }
			if (comparisonPointer(p5, p10) < 0) { temp = p5; p5 = p10; p10 = temp; }
			if (comparisonPointer(p5, p9) < 0) { temp = p5; p5 = p9; p9 = temp; }
			if (comparisonPointer(p3, p7) < 0) { temp = p3; p3 = p7; p7 = temp; }
			if (comparisonPointer(p3, p6) < 0) { temp = p3; p3 = p6; p6 = temp; }
			if (comparisonPointer(p4, p8) < 0) { temp = p4; p4 = p8; p8 = temp; }
			if (comparisonPointer(p5, p8) < 0) { temp = p5; p5 = p8; p8 = temp; }
			if (comparisonPointer(p4, p6) < 0) { temp = p4; p4 = p6; p6 = temp; }
			if (comparisonPointer(p5, p7) < 0) { temp = p5; p5 = p7; p7 = temp; }
			if (comparisonPointer(p5, p6) < 0) { temp = p5; p5 = p6; p6 = temp; }
			if (comparisonPointer(p13, p14) < 0) { temp = p13; p13 = p14; p14 = temp; }
			if (comparisonPointer(p12, p14) < 0) { temp = p12; p12 = p14; p14 = temp; }
			if (comparisonPointer(p12, p13) < 0) { temp = p12; p12 = p13; p13 = temp; }
			if (comparisonPointer(p16, p17) < 0) { temp = p16; p16 = p17; p17 = temp; }
			if (comparisonPointer(p15, p17) < 0) { temp = p15; p15 = p17; p17 = temp; }
			if (comparisonPointer(p15, p16) < 0) { temp = p15; p15 = p16; p16 = temp; }
			if (comparisonPointer(p12, p16) < 0) { temp = p12; p12 = p16; p16 = temp; }
			if (comparisonPointer(p12, p15) < 0) { temp = p12; p12 = p15; p15 = temp; }
			if (comparisonPointer(p13, p17) < 0) { temp = p13; p13 = p17; p17 = temp; }
			if (comparisonPointer(p14, p17) < 0) { temp = p14; p14 = p17; p17 = temp; }
			if (comparisonPointer(p13, p15) < 0) { temp = p13; p13 = p15; p15 = temp; }
			if (comparisonPointer(p14, p16) < 0) { temp = p14; p14 = p16; p16 = temp; }
			if (comparisonPointer(p14, p15) < 0) { temp = p14; p14 = p15; p15 = temp; }
			if (comparisonPointer(p19, p20) < 0) { temp = p19; p19 = p20; p20 = temp; }
			if (comparisonPointer(p18, p20) < 0) { temp = p18; p18 = p20; p20 = temp; }
			if (comparisonPointer(p18, p19) < 0) { temp = p18; p18 = p19; p19 = temp; }
			if (comparisonPointer(p21, p22) < 0) { temp = p21; p21 = p22; p22 = temp; }
			if (comparisonPointer(p23, p24) < 0) { temp = p23; p23 = p24; p24 = temp; }
			if (comparisonPointer(p21, p23) < 0) { temp = p21; p21 = p23; p23 = temp; }
			if (comparisonPointer(p22, p24) < 0) { temp = p22; p22 = p24; p24 = temp; }
			if (comparisonPointer(p22, p23) < 0) { temp = p22; p22 = p23; p23 = temp; }
			if (comparisonPointer(p18, p22) < 0) { temp = p18; p18 = p22; p22 = temp; }
			if (comparisonPointer(p18, p21) < 0) { temp = p18; p18 = p21; p21 = temp; }
			if (comparisonPointer(p19, p23) < 0) { temp = p19; p19 = p23; p23 = temp; }
			if (comparisonPointer(p20, p24) < 0) { temp = p20; p20 = p24; p24 = temp; }
			if (comparisonPointer(p20, p23) < 0) { temp = p20; p20 = p23; p23 = temp; }
			if (comparisonPointer(p19, p21) < 0) { temp = p19; p19 = p21; p21 = temp; }
			if (comparisonPointer(p20, p22) < 0) { temp = p20; p20 = p22; p22 = temp; }
			if (comparisonPointer(p20, p21) < 0) { temp = p20; p20 = p21; p21 = temp; }
			if (comparisonPointer(p12, p19) < 0) { temp = p12; p12 = p19; p19 = temp; }
			if (comparisonPointer(p12, p18) < 0) { temp = p12; p12 = p18; p18 = temp; }
			if (comparisonPointer(p13, p20) < 0) { temp = p13; p13 = p20; p20 = temp; }
			if (comparisonPointer(p14, p21) < 0) { temp = p14; p14 = p21; p21 = temp; }
			if (comparisonPointer(p14, p20) < 0) { temp = p14; p14 = p20; p20 = temp; }
			if (comparisonPointer(p13, p18) < 0) { temp = p13; p13 = p18; p18 = temp; }
			if (comparisonPointer(p14, p19) < 0) { temp = p14; p14 = p19; p19 = temp; }
			if (comparisonPointer(p14, p18) < 0) { temp = p14; p14 = p18; p18 = temp; }
			if (comparisonPointer(p15, p23) < 0) { temp = p15; p15 = p23; p23 = temp; }
			if (comparisonPointer(p15, p22) < 0) { temp = p15; p15 = p22; p22 = temp; }
			if (comparisonPointer(p16, p24) < 0) { temp = p16; p16 = p24; p24 = temp; }
			if (comparisonPointer(p17, p24) < 0) { temp = p17; p17 = p24; p24 = temp; }
			if (comparisonPointer(p16, p22) < 0) { temp = p16; p16 = p22; p22 = temp; }
			if (comparisonPointer(p17, p23) < 0) { temp = p17; p17 = p23; p23 = temp; }
			if (comparisonPointer(p17, p22) < 0) { temp = p17; p17 = p22; p22 = temp; }
			if (comparisonPointer(p15, p19) < 0) { temp = p15; p15 = p19; p19 = temp; }
			if (comparisonPointer(p15, p18) < 0) { temp = p15; p15 = p18; p18 = temp; }
			if (comparisonPointer(p16, p20) < 0) { temp = p16; p16 = p20; p20 = temp; }
			if (comparisonPointer(p17, p21) < 0) { temp = p17; p17 = p21; p21 = temp; }
			if (comparisonPointer(p17, p20) < 0) { temp = p17; p17 = p20; p20 = temp; }
			if (comparisonPointer(p16, p18) < 0) { temp = p16; p16 = p18; p18 = temp; }
			if (comparisonPointer(p17, p19) < 0) { temp = p17; p17 = p19; p19 = temp; }
			if (comparisonPointer(p17, p18) < 0) { temp = p17; p17 = p18; p18 = temp; }
			if (comparisonPointer(p0, p13) < 0) { temp = p0; p0 = p13; p13 = temp; }
			if (comparisonPointer(p0, p12) < 0) { temp = p0; p0 = p12; p12 = temp; }
			if (comparisonPointer(p1, p14) < 0) { temp = p1; p1 = p14; p14 = temp; }
			if (comparisonPointer(p2, p15) < 0) { temp = p2; p2 = p15; p15 = temp; }
			if (comparisonPointer(p2, p14) < 0) { temp = p2; p2 = p14; p14 = temp; }
			if (comparisonPointer(p1, p12) < 0) { temp = p1; p1 = p12; p12 = temp; }
			if (comparisonPointer(p2, p13) < 0) { temp = p2; p2 = p13; p13 = temp; }
			if (comparisonPointer(p2, p12) < 0) { temp = p2; p2 = p12; p12 = temp; }
			if (comparisonPointer(p3, p17) < 0) { temp = p3; p3 = p17; p17 = temp; }
			if (comparisonPointer(p3, p16) < 0) { temp = p3; p3 = p16; p16 = temp; }
			if (comparisonPointer(p4, p18) < 0) { temp = p4; p4 = p18; p18 = temp; }
			if (comparisonPointer(p5, p18) < 0) { temp = p5; p5 = p18; p18 = temp; }
			if (comparisonPointer(p4, p16) < 0) { temp = p4; p4 = p16; p16 = temp; }
			if (comparisonPointer(p5, p17) < 0) { temp = p5; p5 = p17; p17 = temp; }
			if (comparisonPointer(p5, p16) < 0) { temp = p5; p5 = p16; p16 = temp; }
			if (comparisonPointer(p3, p13) < 0) { temp = p3; p3 = p13; p13 = temp; }
			if (comparisonPointer(p3, p12) < 0) { temp = p3; p3 = p12; p12 = temp; }
			if (comparisonPointer(p4, p14) < 0) { temp = p4; p4 = p14; p14 = temp; }
			if (comparisonPointer(p5, p15) < 0) { temp = p5; p5 = p15; p15 = temp; }
			if (comparisonPointer(p5, p14) < 0) { temp = p5; p5 = p14; p14 = temp; }
			if (comparisonPointer(p4, p12) < 0) { temp = p4; p4 = p12; p12 = temp; }
			if (comparisonPointer(p5, p13) < 0) { temp = p5; p5 = p13; p13 = temp; }
			if (comparisonPointer(p5, p12) < 0) { temp = p5; p5 = p12; p12 = temp; }
			if (comparisonPointer(p6, p20) < 0) { temp = p6; p6 = p20; p20 = temp; }
			if (comparisonPointer(p6, p19) < 0) { temp = p6; p6 = p19; p19 = temp; }
			if (comparisonPointer(p7, p21) < 0) { temp = p7; p7 = p21; p21 = temp; }
			if (comparisonPointer(p8, p21) < 0) { temp = p8; p8 = p21; p21 = temp; }
			if (comparisonPointer(p7, p19) < 0) { temp = p7; p7 = p19; p19 = temp; }
			if (comparisonPointer(p8, p20) < 0) { temp = p8; p8 = p20; p20 = temp; }
			if (comparisonPointer(p8, p19) < 0) { temp = p8; p8 = p19; p19 = temp; }
			if (comparisonPointer(p9, p23) < 0) { temp = p9; p9 = p23; p23 = temp; }
			if (comparisonPointer(p9, p22) < 0) { temp = p9; p9 = p22; p22 = temp; }
			if (comparisonPointer(p10, p24) < 0) { temp = p10; p10 = p24; p24 = temp; }
			if (comparisonPointer(p11, p24) < 0) { temp = p11; p11 = p24; p24 = temp; }
			if (comparisonPointer(p10, p22) < 0) { temp = p10; p10 = p22; p22 = temp; }
			if (comparisonPointer(p11, p23) < 0) { temp = p11; p11 = p23; p23 = temp; }
			if (comparisonPointer(p11, p22) < 0) { temp = p11; p11 = p22; p22 = temp; }
			if (comparisonPointer(p9, p20) < 0) { temp = p9; p9 = p20; p20 = temp; }
			if (comparisonPointer(p9, p19) < 0) { temp = p9; p9 = p19; p19 = temp; }
			if (comparisonPointer(p10, p21) < 0) { temp = p10; p10 = p21; p21 = temp; }
			if (comparisonPointer(p11, p21) < 0) { temp = p11; p11 = p21; p21 = temp; }
			if (comparisonPointer(p10, p19) < 0) { temp = p10; p10 = p19; p19 = temp; }
			if (comparisonPointer(p11, p20) < 0) { temp = p11; p11 = p20; p20 = temp; }
			if (comparisonPointer(p11, p19) < 0) { temp = p11; p11 = p19; p19 = temp; }
			if (comparisonPointer(p6, p13) < 0) { temp = p6; p6 = p13; p13 = temp; }
			if (comparisonPointer(p6, p12) < 0) { temp = p6; p6 = p12; p12 = temp; }
			if (comparisonPointer(p7, p14) < 0) { temp = p7; p7 = p14; p14 = temp; }
			if (comparisonPointer(p8, p15) < 0) { temp = p8; p8 = p15; p15 = temp; }
			if (comparisonPointer(p8, p14) < 0) { temp = p8; p8 = p14; p14 = temp; }
			if (comparisonPointer(p7, p12) < 0) { temp = p7; p7 = p12; p12 = temp; }
			if (comparisonPointer(p8, p13) < 0) { temp = p8; p8 = p13; p13 = temp; }
			if (comparisonPointer(p8, p12) < 0) { temp = p8; p8 = p12; p12 = temp; }
			if (comparisonPointer(p9, p17) < 0) { temp = p9; p9 = p17; p17 = temp; }
			if (comparisonPointer(p9, p16) < 0) { temp = p9; p9 = p16; p16 = temp; }
			if (comparisonPointer(p10, p18) < 0) { temp = p10; p10 = p18; p18 = temp; }
			if (comparisonPointer(p11, p18) < 0) { temp = p11; p11 = p18; p18 = temp; }
			if (comparisonPointer(p10, p16) < 0) { temp = p10; p10 = p16; p16 = temp; }
			if (comparisonPointer(p11, p17) < 0) { temp = p11; p11 = p17; p17 = temp; }
			if (comparisonPointer(p11, p16) < 0) { temp = p11; p11 = p16; p16 = temp; }
			if (comparisonPointer(p9, p13) < 0) { temp = p9; p9 = p13; p13 = temp; }
			if (comparisonPointer(p9, p12) < 0) { temp = p9; p9 = p12; p12 = temp; }
			if (comparisonPointer(p10, p14) < 0) { temp = p10; p10 = p14; p14 = temp; }
			if (comparisonPointer(p11, p15) < 0) { temp = p11; p11 = p15; p15 = temp; }
			if (comparisonPointer(p11, p14) < 0) { temp = p11; p11 = p14; p14 = temp; }
			if (comparisonPointer(p10, p12) < 0) { temp = p10; p10 = p12; p12 = temp; }
			if (comparisonPointer(p11, p13) < 0) { temp = p11; p11 = p13; p13 = temp; }
			if (comparisonPointer(p11, p12) < 0) { temp = p11; p11 = p12; p12 = temp; }
		}

		/// <summary>
		/// Sorts a collection of 26 elements in descending order using the specified function pointer.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparisonPointer">The function pointer to use when comparing elements.</param>
		public unsafe static void Sort26Descending<T>(ref T p0, delegate* managed<T, T, int> comparisonPointer)
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
			ref var p16 = ref Unsafe.Add(ref p0, 16);
			ref var p17 = ref Unsafe.Add(ref p0, 17);
			ref var p18 = ref Unsafe.Add(ref p0, 18);
			ref var p19 = ref Unsafe.Add(ref p0, 19);
			ref var p20 = ref Unsafe.Add(ref p0, 20);
			ref var p21 = ref Unsafe.Add(ref p0, 21);
			ref var p22 = ref Unsafe.Add(ref p0, 22);
			ref var p23 = ref Unsafe.Add(ref p0, 23);
			ref var p24 = ref Unsafe.Add(ref p0, 24);
			ref var p25 = ref Unsafe.Add(ref p0, 25);

			T temp;
			if (comparisonPointer(p1, p2) < 0) { temp = p1; p1 = p2; p2 = temp; }
			if (comparisonPointer(p0, p2) < 0) { temp = p0; p0 = p2; p2 = temp; }
			if (comparisonPointer(p0, p1) < 0) { temp = p0; p0 = p1; p1 = temp; }
			if (comparisonPointer(p4, p5) < 0) { temp = p4; p4 = p5; p5 = temp; }
			if (comparisonPointer(p3, p5) < 0) { temp = p3; p3 = p5; p5 = temp; }
			if (comparisonPointer(p3, p4) < 0) { temp = p3; p3 = p4; p4 = temp; }
			if (comparisonPointer(p0, p4) < 0) { temp = p0; p0 = p4; p4 = temp; }
			if (comparisonPointer(p0, p3) < 0) { temp = p0; p0 = p3; p3 = temp; }
			if (comparisonPointer(p1, p5) < 0) { temp = p1; p1 = p5; p5 = temp; }
			if (comparisonPointer(p2, p5) < 0) { temp = p2; p2 = p5; p5 = temp; }
			if (comparisonPointer(p1, p3) < 0) { temp = p1; p1 = p3; p3 = temp; }
			if (comparisonPointer(p2, p4) < 0) { temp = p2; p2 = p4; p4 = temp; }
			if (comparisonPointer(p2, p3) < 0) { temp = p2; p2 = p3; p3 = temp; }
			if (comparisonPointer(p7, p8) < 0) { temp = p7; p7 = p8; p8 = temp; }
			if (comparisonPointer(p6, p8) < 0) { temp = p6; p6 = p8; p8 = temp; }
			if (comparisonPointer(p6, p7) < 0) { temp = p6; p6 = p7; p7 = temp; }
			if (comparisonPointer(p9, p10) < 0) { temp = p9; p9 = p10; p10 = temp; }
			if (comparisonPointer(p11, p12) < 0) { temp = p11; p11 = p12; p12 = temp; }
			if (comparisonPointer(p9, p11) < 0) { temp = p9; p9 = p11; p11 = temp; }
			if (comparisonPointer(p10, p12) < 0) { temp = p10; p10 = p12; p12 = temp; }
			if (comparisonPointer(p10, p11) < 0) { temp = p10; p10 = p11; p11 = temp; }
			if (comparisonPointer(p6, p10) < 0) { temp = p6; p6 = p10; p10 = temp; }
			if (comparisonPointer(p6, p9) < 0) { temp = p6; p6 = p9; p9 = temp; }
			if (comparisonPointer(p7, p11) < 0) { temp = p7; p7 = p11; p11 = temp; }
			if (comparisonPointer(p8, p12) < 0) { temp = p8; p8 = p12; p12 = temp; }
			if (comparisonPointer(p8, p11) < 0) { temp = p8; p8 = p11; p11 = temp; }
			if (comparisonPointer(p7, p9) < 0) { temp = p7; p7 = p9; p9 = temp; }
			if (comparisonPointer(p8, p10) < 0) { temp = p8; p8 = p10; p10 = temp; }
			if (comparisonPointer(p8, p9) < 0) { temp = p8; p8 = p9; p9 = temp; }
			if (comparisonPointer(p0, p7) < 0) { temp = p0; p0 = p7; p7 = temp; }
			if (comparisonPointer(p0, p6) < 0) { temp = p0; p0 = p6; p6 = temp; }
			if (comparisonPointer(p1, p8) < 0) { temp = p1; p1 = p8; p8 = temp; }
			if (comparisonPointer(p2, p9) < 0) { temp = p2; p2 = p9; p9 = temp; }
			if (comparisonPointer(p2, p8) < 0) { temp = p2; p2 = p8; p8 = temp; }
			if (comparisonPointer(p1, p6) < 0) { temp = p1; p1 = p6; p6 = temp; }
			if (comparisonPointer(p2, p7) < 0) { temp = p2; p2 = p7; p7 = temp; }
			if (comparisonPointer(p2, p6) < 0) { temp = p2; p2 = p6; p6 = temp; }
			if (comparisonPointer(p3, p11) < 0) { temp = p3; p3 = p11; p11 = temp; }
			if (comparisonPointer(p3, p10) < 0) { temp = p3; p3 = p10; p10 = temp; }
			if (comparisonPointer(p4, p12) < 0) { temp = p4; p4 = p12; p12 = temp; }
			if (comparisonPointer(p5, p12) < 0) { temp = p5; p5 = p12; p12 = temp; }
			if (comparisonPointer(p4, p10) < 0) { temp = p4; p4 = p10; p10 = temp; }
			if (comparisonPointer(p5, p11) < 0) { temp = p5; p5 = p11; p11 = temp; }
			if (comparisonPointer(p5, p10) < 0) { temp = p5; p5 = p10; p10 = temp; }
			if (comparisonPointer(p3, p7) < 0) { temp = p3; p3 = p7; p7 = temp; }
			if (comparisonPointer(p3, p6) < 0) { temp = p3; p3 = p6; p6 = temp; }
			if (comparisonPointer(p4, p8) < 0) { temp = p4; p4 = p8; p8 = temp; }
			if (comparisonPointer(p5, p9) < 0) { temp = p5; p5 = p9; p9 = temp; }
			if (comparisonPointer(p5, p8) < 0) { temp = p5; p5 = p8; p8 = temp; }
			if (comparisonPointer(p4, p6) < 0) { temp = p4; p4 = p6; p6 = temp; }
			if (comparisonPointer(p5, p7) < 0) { temp = p5; p5 = p7; p7 = temp; }
			if (comparisonPointer(p5, p6) < 0) { temp = p5; p5 = p6; p6 = temp; }
			if (comparisonPointer(p14, p15) < 0) { temp = p14; p14 = p15; p15 = temp; }
			if (comparisonPointer(p13, p15) < 0) { temp = p13; p13 = p15; p15 = temp; }
			if (comparisonPointer(p13, p14) < 0) { temp = p13; p13 = p14; p14 = temp; }
			if (comparisonPointer(p17, p18) < 0) { temp = p17; p17 = p18; p18 = temp; }
			if (comparisonPointer(p16, p18) < 0) { temp = p16; p16 = p18; p18 = temp; }
			if (comparisonPointer(p16, p17) < 0) { temp = p16; p16 = p17; p17 = temp; }
			if (comparisonPointer(p13, p17) < 0) { temp = p13; p13 = p17; p17 = temp; }
			if (comparisonPointer(p13, p16) < 0) { temp = p13; p13 = p16; p16 = temp; }
			if (comparisonPointer(p14, p18) < 0) { temp = p14; p14 = p18; p18 = temp; }
			if (comparisonPointer(p15, p18) < 0) { temp = p15; p15 = p18; p18 = temp; }
			if (comparisonPointer(p14, p16) < 0) { temp = p14; p14 = p16; p16 = temp; }
			if (comparisonPointer(p15, p17) < 0) { temp = p15; p15 = p17; p17 = temp; }
			if (comparisonPointer(p15, p16) < 0) { temp = p15; p15 = p16; p16 = temp; }
			if (comparisonPointer(p20, p21) < 0) { temp = p20; p20 = p21; p21 = temp; }
			if (comparisonPointer(p19, p21) < 0) { temp = p19; p19 = p21; p21 = temp; }
			if (comparisonPointer(p19, p20) < 0) { temp = p19; p19 = p20; p20 = temp; }
			if (comparisonPointer(p22, p23) < 0) { temp = p22; p22 = p23; p23 = temp; }
			if (comparisonPointer(p24, p25) < 0) { temp = p24; p24 = p25; p25 = temp; }
			if (comparisonPointer(p22, p24) < 0) { temp = p22; p22 = p24; p24 = temp; }
			if (comparisonPointer(p23, p25) < 0) { temp = p23; p23 = p25; p25 = temp; }
			if (comparisonPointer(p23, p24) < 0) { temp = p23; p23 = p24; p24 = temp; }
			if (comparisonPointer(p19, p23) < 0) { temp = p19; p19 = p23; p23 = temp; }
			if (comparisonPointer(p19, p22) < 0) { temp = p19; p19 = p22; p22 = temp; }
			if (comparisonPointer(p20, p24) < 0) { temp = p20; p20 = p24; p24 = temp; }
			if (comparisonPointer(p21, p25) < 0) { temp = p21; p21 = p25; p25 = temp; }
			if (comparisonPointer(p21, p24) < 0) { temp = p21; p21 = p24; p24 = temp; }
			if (comparisonPointer(p20, p22) < 0) { temp = p20; p20 = p22; p22 = temp; }
			if (comparisonPointer(p21, p23) < 0) { temp = p21; p21 = p23; p23 = temp; }
			if (comparisonPointer(p21, p22) < 0) { temp = p21; p21 = p22; p22 = temp; }
			if (comparisonPointer(p13, p20) < 0) { temp = p13; p13 = p20; p20 = temp; }
			if (comparisonPointer(p13, p19) < 0) { temp = p13; p13 = p19; p19 = temp; }
			if (comparisonPointer(p14, p21) < 0) { temp = p14; p14 = p21; p21 = temp; }
			if (comparisonPointer(p15, p22) < 0) { temp = p15; p15 = p22; p22 = temp; }
			if (comparisonPointer(p15, p21) < 0) { temp = p15; p15 = p21; p21 = temp; }
			if (comparisonPointer(p14, p19) < 0) { temp = p14; p14 = p19; p19 = temp; }
			if (comparisonPointer(p15, p20) < 0) { temp = p15; p15 = p20; p20 = temp; }
			if (comparisonPointer(p15, p19) < 0) { temp = p15; p15 = p19; p19 = temp; }
			if (comparisonPointer(p16, p24) < 0) { temp = p16; p16 = p24; p24 = temp; }
			if (comparisonPointer(p16, p23) < 0) { temp = p16; p16 = p23; p23 = temp; }
			if (comparisonPointer(p17, p25) < 0) { temp = p17; p17 = p25; p25 = temp; }
			if (comparisonPointer(p18, p25) < 0) { temp = p18; p18 = p25; p25 = temp; }
			if (comparisonPointer(p17, p23) < 0) { temp = p17; p17 = p23; p23 = temp; }
			if (comparisonPointer(p18, p24) < 0) { temp = p18; p18 = p24; p24 = temp; }
			if (comparisonPointer(p18, p23) < 0) { temp = p18; p18 = p23; p23 = temp; }
			if (comparisonPointer(p16, p20) < 0) { temp = p16; p16 = p20; p20 = temp; }
			if (comparisonPointer(p16, p19) < 0) { temp = p16; p16 = p19; p19 = temp; }
			if (comparisonPointer(p17, p21) < 0) { temp = p17; p17 = p21; p21 = temp; }
			if (comparisonPointer(p18, p22) < 0) { temp = p18; p18 = p22; p22 = temp; }
			if (comparisonPointer(p18, p21) < 0) { temp = p18; p18 = p21; p21 = temp; }
			if (comparisonPointer(p17, p19) < 0) { temp = p17; p17 = p19; p19 = temp; }
			if (comparisonPointer(p18, p20) < 0) { temp = p18; p18 = p20; p20 = temp; }
			if (comparisonPointer(p18, p19) < 0) { temp = p18; p18 = p19; p19 = temp; }
			if (comparisonPointer(p0, p14) < 0) { temp = p0; p0 = p14; p14 = temp; }
			if (comparisonPointer(p0, p13) < 0) { temp = p0; p0 = p13; p13 = temp; }
			if (comparisonPointer(p1, p15) < 0) { temp = p1; p1 = p15; p15 = temp; }
			if (comparisonPointer(p2, p16) < 0) { temp = p2; p2 = p16; p16 = temp; }
			if (comparisonPointer(p2, p15) < 0) { temp = p2; p2 = p15; p15 = temp; }
			if (comparisonPointer(p1, p13) < 0) { temp = p1; p1 = p13; p13 = temp; }
			if (comparisonPointer(p2, p14) < 0) { temp = p2; p2 = p14; p14 = temp; }
			if (comparisonPointer(p2, p13) < 0) { temp = p2; p2 = p13; p13 = temp; }
			if (comparisonPointer(p3, p18) < 0) { temp = p3; p3 = p18; p18 = temp; }
			if (comparisonPointer(p3, p17) < 0) { temp = p3; p3 = p17; p17 = temp; }
			if (comparisonPointer(p4, p19) < 0) { temp = p4; p4 = p19; p19 = temp; }
			if (comparisonPointer(p5, p19) < 0) { temp = p5; p5 = p19; p19 = temp; }
			if (comparisonPointer(p4, p17) < 0) { temp = p4; p4 = p17; p17 = temp; }
			if (comparisonPointer(p5, p18) < 0) { temp = p5; p5 = p18; p18 = temp; }
			if (comparisonPointer(p5, p17) < 0) { temp = p5; p5 = p17; p17 = temp; }
			if (comparisonPointer(p3, p14) < 0) { temp = p3; p3 = p14; p14 = temp; }
			if (comparisonPointer(p3, p13) < 0) { temp = p3; p3 = p13; p13 = temp; }
			if (comparisonPointer(p4, p15) < 0) { temp = p4; p4 = p15; p15 = temp; }
			if (comparisonPointer(p5, p16) < 0) { temp = p5; p5 = p16; p16 = temp; }
			if (comparisonPointer(p5, p15) < 0) { temp = p5; p5 = p15; p15 = temp; }
			if (comparisonPointer(p4, p13) < 0) { temp = p4; p4 = p13; p13 = temp; }
			if (comparisonPointer(p5, p14) < 0) { temp = p5; p5 = p14; p14 = temp; }
			if (comparisonPointer(p5, p13) < 0) { temp = p5; p5 = p13; p13 = temp; }
			if (comparisonPointer(p6, p21) < 0) { temp = p6; p6 = p21; p21 = temp; }
			if (comparisonPointer(p6, p20) < 0) { temp = p6; p6 = p20; p20 = temp; }
			if (comparisonPointer(p7, p22) < 0) { temp = p7; p7 = p22; p22 = temp; }
			if (comparisonPointer(p8, p22) < 0) { temp = p8; p8 = p22; p22 = temp; }
			if (comparisonPointer(p7, p20) < 0) { temp = p7; p7 = p20; p20 = temp; }
			if (comparisonPointer(p8, p21) < 0) { temp = p8; p8 = p21; p21 = temp; }
			if (comparisonPointer(p8, p20) < 0) { temp = p8; p8 = p20; p20 = temp; }
			if (comparisonPointer(p9, p23) < 0) { temp = p9; p9 = p23; p23 = temp; }
			if (comparisonPointer(p10, p24) < 0) { temp = p10; p10 = p24; p24 = temp; }
			if (comparisonPointer(p10, p23) < 0) { temp = p10; p10 = p23; p23 = temp; }
			if (comparisonPointer(p11, p25) < 0) { temp = p11; p11 = p25; p25 = temp; }
			if (comparisonPointer(p12, p25) < 0) { temp = p12; p12 = p25; p25 = temp; }
			if (comparisonPointer(p11, p23) < 0) { temp = p11; p11 = p23; p23 = temp; }
			if (comparisonPointer(p12, p24) < 0) { temp = p12; p12 = p24; p24 = temp; }
			if (comparisonPointer(p12, p23) < 0) { temp = p12; p12 = p23; p23 = temp; }
			if (comparisonPointer(p9, p20) < 0) { temp = p9; p9 = p20; p20 = temp; }
			if (comparisonPointer(p10, p21) < 0) { temp = p10; p10 = p21; p21 = temp; }
			if (comparisonPointer(p10, p20) < 0) { temp = p10; p10 = p20; p20 = temp; }
			if (comparisonPointer(p11, p22) < 0) { temp = p11; p11 = p22; p22 = temp; }
			if (comparisonPointer(p12, p22) < 0) { temp = p12; p12 = p22; p22 = temp; }
			if (comparisonPointer(p11, p20) < 0) { temp = p11; p11 = p20; p20 = temp; }
			if (comparisonPointer(p12, p21) < 0) { temp = p12; p12 = p21; p21 = temp; }
			if (comparisonPointer(p12, p20) < 0) { temp = p12; p12 = p20; p20 = temp; }
			if (comparisonPointer(p6, p14) < 0) { temp = p6; p6 = p14; p14 = temp; }
			if (comparisonPointer(p6, p13) < 0) { temp = p6; p6 = p13; p13 = temp; }
			if (comparisonPointer(p7, p15) < 0) { temp = p7; p7 = p15; p15 = temp; }
			if (comparisonPointer(p8, p16) < 0) { temp = p8; p8 = p16; p16 = temp; }
			if (comparisonPointer(p8, p15) < 0) { temp = p8; p8 = p15; p15 = temp; }
			if (comparisonPointer(p7, p13) < 0) { temp = p7; p7 = p13; p13 = temp; }
			if (comparisonPointer(p8, p14) < 0) { temp = p8; p8 = p14; p14 = temp; }
			if (comparisonPointer(p8, p13) < 0) { temp = p8; p8 = p13; p13 = temp; }
			if (comparisonPointer(p9, p17) < 0) { temp = p9; p9 = p17; p17 = temp; }
			if (comparisonPointer(p10, p18) < 0) { temp = p10; p10 = p18; p18 = temp; }
			if (comparisonPointer(p10, p17) < 0) { temp = p10; p10 = p17; p17 = temp; }
			if (comparisonPointer(p11, p19) < 0) { temp = p11; p11 = p19; p19 = temp; }
			if (comparisonPointer(p12, p19) < 0) { temp = p12; p12 = p19; p19 = temp; }
			if (comparisonPointer(p11, p17) < 0) { temp = p11; p11 = p17; p17 = temp; }
			if (comparisonPointer(p12, p18) < 0) { temp = p12; p12 = p18; p18 = temp; }
			if (comparisonPointer(p12, p17) < 0) { temp = p12; p12 = p17; p17 = temp; }
			if (comparisonPointer(p9, p13) < 0) { temp = p9; p9 = p13; p13 = temp; }
			if (comparisonPointer(p10, p14) < 0) { temp = p10; p10 = p14; p14 = temp; }
			if (comparisonPointer(p10, p13) < 0) { temp = p10; p10 = p13; p13 = temp; }
			if (comparisonPointer(p11, p15) < 0) { temp = p11; p11 = p15; p15 = temp; }
			if (comparisonPointer(p12, p16) < 0) { temp = p12; p12 = p16; p16 = temp; }
			if (comparisonPointer(p12, p15) < 0) { temp = p12; p12 = p15; p15 = temp; }
			if (comparisonPointer(p11, p13) < 0) { temp = p11; p11 = p13; p13 = temp; }
			if (comparisonPointer(p12, p14) < 0) { temp = p12; p12 = p14; p14 = temp; }
			if (comparisonPointer(p12, p13) < 0) { temp = p12; p12 = p13; p13 = temp; }
		}

		/// <summary>
		/// Sorts a collection of 27 elements in descending order using the specified function pointer.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparisonPointer">The function pointer to use when comparing elements.</param>
		public unsafe static void Sort27Descending<T>(ref T p0, delegate* managed<T, T, int> comparisonPointer)
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
			ref var p16 = ref Unsafe.Add(ref p0, 16);
			ref var p17 = ref Unsafe.Add(ref p0, 17);
			ref var p18 = ref Unsafe.Add(ref p0, 18);
			ref var p19 = ref Unsafe.Add(ref p0, 19);
			ref var p20 = ref Unsafe.Add(ref p0, 20);
			ref var p21 = ref Unsafe.Add(ref p0, 21);
			ref var p22 = ref Unsafe.Add(ref p0, 22);
			ref var p23 = ref Unsafe.Add(ref p0, 23);
			ref var p24 = ref Unsafe.Add(ref p0, 24);
			ref var p25 = ref Unsafe.Add(ref p0, 25);
			ref var p26 = ref Unsafe.Add(ref p0, 26);

			T temp;
			if (comparisonPointer(p1, p2) < 0) { temp = p1; p1 = p2; p2 = temp; }
			if (comparisonPointer(p0, p2) < 0) { temp = p0; p0 = p2; p2 = temp; }
			if (comparisonPointer(p0, p1) < 0) { temp = p0; p0 = p1; p1 = temp; }
			if (comparisonPointer(p4, p5) < 0) { temp = p4; p4 = p5; p5 = temp; }
			if (comparisonPointer(p3, p5) < 0) { temp = p3; p3 = p5; p5 = temp; }
			if (comparisonPointer(p3, p4) < 0) { temp = p3; p3 = p4; p4 = temp; }
			if (comparisonPointer(p0, p4) < 0) { temp = p0; p0 = p4; p4 = temp; }
			if (comparisonPointer(p0, p3) < 0) { temp = p0; p0 = p3; p3 = temp; }
			if (comparisonPointer(p1, p5) < 0) { temp = p1; p1 = p5; p5 = temp; }
			if (comparisonPointer(p2, p5) < 0) { temp = p2; p2 = p5; p5 = temp; }
			if (comparisonPointer(p1, p3) < 0) { temp = p1; p1 = p3; p3 = temp; }
			if (comparisonPointer(p2, p4) < 0) { temp = p2; p2 = p4; p4 = temp; }
			if (comparisonPointer(p2, p3) < 0) { temp = p2; p2 = p3; p3 = temp; }
			if (comparisonPointer(p7, p8) < 0) { temp = p7; p7 = p8; p8 = temp; }
			if (comparisonPointer(p6, p8) < 0) { temp = p6; p6 = p8; p8 = temp; }
			if (comparisonPointer(p6, p7) < 0) { temp = p6; p6 = p7; p7 = temp; }
			if (comparisonPointer(p9, p10) < 0) { temp = p9; p9 = p10; p10 = temp; }
			if (comparisonPointer(p11, p12) < 0) { temp = p11; p11 = p12; p12 = temp; }
			if (comparisonPointer(p9, p11) < 0) { temp = p9; p9 = p11; p11 = temp; }
			if (comparisonPointer(p10, p12) < 0) { temp = p10; p10 = p12; p12 = temp; }
			if (comparisonPointer(p10, p11) < 0) { temp = p10; p10 = p11; p11 = temp; }
			if (comparisonPointer(p6, p10) < 0) { temp = p6; p6 = p10; p10 = temp; }
			if (comparisonPointer(p6, p9) < 0) { temp = p6; p6 = p9; p9 = temp; }
			if (comparisonPointer(p7, p11) < 0) { temp = p7; p7 = p11; p11 = temp; }
			if (comparisonPointer(p8, p12) < 0) { temp = p8; p8 = p12; p12 = temp; }
			if (comparisonPointer(p8, p11) < 0) { temp = p8; p8 = p11; p11 = temp; }
			if (comparisonPointer(p7, p9) < 0) { temp = p7; p7 = p9; p9 = temp; }
			if (comparisonPointer(p8, p10) < 0) { temp = p8; p8 = p10; p10 = temp; }
			if (comparisonPointer(p8, p9) < 0) { temp = p8; p8 = p9; p9 = temp; }
			if (comparisonPointer(p0, p7) < 0) { temp = p0; p0 = p7; p7 = temp; }
			if (comparisonPointer(p0, p6) < 0) { temp = p0; p0 = p6; p6 = temp; }
			if (comparisonPointer(p1, p8) < 0) { temp = p1; p1 = p8; p8 = temp; }
			if (comparisonPointer(p2, p9) < 0) { temp = p2; p2 = p9; p9 = temp; }
			if (comparisonPointer(p2, p8) < 0) { temp = p2; p2 = p8; p8 = temp; }
			if (comparisonPointer(p1, p6) < 0) { temp = p1; p1 = p6; p6 = temp; }
			if (comparisonPointer(p2, p7) < 0) { temp = p2; p2 = p7; p7 = temp; }
			if (comparisonPointer(p2, p6) < 0) { temp = p2; p2 = p6; p6 = temp; }
			if (comparisonPointer(p3, p11) < 0) { temp = p3; p3 = p11; p11 = temp; }
			if (comparisonPointer(p3, p10) < 0) { temp = p3; p3 = p10; p10 = temp; }
			if (comparisonPointer(p4, p12) < 0) { temp = p4; p4 = p12; p12 = temp; }
			if (comparisonPointer(p5, p12) < 0) { temp = p5; p5 = p12; p12 = temp; }
			if (comparisonPointer(p4, p10) < 0) { temp = p4; p4 = p10; p10 = temp; }
			if (comparisonPointer(p5, p11) < 0) { temp = p5; p5 = p11; p11 = temp; }
			if (comparisonPointer(p5, p10) < 0) { temp = p5; p5 = p10; p10 = temp; }
			if (comparisonPointer(p3, p7) < 0) { temp = p3; p3 = p7; p7 = temp; }
			if (comparisonPointer(p3, p6) < 0) { temp = p3; p3 = p6; p6 = temp; }
			if (comparisonPointer(p4, p8) < 0) { temp = p4; p4 = p8; p8 = temp; }
			if (comparisonPointer(p5, p9) < 0) { temp = p5; p5 = p9; p9 = temp; }
			if (comparisonPointer(p5, p8) < 0) { temp = p5; p5 = p8; p8 = temp; }
			if (comparisonPointer(p4, p6) < 0) { temp = p4; p4 = p6; p6 = temp; }
			if (comparisonPointer(p5, p7) < 0) { temp = p5; p5 = p7; p7 = temp; }
			if (comparisonPointer(p5, p6) < 0) { temp = p5; p5 = p6; p6 = temp; }
			if (comparisonPointer(p14, p15) < 0) { temp = p14; p14 = p15; p15 = temp; }
			if (comparisonPointer(p13, p15) < 0) { temp = p13; p13 = p15; p15 = temp; }
			if (comparisonPointer(p13, p14) < 0) { temp = p13; p13 = p14; p14 = temp; }
			if (comparisonPointer(p16, p17) < 0) { temp = p16; p16 = p17; p17 = temp; }
			if (comparisonPointer(p18, p19) < 0) { temp = p18; p18 = p19; p19 = temp; }
			if (comparisonPointer(p16, p18) < 0) { temp = p16; p16 = p18; p18 = temp; }
			if (comparisonPointer(p17, p19) < 0) { temp = p17; p17 = p19; p19 = temp; }
			if (comparisonPointer(p17, p18) < 0) { temp = p17; p17 = p18; p18 = temp; }
			if (comparisonPointer(p13, p17) < 0) { temp = p13; p13 = p17; p17 = temp; }
			if (comparisonPointer(p13, p16) < 0) { temp = p13; p13 = p16; p16 = temp; }
			if (comparisonPointer(p14, p18) < 0) { temp = p14; p14 = p18; p18 = temp; }
			if (comparisonPointer(p15, p19) < 0) { temp = p15; p15 = p19; p19 = temp; }
			if (comparisonPointer(p15, p18) < 0) { temp = p15; p15 = p18; p18 = temp; }
			if (comparisonPointer(p14, p16) < 0) { temp = p14; p14 = p16; p16 = temp; }
			if (comparisonPointer(p15, p17) < 0) { temp = p15; p15 = p17; p17 = temp; }
			if (comparisonPointer(p15, p16) < 0) { temp = p15; p15 = p16; p16 = temp; }
			if (comparisonPointer(p21, p22) < 0) { temp = p21; p21 = p22; p22 = temp; }
			if (comparisonPointer(p20, p22) < 0) { temp = p20; p20 = p22; p22 = temp; }
			if (comparisonPointer(p20, p21) < 0) { temp = p20; p20 = p21; p21 = temp; }
			if (comparisonPointer(p23, p24) < 0) { temp = p23; p23 = p24; p24 = temp; }
			if (comparisonPointer(p25, p26) < 0) { temp = p25; p25 = p26; p26 = temp; }
			if (comparisonPointer(p23, p25) < 0) { temp = p23; p23 = p25; p25 = temp; }
			if (comparisonPointer(p24, p26) < 0) { temp = p24; p24 = p26; p26 = temp; }
			if (comparisonPointer(p24, p25) < 0) { temp = p24; p24 = p25; p25 = temp; }
			if (comparisonPointer(p20, p24) < 0) { temp = p20; p20 = p24; p24 = temp; }
			if (comparisonPointer(p20, p23) < 0) { temp = p20; p20 = p23; p23 = temp; }
			if (comparisonPointer(p21, p25) < 0) { temp = p21; p21 = p25; p25 = temp; }
			if (comparisonPointer(p22, p26) < 0) { temp = p22; p22 = p26; p26 = temp; }
			if (comparisonPointer(p22, p25) < 0) { temp = p22; p22 = p25; p25 = temp; }
			if (comparisonPointer(p21, p23) < 0) { temp = p21; p21 = p23; p23 = temp; }
			if (comparisonPointer(p22, p24) < 0) { temp = p22; p22 = p24; p24 = temp; }
			if (comparisonPointer(p22, p23) < 0) { temp = p22; p22 = p23; p23 = temp; }
			if (comparisonPointer(p13, p21) < 0) { temp = p13; p13 = p21; p21 = temp; }
			if (comparisonPointer(p13, p20) < 0) { temp = p13; p13 = p20; p20 = temp; }
			if (comparisonPointer(p14, p22) < 0) { temp = p14; p14 = p22; p22 = temp; }
			if (comparisonPointer(p15, p23) < 0) { temp = p15; p15 = p23; p23 = temp; }
			if (comparisonPointer(p15, p22) < 0) { temp = p15; p15 = p22; p22 = temp; }
			if (comparisonPointer(p14, p20) < 0) { temp = p14; p14 = p20; p20 = temp; }
			if (comparisonPointer(p15, p21) < 0) { temp = p15; p15 = p21; p21 = temp; }
			if (comparisonPointer(p15, p20) < 0) { temp = p15; p15 = p20; p20 = temp; }
			if (comparisonPointer(p16, p24) < 0) { temp = p16; p16 = p24; p24 = temp; }
			if (comparisonPointer(p17, p25) < 0) { temp = p17; p17 = p25; p25 = temp; }
			if (comparisonPointer(p17, p24) < 0) { temp = p17; p17 = p24; p24 = temp; }
			if (comparisonPointer(p18, p26) < 0) { temp = p18; p18 = p26; p26 = temp; }
			if (comparisonPointer(p19, p26) < 0) { temp = p19; p19 = p26; p26 = temp; }
			if (comparisonPointer(p18, p24) < 0) { temp = p18; p18 = p24; p24 = temp; }
			if (comparisonPointer(p19, p25) < 0) { temp = p19; p19 = p25; p25 = temp; }
			if (comparisonPointer(p19, p24) < 0) { temp = p19; p19 = p24; p24 = temp; }
			if (comparisonPointer(p16, p20) < 0) { temp = p16; p16 = p20; p20 = temp; }
			if (comparisonPointer(p17, p21) < 0) { temp = p17; p17 = p21; p21 = temp; }
			if (comparisonPointer(p17, p20) < 0) { temp = p17; p17 = p20; p20 = temp; }
			if (comparisonPointer(p18, p22) < 0) { temp = p18; p18 = p22; p22 = temp; }
			if (comparisonPointer(p19, p23) < 0) { temp = p19; p19 = p23; p23 = temp; }
			if (comparisonPointer(p19, p22) < 0) { temp = p19; p19 = p22; p22 = temp; }
			if (comparisonPointer(p18, p20) < 0) { temp = p18; p18 = p20; p20 = temp; }
			if (comparisonPointer(p19, p21) < 0) { temp = p19; p19 = p21; p21 = temp; }
			if (comparisonPointer(p19, p20) < 0) { temp = p19; p19 = p20; p20 = temp; }
			if (comparisonPointer(p0, p14) < 0) { temp = p0; p0 = p14; p14 = temp; }
			if (comparisonPointer(p0, p13) < 0) { temp = p0; p0 = p13; p13 = temp; }
			if (comparisonPointer(p1, p15) < 0) { temp = p1; p1 = p15; p15 = temp; }
			if (comparisonPointer(p2, p16) < 0) { temp = p2; p2 = p16; p16 = temp; }
			if (comparisonPointer(p2, p15) < 0) { temp = p2; p2 = p15; p15 = temp; }
			if (comparisonPointer(p1, p13) < 0) { temp = p1; p1 = p13; p13 = temp; }
			if (comparisonPointer(p2, p14) < 0) { temp = p2; p2 = p14; p14 = temp; }
			if (comparisonPointer(p2, p13) < 0) { temp = p2; p2 = p13; p13 = temp; }
			if (comparisonPointer(p3, p18) < 0) { temp = p3; p3 = p18; p18 = temp; }
			if (comparisonPointer(p3, p17) < 0) { temp = p3; p3 = p17; p17 = temp; }
			if (comparisonPointer(p4, p19) < 0) { temp = p4; p4 = p19; p19 = temp; }
			if (comparisonPointer(p5, p19) < 0) { temp = p5; p5 = p19; p19 = temp; }
			if (comparisonPointer(p4, p17) < 0) { temp = p4; p4 = p17; p17 = temp; }
			if (comparisonPointer(p5, p18) < 0) { temp = p5; p5 = p18; p18 = temp; }
			if (comparisonPointer(p5, p17) < 0) { temp = p5; p5 = p17; p17 = temp; }
			if (comparisonPointer(p3, p14) < 0) { temp = p3; p3 = p14; p14 = temp; }
			if (comparisonPointer(p3, p13) < 0) { temp = p3; p3 = p13; p13 = temp; }
			if (comparisonPointer(p4, p15) < 0) { temp = p4; p4 = p15; p15 = temp; }
			if (comparisonPointer(p5, p16) < 0) { temp = p5; p5 = p16; p16 = temp; }
			if (comparisonPointer(p5, p15) < 0) { temp = p5; p5 = p15; p15 = temp; }
			if (comparisonPointer(p4, p13) < 0) { temp = p4; p4 = p13; p13 = temp; }
			if (comparisonPointer(p5, p14) < 0) { temp = p5; p5 = p14; p14 = temp; }
			if (comparisonPointer(p5, p13) < 0) { temp = p5; p5 = p13; p13 = temp; }
			if (comparisonPointer(p6, p21) < 0) { temp = p6; p6 = p21; p21 = temp; }
			if (comparisonPointer(p6, p20) < 0) { temp = p6; p6 = p20; p20 = temp; }
			if (comparisonPointer(p7, p22) < 0) { temp = p7; p7 = p22; p22 = temp; }
			if (comparisonPointer(p8, p23) < 0) { temp = p8; p8 = p23; p23 = temp; }
			if (comparisonPointer(p8, p22) < 0) { temp = p8; p8 = p22; p22 = temp; }
			if (comparisonPointer(p7, p20) < 0) { temp = p7; p7 = p20; p20 = temp; }
			if (comparisonPointer(p8, p21) < 0) { temp = p8; p8 = p21; p21 = temp; }
			if (comparisonPointer(p8, p20) < 0) { temp = p8; p8 = p20; p20 = temp; }
			if (comparisonPointer(p9, p24) < 0) { temp = p9; p9 = p24; p24 = temp; }
			if (comparisonPointer(p10, p25) < 0) { temp = p10; p10 = p25; p25 = temp; }
			if (comparisonPointer(p10, p24) < 0) { temp = p10; p10 = p24; p24 = temp; }
			if (comparisonPointer(p11, p26) < 0) { temp = p11; p11 = p26; p26 = temp; }
			if (comparisonPointer(p12, p26) < 0) { temp = p12; p12 = p26; p26 = temp; }
			if (comparisonPointer(p11, p24) < 0) { temp = p11; p11 = p24; p24 = temp; }
			if (comparisonPointer(p12, p25) < 0) { temp = p12; p12 = p25; p25 = temp; }
			if (comparisonPointer(p12, p24) < 0) { temp = p12; p12 = p24; p24 = temp; }
			if (comparisonPointer(p9, p20) < 0) { temp = p9; p9 = p20; p20 = temp; }
			if (comparisonPointer(p10, p21) < 0) { temp = p10; p10 = p21; p21 = temp; }
			if (comparisonPointer(p10, p20) < 0) { temp = p10; p10 = p20; p20 = temp; }
			if (comparisonPointer(p11, p22) < 0) { temp = p11; p11 = p22; p22 = temp; }
			if (comparisonPointer(p12, p23) < 0) { temp = p12; p12 = p23; p23 = temp; }
			if (comparisonPointer(p12, p22) < 0) { temp = p12; p12 = p22; p22 = temp; }
			if (comparisonPointer(p11, p20) < 0) { temp = p11; p11 = p20; p20 = temp; }
			if (comparisonPointer(p12, p21) < 0) { temp = p12; p12 = p21; p21 = temp; }
			if (comparisonPointer(p12, p20) < 0) { temp = p12; p12 = p20; p20 = temp; }
			if (comparisonPointer(p6, p14) < 0) { temp = p6; p6 = p14; p14 = temp; }
			if (comparisonPointer(p6, p13) < 0) { temp = p6; p6 = p13; p13 = temp; }
			if (comparisonPointer(p7, p15) < 0) { temp = p7; p7 = p15; p15 = temp; }
			if (comparisonPointer(p8, p16) < 0) { temp = p8; p8 = p16; p16 = temp; }
			if (comparisonPointer(p8, p15) < 0) { temp = p8; p8 = p15; p15 = temp; }
			if (comparisonPointer(p7, p13) < 0) { temp = p7; p7 = p13; p13 = temp; }
			if (comparisonPointer(p8, p14) < 0) { temp = p8; p8 = p14; p14 = temp; }
			if (comparisonPointer(p8, p13) < 0) { temp = p8; p8 = p13; p13 = temp; }
			if (comparisonPointer(p9, p17) < 0) { temp = p9; p9 = p17; p17 = temp; }
			if (comparisonPointer(p10, p18) < 0) { temp = p10; p10 = p18; p18 = temp; }
			if (comparisonPointer(p10, p17) < 0) { temp = p10; p10 = p17; p17 = temp; }
			if (comparisonPointer(p11, p19) < 0) { temp = p11; p11 = p19; p19 = temp; }
			if (comparisonPointer(p12, p19) < 0) { temp = p12; p12 = p19; p19 = temp; }
			if (comparisonPointer(p11, p17) < 0) { temp = p11; p11 = p17; p17 = temp; }
			if (comparisonPointer(p12, p18) < 0) { temp = p12; p12 = p18; p18 = temp; }
			if (comparisonPointer(p12, p17) < 0) { temp = p12; p12 = p17; p17 = temp; }
			if (comparisonPointer(p9, p13) < 0) { temp = p9; p9 = p13; p13 = temp; }
			if (comparisonPointer(p10, p14) < 0) { temp = p10; p10 = p14; p14 = temp; }
			if (comparisonPointer(p10, p13) < 0) { temp = p10; p10 = p13; p13 = temp; }
			if (comparisonPointer(p11, p15) < 0) { temp = p11; p11 = p15; p15 = temp; }
			if (comparisonPointer(p12, p16) < 0) { temp = p12; p12 = p16; p16 = temp; }
			if (comparisonPointer(p12, p15) < 0) { temp = p12; p12 = p15; p15 = temp; }
			if (comparisonPointer(p11, p13) < 0) { temp = p11; p11 = p13; p13 = temp; }
			if (comparisonPointer(p12, p14) < 0) { temp = p12; p12 = p14; p14 = temp; }
			if (comparisonPointer(p12, p13) < 0) { temp = p12; p12 = p13; p13 = temp; }
		}

		/// <summary>
		/// Sorts a collection of 28 elements in descending order using the specified function pointer.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparisonPointer">The function pointer to use when comparing elements.</param>
		public unsafe static void Sort28Descending<T>(ref T p0, delegate* managed<T, T, int> comparisonPointer)
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
			ref var p16 = ref Unsafe.Add(ref p0, 16);
			ref var p17 = ref Unsafe.Add(ref p0, 17);
			ref var p18 = ref Unsafe.Add(ref p0, 18);
			ref var p19 = ref Unsafe.Add(ref p0, 19);
			ref var p20 = ref Unsafe.Add(ref p0, 20);
			ref var p21 = ref Unsafe.Add(ref p0, 21);
			ref var p22 = ref Unsafe.Add(ref p0, 22);
			ref var p23 = ref Unsafe.Add(ref p0, 23);
			ref var p24 = ref Unsafe.Add(ref p0, 24);
			ref var p25 = ref Unsafe.Add(ref p0, 25);
			ref var p26 = ref Unsafe.Add(ref p0, 26);
			ref var p27 = ref Unsafe.Add(ref p0, 27);

			T temp;
			if (comparisonPointer(p1, p2) < 0) { temp = p1; p1 = p2; p2 = temp; }
			if (comparisonPointer(p0, p2) < 0) { temp = p0; p0 = p2; p2 = temp; }
			if (comparisonPointer(p0, p1) < 0) { temp = p0; p0 = p1; p1 = temp; }
			if (comparisonPointer(p3, p4) < 0) { temp = p3; p3 = p4; p4 = temp; }
			if (comparisonPointer(p5, p6) < 0) { temp = p5; p5 = p6; p6 = temp; }
			if (comparisonPointer(p3, p5) < 0) { temp = p3; p3 = p5; p5 = temp; }
			if (comparisonPointer(p4, p6) < 0) { temp = p4; p4 = p6; p6 = temp; }
			if (comparisonPointer(p4, p5) < 0) { temp = p4; p4 = p5; p5 = temp; }
			if (comparisonPointer(p0, p4) < 0) { temp = p0; p0 = p4; p4 = temp; }
			if (comparisonPointer(p0, p3) < 0) { temp = p0; p0 = p3; p3 = temp; }
			if (comparisonPointer(p1, p5) < 0) { temp = p1; p1 = p5; p5 = temp; }
			if (comparisonPointer(p2, p6) < 0) { temp = p2; p2 = p6; p6 = temp; }
			if (comparisonPointer(p2, p5) < 0) { temp = p2; p2 = p5; p5 = temp; }
			if (comparisonPointer(p1, p3) < 0) { temp = p1; p1 = p3; p3 = temp; }
			if (comparisonPointer(p2, p4) < 0) { temp = p2; p2 = p4; p4 = temp; }
			if (comparisonPointer(p2, p3) < 0) { temp = p2; p2 = p3; p3 = temp; }
			if (comparisonPointer(p8, p9) < 0) { temp = p8; p8 = p9; p9 = temp; }
			if (comparisonPointer(p7, p9) < 0) { temp = p7; p7 = p9; p9 = temp; }
			if (comparisonPointer(p7, p8) < 0) { temp = p7; p7 = p8; p8 = temp; }
			if (comparisonPointer(p10, p11) < 0) { temp = p10; p10 = p11; p11 = temp; }
			if (comparisonPointer(p12, p13) < 0) { temp = p12; p12 = p13; p13 = temp; }
			if (comparisonPointer(p10, p12) < 0) { temp = p10; p10 = p12; p12 = temp; }
			if (comparisonPointer(p11, p13) < 0) { temp = p11; p11 = p13; p13 = temp; }
			if (comparisonPointer(p11, p12) < 0) { temp = p11; p11 = p12; p12 = temp; }
			if (comparisonPointer(p7, p11) < 0) { temp = p7; p7 = p11; p11 = temp; }
			if (comparisonPointer(p7, p10) < 0) { temp = p7; p7 = p10; p10 = temp; }
			if (comparisonPointer(p8, p12) < 0) { temp = p8; p8 = p12; p12 = temp; }
			if (comparisonPointer(p9, p13) < 0) { temp = p9; p9 = p13; p13 = temp; }
			if (comparisonPointer(p9, p12) < 0) { temp = p9; p9 = p12; p12 = temp; }
			if (comparisonPointer(p8, p10) < 0) { temp = p8; p8 = p10; p10 = temp; }
			if (comparisonPointer(p9, p11) < 0) { temp = p9; p9 = p11; p11 = temp; }
			if (comparisonPointer(p9, p10) < 0) { temp = p9; p9 = p10; p10 = temp; }
			if (comparisonPointer(p0, p8) < 0) { temp = p0; p0 = p8; p8 = temp; }
			if (comparisonPointer(p0, p7) < 0) { temp = p0; p0 = p7; p7 = temp; }
			if (comparisonPointer(p1, p9) < 0) { temp = p1; p1 = p9; p9 = temp; }
			if (comparisonPointer(p2, p10) < 0) { temp = p2; p2 = p10; p10 = temp; }
			if (comparisonPointer(p2, p9) < 0) { temp = p2; p2 = p9; p9 = temp; }
			if (comparisonPointer(p1, p7) < 0) { temp = p1; p1 = p7; p7 = temp; }
			if (comparisonPointer(p2, p8) < 0) { temp = p2; p2 = p8; p8 = temp; }
			if (comparisonPointer(p2, p7) < 0) { temp = p2; p2 = p7; p7 = temp; }
			if (comparisonPointer(p3, p11) < 0) { temp = p3; p3 = p11; p11 = temp; }
			if (comparisonPointer(p4, p12) < 0) { temp = p4; p4 = p12; p12 = temp; }
			if (comparisonPointer(p4, p11) < 0) { temp = p4; p4 = p11; p11 = temp; }
			if (comparisonPointer(p5, p13) < 0) { temp = p5; p5 = p13; p13 = temp; }
			if (comparisonPointer(p6, p13) < 0) { temp = p6; p6 = p13; p13 = temp; }
			if (comparisonPointer(p5, p11) < 0) { temp = p5; p5 = p11; p11 = temp; }
			if (comparisonPointer(p6, p12) < 0) { temp = p6; p6 = p12; p12 = temp; }
			if (comparisonPointer(p6, p11) < 0) { temp = p6; p6 = p11; p11 = temp; }
			if (comparisonPointer(p3, p7) < 0) { temp = p3; p3 = p7; p7 = temp; }
			if (comparisonPointer(p4, p8) < 0) { temp = p4; p4 = p8; p8 = temp; }
			if (comparisonPointer(p4, p7) < 0) { temp = p4; p4 = p7; p7 = temp; }
			if (comparisonPointer(p5, p9) < 0) { temp = p5; p5 = p9; p9 = temp; }
			if (comparisonPointer(p6, p10) < 0) { temp = p6; p6 = p10; p10 = temp; }
			if (comparisonPointer(p6, p9) < 0) { temp = p6; p6 = p9; p9 = temp; }
			if (comparisonPointer(p5, p7) < 0) { temp = p5; p5 = p7; p7 = temp; }
			if (comparisonPointer(p6, p8) < 0) { temp = p6; p6 = p8; p8 = temp; }
			if (comparisonPointer(p6, p7) < 0) { temp = p6; p6 = p7; p7 = temp; }
			if (comparisonPointer(p15, p16) < 0) { temp = p15; p15 = p16; p16 = temp; }
			if (comparisonPointer(p14, p16) < 0) { temp = p14; p14 = p16; p16 = temp; }
			if (comparisonPointer(p14, p15) < 0) { temp = p14; p14 = p15; p15 = temp; }
			if (comparisonPointer(p17, p18) < 0) { temp = p17; p17 = p18; p18 = temp; }
			if (comparisonPointer(p19, p20) < 0) { temp = p19; p19 = p20; p20 = temp; }
			if (comparisonPointer(p17, p19) < 0) { temp = p17; p17 = p19; p19 = temp; }
			if (comparisonPointer(p18, p20) < 0) { temp = p18; p18 = p20; p20 = temp; }
			if (comparisonPointer(p18, p19) < 0) { temp = p18; p18 = p19; p19 = temp; }
			if (comparisonPointer(p14, p18) < 0) { temp = p14; p14 = p18; p18 = temp; }
			if (comparisonPointer(p14, p17) < 0) { temp = p14; p14 = p17; p17 = temp; }
			if (comparisonPointer(p15, p19) < 0) { temp = p15; p15 = p19; p19 = temp; }
			if (comparisonPointer(p16, p20) < 0) { temp = p16; p16 = p20; p20 = temp; }
			if (comparisonPointer(p16, p19) < 0) { temp = p16; p16 = p19; p19 = temp; }
			if (comparisonPointer(p15, p17) < 0) { temp = p15; p15 = p17; p17 = temp; }
			if (comparisonPointer(p16, p18) < 0) { temp = p16; p16 = p18; p18 = temp; }
			if (comparisonPointer(p16, p17) < 0) { temp = p16; p16 = p17; p17 = temp; }
			if (comparisonPointer(p22, p23) < 0) { temp = p22; p22 = p23; p23 = temp; }
			if (comparisonPointer(p21, p23) < 0) { temp = p21; p21 = p23; p23 = temp; }
			if (comparisonPointer(p21, p22) < 0) { temp = p21; p21 = p22; p22 = temp; }
			if (comparisonPointer(p24, p25) < 0) { temp = p24; p24 = p25; p25 = temp; }
			if (comparisonPointer(p26, p27) < 0) { temp = p26; p26 = p27; p27 = temp; }
			if (comparisonPointer(p24, p26) < 0) { temp = p24; p24 = p26; p26 = temp; }
			if (comparisonPointer(p25, p27) < 0) { temp = p25; p25 = p27; p27 = temp; }
			if (comparisonPointer(p25, p26) < 0) { temp = p25; p25 = p26; p26 = temp; }
			if (comparisonPointer(p21, p25) < 0) { temp = p21; p21 = p25; p25 = temp; }
			if (comparisonPointer(p21, p24) < 0) { temp = p21; p21 = p24; p24 = temp; }
			if (comparisonPointer(p22, p26) < 0) { temp = p22; p22 = p26; p26 = temp; }
			if (comparisonPointer(p23, p27) < 0) { temp = p23; p23 = p27; p27 = temp; }
			if (comparisonPointer(p23, p26) < 0) { temp = p23; p23 = p26; p26 = temp; }
			if (comparisonPointer(p22, p24) < 0) { temp = p22; p22 = p24; p24 = temp; }
			if (comparisonPointer(p23, p25) < 0) { temp = p23; p23 = p25; p25 = temp; }
			if (comparisonPointer(p23, p24) < 0) { temp = p23; p23 = p24; p24 = temp; }
			if (comparisonPointer(p14, p22) < 0) { temp = p14; p14 = p22; p22 = temp; }
			if (comparisonPointer(p14, p21) < 0) { temp = p14; p14 = p21; p21 = temp; }
			if (comparisonPointer(p15, p23) < 0) { temp = p15; p15 = p23; p23 = temp; }
			if (comparisonPointer(p16, p24) < 0) { temp = p16; p16 = p24; p24 = temp; }
			if (comparisonPointer(p16, p23) < 0) { temp = p16; p16 = p23; p23 = temp; }
			if (comparisonPointer(p15, p21) < 0) { temp = p15; p15 = p21; p21 = temp; }
			if (comparisonPointer(p16, p22) < 0) { temp = p16; p16 = p22; p22 = temp; }
			if (comparisonPointer(p16, p21) < 0) { temp = p16; p16 = p21; p21 = temp; }
			if (comparisonPointer(p17, p25) < 0) { temp = p17; p17 = p25; p25 = temp; }
			if (comparisonPointer(p18, p26) < 0) { temp = p18; p18 = p26; p26 = temp; }
			if (comparisonPointer(p18, p25) < 0) { temp = p18; p18 = p25; p25 = temp; }
			if (comparisonPointer(p19, p27) < 0) { temp = p19; p19 = p27; p27 = temp; }
			if (comparisonPointer(p20, p27) < 0) { temp = p20; p20 = p27; p27 = temp; }
			if (comparisonPointer(p19, p25) < 0) { temp = p19; p19 = p25; p25 = temp; }
			if (comparisonPointer(p20, p26) < 0) { temp = p20; p20 = p26; p26 = temp; }
			if (comparisonPointer(p20, p25) < 0) { temp = p20; p20 = p25; p25 = temp; }
			if (comparisonPointer(p17, p21) < 0) { temp = p17; p17 = p21; p21 = temp; }
			if (comparisonPointer(p18, p22) < 0) { temp = p18; p18 = p22; p22 = temp; }
			if (comparisonPointer(p18, p21) < 0) { temp = p18; p18 = p21; p21 = temp; }
			if (comparisonPointer(p19, p23) < 0) { temp = p19; p19 = p23; p23 = temp; }
			if (comparisonPointer(p20, p24) < 0) { temp = p20; p20 = p24; p24 = temp; }
			if (comparisonPointer(p20, p23) < 0) { temp = p20; p20 = p23; p23 = temp; }
			if (comparisonPointer(p19, p21) < 0) { temp = p19; p19 = p21; p21 = temp; }
			if (comparisonPointer(p20, p22) < 0) { temp = p20; p20 = p22; p22 = temp; }
			if (comparisonPointer(p20, p21) < 0) { temp = p20; p20 = p21; p21 = temp; }
			if (comparisonPointer(p0, p15) < 0) { temp = p0; p0 = p15; p15 = temp; }
			if (comparisonPointer(p0, p14) < 0) { temp = p0; p0 = p14; p14 = temp; }
			if (comparisonPointer(p1, p16) < 0) { temp = p1; p1 = p16; p16 = temp; }
			if (comparisonPointer(p2, p17) < 0) { temp = p2; p2 = p17; p17 = temp; }
			if (comparisonPointer(p2, p16) < 0) { temp = p2; p2 = p16; p16 = temp; }
			if (comparisonPointer(p1, p14) < 0) { temp = p1; p1 = p14; p14 = temp; }
			if (comparisonPointer(p2, p15) < 0) { temp = p2; p2 = p15; p15 = temp; }
			if (comparisonPointer(p2, p14) < 0) { temp = p2; p2 = p14; p14 = temp; }
			if (comparisonPointer(p3, p18) < 0) { temp = p3; p3 = p18; p18 = temp; }
			if (comparisonPointer(p4, p19) < 0) { temp = p4; p4 = p19; p19 = temp; }
			if (comparisonPointer(p4, p18) < 0) { temp = p4; p4 = p18; p18 = temp; }
			if (comparisonPointer(p5, p20) < 0) { temp = p5; p5 = p20; p20 = temp; }
			if (comparisonPointer(p6, p20) < 0) { temp = p6; p6 = p20; p20 = temp; }
			if (comparisonPointer(p5, p18) < 0) { temp = p5; p5 = p18; p18 = temp; }
			if (comparisonPointer(p6, p19) < 0) { temp = p6; p6 = p19; p19 = temp; }
			if (comparisonPointer(p6, p18) < 0) { temp = p6; p6 = p18; p18 = temp; }
			if (comparisonPointer(p3, p14) < 0) { temp = p3; p3 = p14; p14 = temp; }
			if (comparisonPointer(p4, p15) < 0) { temp = p4; p4 = p15; p15 = temp; }
			if (comparisonPointer(p4, p14) < 0) { temp = p4; p4 = p14; p14 = temp; }
			if (comparisonPointer(p5, p16) < 0) { temp = p5; p5 = p16; p16 = temp; }
			if (comparisonPointer(p6, p17) < 0) { temp = p6; p6 = p17; p17 = temp; }
			if (comparisonPointer(p6, p16) < 0) { temp = p6; p6 = p16; p16 = temp; }
			if (comparisonPointer(p5, p14) < 0) { temp = p5; p5 = p14; p14 = temp; }
			if (comparisonPointer(p6, p15) < 0) { temp = p6; p6 = p15; p15 = temp; }
			if (comparisonPointer(p6, p14) < 0) { temp = p6; p6 = p14; p14 = temp; }
			if (comparisonPointer(p7, p22) < 0) { temp = p7; p7 = p22; p22 = temp; }
			if (comparisonPointer(p7, p21) < 0) { temp = p7; p7 = p21; p21 = temp; }
			if (comparisonPointer(p8, p23) < 0) { temp = p8; p8 = p23; p23 = temp; }
			if (comparisonPointer(p9, p24) < 0) { temp = p9; p9 = p24; p24 = temp; }
			if (comparisonPointer(p9, p23) < 0) { temp = p9; p9 = p23; p23 = temp; }
			if (comparisonPointer(p8, p21) < 0) { temp = p8; p8 = p21; p21 = temp; }
			if (comparisonPointer(p9, p22) < 0) { temp = p9; p9 = p22; p22 = temp; }
			if (comparisonPointer(p9, p21) < 0) { temp = p9; p9 = p21; p21 = temp; }
			if (comparisonPointer(p10, p25) < 0) { temp = p10; p10 = p25; p25 = temp; }
			if (comparisonPointer(p11, p26) < 0) { temp = p11; p11 = p26; p26 = temp; }
			if (comparisonPointer(p11, p25) < 0) { temp = p11; p11 = p25; p25 = temp; }
			if (comparisonPointer(p12, p27) < 0) { temp = p12; p12 = p27; p27 = temp; }
			if (comparisonPointer(p13, p27) < 0) { temp = p13; p13 = p27; p27 = temp; }
			if (comparisonPointer(p12, p25) < 0) { temp = p12; p12 = p25; p25 = temp; }
			if (comparisonPointer(p13, p26) < 0) { temp = p13; p13 = p26; p26 = temp; }
			if (comparisonPointer(p13, p25) < 0) { temp = p13; p13 = p25; p25 = temp; }
			if (comparisonPointer(p10, p21) < 0) { temp = p10; p10 = p21; p21 = temp; }
			if (comparisonPointer(p11, p22) < 0) { temp = p11; p11 = p22; p22 = temp; }
			if (comparisonPointer(p11, p21) < 0) { temp = p11; p11 = p21; p21 = temp; }
			if (comparisonPointer(p12, p23) < 0) { temp = p12; p12 = p23; p23 = temp; }
			if (comparisonPointer(p13, p24) < 0) { temp = p13; p13 = p24; p24 = temp; }
			if (comparisonPointer(p13, p23) < 0) { temp = p13; p13 = p23; p23 = temp; }
			if (comparisonPointer(p12, p21) < 0) { temp = p12; p12 = p21; p21 = temp; }
			if (comparisonPointer(p13, p22) < 0) { temp = p13; p13 = p22; p22 = temp; }
			if (comparisonPointer(p13, p21) < 0) { temp = p13; p13 = p21; p21 = temp; }
			if (comparisonPointer(p7, p15) < 0) { temp = p7; p7 = p15; p15 = temp; }
			if (comparisonPointer(p7, p14) < 0) { temp = p7; p7 = p14; p14 = temp; }
			if (comparisonPointer(p8, p16) < 0) { temp = p8; p8 = p16; p16 = temp; }
			if (comparisonPointer(p9, p17) < 0) { temp = p9; p9 = p17; p17 = temp; }
			if (comparisonPointer(p9, p16) < 0) { temp = p9; p9 = p16; p16 = temp; }
			if (comparisonPointer(p8, p14) < 0) { temp = p8; p8 = p14; p14 = temp; }
			if (comparisonPointer(p9, p15) < 0) { temp = p9; p9 = p15; p15 = temp; }
			if (comparisonPointer(p9, p14) < 0) { temp = p9; p9 = p14; p14 = temp; }
			if (comparisonPointer(p10, p18) < 0) { temp = p10; p10 = p18; p18 = temp; }
			if (comparisonPointer(p11, p19) < 0) { temp = p11; p11 = p19; p19 = temp; }
			if (comparisonPointer(p11, p18) < 0) { temp = p11; p11 = p18; p18 = temp; }
			if (comparisonPointer(p12, p20) < 0) { temp = p12; p12 = p20; p20 = temp; }
			if (comparisonPointer(p13, p20) < 0) { temp = p13; p13 = p20; p20 = temp; }
			if (comparisonPointer(p12, p18) < 0) { temp = p12; p12 = p18; p18 = temp; }
			if (comparisonPointer(p13, p19) < 0) { temp = p13; p13 = p19; p19 = temp; }
			if (comparisonPointer(p13, p18) < 0) { temp = p13; p13 = p18; p18 = temp; }
			if (comparisonPointer(p10, p14) < 0) { temp = p10; p10 = p14; p14 = temp; }
			if (comparisonPointer(p11, p15) < 0) { temp = p11; p11 = p15; p15 = temp; }
			if (comparisonPointer(p11, p14) < 0) { temp = p11; p11 = p14; p14 = temp; }
			if (comparisonPointer(p12, p16) < 0) { temp = p12; p12 = p16; p16 = temp; }
			if (comparisonPointer(p13, p17) < 0) { temp = p13; p13 = p17; p17 = temp; }
			if (comparisonPointer(p13, p16) < 0) { temp = p13; p13 = p16; p16 = temp; }
			if (comparisonPointer(p12, p14) < 0) { temp = p12; p12 = p14; p14 = temp; }
			if (comparisonPointer(p13, p15) < 0) { temp = p13; p13 = p15; p15 = temp; }
			if (comparisonPointer(p13, p14) < 0) { temp = p13; p13 = p14; p14 = temp; }
		}

		/// <summary>
		/// Sorts a collection of 29 elements in descending order using the specified function pointer.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparisonPointer">The function pointer to use when comparing elements.</param>
		public unsafe static void Sort29Descending<T>(ref T p0, delegate* managed<T, T, int> comparisonPointer)
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
			ref var p16 = ref Unsafe.Add(ref p0, 16);
			ref var p17 = ref Unsafe.Add(ref p0, 17);
			ref var p18 = ref Unsafe.Add(ref p0, 18);
			ref var p19 = ref Unsafe.Add(ref p0, 19);
			ref var p20 = ref Unsafe.Add(ref p0, 20);
			ref var p21 = ref Unsafe.Add(ref p0, 21);
			ref var p22 = ref Unsafe.Add(ref p0, 22);
			ref var p23 = ref Unsafe.Add(ref p0, 23);
			ref var p24 = ref Unsafe.Add(ref p0, 24);
			ref var p25 = ref Unsafe.Add(ref p0, 25);
			ref var p26 = ref Unsafe.Add(ref p0, 26);
			ref var p27 = ref Unsafe.Add(ref p0, 27);
			ref var p28 = ref Unsafe.Add(ref p0, 28);

			T temp;
			if (comparisonPointer(p1, p2) < 0) { temp = p1; p1 = p2; p2 = temp; }
			if (comparisonPointer(p0, p2) < 0) { temp = p0; p0 = p2; p2 = temp; }
			if (comparisonPointer(p0, p1) < 0) { temp = p0; p0 = p1; p1 = temp; }
			if (comparisonPointer(p3, p4) < 0) { temp = p3; p3 = p4; p4 = temp; }
			if (comparisonPointer(p5, p6) < 0) { temp = p5; p5 = p6; p6 = temp; }
			if (comparisonPointer(p3, p5) < 0) { temp = p3; p3 = p5; p5 = temp; }
			if (comparisonPointer(p4, p6) < 0) { temp = p4; p4 = p6; p6 = temp; }
			if (comparisonPointer(p4, p5) < 0) { temp = p4; p4 = p5; p5 = temp; }
			if (comparisonPointer(p0, p4) < 0) { temp = p0; p0 = p4; p4 = temp; }
			if (comparisonPointer(p0, p3) < 0) { temp = p0; p0 = p3; p3 = temp; }
			if (comparisonPointer(p1, p5) < 0) { temp = p1; p1 = p5; p5 = temp; }
			if (comparisonPointer(p2, p6) < 0) { temp = p2; p2 = p6; p6 = temp; }
			if (comparisonPointer(p2, p5) < 0) { temp = p2; p2 = p5; p5 = temp; }
			if (comparisonPointer(p1, p3) < 0) { temp = p1; p1 = p3; p3 = temp; }
			if (comparisonPointer(p2, p4) < 0) { temp = p2; p2 = p4; p4 = temp; }
			if (comparisonPointer(p2, p3) < 0) { temp = p2; p2 = p3; p3 = temp; }
			if (comparisonPointer(p8, p9) < 0) { temp = p8; p8 = p9; p9 = temp; }
			if (comparisonPointer(p7, p9) < 0) { temp = p7; p7 = p9; p9 = temp; }
			if (comparisonPointer(p7, p8) < 0) { temp = p7; p7 = p8; p8 = temp; }
			if (comparisonPointer(p10, p11) < 0) { temp = p10; p10 = p11; p11 = temp; }
			if (comparisonPointer(p12, p13) < 0) { temp = p12; p12 = p13; p13 = temp; }
			if (comparisonPointer(p10, p12) < 0) { temp = p10; p10 = p12; p12 = temp; }
			if (comparisonPointer(p11, p13) < 0) { temp = p11; p11 = p13; p13 = temp; }
			if (comparisonPointer(p11, p12) < 0) { temp = p11; p11 = p12; p12 = temp; }
			if (comparisonPointer(p7, p11) < 0) { temp = p7; p7 = p11; p11 = temp; }
			if (comparisonPointer(p7, p10) < 0) { temp = p7; p7 = p10; p10 = temp; }
			if (comparisonPointer(p8, p12) < 0) { temp = p8; p8 = p12; p12 = temp; }
			if (comparisonPointer(p9, p13) < 0) { temp = p9; p9 = p13; p13 = temp; }
			if (comparisonPointer(p9, p12) < 0) { temp = p9; p9 = p12; p12 = temp; }
			if (comparisonPointer(p8, p10) < 0) { temp = p8; p8 = p10; p10 = temp; }
			if (comparisonPointer(p9, p11) < 0) { temp = p9; p9 = p11; p11 = temp; }
			if (comparisonPointer(p9, p10) < 0) { temp = p9; p9 = p10; p10 = temp; }
			if (comparisonPointer(p0, p8) < 0) { temp = p0; p0 = p8; p8 = temp; }
			if (comparisonPointer(p0, p7) < 0) { temp = p0; p0 = p7; p7 = temp; }
			if (comparisonPointer(p1, p9) < 0) { temp = p1; p1 = p9; p9 = temp; }
			if (comparisonPointer(p2, p10) < 0) { temp = p2; p2 = p10; p10 = temp; }
			if (comparisonPointer(p2, p9) < 0) { temp = p2; p2 = p9; p9 = temp; }
			if (comparisonPointer(p1, p7) < 0) { temp = p1; p1 = p7; p7 = temp; }
			if (comparisonPointer(p2, p8) < 0) { temp = p2; p2 = p8; p8 = temp; }
			if (comparisonPointer(p2, p7) < 0) { temp = p2; p2 = p7; p7 = temp; }
			if (comparisonPointer(p3, p11) < 0) { temp = p3; p3 = p11; p11 = temp; }
			if (comparisonPointer(p4, p12) < 0) { temp = p4; p4 = p12; p12 = temp; }
			if (comparisonPointer(p4, p11) < 0) { temp = p4; p4 = p11; p11 = temp; }
			if (comparisonPointer(p5, p13) < 0) { temp = p5; p5 = p13; p13 = temp; }
			if (comparisonPointer(p6, p13) < 0) { temp = p6; p6 = p13; p13 = temp; }
			if (comparisonPointer(p5, p11) < 0) { temp = p5; p5 = p11; p11 = temp; }
			if (comparisonPointer(p6, p12) < 0) { temp = p6; p6 = p12; p12 = temp; }
			if (comparisonPointer(p6, p11) < 0) { temp = p6; p6 = p11; p11 = temp; }
			if (comparisonPointer(p3, p7) < 0) { temp = p3; p3 = p7; p7 = temp; }
			if (comparisonPointer(p4, p8) < 0) { temp = p4; p4 = p8; p8 = temp; }
			if (comparisonPointer(p4, p7) < 0) { temp = p4; p4 = p7; p7 = temp; }
			if (comparisonPointer(p5, p9) < 0) { temp = p5; p5 = p9; p9 = temp; }
			if (comparisonPointer(p6, p10) < 0) { temp = p6; p6 = p10; p10 = temp; }
			if (comparisonPointer(p6, p9) < 0) { temp = p6; p6 = p9; p9 = temp; }
			if (comparisonPointer(p5, p7) < 0) { temp = p5; p5 = p7; p7 = temp; }
			if (comparisonPointer(p6, p8) < 0) { temp = p6; p6 = p8; p8 = temp; }
			if (comparisonPointer(p6, p7) < 0) { temp = p6; p6 = p7; p7 = temp; }
			if (comparisonPointer(p15, p16) < 0) { temp = p15; p15 = p16; p16 = temp; }
			if (comparisonPointer(p14, p16) < 0) { temp = p14; p14 = p16; p16 = temp; }
			if (comparisonPointer(p14, p15) < 0) { temp = p14; p14 = p15; p15 = temp; }
			if (comparisonPointer(p17, p18) < 0) { temp = p17; p17 = p18; p18 = temp; }
			if (comparisonPointer(p19, p20) < 0) { temp = p19; p19 = p20; p20 = temp; }
			if (comparisonPointer(p17, p19) < 0) { temp = p17; p17 = p19; p19 = temp; }
			if (comparisonPointer(p18, p20) < 0) { temp = p18; p18 = p20; p20 = temp; }
			if (comparisonPointer(p18, p19) < 0) { temp = p18; p18 = p19; p19 = temp; }
			if (comparisonPointer(p14, p18) < 0) { temp = p14; p14 = p18; p18 = temp; }
			if (comparisonPointer(p14, p17) < 0) { temp = p14; p14 = p17; p17 = temp; }
			if (comparisonPointer(p15, p19) < 0) { temp = p15; p15 = p19; p19 = temp; }
			if (comparisonPointer(p16, p20) < 0) { temp = p16; p16 = p20; p20 = temp; }
			if (comparisonPointer(p16, p19) < 0) { temp = p16; p16 = p19; p19 = temp; }
			if (comparisonPointer(p15, p17) < 0) { temp = p15; p15 = p17; p17 = temp; }
			if (comparisonPointer(p16, p18) < 0) { temp = p16; p16 = p18; p18 = temp; }
			if (comparisonPointer(p16, p17) < 0) { temp = p16; p16 = p17; p17 = temp; }
			if (comparisonPointer(p21, p22) < 0) { temp = p21; p21 = p22; p22 = temp; }
			if (comparisonPointer(p23, p24) < 0) { temp = p23; p23 = p24; p24 = temp; }
			if (comparisonPointer(p21, p23) < 0) { temp = p21; p21 = p23; p23 = temp; }
			if (comparisonPointer(p22, p24) < 0) { temp = p22; p22 = p24; p24 = temp; }
			if (comparisonPointer(p22, p23) < 0) { temp = p22; p22 = p23; p23 = temp; }
			if (comparisonPointer(p25, p26) < 0) { temp = p25; p25 = p26; p26 = temp; }
			if (comparisonPointer(p27, p28) < 0) { temp = p27; p27 = p28; p28 = temp; }
			if (comparisonPointer(p25, p27) < 0) { temp = p25; p25 = p27; p27 = temp; }
			if (comparisonPointer(p26, p28) < 0) { temp = p26; p26 = p28; p28 = temp; }
			if (comparisonPointer(p26, p27) < 0) { temp = p26; p26 = p27; p27 = temp; }
			if (comparisonPointer(p21, p25) < 0) { temp = p21; p21 = p25; p25 = temp; }
			if (comparisonPointer(p22, p26) < 0) { temp = p22; p22 = p26; p26 = temp; }
			if (comparisonPointer(p22, p25) < 0) { temp = p22; p22 = p25; p25 = temp; }
			if (comparisonPointer(p23, p27) < 0) { temp = p23; p23 = p27; p27 = temp; }
			if (comparisonPointer(p24, p28) < 0) { temp = p24; p24 = p28; p28 = temp; }
			if (comparisonPointer(p24, p27) < 0) { temp = p24; p24 = p27; p27 = temp; }
			if (comparisonPointer(p23, p25) < 0) { temp = p23; p23 = p25; p25 = temp; }
			if (comparisonPointer(p24, p26) < 0) { temp = p24; p24 = p26; p26 = temp; }
			if (comparisonPointer(p24, p25) < 0) { temp = p24; p24 = p25; p25 = temp; }
			if (comparisonPointer(p14, p22) < 0) { temp = p14; p14 = p22; p22 = temp; }
			if (comparisonPointer(p14, p21) < 0) { temp = p14; p14 = p21; p21 = temp; }
			if (comparisonPointer(p15, p23) < 0) { temp = p15; p15 = p23; p23 = temp; }
			if (comparisonPointer(p16, p24) < 0) { temp = p16; p16 = p24; p24 = temp; }
			if (comparisonPointer(p16, p23) < 0) { temp = p16; p16 = p23; p23 = temp; }
			if (comparisonPointer(p15, p21) < 0) { temp = p15; p15 = p21; p21 = temp; }
			if (comparisonPointer(p16, p22) < 0) { temp = p16; p16 = p22; p22 = temp; }
			if (comparisonPointer(p16, p21) < 0) { temp = p16; p16 = p21; p21 = temp; }
			if (comparisonPointer(p17, p25) < 0) { temp = p17; p17 = p25; p25 = temp; }
			if (comparisonPointer(p18, p26) < 0) { temp = p18; p18 = p26; p26 = temp; }
			if (comparisonPointer(p18, p25) < 0) { temp = p18; p18 = p25; p25 = temp; }
			if (comparisonPointer(p19, p27) < 0) { temp = p19; p19 = p27; p27 = temp; }
			if (comparisonPointer(p20, p28) < 0) { temp = p20; p20 = p28; p28 = temp; }
			if (comparisonPointer(p20, p27) < 0) { temp = p20; p20 = p27; p27 = temp; }
			if (comparisonPointer(p19, p25) < 0) { temp = p19; p19 = p25; p25 = temp; }
			if (comparisonPointer(p20, p26) < 0) { temp = p20; p20 = p26; p26 = temp; }
			if (comparisonPointer(p20, p25) < 0) { temp = p20; p20 = p25; p25 = temp; }
			if (comparisonPointer(p17, p21) < 0) { temp = p17; p17 = p21; p21 = temp; }
			if (comparisonPointer(p18, p22) < 0) { temp = p18; p18 = p22; p22 = temp; }
			if (comparisonPointer(p18, p21) < 0) { temp = p18; p18 = p21; p21 = temp; }
			if (comparisonPointer(p19, p23) < 0) { temp = p19; p19 = p23; p23 = temp; }
			if (comparisonPointer(p20, p24) < 0) { temp = p20; p20 = p24; p24 = temp; }
			if (comparisonPointer(p20, p23) < 0) { temp = p20; p20 = p23; p23 = temp; }
			if (comparisonPointer(p19, p21) < 0) { temp = p19; p19 = p21; p21 = temp; }
			if (comparisonPointer(p20, p22) < 0) { temp = p20; p20 = p22; p22 = temp; }
			if (comparisonPointer(p20, p21) < 0) { temp = p20; p20 = p21; p21 = temp; }
			if (comparisonPointer(p0, p15) < 0) { temp = p0; p0 = p15; p15 = temp; }
			if (comparisonPointer(p0, p14) < 0) { temp = p0; p0 = p14; p14 = temp; }
			if (comparisonPointer(p1, p16) < 0) { temp = p1; p1 = p16; p16 = temp; }
			if (comparisonPointer(p2, p17) < 0) { temp = p2; p2 = p17; p17 = temp; }
			if (comparisonPointer(p2, p16) < 0) { temp = p2; p2 = p16; p16 = temp; }
			if (comparisonPointer(p1, p14) < 0) { temp = p1; p1 = p14; p14 = temp; }
			if (comparisonPointer(p2, p15) < 0) { temp = p2; p2 = p15; p15 = temp; }
			if (comparisonPointer(p2, p14) < 0) { temp = p2; p2 = p14; p14 = temp; }
			if (comparisonPointer(p3, p18) < 0) { temp = p3; p3 = p18; p18 = temp; }
			if (comparisonPointer(p4, p19) < 0) { temp = p4; p4 = p19; p19 = temp; }
			if (comparisonPointer(p4, p18) < 0) { temp = p4; p4 = p18; p18 = temp; }
			if (comparisonPointer(p5, p20) < 0) { temp = p5; p5 = p20; p20 = temp; }
			if (comparisonPointer(p6, p21) < 0) { temp = p6; p6 = p21; p21 = temp; }
			if (comparisonPointer(p6, p20) < 0) { temp = p6; p6 = p20; p20 = temp; }
			if (comparisonPointer(p5, p18) < 0) { temp = p5; p5 = p18; p18 = temp; }
			if (comparisonPointer(p6, p19) < 0) { temp = p6; p6 = p19; p19 = temp; }
			if (comparisonPointer(p6, p18) < 0) { temp = p6; p6 = p18; p18 = temp; }
			if (comparisonPointer(p3, p14) < 0) { temp = p3; p3 = p14; p14 = temp; }
			if (comparisonPointer(p4, p15) < 0) { temp = p4; p4 = p15; p15 = temp; }
			if (comparisonPointer(p4, p14) < 0) { temp = p4; p4 = p14; p14 = temp; }
			if (comparisonPointer(p5, p16) < 0) { temp = p5; p5 = p16; p16 = temp; }
			if (comparisonPointer(p6, p17) < 0) { temp = p6; p6 = p17; p17 = temp; }
			if (comparisonPointer(p6, p16) < 0) { temp = p6; p6 = p16; p16 = temp; }
			if (comparisonPointer(p5, p14) < 0) { temp = p5; p5 = p14; p14 = temp; }
			if (comparisonPointer(p6, p15) < 0) { temp = p6; p6 = p15; p15 = temp; }
			if (comparisonPointer(p6, p14) < 0) { temp = p6; p6 = p14; p14 = temp; }
			if (comparisonPointer(p7, p23) < 0) { temp = p7; p7 = p23; p23 = temp; }
			if (comparisonPointer(p7, p22) < 0) { temp = p7; p7 = p22; p22 = temp; }
			if (comparisonPointer(p8, p24) < 0) { temp = p8; p8 = p24; p24 = temp; }
			if (comparisonPointer(p9, p25) < 0) { temp = p9; p9 = p25; p25 = temp; }
			if (comparisonPointer(p9, p24) < 0) { temp = p9; p9 = p24; p24 = temp; }
			if (comparisonPointer(p8, p22) < 0) { temp = p8; p8 = p22; p22 = temp; }
			if (comparisonPointer(p9, p23) < 0) { temp = p9; p9 = p23; p23 = temp; }
			if (comparisonPointer(p9, p22) < 0) { temp = p9; p9 = p22; p22 = temp; }
			if (comparisonPointer(p10, p26) < 0) { temp = p10; p10 = p26; p26 = temp; }
			if (comparisonPointer(p11, p27) < 0) { temp = p11; p11 = p27; p27 = temp; }
			if (comparisonPointer(p11, p26) < 0) { temp = p11; p11 = p26; p26 = temp; }
			if (comparisonPointer(p12, p28) < 0) { temp = p12; p12 = p28; p28 = temp; }
			if (comparisonPointer(p13, p28) < 0) { temp = p13; p13 = p28; p28 = temp; }
			if (comparisonPointer(p12, p26) < 0) { temp = p12; p12 = p26; p26 = temp; }
			if (comparisonPointer(p13, p27) < 0) { temp = p13; p13 = p27; p27 = temp; }
			if (comparisonPointer(p13, p26) < 0) { temp = p13; p13 = p26; p26 = temp; }
			if (comparisonPointer(p10, p22) < 0) { temp = p10; p10 = p22; p22 = temp; }
			if (comparisonPointer(p11, p23) < 0) { temp = p11; p11 = p23; p23 = temp; }
			if (comparisonPointer(p11, p22) < 0) { temp = p11; p11 = p22; p22 = temp; }
			if (comparisonPointer(p12, p24) < 0) { temp = p12; p12 = p24; p24 = temp; }
			if (comparisonPointer(p13, p25) < 0) { temp = p13; p13 = p25; p25 = temp; }
			if (comparisonPointer(p13, p24) < 0) { temp = p13; p13 = p24; p24 = temp; }
			if (comparisonPointer(p12, p22) < 0) { temp = p12; p12 = p22; p22 = temp; }
			if (comparisonPointer(p13, p23) < 0) { temp = p13; p13 = p23; p23 = temp; }
			if (comparisonPointer(p13, p22) < 0) { temp = p13; p13 = p22; p22 = temp; }
			if (comparisonPointer(p7, p15) < 0) { temp = p7; p7 = p15; p15 = temp; }
			if (comparisonPointer(p7, p14) < 0) { temp = p7; p7 = p14; p14 = temp; }
			if (comparisonPointer(p8, p16) < 0) { temp = p8; p8 = p16; p16 = temp; }
			if (comparisonPointer(p9, p17) < 0) { temp = p9; p9 = p17; p17 = temp; }
			if (comparisonPointer(p9, p16) < 0) { temp = p9; p9 = p16; p16 = temp; }
			if (comparisonPointer(p8, p14) < 0) { temp = p8; p8 = p14; p14 = temp; }
			if (comparisonPointer(p9, p15) < 0) { temp = p9; p9 = p15; p15 = temp; }
			if (comparisonPointer(p9, p14) < 0) { temp = p9; p9 = p14; p14 = temp; }
			if (comparisonPointer(p10, p18) < 0) { temp = p10; p10 = p18; p18 = temp; }
			if (comparisonPointer(p11, p19) < 0) { temp = p11; p11 = p19; p19 = temp; }
			if (comparisonPointer(p11, p18) < 0) { temp = p11; p11 = p18; p18 = temp; }
			if (comparisonPointer(p12, p20) < 0) { temp = p12; p12 = p20; p20 = temp; }
			if (comparisonPointer(p13, p21) < 0) { temp = p13; p13 = p21; p21 = temp; }
			if (comparisonPointer(p13, p20) < 0) { temp = p13; p13 = p20; p20 = temp; }
			if (comparisonPointer(p12, p18) < 0) { temp = p12; p12 = p18; p18 = temp; }
			if (comparisonPointer(p13, p19) < 0) { temp = p13; p13 = p19; p19 = temp; }
			if (comparisonPointer(p13, p18) < 0) { temp = p13; p13 = p18; p18 = temp; }
			if (comparisonPointer(p10, p14) < 0) { temp = p10; p10 = p14; p14 = temp; }
			if (comparisonPointer(p11, p15) < 0) { temp = p11; p11 = p15; p15 = temp; }
			if (comparisonPointer(p11, p14) < 0) { temp = p11; p11 = p14; p14 = temp; }
			if (comparisonPointer(p12, p16) < 0) { temp = p12; p12 = p16; p16 = temp; }
			if (comparisonPointer(p13, p17) < 0) { temp = p13; p13 = p17; p17 = temp; }
			if (comparisonPointer(p13, p16) < 0) { temp = p13; p13 = p16; p16 = temp; }
			if (comparisonPointer(p12, p14) < 0) { temp = p12; p12 = p14; p14 = temp; }
			if (comparisonPointer(p13, p15) < 0) { temp = p13; p13 = p15; p15 = temp; }
			if (comparisonPointer(p13, p14) < 0) { temp = p13; p13 = p14; p14 = temp; }
		}

		/// <summary>
		/// Sorts a collection of 30 elements in descending order using the specified function pointer.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparisonPointer">The function pointer to use when comparing elements.</param>
		public unsafe static void Sort30Descending<T>(ref T p0, delegate* managed<T, T, int> comparisonPointer)
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
			ref var p16 = ref Unsafe.Add(ref p0, 16);
			ref var p17 = ref Unsafe.Add(ref p0, 17);
			ref var p18 = ref Unsafe.Add(ref p0, 18);
			ref var p19 = ref Unsafe.Add(ref p0, 19);
			ref var p20 = ref Unsafe.Add(ref p0, 20);
			ref var p21 = ref Unsafe.Add(ref p0, 21);
			ref var p22 = ref Unsafe.Add(ref p0, 22);
			ref var p23 = ref Unsafe.Add(ref p0, 23);
			ref var p24 = ref Unsafe.Add(ref p0, 24);
			ref var p25 = ref Unsafe.Add(ref p0, 25);
			ref var p26 = ref Unsafe.Add(ref p0, 26);
			ref var p27 = ref Unsafe.Add(ref p0, 27);
			ref var p28 = ref Unsafe.Add(ref p0, 28);
			ref var p29 = ref Unsafe.Add(ref p0, 29);

			T temp;
			if (comparisonPointer(p1, p2) < 0) { temp = p1; p1 = p2; p2 = temp; }
			if (comparisonPointer(p0, p2) < 0) { temp = p0; p0 = p2; p2 = temp; }
			if (comparisonPointer(p0, p1) < 0) { temp = p0; p0 = p1; p1 = temp; }
			if (comparisonPointer(p3, p4) < 0) { temp = p3; p3 = p4; p4 = temp; }
			if (comparisonPointer(p5, p6) < 0) { temp = p5; p5 = p6; p6 = temp; }
			if (comparisonPointer(p3, p5) < 0) { temp = p3; p3 = p5; p5 = temp; }
			if (comparisonPointer(p4, p6) < 0) { temp = p4; p4 = p6; p6 = temp; }
			if (comparisonPointer(p4, p5) < 0) { temp = p4; p4 = p5; p5 = temp; }
			if (comparisonPointer(p0, p4) < 0) { temp = p0; p0 = p4; p4 = temp; }
			if (comparisonPointer(p0, p3) < 0) { temp = p0; p0 = p3; p3 = temp; }
			if (comparisonPointer(p1, p5) < 0) { temp = p1; p1 = p5; p5 = temp; }
			if (comparisonPointer(p2, p6) < 0) { temp = p2; p2 = p6; p6 = temp; }
			if (comparisonPointer(p2, p5) < 0) { temp = p2; p2 = p5; p5 = temp; }
			if (comparisonPointer(p1, p3) < 0) { temp = p1; p1 = p3; p3 = temp; }
			if (comparisonPointer(p2, p4) < 0) { temp = p2; p2 = p4; p4 = temp; }
			if (comparisonPointer(p2, p3) < 0) { temp = p2; p2 = p3; p3 = temp; }
			if (comparisonPointer(p7, p8) < 0) { temp = p7; p7 = p8; p8 = temp; }
			if (comparisonPointer(p9, p10) < 0) { temp = p9; p9 = p10; p10 = temp; }
			if (comparisonPointer(p7, p9) < 0) { temp = p7; p7 = p9; p9 = temp; }
			if (comparisonPointer(p8, p10) < 0) { temp = p8; p8 = p10; p10 = temp; }
			if (comparisonPointer(p8, p9) < 0) { temp = p8; p8 = p9; p9 = temp; }
			if (comparisonPointer(p11, p12) < 0) { temp = p11; p11 = p12; p12 = temp; }
			if (comparisonPointer(p13, p14) < 0) { temp = p13; p13 = p14; p14 = temp; }
			if (comparisonPointer(p11, p13) < 0) { temp = p11; p11 = p13; p13 = temp; }
			if (comparisonPointer(p12, p14) < 0) { temp = p12; p12 = p14; p14 = temp; }
			if (comparisonPointer(p12, p13) < 0) { temp = p12; p12 = p13; p13 = temp; }
			if (comparisonPointer(p7, p11) < 0) { temp = p7; p7 = p11; p11 = temp; }
			if (comparisonPointer(p8, p12) < 0) { temp = p8; p8 = p12; p12 = temp; }
			if (comparisonPointer(p8, p11) < 0) { temp = p8; p8 = p11; p11 = temp; }
			if (comparisonPointer(p9, p13) < 0) { temp = p9; p9 = p13; p13 = temp; }
			if (comparisonPointer(p10, p14) < 0) { temp = p10; p10 = p14; p14 = temp; }
			if (comparisonPointer(p10, p13) < 0) { temp = p10; p10 = p13; p13 = temp; }
			if (comparisonPointer(p9, p11) < 0) { temp = p9; p9 = p11; p11 = temp; }
			if (comparisonPointer(p10, p12) < 0) { temp = p10; p10 = p12; p12 = temp; }
			if (comparisonPointer(p10, p11) < 0) { temp = p10; p10 = p11; p11 = temp; }
			if (comparisonPointer(p0, p8) < 0) { temp = p0; p0 = p8; p8 = temp; }
			if (comparisonPointer(p0, p7) < 0) { temp = p0; p0 = p7; p7 = temp; }
			if (comparisonPointer(p1, p9) < 0) { temp = p1; p1 = p9; p9 = temp; }
			if (comparisonPointer(p2, p10) < 0) { temp = p2; p2 = p10; p10 = temp; }
			if (comparisonPointer(p2, p9) < 0) { temp = p2; p2 = p9; p9 = temp; }
			if (comparisonPointer(p1, p7) < 0) { temp = p1; p1 = p7; p7 = temp; }
			if (comparisonPointer(p2, p8) < 0) { temp = p2; p2 = p8; p8 = temp; }
			if (comparisonPointer(p2, p7) < 0) { temp = p2; p2 = p7; p7 = temp; }
			if (comparisonPointer(p3, p11) < 0) { temp = p3; p3 = p11; p11 = temp; }
			if (comparisonPointer(p4, p12) < 0) { temp = p4; p4 = p12; p12 = temp; }
			if (comparisonPointer(p4, p11) < 0) { temp = p4; p4 = p11; p11 = temp; }
			if (comparisonPointer(p5, p13) < 0) { temp = p5; p5 = p13; p13 = temp; }
			if (comparisonPointer(p6, p14) < 0) { temp = p6; p6 = p14; p14 = temp; }
			if (comparisonPointer(p6, p13) < 0) { temp = p6; p6 = p13; p13 = temp; }
			if (comparisonPointer(p5, p11) < 0) { temp = p5; p5 = p11; p11 = temp; }
			if (comparisonPointer(p6, p12) < 0) { temp = p6; p6 = p12; p12 = temp; }
			if (comparisonPointer(p6, p11) < 0) { temp = p6; p6 = p11; p11 = temp; }
			if (comparisonPointer(p3, p7) < 0) { temp = p3; p3 = p7; p7 = temp; }
			if (comparisonPointer(p4, p8) < 0) { temp = p4; p4 = p8; p8 = temp; }
			if (comparisonPointer(p4, p7) < 0) { temp = p4; p4 = p7; p7 = temp; }
			if (comparisonPointer(p5, p9) < 0) { temp = p5; p5 = p9; p9 = temp; }
			if (comparisonPointer(p6, p10) < 0) { temp = p6; p6 = p10; p10 = temp; }
			if (comparisonPointer(p6, p9) < 0) { temp = p6; p6 = p9; p9 = temp; }
			if (comparisonPointer(p5, p7) < 0) { temp = p5; p5 = p7; p7 = temp; }
			if (comparisonPointer(p6, p8) < 0) { temp = p6; p6 = p8; p8 = temp; }
			if (comparisonPointer(p6, p7) < 0) { temp = p6; p6 = p7; p7 = temp; }
			if (comparisonPointer(p16, p17) < 0) { temp = p16; p16 = p17; p17 = temp; }
			if (comparisonPointer(p15, p17) < 0) { temp = p15; p15 = p17; p17 = temp; }
			if (comparisonPointer(p15, p16) < 0) { temp = p15; p15 = p16; p16 = temp; }
			if (comparisonPointer(p18, p19) < 0) { temp = p18; p18 = p19; p19 = temp; }
			if (comparisonPointer(p20, p21) < 0) { temp = p20; p20 = p21; p21 = temp; }
			if (comparisonPointer(p18, p20) < 0) { temp = p18; p18 = p20; p20 = temp; }
			if (comparisonPointer(p19, p21) < 0) { temp = p19; p19 = p21; p21 = temp; }
			if (comparisonPointer(p19, p20) < 0) { temp = p19; p19 = p20; p20 = temp; }
			if (comparisonPointer(p15, p19) < 0) { temp = p15; p15 = p19; p19 = temp; }
			if (comparisonPointer(p15, p18) < 0) { temp = p15; p15 = p18; p18 = temp; }
			if (comparisonPointer(p16, p20) < 0) { temp = p16; p16 = p20; p20 = temp; }
			if (comparisonPointer(p17, p21) < 0) { temp = p17; p17 = p21; p21 = temp; }
			if (comparisonPointer(p17, p20) < 0) { temp = p17; p17 = p20; p20 = temp; }
			if (comparisonPointer(p16, p18) < 0) { temp = p16; p16 = p18; p18 = temp; }
			if (comparisonPointer(p17, p19) < 0) { temp = p17; p17 = p19; p19 = temp; }
			if (comparisonPointer(p17, p18) < 0) { temp = p17; p17 = p18; p18 = temp; }
			if (comparisonPointer(p22, p23) < 0) { temp = p22; p22 = p23; p23 = temp; }
			if (comparisonPointer(p24, p25) < 0) { temp = p24; p24 = p25; p25 = temp; }
			if (comparisonPointer(p22, p24) < 0) { temp = p22; p22 = p24; p24 = temp; }
			if (comparisonPointer(p23, p25) < 0) { temp = p23; p23 = p25; p25 = temp; }
			if (comparisonPointer(p23, p24) < 0) { temp = p23; p23 = p24; p24 = temp; }
			if (comparisonPointer(p26, p27) < 0) { temp = p26; p26 = p27; p27 = temp; }
			if (comparisonPointer(p28, p29) < 0) { temp = p28; p28 = p29; p29 = temp; }
			if (comparisonPointer(p26, p28) < 0) { temp = p26; p26 = p28; p28 = temp; }
			if (comparisonPointer(p27, p29) < 0) { temp = p27; p27 = p29; p29 = temp; }
			if (comparisonPointer(p27, p28) < 0) { temp = p27; p27 = p28; p28 = temp; }
			if (comparisonPointer(p22, p26) < 0) { temp = p22; p22 = p26; p26 = temp; }
			if (comparisonPointer(p23, p27) < 0) { temp = p23; p23 = p27; p27 = temp; }
			if (comparisonPointer(p23, p26) < 0) { temp = p23; p23 = p26; p26 = temp; }
			if (comparisonPointer(p24, p28) < 0) { temp = p24; p24 = p28; p28 = temp; }
			if (comparisonPointer(p25, p29) < 0) { temp = p25; p25 = p29; p29 = temp; }
			if (comparisonPointer(p25, p28) < 0) { temp = p25; p25 = p28; p28 = temp; }
			if (comparisonPointer(p24, p26) < 0) { temp = p24; p24 = p26; p26 = temp; }
			if (comparisonPointer(p25, p27) < 0) { temp = p25; p25 = p27; p27 = temp; }
			if (comparisonPointer(p25, p26) < 0) { temp = p25; p25 = p26; p26 = temp; }
			if (comparisonPointer(p15, p23) < 0) { temp = p15; p15 = p23; p23 = temp; }
			if (comparisonPointer(p15, p22) < 0) { temp = p15; p15 = p22; p22 = temp; }
			if (comparisonPointer(p16, p24) < 0) { temp = p16; p16 = p24; p24 = temp; }
			if (comparisonPointer(p17, p25) < 0) { temp = p17; p17 = p25; p25 = temp; }
			if (comparisonPointer(p17, p24) < 0) { temp = p17; p17 = p24; p24 = temp; }
			if (comparisonPointer(p16, p22) < 0) { temp = p16; p16 = p22; p22 = temp; }
			if (comparisonPointer(p17, p23) < 0) { temp = p17; p17 = p23; p23 = temp; }
			if (comparisonPointer(p17, p22) < 0) { temp = p17; p17 = p22; p22 = temp; }
			if (comparisonPointer(p18, p26) < 0) { temp = p18; p18 = p26; p26 = temp; }
			if (comparisonPointer(p19, p27) < 0) { temp = p19; p19 = p27; p27 = temp; }
			if (comparisonPointer(p19, p26) < 0) { temp = p19; p19 = p26; p26 = temp; }
			if (comparisonPointer(p20, p28) < 0) { temp = p20; p20 = p28; p28 = temp; }
			if (comparisonPointer(p21, p29) < 0) { temp = p21; p21 = p29; p29 = temp; }
			if (comparisonPointer(p21, p28) < 0) { temp = p21; p21 = p28; p28 = temp; }
			if (comparisonPointer(p20, p26) < 0) { temp = p20; p20 = p26; p26 = temp; }
			if (comparisonPointer(p21, p27) < 0) { temp = p21; p21 = p27; p27 = temp; }
			if (comparisonPointer(p21, p26) < 0) { temp = p21; p21 = p26; p26 = temp; }
			if (comparisonPointer(p18, p22) < 0) { temp = p18; p18 = p22; p22 = temp; }
			if (comparisonPointer(p19, p23) < 0) { temp = p19; p19 = p23; p23 = temp; }
			if (comparisonPointer(p19, p22) < 0) { temp = p19; p19 = p22; p22 = temp; }
			if (comparisonPointer(p20, p24) < 0) { temp = p20; p20 = p24; p24 = temp; }
			if (comparisonPointer(p21, p25) < 0) { temp = p21; p21 = p25; p25 = temp; }
			if (comparisonPointer(p21, p24) < 0) { temp = p21; p21 = p24; p24 = temp; }
			if (comparisonPointer(p20, p22) < 0) { temp = p20; p20 = p22; p22 = temp; }
			if (comparisonPointer(p21, p23) < 0) { temp = p21; p21 = p23; p23 = temp; }
			if (comparisonPointer(p21, p22) < 0) { temp = p21; p21 = p22; p22 = temp; }
			if (comparisonPointer(p0, p16) < 0) { temp = p0; p0 = p16; p16 = temp; }
			if (comparisonPointer(p0, p15) < 0) { temp = p0; p0 = p15; p15 = temp; }
			if (comparisonPointer(p1, p17) < 0) { temp = p1; p1 = p17; p17 = temp; }
			if (comparisonPointer(p2, p18) < 0) { temp = p2; p2 = p18; p18 = temp; }
			if (comparisonPointer(p2, p17) < 0) { temp = p2; p2 = p17; p17 = temp; }
			if (comparisonPointer(p1, p15) < 0) { temp = p1; p1 = p15; p15 = temp; }
			if (comparisonPointer(p2, p16) < 0) { temp = p2; p2 = p16; p16 = temp; }
			if (comparisonPointer(p2, p15) < 0) { temp = p2; p2 = p15; p15 = temp; }
			if (comparisonPointer(p3, p19) < 0) { temp = p3; p3 = p19; p19 = temp; }
			if (comparisonPointer(p4, p20) < 0) { temp = p4; p4 = p20; p20 = temp; }
			if (comparisonPointer(p4, p19) < 0) { temp = p4; p4 = p19; p19 = temp; }
			if (comparisonPointer(p5, p21) < 0) { temp = p5; p5 = p21; p21 = temp; }
			if (comparisonPointer(p6, p22) < 0) { temp = p6; p6 = p22; p22 = temp; }
			if (comparisonPointer(p6, p21) < 0) { temp = p6; p6 = p21; p21 = temp; }
			if (comparisonPointer(p5, p19) < 0) { temp = p5; p5 = p19; p19 = temp; }
			if (comparisonPointer(p6, p20) < 0) { temp = p6; p6 = p20; p20 = temp; }
			if (comparisonPointer(p6, p19) < 0) { temp = p6; p6 = p19; p19 = temp; }
			if (comparisonPointer(p3, p15) < 0) { temp = p3; p3 = p15; p15 = temp; }
			if (comparisonPointer(p4, p16) < 0) { temp = p4; p4 = p16; p16 = temp; }
			if (comparisonPointer(p4, p15) < 0) { temp = p4; p4 = p15; p15 = temp; }
			if (comparisonPointer(p5, p17) < 0) { temp = p5; p5 = p17; p17 = temp; }
			if (comparisonPointer(p6, p18) < 0) { temp = p6; p6 = p18; p18 = temp; }
			if (comparisonPointer(p6, p17) < 0) { temp = p6; p6 = p17; p17 = temp; }
			if (comparisonPointer(p5, p15) < 0) { temp = p5; p5 = p15; p15 = temp; }
			if (comparisonPointer(p6, p16) < 0) { temp = p6; p6 = p16; p16 = temp; }
			if (comparisonPointer(p6, p15) < 0) { temp = p6; p6 = p15; p15 = temp; }
			if (comparisonPointer(p7, p23) < 0) { temp = p7; p7 = p23; p23 = temp; }
			if (comparisonPointer(p8, p24) < 0) { temp = p8; p8 = p24; p24 = temp; }
			if (comparisonPointer(p8, p23) < 0) { temp = p8; p8 = p23; p23 = temp; }
			if (comparisonPointer(p9, p25) < 0) { temp = p9; p9 = p25; p25 = temp; }
			if (comparisonPointer(p10, p26) < 0) { temp = p10; p10 = p26; p26 = temp; }
			if (comparisonPointer(p10, p25) < 0) { temp = p10; p10 = p25; p25 = temp; }
			if (comparisonPointer(p9, p23) < 0) { temp = p9; p9 = p23; p23 = temp; }
			if (comparisonPointer(p10, p24) < 0) { temp = p10; p10 = p24; p24 = temp; }
			if (comparisonPointer(p10, p23) < 0) { temp = p10; p10 = p23; p23 = temp; }
			if (comparisonPointer(p11, p27) < 0) { temp = p11; p11 = p27; p27 = temp; }
			if (comparisonPointer(p12, p28) < 0) { temp = p12; p12 = p28; p28 = temp; }
			if (comparisonPointer(p12, p27) < 0) { temp = p12; p12 = p27; p27 = temp; }
			if (comparisonPointer(p13, p29) < 0) { temp = p13; p13 = p29; p29 = temp; }
			if (comparisonPointer(p14, p29) < 0) { temp = p14; p14 = p29; p29 = temp; }
			if (comparisonPointer(p13, p27) < 0) { temp = p13; p13 = p27; p27 = temp; }
			if (comparisonPointer(p14, p28) < 0) { temp = p14; p14 = p28; p28 = temp; }
			if (comparisonPointer(p14, p27) < 0) { temp = p14; p14 = p27; p27 = temp; }
			if (comparisonPointer(p11, p23) < 0) { temp = p11; p11 = p23; p23 = temp; }
			if (comparisonPointer(p12, p24) < 0) { temp = p12; p12 = p24; p24 = temp; }
			if (comparisonPointer(p12, p23) < 0) { temp = p12; p12 = p23; p23 = temp; }
			if (comparisonPointer(p13, p25) < 0) { temp = p13; p13 = p25; p25 = temp; }
			if (comparisonPointer(p14, p26) < 0) { temp = p14; p14 = p26; p26 = temp; }
			if (comparisonPointer(p14, p25) < 0) { temp = p14; p14 = p25; p25 = temp; }
			if (comparisonPointer(p13, p23) < 0) { temp = p13; p13 = p23; p23 = temp; }
			if (comparisonPointer(p14, p24) < 0) { temp = p14; p14 = p24; p24 = temp; }
			if (comparisonPointer(p14, p23) < 0) { temp = p14; p14 = p23; p23 = temp; }
			if (comparisonPointer(p7, p15) < 0) { temp = p7; p7 = p15; p15 = temp; }
			if (comparisonPointer(p8, p16) < 0) { temp = p8; p8 = p16; p16 = temp; }
			if (comparisonPointer(p8, p15) < 0) { temp = p8; p8 = p15; p15 = temp; }
			if (comparisonPointer(p9, p17) < 0) { temp = p9; p9 = p17; p17 = temp; }
			if (comparisonPointer(p10, p18) < 0) { temp = p10; p10 = p18; p18 = temp; }
			if (comparisonPointer(p10, p17) < 0) { temp = p10; p10 = p17; p17 = temp; }
			if (comparisonPointer(p9, p15) < 0) { temp = p9; p9 = p15; p15 = temp; }
			if (comparisonPointer(p10, p16) < 0) { temp = p10; p10 = p16; p16 = temp; }
			if (comparisonPointer(p10, p15) < 0) { temp = p10; p10 = p15; p15 = temp; }
			if (comparisonPointer(p11, p19) < 0) { temp = p11; p11 = p19; p19 = temp; }
			if (comparisonPointer(p12, p20) < 0) { temp = p12; p12 = p20; p20 = temp; }
			if (comparisonPointer(p12, p19) < 0) { temp = p12; p12 = p19; p19 = temp; }
			if (comparisonPointer(p13, p21) < 0) { temp = p13; p13 = p21; p21 = temp; }
			if (comparisonPointer(p14, p22) < 0) { temp = p14; p14 = p22; p22 = temp; }
			if (comparisonPointer(p14, p21) < 0) { temp = p14; p14 = p21; p21 = temp; }
			if (comparisonPointer(p13, p19) < 0) { temp = p13; p13 = p19; p19 = temp; }
			if (comparisonPointer(p14, p20) < 0) { temp = p14; p14 = p20; p20 = temp; }
			if (comparisonPointer(p14, p19) < 0) { temp = p14; p14 = p19; p19 = temp; }
			if (comparisonPointer(p11, p15) < 0) { temp = p11; p11 = p15; p15 = temp; }
			if (comparisonPointer(p12, p16) < 0) { temp = p12; p12 = p16; p16 = temp; }
			if (comparisonPointer(p12, p15) < 0) { temp = p12; p12 = p15; p15 = temp; }
			if (comparisonPointer(p13, p17) < 0) { temp = p13; p13 = p17; p17 = temp; }
			if (comparisonPointer(p14, p18) < 0) { temp = p14; p14 = p18; p18 = temp; }
			if (comparisonPointer(p14, p17) < 0) { temp = p14; p14 = p17; p17 = temp; }
			if (comparisonPointer(p13, p15) < 0) { temp = p13; p13 = p15; p15 = temp; }
			if (comparisonPointer(p14, p16) < 0) { temp = p14; p14 = p16; p16 = temp; }
			if (comparisonPointer(p14, p15) < 0) { temp = p14; p14 = p15; p15 = temp; }
		}

		/// <summary>
		/// Sorts a collection of 31 elements in descending order using the specified function pointer.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparisonPointer">The function pointer to use when comparing elements.</param>
		public unsafe static void Sort31Descending<T>(ref T p0, delegate* managed<T, T, int> comparisonPointer)
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
			ref var p16 = ref Unsafe.Add(ref p0, 16);
			ref var p17 = ref Unsafe.Add(ref p0, 17);
			ref var p18 = ref Unsafe.Add(ref p0, 18);
			ref var p19 = ref Unsafe.Add(ref p0, 19);
			ref var p20 = ref Unsafe.Add(ref p0, 20);
			ref var p21 = ref Unsafe.Add(ref p0, 21);
			ref var p22 = ref Unsafe.Add(ref p0, 22);
			ref var p23 = ref Unsafe.Add(ref p0, 23);
			ref var p24 = ref Unsafe.Add(ref p0, 24);
			ref var p25 = ref Unsafe.Add(ref p0, 25);
			ref var p26 = ref Unsafe.Add(ref p0, 26);
			ref var p27 = ref Unsafe.Add(ref p0, 27);
			ref var p28 = ref Unsafe.Add(ref p0, 28);
			ref var p29 = ref Unsafe.Add(ref p0, 29);
			ref var p30 = ref Unsafe.Add(ref p0, 30);

			T temp;
			if (comparisonPointer(p1, p2) < 0) { temp = p1; p1 = p2; p2 = temp; }
			if (comparisonPointer(p0, p2) < 0) { temp = p0; p0 = p2; p2 = temp; }
			if (comparisonPointer(p0, p1) < 0) { temp = p0; p0 = p1; p1 = temp; }
			if (comparisonPointer(p3, p4) < 0) { temp = p3; p3 = p4; p4 = temp; }
			if (comparisonPointer(p5, p6) < 0) { temp = p5; p5 = p6; p6 = temp; }
			if (comparisonPointer(p3, p5) < 0) { temp = p3; p3 = p5; p5 = temp; }
			if (comparisonPointer(p4, p6) < 0) { temp = p4; p4 = p6; p6 = temp; }
			if (comparisonPointer(p4, p5) < 0) { temp = p4; p4 = p5; p5 = temp; }
			if (comparisonPointer(p0, p4) < 0) { temp = p0; p0 = p4; p4 = temp; }
			if (comparisonPointer(p0, p3) < 0) { temp = p0; p0 = p3; p3 = temp; }
			if (comparisonPointer(p1, p5) < 0) { temp = p1; p1 = p5; p5 = temp; }
			if (comparisonPointer(p2, p6) < 0) { temp = p2; p2 = p6; p6 = temp; }
			if (comparisonPointer(p2, p5) < 0) { temp = p2; p2 = p5; p5 = temp; }
			if (comparisonPointer(p1, p3) < 0) { temp = p1; p1 = p3; p3 = temp; }
			if (comparisonPointer(p2, p4) < 0) { temp = p2; p2 = p4; p4 = temp; }
			if (comparisonPointer(p2, p3) < 0) { temp = p2; p2 = p3; p3 = temp; }
			if (comparisonPointer(p7, p8) < 0) { temp = p7; p7 = p8; p8 = temp; }
			if (comparisonPointer(p9, p10) < 0) { temp = p9; p9 = p10; p10 = temp; }
			if (comparisonPointer(p7, p9) < 0) { temp = p7; p7 = p9; p9 = temp; }
			if (comparisonPointer(p8, p10) < 0) { temp = p8; p8 = p10; p10 = temp; }
			if (comparisonPointer(p8, p9) < 0) { temp = p8; p8 = p9; p9 = temp; }
			if (comparisonPointer(p11, p12) < 0) { temp = p11; p11 = p12; p12 = temp; }
			if (comparisonPointer(p13, p14) < 0) { temp = p13; p13 = p14; p14 = temp; }
			if (comparisonPointer(p11, p13) < 0) { temp = p11; p11 = p13; p13 = temp; }
			if (comparisonPointer(p12, p14) < 0) { temp = p12; p12 = p14; p14 = temp; }
			if (comparisonPointer(p12, p13) < 0) { temp = p12; p12 = p13; p13 = temp; }
			if (comparisonPointer(p7, p11) < 0) { temp = p7; p7 = p11; p11 = temp; }
			if (comparisonPointer(p8, p12) < 0) { temp = p8; p8 = p12; p12 = temp; }
			if (comparisonPointer(p8, p11) < 0) { temp = p8; p8 = p11; p11 = temp; }
			if (comparisonPointer(p9, p13) < 0) { temp = p9; p9 = p13; p13 = temp; }
			if (comparisonPointer(p10, p14) < 0) { temp = p10; p10 = p14; p14 = temp; }
			if (comparisonPointer(p10, p13) < 0) { temp = p10; p10 = p13; p13 = temp; }
			if (comparisonPointer(p9, p11) < 0) { temp = p9; p9 = p11; p11 = temp; }
			if (comparisonPointer(p10, p12) < 0) { temp = p10; p10 = p12; p12 = temp; }
			if (comparisonPointer(p10, p11) < 0) { temp = p10; p10 = p11; p11 = temp; }
			if (comparisonPointer(p0, p8) < 0) { temp = p0; p0 = p8; p8 = temp; }
			if (comparisonPointer(p0, p7) < 0) { temp = p0; p0 = p7; p7 = temp; }
			if (comparisonPointer(p1, p9) < 0) { temp = p1; p1 = p9; p9 = temp; }
			if (comparisonPointer(p2, p10) < 0) { temp = p2; p2 = p10; p10 = temp; }
			if (comparisonPointer(p2, p9) < 0) { temp = p2; p2 = p9; p9 = temp; }
			if (comparisonPointer(p1, p7) < 0) { temp = p1; p1 = p7; p7 = temp; }
			if (comparisonPointer(p2, p8) < 0) { temp = p2; p2 = p8; p8 = temp; }
			if (comparisonPointer(p2, p7) < 0) { temp = p2; p2 = p7; p7 = temp; }
			if (comparisonPointer(p3, p11) < 0) { temp = p3; p3 = p11; p11 = temp; }
			if (comparisonPointer(p4, p12) < 0) { temp = p4; p4 = p12; p12 = temp; }
			if (comparisonPointer(p4, p11) < 0) { temp = p4; p4 = p11; p11 = temp; }
			if (comparisonPointer(p5, p13) < 0) { temp = p5; p5 = p13; p13 = temp; }
			if (comparisonPointer(p6, p14) < 0) { temp = p6; p6 = p14; p14 = temp; }
			if (comparisonPointer(p6, p13) < 0) { temp = p6; p6 = p13; p13 = temp; }
			if (comparisonPointer(p5, p11) < 0) { temp = p5; p5 = p11; p11 = temp; }
			if (comparisonPointer(p6, p12) < 0) { temp = p6; p6 = p12; p12 = temp; }
			if (comparisonPointer(p6, p11) < 0) { temp = p6; p6 = p11; p11 = temp; }
			if (comparisonPointer(p3, p7) < 0) { temp = p3; p3 = p7; p7 = temp; }
			if (comparisonPointer(p4, p8) < 0) { temp = p4; p4 = p8; p8 = temp; }
			if (comparisonPointer(p4, p7) < 0) { temp = p4; p4 = p7; p7 = temp; }
			if (comparisonPointer(p5, p9) < 0) { temp = p5; p5 = p9; p9 = temp; }
			if (comparisonPointer(p6, p10) < 0) { temp = p6; p6 = p10; p10 = temp; }
			if (comparisonPointer(p6, p9) < 0) { temp = p6; p6 = p9; p9 = temp; }
			if (comparisonPointer(p5, p7) < 0) { temp = p5; p5 = p7; p7 = temp; }
			if (comparisonPointer(p6, p8) < 0) { temp = p6; p6 = p8; p8 = temp; }
			if (comparisonPointer(p6, p7) < 0) { temp = p6; p6 = p7; p7 = temp; }
			if (comparisonPointer(p15, p16) < 0) { temp = p15; p15 = p16; p16 = temp; }
			if (comparisonPointer(p17, p18) < 0) { temp = p17; p17 = p18; p18 = temp; }
			if (comparisonPointer(p15, p17) < 0) { temp = p15; p15 = p17; p17 = temp; }
			if (comparisonPointer(p16, p18) < 0) { temp = p16; p16 = p18; p18 = temp; }
			if (comparisonPointer(p16, p17) < 0) { temp = p16; p16 = p17; p17 = temp; }
			if (comparisonPointer(p19, p20) < 0) { temp = p19; p19 = p20; p20 = temp; }
			if (comparisonPointer(p21, p22) < 0) { temp = p21; p21 = p22; p22 = temp; }
			if (comparisonPointer(p19, p21) < 0) { temp = p19; p19 = p21; p21 = temp; }
			if (comparisonPointer(p20, p22) < 0) { temp = p20; p20 = p22; p22 = temp; }
			if (comparisonPointer(p20, p21) < 0) { temp = p20; p20 = p21; p21 = temp; }
			if (comparisonPointer(p15, p19) < 0) { temp = p15; p15 = p19; p19 = temp; }
			if (comparisonPointer(p16, p20) < 0) { temp = p16; p16 = p20; p20 = temp; }
			if (comparisonPointer(p16, p19) < 0) { temp = p16; p16 = p19; p19 = temp; }
			if (comparisonPointer(p17, p21) < 0) { temp = p17; p17 = p21; p21 = temp; }
			if (comparisonPointer(p18, p22) < 0) { temp = p18; p18 = p22; p22 = temp; }
			if (comparisonPointer(p18, p21) < 0) { temp = p18; p18 = p21; p21 = temp; }
			if (comparisonPointer(p17, p19) < 0) { temp = p17; p17 = p19; p19 = temp; }
			if (comparisonPointer(p18, p20) < 0) { temp = p18; p18 = p20; p20 = temp; }
			if (comparisonPointer(p18, p19) < 0) { temp = p18; p18 = p19; p19 = temp; }
			if (comparisonPointer(p23, p24) < 0) { temp = p23; p23 = p24; p24 = temp; }
			if (comparisonPointer(p25, p26) < 0) { temp = p25; p25 = p26; p26 = temp; }
			if (comparisonPointer(p23, p25) < 0) { temp = p23; p23 = p25; p25 = temp; }
			if (comparisonPointer(p24, p26) < 0) { temp = p24; p24 = p26; p26 = temp; }
			if (comparisonPointer(p24, p25) < 0) { temp = p24; p24 = p25; p25 = temp; }
			if (comparisonPointer(p27, p28) < 0) { temp = p27; p27 = p28; p28 = temp; }
			if (comparisonPointer(p29, p30) < 0) { temp = p29; p29 = p30; p30 = temp; }
			if (comparisonPointer(p27, p29) < 0) { temp = p27; p27 = p29; p29 = temp; }
			if (comparisonPointer(p28, p30) < 0) { temp = p28; p28 = p30; p30 = temp; }
			if (comparisonPointer(p28, p29) < 0) { temp = p28; p28 = p29; p29 = temp; }
			if (comparisonPointer(p23, p27) < 0) { temp = p23; p23 = p27; p27 = temp; }
			if (comparisonPointer(p24, p28) < 0) { temp = p24; p24 = p28; p28 = temp; }
			if (comparisonPointer(p24, p27) < 0) { temp = p24; p24 = p27; p27 = temp; }
			if (comparisonPointer(p25, p29) < 0) { temp = p25; p25 = p29; p29 = temp; }
			if (comparisonPointer(p26, p30) < 0) { temp = p26; p26 = p30; p30 = temp; }
			if (comparisonPointer(p26, p29) < 0) { temp = p26; p26 = p29; p29 = temp; }
			if (comparisonPointer(p25, p27) < 0) { temp = p25; p25 = p27; p27 = temp; }
			if (comparisonPointer(p26, p28) < 0) { temp = p26; p26 = p28; p28 = temp; }
			if (comparisonPointer(p26, p27) < 0) { temp = p26; p26 = p27; p27 = temp; }
			if (comparisonPointer(p15, p23) < 0) { temp = p15; p15 = p23; p23 = temp; }
			if (comparisonPointer(p16, p24) < 0) { temp = p16; p16 = p24; p24 = temp; }
			if (comparisonPointer(p16, p23) < 0) { temp = p16; p16 = p23; p23 = temp; }
			if (comparisonPointer(p17, p25) < 0) { temp = p17; p17 = p25; p25 = temp; }
			if (comparisonPointer(p18, p26) < 0) { temp = p18; p18 = p26; p26 = temp; }
			if (comparisonPointer(p18, p25) < 0) { temp = p18; p18 = p25; p25 = temp; }
			if (comparisonPointer(p17, p23) < 0) { temp = p17; p17 = p23; p23 = temp; }
			if (comparisonPointer(p18, p24) < 0) { temp = p18; p18 = p24; p24 = temp; }
			if (comparisonPointer(p18, p23) < 0) { temp = p18; p18 = p23; p23 = temp; }
			if (comparisonPointer(p19, p27) < 0) { temp = p19; p19 = p27; p27 = temp; }
			if (comparisonPointer(p20, p28) < 0) { temp = p20; p20 = p28; p28 = temp; }
			if (comparisonPointer(p20, p27) < 0) { temp = p20; p20 = p27; p27 = temp; }
			if (comparisonPointer(p21, p29) < 0) { temp = p21; p21 = p29; p29 = temp; }
			if (comparisonPointer(p22, p30) < 0) { temp = p22; p22 = p30; p30 = temp; }
			if (comparisonPointer(p22, p29) < 0) { temp = p22; p22 = p29; p29 = temp; }
			if (comparisonPointer(p21, p27) < 0) { temp = p21; p21 = p27; p27 = temp; }
			if (comparisonPointer(p22, p28) < 0) { temp = p22; p22 = p28; p28 = temp; }
			if (comparisonPointer(p22, p27) < 0) { temp = p22; p22 = p27; p27 = temp; }
			if (comparisonPointer(p19, p23) < 0) { temp = p19; p19 = p23; p23 = temp; }
			if (comparisonPointer(p20, p24) < 0) { temp = p20; p20 = p24; p24 = temp; }
			if (comparisonPointer(p20, p23) < 0) { temp = p20; p20 = p23; p23 = temp; }
			if (comparisonPointer(p21, p25) < 0) { temp = p21; p21 = p25; p25 = temp; }
			if (comparisonPointer(p22, p26) < 0) { temp = p22; p22 = p26; p26 = temp; }
			if (comparisonPointer(p22, p25) < 0) { temp = p22; p22 = p25; p25 = temp; }
			if (comparisonPointer(p21, p23) < 0) { temp = p21; p21 = p23; p23 = temp; }
			if (comparisonPointer(p22, p24) < 0) { temp = p22; p22 = p24; p24 = temp; }
			if (comparisonPointer(p22, p23) < 0) { temp = p22; p22 = p23; p23 = temp; }
			if (comparisonPointer(p0, p16) < 0) { temp = p0; p0 = p16; p16 = temp; }
			if (comparisonPointer(p0, p15) < 0) { temp = p0; p0 = p15; p15 = temp; }
			if (comparisonPointer(p1, p17) < 0) { temp = p1; p1 = p17; p17 = temp; }
			if (comparisonPointer(p2, p18) < 0) { temp = p2; p2 = p18; p18 = temp; }
			if (comparisonPointer(p2, p17) < 0) { temp = p2; p2 = p17; p17 = temp; }
			if (comparisonPointer(p1, p15) < 0) { temp = p1; p1 = p15; p15 = temp; }
			if (comparisonPointer(p2, p16) < 0) { temp = p2; p2 = p16; p16 = temp; }
			if (comparisonPointer(p2, p15) < 0) { temp = p2; p2 = p15; p15 = temp; }
			if (comparisonPointer(p3, p19) < 0) { temp = p3; p3 = p19; p19 = temp; }
			if (comparisonPointer(p4, p20) < 0) { temp = p4; p4 = p20; p20 = temp; }
			if (comparisonPointer(p4, p19) < 0) { temp = p4; p4 = p19; p19 = temp; }
			if (comparisonPointer(p5, p21) < 0) { temp = p5; p5 = p21; p21 = temp; }
			if (comparisonPointer(p6, p22) < 0) { temp = p6; p6 = p22; p22 = temp; }
			if (comparisonPointer(p6, p21) < 0) { temp = p6; p6 = p21; p21 = temp; }
			if (comparisonPointer(p5, p19) < 0) { temp = p5; p5 = p19; p19 = temp; }
			if (comparisonPointer(p6, p20) < 0) { temp = p6; p6 = p20; p20 = temp; }
			if (comparisonPointer(p6, p19) < 0) { temp = p6; p6 = p19; p19 = temp; }
			if (comparisonPointer(p3, p15) < 0) { temp = p3; p3 = p15; p15 = temp; }
			if (comparisonPointer(p4, p16) < 0) { temp = p4; p4 = p16; p16 = temp; }
			if (comparisonPointer(p4, p15) < 0) { temp = p4; p4 = p15; p15 = temp; }
			if (comparisonPointer(p5, p17) < 0) { temp = p5; p5 = p17; p17 = temp; }
			if (comparisonPointer(p6, p18) < 0) { temp = p6; p6 = p18; p18 = temp; }
			if (comparisonPointer(p6, p17) < 0) { temp = p6; p6 = p17; p17 = temp; }
			if (comparisonPointer(p5, p15) < 0) { temp = p5; p5 = p15; p15 = temp; }
			if (comparisonPointer(p6, p16) < 0) { temp = p6; p6 = p16; p16 = temp; }
			if (comparisonPointer(p6, p15) < 0) { temp = p6; p6 = p15; p15 = temp; }
			if (comparisonPointer(p7, p23) < 0) { temp = p7; p7 = p23; p23 = temp; }
			if (comparisonPointer(p8, p24) < 0) { temp = p8; p8 = p24; p24 = temp; }
			if (comparisonPointer(p8, p23) < 0) { temp = p8; p8 = p23; p23 = temp; }
			if (comparisonPointer(p9, p25) < 0) { temp = p9; p9 = p25; p25 = temp; }
			if (comparisonPointer(p10, p26) < 0) { temp = p10; p10 = p26; p26 = temp; }
			if (comparisonPointer(p10, p25) < 0) { temp = p10; p10 = p25; p25 = temp; }
			if (comparisonPointer(p9, p23) < 0) { temp = p9; p9 = p23; p23 = temp; }
			if (comparisonPointer(p10, p24) < 0) { temp = p10; p10 = p24; p24 = temp; }
			if (comparisonPointer(p10, p23) < 0) { temp = p10; p10 = p23; p23 = temp; }
			if (comparisonPointer(p11, p27) < 0) { temp = p11; p11 = p27; p27 = temp; }
			if (comparisonPointer(p12, p28) < 0) { temp = p12; p12 = p28; p28 = temp; }
			if (comparisonPointer(p12, p27) < 0) { temp = p12; p12 = p27; p27 = temp; }
			if (comparisonPointer(p13, p29) < 0) { temp = p13; p13 = p29; p29 = temp; }
			if (comparisonPointer(p14, p30) < 0) { temp = p14; p14 = p30; p30 = temp; }
			if (comparisonPointer(p14, p29) < 0) { temp = p14; p14 = p29; p29 = temp; }
			if (comparisonPointer(p13, p27) < 0) { temp = p13; p13 = p27; p27 = temp; }
			if (comparisonPointer(p14, p28) < 0) { temp = p14; p14 = p28; p28 = temp; }
			if (comparisonPointer(p14, p27) < 0) { temp = p14; p14 = p27; p27 = temp; }
			if (comparisonPointer(p11, p23) < 0) { temp = p11; p11 = p23; p23 = temp; }
			if (comparisonPointer(p12, p24) < 0) { temp = p12; p12 = p24; p24 = temp; }
			if (comparisonPointer(p12, p23) < 0) { temp = p12; p12 = p23; p23 = temp; }
			if (comparisonPointer(p13, p25) < 0) { temp = p13; p13 = p25; p25 = temp; }
			if (comparisonPointer(p14, p26) < 0) { temp = p14; p14 = p26; p26 = temp; }
			if (comparisonPointer(p14, p25) < 0) { temp = p14; p14 = p25; p25 = temp; }
			if (comparisonPointer(p13, p23) < 0) { temp = p13; p13 = p23; p23 = temp; }
			if (comparisonPointer(p14, p24) < 0) { temp = p14; p14 = p24; p24 = temp; }
			if (comparisonPointer(p14, p23) < 0) { temp = p14; p14 = p23; p23 = temp; }
			if (comparisonPointer(p7, p15) < 0) { temp = p7; p7 = p15; p15 = temp; }
			if (comparisonPointer(p8, p16) < 0) { temp = p8; p8 = p16; p16 = temp; }
			if (comparisonPointer(p8, p15) < 0) { temp = p8; p8 = p15; p15 = temp; }
			if (comparisonPointer(p9, p17) < 0) { temp = p9; p9 = p17; p17 = temp; }
			if (comparisonPointer(p10, p18) < 0) { temp = p10; p10 = p18; p18 = temp; }
			if (comparisonPointer(p10, p17) < 0) { temp = p10; p10 = p17; p17 = temp; }
			if (comparisonPointer(p9, p15) < 0) { temp = p9; p9 = p15; p15 = temp; }
			if (comparisonPointer(p10, p16) < 0) { temp = p10; p10 = p16; p16 = temp; }
			if (comparisonPointer(p10, p15) < 0) { temp = p10; p10 = p15; p15 = temp; }
			if (comparisonPointer(p11, p19) < 0) { temp = p11; p11 = p19; p19 = temp; }
			if (comparisonPointer(p12, p20) < 0) { temp = p12; p12 = p20; p20 = temp; }
			if (comparisonPointer(p12, p19) < 0) { temp = p12; p12 = p19; p19 = temp; }
			if (comparisonPointer(p13, p21) < 0) { temp = p13; p13 = p21; p21 = temp; }
			if (comparisonPointer(p14, p22) < 0) { temp = p14; p14 = p22; p22 = temp; }
			if (comparisonPointer(p14, p21) < 0) { temp = p14; p14 = p21; p21 = temp; }
			if (comparisonPointer(p13, p19) < 0) { temp = p13; p13 = p19; p19 = temp; }
			if (comparisonPointer(p14, p20) < 0) { temp = p14; p14 = p20; p20 = temp; }
			if (comparisonPointer(p14, p19) < 0) { temp = p14; p14 = p19; p19 = temp; }
			if (comparisonPointer(p11, p15) < 0) { temp = p11; p11 = p15; p15 = temp; }
			if (comparisonPointer(p12, p16) < 0) { temp = p12; p12 = p16; p16 = temp; }
			if (comparisonPointer(p12, p15) < 0) { temp = p12; p12 = p15; p15 = temp; }
			if (comparisonPointer(p13, p17) < 0) { temp = p13; p13 = p17; p17 = temp; }
			if (comparisonPointer(p14, p18) < 0) { temp = p14; p14 = p18; p18 = temp; }
			if (comparisonPointer(p14, p17) < 0) { temp = p14; p14 = p17; p17 = temp; }
			if (comparisonPointer(p13, p15) < 0) { temp = p13; p13 = p15; p15 = temp; }
			if (comparisonPointer(p14, p16) < 0) { temp = p14; p14 = p16; p16 = temp; }
			if (comparisonPointer(p14, p15) < 0) { temp = p14; p14 = p15; p15 = temp; }
		}

		/// <summary>
		/// Sorts a collection of 32 elements in descending order using the specified function pointer.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparisonPointer">The function pointer to use when comparing elements.</param>
		public unsafe static void Sort32Descending<T>(ref T p0, delegate* managed<T, T, int> comparisonPointer)
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
			ref var p16 = ref Unsafe.Add(ref p0, 16);
			ref var p17 = ref Unsafe.Add(ref p0, 17);
			ref var p18 = ref Unsafe.Add(ref p0, 18);
			ref var p19 = ref Unsafe.Add(ref p0, 19);
			ref var p20 = ref Unsafe.Add(ref p0, 20);
			ref var p21 = ref Unsafe.Add(ref p0, 21);
			ref var p22 = ref Unsafe.Add(ref p0, 22);
			ref var p23 = ref Unsafe.Add(ref p0, 23);
			ref var p24 = ref Unsafe.Add(ref p0, 24);
			ref var p25 = ref Unsafe.Add(ref p0, 25);
			ref var p26 = ref Unsafe.Add(ref p0, 26);
			ref var p27 = ref Unsafe.Add(ref p0, 27);
			ref var p28 = ref Unsafe.Add(ref p0, 28);
			ref var p29 = ref Unsafe.Add(ref p0, 29);
			ref var p30 = ref Unsafe.Add(ref p0, 30);
			ref var p31 = ref Unsafe.Add(ref p0, 31);

			T temp;
			if (comparisonPointer(p0, p1) < 0) { temp = p0; p0 = p1; p1 = temp; }
			if (comparisonPointer(p2, p3) < 0) { temp = p2; p2 = p3; p3 = temp; }
			if (comparisonPointer(p0, p2) < 0) { temp = p0; p0 = p2; p2 = temp; }
			if (comparisonPointer(p1, p3) < 0) { temp = p1; p1 = p3; p3 = temp; }
			if (comparisonPointer(p1, p2) < 0) { temp = p1; p1 = p2; p2 = temp; }
			if (comparisonPointer(p4, p5) < 0) { temp = p4; p4 = p5; p5 = temp; }
			if (comparisonPointer(p6, p7) < 0) { temp = p6; p6 = p7; p7 = temp; }
			if (comparisonPointer(p4, p6) < 0) { temp = p4; p4 = p6; p6 = temp; }
			if (comparisonPointer(p5, p7) < 0) { temp = p5; p5 = p7; p7 = temp; }
			if (comparisonPointer(p5, p6) < 0) { temp = p5; p5 = p6; p6 = temp; }
			if (comparisonPointer(p0, p4) < 0) { temp = p0; p0 = p4; p4 = temp; }
			if (comparisonPointer(p1, p5) < 0) { temp = p1; p1 = p5; p5 = temp; }
			if (comparisonPointer(p1, p4) < 0) { temp = p1; p1 = p4; p4 = temp; }
			if (comparisonPointer(p2, p6) < 0) { temp = p2; p2 = p6; p6 = temp; }
			if (comparisonPointer(p3, p7) < 0) { temp = p3; p3 = p7; p7 = temp; }
			if (comparisonPointer(p3, p6) < 0) { temp = p3; p3 = p6; p6 = temp; }
			if (comparisonPointer(p2, p4) < 0) { temp = p2; p2 = p4; p4 = temp; }
			if (comparisonPointer(p3, p5) < 0) { temp = p3; p3 = p5; p5 = temp; }
			if (comparisonPointer(p3, p4) < 0) { temp = p3; p3 = p4; p4 = temp; }
			if (comparisonPointer(p8, p9) < 0) { temp = p8; p8 = p9; p9 = temp; }
			if (comparisonPointer(p10, p11) < 0) { temp = p10; p10 = p11; p11 = temp; }
			if (comparisonPointer(p8, p10) < 0) { temp = p8; p8 = p10; p10 = temp; }
			if (comparisonPointer(p9, p11) < 0) { temp = p9; p9 = p11; p11 = temp; }
			if (comparisonPointer(p9, p10) < 0) { temp = p9; p9 = p10; p10 = temp; }
			if (comparisonPointer(p12, p13) < 0) { temp = p12; p12 = p13; p13 = temp; }
			if (comparisonPointer(p14, p15) < 0) { temp = p14; p14 = p15; p15 = temp; }
			if (comparisonPointer(p12, p14) < 0) { temp = p12; p12 = p14; p14 = temp; }
			if (comparisonPointer(p13, p15) < 0) { temp = p13; p13 = p15; p15 = temp; }
			if (comparisonPointer(p13, p14) < 0) { temp = p13; p13 = p14; p14 = temp; }
			if (comparisonPointer(p8, p12) < 0) { temp = p8; p8 = p12; p12 = temp; }
			if (comparisonPointer(p9, p13) < 0) { temp = p9; p9 = p13; p13 = temp; }
			if (comparisonPointer(p9, p12) < 0) { temp = p9; p9 = p12; p12 = temp; }
			if (comparisonPointer(p10, p14) < 0) { temp = p10; p10 = p14; p14 = temp; }
			if (comparisonPointer(p11, p15) < 0) { temp = p11; p11 = p15; p15 = temp; }
			if (comparisonPointer(p11, p14) < 0) { temp = p11; p11 = p14; p14 = temp; }
			if (comparisonPointer(p10, p12) < 0) { temp = p10; p10 = p12; p12 = temp; }
			if (comparisonPointer(p11, p13) < 0) { temp = p11; p11 = p13; p13 = temp; }
			if (comparisonPointer(p11, p12) < 0) { temp = p11; p11 = p12; p12 = temp; }
			if (comparisonPointer(p0, p8) < 0) { temp = p0; p0 = p8; p8 = temp; }
			if (comparisonPointer(p1, p9) < 0) { temp = p1; p1 = p9; p9 = temp; }
			if (comparisonPointer(p1, p8) < 0) { temp = p1; p1 = p8; p8 = temp; }
			if (comparisonPointer(p2, p10) < 0) { temp = p2; p2 = p10; p10 = temp; }
			if (comparisonPointer(p3, p11) < 0) { temp = p3; p3 = p11; p11 = temp; }
			if (comparisonPointer(p3, p10) < 0) { temp = p3; p3 = p10; p10 = temp; }
			if (comparisonPointer(p2, p8) < 0) { temp = p2; p2 = p8; p8 = temp; }
			if (comparisonPointer(p3, p9) < 0) { temp = p3; p3 = p9; p9 = temp; }
			if (comparisonPointer(p3, p8) < 0) { temp = p3; p3 = p8; p8 = temp; }
			if (comparisonPointer(p4, p12) < 0) { temp = p4; p4 = p12; p12 = temp; }
			if (comparisonPointer(p5, p13) < 0) { temp = p5; p5 = p13; p13 = temp; }
			if (comparisonPointer(p5, p12) < 0) { temp = p5; p5 = p12; p12 = temp; }
			if (comparisonPointer(p6, p14) < 0) { temp = p6; p6 = p14; p14 = temp; }
			if (comparisonPointer(p7, p15) < 0) { temp = p7; p7 = p15; p15 = temp; }
			if (comparisonPointer(p7, p14) < 0) { temp = p7; p7 = p14; p14 = temp; }
			if (comparisonPointer(p6, p12) < 0) { temp = p6; p6 = p12; p12 = temp; }
			if (comparisonPointer(p7, p13) < 0) { temp = p7; p7 = p13; p13 = temp; }
			if (comparisonPointer(p7, p12) < 0) { temp = p7; p7 = p12; p12 = temp; }
			if (comparisonPointer(p4, p8) < 0) { temp = p4; p4 = p8; p8 = temp; }
			if (comparisonPointer(p5, p9) < 0) { temp = p5; p5 = p9; p9 = temp; }
			if (comparisonPointer(p5, p8) < 0) { temp = p5; p5 = p8; p8 = temp; }
			if (comparisonPointer(p6, p10) < 0) { temp = p6; p6 = p10; p10 = temp; }
			if (comparisonPointer(p7, p11) < 0) { temp = p7; p7 = p11; p11 = temp; }
			if (comparisonPointer(p7, p10) < 0) { temp = p7; p7 = p10; p10 = temp; }
			if (comparisonPointer(p6, p8) < 0) { temp = p6; p6 = p8; p8 = temp; }
			if (comparisonPointer(p7, p9) < 0) { temp = p7; p7 = p9; p9 = temp; }
			if (comparisonPointer(p7, p8) < 0) { temp = p7; p7 = p8; p8 = temp; }
			if (comparisonPointer(p16, p17) < 0) { temp = p16; p16 = p17; p17 = temp; }
			if (comparisonPointer(p18, p19) < 0) { temp = p18; p18 = p19; p19 = temp; }
			if (comparisonPointer(p16, p18) < 0) { temp = p16; p16 = p18; p18 = temp; }
			if (comparisonPointer(p17, p19) < 0) { temp = p17; p17 = p19; p19 = temp; }
			if (comparisonPointer(p17, p18) < 0) { temp = p17; p17 = p18; p18 = temp; }
			if (comparisonPointer(p20, p21) < 0) { temp = p20; p20 = p21; p21 = temp; }
			if (comparisonPointer(p22, p23) < 0) { temp = p22; p22 = p23; p23 = temp; }
			if (comparisonPointer(p20, p22) < 0) { temp = p20; p20 = p22; p22 = temp; }
			if (comparisonPointer(p21, p23) < 0) { temp = p21; p21 = p23; p23 = temp; }
			if (comparisonPointer(p21, p22) < 0) { temp = p21; p21 = p22; p22 = temp; }
			if (comparisonPointer(p16, p20) < 0) { temp = p16; p16 = p20; p20 = temp; }
			if (comparisonPointer(p17, p21) < 0) { temp = p17; p17 = p21; p21 = temp; }
			if (comparisonPointer(p17, p20) < 0) { temp = p17; p17 = p20; p20 = temp; }
			if (comparisonPointer(p18, p22) < 0) { temp = p18; p18 = p22; p22 = temp; }
			if (comparisonPointer(p19, p23) < 0) { temp = p19; p19 = p23; p23 = temp; }
			if (comparisonPointer(p19, p22) < 0) { temp = p19; p19 = p22; p22 = temp; }
			if (comparisonPointer(p18, p20) < 0) { temp = p18; p18 = p20; p20 = temp; }
			if (comparisonPointer(p19, p21) < 0) { temp = p19; p19 = p21; p21 = temp; }
			if (comparisonPointer(p19, p20) < 0) { temp = p19; p19 = p20; p20 = temp; }
			if (comparisonPointer(p24, p25) < 0) { temp = p24; p24 = p25; p25 = temp; }
			if (comparisonPointer(p26, p27) < 0) { temp = p26; p26 = p27; p27 = temp; }
			if (comparisonPointer(p24, p26) < 0) { temp = p24; p24 = p26; p26 = temp; }
			if (comparisonPointer(p25, p27) < 0) { temp = p25; p25 = p27; p27 = temp; }
			if (comparisonPointer(p25, p26) < 0) { temp = p25; p25 = p26; p26 = temp; }
			if (comparisonPointer(p28, p29) < 0) { temp = p28; p28 = p29; p29 = temp; }
			if (comparisonPointer(p30, p31) < 0) { temp = p30; p30 = p31; p31 = temp; }
			if (comparisonPointer(p28, p30) < 0) { temp = p28; p28 = p30; p30 = temp; }
			if (comparisonPointer(p29, p31) < 0) { temp = p29; p29 = p31; p31 = temp; }
			if (comparisonPointer(p29, p30) < 0) { temp = p29; p29 = p30; p30 = temp; }
			if (comparisonPointer(p24, p28) < 0) { temp = p24; p24 = p28; p28 = temp; }
			if (comparisonPointer(p25, p29) < 0) { temp = p25; p25 = p29; p29 = temp; }
			if (comparisonPointer(p25, p28) < 0) { temp = p25; p25 = p28; p28 = temp; }
			if (comparisonPointer(p26, p30) < 0) { temp = p26; p26 = p30; p30 = temp; }
			if (comparisonPointer(p27, p31) < 0) { temp = p27; p27 = p31; p31 = temp; }
			if (comparisonPointer(p27, p30) < 0) { temp = p27; p27 = p30; p30 = temp; }
			if (comparisonPointer(p26, p28) < 0) { temp = p26; p26 = p28; p28 = temp; }
			if (comparisonPointer(p27, p29) < 0) { temp = p27; p27 = p29; p29 = temp; }
			if (comparisonPointer(p27, p28) < 0) { temp = p27; p27 = p28; p28 = temp; }
			if (comparisonPointer(p16, p24) < 0) { temp = p16; p16 = p24; p24 = temp; }
			if (comparisonPointer(p17, p25) < 0) { temp = p17; p17 = p25; p25 = temp; }
			if (comparisonPointer(p17, p24) < 0) { temp = p17; p17 = p24; p24 = temp; }
			if (comparisonPointer(p18, p26) < 0) { temp = p18; p18 = p26; p26 = temp; }
			if (comparisonPointer(p19, p27) < 0) { temp = p19; p19 = p27; p27 = temp; }
			if (comparisonPointer(p19, p26) < 0) { temp = p19; p19 = p26; p26 = temp; }
			if (comparisonPointer(p18, p24) < 0) { temp = p18; p18 = p24; p24 = temp; }
			if (comparisonPointer(p19, p25) < 0) { temp = p19; p19 = p25; p25 = temp; }
			if (comparisonPointer(p19, p24) < 0) { temp = p19; p19 = p24; p24 = temp; }
			if (comparisonPointer(p20, p28) < 0) { temp = p20; p20 = p28; p28 = temp; }
			if (comparisonPointer(p21, p29) < 0) { temp = p21; p21 = p29; p29 = temp; }
			if (comparisonPointer(p21, p28) < 0) { temp = p21; p21 = p28; p28 = temp; }
			if (comparisonPointer(p22, p30) < 0) { temp = p22; p22 = p30; p30 = temp; }
			if (comparisonPointer(p23, p31) < 0) { temp = p23; p23 = p31; p31 = temp; }
			if (comparisonPointer(p23, p30) < 0) { temp = p23; p23 = p30; p30 = temp; }
			if (comparisonPointer(p22, p28) < 0) { temp = p22; p22 = p28; p28 = temp; }
			if (comparisonPointer(p23, p29) < 0) { temp = p23; p23 = p29; p29 = temp; }
			if (comparisonPointer(p23, p28) < 0) { temp = p23; p23 = p28; p28 = temp; }
			if (comparisonPointer(p20, p24) < 0) { temp = p20; p20 = p24; p24 = temp; }
			if (comparisonPointer(p21, p25) < 0) { temp = p21; p21 = p25; p25 = temp; }
			if (comparisonPointer(p21, p24) < 0) { temp = p21; p21 = p24; p24 = temp; }
			if (comparisonPointer(p22, p26) < 0) { temp = p22; p22 = p26; p26 = temp; }
			if (comparisonPointer(p23, p27) < 0) { temp = p23; p23 = p27; p27 = temp; }
			if (comparisonPointer(p23, p26) < 0) { temp = p23; p23 = p26; p26 = temp; }
			if (comparisonPointer(p22, p24) < 0) { temp = p22; p22 = p24; p24 = temp; }
			if (comparisonPointer(p23, p25) < 0) { temp = p23; p23 = p25; p25 = temp; }
			if (comparisonPointer(p23, p24) < 0) { temp = p23; p23 = p24; p24 = temp; }
			if (comparisonPointer(p0, p16) < 0) { temp = p0; p0 = p16; p16 = temp; }
			if (comparisonPointer(p1, p17) < 0) { temp = p1; p1 = p17; p17 = temp; }
			if (comparisonPointer(p1, p16) < 0) { temp = p1; p1 = p16; p16 = temp; }
			if (comparisonPointer(p2, p18) < 0) { temp = p2; p2 = p18; p18 = temp; }
			if (comparisonPointer(p3, p19) < 0) { temp = p3; p3 = p19; p19 = temp; }
			if (comparisonPointer(p3, p18) < 0) { temp = p3; p3 = p18; p18 = temp; }
			if (comparisonPointer(p2, p16) < 0) { temp = p2; p2 = p16; p16 = temp; }
			if (comparisonPointer(p3, p17) < 0) { temp = p3; p3 = p17; p17 = temp; }
			if (comparisonPointer(p3, p16) < 0) { temp = p3; p3 = p16; p16 = temp; }
			if (comparisonPointer(p4, p20) < 0) { temp = p4; p4 = p20; p20 = temp; }
			if (comparisonPointer(p5, p21) < 0) { temp = p5; p5 = p21; p21 = temp; }
			if (comparisonPointer(p5, p20) < 0) { temp = p5; p5 = p20; p20 = temp; }
			if (comparisonPointer(p6, p22) < 0) { temp = p6; p6 = p22; p22 = temp; }
			if (comparisonPointer(p7, p23) < 0) { temp = p7; p7 = p23; p23 = temp; }
			if (comparisonPointer(p7, p22) < 0) { temp = p7; p7 = p22; p22 = temp; }
			if (comparisonPointer(p6, p20) < 0) { temp = p6; p6 = p20; p20 = temp; }
			if (comparisonPointer(p7, p21) < 0) { temp = p7; p7 = p21; p21 = temp; }
			if (comparisonPointer(p7, p20) < 0) { temp = p7; p7 = p20; p20 = temp; }
			if (comparisonPointer(p4, p16) < 0) { temp = p4; p4 = p16; p16 = temp; }
			if (comparisonPointer(p5, p17) < 0) { temp = p5; p5 = p17; p17 = temp; }
			if (comparisonPointer(p5, p16) < 0) { temp = p5; p5 = p16; p16 = temp; }
			if (comparisonPointer(p6, p18) < 0) { temp = p6; p6 = p18; p18 = temp; }
			if (comparisonPointer(p7, p19) < 0) { temp = p7; p7 = p19; p19 = temp; }
			if (comparisonPointer(p7, p18) < 0) { temp = p7; p7 = p18; p18 = temp; }
			if (comparisonPointer(p6, p16) < 0) { temp = p6; p6 = p16; p16 = temp; }
			if (comparisonPointer(p7, p17) < 0) { temp = p7; p7 = p17; p17 = temp; }
			if (comparisonPointer(p7, p16) < 0) { temp = p7; p7 = p16; p16 = temp; }
			if (comparisonPointer(p8, p24) < 0) { temp = p8; p8 = p24; p24 = temp; }
			if (comparisonPointer(p9, p25) < 0) { temp = p9; p9 = p25; p25 = temp; }
			if (comparisonPointer(p9, p24) < 0) { temp = p9; p9 = p24; p24 = temp; }
			if (comparisonPointer(p10, p26) < 0) { temp = p10; p10 = p26; p26 = temp; }
			if (comparisonPointer(p11, p27) < 0) { temp = p11; p11 = p27; p27 = temp; }
			if (comparisonPointer(p11, p26) < 0) { temp = p11; p11 = p26; p26 = temp; }
			if (comparisonPointer(p10, p24) < 0) { temp = p10; p10 = p24; p24 = temp; }
			if (comparisonPointer(p11, p25) < 0) { temp = p11; p11 = p25; p25 = temp; }
			if (comparisonPointer(p11, p24) < 0) { temp = p11; p11 = p24; p24 = temp; }
			if (comparisonPointer(p12, p28) < 0) { temp = p12; p12 = p28; p28 = temp; }
			if (comparisonPointer(p13, p29) < 0) { temp = p13; p13 = p29; p29 = temp; }
			if (comparisonPointer(p13, p28) < 0) { temp = p13; p13 = p28; p28 = temp; }
			if (comparisonPointer(p14, p30) < 0) { temp = p14; p14 = p30; p30 = temp; }
			if (comparisonPointer(p15, p31) < 0) { temp = p15; p15 = p31; p31 = temp; }
			if (comparisonPointer(p15, p30) < 0) { temp = p15; p15 = p30; p30 = temp; }
			if (comparisonPointer(p14, p28) < 0) { temp = p14; p14 = p28; p28 = temp; }
			if (comparisonPointer(p15, p29) < 0) { temp = p15; p15 = p29; p29 = temp; }
			if (comparisonPointer(p15, p28) < 0) { temp = p15; p15 = p28; p28 = temp; }
			if (comparisonPointer(p12, p24) < 0) { temp = p12; p12 = p24; p24 = temp; }
			if (comparisonPointer(p13, p25) < 0) { temp = p13; p13 = p25; p25 = temp; }
			if (comparisonPointer(p13, p24) < 0) { temp = p13; p13 = p24; p24 = temp; }
			if (comparisonPointer(p14, p26) < 0) { temp = p14; p14 = p26; p26 = temp; }
			if (comparisonPointer(p15, p27) < 0) { temp = p15; p15 = p27; p27 = temp; }
			if (comparisonPointer(p15, p26) < 0) { temp = p15; p15 = p26; p26 = temp; }
			if (comparisonPointer(p14, p24) < 0) { temp = p14; p14 = p24; p24 = temp; }
			if (comparisonPointer(p15, p25) < 0) { temp = p15; p15 = p25; p25 = temp; }
			if (comparisonPointer(p15, p24) < 0) { temp = p15; p15 = p24; p24 = temp; }
			if (comparisonPointer(p8, p16) < 0) { temp = p8; p8 = p16; p16 = temp; }
			if (comparisonPointer(p9, p17) < 0) { temp = p9; p9 = p17; p17 = temp; }
			if (comparisonPointer(p9, p16) < 0) { temp = p9; p9 = p16; p16 = temp; }
			if (comparisonPointer(p10, p18) < 0) { temp = p10; p10 = p18; p18 = temp; }
			if (comparisonPointer(p11, p19) < 0) { temp = p11; p11 = p19; p19 = temp; }
			if (comparisonPointer(p11, p18) < 0) { temp = p11; p11 = p18; p18 = temp; }
			if (comparisonPointer(p10, p16) < 0) { temp = p10; p10 = p16; p16 = temp; }
			if (comparisonPointer(p11, p17) < 0) { temp = p11; p11 = p17; p17 = temp; }
			if (comparisonPointer(p11, p16) < 0) { temp = p11; p11 = p16; p16 = temp; }
			if (comparisonPointer(p12, p20) < 0) { temp = p12; p12 = p20; p20 = temp; }
			if (comparisonPointer(p13, p21) < 0) { temp = p13; p13 = p21; p21 = temp; }
			if (comparisonPointer(p13, p20) < 0) { temp = p13; p13 = p20; p20 = temp; }
			if (comparisonPointer(p14, p22) < 0) { temp = p14; p14 = p22; p22 = temp; }
			if (comparisonPointer(p15, p23) < 0) { temp = p15; p15 = p23; p23 = temp; }
			if (comparisonPointer(p15, p22) < 0) { temp = p15; p15 = p22; p22 = temp; }
			if (comparisonPointer(p14, p20) < 0) { temp = p14; p14 = p20; p20 = temp; }
			if (comparisonPointer(p15, p21) < 0) { temp = p15; p15 = p21; p21 = temp; }
			if (comparisonPointer(p15, p20) < 0) { temp = p15; p15 = p20; p20 = temp; }
			if (comparisonPointer(p12, p16) < 0) { temp = p12; p12 = p16; p16 = temp; }
			if (comparisonPointer(p13, p17) < 0) { temp = p13; p13 = p17; p17 = temp; }
			if (comparisonPointer(p13, p16) < 0) { temp = p13; p13 = p16; p16 = temp; }
			if (comparisonPointer(p14, p18) < 0) { temp = p14; p14 = p18; p18 = temp; }
			if (comparisonPointer(p15, p19) < 0) { temp = p15; p15 = p19; p19 = temp; }
			if (comparisonPointer(p15, p18) < 0) { temp = p15; p15 = p18; p18 = temp; }
			if (comparisonPointer(p14, p16) < 0) { temp = p14; p14 = p16; p16 = temp; }
			if (comparisonPointer(p15, p17) < 0) { temp = p15; p15 = p17; p17 = temp; }
			if (comparisonPointer(p15, p16) < 0) { temp = p15; p15 = p16; p16 = temp; }
		}

		/// <summary>
		/// Sorts a collection of specified number of elements in descending order using the specified function pointer.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="length">the length of the collection</param>
		/// <param name="comparisonPointer">The function pointer to use when comparing elements.</param>
		/// <exception cref="ArgumentOutOfRangeException">collection length is not between <see cref="MinLength"/> and <see cref="MaxLength"/></exception>
		public unsafe static void SortDescending<T>(ref T p0, in int length, delegate* managed<T, T, int> comparisonPointer)
		{
			switch (length)
			{
				case 2: Sort2Descending(ref p0, comparisonPointer); break;
				case 3: Sort3Descending(ref p0, comparisonPointer); break;
				case 4: Sort4Descending(ref p0, comparisonPointer); break;
				case 5: Sort5Descending(ref p0, comparisonPointer); break;
				case 6: Sort6Descending(ref p0, comparisonPointer); break;
				case 7: Sort7Descending(ref p0, comparisonPointer); break;
				case 8: Sort8Descending(ref p0, comparisonPointer); break;
				case 9: Sort9Descending(ref p0, comparisonPointer); break;
				case 10: Sort10Descending(ref p0, comparisonPointer); break;
				case 11: Sort11Descending(ref p0, comparisonPointer); break;
				case 12: Sort12Descending(ref p0, comparisonPointer); break;
				case 13: Sort13Descending(ref p0, comparisonPointer); break;
				case 14: Sort14Descending(ref p0, comparisonPointer); break;
				case 15: Sort15Descending(ref p0, comparisonPointer); break;
				case 16: Sort16Descending(ref p0, comparisonPointer); break;
				case 17: Sort17Descending(ref p0, comparisonPointer); break;
				case 18: Sort18Descending(ref p0, comparisonPointer); break;
				case 19: Sort19Descending(ref p0, comparisonPointer); break;
				case 20: Sort20Descending(ref p0, comparisonPointer); break;
				case 21: Sort21Descending(ref p0, comparisonPointer); break;
				case 22: Sort22Descending(ref p0, comparisonPointer); break;
				case 23: Sort23Descending(ref p0, comparisonPointer); break;
				case 24: Sort24Descending(ref p0, comparisonPointer); break;
				case 25: Sort25Descending(ref p0, comparisonPointer); break;
				case 26: Sort26Descending(ref p0, comparisonPointer); break;
				case 27: Sort27Descending(ref p0, comparisonPointer); break;
				case 28: Sort28Descending(ref p0, comparisonPointer); break;
				case 29: Sort29Descending(ref p0, comparisonPointer); break;
				case 30: Sort30Descending(ref p0, comparisonPointer); break;
				case 31: Sort31Descending(ref p0, comparisonPointer); break;
				case 32: Sort32Descending(ref p0, comparisonPointer); break;
				default: throw new ArgumentOutOfRangeException(nameof(length), $"Sorting network length `{length}` must be between `{MinLength}` and `{MaxLength}`.");
			}
		}
	}
}