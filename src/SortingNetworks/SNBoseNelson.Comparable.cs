namespace SortingNetworks
{
	using System;
	using System.Runtime.CompilerServices;

	partial class SNBoseNelson
	{
		/// <summary>
		/// Sorts a collection of 2 elements in ascending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort2Ascending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);

			SwapIfGreater(ref p0, ref p1);
		}

		/// <summary>
		/// Sorts a collection of 2 elements in descending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort2Descending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);

			SwapIfLesser(ref p0, ref p1);
		}

		/// <summary>
		/// Sorts a collection of 3 elements in ascending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort3Ascending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);

			SwapIfGreater(ref p1, ref p2);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p0, ref p1);
		}

		/// <summary>
		/// Sorts a collection of 3 elements in descending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort3Descending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);

			SwapIfLesser(ref p1, ref p2);
			SwapIfLesser(ref p0, ref p2);
			SwapIfLesser(ref p0, ref p1);
		}

		/// <summary>
		/// Sorts a collection of 4 elements in ascending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
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

		/// <summary>
		/// Sorts a collection of 4 elements in descending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort4Descending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);

			SwapIfLesser(ref p0, ref p1);
			SwapIfLesser(ref p2, ref p3);
			SwapIfLesser(ref p0, ref p2);
			SwapIfLesser(ref p1, ref p3);
			SwapIfLesser(ref p1, ref p2);
		}

		/// <summary>
		/// Sorts a collection of 5 elements in ascending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort5Ascending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);

			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p3, ref p4);
			SwapIfGreater(ref p2, ref p4);
			SwapIfGreater(ref p2, ref p3);
			SwapIfGreater(ref p0, ref p3);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p1, ref p4);
			SwapIfGreater(ref p1, ref p3);
			SwapIfGreater(ref p1, ref p2);
		}

		/// <summary>
		/// Sorts a collection of 5 elements in descending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort5Descending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);

			SwapIfLesser(ref p0, ref p1);
			SwapIfLesser(ref p3, ref p4);
			SwapIfLesser(ref p2, ref p4);
			SwapIfLesser(ref p2, ref p3);
			SwapIfLesser(ref p0, ref p3);
			SwapIfLesser(ref p0, ref p2);
			SwapIfLesser(ref p1, ref p4);
			SwapIfLesser(ref p1, ref p3);
			SwapIfLesser(ref p1, ref p2);
		}

		/// <summary>
		/// Sorts a collection of 6 elements in ascending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort6Ascending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);

			SwapIfGreater(ref p1, ref p2);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p4, ref p5);
			SwapIfGreater(ref p3, ref p5);
			SwapIfGreater(ref p3, ref p4);
			SwapIfGreater(ref p0, ref p4);
			SwapIfGreater(ref p0, ref p3);
			SwapIfGreater(ref p1, ref p5);
			SwapIfGreater(ref p2, ref p5);
			SwapIfGreater(ref p1, ref p3);
			SwapIfGreater(ref p2, ref p4);
			SwapIfGreater(ref p2, ref p3);
		}

		/// <summary>
		/// Sorts a collection of 6 elements in descending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort6Descending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);

			SwapIfLesser(ref p1, ref p2);
			SwapIfLesser(ref p0, ref p2);
			SwapIfLesser(ref p0, ref p1);
			SwapIfLesser(ref p4, ref p5);
			SwapIfLesser(ref p3, ref p5);
			SwapIfLesser(ref p3, ref p4);
			SwapIfLesser(ref p0, ref p4);
			SwapIfLesser(ref p0, ref p3);
			SwapIfLesser(ref p1, ref p5);
			SwapIfLesser(ref p2, ref p5);
			SwapIfLesser(ref p1, ref p3);
			SwapIfLesser(ref p2, ref p4);
			SwapIfLesser(ref p2, ref p3);
		}

		/// <summary>
		/// Sorts a collection of 7 elements in ascending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort7Ascending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);

			SwapIfGreater(ref p1, ref p2);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p3, ref p4);
			SwapIfGreater(ref p5, ref p6);
			SwapIfGreater(ref p3, ref p5);
			SwapIfGreater(ref p4, ref p6);
			SwapIfGreater(ref p4, ref p5);
			SwapIfGreater(ref p0, ref p4);
			SwapIfGreater(ref p0, ref p3);
			SwapIfGreater(ref p1, ref p5);
			SwapIfGreater(ref p2, ref p6);
			SwapIfGreater(ref p2, ref p5);
			SwapIfGreater(ref p1, ref p3);
			SwapIfGreater(ref p2, ref p4);
			SwapIfGreater(ref p2, ref p3);
		}

		/// <summary>
		/// Sorts a collection of 7 elements in descending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort7Descending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);

			SwapIfLesser(ref p1, ref p2);
			SwapIfLesser(ref p0, ref p2);
			SwapIfLesser(ref p0, ref p1);
			SwapIfLesser(ref p3, ref p4);
			SwapIfLesser(ref p5, ref p6);
			SwapIfLesser(ref p3, ref p5);
			SwapIfLesser(ref p4, ref p6);
			SwapIfLesser(ref p4, ref p5);
			SwapIfLesser(ref p0, ref p4);
			SwapIfLesser(ref p0, ref p3);
			SwapIfLesser(ref p1, ref p5);
			SwapIfLesser(ref p2, ref p6);
			SwapIfLesser(ref p2, ref p5);
			SwapIfLesser(ref p1, ref p3);
			SwapIfLesser(ref p2, ref p4);
			SwapIfLesser(ref p2, ref p3);
		}

		/// <summary>
		/// Sorts a collection of 8 elements in ascending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort8Ascending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);

			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p2, ref p3);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p1, ref p3);
			SwapIfGreater(ref p1, ref p2);
			SwapIfGreater(ref p4, ref p5);
			SwapIfGreater(ref p6, ref p7);
			SwapIfGreater(ref p4, ref p6);
			SwapIfGreater(ref p5, ref p7);
			SwapIfGreater(ref p5, ref p6);
			SwapIfGreater(ref p0, ref p4);
			SwapIfGreater(ref p1, ref p5);
			SwapIfGreater(ref p1, ref p4);
			SwapIfGreater(ref p2, ref p6);
			SwapIfGreater(ref p3, ref p7);
			SwapIfGreater(ref p3, ref p6);
			SwapIfGreater(ref p2, ref p4);
			SwapIfGreater(ref p3, ref p5);
			SwapIfGreater(ref p3, ref p4);
		}

		/// <summary>
		/// Sorts a collection of 8 elements in descending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort8Descending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);

			SwapIfLesser(ref p0, ref p1);
			SwapIfLesser(ref p2, ref p3);
			SwapIfLesser(ref p0, ref p2);
			SwapIfLesser(ref p1, ref p3);
			SwapIfLesser(ref p1, ref p2);
			SwapIfLesser(ref p4, ref p5);
			SwapIfLesser(ref p6, ref p7);
			SwapIfLesser(ref p4, ref p6);
			SwapIfLesser(ref p5, ref p7);
			SwapIfLesser(ref p5, ref p6);
			SwapIfLesser(ref p0, ref p4);
			SwapIfLesser(ref p1, ref p5);
			SwapIfLesser(ref p1, ref p4);
			SwapIfLesser(ref p2, ref p6);
			SwapIfLesser(ref p3, ref p7);
			SwapIfLesser(ref p3, ref p6);
			SwapIfLesser(ref p2, ref p4);
			SwapIfLesser(ref p3, ref p5);
			SwapIfLesser(ref p3, ref p4);
		}

		/// <summary>
		/// Sorts a collection of 9 elements in ascending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort9Ascending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);

			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p2, ref p3);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p1, ref p3);
			SwapIfGreater(ref p1, ref p2);
			SwapIfGreater(ref p4, ref p5);
			SwapIfGreater(ref p7, ref p8);
			SwapIfGreater(ref p6, ref p8);
			SwapIfGreater(ref p6, ref p7);
			SwapIfGreater(ref p4, ref p7);
			SwapIfGreater(ref p4, ref p6);
			SwapIfGreater(ref p5, ref p8);
			SwapIfGreater(ref p5, ref p7);
			SwapIfGreater(ref p5, ref p6);
			SwapIfGreater(ref p0, ref p5);
			SwapIfGreater(ref p0, ref p4);
			SwapIfGreater(ref p1, ref p6);
			SwapIfGreater(ref p1, ref p5);
			SwapIfGreater(ref p1, ref p4);
			SwapIfGreater(ref p2, ref p7);
			SwapIfGreater(ref p3, ref p8);
			SwapIfGreater(ref p3, ref p7);
			SwapIfGreater(ref p2, ref p5);
			SwapIfGreater(ref p2, ref p4);
			SwapIfGreater(ref p3, ref p6);
			SwapIfGreater(ref p3, ref p5);
			SwapIfGreater(ref p3, ref p4);
		}

		/// <summary>
		/// Sorts a collection of 9 elements in descending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort9Descending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);

			SwapIfLesser(ref p0, ref p1);
			SwapIfLesser(ref p2, ref p3);
			SwapIfLesser(ref p0, ref p2);
			SwapIfLesser(ref p1, ref p3);
			SwapIfLesser(ref p1, ref p2);
			SwapIfLesser(ref p4, ref p5);
			SwapIfLesser(ref p7, ref p8);
			SwapIfLesser(ref p6, ref p8);
			SwapIfLesser(ref p6, ref p7);
			SwapIfLesser(ref p4, ref p7);
			SwapIfLesser(ref p4, ref p6);
			SwapIfLesser(ref p5, ref p8);
			SwapIfLesser(ref p5, ref p7);
			SwapIfLesser(ref p5, ref p6);
			SwapIfLesser(ref p0, ref p5);
			SwapIfLesser(ref p0, ref p4);
			SwapIfLesser(ref p1, ref p6);
			SwapIfLesser(ref p1, ref p5);
			SwapIfLesser(ref p1, ref p4);
			SwapIfLesser(ref p2, ref p7);
			SwapIfLesser(ref p3, ref p8);
			SwapIfLesser(ref p3, ref p7);
			SwapIfLesser(ref p2, ref p5);
			SwapIfLesser(ref p2, ref p4);
			SwapIfLesser(ref p3, ref p6);
			SwapIfLesser(ref p3, ref p5);
			SwapIfLesser(ref p3, ref p4);
		}

		/// <summary>
		/// Sorts a collection of 10 elements in ascending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort10Ascending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);

			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p3, ref p4);
			SwapIfGreater(ref p2, ref p4);
			SwapIfGreater(ref p2, ref p3);
			SwapIfGreater(ref p0, ref p3);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p1, ref p4);
			SwapIfGreater(ref p1, ref p3);
			SwapIfGreater(ref p1, ref p2);
			SwapIfGreater(ref p5, ref p6);
			SwapIfGreater(ref p8, ref p9);
			SwapIfGreater(ref p7, ref p9);
			SwapIfGreater(ref p7, ref p8);
			SwapIfGreater(ref p5, ref p8);
			SwapIfGreater(ref p5, ref p7);
			SwapIfGreater(ref p6, ref p9);
			SwapIfGreater(ref p6, ref p8);
			SwapIfGreater(ref p6, ref p7);
			SwapIfGreater(ref p0, ref p6);
			SwapIfGreater(ref p0, ref p5);
			SwapIfGreater(ref p1, ref p7);
			SwapIfGreater(ref p1, ref p6);
			SwapIfGreater(ref p1, ref p5);
			SwapIfGreater(ref p2, ref p8);
			SwapIfGreater(ref p3, ref p9);
			SwapIfGreater(ref p4, ref p9);
			SwapIfGreater(ref p3, ref p8);
			SwapIfGreater(ref p4, ref p8);
			SwapIfGreater(ref p2, ref p6);
			SwapIfGreater(ref p2, ref p5);
			SwapIfGreater(ref p3, ref p7);
			SwapIfGreater(ref p4, ref p7);
			SwapIfGreater(ref p3, ref p5);
			SwapIfGreater(ref p4, ref p6);
			SwapIfGreater(ref p4, ref p5);
		}

		/// <summary>
		/// Sorts a collection of 10 elements in descending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort10Descending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);

			SwapIfLesser(ref p0, ref p1);
			SwapIfLesser(ref p3, ref p4);
			SwapIfLesser(ref p2, ref p4);
			SwapIfLesser(ref p2, ref p3);
			SwapIfLesser(ref p0, ref p3);
			SwapIfLesser(ref p0, ref p2);
			SwapIfLesser(ref p1, ref p4);
			SwapIfLesser(ref p1, ref p3);
			SwapIfLesser(ref p1, ref p2);
			SwapIfLesser(ref p5, ref p6);
			SwapIfLesser(ref p8, ref p9);
			SwapIfLesser(ref p7, ref p9);
			SwapIfLesser(ref p7, ref p8);
			SwapIfLesser(ref p5, ref p8);
			SwapIfLesser(ref p5, ref p7);
			SwapIfLesser(ref p6, ref p9);
			SwapIfLesser(ref p6, ref p8);
			SwapIfLesser(ref p6, ref p7);
			SwapIfLesser(ref p0, ref p6);
			SwapIfLesser(ref p0, ref p5);
			SwapIfLesser(ref p1, ref p7);
			SwapIfLesser(ref p1, ref p6);
			SwapIfLesser(ref p1, ref p5);
			SwapIfLesser(ref p2, ref p8);
			SwapIfLesser(ref p3, ref p9);
			SwapIfLesser(ref p4, ref p9);
			SwapIfLesser(ref p3, ref p8);
			SwapIfLesser(ref p4, ref p8);
			SwapIfLesser(ref p2, ref p6);
			SwapIfLesser(ref p2, ref p5);
			SwapIfLesser(ref p3, ref p7);
			SwapIfLesser(ref p4, ref p7);
			SwapIfLesser(ref p3, ref p5);
			SwapIfLesser(ref p4, ref p6);
			SwapIfLesser(ref p4, ref p5);
		}

		/// <summary>
		/// Sorts a collection of 11 elements in ascending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort11Ascending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);
			ref var p10 = ref Unsafe.Add(ref p9, 10);

			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p3, ref p4);
			SwapIfGreater(ref p2, ref p4);
			SwapIfGreater(ref p2, ref p3);
			SwapIfGreater(ref p0, ref p3);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p1, ref p4);
			SwapIfGreater(ref p1, ref p3);
			SwapIfGreater(ref p1, ref p2);
			SwapIfGreater(ref p6, ref p7);
			SwapIfGreater(ref p5, ref p7);
			SwapIfGreater(ref p5, ref p6);
			SwapIfGreater(ref p9, ref p10);
			SwapIfGreater(ref p8, ref p10);
			SwapIfGreater(ref p8, ref p9);
			SwapIfGreater(ref p5, ref p9);
			SwapIfGreater(ref p5, ref p8);
			SwapIfGreater(ref p6, ref p10);
			SwapIfGreater(ref p7, ref p10);
			SwapIfGreater(ref p6, ref p8);
			SwapIfGreater(ref p7, ref p9);
			SwapIfGreater(ref p7, ref p8);
			SwapIfGreater(ref p0, ref p6);
			SwapIfGreater(ref p0, ref p5);
			SwapIfGreater(ref p1, ref p7);
			SwapIfGreater(ref p1, ref p6);
			SwapIfGreater(ref p1, ref p5);
			SwapIfGreater(ref p2, ref p9);
			SwapIfGreater(ref p2, ref p8);
			SwapIfGreater(ref p3, ref p10);
			SwapIfGreater(ref p4, ref p10);
			SwapIfGreater(ref p3, ref p8);
			SwapIfGreater(ref p4, ref p9);
			SwapIfGreater(ref p4, ref p8);
			SwapIfGreater(ref p2, ref p6);
			SwapIfGreater(ref p2, ref p5);
			SwapIfGreater(ref p3, ref p7);
			SwapIfGreater(ref p4, ref p7);
			SwapIfGreater(ref p3, ref p5);
			SwapIfGreater(ref p4, ref p6);
			SwapIfGreater(ref p4, ref p5);
		}

		/// <summary>
		/// Sorts a collection of 11 elements in descending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort11Descending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);
			ref var p10 = ref Unsafe.Add(ref p9, 10);

			SwapIfLesser(ref p0, ref p1);
			SwapIfLesser(ref p3, ref p4);
			SwapIfLesser(ref p2, ref p4);
			SwapIfLesser(ref p2, ref p3);
			SwapIfLesser(ref p0, ref p3);
			SwapIfLesser(ref p0, ref p2);
			SwapIfLesser(ref p1, ref p4);
			SwapIfLesser(ref p1, ref p3);
			SwapIfLesser(ref p1, ref p2);
			SwapIfLesser(ref p6, ref p7);
			SwapIfLesser(ref p5, ref p7);
			SwapIfLesser(ref p5, ref p6);
			SwapIfLesser(ref p9, ref p10);
			SwapIfLesser(ref p8, ref p10);
			SwapIfLesser(ref p8, ref p9);
			SwapIfLesser(ref p5, ref p9);
			SwapIfLesser(ref p5, ref p8);
			SwapIfLesser(ref p6, ref p10);
			SwapIfLesser(ref p7, ref p10);
			SwapIfLesser(ref p6, ref p8);
			SwapIfLesser(ref p7, ref p9);
			SwapIfLesser(ref p7, ref p8);
			SwapIfLesser(ref p0, ref p6);
			SwapIfLesser(ref p0, ref p5);
			SwapIfLesser(ref p1, ref p7);
			SwapIfLesser(ref p1, ref p6);
			SwapIfLesser(ref p1, ref p5);
			SwapIfLesser(ref p2, ref p9);
			SwapIfLesser(ref p2, ref p8);
			SwapIfLesser(ref p3, ref p10);
			SwapIfLesser(ref p4, ref p10);
			SwapIfLesser(ref p3, ref p8);
			SwapIfLesser(ref p4, ref p9);
			SwapIfLesser(ref p4, ref p8);
			SwapIfLesser(ref p2, ref p6);
			SwapIfLesser(ref p2, ref p5);
			SwapIfLesser(ref p3, ref p7);
			SwapIfLesser(ref p4, ref p7);
			SwapIfLesser(ref p3, ref p5);
			SwapIfLesser(ref p4, ref p6);
			SwapIfLesser(ref p4, ref p5);
		}

		/// <summary>
		/// Sorts a collection of 12 elements in ascending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort12Ascending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);
			ref var p10 = ref Unsafe.Add(ref p9, 10);
			ref var p11 = ref Unsafe.Add(ref p10, 11);

			SwapIfGreater(ref p1, ref p2);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p4, ref p5);
			SwapIfGreater(ref p3, ref p5);
			SwapIfGreater(ref p3, ref p4);
			SwapIfGreater(ref p0, ref p4);
			SwapIfGreater(ref p0, ref p3);
			SwapIfGreater(ref p1, ref p5);
			SwapIfGreater(ref p2, ref p5);
			SwapIfGreater(ref p1, ref p3);
			SwapIfGreater(ref p2, ref p4);
			SwapIfGreater(ref p2, ref p3);
			SwapIfGreater(ref p7, ref p8);
			SwapIfGreater(ref p6, ref p8);
			SwapIfGreater(ref p6, ref p7);
			SwapIfGreater(ref p10, ref p11);
			SwapIfGreater(ref p9, ref p11);
			SwapIfGreater(ref p9, ref p10);
			SwapIfGreater(ref p6, ref p10);
			SwapIfGreater(ref p6, ref p9);
			SwapIfGreater(ref p7, ref p11);
			SwapIfGreater(ref p8, ref p11);
			SwapIfGreater(ref p7, ref p9);
			SwapIfGreater(ref p8, ref p10);
			SwapIfGreater(ref p8, ref p9);
			SwapIfGreater(ref p0, ref p7);
			SwapIfGreater(ref p0, ref p6);
			SwapIfGreater(ref p1, ref p8);
			SwapIfGreater(ref p2, ref p8);
			SwapIfGreater(ref p1, ref p6);
			SwapIfGreater(ref p2, ref p7);
			SwapIfGreater(ref p2, ref p6);
			SwapIfGreater(ref p3, ref p10);
			SwapIfGreater(ref p3, ref p9);
			SwapIfGreater(ref p4, ref p11);
			SwapIfGreater(ref p5, ref p11);
			SwapIfGreater(ref p4, ref p9);
			SwapIfGreater(ref p5, ref p10);
			SwapIfGreater(ref p5, ref p9);
			SwapIfGreater(ref p3, ref p7);
			SwapIfGreater(ref p3, ref p6);
			SwapIfGreater(ref p4, ref p8);
			SwapIfGreater(ref p5, ref p8);
			SwapIfGreater(ref p4, ref p6);
			SwapIfGreater(ref p5, ref p7);
			SwapIfGreater(ref p5, ref p6);
		}

		/// <summary>
		/// Sorts a collection of 12 elements in descending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort12Descending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);
			ref var p10 = ref Unsafe.Add(ref p9, 10);
			ref var p11 = ref Unsafe.Add(ref p10, 11);

			SwapIfLesser(ref p1, ref p2);
			SwapIfLesser(ref p0, ref p2);
			SwapIfLesser(ref p0, ref p1);
			SwapIfLesser(ref p4, ref p5);
			SwapIfLesser(ref p3, ref p5);
			SwapIfLesser(ref p3, ref p4);
			SwapIfLesser(ref p0, ref p4);
			SwapIfLesser(ref p0, ref p3);
			SwapIfLesser(ref p1, ref p5);
			SwapIfLesser(ref p2, ref p5);
			SwapIfLesser(ref p1, ref p3);
			SwapIfLesser(ref p2, ref p4);
			SwapIfLesser(ref p2, ref p3);
			SwapIfLesser(ref p7, ref p8);
			SwapIfLesser(ref p6, ref p8);
			SwapIfLesser(ref p6, ref p7);
			SwapIfLesser(ref p10, ref p11);
			SwapIfLesser(ref p9, ref p11);
			SwapIfLesser(ref p9, ref p10);
			SwapIfLesser(ref p6, ref p10);
			SwapIfLesser(ref p6, ref p9);
			SwapIfLesser(ref p7, ref p11);
			SwapIfLesser(ref p8, ref p11);
			SwapIfLesser(ref p7, ref p9);
			SwapIfLesser(ref p8, ref p10);
			SwapIfLesser(ref p8, ref p9);
			SwapIfLesser(ref p0, ref p7);
			SwapIfLesser(ref p0, ref p6);
			SwapIfLesser(ref p1, ref p8);
			SwapIfLesser(ref p2, ref p8);
			SwapIfLesser(ref p1, ref p6);
			SwapIfLesser(ref p2, ref p7);
			SwapIfLesser(ref p2, ref p6);
			SwapIfLesser(ref p3, ref p10);
			SwapIfLesser(ref p3, ref p9);
			SwapIfLesser(ref p4, ref p11);
			SwapIfLesser(ref p5, ref p11);
			SwapIfLesser(ref p4, ref p9);
			SwapIfLesser(ref p5, ref p10);
			SwapIfLesser(ref p5, ref p9);
			SwapIfLesser(ref p3, ref p7);
			SwapIfLesser(ref p3, ref p6);
			SwapIfLesser(ref p4, ref p8);
			SwapIfLesser(ref p5, ref p8);
			SwapIfLesser(ref p4, ref p6);
			SwapIfLesser(ref p5, ref p7);
			SwapIfLesser(ref p5, ref p6);
		}

		/// <summary>
		/// Sorts a collection of 13 elements in ascending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort13Ascending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);
			ref var p10 = ref Unsafe.Add(ref p9, 10);
			ref var p11 = ref Unsafe.Add(ref p10, 11);
			ref var p12 = ref Unsafe.Add(ref p11, 12);

			SwapIfGreater(ref p1, ref p2);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p4, ref p5);
			SwapIfGreater(ref p3, ref p5);
			SwapIfGreater(ref p3, ref p4);
			SwapIfGreater(ref p0, ref p4);
			SwapIfGreater(ref p0, ref p3);
			SwapIfGreater(ref p1, ref p5);
			SwapIfGreater(ref p2, ref p5);
			SwapIfGreater(ref p1, ref p3);
			SwapIfGreater(ref p2, ref p4);
			SwapIfGreater(ref p2, ref p3);
			SwapIfGreater(ref p7, ref p8);
			SwapIfGreater(ref p6, ref p8);
			SwapIfGreater(ref p6, ref p7);
			SwapIfGreater(ref p9, ref p10);
			SwapIfGreater(ref p11, ref p12);
			SwapIfGreater(ref p9, ref p11);
			SwapIfGreater(ref p10, ref p12);
			SwapIfGreater(ref p10, ref p11);
			SwapIfGreater(ref p6, ref p10);
			SwapIfGreater(ref p6, ref p9);
			SwapIfGreater(ref p7, ref p11);
			SwapIfGreater(ref p8, ref p12);
			SwapIfGreater(ref p8, ref p11);
			SwapIfGreater(ref p7, ref p9);
			SwapIfGreater(ref p8, ref p10);
			SwapIfGreater(ref p8, ref p9);
			SwapIfGreater(ref p0, ref p7);
			SwapIfGreater(ref p0, ref p6);
			SwapIfGreater(ref p1, ref p8);
			SwapIfGreater(ref p2, ref p9);
			SwapIfGreater(ref p2, ref p8);
			SwapIfGreater(ref p1, ref p6);
			SwapIfGreater(ref p2, ref p7);
			SwapIfGreater(ref p2, ref p6);
			SwapIfGreater(ref p3, ref p11);
			SwapIfGreater(ref p3, ref p10);
			SwapIfGreater(ref p4, ref p12);
			SwapIfGreater(ref p5, ref p12);
			SwapIfGreater(ref p4, ref p10);
			SwapIfGreater(ref p5, ref p11);
			SwapIfGreater(ref p5, ref p10);
			SwapIfGreater(ref p3, ref p7);
			SwapIfGreater(ref p3, ref p6);
			SwapIfGreater(ref p4, ref p8);
			SwapIfGreater(ref p5, ref p9);
			SwapIfGreater(ref p5, ref p8);
			SwapIfGreater(ref p4, ref p6);
			SwapIfGreater(ref p5, ref p7);
			SwapIfGreater(ref p5, ref p6);
		}

		/// <summary>
		/// Sorts a collection of 13 elements in descending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort13Descending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);
			ref var p10 = ref Unsafe.Add(ref p9, 10);
			ref var p11 = ref Unsafe.Add(ref p10, 11);
			ref var p12 = ref Unsafe.Add(ref p11, 12);

			SwapIfLesser(ref p1, ref p2);
			SwapIfLesser(ref p0, ref p2);
			SwapIfLesser(ref p0, ref p1);
			SwapIfLesser(ref p4, ref p5);
			SwapIfLesser(ref p3, ref p5);
			SwapIfLesser(ref p3, ref p4);
			SwapIfLesser(ref p0, ref p4);
			SwapIfLesser(ref p0, ref p3);
			SwapIfLesser(ref p1, ref p5);
			SwapIfLesser(ref p2, ref p5);
			SwapIfLesser(ref p1, ref p3);
			SwapIfLesser(ref p2, ref p4);
			SwapIfLesser(ref p2, ref p3);
			SwapIfLesser(ref p7, ref p8);
			SwapIfLesser(ref p6, ref p8);
			SwapIfLesser(ref p6, ref p7);
			SwapIfLesser(ref p9, ref p10);
			SwapIfLesser(ref p11, ref p12);
			SwapIfLesser(ref p9, ref p11);
			SwapIfLesser(ref p10, ref p12);
			SwapIfLesser(ref p10, ref p11);
			SwapIfLesser(ref p6, ref p10);
			SwapIfLesser(ref p6, ref p9);
			SwapIfLesser(ref p7, ref p11);
			SwapIfLesser(ref p8, ref p12);
			SwapIfLesser(ref p8, ref p11);
			SwapIfLesser(ref p7, ref p9);
			SwapIfLesser(ref p8, ref p10);
			SwapIfLesser(ref p8, ref p9);
			SwapIfLesser(ref p0, ref p7);
			SwapIfLesser(ref p0, ref p6);
			SwapIfLesser(ref p1, ref p8);
			SwapIfLesser(ref p2, ref p9);
			SwapIfLesser(ref p2, ref p8);
			SwapIfLesser(ref p1, ref p6);
			SwapIfLesser(ref p2, ref p7);
			SwapIfLesser(ref p2, ref p6);
			SwapIfLesser(ref p3, ref p11);
			SwapIfLesser(ref p3, ref p10);
			SwapIfLesser(ref p4, ref p12);
			SwapIfLesser(ref p5, ref p12);
			SwapIfLesser(ref p4, ref p10);
			SwapIfLesser(ref p5, ref p11);
			SwapIfLesser(ref p5, ref p10);
			SwapIfLesser(ref p3, ref p7);
			SwapIfLesser(ref p3, ref p6);
			SwapIfLesser(ref p4, ref p8);
			SwapIfLesser(ref p5, ref p9);
			SwapIfLesser(ref p5, ref p8);
			SwapIfLesser(ref p4, ref p6);
			SwapIfLesser(ref p5, ref p7);
			SwapIfLesser(ref p5, ref p6);
		}

		/// <summary>
		/// Sorts a collection of 14 elements in ascending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort14Ascending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);
			ref var p10 = ref Unsafe.Add(ref p9, 10);
			ref var p11 = ref Unsafe.Add(ref p10, 11);
			ref var p12 = ref Unsafe.Add(ref p11, 12);
			ref var p13 = ref Unsafe.Add(ref p12, 13);

			SwapIfGreater(ref p1, ref p2);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p3, ref p4);
			SwapIfGreater(ref p5, ref p6);
			SwapIfGreater(ref p3, ref p5);
			SwapIfGreater(ref p4, ref p6);
			SwapIfGreater(ref p4, ref p5);
			SwapIfGreater(ref p0, ref p4);
			SwapIfGreater(ref p0, ref p3);
			SwapIfGreater(ref p1, ref p5);
			SwapIfGreater(ref p2, ref p6);
			SwapIfGreater(ref p2, ref p5);
			SwapIfGreater(ref p1, ref p3);
			SwapIfGreater(ref p2, ref p4);
			SwapIfGreater(ref p2, ref p3);
			SwapIfGreater(ref p8, ref p9);
			SwapIfGreater(ref p7, ref p9);
			SwapIfGreater(ref p7, ref p8);
			SwapIfGreater(ref p10, ref p11);
			SwapIfGreater(ref p12, ref p13);
			SwapIfGreater(ref p10, ref p12);
			SwapIfGreater(ref p11, ref p13);
			SwapIfGreater(ref p11, ref p12);
			SwapIfGreater(ref p7, ref p11);
			SwapIfGreater(ref p7, ref p10);
			SwapIfGreater(ref p8, ref p12);
			SwapIfGreater(ref p9, ref p13);
			SwapIfGreater(ref p9, ref p12);
			SwapIfGreater(ref p8, ref p10);
			SwapIfGreater(ref p9, ref p11);
			SwapIfGreater(ref p9, ref p10);
			SwapIfGreater(ref p0, ref p8);
			SwapIfGreater(ref p0, ref p7);
			SwapIfGreater(ref p1, ref p9);
			SwapIfGreater(ref p2, ref p10);
			SwapIfGreater(ref p2, ref p9);
			SwapIfGreater(ref p1, ref p7);
			SwapIfGreater(ref p2, ref p8);
			SwapIfGreater(ref p2, ref p7);
			SwapIfGreater(ref p3, ref p11);
			SwapIfGreater(ref p4, ref p12);
			SwapIfGreater(ref p4, ref p11);
			SwapIfGreater(ref p5, ref p13);
			SwapIfGreater(ref p6, ref p13);
			SwapIfGreater(ref p5, ref p11);
			SwapIfGreater(ref p6, ref p12);
			SwapIfGreater(ref p6, ref p11);
			SwapIfGreater(ref p3, ref p7);
			SwapIfGreater(ref p4, ref p8);
			SwapIfGreater(ref p4, ref p7);
			SwapIfGreater(ref p5, ref p9);
			SwapIfGreater(ref p6, ref p10);
			SwapIfGreater(ref p6, ref p9);
			SwapIfGreater(ref p5, ref p7);
			SwapIfGreater(ref p6, ref p8);
			SwapIfGreater(ref p6, ref p7);
		}

		/// <summary>
		/// Sorts a collection of 14 elements in descending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort14Descending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);
			ref var p10 = ref Unsafe.Add(ref p9, 10);
			ref var p11 = ref Unsafe.Add(ref p10, 11);
			ref var p12 = ref Unsafe.Add(ref p11, 12);
			ref var p13 = ref Unsafe.Add(ref p12, 13);

			SwapIfLesser(ref p1, ref p2);
			SwapIfLesser(ref p0, ref p2);
			SwapIfLesser(ref p0, ref p1);
			SwapIfLesser(ref p3, ref p4);
			SwapIfLesser(ref p5, ref p6);
			SwapIfLesser(ref p3, ref p5);
			SwapIfLesser(ref p4, ref p6);
			SwapIfLesser(ref p4, ref p5);
			SwapIfLesser(ref p0, ref p4);
			SwapIfLesser(ref p0, ref p3);
			SwapIfLesser(ref p1, ref p5);
			SwapIfLesser(ref p2, ref p6);
			SwapIfLesser(ref p2, ref p5);
			SwapIfLesser(ref p1, ref p3);
			SwapIfLesser(ref p2, ref p4);
			SwapIfLesser(ref p2, ref p3);
			SwapIfLesser(ref p8, ref p9);
			SwapIfLesser(ref p7, ref p9);
			SwapIfLesser(ref p7, ref p8);
			SwapIfLesser(ref p10, ref p11);
			SwapIfLesser(ref p12, ref p13);
			SwapIfLesser(ref p10, ref p12);
			SwapIfLesser(ref p11, ref p13);
			SwapIfLesser(ref p11, ref p12);
			SwapIfLesser(ref p7, ref p11);
			SwapIfLesser(ref p7, ref p10);
			SwapIfLesser(ref p8, ref p12);
			SwapIfLesser(ref p9, ref p13);
			SwapIfLesser(ref p9, ref p12);
			SwapIfLesser(ref p8, ref p10);
			SwapIfLesser(ref p9, ref p11);
			SwapIfLesser(ref p9, ref p10);
			SwapIfLesser(ref p0, ref p8);
			SwapIfLesser(ref p0, ref p7);
			SwapIfLesser(ref p1, ref p9);
			SwapIfLesser(ref p2, ref p10);
			SwapIfLesser(ref p2, ref p9);
			SwapIfLesser(ref p1, ref p7);
			SwapIfLesser(ref p2, ref p8);
			SwapIfLesser(ref p2, ref p7);
			SwapIfLesser(ref p3, ref p11);
			SwapIfLesser(ref p4, ref p12);
			SwapIfLesser(ref p4, ref p11);
			SwapIfLesser(ref p5, ref p13);
			SwapIfLesser(ref p6, ref p13);
			SwapIfLesser(ref p5, ref p11);
			SwapIfLesser(ref p6, ref p12);
			SwapIfLesser(ref p6, ref p11);
			SwapIfLesser(ref p3, ref p7);
			SwapIfLesser(ref p4, ref p8);
			SwapIfLesser(ref p4, ref p7);
			SwapIfLesser(ref p5, ref p9);
			SwapIfLesser(ref p6, ref p10);
			SwapIfLesser(ref p6, ref p9);
			SwapIfLesser(ref p5, ref p7);
			SwapIfLesser(ref p6, ref p8);
			SwapIfLesser(ref p6, ref p7);
		}

		/// <summary>
		/// Sorts a collection of 15 elements in ascending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort15Ascending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);
			ref var p10 = ref Unsafe.Add(ref p9, 10);
			ref var p11 = ref Unsafe.Add(ref p10, 11);
			ref var p12 = ref Unsafe.Add(ref p11, 12);
			ref var p13 = ref Unsafe.Add(ref p12, 13);
			ref var p14 = ref Unsafe.Add(ref p13, 14);

			SwapIfGreater(ref p1, ref p2);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p3, ref p4);
			SwapIfGreater(ref p5, ref p6);
			SwapIfGreater(ref p3, ref p5);
			SwapIfGreater(ref p4, ref p6);
			SwapIfGreater(ref p4, ref p5);
			SwapIfGreater(ref p0, ref p4);
			SwapIfGreater(ref p0, ref p3);
			SwapIfGreater(ref p1, ref p5);
			SwapIfGreater(ref p2, ref p6);
			SwapIfGreater(ref p2, ref p5);
			SwapIfGreater(ref p1, ref p3);
			SwapIfGreater(ref p2, ref p4);
			SwapIfGreater(ref p2, ref p3);
			SwapIfGreater(ref p7, ref p8);
			SwapIfGreater(ref p9, ref p10);
			SwapIfGreater(ref p7, ref p9);
			SwapIfGreater(ref p8, ref p10);
			SwapIfGreater(ref p8, ref p9);
			SwapIfGreater(ref p11, ref p12);
			SwapIfGreater(ref p13, ref p14);
			SwapIfGreater(ref p11, ref p13);
			SwapIfGreater(ref p12, ref p14);
			SwapIfGreater(ref p12, ref p13);
			SwapIfGreater(ref p7, ref p11);
			SwapIfGreater(ref p8, ref p12);
			SwapIfGreater(ref p8, ref p11);
			SwapIfGreater(ref p9, ref p13);
			SwapIfGreater(ref p10, ref p14);
			SwapIfGreater(ref p10, ref p13);
			SwapIfGreater(ref p9, ref p11);
			SwapIfGreater(ref p10, ref p12);
			SwapIfGreater(ref p10, ref p11);
			SwapIfGreater(ref p0, ref p8);
			SwapIfGreater(ref p0, ref p7);
			SwapIfGreater(ref p1, ref p9);
			SwapIfGreater(ref p2, ref p10);
			SwapIfGreater(ref p2, ref p9);
			SwapIfGreater(ref p1, ref p7);
			SwapIfGreater(ref p2, ref p8);
			SwapIfGreater(ref p2, ref p7);
			SwapIfGreater(ref p3, ref p11);
			SwapIfGreater(ref p4, ref p12);
			SwapIfGreater(ref p4, ref p11);
			SwapIfGreater(ref p5, ref p13);
			SwapIfGreater(ref p6, ref p14);
			SwapIfGreater(ref p6, ref p13);
			SwapIfGreater(ref p5, ref p11);
			SwapIfGreater(ref p6, ref p12);
			SwapIfGreater(ref p6, ref p11);
			SwapIfGreater(ref p3, ref p7);
			SwapIfGreater(ref p4, ref p8);
			SwapIfGreater(ref p4, ref p7);
			SwapIfGreater(ref p5, ref p9);
			SwapIfGreater(ref p6, ref p10);
			SwapIfGreater(ref p6, ref p9);
			SwapIfGreater(ref p5, ref p7);
			SwapIfGreater(ref p6, ref p8);
			SwapIfGreater(ref p6, ref p7);
		}

		/// <summary>
		/// Sorts a collection of 15 elements in descending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort15Descending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);
			ref var p10 = ref Unsafe.Add(ref p9, 10);
			ref var p11 = ref Unsafe.Add(ref p10, 11);
			ref var p12 = ref Unsafe.Add(ref p11, 12);
			ref var p13 = ref Unsafe.Add(ref p12, 13);
			ref var p14 = ref Unsafe.Add(ref p13, 14);

			SwapIfLesser(ref p1, ref p2);
			SwapIfLesser(ref p0, ref p2);
			SwapIfLesser(ref p0, ref p1);
			SwapIfLesser(ref p3, ref p4);
			SwapIfLesser(ref p5, ref p6);
			SwapIfLesser(ref p3, ref p5);
			SwapIfLesser(ref p4, ref p6);
			SwapIfLesser(ref p4, ref p5);
			SwapIfLesser(ref p0, ref p4);
			SwapIfLesser(ref p0, ref p3);
			SwapIfLesser(ref p1, ref p5);
			SwapIfLesser(ref p2, ref p6);
			SwapIfLesser(ref p2, ref p5);
			SwapIfLesser(ref p1, ref p3);
			SwapIfLesser(ref p2, ref p4);
			SwapIfLesser(ref p2, ref p3);
			SwapIfLesser(ref p7, ref p8);
			SwapIfLesser(ref p9, ref p10);
			SwapIfLesser(ref p7, ref p9);
			SwapIfLesser(ref p8, ref p10);
			SwapIfLesser(ref p8, ref p9);
			SwapIfLesser(ref p11, ref p12);
			SwapIfLesser(ref p13, ref p14);
			SwapIfLesser(ref p11, ref p13);
			SwapIfLesser(ref p12, ref p14);
			SwapIfLesser(ref p12, ref p13);
			SwapIfLesser(ref p7, ref p11);
			SwapIfLesser(ref p8, ref p12);
			SwapIfLesser(ref p8, ref p11);
			SwapIfLesser(ref p9, ref p13);
			SwapIfLesser(ref p10, ref p14);
			SwapIfLesser(ref p10, ref p13);
			SwapIfLesser(ref p9, ref p11);
			SwapIfLesser(ref p10, ref p12);
			SwapIfLesser(ref p10, ref p11);
			SwapIfLesser(ref p0, ref p8);
			SwapIfLesser(ref p0, ref p7);
			SwapIfLesser(ref p1, ref p9);
			SwapIfLesser(ref p2, ref p10);
			SwapIfLesser(ref p2, ref p9);
			SwapIfLesser(ref p1, ref p7);
			SwapIfLesser(ref p2, ref p8);
			SwapIfLesser(ref p2, ref p7);
			SwapIfLesser(ref p3, ref p11);
			SwapIfLesser(ref p4, ref p12);
			SwapIfLesser(ref p4, ref p11);
			SwapIfLesser(ref p5, ref p13);
			SwapIfLesser(ref p6, ref p14);
			SwapIfLesser(ref p6, ref p13);
			SwapIfLesser(ref p5, ref p11);
			SwapIfLesser(ref p6, ref p12);
			SwapIfLesser(ref p6, ref p11);
			SwapIfLesser(ref p3, ref p7);
			SwapIfLesser(ref p4, ref p8);
			SwapIfLesser(ref p4, ref p7);
			SwapIfLesser(ref p5, ref p9);
			SwapIfLesser(ref p6, ref p10);
			SwapIfLesser(ref p6, ref p9);
			SwapIfLesser(ref p5, ref p7);
			SwapIfLesser(ref p6, ref p8);
			SwapIfLesser(ref p6, ref p7);
		}

		/// <summary>
		/// Sorts a collection of 16 elements in ascending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort16Ascending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);
			ref var p10 = ref Unsafe.Add(ref p9, 10);
			ref var p11 = ref Unsafe.Add(ref p10, 11);
			ref var p12 = ref Unsafe.Add(ref p11, 12);
			ref var p13 = ref Unsafe.Add(ref p12, 13);
			ref var p14 = ref Unsafe.Add(ref p13, 14);
			ref var p15 = ref Unsafe.Add(ref p14, 15);

			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p2, ref p3);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p1, ref p3);
			SwapIfGreater(ref p1, ref p2);
			SwapIfGreater(ref p4, ref p5);
			SwapIfGreater(ref p6, ref p7);
			SwapIfGreater(ref p4, ref p6);
			SwapIfGreater(ref p5, ref p7);
			SwapIfGreater(ref p5, ref p6);
			SwapIfGreater(ref p0, ref p4);
			SwapIfGreater(ref p1, ref p5);
			SwapIfGreater(ref p1, ref p4);
			SwapIfGreater(ref p2, ref p6);
			SwapIfGreater(ref p3, ref p7);
			SwapIfGreater(ref p3, ref p6);
			SwapIfGreater(ref p2, ref p4);
			SwapIfGreater(ref p3, ref p5);
			SwapIfGreater(ref p3, ref p4);
			SwapIfGreater(ref p8, ref p9);
			SwapIfGreater(ref p10, ref p11);
			SwapIfGreater(ref p8, ref p10);
			SwapIfGreater(ref p9, ref p11);
			SwapIfGreater(ref p9, ref p10);
			SwapIfGreater(ref p12, ref p13);
			SwapIfGreater(ref p14, ref p15);
			SwapIfGreater(ref p12, ref p14);
			SwapIfGreater(ref p13, ref p15);
			SwapIfGreater(ref p13, ref p14);
			SwapIfGreater(ref p8, ref p12);
			SwapIfGreater(ref p9, ref p13);
			SwapIfGreater(ref p9, ref p12);
			SwapIfGreater(ref p10, ref p14);
			SwapIfGreater(ref p11, ref p15);
			SwapIfGreater(ref p11, ref p14);
			SwapIfGreater(ref p10, ref p12);
			SwapIfGreater(ref p11, ref p13);
			SwapIfGreater(ref p11, ref p12);
			SwapIfGreater(ref p0, ref p8);
			SwapIfGreater(ref p1, ref p9);
			SwapIfGreater(ref p1, ref p8);
			SwapIfGreater(ref p2, ref p10);
			SwapIfGreater(ref p3, ref p11);
			SwapIfGreater(ref p3, ref p10);
			SwapIfGreater(ref p2, ref p8);
			SwapIfGreater(ref p3, ref p9);
			SwapIfGreater(ref p3, ref p8);
			SwapIfGreater(ref p4, ref p12);
			SwapIfGreater(ref p5, ref p13);
			SwapIfGreater(ref p5, ref p12);
			SwapIfGreater(ref p6, ref p14);
			SwapIfGreater(ref p7, ref p15);
			SwapIfGreater(ref p7, ref p14);
			SwapIfGreater(ref p6, ref p12);
			SwapIfGreater(ref p7, ref p13);
			SwapIfGreater(ref p7, ref p12);
			SwapIfGreater(ref p4, ref p8);
			SwapIfGreater(ref p5, ref p9);
			SwapIfGreater(ref p5, ref p8);
			SwapIfGreater(ref p6, ref p10);
			SwapIfGreater(ref p7, ref p11);
			SwapIfGreater(ref p7, ref p10);
			SwapIfGreater(ref p6, ref p8);
			SwapIfGreater(ref p7, ref p9);
			SwapIfGreater(ref p7, ref p8);
		}

		/// <summary>
		/// Sorts a collection of 16 elements in descending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort16Descending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);
			ref var p10 = ref Unsafe.Add(ref p9, 10);
			ref var p11 = ref Unsafe.Add(ref p10, 11);
			ref var p12 = ref Unsafe.Add(ref p11, 12);
			ref var p13 = ref Unsafe.Add(ref p12, 13);
			ref var p14 = ref Unsafe.Add(ref p13, 14);
			ref var p15 = ref Unsafe.Add(ref p14, 15);

			SwapIfLesser(ref p0, ref p1);
			SwapIfLesser(ref p2, ref p3);
			SwapIfLesser(ref p0, ref p2);
			SwapIfLesser(ref p1, ref p3);
			SwapIfLesser(ref p1, ref p2);
			SwapIfLesser(ref p4, ref p5);
			SwapIfLesser(ref p6, ref p7);
			SwapIfLesser(ref p4, ref p6);
			SwapIfLesser(ref p5, ref p7);
			SwapIfLesser(ref p5, ref p6);
			SwapIfLesser(ref p0, ref p4);
			SwapIfLesser(ref p1, ref p5);
			SwapIfLesser(ref p1, ref p4);
			SwapIfLesser(ref p2, ref p6);
			SwapIfLesser(ref p3, ref p7);
			SwapIfLesser(ref p3, ref p6);
			SwapIfLesser(ref p2, ref p4);
			SwapIfLesser(ref p3, ref p5);
			SwapIfLesser(ref p3, ref p4);
			SwapIfLesser(ref p8, ref p9);
			SwapIfLesser(ref p10, ref p11);
			SwapIfLesser(ref p8, ref p10);
			SwapIfLesser(ref p9, ref p11);
			SwapIfLesser(ref p9, ref p10);
			SwapIfLesser(ref p12, ref p13);
			SwapIfLesser(ref p14, ref p15);
			SwapIfLesser(ref p12, ref p14);
			SwapIfLesser(ref p13, ref p15);
			SwapIfLesser(ref p13, ref p14);
			SwapIfLesser(ref p8, ref p12);
			SwapIfLesser(ref p9, ref p13);
			SwapIfLesser(ref p9, ref p12);
			SwapIfLesser(ref p10, ref p14);
			SwapIfLesser(ref p11, ref p15);
			SwapIfLesser(ref p11, ref p14);
			SwapIfLesser(ref p10, ref p12);
			SwapIfLesser(ref p11, ref p13);
			SwapIfLesser(ref p11, ref p12);
			SwapIfLesser(ref p0, ref p8);
			SwapIfLesser(ref p1, ref p9);
			SwapIfLesser(ref p1, ref p8);
			SwapIfLesser(ref p2, ref p10);
			SwapIfLesser(ref p3, ref p11);
			SwapIfLesser(ref p3, ref p10);
			SwapIfLesser(ref p2, ref p8);
			SwapIfLesser(ref p3, ref p9);
			SwapIfLesser(ref p3, ref p8);
			SwapIfLesser(ref p4, ref p12);
			SwapIfLesser(ref p5, ref p13);
			SwapIfLesser(ref p5, ref p12);
			SwapIfLesser(ref p6, ref p14);
			SwapIfLesser(ref p7, ref p15);
			SwapIfLesser(ref p7, ref p14);
			SwapIfLesser(ref p6, ref p12);
			SwapIfLesser(ref p7, ref p13);
			SwapIfLesser(ref p7, ref p12);
			SwapIfLesser(ref p4, ref p8);
			SwapIfLesser(ref p5, ref p9);
			SwapIfLesser(ref p5, ref p8);
			SwapIfLesser(ref p6, ref p10);
			SwapIfLesser(ref p7, ref p11);
			SwapIfLesser(ref p7, ref p10);
			SwapIfLesser(ref p6, ref p8);
			SwapIfLesser(ref p7, ref p9);
			SwapIfLesser(ref p7, ref p8);
		}

		/// <summary>
		/// Sorts a collection of 17 elements in ascending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort17Ascending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);
			ref var p10 = ref Unsafe.Add(ref p9, 10);
			ref var p11 = ref Unsafe.Add(ref p10, 11);
			ref var p12 = ref Unsafe.Add(ref p11, 12);
			ref var p13 = ref Unsafe.Add(ref p12, 13);
			ref var p14 = ref Unsafe.Add(ref p13, 14);
			ref var p15 = ref Unsafe.Add(ref p14, 15);
			ref var p16 = ref Unsafe.Add(ref p15, 16);

			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p2, ref p3);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p1, ref p3);
			SwapIfGreater(ref p1, ref p2);
			SwapIfGreater(ref p4, ref p5);
			SwapIfGreater(ref p6, ref p7);
			SwapIfGreater(ref p4, ref p6);
			SwapIfGreater(ref p5, ref p7);
			SwapIfGreater(ref p5, ref p6);
			SwapIfGreater(ref p0, ref p4);
			SwapIfGreater(ref p1, ref p5);
			SwapIfGreater(ref p1, ref p4);
			SwapIfGreater(ref p2, ref p6);
			SwapIfGreater(ref p3, ref p7);
			SwapIfGreater(ref p3, ref p6);
			SwapIfGreater(ref p2, ref p4);
			SwapIfGreater(ref p3, ref p5);
			SwapIfGreater(ref p3, ref p4);
			SwapIfGreater(ref p8, ref p9);
			SwapIfGreater(ref p10, ref p11);
			SwapIfGreater(ref p8, ref p10);
			SwapIfGreater(ref p9, ref p11);
			SwapIfGreater(ref p9, ref p10);
			SwapIfGreater(ref p12, ref p13);
			SwapIfGreater(ref p15, ref p16);
			SwapIfGreater(ref p14, ref p16);
			SwapIfGreater(ref p14, ref p15);
			SwapIfGreater(ref p12, ref p15);
			SwapIfGreater(ref p12, ref p14);
			SwapIfGreater(ref p13, ref p16);
			SwapIfGreater(ref p13, ref p15);
			SwapIfGreater(ref p13, ref p14);
			SwapIfGreater(ref p8, ref p13);
			SwapIfGreater(ref p8, ref p12);
			SwapIfGreater(ref p9, ref p14);
			SwapIfGreater(ref p9, ref p13);
			SwapIfGreater(ref p9, ref p12);
			SwapIfGreater(ref p10, ref p15);
			SwapIfGreater(ref p11, ref p16);
			SwapIfGreater(ref p11, ref p15);
			SwapIfGreater(ref p10, ref p13);
			SwapIfGreater(ref p10, ref p12);
			SwapIfGreater(ref p11, ref p14);
			SwapIfGreater(ref p11, ref p13);
			SwapIfGreater(ref p11, ref p12);
			SwapIfGreater(ref p0, ref p9);
			SwapIfGreater(ref p0, ref p8);
			SwapIfGreater(ref p1, ref p10);
			SwapIfGreater(ref p1, ref p9);
			SwapIfGreater(ref p1, ref p8);
			SwapIfGreater(ref p2, ref p11);
			SwapIfGreater(ref p3, ref p12);
			SwapIfGreater(ref p3, ref p11);
			SwapIfGreater(ref p2, ref p9);
			SwapIfGreater(ref p2, ref p8);
			SwapIfGreater(ref p3, ref p10);
			SwapIfGreater(ref p3, ref p9);
			SwapIfGreater(ref p3, ref p8);
			SwapIfGreater(ref p4, ref p13);
			SwapIfGreater(ref p5, ref p14);
			SwapIfGreater(ref p5, ref p13);
			SwapIfGreater(ref p6, ref p15);
			SwapIfGreater(ref p7, ref p16);
			SwapIfGreater(ref p7, ref p15);
			SwapIfGreater(ref p6, ref p13);
			SwapIfGreater(ref p7, ref p14);
			SwapIfGreater(ref p7, ref p13);
			SwapIfGreater(ref p4, ref p9);
			SwapIfGreater(ref p4, ref p8);
			SwapIfGreater(ref p5, ref p10);
			SwapIfGreater(ref p5, ref p9);
			SwapIfGreater(ref p5, ref p8);
			SwapIfGreater(ref p6, ref p11);
			SwapIfGreater(ref p7, ref p12);
			SwapIfGreater(ref p7, ref p11);
			SwapIfGreater(ref p6, ref p9);
			SwapIfGreater(ref p6, ref p8);
			SwapIfGreater(ref p7, ref p10);
			SwapIfGreater(ref p7, ref p9);
			SwapIfGreater(ref p7, ref p8);
		}

		/// <summary>
		/// Sorts a collection of 17 elements in descending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort17Descending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);
			ref var p10 = ref Unsafe.Add(ref p9, 10);
			ref var p11 = ref Unsafe.Add(ref p10, 11);
			ref var p12 = ref Unsafe.Add(ref p11, 12);
			ref var p13 = ref Unsafe.Add(ref p12, 13);
			ref var p14 = ref Unsafe.Add(ref p13, 14);
			ref var p15 = ref Unsafe.Add(ref p14, 15);
			ref var p16 = ref Unsafe.Add(ref p15, 16);

			SwapIfLesser(ref p0, ref p1);
			SwapIfLesser(ref p2, ref p3);
			SwapIfLesser(ref p0, ref p2);
			SwapIfLesser(ref p1, ref p3);
			SwapIfLesser(ref p1, ref p2);
			SwapIfLesser(ref p4, ref p5);
			SwapIfLesser(ref p6, ref p7);
			SwapIfLesser(ref p4, ref p6);
			SwapIfLesser(ref p5, ref p7);
			SwapIfLesser(ref p5, ref p6);
			SwapIfLesser(ref p0, ref p4);
			SwapIfLesser(ref p1, ref p5);
			SwapIfLesser(ref p1, ref p4);
			SwapIfLesser(ref p2, ref p6);
			SwapIfLesser(ref p3, ref p7);
			SwapIfLesser(ref p3, ref p6);
			SwapIfLesser(ref p2, ref p4);
			SwapIfLesser(ref p3, ref p5);
			SwapIfLesser(ref p3, ref p4);
			SwapIfLesser(ref p8, ref p9);
			SwapIfLesser(ref p10, ref p11);
			SwapIfLesser(ref p8, ref p10);
			SwapIfLesser(ref p9, ref p11);
			SwapIfLesser(ref p9, ref p10);
			SwapIfLesser(ref p12, ref p13);
			SwapIfLesser(ref p15, ref p16);
			SwapIfLesser(ref p14, ref p16);
			SwapIfLesser(ref p14, ref p15);
			SwapIfLesser(ref p12, ref p15);
			SwapIfLesser(ref p12, ref p14);
			SwapIfLesser(ref p13, ref p16);
			SwapIfLesser(ref p13, ref p15);
			SwapIfLesser(ref p13, ref p14);
			SwapIfLesser(ref p8, ref p13);
			SwapIfLesser(ref p8, ref p12);
			SwapIfLesser(ref p9, ref p14);
			SwapIfLesser(ref p9, ref p13);
			SwapIfLesser(ref p9, ref p12);
			SwapIfLesser(ref p10, ref p15);
			SwapIfLesser(ref p11, ref p16);
			SwapIfLesser(ref p11, ref p15);
			SwapIfLesser(ref p10, ref p13);
			SwapIfLesser(ref p10, ref p12);
			SwapIfLesser(ref p11, ref p14);
			SwapIfLesser(ref p11, ref p13);
			SwapIfLesser(ref p11, ref p12);
			SwapIfLesser(ref p0, ref p9);
			SwapIfLesser(ref p0, ref p8);
			SwapIfLesser(ref p1, ref p10);
			SwapIfLesser(ref p1, ref p9);
			SwapIfLesser(ref p1, ref p8);
			SwapIfLesser(ref p2, ref p11);
			SwapIfLesser(ref p3, ref p12);
			SwapIfLesser(ref p3, ref p11);
			SwapIfLesser(ref p2, ref p9);
			SwapIfLesser(ref p2, ref p8);
			SwapIfLesser(ref p3, ref p10);
			SwapIfLesser(ref p3, ref p9);
			SwapIfLesser(ref p3, ref p8);
			SwapIfLesser(ref p4, ref p13);
			SwapIfLesser(ref p5, ref p14);
			SwapIfLesser(ref p5, ref p13);
			SwapIfLesser(ref p6, ref p15);
			SwapIfLesser(ref p7, ref p16);
			SwapIfLesser(ref p7, ref p15);
			SwapIfLesser(ref p6, ref p13);
			SwapIfLesser(ref p7, ref p14);
			SwapIfLesser(ref p7, ref p13);
			SwapIfLesser(ref p4, ref p9);
			SwapIfLesser(ref p4, ref p8);
			SwapIfLesser(ref p5, ref p10);
			SwapIfLesser(ref p5, ref p9);
			SwapIfLesser(ref p5, ref p8);
			SwapIfLesser(ref p6, ref p11);
			SwapIfLesser(ref p7, ref p12);
			SwapIfLesser(ref p7, ref p11);
			SwapIfLesser(ref p6, ref p9);
			SwapIfLesser(ref p6, ref p8);
			SwapIfLesser(ref p7, ref p10);
			SwapIfLesser(ref p7, ref p9);
			SwapIfLesser(ref p7, ref p8);
		}

		/// <summary>
		/// Sorts a collection of 18 elements in ascending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort18Ascending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);
			ref var p10 = ref Unsafe.Add(ref p9, 10);
			ref var p11 = ref Unsafe.Add(ref p10, 11);
			ref var p12 = ref Unsafe.Add(ref p11, 12);
			ref var p13 = ref Unsafe.Add(ref p12, 13);
			ref var p14 = ref Unsafe.Add(ref p13, 14);
			ref var p15 = ref Unsafe.Add(ref p14, 15);
			ref var p16 = ref Unsafe.Add(ref p15, 16);
			ref var p17 = ref Unsafe.Add(ref p16, 17);

			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p2, ref p3);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p1, ref p3);
			SwapIfGreater(ref p1, ref p2);
			SwapIfGreater(ref p4, ref p5);
			SwapIfGreater(ref p7, ref p8);
			SwapIfGreater(ref p6, ref p8);
			SwapIfGreater(ref p6, ref p7);
			SwapIfGreater(ref p4, ref p7);
			SwapIfGreater(ref p4, ref p6);
			SwapIfGreater(ref p5, ref p8);
			SwapIfGreater(ref p5, ref p7);
			SwapIfGreater(ref p5, ref p6);
			SwapIfGreater(ref p0, ref p5);
			SwapIfGreater(ref p0, ref p4);
			SwapIfGreater(ref p1, ref p6);
			SwapIfGreater(ref p1, ref p5);
			SwapIfGreater(ref p1, ref p4);
			SwapIfGreater(ref p2, ref p7);
			SwapIfGreater(ref p3, ref p8);
			SwapIfGreater(ref p3, ref p7);
			SwapIfGreater(ref p2, ref p5);
			SwapIfGreater(ref p2, ref p4);
			SwapIfGreater(ref p3, ref p6);
			SwapIfGreater(ref p3, ref p5);
			SwapIfGreater(ref p3, ref p4);
			SwapIfGreater(ref p9, ref p10);
			SwapIfGreater(ref p11, ref p12);
			SwapIfGreater(ref p9, ref p11);
			SwapIfGreater(ref p10, ref p12);
			SwapIfGreater(ref p10, ref p11);
			SwapIfGreater(ref p13, ref p14);
			SwapIfGreater(ref p16, ref p17);
			SwapIfGreater(ref p15, ref p17);
			SwapIfGreater(ref p15, ref p16);
			SwapIfGreater(ref p13, ref p16);
			SwapIfGreater(ref p13, ref p15);
			SwapIfGreater(ref p14, ref p17);
			SwapIfGreater(ref p14, ref p16);
			SwapIfGreater(ref p14, ref p15);
			SwapIfGreater(ref p9, ref p14);
			SwapIfGreater(ref p9, ref p13);
			SwapIfGreater(ref p10, ref p15);
			SwapIfGreater(ref p10, ref p14);
			SwapIfGreater(ref p10, ref p13);
			SwapIfGreater(ref p11, ref p16);
			SwapIfGreater(ref p12, ref p17);
			SwapIfGreater(ref p12, ref p16);
			SwapIfGreater(ref p11, ref p14);
			SwapIfGreater(ref p11, ref p13);
			SwapIfGreater(ref p12, ref p15);
			SwapIfGreater(ref p12, ref p14);
			SwapIfGreater(ref p12, ref p13);
			SwapIfGreater(ref p0, ref p10);
			SwapIfGreater(ref p0, ref p9);
			SwapIfGreater(ref p1, ref p11);
			SwapIfGreater(ref p1, ref p10);
			SwapIfGreater(ref p1, ref p9);
			SwapIfGreater(ref p2, ref p12);
			SwapIfGreater(ref p3, ref p13);
			SwapIfGreater(ref p3, ref p12);
			SwapIfGreater(ref p2, ref p10);
			SwapIfGreater(ref p2, ref p9);
			SwapIfGreater(ref p3, ref p11);
			SwapIfGreater(ref p3, ref p10);
			SwapIfGreater(ref p3, ref p9);
			SwapIfGreater(ref p4, ref p14);
			SwapIfGreater(ref p5, ref p15);
			SwapIfGreater(ref p5, ref p14);
			SwapIfGreater(ref p6, ref p16);
			SwapIfGreater(ref p7, ref p17);
			SwapIfGreater(ref p8, ref p17);
			SwapIfGreater(ref p7, ref p16);
			SwapIfGreater(ref p8, ref p16);
			SwapIfGreater(ref p6, ref p14);
			SwapIfGreater(ref p7, ref p15);
			SwapIfGreater(ref p8, ref p15);
			SwapIfGreater(ref p7, ref p14);
			SwapIfGreater(ref p8, ref p14);
			SwapIfGreater(ref p4, ref p10);
			SwapIfGreater(ref p4, ref p9);
			SwapIfGreater(ref p5, ref p11);
			SwapIfGreater(ref p5, ref p10);
			SwapIfGreater(ref p5, ref p9);
			SwapIfGreater(ref p6, ref p12);
			SwapIfGreater(ref p7, ref p13);
			SwapIfGreater(ref p8, ref p13);
			SwapIfGreater(ref p7, ref p12);
			SwapIfGreater(ref p8, ref p12);
			SwapIfGreater(ref p6, ref p10);
			SwapIfGreater(ref p6, ref p9);
			SwapIfGreater(ref p7, ref p11);
			SwapIfGreater(ref p8, ref p11);
			SwapIfGreater(ref p7, ref p9);
			SwapIfGreater(ref p8, ref p10);
			SwapIfGreater(ref p8, ref p9);
		}

		/// <summary>
		/// Sorts a collection of 18 elements in descending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort18Descending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);
			ref var p10 = ref Unsafe.Add(ref p9, 10);
			ref var p11 = ref Unsafe.Add(ref p10, 11);
			ref var p12 = ref Unsafe.Add(ref p11, 12);
			ref var p13 = ref Unsafe.Add(ref p12, 13);
			ref var p14 = ref Unsafe.Add(ref p13, 14);
			ref var p15 = ref Unsafe.Add(ref p14, 15);
			ref var p16 = ref Unsafe.Add(ref p15, 16);
			ref var p17 = ref Unsafe.Add(ref p16, 17);

			SwapIfLesser(ref p0, ref p1);
			SwapIfLesser(ref p2, ref p3);
			SwapIfLesser(ref p0, ref p2);
			SwapIfLesser(ref p1, ref p3);
			SwapIfLesser(ref p1, ref p2);
			SwapIfLesser(ref p4, ref p5);
			SwapIfLesser(ref p7, ref p8);
			SwapIfLesser(ref p6, ref p8);
			SwapIfLesser(ref p6, ref p7);
			SwapIfLesser(ref p4, ref p7);
			SwapIfLesser(ref p4, ref p6);
			SwapIfLesser(ref p5, ref p8);
			SwapIfLesser(ref p5, ref p7);
			SwapIfLesser(ref p5, ref p6);
			SwapIfLesser(ref p0, ref p5);
			SwapIfLesser(ref p0, ref p4);
			SwapIfLesser(ref p1, ref p6);
			SwapIfLesser(ref p1, ref p5);
			SwapIfLesser(ref p1, ref p4);
			SwapIfLesser(ref p2, ref p7);
			SwapIfLesser(ref p3, ref p8);
			SwapIfLesser(ref p3, ref p7);
			SwapIfLesser(ref p2, ref p5);
			SwapIfLesser(ref p2, ref p4);
			SwapIfLesser(ref p3, ref p6);
			SwapIfLesser(ref p3, ref p5);
			SwapIfLesser(ref p3, ref p4);
			SwapIfLesser(ref p9, ref p10);
			SwapIfLesser(ref p11, ref p12);
			SwapIfLesser(ref p9, ref p11);
			SwapIfLesser(ref p10, ref p12);
			SwapIfLesser(ref p10, ref p11);
			SwapIfLesser(ref p13, ref p14);
			SwapIfLesser(ref p16, ref p17);
			SwapIfLesser(ref p15, ref p17);
			SwapIfLesser(ref p15, ref p16);
			SwapIfLesser(ref p13, ref p16);
			SwapIfLesser(ref p13, ref p15);
			SwapIfLesser(ref p14, ref p17);
			SwapIfLesser(ref p14, ref p16);
			SwapIfLesser(ref p14, ref p15);
			SwapIfLesser(ref p9, ref p14);
			SwapIfLesser(ref p9, ref p13);
			SwapIfLesser(ref p10, ref p15);
			SwapIfLesser(ref p10, ref p14);
			SwapIfLesser(ref p10, ref p13);
			SwapIfLesser(ref p11, ref p16);
			SwapIfLesser(ref p12, ref p17);
			SwapIfLesser(ref p12, ref p16);
			SwapIfLesser(ref p11, ref p14);
			SwapIfLesser(ref p11, ref p13);
			SwapIfLesser(ref p12, ref p15);
			SwapIfLesser(ref p12, ref p14);
			SwapIfLesser(ref p12, ref p13);
			SwapIfLesser(ref p0, ref p10);
			SwapIfLesser(ref p0, ref p9);
			SwapIfLesser(ref p1, ref p11);
			SwapIfLesser(ref p1, ref p10);
			SwapIfLesser(ref p1, ref p9);
			SwapIfLesser(ref p2, ref p12);
			SwapIfLesser(ref p3, ref p13);
			SwapIfLesser(ref p3, ref p12);
			SwapIfLesser(ref p2, ref p10);
			SwapIfLesser(ref p2, ref p9);
			SwapIfLesser(ref p3, ref p11);
			SwapIfLesser(ref p3, ref p10);
			SwapIfLesser(ref p3, ref p9);
			SwapIfLesser(ref p4, ref p14);
			SwapIfLesser(ref p5, ref p15);
			SwapIfLesser(ref p5, ref p14);
			SwapIfLesser(ref p6, ref p16);
			SwapIfLesser(ref p7, ref p17);
			SwapIfLesser(ref p8, ref p17);
			SwapIfLesser(ref p7, ref p16);
			SwapIfLesser(ref p8, ref p16);
			SwapIfLesser(ref p6, ref p14);
			SwapIfLesser(ref p7, ref p15);
			SwapIfLesser(ref p8, ref p15);
			SwapIfLesser(ref p7, ref p14);
			SwapIfLesser(ref p8, ref p14);
			SwapIfLesser(ref p4, ref p10);
			SwapIfLesser(ref p4, ref p9);
			SwapIfLesser(ref p5, ref p11);
			SwapIfLesser(ref p5, ref p10);
			SwapIfLesser(ref p5, ref p9);
			SwapIfLesser(ref p6, ref p12);
			SwapIfLesser(ref p7, ref p13);
			SwapIfLesser(ref p8, ref p13);
			SwapIfLesser(ref p7, ref p12);
			SwapIfLesser(ref p8, ref p12);
			SwapIfLesser(ref p6, ref p10);
			SwapIfLesser(ref p6, ref p9);
			SwapIfLesser(ref p7, ref p11);
			SwapIfLesser(ref p8, ref p11);
			SwapIfLesser(ref p7, ref p9);
			SwapIfLesser(ref p8, ref p10);
			SwapIfLesser(ref p8, ref p9);
		}

		/// <summary>
		/// Sorts a collection of 19 elements in ascending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort19Ascending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);
			ref var p10 = ref Unsafe.Add(ref p9, 10);
			ref var p11 = ref Unsafe.Add(ref p10, 11);
			ref var p12 = ref Unsafe.Add(ref p11, 12);
			ref var p13 = ref Unsafe.Add(ref p12, 13);
			ref var p14 = ref Unsafe.Add(ref p13, 14);
			ref var p15 = ref Unsafe.Add(ref p14, 15);
			ref var p16 = ref Unsafe.Add(ref p15, 16);
			ref var p17 = ref Unsafe.Add(ref p16, 17);
			ref var p18 = ref Unsafe.Add(ref p17, 18);

			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p2, ref p3);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p1, ref p3);
			SwapIfGreater(ref p1, ref p2);
			SwapIfGreater(ref p4, ref p5);
			SwapIfGreater(ref p7, ref p8);
			SwapIfGreater(ref p6, ref p8);
			SwapIfGreater(ref p6, ref p7);
			SwapIfGreater(ref p4, ref p7);
			SwapIfGreater(ref p4, ref p6);
			SwapIfGreater(ref p5, ref p8);
			SwapIfGreater(ref p5, ref p7);
			SwapIfGreater(ref p5, ref p6);
			SwapIfGreater(ref p0, ref p5);
			SwapIfGreater(ref p0, ref p4);
			SwapIfGreater(ref p1, ref p6);
			SwapIfGreater(ref p1, ref p5);
			SwapIfGreater(ref p1, ref p4);
			SwapIfGreater(ref p2, ref p7);
			SwapIfGreater(ref p3, ref p8);
			SwapIfGreater(ref p3, ref p7);
			SwapIfGreater(ref p2, ref p5);
			SwapIfGreater(ref p2, ref p4);
			SwapIfGreater(ref p3, ref p6);
			SwapIfGreater(ref p3, ref p5);
			SwapIfGreater(ref p3, ref p4);
			SwapIfGreater(ref p9, ref p10);
			SwapIfGreater(ref p12, ref p13);
			SwapIfGreater(ref p11, ref p13);
			SwapIfGreater(ref p11, ref p12);
			SwapIfGreater(ref p9, ref p12);
			SwapIfGreater(ref p9, ref p11);
			SwapIfGreater(ref p10, ref p13);
			SwapIfGreater(ref p10, ref p12);
			SwapIfGreater(ref p10, ref p11);
			SwapIfGreater(ref p14, ref p15);
			SwapIfGreater(ref p17, ref p18);
			SwapIfGreater(ref p16, ref p18);
			SwapIfGreater(ref p16, ref p17);
			SwapIfGreater(ref p14, ref p17);
			SwapIfGreater(ref p14, ref p16);
			SwapIfGreater(ref p15, ref p18);
			SwapIfGreater(ref p15, ref p17);
			SwapIfGreater(ref p15, ref p16);
			SwapIfGreater(ref p9, ref p15);
			SwapIfGreater(ref p9, ref p14);
			SwapIfGreater(ref p10, ref p16);
			SwapIfGreater(ref p10, ref p15);
			SwapIfGreater(ref p10, ref p14);
			SwapIfGreater(ref p11, ref p17);
			SwapIfGreater(ref p12, ref p18);
			SwapIfGreater(ref p13, ref p18);
			SwapIfGreater(ref p12, ref p17);
			SwapIfGreater(ref p13, ref p17);
			SwapIfGreater(ref p11, ref p15);
			SwapIfGreater(ref p11, ref p14);
			SwapIfGreater(ref p12, ref p16);
			SwapIfGreater(ref p13, ref p16);
			SwapIfGreater(ref p12, ref p14);
			SwapIfGreater(ref p13, ref p15);
			SwapIfGreater(ref p13, ref p14);
			SwapIfGreater(ref p0, ref p10);
			SwapIfGreater(ref p0, ref p9);
			SwapIfGreater(ref p1, ref p11);
			SwapIfGreater(ref p1, ref p10);
			SwapIfGreater(ref p1, ref p9);
			SwapIfGreater(ref p2, ref p12);
			SwapIfGreater(ref p3, ref p13);
			SwapIfGreater(ref p3, ref p12);
			SwapIfGreater(ref p2, ref p10);
			SwapIfGreater(ref p2, ref p9);
			SwapIfGreater(ref p3, ref p11);
			SwapIfGreater(ref p3, ref p10);
			SwapIfGreater(ref p3, ref p9);
			SwapIfGreater(ref p4, ref p15);
			SwapIfGreater(ref p4, ref p14);
			SwapIfGreater(ref p5, ref p16);
			SwapIfGreater(ref p5, ref p15);
			SwapIfGreater(ref p5, ref p14);
			SwapIfGreater(ref p6, ref p17);
			SwapIfGreater(ref p7, ref p18);
			SwapIfGreater(ref p8, ref p18);
			SwapIfGreater(ref p7, ref p17);
			SwapIfGreater(ref p8, ref p17);
			SwapIfGreater(ref p6, ref p15);
			SwapIfGreater(ref p6, ref p14);
			SwapIfGreater(ref p7, ref p16);
			SwapIfGreater(ref p8, ref p16);
			SwapIfGreater(ref p7, ref p14);
			SwapIfGreater(ref p8, ref p15);
			SwapIfGreater(ref p8, ref p14);
			SwapIfGreater(ref p4, ref p10);
			SwapIfGreater(ref p4, ref p9);
			SwapIfGreater(ref p5, ref p11);
			SwapIfGreater(ref p5, ref p10);
			SwapIfGreater(ref p5, ref p9);
			SwapIfGreater(ref p6, ref p12);
			SwapIfGreater(ref p7, ref p13);
			SwapIfGreater(ref p8, ref p13);
			SwapIfGreater(ref p7, ref p12);
			SwapIfGreater(ref p8, ref p12);
			SwapIfGreater(ref p6, ref p10);
			SwapIfGreater(ref p6, ref p9);
			SwapIfGreater(ref p7, ref p11);
			SwapIfGreater(ref p8, ref p11);
			SwapIfGreater(ref p7, ref p9);
			SwapIfGreater(ref p8, ref p10);
			SwapIfGreater(ref p8, ref p9);
		}

		/// <summary>
		/// Sorts a collection of 19 elements in descending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort19Descending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);
			ref var p10 = ref Unsafe.Add(ref p9, 10);
			ref var p11 = ref Unsafe.Add(ref p10, 11);
			ref var p12 = ref Unsafe.Add(ref p11, 12);
			ref var p13 = ref Unsafe.Add(ref p12, 13);
			ref var p14 = ref Unsafe.Add(ref p13, 14);
			ref var p15 = ref Unsafe.Add(ref p14, 15);
			ref var p16 = ref Unsafe.Add(ref p15, 16);
			ref var p17 = ref Unsafe.Add(ref p16, 17);
			ref var p18 = ref Unsafe.Add(ref p17, 18);

			SwapIfLesser(ref p0, ref p1);
			SwapIfLesser(ref p2, ref p3);
			SwapIfLesser(ref p0, ref p2);
			SwapIfLesser(ref p1, ref p3);
			SwapIfLesser(ref p1, ref p2);
			SwapIfLesser(ref p4, ref p5);
			SwapIfLesser(ref p7, ref p8);
			SwapIfLesser(ref p6, ref p8);
			SwapIfLesser(ref p6, ref p7);
			SwapIfLesser(ref p4, ref p7);
			SwapIfLesser(ref p4, ref p6);
			SwapIfLesser(ref p5, ref p8);
			SwapIfLesser(ref p5, ref p7);
			SwapIfLesser(ref p5, ref p6);
			SwapIfLesser(ref p0, ref p5);
			SwapIfLesser(ref p0, ref p4);
			SwapIfLesser(ref p1, ref p6);
			SwapIfLesser(ref p1, ref p5);
			SwapIfLesser(ref p1, ref p4);
			SwapIfLesser(ref p2, ref p7);
			SwapIfLesser(ref p3, ref p8);
			SwapIfLesser(ref p3, ref p7);
			SwapIfLesser(ref p2, ref p5);
			SwapIfLesser(ref p2, ref p4);
			SwapIfLesser(ref p3, ref p6);
			SwapIfLesser(ref p3, ref p5);
			SwapIfLesser(ref p3, ref p4);
			SwapIfLesser(ref p9, ref p10);
			SwapIfLesser(ref p12, ref p13);
			SwapIfLesser(ref p11, ref p13);
			SwapIfLesser(ref p11, ref p12);
			SwapIfLesser(ref p9, ref p12);
			SwapIfLesser(ref p9, ref p11);
			SwapIfLesser(ref p10, ref p13);
			SwapIfLesser(ref p10, ref p12);
			SwapIfLesser(ref p10, ref p11);
			SwapIfLesser(ref p14, ref p15);
			SwapIfLesser(ref p17, ref p18);
			SwapIfLesser(ref p16, ref p18);
			SwapIfLesser(ref p16, ref p17);
			SwapIfLesser(ref p14, ref p17);
			SwapIfLesser(ref p14, ref p16);
			SwapIfLesser(ref p15, ref p18);
			SwapIfLesser(ref p15, ref p17);
			SwapIfLesser(ref p15, ref p16);
			SwapIfLesser(ref p9, ref p15);
			SwapIfLesser(ref p9, ref p14);
			SwapIfLesser(ref p10, ref p16);
			SwapIfLesser(ref p10, ref p15);
			SwapIfLesser(ref p10, ref p14);
			SwapIfLesser(ref p11, ref p17);
			SwapIfLesser(ref p12, ref p18);
			SwapIfLesser(ref p13, ref p18);
			SwapIfLesser(ref p12, ref p17);
			SwapIfLesser(ref p13, ref p17);
			SwapIfLesser(ref p11, ref p15);
			SwapIfLesser(ref p11, ref p14);
			SwapIfLesser(ref p12, ref p16);
			SwapIfLesser(ref p13, ref p16);
			SwapIfLesser(ref p12, ref p14);
			SwapIfLesser(ref p13, ref p15);
			SwapIfLesser(ref p13, ref p14);
			SwapIfLesser(ref p0, ref p10);
			SwapIfLesser(ref p0, ref p9);
			SwapIfLesser(ref p1, ref p11);
			SwapIfLesser(ref p1, ref p10);
			SwapIfLesser(ref p1, ref p9);
			SwapIfLesser(ref p2, ref p12);
			SwapIfLesser(ref p3, ref p13);
			SwapIfLesser(ref p3, ref p12);
			SwapIfLesser(ref p2, ref p10);
			SwapIfLesser(ref p2, ref p9);
			SwapIfLesser(ref p3, ref p11);
			SwapIfLesser(ref p3, ref p10);
			SwapIfLesser(ref p3, ref p9);
			SwapIfLesser(ref p4, ref p15);
			SwapIfLesser(ref p4, ref p14);
			SwapIfLesser(ref p5, ref p16);
			SwapIfLesser(ref p5, ref p15);
			SwapIfLesser(ref p5, ref p14);
			SwapIfLesser(ref p6, ref p17);
			SwapIfLesser(ref p7, ref p18);
			SwapIfLesser(ref p8, ref p18);
			SwapIfLesser(ref p7, ref p17);
			SwapIfLesser(ref p8, ref p17);
			SwapIfLesser(ref p6, ref p15);
			SwapIfLesser(ref p6, ref p14);
			SwapIfLesser(ref p7, ref p16);
			SwapIfLesser(ref p8, ref p16);
			SwapIfLesser(ref p7, ref p14);
			SwapIfLesser(ref p8, ref p15);
			SwapIfLesser(ref p8, ref p14);
			SwapIfLesser(ref p4, ref p10);
			SwapIfLesser(ref p4, ref p9);
			SwapIfLesser(ref p5, ref p11);
			SwapIfLesser(ref p5, ref p10);
			SwapIfLesser(ref p5, ref p9);
			SwapIfLesser(ref p6, ref p12);
			SwapIfLesser(ref p7, ref p13);
			SwapIfLesser(ref p8, ref p13);
			SwapIfLesser(ref p7, ref p12);
			SwapIfLesser(ref p8, ref p12);
			SwapIfLesser(ref p6, ref p10);
			SwapIfLesser(ref p6, ref p9);
			SwapIfLesser(ref p7, ref p11);
			SwapIfLesser(ref p8, ref p11);
			SwapIfLesser(ref p7, ref p9);
			SwapIfLesser(ref p8, ref p10);
			SwapIfLesser(ref p8, ref p9);
		}

		/// <summary>
		/// Sorts a collection of 20 elements in ascending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort20Ascending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);
			ref var p10 = ref Unsafe.Add(ref p9, 10);
			ref var p11 = ref Unsafe.Add(ref p10, 11);
			ref var p12 = ref Unsafe.Add(ref p11, 12);
			ref var p13 = ref Unsafe.Add(ref p12, 13);
			ref var p14 = ref Unsafe.Add(ref p13, 14);
			ref var p15 = ref Unsafe.Add(ref p14, 15);
			ref var p16 = ref Unsafe.Add(ref p15, 16);
			ref var p17 = ref Unsafe.Add(ref p16, 17);
			ref var p18 = ref Unsafe.Add(ref p17, 18);
			ref var p19 = ref Unsafe.Add(ref p18, 19);

			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p3, ref p4);
			SwapIfGreater(ref p2, ref p4);
			SwapIfGreater(ref p2, ref p3);
			SwapIfGreater(ref p0, ref p3);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p1, ref p4);
			SwapIfGreater(ref p1, ref p3);
			SwapIfGreater(ref p1, ref p2);
			SwapIfGreater(ref p5, ref p6);
			SwapIfGreater(ref p8, ref p9);
			SwapIfGreater(ref p7, ref p9);
			SwapIfGreater(ref p7, ref p8);
			SwapIfGreater(ref p5, ref p8);
			SwapIfGreater(ref p5, ref p7);
			SwapIfGreater(ref p6, ref p9);
			SwapIfGreater(ref p6, ref p8);
			SwapIfGreater(ref p6, ref p7);
			SwapIfGreater(ref p0, ref p6);
			SwapIfGreater(ref p0, ref p5);
			SwapIfGreater(ref p1, ref p7);
			SwapIfGreater(ref p1, ref p6);
			SwapIfGreater(ref p1, ref p5);
			SwapIfGreater(ref p2, ref p8);
			SwapIfGreater(ref p3, ref p9);
			SwapIfGreater(ref p4, ref p9);
			SwapIfGreater(ref p3, ref p8);
			SwapIfGreater(ref p4, ref p8);
			SwapIfGreater(ref p2, ref p6);
			SwapIfGreater(ref p2, ref p5);
			SwapIfGreater(ref p3, ref p7);
			SwapIfGreater(ref p4, ref p7);
			SwapIfGreater(ref p3, ref p5);
			SwapIfGreater(ref p4, ref p6);
			SwapIfGreater(ref p4, ref p5);
			SwapIfGreater(ref p10, ref p11);
			SwapIfGreater(ref p13, ref p14);
			SwapIfGreater(ref p12, ref p14);
			SwapIfGreater(ref p12, ref p13);
			SwapIfGreater(ref p10, ref p13);
			SwapIfGreater(ref p10, ref p12);
			SwapIfGreater(ref p11, ref p14);
			SwapIfGreater(ref p11, ref p13);
			SwapIfGreater(ref p11, ref p12);
			SwapIfGreater(ref p15, ref p16);
			SwapIfGreater(ref p18, ref p19);
			SwapIfGreater(ref p17, ref p19);
			SwapIfGreater(ref p17, ref p18);
			SwapIfGreater(ref p15, ref p18);
			SwapIfGreater(ref p15, ref p17);
			SwapIfGreater(ref p16, ref p19);
			SwapIfGreater(ref p16, ref p18);
			SwapIfGreater(ref p16, ref p17);
			SwapIfGreater(ref p10, ref p16);
			SwapIfGreater(ref p10, ref p15);
			SwapIfGreater(ref p11, ref p17);
			SwapIfGreater(ref p11, ref p16);
			SwapIfGreater(ref p11, ref p15);
			SwapIfGreater(ref p12, ref p18);
			SwapIfGreater(ref p13, ref p19);
			SwapIfGreater(ref p14, ref p19);
			SwapIfGreater(ref p13, ref p18);
			SwapIfGreater(ref p14, ref p18);
			SwapIfGreater(ref p12, ref p16);
			SwapIfGreater(ref p12, ref p15);
			SwapIfGreater(ref p13, ref p17);
			SwapIfGreater(ref p14, ref p17);
			SwapIfGreater(ref p13, ref p15);
			SwapIfGreater(ref p14, ref p16);
			SwapIfGreater(ref p14, ref p15);
			SwapIfGreater(ref p0, ref p11);
			SwapIfGreater(ref p0, ref p10);
			SwapIfGreater(ref p1, ref p12);
			SwapIfGreater(ref p1, ref p11);
			SwapIfGreater(ref p1, ref p10);
			SwapIfGreater(ref p2, ref p13);
			SwapIfGreater(ref p3, ref p14);
			SwapIfGreater(ref p4, ref p14);
			SwapIfGreater(ref p3, ref p13);
			SwapIfGreater(ref p4, ref p13);
			SwapIfGreater(ref p2, ref p11);
			SwapIfGreater(ref p2, ref p10);
			SwapIfGreater(ref p3, ref p12);
			SwapIfGreater(ref p4, ref p12);
			SwapIfGreater(ref p3, ref p10);
			SwapIfGreater(ref p4, ref p11);
			SwapIfGreater(ref p4, ref p10);
			SwapIfGreater(ref p5, ref p16);
			SwapIfGreater(ref p5, ref p15);
			SwapIfGreater(ref p6, ref p17);
			SwapIfGreater(ref p6, ref p16);
			SwapIfGreater(ref p6, ref p15);
			SwapIfGreater(ref p7, ref p18);
			SwapIfGreater(ref p8, ref p19);
			SwapIfGreater(ref p9, ref p19);
			SwapIfGreater(ref p8, ref p18);
			SwapIfGreater(ref p9, ref p18);
			SwapIfGreater(ref p7, ref p16);
			SwapIfGreater(ref p7, ref p15);
			SwapIfGreater(ref p8, ref p17);
			SwapIfGreater(ref p9, ref p17);
			SwapIfGreater(ref p8, ref p15);
			SwapIfGreater(ref p9, ref p16);
			SwapIfGreater(ref p9, ref p15);
			SwapIfGreater(ref p5, ref p11);
			SwapIfGreater(ref p5, ref p10);
			SwapIfGreater(ref p6, ref p12);
			SwapIfGreater(ref p6, ref p11);
			SwapIfGreater(ref p6, ref p10);
			SwapIfGreater(ref p7, ref p13);
			SwapIfGreater(ref p8, ref p14);
			SwapIfGreater(ref p9, ref p14);
			SwapIfGreater(ref p8, ref p13);
			SwapIfGreater(ref p9, ref p13);
			SwapIfGreater(ref p7, ref p11);
			SwapIfGreater(ref p7, ref p10);
			SwapIfGreater(ref p8, ref p12);
			SwapIfGreater(ref p9, ref p12);
			SwapIfGreater(ref p8, ref p10);
			SwapIfGreater(ref p9, ref p11);
			SwapIfGreater(ref p9, ref p10);
		}

		/// <summary>
		/// Sorts a collection of 20 elements in descending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort20Descending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);
			ref var p10 = ref Unsafe.Add(ref p9, 10);
			ref var p11 = ref Unsafe.Add(ref p10, 11);
			ref var p12 = ref Unsafe.Add(ref p11, 12);
			ref var p13 = ref Unsafe.Add(ref p12, 13);
			ref var p14 = ref Unsafe.Add(ref p13, 14);
			ref var p15 = ref Unsafe.Add(ref p14, 15);
			ref var p16 = ref Unsafe.Add(ref p15, 16);
			ref var p17 = ref Unsafe.Add(ref p16, 17);
			ref var p18 = ref Unsafe.Add(ref p17, 18);
			ref var p19 = ref Unsafe.Add(ref p18, 19);

			SwapIfLesser(ref p0, ref p1);
			SwapIfLesser(ref p3, ref p4);
			SwapIfLesser(ref p2, ref p4);
			SwapIfLesser(ref p2, ref p3);
			SwapIfLesser(ref p0, ref p3);
			SwapIfLesser(ref p0, ref p2);
			SwapIfLesser(ref p1, ref p4);
			SwapIfLesser(ref p1, ref p3);
			SwapIfLesser(ref p1, ref p2);
			SwapIfLesser(ref p5, ref p6);
			SwapIfLesser(ref p8, ref p9);
			SwapIfLesser(ref p7, ref p9);
			SwapIfLesser(ref p7, ref p8);
			SwapIfLesser(ref p5, ref p8);
			SwapIfLesser(ref p5, ref p7);
			SwapIfLesser(ref p6, ref p9);
			SwapIfLesser(ref p6, ref p8);
			SwapIfLesser(ref p6, ref p7);
			SwapIfLesser(ref p0, ref p6);
			SwapIfLesser(ref p0, ref p5);
			SwapIfLesser(ref p1, ref p7);
			SwapIfLesser(ref p1, ref p6);
			SwapIfLesser(ref p1, ref p5);
			SwapIfLesser(ref p2, ref p8);
			SwapIfLesser(ref p3, ref p9);
			SwapIfLesser(ref p4, ref p9);
			SwapIfLesser(ref p3, ref p8);
			SwapIfLesser(ref p4, ref p8);
			SwapIfLesser(ref p2, ref p6);
			SwapIfLesser(ref p2, ref p5);
			SwapIfLesser(ref p3, ref p7);
			SwapIfLesser(ref p4, ref p7);
			SwapIfLesser(ref p3, ref p5);
			SwapIfLesser(ref p4, ref p6);
			SwapIfLesser(ref p4, ref p5);
			SwapIfLesser(ref p10, ref p11);
			SwapIfLesser(ref p13, ref p14);
			SwapIfLesser(ref p12, ref p14);
			SwapIfLesser(ref p12, ref p13);
			SwapIfLesser(ref p10, ref p13);
			SwapIfLesser(ref p10, ref p12);
			SwapIfLesser(ref p11, ref p14);
			SwapIfLesser(ref p11, ref p13);
			SwapIfLesser(ref p11, ref p12);
			SwapIfLesser(ref p15, ref p16);
			SwapIfLesser(ref p18, ref p19);
			SwapIfLesser(ref p17, ref p19);
			SwapIfLesser(ref p17, ref p18);
			SwapIfLesser(ref p15, ref p18);
			SwapIfLesser(ref p15, ref p17);
			SwapIfLesser(ref p16, ref p19);
			SwapIfLesser(ref p16, ref p18);
			SwapIfLesser(ref p16, ref p17);
			SwapIfLesser(ref p10, ref p16);
			SwapIfLesser(ref p10, ref p15);
			SwapIfLesser(ref p11, ref p17);
			SwapIfLesser(ref p11, ref p16);
			SwapIfLesser(ref p11, ref p15);
			SwapIfLesser(ref p12, ref p18);
			SwapIfLesser(ref p13, ref p19);
			SwapIfLesser(ref p14, ref p19);
			SwapIfLesser(ref p13, ref p18);
			SwapIfLesser(ref p14, ref p18);
			SwapIfLesser(ref p12, ref p16);
			SwapIfLesser(ref p12, ref p15);
			SwapIfLesser(ref p13, ref p17);
			SwapIfLesser(ref p14, ref p17);
			SwapIfLesser(ref p13, ref p15);
			SwapIfLesser(ref p14, ref p16);
			SwapIfLesser(ref p14, ref p15);
			SwapIfLesser(ref p0, ref p11);
			SwapIfLesser(ref p0, ref p10);
			SwapIfLesser(ref p1, ref p12);
			SwapIfLesser(ref p1, ref p11);
			SwapIfLesser(ref p1, ref p10);
			SwapIfLesser(ref p2, ref p13);
			SwapIfLesser(ref p3, ref p14);
			SwapIfLesser(ref p4, ref p14);
			SwapIfLesser(ref p3, ref p13);
			SwapIfLesser(ref p4, ref p13);
			SwapIfLesser(ref p2, ref p11);
			SwapIfLesser(ref p2, ref p10);
			SwapIfLesser(ref p3, ref p12);
			SwapIfLesser(ref p4, ref p12);
			SwapIfLesser(ref p3, ref p10);
			SwapIfLesser(ref p4, ref p11);
			SwapIfLesser(ref p4, ref p10);
			SwapIfLesser(ref p5, ref p16);
			SwapIfLesser(ref p5, ref p15);
			SwapIfLesser(ref p6, ref p17);
			SwapIfLesser(ref p6, ref p16);
			SwapIfLesser(ref p6, ref p15);
			SwapIfLesser(ref p7, ref p18);
			SwapIfLesser(ref p8, ref p19);
			SwapIfLesser(ref p9, ref p19);
			SwapIfLesser(ref p8, ref p18);
			SwapIfLesser(ref p9, ref p18);
			SwapIfLesser(ref p7, ref p16);
			SwapIfLesser(ref p7, ref p15);
			SwapIfLesser(ref p8, ref p17);
			SwapIfLesser(ref p9, ref p17);
			SwapIfLesser(ref p8, ref p15);
			SwapIfLesser(ref p9, ref p16);
			SwapIfLesser(ref p9, ref p15);
			SwapIfLesser(ref p5, ref p11);
			SwapIfLesser(ref p5, ref p10);
			SwapIfLesser(ref p6, ref p12);
			SwapIfLesser(ref p6, ref p11);
			SwapIfLesser(ref p6, ref p10);
			SwapIfLesser(ref p7, ref p13);
			SwapIfLesser(ref p8, ref p14);
			SwapIfLesser(ref p9, ref p14);
			SwapIfLesser(ref p8, ref p13);
			SwapIfLesser(ref p9, ref p13);
			SwapIfLesser(ref p7, ref p11);
			SwapIfLesser(ref p7, ref p10);
			SwapIfLesser(ref p8, ref p12);
			SwapIfLesser(ref p9, ref p12);
			SwapIfLesser(ref p8, ref p10);
			SwapIfLesser(ref p9, ref p11);
			SwapIfLesser(ref p9, ref p10);
		}

		/// <summary>
		/// Sorts a collection of 21 elements in ascending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort21Ascending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);
			ref var p10 = ref Unsafe.Add(ref p9, 10);
			ref var p11 = ref Unsafe.Add(ref p10, 11);
			ref var p12 = ref Unsafe.Add(ref p11, 12);
			ref var p13 = ref Unsafe.Add(ref p12, 13);
			ref var p14 = ref Unsafe.Add(ref p13, 14);
			ref var p15 = ref Unsafe.Add(ref p14, 15);
			ref var p16 = ref Unsafe.Add(ref p15, 16);
			ref var p17 = ref Unsafe.Add(ref p16, 17);
			ref var p18 = ref Unsafe.Add(ref p17, 18);
			ref var p19 = ref Unsafe.Add(ref p18, 19);
			ref var p20 = ref Unsafe.Add(ref p19, 20);

			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p3, ref p4);
			SwapIfGreater(ref p2, ref p4);
			SwapIfGreater(ref p2, ref p3);
			SwapIfGreater(ref p0, ref p3);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p1, ref p4);
			SwapIfGreater(ref p1, ref p3);
			SwapIfGreater(ref p1, ref p2);
			SwapIfGreater(ref p5, ref p6);
			SwapIfGreater(ref p8, ref p9);
			SwapIfGreater(ref p7, ref p9);
			SwapIfGreater(ref p7, ref p8);
			SwapIfGreater(ref p5, ref p8);
			SwapIfGreater(ref p5, ref p7);
			SwapIfGreater(ref p6, ref p9);
			SwapIfGreater(ref p6, ref p8);
			SwapIfGreater(ref p6, ref p7);
			SwapIfGreater(ref p0, ref p6);
			SwapIfGreater(ref p0, ref p5);
			SwapIfGreater(ref p1, ref p7);
			SwapIfGreater(ref p1, ref p6);
			SwapIfGreater(ref p1, ref p5);
			SwapIfGreater(ref p2, ref p8);
			SwapIfGreater(ref p3, ref p9);
			SwapIfGreater(ref p4, ref p9);
			SwapIfGreater(ref p3, ref p8);
			SwapIfGreater(ref p4, ref p8);
			SwapIfGreater(ref p2, ref p6);
			SwapIfGreater(ref p2, ref p5);
			SwapIfGreater(ref p3, ref p7);
			SwapIfGreater(ref p4, ref p7);
			SwapIfGreater(ref p3, ref p5);
			SwapIfGreater(ref p4, ref p6);
			SwapIfGreater(ref p4, ref p5);
			SwapIfGreater(ref p10, ref p11);
			SwapIfGreater(ref p13, ref p14);
			SwapIfGreater(ref p12, ref p14);
			SwapIfGreater(ref p12, ref p13);
			SwapIfGreater(ref p10, ref p13);
			SwapIfGreater(ref p10, ref p12);
			SwapIfGreater(ref p11, ref p14);
			SwapIfGreater(ref p11, ref p13);
			SwapIfGreater(ref p11, ref p12);
			SwapIfGreater(ref p16, ref p17);
			SwapIfGreater(ref p15, ref p17);
			SwapIfGreater(ref p15, ref p16);
			SwapIfGreater(ref p19, ref p20);
			SwapIfGreater(ref p18, ref p20);
			SwapIfGreater(ref p18, ref p19);
			SwapIfGreater(ref p15, ref p19);
			SwapIfGreater(ref p15, ref p18);
			SwapIfGreater(ref p16, ref p20);
			SwapIfGreater(ref p17, ref p20);
			SwapIfGreater(ref p16, ref p18);
			SwapIfGreater(ref p17, ref p19);
			SwapIfGreater(ref p17, ref p18);
			SwapIfGreater(ref p10, ref p16);
			SwapIfGreater(ref p10, ref p15);
			SwapIfGreater(ref p11, ref p17);
			SwapIfGreater(ref p11, ref p16);
			SwapIfGreater(ref p11, ref p15);
			SwapIfGreater(ref p12, ref p19);
			SwapIfGreater(ref p12, ref p18);
			SwapIfGreater(ref p13, ref p20);
			SwapIfGreater(ref p14, ref p20);
			SwapIfGreater(ref p13, ref p18);
			SwapIfGreater(ref p14, ref p19);
			SwapIfGreater(ref p14, ref p18);
			SwapIfGreater(ref p12, ref p16);
			SwapIfGreater(ref p12, ref p15);
			SwapIfGreater(ref p13, ref p17);
			SwapIfGreater(ref p14, ref p17);
			SwapIfGreater(ref p13, ref p15);
			SwapIfGreater(ref p14, ref p16);
			SwapIfGreater(ref p14, ref p15);
			SwapIfGreater(ref p0, ref p11);
			SwapIfGreater(ref p0, ref p10);
			SwapIfGreater(ref p1, ref p12);
			SwapIfGreater(ref p1, ref p11);
			SwapIfGreater(ref p1, ref p10);
			SwapIfGreater(ref p2, ref p14);
			SwapIfGreater(ref p2, ref p13);
			SwapIfGreater(ref p3, ref p15);
			SwapIfGreater(ref p4, ref p15);
			SwapIfGreater(ref p3, ref p13);
			SwapIfGreater(ref p4, ref p14);
			SwapIfGreater(ref p4, ref p13);
			SwapIfGreater(ref p2, ref p11);
			SwapIfGreater(ref p2, ref p10);
			SwapIfGreater(ref p3, ref p12);
			SwapIfGreater(ref p4, ref p12);
			SwapIfGreater(ref p3, ref p10);
			SwapIfGreater(ref p4, ref p11);
			SwapIfGreater(ref p4, ref p10);
			SwapIfGreater(ref p5, ref p17);
			SwapIfGreater(ref p5, ref p16);
			SwapIfGreater(ref p6, ref p18);
			SwapIfGreater(ref p6, ref p17);
			SwapIfGreater(ref p6, ref p16);
			SwapIfGreater(ref p7, ref p19);
			SwapIfGreater(ref p8, ref p20);
			SwapIfGreater(ref p9, ref p20);
			SwapIfGreater(ref p8, ref p19);
			SwapIfGreater(ref p9, ref p19);
			SwapIfGreater(ref p7, ref p17);
			SwapIfGreater(ref p7, ref p16);
			SwapIfGreater(ref p8, ref p18);
			SwapIfGreater(ref p9, ref p18);
			SwapIfGreater(ref p8, ref p16);
			SwapIfGreater(ref p9, ref p17);
			SwapIfGreater(ref p9, ref p16);
			SwapIfGreater(ref p5, ref p11);
			SwapIfGreater(ref p5, ref p10);
			SwapIfGreater(ref p6, ref p12);
			SwapIfGreater(ref p6, ref p11);
			SwapIfGreater(ref p6, ref p10);
			SwapIfGreater(ref p7, ref p14);
			SwapIfGreater(ref p7, ref p13);
			SwapIfGreater(ref p8, ref p15);
			SwapIfGreater(ref p9, ref p15);
			SwapIfGreater(ref p8, ref p13);
			SwapIfGreater(ref p9, ref p14);
			SwapIfGreater(ref p9, ref p13);
			SwapIfGreater(ref p7, ref p11);
			SwapIfGreater(ref p7, ref p10);
			SwapIfGreater(ref p8, ref p12);
			SwapIfGreater(ref p9, ref p12);
			SwapIfGreater(ref p8, ref p10);
			SwapIfGreater(ref p9, ref p11);
			SwapIfGreater(ref p9, ref p10);
		}

		/// <summary>
		/// Sorts a collection of 21 elements in descending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort21Descending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);
			ref var p10 = ref Unsafe.Add(ref p9, 10);
			ref var p11 = ref Unsafe.Add(ref p10, 11);
			ref var p12 = ref Unsafe.Add(ref p11, 12);
			ref var p13 = ref Unsafe.Add(ref p12, 13);
			ref var p14 = ref Unsafe.Add(ref p13, 14);
			ref var p15 = ref Unsafe.Add(ref p14, 15);
			ref var p16 = ref Unsafe.Add(ref p15, 16);
			ref var p17 = ref Unsafe.Add(ref p16, 17);
			ref var p18 = ref Unsafe.Add(ref p17, 18);
			ref var p19 = ref Unsafe.Add(ref p18, 19);
			ref var p20 = ref Unsafe.Add(ref p19, 20);

			SwapIfLesser(ref p0, ref p1);
			SwapIfLesser(ref p3, ref p4);
			SwapIfLesser(ref p2, ref p4);
			SwapIfLesser(ref p2, ref p3);
			SwapIfLesser(ref p0, ref p3);
			SwapIfLesser(ref p0, ref p2);
			SwapIfLesser(ref p1, ref p4);
			SwapIfLesser(ref p1, ref p3);
			SwapIfLesser(ref p1, ref p2);
			SwapIfLesser(ref p5, ref p6);
			SwapIfLesser(ref p8, ref p9);
			SwapIfLesser(ref p7, ref p9);
			SwapIfLesser(ref p7, ref p8);
			SwapIfLesser(ref p5, ref p8);
			SwapIfLesser(ref p5, ref p7);
			SwapIfLesser(ref p6, ref p9);
			SwapIfLesser(ref p6, ref p8);
			SwapIfLesser(ref p6, ref p7);
			SwapIfLesser(ref p0, ref p6);
			SwapIfLesser(ref p0, ref p5);
			SwapIfLesser(ref p1, ref p7);
			SwapIfLesser(ref p1, ref p6);
			SwapIfLesser(ref p1, ref p5);
			SwapIfLesser(ref p2, ref p8);
			SwapIfLesser(ref p3, ref p9);
			SwapIfLesser(ref p4, ref p9);
			SwapIfLesser(ref p3, ref p8);
			SwapIfLesser(ref p4, ref p8);
			SwapIfLesser(ref p2, ref p6);
			SwapIfLesser(ref p2, ref p5);
			SwapIfLesser(ref p3, ref p7);
			SwapIfLesser(ref p4, ref p7);
			SwapIfLesser(ref p3, ref p5);
			SwapIfLesser(ref p4, ref p6);
			SwapIfLesser(ref p4, ref p5);
			SwapIfLesser(ref p10, ref p11);
			SwapIfLesser(ref p13, ref p14);
			SwapIfLesser(ref p12, ref p14);
			SwapIfLesser(ref p12, ref p13);
			SwapIfLesser(ref p10, ref p13);
			SwapIfLesser(ref p10, ref p12);
			SwapIfLesser(ref p11, ref p14);
			SwapIfLesser(ref p11, ref p13);
			SwapIfLesser(ref p11, ref p12);
			SwapIfLesser(ref p16, ref p17);
			SwapIfLesser(ref p15, ref p17);
			SwapIfLesser(ref p15, ref p16);
			SwapIfLesser(ref p19, ref p20);
			SwapIfLesser(ref p18, ref p20);
			SwapIfLesser(ref p18, ref p19);
			SwapIfLesser(ref p15, ref p19);
			SwapIfLesser(ref p15, ref p18);
			SwapIfLesser(ref p16, ref p20);
			SwapIfLesser(ref p17, ref p20);
			SwapIfLesser(ref p16, ref p18);
			SwapIfLesser(ref p17, ref p19);
			SwapIfLesser(ref p17, ref p18);
			SwapIfLesser(ref p10, ref p16);
			SwapIfLesser(ref p10, ref p15);
			SwapIfLesser(ref p11, ref p17);
			SwapIfLesser(ref p11, ref p16);
			SwapIfLesser(ref p11, ref p15);
			SwapIfLesser(ref p12, ref p19);
			SwapIfLesser(ref p12, ref p18);
			SwapIfLesser(ref p13, ref p20);
			SwapIfLesser(ref p14, ref p20);
			SwapIfLesser(ref p13, ref p18);
			SwapIfLesser(ref p14, ref p19);
			SwapIfLesser(ref p14, ref p18);
			SwapIfLesser(ref p12, ref p16);
			SwapIfLesser(ref p12, ref p15);
			SwapIfLesser(ref p13, ref p17);
			SwapIfLesser(ref p14, ref p17);
			SwapIfLesser(ref p13, ref p15);
			SwapIfLesser(ref p14, ref p16);
			SwapIfLesser(ref p14, ref p15);
			SwapIfLesser(ref p0, ref p11);
			SwapIfLesser(ref p0, ref p10);
			SwapIfLesser(ref p1, ref p12);
			SwapIfLesser(ref p1, ref p11);
			SwapIfLesser(ref p1, ref p10);
			SwapIfLesser(ref p2, ref p14);
			SwapIfLesser(ref p2, ref p13);
			SwapIfLesser(ref p3, ref p15);
			SwapIfLesser(ref p4, ref p15);
			SwapIfLesser(ref p3, ref p13);
			SwapIfLesser(ref p4, ref p14);
			SwapIfLesser(ref p4, ref p13);
			SwapIfLesser(ref p2, ref p11);
			SwapIfLesser(ref p2, ref p10);
			SwapIfLesser(ref p3, ref p12);
			SwapIfLesser(ref p4, ref p12);
			SwapIfLesser(ref p3, ref p10);
			SwapIfLesser(ref p4, ref p11);
			SwapIfLesser(ref p4, ref p10);
			SwapIfLesser(ref p5, ref p17);
			SwapIfLesser(ref p5, ref p16);
			SwapIfLesser(ref p6, ref p18);
			SwapIfLesser(ref p6, ref p17);
			SwapIfLesser(ref p6, ref p16);
			SwapIfLesser(ref p7, ref p19);
			SwapIfLesser(ref p8, ref p20);
			SwapIfLesser(ref p9, ref p20);
			SwapIfLesser(ref p8, ref p19);
			SwapIfLesser(ref p9, ref p19);
			SwapIfLesser(ref p7, ref p17);
			SwapIfLesser(ref p7, ref p16);
			SwapIfLesser(ref p8, ref p18);
			SwapIfLesser(ref p9, ref p18);
			SwapIfLesser(ref p8, ref p16);
			SwapIfLesser(ref p9, ref p17);
			SwapIfLesser(ref p9, ref p16);
			SwapIfLesser(ref p5, ref p11);
			SwapIfLesser(ref p5, ref p10);
			SwapIfLesser(ref p6, ref p12);
			SwapIfLesser(ref p6, ref p11);
			SwapIfLesser(ref p6, ref p10);
			SwapIfLesser(ref p7, ref p14);
			SwapIfLesser(ref p7, ref p13);
			SwapIfLesser(ref p8, ref p15);
			SwapIfLesser(ref p9, ref p15);
			SwapIfLesser(ref p8, ref p13);
			SwapIfLesser(ref p9, ref p14);
			SwapIfLesser(ref p9, ref p13);
			SwapIfLesser(ref p7, ref p11);
			SwapIfLesser(ref p7, ref p10);
			SwapIfLesser(ref p8, ref p12);
			SwapIfLesser(ref p9, ref p12);
			SwapIfLesser(ref p8, ref p10);
			SwapIfLesser(ref p9, ref p11);
			SwapIfLesser(ref p9, ref p10);
		}

		/// <summary>
		/// Sorts a collection of 22 elements in ascending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort22Ascending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);
			ref var p10 = ref Unsafe.Add(ref p9, 10);
			ref var p11 = ref Unsafe.Add(ref p10, 11);
			ref var p12 = ref Unsafe.Add(ref p11, 12);
			ref var p13 = ref Unsafe.Add(ref p12, 13);
			ref var p14 = ref Unsafe.Add(ref p13, 14);
			ref var p15 = ref Unsafe.Add(ref p14, 15);
			ref var p16 = ref Unsafe.Add(ref p15, 16);
			ref var p17 = ref Unsafe.Add(ref p16, 17);
			ref var p18 = ref Unsafe.Add(ref p17, 18);
			ref var p19 = ref Unsafe.Add(ref p18, 19);
			ref var p20 = ref Unsafe.Add(ref p19, 20);
			ref var p21 = ref Unsafe.Add(ref p20, 21);

			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p3, ref p4);
			SwapIfGreater(ref p2, ref p4);
			SwapIfGreater(ref p2, ref p3);
			SwapIfGreater(ref p0, ref p3);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p1, ref p4);
			SwapIfGreater(ref p1, ref p3);
			SwapIfGreater(ref p1, ref p2);
			SwapIfGreater(ref p6, ref p7);
			SwapIfGreater(ref p5, ref p7);
			SwapIfGreater(ref p5, ref p6);
			SwapIfGreater(ref p9, ref p10);
			SwapIfGreater(ref p8, ref p10);
			SwapIfGreater(ref p8, ref p9);
			SwapIfGreater(ref p5, ref p9);
			SwapIfGreater(ref p5, ref p8);
			SwapIfGreater(ref p6, ref p10);
			SwapIfGreater(ref p7, ref p10);
			SwapIfGreater(ref p6, ref p8);
			SwapIfGreater(ref p7, ref p9);
			SwapIfGreater(ref p7, ref p8);
			SwapIfGreater(ref p0, ref p6);
			SwapIfGreater(ref p0, ref p5);
			SwapIfGreater(ref p1, ref p7);
			SwapIfGreater(ref p1, ref p6);
			SwapIfGreater(ref p1, ref p5);
			SwapIfGreater(ref p2, ref p9);
			SwapIfGreater(ref p2, ref p8);
			SwapIfGreater(ref p3, ref p10);
			SwapIfGreater(ref p4, ref p10);
			SwapIfGreater(ref p3, ref p8);
			SwapIfGreater(ref p4, ref p9);
			SwapIfGreater(ref p4, ref p8);
			SwapIfGreater(ref p2, ref p6);
			SwapIfGreater(ref p2, ref p5);
			SwapIfGreater(ref p3, ref p7);
			SwapIfGreater(ref p4, ref p7);
			SwapIfGreater(ref p3, ref p5);
			SwapIfGreater(ref p4, ref p6);
			SwapIfGreater(ref p4, ref p5);
			SwapIfGreater(ref p11, ref p12);
			SwapIfGreater(ref p14, ref p15);
			SwapIfGreater(ref p13, ref p15);
			SwapIfGreater(ref p13, ref p14);
			SwapIfGreater(ref p11, ref p14);
			SwapIfGreater(ref p11, ref p13);
			SwapIfGreater(ref p12, ref p15);
			SwapIfGreater(ref p12, ref p14);
			SwapIfGreater(ref p12, ref p13);
			SwapIfGreater(ref p17, ref p18);
			SwapIfGreater(ref p16, ref p18);
			SwapIfGreater(ref p16, ref p17);
			SwapIfGreater(ref p20, ref p21);
			SwapIfGreater(ref p19, ref p21);
			SwapIfGreater(ref p19, ref p20);
			SwapIfGreater(ref p16, ref p20);
			SwapIfGreater(ref p16, ref p19);
			SwapIfGreater(ref p17, ref p21);
			SwapIfGreater(ref p18, ref p21);
			SwapIfGreater(ref p17, ref p19);
			SwapIfGreater(ref p18, ref p20);
			SwapIfGreater(ref p18, ref p19);
			SwapIfGreater(ref p11, ref p17);
			SwapIfGreater(ref p11, ref p16);
			SwapIfGreater(ref p12, ref p18);
			SwapIfGreater(ref p12, ref p17);
			SwapIfGreater(ref p12, ref p16);
			SwapIfGreater(ref p13, ref p20);
			SwapIfGreater(ref p13, ref p19);
			SwapIfGreater(ref p14, ref p21);
			SwapIfGreater(ref p15, ref p21);
			SwapIfGreater(ref p14, ref p19);
			SwapIfGreater(ref p15, ref p20);
			SwapIfGreater(ref p15, ref p19);
			SwapIfGreater(ref p13, ref p17);
			SwapIfGreater(ref p13, ref p16);
			SwapIfGreater(ref p14, ref p18);
			SwapIfGreater(ref p15, ref p18);
			SwapIfGreater(ref p14, ref p16);
			SwapIfGreater(ref p15, ref p17);
			SwapIfGreater(ref p15, ref p16);
			SwapIfGreater(ref p0, ref p12);
			SwapIfGreater(ref p0, ref p11);
			SwapIfGreater(ref p1, ref p13);
			SwapIfGreater(ref p1, ref p12);
			SwapIfGreater(ref p1, ref p11);
			SwapIfGreater(ref p2, ref p15);
			SwapIfGreater(ref p2, ref p14);
			SwapIfGreater(ref p3, ref p16);
			SwapIfGreater(ref p4, ref p16);
			SwapIfGreater(ref p3, ref p14);
			SwapIfGreater(ref p4, ref p15);
			SwapIfGreater(ref p4, ref p14);
			SwapIfGreater(ref p2, ref p12);
			SwapIfGreater(ref p2, ref p11);
			SwapIfGreater(ref p3, ref p13);
			SwapIfGreater(ref p4, ref p13);
			SwapIfGreater(ref p3, ref p11);
			SwapIfGreater(ref p4, ref p12);
			SwapIfGreater(ref p4, ref p11);
			SwapIfGreater(ref p5, ref p18);
			SwapIfGreater(ref p5, ref p17);
			SwapIfGreater(ref p6, ref p19);
			SwapIfGreater(ref p7, ref p19);
			SwapIfGreater(ref p6, ref p17);
			SwapIfGreater(ref p7, ref p18);
			SwapIfGreater(ref p7, ref p17);
			SwapIfGreater(ref p8, ref p20);
			SwapIfGreater(ref p9, ref p21);
			SwapIfGreater(ref p10, ref p21);
			SwapIfGreater(ref p9, ref p20);
			SwapIfGreater(ref p10, ref p20);
			SwapIfGreater(ref p8, ref p18);
			SwapIfGreater(ref p8, ref p17);
			SwapIfGreater(ref p9, ref p19);
			SwapIfGreater(ref p10, ref p19);
			SwapIfGreater(ref p9, ref p17);
			SwapIfGreater(ref p10, ref p18);
			SwapIfGreater(ref p10, ref p17);
			SwapIfGreater(ref p5, ref p12);
			SwapIfGreater(ref p5, ref p11);
			SwapIfGreater(ref p6, ref p13);
			SwapIfGreater(ref p7, ref p13);
			SwapIfGreater(ref p6, ref p11);
			SwapIfGreater(ref p7, ref p12);
			SwapIfGreater(ref p7, ref p11);
			SwapIfGreater(ref p8, ref p15);
			SwapIfGreater(ref p8, ref p14);
			SwapIfGreater(ref p9, ref p16);
			SwapIfGreater(ref p10, ref p16);
			SwapIfGreater(ref p9, ref p14);
			SwapIfGreater(ref p10, ref p15);
			SwapIfGreater(ref p10, ref p14);
			SwapIfGreater(ref p8, ref p12);
			SwapIfGreater(ref p8, ref p11);
			SwapIfGreater(ref p9, ref p13);
			SwapIfGreater(ref p10, ref p13);
			SwapIfGreater(ref p9, ref p11);
			SwapIfGreater(ref p10, ref p12);
			SwapIfGreater(ref p10, ref p11);
		}

		/// <summary>
		/// Sorts a collection of 22 elements in descending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort22Descending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);
			ref var p10 = ref Unsafe.Add(ref p9, 10);
			ref var p11 = ref Unsafe.Add(ref p10, 11);
			ref var p12 = ref Unsafe.Add(ref p11, 12);
			ref var p13 = ref Unsafe.Add(ref p12, 13);
			ref var p14 = ref Unsafe.Add(ref p13, 14);
			ref var p15 = ref Unsafe.Add(ref p14, 15);
			ref var p16 = ref Unsafe.Add(ref p15, 16);
			ref var p17 = ref Unsafe.Add(ref p16, 17);
			ref var p18 = ref Unsafe.Add(ref p17, 18);
			ref var p19 = ref Unsafe.Add(ref p18, 19);
			ref var p20 = ref Unsafe.Add(ref p19, 20);
			ref var p21 = ref Unsafe.Add(ref p20, 21);

			SwapIfLesser(ref p0, ref p1);
			SwapIfLesser(ref p3, ref p4);
			SwapIfLesser(ref p2, ref p4);
			SwapIfLesser(ref p2, ref p3);
			SwapIfLesser(ref p0, ref p3);
			SwapIfLesser(ref p0, ref p2);
			SwapIfLesser(ref p1, ref p4);
			SwapIfLesser(ref p1, ref p3);
			SwapIfLesser(ref p1, ref p2);
			SwapIfLesser(ref p6, ref p7);
			SwapIfLesser(ref p5, ref p7);
			SwapIfLesser(ref p5, ref p6);
			SwapIfLesser(ref p9, ref p10);
			SwapIfLesser(ref p8, ref p10);
			SwapIfLesser(ref p8, ref p9);
			SwapIfLesser(ref p5, ref p9);
			SwapIfLesser(ref p5, ref p8);
			SwapIfLesser(ref p6, ref p10);
			SwapIfLesser(ref p7, ref p10);
			SwapIfLesser(ref p6, ref p8);
			SwapIfLesser(ref p7, ref p9);
			SwapIfLesser(ref p7, ref p8);
			SwapIfLesser(ref p0, ref p6);
			SwapIfLesser(ref p0, ref p5);
			SwapIfLesser(ref p1, ref p7);
			SwapIfLesser(ref p1, ref p6);
			SwapIfLesser(ref p1, ref p5);
			SwapIfLesser(ref p2, ref p9);
			SwapIfLesser(ref p2, ref p8);
			SwapIfLesser(ref p3, ref p10);
			SwapIfLesser(ref p4, ref p10);
			SwapIfLesser(ref p3, ref p8);
			SwapIfLesser(ref p4, ref p9);
			SwapIfLesser(ref p4, ref p8);
			SwapIfLesser(ref p2, ref p6);
			SwapIfLesser(ref p2, ref p5);
			SwapIfLesser(ref p3, ref p7);
			SwapIfLesser(ref p4, ref p7);
			SwapIfLesser(ref p3, ref p5);
			SwapIfLesser(ref p4, ref p6);
			SwapIfLesser(ref p4, ref p5);
			SwapIfLesser(ref p11, ref p12);
			SwapIfLesser(ref p14, ref p15);
			SwapIfLesser(ref p13, ref p15);
			SwapIfLesser(ref p13, ref p14);
			SwapIfLesser(ref p11, ref p14);
			SwapIfLesser(ref p11, ref p13);
			SwapIfLesser(ref p12, ref p15);
			SwapIfLesser(ref p12, ref p14);
			SwapIfLesser(ref p12, ref p13);
			SwapIfLesser(ref p17, ref p18);
			SwapIfLesser(ref p16, ref p18);
			SwapIfLesser(ref p16, ref p17);
			SwapIfLesser(ref p20, ref p21);
			SwapIfLesser(ref p19, ref p21);
			SwapIfLesser(ref p19, ref p20);
			SwapIfLesser(ref p16, ref p20);
			SwapIfLesser(ref p16, ref p19);
			SwapIfLesser(ref p17, ref p21);
			SwapIfLesser(ref p18, ref p21);
			SwapIfLesser(ref p17, ref p19);
			SwapIfLesser(ref p18, ref p20);
			SwapIfLesser(ref p18, ref p19);
			SwapIfLesser(ref p11, ref p17);
			SwapIfLesser(ref p11, ref p16);
			SwapIfLesser(ref p12, ref p18);
			SwapIfLesser(ref p12, ref p17);
			SwapIfLesser(ref p12, ref p16);
			SwapIfLesser(ref p13, ref p20);
			SwapIfLesser(ref p13, ref p19);
			SwapIfLesser(ref p14, ref p21);
			SwapIfLesser(ref p15, ref p21);
			SwapIfLesser(ref p14, ref p19);
			SwapIfLesser(ref p15, ref p20);
			SwapIfLesser(ref p15, ref p19);
			SwapIfLesser(ref p13, ref p17);
			SwapIfLesser(ref p13, ref p16);
			SwapIfLesser(ref p14, ref p18);
			SwapIfLesser(ref p15, ref p18);
			SwapIfLesser(ref p14, ref p16);
			SwapIfLesser(ref p15, ref p17);
			SwapIfLesser(ref p15, ref p16);
			SwapIfLesser(ref p0, ref p12);
			SwapIfLesser(ref p0, ref p11);
			SwapIfLesser(ref p1, ref p13);
			SwapIfLesser(ref p1, ref p12);
			SwapIfLesser(ref p1, ref p11);
			SwapIfLesser(ref p2, ref p15);
			SwapIfLesser(ref p2, ref p14);
			SwapIfLesser(ref p3, ref p16);
			SwapIfLesser(ref p4, ref p16);
			SwapIfLesser(ref p3, ref p14);
			SwapIfLesser(ref p4, ref p15);
			SwapIfLesser(ref p4, ref p14);
			SwapIfLesser(ref p2, ref p12);
			SwapIfLesser(ref p2, ref p11);
			SwapIfLesser(ref p3, ref p13);
			SwapIfLesser(ref p4, ref p13);
			SwapIfLesser(ref p3, ref p11);
			SwapIfLesser(ref p4, ref p12);
			SwapIfLesser(ref p4, ref p11);
			SwapIfLesser(ref p5, ref p18);
			SwapIfLesser(ref p5, ref p17);
			SwapIfLesser(ref p6, ref p19);
			SwapIfLesser(ref p7, ref p19);
			SwapIfLesser(ref p6, ref p17);
			SwapIfLesser(ref p7, ref p18);
			SwapIfLesser(ref p7, ref p17);
			SwapIfLesser(ref p8, ref p20);
			SwapIfLesser(ref p9, ref p21);
			SwapIfLesser(ref p10, ref p21);
			SwapIfLesser(ref p9, ref p20);
			SwapIfLesser(ref p10, ref p20);
			SwapIfLesser(ref p8, ref p18);
			SwapIfLesser(ref p8, ref p17);
			SwapIfLesser(ref p9, ref p19);
			SwapIfLesser(ref p10, ref p19);
			SwapIfLesser(ref p9, ref p17);
			SwapIfLesser(ref p10, ref p18);
			SwapIfLesser(ref p10, ref p17);
			SwapIfLesser(ref p5, ref p12);
			SwapIfLesser(ref p5, ref p11);
			SwapIfLesser(ref p6, ref p13);
			SwapIfLesser(ref p7, ref p13);
			SwapIfLesser(ref p6, ref p11);
			SwapIfLesser(ref p7, ref p12);
			SwapIfLesser(ref p7, ref p11);
			SwapIfLesser(ref p8, ref p15);
			SwapIfLesser(ref p8, ref p14);
			SwapIfLesser(ref p9, ref p16);
			SwapIfLesser(ref p10, ref p16);
			SwapIfLesser(ref p9, ref p14);
			SwapIfLesser(ref p10, ref p15);
			SwapIfLesser(ref p10, ref p14);
			SwapIfLesser(ref p8, ref p12);
			SwapIfLesser(ref p8, ref p11);
			SwapIfLesser(ref p9, ref p13);
			SwapIfLesser(ref p10, ref p13);
			SwapIfLesser(ref p9, ref p11);
			SwapIfLesser(ref p10, ref p12);
			SwapIfLesser(ref p10, ref p11);
		}

		/// <summary>
		/// Sorts a collection of 23 elements in ascending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort23Ascending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);
			ref var p10 = ref Unsafe.Add(ref p9, 10);
			ref var p11 = ref Unsafe.Add(ref p10, 11);
			ref var p12 = ref Unsafe.Add(ref p11, 12);
			ref var p13 = ref Unsafe.Add(ref p12, 13);
			ref var p14 = ref Unsafe.Add(ref p13, 14);
			ref var p15 = ref Unsafe.Add(ref p14, 15);
			ref var p16 = ref Unsafe.Add(ref p15, 16);
			ref var p17 = ref Unsafe.Add(ref p16, 17);
			ref var p18 = ref Unsafe.Add(ref p17, 18);
			ref var p19 = ref Unsafe.Add(ref p18, 19);
			ref var p20 = ref Unsafe.Add(ref p19, 20);
			ref var p21 = ref Unsafe.Add(ref p20, 21);
			ref var p22 = ref Unsafe.Add(ref p21, 22);

			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p3, ref p4);
			SwapIfGreater(ref p2, ref p4);
			SwapIfGreater(ref p2, ref p3);
			SwapIfGreater(ref p0, ref p3);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p1, ref p4);
			SwapIfGreater(ref p1, ref p3);
			SwapIfGreater(ref p1, ref p2);
			SwapIfGreater(ref p6, ref p7);
			SwapIfGreater(ref p5, ref p7);
			SwapIfGreater(ref p5, ref p6);
			SwapIfGreater(ref p9, ref p10);
			SwapIfGreater(ref p8, ref p10);
			SwapIfGreater(ref p8, ref p9);
			SwapIfGreater(ref p5, ref p9);
			SwapIfGreater(ref p5, ref p8);
			SwapIfGreater(ref p6, ref p10);
			SwapIfGreater(ref p7, ref p10);
			SwapIfGreater(ref p6, ref p8);
			SwapIfGreater(ref p7, ref p9);
			SwapIfGreater(ref p7, ref p8);
			SwapIfGreater(ref p0, ref p6);
			SwapIfGreater(ref p0, ref p5);
			SwapIfGreater(ref p1, ref p7);
			SwapIfGreater(ref p1, ref p6);
			SwapIfGreater(ref p1, ref p5);
			SwapIfGreater(ref p2, ref p9);
			SwapIfGreater(ref p2, ref p8);
			SwapIfGreater(ref p3, ref p10);
			SwapIfGreater(ref p4, ref p10);
			SwapIfGreater(ref p3, ref p8);
			SwapIfGreater(ref p4, ref p9);
			SwapIfGreater(ref p4, ref p8);
			SwapIfGreater(ref p2, ref p6);
			SwapIfGreater(ref p2, ref p5);
			SwapIfGreater(ref p3, ref p7);
			SwapIfGreater(ref p4, ref p7);
			SwapIfGreater(ref p3, ref p5);
			SwapIfGreater(ref p4, ref p6);
			SwapIfGreater(ref p4, ref p5);
			SwapIfGreater(ref p12, ref p13);
			SwapIfGreater(ref p11, ref p13);
			SwapIfGreater(ref p11, ref p12);
			SwapIfGreater(ref p15, ref p16);
			SwapIfGreater(ref p14, ref p16);
			SwapIfGreater(ref p14, ref p15);
			SwapIfGreater(ref p11, ref p15);
			SwapIfGreater(ref p11, ref p14);
			SwapIfGreater(ref p12, ref p16);
			SwapIfGreater(ref p13, ref p16);
			SwapIfGreater(ref p12, ref p14);
			SwapIfGreater(ref p13, ref p15);
			SwapIfGreater(ref p13, ref p14);
			SwapIfGreater(ref p18, ref p19);
			SwapIfGreater(ref p17, ref p19);
			SwapIfGreater(ref p17, ref p18);
			SwapIfGreater(ref p21, ref p22);
			SwapIfGreater(ref p20, ref p22);
			SwapIfGreater(ref p20, ref p21);
			SwapIfGreater(ref p17, ref p21);
			SwapIfGreater(ref p17, ref p20);
			SwapIfGreater(ref p18, ref p22);
			SwapIfGreater(ref p19, ref p22);
			SwapIfGreater(ref p18, ref p20);
			SwapIfGreater(ref p19, ref p21);
			SwapIfGreater(ref p19, ref p20);
			SwapIfGreater(ref p11, ref p18);
			SwapIfGreater(ref p11, ref p17);
			SwapIfGreater(ref p12, ref p19);
			SwapIfGreater(ref p13, ref p19);
			SwapIfGreater(ref p12, ref p17);
			SwapIfGreater(ref p13, ref p18);
			SwapIfGreater(ref p13, ref p17);
			SwapIfGreater(ref p14, ref p21);
			SwapIfGreater(ref p14, ref p20);
			SwapIfGreater(ref p15, ref p22);
			SwapIfGreater(ref p16, ref p22);
			SwapIfGreater(ref p15, ref p20);
			SwapIfGreater(ref p16, ref p21);
			SwapIfGreater(ref p16, ref p20);
			SwapIfGreater(ref p14, ref p18);
			SwapIfGreater(ref p14, ref p17);
			SwapIfGreater(ref p15, ref p19);
			SwapIfGreater(ref p16, ref p19);
			SwapIfGreater(ref p15, ref p17);
			SwapIfGreater(ref p16, ref p18);
			SwapIfGreater(ref p16, ref p17);
			SwapIfGreater(ref p0, ref p12);
			SwapIfGreater(ref p0, ref p11);
			SwapIfGreater(ref p1, ref p13);
			SwapIfGreater(ref p1, ref p12);
			SwapIfGreater(ref p1, ref p11);
			SwapIfGreater(ref p2, ref p15);
			SwapIfGreater(ref p2, ref p14);
			SwapIfGreater(ref p3, ref p16);
			SwapIfGreater(ref p4, ref p16);
			SwapIfGreater(ref p3, ref p14);
			SwapIfGreater(ref p4, ref p15);
			SwapIfGreater(ref p4, ref p14);
			SwapIfGreater(ref p2, ref p12);
			SwapIfGreater(ref p2, ref p11);
			SwapIfGreater(ref p3, ref p13);
			SwapIfGreater(ref p4, ref p13);
			SwapIfGreater(ref p3, ref p11);
			SwapIfGreater(ref p4, ref p12);
			SwapIfGreater(ref p4, ref p11);
			SwapIfGreater(ref p5, ref p18);
			SwapIfGreater(ref p5, ref p17);
			SwapIfGreater(ref p6, ref p19);
			SwapIfGreater(ref p7, ref p19);
			SwapIfGreater(ref p6, ref p17);
			SwapIfGreater(ref p7, ref p18);
			SwapIfGreater(ref p7, ref p17);
			SwapIfGreater(ref p8, ref p21);
			SwapIfGreater(ref p8, ref p20);
			SwapIfGreater(ref p9, ref p22);
			SwapIfGreater(ref p10, ref p22);
			SwapIfGreater(ref p9, ref p20);
			SwapIfGreater(ref p10, ref p21);
			SwapIfGreater(ref p10, ref p20);
			SwapIfGreater(ref p8, ref p18);
			SwapIfGreater(ref p8, ref p17);
			SwapIfGreater(ref p9, ref p19);
			SwapIfGreater(ref p10, ref p19);
			SwapIfGreater(ref p9, ref p17);
			SwapIfGreater(ref p10, ref p18);
			SwapIfGreater(ref p10, ref p17);
			SwapIfGreater(ref p5, ref p12);
			SwapIfGreater(ref p5, ref p11);
			SwapIfGreater(ref p6, ref p13);
			SwapIfGreater(ref p7, ref p13);
			SwapIfGreater(ref p6, ref p11);
			SwapIfGreater(ref p7, ref p12);
			SwapIfGreater(ref p7, ref p11);
			SwapIfGreater(ref p8, ref p15);
			SwapIfGreater(ref p8, ref p14);
			SwapIfGreater(ref p9, ref p16);
			SwapIfGreater(ref p10, ref p16);
			SwapIfGreater(ref p9, ref p14);
			SwapIfGreater(ref p10, ref p15);
			SwapIfGreater(ref p10, ref p14);
			SwapIfGreater(ref p8, ref p12);
			SwapIfGreater(ref p8, ref p11);
			SwapIfGreater(ref p9, ref p13);
			SwapIfGreater(ref p10, ref p13);
			SwapIfGreater(ref p9, ref p11);
			SwapIfGreater(ref p10, ref p12);
			SwapIfGreater(ref p10, ref p11);
		}

		/// <summary>
		/// Sorts a collection of 23 elements in descending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort23Descending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);
			ref var p10 = ref Unsafe.Add(ref p9, 10);
			ref var p11 = ref Unsafe.Add(ref p10, 11);
			ref var p12 = ref Unsafe.Add(ref p11, 12);
			ref var p13 = ref Unsafe.Add(ref p12, 13);
			ref var p14 = ref Unsafe.Add(ref p13, 14);
			ref var p15 = ref Unsafe.Add(ref p14, 15);
			ref var p16 = ref Unsafe.Add(ref p15, 16);
			ref var p17 = ref Unsafe.Add(ref p16, 17);
			ref var p18 = ref Unsafe.Add(ref p17, 18);
			ref var p19 = ref Unsafe.Add(ref p18, 19);
			ref var p20 = ref Unsafe.Add(ref p19, 20);
			ref var p21 = ref Unsafe.Add(ref p20, 21);
			ref var p22 = ref Unsafe.Add(ref p21, 22);

			SwapIfLesser(ref p0, ref p1);
			SwapIfLesser(ref p3, ref p4);
			SwapIfLesser(ref p2, ref p4);
			SwapIfLesser(ref p2, ref p3);
			SwapIfLesser(ref p0, ref p3);
			SwapIfLesser(ref p0, ref p2);
			SwapIfLesser(ref p1, ref p4);
			SwapIfLesser(ref p1, ref p3);
			SwapIfLesser(ref p1, ref p2);
			SwapIfLesser(ref p6, ref p7);
			SwapIfLesser(ref p5, ref p7);
			SwapIfLesser(ref p5, ref p6);
			SwapIfLesser(ref p9, ref p10);
			SwapIfLesser(ref p8, ref p10);
			SwapIfLesser(ref p8, ref p9);
			SwapIfLesser(ref p5, ref p9);
			SwapIfLesser(ref p5, ref p8);
			SwapIfLesser(ref p6, ref p10);
			SwapIfLesser(ref p7, ref p10);
			SwapIfLesser(ref p6, ref p8);
			SwapIfLesser(ref p7, ref p9);
			SwapIfLesser(ref p7, ref p8);
			SwapIfLesser(ref p0, ref p6);
			SwapIfLesser(ref p0, ref p5);
			SwapIfLesser(ref p1, ref p7);
			SwapIfLesser(ref p1, ref p6);
			SwapIfLesser(ref p1, ref p5);
			SwapIfLesser(ref p2, ref p9);
			SwapIfLesser(ref p2, ref p8);
			SwapIfLesser(ref p3, ref p10);
			SwapIfLesser(ref p4, ref p10);
			SwapIfLesser(ref p3, ref p8);
			SwapIfLesser(ref p4, ref p9);
			SwapIfLesser(ref p4, ref p8);
			SwapIfLesser(ref p2, ref p6);
			SwapIfLesser(ref p2, ref p5);
			SwapIfLesser(ref p3, ref p7);
			SwapIfLesser(ref p4, ref p7);
			SwapIfLesser(ref p3, ref p5);
			SwapIfLesser(ref p4, ref p6);
			SwapIfLesser(ref p4, ref p5);
			SwapIfLesser(ref p12, ref p13);
			SwapIfLesser(ref p11, ref p13);
			SwapIfLesser(ref p11, ref p12);
			SwapIfLesser(ref p15, ref p16);
			SwapIfLesser(ref p14, ref p16);
			SwapIfLesser(ref p14, ref p15);
			SwapIfLesser(ref p11, ref p15);
			SwapIfLesser(ref p11, ref p14);
			SwapIfLesser(ref p12, ref p16);
			SwapIfLesser(ref p13, ref p16);
			SwapIfLesser(ref p12, ref p14);
			SwapIfLesser(ref p13, ref p15);
			SwapIfLesser(ref p13, ref p14);
			SwapIfLesser(ref p18, ref p19);
			SwapIfLesser(ref p17, ref p19);
			SwapIfLesser(ref p17, ref p18);
			SwapIfLesser(ref p21, ref p22);
			SwapIfLesser(ref p20, ref p22);
			SwapIfLesser(ref p20, ref p21);
			SwapIfLesser(ref p17, ref p21);
			SwapIfLesser(ref p17, ref p20);
			SwapIfLesser(ref p18, ref p22);
			SwapIfLesser(ref p19, ref p22);
			SwapIfLesser(ref p18, ref p20);
			SwapIfLesser(ref p19, ref p21);
			SwapIfLesser(ref p19, ref p20);
			SwapIfLesser(ref p11, ref p18);
			SwapIfLesser(ref p11, ref p17);
			SwapIfLesser(ref p12, ref p19);
			SwapIfLesser(ref p13, ref p19);
			SwapIfLesser(ref p12, ref p17);
			SwapIfLesser(ref p13, ref p18);
			SwapIfLesser(ref p13, ref p17);
			SwapIfLesser(ref p14, ref p21);
			SwapIfLesser(ref p14, ref p20);
			SwapIfLesser(ref p15, ref p22);
			SwapIfLesser(ref p16, ref p22);
			SwapIfLesser(ref p15, ref p20);
			SwapIfLesser(ref p16, ref p21);
			SwapIfLesser(ref p16, ref p20);
			SwapIfLesser(ref p14, ref p18);
			SwapIfLesser(ref p14, ref p17);
			SwapIfLesser(ref p15, ref p19);
			SwapIfLesser(ref p16, ref p19);
			SwapIfLesser(ref p15, ref p17);
			SwapIfLesser(ref p16, ref p18);
			SwapIfLesser(ref p16, ref p17);
			SwapIfLesser(ref p0, ref p12);
			SwapIfLesser(ref p0, ref p11);
			SwapIfLesser(ref p1, ref p13);
			SwapIfLesser(ref p1, ref p12);
			SwapIfLesser(ref p1, ref p11);
			SwapIfLesser(ref p2, ref p15);
			SwapIfLesser(ref p2, ref p14);
			SwapIfLesser(ref p3, ref p16);
			SwapIfLesser(ref p4, ref p16);
			SwapIfLesser(ref p3, ref p14);
			SwapIfLesser(ref p4, ref p15);
			SwapIfLesser(ref p4, ref p14);
			SwapIfLesser(ref p2, ref p12);
			SwapIfLesser(ref p2, ref p11);
			SwapIfLesser(ref p3, ref p13);
			SwapIfLesser(ref p4, ref p13);
			SwapIfLesser(ref p3, ref p11);
			SwapIfLesser(ref p4, ref p12);
			SwapIfLesser(ref p4, ref p11);
			SwapIfLesser(ref p5, ref p18);
			SwapIfLesser(ref p5, ref p17);
			SwapIfLesser(ref p6, ref p19);
			SwapIfLesser(ref p7, ref p19);
			SwapIfLesser(ref p6, ref p17);
			SwapIfLesser(ref p7, ref p18);
			SwapIfLesser(ref p7, ref p17);
			SwapIfLesser(ref p8, ref p21);
			SwapIfLesser(ref p8, ref p20);
			SwapIfLesser(ref p9, ref p22);
			SwapIfLesser(ref p10, ref p22);
			SwapIfLesser(ref p9, ref p20);
			SwapIfLesser(ref p10, ref p21);
			SwapIfLesser(ref p10, ref p20);
			SwapIfLesser(ref p8, ref p18);
			SwapIfLesser(ref p8, ref p17);
			SwapIfLesser(ref p9, ref p19);
			SwapIfLesser(ref p10, ref p19);
			SwapIfLesser(ref p9, ref p17);
			SwapIfLesser(ref p10, ref p18);
			SwapIfLesser(ref p10, ref p17);
			SwapIfLesser(ref p5, ref p12);
			SwapIfLesser(ref p5, ref p11);
			SwapIfLesser(ref p6, ref p13);
			SwapIfLesser(ref p7, ref p13);
			SwapIfLesser(ref p6, ref p11);
			SwapIfLesser(ref p7, ref p12);
			SwapIfLesser(ref p7, ref p11);
			SwapIfLesser(ref p8, ref p15);
			SwapIfLesser(ref p8, ref p14);
			SwapIfLesser(ref p9, ref p16);
			SwapIfLesser(ref p10, ref p16);
			SwapIfLesser(ref p9, ref p14);
			SwapIfLesser(ref p10, ref p15);
			SwapIfLesser(ref p10, ref p14);
			SwapIfLesser(ref p8, ref p12);
			SwapIfLesser(ref p8, ref p11);
			SwapIfLesser(ref p9, ref p13);
			SwapIfLesser(ref p10, ref p13);
			SwapIfLesser(ref p9, ref p11);
			SwapIfLesser(ref p10, ref p12);
			SwapIfLesser(ref p10, ref p11);
		}

		/// <summary>
		/// Sorts a collection of 24 elements in ascending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort24Ascending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);
			ref var p10 = ref Unsafe.Add(ref p9, 10);
			ref var p11 = ref Unsafe.Add(ref p10, 11);
			ref var p12 = ref Unsafe.Add(ref p11, 12);
			ref var p13 = ref Unsafe.Add(ref p12, 13);
			ref var p14 = ref Unsafe.Add(ref p13, 14);
			ref var p15 = ref Unsafe.Add(ref p14, 15);
			ref var p16 = ref Unsafe.Add(ref p15, 16);
			ref var p17 = ref Unsafe.Add(ref p16, 17);
			ref var p18 = ref Unsafe.Add(ref p17, 18);
			ref var p19 = ref Unsafe.Add(ref p18, 19);
			ref var p20 = ref Unsafe.Add(ref p19, 20);
			ref var p21 = ref Unsafe.Add(ref p20, 21);
			ref var p22 = ref Unsafe.Add(ref p21, 22);
			ref var p23 = ref Unsafe.Add(ref p22, 23);

			SwapIfGreater(ref p1, ref p2);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p4, ref p5);
			SwapIfGreater(ref p3, ref p5);
			SwapIfGreater(ref p3, ref p4);
			SwapIfGreater(ref p0, ref p4);
			SwapIfGreater(ref p0, ref p3);
			SwapIfGreater(ref p1, ref p5);
			SwapIfGreater(ref p2, ref p5);
			SwapIfGreater(ref p1, ref p3);
			SwapIfGreater(ref p2, ref p4);
			SwapIfGreater(ref p2, ref p3);
			SwapIfGreater(ref p7, ref p8);
			SwapIfGreater(ref p6, ref p8);
			SwapIfGreater(ref p6, ref p7);
			SwapIfGreater(ref p10, ref p11);
			SwapIfGreater(ref p9, ref p11);
			SwapIfGreater(ref p9, ref p10);
			SwapIfGreater(ref p6, ref p10);
			SwapIfGreater(ref p6, ref p9);
			SwapIfGreater(ref p7, ref p11);
			SwapIfGreater(ref p8, ref p11);
			SwapIfGreater(ref p7, ref p9);
			SwapIfGreater(ref p8, ref p10);
			SwapIfGreater(ref p8, ref p9);
			SwapIfGreater(ref p0, ref p7);
			SwapIfGreater(ref p0, ref p6);
			SwapIfGreater(ref p1, ref p8);
			SwapIfGreater(ref p2, ref p8);
			SwapIfGreater(ref p1, ref p6);
			SwapIfGreater(ref p2, ref p7);
			SwapIfGreater(ref p2, ref p6);
			SwapIfGreater(ref p3, ref p10);
			SwapIfGreater(ref p3, ref p9);
			SwapIfGreater(ref p4, ref p11);
			SwapIfGreater(ref p5, ref p11);
			SwapIfGreater(ref p4, ref p9);
			SwapIfGreater(ref p5, ref p10);
			SwapIfGreater(ref p5, ref p9);
			SwapIfGreater(ref p3, ref p7);
			SwapIfGreater(ref p3, ref p6);
			SwapIfGreater(ref p4, ref p8);
			SwapIfGreater(ref p5, ref p8);
			SwapIfGreater(ref p4, ref p6);
			SwapIfGreater(ref p5, ref p7);
			SwapIfGreater(ref p5, ref p6);
			SwapIfGreater(ref p13, ref p14);
			SwapIfGreater(ref p12, ref p14);
			SwapIfGreater(ref p12, ref p13);
			SwapIfGreater(ref p16, ref p17);
			SwapIfGreater(ref p15, ref p17);
			SwapIfGreater(ref p15, ref p16);
			SwapIfGreater(ref p12, ref p16);
			SwapIfGreater(ref p12, ref p15);
			SwapIfGreater(ref p13, ref p17);
			SwapIfGreater(ref p14, ref p17);
			SwapIfGreater(ref p13, ref p15);
			SwapIfGreater(ref p14, ref p16);
			SwapIfGreater(ref p14, ref p15);
			SwapIfGreater(ref p19, ref p20);
			SwapIfGreater(ref p18, ref p20);
			SwapIfGreater(ref p18, ref p19);
			SwapIfGreater(ref p22, ref p23);
			SwapIfGreater(ref p21, ref p23);
			SwapIfGreater(ref p21, ref p22);
			SwapIfGreater(ref p18, ref p22);
			SwapIfGreater(ref p18, ref p21);
			SwapIfGreater(ref p19, ref p23);
			SwapIfGreater(ref p20, ref p23);
			SwapIfGreater(ref p19, ref p21);
			SwapIfGreater(ref p20, ref p22);
			SwapIfGreater(ref p20, ref p21);
			SwapIfGreater(ref p12, ref p19);
			SwapIfGreater(ref p12, ref p18);
			SwapIfGreater(ref p13, ref p20);
			SwapIfGreater(ref p14, ref p20);
			SwapIfGreater(ref p13, ref p18);
			SwapIfGreater(ref p14, ref p19);
			SwapIfGreater(ref p14, ref p18);
			SwapIfGreater(ref p15, ref p22);
			SwapIfGreater(ref p15, ref p21);
			SwapIfGreater(ref p16, ref p23);
			SwapIfGreater(ref p17, ref p23);
			SwapIfGreater(ref p16, ref p21);
			SwapIfGreater(ref p17, ref p22);
			SwapIfGreater(ref p17, ref p21);
			SwapIfGreater(ref p15, ref p19);
			SwapIfGreater(ref p15, ref p18);
			SwapIfGreater(ref p16, ref p20);
			SwapIfGreater(ref p17, ref p20);
			SwapIfGreater(ref p16, ref p18);
			SwapIfGreater(ref p17, ref p19);
			SwapIfGreater(ref p17, ref p18);
			SwapIfGreater(ref p0, ref p13);
			SwapIfGreater(ref p0, ref p12);
			SwapIfGreater(ref p1, ref p14);
			SwapIfGreater(ref p2, ref p14);
			SwapIfGreater(ref p1, ref p12);
			SwapIfGreater(ref p2, ref p13);
			SwapIfGreater(ref p2, ref p12);
			SwapIfGreater(ref p3, ref p16);
			SwapIfGreater(ref p3, ref p15);
			SwapIfGreater(ref p4, ref p17);
			SwapIfGreater(ref p5, ref p17);
			SwapIfGreater(ref p4, ref p15);
			SwapIfGreater(ref p5, ref p16);
			SwapIfGreater(ref p5, ref p15);
			SwapIfGreater(ref p3, ref p13);
			SwapIfGreater(ref p3, ref p12);
			SwapIfGreater(ref p4, ref p14);
			SwapIfGreater(ref p5, ref p14);
			SwapIfGreater(ref p4, ref p12);
			SwapIfGreater(ref p5, ref p13);
			SwapIfGreater(ref p5, ref p12);
			SwapIfGreater(ref p6, ref p19);
			SwapIfGreater(ref p6, ref p18);
			SwapIfGreater(ref p7, ref p20);
			SwapIfGreater(ref p8, ref p20);
			SwapIfGreater(ref p7, ref p18);
			SwapIfGreater(ref p8, ref p19);
			SwapIfGreater(ref p8, ref p18);
			SwapIfGreater(ref p9, ref p22);
			SwapIfGreater(ref p9, ref p21);
			SwapIfGreater(ref p10, ref p23);
			SwapIfGreater(ref p11, ref p23);
			SwapIfGreater(ref p10, ref p21);
			SwapIfGreater(ref p11, ref p22);
			SwapIfGreater(ref p11, ref p21);
			SwapIfGreater(ref p9, ref p19);
			SwapIfGreater(ref p9, ref p18);
			SwapIfGreater(ref p10, ref p20);
			SwapIfGreater(ref p11, ref p20);
			SwapIfGreater(ref p10, ref p18);
			SwapIfGreater(ref p11, ref p19);
			SwapIfGreater(ref p11, ref p18);
			SwapIfGreater(ref p6, ref p13);
			SwapIfGreater(ref p6, ref p12);
			SwapIfGreater(ref p7, ref p14);
			SwapIfGreater(ref p8, ref p14);
			SwapIfGreater(ref p7, ref p12);
			SwapIfGreater(ref p8, ref p13);
			SwapIfGreater(ref p8, ref p12);
			SwapIfGreater(ref p9, ref p16);
			SwapIfGreater(ref p9, ref p15);
			SwapIfGreater(ref p10, ref p17);
			SwapIfGreater(ref p11, ref p17);
			SwapIfGreater(ref p10, ref p15);
			SwapIfGreater(ref p11, ref p16);
			SwapIfGreater(ref p11, ref p15);
			SwapIfGreater(ref p9, ref p13);
			SwapIfGreater(ref p9, ref p12);
			SwapIfGreater(ref p10, ref p14);
			SwapIfGreater(ref p11, ref p14);
			SwapIfGreater(ref p10, ref p12);
			SwapIfGreater(ref p11, ref p13);
			SwapIfGreater(ref p11, ref p12);
		}

		/// <summary>
		/// Sorts a collection of 24 elements in descending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort24Descending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);
			ref var p10 = ref Unsafe.Add(ref p9, 10);
			ref var p11 = ref Unsafe.Add(ref p10, 11);
			ref var p12 = ref Unsafe.Add(ref p11, 12);
			ref var p13 = ref Unsafe.Add(ref p12, 13);
			ref var p14 = ref Unsafe.Add(ref p13, 14);
			ref var p15 = ref Unsafe.Add(ref p14, 15);
			ref var p16 = ref Unsafe.Add(ref p15, 16);
			ref var p17 = ref Unsafe.Add(ref p16, 17);
			ref var p18 = ref Unsafe.Add(ref p17, 18);
			ref var p19 = ref Unsafe.Add(ref p18, 19);
			ref var p20 = ref Unsafe.Add(ref p19, 20);
			ref var p21 = ref Unsafe.Add(ref p20, 21);
			ref var p22 = ref Unsafe.Add(ref p21, 22);
			ref var p23 = ref Unsafe.Add(ref p22, 23);

			SwapIfLesser(ref p1, ref p2);
			SwapIfLesser(ref p0, ref p2);
			SwapIfLesser(ref p0, ref p1);
			SwapIfLesser(ref p4, ref p5);
			SwapIfLesser(ref p3, ref p5);
			SwapIfLesser(ref p3, ref p4);
			SwapIfLesser(ref p0, ref p4);
			SwapIfLesser(ref p0, ref p3);
			SwapIfLesser(ref p1, ref p5);
			SwapIfLesser(ref p2, ref p5);
			SwapIfLesser(ref p1, ref p3);
			SwapIfLesser(ref p2, ref p4);
			SwapIfLesser(ref p2, ref p3);
			SwapIfLesser(ref p7, ref p8);
			SwapIfLesser(ref p6, ref p8);
			SwapIfLesser(ref p6, ref p7);
			SwapIfLesser(ref p10, ref p11);
			SwapIfLesser(ref p9, ref p11);
			SwapIfLesser(ref p9, ref p10);
			SwapIfLesser(ref p6, ref p10);
			SwapIfLesser(ref p6, ref p9);
			SwapIfLesser(ref p7, ref p11);
			SwapIfLesser(ref p8, ref p11);
			SwapIfLesser(ref p7, ref p9);
			SwapIfLesser(ref p8, ref p10);
			SwapIfLesser(ref p8, ref p9);
			SwapIfLesser(ref p0, ref p7);
			SwapIfLesser(ref p0, ref p6);
			SwapIfLesser(ref p1, ref p8);
			SwapIfLesser(ref p2, ref p8);
			SwapIfLesser(ref p1, ref p6);
			SwapIfLesser(ref p2, ref p7);
			SwapIfLesser(ref p2, ref p6);
			SwapIfLesser(ref p3, ref p10);
			SwapIfLesser(ref p3, ref p9);
			SwapIfLesser(ref p4, ref p11);
			SwapIfLesser(ref p5, ref p11);
			SwapIfLesser(ref p4, ref p9);
			SwapIfLesser(ref p5, ref p10);
			SwapIfLesser(ref p5, ref p9);
			SwapIfLesser(ref p3, ref p7);
			SwapIfLesser(ref p3, ref p6);
			SwapIfLesser(ref p4, ref p8);
			SwapIfLesser(ref p5, ref p8);
			SwapIfLesser(ref p4, ref p6);
			SwapIfLesser(ref p5, ref p7);
			SwapIfLesser(ref p5, ref p6);
			SwapIfLesser(ref p13, ref p14);
			SwapIfLesser(ref p12, ref p14);
			SwapIfLesser(ref p12, ref p13);
			SwapIfLesser(ref p16, ref p17);
			SwapIfLesser(ref p15, ref p17);
			SwapIfLesser(ref p15, ref p16);
			SwapIfLesser(ref p12, ref p16);
			SwapIfLesser(ref p12, ref p15);
			SwapIfLesser(ref p13, ref p17);
			SwapIfLesser(ref p14, ref p17);
			SwapIfLesser(ref p13, ref p15);
			SwapIfLesser(ref p14, ref p16);
			SwapIfLesser(ref p14, ref p15);
			SwapIfLesser(ref p19, ref p20);
			SwapIfLesser(ref p18, ref p20);
			SwapIfLesser(ref p18, ref p19);
			SwapIfLesser(ref p22, ref p23);
			SwapIfLesser(ref p21, ref p23);
			SwapIfLesser(ref p21, ref p22);
			SwapIfLesser(ref p18, ref p22);
			SwapIfLesser(ref p18, ref p21);
			SwapIfLesser(ref p19, ref p23);
			SwapIfLesser(ref p20, ref p23);
			SwapIfLesser(ref p19, ref p21);
			SwapIfLesser(ref p20, ref p22);
			SwapIfLesser(ref p20, ref p21);
			SwapIfLesser(ref p12, ref p19);
			SwapIfLesser(ref p12, ref p18);
			SwapIfLesser(ref p13, ref p20);
			SwapIfLesser(ref p14, ref p20);
			SwapIfLesser(ref p13, ref p18);
			SwapIfLesser(ref p14, ref p19);
			SwapIfLesser(ref p14, ref p18);
			SwapIfLesser(ref p15, ref p22);
			SwapIfLesser(ref p15, ref p21);
			SwapIfLesser(ref p16, ref p23);
			SwapIfLesser(ref p17, ref p23);
			SwapIfLesser(ref p16, ref p21);
			SwapIfLesser(ref p17, ref p22);
			SwapIfLesser(ref p17, ref p21);
			SwapIfLesser(ref p15, ref p19);
			SwapIfLesser(ref p15, ref p18);
			SwapIfLesser(ref p16, ref p20);
			SwapIfLesser(ref p17, ref p20);
			SwapIfLesser(ref p16, ref p18);
			SwapIfLesser(ref p17, ref p19);
			SwapIfLesser(ref p17, ref p18);
			SwapIfLesser(ref p0, ref p13);
			SwapIfLesser(ref p0, ref p12);
			SwapIfLesser(ref p1, ref p14);
			SwapIfLesser(ref p2, ref p14);
			SwapIfLesser(ref p1, ref p12);
			SwapIfLesser(ref p2, ref p13);
			SwapIfLesser(ref p2, ref p12);
			SwapIfLesser(ref p3, ref p16);
			SwapIfLesser(ref p3, ref p15);
			SwapIfLesser(ref p4, ref p17);
			SwapIfLesser(ref p5, ref p17);
			SwapIfLesser(ref p4, ref p15);
			SwapIfLesser(ref p5, ref p16);
			SwapIfLesser(ref p5, ref p15);
			SwapIfLesser(ref p3, ref p13);
			SwapIfLesser(ref p3, ref p12);
			SwapIfLesser(ref p4, ref p14);
			SwapIfLesser(ref p5, ref p14);
			SwapIfLesser(ref p4, ref p12);
			SwapIfLesser(ref p5, ref p13);
			SwapIfLesser(ref p5, ref p12);
			SwapIfLesser(ref p6, ref p19);
			SwapIfLesser(ref p6, ref p18);
			SwapIfLesser(ref p7, ref p20);
			SwapIfLesser(ref p8, ref p20);
			SwapIfLesser(ref p7, ref p18);
			SwapIfLesser(ref p8, ref p19);
			SwapIfLesser(ref p8, ref p18);
			SwapIfLesser(ref p9, ref p22);
			SwapIfLesser(ref p9, ref p21);
			SwapIfLesser(ref p10, ref p23);
			SwapIfLesser(ref p11, ref p23);
			SwapIfLesser(ref p10, ref p21);
			SwapIfLesser(ref p11, ref p22);
			SwapIfLesser(ref p11, ref p21);
			SwapIfLesser(ref p9, ref p19);
			SwapIfLesser(ref p9, ref p18);
			SwapIfLesser(ref p10, ref p20);
			SwapIfLesser(ref p11, ref p20);
			SwapIfLesser(ref p10, ref p18);
			SwapIfLesser(ref p11, ref p19);
			SwapIfLesser(ref p11, ref p18);
			SwapIfLesser(ref p6, ref p13);
			SwapIfLesser(ref p6, ref p12);
			SwapIfLesser(ref p7, ref p14);
			SwapIfLesser(ref p8, ref p14);
			SwapIfLesser(ref p7, ref p12);
			SwapIfLesser(ref p8, ref p13);
			SwapIfLesser(ref p8, ref p12);
			SwapIfLesser(ref p9, ref p16);
			SwapIfLesser(ref p9, ref p15);
			SwapIfLesser(ref p10, ref p17);
			SwapIfLesser(ref p11, ref p17);
			SwapIfLesser(ref p10, ref p15);
			SwapIfLesser(ref p11, ref p16);
			SwapIfLesser(ref p11, ref p15);
			SwapIfLesser(ref p9, ref p13);
			SwapIfLesser(ref p9, ref p12);
			SwapIfLesser(ref p10, ref p14);
			SwapIfLesser(ref p11, ref p14);
			SwapIfLesser(ref p10, ref p12);
			SwapIfLesser(ref p11, ref p13);
			SwapIfLesser(ref p11, ref p12);
		}

		/// <summary>
		/// Sorts a collection of 25 elements in ascending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort25Ascending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);
			ref var p10 = ref Unsafe.Add(ref p9, 10);
			ref var p11 = ref Unsafe.Add(ref p10, 11);
			ref var p12 = ref Unsafe.Add(ref p11, 12);
			ref var p13 = ref Unsafe.Add(ref p12, 13);
			ref var p14 = ref Unsafe.Add(ref p13, 14);
			ref var p15 = ref Unsafe.Add(ref p14, 15);
			ref var p16 = ref Unsafe.Add(ref p15, 16);
			ref var p17 = ref Unsafe.Add(ref p16, 17);
			ref var p18 = ref Unsafe.Add(ref p17, 18);
			ref var p19 = ref Unsafe.Add(ref p18, 19);
			ref var p20 = ref Unsafe.Add(ref p19, 20);
			ref var p21 = ref Unsafe.Add(ref p20, 21);
			ref var p22 = ref Unsafe.Add(ref p21, 22);
			ref var p23 = ref Unsafe.Add(ref p22, 23);
			ref var p24 = ref Unsafe.Add(ref p23, 24);

			SwapIfGreater(ref p1, ref p2);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p4, ref p5);
			SwapIfGreater(ref p3, ref p5);
			SwapIfGreater(ref p3, ref p4);
			SwapIfGreater(ref p0, ref p4);
			SwapIfGreater(ref p0, ref p3);
			SwapIfGreater(ref p1, ref p5);
			SwapIfGreater(ref p2, ref p5);
			SwapIfGreater(ref p1, ref p3);
			SwapIfGreater(ref p2, ref p4);
			SwapIfGreater(ref p2, ref p3);
			SwapIfGreater(ref p7, ref p8);
			SwapIfGreater(ref p6, ref p8);
			SwapIfGreater(ref p6, ref p7);
			SwapIfGreater(ref p10, ref p11);
			SwapIfGreater(ref p9, ref p11);
			SwapIfGreater(ref p9, ref p10);
			SwapIfGreater(ref p6, ref p10);
			SwapIfGreater(ref p6, ref p9);
			SwapIfGreater(ref p7, ref p11);
			SwapIfGreater(ref p8, ref p11);
			SwapIfGreater(ref p7, ref p9);
			SwapIfGreater(ref p8, ref p10);
			SwapIfGreater(ref p8, ref p9);
			SwapIfGreater(ref p0, ref p7);
			SwapIfGreater(ref p0, ref p6);
			SwapIfGreater(ref p1, ref p8);
			SwapIfGreater(ref p2, ref p8);
			SwapIfGreater(ref p1, ref p6);
			SwapIfGreater(ref p2, ref p7);
			SwapIfGreater(ref p2, ref p6);
			SwapIfGreater(ref p3, ref p10);
			SwapIfGreater(ref p3, ref p9);
			SwapIfGreater(ref p4, ref p11);
			SwapIfGreater(ref p5, ref p11);
			SwapIfGreater(ref p4, ref p9);
			SwapIfGreater(ref p5, ref p10);
			SwapIfGreater(ref p5, ref p9);
			SwapIfGreater(ref p3, ref p7);
			SwapIfGreater(ref p3, ref p6);
			SwapIfGreater(ref p4, ref p8);
			SwapIfGreater(ref p5, ref p8);
			SwapIfGreater(ref p4, ref p6);
			SwapIfGreater(ref p5, ref p7);
			SwapIfGreater(ref p5, ref p6);
			SwapIfGreater(ref p13, ref p14);
			SwapIfGreater(ref p12, ref p14);
			SwapIfGreater(ref p12, ref p13);
			SwapIfGreater(ref p16, ref p17);
			SwapIfGreater(ref p15, ref p17);
			SwapIfGreater(ref p15, ref p16);
			SwapIfGreater(ref p12, ref p16);
			SwapIfGreater(ref p12, ref p15);
			SwapIfGreater(ref p13, ref p17);
			SwapIfGreater(ref p14, ref p17);
			SwapIfGreater(ref p13, ref p15);
			SwapIfGreater(ref p14, ref p16);
			SwapIfGreater(ref p14, ref p15);
			SwapIfGreater(ref p19, ref p20);
			SwapIfGreater(ref p18, ref p20);
			SwapIfGreater(ref p18, ref p19);
			SwapIfGreater(ref p21, ref p22);
			SwapIfGreater(ref p23, ref p24);
			SwapIfGreater(ref p21, ref p23);
			SwapIfGreater(ref p22, ref p24);
			SwapIfGreater(ref p22, ref p23);
			SwapIfGreater(ref p18, ref p22);
			SwapIfGreater(ref p18, ref p21);
			SwapIfGreater(ref p19, ref p23);
			SwapIfGreater(ref p20, ref p24);
			SwapIfGreater(ref p20, ref p23);
			SwapIfGreater(ref p19, ref p21);
			SwapIfGreater(ref p20, ref p22);
			SwapIfGreater(ref p20, ref p21);
			SwapIfGreater(ref p12, ref p19);
			SwapIfGreater(ref p12, ref p18);
			SwapIfGreater(ref p13, ref p20);
			SwapIfGreater(ref p14, ref p21);
			SwapIfGreater(ref p14, ref p20);
			SwapIfGreater(ref p13, ref p18);
			SwapIfGreater(ref p14, ref p19);
			SwapIfGreater(ref p14, ref p18);
			SwapIfGreater(ref p15, ref p23);
			SwapIfGreater(ref p15, ref p22);
			SwapIfGreater(ref p16, ref p24);
			SwapIfGreater(ref p17, ref p24);
			SwapIfGreater(ref p16, ref p22);
			SwapIfGreater(ref p17, ref p23);
			SwapIfGreater(ref p17, ref p22);
			SwapIfGreater(ref p15, ref p19);
			SwapIfGreater(ref p15, ref p18);
			SwapIfGreater(ref p16, ref p20);
			SwapIfGreater(ref p17, ref p21);
			SwapIfGreater(ref p17, ref p20);
			SwapIfGreater(ref p16, ref p18);
			SwapIfGreater(ref p17, ref p19);
			SwapIfGreater(ref p17, ref p18);
			SwapIfGreater(ref p0, ref p13);
			SwapIfGreater(ref p0, ref p12);
			SwapIfGreater(ref p1, ref p14);
			SwapIfGreater(ref p2, ref p15);
			SwapIfGreater(ref p2, ref p14);
			SwapIfGreater(ref p1, ref p12);
			SwapIfGreater(ref p2, ref p13);
			SwapIfGreater(ref p2, ref p12);
			SwapIfGreater(ref p3, ref p17);
			SwapIfGreater(ref p3, ref p16);
			SwapIfGreater(ref p4, ref p18);
			SwapIfGreater(ref p5, ref p18);
			SwapIfGreater(ref p4, ref p16);
			SwapIfGreater(ref p5, ref p17);
			SwapIfGreater(ref p5, ref p16);
			SwapIfGreater(ref p3, ref p13);
			SwapIfGreater(ref p3, ref p12);
			SwapIfGreater(ref p4, ref p14);
			SwapIfGreater(ref p5, ref p15);
			SwapIfGreater(ref p5, ref p14);
			SwapIfGreater(ref p4, ref p12);
			SwapIfGreater(ref p5, ref p13);
			SwapIfGreater(ref p5, ref p12);
			SwapIfGreater(ref p6, ref p20);
			SwapIfGreater(ref p6, ref p19);
			SwapIfGreater(ref p7, ref p21);
			SwapIfGreater(ref p8, ref p21);
			SwapIfGreater(ref p7, ref p19);
			SwapIfGreater(ref p8, ref p20);
			SwapIfGreater(ref p8, ref p19);
			SwapIfGreater(ref p9, ref p23);
			SwapIfGreater(ref p9, ref p22);
			SwapIfGreater(ref p10, ref p24);
			SwapIfGreater(ref p11, ref p24);
			SwapIfGreater(ref p10, ref p22);
			SwapIfGreater(ref p11, ref p23);
			SwapIfGreater(ref p11, ref p22);
			SwapIfGreater(ref p9, ref p20);
			SwapIfGreater(ref p9, ref p19);
			SwapIfGreater(ref p10, ref p21);
			SwapIfGreater(ref p11, ref p21);
			SwapIfGreater(ref p10, ref p19);
			SwapIfGreater(ref p11, ref p20);
			SwapIfGreater(ref p11, ref p19);
			SwapIfGreater(ref p6, ref p13);
			SwapIfGreater(ref p6, ref p12);
			SwapIfGreater(ref p7, ref p14);
			SwapIfGreater(ref p8, ref p15);
			SwapIfGreater(ref p8, ref p14);
			SwapIfGreater(ref p7, ref p12);
			SwapIfGreater(ref p8, ref p13);
			SwapIfGreater(ref p8, ref p12);
			SwapIfGreater(ref p9, ref p17);
			SwapIfGreater(ref p9, ref p16);
			SwapIfGreater(ref p10, ref p18);
			SwapIfGreater(ref p11, ref p18);
			SwapIfGreater(ref p10, ref p16);
			SwapIfGreater(ref p11, ref p17);
			SwapIfGreater(ref p11, ref p16);
			SwapIfGreater(ref p9, ref p13);
			SwapIfGreater(ref p9, ref p12);
			SwapIfGreater(ref p10, ref p14);
			SwapIfGreater(ref p11, ref p15);
			SwapIfGreater(ref p11, ref p14);
			SwapIfGreater(ref p10, ref p12);
			SwapIfGreater(ref p11, ref p13);
			SwapIfGreater(ref p11, ref p12);
		}

		/// <summary>
		/// Sorts a collection of 25 elements in descending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort25Descending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);
			ref var p10 = ref Unsafe.Add(ref p9, 10);
			ref var p11 = ref Unsafe.Add(ref p10, 11);
			ref var p12 = ref Unsafe.Add(ref p11, 12);
			ref var p13 = ref Unsafe.Add(ref p12, 13);
			ref var p14 = ref Unsafe.Add(ref p13, 14);
			ref var p15 = ref Unsafe.Add(ref p14, 15);
			ref var p16 = ref Unsafe.Add(ref p15, 16);
			ref var p17 = ref Unsafe.Add(ref p16, 17);
			ref var p18 = ref Unsafe.Add(ref p17, 18);
			ref var p19 = ref Unsafe.Add(ref p18, 19);
			ref var p20 = ref Unsafe.Add(ref p19, 20);
			ref var p21 = ref Unsafe.Add(ref p20, 21);
			ref var p22 = ref Unsafe.Add(ref p21, 22);
			ref var p23 = ref Unsafe.Add(ref p22, 23);
			ref var p24 = ref Unsafe.Add(ref p23, 24);

			SwapIfLesser(ref p1, ref p2);
			SwapIfLesser(ref p0, ref p2);
			SwapIfLesser(ref p0, ref p1);
			SwapIfLesser(ref p4, ref p5);
			SwapIfLesser(ref p3, ref p5);
			SwapIfLesser(ref p3, ref p4);
			SwapIfLesser(ref p0, ref p4);
			SwapIfLesser(ref p0, ref p3);
			SwapIfLesser(ref p1, ref p5);
			SwapIfLesser(ref p2, ref p5);
			SwapIfLesser(ref p1, ref p3);
			SwapIfLesser(ref p2, ref p4);
			SwapIfLesser(ref p2, ref p3);
			SwapIfLesser(ref p7, ref p8);
			SwapIfLesser(ref p6, ref p8);
			SwapIfLesser(ref p6, ref p7);
			SwapIfLesser(ref p10, ref p11);
			SwapIfLesser(ref p9, ref p11);
			SwapIfLesser(ref p9, ref p10);
			SwapIfLesser(ref p6, ref p10);
			SwapIfLesser(ref p6, ref p9);
			SwapIfLesser(ref p7, ref p11);
			SwapIfLesser(ref p8, ref p11);
			SwapIfLesser(ref p7, ref p9);
			SwapIfLesser(ref p8, ref p10);
			SwapIfLesser(ref p8, ref p9);
			SwapIfLesser(ref p0, ref p7);
			SwapIfLesser(ref p0, ref p6);
			SwapIfLesser(ref p1, ref p8);
			SwapIfLesser(ref p2, ref p8);
			SwapIfLesser(ref p1, ref p6);
			SwapIfLesser(ref p2, ref p7);
			SwapIfLesser(ref p2, ref p6);
			SwapIfLesser(ref p3, ref p10);
			SwapIfLesser(ref p3, ref p9);
			SwapIfLesser(ref p4, ref p11);
			SwapIfLesser(ref p5, ref p11);
			SwapIfLesser(ref p4, ref p9);
			SwapIfLesser(ref p5, ref p10);
			SwapIfLesser(ref p5, ref p9);
			SwapIfLesser(ref p3, ref p7);
			SwapIfLesser(ref p3, ref p6);
			SwapIfLesser(ref p4, ref p8);
			SwapIfLesser(ref p5, ref p8);
			SwapIfLesser(ref p4, ref p6);
			SwapIfLesser(ref p5, ref p7);
			SwapIfLesser(ref p5, ref p6);
			SwapIfLesser(ref p13, ref p14);
			SwapIfLesser(ref p12, ref p14);
			SwapIfLesser(ref p12, ref p13);
			SwapIfLesser(ref p16, ref p17);
			SwapIfLesser(ref p15, ref p17);
			SwapIfLesser(ref p15, ref p16);
			SwapIfLesser(ref p12, ref p16);
			SwapIfLesser(ref p12, ref p15);
			SwapIfLesser(ref p13, ref p17);
			SwapIfLesser(ref p14, ref p17);
			SwapIfLesser(ref p13, ref p15);
			SwapIfLesser(ref p14, ref p16);
			SwapIfLesser(ref p14, ref p15);
			SwapIfLesser(ref p19, ref p20);
			SwapIfLesser(ref p18, ref p20);
			SwapIfLesser(ref p18, ref p19);
			SwapIfLesser(ref p21, ref p22);
			SwapIfLesser(ref p23, ref p24);
			SwapIfLesser(ref p21, ref p23);
			SwapIfLesser(ref p22, ref p24);
			SwapIfLesser(ref p22, ref p23);
			SwapIfLesser(ref p18, ref p22);
			SwapIfLesser(ref p18, ref p21);
			SwapIfLesser(ref p19, ref p23);
			SwapIfLesser(ref p20, ref p24);
			SwapIfLesser(ref p20, ref p23);
			SwapIfLesser(ref p19, ref p21);
			SwapIfLesser(ref p20, ref p22);
			SwapIfLesser(ref p20, ref p21);
			SwapIfLesser(ref p12, ref p19);
			SwapIfLesser(ref p12, ref p18);
			SwapIfLesser(ref p13, ref p20);
			SwapIfLesser(ref p14, ref p21);
			SwapIfLesser(ref p14, ref p20);
			SwapIfLesser(ref p13, ref p18);
			SwapIfLesser(ref p14, ref p19);
			SwapIfLesser(ref p14, ref p18);
			SwapIfLesser(ref p15, ref p23);
			SwapIfLesser(ref p15, ref p22);
			SwapIfLesser(ref p16, ref p24);
			SwapIfLesser(ref p17, ref p24);
			SwapIfLesser(ref p16, ref p22);
			SwapIfLesser(ref p17, ref p23);
			SwapIfLesser(ref p17, ref p22);
			SwapIfLesser(ref p15, ref p19);
			SwapIfLesser(ref p15, ref p18);
			SwapIfLesser(ref p16, ref p20);
			SwapIfLesser(ref p17, ref p21);
			SwapIfLesser(ref p17, ref p20);
			SwapIfLesser(ref p16, ref p18);
			SwapIfLesser(ref p17, ref p19);
			SwapIfLesser(ref p17, ref p18);
			SwapIfLesser(ref p0, ref p13);
			SwapIfLesser(ref p0, ref p12);
			SwapIfLesser(ref p1, ref p14);
			SwapIfLesser(ref p2, ref p15);
			SwapIfLesser(ref p2, ref p14);
			SwapIfLesser(ref p1, ref p12);
			SwapIfLesser(ref p2, ref p13);
			SwapIfLesser(ref p2, ref p12);
			SwapIfLesser(ref p3, ref p17);
			SwapIfLesser(ref p3, ref p16);
			SwapIfLesser(ref p4, ref p18);
			SwapIfLesser(ref p5, ref p18);
			SwapIfLesser(ref p4, ref p16);
			SwapIfLesser(ref p5, ref p17);
			SwapIfLesser(ref p5, ref p16);
			SwapIfLesser(ref p3, ref p13);
			SwapIfLesser(ref p3, ref p12);
			SwapIfLesser(ref p4, ref p14);
			SwapIfLesser(ref p5, ref p15);
			SwapIfLesser(ref p5, ref p14);
			SwapIfLesser(ref p4, ref p12);
			SwapIfLesser(ref p5, ref p13);
			SwapIfLesser(ref p5, ref p12);
			SwapIfLesser(ref p6, ref p20);
			SwapIfLesser(ref p6, ref p19);
			SwapIfLesser(ref p7, ref p21);
			SwapIfLesser(ref p8, ref p21);
			SwapIfLesser(ref p7, ref p19);
			SwapIfLesser(ref p8, ref p20);
			SwapIfLesser(ref p8, ref p19);
			SwapIfLesser(ref p9, ref p23);
			SwapIfLesser(ref p9, ref p22);
			SwapIfLesser(ref p10, ref p24);
			SwapIfLesser(ref p11, ref p24);
			SwapIfLesser(ref p10, ref p22);
			SwapIfLesser(ref p11, ref p23);
			SwapIfLesser(ref p11, ref p22);
			SwapIfLesser(ref p9, ref p20);
			SwapIfLesser(ref p9, ref p19);
			SwapIfLesser(ref p10, ref p21);
			SwapIfLesser(ref p11, ref p21);
			SwapIfLesser(ref p10, ref p19);
			SwapIfLesser(ref p11, ref p20);
			SwapIfLesser(ref p11, ref p19);
			SwapIfLesser(ref p6, ref p13);
			SwapIfLesser(ref p6, ref p12);
			SwapIfLesser(ref p7, ref p14);
			SwapIfLesser(ref p8, ref p15);
			SwapIfLesser(ref p8, ref p14);
			SwapIfLesser(ref p7, ref p12);
			SwapIfLesser(ref p8, ref p13);
			SwapIfLesser(ref p8, ref p12);
			SwapIfLesser(ref p9, ref p17);
			SwapIfLesser(ref p9, ref p16);
			SwapIfLesser(ref p10, ref p18);
			SwapIfLesser(ref p11, ref p18);
			SwapIfLesser(ref p10, ref p16);
			SwapIfLesser(ref p11, ref p17);
			SwapIfLesser(ref p11, ref p16);
			SwapIfLesser(ref p9, ref p13);
			SwapIfLesser(ref p9, ref p12);
			SwapIfLesser(ref p10, ref p14);
			SwapIfLesser(ref p11, ref p15);
			SwapIfLesser(ref p11, ref p14);
			SwapIfLesser(ref p10, ref p12);
			SwapIfLesser(ref p11, ref p13);
			SwapIfLesser(ref p11, ref p12);
		}

		/// <summary>
		/// Sorts a collection of 26 elements in ascending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort26Ascending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);
			ref var p10 = ref Unsafe.Add(ref p9, 10);
			ref var p11 = ref Unsafe.Add(ref p10, 11);
			ref var p12 = ref Unsafe.Add(ref p11, 12);
			ref var p13 = ref Unsafe.Add(ref p12, 13);
			ref var p14 = ref Unsafe.Add(ref p13, 14);
			ref var p15 = ref Unsafe.Add(ref p14, 15);
			ref var p16 = ref Unsafe.Add(ref p15, 16);
			ref var p17 = ref Unsafe.Add(ref p16, 17);
			ref var p18 = ref Unsafe.Add(ref p17, 18);
			ref var p19 = ref Unsafe.Add(ref p18, 19);
			ref var p20 = ref Unsafe.Add(ref p19, 20);
			ref var p21 = ref Unsafe.Add(ref p20, 21);
			ref var p22 = ref Unsafe.Add(ref p21, 22);
			ref var p23 = ref Unsafe.Add(ref p22, 23);
			ref var p24 = ref Unsafe.Add(ref p23, 24);
			ref var p25 = ref Unsafe.Add(ref p24, 25);

			SwapIfGreater(ref p1, ref p2);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p4, ref p5);
			SwapIfGreater(ref p3, ref p5);
			SwapIfGreater(ref p3, ref p4);
			SwapIfGreater(ref p0, ref p4);
			SwapIfGreater(ref p0, ref p3);
			SwapIfGreater(ref p1, ref p5);
			SwapIfGreater(ref p2, ref p5);
			SwapIfGreater(ref p1, ref p3);
			SwapIfGreater(ref p2, ref p4);
			SwapIfGreater(ref p2, ref p3);
			SwapIfGreater(ref p7, ref p8);
			SwapIfGreater(ref p6, ref p8);
			SwapIfGreater(ref p6, ref p7);
			SwapIfGreater(ref p9, ref p10);
			SwapIfGreater(ref p11, ref p12);
			SwapIfGreater(ref p9, ref p11);
			SwapIfGreater(ref p10, ref p12);
			SwapIfGreater(ref p10, ref p11);
			SwapIfGreater(ref p6, ref p10);
			SwapIfGreater(ref p6, ref p9);
			SwapIfGreater(ref p7, ref p11);
			SwapIfGreater(ref p8, ref p12);
			SwapIfGreater(ref p8, ref p11);
			SwapIfGreater(ref p7, ref p9);
			SwapIfGreater(ref p8, ref p10);
			SwapIfGreater(ref p8, ref p9);
			SwapIfGreater(ref p0, ref p7);
			SwapIfGreater(ref p0, ref p6);
			SwapIfGreater(ref p1, ref p8);
			SwapIfGreater(ref p2, ref p9);
			SwapIfGreater(ref p2, ref p8);
			SwapIfGreater(ref p1, ref p6);
			SwapIfGreater(ref p2, ref p7);
			SwapIfGreater(ref p2, ref p6);
			SwapIfGreater(ref p3, ref p11);
			SwapIfGreater(ref p3, ref p10);
			SwapIfGreater(ref p4, ref p12);
			SwapIfGreater(ref p5, ref p12);
			SwapIfGreater(ref p4, ref p10);
			SwapIfGreater(ref p5, ref p11);
			SwapIfGreater(ref p5, ref p10);
			SwapIfGreater(ref p3, ref p7);
			SwapIfGreater(ref p3, ref p6);
			SwapIfGreater(ref p4, ref p8);
			SwapIfGreater(ref p5, ref p9);
			SwapIfGreater(ref p5, ref p8);
			SwapIfGreater(ref p4, ref p6);
			SwapIfGreater(ref p5, ref p7);
			SwapIfGreater(ref p5, ref p6);
			SwapIfGreater(ref p14, ref p15);
			SwapIfGreater(ref p13, ref p15);
			SwapIfGreater(ref p13, ref p14);
			SwapIfGreater(ref p17, ref p18);
			SwapIfGreater(ref p16, ref p18);
			SwapIfGreater(ref p16, ref p17);
			SwapIfGreater(ref p13, ref p17);
			SwapIfGreater(ref p13, ref p16);
			SwapIfGreater(ref p14, ref p18);
			SwapIfGreater(ref p15, ref p18);
			SwapIfGreater(ref p14, ref p16);
			SwapIfGreater(ref p15, ref p17);
			SwapIfGreater(ref p15, ref p16);
			SwapIfGreater(ref p20, ref p21);
			SwapIfGreater(ref p19, ref p21);
			SwapIfGreater(ref p19, ref p20);
			SwapIfGreater(ref p22, ref p23);
			SwapIfGreater(ref p24, ref p25);
			SwapIfGreater(ref p22, ref p24);
			SwapIfGreater(ref p23, ref p25);
			SwapIfGreater(ref p23, ref p24);
			SwapIfGreater(ref p19, ref p23);
			SwapIfGreater(ref p19, ref p22);
			SwapIfGreater(ref p20, ref p24);
			SwapIfGreater(ref p21, ref p25);
			SwapIfGreater(ref p21, ref p24);
			SwapIfGreater(ref p20, ref p22);
			SwapIfGreater(ref p21, ref p23);
			SwapIfGreater(ref p21, ref p22);
			SwapIfGreater(ref p13, ref p20);
			SwapIfGreater(ref p13, ref p19);
			SwapIfGreater(ref p14, ref p21);
			SwapIfGreater(ref p15, ref p22);
			SwapIfGreater(ref p15, ref p21);
			SwapIfGreater(ref p14, ref p19);
			SwapIfGreater(ref p15, ref p20);
			SwapIfGreater(ref p15, ref p19);
			SwapIfGreater(ref p16, ref p24);
			SwapIfGreater(ref p16, ref p23);
			SwapIfGreater(ref p17, ref p25);
			SwapIfGreater(ref p18, ref p25);
			SwapIfGreater(ref p17, ref p23);
			SwapIfGreater(ref p18, ref p24);
			SwapIfGreater(ref p18, ref p23);
			SwapIfGreater(ref p16, ref p20);
			SwapIfGreater(ref p16, ref p19);
			SwapIfGreater(ref p17, ref p21);
			SwapIfGreater(ref p18, ref p22);
			SwapIfGreater(ref p18, ref p21);
			SwapIfGreater(ref p17, ref p19);
			SwapIfGreater(ref p18, ref p20);
			SwapIfGreater(ref p18, ref p19);
			SwapIfGreater(ref p0, ref p14);
			SwapIfGreater(ref p0, ref p13);
			SwapIfGreater(ref p1, ref p15);
			SwapIfGreater(ref p2, ref p16);
			SwapIfGreater(ref p2, ref p15);
			SwapIfGreater(ref p1, ref p13);
			SwapIfGreater(ref p2, ref p14);
			SwapIfGreater(ref p2, ref p13);
			SwapIfGreater(ref p3, ref p18);
			SwapIfGreater(ref p3, ref p17);
			SwapIfGreater(ref p4, ref p19);
			SwapIfGreater(ref p5, ref p19);
			SwapIfGreater(ref p4, ref p17);
			SwapIfGreater(ref p5, ref p18);
			SwapIfGreater(ref p5, ref p17);
			SwapIfGreater(ref p3, ref p14);
			SwapIfGreater(ref p3, ref p13);
			SwapIfGreater(ref p4, ref p15);
			SwapIfGreater(ref p5, ref p16);
			SwapIfGreater(ref p5, ref p15);
			SwapIfGreater(ref p4, ref p13);
			SwapIfGreater(ref p5, ref p14);
			SwapIfGreater(ref p5, ref p13);
			SwapIfGreater(ref p6, ref p21);
			SwapIfGreater(ref p6, ref p20);
			SwapIfGreater(ref p7, ref p22);
			SwapIfGreater(ref p8, ref p22);
			SwapIfGreater(ref p7, ref p20);
			SwapIfGreater(ref p8, ref p21);
			SwapIfGreater(ref p8, ref p20);
			SwapIfGreater(ref p9, ref p23);
			SwapIfGreater(ref p10, ref p24);
			SwapIfGreater(ref p10, ref p23);
			SwapIfGreater(ref p11, ref p25);
			SwapIfGreater(ref p12, ref p25);
			SwapIfGreater(ref p11, ref p23);
			SwapIfGreater(ref p12, ref p24);
			SwapIfGreater(ref p12, ref p23);
			SwapIfGreater(ref p9, ref p20);
			SwapIfGreater(ref p10, ref p21);
			SwapIfGreater(ref p10, ref p20);
			SwapIfGreater(ref p11, ref p22);
			SwapIfGreater(ref p12, ref p22);
			SwapIfGreater(ref p11, ref p20);
			SwapIfGreater(ref p12, ref p21);
			SwapIfGreater(ref p12, ref p20);
			SwapIfGreater(ref p6, ref p14);
			SwapIfGreater(ref p6, ref p13);
			SwapIfGreater(ref p7, ref p15);
			SwapIfGreater(ref p8, ref p16);
			SwapIfGreater(ref p8, ref p15);
			SwapIfGreater(ref p7, ref p13);
			SwapIfGreater(ref p8, ref p14);
			SwapIfGreater(ref p8, ref p13);
			SwapIfGreater(ref p9, ref p17);
			SwapIfGreater(ref p10, ref p18);
			SwapIfGreater(ref p10, ref p17);
			SwapIfGreater(ref p11, ref p19);
			SwapIfGreater(ref p12, ref p19);
			SwapIfGreater(ref p11, ref p17);
			SwapIfGreater(ref p12, ref p18);
			SwapIfGreater(ref p12, ref p17);
			SwapIfGreater(ref p9, ref p13);
			SwapIfGreater(ref p10, ref p14);
			SwapIfGreater(ref p10, ref p13);
			SwapIfGreater(ref p11, ref p15);
			SwapIfGreater(ref p12, ref p16);
			SwapIfGreater(ref p12, ref p15);
			SwapIfGreater(ref p11, ref p13);
			SwapIfGreater(ref p12, ref p14);
			SwapIfGreater(ref p12, ref p13);
		}

		/// <summary>
		/// Sorts a collection of 26 elements in descending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort26Descending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);
			ref var p10 = ref Unsafe.Add(ref p9, 10);
			ref var p11 = ref Unsafe.Add(ref p10, 11);
			ref var p12 = ref Unsafe.Add(ref p11, 12);
			ref var p13 = ref Unsafe.Add(ref p12, 13);
			ref var p14 = ref Unsafe.Add(ref p13, 14);
			ref var p15 = ref Unsafe.Add(ref p14, 15);
			ref var p16 = ref Unsafe.Add(ref p15, 16);
			ref var p17 = ref Unsafe.Add(ref p16, 17);
			ref var p18 = ref Unsafe.Add(ref p17, 18);
			ref var p19 = ref Unsafe.Add(ref p18, 19);
			ref var p20 = ref Unsafe.Add(ref p19, 20);
			ref var p21 = ref Unsafe.Add(ref p20, 21);
			ref var p22 = ref Unsafe.Add(ref p21, 22);
			ref var p23 = ref Unsafe.Add(ref p22, 23);
			ref var p24 = ref Unsafe.Add(ref p23, 24);
			ref var p25 = ref Unsafe.Add(ref p24, 25);

			SwapIfLesser(ref p1, ref p2);
			SwapIfLesser(ref p0, ref p2);
			SwapIfLesser(ref p0, ref p1);
			SwapIfLesser(ref p4, ref p5);
			SwapIfLesser(ref p3, ref p5);
			SwapIfLesser(ref p3, ref p4);
			SwapIfLesser(ref p0, ref p4);
			SwapIfLesser(ref p0, ref p3);
			SwapIfLesser(ref p1, ref p5);
			SwapIfLesser(ref p2, ref p5);
			SwapIfLesser(ref p1, ref p3);
			SwapIfLesser(ref p2, ref p4);
			SwapIfLesser(ref p2, ref p3);
			SwapIfLesser(ref p7, ref p8);
			SwapIfLesser(ref p6, ref p8);
			SwapIfLesser(ref p6, ref p7);
			SwapIfLesser(ref p9, ref p10);
			SwapIfLesser(ref p11, ref p12);
			SwapIfLesser(ref p9, ref p11);
			SwapIfLesser(ref p10, ref p12);
			SwapIfLesser(ref p10, ref p11);
			SwapIfLesser(ref p6, ref p10);
			SwapIfLesser(ref p6, ref p9);
			SwapIfLesser(ref p7, ref p11);
			SwapIfLesser(ref p8, ref p12);
			SwapIfLesser(ref p8, ref p11);
			SwapIfLesser(ref p7, ref p9);
			SwapIfLesser(ref p8, ref p10);
			SwapIfLesser(ref p8, ref p9);
			SwapIfLesser(ref p0, ref p7);
			SwapIfLesser(ref p0, ref p6);
			SwapIfLesser(ref p1, ref p8);
			SwapIfLesser(ref p2, ref p9);
			SwapIfLesser(ref p2, ref p8);
			SwapIfLesser(ref p1, ref p6);
			SwapIfLesser(ref p2, ref p7);
			SwapIfLesser(ref p2, ref p6);
			SwapIfLesser(ref p3, ref p11);
			SwapIfLesser(ref p3, ref p10);
			SwapIfLesser(ref p4, ref p12);
			SwapIfLesser(ref p5, ref p12);
			SwapIfLesser(ref p4, ref p10);
			SwapIfLesser(ref p5, ref p11);
			SwapIfLesser(ref p5, ref p10);
			SwapIfLesser(ref p3, ref p7);
			SwapIfLesser(ref p3, ref p6);
			SwapIfLesser(ref p4, ref p8);
			SwapIfLesser(ref p5, ref p9);
			SwapIfLesser(ref p5, ref p8);
			SwapIfLesser(ref p4, ref p6);
			SwapIfLesser(ref p5, ref p7);
			SwapIfLesser(ref p5, ref p6);
			SwapIfLesser(ref p14, ref p15);
			SwapIfLesser(ref p13, ref p15);
			SwapIfLesser(ref p13, ref p14);
			SwapIfLesser(ref p17, ref p18);
			SwapIfLesser(ref p16, ref p18);
			SwapIfLesser(ref p16, ref p17);
			SwapIfLesser(ref p13, ref p17);
			SwapIfLesser(ref p13, ref p16);
			SwapIfLesser(ref p14, ref p18);
			SwapIfLesser(ref p15, ref p18);
			SwapIfLesser(ref p14, ref p16);
			SwapIfLesser(ref p15, ref p17);
			SwapIfLesser(ref p15, ref p16);
			SwapIfLesser(ref p20, ref p21);
			SwapIfLesser(ref p19, ref p21);
			SwapIfLesser(ref p19, ref p20);
			SwapIfLesser(ref p22, ref p23);
			SwapIfLesser(ref p24, ref p25);
			SwapIfLesser(ref p22, ref p24);
			SwapIfLesser(ref p23, ref p25);
			SwapIfLesser(ref p23, ref p24);
			SwapIfLesser(ref p19, ref p23);
			SwapIfLesser(ref p19, ref p22);
			SwapIfLesser(ref p20, ref p24);
			SwapIfLesser(ref p21, ref p25);
			SwapIfLesser(ref p21, ref p24);
			SwapIfLesser(ref p20, ref p22);
			SwapIfLesser(ref p21, ref p23);
			SwapIfLesser(ref p21, ref p22);
			SwapIfLesser(ref p13, ref p20);
			SwapIfLesser(ref p13, ref p19);
			SwapIfLesser(ref p14, ref p21);
			SwapIfLesser(ref p15, ref p22);
			SwapIfLesser(ref p15, ref p21);
			SwapIfLesser(ref p14, ref p19);
			SwapIfLesser(ref p15, ref p20);
			SwapIfLesser(ref p15, ref p19);
			SwapIfLesser(ref p16, ref p24);
			SwapIfLesser(ref p16, ref p23);
			SwapIfLesser(ref p17, ref p25);
			SwapIfLesser(ref p18, ref p25);
			SwapIfLesser(ref p17, ref p23);
			SwapIfLesser(ref p18, ref p24);
			SwapIfLesser(ref p18, ref p23);
			SwapIfLesser(ref p16, ref p20);
			SwapIfLesser(ref p16, ref p19);
			SwapIfLesser(ref p17, ref p21);
			SwapIfLesser(ref p18, ref p22);
			SwapIfLesser(ref p18, ref p21);
			SwapIfLesser(ref p17, ref p19);
			SwapIfLesser(ref p18, ref p20);
			SwapIfLesser(ref p18, ref p19);
			SwapIfLesser(ref p0, ref p14);
			SwapIfLesser(ref p0, ref p13);
			SwapIfLesser(ref p1, ref p15);
			SwapIfLesser(ref p2, ref p16);
			SwapIfLesser(ref p2, ref p15);
			SwapIfLesser(ref p1, ref p13);
			SwapIfLesser(ref p2, ref p14);
			SwapIfLesser(ref p2, ref p13);
			SwapIfLesser(ref p3, ref p18);
			SwapIfLesser(ref p3, ref p17);
			SwapIfLesser(ref p4, ref p19);
			SwapIfLesser(ref p5, ref p19);
			SwapIfLesser(ref p4, ref p17);
			SwapIfLesser(ref p5, ref p18);
			SwapIfLesser(ref p5, ref p17);
			SwapIfLesser(ref p3, ref p14);
			SwapIfLesser(ref p3, ref p13);
			SwapIfLesser(ref p4, ref p15);
			SwapIfLesser(ref p5, ref p16);
			SwapIfLesser(ref p5, ref p15);
			SwapIfLesser(ref p4, ref p13);
			SwapIfLesser(ref p5, ref p14);
			SwapIfLesser(ref p5, ref p13);
			SwapIfLesser(ref p6, ref p21);
			SwapIfLesser(ref p6, ref p20);
			SwapIfLesser(ref p7, ref p22);
			SwapIfLesser(ref p8, ref p22);
			SwapIfLesser(ref p7, ref p20);
			SwapIfLesser(ref p8, ref p21);
			SwapIfLesser(ref p8, ref p20);
			SwapIfLesser(ref p9, ref p23);
			SwapIfLesser(ref p10, ref p24);
			SwapIfLesser(ref p10, ref p23);
			SwapIfLesser(ref p11, ref p25);
			SwapIfLesser(ref p12, ref p25);
			SwapIfLesser(ref p11, ref p23);
			SwapIfLesser(ref p12, ref p24);
			SwapIfLesser(ref p12, ref p23);
			SwapIfLesser(ref p9, ref p20);
			SwapIfLesser(ref p10, ref p21);
			SwapIfLesser(ref p10, ref p20);
			SwapIfLesser(ref p11, ref p22);
			SwapIfLesser(ref p12, ref p22);
			SwapIfLesser(ref p11, ref p20);
			SwapIfLesser(ref p12, ref p21);
			SwapIfLesser(ref p12, ref p20);
			SwapIfLesser(ref p6, ref p14);
			SwapIfLesser(ref p6, ref p13);
			SwapIfLesser(ref p7, ref p15);
			SwapIfLesser(ref p8, ref p16);
			SwapIfLesser(ref p8, ref p15);
			SwapIfLesser(ref p7, ref p13);
			SwapIfLesser(ref p8, ref p14);
			SwapIfLesser(ref p8, ref p13);
			SwapIfLesser(ref p9, ref p17);
			SwapIfLesser(ref p10, ref p18);
			SwapIfLesser(ref p10, ref p17);
			SwapIfLesser(ref p11, ref p19);
			SwapIfLesser(ref p12, ref p19);
			SwapIfLesser(ref p11, ref p17);
			SwapIfLesser(ref p12, ref p18);
			SwapIfLesser(ref p12, ref p17);
			SwapIfLesser(ref p9, ref p13);
			SwapIfLesser(ref p10, ref p14);
			SwapIfLesser(ref p10, ref p13);
			SwapIfLesser(ref p11, ref p15);
			SwapIfLesser(ref p12, ref p16);
			SwapIfLesser(ref p12, ref p15);
			SwapIfLesser(ref p11, ref p13);
			SwapIfLesser(ref p12, ref p14);
			SwapIfLesser(ref p12, ref p13);
		}

		/// <summary>
		/// Sorts a collection of 27 elements in ascending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort27Ascending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);
			ref var p10 = ref Unsafe.Add(ref p9, 10);
			ref var p11 = ref Unsafe.Add(ref p10, 11);
			ref var p12 = ref Unsafe.Add(ref p11, 12);
			ref var p13 = ref Unsafe.Add(ref p12, 13);
			ref var p14 = ref Unsafe.Add(ref p13, 14);
			ref var p15 = ref Unsafe.Add(ref p14, 15);
			ref var p16 = ref Unsafe.Add(ref p15, 16);
			ref var p17 = ref Unsafe.Add(ref p16, 17);
			ref var p18 = ref Unsafe.Add(ref p17, 18);
			ref var p19 = ref Unsafe.Add(ref p18, 19);
			ref var p20 = ref Unsafe.Add(ref p19, 20);
			ref var p21 = ref Unsafe.Add(ref p20, 21);
			ref var p22 = ref Unsafe.Add(ref p21, 22);
			ref var p23 = ref Unsafe.Add(ref p22, 23);
			ref var p24 = ref Unsafe.Add(ref p23, 24);
			ref var p25 = ref Unsafe.Add(ref p24, 25);
			ref var p26 = ref Unsafe.Add(ref p25, 26);

			SwapIfGreater(ref p1, ref p2);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p4, ref p5);
			SwapIfGreater(ref p3, ref p5);
			SwapIfGreater(ref p3, ref p4);
			SwapIfGreater(ref p0, ref p4);
			SwapIfGreater(ref p0, ref p3);
			SwapIfGreater(ref p1, ref p5);
			SwapIfGreater(ref p2, ref p5);
			SwapIfGreater(ref p1, ref p3);
			SwapIfGreater(ref p2, ref p4);
			SwapIfGreater(ref p2, ref p3);
			SwapIfGreater(ref p7, ref p8);
			SwapIfGreater(ref p6, ref p8);
			SwapIfGreater(ref p6, ref p7);
			SwapIfGreater(ref p9, ref p10);
			SwapIfGreater(ref p11, ref p12);
			SwapIfGreater(ref p9, ref p11);
			SwapIfGreater(ref p10, ref p12);
			SwapIfGreater(ref p10, ref p11);
			SwapIfGreater(ref p6, ref p10);
			SwapIfGreater(ref p6, ref p9);
			SwapIfGreater(ref p7, ref p11);
			SwapIfGreater(ref p8, ref p12);
			SwapIfGreater(ref p8, ref p11);
			SwapIfGreater(ref p7, ref p9);
			SwapIfGreater(ref p8, ref p10);
			SwapIfGreater(ref p8, ref p9);
			SwapIfGreater(ref p0, ref p7);
			SwapIfGreater(ref p0, ref p6);
			SwapIfGreater(ref p1, ref p8);
			SwapIfGreater(ref p2, ref p9);
			SwapIfGreater(ref p2, ref p8);
			SwapIfGreater(ref p1, ref p6);
			SwapIfGreater(ref p2, ref p7);
			SwapIfGreater(ref p2, ref p6);
			SwapIfGreater(ref p3, ref p11);
			SwapIfGreater(ref p3, ref p10);
			SwapIfGreater(ref p4, ref p12);
			SwapIfGreater(ref p5, ref p12);
			SwapIfGreater(ref p4, ref p10);
			SwapIfGreater(ref p5, ref p11);
			SwapIfGreater(ref p5, ref p10);
			SwapIfGreater(ref p3, ref p7);
			SwapIfGreater(ref p3, ref p6);
			SwapIfGreater(ref p4, ref p8);
			SwapIfGreater(ref p5, ref p9);
			SwapIfGreater(ref p5, ref p8);
			SwapIfGreater(ref p4, ref p6);
			SwapIfGreater(ref p5, ref p7);
			SwapIfGreater(ref p5, ref p6);
			SwapIfGreater(ref p14, ref p15);
			SwapIfGreater(ref p13, ref p15);
			SwapIfGreater(ref p13, ref p14);
			SwapIfGreater(ref p16, ref p17);
			SwapIfGreater(ref p18, ref p19);
			SwapIfGreater(ref p16, ref p18);
			SwapIfGreater(ref p17, ref p19);
			SwapIfGreater(ref p17, ref p18);
			SwapIfGreater(ref p13, ref p17);
			SwapIfGreater(ref p13, ref p16);
			SwapIfGreater(ref p14, ref p18);
			SwapIfGreater(ref p15, ref p19);
			SwapIfGreater(ref p15, ref p18);
			SwapIfGreater(ref p14, ref p16);
			SwapIfGreater(ref p15, ref p17);
			SwapIfGreater(ref p15, ref p16);
			SwapIfGreater(ref p21, ref p22);
			SwapIfGreater(ref p20, ref p22);
			SwapIfGreater(ref p20, ref p21);
			SwapIfGreater(ref p23, ref p24);
			SwapIfGreater(ref p25, ref p26);
			SwapIfGreater(ref p23, ref p25);
			SwapIfGreater(ref p24, ref p26);
			SwapIfGreater(ref p24, ref p25);
			SwapIfGreater(ref p20, ref p24);
			SwapIfGreater(ref p20, ref p23);
			SwapIfGreater(ref p21, ref p25);
			SwapIfGreater(ref p22, ref p26);
			SwapIfGreater(ref p22, ref p25);
			SwapIfGreater(ref p21, ref p23);
			SwapIfGreater(ref p22, ref p24);
			SwapIfGreater(ref p22, ref p23);
			SwapIfGreater(ref p13, ref p21);
			SwapIfGreater(ref p13, ref p20);
			SwapIfGreater(ref p14, ref p22);
			SwapIfGreater(ref p15, ref p23);
			SwapIfGreater(ref p15, ref p22);
			SwapIfGreater(ref p14, ref p20);
			SwapIfGreater(ref p15, ref p21);
			SwapIfGreater(ref p15, ref p20);
			SwapIfGreater(ref p16, ref p24);
			SwapIfGreater(ref p17, ref p25);
			SwapIfGreater(ref p17, ref p24);
			SwapIfGreater(ref p18, ref p26);
			SwapIfGreater(ref p19, ref p26);
			SwapIfGreater(ref p18, ref p24);
			SwapIfGreater(ref p19, ref p25);
			SwapIfGreater(ref p19, ref p24);
			SwapIfGreater(ref p16, ref p20);
			SwapIfGreater(ref p17, ref p21);
			SwapIfGreater(ref p17, ref p20);
			SwapIfGreater(ref p18, ref p22);
			SwapIfGreater(ref p19, ref p23);
			SwapIfGreater(ref p19, ref p22);
			SwapIfGreater(ref p18, ref p20);
			SwapIfGreater(ref p19, ref p21);
			SwapIfGreater(ref p19, ref p20);
			SwapIfGreater(ref p0, ref p14);
			SwapIfGreater(ref p0, ref p13);
			SwapIfGreater(ref p1, ref p15);
			SwapIfGreater(ref p2, ref p16);
			SwapIfGreater(ref p2, ref p15);
			SwapIfGreater(ref p1, ref p13);
			SwapIfGreater(ref p2, ref p14);
			SwapIfGreater(ref p2, ref p13);
			SwapIfGreater(ref p3, ref p18);
			SwapIfGreater(ref p3, ref p17);
			SwapIfGreater(ref p4, ref p19);
			SwapIfGreater(ref p5, ref p19);
			SwapIfGreater(ref p4, ref p17);
			SwapIfGreater(ref p5, ref p18);
			SwapIfGreater(ref p5, ref p17);
			SwapIfGreater(ref p3, ref p14);
			SwapIfGreater(ref p3, ref p13);
			SwapIfGreater(ref p4, ref p15);
			SwapIfGreater(ref p5, ref p16);
			SwapIfGreater(ref p5, ref p15);
			SwapIfGreater(ref p4, ref p13);
			SwapIfGreater(ref p5, ref p14);
			SwapIfGreater(ref p5, ref p13);
			SwapIfGreater(ref p6, ref p21);
			SwapIfGreater(ref p6, ref p20);
			SwapIfGreater(ref p7, ref p22);
			SwapIfGreater(ref p8, ref p23);
			SwapIfGreater(ref p8, ref p22);
			SwapIfGreater(ref p7, ref p20);
			SwapIfGreater(ref p8, ref p21);
			SwapIfGreater(ref p8, ref p20);
			SwapIfGreater(ref p9, ref p24);
			SwapIfGreater(ref p10, ref p25);
			SwapIfGreater(ref p10, ref p24);
			SwapIfGreater(ref p11, ref p26);
			SwapIfGreater(ref p12, ref p26);
			SwapIfGreater(ref p11, ref p24);
			SwapIfGreater(ref p12, ref p25);
			SwapIfGreater(ref p12, ref p24);
			SwapIfGreater(ref p9, ref p20);
			SwapIfGreater(ref p10, ref p21);
			SwapIfGreater(ref p10, ref p20);
			SwapIfGreater(ref p11, ref p22);
			SwapIfGreater(ref p12, ref p23);
			SwapIfGreater(ref p12, ref p22);
			SwapIfGreater(ref p11, ref p20);
			SwapIfGreater(ref p12, ref p21);
			SwapIfGreater(ref p12, ref p20);
			SwapIfGreater(ref p6, ref p14);
			SwapIfGreater(ref p6, ref p13);
			SwapIfGreater(ref p7, ref p15);
			SwapIfGreater(ref p8, ref p16);
			SwapIfGreater(ref p8, ref p15);
			SwapIfGreater(ref p7, ref p13);
			SwapIfGreater(ref p8, ref p14);
			SwapIfGreater(ref p8, ref p13);
			SwapIfGreater(ref p9, ref p17);
			SwapIfGreater(ref p10, ref p18);
			SwapIfGreater(ref p10, ref p17);
			SwapIfGreater(ref p11, ref p19);
			SwapIfGreater(ref p12, ref p19);
			SwapIfGreater(ref p11, ref p17);
			SwapIfGreater(ref p12, ref p18);
			SwapIfGreater(ref p12, ref p17);
			SwapIfGreater(ref p9, ref p13);
			SwapIfGreater(ref p10, ref p14);
			SwapIfGreater(ref p10, ref p13);
			SwapIfGreater(ref p11, ref p15);
			SwapIfGreater(ref p12, ref p16);
			SwapIfGreater(ref p12, ref p15);
			SwapIfGreater(ref p11, ref p13);
			SwapIfGreater(ref p12, ref p14);
			SwapIfGreater(ref p12, ref p13);
		}

		/// <summary>
		/// Sorts a collection of 27 elements in descending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort27Descending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);
			ref var p10 = ref Unsafe.Add(ref p9, 10);
			ref var p11 = ref Unsafe.Add(ref p10, 11);
			ref var p12 = ref Unsafe.Add(ref p11, 12);
			ref var p13 = ref Unsafe.Add(ref p12, 13);
			ref var p14 = ref Unsafe.Add(ref p13, 14);
			ref var p15 = ref Unsafe.Add(ref p14, 15);
			ref var p16 = ref Unsafe.Add(ref p15, 16);
			ref var p17 = ref Unsafe.Add(ref p16, 17);
			ref var p18 = ref Unsafe.Add(ref p17, 18);
			ref var p19 = ref Unsafe.Add(ref p18, 19);
			ref var p20 = ref Unsafe.Add(ref p19, 20);
			ref var p21 = ref Unsafe.Add(ref p20, 21);
			ref var p22 = ref Unsafe.Add(ref p21, 22);
			ref var p23 = ref Unsafe.Add(ref p22, 23);
			ref var p24 = ref Unsafe.Add(ref p23, 24);
			ref var p25 = ref Unsafe.Add(ref p24, 25);
			ref var p26 = ref Unsafe.Add(ref p25, 26);

			SwapIfLesser(ref p1, ref p2);
			SwapIfLesser(ref p0, ref p2);
			SwapIfLesser(ref p0, ref p1);
			SwapIfLesser(ref p4, ref p5);
			SwapIfLesser(ref p3, ref p5);
			SwapIfLesser(ref p3, ref p4);
			SwapIfLesser(ref p0, ref p4);
			SwapIfLesser(ref p0, ref p3);
			SwapIfLesser(ref p1, ref p5);
			SwapIfLesser(ref p2, ref p5);
			SwapIfLesser(ref p1, ref p3);
			SwapIfLesser(ref p2, ref p4);
			SwapIfLesser(ref p2, ref p3);
			SwapIfLesser(ref p7, ref p8);
			SwapIfLesser(ref p6, ref p8);
			SwapIfLesser(ref p6, ref p7);
			SwapIfLesser(ref p9, ref p10);
			SwapIfLesser(ref p11, ref p12);
			SwapIfLesser(ref p9, ref p11);
			SwapIfLesser(ref p10, ref p12);
			SwapIfLesser(ref p10, ref p11);
			SwapIfLesser(ref p6, ref p10);
			SwapIfLesser(ref p6, ref p9);
			SwapIfLesser(ref p7, ref p11);
			SwapIfLesser(ref p8, ref p12);
			SwapIfLesser(ref p8, ref p11);
			SwapIfLesser(ref p7, ref p9);
			SwapIfLesser(ref p8, ref p10);
			SwapIfLesser(ref p8, ref p9);
			SwapIfLesser(ref p0, ref p7);
			SwapIfLesser(ref p0, ref p6);
			SwapIfLesser(ref p1, ref p8);
			SwapIfLesser(ref p2, ref p9);
			SwapIfLesser(ref p2, ref p8);
			SwapIfLesser(ref p1, ref p6);
			SwapIfLesser(ref p2, ref p7);
			SwapIfLesser(ref p2, ref p6);
			SwapIfLesser(ref p3, ref p11);
			SwapIfLesser(ref p3, ref p10);
			SwapIfLesser(ref p4, ref p12);
			SwapIfLesser(ref p5, ref p12);
			SwapIfLesser(ref p4, ref p10);
			SwapIfLesser(ref p5, ref p11);
			SwapIfLesser(ref p5, ref p10);
			SwapIfLesser(ref p3, ref p7);
			SwapIfLesser(ref p3, ref p6);
			SwapIfLesser(ref p4, ref p8);
			SwapIfLesser(ref p5, ref p9);
			SwapIfLesser(ref p5, ref p8);
			SwapIfLesser(ref p4, ref p6);
			SwapIfLesser(ref p5, ref p7);
			SwapIfLesser(ref p5, ref p6);
			SwapIfLesser(ref p14, ref p15);
			SwapIfLesser(ref p13, ref p15);
			SwapIfLesser(ref p13, ref p14);
			SwapIfLesser(ref p16, ref p17);
			SwapIfLesser(ref p18, ref p19);
			SwapIfLesser(ref p16, ref p18);
			SwapIfLesser(ref p17, ref p19);
			SwapIfLesser(ref p17, ref p18);
			SwapIfLesser(ref p13, ref p17);
			SwapIfLesser(ref p13, ref p16);
			SwapIfLesser(ref p14, ref p18);
			SwapIfLesser(ref p15, ref p19);
			SwapIfLesser(ref p15, ref p18);
			SwapIfLesser(ref p14, ref p16);
			SwapIfLesser(ref p15, ref p17);
			SwapIfLesser(ref p15, ref p16);
			SwapIfLesser(ref p21, ref p22);
			SwapIfLesser(ref p20, ref p22);
			SwapIfLesser(ref p20, ref p21);
			SwapIfLesser(ref p23, ref p24);
			SwapIfLesser(ref p25, ref p26);
			SwapIfLesser(ref p23, ref p25);
			SwapIfLesser(ref p24, ref p26);
			SwapIfLesser(ref p24, ref p25);
			SwapIfLesser(ref p20, ref p24);
			SwapIfLesser(ref p20, ref p23);
			SwapIfLesser(ref p21, ref p25);
			SwapIfLesser(ref p22, ref p26);
			SwapIfLesser(ref p22, ref p25);
			SwapIfLesser(ref p21, ref p23);
			SwapIfLesser(ref p22, ref p24);
			SwapIfLesser(ref p22, ref p23);
			SwapIfLesser(ref p13, ref p21);
			SwapIfLesser(ref p13, ref p20);
			SwapIfLesser(ref p14, ref p22);
			SwapIfLesser(ref p15, ref p23);
			SwapIfLesser(ref p15, ref p22);
			SwapIfLesser(ref p14, ref p20);
			SwapIfLesser(ref p15, ref p21);
			SwapIfLesser(ref p15, ref p20);
			SwapIfLesser(ref p16, ref p24);
			SwapIfLesser(ref p17, ref p25);
			SwapIfLesser(ref p17, ref p24);
			SwapIfLesser(ref p18, ref p26);
			SwapIfLesser(ref p19, ref p26);
			SwapIfLesser(ref p18, ref p24);
			SwapIfLesser(ref p19, ref p25);
			SwapIfLesser(ref p19, ref p24);
			SwapIfLesser(ref p16, ref p20);
			SwapIfLesser(ref p17, ref p21);
			SwapIfLesser(ref p17, ref p20);
			SwapIfLesser(ref p18, ref p22);
			SwapIfLesser(ref p19, ref p23);
			SwapIfLesser(ref p19, ref p22);
			SwapIfLesser(ref p18, ref p20);
			SwapIfLesser(ref p19, ref p21);
			SwapIfLesser(ref p19, ref p20);
			SwapIfLesser(ref p0, ref p14);
			SwapIfLesser(ref p0, ref p13);
			SwapIfLesser(ref p1, ref p15);
			SwapIfLesser(ref p2, ref p16);
			SwapIfLesser(ref p2, ref p15);
			SwapIfLesser(ref p1, ref p13);
			SwapIfLesser(ref p2, ref p14);
			SwapIfLesser(ref p2, ref p13);
			SwapIfLesser(ref p3, ref p18);
			SwapIfLesser(ref p3, ref p17);
			SwapIfLesser(ref p4, ref p19);
			SwapIfLesser(ref p5, ref p19);
			SwapIfLesser(ref p4, ref p17);
			SwapIfLesser(ref p5, ref p18);
			SwapIfLesser(ref p5, ref p17);
			SwapIfLesser(ref p3, ref p14);
			SwapIfLesser(ref p3, ref p13);
			SwapIfLesser(ref p4, ref p15);
			SwapIfLesser(ref p5, ref p16);
			SwapIfLesser(ref p5, ref p15);
			SwapIfLesser(ref p4, ref p13);
			SwapIfLesser(ref p5, ref p14);
			SwapIfLesser(ref p5, ref p13);
			SwapIfLesser(ref p6, ref p21);
			SwapIfLesser(ref p6, ref p20);
			SwapIfLesser(ref p7, ref p22);
			SwapIfLesser(ref p8, ref p23);
			SwapIfLesser(ref p8, ref p22);
			SwapIfLesser(ref p7, ref p20);
			SwapIfLesser(ref p8, ref p21);
			SwapIfLesser(ref p8, ref p20);
			SwapIfLesser(ref p9, ref p24);
			SwapIfLesser(ref p10, ref p25);
			SwapIfLesser(ref p10, ref p24);
			SwapIfLesser(ref p11, ref p26);
			SwapIfLesser(ref p12, ref p26);
			SwapIfLesser(ref p11, ref p24);
			SwapIfLesser(ref p12, ref p25);
			SwapIfLesser(ref p12, ref p24);
			SwapIfLesser(ref p9, ref p20);
			SwapIfLesser(ref p10, ref p21);
			SwapIfLesser(ref p10, ref p20);
			SwapIfLesser(ref p11, ref p22);
			SwapIfLesser(ref p12, ref p23);
			SwapIfLesser(ref p12, ref p22);
			SwapIfLesser(ref p11, ref p20);
			SwapIfLesser(ref p12, ref p21);
			SwapIfLesser(ref p12, ref p20);
			SwapIfLesser(ref p6, ref p14);
			SwapIfLesser(ref p6, ref p13);
			SwapIfLesser(ref p7, ref p15);
			SwapIfLesser(ref p8, ref p16);
			SwapIfLesser(ref p8, ref p15);
			SwapIfLesser(ref p7, ref p13);
			SwapIfLesser(ref p8, ref p14);
			SwapIfLesser(ref p8, ref p13);
			SwapIfLesser(ref p9, ref p17);
			SwapIfLesser(ref p10, ref p18);
			SwapIfLesser(ref p10, ref p17);
			SwapIfLesser(ref p11, ref p19);
			SwapIfLesser(ref p12, ref p19);
			SwapIfLesser(ref p11, ref p17);
			SwapIfLesser(ref p12, ref p18);
			SwapIfLesser(ref p12, ref p17);
			SwapIfLesser(ref p9, ref p13);
			SwapIfLesser(ref p10, ref p14);
			SwapIfLesser(ref p10, ref p13);
			SwapIfLesser(ref p11, ref p15);
			SwapIfLesser(ref p12, ref p16);
			SwapIfLesser(ref p12, ref p15);
			SwapIfLesser(ref p11, ref p13);
			SwapIfLesser(ref p12, ref p14);
			SwapIfLesser(ref p12, ref p13);
		}

		/// <summary>
		/// Sorts a collection of 28 elements in ascending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort28Ascending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);
			ref var p10 = ref Unsafe.Add(ref p9, 10);
			ref var p11 = ref Unsafe.Add(ref p10, 11);
			ref var p12 = ref Unsafe.Add(ref p11, 12);
			ref var p13 = ref Unsafe.Add(ref p12, 13);
			ref var p14 = ref Unsafe.Add(ref p13, 14);
			ref var p15 = ref Unsafe.Add(ref p14, 15);
			ref var p16 = ref Unsafe.Add(ref p15, 16);
			ref var p17 = ref Unsafe.Add(ref p16, 17);
			ref var p18 = ref Unsafe.Add(ref p17, 18);
			ref var p19 = ref Unsafe.Add(ref p18, 19);
			ref var p20 = ref Unsafe.Add(ref p19, 20);
			ref var p21 = ref Unsafe.Add(ref p20, 21);
			ref var p22 = ref Unsafe.Add(ref p21, 22);
			ref var p23 = ref Unsafe.Add(ref p22, 23);
			ref var p24 = ref Unsafe.Add(ref p23, 24);
			ref var p25 = ref Unsafe.Add(ref p24, 25);
			ref var p26 = ref Unsafe.Add(ref p25, 26);
			ref var p27 = ref Unsafe.Add(ref p26, 27);

			SwapIfGreater(ref p1, ref p2);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p3, ref p4);
			SwapIfGreater(ref p5, ref p6);
			SwapIfGreater(ref p3, ref p5);
			SwapIfGreater(ref p4, ref p6);
			SwapIfGreater(ref p4, ref p5);
			SwapIfGreater(ref p0, ref p4);
			SwapIfGreater(ref p0, ref p3);
			SwapIfGreater(ref p1, ref p5);
			SwapIfGreater(ref p2, ref p6);
			SwapIfGreater(ref p2, ref p5);
			SwapIfGreater(ref p1, ref p3);
			SwapIfGreater(ref p2, ref p4);
			SwapIfGreater(ref p2, ref p3);
			SwapIfGreater(ref p8, ref p9);
			SwapIfGreater(ref p7, ref p9);
			SwapIfGreater(ref p7, ref p8);
			SwapIfGreater(ref p10, ref p11);
			SwapIfGreater(ref p12, ref p13);
			SwapIfGreater(ref p10, ref p12);
			SwapIfGreater(ref p11, ref p13);
			SwapIfGreater(ref p11, ref p12);
			SwapIfGreater(ref p7, ref p11);
			SwapIfGreater(ref p7, ref p10);
			SwapIfGreater(ref p8, ref p12);
			SwapIfGreater(ref p9, ref p13);
			SwapIfGreater(ref p9, ref p12);
			SwapIfGreater(ref p8, ref p10);
			SwapIfGreater(ref p9, ref p11);
			SwapIfGreater(ref p9, ref p10);
			SwapIfGreater(ref p0, ref p8);
			SwapIfGreater(ref p0, ref p7);
			SwapIfGreater(ref p1, ref p9);
			SwapIfGreater(ref p2, ref p10);
			SwapIfGreater(ref p2, ref p9);
			SwapIfGreater(ref p1, ref p7);
			SwapIfGreater(ref p2, ref p8);
			SwapIfGreater(ref p2, ref p7);
			SwapIfGreater(ref p3, ref p11);
			SwapIfGreater(ref p4, ref p12);
			SwapIfGreater(ref p4, ref p11);
			SwapIfGreater(ref p5, ref p13);
			SwapIfGreater(ref p6, ref p13);
			SwapIfGreater(ref p5, ref p11);
			SwapIfGreater(ref p6, ref p12);
			SwapIfGreater(ref p6, ref p11);
			SwapIfGreater(ref p3, ref p7);
			SwapIfGreater(ref p4, ref p8);
			SwapIfGreater(ref p4, ref p7);
			SwapIfGreater(ref p5, ref p9);
			SwapIfGreater(ref p6, ref p10);
			SwapIfGreater(ref p6, ref p9);
			SwapIfGreater(ref p5, ref p7);
			SwapIfGreater(ref p6, ref p8);
			SwapIfGreater(ref p6, ref p7);
			SwapIfGreater(ref p15, ref p16);
			SwapIfGreater(ref p14, ref p16);
			SwapIfGreater(ref p14, ref p15);
			SwapIfGreater(ref p17, ref p18);
			SwapIfGreater(ref p19, ref p20);
			SwapIfGreater(ref p17, ref p19);
			SwapIfGreater(ref p18, ref p20);
			SwapIfGreater(ref p18, ref p19);
			SwapIfGreater(ref p14, ref p18);
			SwapIfGreater(ref p14, ref p17);
			SwapIfGreater(ref p15, ref p19);
			SwapIfGreater(ref p16, ref p20);
			SwapIfGreater(ref p16, ref p19);
			SwapIfGreater(ref p15, ref p17);
			SwapIfGreater(ref p16, ref p18);
			SwapIfGreater(ref p16, ref p17);
			SwapIfGreater(ref p22, ref p23);
			SwapIfGreater(ref p21, ref p23);
			SwapIfGreater(ref p21, ref p22);
			SwapIfGreater(ref p24, ref p25);
			SwapIfGreater(ref p26, ref p27);
			SwapIfGreater(ref p24, ref p26);
			SwapIfGreater(ref p25, ref p27);
			SwapIfGreater(ref p25, ref p26);
			SwapIfGreater(ref p21, ref p25);
			SwapIfGreater(ref p21, ref p24);
			SwapIfGreater(ref p22, ref p26);
			SwapIfGreater(ref p23, ref p27);
			SwapIfGreater(ref p23, ref p26);
			SwapIfGreater(ref p22, ref p24);
			SwapIfGreater(ref p23, ref p25);
			SwapIfGreater(ref p23, ref p24);
			SwapIfGreater(ref p14, ref p22);
			SwapIfGreater(ref p14, ref p21);
			SwapIfGreater(ref p15, ref p23);
			SwapIfGreater(ref p16, ref p24);
			SwapIfGreater(ref p16, ref p23);
			SwapIfGreater(ref p15, ref p21);
			SwapIfGreater(ref p16, ref p22);
			SwapIfGreater(ref p16, ref p21);
			SwapIfGreater(ref p17, ref p25);
			SwapIfGreater(ref p18, ref p26);
			SwapIfGreater(ref p18, ref p25);
			SwapIfGreater(ref p19, ref p27);
			SwapIfGreater(ref p20, ref p27);
			SwapIfGreater(ref p19, ref p25);
			SwapIfGreater(ref p20, ref p26);
			SwapIfGreater(ref p20, ref p25);
			SwapIfGreater(ref p17, ref p21);
			SwapIfGreater(ref p18, ref p22);
			SwapIfGreater(ref p18, ref p21);
			SwapIfGreater(ref p19, ref p23);
			SwapIfGreater(ref p20, ref p24);
			SwapIfGreater(ref p20, ref p23);
			SwapIfGreater(ref p19, ref p21);
			SwapIfGreater(ref p20, ref p22);
			SwapIfGreater(ref p20, ref p21);
			SwapIfGreater(ref p0, ref p15);
			SwapIfGreater(ref p0, ref p14);
			SwapIfGreater(ref p1, ref p16);
			SwapIfGreater(ref p2, ref p17);
			SwapIfGreater(ref p2, ref p16);
			SwapIfGreater(ref p1, ref p14);
			SwapIfGreater(ref p2, ref p15);
			SwapIfGreater(ref p2, ref p14);
			SwapIfGreater(ref p3, ref p18);
			SwapIfGreater(ref p4, ref p19);
			SwapIfGreater(ref p4, ref p18);
			SwapIfGreater(ref p5, ref p20);
			SwapIfGreater(ref p6, ref p20);
			SwapIfGreater(ref p5, ref p18);
			SwapIfGreater(ref p6, ref p19);
			SwapIfGreater(ref p6, ref p18);
			SwapIfGreater(ref p3, ref p14);
			SwapIfGreater(ref p4, ref p15);
			SwapIfGreater(ref p4, ref p14);
			SwapIfGreater(ref p5, ref p16);
			SwapIfGreater(ref p6, ref p17);
			SwapIfGreater(ref p6, ref p16);
			SwapIfGreater(ref p5, ref p14);
			SwapIfGreater(ref p6, ref p15);
			SwapIfGreater(ref p6, ref p14);
			SwapIfGreater(ref p7, ref p22);
			SwapIfGreater(ref p7, ref p21);
			SwapIfGreater(ref p8, ref p23);
			SwapIfGreater(ref p9, ref p24);
			SwapIfGreater(ref p9, ref p23);
			SwapIfGreater(ref p8, ref p21);
			SwapIfGreater(ref p9, ref p22);
			SwapIfGreater(ref p9, ref p21);
			SwapIfGreater(ref p10, ref p25);
			SwapIfGreater(ref p11, ref p26);
			SwapIfGreater(ref p11, ref p25);
			SwapIfGreater(ref p12, ref p27);
			SwapIfGreater(ref p13, ref p27);
			SwapIfGreater(ref p12, ref p25);
			SwapIfGreater(ref p13, ref p26);
			SwapIfGreater(ref p13, ref p25);
			SwapIfGreater(ref p10, ref p21);
			SwapIfGreater(ref p11, ref p22);
			SwapIfGreater(ref p11, ref p21);
			SwapIfGreater(ref p12, ref p23);
			SwapIfGreater(ref p13, ref p24);
			SwapIfGreater(ref p13, ref p23);
			SwapIfGreater(ref p12, ref p21);
			SwapIfGreater(ref p13, ref p22);
			SwapIfGreater(ref p13, ref p21);
			SwapIfGreater(ref p7, ref p15);
			SwapIfGreater(ref p7, ref p14);
			SwapIfGreater(ref p8, ref p16);
			SwapIfGreater(ref p9, ref p17);
			SwapIfGreater(ref p9, ref p16);
			SwapIfGreater(ref p8, ref p14);
			SwapIfGreater(ref p9, ref p15);
			SwapIfGreater(ref p9, ref p14);
			SwapIfGreater(ref p10, ref p18);
			SwapIfGreater(ref p11, ref p19);
			SwapIfGreater(ref p11, ref p18);
			SwapIfGreater(ref p12, ref p20);
			SwapIfGreater(ref p13, ref p20);
			SwapIfGreater(ref p12, ref p18);
			SwapIfGreater(ref p13, ref p19);
			SwapIfGreater(ref p13, ref p18);
			SwapIfGreater(ref p10, ref p14);
			SwapIfGreater(ref p11, ref p15);
			SwapIfGreater(ref p11, ref p14);
			SwapIfGreater(ref p12, ref p16);
			SwapIfGreater(ref p13, ref p17);
			SwapIfGreater(ref p13, ref p16);
			SwapIfGreater(ref p12, ref p14);
			SwapIfGreater(ref p13, ref p15);
			SwapIfGreater(ref p13, ref p14);
		}

		/// <summary>
		/// Sorts a collection of 28 elements in descending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort28Descending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);
			ref var p10 = ref Unsafe.Add(ref p9, 10);
			ref var p11 = ref Unsafe.Add(ref p10, 11);
			ref var p12 = ref Unsafe.Add(ref p11, 12);
			ref var p13 = ref Unsafe.Add(ref p12, 13);
			ref var p14 = ref Unsafe.Add(ref p13, 14);
			ref var p15 = ref Unsafe.Add(ref p14, 15);
			ref var p16 = ref Unsafe.Add(ref p15, 16);
			ref var p17 = ref Unsafe.Add(ref p16, 17);
			ref var p18 = ref Unsafe.Add(ref p17, 18);
			ref var p19 = ref Unsafe.Add(ref p18, 19);
			ref var p20 = ref Unsafe.Add(ref p19, 20);
			ref var p21 = ref Unsafe.Add(ref p20, 21);
			ref var p22 = ref Unsafe.Add(ref p21, 22);
			ref var p23 = ref Unsafe.Add(ref p22, 23);
			ref var p24 = ref Unsafe.Add(ref p23, 24);
			ref var p25 = ref Unsafe.Add(ref p24, 25);
			ref var p26 = ref Unsafe.Add(ref p25, 26);
			ref var p27 = ref Unsafe.Add(ref p26, 27);

			SwapIfLesser(ref p1, ref p2);
			SwapIfLesser(ref p0, ref p2);
			SwapIfLesser(ref p0, ref p1);
			SwapIfLesser(ref p3, ref p4);
			SwapIfLesser(ref p5, ref p6);
			SwapIfLesser(ref p3, ref p5);
			SwapIfLesser(ref p4, ref p6);
			SwapIfLesser(ref p4, ref p5);
			SwapIfLesser(ref p0, ref p4);
			SwapIfLesser(ref p0, ref p3);
			SwapIfLesser(ref p1, ref p5);
			SwapIfLesser(ref p2, ref p6);
			SwapIfLesser(ref p2, ref p5);
			SwapIfLesser(ref p1, ref p3);
			SwapIfLesser(ref p2, ref p4);
			SwapIfLesser(ref p2, ref p3);
			SwapIfLesser(ref p8, ref p9);
			SwapIfLesser(ref p7, ref p9);
			SwapIfLesser(ref p7, ref p8);
			SwapIfLesser(ref p10, ref p11);
			SwapIfLesser(ref p12, ref p13);
			SwapIfLesser(ref p10, ref p12);
			SwapIfLesser(ref p11, ref p13);
			SwapIfLesser(ref p11, ref p12);
			SwapIfLesser(ref p7, ref p11);
			SwapIfLesser(ref p7, ref p10);
			SwapIfLesser(ref p8, ref p12);
			SwapIfLesser(ref p9, ref p13);
			SwapIfLesser(ref p9, ref p12);
			SwapIfLesser(ref p8, ref p10);
			SwapIfLesser(ref p9, ref p11);
			SwapIfLesser(ref p9, ref p10);
			SwapIfLesser(ref p0, ref p8);
			SwapIfLesser(ref p0, ref p7);
			SwapIfLesser(ref p1, ref p9);
			SwapIfLesser(ref p2, ref p10);
			SwapIfLesser(ref p2, ref p9);
			SwapIfLesser(ref p1, ref p7);
			SwapIfLesser(ref p2, ref p8);
			SwapIfLesser(ref p2, ref p7);
			SwapIfLesser(ref p3, ref p11);
			SwapIfLesser(ref p4, ref p12);
			SwapIfLesser(ref p4, ref p11);
			SwapIfLesser(ref p5, ref p13);
			SwapIfLesser(ref p6, ref p13);
			SwapIfLesser(ref p5, ref p11);
			SwapIfLesser(ref p6, ref p12);
			SwapIfLesser(ref p6, ref p11);
			SwapIfLesser(ref p3, ref p7);
			SwapIfLesser(ref p4, ref p8);
			SwapIfLesser(ref p4, ref p7);
			SwapIfLesser(ref p5, ref p9);
			SwapIfLesser(ref p6, ref p10);
			SwapIfLesser(ref p6, ref p9);
			SwapIfLesser(ref p5, ref p7);
			SwapIfLesser(ref p6, ref p8);
			SwapIfLesser(ref p6, ref p7);
			SwapIfLesser(ref p15, ref p16);
			SwapIfLesser(ref p14, ref p16);
			SwapIfLesser(ref p14, ref p15);
			SwapIfLesser(ref p17, ref p18);
			SwapIfLesser(ref p19, ref p20);
			SwapIfLesser(ref p17, ref p19);
			SwapIfLesser(ref p18, ref p20);
			SwapIfLesser(ref p18, ref p19);
			SwapIfLesser(ref p14, ref p18);
			SwapIfLesser(ref p14, ref p17);
			SwapIfLesser(ref p15, ref p19);
			SwapIfLesser(ref p16, ref p20);
			SwapIfLesser(ref p16, ref p19);
			SwapIfLesser(ref p15, ref p17);
			SwapIfLesser(ref p16, ref p18);
			SwapIfLesser(ref p16, ref p17);
			SwapIfLesser(ref p22, ref p23);
			SwapIfLesser(ref p21, ref p23);
			SwapIfLesser(ref p21, ref p22);
			SwapIfLesser(ref p24, ref p25);
			SwapIfLesser(ref p26, ref p27);
			SwapIfLesser(ref p24, ref p26);
			SwapIfLesser(ref p25, ref p27);
			SwapIfLesser(ref p25, ref p26);
			SwapIfLesser(ref p21, ref p25);
			SwapIfLesser(ref p21, ref p24);
			SwapIfLesser(ref p22, ref p26);
			SwapIfLesser(ref p23, ref p27);
			SwapIfLesser(ref p23, ref p26);
			SwapIfLesser(ref p22, ref p24);
			SwapIfLesser(ref p23, ref p25);
			SwapIfLesser(ref p23, ref p24);
			SwapIfLesser(ref p14, ref p22);
			SwapIfLesser(ref p14, ref p21);
			SwapIfLesser(ref p15, ref p23);
			SwapIfLesser(ref p16, ref p24);
			SwapIfLesser(ref p16, ref p23);
			SwapIfLesser(ref p15, ref p21);
			SwapIfLesser(ref p16, ref p22);
			SwapIfLesser(ref p16, ref p21);
			SwapIfLesser(ref p17, ref p25);
			SwapIfLesser(ref p18, ref p26);
			SwapIfLesser(ref p18, ref p25);
			SwapIfLesser(ref p19, ref p27);
			SwapIfLesser(ref p20, ref p27);
			SwapIfLesser(ref p19, ref p25);
			SwapIfLesser(ref p20, ref p26);
			SwapIfLesser(ref p20, ref p25);
			SwapIfLesser(ref p17, ref p21);
			SwapIfLesser(ref p18, ref p22);
			SwapIfLesser(ref p18, ref p21);
			SwapIfLesser(ref p19, ref p23);
			SwapIfLesser(ref p20, ref p24);
			SwapIfLesser(ref p20, ref p23);
			SwapIfLesser(ref p19, ref p21);
			SwapIfLesser(ref p20, ref p22);
			SwapIfLesser(ref p20, ref p21);
			SwapIfLesser(ref p0, ref p15);
			SwapIfLesser(ref p0, ref p14);
			SwapIfLesser(ref p1, ref p16);
			SwapIfLesser(ref p2, ref p17);
			SwapIfLesser(ref p2, ref p16);
			SwapIfLesser(ref p1, ref p14);
			SwapIfLesser(ref p2, ref p15);
			SwapIfLesser(ref p2, ref p14);
			SwapIfLesser(ref p3, ref p18);
			SwapIfLesser(ref p4, ref p19);
			SwapIfLesser(ref p4, ref p18);
			SwapIfLesser(ref p5, ref p20);
			SwapIfLesser(ref p6, ref p20);
			SwapIfLesser(ref p5, ref p18);
			SwapIfLesser(ref p6, ref p19);
			SwapIfLesser(ref p6, ref p18);
			SwapIfLesser(ref p3, ref p14);
			SwapIfLesser(ref p4, ref p15);
			SwapIfLesser(ref p4, ref p14);
			SwapIfLesser(ref p5, ref p16);
			SwapIfLesser(ref p6, ref p17);
			SwapIfLesser(ref p6, ref p16);
			SwapIfLesser(ref p5, ref p14);
			SwapIfLesser(ref p6, ref p15);
			SwapIfLesser(ref p6, ref p14);
			SwapIfLesser(ref p7, ref p22);
			SwapIfLesser(ref p7, ref p21);
			SwapIfLesser(ref p8, ref p23);
			SwapIfLesser(ref p9, ref p24);
			SwapIfLesser(ref p9, ref p23);
			SwapIfLesser(ref p8, ref p21);
			SwapIfLesser(ref p9, ref p22);
			SwapIfLesser(ref p9, ref p21);
			SwapIfLesser(ref p10, ref p25);
			SwapIfLesser(ref p11, ref p26);
			SwapIfLesser(ref p11, ref p25);
			SwapIfLesser(ref p12, ref p27);
			SwapIfLesser(ref p13, ref p27);
			SwapIfLesser(ref p12, ref p25);
			SwapIfLesser(ref p13, ref p26);
			SwapIfLesser(ref p13, ref p25);
			SwapIfLesser(ref p10, ref p21);
			SwapIfLesser(ref p11, ref p22);
			SwapIfLesser(ref p11, ref p21);
			SwapIfLesser(ref p12, ref p23);
			SwapIfLesser(ref p13, ref p24);
			SwapIfLesser(ref p13, ref p23);
			SwapIfLesser(ref p12, ref p21);
			SwapIfLesser(ref p13, ref p22);
			SwapIfLesser(ref p13, ref p21);
			SwapIfLesser(ref p7, ref p15);
			SwapIfLesser(ref p7, ref p14);
			SwapIfLesser(ref p8, ref p16);
			SwapIfLesser(ref p9, ref p17);
			SwapIfLesser(ref p9, ref p16);
			SwapIfLesser(ref p8, ref p14);
			SwapIfLesser(ref p9, ref p15);
			SwapIfLesser(ref p9, ref p14);
			SwapIfLesser(ref p10, ref p18);
			SwapIfLesser(ref p11, ref p19);
			SwapIfLesser(ref p11, ref p18);
			SwapIfLesser(ref p12, ref p20);
			SwapIfLesser(ref p13, ref p20);
			SwapIfLesser(ref p12, ref p18);
			SwapIfLesser(ref p13, ref p19);
			SwapIfLesser(ref p13, ref p18);
			SwapIfLesser(ref p10, ref p14);
			SwapIfLesser(ref p11, ref p15);
			SwapIfLesser(ref p11, ref p14);
			SwapIfLesser(ref p12, ref p16);
			SwapIfLesser(ref p13, ref p17);
			SwapIfLesser(ref p13, ref p16);
			SwapIfLesser(ref p12, ref p14);
			SwapIfLesser(ref p13, ref p15);
			SwapIfLesser(ref p13, ref p14);
		}

		/// <summary>
		/// Sorts a collection of 29 elements in ascending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort29Ascending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);
			ref var p10 = ref Unsafe.Add(ref p9, 10);
			ref var p11 = ref Unsafe.Add(ref p10, 11);
			ref var p12 = ref Unsafe.Add(ref p11, 12);
			ref var p13 = ref Unsafe.Add(ref p12, 13);
			ref var p14 = ref Unsafe.Add(ref p13, 14);
			ref var p15 = ref Unsafe.Add(ref p14, 15);
			ref var p16 = ref Unsafe.Add(ref p15, 16);
			ref var p17 = ref Unsafe.Add(ref p16, 17);
			ref var p18 = ref Unsafe.Add(ref p17, 18);
			ref var p19 = ref Unsafe.Add(ref p18, 19);
			ref var p20 = ref Unsafe.Add(ref p19, 20);
			ref var p21 = ref Unsafe.Add(ref p20, 21);
			ref var p22 = ref Unsafe.Add(ref p21, 22);
			ref var p23 = ref Unsafe.Add(ref p22, 23);
			ref var p24 = ref Unsafe.Add(ref p23, 24);
			ref var p25 = ref Unsafe.Add(ref p24, 25);
			ref var p26 = ref Unsafe.Add(ref p25, 26);
			ref var p27 = ref Unsafe.Add(ref p26, 27);
			ref var p28 = ref Unsafe.Add(ref p27, 28);

			SwapIfGreater(ref p1, ref p2);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p3, ref p4);
			SwapIfGreater(ref p5, ref p6);
			SwapIfGreater(ref p3, ref p5);
			SwapIfGreater(ref p4, ref p6);
			SwapIfGreater(ref p4, ref p5);
			SwapIfGreater(ref p0, ref p4);
			SwapIfGreater(ref p0, ref p3);
			SwapIfGreater(ref p1, ref p5);
			SwapIfGreater(ref p2, ref p6);
			SwapIfGreater(ref p2, ref p5);
			SwapIfGreater(ref p1, ref p3);
			SwapIfGreater(ref p2, ref p4);
			SwapIfGreater(ref p2, ref p3);
			SwapIfGreater(ref p8, ref p9);
			SwapIfGreater(ref p7, ref p9);
			SwapIfGreater(ref p7, ref p8);
			SwapIfGreater(ref p10, ref p11);
			SwapIfGreater(ref p12, ref p13);
			SwapIfGreater(ref p10, ref p12);
			SwapIfGreater(ref p11, ref p13);
			SwapIfGreater(ref p11, ref p12);
			SwapIfGreater(ref p7, ref p11);
			SwapIfGreater(ref p7, ref p10);
			SwapIfGreater(ref p8, ref p12);
			SwapIfGreater(ref p9, ref p13);
			SwapIfGreater(ref p9, ref p12);
			SwapIfGreater(ref p8, ref p10);
			SwapIfGreater(ref p9, ref p11);
			SwapIfGreater(ref p9, ref p10);
			SwapIfGreater(ref p0, ref p8);
			SwapIfGreater(ref p0, ref p7);
			SwapIfGreater(ref p1, ref p9);
			SwapIfGreater(ref p2, ref p10);
			SwapIfGreater(ref p2, ref p9);
			SwapIfGreater(ref p1, ref p7);
			SwapIfGreater(ref p2, ref p8);
			SwapIfGreater(ref p2, ref p7);
			SwapIfGreater(ref p3, ref p11);
			SwapIfGreater(ref p4, ref p12);
			SwapIfGreater(ref p4, ref p11);
			SwapIfGreater(ref p5, ref p13);
			SwapIfGreater(ref p6, ref p13);
			SwapIfGreater(ref p5, ref p11);
			SwapIfGreater(ref p6, ref p12);
			SwapIfGreater(ref p6, ref p11);
			SwapIfGreater(ref p3, ref p7);
			SwapIfGreater(ref p4, ref p8);
			SwapIfGreater(ref p4, ref p7);
			SwapIfGreater(ref p5, ref p9);
			SwapIfGreater(ref p6, ref p10);
			SwapIfGreater(ref p6, ref p9);
			SwapIfGreater(ref p5, ref p7);
			SwapIfGreater(ref p6, ref p8);
			SwapIfGreater(ref p6, ref p7);
			SwapIfGreater(ref p15, ref p16);
			SwapIfGreater(ref p14, ref p16);
			SwapIfGreater(ref p14, ref p15);
			SwapIfGreater(ref p17, ref p18);
			SwapIfGreater(ref p19, ref p20);
			SwapIfGreater(ref p17, ref p19);
			SwapIfGreater(ref p18, ref p20);
			SwapIfGreater(ref p18, ref p19);
			SwapIfGreater(ref p14, ref p18);
			SwapIfGreater(ref p14, ref p17);
			SwapIfGreater(ref p15, ref p19);
			SwapIfGreater(ref p16, ref p20);
			SwapIfGreater(ref p16, ref p19);
			SwapIfGreater(ref p15, ref p17);
			SwapIfGreater(ref p16, ref p18);
			SwapIfGreater(ref p16, ref p17);
			SwapIfGreater(ref p21, ref p22);
			SwapIfGreater(ref p23, ref p24);
			SwapIfGreater(ref p21, ref p23);
			SwapIfGreater(ref p22, ref p24);
			SwapIfGreater(ref p22, ref p23);
			SwapIfGreater(ref p25, ref p26);
			SwapIfGreater(ref p27, ref p28);
			SwapIfGreater(ref p25, ref p27);
			SwapIfGreater(ref p26, ref p28);
			SwapIfGreater(ref p26, ref p27);
			SwapIfGreater(ref p21, ref p25);
			SwapIfGreater(ref p22, ref p26);
			SwapIfGreater(ref p22, ref p25);
			SwapIfGreater(ref p23, ref p27);
			SwapIfGreater(ref p24, ref p28);
			SwapIfGreater(ref p24, ref p27);
			SwapIfGreater(ref p23, ref p25);
			SwapIfGreater(ref p24, ref p26);
			SwapIfGreater(ref p24, ref p25);
			SwapIfGreater(ref p14, ref p22);
			SwapIfGreater(ref p14, ref p21);
			SwapIfGreater(ref p15, ref p23);
			SwapIfGreater(ref p16, ref p24);
			SwapIfGreater(ref p16, ref p23);
			SwapIfGreater(ref p15, ref p21);
			SwapIfGreater(ref p16, ref p22);
			SwapIfGreater(ref p16, ref p21);
			SwapIfGreater(ref p17, ref p25);
			SwapIfGreater(ref p18, ref p26);
			SwapIfGreater(ref p18, ref p25);
			SwapIfGreater(ref p19, ref p27);
			SwapIfGreater(ref p20, ref p28);
			SwapIfGreater(ref p20, ref p27);
			SwapIfGreater(ref p19, ref p25);
			SwapIfGreater(ref p20, ref p26);
			SwapIfGreater(ref p20, ref p25);
			SwapIfGreater(ref p17, ref p21);
			SwapIfGreater(ref p18, ref p22);
			SwapIfGreater(ref p18, ref p21);
			SwapIfGreater(ref p19, ref p23);
			SwapIfGreater(ref p20, ref p24);
			SwapIfGreater(ref p20, ref p23);
			SwapIfGreater(ref p19, ref p21);
			SwapIfGreater(ref p20, ref p22);
			SwapIfGreater(ref p20, ref p21);
			SwapIfGreater(ref p0, ref p15);
			SwapIfGreater(ref p0, ref p14);
			SwapIfGreater(ref p1, ref p16);
			SwapIfGreater(ref p2, ref p17);
			SwapIfGreater(ref p2, ref p16);
			SwapIfGreater(ref p1, ref p14);
			SwapIfGreater(ref p2, ref p15);
			SwapIfGreater(ref p2, ref p14);
			SwapIfGreater(ref p3, ref p18);
			SwapIfGreater(ref p4, ref p19);
			SwapIfGreater(ref p4, ref p18);
			SwapIfGreater(ref p5, ref p20);
			SwapIfGreater(ref p6, ref p21);
			SwapIfGreater(ref p6, ref p20);
			SwapIfGreater(ref p5, ref p18);
			SwapIfGreater(ref p6, ref p19);
			SwapIfGreater(ref p6, ref p18);
			SwapIfGreater(ref p3, ref p14);
			SwapIfGreater(ref p4, ref p15);
			SwapIfGreater(ref p4, ref p14);
			SwapIfGreater(ref p5, ref p16);
			SwapIfGreater(ref p6, ref p17);
			SwapIfGreater(ref p6, ref p16);
			SwapIfGreater(ref p5, ref p14);
			SwapIfGreater(ref p6, ref p15);
			SwapIfGreater(ref p6, ref p14);
			SwapIfGreater(ref p7, ref p23);
			SwapIfGreater(ref p7, ref p22);
			SwapIfGreater(ref p8, ref p24);
			SwapIfGreater(ref p9, ref p25);
			SwapIfGreater(ref p9, ref p24);
			SwapIfGreater(ref p8, ref p22);
			SwapIfGreater(ref p9, ref p23);
			SwapIfGreater(ref p9, ref p22);
			SwapIfGreater(ref p10, ref p26);
			SwapIfGreater(ref p11, ref p27);
			SwapIfGreater(ref p11, ref p26);
			SwapIfGreater(ref p12, ref p28);
			SwapIfGreater(ref p13, ref p28);
			SwapIfGreater(ref p12, ref p26);
			SwapIfGreater(ref p13, ref p27);
			SwapIfGreater(ref p13, ref p26);
			SwapIfGreater(ref p10, ref p22);
			SwapIfGreater(ref p11, ref p23);
			SwapIfGreater(ref p11, ref p22);
			SwapIfGreater(ref p12, ref p24);
			SwapIfGreater(ref p13, ref p25);
			SwapIfGreater(ref p13, ref p24);
			SwapIfGreater(ref p12, ref p22);
			SwapIfGreater(ref p13, ref p23);
			SwapIfGreater(ref p13, ref p22);
			SwapIfGreater(ref p7, ref p15);
			SwapIfGreater(ref p7, ref p14);
			SwapIfGreater(ref p8, ref p16);
			SwapIfGreater(ref p9, ref p17);
			SwapIfGreater(ref p9, ref p16);
			SwapIfGreater(ref p8, ref p14);
			SwapIfGreater(ref p9, ref p15);
			SwapIfGreater(ref p9, ref p14);
			SwapIfGreater(ref p10, ref p18);
			SwapIfGreater(ref p11, ref p19);
			SwapIfGreater(ref p11, ref p18);
			SwapIfGreater(ref p12, ref p20);
			SwapIfGreater(ref p13, ref p21);
			SwapIfGreater(ref p13, ref p20);
			SwapIfGreater(ref p12, ref p18);
			SwapIfGreater(ref p13, ref p19);
			SwapIfGreater(ref p13, ref p18);
			SwapIfGreater(ref p10, ref p14);
			SwapIfGreater(ref p11, ref p15);
			SwapIfGreater(ref p11, ref p14);
			SwapIfGreater(ref p12, ref p16);
			SwapIfGreater(ref p13, ref p17);
			SwapIfGreater(ref p13, ref p16);
			SwapIfGreater(ref p12, ref p14);
			SwapIfGreater(ref p13, ref p15);
			SwapIfGreater(ref p13, ref p14);
		}

		/// <summary>
		/// Sorts a collection of 29 elements in descending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort29Descending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);
			ref var p10 = ref Unsafe.Add(ref p9, 10);
			ref var p11 = ref Unsafe.Add(ref p10, 11);
			ref var p12 = ref Unsafe.Add(ref p11, 12);
			ref var p13 = ref Unsafe.Add(ref p12, 13);
			ref var p14 = ref Unsafe.Add(ref p13, 14);
			ref var p15 = ref Unsafe.Add(ref p14, 15);
			ref var p16 = ref Unsafe.Add(ref p15, 16);
			ref var p17 = ref Unsafe.Add(ref p16, 17);
			ref var p18 = ref Unsafe.Add(ref p17, 18);
			ref var p19 = ref Unsafe.Add(ref p18, 19);
			ref var p20 = ref Unsafe.Add(ref p19, 20);
			ref var p21 = ref Unsafe.Add(ref p20, 21);
			ref var p22 = ref Unsafe.Add(ref p21, 22);
			ref var p23 = ref Unsafe.Add(ref p22, 23);
			ref var p24 = ref Unsafe.Add(ref p23, 24);
			ref var p25 = ref Unsafe.Add(ref p24, 25);
			ref var p26 = ref Unsafe.Add(ref p25, 26);
			ref var p27 = ref Unsafe.Add(ref p26, 27);
			ref var p28 = ref Unsafe.Add(ref p27, 28);

			SwapIfLesser(ref p1, ref p2);
			SwapIfLesser(ref p0, ref p2);
			SwapIfLesser(ref p0, ref p1);
			SwapIfLesser(ref p3, ref p4);
			SwapIfLesser(ref p5, ref p6);
			SwapIfLesser(ref p3, ref p5);
			SwapIfLesser(ref p4, ref p6);
			SwapIfLesser(ref p4, ref p5);
			SwapIfLesser(ref p0, ref p4);
			SwapIfLesser(ref p0, ref p3);
			SwapIfLesser(ref p1, ref p5);
			SwapIfLesser(ref p2, ref p6);
			SwapIfLesser(ref p2, ref p5);
			SwapIfLesser(ref p1, ref p3);
			SwapIfLesser(ref p2, ref p4);
			SwapIfLesser(ref p2, ref p3);
			SwapIfLesser(ref p8, ref p9);
			SwapIfLesser(ref p7, ref p9);
			SwapIfLesser(ref p7, ref p8);
			SwapIfLesser(ref p10, ref p11);
			SwapIfLesser(ref p12, ref p13);
			SwapIfLesser(ref p10, ref p12);
			SwapIfLesser(ref p11, ref p13);
			SwapIfLesser(ref p11, ref p12);
			SwapIfLesser(ref p7, ref p11);
			SwapIfLesser(ref p7, ref p10);
			SwapIfLesser(ref p8, ref p12);
			SwapIfLesser(ref p9, ref p13);
			SwapIfLesser(ref p9, ref p12);
			SwapIfLesser(ref p8, ref p10);
			SwapIfLesser(ref p9, ref p11);
			SwapIfLesser(ref p9, ref p10);
			SwapIfLesser(ref p0, ref p8);
			SwapIfLesser(ref p0, ref p7);
			SwapIfLesser(ref p1, ref p9);
			SwapIfLesser(ref p2, ref p10);
			SwapIfLesser(ref p2, ref p9);
			SwapIfLesser(ref p1, ref p7);
			SwapIfLesser(ref p2, ref p8);
			SwapIfLesser(ref p2, ref p7);
			SwapIfLesser(ref p3, ref p11);
			SwapIfLesser(ref p4, ref p12);
			SwapIfLesser(ref p4, ref p11);
			SwapIfLesser(ref p5, ref p13);
			SwapIfLesser(ref p6, ref p13);
			SwapIfLesser(ref p5, ref p11);
			SwapIfLesser(ref p6, ref p12);
			SwapIfLesser(ref p6, ref p11);
			SwapIfLesser(ref p3, ref p7);
			SwapIfLesser(ref p4, ref p8);
			SwapIfLesser(ref p4, ref p7);
			SwapIfLesser(ref p5, ref p9);
			SwapIfLesser(ref p6, ref p10);
			SwapIfLesser(ref p6, ref p9);
			SwapIfLesser(ref p5, ref p7);
			SwapIfLesser(ref p6, ref p8);
			SwapIfLesser(ref p6, ref p7);
			SwapIfLesser(ref p15, ref p16);
			SwapIfLesser(ref p14, ref p16);
			SwapIfLesser(ref p14, ref p15);
			SwapIfLesser(ref p17, ref p18);
			SwapIfLesser(ref p19, ref p20);
			SwapIfLesser(ref p17, ref p19);
			SwapIfLesser(ref p18, ref p20);
			SwapIfLesser(ref p18, ref p19);
			SwapIfLesser(ref p14, ref p18);
			SwapIfLesser(ref p14, ref p17);
			SwapIfLesser(ref p15, ref p19);
			SwapIfLesser(ref p16, ref p20);
			SwapIfLesser(ref p16, ref p19);
			SwapIfLesser(ref p15, ref p17);
			SwapIfLesser(ref p16, ref p18);
			SwapIfLesser(ref p16, ref p17);
			SwapIfLesser(ref p21, ref p22);
			SwapIfLesser(ref p23, ref p24);
			SwapIfLesser(ref p21, ref p23);
			SwapIfLesser(ref p22, ref p24);
			SwapIfLesser(ref p22, ref p23);
			SwapIfLesser(ref p25, ref p26);
			SwapIfLesser(ref p27, ref p28);
			SwapIfLesser(ref p25, ref p27);
			SwapIfLesser(ref p26, ref p28);
			SwapIfLesser(ref p26, ref p27);
			SwapIfLesser(ref p21, ref p25);
			SwapIfLesser(ref p22, ref p26);
			SwapIfLesser(ref p22, ref p25);
			SwapIfLesser(ref p23, ref p27);
			SwapIfLesser(ref p24, ref p28);
			SwapIfLesser(ref p24, ref p27);
			SwapIfLesser(ref p23, ref p25);
			SwapIfLesser(ref p24, ref p26);
			SwapIfLesser(ref p24, ref p25);
			SwapIfLesser(ref p14, ref p22);
			SwapIfLesser(ref p14, ref p21);
			SwapIfLesser(ref p15, ref p23);
			SwapIfLesser(ref p16, ref p24);
			SwapIfLesser(ref p16, ref p23);
			SwapIfLesser(ref p15, ref p21);
			SwapIfLesser(ref p16, ref p22);
			SwapIfLesser(ref p16, ref p21);
			SwapIfLesser(ref p17, ref p25);
			SwapIfLesser(ref p18, ref p26);
			SwapIfLesser(ref p18, ref p25);
			SwapIfLesser(ref p19, ref p27);
			SwapIfLesser(ref p20, ref p28);
			SwapIfLesser(ref p20, ref p27);
			SwapIfLesser(ref p19, ref p25);
			SwapIfLesser(ref p20, ref p26);
			SwapIfLesser(ref p20, ref p25);
			SwapIfLesser(ref p17, ref p21);
			SwapIfLesser(ref p18, ref p22);
			SwapIfLesser(ref p18, ref p21);
			SwapIfLesser(ref p19, ref p23);
			SwapIfLesser(ref p20, ref p24);
			SwapIfLesser(ref p20, ref p23);
			SwapIfLesser(ref p19, ref p21);
			SwapIfLesser(ref p20, ref p22);
			SwapIfLesser(ref p20, ref p21);
			SwapIfLesser(ref p0, ref p15);
			SwapIfLesser(ref p0, ref p14);
			SwapIfLesser(ref p1, ref p16);
			SwapIfLesser(ref p2, ref p17);
			SwapIfLesser(ref p2, ref p16);
			SwapIfLesser(ref p1, ref p14);
			SwapIfLesser(ref p2, ref p15);
			SwapIfLesser(ref p2, ref p14);
			SwapIfLesser(ref p3, ref p18);
			SwapIfLesser(ref p4, ref p19);
			SwapIfLesser(ref p4, ref p18);
			SwapIfLesser(ref p5, ref p20);
			SwapIfLesser(ref p6, ref p21);
			SwapIfLesser(ref p6, ref p20);
			SwapIfLesser(ref p5, ref p18);
			SwapIfLesser(ref p6, ref p19);
			SwapIfLesser(ref p6, ref p18);
			SwapIfLesser(ref p3, ref p14);
			SwapIfLesser(ref p4, ref p15);
			SwapIfLesser(ref p4, ref p14);
			SwapIfLesser(ref p5, ref p16);
			SwapIfLesser(ref p6, ref p17);
			SwapIfLesser(ref p6, ref p16);
			SwapIfLesser(ref p5, ref p14);
			SwapIfLesser(ref p6, ref p15);
			SwapIfLesser(ref p6, ref p14);
			SwapIfLesser(ref p7, ref p23);
			SwapIfLesser(ref p7, ref p22);
			SwapIfLesser(ref p8, ref p24);
			SwapIfLesser(ref p9, ref p25);
			SwapIfLesser(ref p9, ref p24);
			SwapIfLesser(ref p8, ref p22);
			SwapIfLesser(ref p9, ref p23);
			SwapIfLesser(ref p9, ref p22);
			SwapIfLesser(ref p10, ref p26);
			SwapIfLesser(ref p11, ref p27);
			SwapIfLesser(ref p11, ref p26);
			SwapIfLesser(ref p12, ref p28);
			SwapIfLesser(ref p13, ref p28);
			SwapIfLesser(ref p12, ref p26);
			SwapIfLesser(ref p13, ref p27);
			SwapIfLesser(ref p13, ref p26);
			SwapIfLesser(ref p10, ref p22);
			SwapIfLesser(ref p11, ref p23);
			SwapIfLesser(ref p11, ref p22);
			SwapIfLesser(ref p12, ref p24);
			SwapIfLesser(ref p13, ref p25);
			SwapIfLesser(ref p13, ref p24);
			SwapIfLesser(ref p12, ref p22);
			SwapIfLesser(ref p13, ref p23);
			SwapIfLesser(ref p13, ref p22);
			SwapIfLesser(ref p7, ref p15);
			SwapIfLesser(ref p7, ref p14);
			SwapIfLesser(ref p8, ref p16);
			SwapIfLesser(ref p9, ref p17);
			SwapIfLesser(ref p9, ref p16);
			SwapIfLesser(ref p8, ref p14);
			SwapIfLesser(ref p9, ref p15);
			SwapIfLesser(ref p9, ref p14);
			SwapIfLesser(ref p10, ref p18);
			SwapIfLesser(ref p11, ref p19);
			SwapIfLesser(ref p11, ref p18);
			SwapIfLesser(ref p12, ref p20);
			SwapIfLesser(ref p13, ref p21);
			SwapIfLesser(ref p13, ref p20);
			SwapIfLesser(ref p12, ref p18);
			SwapIfLesser(ref p13, ref p19);
			SwapIfLesser(ref p13, ref p18);
			SwapIfLesser(ref p10, ref p14);
			SwapIfLesser(ref p11, ref p15);
			SwapIfLesser(ref p11, ref p14);
			SwapIfLesser(ref p12, ref p16);
			SwapIfLesser(ref p13, ref p17);
			SwapIfLesser(ref p13, ref p16);
			SwapIfLesser(ref p12, ref p14);
			SwapIfLesser(ref p13, ref p15);
			SwapIfLesser(ref p13, ref p14);
		}

		/// <summary>
		/// Sorts a collection of 30 elements in ascending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort30Ascending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);
			ref var p10 = ref Unsafe.Add(ref p9, 10);
			ref var p11 = ref Unsafe.Add(ref p10, 11);
			ref var p12 = ref Unsafe.Add(ref p11, 12);
			ref var p13 = ref Unsafe.Add(ref p12, 13);
			ref var p14 = ref Unsafe.Add(ref p13, 14);
			ref var p15 = ref Unsafe.Add(ref p14, 15);
			ref var p16 = ref Unsafe.Add(ref p15, 16);
			ref var p17 = ref Unsafe.Add(ref p16, 17);
			ref var p18 = ref Unsafe.Add(ref p17, 18);
			ref var p19 = ref Unsafe.Add(ref p18, 19);
			ref var p20 = ref Unsafe.Add(ref p19, 20);
			ref var p21 = ref Unsafe.Add(ref p20, 21);
			ref var p22 = ref Unsafe.Add(ref p21, 22);
			ref var p23 = ref Unsafe.Add(ref p22, 23);
			ref var p24 = ref Unsafe.Add(ref p23, 24);
			ref var p25 = ref Unsafe.Add(ref p24, 25);
			ref var p26 = ref Unsafe.Add(ref p25, 26);
			ref var p27 = ref Unsafe.Add(ref p26, 27);
			ref var p28 = ref Unsafe.Add(ref p27, 28);
			ref var p29 = ref Unsafe.Add(ref p28, 29);

			SwapIfGreater(ref p1, ref p2);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p3, ref p4);
			SwapIfGreater(ref p5, ref p6);
			SwapIfGreater(ref p3, ref p5);
			SwapIfGreater(ref p4, ref p6);
			SwapIfGreater(ref p4, ref p5);
			SwapIfGreater(ref p0, ref p4);
			SwapIfGreater(ref p0, ref p3);
			SwapIfGreater(ref p1, ref p5);
			SwapIfGreater(ref p2, ref p6);
			SwapIfGreater(ref p2, ref p5);
			SwapIfGreater(ref p1, ref p3);
			SwapIfGreater(ref p2, ref p4);
			SwapIfGreater(ref p2, ref p3);
			SwapIfGreater(ref p7, ref p8);
			SwapIfGreater(ref p9, ref p10);
			SwapIfGreater(ref p7, ref p9);
			SwapIfGreater(ref p8, ref p10);
			SwapIfGreater(ref p8, ref p9);
			SwapIfGreater(ref p11, ref p12);
			SwapIfGreater(ref p13, ref p14);
			SwapIfGreater(ref p11, ref p13);
			SwapIfGreater(ref p12, ref p14);
			SwapIfGreater(ref p12, ref p13);
			SwapIfGreater(ref p7, ref p11);
			SwapIfGreater(ref p8, ref p12);
			SwapIfGreater(ref p8, ref p11);
			SwapIfGreater(ref p9, ref p13);
			SwapIfGreater(ref p10, ref p14);
			SwapIfGreater(ref p10, ref p13);
			SwapIfGreater(ref p9, ref p11);
			SwapIfGreater(ref p10, ref p12);
			SwapIfGreater(ref p10, ref p11);
			SwapIfGreater(ref p0, ref p8);
			SwapIfGreater(ref p0, ref p7);
			SwapIfGreater(ref p1, ref p9);
			SwapIfGreater(ref p2, ref p10);
			SwapIfGreater(ref p2, ref p9);
			SwapIfGreater(ref p1, ref p7);
			SwapIfGreater(ref p2, ref p8);
			SwapIfGreater(ref p2, ref p7);
			SwapIfGreater(ref p3, ref p11);
			SwapIfGreater(ref p4, ref p12);
			SwapIfGreater(ref p4, ref p11);
			SwapIfGreater(ref p5, ref p13);
			SwapIfGreater(ref p6, ref p14);
			SwapIfGreater(ref p6, ref p13);
			SwapIfGreater(ref p5, ref p11);
			SwapIfGreater(ref p6, ref p12);
			SwapIfGreater(ref p6, ref p11);
			SwapIfGreater(ref p3, ref p7);
			SwapIfGreater(ref p4, ref p8);
			SwapIfGreater(ref p4, ref p7);
			SwapIfGreater(ref p5, ref p9);
			SwapIfGreater(ref p6, ref p10);
			SwapIfGreater(ref p6, ref p9);
			SwapIfGreater(ref p5, ref p7);
			SwapIfGreater(ref p6, ref p8);
			SwapIfGreater(ref p6, ref p7);
			SwapIfGreater(ref p16, ref p17);
			SwapIfGreater(ref p15, ref p17);
			SwapIfGreater(ref p15, ref p16);
			SwapIfGreater(ref p18, ref p19);
			SwapIfGreater(ref p20, ref p21);
			SwapIfGreater(ref p18, ref p20);
			SwapIfGreater(ref p19, ref p21);
			SwapIfGreater(ref p19, ref p20);
			SwapIfGreater(ref p15, ref p19);
			SwapIfGreater(ref p15, ref p18);
			SwapIfGreater(ref p16, ref p20);
			SwapIfGreater(ref p17, ref p21);
			SwapIfGreater(ref p17, ref p20);
			SwapIfGreater(ref p16, ref p18);
			SwapIfGreater(ref p17, ref p19);
			SwapIfGreater(ref p17, ref p18);
			SwapIfGreater(ref p22, ref p23);
			SwapIfGreater(ref p24, ref p25);
			SwapIfGreater(ref p22, ref p24);
			SwapIfGreater(ref p23, ref p25);
			SwapIfGreater(ref p23, ref p24);
			SwapIfGreater(ref p26, ref p27);
			SwapIfGreater(ref p28, ref p29);
			SwapIfGreater(ref p26, ref p28);
			SwapIfGreater(ref p27, ref p29);
			SwapIfGreater(ref p27, ref p28);
			SwapIfGreater(ref p22, ref p26);
			SwapIfGreater(ref p23, ref p27);
			SwapIfGreater(ref p23, ref p26);
			SwapIfGreater(ref p24, ref p28);
			SwapIfGreater(ref p25, ref p29);
			SwapIfGreater(ref p25, ref p28);
			SwapIfGreater(ref p24, ref p26);
			SwapIfGreater(ref p25, ref p27);
			SwapIfGreater(ref p25, ref p26);
			SwapIfGreater(ref p15, ref p23);
			SwapIfGreater(ref p15, ref p22);
			SwapIfGreater(ref p16, ref p24);
			SwapIfGreater(ref p17, ref p25);
			SwapIfGreater(ref p17, ref p24);
			SwapIfGreater(ref p16, ref p22);
			SwapIfGreater(ref p17, ref p23);
			SwapIfGreater(ref p17, ref p22);
			SwapIfGreater(ref p18, ref p26);
			SwapIfGreater(ref p19, ref p27);
			SwapIfGreater(ref p19, ref p26);
			SwapIfGreater(ref p20, ref p28);
			SwapIfGreater(ref p21, ref p29);
			SwapIfGreater(ref p21, ref p28);
			SwapIfGreater(ref p20, ref p26);
			SwapIfGreater(ref p21, ref p27);
			SwapIfGreater(ref p21, ref p26);
			SwapIfGreater(ref p18, ref p22);
			SwapIfGreater(ref p19, ref p23);
			SwapIfGreater(ref p19, ref p22);
			SwapIfGreater(ref p20, ref p24);
			SwapIfGreater(ref p21, ref p25);
			SwapIfGreater(ref p21, ref p24);
			SwapIfGreater(ref p20, ref p22);
			SwapIfGreater(ref p21, ref p23);
			SwapIfGreater(ref p21, ref p22);
			SwapIfGreater(ref p0, ref p16);
			SwapIfGreater(ref p0, ref p15);
			SwapIfGreater(ref p1, ref p17);
			SwapIfGreater(ref p2, ref p18);
			SwapIfGreater(ref p2, ref p17);
			SwapIfGreater(ref p1, ref p15);
			SwapIfGreater(ref p2, ref p16);
			SwapIfGreater(ref p2, ref p15);
			SwapIfGreater(ref p3, ref p19);
			SwapIfGreater(ref p4, ref p20);
			SwapIfGreater(ref p4, ref p19);
			SwapIfGreater(ref p5, ref p21);
			SwapIfGreater(ref p6, ref p22);
			SwapIfGreater(ref p6, ref p21);
			SwapIfGreater(ref p5, ref p19);
			SwapIfGreater(ref p6, ref p20);
			SwapIfGreater(ref p6, ref p19);
			SwapIfGreater(ref p3, ref p15);
			SwapIfGreater(ref p4, ref p16);
			SwapIfGreater(ref p4, ref p15);
			SwapIfGreater(ref p5, ref p17);
			SwapIfGreater(ref p6, ref p18);
			SwapIfGreater(ref p6, ref p17);
			SwapIfGreater(ref p5, ref p15);
			SwapIfGreater(ref p6, ref p16);
			SwapIfGreater(ref p6, ref p15);
			SwapIfGreater(ref p7, ref p23);
			SwapIfGreater(ref p8, ref p24);
			SwapIfGreater(ref p8, ref p23);
			SwapIfGreater(ref p9, ref p25);
			SwapIfGreater(ref p10, ref p26);
			SwapIfGreater(ref p10, ref p25);
			SwapIfGreater(ref p9, ref p23);
			SwapIfGreater(ref p10, ref p24);
			SwapIfGreater(ref p10, ref p23);
			SwapIfGreater(ref p11, ref p27);
			SwapIfGreater(ref p12, ref p28);
			SwapIfGreater(ref p12, ref p27);
			SwapIfGreater(ref p13, ref p29);
			SwapIfGreater(ref p14, ref p29);
			SwapIfGreater(ref p13, ref p27);
			SwapIfGreater(ref p14, ref p28);
			SwapIfGreater(ref p14, ref p27);
			SwapIfGreater(ref p11, ref p23);
			SwapIfGreater(ref p12, ref p24);
			SwapIfGreater(ref p12, ref p23);
			SwapIfGreater(ref p13, ref p25);
			SwapIfGreater(ref p14, ref p26);
			SwapIfGreater(ref p14, ref p25);
			SwapIfGreater(ref p13, ref p23);
			SwapIfGreater(ref p14, ref p24);
			SwapIfGreater(ref p14, ref p23);
			SwapIfGreater(ref p7, ref p15);
			SwapIfGreater(ref p8, ref p16);
			SwapIfGreater(ref p8, ref p15);
			SwapIfGreater(ref p9, ref p17);
			SwapIfGreater(ref p10, ref p18);
			SwapIfGreater(ref p10, ref p17);
			SwapIfGreater(ref p9, ref p15);
			SwapIfGreater(ref p10, ref p16);
			SwapIfGreater(ref p10, ref p15);
			SwapIfGreater(ref p11, ref p19);
			SwapIfGreater(ref p12, ref p20);
			SwapIfGreater(ref p12, ref p19);
			SwapIfGreater(ref p13, ref p21);
			SwapIfGreater(ref p14, ref p22);
			SwapIfGreater(ref p14, ref p21);
			SwapIfGreater(ref p13, ref p19);
			SwapIfGreater(ref p14, ref p20);
			SwapIfGreater(ref p14, ref p19);
			SwapIfGreater(ref p11, ref p15);
			SwapIfGreater(ref p12, ref p16);
			SwapIfGreater(ref p12, ref p15);
			SwapIfGreater(ref p13, ref p17);
			SwapIfGreater(ref p14, ref p18);
			SwapIfGreater(ref p14, ref p17);
			SwapIfGreater(ref p13, ref p15);
			SwapIfGreater(ref p14, ref p16);
			SwapIfGreater(ref p14, ref p15);
		}

		/// <summary>
		/// Sorts a collection of 30 elements in descending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort30Descending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);
			ref var p10 = ref Unsafe.Add(ref p9, 10);
			ref var p11 = ref Unsafe.Add(ref p10, 11);
			ref var p12 = ref Unsafe.Add(ref p11, 12);
			ref var p13 = ref Unsafe.Add(ref p12, 13);
			ref var p14 = ref Unsafe.Add(ref p13, 14);
			ref var p15 = ref Unsafe.Add(ref p14, 15);
			ref var p16 = ref Unsafe.Add(ref p15, 16);
			ref var p17 = ref Unsafe.Add(ref p16, 17);
			ref var p18 = ref Unsafe.Add(ref p17, 18);
			ref var p19 = ref Unsafe.Add(ref p18, 19);
			ref var p20 = ref Unsafe.Add(ref p19, 20);
			ref var p21 = ref Unsafe.Add(ref p20, 21);
			ref var p22 = ref Unsafe.Add(ref p21, 22);
			ref var p23 = ref Unsafe.Add(ref p22, 23);
			ref var p24 = ref Unsafe.Add(ref p23, 24);
			ref var p25 = ref Unsafe.Add(ref p24, 25);
			ref var p26 = ref Unsafe.Add(ref p25, 26);
			ref var p27 = ref Unsafe.Add(ref p26, 27);
			ref var p28 = ref Unsafe.Add(ref p27, 28);
			ref var p29 = ref Unsafe.Add(ref p28, 29);

			SwapIfLesser(ref p1, ref p2);
			SwapIfLesser(ref p0, ref p2);
			SwapIfLesser(ref p0, ref p1);
			SwapIfLesser(ref p3, ref p4);
			SwapIfLesser(ref p5, ref p6);
			SwapIfLesser(ref p3, ref p5);
			SwapIfLesser(ref p4, ref p6);
			SwapIfLesser(ref p4, ref p5);
			SwapIfLesser(ref p0, ref p4);
			SwapIfLesser(ref p0, ref p3);
			SwapIfLesser(ref p1, ref p5);
			SwapIfLesser(ref p2, ref p6);
			SwapIfLesser(ref p2, ref p5);
			SwapIfLesser(ref p1, ref p3);
			SwapIfLesser(ref p2, ref p4);
			SwapIfLesser(ref p2, ref p3);
			SwapIfLesser(ref p7, ref p8);
			SwapIfLesser(ref p9, ref p10);
			SwapIfLesser(ref p7, ref p9);
			SwapIfLesser(ref p8, ref p10);
			SwapIfLesser(ref p8, ref p9);
			SwapIfLesser(ref p11, ref p12);
			SwapIfLesser(ref p13, ref p14);
			SwapIfLesser(ref p11, ref p13);
			SwapIfLesser(ref p12, ref p14);
			SwapIfLesser(ref p12, ref p13);
			SwapIfLesser(ref p7, ref p11);
			SwapIfLesser(ref p8, ref p12);
			SwapIfLesser(ref p8, ref p11);
			SwapIfLesser(ref p9, ref p13);
			SwapIfLesser(ref p10, ref p14);
			SwapIfLesser(ref p10, ref p13);
			SwapIfLesser(ref p9, ref p11);
			SwapIfLesser(ref p10, ref p12);
			SwapIfLesser(ref p10, ref p11);
			SwapIfLesser(ref p0, ref p8);
			SwapIfLesser(ref p0, ref p7);
			SwapIfLesser(ref p1, ref p9);
			SwapIfLesser(ref p2, ref p10);
			SwapIfLesser(ref p2, ref p9);
			SwapIfLesser(ref p1, ref p7);
			SwapIfLesser(ref p2, ref p8);
			SwapIfLesser(ref p2, ref p7);
			SwapIfLesser(ref p3, ref p11);
			SwapIfLesser(ref p4, ref p12);
			SwapIfLesser(ref p4, ref p11);
			SwapIfLesser(ref p5, ref p13);
			SwapIfLesser(ref p6, ref p14);
			SwapIfLesser(ref p6, ref p13);
			SwapIfLesser(ref p5, ref p11);
			SwapIfLesser(ref p6, ref p12);
			SwapIfLesser(ref p6, ref p11);
			SwapIfLesser(ref p3, ref p7);
			SwapIfLesser(ref p4, ref p8);
			SwapIfLesser(ref p4, ref p7);
			SwapIfLesser(ref p5, ref p9);
			SwapIfLesser(ref p6, ref p10);
			SwapIfLesser(ref p6, ref p9);
			SwapIfLesser(ref p5, ref p7);
			SwapIfLesser(ref p6, ref p8);
			SwapIfLesser(ref p6, ref p7);
			SwapIfLesser(ref p16, ref p17);
			SwapIfLesser(ref p15, ref p17);
			SwapIfLesser(ref p15, ref p16);
			SwapIfLesser(ref p18, ref p19);
			SwapIfLesser(ref p20, ref p21);
			SwapIfLesser(ref p18, ref p20);
			SwapIfLesser(ref p19, ref p21);
			SwapIfLesser(ref p19, ref p20);
			SwapIfLesser(ref p15, ref p19);
			SwapIfLesser(ref p15, ref p18);
			SwapIfLesser(ref p16, ref p20);
			SwapIfLesser(ref p17, ref p21);
			SwapIfLesser(ref p17, ref p20);
			SwapIfLesser(ref p16, ref p18);
			SwapIfLesser(ref p17, ref p19);
			SwapIfLesser(ref p17, ref p18);
			SwapIfLesser(ref p22, ref p23);
			SwapIfLesser(ref p24, ref p25);
			SwapIfLesser(ref p22, ref p24);
			SwapIfLesser(ref p23, ref p25);
			SwapIfLesser(ref p23, ref p24);
			SwapIfLesser(ref p26, ref p27);
			SwapIfLesser(ref p28, ref p29);
			SwapIfLesser(ref p26, ref p28);
			SwapIfLesser(ref p27, ref p29);
			SwapIfLesser(ref p27, ref p28);
			SwapIfLesser(ref p22, ref p26);
			SwapIfLesser(ref p23, ref p27);
			SwapIfLesser(ref p23, ref p26);
			SwapIfLesser(ref p24, ref p28);
			SwapIfLesser(ref p25, ref p29);
			SwapIfLesser(ref p25, ref p28);
			SwapIfLesser(ref p24, ref p26);
			SwapIfLesser(ref p25, ref p27);
			SwapIfLesser(ref p25, ref p26);
			SwapIfLesser(ref p15, ref p23);
			SwapIfLesser(ref p15, ref p22);
			SwapIfLesser(ref p16, ref p24);
			SwapIfLesser(ref p17, ref p25);
			SwapIfLesser(ref p17, ref p24);
			SwapIfLesser(ref p16, ref p22);
			SwapIfLesser(ref p17, ref p23);
			SwapIfLesser(ref p17, ref p22);
			SwapIfLesser(ref p18, ref p26);
			SwapIfLesser(ref p19, ref p27);
			SwapIfLesser(ref p19, ref p26);
			SwapIfLesser(ref p20, ref p28);
			SwapIfLesser(ref p21, ref p29);
			SwapIfLesser(ref p21, ref p28);
			SwapIfLesser(ref p20, ref p26);
			SwapIfLesser(ref p21, ref p27);
			SwapIfLesser(ref p21, ref p26);
			SwapIfLesser(ref p18, ref p22);
			SwapIfLesser(ref p19, ref p23);
			SwapIfLesser(ref p19, ref p22);
			SwapIfLesser(ref p20, ref p24);
			SwapIfLesser(ref p21, ref p25);
			SwapIfLesser(ref p21, ref p24);
			SwapIfLesser(ref p20, ref p22);
			SwapIfLesser(ref p21, ref p23);
			SwapIfLesser(ref p21, ref p22);
			SwapIfLesser(ref p0, ref p16);
			SwapIfLesser(ref p0, ref p15);
			SwapIfLesser(ref p1, ref p17);
			SwapIfLesser(ref p2, ref p18);
			SwapIfLesser(ref p2, ref p17);
			SwapIfLesser(ref p1, ref p15);
			SwapIfLesser(ref p2, ref p16);
			SwapIfLesser(ref p2, ref p15);
			SwapIfLesser(ref p3, ref p19);
			SwapIfLesser(ref p4, ref p20);
			SwapIfLesser(ref p4, ref p19);
			SwapIfLesser(ref p5, ref p21);
			SwapIfLesser(ref p6, ref p22);
			SwapIfLesser(ref p6, ref p21);
			SwapIfLesser(ref p5, ref p19);
			SwapIfLesser(ref p6, ref p20);
			SwapIfLesser(ref p6, ref p19);
			SwapIfLesser(ref p3, ref p15);
			SwapIfLesser(ref p4, ref p16);
			SwapIfLesser(ref p4, ref p15);
			SwapIfLesser(ref p5, ref p17);
			SwapIfLesser(ref p6, ref p18);
			SwapIfLesser(ref p6, ref p17);
			SwapIfLesser(ref p5, ref p15);
			SwapIfLesser(ref p6, ref p16);
			SwapIfLesser(ref p6, ref p15);
			SwapIfLesser(ref p7, ref p23);
			SwapIfLesser(ref p8, ref p24);
			SwapIfLesser(ref p8, ref p23);
			SwapIfLesser(ref p9, ref p25);
			SwapIfLesser(ref p10, ref p26);
			SwapIfLesser(ref p10, ref p25);
			SwapIfLesser(ref p9, ref p23);
			SwapIfLesser(ref p10, ref p24);
			SwapIfLesser(ref p10, ref p23);
			SwapIfLesser(ref p11, ref p27);
			SwapIfLesser(ref p12, ref p28);
			SwapIfLesser(ref p12, ref p27);
			SwapIfLesser(ref p13, ref p29);
			SwapIfLesser(ref p14, ref p29);
			SwapIfLesser(ref p13, ref p27);
			SwapIfLesser(ref p14, ref p28);
			SwapIfLesser(ref p14, ref p27);
			SwapIfLesser(ref p11, ref p23);
			SwapIfLesser(ref p12, ref p24);
			SwapIfLesser(ref p12, ref p23);
			SwapIfLesser(ref p13, ref p25);
			SwapIfLesser(ref p14, ref p26);
			SwapIfLesser(ref p14, ref p25);
			SwapIfLesser(ref p13, ref p23);
			SwapIfLesser(ref p14, ref p24);
			SwapIfLesser(ref p14, ref p23);
			SwapIfLesser(ref p7, ref p15);
			SwapIfLesser(ref p8, ref p16);
			SwapIfLesser(ref p8, ref p15);
			SwapIfLesser(ref p9, ref p17);
			SwapIfLesser(ref p10, ref p18);
			SwapIfLesser(ref p10, ref p17);
			SwapIfLesser(ref p9, ref p15);
			SwapIfLesser(ref p10, ref p16);
			SwapIfLesser(ref p10, ref p15);
			SwapIfLesser(ref p11, ref p19);
			SwapIfLesser(ref p12, ref p20);
			SwapIfLesser(ref p12, ref p19);
			SwapIfLesser(ref p13, ref p21);
			SwapIfLesser(ref p14, ref p22);
			SwapIfLesser(ref p14, ref p21);
			SwapIfLesser(ref p13, ref p19);
			SwapIfLesser(ref p14, ref p20);
			SwapIfLesser(ref p14, ref p19);
			SwapIfLesser(ref p11, ref p15);
			SwapIfLesser(ref p12, ref p16);
			SwapIfLesser(ref p12, ref p15);
			SwapIfLesser(ref p13, ref p17);
			SwapIfLesser(ref p14, ref p18);
			SwapIfLesser(ref p14, ref p17);
			SwapIfLesser(ref p13, ref p15);
			SwapIfLesser(ref p14, ref p16);
			SwapIfLesser(ref p14, ref p15);
		}

		/// <summary>
		/// Sorts a collection of 31 elements in ascending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort31Ascending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);
			ref var p10 = ref Unsafe.Add(ref p9, 10);
			ref var p11 = ref Unsafe.Add(ref p10, 11);
			ref var p12 = ref Unsafe.Add(ref p11, 12);
			ref var p13 = ref Unsafe.Add(ref p12, 13);
			ref var p14 = ref Unsafe.Add(ref p13, 14);
			ref var p15 = ref Unsafe.Add(ref p14, 15);
			ref var p16 = ref Unsafe.Add(ref p15, 16);
			ref var p17 = ref Unsafe.Add(ref p16, 17);
			ref var p18 = ref Unsafe.Add(ref p17, 18);
			ref var p19 = ref Unsafe.Add(ref p18, 19);
			ref var p20 = ref Unsafe.Add(ref p19, 20);
			ref var p21 = ref Unsafe.Add(ref p20, 21);
			ref var p22 = ref Unsafe.Add(ref p21, 22);
			ref var p23 = ref Unsafe.Add(ref p22, 23);
			ref var p24 = ref Unsafe.Add(ref p23, 24);
			ref var p25 = ref Unsafe.Add(ref p24, 25);
			ref var p26 = ref Unsafe.Add(ref p25, 26);
			ref var p27 = ref Unsafe.Add(ref p26, 27);
			ref var p28 = ref Unsafe.Add(ref p27, 28);
			ref var p29 = ref Unsafe.Add(ref p28, 29);
			ref var p30 = ref Unsafe.Add(ref p29, 30);

			SwapIfGreater(ref p1, ref p2);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p3, ref p4);
			SwapIfGreater(ref p5, ref p6);
			SwapIfGreater(ref p3, ref p5);
			SwapIfGreater(ref p4, ref p6);
			SwapIfGreater(ref p4, ref p5);
			SwapIfGreater(ref p0, ref p4);
			SwapIfGreater(ref p0, ref p3);
			SwapIfGreater(ref p1, ref p5);
			SwapIfGreater(ref p2, ref p6);
			SwapIfGreater(ref p2, ref p5);
			SwapIfGreater(ref p1, ref p3);
			SwapIfGreater(ref p2, ref p4);
			SwapIfGreater(ref p2, ref p3);
			SwapIfGreater(ref p7, ref p8);
			SwapIfGreater(ref p9, ref p10);
			SwapIfGreater(ref p7, ref p9);
			SwapIfGreater(ref p8, ref p10);
			SwapIfGreater(ref p8, ref p9);
			SwapIfGreater(ref p11, ref p12);
			SwapIfGreater(ref p13, ref p14);
			SwapIfGreater(ref p11, ref p13);
			SwapIfGreater(ref p12, ref p14);
			SwapIfGreater(ref p12, ref p13);
			SwapIfGreater(ref p7, ref p11);
			SwapIfGreater(ref p8, ref p12);
			SwapIfGreater(ref p8, ref p11);
			SwapIfGreater(ref p9, ref p13);
			SwapIfGreater(ref p10, ref p14);
			SwapIfGreater(ref p10, ref p13);
			SwapIfGreater(ref p9, ref p11);
			SwapIfGreater(ref p10, ref p12);
			SwapIfGreater(ref p10, ref p11);
			SwapIfGreater(ref p0, ref p8);
			SwapIfGreater(ref p0, ref p7);
			SwapIfGreater(ref p1, ref p9);
			SwapIfGreater(ref p2, ref p10);
			SwapIfGreater(ref p2, ref p9);
			SwapIfGreater(ref p1, ref p7);
			SwapIfGreater(ref p2, ref p8);
			SwapIfGreater(ref p2, ref p7);
			SwapIfGreater(ref p3, ref p11);
			SwapIfGreater(ref p4, ref p12);
			SwapIfGreater(ref p4, ref p11);
			SwapIfGreater(ref p5, ref p13);
			SwapIfGreater(ref p6, ref p14);
			SwapIfGreater(ref p6, ref p13);
			SwapIfGreater(ref p5, ref p11);
			SwapIfGreater(ref p6, ref p12);
			SwapIfGreater(ref p6, ref p11);
			SwapIfGreater(ref p3, ref p7);
			SwapIfGreater(ref p4, ref p8);
			SwapIfGreater(ref p4, ref p7);
			SwapIfGreater(ref p5, ref p9);
			SwapIfGreater(ref p6, ref p10);
			SwapIfGreater(ref p6, ref p9);
			SwapIfGreater(ref p5, ref p7);
			SwapIfGreater(ref p6, ref p8);
			SwapIfGreater(ref p6, ref p7);
			SwapIfGreater(ref p15, ref p16);
			SwapIfGreater(ref p17, ref p18);
			SwapIfGreater(ref p15, ref p17);
			SwapIfGreater(ref p16, ref p18);
			SwapIfGreater(ref p16, ref p17);
			SwapIfGreater(ref p19, ref p20);
			SwapIfGreater(ref p21, ref p22);
			SwapIfGreater(ref p19, ref p21);
			SwapIfGreater(ref p20, ref p22);
			SwapIfGreater(ref p20, ref p21);
			SwapIfGreater(ref p15, ref p19);
			SwapIfGreater(ref p16, ref p20);
			SwapIfGreater(ref p16, ref p19);
			SwapIfGreater(ref p17, ref p21);
			SwapIfGreater(ref p18, ref p22);
			SwapIfGreater(ref p18, ref p21);
			SwapIfGreater(ref p17, ref p19);
			SwapIfGreater(ref p18, ref p20);
			SwapIfGreater(ref p18, ref p19);
			SwapIfGreater(ref p23, ref p24);
			SwapIfGreater(ref p25, ref p26);
			SwapIfGreater(ref p23, ref p25);
			SwapIfGreater(ref p24, ref p26);
			SwapIfGreater(ref p24, ref p25);
			SwapIfGreater(ref p27, ref p28);
			SwapIfGreater(ref p29, ref p30);
			SwapIfGreater(ref p27, ref p29);
			SwapIfGreater(ref p28, ref p30);
			SwapIfGreater(ref p28, ref p29);
			SwapIfGreater(ref p23, ref p27);
			SwapIfGreater(ref p24, ref p28);
			SwapIfGreater(ref p24, ref p27);
			SwapIfGreater(ref p25, ref p29);
			SwapIfGreater(ref p26, ref p30);
			SwapIfGreater(ref p26, ref p29);
			SwapIfGreater(ref p25, ref p27);
			SwapIfGreater(ref p26, ref p28);
			SwapIfGreater(ref p26, ref p27);
			SwapIfGreater(ref p15, ref p23);
			SwapIfGreater(ref p16, ref p24);
			SwapIfGreater(ref p16, ref p23);
			SwapIfGreater(ref p17, ref p25);
			SwapIfGreater(ref p18, ref p26);
			SwapIfGreater(ref p18, ref p25);
			SwapIfGreater(ref p17, ref p23);
			SwapIfGreater(ref p18, ref p24);
			SwapIfGreater(ref p18, ref p23);
			SwapIfGreater(ref p19, ref p27);
			SwapIfGreater(ref p20, ref p28);
			SwapIfGreater(ref p20, ref p27);
			SwapIfGreater(ref p21, ref p29);
			SwapIfGreater(ref p22, ref p30);
			SwapIfGreater(ref p22, ref p29);
			SwapIfGreater(ref p21, ref p27);
			SwapIfGreater(ref p22, ref p28);
			SwapIfGreater(ref p22, ref p27);
			SwapIfGreater(ref p19, ref p23);
			SwapIfGreater(ref p20, ref p24);
			SwapIfGreater(ref p20, ref p23);
			SwapIfGreater(ref p21, ref p25);
			SwapIfGreater(ref p22, ref p26);
			SwapIfGreater(ref p22, ref p25);
			SwapIfGreater(ref p21, ref p23);
			SwapIfGreater(ref p22, ref p24);
			SwapIfGreater(ref p22, ref p23);
			SwapIfGreater(ref p0, ref p16);
			SwapIfGreater(ref p0, ref p15);
			SwapIfGreater(ref p1, ref p17);
			SwapIfGreater(ref p2, ref p18);
			SwapIfGreater(ref p2, ref p17);
			SwapIfGreater(ref p1, ref p15);
			SwapIfGreater(ref p2, ref p16);
			SwapIfGreater(ref p2, ref p15);
			SwapIfGreater(ref p3, ref p19);
			SwapIfGreater(ref p4, ref p20);
			SwapIfGreater(ref p4, ref p19);
			SwapIfGreater(ref p5, ref p21);
			SwapIfGreater(ref p6, ref p22);
			SwapIfGreater(ref p6, ref p21);
			SwapIfGreater(ref p5, ref p19);
			SwapIfGreater(ref p6, ref p20);
			SwapIfGreater(ref p6, ref p19);
			SwapIfGreater(ref p3, ref p15);
			SwapIfGreater(ref p4, ref p16);
			SwapIfGreater(ref p4, ref p15);
			SwapIfGreater(ref p5, ref p17);
			SwapIfGreater(ref p6, ref p18);
			SwapIfGreater(ref p6, ref p17);
			SwapIfGreater(ref p5, ref p15);
			SwapIfGreater(ref p6, ref p16);
			SwapIfGreater(ref p6, ref p15);
			SwapIfGreater(ref p7, ref p23);
			SwapIfGreater(ref p8, ref p24);
			SwapIfGreater(ref p8, ref p23);
			SwapIfGreater(ref p9, ref p25);
			SwapIfGreater(ref p10, ref p26);
			SwapIfGreater(ref p10, ref p25);
			SwapIfGreater(ref p9, ref p23);
			SwapIfGreater(ref p10, ref p24);
			SwapIfGreater(ref p10, ref p23);
			SwapIfGreater(ref p11, ref p27);
			SwapIfGreater(ref p12, ref p28);
			SwapIfGreater(ref p12, ref p27);
			SwapIfGreater(ref p13, ref p29);
			SwapIfGreater(ref p14, ref p30);
			SwapIfGreater(ref p14, ref p29);
			SwapIfGreater(ref p13, ref p27);
			SwapIfGreater(ref p14, ref p28);
			SwapIfGreater(ref p14, ref p27);
			SwapIfGreater(ref p11, ref p23);
			SwapIfGreater(ref p12, ref p24);
			SwapIfGreater(ref p12, ref p23);
			SwapIfGreater(ref p13, ref p25);
			SwapIfGreater(ref p14, ref p26);
			SwapIfGreater(ref p14, ref p25);
			SwapIfGreater(ref p13, ref p23);
			SwapIfGreater(ref p14, ref p24);
			SwapIfGreater(ref p14, ref p23);
			SwapIfGreater(ref p7, ref p15);
			SwapIfGreater(ref p8, ref p16);
			SwapIfGreater(ref p8, ref p15);
			SwapIfGreater(ref p9, ref p17);
			SwapIfGreater(ref p10, ref p18);
			SwapIfGreater(ref p10, ref p17);
			SwapIfGreater(ref p9, ref p15);
			SwapIfGreater(ref p10, ref p16);
			SwapIfGreater(ref p10, ref p15);
			SwapIfGreater(ref p11, ref p19);
			SwapIfGreater(ref p12, ref p20);
			SwapIfGreater(ref p12, ref p19);
			SwapIfGreater(ref p13, ref p21);
			SwapIfGreater(ref p14, ref p22);
			SwapIfGreater(ref p14, ref p21);
			SwapIfGreater(ref p13, ref p19);
			SwapIfGreater(ref p14, ref p20);
			SwapIfGreater(ref p14, ref p19);
			SwapIfGreater(ref p11, ref p15);
			SwapIfGreater(ref p12, ref p16);
			SwapIfGreater(ref p12, ref p15);
			SwapIfGreater(ref p13, ref p17);
			SwapIfGreater(ref p14, ref p18);
			SwapIfGreater(ref p14, ref p17);
			SwapIfGreater(ref p13, ref p15);
			SwapIfGreater(ref p14, ref p16);
			SwapIfGreater(ref p14, ref p15);
		}

		/// <summary>
		/// Sorts a collection of 31 elements in descending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort31Descending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);
			ref var p10 = ref Unsafe.Add(ref p9, 10);
			ref var p11 = ref Unsafe.Add(ref p10, 11);
			ref var p12 = ref Unsafe.Add(ref p11, 12);
			ref var p13 = ref Unsafe.Add(ref p12, 13);
			ref var p14 = ref Unsafe.Add(ref p13, 14);
			ref var p15 = ref Unsafe.Add(ref p14, 15);
			ref var p16 = ref Unsafe.Add(ref p15, 16);
			ref var p17 = ref Unsafe.Add(ref p16, 17);
			ref var p18 = ref Unsafe.Add(ref p17, 18);
			ref var p19 = ref Unsafe.Add(ref p18, 19);
			ref var p20 = ref Unsafe.Add(ref p19, 20);
			ref var p21 = ref Unsafe.Add(ref p20, 21);
			ref var p22 = ref Unsafe.Add(ref p21, 22);
			ref var p23 = ref Unsafe.Add(ref p22, 23);
			ref var p24 = ref Unsafe.Add(ref p23, 24);
			ref var p25 = ref Unsafe.Add(ref p24, 25);
			ref var p26 = ref Unsafe.Add(ref p25, 26);
			ref var p27 = ref Unsafe.Add(ref p26, 27);
			ref var p28 = ref Unsafe.Add(ref p27, 28);
			ref var p29 = ref Unsafe.Add(ref p28, 29);
			ref var p30 = ref Unsafe.Add(ref p29, 30);

			SwapIfLesser(ref p1, ref p2);
			SwapIfLesser(ref p0, ref p2);
			SwapIfLesser(ref p0, ref p1);
			SwapIfLesser(ref p3, ref p4);
			SwapIfLesser(ref p5, ref p6);
			SwapIfLesser(ref p3, ref p5);
			SwapIfLesser(ref p4, ref p6);
			SwapIfLesser(ref p4, ref p5);
			SwapIfLesser(ref p0, ref p4);
			SwapIfLesser(ref p0, ref p3);
			SwapIfLesser(ref p1, ref p5);
			SwapIfLesser(ref p2, ref p6);
			SwapIfLesser(ref p2, ref p5);
			SwapIfLesser(ref p1, ref p3);
			SwapIfLesser(ref p2, ref p4);
			SwapIfLesser(ref p2, ref p3);
			SwapIfLesser(ref p7, ref p8);
			SwapIfLesser(ref p9, ref p10);
			SwapIfLesser(ref p7, ref p9);
			SwapIfLesser(ref p8, ref p10);
			SwapIfLesser(ref p8, ref p9);
			SwapIfLesser(ref p11, ref p12);
			SwapIfLesser(ref p13, ref p14);
			SwapIfLesser(ref p11, ref p13);
			SwapIfLesser(ref p12, ref p14);
			SwapIfLesser(ref p12, ref p13);
			SwapIfLesser(ref p7, ref p11);
			SwapIfLesser(ref p8, ref p12);
			SwapIfLesser(ref p8, ref p11);
			SwapIfLesser(ref p9, ref p13);
			SwapIfLesser(ref p10, ref p14);
			SwapIfLesser(ref p10, ref p13);
			SwapIfLesser(ref p9, ref p11);
			SwapIfLesser(ref p10, ref p12);
			SwapIfLesser(ref p10, ref p11);
			SwapIfLesser(ref p0, ref p8);
			SwapIfLesser(ref p0, ref p7);
			SwapIfLesser(ref p1, ref p9);
			SwapIfLesser(ref p2, ref p10);
			SwapIfLesser(ref p2, ref p9);
			SwapIfLesser(ref p1, ref p7);
			SwapIfLesser(ref p2, ref p8);
			SwapIfLesser(ref p2, ref p7);
			SwapIfLesser(ref p3, ref p11);
			SwapIfLesser(ref p4, ref p12);
			SwapIfLesser(ref p4, ref p11);
			SwapIfLesser(ref p5, ref p13);
			SwapIfLesser(ref p6, ref p14);
			SwapIfLesser(ref p6, ref p13);
			SwapIfLesser(ref p5, ref p11);
			SwapIfLesser(ref p6, ref p12);
			SwapIfLesser(ref p6, ref p11);
			SwapIfLesser(ref p3, ref p7);
			SwapIfLesser(ref p4, ref p8);
			SwapIfLesser(ref p4, ref p7);
			SwapIfLesser(ref p5, ref p9);
			SwapIfLesser(ref p6, ref p10);
			SwapIfLesser(ref p6, ref p9);
			SwapIfLesser(ref p5, ref p7);
			SwapIfLesser(ref p6, ref p8);
			SwapIfLesser(ref p6, ref p7);
			SwapIfLesser(ref p15, ref p16);
			SwapIfLesser(ref p17, ref p18);
			SwapIfLesser(ref p15, ref p17);
			SwapIfLesser(ref p16, ref p18);
			SwapIfLesser(ref p16, ref p17);
			SwapIfLesser(ref p19, ref p20);
			SwapIfLesser(ref p21, ref p22);
			SwapIfLesser(ref p19, ref p21);
			SwapIfLesser(ref p20, ref p22);
			SwapIfLesser(ref p20, ref p21);
			SwapIfLesser(ref p15, ref p19);
			SwapIfLesser(ref p16, ref p20);
			SwapIfLesser(ref p16, ref p19);
			SwapIfLesser(ref p17, ref p21);
			SwapIfLesser(ref p18, ref p22);
			SwapIfLesser(ref p18, ref p21);
			SwapIfLesser(ref p17, ref p19);
			SwapIfLesser(ref p18, ref p20);
			SwapIfLesser(ref p18, ref p19);
			SwapIfLesser(ref p23, ref p24);
			SwapIfLesser(ref p25, ref p26);
			SwapIfLesser(ref p23, ref p25);
			SwapIfLesser(ref p24, ref p26);
			SwapIfLesser(ref p24, ref p25);
			SwapIfLesser(ref p27, ref p28);
			SwapIfLesser(ref p29, ref p30);
			SwapIfLesser(ref p27, ref p29);
			SwapIfLesser(ref p28, ref p30);
			SwapIfLesser(ref p28, ref p29);
			SwapIfLesser(ref p23, ref p27);
			SwapIfLesser(ref p24, ref p28);
			SwapIfLesser(ref p24, ref p27);
			SwapIfLesser(ref p25, ref p29);
			SwapIfLesser(ref p26, ref p30);
			SwapIfLesser(ref p26, ref p29);
			SwapIfLesser(ref p25, ref p27);
			SwapIfLesser(ref p26, ref p28);
			SwapIfLesser(ref p26, ref p27);
			SwapIfLesser(ref p15, ref p23);
			SwapIfLesser(ref p16, ref p24);
			SwapIfLesser(ref p16, ref p23);
			SwapIfLesser(ref p17, ref p25);
			SwapIfLesser(ref p18, ref p26);
			SwapIfLesser(ref p18, ref p25);
			SwapIfLesser(ref p17, ref p23);
			SwapIfLesser(ref p18, ref p24);
			SwapIfLesser(ref p18, ref p23);
			SwapIfLesser(ref p19, ref p27);
			SwapIfLesser(ref p20, ref p28);
			SwapIfLesser(ref p20, ref p27);
			SwapIfLesser(ref p21, ref p29);
			SwapIfLesser(ref p22, ref p30);
			SwapIfLesser(ref p22, ref p29);
			SwapIfLesser(ref p21, ref p27);
			SwapIfLesser(ref p22, ref p28);
			SwapIfLesser(ref p22, ref p27);
			SwapIfLesser(ref p19, ref p23);
			SwapIfLesser(ref p20, ref p24);
			SwapIfLesser(ref p20, ref p23);
			SwapIfLesser(ref p21, ref p25);
			SwapIfLesser(ref p22, ref p26);
			SwapIfLesser(ref p22, ref p25);
			SwapIfLesser(ref p21, ref p23);
			SwapIfLesser(ref p22, ref p24);
			SwapIfLesser(ref p22, ref p23);
			SwapIfLesser(ref p0, ref p16);
			SwapIfLesser(ref p0, ref p15);
			SwapIfLesser(ref p1, ref p17);
			SwapIfLesser(ref p2, ref p18);
			SwapIfLesser(ref p2, ref p17);
			SwapIfLesser(ref p1, ref p15);
			SwapIfLesser(ref p2, ref p16);
			SwapIfLesser(ref p2, ref p15);
			SwapIfLesser(ref p3, ref p19);
			SwapIfLesser(ref p4, ref p20);
			SwapIfLesser(ref p4, ref p19);
			SwapIfLesser(ref p5, ref p21);
			SwapIfLesser(ref p6, ref p22);
			SwapIfLesser(ref p6, ref p21);
			SwapIfLesser(ref p5, ref p19);
			SwapIfLesser(ref p6, ref p20);
			SwapIfLesser(ref p6, ref p19);
			SwapIfLesser(ref p3, ref p15);
			SwapIfLesser(ref p4, ref p16);
			SwapIfLesser(ref p4, ref p15);
			SwapIfLesser(ref p5, ref p17);
			SwapIfLesser(ref p6, ref p18);
			SwapIfLesser(ref p6, ref p17);
			SwapIfLesser(ref p5, ref p15);
			SwapIfLesser(ref p6, ref p16);
			SwapIfLesser(ref p6, ref p15);
			SwapIfLesser(ref p7, ref p23);
			SwapIfLesser(ref p8, ref p24);
			SwapIfLesser(ref p8, ref p23);
			SwapIfLesser(ref p9, ref p25);
			SwapIfLesser(ref p10, ref p26);
			SwapIfLesser(ref p10, ref p25);
			SwapIfLesser(ref p9, ref p23);
			SwapIfLesser(ref p10, ref p24);
			SwapIfLesser(ref p10, ref p23);
			SwapIfLesser(ref p11, ref p27);
			SwapIfLesser(ref p12, ref p28);
			SwapIfLesser(ref p12, ref p27);
			SwapIfLesser(ref p13, ref p29);
			SwapIfLesser(ref p14, ref p30);
			SwapIfLesser(ref p14, ref p29);
			SwapIfLesser(ref p13, ref p27);
			SwapIfLesser(ref p14, ref p28);
			SwapIfLesser(ref p14, ref p27);
			SwapIfLesser(ref p11, ref p23);
			SwapIfLesser(ref p12, ref p24);
			SwapIfLesser(ref p12, ref p23);
			SwapIfLesser(ref p13, ref p25);
			SwapIfLesser(ref p14, ref p26);
			SwapIfLesser(ref p14, ref p25);
			SwapIfLesser(ref p13, ref p23);
			SwapIfLesser(ref p14, ref p24);
			SwapIfLesser(ref p14, ref p23);
			SwapIfLesser(ref p7, ref p15);
			SwapIfLesser(ref p8, ref p16);
			SwapIfLesser(ref p8, ref p15);
			SwapIfLesser(ref p9, ref p17);
			SwapIfLesser(ref p10, ref p18);
			SwapIfLesser(ref p10, ref p17);
			SwapIfLesser(ref p9, ref p15);
			SwapIfLesser(ref p10, ref p16);
			SwapIfLesser(ref p10, ref p15);
			SwapIfLesser(ref p11, ref p19);
			SwapIfLesser(ref p12, ref p20);
			SwapIfLesser(ref p12, ref p19);
			SwapIfLesser(ref p13, ref p21);
			SwapIfLesser(ref p14, ref p22);
			SwapIfLesser(ref p14, ref p21);
			SwapIfLesser(ref p13, ref p19);
			SwapIfLesser(ref p14, ref p20);
			SwapIfLesser(ref p14, ref p19);
			SwapIfLesser(ref p11, ref p15);
			SwapIfLesser(ref p12, ref p16);
			SwapIfLesser(ref p12, ref p15);
			SwapIfLesser(ref p13, ref p17);
			SwapIfLesser(ref p14, ref p18);
			SwapIfLesser(ref p14, ref p17);
			SwapIfLesser(ref p13, ref p15);
			SwapIfLesser(ref p14, ref p16);
			SwapIfLesser(ref p14, ref p15);
		}

		/// <summary>
		/// Sorts a collection of 32 elements in ascending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort32Ascending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);
			ref var p10 = ref Unsafe.Add(ref p9, 10);
			ref var p11 = ref Unsafe.Add(ref p10, 11);
			ref var p12 = ref Unsafe.Add(ref p11, 12);
			ref var p13 = ref Unsafe.Add(ref p12, 13);
			ref var p14 = ref Unsafe.Add(ref p13, 14);
			ref var p15 = ref Unsafe.Add(ref p14, 15);
			ref var p16 = ref Unsafe.Add(ref p15, 16);
			ref var p17 = ref Unsafe.Add(ref p16, 17);
			ref var p18 = ref Unsafe.Add(ref p17, 18);
			ref var p19 = ref Unsafe.Add(ref p18, 19);
			ref var p20 = ref Unsafe.Add(ref p19, 20);
			ref var p21 = ref Unsafe.Add(ref p20, 21);
			ref var p22 = ref Unsafe.Add(ref p21, 22);
			ref var p23 = ref Unsafe.Add(ref p22, 23);
			ref var p24 = ref Unsafe.Add(ref p23, 24);
			ref var p25 = ref Unsafe.Add(ref p24, 25);
			ref var p26 = ref Unsafe.Add(ref p25, 26);
			ref var p27 = ref Unsafe.Add(ref p26, 27);
			ref var p28 = ref Unsafe.Add(ref p27, 28);
			ref var p29 = ref Unsafe.Add(ref p28, 29);
			ref var p30 = ref Unsafe.Add(ref p29, 30);
			ref var p31 = ref Unsafe.Add(ref p30, 31);

			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p2, ref p3);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p1, ref p3);
			SwapIfGreater(ref p1, ref p2);
			SwapIfGreater(ref p4, ref p5);
			SwapIfGreater(ref p6, ref p7);
			SwapIfGreater(ref p4, ref p6);
			SwapIfGreater(ref p5, ref p7);
			SwapIfGreater(ref p5, ref p6);
			SwapIfGreater(ref p0, ref p4);
			SwapIfGreater(ref p1, ref p5);
			SwapIfGreater(ref p1, ref p4);
			SwapIfGreater(ref p2, ref p6);
			SwapIfGreater(ref p3, ref p7);
			SwapIfGreater(ref p3, ref p6);
			SwapIfGreater(ref p2, ref p4);
			SwapIfGreater(ref p3, ref p5);
			SwapIfGreater(ref p3, ref p4);
			SwapIfGreater(ref p8, ref p9);
			SwapIfGreater(ref p10, ref p11);
			SwapIfGreater(ref p8, ref p10);
			SwapIfGreater(ref p9, ref p11);
			SwapIfGreater(ref p9, ref p10);
			SwapIfGreater(ref p12, ref p13);
			SwapIfGreater(ref p14, ref p15);
			SwapIfGreater(ref p12, ref p14);
			SwapIfGreater(ref p13, ref p15);
			SwapIfGreater(ref p13, ref p14);
			SwapIfGreater(ref p8, ref p12);
			SwapIfGreater(ref p9, ref p13);
			SwapIfGreater(ref p9, ref p12);
			SwapIfGreater(ref p10, ref p14);
			SwapIfGreater(ref p11, ref p15);
			SwapIfGreater(ref p11, ref p14);
			SwapIfGreater(ref p10, ref p12);
			SwapIfGreater(ref p11, ref p13);
			SwapIfGreater(ref p11, ref p12);
			SwapIfGreater(ref p0, ref p8);
			SwapIfGreater(ref p1, ref p9);
			SwapIfGreater(ref p1, ref p8);
			SwapIfGreater(ref p2, ref p10);
			SwapIfGreater(ref p3, ref p11);
			SwapIfGreater(ref p3, ref p10);
			SwapIfGreater(ref p2, ref p8);
			SwapIfGreater(ref p3, ref p9);
			SwapIfGreater(ref p3, ref p8);
			SwapIfGreater(ref p4, ref p12);
			SwapIfGreater(ref p5, ref p13);
			SwapIfGreater(ref p5, ref p12);
			SwapIfGreater(ref p6, ref p14);
			SwapIfGreater(ref p7, ref p15);
			SwapIfGreater(ref p7, ref p14);
			SwapIfGreater(ref p6, ref p12);
			SwapIfGreater(ref p7, ref p13);
			SwapIfGreater(ref p7, ref p12);
			SwapIfGreater(ref p4, ref p8);
			SwapIfGreater(ref p5, ref p9);
			SwapIfGreater(ref p5, ref p8);
			SwapIfGreater(ref p6, ref p10);
			SwapIfGreater(ref p7, ref p11);
			SwapIfGreater(ref p7, ref p10);
			SwapIfGreater(ref p6, ref p8);
			SwapIfGreater(ref p7, ref p9);
			SwapIfGreater(ref p7, ref p8);
			SwapIfGreater(ref p16, ref p17);
			SwapIfGreater(ref p18, ref p19);
			SwapIfGreater(ref p16, ref p18);
			SwapIfGreater(ref p17, ref p19);
			SwapIfGreater(ref p17, ref p18);
			SwapIfGreater(ref p20, ref p21);
			SwapIfGreater(ref p22, ref p23);
			SwapIfGreater(ref p20, ref p22);
			SwapIfGreater(ref p21, ref p23);
			SwapIfGreater(ref p21, ref p22);
			SwapIfGreater(ref p16, ref p20);
			SwapIfGreater(ref p17, ref p21);
			SwapIfGreater(ref p17, ref p20);
			SwapIfGreater(ref p18, ref p22);
			SwapIfGreater(ref p19, ref p23);
			SwapIfGreater(ref p19, ref p22);
			SwapIfGreater(ref p18, ref p20);
			SwapIfGreater(ref p19, ref p21);
			SwapIfGreater(ref p19, ref p20);
			SwapIfGreater(ref p24, ref p25);
			SwapIfGreater(ref p26, ref p27);
			SwapIfGreater(ref p24, ref p26);
			SwapIfGreater(ref p25, ref p27);
			SwapIfGreater(ref p25, ref p26);
			SwapIfGreater(ref p28, ref p29);
			SwapIfGreater(ref p30, ref p31);
			SwapIfGreater(ref p28, ref p30);
			SwapIfGreater(ref p29, ref p31);
			SwapIfGreater(ref p29, ref p30);
			SwapIfGreater(ref p24, ref p28);
			SwapIfGreater(ref p25, ref p29);
			SwapIfGreater(ref p25, ref p28);
			SwapIfGreater(ref p26, ref p30);
			SwapIfGreater(ref p27, ref p31);
			SwapIfGreater(ref p27, ref p30);
			SwapIfGreater(ref p26, ref p28);
			SwapIfGreater(ref p27, ref p29);
			SwapIfGreater(ref p27, ref p28);
			SwapIfGreater(ref p16, ref p24);
			SwapIfGreater(ref p17, ref p25);
			SwapIfGreater(ref p17, ref p24);
			SwapIfGreater(ref p18, ref p26);
			SwapIfGreater(ref p19, ref p27);
			SwapIfGreater(ref p19, ref p26);
			SwapIfGreater(ref p18, ref p24);
			SwapIfGreater(ref p19, ref p25);
			SwapIfGreater(ref p19, ref p24);
			SwapIfGreater(ref p20, ref p28);
			SwapIfGreater(ref p21, ref p29);
			SwapIfGreater(ref p21, ref p28);
			SwapIfGreater(ref p22, ref p30);
			SwapIfGreater(ref p23, ref p31);
			SwapIfGreater(ref p23, ref p30);
			SwapIfGreater(ref p22, ref p28);
			SwapIfGreater(ref p23, ref p29);
			SwapIfGreater(ref p23, ref p28);
			SwapIfGreater(ref p20, ref p24);
			SwapIfGreater(ref p21, ref p25);
			SwapIfGreater(ref p21, ref p24);
			SwapIfGreater(ref p22, ref p26);
			SwapIfGreater(ref p23, ref p27);
			SwapIfGreater(ref p23, ref p26);
			SwapIfGreater(ref p22, ref p24);
			SwapIfGreater(ref p23, ref p25);
			SwapIfGreater(ref p23, ref p24);
			SwapIfGreater(ref p0, ref p16);
			SwapIfGreater(ref p1, ref p17);
			SwapIfGreater(ref p1, ref p16);
			SwapIfGreater(ref p2, ref p18);
			SwapIfGreater(ref p3, ref p19);
			SwapIfGreater(ref p3, ref p18);
			SwapIfGreater(ref p2, ref p16);
			SwapIfGreater(ref p3, ref p17);
			SwapIfGreater(ref p3, ref p16);
			SwapIfGreater(ref p4, ref p20);
			SwapIfGreater(ref p5, ref p21);
			SwapIfGreater(ref p5, ref p20);
			SwapIfGreater(ref p6, ref p22);
			SwapIfGreater(ref p7, ref p23);
			SwapIfGreater(ref p7, ref p22);
			SwapIfGreater(ref p6, ref p20);
			SwapIfGreater(ref p7, ref p21);
			SwapIfGreater(ref p7, ref p20);
			SwapIfGreater(ref p4, ref p16);
			SwapIfGreater(ref p5, ref p17);
			SwapIfGreater(ref p5, ref p16);
			SwapIfGreater(ref p6, ref p18);
			SwapIfGreater(ref p7, ref p19);
			SwapIfGreater(ref p7, ref p18);
			SwapIfGreater(ref p6, ref p16);
			SwapIfGreater(ref p7, ref p17);
			SwapIfGreater(ref p7, ref p16);
			SwapIfGreater(ref p8, ref p24);
			SwapIfGreater(ref p9, ref p25);
			SwapIfGreater(ref p9, ref p24);
			SwapIfGreater(ref p10, ref p26);
			SwapIfGreater(ref p11, ref p27);
			SwapIfGreater(ref p11, ref p26);
			SwapIfGreater(ref p10, ref p24);
			SwapIfGreater(ref p11, ref p25);
			SwapIfGreater(ref p11, ref p24);
			SwapIfGreater(ref p12, ref p28);
			SwapIfGreater(ref p13, ref p29);
			SwapIfGreater(ref p13, ref p28);
			SwapIfGreater(ref p14, ref p30);
			SwapIfGreater(ref p15, ref p31);
			SwapIfGreater(ref p15, ref p30);
			SwapIfGreater(ref p14, ref p28);
			SwapIfGreater(ref p15, ref p29);
			SwapIfGreater(ref p15, ref p28);
			SwapIfGreater(ref p12, ref p24);
			SwapIfGreater(ref p13, ref p25);
			SwapIfGreater(ref p13, ref p24);
			SwapIfGreater(ref p14, ref p26);
			SwapIfGreater(ref p15, ref p27);
			SwapIfGreater(ref p15, ref p26);
			SwapIfGreater(ref p14, ref p24);
			SwapIfGreater(ref p15, ref p25);
			SwapIfGreater(ref p15, ref p24);
			SwapIfGreater(ref p8, ref p16);
			SwapIfGreater(ref p9, ref p17);
			SwapIfGreater(ref p9, ref p16);
			SwapIfGreater(ref p10, ref p18);
			SwapIfGreater(ref p11, ref p19);
			SwapIfGreater(ref p11, ref p18);
			SwapIfGreater(ref p10, ref p16);
			SwapIfGreater(ref p11, ref p17);
			SwapIfGreater(ref p11, ref p16);
			SwapIfGreater(ref p12, ref p20);
			SwapIfGreater(ref p13, ref p21);
			SwapIfGreater(ref p13, ref p20);
			SwapIfGreater(ref p14, ref p22);
			SwapIfGreater(ref p15, ref p23);
			SwapIfGreater(ref p15, ref p22);
			SwapIfGreater(ref p14, ref p20);
			SwapIfGreater(ref p15, ref p21);
			SwapIfGreater(ref p15, ref p20);
			SwapIfGreater(ref p12, ref p16);
			SwapIfGreater(ref p13, ref p17);
			SwapIfGreater(ref p13, ref p16);
			SwapIfGreater(ref p14, ref p18);
			SwapIfGreater(ref p15, ref p19);
			SwapIfGreater(ref p15, ref p18);
			SwapIfGreater(ref p14, ref p16);
			SwapIfGreater(ref p15, ref p17);
			SwapIfGreater(ref p15, ref p16);
		}

		/// <summary>
		/// Sorts a collection of 32 elements in descending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		public static void Sort32Descending<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p1, 2);
			ref var p3 = ref Unsafe.Add(ref p2, 3);
			ref var p4 = ref Unsafe.Add(ref p3, 4);
			ref var p5 = ref Unsafe.Add(ref p4, 5);
			ref var p6 = ref Unsafe.Add(ref p5, 6);
			ref var p7 = ref Unsafe.Add(ref p6, 7);
			ref var p8 = ref Unsafe.Add(ref p7, 8);
			ref var p9 = ref Unsafe.Add(ref p8, 9);
			ref var p10 = ref Unsafe.Add(ref p9, 10);
			ref var p11 = ref Unsafe.Add(ref p10, 11);
			ref var p12 = ref Unsafe.Add(ref p11, 12);
			ref var p13 = ref Unsafe.Add(ref p12, 13);
			ref var p14 = ref Unsafe.Add(ref p13, 14);
			ref var p15 = ref Unsafe.Add(ref p14, 15);
			ref var p16 = ref Unsafe.Add(ref p15, 16);
			ref var p17 = ref Unsafe.Add(ref p16, 17);
			ref var p18 = ref Unsafe.Add(ref p17, 18);
			ref var p19 = ref Unsafe.Add(ref p18, 19);
			ref var p20 = ref Unsafe.Add(ref p19, 20);
			ref var p21 = ref Unsafe.Add(ref p20, 21);
			ref var p22 = ref Unsafe.Add(ref p21, 22);
			ref var p23 = ref Unsafe.Add(ref p22, 23);
			ref var p24 = ref Unsafe.Add(ref p23, 24);
			ref var p25 = ref Unsafe.Add(ref p24, 25);
			ref var p26 = ref Unsafe.Add(ref p25, 26);
			ref var p27 = ref Unsafe.Add(ref p26, 27);
			ref var p28 = ref Unsafe.Add(ref p27, 28);
			ref var p29 = ref Unsafe.Add(ref p28, 29);
			ref var p30 = ref Unsafe.Add(ref p29, 30);
			ref var p31 = ref Unsafe.Add(ref p30, 31);

			SwapIfLesser(ref p0, ref p1);
			SwapIfLesser(ref p2, ref p3);
			SwapIfLesser(ref p0, ref p2);
			SwapIfLesser(ref p1, ref p3);
			SwapIfLesser(ref p1, ref p2);
			SwapIfLesser(ref p4, ref p5);
			SwapIfLesser(ref p6, ref p7);
			SwapIfLesser(ref p4, ref p6);
			SwapIfLesser(ref p5, ref p7);
			SwapIfLesser(ref p5, ref p6);
			SwapIfLesser(ref p0, ref p4);
			SwapIfLesser(ref p1, ref p5);
			SwapIfLesser(ref p1, ref p4);
			SwapIfLesser(ref p2, ref p6);
			SwapIfLesser(ref p3, ref p7);
			SwapIfLesser(ref p3, ref p6);
			SwapIfLesser(ref p2, ref p4);
			SwapIfLesser(ref p3, ref p5);
			SwapIfLesser(ref p3, ref p4);
			SwapIfLesser(ref p8, ref p9);
			SwapIfLesser(ref p10, ref p11);
			SwapIfLesser(ref p8, ref p10);
			SwapIfLesser(ref p9, ref p11);
			SwapIfLesser(ref p9, ref p10);
			SwapIfLesser(ref p12, ref p13);
			SwapIfLesser(ref p14, ref p15);
			SwapIfLesser(ref p12, ref p14);
			SwapIfLesser(ref p13, ref p15);
			SwapIfLesser(ref p13, ref p14);
			SwapIfLesser(ref p8, ref p12);
			SwapIfLesser(ref p9, ref p13);
			SwapIfLesser(ref p9, ref p12);
			SwapIfLesser(ref p10, ref p14);
			SwapIfLesser(ref p11, ref p15);
			SwapIfLesser(ref p11, ref p14);
			SwapIfLesser(ref p10, ref p12);
			SwapIfLesser(ref p11, ref p13);
			SwapIfLesser(ref p11, ref p12);
			SwapIfLesser(ref p0, ref p8);
			SwapIfLesser(ref p1, ref p9);
			SwapIfLesser(ref p1, ref p8);
			SwapIfLesser(ref p2, ref p10);
			SwapIfLesser(ref p3, ref p11);
			SwapIfLesser(ref p3, ref p10);
			SwapIfLesser(ref p2, ref p8);
			SwapIfLesser(ref p3, ref p9);
			SwapIfLesser(ref p3, ref p8);
			SwapIfLesser(ref p4, ref p12);
			SwapIfLesser(ref p5, ref p13);
			SwapIfLesser(ref p5, ref p12);
			SwapIfLesser(ref p6, ref p14);
			SwapIfLesser(ref p7, ref p15);
			SwapIfLesser(ref p7, ref p14);
			SwapIfLesser(ref p6, ref p12);
			SwapIfLesser(ref p7, ref p13);
			SwapIfLesser(ref p7, ref p12);
			SwapIfLesser(ref p4, ref p8);
			SwapIfLesser(ref p5, ref p9);
			SwapIfLesser(ref p5, ref p8);
			SwapIfLesser(ref p6, ref p10);
			SwapIfLesser(ref p7, ref p11);
			SwapIfLesser(ref p7, ref p10);
			SwapIfLesser(ref p6, ref p8);
			SwapIfLesser(ref p7, ref p9);
			SwapIfLesser(ref p7, ref p8);
			SwapIfLesser(ref p16, ref p17);
			SwapIfLesser(ref p18, ref p19);
			SwapIfLesser(ref p16, ref p18);
			SwapIfLesser(ref p17, ref p19);
			SwapIfLesser(ref p17, ref p18);
			SwapIfLesser(ref p20, ref p21);
			SwapIfLesser(ref p22, ref p23);
			SwapIfLesser(ref p20, ref p22);
			SwapIfLesser(ref p21, ref p23);
			SwapIfLesser(ref p21, ref p22);
			SwapIfLesser(ref p16, ref p20);
			SwapIfLesser(ref p17, ref p21);
			SwapIfLesser(ref p17, ref p20);
			SwapIfLesser(ref p18, ref p22);
			SwapIfLesser(ref p19, ref p23);
			SwapIfLesser(ref p19, ref p22);
			SwapIfLesser(ref p18, ref p20);
			SwapIfLesser(ref p19, ref p21);
			SwapIfLesser(ref p19, ref p20);
			SwapIfLesser(ref p24, ref p25);
			SwapIfLesser(ref p26, ref p27);
			SwapIfLesser(ref p24, ref p26);
			SwapIfLesser(ref p25, ref p27);
			SwapIfLesser(ref p25, ref p26);
			SwapIfLesser(ref p28, ref p29);
			SwapIfLesser(ref p30, ref p31);
			SwapIfLesser(ref p28, ref p30);
			SwapIfLesser(ref p29, ref p31);
			SwapIfLesser(ref p29, ref p30);
			SwapIfLesser(ref p24, ref p28);
			SwapIfLesser(ref p25, ref p29);
			SwapIfLesser(ref p25, ref p28);
			SwapIfLesser(ref p26, ref p30);
			SwapIfLesser(ref p27, ref p31);
			SwapIfLesser(ref p27, ref p30);
			SwapIfLesser(ref p26, ref p28);
			SwapIfLesser(ref p27, ref p29);
			SwapIfLesser(ref p27, ref p28);
			SwapIfLesser(ref p16, ref p24);
			SwapIfLesser(ref p17, ref p25);
			SwapIfLesser(ref p17, ref p24);
			SwapIfLesser(ref p18, ref p26);
			SwapIfLesser(ref p19, ref p27);
			SwapIfLesser(ref p19, ref p26);
			SwapIfLesser(ref p18, ref p24);
			SwapIfLesser(ref p19, ref p25);
			SwapIfLesser(ref p19, ref p24);
			SwapIfLesser(ref p20, ref p28);
			SwapIfLesser(ref p21, ref p29);
			SwapIfLesser(ref p21, ref p28);
			SwapIfLesser(ref p22, ref p30);
			SwapIfLesser(ref p23, ref p31);
			SwapIfLesser(ref p23, ref p30);
			SwapIfLesser(ref p22, ref p28);
			SwapIfLesser(ref p23, ref p29);
			SwapIfLesser(ref p23, ref p28);
			SwapIfLesser(ref p20, ref p24);
			SwapIfLesser(ref p21, ref p25);
			SwapIfLesser(ref p21, ref p24);
			SwapIfLesser(ref p22, ref p26);
			SwapIfLesser(ref p23, ref p27);
			SwapIfLesser(ref p23, ref p26);
			SwapIfLesser(ref p22, ref p24);
			SwapIfLesser(ref p23, ref p25);
			SwapIfLesser(ref p23, ref p24);
			SwapIfLesser(ref p0, ref p16);
			SwapIfLesser(ref p1, ref p17);
			SwapIfLesser(ref p1, ref p16);
			SwapIfLesser(ref p2, ref p18);
			SwapIfLesser(ref p3, ref p19);
			SwapIfLesser(ref p3, ref p18);
			SwapIfLesser(ref p2, ref p16);
			SwapIfLesser(ref p3, ref p17);
			SwapIfLesser(ref p3, ref p16);
			SwapIfLesser(ref p4, ref p20);
			SwapIfLesser(ref p5, ref p21);
			SwapIfLesser(ref p5, ref p20);
			SwapIfLesser(ref p6, ref p22);
			SwapIfLesser(ref p7, ref p23);
			SwapIfLesser(ref p7, ref p22);
			SwapIfLesser(ref p6, ref p20);
			SwapIfLesser(ref p7, ref p21);
			SwapIfLesser(ref p7, ref p20);
			SwapIfLesser(ref p4, ref p16);
			SwapIfLesser(ref p5, ref p17);
			SwapIfLesser(ref p5, ref p16);
			SwapIfLesser(ref p6, ref p18);
			SwapIfLesser(ref p7, ref p19);
			SwapIfLesser(ref p7, ref p18);
			SwapIfLesser(ref p6, ref p16);
			SwapIfLesser(ref p7, ref p17);
			SwapIfLesser(ref p7, ref p16);
			SwapIfLesser(ref p8, ref p24);
			SwapIfLesser(ref p9, ref p25);
			SwapIfLesser(ref p9, ref p24);
			SwapIfLesser(ref p10, ref p26);
			SwapIfLesser(ref p11, ref p27);
			SwapIfLesser(ref p11, ref p26);
			SwapIfLesser(ref p10, ref p24);
			SwapIfLesser(ref p11, ref p25);
			SwapIfLesser(ref p11, ref p24);
			SwapIfLesser(ref p12, ref p28);
			SwapIfLesser(ref p13, ref p29);
			SwapIfLesser(ref p13, ref p28);
			SwapIfLesser(ref p14, ref p30);
			SwapIfLesser(ref p15, ref p31);
			SwapIfLesser(ref p15, ref p30);
			SwapIfLesser(ref p14, ref p28);
			SwapIfLesser(ref p15, ref p29);
			SwapIfLesser(ref p15, ref p28);
			SwapIfLesser(ref p12, ref p24);
			SwapIfLesser(ref p13, ref p25);
			SwapIfLesser(ref p13, ref p24);
			SwapIfLesser(ref p14, ref p26);
			SwapIfLesser(ref p15, ref p27);
			SwapIfLesser(ref p15, ref p26);
			SwapIfLesser(ref p14, ref p24);
			SwapIfLesser(ref p15, ref p25);
			SwapIfLesser(ref p15, ref p24);
			SwapIfLesser(ref p8, ref p16);
			SwapIfLesser(ref p9, ref p17);
			SwapIfLesser(ref p9, ref p16);
			SwapIfLesser(ref p10, ref p18);
			SwapIfLesser(ref p11, ref p19);
			SwapIfLesser(ref p11, ref p18);
			SwapIfLesser(ref p10, ref p16);
			SwapIfLesser(ref p11, ref p17);
			SwapIfLesser(ref p11, ref p16);
			SwapIfLesser(ref p12, ref p20);
			SwapIfLesser(ref p13, ref p21);
			SwapIfLesser(ref p13, ref p20);
			SwapIfLesser(ref p14, ref p22);
			SwapIfLesser(ref p15, ref p23);
			SwapIfLesser(ref p15, ref p22);
			SwapIfLesser(ref p14, ref p20);
			SwapIfLesser(ref p15, ref p21);
			SwapIfLesser(ref p15, ref p20);
			SwapIfLesser(ref p12, ref p16);
			SwapIfLesser(ref p13, ref p17);
			SwapIfLesser(ref p13, ref p16);
			SwapIfLesser(ref p14, ref p18);
			SwapIfLesser(ref p15, ref p19);
			SwapIfLesser(ref p15, ref p18);
			SwapIfLesser(ref p14, ref p16);
			SwapIfLesser(ref p15, ref p17);
			SwapIfLesser(ref p15, ref p16);
		}

		/// <summary>
		/// Sorts a collection of specified number of elements in ascending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="length">the length of the collection</param>
		/// <exception cref="ArgumentOutOfRangeException">collection length is not between <see cref="MinLength"/> and <see cref="MaxLength"/></exception>
		public static void SortAscending<T>(ref T p0, in int length)
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

		/// <summary>
		/// Sorts a collection of specified number of elements in descending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="length">the length of the collection</param>
		/// <exception cref="ArgumentOutOfRangeException">collection length is not between <see cref="MinLength"/> and <see cref="MaxLength"/></exception>
		public static void SortDescending<T>(ref T p0, in int length)
			where T : IComparable<T>
		{
			switch (length)
			{
				case 2: Sort2Descending(ref p0); break;
				case 3: Sort3Descending(ref p0); break;
				case 4: Sort4Descending(ref p0); break;
				case 5: Sort5Descending(ref p0); break;
				case 6: Sort6Descending(ref p0); break;
				case 7: Sort7Descending(ref p0); break;
				case 8: Sort8Descending(ref p0); break;
				case 9: Sort9Descending(ref p0); break;
				case 10: Sort10Descending(ref p0); break;
				case 11: Sort11Descending(ref p0); break;
				case 12: Sort12Descending(ref p0); break;
				case 13: Sort13Descending(ref p0); break;
				case 14: Sort14Descending(ref p0); break;
				case 15: Sort15Descending(ref p0); break;
				case 16: Sort16Descending(ref p0); break;
				case 17: Sort17Descending(ref p0); break;
				case 18: Sort18Descending(ref p0); break;
				case 19: Sort19Descending(ref p0); break;
				case 20: Sort20Descending(ref p0); break;
				case 21: Sort21Descending(ref p0); break;
				case 22: Sort22Descending(ref p0); break;
				case 23: Sort23Descending(ref p0); break;
				case 24: Sort24Descending(ref p0); break;
				case 25: Sort25Descending(ref p0); break;
				case 26: Sort26Descending(ref p0); break;
				case 27: Sort27Descending(ref p0); break;
				case 28: Sort28Descending(ref p0); break;
				case 29: Sort29Descending(ref p0); break;
				case 30: Sort30Descending(ref p0); break;
				case 31: Sort31Descending(ref p0); break;
				case 32: Sort32Descending(ref p0); break;
				default: throw new ArgumentOutOfRangeException(nameof(length), $"Sorting network length `{length}` must be between `{MinLength}` and `{MaxLength}`.");
			}
		}
	}
}