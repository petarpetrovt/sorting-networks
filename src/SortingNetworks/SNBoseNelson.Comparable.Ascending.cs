﻿namespace SortingNetworks
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

			T temp;
#if NETSTANDARD1_3
			if (p0.CompareTo(p1) > 0) { temp = p0; p0 = p1; p1 = temp; }
#else
			if (GreaterThan(ref p0, ref p1)) { temp = p0; p0 = p1; p1 = temp; }
#endif
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
			ref var p2 = ref Unsafe.Add(ref p0, 2);

			T temp;
#if NETSTANDARD1_3
			if (p1.CompareTo(p2) > 0) { temp = p1; p1 = p2; p2 = temp; }
			if (p0.CompareTo(p2) > 0) { temp = p0; p0 = p2; p2 = temp; }
			if (p0.CompareTo(p1) > 0) { temp = p0; p0 = p1; p1 = temp; }
#else
			if (GreaterThan(ref p1, ref p2)) { temp = p1; p1 = p2; p2 = temp; }
			if (GreaterThan(ref p0, ref p2)) { temp = p0; p0 = p2; p2 = temp; }
			if (GreaterThan(ref p0, ref p1)) { temp = p0; p0 = p1; p1 = temp; }
#endif
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
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);

			T temp;
#if NETSTANDARD1_3
			if (p0.CompareTo(p1) > 0) { temp = p0; p0 = p1; p1 = temp; }
			if (p2.CompareTo(p3) > 0) { temp = p2; p2 = p3; p3 = temp; }
			if (p0.CompareTo(p2) > 0) { temp = p0; p0 = p2; p2 = temp; }
			if (p1.CompareTo(p3) > 0) { temp = p1; p1 = p3; p3 = temp; }
			if (p1.CompareTo(p2) > 0) { temp = p1; p1 = p2; p2 = temp; }
#else
			if (GreaterThan(ref p0, ref p1)) { temp = p0; p0 = p1; p1 = temp; }
			if (GreaterThan(ref p2, ref p3)) { temp = p2; p2 = p3; p3 = temp; }
			if (GreaterThan(ref p0, ref p2)) { temp = p0; p0 = p2; p2 = temp; }
			if (GreaterThan(ref p1, ref p3)) { temp = p1; p1 = p3; p3 = temp; }
			if (GreaterThan(ref p1, ref p2)) { temp = p1; p1 = p2; p2 = temp; }
#endif
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
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);

			T temp;
#if NETSTANDARD1_3
			if (p0.CompareTo(p1) > 0) { temp = p0; p0 = p1; p1 = temp; }
			if (p3.CompareTo(p4) > 0) { temp = p3; p3 = p4; p4 = temp; }
			if (p2.CompareTo(p4) > 0) { temp = p2; p2 = p4; p4 = temp; }
			if (p2.CompareTo(p3) > 0) { temp = p2; p2 = p3; p3 = temp; }
			if (p0.CompareTo(p3) > 0) { temp = p0; p0 = p3; p3 = temp; }
			if (p0.CompareTo(p2) > 0) { temp = p0; p0 = p2; p2 = temp; }
			if (p1.CompareTo(p4) > 0) { temp = p1; p1 = p4; p4 = temp; }
			if (p1.CompareTo(p3) > 0) { temp = p1; p1 = p3; p3 = temp; }
			if (p1.CompareTo(p2) > 0) { temp = p1; p1 = p2; p2 = temp; }
#else
			if (GreaterThan(ref p0, ref p1)) { temp = p0; p0 = p1; p1 = temp; }
			if (GreaterThan(ref p3, ref p4)) { temp = p3; p3 = p4; p4 = temp; }
			if (GreaterThan(ref p2, ref p4)) { temp = p2; p2 = p4; p4 = temp; }
			if (GreaterThan(ref p2, ref p3)) { temp = p2; p2 = p3; p3 = temp; }
			if (GreaterThan(ref p0, ref p3)) { temp = p0; p0 = p3; p3 = temp; }
			if (GreaterThan(ref p0, ref p2)) { temp = p0; p0 = p2; p2 = temp; }
			if (GreaterThan(ref p1, ref p4)) { temp = p1; p1 = p4; p4 = temp; }
			if (GreaterThan(ref p1, ref p3)) { temp = p1; p1 = p3; p3 = temp; }
			if (GreaterThan(ref p1, ref p2)) { temp = p1; p1 = p2; p2 = temp; }
#endif
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
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);
			ref var p5 = ref Unsafe.Add(ref p0, 5);

			T temp;
#if NETSTANDARD1_3
			if (p1.CompareTo(p2) > 0) { temp = p1; p1 = p2; p2 = temp; }
			if (p0.CompareTo(p2) > 0) { temp = p0; p0 = p2; p2 = temp; }
			if (p0.CompareTo(p1) > 0) { temp = p0; p0 = p1; p1 = temp; }
			if (p4.CompareTo(p5) > 0) { temp = p4; p4 = p5; p5 = temp; }
			if (p3.CompareTo(p5) > 0) { temp = p3; p3 = p5; p5 = temp; }
			if (p3.CompareTo(p4) > 0) { temp = p3; p3 = p4; p4 = temp; }
			if (p0.CompareTo(p4) > 0) { temp = p0; p0 = p4; p4 = temp; }
			if (p0.CompareTo(p3) > 0) { temp = p0; p0 = p3; p3 = temp; }
			if (p1.CompareTo(p5) > 0) { temp = p1; p1 = p5; p5 = temp; }
			if (p2.CompareTo(p5) > 0) { temp = p2; p2 = p5; p5 = temp; }
			if (p1.CompareTo(p3) > 0) { temp = p1; p1 = p3; p3 = temp; }
			if (p2.CompareTo(p4) > 0) { temp = p2; p2 = p4; p4 = temp; }
			if (p2.CompareTo(p3) > 0) { temp = p2; p2 = p3; p3 = temp; }
#else
			if (GreaterThan(ref p1, ref p2)) { temp = p1; p1 = p2; p2 = temp; }
			if (GreaterThan(ref p0, ref p2)) { temp = p0; p0 = p2; p2 = temp; }
			if (GreaterThan(ref p0, ref p1)) { temp = p0; p0 = p1; p1 = temp; }
			if (GreaterThan(ref p4, ref p5)) { temp = p4; p4 = p5; p5 = temp; }
			if (GreaterThan(ref p3, ref p5)) { temp = p3; p3 = p5; p5 = temp; }
			if (GreaterThan(ref p3, ref p4)) { temp = p3; p3 = p4; p4 = temp; }
			if (GreaterThan(ref p0, ref p4)) { temp = p0; p0 = p4; p4 = temp; }
			if (GreaterThan(ref p0, ref p3)) { temp = p0; p0 = p3; p3 = temp; }
			if (GreaterThan(ref p1, ref p5)) { temp = p1; p1 = p5; p5 = temp; }
			if (GreaterThan(ref p2, ref p5)) { temp = p2; p2 = p5; p5 = temp; }
			if (GreaterThan(ref p1, ref p3)) { temp = p1; p1 = p3; p3 = temp; }
			if (GreaterThan(ref p2, ref p4)) { temp = p2; p2 = p4; p4 = temp; }
			if (GreaterThan(ref p2, ref p3)) { temp = p2; p2 = p3; p3 = temp; }
#endif
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
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);
			ref var p5 = ref Unsafe.Add(ref p0, 5);
			ref var p6 = ref Unsafe.Add(ref p0, 6);

			T temp;
#if NETSTANDARD1_3
			if (p1.CompareTo(p2) > 0) { temp = p1; p1 = p2; p2 = temp; }
			if (p0.CompareTo(p2) > 0) { temp = p0; p0 = p2; p2 = temp; }
			if (p0.CompareTo(p1) > 0) { temp = p0; p0 = p1; p1 = temp; }
			if (p3.CompareTo(p4) > 0) { temp = p3; p3 = p4; p4 = temp; }
			if (p5.CompareTo(p6) > 0) { temp = p5; p5 = p6; p6 = temp; }
			if (p3.CompareTo(p5) > 0) { temp = p3; p3 = p5; p5 = temp; }
			if (p4.CompareTo(p6) > 0) { temp = p4; p4 = p6; p6 = temp; }
			if (p4.CompareTo(p5) > 0) { temp = p4; p4 = p5; p5 = temp; }
			if (p0.CompareTo(p4) > 0) { temp = p0; p0 = p4; p4 = temp; }
			if (p0.CompareTo(p3) > 0) { temp = p0; p0 = p3; p3 = temp; }
			if (p1.CompareTo(p5) > 0) { temp = p1; p1 = p5; p5 = temp; }
			if (p2.CompareTo(p6) > 0) { temp = p2; p2 = p6; p6 = temp; }
			if (p2.CompareTo(p5) > 0) { temp = p2; p2 = p5; p5 = temp; }
			if (p1.CompareTo(p3) > 0) { temp = p1; p1 = p3; p3 = temp; }
			if (p2.CompareTo(p4) > 0) { temp = p2; p2 = p4; p4 = temp; }
			if (p2.CompareTo(p3) > 0) { temp = p2; p2 = p3; p3 = temp; }
#else
			if (GreaterThan(ref p1, ref p2)) { temp = p1; p1 = p2; p2 = temp; }
			if (GreaterThan(ref p0, ref p2)) { temp = p0; p0 = p2; p2 = temp; }
			if (GreaterThan(ref p0, ref p1)) { temp = p0; p0 = p1; p1 = temp; }
			if (GreaterThan(ref p3, ref p4)) { temp = p3; p3 = p4; p4 = temp; }
			if (GreaterThan(ref p5, ref p6)) { temp = p5; p5 = p6; p6 = temp; }
			if (GreaterThan(ref p3, ref p5)) { temp = p3; p3 = p5; p5 = temp; }
			if (GreaterThan(ref p4, ref p6)) { temp = p4; p4 = p6; p6 = temp; }
			if (GreaterThan(ref p4, ref p5)) { temp = p4; p4 = p5; p5 = temp; }
			if (GreaterThan(ref p0, ref p4)) { temp = p0; p0 = p4; p4 = temp; }
			if (GreaterThan(ref p0, ref p3)) { temp = p0; p0 = p3; p3 = temp; }
			if (GreaterThan(ref p1, ref p5)) { temp = p1; p1 = p5; p5 = temp; }
			if (GreaterThan(ref p2, ref p6)) { temp = p2; p2 = p6; p6 = temp; }
			if (GreaterThan(ref p2, ref p5)) { temp = p2; p2 = p5; p5 = temp; }
			if (GreaterThan(ref p1, ref p3)) { temp = p1; p1 = p3; p3 = temp; }
			if (GreaterThan(ref p2, ref p4)) { temp = p2; p2 = p4; p4 = temp; }
			if (GreaterThan(ref p2, ref p3)) { temp = p2; p2 = p3; p3 = temp; }
#endif
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
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);
			ref var p5 = ref Unsafe.Add(ref p0, 5);
			ref var p6 = ref Unsafe.Add(ref p0, 6);
			ref var p7 = ref Unsafe.Add(ref p0, 7);

			T temp;
#if NETSTANDARD1_3
			if (p0.CompareTo(p1) > 0) { temp = p0; p0 = p1; p1 = temp; }
			if (p2.CompareTo(p3) > 0) { temp = p2; p2 = p3; p3 = temp; }
			if (p0.CompareTo(p2) > 0) { temp = p0; p0 = p2; p2 = temp; }
			if (p1.CompareTo(p3) > 0) { temp = p1; p1 = p3; p3 = temp; }
			if (p1.CompareTo(p2) > 0) { temp = p1; p1 = p2; p2 = temp; }
			if (p4.CompareTo(p5) > 0) { temp = p4; p4 = p5; p5 = temp; }
			if (p6.CompareTo(p7) > 0) { temp = p6; p6 = p7; p7 = temp; }
			if (p4.CompareTo(p6) > 0) { temp = p4; p4 = p6; p6 = temp; }
			if (p5.CompareTo(p7) > 0) { temp = p5; p5 = p7; p7 = temp; }
			if (p5.CompareTo(p6) > 0) { temp = p5; p5 = p6; p6 = temp; }
			if (p0.CompareTo(p4) > 0) { temp = p0; p0 = p4; p4 = temp; }
			if (p1.CompareTo(p5) > 0) { temp = p1; p1 = p5; p5 = temp; }
			if (p1.CompareTo(p4) > 0) { temp = p1; p1 = p4; p4 = temp; }
			if (p2.CompareTo(p6) > 0) { temp = p2; p2 = p6; p6 = temp; }
			if (p3.CompareTo(p7) > 0) { temp = p3; p3 = p7; p7 = temp; }
			if (p3.CompareTo(p6) > 0) { temp = p3; p3 = p6; p6 = temp; }
			if (p2.CompareTo(p4) > 0) { temp = p2; p2 = p4; p4 = temp; }
			if (p3.CompareTo(p5) > 0) { temp = p3; p3 = p5; p5 = temp; }
			if (p3.CompareTo(p4) > 0) { temp = p3; p3 = p4; p4 = temp; }
#else
			if (GreaterThan(ref p0, ref p1)) { temp = p0; p0 = p1; p1 = temp; }
			if (GreaterThan(ref p2, ref p3)) { temp = p2; p2 = p3; p3 = temp; }
			if (GreaterThan(ref p0, ref p2)) { temp = p0; p0 = p2; p2 = temp; }
			if (GreaterThan(ref p1, ref p3)) { temp = p1; p1 = p3; p3 = temp; }
			if (GreaterThan(ref p1, ref p2)) { temp = p1; p1 = p2; p2 = temp; }
			if (GreaterThan(ref p4, ref p5)) { temp = p4; p4 = p5; p5 = temp; }
			if (GreaterThan(ref p6, ref p7)) { temp = p6; p6 = p7; p7 = temp; }
			if (GreaterThan(ref p4, ref p6)) { temp = p4; p4 = p6; p6 = temp; }
			if (GreaterThan(ref p5, ref p7)) { temp = p5; p5 = p7; p7 = temp; }
			if (GreaterThan(ref p5, ref p6)) { temp = p5; p5 = p6; p6 = temp; }
			if (GreaterThan(ref p0, ref p4)) { temp = p0; p0 = p4; p4 = temp; }
			if (GreaterThan(ref p1, ref p5)) { temp = p1; p1 = p5; p5 = temp; }
			if (GreaterThan(ref p1, ref p4)) { temp = p1; p1 = p4; p4 = temp; }
			if (GreaterThan(ref p2, ref p6)) { temp = p2; p2 = p6; p6 = temp; }
			if (GreaterThan(ref p3, ref p7)) { temp = p3; p3 = p7; p7 = temp; }
			if (GreaterThan(ref p3, ref p6)) { temp = p3; p3 = p6; p6 = temp; }
			if (GreaterThan(ref p2, ref p4)) { temp = p2; p2 = p4; p4 = temp; }
			if (GreaterThan(ref p3, ref p5)) { temp = p3; p3 = p5; p5 = temp; }
			if (GreaterThan(ref p3, ref p4)) { temp = p3; p3 = p4; p4 = temp; }
#endif
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
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);
			ref var p5 = ref Unsafe.Add(ref p0, 5);
			ref var p6 = ref Unsafe.Add(ref p0, 6);
			ref var p7 = ref Unsafe.Add(ref p0, 7);
			ref var p8 = ref Unsafe.Add(ref p0, 8);

			T temp;
#if NETSTANDARD1_3
			if (p0.CompareTo(p1) > 0) { temp = p0; p0 = p1; p1 = temp; }
			if (p2.CompareTo(p3) > 0) { temp = p2; p2 = p3; p3 = temp; }
			if (p0.CompareTo(p2) > 0) { temp = p0; p0 = p2; p2 = temp; }
			if (p1.CompareTo(p3) > 0) { temp = p1; p1 = p3; p3 = temp; }
			if (p1.CompareTo(p2) > 0) { temp = p1; p1 = p2; p2 = temp; }
			if (p4.CompareTo(p5) > 0) { temp = p4; p4 = p5; p5 = temp; }
			if (p7.CompareTo(p8) > 0) { temp = p7; p7 = p8; p8 = temp; }
			if (p6.CompareTo(p8) > 0) { temp = p6; p6 = p8; p8 = temp; }
			if (p6.CompareTo(p7) > 0) { temp = p6; p6 = p7; p7 = temp; }
			if (p4.CompareTo(p7) > 0) { temp = p4; p4 = p7; p7 = temp; }
			if (p4.CompareTo(p6) > 0) { temp = p4; p4 = p6; p6 = temp; }
			if (p5.CompareTo(p8) > 0) { temp = p5; p5 = p8; p8 = temp; }
			if (p5.CompareTo(p7) > 0) { temp = p5; p5 = p7; p7 = temp; }
			if (p5.CompareTo(p6) > 0) { temp = p5; p5 = p6; p6 = temp; }
			if (p0.CompareTo(p5) > 0) { temp = p0; p0 = p5; p5 = temp; }
			if (p0.CompareTo(p4) > 0) { temp = p0; p0 = p4; p4 = temp; }
			if (p1.CompareTo(p6) > 0) { temp = p1; p1 = p6; p6 = temp; }
			if (p1.CompareTo(p5) > 0) { temp = p1; p1 = p5; p5 = temp; }
			if (p1.CompareTo(p4) > 0) { temp = p1; p1 = p4; p4 = temp; }
			if (p2.CompareTo(p7) > 0) { temp = p2; p2 = p7; p7 = temp; }
			if (p3.CompareTo(p8) > 0) { temp = p3; p3 = p8; p8 = temp; }
			if (p3.CompareTo(p7) > 0) { temp = p3; p3 = p7; p7 = temp; }
			if (p2.CompareTo(p5) > 0) { temp = p2; p2 = p5; p5 = temp; }
			if (p2.CompareTo(p4) > 0) { temp = p2; p2 = p4; p4 = temp; }
			if (p3.CompareTo(p6) > 0) { temp = p3; p3 = p6; p6 = temp; }
			if (p3.CompareTo(p5) > 0) { temp = p3; p3 = p5; p5 = temp; }
			if (p3.CompareTo(p4) > 0) { temp = p3; p3 = p4; p4 = temp; }
#else
			if (GreaterThan(ref p0, ref p1)) { temp = p0; p0 = p1; p1 = temp; }
			if (GreaterThan(ref p2, ref p3)) { temp = p2; p2 = p3; p3 = temp; }
			if (GreaterThan(ref p0, ref p2)) { temp = p0; p0 = p2; p2 = temp; }
			if (GreaterThan(ref p1, ref p3)) { temp = p1; p1 = p3; p3 = temp; }
			if (GreaterThan(ref p1, ref p2)) { temp = p1; p1 = p2; p2 = temp; }
			if (GreaterThan(ref p4, ref p5)) { temp = p4; p4 = p5; p5 = temp; }
			if (GreaterThan(ref p7, ref p8)) { temp = p7; p7 = p8; p8 = temp; }
			if (GreaterThan(ref p6, ref p8)) { temp = p6; p6 = p8; p8 = temp; }
			if (GreaterThan(ref p6, ref p7)) { temp = p6; p6 = p7; p7 = temp; }
			if (GreaterThan(ref p4, ref p7)) { temp = p4; p4 = p7; p7 = temp; }
			if (GreaterThan(ref p4, ref p6)) { temp = p4; p4 = p6; p6 = temp; }
			if (GreaterThan(ref p5, ref p8)) { temp = p5; p5 = p8; p8 = temp; }
			if (GreaterThan(ref p5, ref p7)) { temp = p5; p5 = p7; p7 = temp; }
			if (GreaterThan(ref p5, ref p6)) { temp = p5; p5 = p6; p6 = temp; }
			if (GreaterThan(ref p0, ref p5)) { temp = p0; p0 = p5; p5 = temp; }
			if (GreaterThan(ref p0, ref p4)) { temp = p0; p0 = p4; p4 = temp; }
			if (GreaterThan(ref p1, ref p6)) { temp = p1; p1 = p6; p6 = temp; }
			if (GreaterThan(ref p1, ref p5)) { temp = p1; p1 = p5; p5 = temp; }
			if (GreaterThan(ref p1, ref p4)) { temp = p1; p1 = p4; p4 = temp; }
			if (GreaterThan(ref p2, ref p7)) { temp = p2; p2 = p7; p7 = temp; }
			if (GreaterThan(ref p3, ref p8)) { temp = p3; p3 = p8; p8 = temp; }
			if (GreaterThan(ref p3, ref p7)) { temp = p3; p3 = p7; p7 = temp; }
			if (GreaterThan(ref p2, ref p5)) { temp = p2; p2 = p5; p5 = temp; }
			if (GreaterThan(ref p2, ref p4)) { temp = p2; p2 = p4; p4 = temp; }
			if (GreaterThan(ref p3, ref p6)) { temp = p3; p3 = p6; p6 = temp; }
			if (GreaterThan(ref p3, ref p5)) { temp = p3; p3 = p5; p5 = temp; }
			if (GreaterThan(ref p3, ref p4)) { temp = p3; p3 = p4; p4 = temp; }
#endif
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
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);
			ref var p5 = ref Unsafe.Add(ref p0, 5);
			ref var p6 = ref Unsafe.Add(ref p0, 6);
			ref var p7 = ref Unsafe.Add(ref p0, 7);
			ref var p8 = ref Unsafe.Add(ref p0, 8);
			ref var p9 = ref Unsafe.Add(ref p0, 9);

			T temp;
#if NETSTANDARD1_3
			if (p0.CompareTo(p1) > 0) { temp = p0; p0 = p1; p1 = temp; }
			if (p3.CompareTo(p4) > 0) { temp = p3; p3 = p4; p4 = temp; }
			if (p2.CompareTo(p4) > 0) { temp = p2; p2 = p4; p4 = temp; }
			if (p2.CompareTo(p3) > 0) { temp = p2; p2 = p3; p3 = temp; }
			if (p0.CompareTo(p3) > 0) { temp = p0; p0 = p3; p3 = temp; }
			if (p0.CompareTo(p2) > 0) { temp = p0; p0 = p2; p2 = temp; }
			if (p1.CompareTo(p4) > 0) { temp = p1; p1 = p4; p4 = temp; }
			if (p1.CompareTo(p3) > 0) { temp = p1; p1 = p3; p3 = temp; }
			if (p1.CompareTo(p2) > 0) { temp = p1; p1 = p2; p2 = temp; }
			if (p5.CompareTo(p6) > 0) { temp = p5; p5 = p6; p6 = temp; }
			if (p8.CompareTo(p9) > 0) { temp = p8; p8 = p9; p9 = temp; }
			if (p7.CompareTo(p9) > 0) { temp = p7; p7 = p9; p9 = temp; }
			if (p7.CompareTo(p8) > 0) { temp = p7; p7 = p8; p8 = temp; }
			if (p5.CompareTo(p8) > 0) { temp = p5; p5 = p8; p8 = temp; }
			if (p5.CompareTo(p7) > 0) { temp = p5; p5 = p7; p7 = temp; }
			if (p6.CompareTo(p9) > 0) { temp = p6; p6 = p9; p9 = temp; }
			if (p6.CompareTo(p8) > 0) { temp = p6; p6 = p8; p8 = temp; }
			if (p6.CompareTo(p7) > 0) { temp = p6; p6 = p7; p7 = temp; }
			if (p0.CompareTo(p6) > 0) { temp = p0; p0 = p6; p6 = temp; }
			if (p0.CompareTo(p5) > 0) { temp = p0; p0 = p5; p5 = temp; }
			if (p1.CompareTo(p7) > 0) { temp = p1; p1 = p7; p7 = temp; }
			if (p1.CompareTo(p6) > 0) { temp = p1; p1 = p6; p6 = temp; }
			if (p1.CompareTo(p5) > 0) { temp = p1; p1 = p5; p5 = temp; }
			if (p2.CompareTo(p8) > 0) { temp = p2; p2 = p8; p8 = temp; }
			if (p3.CompareTo(p9) > 0) { temp = p3; p3 = p9; p9 = temp; }
			if (p4.CompareTo(p9) > 0) { temp = p4; p4 = p9; p9 = temp; }
			if (p3.CompareTo(p8) > 0) { temp = p3; p3 = p8; p8 = temp; }
			if (p4.CompareTo(p8) > 0) { temp = p4; p4 = p8; p8 = temp; }
			if (p2.CompareTo(p6) > 0) { temp = p2; p2 = p6; p6 = temp; }
			if (p2.CompareTo(p5) > 0) { temp = p2; p2 = p5; p5 = temp; }
			if (p3.CompareTo(p7) > 0) { temp = p3; p3 = p7; p7 = temp; }
			if (p4.CompareTo(p7) > 0) { temp = p4; p4 = p7; p7 = temp; }
			if (p3.CompareTo(p5) > 0) { temp = p3; p3 = p5; p5 = temp; }
			if (p4.CompareTo(p6) > 0) { temp = p4; p4 = p6; p6 = temp; }
			if (p4.CompareTo(p5) > 0) { temp = p4; p4 = p5; p5 = temp; }
#else
			if (GreaterThan(ref p0, ref p1)) { temp = p0; p0 = p1; p1 = temp; }
			if (GreaterThan(ref p3, ref p4)) { temp = p3; p3 = p4; p4 = temp; }
			if (GreaterThan(ref p2, ref p4)) { temp = p2; p2 = p4; p4 = temp; }
			if (GreaterThan(ref p2, ref p3)) { temp = p2; p2 = p3; p3 = temp; }
			if (GreaterThan(ref p0, ref p3)) { temp = p0; p0 = p3; p3 = temp; }
			if (GreaterThan(ref p0, ref p2)) { temp = p0; p0 = p2; p2 = temp; }
			if (GreaterThan(ref p1, ref p4)) { temp = p1; p1 = p4; p4 = temp; }
			if (GreaterThan(ref p1, ref p3)) { temp = p1; p1 = p3; p3 = temp; }
			if (GreaterThan(ref p1, ref p2)) { temp = p1; p1 = p2; p2 = temp; }
			if (GreaterThan(ref p5, ref p6)) { temp = p5; p5 = p6; p6 = temp; }
			if (GreaterThan(ref p8, ref p9)) { temp = p8; p8 = p9; p9 = temp; }
			if (GreaterThan(ref p7, ref p9)) { temp = p7; p7 = p9; p9 = temp; }
			if (GreaterThan(ref p7, ref p8)) { temp = p7; p7 = p8; p8 = temp; }
			if (GreaterThan(ref p5, ref p8)) { temp = p5; p5 = p8; p8 = temp; }
			if (GreaterThan(ref p5, ref p7)) { temp = p5; p5 = p7; p7 = temp; }
			if (GreaterThan(ref p6, ref p9)) { temp = p6; p6 = p9; p9 = temp; }
			if (GreaterThan(ref p6, ref p8)) { temp = p6; p6 = p8; p8 = temp; }
			if (GreaterThan(ref p6, ref p7)) { temp = p6; p6 = p7; p7 = temp; }
			if (GreaterThan(ref p0, ref p6)) { temp = p0; p0 = p6; p6 = temp; }
			if (GreaterThan(ref p0, ref p5)) { temp = p0; p0 = p5; p5 = temp; }
			if (GreaterThan(ref p1, ref p7)) { temp = p1; p1 = p7; p7 = temp; }
			if (GreaterThan(ref p1, ref p6)) { temp = p1; p1 = p6; p6 = temp; }
			if (GreaterThan(ref p1, ref p5)) { temp = p1; p1 = p5; p5 = temp; }
			if (GreaterThan(ref p2, ref p8)) { temp = p2; p2 = p8; p8 = temp; }
			if (GreaterThan(ref p3, ref p9)) { temp = p3; p3 = p9; p9 = temp; }
			if (GreaterThan(ref p4, ref p9)) { temp = p4; p4 = p9; p9 = temp; }
			if (GreaterThan(ref p3, ref p8)) { temp = p3; p3 = p8; p8 = temp; }
			if (GreaterThan(ref p4, ref p8)) { temp = p4; p4 = p8; p8 = temp; }
			if (GreaterThan(ref p2, ref p6)) { temp = p2; p2 = p6; p6 = temp; }
			if (GreaterThan(ref p2, ref p5)) { temp = p2; p2 = p5; p5 = temp; }
			if (GreaterThan(ref p3, ref p7)) { temp = p3; p3 = p7; p7 = temp; }
			if (GreaterThan(ref p4, ref p7)) { temp = p4; p4 = p7; p7 = temp; }
			if (GreaterThan(ref p3, ref p5)) { temp = p3; p3 = p5; p5 = temp; }
			if (GreaterThan(ref p4, ref p6)) { temp = p4; p4 = p6; p6 = temp; }
			if (GreaterThan(ref p4, ref p5)) { temp = p4; p4 = p5; p5 = temp; }
#endif
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
#if NETSTANDARD1_3
			if (p0.CompareTo(p1) > 0) { temp = p0; p0 = p1; p1 = temp; }
			if (p3.CompareTo(p4) > 0) { temp = p3; p3 = p4; p4 = temp; }
			if (p2.CompareTo(p4) > 0) { temp = p2; p2 = p4; p4 = temp; }
			if (p2.CompareTo(p3) > 0) { temp = p2; p2 = p3; p3 = temp; }
			if (p0.CompareTo(p3) > 0) { temp = p0; p0 = p3; p3 = temp; }
			if (p0.CompareTo(p2) > 0) { temp = p0; p0 = p2; p2 = temp; }
			if (p1.CompareTo(p4) > 0) { temp = p1; p1 = p4; p4 = temp; }
			if (p1.CompareTo(p3) > 0) { temp = p1; p1 = p3; p3 = temp; }
			if (p1.CompareTo(p2) > 0) { temp = p1; p1 = p2; p2 = temp; }
			if (p6.CompareTo(p7) > 0) { temp = p6; p6 = p7; p7 = temp; }
			if (p5.CompareTo(p7) > 0) { temp = p5; p5 = p7; p7 = temp; }
			if (p5.CompareTo(p6) > 0) { temp = p5; p5 = p6; p6 = temp; }
			if (p9.CompareTo(p10) > 0) { temp = p9; p9 = p10; p10 = temp; }
			if (p8.CompareTo(p10) > 0) { temp = p8; p8 = p10; p10 = temp; }
			if (p8.CompareTo(p9) > 0) { temp = p8; p8 = p9; p9 = temp; }
			if (p5.CompareTo(p9) > 0) { temp = p5; p5 = p9; p9 = temp; }
			if (p5.CompareTo(p8) > 0) { temp = p5; p5 = p8; p8 = temp; }
			if (p6.CompareTo(p10) > 0) { temp = p6; p6 = p10; p10 = temp; }
			if (p7.CompareTo(p10) > 0) { temp = p7; p7 = p10; p10 = temp; }
			if (p6.CompareTo(p8) > 0) { temp = p6; p6 = p8; p8 = temp; }
			if (p7.CompareTo(p9) > 0) { temp = p7; p7 = p9; p9 = temp; }
			if (p7.CompareTo(p8) > 0) { temp = p7; p7 = p8; p8 = temp; }
			if (p0.CompareTo(p6) > 0) { temp = p0; p0 = p6; p6 = temp; }
			if (p0.CompareTo(p5) > 0) { temp = p0; p0 = p5; p5 = temp; }
			if (p1.CompareTo(p7) > 0) { temp = p1; p1 = p7; p7 = temp; }
			if (p1.CompareTo(p6) > 0) { temp = p1; p1 = p6; p6 = temp; }
			if (p1.CompareTo(p5) > 0) { temp = p1; p1 = p5; p5 = temp; }
			if (p2.CompareTo(p9) > 0) { temp = p2; p2 = p9; p9 = temp; }
			if (p2.CompareTo(p8) > 0) { temp = p2; p2 = p8; p8 = temp; }
			if (p3.CompareTo(p10) > 0) { temp = p3; p3 = p10; p10 = temp; }
			if (p4.CompareTo(p10) > 0) { temp = p4; p4 = p10; p10 = temp; }
			if (p3.CompareTo(p8) > 0) { temp = p3; p3 = p8; p8 = temp; }
			if (p4.CompareTo(p9) > 0) { temp = p4; p4 = p9; p9 = temp; }
			if (p4.CompareTo(p8) > 0) { temp = p4; p4 = p8; p8 = temp; }
			if (p2.CompareTo(p6) > 0) { temp = p2; p2 = p6; p6 = temp; }
			if (p2.CompareTo(p5) > 0) { temp = p2; p2 = p5; p5 = temp; }
			if (p3.CompareTo(p7) > 0) { temp = p3; p3 = p7; p7 = temp; }
			if (p4.CompareTo(p7) > 0) { temp = p4; p4 = p7; p7 = temp; }
			if (p3.CompareTo(p5) > 0) { temp = p3; p3 = p5; p5 = temp; }
			if (p4.CompareTo(p6) > 0) { temp = p4; p4 = p6; p6 = temp; }
			if (p4.CompareTo(p5) > 0) { temp = p4; p4 = p5; p5 = temp; }
#else
			if (GreaterThan(ref p0, ref p1)) { temp = p0; p0 = p1; p1 = temp; }
			if (GreaterThan(ref p3, ref p4)) { temp = p3; p3 = p4; p4 = temp; }
			if (GreaterThan(ref p2, ref p4)) { temp = p2; p2 = p4; p4 = temp; }
			if (GreaterThan(ref p2, ref p3)) { temp = p2; p2 = p3; p3 = temp; }
			if (GreaterThan(ref p0, ref p3)) { temp = p0; p0 = p3; p3 = temp; }
			if (GreaterThan(ref p0, ref p2)) { temp = p0; p0 = p2; p2 = temp; }
			if (GreaterThan(ref p1, ref p4)) { temp = p1; p1 = p4; p4 = temp; }
			if (GreaterThan(ref p1, ref p3)) { temp = p1; p1 = p3; p3 = temp; }
			if (GreaterThan(ref p1, ref p2)) { temp = p1; p1 = p2; p2 = temp; }
			if (GreaterThan(ref p6, ref p7)) { temp = p6; p6 = p7; p7 = temp; }
			if (GreaterThan(ref p5, ref p7)) { temp = p5; p5 = p7; p7 = temp; }
			if (GreaterThan(ref p5, ref p6)) { temp = p5; p5 = p6; p6 = temp; }
			if (GreaterThan(ref p9, ref p10)) { temp = p9; p9 = p10; p10 = temp; }
			if (GreaterThan(ref p8, ref p10)) { temp = p8; p8 = p10; p10 = temp; }
			if (GreaterThan(ref p8, ref p9)) { temp = p8; p8 = p9; p9 = temp; }
			if (GreaterThan(ref p5, ref p9)) { temp = p5; p5 = p9; p9 = temp; }
			if (GreaterThan(ref p5, ref p8)) { temp = p5; p5 = p8; p8 = temp; }
			if (GreaterThan(ref p6, ref p10)) { temp = p6; p6 = p10; p10 = temp; }
			if (GreaterThan(ref p7, ref p10)) { temp = p7; p7 = p10; p10 = temp; }
			if (GreaterThan(ref p6, ref p8)) { temp = p6; p6 = p8; p8 = temp; }
			if (GreaterThan(ref p7, ref p9)) { temp = p7; p7 = p9; p9 = temp; }
			if (GreaterThan(ref p7, ref p8)) { temp = p7; p7 = p8; p8 = temp; }
			if (GreaterThan(ref p0, ref p6)) { temp = p0; p0 = p6; p6 = temp; }
			if (GreaterThan(ref p0, ref p5)) { temp = p0; p0 = p5; p5 = temp; }
			if (GreaterThan(ref p1, ref p7)) { temp = p1; p1 = p7; p7 = temp; }
			if (GreaterThan(ref p1, ref p6)) { temp = p1; p1 = p6; p6 = temp; }
			if (GreaterThan(ref p1, ref p5)) { temp = p1; p1 = p5; p5 = temp; }
			if (GreaterThan(ref p2, ref p9)) { temp = p2; p2 = p9; p9 = temp; }
			if (GreaterThan(ref p2, ref p8)) { temp = p2; p2 = p8; p8 = temp; }
			if (GreaterThan(ref p3, ref p10)) { temp = p3; p3 = p10; p10 = temp; }
			if (GreaterThan(ref p4, ref p10)) { temp = p4; p4 = p10; p10 = temp; }
			if (GreaterThan(ref p3, ref p8)) { temp = p3; p3 = p8; p8 = temp; }
			if (GreaterThan(ref p4, ref p9)) { temp = p4; p4 = p9; p9 = temp; }
			if (GreaterThan(ref p4, ref p8)) { temp = p4; p4 = p8; p8 = temp; }
			if (GreaterThan(ref p2, ref p6)) { temp = p2; p2 = p6; p6 = temp; }
			if (GreaterThan(ref p2, ref p5)) { temp = p2; p2 = p5; p5 = temp; }
			if (GreaterThan(ref p3, ref p7)) { temp = p3; p3 = p7; p7 = temp; }
			if (GreaterThan(ref p4, ref p7)) { temp = p4; p4 = p7; p7 = temp; }
			if (GreaterThan(ref p3, ref p5)) { temp = p3; p3 = p5; p5 = temp; }
			if (GreaterThan(ref p4, ref p6)) { temp = p4; p4 = p6; p6 = temp; }
			if (GreaterThan(ref p4, ref p5)) { temp = p4; p4 = p5; p5 = temp; }
#endif
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
#if NETSTANDARD1_3
			if (p1.CompareTo(p2) > 0) { temp = p1; p1 = p2; p2 = temp; }
			if (p0.CompareTo(p2) > 0) { temp = p0; p0 = p2; p2 = temp; }
			if (p0.CompareTo(p1) > 0) { temp = p0; p0 = p1; p1 = temp; }
			if (p4.CompareTo(p5) > 0) { temp = p4; p4 = p5; p5 = temp; }
			if (p3.CompareTo(p5) > 0) { temp = p3; p3 = p5; p5 = temp; }
			if (p3.CompareTo(p4) > 0) { temp = p3; p3 = p4; p4 = temp; }
			if (p0.CompareTo(p4) > 0) { temp = p0; p0 = p4; p4 = temp; }
			if (p0.CompareTo(p3) > 0) { temp = p0; p0 = p3; p3 = temp; }
			if (p1.CompareTo(p5) > 0) { temp = p1; p1 = p5; p5 = temp; }
			if (p2.CompareTo(p5) > 0) { temp = p2; p2 = p5; p5 = temp; }
			if (p1.CompareTo(p3) > 0) { temp = p1; p1 = p3; p3 = temp; }
			if (p2.CompareTo(p4) > 0) { temp = p2; p2 = p4; p4 = temp; }
			if (p2.CompareTo(p3) > 0) { temp = p2; p2 = p3; p3 = temp; }
			if (p7.CompareTo(p8) > 0) { temp = p7; p7 = p8; p8 = temp; }
			if (p6.CompareTo(p8) > 0) { temp = p6; p6 = p8; p8 = temp; }
			if (p6.CompareTo(p7) > 0) { temp = p6; p6 = p7; p7 = temp; }
			if (p10.CompareTo(p11) > 0) { temp = p10; p10 = p11; p11 = temp; }
			if (p9.CompareTo(p11) > 0) { temp = p9; p9 = p11; p11 = temp; }
			if (p9.CompareTo(p10) > 0) { temp = p9; p9 = p10; p10 = temp; }
			if (p6.CompareTo(p10) > 0) { temp = p6; p6 = p10; p10 = temp; }
			if (p6.CompareTo(p9) > 0) { temp = p6; p6 = p9; p9 = temp; }
			if (p7.CompareTo(p11) > 0) { temp = p7; p7 = p11; p11 = temp; }
			if (p8.CompareTo(p11) > 0) { temp = p8; p8 = p11; p11 = temp; }
			if (p7.CompareTo(p9) > 0) { temp = p7; p7 = p9; p9 = temp; }
			if (p8.CompareTo(p10) > 0) { temp = p8; p8 = p10; p10 = temp; }
			if (p8.CompareTo(p9) > 0) { temp = p8; p8 = p9; p9 = temp; }
			if (p0.CompareTo(p7) > 0) { temp = p0; p0 = p7; p7 = temp; }
			if (p0.CompareTo(p6) > 0) { temp = p0; p0 = p6; p6 = temp; }
			if (p1.CompareTo(p8) > 0) { temp = p1; p1 = p8; p8 = temp; }
			if (p2.CompareTo(p8) > 0) { temp = p2; p2 = p8; p8 = temp; }
			if (p1.CompareTo(p6) > 0) { temp = p1; p1 = p6; p6 = temp; }
			if (p2.CompareTo(p7) > 0) { temp = p2; p2 = p7; p7 = temp; }
			if (p2.CompareTo(p6) > 0) { temp = p2; p2 = p6; p6 = temp; }
			if (p3.CompareTo(p10) > 0) { temp = p3; p3 = p10; p10 = temp; }
			if (p3.CompareTo(p9) > 0) { temp = p3; p3 = p9; p9 = temp; }
			if (p4.CompareTo(p11) > 0) { temp = p4; p4 = p11; p11 = temp; }
			if (p5.CompareTo(p11) > 0) { temp = p5; p5 = p11; p11 = temp; }
			if (p4.CompareTo(p9) > 0) { temp = p4; p4 = p9; p9 = temp; }
			if (p5.CompareTo(p10) > 0) { temp = p5; p5 = p10; p10 = temp; }
			if (p5.CompareTo(p9) > 0) { temp = p5; p5 = p9; p9 = temp; }
			if (p3.CompareTo(p7) > 0) { temp = p3; p3 = p7; p7 = temp; }
			if (p3.CompareTo(p6) > 0) { temp = p3; p3 = p6; p6 = temp; }
			if (p4.CompareTo(p8) > 0) { temp = p4; p4 = p8; p8 = temp; }
			if (p5.CompareTo(p8) > 0) { temp = p5; p5 = p8; p8 = temp; }
			if (p4.CompareTo(p6) > 0) { temp = p4; p4 = p6; p6 = temp; }
			if (p5.CompareTo(p7) > 0) { temp = p5; p5 = p7; p7 = temp; }
			if (p5.CompareTo(p6) > 0) { temp = p5; p5 = p6; p6 = temp; }
#else
			if (GreaterThan(ref p1, ref p2)) { temp = p1; p1 = p2; p2 = temp; }
			if (GreaterThan(ref p0, ref p2)) { temp = p0; p0 = p2; p2 = temp; }
			if (GreaterThan(ref p0, ref p1)) { temp = p0; p0 = p1; p1 = temp; }
			if (GreaterThan(ref p4, ref p5)) { temp = p4; p4 = p5; p5 = temp; }
			if (GreaterThan(ref p3, ref p5)) { temp = p3; p3 = p5; p5 = temp; }
			if (GreaterThan(ref p3, ref p4)) { temp = p3; p3 = p4; p4 = temp; }
			if (GreaterThan(ref p0, ref p4)) { temp = p0; p0 = p4; p4 = temp; }
			if (GreaterThan(ref p0, ref p3)) { temp = p0; p0 = p3; p3 = temp; }
			if (GreaterThan(ref p1, ref p5)) { temp = p1; p1 = p5; p5 = temp; }
			if (GreaterThan(ref p2, ref p5)) { temp = p2; p2 = p5; p5 = temp; }
			if (GreaterThan(ref p1, ref p3)) { temp = p1; p1 = p3; p3 = temp; }
			if (GreaterThan(ref p2, ref p4)) { temp = p2; p2 = p4; p4 = temp; }
			if (GreaterThan(ref p2, ref p3)) { temp = p2; p2 = p3; p3 = temp; }
			if (GreaterThan(ref p7, ref p8)) { temp = p7; p7 = p8; p8 = temp; }
			if (GreaterThan(ref p6, ref p8)) { temp = p6; p6 = p8; p8 = temp; }
			if (GreaterThan(ref p6, ref p7)) { temp = p6; p6 = p7; p7 = temp; }
			if (GreaterThan(ref p10, ref p11)) { temp = p10; p10 = p11; p11 = temp; }
			if (GreaterThan(ref p9, ref p11)) { temp = p9; p9 = p11; p11 = temp; }
			if (GreaterThan(ref p9, ref p10)) { temp = p9; p9 = p10; p10 = temp; }
			if (GreaterThan(ref p6, ref p10)) { temp = p6; p6 = p10; p10 = temp; }
			if (GreaterThan(ref p6, ref p9)) { temp = p6; p6 = p9; p9 = temp; }
			if (GreaterThan(ref p7, ref p11)) { temp = p7; p7 = p11; p11 = temp; }
			if (GreaterThan(ref p8, ref p11)) { temp = p8; p8 = p11; p11 = temp; }
			if (GreaterThan(ref p7, ref p9)) { temp = p7; p7 = p9; p9 = temp; }
			if (GreaterThan(ref p8, ref p10)) { temp = p8; p8 = p10; p10 = temp; }
			if (GreaterThan(ref p8, ref p9)) { temp = p8; p8 = p9; p9 = temp; }
			if (GreaterThan(ref p0, ref p7)) { temp = p0; p0 = p7; p7 = temp; }
			if (GreaterThan(ref p0, ref p6)) { temp = p0; p0 = p6; p6 = temp; }
			if (GreaterThan(ref p1, ref p8)) { temp = p1; p1 = p8; p8 = temp; }
			if (GreaterThan(ref p2, ref p8)) { temp = p2; p2 = p8; p8 = temp; }
			if (GreaterThan(ref p1, ref p6)) { temp = p1; p1 = p6; p6 = temp; }
			if (GreaterThan(ref p2, ref p7)) { temp = p2; p2 = p7; p7 = temp; }
			if (GreaterThan(ref p2, ref p6)) { temp = p2; p2 = p6; p6 = temp; }
			if (GreaterThan(ref p3, ref p10)) { temp = p3; p3 = p10; p10 = temp; }
			if (GreaterThan(ref p3, ref p9)) { temp = p3; p3 = p9; p9 = temp; }
			if (GreaterThan(ref p4, ref p11)) { temp = p4; p4 = p11; p11 = temp; }
			if (GreaterThan(ref p5, ref p11)) { temp = p5; p5 = p11; p11 = temp; }
			if (GreaterThan(ref p4, ref p9)) { temp = p4; p4 = p9; p9 = temp; }
			if (GreaterThan(ref p5, ref p10)) { temp = p5; p5 = p10; p10 = temp; }
			if (GreaterThan(ref p5, ref p9)) { temp = p5; p5 = p9; p9 = temp; }
			if (GreaterThan(ref p3, ref p7)) { temp = p3; p3 = p7; p7 = temp; }
			if (GreaterThan(ref p3, ref p6)) { temp = p3; p3 = p6; p6 = temp; }
			if (GreaterThan(ref p4, ref p8)) { temp = p4; p4 = p8; p8 = temp; }
			if (GreaterThan(ref p5, ref p8)) { temp = p5; p5 = p8; p8 = temp; }
			if (GreaterThan(ref p4, ref p6)) { temp = p4; p4 = p6; p6 = temp; }
			if (GreaterThan(ref p5, ref p7)) { temp = p5; p5 = p7; p7 = temp; }
			if (GreaterThan(ref p5, ref p6)) { temp = p5; p5 = p6; p6 = temp; }
#endif
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
#if NETSTANDARD1_3
			if (p1.CompareTo(p2) > 0) { temp = p1; p1 = p2; p2 = temp; }
			if (p0.CompareTo(p2) > 0) { temp = p0; p0 = p2; p2 = temp; }
			if (p0.CompareTo(p1) > 0) { temp = p0; p0 = p1; p1 = temp; }
			if (p4.CompareTo(p5) > 0) { temp = p4; p4 = p5; p5 = temp; }
			if (p3.CompareTo(p5) > 0) { temp = p3; p3 = p5; p5 = temp; }
			if (p3.CompareTo(p4) > 0) { temp = p3; p3 = p4; p4 = temp; }
			if (p0.CompareTo(p4) > 0) { temp = p0; p0 = p4; p4 = temp; }
			if (p0.CompareTo(p3) > 0) { temp = p0; p0 = p3; p3 = temp; }
			if (p1.CompareTo(p5) > 0) { temp = p1; p1 = p5; p5 = temp; }
			if (p2.CompareTo(p5) > 0) { temp = p2; p2 = p5; p5 = temp; }
			if (p1.CompareTo(p3) > 0) { temp = p1; p1 = p3; p3 = temp; }
			if (p2.CompareTo(p4) > 0) { temp = p2; p2 = p4; p4 = temp; }
			if (p2.CompareTo(p3) > 0) { temp = p2; p2 = p3; p3 = temp; }
			if (p7.CompareTo(p8) > 0) { temp = p7; p7 = p8; p8 = temp; }
			if (p6.CompareTo(p8) > 0) { temp = p6; p6 = p8; p8 = temp; }
			if (p6.CompareTo(p7) > 0) { temp = p6; p6 = p7; p7 = temp; }
			if (p9.CompareTo(p10) > 0) { temp = p9; p9 = p10; p10 = temp; }
			if (p11.CompareTo(p12) > 0) { temp = p11; p11 = p12; p12 = temp; }
			if (p9.CompareTo(p11) > 0) { temp = p9; p9 = p11; p11 = temp; }
			if (p10.CompareTo(p12) > 0) { temp = p10; p10 = p12; p12 = temp; }
			if (p10.CompareTo(p11) > 0) { temp = p10; p10 = p11; p11 = temp; }
			if (p6.CompareTo(p10) > 0) { temp = p6; p6 = p10; p10 = temp; }
			if (p6.CompareTo(p9) > 0) { temp = p6; p6 = p9; p9 = temp; }
			if (p7.CompareTo(p11) > 0) { temp = p7; p7 = p11; p11 = temp; }
			if (p8.CompareTo(p12) > 0) { temp = p8; p8 = p12; p12 = temp; }
			if (p8.CompareTo(p11) > 0) { temp = p8; p8 = p11; p11 = temp; }
			if (p7.CompareTo(p9) > 0) { temp = p7; p7 = p9; p9 = temp; }
			if (p8.CompareTo(p10) > 0) { temp = p8; p8 = p10; p10 = temp; }
			if (p8.CompareTo(p9) > 0) { temp = p8; p8 = p9; p9 = temp; }
			if (p0.CompareTo(p7) > 0) { temp = p0; p0 = p7; p7 = temp; }
			if (p0.CompareTo(p6) > 0) { temp = p0; p0 = p6; p6 = temp; }
			if (p1.CompareTo(p8) > 0) { temp = p1; p1 = p8; p8 = temp; }
			if (p2.CompareTo(p9) > 0) { temp = p2; p2 = p9; p9 = temp; }
			if (p2.CompareTo(p8) > 0) { temp = p2; p2 = p8; p8 = temp; }
			if (p1.CompareTo(p6) > 0) { temp = p1; p1 = p6; p6 = temp; }
			if (p2.CompareTo(p7) > 0) { temp = p2; p2 = p7; p7 = temp; }
			if (p2.CompareTo(p6) > 0) { temp = p2; p2 = p6; p6 = temp; }
			if (p3.CompareTo(p11) > 0) { temp = p3; p3 = p11; p11 = temp; }
			if (p3.CompareTo(p10) > 0) { temp = p3; p3 = p10; p10 = temp; }
			if (p4.CompareTo(p12) > 0) { temp = p4; p4 = p12; p12 = temp; }
			if (p5.CompareTo(p12) > 0) { temp = p5; p5 = p12; p12 = temp; }
			if (p4.CompareTo(p10) > 0) { temp = p4; p4 = p10; p10 = temp; }
			if (p5.CompareTo(p11) > 0) { temp = p5; p5 = p11; p11 = temp; }
			if (p5.CompareTo(p10) > 0) { temp = p5; p5 = p10; p10 = temp; }
			if (p3.CompareTo(p7) > 0) { temp = p3; p3 = p7; p7 = temp; }
			if (p3.CompareTo(p6) > 0) { temp = p3; p3 = p6; p6 = temp; }
			if (p4.CompareTo(p8) > 0) { temp = p4; p4 = p8; p8 = temp; }
			if (p5.CompareTo(p9) > 0) { temp = p5; p5 = p9; p9 = temp; }
			if (p5.CompareTo(p8) > 0) { temp = p5; p5 = p8; p8 = temp; }
			if (p4.CompareTo(p6) > 0) { temp = p4; p4 = p6; p6 = temp; }
			if (p5.CompareTo(p7) > 0) { temp = p5; p5 = p7; p7 = temp; }
			if (p5.CompareTo(p6) > 0) { temp = p5; p5 = p6; p6 = temp; }
#else
			if (GreaterThan(ref p1, ref p2)) { temp = p1; p1 = p2; p2 = temp; }
			if (GreaterThan(ref p0, ref p2)) { temp = p0; p0 = p2; p2 = temp; }
			if (GreaterThan(ref p0, ref p1)) { temp = p0; p0 = p1; p1 = temp; }
			if (GreaterThan(ref p4, ref p5)) { temp = p4; p4 = p5; p5 = temp; }
			if (GreaterThan(ref p3, ref p5)) { temp = p3; p3 = p5; p5 = temp; }
			if (GreaterThan(ref p3, ref p4)) { temp = p3; p3 = p4; p4 = temp; }
			if (GreaterThan(ref p0, ref p4)) { temp = p0; p0 = p4; p4 = temp; }
			if (GreaterThan(ref p0, ref p3)) { temp = p0; p0 = p3; p3 = temp; }
			if (GreaterThan(ref p1, ref p5)) { temp = p1; p1 = p5; p5 = temp; }
			if (GreaterThan(ref p2, ref p5)) { temp = p2; p2 = p5; p5 = temp; }
			if (GreaterThan(ref p1, ref p3)) { temp = p1; p1 = p3; p3 = temp; }
			if (GreaterThan(ref p2, ref p4)) { temp = p2; p2 = p4; p4 = temp; }
			if (GreaterThan(ref p2, ref p3)) { temp = p2; p2 = p3; p3 = temp; }
			if (GreaterThan(ref p7, ref p8)) { temp = p7; p7 = p8; p8 = temp; }
			if (GreaterThan(ref p6, ref p8)) { temp = p6; p6 = p8; p8 = temp; }
			if (GreaterThan(ref p6, ref p7)) { temp = p6; p6 = p7; p7 = temp; }
			if (GreaterThan(ref p9, ref p10)) { temp = p9; p9 = p10; p10 = temp; }
			if (GreaterThan(ref p11, ref p12)) { temp = p11; p11 = p12; p12 = temp; }
			if (GreaterThan(ref p9, ref p11)) { temp = p9; p9 = p11; p11 = temp; }
			if (GreaterThan(ref p10, ref p12)) { temp = p10; p10 = p12; p12 = temp; }
			if (GreaterThan(ref p10, ref p11)) { temp = p10; p10 = p11; p11 = temp; }
			if (GreaterThan(ref p6, ref p10)) { temp = p6; p6 = p10; p10 = temp; }
			if (GreaterThan(ref p6, ref p9)) { temp = p6; p6 = p9; p9 = temp; }
			if (GreaterThan(ref p7, ref p11)) { temp = p7; p7 = p11; p11 = temp; }
			if (GreaterThan(ref p8, ref p12)) { temp = p8; p8 = p12; p12 = temp; }
			if (GreaterThan(ref p8, ref p11)) { temp = p8; p8 = p11; p11 = temp; }
			if (GreaterThan(ref p7, ref p9)) { temp = p7; p7 = p9; p9 = temp; }
			if (GreaterThan(ref p8, ref p10)) { temp = p8; p8 = p10; p10 = temp; }
			if (GreaterThan(ref p8, ref p9)) { temp = p8; p8 = p9; p9 = temp; }
			if (GreaterThan(ref p0, ref p7)) { temp = p0; p0 = p7; p7 = temp; }
			if (GreaterThan(ref p0, ref p6)) { temp = p0; p0 = p6; p6 = temp; }
			if (GreaterThan(ref p1, ref p8)) { temp = p1; p1 = p8; p8 = temp; }
			if (GreaterThan(ref p2, ref p9)) { temp = p2; p2 = p9; p9 = temp; }
			if (GreaterThan(ref p2, ref p8)) { temp = p2; p2 = p8; p8 = temp; }
			if (GreaterThan(ref p1, ref p6)) { temp = p1; p1 = p6; p6 = temp; }
			if (GreaterThan(ref p2, ref p7)) { temp = p2; p2 = p7; p7 = temp; }
			if (GreaterThan(ref p2, ref p6)) { temp = p2; p2 = p6; p6 = temp; }
			if (GreaterThan(ref p3, ref p11)) { temp = p3; p3 = p11; p11 = temp; }
			if (GreaterThan(ref p3, ref p10)) { temp = p3; p3 = p10; p10 = temp; }
			if (GreaterThan(ref p4, ref p12)) { temp = p4; p4 = p12; p12 = temp; }
			if (GreaterThan(ref p5, ref p12)) { temp = p5; p5 = p12; p12 = temp; }
			if (GreaterThan(ref p4, ref p10)) { temp = p4; p4 = p10; p10 = temp; }
			if (GreaterThan(ref p5, ref p11)) { temp = p5; p5 = p11; p11 = temp; }
			if (GreaterThan(ref p5, ref p10)) { temp = p5; p5 = p10; p10 = temp; }
			if (GreaterThan(ref p3, ref p7)) { temp = p3; p3 = p7; p7 = temp; }
			if (GreaterThan(ref p3, ref p6)) { temp = p3; p3 = p6; p6 = temp; }
			if (GreaterThan(ref p4, ref p8)) { temp = p4; p4 = p8; p8 = temp; }
			if (GreaterThan(ref p5, ref p9)) { temp = p5; p5 = p9; p9 = temp; }
			if (GreaterThan(ref p5, ref p8)) { temp = p5; p5 = p8; p8 = temp; }
			if (GreaterThan(ref p4, ref p6)) { temp = p4; p4 = p6; p6 = temp; }
			if (GreaterThan(ref p5, ref p7)) { temp = p5; p5 = p7; p7 = temp; }
			if (GreaterThan(ref p5, ref p6)) { temp = p5; p5 = p6; p6 = temp; }
#endif
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
#if NETSTANDARD1_3
			if (p1.CompareTo(p2) > 0) { temp = p1; p1 = p2; p2 = temp; }
			if (p0.CompareTo(p2) > 0) { temp = p0; p0 = p2; p2 = temp; }
			if (p0.CompareTo(p1) > 0) { temp = p0; p0 = p1; p1 = temp; }
			if (p3.CompareTo(p4) > 0) { temp = p3; p3 = p4; p4 = temp; }
			if (p5.CompareTo(p6) > 0) { temp = p5; p5 = p6; p6 = temp; }
			if (p3.CompareTo(p5) > 0) { temp = p3; p3 = p5; p5 = temp; }
			if (p4.CompareTo(p6) > 0) { temp = p4; p4 = p6; p6 = temp; }
			if (p4.CompareTo(p5) > 0) { temp = p4; p4 = p5; p5 = temp; }
			if (p0.CompareTo(p4) > 0) { temp = p0; p0 = p4; p4 = temp; }
			if (p0.CompareTo(p3) > 0) { temp = p0; p0 = p3; p3 = temp; }
			if (p1.CompareTo(p5) > 0) { temp = p1; p1 = p5; p5 = temp; }
			if (p2.CompareTo(p6) > 0) { temp = p2; p2 = p6; p6 = temp; }
			if (p2.CompareTo(p5) > 0) { temp = p2; p2 = p5; p5 = temp; }
			if (p1.CompareTo(p3) > 0) { temp = p1; p1 = p3; p3 = temp; }
			if (p2.CompareTo(p4) > 0) { temp = p2; p2 = p4; p4 = temp; }
			if (p2.CompareTo(p3) > 0) { temp = p2; p2 = p3; p3 = temp; }
			if (p8.CompareTo(p9) > 0) { temp = p8; p8 = p9; p9 = temp; }
			if (p7.CompareTo(p9) > 0) { temp = p7; p7 = p9; p9 = temp; }
			if (p7.CompareTo(p8) > 0) { temp = p7; p7 = p8; p8 = temp; }
			if (p10.CompareTo(p11) > 0) { temp = p10; p10 = p11; p11 = temp; }
			if (p12.CompareTo(p13) > 0) { temp = p12; p12 = p13; p13 = temp; }
			if (p10.CompareTo(p12) > 0) { temp = p10; p10 = p12; p12 = temp; }
			if (p11.CompareTo(p13) > 0) { temp = p11; p11 = p13; p13 = temp; }
			if (p11.CompareTo(p12) > 0) { temp = p11; p11 = p12; p12 = temp; }
			if (p7.CompareTo(p11) > 0) { temp = p7; p7 = p11; p11 = temp; }
			if (p7.CompareTo(p10) > 0) { temp = p7; p7 = p10; p10 = temp; }
			if (p8.CompareTo(p12) > 0) { temp = p8; p8 = p12; p12 = temp; }
			if (p9.CompareTo(p13) > 0) { temp = p9; p9 = p13; p13 = temp; }
			if (p9.CompareTo(p12) > 0) { temp = p9; p9 = p12; p12 = temp; }
			if (p8.CompareTo(p10) > 0) { temp = p8; p8 = p10; p10 = temp; }
			if (p9.CompareTo(p11) > 0) { temp = p9; p9 = p11; p11 = temp; }
			if (p9.CompareTo(p10) > 0) { temp = p9; p9 = p10; p10 = temp; }
			if (p0.CompareTo(p8) > 0) { temp = p0; p0 = p8; p8 = temp; }
			if (p0.CompareTo(p7) > 0) { temp = p0; p0 = p7; p7 = temp; }
			if (p1.CompareTo(p9) > 0) { temp = p1; p1 = p9; p9 = temp; }
			if (p2.CompareTo(p10) > 0) { temp = p2; p2 = p10; p10 = temp; }
			if (p2.CompareTo(p9) > 0) { temp = p2; p2 = p9; p9 = temp; }
			if (p1.CompareTo(p7) > 0) { temp = p1; p1 = p7; p7 = temp; }
			if (p2.CompareTo(p8) > 0) { temp = p2; p2 = p8; p8 = temp; }
			if (p2.CompareTo(p7) > 0) { temp = p2; p2 = p7; p7 = temp; }
			if (p3.CompareTo(p11) > 0) { temp = p3; p3 = p11; p11 = temp; }
			if (p4.CompareTo(p12) > 0) { temp = p4; p4 = p12; p12 = temp; }
			if (p4.CompareTo(p11) > 0) { temp = p4; p4 = p11; p11 = temp; }
			if (p5.CompareTo(p13) > 0) { temp = p5; p5 = p13; p13 = temp; }
			if (p6.CompareTo(p13) > 0) { temp = p6; p6 = p13; p13 = temp; }
			if (p5.CompareTo(p11) > 0) { temp = p5; p5 = p11; p11 = temp; }
			if (p6.CompareTo(p12) > 0) { temp = p6; p6 = p12; p12 = temp; }
			if (p6.CompareTo(p11) > 0) { temp = p6; p6 = p11; p11 = temp; }
			if (p3.CompareTo(p7) > 0) { temp = p3; p3 = p7; p7 = temp; }
			if (p4.CompareTo(p8) > 0) { temp = p4; p4 = p8; p8 = temp; }
			if (p4.CompareTo(p7) > 0) { temp = p4; p4 = p7; p7 = temp; }
			if (p5.CompareTo(p9) > 0) { temp = p5; p5 = p9; p9 = temp; }
			if (p6.CompareTo(p10) > 0) { temp = p6; p6 = p10; p10 = temp; }
			if (p6.CompareTo(p9) > 0) { temp = p6; p6 = p9; p9 = temp; }
			if (p5.CompareTo(p7) > 0) { temp = p5; p5 = p7; p7 = temp; }
			if (p6.CompareTo(p8) > 0) { temp = p6; p6 = p8; p8 = temp; }
			if (p6.CompareTo(p7) > 0) { temp = p6; p6 = p7; p7 = temp; }
#else
			if (GreaterThan(ref p1, ref p2)) { temp = p1; p1 = p2; p2 = temp; }
			if (GreaterThan(ref p0, ref p2)) { temp = p0; p0 = p2; p2 = temp; }
			if (GreaterThan(ref p0, ref p1)) { temp = p0; p0 = p1; p1 = temp; }
			if (GreaterThan(ref p3, ref p4)) { temp = p3; p3 = p4; p4 = temp; }
			if (GreaterThan(ref p5, ref p6)) { temp = p5; p5 = p6; p6 = temp; }
			if (GreaterThan(ref p3, ref p5)) { temp = p3; p3 = p5; p5 = temp; }
			if (GreaterThan(ref p4, ref p6)) { temp = p4; p4 = p6; p6 = temp; }
			if (GreaterThan(ref p4, ref p5)) { temp = p4; p4 = p5; p5 = temp; }
			if (GreaterThan(ref p0, ref p4)) { temp = p0; p0 = p4; p4 = temp; }
			if (GreaterThan(ref p0, ref p3)) { temp = p0; p0 = p3; p3 = temp; }
			if (GreaterThan(ref p1, ref p5)) { temp = p1; p1 = p5; p5 = temp; }
			if (GreaterThan(ref p2, ref p6)) { temp = p2; p2 = p6; p6 = temp; }
			if (GreaterThan(ref p2, ref p5)) { temp = p2; p2 = p5; p5 = temp; }
			if (GreaterThan(ref p1, ref p3)) { temp = p1; p1 = p3; p3 = temp; }
			if (GreaterThan(ref p2, ref p4)) { temp = p2; p2 = p4; p4 = temp; }
			if (GreaterThan(ref p2, ref p3)) { temp = p2; p2 = p3; p3 = temp; }
			if (GreaterThan(ref p8, ref p9)) { temp = p8; p8 = p9; p9 = temp; }
			if (GreaterThan(ref p7, ref p9)) { temp = p7; p7 = p9; p9 = temp; }
			if (GreaterThan(ref p7, ref p8)) { temp = p7; p7 = p8; p8 = temp; }
			if (GreaterThan(ref p10, ref p11)) { temp = p10; p10 = p11; p11 = temp; }
			if (GreaterThan(ref p12, ref p13)) { temp = p12; p12 = p13; p13 = temp; }
			if (GreaterThan(ref p10, ref p12)) { temp = p10; p10 = p12; p12 = temp; }
			if (GreaterThan(ref p11, ref p13)) { temp = p11; p11 = p13; p13 = temp; }
			if (GreaterThan(ref p11, ref p12)) { temp = p11; p11 = p12; p12 = temp; }
			if (GreaterThan(ref p7, ref p11)) { temp = p7; p7 = p11; p11 = temp; }
			if (GreaterThan(ref p7, ref p10)) { temp = p7; p7 = p10; p10 = temp; }
			if (GreaterThan(ref p8, ref p12)) { temp = p8; p8 = p12; p12 = temp; }
			if (GreaterThan(ref p9, ref p13)) { temp = p9; p9 = p13; p13 = temp; }
			if (GreaterThan(ref p9, ref p12)) { temp = p9; p9 = p12; p12 = temp; }
			if (GreaterThan(ref p8, ref p10)) { temp = p8; p8 = p10; p10 = temp; }
			if (GreaterThan(ref p9, ref p11)) { temp = p9; p9 = p11; p11 = temp; }
			if (GreaterThan(ref p9, ref p10)) { temp = p9; p9 = p10; p10 = temp; }
			if (GreaterThan(ref p0, ref p8)) { temp = p0; p0 = p8; p8 = temp; }
			if (GreaterThan(ref p0, ref p7)) { temp = p0; p0 = p7; p7 = temp; }
			if (GreaterThan(ref p1, ref p9)) { temp = p1; p1 = p9; p9 = temp; }
			if (GreaterThan(ref p2, ref p10)) { temp = p2; p2 = p10; p10 = temp; }
			if (GreaterThan(ref p2, ref p9)) { temp = p2; p2 = p9; p9 = temp; }
			if (GreaterThan(ref p1, ref p7)) { temp = p1; p1 = p7; p7 = temp; }
			if (GreaterThan(ref p2, ref p8)) { temp = p2; p2 = p8; p8 = temp; }
			if (GreaterThan(ref p2, ref p7)) { temp = p2; p2 = p7; p7 = temp; }
			if (GreaterThan(ref p3, ref p11)) { temp = p3; p3 = p11; p11 = temp; }
			if (GreaterThan(ref p4, ref p12)) { temp = p4; p4 = p12; p12 = temp; }
			if (GreaterThan(ref p4, ref p11)) { temp = p4; p4 = p11; p11 = temp; }
			if (GreaterThan(ref p5, ref p13)) { temp = p5; p5 = p13; p13 = temp; }
			if (GreaterThan(ref p6, ref p13)) { temp = p6; p6 = p13; p13 = temp; }
			if (GreaterThan(ref p5, ref p11)) { temp = p5; p5 = p11; p11 = temp; }
			if (GreaterThan(ref p6, ref p12)) { temp = p6; p6 = p12; p12 = temp; }
			if (GreaterThan(ref p6, ref p11)) { temp = p6; p6 = p11; p11 = temp; }
			if (GreaterThan(ref p3, ref p7)) { temp = p3; p3 = p7; p7 = temp; }
			if (GreaterThan(ref p4, ref p8)) { temp = p4; p4 = p8; p8 = temp; }
			if (GreaterThan(ref p4, ref p7)) { temp = p4; p4 = p7; p7 = temp; }
			if (GreaterThan(ref p5, ref p9)) { temp = p5; p5 = p9; p9 = temp; }
			if (GreaterThan(ref p6, ref p10)) { temp = p6; p6 = p10; p10 = temp; }
			if (GreaterThan(ref p6, ref p9)) { temp = p6; p6 = p9; p9 = temp; }
			if (GreaterThan(ref p5, ref p7)) { temp = p5; p5 = p7; p7 = temp; }
			if (GreaterThan(ref p6, ref p8)) { temp = p6; p6 = p8; p8 = temp; }
			if (GreaterThan(ref p6, ref p7)) { temp = p6; p6 = p7; p7 = temp; }
#endif
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
#if NETSTANDARD1_3
			if (p1.CompareTo(p2) > 0) { temp = p1; p1 = p2; p2 = temp; }
			if (p0.CompareTo(p2) > 0) { temp = p0; p0 = p2; p2 = temp; }
			if (p0.CompareTo(p1) > 0) { temp = p0; p0 = p1; p1 = temp; }
			if (p3.CompareTo(p4) > 0) { temp = p3; p3 = p4; p4 = temp; }
			if (p5.CompareTo(p6) > 0) { temp = p5; p5 = p6; p6 = temp; }
			if (p3.CompareTo(p5) > 0) { temp = p3; p3 = p5; p5 = temp; }
			if (p4.CompareTo(p6) > 0) { temp = p4; p4 = p6; p6 = temp; }
			if (p4.CompareTo(p5) > 0) { temp = p4; p4 = p5; p5 = temp; }
			if (p0.CompareTo(p4) > 0) { temp = p0; p0 = p4; p4 = temp; }
			if (p0.CompareTo(p3) > 0) { temp = p0; p0 = p3; p3 = temp; }
			if (p1.CompareTo(p5) > 0) { temp = p1; p1 = p5; p5 = temp; }
			if (p2.CompareTo(p6) > 0) { temp = p2; p2 = p6; p6 = temp; }
			if (p2.CompareTo(p5) > 0) { temp = p2; p2 = p5; p5 = temp; }
			if (p1.CompareTo(p3) > 0) { temp = p1; p1 = p3; p3 = temp; }
			if (p2.CompareTo(p4) > 0) { temp = p2; p2 = p4; p4 = temp; }
			if (p2.CompareTo(p3) > 0) { temp = p2; p2 = p3; p3 = temp; }
			if (p7.CompareTo(p8) > 0) { temp = p7; p7 = p8; p8 = temp; }
			if (p9.CompareTo(p10) > 0) { temp = p9; p9 = p10; p10 = temp; }
			if (p7.CompareTo(p9) > 0) { temp = p7; p7 = p9; p9 = temp; }
			if (p8.CompareTo(p10) > 0) { temp = p8; p8 = p10; p10 = temp; }
			if (p8.CompareTo(p9) > 0) { temp = p8; p8 = p9; p9 = temp; }
			if (p11.CompareTo(p12) > 0) { temp = p11; p11 = p12; p12 = temp; }
			if (p13.CompareTo(p14) > 0) { temp = p13; p13 = p14; p14 = temp; }
			if (p11.CompareTo(p13) > 0) { temp = p11; p11 = p13; p13 = temp; }
			if (p12.CompareTo(p14) > 0) { temp = p12; p12 = p14; p14 = temp; }
			if (p12.CompareTo(p13) > 0) { temp = p12; p12 = p13; p13 = temp; }
			if (p7.CompareTo(p11) > 0) { temp = p7; p7 = p11; p11 = temp; }
			if (p8.CompareTo(p12) > 0) { temp = p8; p8 = p12; p12 = temp; }
			if (p8.CompareTo(p11) > 0) { temp = p8; p8 = p11; p11 = temp; }
			if (p9.CompareTo(p13) > 0) { temp = p9; p9 = p13; p13 = temp; }
			if (p10.CompareTo(p14) > 0) { temp = p10; p10 = p14; p14 = temp; }
			if (p10.CompareTo(p13) > 0) { temp = p10; p10 = p13; p13 = temp; }
			if (p9.CompareTo(p11) > 0) { temp = p9; p9 = p11; p11 = temp; }
			if (p10.CompareTo(p12) > 0) { temp = p10; p10 = p12; p12 = temp; }
			if (p10.CompareTo(p11) > 0) { temp = p10; p10 = p11; p11 = temp; }
			if (p0.CompareTo(p8) > 0) { temp = p0; p0 = p8; p8 = temp; }
			if (p0.CompareTo(p7) > 0) { temp = p0; p0 = p7; p7 = temp; }
			if (p1.CompareTo(p9) > 0) { temp = p1; p1 = p9; p9 = temp; }
			if (p2.CompareTo(p10) > 0) { temp = p2; p2 = p10; p10 = temp; }
			if (p2.CompareTo(p9) > 0) { temp = p2; p2 = p9; p9 = temp; }
			if (p1.CompareTo(p7) > 0) { temp = p1; p1 = p7; p7 = temp; }
			if (p2.CompareTo(p8) > 0) { temp = p2; p2 = p8; p8 = temp; }
			if (p2.CompareTo(p7) > 0) { temp = p2; p2 = p7; p7 = temp; }
			if (p3.CompareTo(p11) > 0) { temp = p3; p3 = p11; p11 = temp; }
			if (p4.CompareTo(p12) > 0) { temp = p4; p4 = p12; p12 = temp; }
			if (p4.CompareTo(p11) > 0) { temp = p4; p4 = p11; p11 = temp; }
			if (p5.CompareTo(p13) > 0) { temp = p5; p5 = p13; p13 = temp; }
			if (p6.CompareTo(p14) > 0) { temp = p6; p6 = p14; p14 = temp; }
			if (p6.CompareTo(p13) > 0) { temp = p6; p6 = p13; p13 = temp; }
			if (p5.CompareTo(p11) > 0) { temp = p5; p5 = p11; p11 = temp; }
			if (p6.CompareTo(p12) > 0) { temp = p6; p6 = p12; p12 = temp; }
			if (p6.CompareTo(p11) > 0) { temp = p6; p6 = p11; p11 = temp; }
			if (p3.CompareTo(p7) > 0) { temp = p3; p3 = p7; p7 = temp; }
			if (p4.CompareTo(p8) > 0) { temp = p4; p4 = p8; p8 = temp; }
			if (p4.CompareTo(p7) > 0) { temp = p4; p4 = p7; p7 = temp; }
			if (p5.CompareTo(p9) > 0) { temp = p5; p5 = p9; p9 = temp; }
			if (p6.CompareTo(p10) > 0) { temp = p6; p6 = p10; p10 = temp; }
			if (p6.CompareTo(p9) > 0) { temp = p6; p6 = p9; p9 = temp; }
			if (p5.CompareTo(p7) > 0) { temp = p5; p5 = p7; p7 = temp; }
			if (p6.CompareTo(p8) > 0) { temp = p6; p6 = p8; p8 = temp; }
			if (p6.CompareTo(p7) > 0) { temp = p6; p6 = p7; p7 = temp; }
#else
			if (GreaterThan(ref p1, ref p2)) { temp = p1; p1 = p2; p2 = temp; }
			if (GreaterThan(ref p0, ref p2)) { temp = p0; p0 = p2; p2 = temp; }
			if (GreaterThan(ref p0, ref p1)) { temp = p0; p0 = p1; p1 = temp; }
			if (GreaterThan(ref p3, ref p4)) { temp = p3; p3 = p4; p4 = temp; }
			if (GreaterThan(ref p5, ref p6)) { temp = p5; p5 = p6; p6 = temp; }
			if (GreaterThan(ref p3, ref p5)) { temp = p3; p3 = p5; p5 = temp; }
			if (GreaterThan(ref p4, ref p6)) { temp = p4; p4 = p6; p6 = temp; }
			if (GreaterThan(ref p4, ref p5)) { temp = p4; p4 = p5; p5 = temp; }
			if (GreaterThan(ref p0, ref p4)) { temp = p0; p0 = p4; p4 = temp; }
			if (GreaterThan(ref p0, ref p3)) { temp = p0; p0 = p3; p3 = temp; }
			if (GreaterThan(ref p1, ref p5)) { temp = p1; p1 = p5; p5 = temp; }
			if (GreaterThan(ref p2, ref p6)) { temp = p2; p2 = p6; p6 = temp; }
			if (GreaterThan(ref p2, ref p5)) { temp = p2; p2 = p5; p5 = temp; }
			if (GreaterThan(ref p1, ref p3)) { temp = p1; p1 = p3; p3 = temp; }
			if (GreaterThan(ref p2, ref p4)) { temp = p2; p2 = p4; p4 = temp; }
			if (GreaterThan(ref p2, ref p3)) { temp = p2; p2 = p3; p3 = temp; }
			if (GreaterThan(ref p7, ref p8)) { temp = p7; p7 = p8; p8 = temp; }
			if (GreaterThan(ref p9, ref p10)) { temp = p9; p9 = p10; p10 = temp; }
			if (GreaterThan(ref p7, ref p9)) { temp = p7; p7 = p9; p9 = temp; }
			if (GreaterThan(ref p8, ref p10)) { temp = p8; p8 = p10; p10 = temp; }
			if (GreaterThan(ref p8, ref p9)) { temp = p8; p8 = p9; p9 = temp; }
			if (GreaterThan(ref p11, ref p12)) { temp = p11; p11 = p12; p12 = temp; }
			if (GreaterThan(ref p13, ref p14)) { temp = p13; p13 = p14; p14 = temp; }
			if (GreaterThan(ref p11, ref p13)) { temp = p11; p11 = p13; p13 = temp; }
			if (GreaterThan(ref p12, ref p14)) { temp = p12; p12 = p14; p14 = temp; }
			if (GreaterThan(ref p12, ref p13)) { temp = p12; p12 = p13; p13 = temp; }
			if (GreaterThan(ref p7, ref p11)) { temp = p7; p7 = p11; p11 = temp; }
			if (GreaterThan(ref p8, ref p12)) { temp = p8; p8 = p12; p12 = temp; }
			if (GreaterThan(ref p8, ref p11)) { temp = p8; p8 = p11; p11 = temp; }
			if (GreaterThan(ref p9, ref p13)) { temp = p9; p9 = p13; p13 = temp; }
			if (GreaterThan(ref p10, ref p14)) { temp = p10; p10 = p14; p14 = temp; }
			if (GreaterThan(ref p10, ref p13)) { temp = p10; p10 = p13; p13 = temp; }
			if (GreaterThan(ref p9, ref p11)) { temp = p9; p9 = p11; p11 = temp; }
			if (GreaterThan(ref p10, ref p12)) { temp = p10; p10 = p12; p12 = temp; }
			if (GreaterThan(ref p10, ref p11)) { temp = p10; p10 = p11; p11 = temp; }
			if (GreaterThan(ref p0, ref p8)) { temp = p0; p0 = p8; p8 = temp; }
			if (GreaterThan(ref p0, ref p7)) { temp = p0; p0 = p7; p7 = temp; }
			if (GreaterThan(ref p1, ref p9)) { temp = p1; p1 = p9; p9 = temp; }
			if (GreaterThan(ref p2, ref p10)) { temp = p2; p2 = p10; p10 = temp; }
			if (GreaterThan(ref p2, ref p9)) { temp = p2; p2 = p9; p9 = temp; }
			if (GreaterThan(ref p1, ref p7)) { temp = p1; p1 = p7; p7 = temp; }
			if (GreaterThan(ref p2, ref p8)) { temp = p2; p2 = p8; p8 = temp; }
			if (GreaterThan(ref p2, ref p7)) { temp = p2; p2 = p7; p7 = temp; }
			if (GreaterThan(ref p3, ref p11)) { temp = p3; p3 = p11; p11 = temp; }
			if (GreaterThan(ref p4, ref p12)) { temp = p4; p4 = p12; p12 = temp; }
			if (GreaterThan(ref p4, ref p11)) { temp = p4; p4 = p11; p11 = temp; }
			if (GreaterThan(ref p5, ref p13)) { temp = p5; p5 = p13; p13 = temp; }
			if (GreaterThan(ref p6, ref p14)) { temp = p6; p6 = p14; p14 = temp; }
			if (GreaterThan(ref p6, ref p13)) { temp = p6; p6 = p13; p13 = temp; }
			if (GreaterThan(ref p5, ref p11)) { temp = p5; p5 = p11; p11 = temp; }
			if (GreaterThan(ref p6, ref p12)) { temp = p6; p6 = p12; p12 = temp; }
			if (GreaterThan(ref p6, ref p11)) { temp = p6; p6 = p11; p11 = temp; }
			if (GreaterThan(ref p3, ref p7)) { temp = p3; p3 = p7; p7 = temp; }
			if (GreaterThan(ref p4, ref p8)) { temp = p4; p4 = p8; p8 = temp; }
			if (GreaterThan(ref p4, ref p7)) { temp = p4; p4 = p7; p7 = temp; }
			if (GreaterThan(ref p5, ref p9)) { temp = p5; p5 = p9; p9 = temp; }
			if (GreaterThan(ref p6, ref p10)) { temp = p6; p6 = p10; p10 = temp; }
			if (GreaterThan(ref p6, ref p9)) { temp = p6; p6 = p9; p9 = temp; }
			if (GreaterThan(ref p5, ref p7)) { temp = p5; p5 = p7; p7 = temp; }
			if (GreaterThan(ref p6, ref p8)) { temp = p6; p6 = p8; p8 = temp; }
			if (GreaterThan(ref p6, ref p7)) { temp = p6; p6 = p7; p7 = temp; }
#endif
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
#if NETSTANDARD1_3
			if (p0.CompareTo(p1) > 0) { temp = p0; p0 = p1; p1 = temp; }
			if (p2.CompareTo(p3) > 0) { temp = p2; p2 = p3; p3 = temp; }
			if (p0.CompareTo(p2) > 0) { temp = p0; p0 = p2; p2 = temp; }
			if (p1.CompareTo(p3) > 0) { temp = p1; p1 = p3; p3 = temp; }
			if (p1.CompareTo(p2) > 0) { temp = p1; p1 = p2; p2 = temp; }
			if (p4.CompareTo(p5) > 0) { temp = p4; p4 = p5; p5 = temp; }
			if (p6.CompareTo(p7) > 0) { temp = p6; p6 = p7; p7 = temp; }
			if (p4.CompareTo(p6) > 0) { temp = p4; p4 = p6; p6 = temp; }
			if (p5.CompareTo(p7) > 0) { temp = p5; p5 = p7; p7 = temp; }
			if (p5.CompareTo(p6) > 0) { temp = p5; p5 = p6; p6 = temp; }
			if (p0.CompareTo(p4) > 0) { temp = p0; p0 = p4; p4 = temp; }
			if (p1.CompareTo(p5) > 0) { temp = p1; p1 = p5; p5 = temp; }
			if (p1.CompareTo(p4) > 0) { temp = p1; p1 = p4; p4 = temp; }
			if (p2.CompareTo(p6) > 0) { temp = p2; p2 = p6; p6 = temp; }
			if (p3.CompareTo(p7) > 0) { temp = p3; p3 = p7; p7 = temp; }
			if (p3.CompareTo(p6) > 0) { temp = p3; p3 = p6; p6 = temp; }
			if (p2.CompareTo(p4) > 0) { temp = p2; p2 = p4; p4 = temp; }
			if (p3.CompareTo(p5) > 0) { temp = p3; p3 = p5; p5 = temp; }
			if (p3.CompareTo(p4) > 0) { temp = p3; p3 = p4; p4 = temp; }
			if (p8.CompareTo(p9) > 0) { temp = p8; p8 = p9; p9 = temp; }
			if (p10.CompareTo(p11) > 0) { temp = p10; p10 = p11; p11 = temp; }
			if (p8.CompareTo(p10) > 0) { temp = p8; p8 = p10; p10 = temp; }
			if (p9.CompareTo(p11) > 0) { temp = p9; p9 = p11; p11 = temp; }
			if (p9.CompareTo(p10) > 0) { temp = p9; p9 = p10; p10 = temp; }
			if (p12.CompareTo(p13) > 0) { temp = p12; p12 = p13; p13 = temp; }
			if (p14.CompareTo(p15) > 0) { temp = p14; p14 = p15; p15 = temp; }
			if (p12.CompareTo(p14) > 0) { temp = p12; p12 = p14; p14 = temp; }
			if (p13.CompareTo(p15) > 0) { temp = p13; p13 = p15; p15 = temp; }
			if (p13.CompareTo(p14) > 0) { temp = p13; p13 = p14; p14 = temp; }
			if (p8.CompareTo(p12) > 0) { temp = p8; p8 = p12; p12 = temp; }
			if (p9.CompareTo(p13) > 0) { temp = p9; p9 = p13; p13 = temp; }
			if (p9.CompareTo(p12) > 0) { temp = p9; p9 = p12; p12 = temp; }
			if (p10.CompareTo(p14) > 0) { temp = p10; p10 = p14; p14 = temp; }
			if (p11.CompareTo(p15) > 0) { temp = p11; p11 = p15; p15 = temp; }
			if (p11.CompareTo(p14) > 0) { temp = p11; p11 = p14; p14 = temp; }
			if (p10.CompareTo(p12) > 0) { temp = p10; p10 = p12; p12 = temp; }
			if (p11.CompareTo(p13) > 0) { temp = p11; p11 = p13; p13 = temp; }
			if (p11.CompareTo(p12) > 0) { temp = p11; p11 = p12; p12 = temp; }
			if (p0.CompareTo(p8) > 0) { temp = p0; p0 = p8; p8 = temp; }
			if (p1.CompareTo(p9) > 0) { temp = p1; p1 = p9; p9 = temp; }
			if (p1.CompareTo(p8) > 0) { temp = p1; p1 = p8; p8 = temp; }
			if (p2.CompareTo(p10) > 0) { temp = p2; p2 = p10; p10 = temp; }
			if (p3.CompareTo(p11) > 0) { temp = p3; p3 = p11; p11 = temp; }
			if (p3.CompareTo(p10) > 0) { temp = p3; p3 = p10; p10 = temp; }
			if (p2.CompareTo(p8) > 0) { temp = p2; p2 = p8; p8 = temp; }
			if (p3.CompareTo(p9) > 0) { temp = p3; p3 = p9; p9 = temp; }
			if (p3.CompareTo(p8) > 0) { temp = p3; p3 = p8; p8 = temp; }
			if (p4.CompareTo(p12) > 0) { temp = p4; p4 = p12; p12 = temp; }
			if (p5.CompareTo(p13) > 0) { temp = p5; p5 = p13; p13 = temp; }
			if (p5.CompareTo(p12) > 0) { temp = p5; p5 = p12; p12 = temp; }
			if (p6.CompareTo(p14) > 0) { temp = p6; p6 = p14; p14 = temp; }
			if (p7.CompareTo(p15) > 0) { temp = p7; p7 = p15; p15 = temp; }
			if (p7.CompareTo(p14) > 0) { temp = p7; p7 = p14; p14 = temp; }
			if (p6.CompareTo(p12) > 0) { temp = p6; p6 = p12; p12 = temp; }
			if (p7.CompareTo(p13) > 0) { temp = p7; p7 = p13; p13 = temp; }
			if (p7.CompareTo(p12) > 0) { temp = p7; p7 = p12; p12 = temp; }
			if (p4.CompareTo(p8) > 0) { temp = p4; p4 = p8; p8 = temp; }
			if (p5.CompareTo(p9) > 0) { temp = p5; p5 = p9; p9 = temp; }
			if (p5.CompareTo(p8) > 0) { temp = p5; p5 = p8; p8 = temp; }
			if (p6.CompareTo(p10) > 0) { temp = p6; p6 = p10; p10 = temp; }
			if (p7.CompareTo(p11) > 0) { temp = p7; p7 = p11; p11 = temp; }
			if (p7.CompareTo(p10) > 0) { temp = p7; p7 = p10; p10 = temp; }
			if (p6.CompareTo(p8) > 0) { temp = p6; p6 = p8; p8 = temp; }
			if (p7.CompareTo(p9) > 0) { temp = p7; p7 = p9; p9 = temp; }
			if (p7.CompareTo(p8) > 0) { temp = p7; p7 = p8; p8 = temp; }
#else
			if (GreaterThan(ref p0, ref p1)) { temp = p0; p0 = p1; p1 = temp; }
			if (GreaterThan(ref p2, ref p3)) { temp = p2; p2 = p3; p3 = temp; }
			if (GreaterThan(ref p0, ref p2)) { temp = p0; p0 = p2; p2 = temp; }
			if (GreaterThan(ref p1, ref p3)) { temp = p1; p1 = p3; p3 = temp; }
			if (GreaterThan(ref p1, ref p2)) { temp = p1; p1 = p2; p2 = temp; }
			if (GreaterThan(ref p4, ref p5)) { temp = p4; p4 = p5; p5 = temp; }
			if (GreaterThan(ref p6, ref p7)) { temp = p6; p6 = p7; p7 = temp; }
			if (GreaterThan(ref p4, ref p6)) { temp = p4; p4 = p6; p6 = temp; }
			if (GreaterThan(ref p5, ref p7)) { temp = p5; p5 = p7; p7 = temp; }
			if (GreaterThan(ref p5, ref p6)) { temp = p5; p5 = p6; p6 = temp; }
			if (GreaterThan(ref p0, ref p4)) { temp = p0; p0 = p4; p4 = temp; }
			if (GreaterThan(ref p1, ref p5)) { temp = p1; p1 = p5; p5 = temp; }
			if (GreaterThan(ref p1, ref p4)) { temp = p1; p1 = p4; p4 = temp; }
			if (GreaterThan(ref p2, ref p6)) { temp = p2; p2 = p6; p6 = temp; }
			if (GreaterThan(ref p3, ref p7)) { temp = p3; p3 = p7; p7 = temp; }
			if (GreaterThan(ref p3, ref p6)) { temp = p3; p3 = p6; p6 = temp; }
			if (GreaterThan(ref p2, ref p4)) { temp = p2; p2 = p4; p4 = temp; }
			if (GreaterThan(ref p3, ref p5)) { temp = p3; p3 = p5; p5 = temp; }
			if (GreaterThan(ref p3, ref p4)) { temp = p3; p3 = p4; p4 = temp; }
			if (GreaterThan(ref p8, ref p9)) { temp = p8; p8 = p9; p9 = temp; }
			if (GreaterThan(ref p10, ref p11)) { temp = p10; p10 = p11; p11 = temp; }
			if (GreaterThan(ref p8, ref p10)) { temp = p8; p8 = p10; p10 = temp; }
			if (GreaterThan(ref p9, ref p11)) { temp = p9; p9 = p11; p11 = temp; }
			if (GreaterThan(ref p9, ref p10)) { temp = p9; p9 = p10; p10 = temp; }
			if (GreaterThan(ref p12, ref p13)) { temp = p12; p12 = p13; p13 = temp; }
			if (GreaterThan(ref p14, ref p15)) { temp = p14; p14 = p15; p15 = temp; }
			if (GreaterThan(ref p12, ref p14)) { temp = p12; p12 = p14; p14 = temp; }
			if (GreaterThan(ref p13, ref p15)) { temp = p13; p13 = p15; p15 = temp; }
			if (GreaterThan(ref p13, ref p14)) { temp = p13; p13 = p14; p14 = temp; }
			if (GreaterThan(ref p8, ref p12)) { temp = p8; p8 = p12; p12 = temp; }
			if (GreaterThan(ref p9, ref p13)) { temp = p9; p9 = p13; p13 = temp; }
			if (GreaterThan(ref p9, ref p12)) { temp = p9; p9 = p12; p12 = temp; }
			if (GreaterThan(ref p10, ref p14)) { temp = p10; p10 = p14; p14 = temp; }
			if (GreaterThan(ref p11, ref p15)) { temp = p11; p11 = p15; p15 = temp; }
			if (GreaterThan(ref p11, ref p14)) { temp = p11; p11 = p14; p14 = temp; }
			if (GreaterThan(ref p10, ref p12)) { temp = p10; p10 = p12; p12 = temp; }
			if (GreaterThan(ref p11, ref p13)) { temp = p11; p11 = p13; p13 = temp; }
			if (GreaterThan(ref p11, ref p12)) { temp = p11; p11 = p12; p12 = temp; }
			if (GreaterThan(ref p0, ref p8)) { temp = p0; p0 = p8; p8 = temp; }
			if (GreaterThan(ref p1, ref p9)) { temp = p1; p1 = p9; p9 = temp; }
			if (GreaterThan(ref p1, ref p8)) { temp = p1; p1 = p8; p8 = temp; }
			if (GreaterThan(ref p2, ref p10)) { temp = p2; p2 = p10; p10 = temp; }
			if (GreaterThan(ref p3, ref p11)) { temp = p3; p3 = p11; p11 = temp; }
			if (GreaterThan(ref p3, ref p10)) { temp = p3; p3 = p10; p10 = temp; }
			if (GreaterThan(ref p2, ref p8)) { temp = p2; p2 = p8; p8 = temp; }
			if (GreaterThan(ref p3, ref p9)) { temp = p3; p3 = p9; p9 = temp; }
			if (GreaterThan(ref p3, ref p8)) { temp = p3; p3 = p8; p8 = temp; }
			if (GreaterThan(ref p4, ref p12)) { temp = p4; p4 = p12; p12 = temp; }
			if (GreaterThan(ref p5, ref p13)) { temp = p5; p5 = p13; p13 = temp; }
			if (GreaterThan(ref p5, ref p12)) { temp = p5; p5 = p12; p12 = temp; }
			if (GreaterThan(ref p6, ref p14)) { temp = p6; p6 = p14; p14 = temp; }
			if (GreaterThan(ref p7, ref p15)) { temp = p7; p7 = p15; p15 = temp; }
			if (GreaterThan(ref p7, ref p14)) { temp = p7; p7 = p14; p14 = temp; }
			if (GreaterThan(ref p6, ref p12)) { temp = p6; p6 = p12; p12 = temp; }
			if (GreaterThan(ref p7, ref p13)) { temp = p7; p7 = p13; p13 = temp; }
			if (GreaterThan(ref p7, ref p12)) { temp = p7; p7 = p12; p12 = temp; }
			if (GreaterThan(ref p4, ref p8)) { temp = p4; p4 = p8; p8 = temp; }
			if (GreaterThan(ref p5, ref p9)) { temp = p5; p5 = p9; p9 = temp; }
			if (GreaterThan(ref p5, ref p8)) { temp = p5; p5 = p8; p8 = temp; }
			if (GreaterThan(ref p6, ref p10)) { temp = p6; p6 = p10; p10 = temp; }
			if (GreaterThan(ref p7, ref p11)) { temp = p7; p7 = p11; p11 = temp; }
			if (GreaterThan(ref p7, ref p10)) { temp = p7; p7 = p10; p10 = temp; }
			if (GreaterThan(ref p6, ref p8)) { temp = p6; p6 = p8; p8 = temp; }
			if (GreaterThan(ref p7, ref p9)) { temp = p7; p7 = p9; p9 = temp; }
			if (GreaterThan(ref p7, ref p8)) { temp = p7; p7 = p8; p8 = temp; }
#endif
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
#if NETSTANDARD1_3
			if (p0.CompareTo(p1) > 0) { temp = p0; p0 = p1; p1 = temp; }
			if (p2.CompareTo(p3) > 0) { temp = p2; p2 = p3; p3 = temp; }
			if (p0.CompareTo(p2) > 0) { temp = p0; p0 = p2; p2 = temp; }
			if (p1.CompareTo(p3) > 0) { temp = p1; p1 = p3; p3 = temp; }
			if (p1.CompareTo(p2) > 0) { temp = p1; p1 = p2; p2 = temp; }
			if (p4.CompareTo(p5) > 0) { temp = p4; p4 = p5; p5 = temp; }
			if (p6.CompareTo(p7) > 0) { temp = p6; p6 = p7; p7 = temp; }
			if (p4.CompareTo(p6) > 0) { temp = p4; p4 = p6; p6 = temp; }
			if (p5.CompareTo(p7) > 0) { temp = p5; p5 = p7; p7 = temp; }
			if (p5.CompareTo(p6) > 0) { temp = p5; p5 = p6; p6 = temp; }
			if (p0.CompareTo(p4) > 0) { temp = p0; p0 = p4; p4 = temp; }
			if (p1.CompareTo(p5) > 0) { temp = p1; p1 = p5; p5 = temp; }
			if (p1.CompareTo(p4) > 0) { temp = p1; p1 = p4; p4 = temp; }
			if (p2.CompareTo(p6) > 0) { temp = p2; p2 = p6; p6 = temp; }
			if (p3.CompareTo(p7) > 0) { temp = p3; p3 = p7; p7 = temp; }
			if (p3.CompareTo(p6) > 0) { temp = p3; p3 = p6; p6 = temp; }
			if (p2.CompareTo(p4) > 0) { temp = p2; p2 = p4; p4 = temp; }
			if (p3.CompareTo(p5) > 0) { temp = p3; p3 = p5; p5 = temp; }
			if (p3.CompareTo(p4) > 0) { temp = p3; p3 = p4; p4 = temp; }
			if (p8.CompareTo(p9) > 0) { temp = p8; p8 = p9; p9 = temp; }
			if (p10.CompareTo(p11) > 0) { temp = p10; p10 = p11; p11 = temp; }
			if (p8.CompareTo(p10) > 0) { temp = p8; p8 = p10; p10 = temp; }
			if (p9.CompareTo(p11) > 0) { temp = p9; p9 = p11; p11 = temp; }
			if (p9.CompareTo(p10) > 0) { temp = p9; p9 = p10; p10 = temp; }
			if (p12.CompareTo(p13) > 0) { temp = p12; p12 = p13; p13 = temp; }
			if (p15.CompareTo(p16) > 0) { temp = p15; p15 = p16; p16 = temp; }
			if (p14.CompareTo(p16) > 0) { temp = p14; p14 = p16; p16 = temp; }
			if (p14.CompareTo(p15) > 0) { temp = p14; p14 = p15; p15 = temp; }
			if (p12.CompareTo(p15) > 0) { temp = p12; p12 = p15; p15 = temp; }
			if (p12.CompareTo(p14) > 0) { temp = p12; p12 = p14; p14 = temp; }
			if (p13.CompareTo(p16) > 0) { temp = p13; p13 = p16; p16 = temp; }
			if (p13.CompareTo(p15) > 0) { temp = p13; p13 = p15; p15 = temp; }
			if (p13.CompareTo(p14) > 0) { temp = p13; p13 = p14; p14 = temp; }
			if (p8.CompareTo(p13) > 0) { temp = p8; p8 = p13; p13 = temp; }
			if (p8.CompareTo(p12) > 0) { temp = p8; p8 = p12; p12 = temp; }
			if (p9.CompareTo(p14) > 0) { temp = p9; p9 = p14; p14 = temp; }
			if (p9.CompareTo(p13) > 0) { temp = p9; p9 = p13; p13 = temp; }
			if (p9.CompareTo(p12) > 0) { temp = p9; p9 = p12; p12 = temp; }
			if (p10.CompareTo(p15) > 0) { temp = p10; p10 = p15; p15 = temp; }
			if (p11.CompareTo(p16) > 0) { temp = p11; p11 = p16; p16 = temp; }
			if (p11.CompareTo(p15) > 0) { temp = p11; p11 = p15; p15 = temp; }
			if (p10.CompareTo(p13) > 0) { temp = p10; p10 = p13; p13 = temp; }
			if (p10.CompareTo(p12) > 0) { temp = p10; p10 = p12; p12 = temp; }
			if (p11.CompareTo(p14) > 0) { temp = p11; p11 = p14; p14 = temp; }
			if (p11.CompareTo(p13) > 0) { temp = p11; p11 = p13; p13 = temp; }
			if (p11.CompareTo(p12) > 0) { temp = p11; p11 = p12; p12 = temp; }
			if (p0.CompareTo(p9) > 0) { temp = p0; p0 = p9; p9 = temp; }
			if (p0.CompareTo(p8) > 0) { temp = p0; p0 = p8; p8 = temp; }
			if (p1.CompareTo(p10) > 0) { temp = p1; p1 = p10; p10 = temp; }
			if (p1.CompareTo(p9) > 0) { temp = p1; p1 = p9; p9 = temp; }
			if (p1.CompareTo(p8) > 0) { temp = p1; p1 = p8; p8 = temp; }
			if (p2.CompareTo(p11) > 0) { temp = p2; p2 = p11; p11 = temp; }
			if (p3.CompareTo(p12) > 0) { temp = p3; p3 = p12; p12 = temp; }
			if (p3.CompareTo(p11) > 0) { temp = p3; p3 = p11; p11 = temp; }
			if (p2.CompareTo(p9) > 0) { temp = p2; p2 = p9; p9 = temp; }
			if (p2.CompareTo(p8) > 0) { temp = p2; p2 = p8; p8 = temp; }
			if (p3.CompareTo(p10) > 0) { temp = p3; p3 = p10; p10 = temp; }
			if (p3.CompareTo(p9) > 0) { temp = p3; p3 = p9; p9 = temp; }
			if (p3.CompareTo(p8) > 0) { temp = p3; p3 = p8; p8 = temp; }
			if (p4.CompareTo(p13) > 0) { temp = p4; p4 = p13; p13 = temp; }
			if (p5.CompareTo(p14) > 0) { temp = p5; p5 = p14; p14 = temp; }
			if (p5.CompareTo(p13) > 0) { temp = p5; p5 = p13; p13 = temp; }
			if (p6.CompareTo(p15) > 0) { temp = p6; p6 = p15; p15 = temp; }
			if (p7.CompareTo(p16) > 0) { temp = p7; p7 = p16; p16 = temp; }
			if (p7.CompareTo(p15) > 0) { temp = p7; p7 = p15; p15 = temp; }
			if (p6.CompareTo(p13) > 0) { temp = p6; p6 = p13; p13 = temp; }
			if (p7.CompareTo(p14) > 0) { temp = p7; p7 = p14; p14 = temp; }
			if (p7.CompareTo(p13) > 0) { temp = p7; p7 = p13; p13 = temp; }
			if (p4.CompareTo(p9) > 0) { temp = p4; p4 = p9; p9 = temp; }
			if (p4.CompareTo(p8) > 0) { temp = p4; p4 = p8; p8 = temp; }
			if (p5.CompareTo(p10) > 0) { temp = p5; p5 = p10; p10 = temp; }
			if (p5.CompareTo(p9) > 0) { temp = p5; p5 = p9; p9 = temp; }
			if (p5.CompareTo(p8) > 0) { temp = p5; p5 = p8; p8 = temp; }
			if (p6.CompareTo(p11) > 0) { temp = p6; p6 = p11; p11 = temp; }
			if (p7.CompareTo(p12) > 0) { temp = p7; p7 = p12; p12 = temp; }
			if (p7.CompareTo(p11) > 0) { temp = p7; p7 = p11; p11 = temp; }
			if (p6.CompareTo(p9) > 0) { temp = p6; p6 = p9; p9 = temp; }
			if (p6.CompareTo(p8) > 0) { temp = p6; p6 = p8; p8 = temp; }
			if (p7.CompareTo(p10) > 0) { temp = p7; p7 = p10; p10 = temp; }
			if (p7.CompareTo(p9) > 0) { temp = p7; p7 = p9; p9 = temp; }
			if (p7.CompareTo(p8) > 0) { temp = p7; p7 = p8; p8 = temp; }
#else
			if (GreaterThan(ref p0, ref p1)) { temp = p0; p0 = p1; p1 = temp; }
			if (GreaterThan(ref p2, ref p3)) { temp = p2; p2 = p3; p3 = temp; }
			if (GreaterThan(ref p0, ref p2)) { temp = p0; p0 = p2; p2 = temp; }
			if (GreaterThan(ref p1, ref p3)) { temp = p1; p1 = p3; p3 = temp; }
			if (GreaterThan(ref p1, ref p2)) { temp = p1; p1 = p2; p2 = temp; }
			if (GreaterThan(ref p4, ref p5)) { temp = p4; p4 = p5; p5 = temp; }
			if (GreaterThan(ref p6, ref p7)) { temp = p6; p6 = p7; p7 = temp; }
			if (GreaterThan(ref p4, ref p6)) { temp = p4; p4 = p6; p6 = temp; }
			if (GreaterThan(ref p5, ref p7)) { temp = p5; p5 = p7; p7 = temp; }
			if (GreaterThan(ref p5, ref p6)) { temp = p5; p5 = p6; p6 = temp; }
			if (GreaterThan(ref p0, ref p4)) { temp = p0; p0 = p4; p4 = temp; }
			if (GreaterThan(ref p1, ref p5)) { temp = p1; p1 = p5; p5 = temp; }
			if (GreaterThan(ref p1, ref p4)) { temp = p1; p1 = p4; p4 = temp; }
			if (GreaterThan(ref p2, ref p6)) { temp = p2; p2 = p6; p6 = temp; }
			if (GreaterThan(ref p3, ref p7)) { temp = p3; p3 = p7; p7 = temp; }
			if (GreaterThan(ref p3, ref p6)) { temp = p3; p3 = p6; p6 = temp; }
			if (GreaterThan(ref p2, ref p4)) { temp = p2; p2 = p4; p4 = temp; }
			if (GreaterThan(ref p3, ref p5)) { temp = p3; p3 = p5; p5 = temp; }
			if (GreaterThan(ref p3, ref p4)) { temp = p3; p3 = p4; p4 = temp; }
			if (GreaterThan(ref p8, ref p9)) { temp = p8; p8 = p9; p9 = temp; }
			if (GreaterThan(ref p10, ref p11)) { temp = p10; p10 = p11; p11 = temp; }
			if (GreaterThan(ref p8, ref p10)) { temp = p8; p8 = p10; p10 = temp; }
			if (GreaterThan(ref p9, ref p11)) { temp = p9; p9 = p11; p11 = temp; }
			if (GreaterThan(ref p9, ref p10)) { temp = p9; p9 = p10; p10 = temp; }
			if (GreaterThan(ref p12, ref p13)) { temp = p12; p12 = p13; p13 = temp; }
			if (GreaterThan(ref p15, ref p16)) { temp = p15; p15 = p16; p16 = temp; }
			if (GreaterThan(ref p14, ref p16)) { temp = p14; p14 = p16; p16 = temp; }
			if (GreaterThan(ref p14, ref p15)) { temp = p14; p14 = p15; p15 = temp; }
			if (GreaterThan(ref p12, ref p15)) { temp = p12; p12 = p15; p15 = temp; }
			if (GreaterThan(ref p12, ref p14)) { temp = p12; p12 = p14; p14 = temp; }
			if (GreaterThan(ref p13, ref p16)) { temp = p13; p13 = p16; p16 = temp; }
			if (GreaterThan(ref p13, ref p15)) { temp = p13; p13 = p15; p15 = temp; }
			if (GreaterThan(ref p13, ref p14)) { temp = p13; p13 = p14; p14 = temp; }
			if (GreaterThan(ref p8, ref p13)) { temp = p8; p8 = p13; p13 = temp; }
			if (GreaterThan(ref p8, ref p12)) { temp = p8; p8 = p12; p12 = temp; }
			if (GreaterThan(ref p9, ref p14)) { temp = p9; p9 = p14; p14 = temp; }
			if (GreaterThan(ref p9, ref p13)) { temp = p9; p9 = p13; p13 = temp; }
			if (GreaterThan(ref p9, ref p12)) { temp = p9; p9 = p12; p12 = temp; }
			if (GreaterThan(ref p10, ref p15)) { temp = p10; p10 = p15; p15 = temp; }
			if (GreaterThan(ref p11, ref p16)) { temp = p11; p11 = p16; p16 = temp; }
			if (GreaterThan(ref p11, ref p15)) { temp = p11; p11 = p15; p15 = temp; }
			if (GreaterThan(ref p10, ref p13)) { temp = p10; p10 = p13; p13 = temp; }
			if (GreaterThan(ref p10, ref p12)) { temp = p10; p10 = p12; p12 = temp; }
			if (GreaterThan(ref p11, ref p14)) { temp = p11; p11 = p14; p14 = temp; }
			if (GreaterThan(ref p11, ref p13)) { temp = p11; p11 = p13; p13 = temp; }
			if (GreaterThan(ref p11, ref p12)) { temp = p11; p11 = p12; p12 = temp; }
			if (GreaterThan(ref p0, ref p9)) { temp = p0; p0 = p9; p9 = temp; }
			if (GreaterThan(ref p0, ref p8)) { temp = p0; p0 = p8; p8 = temp; }
			if (GreaterThan(ref p1, ref p10)) { temp = p1; p1 = p10; p10 = temp; }
			if (GreaterThan(ref p1, ref p9)) { temp = p1; p1 = p9; p9 = temp; }
			if (GreaterThan(ref p1, ref p8)) { temp = p1; p1 = p8; p8 = temp; }
			if (GreaterThan(ref p2, ref p11)) { temp = p2; p2 = p11; p11 = temp; }
			if (GreaterThan(ref p3, ref p12)) { temp = p3; p3 = p12; p12 = temp; }
			if (GreaterThan(ref p3, ref p11)) { temp = p3; p3 = p11; p11 = temp; }
			if (GreaterThan(ref p2, ref p9)) { temp = p2; p2 = p9; p9 = temp; }
			if (GreaterThan(ref p2, ref p8)) { temp = p2; p2 = p8; p8 = temp; }
			if (GreaterThan(ref p3, ref p10)) { temp = p3; p3 = p10; p10 = temp; }
			if (GreaterThan(ref p3, ref p9)) { temp = p3; p3 = p9; p9 = temp; }
			if (GreaterThan(ref p3, ref p8)) { temp = p3; p3 = p8; p8 = temp; }
			if (GreaterThan(ref p4, ref p13)) { temp = p4; p4 = p13; p13 = temp; }
			if (GreaterThan(ref p5, ref p14)) { temp = p5; p5 = p14; p14 = temp; }
			if (GreaterThan(ref p5, ref p13)) { temp = p5; p5 = p13; p13 = temp; }
			if (GreaterThan(ref p6, ref p15)) { temp = p6; p6 = p15; p15 = temp; }
			if (GreaterThan(ref p7, ref p16)) { temp = p7; p7 = p16; p16 = temp; }
			if (GreaterThan(ref p7, ref p15)) { temp = p7; p7 = p15; p15 = temp; }
			if (GreaterThan(ref p6, ref p13)) { temp = p6; p6 = p13; p13 = temp; }
			if (GreaterThan(ref p7, ref p14)) { temp = p7; p7 = p14; p14 = temp; }
			if (GreaterThan(ref p7, ref p13)) { temp = p7; p7 = p13; p13 = temp; }
			if (GreaterThan(ref p4, ref p9)) { temp = p4; p4 = p9; p9 = temp; }
			if (GreaterThan(ref p4, ref p8)) { temp = p4; p4 = p8; p8 = temp; }
			if (GreaterThan(ref p5, ref p10)) { temp = p5; p5 = p10; p10 = temp; }
			if (GreaterThan(ref p5, ref p9)) { temp = p5; p5 = p9; p9 = temp; }
			if (GreaterThan(ref p5, ref p8)) { temp = p5; p5 = p8; p8 = temp; }
			if (GreaterThan(ref p6, ref p11)) { temp = p6; p6 = p11; p11 = temp; }
			if (GreaterThan(ref p7, ref p12)) { temp = p7; p7 = p12; p12 = temp; }
			if (GreaterThan(ref p7, ref p11)) { temp = p7; p7 = p11; p11 = temp; }
			if (GreaterThan(ref p6, ref p9)) { temp = p6; p6 = p9; p9 = temp; }
			if (GreaterThan(ref p6, ref p8)) { temp = p6; p6 = p8; p8 = temp; }
			if (GreaterThan(ref p7, ref p10)) { temp = p7; p7 = p10; p10 = temp; }
			if (GreaterThan(ref p7, ref p9)) { temp = p7; p7 = p9; p9 = temp; }
			if (GreaterThan(ref p7, ref p8)) { temp = p7; p7 = p8; p8 = temp; }
#endif
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
#if NETSTANDARD1_3
			if (p0.CompareTo(p1) > 0) { temp = p0; p0 = p1; p1 = temp; }
			if (p2.CompareTo(p3) > 0) { temp = p2; p2 = p3; p3 = temp; }
			if (p0.CompareTo(p2) > 0) { temp = p0; p0 = p2; p2 = temp; }
			if (p1.CompareTo(p3) > 0) { temp = p1; p1 = p3; p3 = temp; }
			if (p1.CompareTo(p2) > 0) { temp = p1; p1 = p2; p2 = temp; }
			if (p4.CompareTo(p5) > 0) { temp = p4; p4 = p5; p5 = temp; }
			if (p7.CompareTo(p8) > 0) { temp = p7; p7 = p8; p8 = temp; }
			if (p6.CompareTo(p8) > 0) { temp = p6; p6 = p8; p8 = temp; }
			if (p6.CompareTo(p7) > 0) { temp = p6; p6 = p7; p7 = temp; }
			if (p4.CompareTo(p7) > 0) { temp = p4; p4 = p7; p7 = temp; }
			if (p4.CompareTo(p6) > 0) { temp = p4; p4 = p6; p6 = temp; }
			if (p5.CompareTo(p8) > 0) { temp = p5; p5 = p8; p8 = temp; }
			if (p5.CompareTo(p7) > 0) { temp = p5; p5 = p7; p7 = temp; }
			if (p5.CompareTo(p6) > 0) { temp = p5; p5 = p6; p6 = temp; }
			if (p0.CompareTo(p5) > 0) { temp = p0; p0 = p5; p5 = temp; }
			if (p0.CompareTo(p4) > 0) { temp = p0; p0 = p4; p4 = temp; }
			if (p1.CompareTo(p6) > 0) { temp = p1; p1 = p6; p6 = temp; }
			if (p1.CompareTo(p5) > 0) { temp = p1; p1 = p5; p5 = temp; }
			if (p1.CompareTo(p4) > 0) { temp = p1; p1 = p4; p4 = temp; }
			if (p2.CompareTo(p7) > 0) { temp = p2; p2 = p7; p7 = temp; }
			if (p3.CompareTo(p8) > 0) { temp = p3; p3 = p8; p8 = temp; }
			if (p3.CompareTo(p7) > 0) { temp = p3; p3 = p7; p7 = temp; }
			if (p2.CompareTo(p5) > 0) { temp = p2; p2 = p5; p5 = temp; }
			if (p2.CompareTo(p4) > 0) { temp = p2; p2 = p4; p4 = temp; }
			if (p3.CompareTo(p6) > 0) { temp = p3; p3 = p6; p6 = temp; }
			if (p3.CompareTo(p5) > 0) { temp = p3; p3 = p5; p5 = temp; }
			if (p3.CompareTo(p4) > 0) { temp = p3; p3 = p4; p4 = temp; }
			if (p9.CompareTo(p10) > 0) { temp = p9; p9 = p10; p10 = temp; }
			if (p11.CompareTo(p12) > 0) { temp = p11; p11 = p12; p12 = temp; }
			if (p9.CompareTo(p11) > 0) { temp = p9; p9 = p11; p11 = temp; }
			if (p10.CompareTo(p12) > 0) { temp = p10; p10 = p12; p12 = temp; }
			if (p10.CompareTo(p11) > 0) { temp = p10; p10 = p11; p11 = temp; }
			if (p13.CompareTo(p14) > 0) { temp = p13; p13 = p14; p14 = temp; }
			if (p16.CompareTo(p17) > 0) { temp = p16; p16 = p17; p17 = temp; }
			if (p15.CompareTo(p17) > 0) { temp = p15; p15 = p17; p17 = temp; }
			if (p15.CompareTo(p16) > 0) { temp = p15; p15 = p16; p16 = temp; }
			if (p13.CompareTo(p16) > 0) { temp = p13; p13 = p16; p16 = temp; }
			if (p13.CompareTo(p15) > 0) { temp = p13; p13 = p15; p15 = temp; }
			if (p14.CompareTo(p17) > 0) { temp = p14; p14 = p17; p17 = temp; }
			if (p14.CompareTo(p16) > 0) { temp = p14; p14 = p16; p16 = temp; }
			if (p14.CompareTo(p15) > 0) { temp = p14; p14 = p15; p15 = temp; }
			if (p9.CompareTo(p14) > 0) { temp = p9; p9 = p14; p14 = temp; }
			if (p9.CompareTo(p13) > 0) { temp = p9; p9 = p13; p13 = temp; }
			if (p10.CompareTo(p15) > 0) { temp = p10; p10 = p15; p15 = temp; }
			if (p10.CompareTo(p14) > 0) { temp = p10; p10 = p14; p14 = temp; }
			if (p10.CompareTo(p13) > 0) { temp = p10; p10 = p13; p13 = temp; }
			if (p11.CompareTo(p16) > 0) { temp = p11; p11 = p16; p16 = temp; }
			if (p12.CompareTo(p17) > 0) { temp = p12; p12 = p17; p17 = temp; }
			if (p12.CompareTo(p16) > 0) { temp = p12; p12 = p16; p16 = temp; }
			if (p11.CompareTo(p14) > 0) { temp = p11; p11 = p14; p14 = temp; }
			if (p11.CompareTo(p13) > 0) { temp = p11; p11 = p13; p13 = temp; }
			if (p12.CompareTo(p15) > 0) { temp = p12; p12 = p15; p15 = temp; }
			if (p12.CompareTo(p14) > 0) { temp = p12; p12 = p14; p14 = temp; }
			if (p12.CompareTo(p13) > 0) { temp = p12; p12 = p13; p13 = temp; }
			if (p0.CompareTo(p10) > 0) { temp = p0; p0 = p10; p10 = temp; }
			if (p0.CompareTo(p9) > 0) { temp = p0; p0 = p9; p9 = temp; }
			if (p1.CompareTo(p11) > 0) { temp = p1; p1 = p11; p11 = temp; }
			if (p1.CompareTo(p10) > 0) { temp = p1; p1 = p10; p10 = temp; }
			if (p1.CompareTo(p9) > 0) { temp = p1; p1 = p9; p9 = temp; }
			if (p2.CompareTo(p12) > 0) { temp = p2; p2 = p12; p12 = temp; }
			if (p3.CompareTo(p13) > 0) { temp = p3; p3 = p13; p13 = temp; }
			if (p3.CompareTo(p12) > 0) { temp = p3; p3 = p12; p12 = temp; }
			if (p2.CompareTo(p10) > 0) { temp = p2; p2 = p10; p10 = temp; }
			if (p2.CompareTo(p9) > 0) { temp = p2; p2 = p9; p9 = temp; }
			if (p3.CompareTo(p11) > 0) { temp = p3; p3 = p11; p11 = temp; }
			if (p3.CompareTo(p10) > 0) { temp = p3; p3 = p10; p10 = temp; }
			if (p3.CompareTo(p9) > 0) { temp = p3; p3 = p9; p9 = temp; }
			if (p4.CompareTo(p14) > 0) { temp = p4; p4 = p14; p14 = temp; }
			if (p5.CompareTo(p15) > 0) { temp = p5; p5 = p15; p15 = temp; }
			if (p5.CompareTo(p14) > 0) { temp = p5; p5 = p14; p14 = temp; }
			if (p6.CompareTo(p16) > 0) { temp = p6; p6 = p16; p16 = temp; }
			if (p7.CompareTo(p17) > 0) { temp = p7; p7 = p17; p17 = temp; }
			if (p8.CompareTo(p17) > 0) { temp = p8; p8 = p17; p17 = temp; }
			if (p7.CompareTo(p16) > 0) { temp = p7; p7 = p16; p16 = temp; }
			if (p8.CompareTo(p16) > 0) { temp = p8; p8 = p16; p16 = temp; }
			if (p6.CompareTo(p14) > 0) { temp = p6; p6 = p14; p14 = temp; }
			if (p7.CompareTo(p15) > 0) { temp = p7; p7 = p15; p15 = temp; }
			if (p8.CompareTo(p15) > 0) { temp = p8; p8 = p15; p15 = temp; }
			if (p7.CompareTo(p14) > 0) { temp = p7; p7 = p14; p14 = temp; }
			if (p8.CompareTo(p14) > 0) { temp = p8; p8 = p14; p14 = temp; }
			if (p4.CompareTo(p10) > 0) { temp = p4; p4 = p10; p10 = temp; }
			if (p4.CompareTo(p9) > 0) { temp = p4; p4 = p9; p9 = temp; }
			if (p5.CompareTo(p11) > 0) { temp = p5; p5 = p11; p11 = temp; }
			if (p5.CompareTo(p10) > 0) { temp = p5; p5 = p10; p10 = temp; }
			if (p5.CompareTo(p9) > 0) { temp = p5; p5 = p9; p9 = temp; }
			if (p6.CompareTo(p12) > 0) { temp = p6; p6 = p12; p12 = temp; }
			if (p7.CompareTo(p13) > 0) { temp = p7; p7 = p13; p13 = temp; }
			if (p8.CompareTo(p13) > 0) { temp = p8; p8 = p13; p13 = temp; }
			if (p7.CompareTo(p12) > 0) { temp = p7; p7 = p12; p12 = temp; }
			if (p8.CompareTo(p12) > 0) { temp = p8; p8 = p12; p12 = temp; }
			if (p6.CompareTo(p10) > 0) { temp = p6; p6 = p10; p10 = temp; }
			if (p6.CompareTo(p9) > 0) { temp = p6; p6 = p9; p9 = temp; }
			if (p7.CompareTo(p11) > 0) { temp = p7; p7 = p11; p11 = temp; }
			if (p8.CompareTo(p11) > 0) { temp = p8; p8 = p11; p11 = temp; }
			if (p7.CompareTo(p9) > 0) { temp = p7; p7 = p9; p9 = temp; }
			if (p8.CompareTo(p10) > 0) { temp = p8; p8 = p10; p10 = temp; }
			if (p8.CompareTo(p9) > 0) { temp = p8; p8 = p9; p9 = temp; }
#else
			if (GreaterThan(ref p0, ref p1)) { temp = p0; p0 = p1; p1 = temp; }
			if (GreaterThan(ref p2, ref p3)) { temp = p2; p2 = p3; p3 = temp; }
			if (GreaterThan(ref p0, ref p2)) { temp = p0; p0 = p2; p2 = temp; }
			if (GreaterThan(ref p1, ref p3)) { temp = p1; p1 = p3; p3 = temp; }
			if (GreaterThan(ref p1, ref p2)) { temp = p1; p1 = p2; p2 = temp; }
			if (GreaterThan(ref p4, ref p5)) { temp = p4; p4 = p5; p5 = temp; }
			if (GreaterThan(ref p7, ref p8)) { temp = p7; p7 = p8; p8 = temp; }
			if (GreaterThan(ref p6, ref p8)) { temp = p6; p6 = p8; p8 = temp; }
			if (GreaterThan(ref p6, ref p7)) { temp = p6; p6 = p7; p7 = temp; }
			if (GreaterThan(ref p4, ref p7)) { temp = p4; p4 = p7; p7 = temp; }
			if (GreaterThan(ref p4, ref p6)) { temp = p4; p4 = p6; p6 = temp; }
			if (GreaterThan(ref p5, ref p8)) { temp = p5; p5 = p8; p8 = temp; }
			if (GreaterThan(ref p5, ref p7)) { temp = p5; p5 = p7; p7 = temp; }
			if (GreaterThan(ref p5, ref p6)) { temp = p5; p5 = p6; p6 = temp; }
			if (GreaterThan(ref p0, ref p5)) { temp = p0; p0 = p5; p5 = temp; }
			if (GreaterThan(ref p0, ref p4)) { temp = p0; p0 = p4; p4 = temp; }
			if (GreaterThan(ref p1, ref p6)) { temp = p1; p1 = p6; p6 = temp; }
			if (GreaterThan(ref p1, ref p5)) { temp = p1; p1 = p5; p5 = temp; }
			if (GreaterThan(ref p1, ref p4)) { temp = p1; p1 = p4; p4 = temp; }
			if (GreaterThan(ref p2, ref p7)) { temp = p2; p2 = p7; p7 = temp; }
			if (GreaterThan(ref p3, ref p8)) { temp = p3; p3 = p8; p8 = temp; }
			if (GreaterThan(ref p3, ref p7)) { temp = p3; p3 = p7; p7 = temp; }
			if (GreaterThan(ref p2, ref p5)) { temp = p2; p2 = p5; p5 = temp; }
			if (GreaterThan(ref p2, ref p4)) { temp = p2; p2 = p4; p4 = temp; }
			if (GreaterThan(ref p3, ref p6)) { temp = p3; p3 = p6; p6 = temp; }
			if (GreaterThan(ref p3, ref p5)) { temp = p3; p3 = p5; p5 = temp; }
			if (GreaterThan(ref p3, ref p4)) { temp = p3; p3 = p4; p4 = temp; }
			if (GreaterThan(ref p9, ref p10)) { temp = p9; p9 = p10; p10 = temp; }
			if (GreaterThan(ref p11, ref p12)) { temp = p11; p11 = p12; p12 = temp; }
			if (GreaterThan(ref p9, ref p11)) { temp = p9; p9 = p11; p11 = temp; }
			if (GreaterThan(ref p10, ref p12)) { temp = p10; p10 = p12; p12 = temp; }
			if (GreaterThan(ref p10, ref p11)) { temp = p10; p10 = p11; p11 = temp; }
			if (GreaterThan(ref p13, ref p14)) { temp = p13; p13 = p14; p14 = temp; }
			if (GreaterThan(ref p16, ref p17)) { temp = p16; p16 = p17; p17 = temp; }
			if (GreaterThan(ref p15, ref p17)) { temp = p15; p15 = p17; p17 = temp; }
			if (GreaterThan(ref p15, ref p16)) { temp = p15; p15 = p16; p16 = temp; }
			if (GreaterThan(ref p13, ref p16)) { temp = p13; p13 = p16; p16 = temp; }
			if (GreaterThan(ref p13, ref p15)) { temp = p13; p13 = p15; p15 = temp; }
			if (GreaterThan(ref p14, ref p17)) { temp = p14; p14 = p17; p17 = temp; }
			if (GreaterThan(ref p14, ref p16)) { temp = p14; p14 = p16; p16 = temp; }
			if (GreaterThan(ref p14, ref p15)) { temp = p14; p14 = p15; p15 = temp; }
			if (GreaterThan(ref p9, ref p14)) { temp = p9; p9 = p14; p14 = temp; }
			if (GreaterThan(ref p9, ref p13)) { temp = p9; p9 = p13; p13 = temp; }
			if (GreaterThan(ref p10, ref p15)) { temp = p10; p10 = p15; p15 = temp; }
			if (GreaterThan(ref p10, ref p14)) { temp = p10; p10 = p14; p14 = temp; }
			if (GreaterThan(ref p10, ref p13)) { temp = p10; p10 = p13; p13 = temp; }
			if (GreaterThan(ref p11, ref p16)) { temp = p11; p11 = p16; p16 = temp; }
			if (GreaterThan(ref p12, ref p17)) { temp = p12; p12 = p17; p17 = temp; }
			if (GreaterThan(ref p12, ref p16)) { temp = p12; p12 = p16; p16 = temp; }
			if (GreaterThan(ref p11, ref p14)) { temp = p11; p11 = p14; p14 = temp; }
			if (GreaterThan(ref p11, ref p13)) { temp = p11; p11 = p13; p13 = temp; }
			if (GreaterThan(ref p12, ref p15)) { temp = p12; p12 = p15; p15 = temp; }
			if (GreaterThan(ref p12, ref p14)) { temp = p12; p12 = p14; p14 = temp; }
			if (GreaterThan(ref p12, ref p13)) { temp = p12; p12 = p13; p13 = temp; }
			if (GreaterThan(ref p0, ref p10)) { temp = p0; p0 = p10; p10 = temp; }
			if (GreaterThan(ref p0, ref p9)) { temp = p0; p0 = p9; p9 = temp; }
			if (GreaterThan(ref p1, ref p11)) { temp = p1; p1 = p11; p11 = temp; }
			if (GreaterThan(ref p1, ref p10)) { temp = p1; p1 = p10; p10 = temp; }
			if (GreaterThan(ref p1, ref p9)) { temp = p1; p1 = p9; p9 = temp; }
			if (GreaterThan(ref p2, ref p12)) { temp = p2; p2 = p12; p12 = temp; }
			if (GreaterThan(ref p3, ref p13)) { temp = p3; p3 = p13; p13 = temp; }
			if (GreaterThan(ref p3, ref p12)) { temp = p3; p3 = p12; p12 = temp; }
			if (GreaterThan(ref p2, ref p10)) { temp = p2; p2 = p10; p10 = temp; }
			if (GreaterThan(ref p2, ref p9)) { temp = p2; p2 = p9; p9 = temp; }
			if (GreaterThan(ref p3, ref p11)) { temp = p3; p3 = p11; p11 = temp; }
			if (GreaterThan(ref p3, ref p10)) { temp = p3; p3 = p10; p10 = temp; }
			if (GreaterThan(ref p3, ref p9)) { temp = p3; p3 = p9; p9 = temp; }
			if (GreaterThan(ref p4, ref p14)) { temp = p4; p4 = p14; p14 = temp; }
			if (GreaterThan(ref p5, ref p15)) { temp = p5; p5 = p15; p15 = temp; }
			if (GreaterThan(ref p5, ref p14)) { temp = p5; p5 = p14; p14 = temp; }
			if (GreaterThan(ref p6, ref p16)) { temp = p6; p6 = p16; p16 = temp; }
			if (GreaterThan(ref p7, ref p17)) { temp = p7; p7 = p17; p17 = temp; }
			if (GreaterThan(ref p8, ref p17)) { temp = p8; p8 = p17; p17 = temp; }
			if (GreaterThan(ref p7, ref p16)) { temp = p7; p7 = p16; p16 = temp; }
			if (GreaterThan(ref p8, ref p16)) { temp = p8; p8 = p16; p16 = temp; }
			if (GreaterThan(ref p6, ref p14)) { temp = p6; p6 = p14; p14 = temp; }
			if (GreaterThan(ref p7, ref p15)) { temp = p7; p7 = p15; p15 = temp; }
			if (GreaterThan(ref p8, ref p15)) { temp = p8; p8 = p15; p15 = temp; }
			if (GreaterThan(ref p7, ref p14)) { temp = p7; p7 = p14; p14 = temp; }
			if (GreaterThan(ref p8, ref p14)) { temp = p8; p8 = p14; p14 = temp; }
			if (GreaterThan(ref p4, ref p10)) { temp = p4; p4 = p10; p10 = temp; }
			if (GreaterThan(ref p4, ref p9)) { temp = p4; p4 = p9; p9 = temp; }
			if (GreaterThan(ref p5, ref p11)) { temp = p5; p5 = p11; p11 = temp; }
			if (GreaterThan(ref p5, ref p10)) { temp = p5; p5 = p10; p10 = temp; }
			if (GreaterThan(ref p5, ref p9)) { temp = p5; p5 = p9; p9 = temp; }
			if (GreaterThan(ref p6, ref p12)) { temp = p6; p6 = p12; p12 = temp; }
			if (GreaterThan(ref p7, ref p13)) { temp = p7; p7 = p13; p13 = temp; }
			if (GreaterThan(ref p8, ref p13)) { temp = p8; p8 = p13; p13 = temp; }
			if (GreaterThan(ref p7, ref p12)) { temp = p7; p7 = p12; p12 = temp; }
			if (GreaterThan(ref p8, ref p12)) { temp = p8; p8 = p12; p12 = temp; }
			if (GreaterThan(ref p6, ref p10)) { temp = p6; p6 = p10; p10 = temp; }
			if (GreaterThan(ref p6, ref p9)) { temp = p6; p6 = p9; p9 = temp; }
			if (GreaterThan(ref p7, ref p11)) { temp = p7; p7 = p11; p11 = temp; }
			if (GreaterThan(ref p8, ref p11)) { temp = p8; p8 = p11; p11 = temp; }
			if (GreaterThan(ref p7, ref p9)) { temp = p7; p7 = p9; p9 = temp; }
			if (GreaterThan(ref p8, ref p10)) { temp = p8; p8 = p10; p10 = temp; }
			if (GreaterThan(ref p8, ref p9)) { temp = p8; p8 = p9; p9 = temp; }
#endif
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
#if NETSTANDARD1_3
			if (p0.CompareTo(p1) > 0) { temp = p0; p0 = p1; p1 = temp; }
			if (p2.CompareTo(p3) > 0) { temp = p2; p2 = p3; p3 = temp; }
			if (p0.CompareTo(p2) > 0) { temp = p0; p0 = p2; p2 = temp; }
			if (p1.CompareTo(p3) > 0) { temp = p1; p1 = p3; p3 = temp; }
			if (p1.CompareTo(p2) > 0) { temp = p1; p1 = p2; p2 = temp; }
			if (p4.CompareTo(p5) > 0) { temp = p4; p4 = p5; p5 = temp; }
			if (p7.CompareTo(p8) > 0) { temp = p7; p7 = p8; p8 = temp; }
			if (p6.CompareTo(p8) > 0) { temp = p6; p6 = p8; p8 = temp; }
			if (p6.CompareTo(p7) > 0) { temp = p6; p6 = p7; p7 = temp; }
			if (p4.CompareTo(p7) > 0) { temp = p4; p4 = p7; p7 = temp; }
			if (p4.CompareTo(p6) > 0) { temp = p4; p4 = p6; p6 = temp; }
			if (p5.CompareTo(p8) > 0) { temp = p5; p5 = p8; p8 = temp; }
			if (p5.CompareTo(p7) > 0) { temp = p5; p5 = p7; p7 = temp; }
			if (p5.CompareTo(p6) > 0) { temp = p5; p5 = p6; p6 = temp; }
			if (p0.CompareTo(p5) > 0) { temp = p0; p0 = p5; p5 = temp; }
			if (p0.CompareTo(p4) > 0) { temp = p0; p0 = p4; p4 = temp; }
			if (p1.CompareTo(p6) > 0) { temp = p1; p1 = p6; p6 = temp; }
			if (p1.CompareTo(p5) > 0) { temp = p1; p1 = p5; p5 = temp; }
			if (p1.CompareTo(p4) > 0) { temp = p1; p1 = p4; p4 = temp; }
			if (p2.CompareTo(p7) > 0) { temp = p2; p2 = p7; p7 = temp; }
			if (p3.CompareTo(p8) > 0) { temp = p3; p3 = p8; p8 = temp; }
			if (p3.CompareTo(p7) > 0) { temp = p3; p3 = p7; p7 = temp; }
			if (p2.CompareTo(p5) > 0) { temp = p2; p2 = p5; p5 = temp; }
			if (p2.CompareTo(p4) > 0) { temp = p2; p2 = p4; p4 = temp; }
			if (p3.CompareTo(p6) > 0) { temp = p3; p3 = p6; p6 = temp; }
			if (p3.CompareTo(p5) > 0) { temp = p3; p3 = p5; p5 = temp; }
			if (p3.CompareTo(p4) > 0) { temp = p3; p3 = p4; p4 = temp; }
			if (p9.CompareTo(p10) > 0) { temp = p9; p9 = p10; p10 = temp; }
			if (p12.CompareTo(p13) > 0) { temp = p12; p12 = p13; p13 = temp; }
			if (p11.CompareTo(p13) > 0) { temp = p11; p11 = p13; p13 = temp; }
			if (p11.CompareTo(p12) > 0) { temp = p11; p11 = p12; p12 = temp; }
			if (p9.CompareTo(p12) > 0) { temp = p9; p9 = p12; p12 = temp; }
			if (p9.CompareTo(p11) > 0) { temp = p9; p9 = p11; p11 = temp; }
			if (p10.CompareTo(p13) > 0) { temp = p10; p10 = p13; p13 = temp; }
			if (p10.CompareTo(p12) > 0) { temp = p10; p10 = p12; p12 = temp; }
			if (p10.CompareTo(p11) > 0) { temp = p10; p10 = p11; p11 = temp; }
			if (p14.CompareTo(p15) > 0) { temp = p14; p14 = p15; p15 = temp; }
			if (p17.CompareTo(p18) > 0) { temp = p17; p17 = p18; p18 = temp; }
			if (p16.CompareTo(p18) > 0) { temp = p16; p16 = p18; p18 = temp; }
			if (p16.CompareTo(p17) > 0) { temp = p16; p16 = p17; p17 = temp; }
			if (p14.CompareTo(p17) > 0) { temp = p14; p14 = p17; p17 = temp; }
			if (p14.CompareTo(p16) > 0) { temp = p14; p14 = p16; p16 = temp; }
			if (p15.CompareTo(p18) > 0) { temp = p15; p15 = p18; p18 = temp; }
			if (p15.CompareTo(p17) > 0) { temp = p15; p15 = p17; p17 = temp; }
			if (p15.CompareTo(p16) > 0) { temp = p15; p15 = p16; p16 = temp; }
			if (p9.CompareTo(p15) > 0) { temp = p9; p9 = p15; p15 = temp; }
			if (p9.CompareTo(p14) > 0) { temp = p9; p9 = p14; p14 = temp; }
			if (p10.CompareTo(p16) > 0) { temp = p10; p10 = p16; p16 = temp; }
			if (p10.CompareTo(p15) > 0) { temp = p10; p10 = p15; p15 = temp; }
			if (p10.CompareTo(p14) > 0) { temp = p10; p10 = p14; p14 = temp; }
			if (p11.CompareTo(p17) > 0) { temp = p11; p11 = p17; p17 = temp; }
			if (p12.CompareTo(p18) > 0) { temp = p12; p12 = p18; p18 = temp; }
			if (p13.CompareTo(p18) > 0) { temp = p13; p13 = p18; p18 = temp; }
			if (p12.CompareTo(p17) > 0) { temp = p12; p12 = p17; p17 = temp; }
			if (p13.CompareTo(p17) > 0) { temp = p13; p13 = p17; p17 = temp; }
			if (p11.CompareTo(p15) > 0) { temp = p11; p11 = p15; p15 = temp; }
			if (p11.CompareTo(p14) > 0) { temp = p11; p11 = p14; p14 = temp; }
			if (p12.CompareTo(p16) > 0) { temp = p12; p12 = p16; p16 = temp; }
			if (p13.CompareTo(p16) > 0) { temp = p13; p13 = p16; p16 = temp; }
			if (p12.CompareTo(p14) > 0) { temp = p12; p12 = p14; p14 = temp; }
			if (p13.CompareTo(p15) > 0) { temp = p13; p13 = p15; p15 = temp; }
			if (p13.CompareTo(p14) > 0) { temp = p13; p13 = p14; p14 = temp; }
			if (p0.CompareTo(p10) > 0) { temp = p0; p0 = p10; p10 = temp; }
			if (p0.CompareTo(p9) > 0) { temp = p0; p0 = p9; p9 = temp; }
			if (p1.CompareTo(p11) > 0) { temp = p1; p1 = p11; p11 = temp; }
			if (p1.CompareTo(p10) > 0) { temp = p1; p1 = p10; p10 = temp; }
			if (p1.CompareTo(p9) > 0) { temp = p1; p1 = p9; p9 = temp; }
			if (p2.CompareTo(p12) > 0) { temp = p2; p2 = p12; p12 = temp; }
			if (p3.CompareTo(p13) > 0) { temp = p3; p3 = p13; p13 = temp; }
			if (p3.CompareTo(p12) > 0) { temp = p3; p3 = p12; p12 = temp; }
			if (p2.CompareTo(p10) > 0) { temp = p2; p2 = p10; p10 = temp; }
			if (p2.CompareTo(p9) > 0) { temp = p2; p2 = p9; p9 = temp; }
			if (p3.CompareTo(p11) > 0) { temp = p3; p3 = p11; p11 = temp; }
			if (p3.CompareTo(p10) > 0) { temp = p3; p3 = p10; p10 = temp; }
			if (p3.CompareTo(p9) > 0) { temp = p3; p3 = p9; p9 = temp; }
			if (p4.CompareTo(p15) > 0) { temp = p4; p4 = p15; p15 = temp; }
			if (p4.CompareTo(p14) > 0) { temp = p4; p4 = p14; p14 = temp; }
			if (p5.CompareTo(p16) > 0) { temp = p5; p5 = p16; p16 = temp; }
			if (p5.CompareTo(p15) > 0) { temp = p5; p5 = p15; p15 = temp; }
			if (p5.CompareTo(p14) > 0) { temp = p5; p5 = p14; p14 = temp; }
			if (p6.CompareTo(p17) > 0) { temp = p6; p6 = p17; p17 = temp; }
			if (p7.CompareTo(p18) > 0) { temp = p7; p7 = p18; p18 = temp; }
			if (p8.CompareTo(p18) > 0) { temp = p8; p8 = p18; p18 = temp; }
			if (p7.CompareTo(p17) > 0) { temp = p7; p7 = p17; p17 = temp; }
			if (p8.CompareTo(p17) > 0) { temp = p8; p8 = p17; p17 = temp; }
			if (p6.CompareTo(p15) > 0) { temp = p6; p6 = p15; p15 = temp; }
			if (p6.CompareTo(p14) > 0) { temp = p6; p6 = p14; p14 = temp; }
			if (p7.CompareTo(p16) > 0) { temp = p7; p7 = p16; p16 = temp; }
			if (p8.CompareTo(p16) > 0) { temp = p8; p8 = p16; p16 = temp; }
			if (p7.CompareTo(p14) > 0) { temp = p7; p7 = p14; p14 = temp; }
			if (p8.CompareTo(p15) > 0) { temp = p8; p8 = p15; p15 = temp; }
			if (p8.CompareTo(p14) > 0) { temp = p8; p8 = p14; p14 = temp; }
			if (p4.CompareTo(p10) > 0) { temp = p4; p4 = p10; p10 = temp; }
			if (p4.CompareTo(p9) > 0) { temp = p4; p4 = p9; p9 = temp; }
			if (p5.CompareTo(p11) > 0) { temp = p5; p5 = p11; p11 = temp; }
			if (p5.CompareTo(p10) > 0) { temp = p5; p5 = p10; p10 = temp; }
			if (p5.CompareTo(p9) > 0) { temp = p5; p5 = p9; p9 = temp; }
			if (p6.CompareTo(p12) > 0) { temp = p6; p6 = p12; p12 = temp; }
			if (p7.CompareTo(p13) > 0) { temp = p7; p7 = p13; p13 = temp; }
			if (p8.CompareTo(p13) > 0) { temp = p8; p8 = p13; p13 = temp; }
			if (p7.CompareTo(p12) > 0) { temp = p7; p7 = p12; p12 = temp; }
			if (p8.CompareTo(p12) > 0) { temp = p8; p8 = p12; p12 = temp; }
			if (p6.CompareTo(p10) > 0) { temp = p6; p6 = p10; p10 = temp; }
			if (p6.CompareTo(p9) > 0) { temp = p6; p6 = p9; p9 = temp; }
			if (p7.CompareTo(p11) > 0) { temp = p7; p7 = p11; p11 = temp; }
			if (p8.CompareTo(p11) > 0) { temp = p8; p8 = p11; p11 = temp; }
			if (p7.CompareTo(p9) > 0) { temp = p7; p7 = p9; p9 = temp; }
			if (p8.CompareTo(p10) > 0) { temp = p8; p8 = p10; p10 = temp; }
			if (p8.CompareTo(p9) > 0) { temp = p8; p8 = p9; p9 = temp; }
#else
			if (GreaterThan(ref p0, ref p1)) { temp = p0; p0 = p1; p1 = temp; }
			if (GreaterThan(ref p2, ref p3)) { temp = p2; p2 = p3; p3 = temp; }
			if (GreaterThan(ref p0, ref p2)) { temp = p0; p0 = p2; p2 = temp; }
			if (GreaterThan(ref p1, ref p3)) { temp = p1; p1 = p3; p3 = temp; }
			if (GreaterThan(ref p1, ref p2)) { temp = p1; p1 = p2; p2 = temp; }
			if (GreaterThan(ref p4, ref p5)) { temp = p4; p4 = p5; p5 = temp; }
			if (GreaterThan(ref p7, ref p8)) { temp = p7; p7 = p8; p8 = temp; }
			if (GreaterThan(ref p6, ref p8)) { temp = p6; p6 = p8; p8 = temp; }
			if (GreaterThan(ref p6, ref p7)) { temp = p6; p6 = p7; p7 = temp; }
			if (GreaterThan(ref p4, ref p7)) { temp = p4; p4 = p7; p7 = temp; }
			if (GreaterThan(ref p4, ref p6)) { temp = p4; p4 = p6; p6 = temp; }
			if (GreaterThan(ref p5, ref p8)) { temp = p5; p5 = p8; p8 = temp; }
			if (GreaterThan(ref p5, ref p7)) { temp = p5; p5 = p7; p7 = temp; }
			if (GreaterThan(ref p5, ref p6)) { temp = p5; p5 = p6; p6 = temp; }
			if (GreaterThan(ref p0, ref p5)) { temp = p0; p0 = p5; p5 = temp; }
			if (GreaterThan(ref p0, ref p4)) { temp = p0; p0 = p4; p4 = temp; }
			if (GreaterThan(ref p1, ref p6)) { temp = p1; p1 = p6; p6 = temp; }
			if (GreaterThan(ref p1, ref p5)) { temp = p1; p1 = p5; p5 = temp; }
			if (GreaterThan(ref p1, ref p4)) { temp = p1; p1 = p4; p4 = temp; }
			if (GreaterThan(ref p2, ref p7)) { temp = p2; p2 = p7; p7 = temp; }
			if (GreaterThan(ref p3, ref p8)) { temp = p3; p3 = p8; p8 = temp; }
			if (GreaterThan(ref p3, ref p7)) { temp = p3; p3 = p7; p7 = temp; }
			if (GreaterThan(ref p2, ref p5)) { temp = p2; p2 = p5; p5 = temp; }
			if (GreaterThan(ref p2, ref p4)) { temp = p2; p2 = p4; p4 = temp; }
			if (GreaterThan(ref p3, ref p6)) { temp = p3; p3 = p6; p6 = temp; }
			if (GreaterThan(ref p3, ref p5)) { temp = p3; p3 = p5; p5 = temp; }
			if (GreaterThan(ref p3, ref p4)) { temp = p3; p3 = p4; p4 = temp; }
			if (GreaterThan(ref p9, ref p10)) { temp = p9; p9 = p10; p10 = temp; }
			if (GreaterThan(ref p12, ref p13)) { temp = p12; p12 = p13; p13 = temp; }
			if (GreaterThan(ref p11, ref p13)) { temp = p11; p11 = p13; p13 = temp; }
			if (GreaterThan(ref p11, ref p12)) { temp = p11; p11 = p12; p12 = temp; }
			if (GreaterThan(ref p9, ref p12)) { temp = p9; p9 = p12; p12 = temp; }
			if (GreaterThan(ref p9, ref p11)) { temp = p9; p9 = p11; p11 = temp; }
			if (GreaterThan(ref p10, ref p13)) { temp = p10; p10 = p13; p13 = temp; }
			if (GreaterThan(ref p10, ref p12)) { temp = p10; p10 = p12; p12 = temp; }
			if (GreaterThan(ref p10, ref p11)) { temp = p10; p10 = p11; p11 = temp; }
			if (GreaterThan(ref p14, ref p15)) { temp = p14; p14 = p15; p15 = temp; }
			if (GreaterThan(ref p17, ref p18)) { temp = p17; p17 = p18; p18 = temp; }
			if (GreaterThan(ref p16, ref p18)) { temp = p16; p16 = p18; p18 = temp; }
			if (GreaterThan(ref p16, ref p17)) { temp = p16; p16 = p17; p17 = temp; }
			if (GreaterThan(ref p14, ref p17)) { temp = p14; p14 = p17; p17 = temp; }
			if (GreaterThan(ref p14, ref p16)) { temp = p14; p14 = p16; p16 = temp; }
			if (GreaterThan(ref p15, ref p18)) { temp = p15; p15 = p18; p18 = temp; }
			if (GreaterThan(ref p15, ref p17)) { temp = p15; p15 = p17; p17 = temp; }
			if (GreaterThan(ref p15, ref p16)) { temp = p15; p15 = p16; p16 = temp; }
			if (GreaterThan(ref p9, ref p15)) { temp = p9; p9 = p15; p15 = temp; }
			if (GreaterThan(ref p9, ref p14)) { temp = p9; p9 = p14; p14 = temp; }
			if (GreaterThan(ref p10, ref p16)) { temp = p10; p10 = p16; p16 = temp; }
			if (GreaterThan(ref p10, ref p15)) { temp = p10; p10 = p15; p15 = temp; }
			if (GreaterThan(ref p10, ref p14)) { temp = p10; p10 = p14; p14 = temp; }
			if (GreaterThan(ref p11, ref p17)) { temp = p11; p11 = p17; p17 = temp; }
			if (GreaterThan(ref p12, ref p18)) { temp = p12; p12 = p18; p18 = temp; }
			if (GreaterThan(ref p13, ref p18)) { temp = p13; p13 = p18; p18 = temp; }
			if (GreaterThan(ref p12, ref p17)) { temp = p12; p12 = p17; p17 = temp; }
			if (GreaterThan(ref p13, ref p17)) { temp = p13; p13 = p17; p17 = temp; }
			if (GreaterThan(ref p11, ref p15)) { temp = p11; p11 = p15; p15 = temp; }
			if (GreaterThan(ref p11, ref p14)) { temp = p11; p11 = p14; p14 = temp; }
			if (GreaterThan(ref p12, ref p16)) { temp = p12; p12 = p16; p16 = temp; }
			if (GreaterThan(ref p13, ref p16)) { temp = p13; p13 = p16; p16 = temp; }
			if (GreaterThan(ref p12, ref p14)) { temp = p12; p12 = p14; p14 = temp; }
			if (GreaterThan(ref p13, ref p15)) { temp = p13; p13 = p15; p15 = temp; }
			if (GreaterThan(ref p13, ref p14)) { temp = p13; p13 = p14; p14 = temp; }
			if (GreaterThan(ref p0, ref p10)) { temp = p0; p0 = p10; p10 = temp; }
			if (GreaterThan(ref p0, ref p9)) { temp = p0; p0 = p9; p9 = temp; }
			if (GreaterThan(ref p1, ref p11)) { temp = p1; p1 = p11; p11 = temp; }
			if (GreaterThan(ref p1, ref p10)) { temp = p1; p1 = p10; p10 = temp; }
			if (GreaterThan(ref p1, ref p9)) { temp = p1; p1 = p9; p9 = temp; }
			if (GreaterThan(ref p2, ref p12)) { temp = p2; p2 = p12; p12 = temp; }
			if (GreaterThan(ref p3, ref p13)) { temp = p3; p3 = p13; p13 = temp; }
			if (GreaterThan(ref p3, ref p12)) { temp = p3; p3 = p12; p12 = temp; }
			if (GreaterThan(ref p2, ref p10)) { temp = p2; p2 = p10; p10 = temp; }
			if (GreaterThan(ref p2, ref p9)) { temp = p2; p2 = p9; p9 = temp; }
			if (GreaterThan(ref p3, ref p11)) { temp = p3; p3 = p11; p11 = temp; }
			if (GreaterThan(ref p3, ref p10)) { temp = p3; p3 = p10; p10 = temp; }
			if (GreaterThan(ref p3, ref p9)) { temp = p3; p3 = p9; p9 = temp; }
			if (GreaterThan(ref p4, ref p15)) { temp = p4; p4 = p15; p15 = temp; }
			if (GreaterThan(ref p4, ref p14)) { temp = p4; p4 = p14; p14 = temp; }
			if (GreaterThan(ref p5, ref p16)) { temp = p5; p5 = p16; p16 = temp; }
			if (GreaterThan(ref p5, ref p15)) { temp = p5; p5 = p15; p15 = temp; }
			if (GreaterThan(ref p5, ref p14)) { temp = p5; p5 = p14; p14 = temp; }
			if (GreaterThan(ref p6, ref p17)) { temp = p6; p6 = p17; p17 = temp; }
			if (GreaterThan(ref p7, ref p18)) { temp = p7; p7 = p18; p18 = temp; }
			if (GreaterThan(ref p8, ref p18)) { temp = p8; p8 = p18; p18 = temp; }
			if (GreaterThan(ref p7, ref p17)) { temp = p7; p7 = p17; p17 = temp; }
			if (GreaterThan(ref p8, ref p17)) { temp = p8; p8 = p17; p17 = temp; }
			if (GreaterThan(ref p6, ref p15)) { temp = p6; p6 = p15; p15 = temp; }
			if (GreaterThan(ref p6, ref p14)) { temp = p6; p6 = p14; p14 = temp; }
			if (GreaterThan(ref p7, ref p16)) { temp = p7; p7 = p16; p16 = temp; }
			if (GreaterThan(ref p8, ref p16)) { temp = p8; p8 = p16; p16 = temp; }
			if (GreaterThan(ref p7, ref p14)) { temp = p7; p7 = p14; p14 = temp; }
			if (GreaterThan(ref p8, ref p15)) { temp = p8; p8 = p15; p15 = temp; }
			if (GreaterThan(ref p8, ref p14)) { temp = p8; p8 = p14; p14 = temp; }
			if (GreaterThan(ref p4, ref p10)) { temp = p4; p4 = p10; p10 = temp; }
			if (GreaterThan(ref p4, ref p9)) { temp = p4; p4 = p9; p9 = temp; }
			if (GreaterThan(ref p5, ref p11)) { temp = p5; p5 = p11; p11 = temp; }
			if (GreaterThan(ref p5, ref p10)) { temp = p5; p5 = p10; p10 = temp; }
			if (GreaterThan(ref p5, ref p9)) { temp = p5; p5 = p9; p9 = temp; }
			if (GreaterThan(ref p6, ref p12)) { temp = p6; p6 = p12; p12 = temp; }
			if (GreaterThan(ref p7, ref p13)) { temp = p7; p7 = p13; p13 = temp; }
			if (GreaterThan(ref p8, ref p13)) { temp = p8; p8 = p13; p13 = temp; }
			if (GreaterThan(ref p7, ref p12)) { temp = p7; p7 = p12; p12 = temp; }
			if (GreaterThan(ref p8, ref p12)) { temp = p8; p8 = p12; p12 = temp; }
			if (GreaterThan(ref p6, ref p10)) { temp = p6; p6 = p10; p10 = temp; }
			if (GreaterThan(ref p6, ref p9)) { temp = p6; p6 = p9; p9 = temp; }
			if (GreaterThan(ref p7, ref p11)) { temp = p7; p7 = p11; p11 = temp; }
			if (GreaterThan(ref p8, ref p11)) { temp = p8; p8 = p11; p11 = temp; }
			if (GreaterThan(ref p7, ref p9)) { temp = p7; p7 = p9; p9 = temp; }
			if (GreaterThan(ref p8, ref p10)) { temp = p8; p8 = p10; p10 = temp; }
			if (GreaterThan(ref p8, ref p9)) { temp = p8; p8 = p9; p9 = temp; }
#endif
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
#if NETSTANDARD1_3
			if (p0.CompareTo(p1) > 0) { temp = p0; p0 = p1; p1 = temp; }
			if (p3.CompareTo(p4) > 0) { temp = p3; p3 = p4; p4 = temp; }
			if (p2.CompareTo(p4) > 0) { temp = p2; p2 = p4; p4 = temp; }
			if (p2.CompareTo(p3) > 0) { temp = p2; p2 = p3; p3 = temp; }
			if (p0.CompareTo(p3) > 0) { temp = p0; p0 = p3; p3 = temp; }
			if (p0.CompareTo(p2) > 0) { temp = p0; p0 = p2; p2 = temp; }
			if (p1.CompareTo(p4) > 0) { temp = p1; p1 = p4; p4 = temp; }
			if (p1.CompareTo(p3) > 0) { temp = p1; p1 = p3; p3 = temp; }
			if (p1.CompareTo(p2) > 0) { temp = p1; p1 = p2; p2 = temp; }
			if (p5.CompareTo(p6) > 0) { temp = p5; p5 = p6; p6 = temp; }
			if (p8.CompareTo(p9) > 0) { temp = p8; p8 = p9; p9 = temp; }
			if (p7.CompareTo(p9) > 0) { temp = p7; p7 = p9; p9 = temp; }
			if (p7.CompareTo(p8) > 0) { temp = p7; p7 = p8; p8 = temp; }
			if (p5.CompareTo(p8) > 0) { temp = p5; p5 = p8; p8 = temp; }
			if (p5.CompareTo(p7) > 0) { temp = p5; p5 = p7; p7 = temp; }
			if (p6.CompareTo(p9) > 0) { temp = p6; p6 = p9; p9 = temp; }
			if (p6.CompareTo(p8) > 0) { temp = p6; p6 = p8; p8 = temp; }
			if (p6.CompareTo(p7) > 0) { temp = p6; p6 = p7; p7 = temp; }
			if (p0.CompareTo(p6) > 0) { temp = p0; p0 = p6; p6 = temp; }
			if (p0.CompareTo(p5) > 0) { temp = p0; p0 = p5; p5 = temp; }
			if (p1.CompareTo(p7) > 0) { temp = p1; p1 = p7; p7 = temp; }
			if (p1.CompareTo(p6) > 0) { temp = p1; p1 = p6; p6 = temp; }
			if (p1.CompareTo(p5) > 0) { temp = p1; p1 = p5; p5 = temp; }
			if (p2.CompareTo(p8) > 0) { temp = p2; p2 = p8; p8 = temp; }
			if (p3.CompareTo(p9) > 0) { temp = p3; p3 = p9; p9 = temp; }
			if (p4.CompareTo(p9) > 0) { temp = p4; p4 = p9; p9 = temp; }
			if (p3.CompareTo(p8) > 0) { temp = p3; p3 = p8; p8 = temp; }
			if (p4.CompareTo(p8) > 0) { temp = p4; p4 = p8; p8 = temp; }
			if (p2.CompareTo(p6) > 0) { temp = p2; p2 = p6; p6 = temp; }
			if (p2.CompareTo(p5) > 0) { temp = p2; p2 = p5; p5 = temp; }
			if (p3.CompareTo(p7) > 0) { temp = p3; p3 = p7; p7 = temp; }
			if (p4.CompareTo(p7) > 0) { temp = p4; p4 = p7; p7 = temp; }
			if (p3.CompareTo(p5) > 0) { temp = p3; p3 = p5; p5 = temp; }
			if (p4.CompareTo(p6) > 0) { temp = p4; p4 = p6; p6 = temp; }
			if (p4.CompareTo(p5) > 0) { temp = p4; p4 = p5; p5 = temp; }
			if (p10.CompareTo(p11) > 0) { temp = p10; p10 = p11; p11 = temp; }
			if (p13.CompareTo(p14) > 0) { temp = p13; p13 = p14; p14 = temp; }
			if (p12.CompareTo(p14) > 0) { temp = p12; p12 = p14; p14 = temp; }
			if (p12.CompareTo(p13) > 0) { temp = p12; p12 = p13; p13 = temp; }
			if (p10.CompareTo(p13) > 0) { temp = p10; p10 = p13; p13 = temp; }
			if (p10.CompareTo(p12) > 0) { temp = p10; p10 = p12; p12 = temp; }
			if (p11.CompareTo(p14) > 0) { temp = p11; p11 = p14; p14 = temp; }
			if (p11.CompareTo(p13) > 0) { temp = p11; p11 = p13; p13 = temp; }
			if (p11.CompareTo(p12) > 0) { temp = p11; p11 = p12; p12 = temp; }
			if (p15.CompareTo(p16) > 0) { temp = p15; p15 = p16; p16 = temp; }
			if (p18.CompareTo(p19) > 0) { temp = p18; p18 = p19; p19 = temp; }
			if (p17.CompareTo(p19) > 0) { temp = p17; p17 = p19; p19 = temp; }
			if (p17.CompareTo(p18) > 0) { temp = p17; p17 = p18; p18 = temp; }
			if (p15.CompareTo(p18) > 0) { temp = p15; p15 = p18; p18 = temp; }
			if (p15.CompareTo(p17) > 0) { temp = p15; p15 = p17; p17 = temp; }
			if (p16.CompareTo(p19) > 0) { temp = p16; p16 = p19; p19 = temp; }
			if (p16.CompareTo(p18) > 0) { temp = p16; p16 = p18; p18 = temp; }
			if (p16.CompareTo(p17) > 0) { temp = p16; p16 = p17; p17 = temp; }
			if (p10.CompareTo(p16) > 0) { temp = p10; p10 = p16; p16 = temp; }
			if (p10.CompareTo(p15) > 0) { temp = p10; p10 = p15; p15 = temp; }
			if (p11.CompareTo(p17) > 0) { temp = p11; p11 = p17; p17 = temp; }
			if (p11.CompareTo(p16) > 0) { temp = p11; p11 = p16; p16 = temp; }
			if (p11.CompareTo(p15) > 0) { temp = p11; p11 = p15; p15 = temp; }
			if (p12.CompareTo(p18) > 0) { temp = p12; p12 = p18; p18 = temp; }
			if (p13.CompareTo(p19) > 0) { temp = p13; p13 = p19; p19 = temp; }
			if (p14.CompareTo(p19) > 0) { temp = p14; p14 = p19; p19 = temp; }
			if (p13.CompareTo(p18) > 0) { temp = p13; p13 = p18; p18 = temp; }
			if (p14.CompareTo(p18) > 0) { temp = p14; p14 = p18; p18 = temp; }
			if (p12.CompareTo(p16) > 0) { temp = p12; p12 = p16; p16 = temp; }
			if (p12.CompareTo(p15) > 0) { temp = p12; p12 = p15; p15 = temp; }
			if (p13.CompareTo(p17) > 0) { temp = p13; p13 = p17; p17 = temp; }
			if (p14.CompareTo(p17) > 0) { temp = p14; p14 = p17; p17 = temp; }
			if (p13.CompareTo(p15) > 0) { temp = p13; p13 = p15; p15 = temp; }
			if (p14.CompareTo(p16) > 0) { temp = p14; p14 = p16; p16 = temp; }
			if (p14.CompareTo(p15) > 0) { temp = p14; p14 = p15; p15 = temp; }
			if (p0.CompareTo(p11) > 0) { temp = p0; p0 = p11; p11 = temp; }
			if (p0.CompareTo(p10) > 0) { temp = p0; p0 = p10; p10 = temp; }
			if (p1.CompareTo(p12) > 0) { temp = p1; p1 = p12; p12 = temp; }
			if (p1.CompareTo(p11) > 0) { temp = p1; p1 = p11; p11 = temp; }
			if (p1.CompareTo(p10) > 0) { temp = p1; p1 = p10; p10 = temp; }
			if (p2.CompareTo(p13) > 0) { temp = p2; p2 = p13; p13 = temp; }
			if (p3.CompareTo(p14) > 0) { temp = p3; p3 = p14; p14 = temp; }
			if (p4.CompareTo(p14) > 0) { temp = p4; p4 = p14; p14 = temp; }
			if (p3.CompareTo(p13) > 0) { temp = p3; p3 = p13; p13 = temp; }
			if (p4.CompareTo(p13) > 0) { temp = p4; p4 = p13; p13 = temp; }
			if (p2.CompareTo(p11) > 0) { temp = p2; p2 = p11; p11 = temp; }
			if (p2.CompareTo(p10) > 0) { temp = p2; p2 = p10; p10 = temp; }
			if (p3.CompareTo(p12) > 0) { temp = p3; p3 = p12; p12 = temp; }
			if (p4.CompareTo(p12) > 0) { temp = p4; p4 = p12; p12 = temp; }
			if (p3.CompareTo(p10) > 0) { temp = p3; p3 = p10; p10 = temp; }
			if (p4.CompareTo(p11) > 0) { temp = p4; p4 = p11; p11 = temp; }
			if (p4.CompareTo(p10) > 0) { temp = p4; p4 = p10; p10 = temp; }
			if (p5.CompareTo(p16) > 0) { temp = p5; p5 = p16; p16 = temp; }
			if (p5.CompareTo(p15) > 0) { temp = p5; p5 = p15; p15 = temp; }
			if (p6.CompareTo(p17) > 0) { temp = p6; p6 = p17; p17 = temp; }
			if (p6.CompareTo(p16) > 0) { temp = p6; p6 = p16; p16 = temp; }
			if (p6.CompareTo(p15) > 0) { temp = p6; p6 = p15; p15 = temp; }
			if (p7.CompareTo(p18) > 0) { temp = p7; p7 = p18; p18 = temp; }
			if (p8.CompareTo(p19) > 0) { temp = p8; p8 = p19; p19 = temp; }
			if (p9.CompareTo(p19) > 0) { temp = p9; p9 = p19; p19 = temp; }
			if (p8.CompareTo(p18) > 0) { temp = p8; p8 = p18; p18 = temp; }
			if (p9.CompareTo(p18) > 0) { temp = p9; p9 = p18; p18 = temp; }
			if (p7.CompareTo(p16) > 0) { temp = p7; p7 = p16; p16 = temp; }
			if (p7.CompareTo(p15) > 0) { temp = p7; p7 = p15; p15 = temp; }
			if (p8.CompareTo(p17) > 0) { temp = p8; p8 = p17; p17 = temp; }
			if (p9.CompareTo(p17) > 0) { temp = p9; p9 = p17; p17 = temp; }
			if (p8.CompareTo(p15) > 0) { temp = p8; p8 = p15; p15 = temp; }
			if (p9.CompareTo(p16) > 0) { temp = p9; p9 = p16; p16 = temp; }
			if (p9.CompareTo(p15) > 0) { temp = p9; p9 = p15; p15 = temp; }
			if (p5.CompareTo(p11) > 0) { temp = p5; p5 = p11; p11 = temp; }
			if (p5.CompareTo(p10) > 0) { temp = p5; p5 = p10; p10 = temp; }
			if (p6.CompareTo(p12) > 0) { temp = p6; p6 = p12; p12 = temp; }
			if (p6.CompareTo(p11) > 0) { temp = p6; p6 = p11; p11 = temp; }
			if (p6.CompareTo(p10) > 0) { temp = p6; p6 = p10; p10 = temp; }
			if (p7.CompareTo(p13) > 0) { temp = p7; p7 = p13; p13 = temp; }
			if (p8.CompareTo(p14) > 0) { temp = p8; p8 = p14; p14 = temp; }
			if (p9.CompareTo(p14) > 0) { temp = p9; p9 = p14; p14 = temp; }
			if (p8.CompareTo(p13) > 0) { temp = p8; p8 = p13; p13 = temp; }
			if (p9.CompareTo(p13) > 0) { temp = p9; p9 = p13; p13 = temp; }
			if (p7.CompareTo(p11) > 0) { temp = p7; p7 = p11; p11 = temp; }
			if (p7.CompareTo(p10) > 0) { temp = p7; p7 = p10; p10 = temp; }
			if (p8.CompareTo(p12) > 0) { temp = p8; p8 = p12; p12 = temp; }
			if (p9.CompareTo(p12) > 0) { temp = p9; p9 = p12; p12 = temp; }
			if (p8.CompareTo(p10) > 0) { temp = p8; p8 = p10; p10 = temp; }
			if (p9.CompareTo(p11) > 0) { temp = p9; p9 = p11; p11 = temp; }
			if (p9.CompareTo(p10) > 0) { temp = p9; p9 = p10; p10 = temp; }
#else
			if (GreaterThan(ref p0, ref p1)) { temp = p0; p0 = p1; p1 = temp; }
			if (GreaterThan(ref p3, ref p4)) { temp = p3; p3 = p4; p4 = temp; }
			if (GreaterThan(ref p2, ref p4)) { temp = p2; p2 = p4; p4 = temp; }
			if (GreaterThan(ref p2, ref p3)) { temp = p2; p2 = p3; p3 = temp; }
			if (GreaterThan(ref p0, ref p3)) { temp = p0; p0 = p3; p3 = temp; }
			if (GreaterThan(ref p0, ref p2)) { temp = p0; p0 = p2; p2 = temp; }
			if (GreaterThan(ref p1, ref p4)) { temp = p1; p1 = p4; p4 = temp; }
			if (GreaterThan(ref p1, ref p3)) { temp = p1; p1 = p3; p3 = temp; }
			if (GreaterThan(ref p1, ref p2)) { temp = p1; p1 = p2; p2 = temp; }
			if (GreaterThan(ref p5, ref p6)) { temp = p5; p5 = p6; p6 = temp; }
			if (GreaterThan(ref p8, ref p9)) { temp = p8; p8 = p9; p9 = temp; }
			if (GreaterThan(ref p7, ref p9)) { temp = p7; p7 = p9; p9 = temp; }
			if (GreaterThan(ref p7, ref p8)) { temp = p7; p7 = p8; p8 = temp; }
			if (GreaterThan(ref p5, ref p8)) { temp = p5; p5 = p8; p8 = temp; }
			if (GreaterThan(ref p5, ref p7)) { temp = p5; p5 = p7; p7 = temp; }
			if (GreaterThan(ref p6, ref p9)) { temp = p6; p6 = p9; p9 = temp; }
			if (GreaterThan(ref p6, ref p8)) { temp = p6; p6 = p8; p8 = temp; }
			if (GreaterThan(ref p6, ref p7)) { temp = p6; p6 = p7; p7 = temp; }
			if (GreaterThan(ref p0, ref p6)) { temp = p0; p0 = p6; p6 = temp; }
			if (GreaterThan(ref p0, ref p5)) { temp = p0; p0 = p5; p5 = temp; }
			if (GreaterThan(ref p1, ref p7)) { temp = p1; p1 = p7; p7 = temp; }
			if (GreaterThan(ref p1, ref p6)) { temp = p1; p1 = p6; p6 = temp; }
			if (GreaterThan(ref p1, ref p5)) { temp = p1; p1 = p5; p5 = temp; }
			if (GreaterThan(ref p2, ref p8)) { temp = p2; p2 = p8; p8 = temp; }
			if (GreaterThan(ref p3, ref p9)) { temp = p3; p3 = p9; p9 = temp; }
			if (GreaterThan(ref p4, ref p9)) { temp = p4; p4 = p9; p9 = temp; }
			if (GreaterThan(ref p3, ref p8)) { temp = p3; p3 = p8; p8 = temp; }
			if (GreaterThan(ref p4, ref p8)) { temp = p4; p4 = p8; p8 = temp; }
			if (GreaterThan(ref p2, ref p6)) { temp = p2; p2 = p6; p6 = temp; }
			if (GreaterThan(ref p2, ref p5)) { temp = p2; p2 = p5; p5 = temp; }
			if (GreaterThan(ref p3, ref p7)) { temp = p3; p3 = p7; p7 = temp; }
			if (GreaterThan(ref p4, ref p7)) { temp = p4; p4 = p7; p7 = temp; }
			if (GreaterThan(ref p3, ref p5)) { temp = p3; p3 = p5; p5 = temp; }
			if (GreaterThan(ref p4, ref p6)) { temp = p4; p4 = p6; p6 = temp; }
			if (GreaterThan(ref p4, ref p5)) { temp = p4; p4 = p5; p5 = temp; }
			if (GreaterThan(ref p10, ref p11)) { temp = p10; p10 = p11; p11 = temp; }
			if (GreaterThan(ref p13, ref p14)) { temp = p13; p13 = p14; p14 = temp; }
			if (GreaterThan(ref p12, ref p14)) { temp = p12; p12 = p14; p14 = temp; }
			if (GreaterThan(ref p12, ref p13)) { temp = p12; p12 = p13; p13 = temp; }
			if (GreaterThan(ref p10, ref p13)) { temp = p10; p10 = p13; p13 = temp; }
			if (GreaterThan(ref p10, ref p12)) { temp = p10; p10 = p12; p12 = temp; }
			if (GreaterThan(ref p11, ref p14)) { temp = p11; p11 = p14; p14 = temp; }
			if (GreaterThan(ref p11, ref p13)) { temp = p11; p11 = p13; p13 = temp; }
			if (GreaterThan(ref p11, ref p12)) { temp = p11; p11 = p12; p12 = temp; }
			if (GreaterThan(ref p15, ref p16)) { temp = p15; p15 = p16; p16 = temp; }
			if (GreaterThan(ref p18, ref p19)) { temp = p18; p18 = p19; p19 = temp; }
			if (GreaterThan(ref p17, ref p19)) { temp = p17; p17 = p19; p19 = temp; }
			if (GreaterThan(ref p17, ref p18)) { temp = p17; p17 = p18; p18 = temp; }
			if (GreaterThan(ref p15, ref p18)) { temp = p15; p15 = p18; p18 = temp; }
			if (GreaterThan(ref p15, ref p17)) { temp = p15; p15 = p17; p17 = temp; }
			if (GreaterThan(ref p16, ref p19)) { temp = p16; p16 = p19; p19 = temp; }
			if (GreaterThan(ref p16, ref p18)) { temp = p16; p16 = p18; p18 = temp; }
			if (GreaterThan(ref p16, ref p17)) { temp = p16; p16 = p17; p17 = temp; }
			if (GreaterThan(ref p10, ref p16)) { temp = p10; p10 = p16; p16 = temp; }
			if (GreaterThan(ref p10, ref p15)) { temp = p10; p10 = p15; p15 = temp; }
			if (GreaterThan(ref p11, ref p17)) { temp = p11; p11 = p17; p17 = temp; }
			if (GreaterThan(ref p11, ref p16)) { temp = p11; p11 = p16; p16 = temp; }
			if (GreaterThan(ref p11, ref p15)) { temp = p11; p11 = p15; p15 = temp; }
			if (GreaterThan(ref p12, ref p18)) { temp = p12; p12 = p18; p18 = temp; }
			if (GreaterThan(ref p13, ref p19)) { temp = p13; p13 = p19; p19 = temp; }
			if (GreaterThan(ref p14, ref p19)) { temp = p14; p14 = p19; p19 = temp; }
			if (GreaterThan(ref p13, ref p18)) { temp = p13; p13 = p18; p18 = temp; }
			if (GreaterThan(ref p14, ref p18)) { temp = p14; p14 = p18; p18 = temp; }
			if (GreaterThan(ref p12, ref p16)) { temp = p12; p12 = p16; p16 = temp; }
			if (GreaterThan(ref p12, ref p15)) { temp = p12; p12 = p15; p15 = temp; }
			if (GreaterThan(ref p13, ref p17)) { temp = p13; p13 = p17; p17 = temp; }
			if (GreaterThan(ref p14, ref p17)) { temp = p14; p14 = p17; p17 = temp; }
			if (GreaterThan(ref p13, ref p15)) { temp = p13; p13 = p15; p15 = temp; }
			if (GreaterThan(ref p14, ref p16)) { temp = p14; p14 = p16; p16 = temp; }
			if (GreaterThan(ref p14, ref p15)) { temp = p14; p14 = p15; p15 = temp; }
			if (GreaterThan(ref p0, ref p11)) { temp = p0; p0 = p11; p11 = temp; }
			if (GreaterThan(ref p0, ref p10)) { temp = p0; p0 = p10; p10 = temp; }
			if (GreaterThan(ref p1, ref p12)) { temp = p1; p1 = p12; p12 = temp; }
			if (GreaterThan(ref p1, ref p11)) { temp = p1; p1 = p11; p11 = temp; }
			if (GreaterThan(ref p1, ref p10)) { temp = p1; p1 = p10; p10 = temp; }
			if (GreaterThan(ref p2, ref p13)) { temp = p2; p2 = p13; p13 = temp; }
			if (GreaterThan(ref p3, ref p14)) { temp = p3; p3 = p14; p14 = temp; }
			if (GreaterThan(ref p4, ref p14)) { temp = p4; p4 = p14; p14 = temp; }
			if (GreaterThan(ref p3, ref p13)) { temp = p3; p3 = p13; p13 = temp; }
			if (GreaterThan(ref p4, ref p13)) { temp = p4; p4 = p13; p13 = temp; }
			if (GreaterThan(ref p2, ref p11)) { temp = p2; p2 = p11; p11 = temp; }
			if (GreaterThan(ref p2, ref p10)) { temp = p2; p2 = p10; p10 = temp; }
			if (GreaterThan(ref p3, ref p12)) { temp = p3; p3 = p12; p12 = temp; }
			if (GreaterThan(ref p4, ref p12)) { temp = p4; p4 = p12; p12 = temp; }
			if (GreaterThan(ref p3, ref p10)) { temp = p3; p3 = p10; p10 = temp; }
			if (GreaterThan(ref p4, ref p11)) { temp = p4; p4 = p11; p11 = temp; }
			if (GreaterThan(ref p4, ref p10)) { temp = p4; p4 = p10; p10 = temp; }
			if (GreaterThan(ref p5, ref p16)) { temp = p5; p5 = p16; p16 = temp; }
			if (GreaterThan(ref p5, ref p15)) { temp = p5; p5 = p15; p15 = temp; }
			if (GreaterThan(ref p6, ref p17)) { temp = p6; p6 = p17; p17 = temp; }
			if (GreaterThan(ref p6, ref p16)) { temp = p6; p6 = p16; p16 = temp; }
			if (GreaterThan(ref p6, ref p15)) { temp = p6; p6 = p15; p15 = temp; }
			if (GreaterThan(ref p7, ref p18)) { temp = p7; p7 = p18; p18 = temp; }
			if (GreaterThan(ref p8, ref p19)) { temp = p8; p8 = p19; p19 = temp; }
			if (GreaterThan(ref p9, ref p19)) { temp = p9; p9 = p19; p19 = temp; }
			if (GreaterThan(ref p8, ref p18)) { temp = p8; p8 = p18; p18 = temp; }
			if (GreaterThan(ref p9, ref p18)) { temp = p9; p9 = p18; p18 = temp; }
			if (GreaterThan(ref p7, ref p16)) { temp = p7; p7 = p16; p16 = temp; }
			if (GreaterThan(ref p7, ref p15)) { temp = p7; p7 = p15; p15 = temp; }
			if (GreaterThan(ref p8, ref p17)) { temp = p8; p8 = p17; p17 = temp; }
			if (GreaterThan(ref p9, ref p17)) { temp = p9; p9 = p17; p17 = temp; }
			if (GreaterThan(ref p8, ref p15)) { temp = p8; p8 = p15; p15 = temp; }
			if (GreaterThan(ref p9, ref p16)) { temp = p9; p9 = p16; p16 = temp; }
			if (GreaterThan(ref p9, ref p15)) { temp = p9; p9 = p15; p15 = temp; }
			if (GreaterThan(ref p5, ref p11)) { temp = p5; p5 = p11; p11 = temp; }
			if (GreaterThan(ref p5, ref p10)) { temp = p5; p5 = p10; p10 = temp; }
			if (GreaterThan(ref p6, ref p12)) { temp = p6; p6 = p12; p12 = temp; }
			if (GreaterThan(ref p6, ref p11)) { temp = p6; p6 = p11; p11 = temp; }
			if (GreaterThan(ref p6, ref p10)) { temp = p6; p6 = p10; p10 = temp; }
			if (GreaterThan(ref p7, ref p13)) { temp = p7; p7 = p13; p13 = temp; }
			if (GreaterThan(ref p8, ref p14)) { temp = p8; p8 = p14; p14 = temp; }
			if (GreaterThan(ref p9, ref p14)) { temp = p9; p9 = p14; p14 = temp; }
			if (GreaterThan(ref p8, ref p13)) { temp = p8; p8 = p13; p13 = temp; }
			if (GreaterThan(ref p9, ref p13)) { temp = p9; p9 = p13; p13 = temp; }
			if (GreaterThan(ref p7, ref p11)) { temp = p7; p7 = p11; p11 = temp; }
			if (GreaterThan(ref p7, ref p10)) { temp = p7; p7 = p10; p10 = temp; }
			if (GreaterThan(ref p8, ref p12)) { temp = p8; p8 = p12; p12 = temp; }
			if (GreaterThan(ref p9, ref p12)) { temp = p9; p9 = p12; p12 = temp; }
			if (GreaterThan(ref p8, ref p10)) { temp = p8; p8 = p10; p10 = temp; }
			if (GreaterThan(ref p9, ref p11)) { temp = p9; p9 = p11; p11 = temp; }
			if (GreaterThan(ref p9, ref p10)) { temp = p9; p9 = p10; p10 = temp; }
#endif
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
#if NETSTANDARD1_3
			if (p0.CompareTo(p1) > 0) { temp = p0; p0 = p1; p1 = temp; }
			if (p3.CompareTo(p4) > 0) { temp = p3; p3 = p4; p4 = temp; }
			if (p2.CompareTo(p4) > 0) { temp = p2; p2 = p4; p4 = temp; }
			if (p2.CompareTo(p3) > 0) { temp = p2; p2 = p3; p3 = temp; }
			if (p0.CompareTo(p3) > 0) { temp = p0; p0 = p3; p3 = temp; }
			if (p0.CompareTo(p2) > 0) { temp = p0; p0 = p2; p2 = temp; }
			if (p1.CompareTo(p4) > 0) { temp = p1; p1 = p4; p4 = temp; }
			if (p1.CompareTo(p3) > 0) { temp = p1; p1 = p3; p3 = temp; }
			if (p1.CompareTo(p2) > 0) { temp = p1; p1 = p2; p2 = temp; }
			if (p5.CompareTo(p6) > 0) { temp = p5; p5 = p6; p6 = temp; }
			if (p8.CompareTo(p9) > 0) { temp = p8; p8 = p9; p9 = temp; }
			if (p7.CompareTo(p9) > 0) { temp = p7; p7 = p9; p9 = temp; }
			if (p7.CompareTo(p8) > 0) { temp = p7; p7 = p8; p8 = temp; }
			if (p5.CompareTo(p8) > 0) { temp = p5; p5 = p8; p8 = temp; }
			if (p5.CompareTo(p7) > 0) { temp = p5; p5 = p7; p7 = temp; }
			if (p6.CompareTo(p9) > 0) { temp = p6; p6 = p9; p9 = temp; }
			if (p6.CompareTo(p8) > 0) { temp = p6; p6 = p8; p8 = temp; }
			if (p6.CompareTo(p7) > 0) { temp = p6; p6 = p7; p7 = temp; }
			if (p0.CompareTo(p6) > 0) { temp = p0; p0 = p6; p6 = temp; }
			if (p0.CompareTo(p5) > 0) { temp = p0; p0 = p5; p5 = temp; }
			if (p1.CompareTo(p7) > 0) { temp = p1; p1 = p7; p7 = temp; }
			if (p1.CompareTo(p6) > 0) { temp = p1; p1 = p6; p6 = temp; }
			if (p1.CompareTo(p5) > 0) { temp = p1; p1 = p5; p5 = temp; }
			if (p2.CompareTo(p8) > 0) { temp = p2; p2 = p8; p8 = temp; }
			if (p3.CompareTo(p9) > 0) { temp = p3; p3 = p9; p9 = temp; }
			if (p4.CompareTo(p9) > 0) { temp = p4; p4 = p9; p9 = temp; }
			if (p3.CompareTo(p8) > 0) { temp = p3; p3 = p8; p8 = temp; }
			if (p4.CompareTo(p8) > 0) { temp = p4; p4 = p8; p8 = temp; }
			if (p2.CompareTo(p6) > 0) { temp = p2; p2 = p6; p6 = temp; }
			if (p2.CompareTo(p5) > 0) { temp = p2; p2 = p5; p5 = temp; }
			if (p3.CompareTo(p7) > 0) { temp = p3; p3 = p7; p7 = temp; }
			if (p4.CompareTo(p7) > 0) { temp = p4; p4 = p7; p7 = temp; }
			if (p3.CompareTo(p5) > 0) { temp = p3; p3 = p5; p5 = temp; }
			if (p4.CompareTo(p6) > 0) { temp = p4; p4 = p6; p6 = temp; }
			if (p4.CompareTo(p5) > 0) { temp = p4; p4 = p5; p5 = temp; }
			if (p10.CompareTo(p11) > 0) { temp = p10; p10 = p11; p11 = temp; }
			if (p13.CompareTo(p14) > 0) { temp = p13; p13 = p14; p14 = temp; }
			if (p12.CompareTo(p14) > 0) { temp = p12; p12 = p14; p14 = temp; }
			if (p12.CompareTo(p13) > 0) { temp = p12; p12 = p13; p13 = temp; }
			if (p10.CompareTo(p13) > 0) { temp = p10; p10 = p13; p13 = temp; }
			if (p10.CompareTo(p12) > 0) { temp = p10; p10 = p12; p12 = temp; }
			if (p11.CompareTo(p14) > 0) { temp = p11; p11 = p14; p14 = temp; }
			if (p11.CompareTo(p13) > 0) { temp = p11; p11 = p13; p13 = temp; }
			if (p11.CompareTo(p12) > 0) { temp = p11; p11 = p12; p12 = temp; }
			if (p16.CompareTo(p17) > 0) { temp = p16; p16 = p17; p17 = temp; }
			if (p15.CompareTo(p17) > 0) { temp = p15; p15 = p17; p17 = temp; }
			if (p15.CompareTo(p16) > 0) { temp = p15; p15 = p16; p16 = temp; }
			if (p19.CompareTo(p20) > 0) { temp = p19; p19 = p20; p20 = temp; }
			if (p18.CompareTo(p20) > 0) { temp = p18; p18 = p20; p20 = temp; }
			if (p18.CompareTo(p19) > 0) { temp = p18; p18 = p19; p19 = temp; }
			if (p15.CompareTo(p19) > 0) { temp = p15; p15 = p19; p19 = temp; }
			if (p15.CompareTo(p18) > 0) { temp = p15; p15 = p18; p18 = temp; }
			if (p16.CompareTo(p20) > 0) { temp = p16; p16 = p20; p20 = temp; }
			if (p17.CompareTo(p20) > 0) { temp = p17; p17 = p20; p20 = temp; }
			if (p16.CompareTo(p18) > 0) { temp = p16; p16 = p18; p18 = temp; }
			if (p17.CompareTo(p19) > 0) { temp = p17; p17 = p19; p19 = temp; }
			if (p17.CompareTo(p18) > 0) { temp = p17; p17 = p18; p18 = temp; }
			if (p10.CompareTo(p16) > 0) { temp = p10; p10 = p16; p16 = temp; }
			if (p10.CompareTo(p15) > 0) { temp = p10; p10 = p15; p15 = temp; }
			if (p11.CompareTo(p17) > 0) { temp = p11; p11 = p17; p17 = temp; }
			if (p11.CompareTo(p16) > 0) { temp = p11; p11 = p16; p16 = temp; }
			if (p11.CompareTo(p15) > 0) { temp = p11; p11 = p15; p15 = temp; }
			if (p12.CompareTo(p19) > 0) { temp = p12; p12 = p19; p19 = temp; }
			if (p12.CompareTo(p18) > 0) { temp = p12; p12 = p18; p18 = temp; }
			if (p13.CompareTo(p20) > 0) { temp = p13; p13 = p20; p20 = temp; }
			if (p14.CompareTo(p20) > 0) { temp = p14; p14 = p20; p20 = temp; }
			if (p13.CompareTo(p18) > 0) { temp = p13; p13 = p18; p18 = temp; }
			if (p14.CompareTo(p19) > 0) { temp = p14; p14 = p19; p19 = temp; }
			if (p14.CompareTo(p18) > 0) { temp = p14; p14 = p18; p18 = temp; }
			if (p12.CompareTo(p16) > 0) { temp = p12; p12 = p16; p16 = temp; }
			if (p12.CompareTo(p15) > 0) { temp = p12; p12 = p15; p15 = temp; }
			if (p13.CompareTo(p17) > 0) { temp = p13; p13 = p17; p17 = temp; }
			if (p14.CompareTo(p17) > 0) { temp = p14; p14 = p17; p17 = temp; }
			if (p13.CompareTo(p15) > 0) { temp = p13; p13 = p15; p15 = temp; }
			if (p14.CompareTo(p16) > 0) { temp = p14; p14 = p16; p16 = temp; }
			if (p14.CompareTo(p15) > 0) { temp = p14; p14 = p15; p15 = temp; }
			if (p0.CompareTo(p11) > 0) { temp = p0; p0 = p11; p11 = temp; }
			if (p0.CompareTo(p10) > 0) { temp = p0; p0 = p10; p10 = temp; }
			if (p1.CompareTo(p12) > 0) { temp = p1; p1 = p12; p12 = temp; }
			if (p1.CompareTo(p11) > 0) { temp = p1; p1 = p11; p11 = temp; }
			if (p1.CompareTo(p10) > 0) { temp = p1; p1 = p10; p10 = temp; }
			if (p2.CompareTo(p14) > 0) { temp = p2; p2 = p14; p14 = temp; }
			if (p2.CompareTo(p13) > 0) { temp = p2; p2 = p13; p13 = temp; }
			if (p3.CompareTo(p15) > 0) { temp = p3; p3 = p15; p15 = temp; }
			if (p4.CompareTo(p15) > 0) { temp = p4; p4 = p15; p15 = temp; }
			if (p3.CompareTo(p13) > 0) { temp = p3; p3 = p13; p13 = temp; }
			if (p4.CompareTo(p14) > 0) { temp = p4; p4 = p14; p14 = temp; }
			if (p4.CompareTo(p13) > 0) { temp = p4; p4 = p13; p13 = temp; }
			if (p2.CompareTo(p11) > 0) { temp = p2; p2 = p11; p11 = temp; }
			if (p2.CompareTo(p10) > 0) { temp = p2; p2 = p10; p10 = temp; }
			if (p3.CompareTo(p12) > 0) { temp = p3; p3 = p12; p12 = temp; }
			if (p4.CompareTo(p12) > 0) { temp = p4; p4 = p12; p12 = temp; }
			if (p3.CompareTo(p10) > 0) { temp = p3; p3 = p10; p10 = temp; }
			if (p4.CompareTo(p11) > 0) { temp = p4; p4 = p11; p11 = temp; }
			if (p4.CompareTo(p10) > 0) { temp = p4; p4 = p10; p10 = temp; }
			if (p5.CompareTo(p17) > 0) { temp = p5; p5 = p17; p17 = temp; }
			if (p5.CompareTo(p16) > 0) { temp = p5; p5 = p16; p16 = temp; }
			if (p6.CompareTo(p18) > 0) { temp = p6; p6 = p18; p18 = temp; }
			if (p6.CompareTo(p17) > 0) { temp = p6; p6 = p17; p17 = temp; }
			if (p6.CompareTo(p16) > 0) { temp = p6; p6 = p16; p16 = temp; }
			if (p7.CompareTo(p19) > 0) { temp = p7; p7 = p19; p19 = temp; }
			if (p8.CompareTo(p20) > 0) { temp = p8; p8 = p20; p20 = temp; }
			if (p9.CompareTo(p20) > 0) { temp = p9; p9 = p20; p20 = temp; }
			if (p8.CompareTo(p19) > 0) { temp = p8; p8 = p19; p19 = temp; }
			if (p9.CompareTo(p19) > 0) { temp = p9; p9 = p19; p19 = temp; }
			if (p7.CompareTo(p17) > 0) { temp = p7; p7 = p17; p17 = temp; }
			if (p7.CompareTo(p16) > 0) { temp = p7; p7 = p16; p16 = temp; }
			if (p8.CompareTo(p18) > 0) { temp = p8; p8 = p18; p18 = temp; }
			if (p9.CompareTo(p18) > 0) { temp = p9; p9 = p18; p18 = temp; }
			if (p8.CompareTo(p16) > 0) { temp = p8; p8 = p16; p16 = temp; }
			if (p9.CompareTo(p17) > 0) { temp = p9; p9 = p17; p17 = temp; }
			if (p9.CompareTo(p16) > 0) { temp = p9; p9 = p16; p16 = temp; }
			if (p5.CompareTo(p11) > 0) { temp = p5; p5 = p11; p11 = temp; }
			if (p5.CompareTo(p10) > 0) { temp = p5; p5 = p10; p10 = temp; }
			if (p6.CompareTo(p12) > 0) { temp = p6; p6 = p12; p12 = temp; }
			if (p6.CompareTo(p11) > 0) { temp = p6; p6 = p11; p11 = temp; }
			if (p6.CompareTo(p10) > 0) { temp = p6; p6 = p10; p10 = temp; }
			if (p7.CompareTo(p14) > 0) { temp = p7; p7 = p14; p14 = temp; }
			if (p7.CompareTo(p13) > 0) { temp = p7; p7 = p13; p13 = temp; }
			if (p8.CompareTo(p15) > 0) { temp = p8; p8 = p15; p15 = temp; }
			if (p9.CompareTo(p15) > 0) { temp = p9; p9 = p15; p15 = temp; }
			if (p8.CompareTo(p13) > 0) { temp = p8; p8 = p13; p13 = temp; }
			if (p9.CompareTo(p14) > 0) { temp = p9; p9 = p14; p14 = temp; }
			if (p9.CompareTo(p13) > 0) { temp = p9; p9 = p13; p13 = temp; }
			if (p7.CompareTo(p11) > 0) { temp = p7; p7 = p11; p11 = temp; }
			if (p7.CompareTo(p10) > 0) { temp = p7; p7 = p10; p10 = temp; }
			if (p8.CompareTo(p12) > 0) { temp = p8; p8 = p12; p12 = temp; }
			if (p9.CompareTo(p12) > 0) { temp = p9; p9 = p12; p12 = temp; }
			if (p8.CompareTo(p10) > 0) { temp = p8; p8 = p10; p10 = temp; }
			if (p9.CompareTo(p11) > 0) { temp = p9; p9 = p11; p11 = temp; }
			if (p9.CompareTo(p10) > 0) { temp = p9; p9 = p10; p10 = temp; }
#else
			if (GreaterThan(ref p0, ref p1)) { temp = p0; p0 = p1; p1 = temp; }
			if (GreaterThan(ref p3, ref p4)) { temp = p3; p3 = p4; p4 = temp; }
			if (GreaterThan(ref p2, ref p4)) { temp = p2; p2 = p4; p4 = temp; }
			if (GreaterThan(ref p2, ref p3)) { temp = p2; p2 = p3; p3 = temp; }
			if (GreaterThan(ref p0, ref p3)) { temp = p0; p0 = p3; p3 = temp; }
			if (GreaterThan(ref p0, ref p2)) { temp = p0; p0 = p2; p2 = temp; }
			if (GreaterThan(ref p1, ref p4)) { temp = p1; p1 = p4; p4 = temp; }
			if (GreaterThan(ref p1, ref p3)) { temp = p1; p1 = p3; p3 = temp; }
			if (GreaterThan(ref p1, ref p2)) { temp = p1; p1 = p2; p2 = temp; }
			if (GreaterThan(ref p5, ref p6)) { temp = p5; p5 = p6; p6 = temp; }
			if (GreaterThan(ref p8, ref p9)) { temp = p8; p8 = p9; p9 = temp; }
			if (GreaterThan(ref p7, ref p9)) { temp = p7; p7 = p9; p9 = temp; }
			if (GreaterThan(ref p7, ref p8)) { temp = p7; p7 = p8; p8 = temp; }
			if (GreaterThan(ref p5, ref p8)) { temp = p5; p5 = p8; p8 = temp; }
			if (GreaterThan(ref p5, ref p7)) { temp = p5; p5 = p7; p7 = temp; }
			if (GreaterThan(ref p6, ref p9)) { temp = p6; p6 = p9; p9 = temp; }
			if (GreaterThan(ref p6, ref p8)) { temp = p6; p6 = p8; p8 = temp; }
			if (GreaterThan(ref p6, ref p7)) { temp = p6; p6 = p7; p7 = temp; }
			if (GreaterThan(ref p0, ref p6)) { temp = p0; p0 = p6; p6 = temp; }
			if (GreaterThan(ref p0, ref p5)) { temp = p0; p0 = p5; p5 = temp; }
			if (GreaterThan(ref p1, ref p7)) { temp = p1; p1 = p7; p7 = temp; }
			if (GreaterThan(ref p1, ref p6)) { temp = p1; p1 = p6; p6 = temp; }
			if (GreaterThan(ref p1, ref p5)) { temp = p1; p1 = p5; p5 = temp; }
			if (GreaterThan(ref p2, ref p8)) { temp = p2; p2 = p8; p8 = temp; }
			if (GreaterThan(ref p3, ref p9)) { temp = p3; p3 = p9; p9 = temp; }
			if (GreaterThan(ref p4, ref p9)) { temp = p4; p4 = p9; p9 = temp; }
			if (GreaterThan(ref p3, ref p8)) { temp = p3; p3 = p8; p8 = temp; }
			if (GreaterThan(ref p4, ref p8)) { temp = p4; p4 = p8; p8 = temp; }
			if (GreaterThan(ref p2, ref p6)) { temp = p2; p2 = p6; p6 = temp; }
			if (GreaterThan(ref p2, ref p5)) { temp = p2; p2 = p5; p5 = temp; }
			if (GreaterThan(ref p3, ref p7)) { temp = p3; p3 = p7; p7 = temp; }
			if (GreaterThan(ref p4, ref p7)) { temp = p4; p4 = p7; p7 = temp; }
			if (GreaterThan(ref p3, ref p5)) { temp = p3; p3 = p5; p5 = temp; }
			if (GreaterThan(ref p4, ref p6)) { temp = p4; p4 = p6; p6 = temp; }
			if (GreaterThan(ref p4, ref p5)) { temp = p4; p4 = p5; p5 = temp; }
			if (GreaterThan(ref p10, ref p11)) { temp = p10; p10 = p11; p11 = temp; }
			if (GreaterThan(ref p13, ref p14)) { temp = p13; p13 = p14; p14 = temp; }
			if (GreaterThan(ref p12, ref p14)) { temp = p12; p12 = p14; p14 = temp; }
			if (GreaterThan(ref p12, ref p13)) { temp = p12; p12 = p13; p13 = temp; }
			if (GreaterThan(ref p10, ref p13)) { temp = p10; p10 = p13; p13 = temp; }
			if (GreaterThan(ref p10, ref p12)) { temp = p10; p10 = p12; p12 = temp; }
			if (GreaterThan(ref p11, ref p14)) { temp = p11; p11 = p14; p14 = temp; }
			if (GreaterThan(ref p11, ref p13)) { temp = p11; p11 = p13; p13 = temp; }
			if (GreaterThan(ref p11, ref p12)) { temp = p11; p11 = p12; p12 = temp; }
			if (GreaterThan(ref p16, ref p17)) { temp = p16; p16 = p17; p17 = temp; }
			if (GreaterThan(ref p15, ref p17)) { temp = p15; p15 = p17; p17 = temp; }
			if (GreaterThan(ref p15, ref p16)) { temp = p15; p15 = p16; p16 = temp; }
			if (GreaterThan(ref p19, ref p20)) { temp = p19; p19 = p20; p20 = temp; }
			if (GreaterThan(ref p18, ref p20)) { temp = p18; p18 = p20; p20 = temp; }
			if (GreaterThan(ref p18, ref p19)) { temp = p18; p18 = p19; p19 = temp; }
			if (GreaterThan(ref p15, ref p19)) { temp = p15; p15 = p19; p19 = temp; }
			if (GreaterThan(ref p15, ref p18)) { temp = p15; p15 = p18; p18 = temp; }
			if (GreaterThan(ref p16, ref p20)) { temp = p16; p16 = p20; p20 = temp; }
			if (GreaterThan(ref p17, ref p20)) { temp = p17; p17 = p20; p20 = temp; }
			if (GreaterThan(ref p16, ref p18)) { temp = p16; p16 = p18; p18 = temp; }
			if (GreaterThan(ref p17, ref p19)) { temp = p17; p17 = p19; p19 = temp; }
			if (GreaterThan(ref p17, ref p18)) { temp = p17; p17 = p18; p18 = temp; }
			if (GreaterThan(ref p10, ref p16)) { temp = p10; p10 = p16; p16 = temp; }
			if (GreaterThan(ref p10, ref p15)) { temp = p10; p10 = p15; p15 = temp; }
			if (GreaterThan(ref p11, ref p17)) { temp = p11; p11 = p17; p17 = temp; }
			if (GreaterThan(ref p11, ref p16)) { temp = p11; p11 = p16; p16 = temp; }
			if (GreaterThan(ref p11, ref p15)) { temp = p11; p11 = p15; p15 = temp; }
			if (GreaterThan(ref p12, ref p19)) { temp = p12; p12 = p19; p19 = temp; }
			if (GreaterThan(ref p12, ref p18)) { temp = p12; p12 = p18; p18 = temp; }
			if (GreaterThan(ref p13, ref p20)) { temp = p13; p13 = p20; p20 = temp; }
			if (GreaterThan(ref p14, ref p20)) { temp = p14; p14 = p20; p20 = temp; }
			if (GreaterThan(ref p13, ref p18)) { temp = p13; p13 = p18; p18 = temp; }
			if (GreaterThan(ref p14, ref p19)) { temp = p14; p14 = p19; p19 = temp; }
			if (GreaterThan(ref p14, ref p18)) { temp = p14; p14 = p18; p18 = temp; }
			if (GreaterThan(ref p12, ref p16)) { temp = p12; p12 = p16; p16 = temp; }
			if (GreaterThan(ref p12, ref p15)) { temp = p12; p12 = p15; p15 = temp; }
			if (GreaterThan(ref p13, ref p17)) { temp = p13; p13 = p17; p17 = temp; }
			if (GreaterThan(ref p14, ref p17)) { temp = p14; p14 = p17; p17 = temp; }
			if (GreaterThan(ref p13, ref p15)) { temp = p13; p13 = p15; p15 = temp; }
			if (GreaterThan(ref p14, ref p16)) { temp = p14; p14 = p16; p16 = temp; }
			if (GreaterThan(ref p14, ref p15)) { temp = p14; p14 = p15; p15 = temp; }
			if (GreaterThan(ref p0, ref p11)) { temp = p0; p0 = p11; p11 = temp; }
			if (GreaterThan(ref p0, ref p10)) { temp = p0; p0 = p10; p10 = temp; }
			if (GreaterThan(ref p1, ref p12)) { temp = p1; p1 = p12; p12 = temp; }
			if (GreaterThan(ref p1, ref p11)) { temp = p1; p1 = p11; p11 = temp; }
			if (GreaterThan(ref p1, ref p10)) { temp = p1; p1 = p10; p10 = temp; }
			if (GreaterThan(ref p2, ref p14)) { temp = p2; p2 = p14; p14 = temp; }
			if (GreaterThan(ref p2, ref p13)) { temp = p2; p2 = p13; p13 = temp; }
			if (GreaterThan(ref p3, ref p15)) { temp = p3; p3 = p15; p15 = temp; }
			if (GreaterThan(ref p4, ref p15)) { temp = p4; p4 = p15; p15 = temp; }
			if (GreaterThan(ref p3, ref p13)) { temp = p3; p3 = p13; p13 = temp; }
			if (GreaterThan(ref p4, ref p14)) { temp = p4; p4 = p14; p14 = temp; }
			if (GreaterThan(ref p4, ref p13)) { temp = p4; p4 = p13; p13 = temp; }
			if (GreaterThan(ref p2, ref p11)) { temp = p2; p2 = p11; p11 = temp; }
			if (GreaterThan(ref p2, ref p10)) { temp = p2; p2 = p10; p10 = temp; }
			if (GreaterThan(ref p3, ref p12)) { temp = p3; p3 = p12; p12 = temp; }
			if (GreaterThan(ref p4, ref p12)) { temp = p4; p4 = p12; p12 = temp; }
			if (GreaterThan(ref p3, ref p10)) { temp = p3; p3 = p10; p10 = temp; }
			if (GreaterThan(ref p4, ref p11)) { temp = p4; p4 = p11; p11 = temp; }
			if (GreaterThan(ref p4, ref p10)) { temp = p4; p4 = p10; p10 = temp; }
			if (GreaterThan(ref p5, ref p17)) { temp = p5; p5 = p17; p17 = temp; }
			if (GreaterThan(ref p5, ref p16)) { temp = p5; p5 = p16; p16 = temp; }
			if (GreaterThan(ref p6, ref p18)) { temp = p6; p6 = p18; p18 = temp; }
			if (GreaterThan(ref p6, ref p17)) { temp = p6; p6 = p17; p17 = temp; }
			if (GreaterThan(ref p6, ref p16)) { temp = p6; p6 = p16; p16 = temp; }
			if (GreaterThan(ref p7, ref p19)) { temp = p7; p7 = p19; p19 = temp; }
			if (GreaterThan(ref p8, ref p20)) { temp = p8; p8 = p20; p20 = temp; }
			if (GreaterThan(ref p9, ref p20)) { temp = p9; p9 = p20; p20 = temp; }
			if (GreaterThan(ref p8, ref p19)) { temp = p8; p8 = p19; p19 = temp; }
			if (GreaterThan(ref p9, ref p19)) { temp = p9; p9 = p19; p19 = temp; }
			if (GreaterThan(ref p7, ref p17)) { temp = p7; p7 = p17; p17 = temp; }
			if (GreaterThan(ref p7, ref p16)) { temp = p7; p7 = p16; p16 = temp; }
			if (GreaterThan(ref p8, ref p18)) { temp = p8; p8 = p18; p18 = temp; }
			if (GreaterThan(ref p9, ref p18)) { temp = p9; p9 = p18; p18 = temp; }
			if (GreaterThan(ref p8, ref p16)) { temp = p8; p8 = p16; p16 = temp; }
			if (GreaterThan(ref p9, ref p17)) { temp = p9; p9 = p17; p17 = temp; }
			if (GreaterThan(ref p9, ref p16)) { temp = p9; p9 = p16; p16 = temp; }
			if (GreaterThan(ref p5, ref p11)) { temp = p5; p5 = p11; p11 = temp; }
			if (GreaterThan(ref p5, ref p10)) { temp = p5; p5 = p10; p10 = temp; }
			if (GreaterThan(ref p6, ref p12)) { temp = p6; p6 = p12; p12 = temp; }
			if (GreaterThan(ref p6, ref p11)) { temp = p6; p6 = p11; p11 = temp; }
			if (GreaterThan(ref p6, ref p10)) { temp = p6; p6 = p10; p10 = temp; }
			if (GreaterThan(ref p7, ref p14)) { temp = p7; p7 = p14; p14 = temp; }
			if (GreaterThan(ref p7, ref p13)) { temp = p7; p7 = p13; p13 = temp; }
			if (GreaterThan(ref p8, ref p15)) { temp = p8; p8 = p15; p15 = temp; }
			if (GreaterThan(ref p9, ref p15)) { temp = p9; p9 = p15; p15 = temp; }
			if (GreaterThan(ref p8, ref p13)) { temp = p8; p8 = p13; p13 = temp; }
			if (GreaterThan(ref p9, ref p14)) { temp = p9; p9 = p14; p14 = temp; }
			if (GreaterThan(ref p9, ref p13)) { temp = p9; p9 = p13; p13 = temp; }
			if (GreaterThan(ref p7, ref p11)) { temp = p7; p7 = p11; p11 = temp; }
			if (GreaterThan(ref p7, ref p10)) { temp = p7; p7 = p10; p10 = temp; }
			if (GreaterThan(ref p8, ref p12)) { temp = p8; p8 = p12; p12 = temp; }
			if (GreaterThan(ref p9, ref p12)) { temp = p9; p9 = p12; p12 = temp; }
			if (GreaterThan(ref p8, ref p10)) { temp = p8; p8 = p10; p10 = temp; }
			if (GreaterThan(ref p9, ref p11)) { temp = p9; p9 = p11; p11 = temp; }
			if (GreaterThan(ref p9, ref p10)) { temp = p9; p9 = p10; p10 = temp; }
#endif
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
#if NETSTANDARD1_3
			if (p0.CompareTo(p1) > 0) { temp = p0; p0 = p1; p1 = temp; }
			if (p3.CompareTo(p4) > 0) { temp = p3; p3 = p4; p4 = temp; }
			if (p2.CompareTo(p4) > 0) { temp = p2; p2 = p4; p4 = temp; }
			if (p2.CompareTo(p3) > 0) { temp = p2; p2 = p3; p3 = temp; }
			if (p0.CompareTo(p3) > 0) { temp = p0; p0 = p3; p3 = temp; }
			if (p0.CompareTo(p2) > 0) { temp = p0; p0 = p2; p2 = temp; }
			if (p1.CompareTo(p4) > 0) { temp = p1; p1 = p4; p4 = temp; }
			if (p1.CompareTo(p3) > 0) { temp = p1; p1 = p3; p3 = temp; }
			if (p1.CompareTo(p2) > 0) { temp = p1; p1 = p2; p2 = temp; }
			if (p6.CompareTo(p7) > 0) { temp = p6; p6 = p7; p7 = temp; }
			if (p5.CompareTo(p7) > 0) { temp = p5; p5 = p7; p7 = temp; }
			if (p5.CompareTo(p6) > 0) { temp = p5; p5 = p6; p6 = temp; }
			if (p9.CompareTo(p10) > 0) { temp = p9; p9 = p10; p10 = temp; }
			if (p8.CompareTo(p10) > 0) { temp = p8; p8 = p10; p10 = temp; }
			if (p8.CompareTo(p9) > 0) { temp = p8; p8 = p9; p9 = temp; }
			if (p5.CompareTo(p9) > 0) { temp = p5; p5 = p9; p9 = temp; }
			if (p5.CompareTo(p8) > 0) { temp = p5; p5 = p8; p8 = temp; }
			if (p6.CompareTo(p10) > 0) { temp = p6; p6 = p10; p10 = temp; }
			if (p7.CompareTo(p10) > 0) { temp = p7; p7 = p10; p10 = temp; }
			if (p6.CompareTo(p8) > 0) { temp = p6; p6 = p8; p8 = temp; }
			if (p7.CompareTo(p9) > 0) { temp = p7; p7 = p9; p9 = temp; }
			if (p7.CompareTo(p8) > 0) { temp = p7; p7 = p8; p8 = temp; }
			if (p0.CompareTo(p6) > 0) { temp = p0; p0 = p6; p6 = temp; }
			if (p0.CompareTo(p5) > 0) { temp = p0; p0 = p5; p5 = temp; }
			if (p1.CompareTo(p7) > 0) { temp = p1; p1 = p7; p7 = temp; }
			if (p1.CompareTo(p6) > 0) { temp = p1; p1 = p6; p6 = temp; }
			if (p1.CompareTo(p5) > 0) { temp = p1; p1 = p5; p5 = temp; }
			if (p2.CompareTo(p9) > 0) { temp = p2; p2 = p9; p9 = temp; }
			if (p2.CompareTo(p8) > 0) { temp = p2; p2 = p8; p8 = temp; }
			if (p3.CompareTo(p10) > 0) { temp = p3; p3 = p10; p10 = temp; }
			if (p4.CompareTo(p10) > 0) { temp = p4; p4 = p10; p10 = temp; }
			if (p3.CompareTo(p8) > 0) { temp = p3; p3 = p8; p8 = temp; }
			if (p4.CompareTo(p9) > 0) { temp = p4; p4 = p9; p9 = temp; }
			if (p4.CompareTo(p8) > 0) { temp = p4; p4 = p8; p8 = temp; }
			if (p2.CompareTo(p6) > 0) { temp = p2; p2 = p6; p6 = temp; }
			if (p2.CompareTo(p5) > 0) { temp = p2; p2 = p5; p5 = temp; }
			if (p3.CompareTo(p7) > 0) { temp = p3; p3 = p7; p7 = temp; }
			if (p4.CompareTo(p7) > 0) { temp = p4; p4 = p7; p7 = temp; }
			if (p3.CompareTo(p5) > 0) { temp = p3; p3 = p5; p5 = temp; }
			if (p4.CompareTo(p6) > 0) { temp = p4; p4 = p6; p6 = temp; }
			if (p4.CompareTo(p5) > 0) { temp = p4; p4 = p5; p5 = temp; }
			if (p11.CompareTo(p12) > 0) { temp = p11; p11 = p12; p12 = temp; }
			if (p14.CompareTo(p15) > 0) { temp = p14; p14 = p15; p15 = temp; }
			if (p13.CompareTo(p15) > 0) { temp = p13; p13 = p15; p15 = temp; }
			if (p13.CompareTo(p14) > 0) { temp = p13; p13 = p14; p14 = temp; }
			if (p11.CompareTo(p14) > 0) { temp = p11; p11 = p14; p14 = temp; }
			if (p11.CompareTo(p13) > 0) { temp = p11; p11 = p13; p13 = temp; }
			if (p12.CompareTo(p15) > 0) { temp = p12; p12 = p15; p15 = temp; }
			if (p12.CompareTo(p14) > 0) { temp = p12; p12 = p14; p14 = temp; }
			if (p12.CompareTo(p13) > 0) { temp = p12; p12 = p13; p13 = temp; }
			if (p17.CompareTo(p18) > 0) { temp = p17; p17 = p18; p18 = temp; }
			if (p16.CompareTo(p18) > 0) { temp = p16; p16 = p18; p18 = temp; }
			if (p16.CompareTo(p17) > 0) { temp = p16; p16 = p17; p17 = temp; }
			if (p20.CompareTo(p21) > 0) { temp = p20; p20 = p21; p21 = temp; }
			if (p19.CompareTo(p21) > 0) { temp = p19; p19 = p21; p21 = temp; }
			if (p19.CompareTo(p20) > 0) { temp = p19; p19 = p20; p20 = temp; }
			if (p16.CompareTo(p20) > 0) { temp = p16; p16 = p20; p20 = temp; }
			if (p16.CompareTo(p19) > 0) { temp = p16; p16 = p19; p19 = temp; }
			if (p17.CompareTo(p21) > 0) { temp = p17; p17 = p21; p21 = temp; }
			if (p18.CompareTo(p21) > 0) { temp = p18; p18 = p21; p21 = temp; }
			if (p17.CompareTo(p19) > 0) { temp = p17; p17 = p19; p19 = temp; }
			if (p18.CompareTo(p20) > 0) { temp = p18; p18 = p20; p20 = temp; }
			if (p18.CompareTo(p19) > 0) { temp = p18; p18 = p19; p19 = temp; }
			if (p11.CompareTo(p17) > 0) { temp = p11; p11 = p17; p17 = temp; }
			if (p11.CompareTo(p16) > 0) { temp = p11; p11 = p16; p16 = temp; }
			if (p12.CompareTo(p18) > 0) { temp = p12; p12 = p18; p18 = temp; }
			if (p12.CompareTo(p17) > 0) { temp = p12; p12 = p17; p17 = temp; }
			if (p12.CompareTo(p16) > 0) { temp = p12; p12 = p16; p16 = temp; }
			if (p13.CompareTo(p20) > 0) { temp = p13; p13 = p20; p20 = temp; }
			if (p13.CompareTo(p19) > 0) { temp = p13; p13 = p19; p19 = temp; }
			if (p14.CompareTo(p21) > 0) { temp = p14; p14 = p21; p21 = temp; }
			if (p15.CompareTo(p21) > 0) { temp = p15; p15 = p21; p21 = temp; }
			if (p14.CompareTo(p19) > 0) { temp = p14; p14 = p19; p19 = temp; }
			if (p15.CompareTo(p20) > 0) { temp = p15; p15 = p20; p20 = temp; }
			if (p15.CompareTo(p19) > 0) { temp = p15; p15 = p19; p19 = temp; }
			if (p13.CompareTo(p17) > 0) { temp = p13; p13 = p17; p17 = temp; }
			if (p13.CompareTo(p16) > 0) { temp = p13; p13 = p16; p16 = temp; }
			if (p14.CompareTo(p18) > 0) { temp = p14; p14 = p18; p18 = temp; }
			if (p15.CompareTo(p18) > 0) { temp = p15; p15 = p18; p18 = temp; }
			if (p14.CompareTo(p16) > 0) { temp = p14; p14 = p16; p16 = temp; }
			if (p15.CompareTo(p17) > 0) { temp = p15; p15 = p17; p17 = temp; }
			if (p15.CompareTo(p16) > 0) { temp = p15; p15 = p16; p16 = temp; }
			if (p0.CompareTo(p12) > 0) { temp = p0; p0 = p12; p12 = temp; }
			if (p0.CompareTo(p11) > 0) { temp = p0; p0 = p11; p11 = temp; }
			if (p1.CompareTo(p13) > 0) { temp = p1; p1 = p13; p13 = temp; }
			if (p1.CompareTo(p12) > 0) { temp = p1; p1 = p12; p12 = temp; }
			if (p1.CompareTo(p11) > 0) { temp = p1; p1 = p11; p11 = temp; }
			if (p2.CompareTo(p15) > 0) { temp = p2; p2 = p15; p15 = temp; }
			if (p2.CompareTo(p14) > 0) { temp = p2; p2 = p14; p14 = temp; }
			if (p3.CompareTo(p16) > 0) { temp = p3; p3 = p16; p16 = temp; }
			if (p4.CompareTo(p16) > 0) { temp = p4; p4 = p16; p16 = temp; }
			if (p3.CompareTo(p14) > 0) { temp = p3; p3 = p14; p14 = temp; }
			if (p4.CompareTo(p15) > 0) { temp = p4; p4 = p15; p15 = temp; }
			if (p4.CompareTo(p14) > 0) { temp = p4; p4 = p14; p14 = temp; }
			if (p2.CompareTo(p12) > 0) { temp = p2; p2 = p12; p12 = temp; }
			if (p2.CompareTo(p11) > 0) { temp = p2; p2 = p11; p11 = temp; }
			if (p3.CompareTo(p13) > 0) { temp = p3; p3 = p13; p13 = temp; }
			if (p4.CompareTo(p13) > 0) { temp = p4; p4 = p13; p13 = temp; }
			if (p3.CompareTo(p11) > 0) { temp = p3; p3 = p11; p11 = temp; }
			if (p4.CompareTo(p12) > 0) { temp = p4; p4 = p12; p12 = temp; }
			if (p4.CompareTo(p11) > 0) { temp = p4; p4 = p11; p11 = temp; }
			if (p5.CompareTo(p18) > 0) { temp = p5; p5 = p18; p18 = temp; }
			if (p5.CompareTo(p17) > 0) { temp = p5; p5 = p17; p17 = temp; }
			if (p6.CompareTo(p19) > 0) { temp = p6; p6 = p19; p19 = temp; }
			if (p7.CompareTo(p19) > 0) { temp = p7; p7 = p19; p19 = temp; }
			if (p6.CompareTo(p17) > 0) { temp = p6; p6 = p17; p17 = temp; }
			if (p7.CompareTo(p18) > 0) { temp = p7; p7 = p18; p18 = temp; }
			if (p7.CompareTo(p17) > 0) { temp = p7; p7 = p17; p17 = temp; }
			if (p8.CompareTo(p20) > 0) { temp = p8; p8 = p20; p20 = temp; }
			if (p9.CompareTo(p21) > 0) { temp = p9; p9 = p21; p21 = temp; }
			if (p10.CompareTo(p21) > 0) { temp = p10; p10 = p21; p21 = temp; }
			if (p9.CompareTo(p20) > 0) { temp = p9; p9 = p20; p20 = temp; }
			if (p10.CompareTo(p20) > 0) { temp = p10; p10 = p20; p20 = temp; }
			if (p8.CompareTo(p18) > 0) { temp = p8; p8 = p18; p18 = temp; }
			if (p8.CompareTo(p17) > 0) { temp = p8; p8 = p17; p17 = temp; }
			if (p9.CompareTo(p19) > 0) { temp = p9; p9 = p19; p19 = temp; }
			if (p10.CompareTo(p19) > 0) { temp = p10; p10 = p19; p19 = temp; }
			if (p9.CompareTo(p17) > 0) { temp = p9; p9 = p17; p17 = temp; }
			if (p10.CompareTo(p18) > 0) { temp = p10; p10 = p18; p18 = temp; }
			if (p10.CompareTo(p17) > 0) { temp = p10; p10 = p17; p17 = temp; }
			if (p5.CompareTo(p12) > 0) { temp = p5; p5 = p12; p12 = temp; }
			if (p5.CompareTo(p11) > 0) { temp = p5; p5 = p11; p11 = temp; }
			if (p6.CompareTo(p13) > 0) { temp = p6; p6 = p13; p13 = temp; }
			if (p7.CompareTo(p13) > 0) { temp = p7; p7 = p13; p13 = temp; }
			if (p6.CompareTo(p11) > 0) { temp = p6; p6 = p11; p11 = temp; }
			if (p7.CompareTo(p12) > 0) { temp = p7; p7 = p12; p12 = temp; }
			if (p7.CompareTo(p11) > 0) { temp = p7; p7 = p11; p11 = temp; }
			if (p8.CompareTo(p15) > 0) { temp = p8; p8 = p15; p15 = temp; }
			if (p8.CompareTo(p14) > 0) { temp = p8; p8 = p14; p14 = temp; }
			if (p9.CompareTo(p16) > 0) { temp = p9; p9 = p16; p16 = temp; }
			if (p10.CompareTo(p16) > 0) { temp = p10; p10 = p16; p16 = temp; }
			if (p9.CompareTo(p14) > 0) { temp = p9; p9 = p14; p14 = temp; }
			if (p10.CompareTo(p15) > 0) { temp = p10; p10 = p15; p15 = temp; }
			if (p10.CompareTo(p14) > 0) { temp = p10; p10 = p14; p14 = temp; }
			if (p8.CompareTo(p12) > 0) { temp = p8; p8 = p12; p12 = temp; }
			if (p8.CompareTo(p11) > 0) { temp = p8; p8 = p11; p11 = temp; }
			if (p9.CompareTo(p13) > 0) { temp = p9; p9 = p13; p13 = temp; }
			if (p10.CompareTo(p13) > 0) { temp = p10; p10 = p13; p13 = temp; }
			if (p9.CompareTo(p11) > 0) { temp = p9; p9 = p11; p11 = temp; }
			if (p10.CompareTo(p12) > 0) { temp = p10; p10 = p12; p12 = temp; }
			if (p10.CompareTo(p11) > 0) { temp = p10; p10 = p11; p11 = temp; }
#else
			if (GreaterThan(ref p0, ref p1)) { temp = p0; p0 = p1; p1 = temp; }
			if (GreaterThan(ref p3, ref p4)) { temp = p3; p3 = p4; p4 = temp; }
			if (GreaterThan(ref p2, ref p4)) { temp = p2; p2 = p4; p4 = temp; }
			if (GreaterThan(ref p2, ref p3)) { temp = p2; p2 = p3; p3 = temp; }
			if (GreaterThan(ref p0, ref p3)) { temp = p0; p0 = p3; p3 = temp; }
			if (GreaterThan(ref p0, ref p2)) { temp = p0; p0 = p2; p2 = temp; }
			if (GreaterThan(ref p1, ref p4)) { temp = p1; p1 = p4; p4 = temp; }
			if (GreaterThan(ref p1, ref p3)) { temp = p1; p1 = p3; p3 = temp; }
			if (GreaterThan(ref p1, ref p2)) { temp = p1; p1 = p2; p2 = temp; }
			if (GreaterThan(ref p6, ref p7)) { temp = p6; p6 = p7; p7 = temp; }
			if (GreaterThan(ref p5, ref p7)) { temp = p5; p5 = p7; p7 = temp; }
			if (GreaterThan(ref p5, ref p6)) { temp = p5; p5 = p6; p6 = temp; }
			if (GreaterThan(ref p9, ref p10)) { temp = p9; p9 = p10; p10 = temp; }
			if (GreaterThan(ref p8, ref p10)) { temp = p8; p8 = p10; p10 = temp; }
			if (GreaterThan(ref p8, ref p9)) { temp = p8; p8 = p9; p9 = temp; }
			if (GreaterThan(ref p5, ref p9)) { temp = p5; p5 = p9; p9 = temp; }
			if (GreaterThan(ref p5, ref p8)) { temp = p5; p5 = p8; p8 = temp; }
			if (GreaterThan(ref p6, ref p10)) { temp = p6; p6 = p10; p10 = temp; }
			if (GreaterThan(ref p7, ref p10)) { temp = p7; p7 = p10; p10 = temp; }
			if (GreaterThan(ref p6, ref p8)) { temp = p6; p6 = p8; p8 = temp; }
			if (GreaterThan(ref p7, ref p9)) { temp = p7; p7 = p9; p9 = temp; }
			if (GreaterThan(ref p7, ref p8)) { temp = p7; p7 = p8; p8 = temp; }
			if (GreaterThan(ref p0, ref p6)) { temp = p0; p0 = p6; p6 = temp; }
			if (GreaterThan(ref p0, ref p5)) { temp = p0; p0 = p5; p5 = temp; }
			if (GreaterThan(ref p1, ref p7)) { temp = p1; p1 = p7; p7 = temp; }
			if (GreaterThan(ref p1, ref p6)) { temp = p1; p1 = p6; p6 = temp; }
			if (GreaterThan(ref p1, ref p5)) { temp = p1; p1 = p5; p5 = temp; }
			if (GreaterThan(ref p2, ref p9)) { temp = p2; p2 = p9; p9 = temp; }
			if (GreaterThan(ref p2, ref p8)) { temp = p2; p2 = p8; p8 = temp; }
			if (GreaterThan(ref p3, ref p10)) { temp = p3; p3 = p10; p10 = temp; }
			if (GreaterThan(ref p4, ref p10)) { temp = p4; p4 = p10; p10 = temp; }
			if (GreaterThan(ref p3, ref p8)) { temp = p3; p3 = p8; p8 = temp; }
			if (GreaterThan(ref p4, ref p9)) { temp = p4; p4 = p9; p9 = temp; }
			if (GreaterThan(ref p4, ref p8)) { temp = p4; p4 = p8; p8 = temp; }
			if (GreaterThan(ref p2, ref p6)) { temp = p2; p2 = p6; p6 = temp; }
			if (GreaterThan(ref p2, ref p5)) { temp = p2; p2 = p5; p5 = temp; }
			if (GreaterThan(ref p3, ref p7)) { temp = p3; p3 = p7; p7 = temp; }
			if (GreaterThan(ref p4, ref p7)) { temp = p4; p4 = p7; p7 = temp; }
			if (GreaterThan(ref p3, ref p5)) { temp = p3; p3 = p5; p5 = temp; }
			if (GreaterThan(ref p4, ref p6)) { temp = p4; p4 = p6; p6 = temp; }
			if (GreaterThan(ref p4, ref p5)) { temp = p4; p4 = p5; p5 = temp; }
			if (GreaterThan(ref p11, ref p12)) { temp = p11; p11 = p12; p12 = temp; }
			if (GreaterThan(ref p14, ref p15)) { temp = p14; p14 = p15; p15 = temp; }
			if (GreaterThan(ref p13, ref p15)) { temp = p13; p13 = p15; p15 = temp; }
			if (GreaterThan(ref p13, ref p14)) { temp = p13; p13 = p14; p14 = temp; }
			if (GreaterThan(ref p11, ref p14)) { temp = p11; p11 = p14; p14 = temp; }
			if (GreaterThan(ref p11, ref p13)) { temp = p11; p11 = p13; p13 = temp; }
			if (GreaterThan(ref p12, ref p15)) { temp = p12; p12 = p15; p15 = temp; }
			if (GreaterThan(ref p12, ref p14)) { temp = p12; p12 = p14; p14 = temp; }
			if (GreaterThan(ref p12, ref p13)) { temp = p12; p12 = p13; p13 = temp; }
			if (GreaterThan(ref p17, ref p18)) { temp = p17; p17 = p18; p18 = temp; }
			if (GreaterThan(ref p16, ref p18)) { temp = p16; p16 = p18; p18 = temp; }
			if (GreaterThan(ref p16, ref p17)) { temp = p16; p16 = p17; p17 = temp; }
			if (GreaterThan(ref p20, ref p21)) { temp = p20; p20 = p21; p21 = temp; }
			if (GreaterThan(ref p19, ref p21)) { temp = p19; p19 = p21; p21 = temp; }
			if (GreaterThan(ref p19, ref p20)) { temp = p19; p19 = p20; p20 = temp; }
			if (GreaterThan(ref p16, ref p20)) { temp = p16; p16 = p20; p20 = temp; }
			if (GreaterThan(ref p16, ref p19)) { temp = p16; p16 = p19; p19 = temp; }
			if (GreaterThan(ref p17, ref p21)) { temp = p17; p17 = p21; p21 = temp; }
			if (GreaterThan(ref p18, ref p21)) { temp = p18; p18 = p21; p21 = temp; }
			if (GreaterThan(ref p17, ref p19)) { temp = p17; p17 = p19; p19 = temp; }
			if (GreaterThan(ref p18, ref p20)) { temp = p18; p18 = p20; p20 = temp; }
			if (GreaterThan(ref p18, ref p19)) { temp = p18; p18 = p19; p19 = temp; }
			if (GreaterThan(ref p11, ref p17)) { temp = p11; p11 = p17; p17 = temp; }
			if (GreaterThan(ref p11, ref p16)) { temp = p11; p11 = p16; p16 = temp; }
			if (GreaterThan(ref p12, ref p18)) { temp = p12; p12 = p18; p18 = temp; }
			if (GreaterThan(ref p12, ref p17)) { temp = p12; p12 = p17; p17 = temp; }
			if (GreaterThan(ref p12, ref p16)) { temp = p12; p12 = p16; p16 = temp; }
			if (GreaterThan(ref p13, ref p20)) { temp = p13; p13 = p20; p20 = temp; }
			if (GreaterThan(ref p13, ref p19)) { temp = p13; p13 = p19; p19 = temp; }
			if (GreaterThan(ref p14, ref p21)) { temp = p14; p14 = p21; p21 = temp; }
			if (GreaterThan(ref p15, ref p21)) { temp = p15; p15 = p21; p21 = temp; }
			if (GreaterThan(ref p14, ref p19)) { temp = p14; p14 = p19; p19 = temp; }
			if (GreaterThan(ref p15, ref p20)) { temp = p15; p15 = p20; p20 = temp; }
			if (GreaterThan(ref p15, ref p19)) { temp = p15; p15 = p19; p19 = temp; }
			if (GreaterThan(ref p13, ref p17)) { temp = p13; p13 = p17; p17 = temp; }
			if (GreaterThan(ref p13, ref p16)) { temp = p13; p13 = p16; p16 = temp; }
			if (GreaterThan(ref p14, ref p18)) { temp = p14; p14 = p18; p18 = temp; }
			if (GreaterThan(ref p15, ref p18)) { temp = p15; p15 = p18; p18 = temp; }
			if (GreaterThan(ref p14, ref p16)) { temp = p14; p14 = p16; p16 = temp; }
			if (GreaterThan(ref p15, ref p17)) { temp = p15; p15 = p17; p17 = temp; }
			if (GreaterThan(ref p15, ref p16)) { temp = p15; p15 = p16; p16 = temp; }
			if (GreaterThan(ref p0, ref p12)) { temp = p0; p0 = p12; p12 = temp; }
			if (GreaterThan(ref p0, ref p11)) { temp = p0; p0 = p11; p11 = temp; }
			if (GreaterThan(ref p1, ref p13)) { temp = p1; p1 = p13; p13 = temp; }
			if (GreaterThan(ref p1, ref p12)) { temp = p1; p1 = p12; p12 = temp; }
			if (GreaterThan(ref p1, ref p11)) { temp = p1; p1 = p11; p11 = temp; }
			if (GreaterThan(ref p2, ref p15)) { temp = p2; p2 = p15; p15 = temp; }
			if (GreaterThan(ref p2, ref p14)) { temp = p2; p2 = p14; p14 = temp; }
			if (GreaterThan(ref p3, ref p16)) { temp = p3; p3 = p16; p16 = temp; }
			if (GreaterThan(ref p4, ref p16)) { temp = p4; p4 = p16; p16 = temp; }
			if (GreaterThan(ref p3, ref p14)) { temp = p3; p3 = p14; p14 = temp; }
			if (GreaterThan(ref p4, ref p15)) { temp = p4; p4 = p15; p15 = temp; }
			if (GreaterThan(ref p4, ref p14)) { temp = p4; p4 = p14; p14 = temp; }
			if (GreaterThan(ref p2, ref p12)) { temp = p2; p2 = p12; p12 = temp; }
			if (GreaterThan(ref p2, ref p11)) { temp = p2; p2 = p11; p11 = temp; }
			if (GreaterThan(ref p3, ref p13)) { temp = p3; p3 = p13; p13 = temp; }
			if (GreaterThan(ref p4, ref p13)) { temp = p4; p4 = p13; p13 = temp; }
			if (GreaterThan(ref p3, ref p11)) { temp = p3; p3 = p11; p11 = temp; }
			if (GreaterThan(ref p4, ref p12)) { temp = p4; p4 = p12; p12 = temp; }
			if (GreaterThan(ref p4, ref p11)) { temp = p4; p4 = p11; p11 = temp; }
			if (GreaterThan(ref p5, ref p18)) { temp = p5; p5 = p18; p18 = temp; }
			if (GreaterThan(ref p5, ref p17)) { temp = p5; p5 = p17; p17 = temp; }
			if (GreaterThan(ref p6, ref p19)) { temp = p6; p6 = p19; p19 = temp; }
			if (GreaterThan(ref p7, ref p19)) { temp = p7; p7 = p19; p19 = temp; }
			if (GreaterThan(ref p6, ref p17)) { temp = p6; p6 = p17; p17 = temp; }
			if (GreaterThan(ref p7, ref p18)) { temp = p7; p7 = p18; p18 = temp; }
			if (GreaterThan(ref p7, ref p17)) { temp = p7; p7 = p17; p17 = temp; }
			if (GreaterThan(ref p8, ref p20)) { temp = p8; p8 = p20; p20 = temp; }
			if (GreaterThan(ref p9, ref p21)) { temp = p9; p9 = p21; p21 = temp; }
			if (GreaterThan(ref p10, ref p21)) { temp = p10; p10 = p21; p21 = temp; }
			if (GreaterThan(ref p9, ref p20)) { temp = p9; p9 = p20; p20 = temp; }
			if (GreaterThan(ref p10, ref p20)) { temp = p10; p10 = p20; p20 = temp; }
			if (GreaterThan(ref p8, ref p18)) { temp = p8; p8 = p18; p18 = temp; }
			if (GreaterThan(ref p8, ref p17)) { temp = p8; p8 = p17; p17 = temp; }
			if (GreaterThan(ref p9, ref p19)) { temp = p9; p9 = p19; p19 = temp; }
			if (GreaterThan(ref p10, ref p19)) { temp = p10; p10 = p19; p19 = temp; }
			if (GreaterThan(ref p9, ref p17)) { temp = p9; p9 = p17; p17 = temp; }
			if (GreaterThan(ref p10, ref p18)) { temp = p10; p10 = p18; p18 = temp; }
			if (GreaterThan(ref p10, ref p17)) { temp = p10; p10 = p17; p17 = temp; }
			if (GreaterThan(ref p5, ref p12)) { temp = p5; p5 = p12; p12 = temp; }
			if (GreaterThan(ref p5, ref p11)) { temp = p5; p5 = p11; p11 = temp; }
			if (GreaterThan(ref p6, ref p13)) { temp = p6; p6 = p13; p13 = temp; }
			if (GreaterThan(ref p7, ref p13)) { temp = p7; p7 = p13; p13 = temp; }
			if (GreaterThan(ref p6, ref p11)) { temp = p6; p6 = p11; p11 = temp; }
			if (GreaterThan(ref p7, ref p12)) { temp = p7; p7 = p12; p12 = temp; }
			if (GreaterThan(ref p7, ref p11)) { temp = p7; p7 = p11; p11 = temp; }
			if (GreaterThan(ref p8, ref p15)) { temp = p8; p8 = p15; p15 = temp; }
			if (GreaterThan(ref p8, ref p14)) { temp = p8; p8 = p14; p14 = temp; }
			if (GreaterThan(ref p9, ref p16)) { temp = p9; p9 = p16; p16 = temp; }
			if (GreaterThan(ref p10, ref p16)) { temp = p10; p10 = p16; p16 = temp; }
			if (GreaterThan(ref p9, ref p14)) { temp = p9; p9 = p14; p14 = temp; }
			if (GreaterThan(ref p10, ref p15)) { temp = p10; p10 = p15; p15 = temp; }
			if (GreaterThan(ref p10, ref p14)) { temp = p10; p10 = p14; p14 = temp; }
			if (GreaterThan(ref p8, ref p12)) { temp = p8; p8 = p12; p12 = temp; }
			if (GreaterThan(ref p8, ref p11)) { temp = p8; p8 = p11; p11 = temp; }
			if (GreaterThan(ref p9, ref p13)) { temp = p9; p9 = p13; p13 = temp; }
			if (GreaterThan(ref p10, ref p13)) { temp = p10; p10 = p13; p13 = temp; }
			if (GreaterThan(ref p9, ref p11)) { temp = p9; p9 = p11; p11 = temp; }
			if (GreaterThan(ref p10, ref p12)) { temp = p10; p10 = p12; p12 = temp; }
			if (GreaterThan(ref p10, ref p11)) { temp = p10; p10 = p11; p11 = temp; }
#endif
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
#if NETSTANDARD1_3
			if (p0.CompareTo(p1) > 0) { temp = p0; p0 = p1; p1 = temp; }
			if (p3.CompareTo(p4) > 0) { temp = p3; p3 = p4; p4 = temp; }
			if (p2.CompareTo(p4) > 0) { temp = p2; p2 = p4; p4 = temp; }
			if (p2.CompareTo(p3) > 0) { temp = p2; p2 = p3; p3 = temp; }
			if (p0.CompareTo(p3) > 0) { temp = p0; p0 = p3; p3 = temp; }
			if (p0.CompareTo(p2) > 0) { temp = p0; p0 = p2; p2 = temp; }
			if (p1.CompareTo(p4) > 0) { temp = p1; p1 = p4; p4 = temp; }
			if (p1.CompareTo(p3) > 0) { temp = p1; p1 = p3; p3 = temp; }
			if (p1.CompareTo(p2) > 0) { temp = p1; p1 = p2; p2 = temp; }
			if (p6.CompareTo(p7) > 0) { temp = p6; p6 = p7; p7 = temp; }
			if (p5.CompareTo(p7) > 0) { temp = p5; p5 = p7; p7 = temp; }
			if (p5.CompareTo(p6) > 0) { temp = p5; p5 = p6; p6 = temp; }
			if (p9.CompareTo(p10) > 0) { temp = p9; p9 = p10; p10 = temp; }
			if (p8.CompareTo(p10) > 0) { temp = p8; p8 = p10; p10 = temp; }
			if (p8.CompareTo(p9) > 0) { temp = p8; p8 = p9; p9 = temp; }
			if (p5.CompareTo(p9) > 0) { temp = p5; p5 = p9; p9 = temp; }
			if (p5.CompareTo(p8) > 0) { temp = p5; p5 = p8; p8 = temp; }
			if (p6.CompareTo(p10) > 0) { temp = p6; p6 = p10; p10 = temp; }
			if (p7.CompareTo(p10) > 0) { temp = p7; p7 = p10; p10 = temp; }
			if (p6.CompareTo(p8) > 0) { temp = p6; p6 = p8; p8 = temp; }
			if (p7.CompareTo(p9) > 0) { temp = p7; p7 = p9; p9 = temp; }
			if (p7.CompareTo(p8) > 0) { temp = p7; p7 = p8; p8 = temp; }
			if (p0.CompareTo(p6) > 0) { temp = p0; p0 = p6; p6 = temp; }
			if (p0.CompareTo(p5) > 0) { temp = p0; p0 = p5; p5 = temp; }
			if (p1.CompareTo(p7) > 0) { temp = p1; p1 = p7; p7 = temp; }
			if (p1.CompareTo(p6) > 0) { temp = p1; p1 = p6; p6 = temp; }
			if (p1.CompareTo(p5) > 0) { temp = p1; p1 = p5; p5 = temp; }
			if (p2.CompareTo(p9) > 0) { temp = p2; p2 = p9; p9 = temp; }
			if (p2.CompareTo(p8) > 0) { temp = p2; p2 = p8; p8 = temp; }
			if (p3.CompareTo(p10) > 0) { temp = p3; p3 = p10; p10 = temp; }
			if (p4.CompareTo(p10) > 0) { temp = p4; p4 = p10; p10 = temp; }
			if (p3.CompareTo(p8) > 0) { temp = p3; p3 = p8; p8 = temp; }
			if (p4.CompareTo(p9) > 0) { temp = p4; p4 = p9; p9 = temp; }
			if (p4.CompareTo(p8) > 0) { temp = p4; p4 = p8; p8 = temp; }
			if (p2.CompareTo(p6) > 0) { temp = p2; p2 = p6; p6 = temp; }
			if (p2.CompareTo(p5) > 0) { temp = p2; p2 = p5; p5 = temp; }
			if (p3.CompareTo(p7) > 0) { temp = p3; p3 = p7; p7 = temp; }
			if (p4.CompareTo(p7) > 0) { temp = p4; p4 = p7; p7 = temp; }
			if (p3.CompareTo(p5) > 0) { temp = p3; p3 = p5; p5 = temp; }
			if (p4.CompareTo(p6) > 0) { temp = p4; p4 = p6; p6 = temp; }
			if (p4.CompareTo(p5) > 0) { temp = p4; p4 = p5; p5 = temp; }
			if (p12.CompareTo(p13) > 0) { temp = p12; p12 = p13; p13 = temp; }
			if (p11.CompareTo(p13) > 0) { temp = p11; p11 = p13; p13 = temp; }
			if (p11.CompareTo(p12) > 0) { temp = p11; p11 = p12; p12 = temp; }
			if (p15.CompareTo(p16) > 0) { temp = p15; p15 = p16; p16 = temp; }
			if (p14.CompareTo(p16) > 0) { temp = p14; p14 = p16; p16 = temp; }
			if (p14.CompareTo(p15) > 0) { temp = p14; p14 = p15; p15 = temp; }
			if (p11.CompareTo(p15) > 0) { temp = p11; p11 = p15; p15 = temp; }
			if (p11.CompareTo(p14) > 0) { temp = p11; p11 = p14; p14 = temp; }
			if (p12.CompareTo(p16) > 0) { temp = p12; p12 = p16; p16 = temp; }
			if (p13.CompareTo(p16) > 0) { temp = p13; p13 = p16; p16 = temp; }
			if (p12.CompareTo(p14) > 0) { temp = p12; p12 = p14; p14 = temp; }
			if (p13.CompareTo(p15) > 0) { temp = p13; p13 = p15; p15 = temp; }
			if (p13.CompareTo(p14) > 0) { temp = p13; p13 = p14; p14 = temp; }
			if (p18.CompareTo(p19) > 0) { temp = p18; p18 = p19; p19 = temp; }
			if (p17.CompareTo(p19) > 0) { temp = p17; p17 = p19; p19 = temp; }
			if (p17.CompareTo(p18) > 0) { temp = p17; p17 = p18; p18 = temp; }
			if (p21.CompareTo(p22) > 0) { temp = p21; p21 = p22; p22 = temp; }
			if (p20.CompareTo(p22) > 0) { temp = p20; p20 = p22; p22 = temp; }
			if (p20.CompareTo(p21) > 0) { temp = p20; p20 = p21; p21 = temp; }
			if (p17.CompareTo(p21) > 0) { temp = p17; p17 = p21; p21 = temp; }
			if (p17.CompareTo(p20) > 0) { temp = p17; p17 = p20; p20 = temp; }
			if (p18.CompareTo(p22) > 0) { temp = p18; p18 = p22; p22 = temp; }
			if (p19.CompareTo(p22) > 0) { temp = p19; p19 = p22; p22 = temp; }
			if (p18.CompareTo(p20) > 0) { temp = p18; p18 = p20; p20 = temp; }
			if (p19.CompareTo(p21) > 0) { temp = p19; p19 = p21; p21 = temp; }
			if (p19.CompareTo(p20) > 0) { temp = p19; p19 = p20; p20 = temp; }
			if (p11.CompareTo(p18) > 0) { temp = p11; p11 = p18; p18 = temp; }
			if (p11.CompareTo(p17) > 0) { temp = p11; p11 = p17; p17 = temp; }
			if (p12.CompareTo(p19) > 0) { temp = p12; p12 = p19; p19 = temp; }
			if (p13.CompareTo(p19) > 0) { temp = p13; p13 = p19; p19 = temp; }
			if (p12.CompareTo(p17) > 0) { temp = p12; p12 = p17; p17 = temp; }
			if (p13.CompareTo(p18) > 0) { temp = p13; p13 = p18; p18 = temp; }
			if (p13.CompareTo(p17) > 0) { temp = p13; p13 = p17; p17 = temp; }
			if (p14.CompareTo(p21) > 0) { temp = p14; p14 = p21; p21 = temp; }
			if (p14.CompareTo(p20) > 0) { temp = p14; p14 = p20; p20 = temp; }
			if (p15.CompareTo(p22) > 0) { temp = p15; p15 = p22; p22 = temp; }
			if (p16.CompareTo(p22) > 0) { temp = p16; p16 = p22; p22 = temp; }
			if (p15.CompareTo(p20) > 0) { temp = p15; p15 = p20; p20 = temp; }
			if (p16.CompareTo(p21) > 0) { temp = p16; p16 = p21; p21 = temp; }
			if (p16.CompareTo(p20) > 0) { temp = p16; p16 = p20; p20 = temp; }
			if (p14.CompareTo(p18) > 0) { temp = p14; p14 = p18; p18 = temp; }
			if (p14.CompareTo(p17) > 0) { temp = p14; p14 = p17; p17 = temp; }
			if (p15.CompareTo(p19) > 0) { temp = p15; p15 = p19; p19 = temp; }
			if (p16.CompareTo(p19) > 0) { temp = p16; p16 = p19; p19 = temp; }
			if (p15.CompareTo(p17) > 0) { temp = p15; p15 = p17; p17 = temp; }
			if (p16.CompareTo(p18) > 0) { temp = p16; p16 = p18; p18 = temp; }
			if (p16.CompareTo(p17) > 0) { temp = p16; p16 = p17; p17 = temp; }
			if (p0.CompareTo(p12) > 0) { temp = p0; p0 = p12; p12 = temp; }
			if (p0.CompareTo(p11) > 0) { temp = p0; p0 = p11; p11 = temp; }
			if (p1.CompareTo(p13) > 0) { temp = p1; p1 = p13; p13 = temp; }
			if (p1.CompareTo(p12) > 0) { temp = p1; p1 = p12; p12 = temp; }
			if (p1.CompareTo(p11) > 0) { temp = p1; p1 = p11; p11 = temp; }
			if (p2.CompareTo(p15) > 0) { temp = p2; p2 = p15; p15 = temp; }
			if (p2.CompareTo(p14) > 0) { temp = p2; p2 = p14; p14 = temp; }
			if (p3.CompareTo(p16) > 0) { temp = p3; p3 = p16; p16 = temp; }
			if (p4.CompareTo(p16) > 0) { temp = p4; p4 = p16; p16 = temp; }
			if (p3.CompareTo(p14) > 0) { temp = p3; p3 = p14; p14 = temp; }
			if (p4.CompareTo(p15) > 0) { temp = p4; p4 = p15; p15 = temp; }
			if (p4.CompareTo(p14) > 0) { temp = p4; p4 = p14; p14 = temp; }
			if (p2.CompareTo(p12) > 0) { temp = p2; p2 = p12; p12 = temp; }
			if (p2.CompareTo(p11) > 0) { temp = p2; p2 = p11; p11 = temp; }
			if (p3.CompareTo(p13) > 0) { temp = p3; p3 = p13; p13 = temp; }
			if (p4.CompareTo(p13) > 0) { temp = p4; p4 = p13; p13 = temp; }
			if (p3.CompareTo(p11) > 0) { temp = p3; p3 = p11; p11 = temp; }
			if (p4.CompareTo(p12) > 0) { temp = p4; p4 = p12; p12 = temp; }
			if (p4.CompareTo(p11) > 0) { temp = p4; p4 = p11; p11 = temp; }
			if (p5.CompareTo(p18) > 0) { temp = p5; p5 = p18; p18 = temp; }
			if (p5.CompareTo(p17) > 0) { temp = p5; p5 = p17; p17 = temp; }
			if (p6.CompareTo(p19) > 0) { temp = p6; p6 = p19; p19 = temp; }
			if (p7.CompareTo(p19) > 0) { temp = p7; p7 = p19; p19 = temp; }
			if (p6.CompareTo(p17) > 0) { temp = p6; p6 = p17; p17 = temp; }
			if (p7.CompareTo(p18) > 0) { temp = p7; p7 = p18; p18 = temp; }
			if (p7.CompareTo(p17) > 0) { temp = p7; p7 = p17; p17 = temp; }
			if (p8.CompareTo(p21) > 0) { temp = p8; p8 = p21; p21 = temp; }
			if (p8.CompareTo(p20) > 0) { temp = p8; p8 = p20; p20 = temp; }
			if (p9.CompareTo(p22) > 0) { temp = p9; p9 = p22; p22 = temp; }
			if (p10.CompareTo(p22) > 0) { temp = p10; p10 = p22; p22 = temp; }
			if (p9.CompareTo(p20) > 0) { temp = p9; p9 = p20; p20 = temp; }
			if (p10.CompareTo(p21) > 0) { temp = p10; p10 = p21; p21 = temp; }
			if (p10.CompareTo(p20) > 0) { temp = p10; p10 = p20; p20 = temp; }
			if (p8.CompareTo(p18) > 0) { temp = p8; p8 = p18; p18 = temp; }
			if (p8.CompareTo(p17) > 0) { temp = p8; p8 = p17; p17 = temp; }
			if (p9.CompareTo(p19) > 0) { temp = p9; p9 = p19; p19 = temp; }
			if (p10.CompareTo(p19) > 0) { temp = p10; p10 = p19; p19 = temp; }
			if (p9.CompareTo(p17) > 0) { temp = p9; p9 = p17; p17 = temp; }
			if (p10.CompareTo(p18) > 0) { temp = p10; p10 = p18; p18 = temp; }
			if (p10.CompareTo(p17) > 0) { temp = p10; p10 = p17; p17 = temp; }
			if (p5.CompareTo(p12) > 0) { temp = p5; p5 = p12; p12 = temp; }
			if (p5.CompareTo(p11) > 0) { temp = p5; p5 = p11; p11 = temp; }
			if (p6.CompareTo(p13) > 0) { temp = p6; p6 = p13; p13 = temp; }
			if (p7.CompareTo(p13) > 0) { temp = p7; p7 = p13; p13 = temp; }
			if (p6.CompareTo(p11) > 0) { temp = p6; p6 = p11; p11 = temp; }
			if (p7.CompareTo(p12) > 0) { temp = p7; p7 = p12; p12 = temp; }
			if (p7.CompareTo(p11) > 0) { temp = p7; p7 = p11; p11 = temp; }
			if (p8.CompareTo(p15) > 0) { temp = p8; p8 = p15; p15 = temp; }
			if (p8.CompareTo(p14) > 0) { temp = p8; p8 = p14; p14 = temp; }
			if (p9.CompareTo(p16) > 0) { temp = p9; p9 = p16; p16 = temp; }
			if (p10.CompareTo(p16) > 0) { temp = p10; p10 = p16; p16 = temp; }
			if (p9.CompareTo(p14) > 0) { temp = p9; p9 = p14; p14 = temp; }
			if (p10.CompareTo(p15) > 0) { temp = p10; p10 = p15; p15 = temp; }
			if (p10.CompareTo(p14) > 0) { temp = p10; p10 = p14; p14 = temp; }
			if (p8.CompareTo(p12) > 0) { temp = p8; p8 = p12; p12 = temp; }
			if (p8.CompareTo(p11) > 0) { temp = p8; p8 = p11; p11 = temp; }
			if (p9.CompareTo(p13) > 0) { temp = p9; p9 = p13; p13 = temp; }
			if (p10.CompareTo(p13) > 0) { temp = p10; p10 = p13; p13 = temp; }
			if (p9.CompareTo(p11) > 0) { temp = p9; p9 = p11; p11 = temp; }
			if (p10.CompareTo(p12) > 0) { temp = p10; p10 = p12; p12 = temp; }
			if (p10.CompareTo(p11) > 0) { temp = p10; p10 = p11; p11 = temp; }
#else
			if (GreaterThan(ref p0, ref p1)) { temp = p0; p0 = p1; p1 = temp; }
			if (GreaterThan(ref p3, ref p4)) { temp = p3; p3 = p4; p4 = temp; }
			if (GreaterThan(ref p2, ref p4)) { temp = p2; p2 = p4; p4 = temp; }
			if (GreaterThan(ref p2, ref p3)) { temp = p2; p2 = p3; p3 = temp; }
			if (GreaterThan(ref p0, ref p3)) { temp = p0; p0 = p3; p3 = temp; }
			if (GreaterThan(ref p0, ref p2)) { temp = p0; p0 = p2; p2 = temp; }
			if (GreaterThan(ref p1, ref p4)) { temp = p1; p1 = p4; p4 = temp; }
			if (GreaterThan(ref p1, ref p3)) { temp = p1; p1 = p3; p3 = temp; }
			if (GreaterThan(ref p1, ref p2)) { temp = p1; p1 = p2; p2 = temp; }
			if (GreaterThan(ref p6, ref p7)) { temp = p6; p6 = p7; p7 = temp; }
			if (GreaterThan(ref p5, ref p7)) { temp = p5; p5 = p7; p7 = temp; }
			if (GreaterThan(ref p5, ref p6)) { temp = p5; p5 = p6; p6 = temp; }
			if (GreaterThan(ref p9, ref p10)) { temp = p9; p9 = p10; p10 = temp; }
			if (GreaterThan(ref p8, ref p10)) { temp = p8; p8 = p10; p10 = temp; }
			if (GreaterThan(ref p8, ref p9)) { temp = p8; p8 = p9; p9 = temp; }
			if (GreaterThan(ref p5, ref p9)) { temp = p5; p5 = p9; p9 = temp; }
			if (GreaterThan(ref p5, ref p8)) { temp = p5; p5 = p8; p8 = temp; }
			if (GreaterThan(ref p6, ref p10)) { temp = p6; p6 = p10; p10 = temp; }
			if (GreaterThan(ref p7, ref p10)) { temp = p7; p7 = p10; p10 = temp; }
			if (GreaterThan(ref p6, ref p8)) { temp = p6; p6 = p8; p8 = temp; }
			if (GreaterThan(ref p7, ref p9)) { temp = p7; p7 = p9; p9 = temp; }
			if (GreaterThan(ref p7, ref p8)) { temp = p7; p7 = p8; p8 = temp; }
			if (GreaterThan(ref p0, ref p6)) { temp = p0; p0 = p6; p6 = temp; }
			if (GreaterThan(ref p0, ref p5)) { temp = p0; p0 = p5; p5 = temp; }
			if (GreaterThan(ref p1, ref p7)) { temp = p1; p1 = p7; p7 = temp; }
			if (GreaterThan(ref p1, ref p6)) { temp = p1; p1 = p6; p6 = temp; }
			if (GreaterThan(ref p1, ref p5)) { temp = p1; p1 = p5; p5 = temp; }
			if (GreaterThan(ref p2, ref p9)) { temp = p2; p2 = p9; p9 = temp; }
			if (GreaterThan(ref p2, ref p8)) { temp = p2; p2 = p8; p8 = temp; }
			if (GreaterThan(ref p3, ref p10)) { temp = p3; p3 = p10; p10 = temp; }
			if (GreaterThan(ref p4, ref p10)) { temp = p4; p4 = p10; p10 = temp; }
			if (GreaterThan(ref p3, ref p8)) { temp = p3; p3 = p8; p8 = temp; }
			if (GreaterThan(ref p4, ref p9)) { temp = p4; p4 = p9; p9 = temp; }
			if (GreaterThan(ref p4, ref p8)) { temp = p4; p4 = p8; p8 = temp; }
			if (GreaterThan(ref p2, ref p6)) { temp = p2; p2 = p6; p6 = temp; }
			if (GreaterThan(ref p2, ref p5)) { temp = p2; p2 = p5; p5 = temp; }
			if (GreaterThan(ref p3, ref p7)) { temp = p3; p3 = p7; p7 = temp; }
			if (GreaterThan(ref p4, ref p7)) { temp = p4; p4 = p7; p7 = temp; }
			if (GreaterThan(ref p3, ref p5)) { temp = p3; p3 = p5; p5 = temp; }
			if (GreaterThan(ref p4, ref p6)) { temp = p4; p4 = p6; p6 = temp; }
			if (GreaterThan(ref p4, ref p5)) { temp = p4; p4 = p5; p5 = temp; }
			if (GreaterThan(ref p12, ref p13)) { temp = p12; p12 = p13; p13 = temp; }
			if (GreaterThan(ref p11, ref p13)) { temp = p11; p11 = p13; p13 = temp; }
			if (GreaterThan(ref p11, ref p12)) { temp = p11; p11 = p12; p12 = temp; }
			if (GreaterThan(ref p15, ref p16)) { temp = p15; p15 = p16; p16 = temp; }
			if (GreaterThan(ref p14, ref p16)) { temp = p14; p14 = p16; p16 = temp; }
			if (GreaterThan(ref p14, ref p15)) { temp = p14; p14 = p15; p15 = temp; }
			if (GreaterThan(ref p11, ref p15)) { temp = p11; p11 = p15; p15 = temp; }
			if (GreaterThan(ref p11, ref p14)) { temp = p11; p11 = p14; p14 = temp; }
			if (GreaterThan(ref p12, ref p16)) { temp = p12; p12 = p16; p16 = temp; }
			if (GreaterThan(ref p13, ref p16)) { temp = p13; p13 = p16; p16 = temp; }
			if (GreaterThan(ref p12, ref p14)) { temp = p12; p12 = p14; p14 = temp; }
			if (GreaterThan(ref p13, ref p15)) { temp = p13; p13 = p15; p15 = temp; }
			if (GreaterThan(ref p13, ref p14)) { temp = p13; p13 = p14; p14 = temp; }
			if (GreaterThan(ref p18, ref p19)) { temp = p18; p18 = p19; p19 = temp; }
			if (GreaterThan(ref p17, ref p19)) { temp = p17; p17 = p19; p19 = temp; }
			if (GreaterThan(ref p17, ref p18)) { temp = p17; p17 = p18; p18 = temp; }
			if (GreaterThan(ref p21, ref p22)) { temp = p21; p21 = p22; p22 = temp; }
			if (GreaterThan(ref p20, ref p22)) { temp = p20; p20 = p22; p22 = temp; }
			if (GreaterThan(ref p20, ref p21)) { temp = p20; p20 = p21; p21 = temp; }
			if (GreaterThan(ref p17, ref p21)) { temp = p17; p17 = p21; p21 = temp; }
			if (GreaterThan(ref p17, ref p20)) { temp = p17; p17 = p20; p20 = temp; }
			if (GreaterThan(ref p18, ref p22)) { temp = p18; p18 = p22; p22 = temp; }
			if (GreaterThan(ref p19, ref p22)) { temp = p19; p19 = p22; p22 = temp; }
			if (GreaterThan(ref p18, ref p20)) { temp = p18; p18 = p20; p20 = temp; }
			if (GreaterThan(ref p19, ref p21)) { temp = p19; p19 = p21; p21 = temp; }
			if (GreaterThan(ref p19, ref p20)) { temp = p19; p19 = p20; p20 = temp; }
			if (GreaterThan(ref p11, ref p18)) { temp = p11; p11 = p18; p18 = temp; }
			if (GreaterThan(ref p11, ref p17)) { temp = p11; p11 = p17; p17 = temp; }
			if (GreaterThan(ref p12, ref p19)) { temp = p12; p12 = p19; p19 = temp; }
			if (GreaterThan(ref p13, ref p19)) { temp = p13; p13 = p19; p19 = temp; }
			if (GreaterThan(ref p12, ref p17)) { temp = p12; p12 = p17; p17 = temp; }
			if (GreaterThan(ref p13, ref p18)) { temp = p13; p13 = p18; p18 = temp; }
			if (GreaterThan(ref p13, ref p17)) { temp = p13; p13 = p17; p17 = temp; }
			if (GreaterThan(ref p14, ref p21)) { temp = p14; p14 = p21; p21 = temp; }
			if (GreaterThan(ref p14, ref p20)) { temp = p14; p14 = p20; p20 = temp; }
			if (GreaterThan(ref p15, ref p22)) { temp = p15; p15 = p22; p22 = temp; }
			if (GreaterThan(ref p16, ref p22)) { temp = p16; p16 = p22; p22 = temp; }
			if (GreaterThan(ref p15, ref p20)) { temp = p15; p15 = p20; p20 = temp; }
			if (GreaterThan(ref p16, ref p21)) { temp = p16; p16 = p21; p21 = temp; }
			if (GreaterThan(ref p16, ref p20)) { temp = p16; p16 = p20; p20 = temp; }
			if (GreaterThan(ref p14, ref p18)) { temp = p14; p14 = p18; p18 = temp; }
			if (GreaterThan(ref p14, ref p17)) { temp = p14; p14 = p17; p17 = temp; }
			if (GreaterThan(ref p15, ref p19)) { temp = p15; p15 = p19; p19 = temp; }
			if (GreaterThan(ref p16, ref p19)) { temp = p16; p16 = p19; p19 = temp; }
			if (GreaterThan(ref p15, ref p17)) { temp = p15; p15 = p17; p17 = temp; }
			if (GreaterThan(ref p16, ref p18)) { temp = p16; p16 = p18; p18 = temp; }
			if (GreaterThan(ref p16, ref p17)) { temp = p16; p16 = p17; p17 = temp; }
			if (GreaterThan(ref p0, ref p12)) { temp = p0; p0 = p12; p12 = temp; }
			if (GreaterThan(ref p0, ref p11)) { temp = p0; p0 = p11; p11 = temp; }
			if (GreaterThan(ref p1, ref p13)) { temp = p1; p1 = p13; p13 = temp; }
			if (GreaterThan(ref p1, ref p12)) { temp = p1; p1 = p12; p12 = temp; }
			if (GreaterThan(ref p1, ref p11)) { temp = p1; p1 = p11; p11 = temp; }
			if (GreaterThan(ref p2, ref p15)) { temp = p2; p2 = p15; p15 = temp; }
			if (GreaterThan(ref p2, ref p14)) { temp = p2; p2 = p14; p14 = temp; }
			if (GreaterThan(ref p3, ref p16)) { temp = p3; p3 = p16; p16 = temp; }
			if (GreaterThan(ref p4, ref p16)) { temp = p4; p4 = p16; p16 = temp; }
			if (GreaterThan(ref p3, ref p14)) { temp = p3; p3 = p14; p14 = temp; }
			if (GreaterThan(ref p4, ref p15)) { temp = p4; p4 = p15; p15 = temp; }
			if (GreaterThan(ref p4, ref p14)) { temp = p4; p4 = p14; p14 = temp; }
			if (GreaterThan(ref p2, ref p12)) { temp = p2; p2 = p12; p12 = temp; }
			if (GreaterThan(ref p2, ref p11)) { temp = p2; p2 = p11; p11 = temp; }
			if (GreaterThan(ref p3, ref p13)) { temp = p3; p3 = p13; p13 = temp; }
			if (GreaterThan(ref p4, ref p13)) { temp = p4; p4 = p13; p13 = temp; }
			if (GreaterThan(ref p3, ref p11)) { temp = p3; p3 = p11; p11 = temp; }
			if (GreaterThan(ref p4, ref p12)) { temp = p4; p4 = p12; p12 = temp; }
			if (GreaterThan(ref p4, ref p11)) { temp = p4; p4 = p11; p11 = temp; }
			if (GreaterThan(ref p5, ref p18)) { temp = p5; p5 = p18; p18 = temp; }
			if (GreaterThan(ref p5, ref p17)) { temp = p5; p5 = p17; p17 = temp; }
			if (GreaterThan(ref p6, ref p19)) { temp = p6; p6 = p19; p19 = temp; }
			if (GreaterThan(ref p7, ref p19)) { temp = p7; p7 = p19; p19 = temp; }
			if (GreaterThan(ref p6, ref p17)) { temp = p6; p6 = p17; p17 = temp; }
			if (GreaterThan(ref p7, ref p18)) { temp = p7; p7 = p18; p18 = temp; }
			if (GreaterThan(ref p7, ref p17)) { temp = p7; p7 = p17; p17 = temp; }
			if (GreaterThan(ref p8, ref p21)) { temp = p8; p8 = p21; p21 = temp; }
			if (GreaterThan(ref p8, ref p20)) { temp = p8; p8 = p20; p20 = temp; }
			if (GreaterThan(ref p9, ref p22)) { temp = p9; p9 = p22; p22 = temp; }
			if (GreaterThan(ref p10, ref p22)) { temp = p10; p10 = p22; p22 = temp; }
			if (GreaterThan(ref p9, ref p20)) { temp = p9; p9 = p20; p20 = temp; }
			if (GreaterThan(ref p10, ref p21)) { temp = p10; p10 = p21; p21 = temp; }
			if (GreaterThan(ref p10, ref p20)) { temp = p10; p10 = p20; p20 = temp; }
			if (GreaterThan(ref p8, ref p18)) { temp = p8; p8 = p18; p18 = temp; }
			if (GreaterThan(ref p8, ref p17)) { temp = p8; p8 = p17; p17 = temp; }
			if (GreaterThan(ref p9, ref p19)) { temp = p9; p9 = p19; p19 = temp; }
			if (GreaterThan(ref p10, ref p19)) { temp = p10; p10 = p19; p19 = temp; }
			if (GreaterThan(ref p9, ref p17)) { temp = p9; p9 = p17; p17 = temp; }
			if (GreaterThan(ref p10, ref p18)) { temp = p10; p10 = p18; p18 = temp; }
			if (GreaterThan(ref p10, ref p17)) { temp = p10; p10 = p17; p17 = temp; }
			if (GreaterThan(ref p5, ref p12)) { temp = p5; p5 = p12; p12 = temp; }
			if (GreaterThan(ref p5, ref p11)) { temp = p5; p5 = p11; p11 = temp; }
			if (GreaterThan(ref p6, ref p13)) { temp = p6; p6 = p13; p13 = temp; }
			if (GreaterThan(ref p7, ref p13)) { temp = p7; p7 = p13; p13 = temp; }
			if (GreaterThan(ref p6, ref p11)) { temp = p6; p6 = p11; p11 = temp; }
			if (GreaterThan(ref p7, ref p12)) { temp = p7; p7 = p12; p12 = temp; }
			if (GreaterThan(ref p7, ref p11)) { temp = p7; p7 = p11; p11 = temp; }
			if (GreaterThan(ref p8, ref p15)) { temp = p8; p8 = p15; p15 = temp; }
			if (GreaterThan(ref p8, ref p14)) { temp = p8; p8 = p14; p14 = temp; }
			if (GreaterThan(ref p9, ref p16)) { temp = p9; p9 = p16; p16 = temp; }
			if (GreaterThan(ref p10, ref p16)) { temp = p10; p10 = p16; p16 = temp; }
			if (GreaterThan(ref p9, ref p14)) { temp = p9; p9 = p14; p14 = temp; }
			if (GreaterThan(ref p10, ref p15)) { temp = p10; p10 = p15; p15 = temp; }
			if (GreaterThan(ref p10, ref p14)) { temp = p10; p10 = p14; p14 = temp; }
			if (GreaterThan(ref p8, ref p12)) { temp = p8; p8 = p12; p12 = temp; }
			if (GreaterThan(ref p8, ref p11)) { temp = p8; p8 = p11; p11 = temp; }
			if (GreaterThan(ref p9, ref p13)) { temp = p9; p9 = p13; p13 = temp; }
			if (GreaterThan(ref p10, ref p13)) { temp = p10; p10 = p13; p13 = temp; }
			if (GreaterThan(ref p9, ref p11)) { temp = p9; p9 = p11; p11 = temp; }
			if (GreaterThan(ref p10, ref p12)) { temp = p10; p10 = p12; p12 = temp; }
			if (GreaterThan(ref p10, ref p11)) { temp = p10; p10 = p11; p11 = temp; }
#endif
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
#if NETSTANDARD1_3
			if (p1.CompareTo(p2) > 0) { temp = p1; p1 = p2; p2 = temp; }
			if (p0.CompareTo(p2) > 0) { temp = p0; p0 = p2; p2 = temp; }
			if (p0.CompareTo(p1) > 0) { temp = p0; p0 = p1; p1 = temp; }
			if (p4.CompareTo(p5) > 0) { temp = p4; p4 = p5; p5 = temp; }
			if (p3.CompareTo(p5) > 0) { temp = p3; p3 = p5; p5 = temp; }
			if (p3.CompareTo(p4) > 0) { temp = p3; p3 = p4; p4 = temp; }
			if (p0.CompareTo(p4) > 0) { temp = p0; p0 = p4; p4 = temp; }
			if (p0.CompareTo(p3) > 0) { temp = p0; p0 = p3; p3 = temp; }
			if (p1.CompareTo(p5) > 0) { temp = p1; p1 = p5; p5 = temp; }
			if (p2.CompareTo(p5) > 0) { temp = p2; p2 = p5; p5 = temp; }
			if (p1.CompareTo(p3) > 0) { temp = p1; p1 = p3; p3 = temp; }
			if (p2.CompareTo(p4) > 0) { temp = p2; p2 = p4; p4 = temp; }
			if (p2.CompareTo(p3) > 0) { temp = p2; p2 = p3; p3 = temp; }
			if (p7.CompareTo(p8) > 0) { temp = p7; p7 = p8; p8 = temp; }
			if (p6.CompareTo(p8) > 0) { temp = p6; p6 = p8; p8 = temp; }
			if (p6.CompareTo(p7) > 0) { temp = p6; p6 = p7; p7 = temp; }
			if (p10.CompareTo(p11) > 0) { temp = p10; p10 = p11; p11 = temp; }
			if (p9.CompareTo(p11) > 0) { temp = p9; p9 = p11; p11 = temp; }
			if (p9.CompareTo(p10) > 0) { temp = p9; p9 = p10; p10 = temp; }
			if (p6.CompareTo(p10) > 0) { temp = p6; p6 = p10; p10 = temp; }
			if (p6.CompareTo(p9) > 0) { temp = p6; p6 = p9; p9 = temp; }
			if (p7.CompareTo(p11) > 0) { temp = p7; p7 = p11; p11 = temp; }
			if (p8.CompareTo(p11) > 0) { temp = p8; p8 = p11; p11 = temp; }
			if (p7.CompareTo(p9) > 0) { temp = p7; p7 = p9; p9 = temp; }
			if (p8.CompareTo(p10) > 0) { temp = p8; p8 = p10; p10 = temp; }
			if (p8.CompareTo(p9) > 0) { temp = p8; p8 = p9; p9 = temp; }
			if (p0.CompareTo(p7) > 0) { temp = p0; p0 = p7; p7 = temp; }
			if (p0.CompareTo(p6) > 0) { temp = p0; p0 = p6; p6 = temp; }
			if (p1.CompareTo(p8) > 0) { temp = p1; p1 = p8; p8 = temp; }
			if (p2.CompareTo(p8) > 0) { temp = p2; p2 = p8; p8 = temp; }
			if (p1.CompareTo(p6) > 0) { temp = p1; p1 = p6; p6 = temp; }
			if (p2.CompareTo(p7) > 0) { temp = p2; p2 = p7; p7 = temp; }
			if (p2.CompareTo(p6) > 0) { temp = p2; p2 = p6; p6 = temp; }
			if (p3.CompareTo(p10) > 0) { temp = p3; p3 = p10; p10 = temp; }
			if (p3.CompareTo(p9) > 0) { temp = p3; p3 = p9; p9 = temp; }
			if (p4.CompareTo(p11) > 0) { temp = p4; p4 = p11; p11 = temp; }
			if (p5.CompareTo(p11) > 0) { temp = p5; p5 = p11; p11 = temp; }
			if (p4.CompareTo(p9) > 0) { temp = p4; p4 = p9; p9 = temp; }
			if (p5.CompareTo(p10) > 0) { temp = p5; p5 = p10; p10 = temp; }
			if (p5.CompareTo(p9) > 0) { temp = p5; p5 = p9; p9 = temp; }
			if (p3.CompareTo(p7) > 0) { temp = p3; p3 = p7; p7 = temp; }
			if (p3.CompareTo(p6) > 0) { temp = p3; p3 = p6; p6 = temp; }
			if (p4.CompareTo(p8) > 0) { temp = p4; p4 = p8; p8 = temp; }
			if (p5.CompareTo(p8) > 0) { temp = p5; p5 = p8; p8 = temp; }
			if (p4.CompareTo(p6) > 0) { temp = p4; p4 = p6; p6 = temp; }
			if (p5.CompareTo(p7) > 0) { temp = p5; p5 = p7; p7 = temp; }
			if (p5.CompareTo(p6) > 0) { temp = p5; p5 = p6; p6 = temp; }
			if (p13.CompareTo(p14) > 0) { temp = p13; p13 = p14; p14 = temp; }
			if (p12.CompareTo(p14) > 0) { temp = p12; p12 = p14; p14 = temp; }
			if (p12.CompareTo(p13) > 0) { temp = p12; p12 = p13; p13 = temp; }
			if (p16.CompareTo(p17) > 0) { temp = p16; p16 = p17; p17 = temp; }
			if (p15.CompareTo(p17) > 0) { temp = p15; p15 = p17; p17 = temp; }
			if (p15.CompareTo(p16) > 0) { temp = p15; p15 = p16; p16 = temp; }
			if (p12.CompareTo(p16) > 0) { temp = p12; p12 = p16; p16 = temp; }
			if (p12.CompareTo(p15) > 0) { temp = p12; p12 = p15; p15 = temp; }
			if (p13.CompareTo(p17) > 0) { temp = p13; p13 = p17; p17 = temp; }
			if (p14.CompareTo(p17) > 0) { temp = p14; p14 = p17; p17 = temp; }
			if (p13.CompareTo(p15) > 0) { temp = p13; p13 = p15; p15 = temp; }
			if (p14.CompareTo(p16) > 0) { temp = p14; p14 = p16; p16 = temp; }
			if (p14.CompareTo(p15) > 0) { temp = p14; p14 = p15; p15 = temp; }
			if (p19.CompareTo(p20) > 0) { temp = p19; p19 = p20; p20 = temp; }
			if (p18.CompareTo(p20) > 0) { temp = p18; p18 = p20; p20 = temp; }
			if (p18.CompareTo(p19) > 0) { temp = p18; p18 = p19; p19 = temp; }
			if (p22.CompareTo(p23) > 0) { temp = p22; p22 = p23; p23 = temp; }
			if (p21.CompareTo(p23) > 0) { temp = p21; p21 = p23; p23 = temp; }
			if (p21.CompareTo(p22) > 0) { temp = p21; p21 = p22; p22 = temp; }
			if (p18.CompareTo(p22) > 0) { temp = p18; p18 = p22; p22 = temp; }
			if (p18.CompareTo(p21) > 0) { temp = p18; p18 = p21; p21 = temp; }
			if (p19.CompareTo(p23) > 0) { temp = p19; p19 = p23; p23 = temp; }
			if (p20.CompareTo(p23) > 0) { temp = p20; p20 = p23; p23 = temp; }
			if (p19.CompareTo(p21) > 0) { temp = p19; p19 = p21; p21 = temp; }
			if (p20.CompareTo(p22) > 0) { temp = p20; p20 = p22; p22 = temp; }
			if (p20.CompareTo(p21) > 0) { temp = p20; p20 = p21; p21 = temp; }
			if (p12.CompareTo(p19) > 0) { temp = p12; p12 = p19; p19 = temp; }
			if (p12.CompareTo(p18) > 0) { temp = p12; p12 = p18; p18 = temp; }
			if (p13.CompareTo(p20) > 0) { temp = p13; p13 = p20; p20 = temp; }
			if (p14.CompareTo(p20) > 0) { temp = p14; p14 = p20; p20 = temp; }
			if (p13.CompareTo(p18) > 0) { temp = p13; p13 = p18; p18 = temp; }
			if (p14.CompareTo(p19) > 0) { temp = p14; p14 = p19; p19 = temp; }
			if (p14.CompareTo(p18) > 0) { temp = p14; p14 = p18; p18 = temp; }
			if (p15.CompareTo(p22) > 0) { temp = p15; p15 = p22; p22 = temp; }
			if (p15.CompareTo(p21) > 0) { temp = p15; p15 = p21; p21 = temp; }
			if (p16.CompareTo(p23) > 0) { temp = p16; p16 = p23; p23 = temp; }
			if (p17.CompareTo(p23) > 0) { temp = p17; p17 = p23; p23 = temp; }
			if (p16.CompareTo(p21) > 0) { temp = p16; p16 = p21; p21 = temp; }
			if (p17.CompareTo(p22) > 0) { temp = p17; p17 = p22; p22 = temp; }
			if (p17.CompareTo(p21) > 0) { temp = p17; p17 = p21; p21 = temp; }
			if (p15.CompareTo(p19) > 0) { temp = p15; p15 = p19; p19 = temp; }
			if (p15.CompareTo(p18) > 0) { temp = p15; p15 = p18; p18 = temp; }
			if (p16.CompareTo(p20) > 0) { temp = p16; p16 = p20; p20 = temp; }
			if (p17.CompareTo(p20) > 0) { temp = p17; p17 = p20; p20 = temp; }
			if (p16.CompareTo(p18) > 0) { temp = p16; p16 = p18; p18 = temp; }
			if (p17.CompareTo(p19) > 0) { temp = p17; p17 = p19; p19 = temp; }
			if (p17.CompareTo(p18) > 0) { temp = p17; p17 = p18; p18 = temp; }
			if (p0.CompareTo(p13) > 0) { temp = p0; p0 = p13; p13 = temp; }
			if (p0.CompareTo(p12) > 0) { temp = p0; p0 = p12; p12 = temp; }
			if (p1.CompareTo(p14) > 0) { temp = p1; p1 = p14; p14 = temp; }
			if (p2.CompareTo(p14) > 0) { temp = p2; p2 = p14; p14 = temp; }
			if (p1.CompareTo(p12) > 0) { temp = p1; p1 = p12; p12 = temp; }
			if (p2.CompareTo(p13) > 0) { temp = p2; p2 = p13; p13 = temp; }
			if (p2.CompareTo(p12) > 0) { temp = p2; p2 = p12; p12 = temp; }
			if (p3.CompareTo(p16) > 0) { temp = p3; p3 = p16; p16 = temp; }
			if (p3.CompareTo(p15) > 0) { temp = p3; p3 = p15; p15 = temp; }
			if (p4.CompareTo(p17) > 0) { temp = p4; p4 = p17; p17 = temp; }
			if (p5.CompareTo(p17) > 0) { temp = p5; p5 = p17; p17 = temp; }
			if (p4.CompareTo(p15) > 0) { temp = p4; p4 = p15; p15 = temp; }
			if (p5.CompareTo(p16) > 0) { temp = p5; p5 = p16; p16 = temp; }
			if (p5.CompareTo(p15) > 0) { temp = p5; p5 = p15; p15 = temp; }
			if (p3.CompareTo(p13) > 0) { temp = p3; p3 = p13; p13 = temp; }
			if (p3.CompareTo(p12) > 0) { temp = p3; p3 = p12; p12 = temp; }
			if (p4.CompareTo(p14) > 0) { temp = p4; p4 = p14; p14 = temp; }
			if (p5.CompareTo(p14) > 0) { temp = p5; p5 = p14; p14 = temp; }
			if (p4.CompareTo(p12) > 0) { temp = p4; p4 = p12; p12 = temp; }
			if (p5.CompareTo(p13) > 0) { temp = p5; p5 = p13; p13 = temp; }
			if (p5.CompareTo(p12) > 0) { temp = p5; p5 = p12; p12 = temp; }
			if (p6.CompareTo(p19) > 0) { temp = p6; p6 = p19; p19 = temp; }
			if (p6.CompareTo(p18) > 0) { temp = p6; p6 = p18; p18 = temp; }
			if (p7.CompareTo(p20) > 0) { temp = p7; p7 = p20; p20 = temp; }
			if (p8.CompareTo(p20) > 0) { temp = p8; p8 = p20; p20 = temp; }
			if (p7.CompareTo(p18) > 0) { temp = p7; p7 = p18; p18 = temp; }
			if (p8.CompareTo(p19) > 0) { temp = p8; p8 = p19; p19 = temp; }
			if (p8.CompareTo(p18) > 0) { temp = p8; p8 = p18; p18 = temp; }
			if (p9.CompareTo(p22) > 0) { temp = p9; p9 = p22; p22 = temp; }
			if (p9.CompareTo(p21) > 0) { temp = p9; p9 = p21; p21 = temp; }
			if (p10.CompareTo(p23) > 0) { temp = p10; p10 = p23; p23 = temp; }
			if (p11.CompareTo(p23) > 0) { temp = p11; p11 = p23; p23 = temp; }
			if (p10.CompareTo(p21) > 0) { temp = p10; p10 = p21; p21 = temp; }
			if (p11.CompareTo(p22) > 0) { temp = p11; p11 = p22; p22 = temp; }
			if (p11.CompareTo(p21) > 0) { temp = p11; p11 = p21; p21 = temp; }
			if (p9.CompareTo(p19) > 0) { temp = p9; p9 = p19; p19 = temp; }
			if (p9.CompareTo(p18) > 0) { temp = p9; p9 = p18; p18 = temp; }
			if (p10.CompareTo(p20) > 0) { temp = p10; p10 = p20; p20 = temp; }
			if (p11.CompareTo(p20) > 0) { temp = p11; p11 = p20; p20 = temp; }
			if (p10.CompareTo(p18) > 0) { temp = p10; p10 = p18; p18 = temp; }
			if (p11.CompareTo(p19) > 0) { temp = p11; p11 = p19; p19 = temp; }
			if (p11.CompareTo(p18) > 0) { temp = p11; p11 = p18; p18 = temp; }
			if (p6.CompareTo(p13) > 0) { temp = p6; p6 = p13; p13 = temp; }
			if (p6.CompareTo(p12) > 0) { temp = p6; p6 = p12; p12 = temp; }
			if (p7.CompareTo(p14) > 0) { temp = p7; p7 = p14; p14 = temp; }
			if (p8.CompareTo(p14) > 0) { temp = p8; p8 = p14; p14 = temp; }
			if (p7.CompareTo(p12) > 0) { temp = p7; p7 = p12; p12 = temp; }
			if (p8.CompareTo(p13) > 0) { temp = p8; p8 = p13; p13 = temp; }
			if (p8.CompareTo(p12) > 0) { temp = p8; p8 = p12; p12 = temp; }
			if (p9.CompareTo(p16) > 0) { temp = p9; p9 = p16; p16 = temp; }
			if (p9.CompareTo(p15) > 0) { temp = p9; p9 = p15; p15 = temp; }
			if (p10.CompareTo(p17) > 0) { temp = p10; p10 = p17; p17 = temp; }
			if (p11.CompareTo(p17) > 0) { temp = p11; p11 = p17; p17 = temp; }
			if (p10.CompareTo(p15) > 0) { temp = p10; p10 = p15; p15 = temp; }
			if (p11.CompareTo(p16) > 0) { temp = p11; p11 = p16; p16 = temp; }
			if (p11.CompareTo(p15) > 0) { temp = p11; p11 = p15; p15 = temp; }
			if (p9.CompareTo(p13) > 0) { temp = p9; p9 = p13; p13 = temp; }
			if (p9.CompareTo(p12) > 0) { temp = p9; p9 = p12; p12 = temp; }
			if (p10.CompareTo(p14) > 0) { temp = p10; p10 = p14; p14 = temp; }
			if (p11.CompareTo(p14) > 0) { temp = p11; p11 = p14; p14 = temp; }
			if (p10.CompareTo(p12) > 0) { temp = p10; p10 = p12; p12 = temp; }
			if (p11.CompareTo(p13) > 0) { temp = p11; p11 = p13; p13 = temp; }
			if (p11.CompareTo(p12) > 0) { temp = p11; p11 = p12; p12 = temp; }
#else
			if (GreaterThan(ref p1, ref p2)) { temp = p1; p1 = p2; p2 = temp; }
			if (GreaterThan(ref p0, ref p2)) { temp = p0; p0 = p2; p2 = temp; }
			if (GreaterThan(ref p0, ref p1)) { temp = p0; p0 = p1; p1 = temp; }
			if (GreaterThan(ref p4, ref p5)) { temp = p4; p4 = p5; p5 = temp; }
			if (GreaterThan(ref p3, ref p5)) { temp = p3; p3 = p5; p5 = temp; }
			if (GreaterThan(ref p3, ref p4)) { temp = p3; p3 = p4; p4 = temp; }
			if (GreaterThan(ref p0, ref p4)) { temp = p0; p0 = p4; p4 = temp; }
			if (GreaterThan(ref p0, ref p3)) { temp = p0; p0 = p3; p3 = temp; }
			if (GreaterThan(ref p1, ref p5)) { temp = p1; p1 = p5; p5 = temp; }
			if (GreaterThan(ref p2, ref p5)) { temp = p2; p2 = p5; p5 = temp; }
			if (GreaterThan(ref p1, ref p3)) { temp = p1; p1 = p3; p3 = temp; }
			if (GreaterThan(ref p2, ref p4)) { temp = p2; p2 = p4; p4 = temp; }
			if (GreaterThan(ref p2, ref p3)) { temp = p2; p2 = p3; p3 = temp; }
			if (GreaterThan(ref p7, ref p8)) { temp = p7; p7 = p8; p8 = temp; }
			if (GreaterThan(ref p6, ref p8)) { temp = p6; p6 = p8; p8 = temp; }
			if (GreaterThan(ref p6, ref p7)) { temp = p6; p6 = p7; p7 = temp; }
			if (GreaterThan(ref p10, ref p11)) { temp = p10; p10 = p11; p11 = temp; }
			if (GreaterThan(ref p9, ref p11)) { temp = p9; p9 = p11; p11 = temp; }
			if (GreaterThan(ref p9, ref p10)) { temp = p9; p9 = p10; p10 = temp; }
			if (GreaterThan(ref p6, ref p10)) { temp = p6; p6 = p10; p10 = temp; }
			if (GreaterThan(ref p6, ref p9)) { temp = p6; p6 = p9; p9 = temp; }
			if (GreaterThan(ref p7, ref p11)) { temp = p7; p7 = p11; p11 = temp; }
			if (GreaterThan(ref p8, ref p11)) { temp = p8; p8 = p11; p11 = temp; }
			if (GreaterThan(ref p7, ref p9)) { temp = p7; p7 = p9; p9 = temp; }
			if (GreaterThan(ref p8, ref p10)) { temp = p8; p8 = p10; p10 = temp; }
			if (GreaterThan(ref p8, ref p9)) { temp = p8; p8 = p9; p9 = temp; }
			if (GreaterThan(ref p0, ref p7)) { temp = p0; p0 = p7; p7 = temp; }
			if (GreaterThan(ref p0, ref p6)) { temp = p0; p0 = p6; p6 = temp; }
			if (GreaterThan(ref p1, ref p8)) { temp = p1; p1 = p8; p8 = temp; }
			if (GreaterThan(ref p2, ref p8)) { temp = p2; p2 = p8; p8 = temp; }
			if (GreaterThan(ref p1, ref p6)) { temp = p1; p1 = p6; p6 = temp; }
			if (GreaterThan(ref p2, ref p7)) { temp = p2; p2 = p7; p7 = temp; }
			if (GreaterThan(ref p2, ref p6)) { temp = p2; p2 = p6; p6 = temp; }
			if (GreaterThan(ref p3, ref p10)) { temp = p3; p3 = p10; p10 = temp; }
			if (GreaterThan(ref p3, ref p9)) { temp = p3; p3 = p9; p9 = temp; }
			if (GreaterThan(ref p4, ref p11)) { temp = p4; p4 = p11; p11 = temp; }
			if (GreaterThan(ref p5, ref p11)) { temp = p5; p5 = p11; p11 = temp; }
			if (GreaterThan(ref p4, ref p9)) { temp = p4; p4 = p9; p9 = temp; }
			if (GreaterThan(ref p5, ref p10)) { temp = p5; p5 = p10; p10 = temp; }
			if (GreaterThan(ref p5, ref p9)) { temp = p5; p5 = p9; p9 = temp; }
			if (GreaterThan(ref p3, ref p7)) { temp = p3; p3 = p7; p7 = temp; }
			if (GreaterThan(ref p3, ref p6)) { temp = p3; p3 = p6; p6 = temp; }
			if (GreaterThan(ref p4, ref p8)) { temp = p4; p4 = p8; p8 = temp; }
			if (GreaterThan(ref p5, ref p8)) { temp = p5; p5 = p8; p8 = temp; }
			if (GreaterThan(ref p4, ref p6)) { temp = p4; p4 = p6; p6 = temp; }
			if (GreaterThan(ref p5, ref p7)) { temp = p5; p5 = p7; p7 = temp; }
			if (GreaterThan(ref p5, ref p6)) { temp = p5; p5 = p6; p6 = temp; }
			if (GreaterThan(ref p13, ref p14)) { temp = p13; p13 = p14; p14 = temp; }
			if (GreaterThan(ref p12, ref p14)) { temp = p12; p12 = p14; p14 = temp; }
			if (GreaterThan(ref p12, ref p13)) { temp = p12; p12 = p13; p13 = temp; }
			if (GreaterThan(ref p16, ref p17)) { temp = p16; p16 = p17; p17 = temp; }
			if (GreaterThan(ref p15, ref p17)) { temp = p15; p15 = p17; p17 = temp; }
			if (GreaterThan(ref p15, ref p16)) { temp = p15; p15 = p16; p16 = temp; }
			if (GreaterThan(ref p12, ref p16)) { temp = p12; p12 = p16; p16 = temp; }
			if (GreaterThan(ref p12, ref p15)) { temp = p12; p12 = p15; p15 = temp; }
			if (GreaterThan(ref p13, ref p17)) { temp = p13; p13 = p17; p17 = temp; }
			if (GreaterThan(ref p14, ref p17)) { temp = p14; p14 = p17; p17 = temp; }
			if (GreaterThan(ref p13, ref p15)) { temp = p13; p13 = p15; p15 = temp; }
			if (GreaterThan(ref p14, ref p16)) { temp = p14; p14 = p16; p16 = temp; }
			if (GreaterThan(ref p14, ref p15)) { temp = p14; p14 = p15; p15 = temp; }
			if (GreaterThan(ref p19, ref p20)) { temp = p19; p19 = p20; p20 = temp; }
			if (GreaterThan(ref p18, ref p20)) { temp = p18; p18 = p20; p20 = temp; }
			if (GreaterThan(ref p18, ref p19)) { temp = p18; p18 = p19; p19 = temp; }
			if (GreaterThan(ref p22, ref p23)) { temp = p22; p22 = p23; p23 = temp; }
			if (GreaterThan(ref p21, ref p23)) { temp = p21; p21 = p23; p23 = temp; }
			if (GreaterThan(ref p21, ref p22)) { temp = p21; p21 = p22; p22 = temp; }
			if (GreaterThan(ref p18, ref p22)) { temp = p18; p18 = p22; p22 = temp; }
			if (GreaterThan(ref p18, ref p21)) { temp = p18; p18 = p21; p21 = temp; }
			if (GreaterThan(ref p19, ref p23)) { temp = p19; p19 = p23; p23 = temp; }
			if (GreaterThan(ref p20, ref p23)) { temp = p20; p20 = p23; p23 = temp; }
			if (GreaterThan(ref p19, ref p21)) { temp = p19; p19 = p21; p21 = temp; }
			if (GreaterThan(ref p20, ref p22)) { temp = p20; p20 = p22; p22 = temp; }
			if (GreaterThan(ref p20, ref p21)) { temp = p20; p20 = p21; p21 = temp; }
			if (GreaterThan(ref p12, ref p19)) { temp = p12; p12 = p19; p19 = temp; }
			if (GreaterThan(ref p12, ref p18)) { temp = p12; p12 = p18; p18 = temp; }
			if (GreaterThan(ref p13, ref p20)) { temp = p13; p13 = p20; p20 = temp; }
			if (GreaterThan(ref p14, ref p20)) { temp = p14; p14 = p20; p20 = temp; }
			if (GreaterThan(ref p13, ref p18)) { temp = p13; p13 = p18; p18 = temp; }
			if (GreaterThan(ref p14, ref p19)) { temp = p14; p14 = p19; p19 = temp; }
			if (GreaterThan(ref p14, ref p18)) { temp = p14; p14 = p18; p18 = temp; }
			if (GreaterThan(ref p15, ref p22)) { temp = p15; p15 = p22; p22 = temp; }
			if (GreaterThan(ref p15, ref p21)) { temp = p15; p15 = p21; p21 = temp; }
			if (GreaterThan(ref p16, ref p23)) { temp = p16; p16 = p23; p23 = temp; }
			if (GreaterThan(ref p17, ref p23)) { temp = p17; p17 = p23; p23 = temp; }
			if (GreaterThan(ref p16, ref p21)) { temp = p16; p16 = p21; p21 = temp; }
			if (GreaterThan(ref p17, ref p22)) { temp = p17; p17 = p22; p22 = temp; }
			if (GreaterThan(ref p17, ref p21)) { temp = p17; p17 = p21; p21 = temp; }
			if (GreaterThan(ref p15, ref p19)) { temp = p15; p15 = p19; p19 = temp; }
			if (GreaterThan(ref p15, ref p18)) { temp = p15; p15 = p18; p18 = temp; }
			if (GreaterThan(ref p16, ref p20)) { temp = p16; p16 = p20; p20 = temp; }
			if (GreaterThan(ref p17, ref p20)) { temp = p17; p17 = p20; p20 = temp; }
			if (GreaterThan(ref p16, ref p18)) { temp = p16; p16 = p18; p18 = temp; }
			if (GreaterThan(ref p17, ref p19)) { temp = p17; p17 = p19; p19 = temp; }
			if (GreaterThan(ref p17, ref p18)) { temp = p17; p17 = p18; p18 = temp; }
			if (GreaterThan(ref p0, ref p13)) { temp = p0; p0 = p13; p13 = temp; }
			if (GreaterThan(ref p0, ref p12)) { temp = p0; p0 = p12; p12 = temp; }
			if (GreaterThan(ref p1, ref p14)) { temp = p1; p1 = p14; p14 = temp; }
			if (GreaterThan(ref p2, ref p14)) { temp = p2; p2 = p14; p14 = temp; }
			if (GreaterThan(ref p1, ref p12)) { temp = p1; p1 = p12; p12 = temp; }
			if (GreaterThan(ref p2, ref p13)) { temp = p2; p2 = p13; p13 = temp; }
			if (GreaterThan(ref p2, ref p12)) { temp = p2; p2 = p12; p12 = temp; }
			if (GreaterThan(ref p3, ref p16)) { temp = p3; p3 = p16; p16 = temp; }
			if (GreaterThan(ref p3, ref p15)) { temp = p3; p3 = p15; p15 = temp; }
			if (GreaterThan(ref p4, ref p17)) { temp = p4; p4 = p17; p17 = temp; }
			if (GreaterThan(ref p5, ref p17)) { temp = p5; p5 = p17; p17 = temp; }
			if (GreaterThan(ref p4, ref p15)) { temp = p4; p4 = p15; p15 = temp; }
			if (GreaterThan(ref p5, ref p16)) { temp = p5; p5 = p16; p16 = temp; }
			if (GreaterThan(ref p5, ref p15)) { temp = p5; p5 = p15; p15 = temp; }
			if (GreaterThan(ref p3, ref p13)) { temp = p3; p3 = p13; p13 = temp; }
			if (GreaterThan(ref p3, ref p12)) { temp = p3; p3 = p12; p12 = temp; }
			if (GreaterThan(ref p4, ref p14)) { temp = p4; p4 = p14; p14 = temp; }
			if (GreaterThan(ref p5, ref p14)) { temp = p5; p5 = p14; p14 = temp; }
			if (GreaterThan(ref p4, ref p12)) { temp = p4; p4 = p12; p12 = temp; }
			if (GreaterThan(ref p5, ref p13)) { temp = p5; p5 = p13; p13 = temp; }
			if (GreaterThan(ref p5, ref p12)) { temp = p5; p5 = p12; p12 = temp; }
			if (GreaterThan(ref p6, ref p19)) { temp = p6; p6 = p19; p19 = temp; }
			if (GreaterThan(ref p6, ref p18)) { temp = p6; p6 = p18; p18 = temp; }
			if (GreaterThan(ref p7, ref p20)) { temp = p7; p7 = p20; p20 = temp; }
			if (GreaterThan(ref p8, ref p20)) { temp = p8; p8 = p20; p20 = temp; }
			if (GreaterThan(ref p7, ref p18)) { temp = p7; p7 = p18; p18 = temp; }
			if (GreaterThan(ref p8, ref p19)) { temp = p8; p8 = p19; p19 = temp; }
			if (GreaterThan(ref p8, ref p18)) { temp = p8; p8 = p18; p18 = temp; }
			if (GreaterThan(ref p9, ref p22)) { temp = p9; p9 = p22; p22 = temp; }
			if (GreaterThan(ref p9, ref p21)) { temp = p9; p9 = p21; p21 = temp; }
			if (GreaterThan(ref p10, ref p23)) { temp = p10; p10 = p23; p23 = temp; }
			if (GreaterThan(ref p11, ref p23)) { temp = p11; p11 = p23; p23 = temp; }
			if (GreaterThan(ref p10, ref p21)) { temp = p10; p10 = p21; p21 = temp; }
			if (GreaterThan(ref p11, ref p22)) { temp = p11; p11 = p22; p22 = temp; }
			if (GreaterThan(ref p11, ref p21)) { temp = p11; p11 = p21; p21 = temp; }
			if (GreaterThan(ref p9, ref p19)) { temp = p9; p9 = p19; p19 = temp; }
			if (GreaterThan(ref p9, ref p18)) { temp = p9; p9 = p18; p18 = temp; }
			if (GreaterThan(ref p10, ref p20)) { temp = p10; p10 = p20; p20 = temp; }
			if (GreaterThan(ref p11, ref p20)) { temp = p11; p11 = p20; p20 = temp; }
			if (GreaterThan(ref p10, ref p18)) { temp = p10; p10 = p18; p18 = temp; }
			if (GreaterThan(ref p11, ref p19)) { temp = p11; p11 = p19; p19 = temp; }
			if (GreaterThan(ref p11, ref p18)) { temp = p11; p11 = p18; p18 = temp; }
			if (GreaterThan(ref p6, ref p13)) { temp = p6; p6 = p13; p13 = temp; }
			if (GreaterThan(ref p6, ref p12)) { temp = p6; p6 = p12; p12 = temp; }
			if (GreaterThan(ref p7, ref p14)) { temp = p7; p7 = p14; p14 = temp; }
			if (GreaterThan(ref p8, ref p14)) { temp = p8; p8 = p14; p14 = temp; }
			if (GreaterThan(ref p7, ref p12)) { temp = p7; p7 = p12; p12 = temp; }
			if (GreaterThan(ref p8, ref p13)) { temp = p8; p8 = p13; p13 = temp; }
			if (GreaterThan(ref p8, ref p12)) { temp = p8; p8 = p12; p12 = temp; }
			if (GreaterThan(ref p9, ref p16)) { temp = p9; p9 = p16; p16 = temp; }
			if (GreaterThan(ref p9, ref p15)) { temp = p9; p9 = p15; p15 = temp; }
			if (GreaterThan(ref p10, ref p17)) { temp = p10; p10 = p17; p17 = temp; }
			if (GreaterThan(ref p11, ref p17)) { temp = p11; p11 = p17; p17 = temp; }
			if (GreaterThan(ref p10, ref p15)) { temp = p10; p10 = p15; p15 = temp; }
			if (GreaterThan(ref p11, ref p16)) { temp = p11; p11 = p16; p16 = temp; }
			if (GreaterThan(ref p11, ref p15)) { temp = p11; p11 = p15; p15 = temp; }
			if (GreaterThan(ref p9, ref p13)) { temp = p9; p9 = p13; p13 = temp; }
			if (GreaterThan(ref p9, ref p12)) { temp = p9; p9 = p12; p12 = temp; }
			if (GreaterThan(ref p10, ref p14)) { temp = p10; p10 = p14; p14 = temp; }
			if (GreaterThan(ref p11, ref p14)) { temp = p11; p11 = p14; p14 = temp; }
			if (GreaterThan(ref p10, ref p12)) { temp = p10; p10 = p12; p12 = temp; }
			if (GreaterThan(ref p11, ref p13)) { temp = p11; p11 = p13; p13 = temp; }
			if (GreaterThan(ref p11, ref p12)) { temp = p11; p11 = p12; p12 = temp; }
#endif
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
#if NETSTANDARD1_3
			if (p1.CompareTo(p2) > 0) { temp = p1; p1 = p2; p2 = temp; }
			if (p0.CompareTo(p2) > 0) { temp = p0; p0 = p2; p2 = temp; }
			if (p0.CompareTo(p1) > 0) { temp = p0; p0 = p1; p1 = temp; }
			if (p4.CompareTo(p5) > 0) { temp = p4; p4 = p5; p5 = temp; }
			if (p3.CompareTo(p5) > 0) { temp = p3; p3 = p5; p5 = temp; }
			if (p3.CompareTo(p4) > 0) { temp = p3; p3 = p4; p4 = temp; }
			if (p0.CompareTo(p4) > 0) { temp = p0; p0 = p4; p4 = temp; }
			if (p0.CompareTo(p3) > 0) { temp = p0; p0 = p3; p3 = temp; }
			if (p1.CompareTo(p5) > 0) { temp = p1; p1 = p5; p5 = temp; }
			if (p2.CompareTo(p5) > 0) { temp = p2; p2 = p5; p5 = temp; }
			if (p1.CompareTo(p3) > 0) { temp = p1; p1 = p3; p3 = temp; }
			if (p2.CompareTo(p4) > 0) { temp = p2; p2 = p4; p4 = temp; }
			if (p2.CompareTo(p3) > 0) { temp = p2; p2 = p3; p3 = temp; }
			if (p7.CompareTo(p8) > 0) { temp = p7; p7 = p8; p8 = temp; }
			if (p6.CompareTo(p8) > 0) { temp = p6; p6 = p8; p8 = temp; }
			if (p6.CompareTo(p7) > 0) { temp = p6; p6 = p7; p7 = temp; }
			if (p10.CompareTo(p11) > 0) { temp = p10; p10 = p11; p11 = temp; }
			if (p9.CompareTo(p11) > 0) { temp = p9; p9 = p11; p11 = temp; }
			if (p9.CompareTo(p10) > 0) { temp = p9; p9 = p10; p10 = temp; }
			if (p6.CompareTo(p10) > 0) { temp = p6; p6 = p10; p10 = temp; }
			if (p6.CompareTo(p9) > 0) { temp = p6; p6 = p9; p9 = temp; }
			if (p7.CompareTo(p11) > 0) { temp = p7; p7 = p11; p11 = temp; }
			if (p8.CompareTo(p11) > 0) { temp = p8; p8 = p11; p11 = temp; }
			if (p7.CompareTo(p9) > 0) { temp = p7; p7 = p9; p9 = temp; }
			if (p8.CompareTo(p10) > 0) { temp = p8; p8 = p10; p10 = temp; }
			if (p8.CompareTo(p9) > 0) { temp = p8; p8 = p9; p9 = temp; }
			if (p0.CompareTo(p7) > 0) { temp = p0; p0 = p7; p7 = temp; }
			if (p0.CompareTo(p6) > 0) { temp = p0; p0 = p6; p6 = temp; }
			if (p1.CompareTo(p8) > 0) { temp = p1; p1 = p8; p8 = temp; }
			if (p2.CompareTo(p8) > 0) { temp = p2; p2 = p8; p8 = temp; }
			if (p1.CompareTo(p6) > 0) { temp = p1; p1 = p6; p6 = temp; }
			if (p2.CompareTo(p7) > 0) { temp = p2; p2 = p7; p7 = temp; }
			if (p2.CompareTo(p6) > 0) { temp = p2; p2 = p6; p6 = temp; }
			if (p3.CompareTo(p10) > 0) { temp = p3; p3 = p10; p10 = temp; }
			if (p3.CompareTo(p9) > 0) { temp = p3; p3 = p9; p9 = temp; }
			if (p4.CompareTo(p11) > 0) { temp = p4; p4 = p11; p11 = temp; }
			if (p5.CompareTo(p11) > 0) { temp = p5; p5 = p11; p11 = temp; }
			if (p4.CompareTo(p9) > 0) { temp = p4; p4 = p9; p9 = temp; }
			if (p5.CompareTo(p10) > 0) { temp = p5; p5 = p10; p10 = temp; }
			if (p5.CompareTo(p9) > 0) { temp = p5; p5 = p9; p9 = temp; }
			if (p3.CompareTo(p7) > 0) { temp = p3; p3 = p7; p7 = temp; }
			if (p3.CompareTo(p6) > 0) { temp = p3; p3 = p6; p6 = temp; }
			if (p4.CompareTo(p8) > 0) { temp = p4; p4 = p8; p8 = temp; }
			if (p5.CompareTo(p8) > 0) { temp = p5; p5 = p8; p8 = temp; }
			if (p4.CompareTo(p6) > 0) { temp = p4; p4 = p6; p6 = temp; }
			if (p5.CompareTo(p7) > 0) { temp = p5; p5 = p7; p7 = temp; }
			if (p5.CompareTo(p6) > 0) { temp = p5; p5 = p6; p6 = temp; }
			if (p13.CompareTo(p14) > 0) { temp = p13; p13 = p14; p14 = temp; }
			if (p12.CompareTo(p14) > 0) { temp = p12; p12 = p14; p14 = temp; }
			if (p12.CompareTo(p13) > 0) { temp = p12; p12 = p13; p13 = temp; }
			if (p16.CompareTo(p17) > 0) { temp = p16; p16 = p17; p17 = temp; }
			if (p15.CompareTo(p17) > 0) { temp = p15; p15 = p17; p17 = temp; }
			if (p15.CompareTo(p16) > 0) { temp = p15; p15 = p16; p16 = temp; }
			if (p12.CompareTo(p16) > 0) { temp = p12; p12 = p16; p16 = temp; }
			if (p12.CompareTo(p15) > 0) { temp = p12; p12 = p15; p15 = temp; }
			if (p13.CompareTo(p17) > 0) { temp = p13; p13 = p17; p17 = temp; }
			if (p14.CompareTo(p17) > 0) { temp = p14; p14 = p17; p17 = temp; }
			if (p13.CompareTo(p15) > 0) { temp = p13; p13 = p15; p15 = temp; }
			if (p14.CompareTo(p16) > 0) { temp = p14; p14 = p16; p16 = temp; }
			if (p14.CompareTo(p15) > 0) { temp = p14; p14 = p15; p15 = temp; }
			if (p19.CompareTo(p20) > 0) { temp = p19; p19 = p20; p20 = temp; }
			if (p18.CompareTo(p20) > 0) { temp = p18; p18 = p20; p20 = temp; }
			if (p18.CompareTo(p19) > 0) { temp = p18; p18 = p19; p19 = temp; }
			if (p21.CompareTo(p22) > 0) { temp = p21; p21 = p22; p22 = temp; }
			if (p23.CompareTo(p24) > 0) { temp = p23; p23 = p24; p24 = temp; }
			if (p21.CompareTo(p23) > 0) { temp = p21; p21 = p23; p23 = temp; }
			if (p22.CompareTo(p24) > 0) { temp = p22; p22 = p24; p24 = temp; }
			if (p22.CompareTo(p23) > 0) { temp = p22; p22 = p23; p23 = temp; }
			if (p18.CompareTo(p22) > 0) { temp = p18; p18 = p22; p22 = temp; }
			if (p18.CompareTo(p21) > 0) { temp = p18; p18 = p21; p21 = temp; }
			if (p19.CompareTo(p23) > 0) { temp = p19; p19 = p23; p23 = temp; }
			if (p20.CompareTo(p24) > 0) { temp = p20; p20 = p24; p24 = temp; }
			if (p20.CompareTo(p23) > 0) { temp = p20; p20 = p23; p23 = temp; }
			if (p19.CompareTo(p21) > 0) { temp = p19; p19 = p21; p21 = temp; }
			if (p20.CompareTo(p22) > 0) { temp = p20; p20 = p22; p22 = temp; }
			if (p20.CompareTo(p21) > 0) { temp = p20; p20 = p21; p21 = temp; }
			if (p12.CompareTo(p19) > 0) { temp = p12; p12 = p19; p19 = temp; }
			if (p12.CompareTo(p18) > 0) { temp = p12; p12 = p18; p18 = temp; }
			if (p13.CompareTo(p20) > 0) { temp = p13; p13 = p20; p20 = temp; }
			if (p14.CompareTo(p21) > 0) { temp = p14; p14 = p21; p21 = temp; }
			if (p14.CompareTo(p20) > 0) { temp = p14; p14 = p20; p20 = temp; }
			if (p13.CompareTo(p18) > 0) { temp = p13; p13 = p18; p18 = temp; }
			if (p14.CompareTo(p19) > 0) { temp = p14; p14 = p19; p19 = temp; }
			if (p14.CompareTo(p18) > 0) { temp = p14; p14 = p18; p18 = temp; }
			if (p15.CompareTo(p23) > 0) { temp = p15; p15 = p23; p23 = temp; }
			if (p15.CompareTo(p22) > 0) { temp = p15; p15 = p22; p22 = temp; }
			if (p16.CompareTo(p24) > 0) { temp = p16; p16 = p24; p24 = temp; }
			if (p17.CompareTo(p24) > 0) { temp = p17; p17 = p24; p24 = temp; }
			if (p16.CompareTo(p22) > 0) { temp = p16; p16 = p22; p22 = temp; }
			if (p17.CompareTo(p23) > 0) { temp = p17; p17 = p23; p23 = temp; }
			if (p17.CompareTo(p22) > 0) { temp = p17; p17 = p22; p22 = temp; }
			if (p15.CompareTo(p19) > 0) { temp = p15; p15 = p19; p19 = temp; }
			if (p15.CompareTo(p18) > 0) { temp = p15; p15 = p18; p18 = temp; }
			if (p16.CompareTo(p20) > 0) { temp = p16; p16 = p20; p20 = temp; }
			if (p17.CompareTo(p21) > 0) { temp = p17; p17 = p21; p21 = temp; }
			if (p17.CompareTo(p20) > 0) { temp = p17; p17 = p20; p20 = temp; }
			if (p16.CompareTo(p18) > 0) { temp = p16; p16 = p18; p18 = temp; }
			if (p17.CompareTo(p19) > 0) { temp = p17; p17 = p19; p19 = temp; }
			if (p17.CompareTo(p18) > 0) { temp = p17; p17 = p18; p18 = temp; }
			if (p0.CompareTo(p13) > 0) { temp = p0; p0 = p13; p13 = temp; }
			if (p0.CompareTo(p12) > 0) { temp = p0; p0 = p12; p12 = temp; }
			if (p1.CompareTo(p14) > 0) { temp = p1; p1 = p14; p14 = temp; }
			if (p2.CompareTo(p15) > 0) { temp = p2; p2 = p15; p15 = temp; }
			if (p2.CompareTo(p14) > 0) { temp = p2; p2 = p14; p14 = temp; }
			if (p1.CompareTo(p12) > 0) { temp = p1; p1 = p12; p12 = temp; }
			if (p2.CompareTo(p13) > 0) { temp = p2; p2 = p13; p13 = temp; }
			if (p2.CompareTo(p12) > 0) { temp = p2; p2 = p12; p12 = temp; }
			if (p3.CompareTo(p17) > 0) { temp = p3; p3 = p17; p17 = temp; }
			if (p3.CompareTo(p16) > 0) { temp = p3; p3 = p16; p16 = temp; }
			if (p4.CompareTo(p18) > 0) { temp = p4; p4 = p18; p18 = temp; }
			if (p5.CompareTo(p18) > 0) { temp = p5; p5 = p18; p18 = temp; }
			if (p4.CompareTo(p16) > 0) { temp = p4; p4 = p16; p16 = temp; }
			if (p5.CompareTo(p17) > 0) { temp = p5; p5 = p17; p17 = temp; }
			if (p5.CompareTo(p16) > 0) { temp = p5; p5 = p16; p16 = temp; }
			if (p3.CompareTo(p13) > 0) { temp = p3; p3 = p13; p13 = temp; }
			if (p3.CompareTo(p12) > 0) { temp = p3; p3 = p12; p12 = temp; }
			if (p4.CompareTo(p14) > 0) { temp = p4; p4 = p14; p14 = temp; }
			if (p5.CompareTo(p15) > 0) { temp = p5; p5 = p15; p15 = temp; }
			if (p5.CompareTo(p14) > 0) { temp = p5; p5 = p14; p14 = temp; }
			if (p4.CompareTo(p12) > 0) { temp = p4; p4 = p12; p12 = temp; }
			if (p5.CompareTo(p13) > 0) { temp = p5; p5 = p13; p13 = temp; }
			if (p5.CompareTo(p12) > 0) { temp = p5; p5 = p12; p12 = temp; }
			if (p6.CompareTo(p20) > 0) { temp = p6; p6 = p20; p20 = temp; }
			if (p6.CompareTo(p19) > 0) { temp = p6; p6 = p19; p19 = temp; }
			if (p7.CompareTo(p21) > 0) { temp = p7; p7 = p21; p21 = temp; }
			if (p8.CompareTo(p21) > 0) { temp = p8; p8 = p21; p21 = temp; }
			if (p7.CompareTo(p19) > 0) { temp = p7; p7 = p19; p19 = temp; }
			if (p8.CompareTo(p20) > 0) { temp = p8; p8 = p20; p20 = temp; }
			if (p8.CompareTo(p19) > 0) { temp = p8; p8 = p19; p19 = temp; }
			if (p9.CompareTo(p23) > 0) { temp = p9; p9 = p23; p23 = temp; }
			if (p9.CompareTo(p22) > 0) { temp = p9; p9 = p22; p22 = temp; }
			if (p10.CompareTo(p24) > 0) { temp = p10; p10 = p24; p24 = temp; }
			if (p11.CompareTo(p24) > 0) { temp = p11; p11 = p24; p24 = temp; }
			if (p10.CompareTo(p22) > 0) { temp = p10; p10 = p22; p22 = temp; }
			if (p11.CompareTo(p23) > 0) { temp = p11; p11 = p23; p23 = temp; }
			if (p11.CompareTo(p22) > 0) { temp = p11; p11 = p22; p22 = temp; }
			if (p9.CompareTo(p20) > 0) { temp = p9; p9 = p20; p20 = temp; }
			if (p9.CompareTo(p19) > 0) { temp = p9; p9 = p19; p19 = temp; }
			if (p10.CompareTo(p21) > 0) { temp = p10; p10 = p21; p21 = temp; }
			if (p11.CompareTo(p21) > 0) { temp = p11; p11 = p21; p21 = temp; }
			if (p10.CompareTo(p19) > 0) { temp = p10; p10 = p19; p19 = temp; }
			if (p11.CompareTo(p20) > 0) { temp = p11; p11 = p20; p20 = temp; }
			if (p11.CompareTo(p19) > 0) { temp = p11; p11 = p19; p19 = temp; }
			if (p6.CompareTo(p13) > 0) { temp = p6; p6 = p13; p13 = temp; }
			if (p6.CompareTo(p12) > 0) { temp = p6; p6 = p12; p12 = temp; }
			if (p7.CompareTo(p14) > 0) { temp = p7; p7 = p14; p14 = temp; }
			if (p8.CompareTo(p15) > 0) { temp = p8; p8 = p15; p15 = temp; }
			if (p8.CompareTo(p14) > 0) { temp = p8; p8 = p14; p14 = temp; }
			if (p7.CompareTo(p12) > 0) { temp = p7; p7 = p12; p12 = temp; }
			if (p8.CompareTo(p13) > 0) { temp = p8; p8 = p13; p13 = temp; }
			if (p8.CompareTo(p12) > 0) { temp = p8; p8 = p12; p12 = temp; }
			if (p9.CompareTo(p17) > 0) { temp = p9; p9 = p17; p17 = temp; }
			if (p9.CompareTo(p16) > 0) { temp = p9; p9 = p16; p16 = temp; }
			if (p10.CompareTo(p18) > 0) { temp = p10; p10 = p18; p18 = temp; }
			if (p11.CompareTo(p18) > 0) { temp = p11; p11 = p18; p18 = temp; }
			if (p10.CompareTo(p16) > 0) { temp = p10; p10 = p16; p16 = temp; }
			if (p11.CompareTo(p17) > 0) { temp = p11; p11 = p17; p17 = temp; }
			if (p11.CompareTo(p16) > 0) { temp = p11; p11 = p16; p16 = temp; }
			if (p9.CompareTo(p13) > 0) { temp = p9; p9 = p13; p13 = temp; }
			if (p9.CompareTo(p12) > 0) { temp = p9; p9 = p12; p12 = temp; }
			if (p10.CompareTo(p14) > 0) { temp = p10; p10 = p14; p14 = temp; }
			if (p11.CompareTo(p15) > 0) { temp = p11; p11 = p15; p15 = temp; }
			if (p11.CompareTo(p14) > 0) { temp = p11; p11 = p14; p14 = temp; }
			if (p10.CompareTo(p12) > 0) { temp = p10; p10 = p12; p12 = temp; }
			if (p11.CompareTo(p13) > 0) { temp = p11; p11 = p13; p13 = temp; }
			if (p11.CompareTo(p12) > 0) { temp = p11; p11 = p12; p12 = temp; }
#else
			if (GreaterThan(ref p1, ref p2)) { temp = p1; p1 = p2; p2 = temp; }
			if (GreaterThan(ref p0, ref p2)) { temp = p0; p0 = p2; p2 = temp; }
			if (GreaterThan(ref p0, ref p1)) { temp = p0; p0 = p1; p1 = temp; }
			if (GreaterThan(ref p4, ref p5)) { temp = p4; p4 = p5; p5 = temp; }
			if (GreaterThan(ref p3, ref p5)) { temp = p3; p3 = p5; p5 = temp; }
			if (GreaterThan(ref p3, ref p4)) { temp = p3; p3 = p4; p4 = temp; }
			if (GreaterThan(ref p0, ref p4)) { temp = p0; p0 = p4; p4 = temp; }
			if (GreaterThan(ref p0, ref p3)) { temp = p0; p0 = p3; p3 = temp; }
			if (GreaterThan(ref p1, ref p5)) { temp = p1; p1 = p5; p5 = temp; }
			if (GreaterThan(ref p2, ref p5)) { temp = p2; p2 = p5; p5 = temp; }
			if (GreaterThan(ref p1, ref p3)) { temp = p1; p1 = p3; p3 = temp; }
			if (GreaterThan(ref p2, ref p4)) { temp = p2; p2 = p4; p4 = temp; }
			if (GreaterThan(ref p2, ref p3)) { temp = p2; p2 = p3; p3 = temp; }
			if (GreaterThan(ref p7, ref p8)) { temp = p7; p7 = p8; p8 = temp; }
			if (GreaterThan(ref p6, ref p8)) { temp = p6; p6 = p8; p8 = temp; }
			if (GreaterThan(ref p6, ref p7)) { temp = p6; p6 = p7; p7 = temp; }
			if (GreaterThan(ref p10, ref p11)) { temp = p10; p10 = p11; p11 = temp; }
			if (GreaterThan(ref p9, ref p11)) { temp = p9; p9 = p11; p11 = temp; }
			if (GreaterThan(ref p9, ref p10)) { temp = p9; p9 = p10; p10 = temp; }
			if (GreaterThan(ref p6, ref p10)) { temp = p6; p6 = p10; p10 = temp; }
			if (GreaterThan(ref p6, ref p9)) { temp = p6; p6 = p9; p9 = temp; }
			if (GreaterThan(ref p7, ref p11)) { temp = p7; p7 = p11; p11 = temp; }
			if (GreaterThan(ref p8, ref p11)) { temp = p8; p8 = p11; p11 = temp; }
			if (GreaterThan(ref p7, ref p9)) { temp = p7; p7 = p9; p9 = temp; }
			if (GreaterThan(ref p8, ref p10)) { temp = p8; p8 = p10; p10 = temp; }
			if (GreaterThan(ref p8, ref p9)) { temp = p8; p8 = p9; p9 = temp; }
			if (GreaterThan(ref p0, ref p7)) { temp = p0; p0 = p7; p7 = temp; }
			if (GreaterThan(ref p0, ref p6)) { temp = p0; p0 = p6; p6 = temp; }
			if (GreaterThan(ref p1, ref p8)) { temp = p1; p1 = p8; p8 = temp; }
			if (GreaterThan(ref p2, ref p8)) { temp = p2; p2 = p8; p8 = temp; }
			if (GreaterThan(ref p1, ref p6)) { temp = p1; p1 = p6; p6 = temp; }
			if (GreaterThan(ref p2, ref p7)) { temp = p2; p2 = p7; p7 = temp; }
			if (GreaterThan(ref p2, ref p6)) { temp = p2; p2 = p6; p6 = temp; }
			if (GreaterThan(ref p3, ref p10)) { temp = p3; p3 = p10; p10 = temp; }
			if (GreaterThan(ref p3, ref p9)) { temp = p3; p3 = p9; p9 = temp; }
			if (GreaterThan(ref p4, ref p11)) { temp = p4; p4 = p11; p11 = temp; }
			if (GreaterThan(ref p5, ref p11)) { temp = p5; p5 = p11; p11 = temp; }
			if (GreaterThan(ref p4, ref p9)) { temp = p4; p4 = p9; p9 = temp; }
			if (GreaterThan(ref p5, ref p10)) { temp = p5; p5 = p10; p10 = temp; }
			if (GreaterThan(ref p5, ref p9)) { temp = p5; p5 = p9; p9 = temp; }
			if (GreaterThan(ref p3, ref p7)) { temp = p3; p3 = p7; p7 = temp; }
			if (GreaterThan(ref p3, ref p6)) { temp = p3; p3 = p6; p6 = temp; }
			if (GreaterThan(ref p4, ref p8)) { temp = p4; p4 = p8; p8 = temp; }
			if (GreaterThan(ref p5, ref p8)) { temp = p5; p5 = p8; p8 = temp; }
			if (GreaterThan(ref p4, ref p6)) { temp = p4; p4 = p6; p6 = temp; }
			if (GreaterThan(ref p5, ref p7)) { temp = p5; p5 = p7; p7 = temp; }
			if (GreaterThan(ref p5, ref p6)) { temp = p5; p5 = p6; p6 = temp; }
			if (GreaterThan(ref p13, ref p14)) { temp = p13; p13 = p14; p14 = temp; }
			if (GreaterThan(ref p12, ref p14)) { temp = p12; p12 = p14; p14 = temp; }
			if (GreaterThan(ref p12, ref p13)) { temp = p12; p12 = p13; p13 = temp; }
			if (GreaterThan(ref p16, ref p17)) { temp = p16; p16 = p17; p17 = temp; }
			if (GreaterThan(ref p15, ref p17)) { temp = p15; p15 = p17; p17 = temp; }
			if (GreaterThan(ref p15, ref p16)) { temp = p15; p15 = p16; p16 = temp; }
			if (GreaterThan(ref p12, ref p16)) { temp = p12; p12 = p16; p16 = temp; }
			if (GreaterThan(ref p12, ref p15)) { temp = p12; p12 = p15; p15 = temp; }
			if (GreaterThan(ref p13, ref p17)) { temp = p13; p13 = p17; p17 = temp; }
			if (GreaterThan(ref p14, ref p17)) { temp = p14; p14 = p17; p17 = temp; }
			if (GreaterThan(ref p13, ref p15)) { temp = p13; p13 = p15; p15 = temp; }
			if (GreaterThan(ref p14, ref p16)) { temp = p14; p14 = p16; p16 = temp; }
			if (GreaterThan(ref p14, ref p15)) { temp = p14; p14 = p15; p15 = temp; }
			if (GreaterThan(ref p19, ref p20)) { temp = p19; p19 = p20; p20 = temp; }
			if (GreaterThan(ref p18, ref p20)) { temp = p18; p18 = p20; p20 = temp; }
			if (GreaterThan(ref p18, ref p19)) { temp = p18; p18 = p19; p19 = temp; }
			if (GreaterThan(ref p21, ref p22)) { temp = p21; p21 = p22; p22 = temp; }
			if (GreaterThan(ref p23, ref p24)) { temp = p23; p23 = p24; p24 = temp; }
			if (GreaterThan(ref p21, ref p23)) { temp = p21; p21 = p23; p23 = temp; }
			if (GreaterThan(ref p22, ref p24)) { temp = p22; p22 = p24; p24 = temp; }
			if (GreaterThan(ref p22, ref p23)) { temp = p22; p22 = p23; p23 = temp; }
			if (GreaterThan(ref p18, ref p22)) { temp = p18; p18 = p22; p22 = temp; }
			if (GreaterThan(ref p18, ref p21)) { temp = p18; p18 = p21; p21 = temp; }
			if (GreaterThan(ref p19, ref p23)) { temp = p19; p19 = p23; p23 = temp; }
			if (GreaterThan(ref p20, ref p24)) { temp = p20; p20 = p24; p24 = temp; }
			if (GreaterThan(ref p20, ref p23)) { temp = p20; p20 = p23; p23 = temp; }
			if (GreaterThan(ref p19, ref p21)) { temp = p19; p19 = p21; p21 = temp; }
			if (GreaterThan(ref p20, ref p22)) { temp = p20; p20 = p22; p22 = temp; }
			if (GreaterThan(ref p20, ref p21)) { temp = p20; p20 = p21; p21 = temp; }
			if (GreaterThan(ref p12, ref p19)) { temp = p12; p12 = p19; p19 = temp; }
			if (GreaterThan(ref p12, ref p18)) { temp = p12; p12 = p18; p18 = temp; }
			if (GreaterThan(ref p13, ref p20)) { temp = p13; p13 = p20; p20 = temp; }
			if (GreaterThan(ref p14, ref p21)) { temp = p14; p14 = p21; p21 = temp; }
			if (GreaterThan(ref p14, ref p20)) { temp = p14; p14 = p20; p20 = temp; }
			if (GreaterThan(ref p13, ref p18)) { temp = p13; p13 = p18; p18 = temp; }
			if (GreaterThan(ref p14, ref p19)) { temp = p14; p14 = p19; p19 = temp; }
			if (GreaterThan(ref p14, ref p18)) { temp = p14; p14 = p18; p18 = temp; }
			if (GreaterThan(ref p15, ref p23)) { temp = p15; p15 = p23; p23 = temp; }
			if (GreaterThan(ref p15, ref p22)) { temp = p15; p15 = p22; p22 = temp; }
			if (GreaterThan(ref p16, ref p24)) { temp = p16; p16 = p24; p24 = temp; }
			if (GreaterThan(ref p17, ref p24)) { temp = p17; p17 = p24; p24 = temp; }
			if (GreaterThan(ref p16, ref p22)) { temp = p16; p16 = p22; p22 = temp; }
			if (GreaterThan(ref p17, ref p23)) { temp = p17; p17 = p23; p23 = temp; }
			if (GreaterThan(ref p17, ref p22)) { temp = p17; p17 = p22; p22 = temp; }
			if (GreaterThan(ref p15, ref p19)) { temp = p15; p15 = p19; p19 = temp; }
			if (GreaterThan(ref p15, ref p18)) { temp = p15; p15 = p18; p18 = temp; }
			if (GreaterThan(ref p16, ref p20)) { temp = p16; p16 = p20; p20 = temp; }
			if (GreaterThan(ref p17, ref p21)) { temp = p17; p17 = p21; p21 = temp; }
			if (GreaterThan(ref p17, ref p20)) { temp = p17; p17 = p20; p20 = temp; }
			if (GreaterThan(ref p16, ref p18)) { temp = p16; p16 = p18; p18 = temp; }
			if (GreaterThan(ref p17, ref p19)) { temp = p17; p17 = p19; p19 = temp; }
			if (GreaterThan(ref p17, ref p18)) { temp = p17; p17 = p18; p18 = temp; }
			if (GreaterThan(ref p0, ref p13)) { temp = p0; p0 = p13; p13 = temp; }
			if (GreaterThan(ref p0, ref p12)) { temp = p0; p0 = p12; p12 = temp; }
			if (GreaterThan(ref p1, ref p14)) { temp = p1; p1 = p14; p14 = temp; }
			if (GreaterThan(ref p2, ref p15)) { temp = p2; p2 = p15; p15 = temp; }
			if (GreaterThan(ref p2, ref p14)) { temp = p2; p2 = p14; p14 = temp; }
			if (GreaterThan(ref p1, ref p12)) { temp = p1; p1 = p12; p12 = temp; }
			if (GreaterThan(ref p2, ref p13)) { temp = p2; p2 = p13; p13 = temp; }
			if (GreaterThan(ref p2, ref p12)) { temp = p2; p2 = p12; p12 = temp; }
			if (GreaterThan(ref p3, ref p17)) { temp = p3; p3 = p17; p17 = temp; }
			if (GreaterThan(ref p3, ref p16)) { temp = p3; p3 = p16; p16 = temp; }
			if (GreaterThan(ref p4, ref p18)) { temp = p4; p4 = p18; p18 = temp; }
			if (GreaterThan(ref p5, ref p18)) { temp = p5; p5 = p18; p18 = temp; }
			if (GreaterThan(ref p4, ref p16)) { temp = p4; p4 = p16; p16 = temp; }
			if (GreaterThan(ref p5, ref p17)) { temp = p5; p5 = p17; p17 = temp; }
			if (GreaterThan(ref p5, ref p16)) { temp = p5; p5 = p16; p16 = temp; }
			if (GreaterThan(ref p3, ref p13)) { temp = p3; p3 = p13; p13 = temp; }
			if (GreaterThan(ref p3, ref p12)) { temp = p3; p3 = p12; p12 = temp; }
			if (GreaterThan(ref p4, ref p14)) { temp = p4; p4 = p14; p14 = temp; }
			if (GreaterThan(ref p5, ref p15)) { temp = p5; p5 = p15; p15 = temp; }
			if (GreaterThan(ref p5, ref p14)) { temp = p5; p5 = p14; p14 = temp; }
			if (GreaterThan(ref p4, ref p12)) { temp = p4; p4 = p12; p12 = temp; }
			if (GreaterThan(ref p5, ref p13)) { temp = p5; p5 = p13; p13 = temp; }
			if (GreaterThan(ref p5, ref p12)) { temp = p5; p5 = p12; p12 = temp; }
			if (GreaterThan(ref p6, ref p20)) { temp = p6; p6 = p20; p20 = temp; }
			if (GreaterThan(ref p6, ref p19)) { temp = p6; p6 = p19; p19 = temp; }
			if (GreaterThan(ref p7, ref p21)) { temp = p7; p7 = p21; p21 = temp; }
			if (GreaterThan(ref p8, ref p21)) { temp = p8; p8 = p21; p21 = temp; }
			if (GreaterThan(ref p7, ref p19)) { temp = p7; p7 = p19; p19 = temp; }
			if (GreaterThan(ref p8, ref p20)) { temp = p8; p8 = p20; p20 = temp; }
			if (GreaterThan(ref p8, ref p19)) { temp = p8; p8 = p19; p19 = temp; }
			if (GreaterThan(ref p9, ref p23)) { temp = p9; p9 = p23; p23 = temp; }
			if (GreaterThan(ref p9, ref p22)) { temp = p9; p9 = p22; p22 = temp; }
			if (GreaterThan(ref p10, ref p24)) { temp = p10; p10 = p24; p24 = temp; }
			if (GreaterThan(ref p11, ref p24)) { temp = p11; p11 = p24; p24 = temp; }
			if (GreaterThan(ref p10, ref p22)) { temp = p10; p10 = p22; p22 = temp; }
			if (GreaterThan(ref p11, ref p23)) { temp = p11; p11 = p23; p23 = temp; }
			if (GreaterThan(ref p11, ref p22)) { temp = p11; p11 = p22; p22 = temp; }
			if (GreaterThan(ref p9, ref p20)) { temp = p9; p9 = p20; p20 = temp; }
			if (GreaterThan(ref p9, ref p19)) { temp = p9; p9 = p19; p19 = temp; }
			if (GreaterThan(ref p10, ref p21)) { temp = p10; p10 = p21; p21 = temp; }
			if (GreaterThan(ref p11, ref p21)) { temp = p11; p11 = p21; p21 = temp; }
			if (GreaterThan(ref p10, ref p19)) { temp = p10; p10 = p19; p19 = temp; }
			if (GreaterThan(ref p11, ref p20)) { temp = p11; p11 = p20; p20 = temp; }
			if (GreaterThan(ref p11, ref p19)) { temp = p11; p11 = p19; p19 = temp; }
			if (GreaterThan(ref p6, ref p13)) { temp = p6; p6 = p13; p13 = temp; }
			if (GreaterThan(ref p6, ref p12)) { temp = p6; p6 = p12; p12 = temp; }
			if (GreaterThan(ref p7, ref p14)) { temp = p7; p7 = p14; p14 = temp; }
			if (GreaterThan(ref p8, ref p15)) { temp = p8; p8 = p15; p15 = temp; }
			if (GreaterThan(ref p8, ref p14)) { temp = p8; p8 = p14; p14 = temp; }
			if (GreaterThan(ref p7, ref p12)) { temp = p7; p7 = p12; p12 = temp; }
			if (GreaterThan(ref p8, ref p13)) { temp = p8; p8 = p13; p13 = temp; }
			if (GreaterThan(ref p8, ref p12)) { temp = p8; p8 = p12; p12 = temp; }
			if (GreaterThan(ref p9, ref p17)) { temp = p9; p9 = p17; p17 = temp; }
			if (GreaterThan(ref p9, ref p16)) { temp = p9; p9 = p16; p16 = temp; }
			if (GreaterThan(ref p10, ref p18)) { temp = p10; p10 = p18; p18 = temp; }
			if (GreaterThan(ref p11, ref p18)) { temp = p11; p11 = p18; p18 = temp; }
			if (GreaterThan(ref p10, ref p16)) { temp = p10; p10 = p16; p16 = temp; }
			if (GreaterThan(ref p11, ref p17)) { temp = p11; p11 = p17; p17 = temp; }
			if (GreaterThan(ref p11, ref p16)) { temp = p11; p11 = p16; p16 = temp; }
			if (GreaterThan(ref p9, ref p13)) { temp = p9; p9 = p13; p13 = temp; }
			if (GreaterThan(ref p9, ref p12)) { temp = p9; p9 = p12; p12 = temp; }
			if (GreaterThan(ref p10, ref p14)) { temp = p10; p10 = p14; p14 = temp; }
			if (GreaterThan(ref p11, ref p15)) { temp = p11; p11 = p15; p15 = temp; }
			if (GreaterThan(ref p11, ref p14)) { temp = p11; p11 = p14; p14 = temp; }
			if (GreaterThan(ref p10, ref p12)) { temp = p10; p10 = p12; p12 = temp; }
			if (GreaterThan(ref p11, ref p13)) { temp = p11; p11 = p13; p13 = temp; }
			if (GreaterThan(ref p11, ref p12)) { temp = p11; p11 = p12; p12 = temp; }
#endif
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
#if NETSTANDARD1_3
			if (p1.CompareTo(p2) > 0) { temp = p1; p1 = p2; p2 = temp; }
			if (p0.CompareTo(p2) > 0) { temp = p0; p0 = p2; p2 = temp; }
			if (p0.CompareTo(p1) > 0) { temp = p0; p0 = p1; p1 = temp; }
			if (p4.CompareTo(p5) > 0) { temp = p4; p4 = p5; p5 = temp; }
			if (p3.CompareTo(p5) > 0) { temp = p3; p3 = p5; p5 = temp; }
			if (p3.CompareTo(p4) > 0) { temp = p3; p3 = p4; p4 = temp; }
			if (p0.CompareTo(p4) > 0) { temp = p0; p0 = p4; p4 = temp; }
			if (p0.CompareTo(p3) > 0) { temp = p0; p0 = p3; p3 = temp; }
			if (p1.CompareTo(p5) > 0) { temp = p1; p1 = p5; p5 = temp; }
			if (p2.CompareTo(p5) > 0) { temp = p2; p2 = p5; p5 = temp; }
			if (p1.CompareTo(p3) > 0) { temp = p1; p1 = p3; p3 = temp; }
			if (p2.CompareTo(p4) > 0) { temp = p2; p2 = p4; p4 = temp; }
			if (p2.CompareTo(p3) > 0) { temp = p2; p2 = p3; p3 = temp; }
			if (p7.CompareTo(p8) > 0) { temp = p7; p7 = p8; p8 = temp; }
			if (p6.CompareTo(p8) > 0) { temp = p6; p6 = p8; p8 = temp; }
			if (p6.CompareTo(p7) > 0) { temp = p6; p6 = p7; p7 = temp; }
			if (p9.CompareTo(p10) > 0) { temp = p9; p9 = p10; p10 = temp; }
			if (p11.CompareTo(p12) > 0) { temp = p11; p11 = p12; p12 = temp; }
			if (p9.CompareTo(p11) > 0) { temp = p9; p9 = p11; p11 = temp; }
			if (p10.CompareTo(p12) > 0) { temp = p10; p10 = p12; p12 = temp; }
			if (p10.CompareTo(p11) > 0) { temp = p10; p10 = p11; p11 = temp; }
			if (p6.CompareTo(p10) > 0) { temp = p6; p6 = p10; p10 = temp; }
			if (p6.CompareTo(p9) > 0) { temp = p6; p6 = p9; p9 = temp; }
			if (p7.CompareTo(p11) > 0) { temp = p7; p7 = p11; p11 = temp; }
			if (p8.CompareTo(p12) > 0) { temp = p8; p8 = p12; p12 = temp; }
			if (p8.CompareTo(p11) > 0) { temp = p8; p8 = p11; p11 = temp; }
			if (p7.CompareTo(p9) > 0) { temp = p7; p7 = p9; p9 = temp; }
			if (p8.CompareTo(p10) > 0) { temp = p8; p8 = p10; p10 = temp; }
			if (p8.CompareTo(p9) > 0) { temp = p8; p8 = p9; p9 = temp; }
			if (p0.CompareTo(p7) > 0) { temp = p0; p0 = p7; p7 = temp; }
			if (p0.CompareTo(p6) > 0) { temp = p0; p0 = p6; p6 = temp; }
			if (p1.CompareTo(p8) > 0) { temp = p1; p1 = p8; p8 = temp; }
			if (p2.CompareTo(p9) > 0) { temp = p2; p2 = p9; p9 = temp; }
			if (p2.CompareTo(p8) > 0) { temp = p2; p2 = p8; p8 = temp; }
			if (p1.CompareTo(p6) > 0) { temp = p1; p1 = p6; p6 = temp; }
			if (p2.CompareTo(p7) > 0) { temp = p2; p2 = p7; p7 = temp; }
			if (p2.CompareTo(p6) > 0) { temp = p2; p2 = p6; p6 = temp; }
			if (p3.CompareTo(p11) > 0) { temp = p3; p3 = p11; p11 = temp; }
			if (p3.CompareTo(p10) > 0) { temp = p3; p3 = p10; p10 = temp; }
			if (p4.CompareTo(p12) > 0) { temp = p4; p4 = p12; p12 = temp; }
			if (p5.CompareTo(p12) > 0) { temp = p5; p5 = p12; p12 = temp; }
			if (p4.CompareTo(p10) > 0) { temp = p4; p4 = p10; p10 = temp; }
			if (p5.CompareTo(p11) > 0) { temp = p5; p5 = p11; p11 = temp; }
			if (p5.CompareTo(p10) > 0) { temp = p5; p5 = p10; p10 = temp; }
			if (p3.CompareTo(p7) > 0) { temp = p3; p3 = p7; p7 = temp; }
			if (p3.CompareTo(p6) > 0) { temp = p3; p3 = p6; p6 = temp; }
			if (p4.CompareTo(p8) > 0) { temp = p4; p4 = p8; p8 = temp; }
			if (p5.CompareTo(p9) > 0) { temp = p5; p5 = p9; p9 = temp; }
			if (p5.CompareTo(p8) > 0) { temp = p5; p5 = p8; p8 = temp; }
			if (p4.CompareTo(p6) > 0) { temp = p4; p4 = p6; p6 = temp; }
			if (p5.CompareTo(p7) > 0) { temp = p5; p5 = p7; p7 = temp; }
			if (p5.CompareTo(p6) > 0) { temp = p5; p5 = p6; p6 = temp; }
			if (p14.CompareTo(p15) > 0) { temp = p14; p14 = p15; p15 = temp; }
			if (p13.CompareTo(p15) > 0) { temp = p13; p13 = p15; p15 = temp; }
			if (p13.CompareTo(p14) > 0) { temp = p13; p13 = p14; p14 = temp; }
			if (p17.CompareTo(p18) > 0) { temp = p17; p17 = p18; p18 = temp; }
			if (p16.CompareTo(p18) > 0) { temp = p16; p16 = p18; p18 = temp; }
			if (p16.CompareTo(p17) > 0) { temp = p16; p16 = p17; p17 = temp; }
			if (p13.CompareTo(p17) > 0) { temp = p13; p13 = p17; p17 = temp; }
			if (p13.CompareTo(p16) > 0) { temp = p13; p13 = p16; p16 = temp; }
			if (p14.CompareTo(p18) > 0) { temp = p14; p14 = p18; p18 = temp; }
			if (p15.CompareTo(p18) > 0) { temp = p15; p15 = p18; p18 = temp; }
			if (p14.CompareTo(p16) > 0) { temp = p14; p14 = p16; p16 = temp; }
			if (p15.CompareTo(p17) > 0) { temp = p15; p15 = p17; p17 = temp; }
			if (p15.CompareTo(p16) > 0) { temp = p15; p15 = p16; p16 = temp; }
			if (p20.CompareTo(p21) > 0) { temp = p20; p20 = p21; p21 = temp; }
			if (p19.CompareTo(p21) > 0) { temp = p19; p19 = p21; p21 = temp; }
			if (p19.CompareTo(p20) > 0) { temp = p19; p19 = p20; p20 = temp; }
			if (p22.CompareTo(p23) > 0) { temp = p22; p22 = p23; p23 = temp; }
			if (p24.CompareTo(p25) > 0) { temp = p24; p24 = p25; p25 = temp; }
			if (p22.CompareTo(p24) > 0) { temp = p22; p22 = p24; p24 = temp; }
			if (p23.CompareTo(p25) > 0) { temp = p23; p23 = p25; p25 = temp; }
			if (p23.CompareTo(p24) > 0) { temp = p23; p23 = p24; p24 = temp; }
			if (p19.CompareTo(p23) > 0) { temp = p19; p19 = p23; p23 = temp; }
			if (p19.CompareTo(p22) > 0) { temp = p19; p19 = p22; p22 = temp; }
			if (p20.CompareTo(p24) > 0) { temp = p20; p20 = p24; p24 = temp; }
			if (p21.CompareTo(p25) > 0) { temp = p21; p21 = p25; p25 = temp; }
			if (p21.CompareTo(p24) > 0) { temp = p21; p21 = p24; p24 = temp; }
			if (p20.CompareTo(p22) > 0) { temp = p20; p20 = p22; p22 = temp; }
			if (p21.CompareTo(p23) > 0) { temp = p21; p21 = p23; p23 = temp; }
			if (p21.CompareTo(p22) > 0) { temp = p21; p21 = p22; p22 = temp; }
			if (p13.CompareTo(p20) > 0) { temp = p13; p13 = p20; p20 = temp; }
			if (p13.CompareTo(p19) > 0) { temp = p13; p13 = p19; p19 = temp; }
			if (p14.CompareTo(p21) > 0) { temp = p14; p14 = p21; p21 = temp; }
			if (p15.CompareTo(p22) > 0) { temp = p15; p15 = p22; p22 = temp; }
			if (p15.CompareTo(p21) > 0) { temp = p15; p15 = p21; p21 = temp; }
			if (p14.CompareTo(p19) > 0) { temp = p14; p14 = p19; p19 = temp; }
			if (p15.CompareTo(p20) > 0) { temp = p15; p15 = p20; p20 = temp; }
			if (p15.CompareTo(p19) > 0) { temp = p15; p15 = p19; p19 = temp; }
			if (p16.CompareTo(p24) > 0) { temp = p16; p16 = p24; p24 = temp; }
			if (p16.CompareTo(p23) > 0) { temp = p16; p16 = p23; p23 = temp; }
			if (p17.CompareTo(p25) > 0) { temp = p17; p17 = p25; p25 = temp; }
			if (p18.CompareTo(p25) > 0) { temp = p18; p18 = p25; p25 = temp; }
			if (p17.CompareTo(p23) > 0) { temp = p17; p17 = p23; p23 = temp; }
			if (p18.CompareTo(p24) > 0) { temp = p18; p18 = p24; p24 = temp; }
			if (p18.CompareTo(p23) > 0) { temp = p18; p18 = p23; p23 = temp; }
			if (p16.CompareTo(p20) > 0) { temp = p16; p16 = p20; p20 = temp; }
			if (p16.CompareTo(p19) > 0) { temp = p16; p16 = p19; p19 = temp; }
			if (p17.CompareTo(p21) > 0) { temp = p17; p17 = p21; p21 = temp; }
			if (p18.CompareTo(p22) > 0) { temp = p18; p18 = p22; p22 = temp; }
			if (p18.CompareTo(p21) > 0) { temp = p18; p18 = p21; p21 = temp; }
			if (p17.CompareTo(p19) > 0) { temp = p17; p17 = p19; p19 = temp; }
			if (p18.CompareTo(p20) > 0) { temp = p18; p18 = p20; p20 = temp; }
			if (p18.CompareTo(p19) > 0) { temp = p18; p18 = p19; p19 = temp; }
			if (p0.CompareTo(p14) > 0) { temp = p0; p0 = p14; p14 = temp; }
			if (p0.CompareTo(p13) > 0) { temp = p0; p0 = p13; p13 = temp; }
			if (p1.CompareTo(p15) > 0) { temp = p1; p1 = p15; p15 = temp; }
			if (p2.CompareTo(p16) > 0) { temp = p2; p2 = p16; p16 = temp; }
			if (p2.CompareTo(p15) > 0) { temp = p2; p2 = p15; p15 = temp; }
			if (p1.CompareTo(p13) > 0) { temp = p1; p1 = p13; p13 = temp; }
			if (p2.CompareTo(p14) > 0) { temp = p2; p2 = p14; p14 = temp; }
			if (p2.CompareTo(p13) > 0) { temp = p2; p2 = p13; p13 = temp; }
			if (p3.CompareTo(p18) > 0) { temp = p3; p3 = p18; p18 = temp; }
			if (p3.CompareTo(p17) > 0) { temp = p3; p3 = p17; p17 = temp; }
			if (p4.CompareTo(p19) > 0) { temp = p4; p4 = p19; p19 = temp; }
			if (p5.CompareTo(p19) > 0) { temp = p5; p5 = p19; p19 = temp; }
			if (p4.CompareTo(p17) > 0) { temp = p4; p4 = p17; p17 = temp; }
			if (p5.CompareTo(p18) > 0) { temp = p5; p5 = p18; p18 = temp; }
			if (p5.CompareTo(p17) > 0) { temp = p5; p5 = p17; p17 = temp; }
			if (p3.CompareTo(p14) > 0) { temp = p3; p3 = p14; p14 = temp; }
			if (p3.CompareTo(p13) > 0) { temp = p3; p3 = p13; p13 = temp; }
			if (p4.CompareTo(p15) > 0) { temp = p4; p4 = p15; p15 = temp; }
			if (p5.CompareTo(p16) > 0) { temp = p5; p5 = p16; p16 = temp; }
			if (p5.CompareTo(p15) > 0) { temp = p5; p5 = p15; p15 = temp; }
			if (p4.CompareTo(p13) > 0) { temp = p4; p4 = p13; p13 = temp; }
			if (p5.CompareTo(p14) > 0) { temp = p5; p5 = p14; p14 = temp; }
			if (p5.CompareTo(p13) > 0) { temp = p5; p5 = p13; p13 = temp; }
			if (p6.CompareTo(p21) > 0) { temp = p6; p6 = p21; p21 = temp; }
			if (p6.CompareTo(p20) > 0) { temp = p6; p6 = p20; p20 = temp; }
			if (p7.CompareTo(p22) > 0) { temp = p7; p7 = p22; p22 = temp; }
			if (p8.CompareTo(p22) > 0) { temp = p8; p8 = p22; p22 = temp; }
			if (p7.CompareTo(p20) > 0) { temp = p7; p7 = p20; p20 = temp; }
			if (p8.CompareTo(p21) > 0) { temp = p8; p8 = p21; p21 = temp; }
			if (p8.CompareTo(p20) > 0) { temp = p8; p8 = p20; p20 = temp; }
			if (p9.CompareTo(p23) > 0) { temp = p9; p9 = p23; p23 = temp; }
			if (p10.CompareTo(p24) > 0) { temp = p10; p10 = p24; p24 = temp; }
			if (p10.CompareTo(p23) > 0) { temp = p10; p10 = p23; p23 = temp; }
			if (p11.CompareTo(p25) > 0) { temp = p11; p11 = p25; p25 = temp; }
			if (p12.CompareTo(p25) > 0) { temp = p12; p12 = p25; p25 = temp; }
			if (p11.CompareTo(p23) > 0) { temp = p11; p11 = p23; p23 = temp; }
			if (p12.CompareTo(p24) > 0) { temp = p12; p12 = p24; p24 = temp; }
			if (p12.CompareTo(p23) > 0) { temp = p12; p12 = p23; p23 = temp; }
			if (p9.CompareTo(p20) > 0) { temp = p9; p9 = p20; p20 = temp; }
			if (p10.CompareTo(p21) > 0) { temp = p10; p10 = p21; p21 = temp; }
			if (p10.CompareTo(p20) > 0) { temp = p10; p10 = p20; p20 = temp; }
			if (p11.CompareTo(p22) > 0) { temp = p11; p11 = p22; p22 = temp; }
			if (p12.CompareTo(p22) > 0) { temp = p12; p12 = p22; p22 = temp; }
			if (p11.CompareTo(p20) > 0) { temp = p11; p11 = p20; p20 = temp; }
			if (p12.CompareTo(p21) > 0) { temp = p12; p12 = p21; p21 = temp; }
			if (p12.CompareTo(p20) > 0) { temp = p12; p12 = p20; p20 = temp; }
			if (p6.CompareTo(p14) > 0) { temp = p6; p6 = p14; p14 = temp; }
			if (p6.CompareTo(p13) > 0) { temp = p6; p6 = p13; p13 = temp; }
			if (p7.CompareTo(p15) > 0) { temp = p7; p7 = p15; p15 = temp; }
			if (p8.CompareTo(p16) > 0) { temp = p8; p8 = p16; p16 = temp; }
			if (p8.CompareTo(p15) > 0) { temp = p8; p8 = p15; p15 = temp; }
			if (p7.CompareTo(p13) > 0) { temp = p7; p7 = p13; p13 = temp; }
			if (p8.CompareTo(p14) > 0) { temp = p8; p8 = p14; p14 = temp; }
			if (p8.CompareTo(p13) > 0) { temp = p8; p8 = p13; p13 = temp; }
			if (p9.CompareTo(p17) > 0) { temp = p9; p9 = p17; p17 = temp; }
			if (p10.CompareTo(p18) > 0) { temp = p10; p10 = p18; p18 = temp; }
			if (p10.CompareTo(p17) > 0) { temp = p10; p10 = p17; p17 = temp; }
			if (p11.CompareTo(p19) > 0) { temp = p11; p11 = p19; p19 = temp; }
			if (p12.CompareTo(p19) > 0) { temp = p12; p12 = p19; p19 = temp; }
			if (p11.CompareTo(p17) > 0) { temp = p11; p11 = p17; p17 = temp; }
			if (p12.CompareTo(p18) > 0) { temp = p12; p12 = p18; p18 = temp; }
			if (p12.CompareTo(p17) > 0) { temp = p12; p12 = p17; p17 = temp; }
			if (p9.CompareTo(p13) > 0) { temp = p9; p9 = p13; p13 = temp; }
			if (p10.CompareTo(p14) > 0) { temp = p10; p10 = p14; p14 = temp; }
			if (p10.CompareTo(p13) > 0) { temp = p10; p10 = p13; p13 = temp; }
			if (p11.CompareTo(p15) > 0) { temp = p11; p11 = p15; p15 = temp; }
			if (p12.CompareTo(p16) > 0) { temp = p12; p12 = p16; p16 = temp; }
			if (p12.CompareTo(p15) > 0) { temp = p12; p12 = p15; p15 = temp; }
			if (p11.CompareTo(p13) > 0) { temp = p11; p11 = p13; p13 = temp; }
			if (p12.CompareTo(p14) > 0) { temp = p12; p12 = p14; p14 = temp; }
			if (p12.CompareTo(p13) > 0) { temp = p12; p12 = p13; p13 = temp; }
#else
			if (GreaterThan(ref p1, ref p2)) { temp = p1; p1 = p2; p2 = temp; }
			if (GreaterThan(ref p0, ref p2)) { temp = p0; p0 = p2; p2 = temp; }
			if (GreaterThan(ref p0, ref p1)) { temp = p0; p0 = p1; p1 = temp; }
			if (GreaterThan(ref p4, ref p5)) { temp = p4; p4 = p5; p5 = temp; }
			if (GreaterThan(ref p3, ref p5)) { temp = p3; p3 = p5; p5 = temp; }
			if (GreaterThan(ref p3, ref p4)) { temp = p3; p3 = p4; p4 = temp; }
			if (GreaterThan(ref p0, ref p4)) { temp = p0; p0 = p4; p4 = temp; }
			if (GreaterThan(ref p0, ref p3)) { temp = p0; p0 = p3; p3 = temp; }
			if (GreaterThan(ref p1, ref p5)) { temp = p1; p1 = p5; p5 = temp; }
			if (GreaterThan(ref p2, ref p5)) { temp = p2; p2 = p5; p5 = temp; }
			if (GreaterThan(ref p1, ref p3)) { temp = p1; p1 = p3; p3 = temp; }
			if (GreaterThan(ref p2, ref p4)) { temp = p2; p2 = p4; p4 = temp; }
			if (GreaterThan(ref p2, ref p3)) { temp = p2; p2 = p3; p3 = temp; }
			if (GreaterThan(ref p7, ref p8)) { temp = p7; p7 = p8; p8 = temp; }
			if (GreaterThan(ref p6, ref p8)) { temp = p6; p6 = p8; p8 = temp; }
			if (GreaterThan(ref p6, ref p7)) { temp = p6; p6 = p7; p7 = temp; }
			if (GreaterThan(ref p9, ref p10)) { temp = p9; p9 = p10; p10 = temp; }
			if (GreaterThan(ref p11, ref p12)) { temp = p11; p11 = p12; p12 = temp; }
			if (GreaterThan(ref p9, ref p11)) { temp = p9; p9 = p11; p11 = temp; }
			if (GreaterThan(ref p10, ref p12)) { temp = p10; p10 = p12; p12 = temp; }
			if (GreaterThan(ref p10, ref p11)) { temp = p10; p10 = p11; p11 = temp; }
			if (GreaterThan(ref p6, ref p10)) { temp = p6; p6 = p10; p10 = temp; }
			if (GreaterThan(ref p6, ref p9)) { temp = p6; p6 = p9; p9 = temp; }
			if (GreaterThan(ref p7, ref p11)) { temp = p7; p7 = p11; p11 = temp; }
			if (GreaterThan(ref p8, ref p12)) { temp = p8; p8 = p12; p12 = temp; }
			if (GreaterThan(ref p8, ref p11)) { temp = p8; p8 = p11; p11 = temp; }
			if (GreaterThan(ref p7, ref p9)) { temp = p7; p7 = p9; p9 = temp; }
			if (GreaterThan(ref p8, ref p10)) { temp = p8; p8 = p10; p10 = temp; }
			if (GreaterThan(ref p8, ref p9)) { temp = p8; p8 = p9; p9 = temp; }
			if (GreaterThan(ref p0, ref p7)) { temp = p0; p0 = p7; p7 = temp; }
			if (GreaterThan(ref p0, ref p6)) { temp = p0; p0 = p6; p6 = temp; }
			if (GreaterThan(ref p1, ref p8)) { temp = p1; p1 = p8; p8 = temp; }
			if (GreaterThan(ref p2, ref p9)) { temp = p2; p2 = p9; p9 = temp; }
			if (GreaterThan(ref p2, ref p8)) { temp = p2; p2 = p8; p8 = temp; }
			if (GreaterThan(ref p1, ref p6)) { temp = p1; p1 = p6; p6 = temp; }
			if (GreaterThan(ref p2, ref p7)) { temp = p2; p2 = p7; p7 = temp; }
			if (GreaterThan(ref p2, ref p6)) { temp = p2; p2 = p6; p6 = temp; }
			if (GreaterThan(ref p3, ref p11)) { temp = p3; p3 = p11; p11 = temp; }
			if (GreaterThan(ref p3, ref p10)) { temp = p3; p3 = p10; p10 = temp; }
			if (GreaterThan(ref p4, ref p12)) { temp = p4; p4 = p12; p12 = temp; }
			if (GreaterThan(ref p5, ref p12)) { temp = p5; p5 = p12; p12 = temp; }
			if (GreaterThan(ref p4, ref p10)) { temp = p4; p4 = p10; p10 = temp; }
			if (GreaterThan(ref p5, ref p11)) { temp = p5; p5 = p11; p11 = temp; }
			if (GreaterThan(ref p5, ref p10)) { temp = p5; p5 = p10; p10 = temp; }
			if (GreaterThan(ref p3, ref p7)) { temp = p3; p3 = p7; p7 = temp; }
			if (GreaterThan(ref p3, ref p6)) { temp = p3; p3 = p6; p6 = temp; }
			if (GreaterThan(ref p4, ref p8)) { temp = p4; p4 = p8; p8 = temp; }
			if (GreaterThan(ref p5, ref p9)) { temp = p5; p5 = p9; p9 = temp; }
			if (GreaterThan(ref p5, ref p8)) { temp = p5; p5 = p8; p8 = temp; }
			if (GreaterThan(ref p4, ref p6)) { temp = p4; p4 = p6; p6 = temp; }
			if (GreaterThan(ref p5, ref p7)) { temp = p5; p5 = p7; p7 = temp; }
			if (GreaterThan(ref p5, ref p6)) { temp = p5; p5 = p6; p6 = temp; }
			if (GreaterThan(ref p14, ref p15)) { temp = p14; p14 = p15; p15 = temp; }
			if (GreaterThan(ref p13, ref p15)) { temp = p13; p13 = p15; p15 = temp; }
			if (GreaterThan(ref p13, ref p14)) { temp = p13; p13 = p14; p14 = temp; }
			if (GreaterThan(ref p17, ref p18)) { temp = p17; p17 = p18; p18 = temp; }
			if (GreaterThan(ref p16, ref p18)) { temp = p16; p16 = p18; p18 = temp; }
			if (GreaterThan(ref p16, ref p17)) { temp = p16; p16 = p17; p17 = temp; }
			if (GreaterThan(ref p13, ref p17)) { temp = p13; p13 = p17; p17 = temp; }
			if (GreaterThan(ref p13, ref p16)) { temp = p13; p13 = p16; p16 = temp; }
			if (GreaterThan(ref p14, ref p18)) { temp = p14; p14 = p18; p18 = temp; }
			if (GreaterThan(ref p15, ref p18)) { temp = p15; p15 = p18; p18 = temp; }
			if (GreaterThan(ref p14, ref p16)) { temp = p14; p14 = p16; p16 = temp; }
			if (GreaterThan(ref p15, ref p17)) { temp = p15; p15 = p17; p17 = temp; }
			if (GreaterThan(ref p15, ref p16)) { temp = p15; p15 = p16; p16 = temp; }
			if (GreaterThan(ref p20, ref p21)) { temp = p20; p20 = p21; p21 = temp; }
			if (GreaterThan(ref p19, ref p21)) { temp = p19; p19 = p21; p21 = temp; }
			if (GreaterThan(ref p19, ref p20)) { temp = p19; p19 = p20; p20 = temp; }
			if (GreaterThan(ref p22, ref p23)) { temp = p22; p22 = p23; p23 = temp; }
			if (GreaterThan(ref p24, ref p25)) { temp = p24; p24 = p25; p25 = temp; }
			if (GreaterThan(ref p22, ref p24)) { temp = p22; p22 = p24; p24 = temp; }
			if (GreaterThan(ref p23, ref p25)) { temp = p23; p23 = p25; p25 = temp; }
			if (GreaterThan(ref p23, ref p24)) { temp = p23; p23 = p24; p24 = temp; }
			if (GreaterThan(ref p19, ref p23)) { temp = p19; p19 = p23; p23 = temp; }
			if (GreaterThan(ref p19, ref p22)) { temp = p19; p19 = p22; p22 = temp; }
			if (GreaterThan(ref p20, ref p24)) { temp = p20; p20 = p24; p24 = temp; }
			if (GreaterThan(ref p21, ref p25)) { temp = p21; p21 = p25; p25 = temp; }
			if (GreaterThan(ref p21, ref p24)) { temp = p21; p21 = p24; p24 = temp; }
			if (GreaterThan(ref p20, ref p22)) { temp = p20; p20 = p22; p22 = temp; }
			if (GreaterThan(ref p21, ref p23)) { temp = p21; p21 = p23; p23 = temp; }
			if (GreaterThan(ref p21, ref p22)) { temp = p21; p21 = p22; p22 = temp; }
			if (GreaterThan(ref p13, ref p20)) { temp = p13; p13 = p20; p20 = temp; }
			if (GreaterThan(ref p13, ref p19)) { temp = p13; p13 = p19; p19 = temp; }
			if (GreaterThan(ref p14, ref p21)) { temp = p14; p14 = p21; p21 = temp; }
			if (GreaterThan(ref p15, ref p22)) { temp = p15; p15 = p22; p22 = temp; }
			if (GreaterThan(ref p15, ref p21)) { temp = p15; p15 = p21; p21 = temp; }
			if (GreaterThan(ref p14, ref p19)) { temp = p14; p14 = p19; p19 = temp; }
			if (GreaterThan(ref p15, ref p20)) { temp = p15; p15 = p20; p20 = temp; }
			if (GreaterThan(ref p15, ref p19)) { temp = p15; p15 = p19; p19 = temp; }
			if (GreaterThan(ref p16, ref p24)) { temp = p16; p16 = p24; p24 = temp; }
			if (GreaterThan(ref p16, ref p23)) { temp = p16; p16 = p23; p23 = temp; }
			if (GreaterThan(ref p17, ref p25)) { temp = p17; p17 = p25; p25 = temp; }
			if (GreaterThan(ref p18, ref p25)) { temp = p18; p18 = p25; p25 = temp; }
			if (GreaterThan(ref p17, ref p23)) { temp = p17; p17 = p23; p23 = temp; }
			if (GreaterThan(ref p18, ref p24)) { temp = p18; p18 = p24; p24 = temp; }
			if (GreaterThan(ref p18, ref p23)) { temp = p18; p18 = p23; p23 = temp; }
			if (GreaterThan(ref p16, ref p20)) { temp = p16; p16 = p20; p20 = temp; }
			if (GreaterThan(ref p16, ref p19)) { temp = p16; p16 = p19; p19 = temp; }
			if (GreaterThan(ref p17, ref p21)) { temp = p17; p17 = p21; p21 = temp; }
			if (GreaterThan(ref p18, ref p22)) { temp = p18; p18 = p22; p22 = temp; }
			if (GreaterThan(ref p18, ref p21)) { temp = p18; p18 = p21; p21 = temp; }
			if (GreaterThan(ref p17, ref p19)) { temp = p17; p17 = p19; p19 = temp; }
			if (GreaterThan(ref p18, ref p20)) { temp = p18; p18 = p20; p20 = temp; }
			if (GreaterThan(ref p18, ref p19)) { temp = p18; p18 = p19; p19 = temp; }
			if (GreaterThan(ref p0, ref p14)) { temp = p0; p0 = p14; p14 = temp; }
			if (GreaterThan(ref p0, ref p13)) { temp = p0; p0 = p13; p13 = temp; }
			if (GreaterThan(ref p1, ref p15)) { temp = p1; p1 = p15; p15 = temp; }
			if (GreaterThan(ref p2, ref p16)) { temp = p2; p2 = p16; p16 = temp; }
			if (GreaterThan(ref p2, ref p15)) { temp = p2; p2 = p15; p15 = temp; }
			if (GreaterThan(ref p1, ref p13)) { temp = p1; p1 = p13; p13 = temp; }
			if (GreaterThan(ref p2, ref p14)) { temp = p2; p2 = p14; p14 = temp; }
			if (GreaterThan(ref p2, ref p13)) { temp = p2; p2 = p13; p13 = temp; }
			if (GreaterThan(ref p3, ref p18)) { temp = p3; p3 = p18; p18 = temp; }
			if (GreaterThan(ref p3, ref p17)) { temp = p3; p3 = p17; p17 = temp; }
			if (GreaterThan(ref p4, ref p19)) { temp = p4; p4 = p19; p19 = temp; }
			if (GreaterThan(ref p5, ref p19)) { temp = p5; p5 = p19; p19 = temp; }
			if (GreaterThan(ref p4, ref p17)) { temp = p4; p4 = p17; p17 = temp; }
			if (GreaterThan(ref p5, ref p18)) { temp = p5; p5 = p18; p18 = temp; }
			if (GreaterThan(ref p5, ref p17)) { temp = p5; p5 = p17; p17 = temp; }
			if (GreaterThan(ref p3, ref p14)) { temp = p3; p3 = p14; p14 = temp; }
			if (GreaterThan(ref p3, ref p13)) { temp = p3; p3 = p13; p13 = temp; }
			if (GreaterThan(ref p4, ref p15)) { temp = p4; p4 = p15; p15 = temp; }
			if (GreaterThan(ref p5, ref p16)) { temp = p5; p5 = p16; p16 = temp; }
			if (GreaterThan(ref p5, ref p15)) { temp = p5; p5 = p15; p15 = temp; }
			if (GreaterThan(ref p4, ref p13)) { temp = p4; p4 = p13; p13 = temp; }
			if (GreaterThan(ref p5, ref p14)) { temp = p5; p5 = p14; p14 = temp; }
			if (GreaterThan(ref p5, ref p13)) { temp = p5; p5 = p13; p13 = temp; }
			if (GreaterThan(ref p6, ref p21)) { temp = p6; p6 = p21; p21 = temp; }
			if (GreaterThan(ref p6, ref p20)) { temp = p6; p6 = p20; p20 = temp; }
			if (GreaterThan(ref p7, ref p22)) { temp = p7; p7 = p22; p22 = temp; }
			if (GreaterThan(ref p8, ref p22)) { temp = p8; p8 = p22; p22 = temp; }
			if (GreaterThan(ref p7, ref p20)) { temp = p7; p7 = p20; p20 = temp; }
			if (GreaterThan(ref p8, ref p21)) { temp = p8; p8 = p21; p21 = temp; }
			if (GreaterThan(ref p8, ref p20)) { temp = p8; p8 = p20; p20 = temp; }
			if (GreaterThan(ref p9, ref p23)) { temp = p9; p9 = p23; p23 = temp; }
			if (GreaterThan(ref p10, ref p24)) { temp = p10; p10 = p24; p24 = temp; }
			if (GreaterThan(ref p10, ref p23)) { temp = p10; p10 = p23; p23 = temp; }
			if (GreaterThan(ref p11, ref p25)) { temp = p11; p11 = p25; p25 = temp; }
			if (GreaterThan(ref p12, ref p25)) { temp = p12; p12 = p25; p25 = temp; }
			if (GreaterThan(ref p11, ref p23)) { temp = p11; p11 = p23; p23 = temp; }
			if (GreaterThan(ref p12, ref p24)) { temp = p12; p12 = p24; p24 = temp; }
			if (GreaterThan(ref p12, ref p23)) { temp = p12; p12 = p23; p23 = temp; }
			if (GreaterThan(ref p9, ref p20)) { temp = p9; p9 = p20; p20 = temp; }
			if (GreaterThan(ref p10, ref p21)) { temp = p10; p10 = p21; p21 = temp; }
			if (GreaterThan(ref p10, ref p20)) { temp = p10; p10 = p20; p20 = temp; }
			if (GreaterThan(ref p11, ref p22)) { temp = p11; p11 = p22; p22 = temp; }
			if (GreaterThan(ref p12, ref p22)) { temp = p12; p12 = p22; p22 = temp; }
			if (GreaterThan(ref p11, ref p20)) { temp = p11; p11 = p20; p20 = temp; }
			if (GreaterThan(ref p12, ref p21)) { temp = p12; p12 = p21; p21 = temp; }
			if (GreaterThan(ref p12, ref p20)) { temp = p12; p12 = p20; p20 = temp; }
			if (GreaterThan(ref p6, ref p14)) { temp = p6; p6 = p14; p14 = temp; }
			if (GreaterThan(ref p6, ref p13)) { temp = p6; p6 = p13; p13 = temp; }
			if (GreaterThan(ref p7, ref p15)) { temp = p7; p7 = p15; p15 = temp; }
			if (GreaterThan(ref p8, ref p16)) { temp = p8; p8 = p16; p16 = temp; }
			if (GreaterThan(ref p8, ref p15)) { temp = p8; p8 = p15; p15 = temp; }
			if (GreaterThan(ref p7, ref p13)) { temp = p7; p7 = p13; p13 = temp; }
			if (GreaterThan(ref p8, ref p14)) { temp = p8; p8 = p14; p14 = temp; }
			if (GreaterThan(ref p8, ref p13)) { temp = p8; p8 = p13; p13 = temp; }
			if (GreaterThan(ref p9, ref p17)) { temp = p9; p9 = p17; p17 = temp; }
			if (GreaterThan(ref p10, ref p18)) { temp = p10; p10 = p18; p18 = temp; }
			if (GreaterThan(ref p10, ref p17)) { temp = p10; p10 = p17; p17 = temp; }
			if (GreaterThan(ref p11, ref p19)) { temp = p11; p11 = p19; p19 = temp; }
			if (GreaterThan(ref p12, ref p19)) { temp = p12; p12 = p19; p19 = temp; }
			if (GreaterThan(ref p11, ref p17)) { temp = p11; p11 = p17; p17 = temp; }
			if (GreaterThan(ref p12, ref p18)) { temp = p12; p12 = p18; p18 = temp; }
			if (GreaterThan(ref p12, ref p17)) { temp = p12; p12 = p17; p17 = temp; }
			if (GreaterThan(ref p9, ref p13)) { temp = p9; p9 = p13; p13 = temp; }
			if (GreaterThan(ref p10, ref p14)) { temp = p10; p10 = p14; p14 = temp; }
			if (GreaterThan(ref p10, ref p13)) { temp = p10; p10 = p13; p13 = temp; }
			if (GreaterThan(ref p11, ref p15)) { temp = p11; p11 = p15; p15 = temp; }
			if (GreaterThan(ref p12, ref p16)) { temp = p12; p12 = p16; p16 = temp; }
			if (GreaterThan(ref p12, ref p15)) { temp = p12; p12 = p15; p15 = temp; }
			if (GreaterThan(ref p11, ref p13)) { temp = p11; p11 = p13; p13 = temp; }
			if (GreaterThan(ref p12, ref p14)) { temp = p12; p12 = p14; p14 = temp; }
			if (GreaterThan(ref p12, ref p13)) { temp = p12; p12 = p13; p13 = temp; }
#endif
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
#if NETSTANDARD1_3
			if (p1.CompareTo(p2) > 0) { temp = p1; p1 = p2; p2 = temp; }
			if (p0.CompareTo(p2) > 0) { temp = p0; p0 = p2; p2 = temp; }
			if (p0.CompareTo(p1) > 0) { temp = p0; p0 = p1; p1 = temp; }
			if (p4.CompareTo(p5) > 0) { temp = p4; p4 = p5; p5 = temp; }
			if (p3.CompareTo(p5) > 0) { temp = p3; p3 = p5; p5 = temp; }
			if (p3.CompareTo(p4) > 0) { temp = p3; p3 = p4; p4 = temp; }
			if (p0.CompareTo(p4) > 0) { temp = p0; p0 = p4; p4 = temp; }
			if (p0.CompareTo(p3) > 0) { temp = p0; p0 = p3; p3 = temp; }
			if (p1.CompareTo(p5) > 0) { temp = p1; p1 = p5; p5 = temp; }
			if (p2.CompareTo(p5) > 0) { temp = p2; p2 = p5; p5 = temp; }
			if (p1.CompareTo(p3) > 0) { temp = p1; p1 = p3; p3 = temp; }
			if (p2.CompareTo(p4) > 0) { temp = p2; p2 = p4; p4 = temp; }
			if (p2.CompareTo(p3) > 0) { temp = p2; p2 = p3; p3 = temp; }
			if (p7.CompareTo(p8) > 0) { temp = p7; p7 = p8; p8 = temp; }
			if (p6.CompareTo(p8) > 0) { temp = p6; p6 = p8; p8 = temp; }
			if (p6.CompareTo(p7) > 0) { temp = p6; p6 = p7; p7 = temp; }
			if (p9.CompareTo(p10) > 0) { temp = p9; p9 = p10; p10 = temp; }
			if (p11.CompareTo(p12) > 0) { temp = p11; p11 = p12; p12 = temp; }
			if (p9.CompareTo(p11) > 0) { temp = p9; p9 = p11; p11 = temp; }
			if (p10.CompareTo(p12) > 0) { temp = p10; p10 = p12; p12 = temp; }
			if (p10.CompareTo(p11) > 0) { temp = p10; p10 = p11; p11 = temp; }
			if (p6.CompareTo(p10) > 0) { temp = p6; p6 = p10; p10 = temp; }
			if (p6.CompareTo(p9) > 0) { temp = p6; p6 = p9; p9 = temp; }
			if (p7.CompareTo(p11) > 0) { temp = p7; p7 = p11; p11 = temp; }
			if (p8.CompareTo(p12) > 0) { temp = p8; p8 = p12; p12 = temp; }
			if (p8.CompareTo(p11) > 0) { temp = p8; p8 = p11; p11 = temp; }
			if (p7.CompareTo(p9) > 0) { temp = p7; p7 = p9; p9 = temp; }
			if (p8.CompareTo(p10) > 0) { temp = p8; p8 = p10; p10 = temp; }
			if (p8.CompareTo(p9) > 0) { temp = p8; p8 = p9; p9 = temp; }
			if (p0.CompareTo(p7) > 0) { temp = p0; p0 = p7; p7 = temp; }
			if (p0.CompareTo(p6) > 0) { temp = p0; p0 = p6; p6 = temp; }
			if (p1.CompareTo(p8) > 0) { temp = p1; p1 = p8; p8 = temp; }
			if (p2.CompareTo(p9) > 0) { temp = p2; p2 = p9; p9 = temp; }
			if (p2.CompareTo(p8) > 0) { temp = p2; p2 = p8; p8 = temp; }
			if (p1.CompareTo(p6) > 0) { temp = p1; p1 = p6; p6 = temp; }
			if (p2.CompareTo(p7) > 0) { temp = p2; p2 = p7; p7 = temp; }
			if (p2.CompareTo(p6) > 0) { temp = p2; p2 = p6; p6 = temp; }
			if (p3.CompareTo(p11) > 0) { temp = p3; p3 = p11; p11 = temp; }
			if (p3.CompareTo(p10) > 0) { temp = p3; p3 = p10; p10 = temp; }
			if (p4.CompareTo(p12) > 0) { temp = p4; p4 = p12; p12 = temp; }
			if (p5.CompareTo(p12) > 0) { temp = p5; p5 = p12; p12 = temp; }
			if (p4.CompareTo(p10) > 0) { temp = p4; p4 = p10; p10 = temp; }
			if (p5.CompareTo(p11) > 0) { temp = p5; p5 = p11; p11 = temp; }
			if (p5.CompareTo(p10) > 0) { temp = p5; p5 = p10; p10 = temp; }
			if (p3.CompareTo(p7) > 0) { temp = p3; p3 = p7; p7 = temp; }
			if (p3.CompareTo(p6) > 0) { temp = p3; p3 = p6; p6 = temp; }
			if (p4.CompareTo(p8) > 0) { temp = p4; p4 = p8; p8 = temp; }
			if (p5.CompareTo(p9) > 0) { temp = p5; p5 = p9; p9 = temp; }
			if (p5.CompareTo(p8) > 0) { temp = p5; p5 = p8; p8 = temp; }
			if (p4.CompareTo(p6) > 0) { temp = p4; p4 = p6; p6 = temp; }
			if (p5.CompareTo(p7) > 0) { temp = p5; p5 = p7; p7 = temp; }
			if (p5.CompareTo(p6) > 0) { temp = p5; p5 = p6; p6 = temp; }
			if (p14.CompareTo(p15) > 0) { temp = p14; p14 = p15; p15 = temp; }
			if (p13.CompareTo(p15) > 0) { temp = p13; p13 = p15; p15 = temp; }
			if (p13.CompareTo(p14) > 0) { temp = p13; p13 = p14; p14 = temp; }
			if (p16.CompareTo(p17) > 0) { temp = p16; p16 = p17; p17 = temp; }
			if (p18.CompareTo(p19) > 0) { temp = p18; p18 = p19; p19 = temp; }
			if (p16.CompareTo(p18) > 0) { temp = p16; p16 = p18; p18 = temp; }
			if (p17.CompareTo(p19) > 0) { temp = p17; p17 = p19; p19 = temp; }
			if (p17.CompareTo(p18) > 0) { temp = p17; p17 = p18; p18 = temp; }
			if (p13.CompareTo(p17) > 0) { temp = p13; p13 = p17; p17 = temp; }
			if (p13.CompareTo(p16) > 0) { temp = p13; p13 = p16; p16 = temp; }
			if (p14.CompareTo(p18) > 0) { temp = p14; p14 = p18; p18 = temp; }
			if (p15.CompareTo(p19) > 0) { temp = p15; p15 = p19; p19 = temp; }
			if (p15.CompareTo(p18) > 0) { temp = p15; p15 = p18; p18 = temp; }
			if (p14.CompareTo(p16) > 0) { temp = p14; p14 = p16; p16 = temp; }
			if (p15.CompareTo(p17) > 0) { temp = p15; p15 = p17; p17 = temp; }
			if (p15.CompareTo(p16) > 0) { temp = p15; p15 = p16; p16 = temp; }
			if (p21.CompareTo(p22) > 0) { temp = p21; p21 = p22; p22 = temp; }
			if (p20.CompareTo(p22) > 0) { temp = p20; p20 = p22; p22 = temp; }
			if (p20.CompareTo(p21) > 0) { temp = p20; p20 = p21; p21 = temp; }
			if (p23.CompareTo(p24) > 0) { temp = p23; p23 = p24; p24 = temp; }
			if (p25.CompareTo(p26) > 0) { temp = p25; p25 = p26; p26 = temp; }
			if (p23.CompareTo(p25) > 0) { temp = p23; p23 = p25; p25 = temp; }
			if (p24.CompareTo(p26) > 0) { temp = p24; p24 = p26; p26 = temp; }
			if (p24.CompareTo(p25) > 0) { temp = p24; p24 = p25; p25 = temp; }
			if (p20.CompareTo(p24) > 0) { temp = p20; p20 = p24; p24 = temp; }
			if (p20.CompareTo(p23) > 0) { temp = p20; p20 = p23; p23 = temp; }
			if (p21.CompareTo(p25) > 0) { temp = p21; p21 = p25; p25 = temp; }
			if (p22.CompareTo(p26) > 0) { temp = p22; p22 = p26; p26 = temp; }
			if (p22.CompareTo(p25) > 0) { temp = p22; p22 = p25; p25 = temp; }
			if (p21.CompareTo(p23) > 0) { temp = p21; p21 = p23; p23 = temp; }
			if (p22.CompareTo(p24) > 0) { temp = p22; p22 = p24; p24 = temp; }
			if (p22.CompareTo(p23) > 0) { temp = p22; p22 = p23; p23 = temp; }
			if (p13.CompareTo(p21) > 0) { temp = p13; p13 = p21; p21 = temp; }
			if (p13.CompareTo(p20) > 0) { temp = p13; p13 = p20; p20 = temp; }
			if (p14.CompareTo(p22) > 0) { temp = p14; p14 = p22; p22 = temp; }
			if (p15.CompareTo(p23) > 0) { temp = p15; p15 = p23; p23 = temp; }
			if (p15.CompareTo(p22) > 0) { temp = p15; p15 = p22; p22 = temp; }
			if (p14.CompareTo(p20) > 0) { temp = p14; p14 = p20; p20 = temp; }
			if (p15.CompareTo(p21) > 0) { temp = p15; p15 = p21; p21 = temp; }
			if (p15.CompareTo(p20) > 0) { temp = p15; p15 = p20; p20 = temp; }
			if (p16.CompareTo(p24) > 0) { temp = p16; p16 = p24; p24 = temp; }
			if (p17.CompareTo(p25) > 0) { temp = p17; p17 = p25; p25 = temp; }
			if (p17.CompareTo(p24) > 0) { temp = p17; p17 = p24; p24 = temp; }
			if (p18.CompareTo(p26) > 0) { temp = p18; p18 = p26; p26 = temp; }
			if (p19.CompareTo(p26) > 0) { temp = p19; p19 = p26; p26 = temp; }
			if (p18.CompareTo(p24) > 0) { temp = p18; p18 = p24; p24 = temp; }
			if (p19.CompareTo(p25) > 0) { temp = p19; p19 = p25; p25 = temp; }
			if (p19.CompareTo(p24) > 0) { temp = p19; p19 = p24; p24 = temp; }
			if (p16.CompareTo(p20) > 0) { temp = p16; p16 = p20; p20 = temp; }
			if (p17.CompareTo(p21) > 0) { temp = p17; p17 = p21; p21 = temp; }
			if (p17.CompareTo(p20) > 0) { temp = p17; p17 = p20; p20 = temp; }
			if (p18.CompareTo(p22) > 0) { temp = p18; p18 = p22; p22 = temp; }
			if (p19.CompareTo(p23) > 0) { temp = p19; p19 = p23; p23 = temp; }
			if (p19.CompareTo(p22) > 0) { temp = p19; p19 = p22; p22 = temp; }
			if (p18.CompareTo(p20) > 0) { temp = p18; p18 = p20; p20 = temp; }
			if (p19.CompareTo(p21) > 0) { temp = p19; p19 = p21; p21 = temp; }
			if (p19.CompareTo(p20) > 0) { temp = p19; p19 = p20; p20 = temp; }
			if (p0.CompareTo(p14) > 0) { temp = p0; p0 = p14; p14 = temp; }
			if (p0.CompareTo(p13) > 0) { temp = p0; p0 = p13; p13 = temp; }
			if (p1.CompareTo(p15) > 0) { temp = p1; p1 = p15; p15 = temp; }
			if (p2.CompareTo(p16) > 0) { temp = p2; p2 = p16; p16 = temp; }
			if (p2.CompareTo(p15) > 0) { temp = p2; p2 = p15; p15 = temp; }
			if (p1.CompareTo(p13) > 0) { temp = p1; p1 = p13; p13 = temp; }
			if (p2.CompareTo(p14) > 0) { temp = p2; p2 = p14; p14 = temp; }
			if (p2.CompareTo(p13) > 0) { temp = p2; p2 = p13; p13 = temp; }
			if (p3.CompareTo(p18) > 0) { temp = p3; p3 = p18; p18 = temp; }
			if (p3.CompareTo(p17) > 0) { temp = p3; p3 = p17; p17 = temp; }
			if (p4.CompareTo(p19) > 0) { temp = p4; p4 = p19; p19 = temp; }
			if (p5.CompareTo(p19) > 0) { temp = p5; p5 = p19; p19 = temp; }
			if (p4.CompareTo(p17) > 0) { temp = p4; p4 = p17; p17 = temp; }
			if (p5.CompareTo(p18) > 0) { temp = p5; p5 = p18; p18 = temp; }
			if (p5.CompareTo(p17) > 0) { temp = p5; p5 = p17; p17 = temp; }
			if (p3.CompareTo(p14) > 0) { temp = p3; p3 = p14; p14 = temp; }
			if (p3.CompareTo(p13) > 0) { temp = p3; p3 = p13; p13 = temp; }
			if (p4.CompareTo(p15) > 0) { temp = p4; p4 = p15; p15 = temp; }
			if (p5.CompareTo(p16) > 0) { temp = p5; p5 = p16; p16 = temp; }
			if (p5.CompareTo(p15) > 0) { temp = p5; p5 = p15; p15 = temp; }
			if (p4.CompareTo(p13) > 0) { temp = p4; p4 = p13; p13 = temp; }
			if (p5.CompareTo(p14) > 0) { temp = p5; p5 = p14; p14 = temp; }
			if (p5.CompareTo(p13) > 0) { temp = p5; p5 = p13; p13 = temp; }
			if (p6.CompareTo(p21) > 0) { temp = p6; p6 = p21; p21 = temp; }
			if (p6.CompareTo(p20) > 0) { temp = p6; p6 = p20; p20 = temp; }
			if (p7.CompareTo(p22) > 0) { temp = p7; p7 = p22; p22 = temp; }
			if (p8.CompareTo(p23) > 0) { temp = p8; p8 = p23; p23 = temp; }
			if (p8.CompareTo(p22) > 0) { temp = p8; p8 = p22; p22 = temp; }
			if (p7.CompareTo(p20) > 0) { temp = p7; p7 = p20; p20 = temp; }
			if (p8.CompareTo(p21) > 0) { temp = p8; p8 = p21; p21 = temp; }
			if (p8.CompareTo(p20) > 0) { temp = p8; p8 = p20; p20 = temp; }
			if (p9.CompareTo(p24) > 0) { temp = p9; p9 = p24; p24 = temp; }
			if (p10.CompareTo(p25) > 0) { temp = p10; p10 = p25; p25 = temp; }
			if (p10.CompareTo(p24) > 0) { temp = p10; p10 = p24; p24 = temp; }
			if (p11.CompareTo(p26) > 0) { temp = p11; p11 = p26; p26 = temp; }
			if (p12.CompareTo(p26) > 0) { temp = p12; p12 = p26; p26 = temp; }
			if (p11.CompareTo(p24) > 0) { temp = p11; p11 = p24; p24 = temp; }
			if (p12.CompareTo(p25) > 0) { temp = p12; p12 = p25; p25 = temp; }
			if (p12.CompareTo(p24) > 0) { temp = p12; p12 = p24; p24 = temp; }
			if (p9.CompareTo(p20) > 0) { temp = p9; p9 = p20; p20 = temp; }
			if (p10.CompareTo(p21) > 0) { temp = p10; p10 = p21; p21 = temp; }
			if (p10.CompareTo(p20) > 0) { temp = p10; p10 = p20; p20 = temp; }
			if (p11.CompareTo(p22) > 0) { temp = p11; p11 = p22; p22 = temp; }
			if (p12.CompareTo(p23) > 0) { temp = p12; p12 = p23; p23 = temp; }
			if (p12.CompareTo(p22) > 0) { temp = p12; p12 = p22; p22 = temp; }
			if (p11.CompareTo(p20) > 0) { temp = p11; p11 = p20; p20 = temp; }
			if (p12.CompareTo(p21) > 0) { temp = p12; p12 = p21; p21 = temp; }
			if (p12.CompareTo(p20) > 0) { temp = p12; p12 = p20; p20 = temp; }
			if (p6.CompareTo(p14) > 0) { temp = p6; p6 = p14; p14 = temp; }
			if (p6.CompareTo(p13) > 0) { temp = p6; p6 = p13; p13 = temp; }
			if (p7.CompareTo(p15) > 0) { temp = p7; p7 = p15; p15 = temp; }
			if (p8.CompareTo(p16) > 0) { temp = p8; p8 = p16; p16 = temp; }
			if (p8.CompareTo(p15) > 0) { temp = p8; p8 = p15; p15 = temp; }
			if (p7.CompareTo(p13) > 0) { temp = p7; p7 = p13; p13 = temp; }
			if (p8.CompareTo(p14) > 0) { temp = p8; p8 = p14; p14 = temp; }
			if (p8.CompareTo(p13) > 0) { temp = p8; p8 = p13; p13 = temp; }
			if (p9.CompareTo(p17) > 0) { temp = p9; p9 = p17; p17 = temp; }
			if (p10.CompareTo(p18) > 0) { temp = p10; p10 = p18; p18 = temp; }
			if (p10.CompareTo(p17) > 0) { temp = p10; p10 = p17; p17 = temp; }
			if (p11.CompareTo(p19) > 0) { temp = p11; p11 = p19; p19 = temp; }
			if (p12.CompareTo(p19) > 0) { temp = p12; p12 = p19; p19 = temp; }
			if (p11.CompareTo(p17) > 0) { temp = p11; p11 = p17; p17 = temp; }
			if (p12.CompareTo(p18) > 0) { temp = p12; p12 = p18; p18 = temp; }
			if (p12.CompareTo(p17) > 0) { temp = p12; p12 = p17; p17 = temp; }
			if (p9.CompareTo(p13) > 0) { temp = p9; p9 = p13; p13 = temp; }
			if (p10.CompareTo(p14) > 0) { temp = p10; p10 = p14; p14 = temp; }
			if (p10.CompareTo(p13) > 0) { temp = p10; p10 = p13; p13 = temp; }
			if (p11.CompareTo(p15) > 0) { temp = p11; p11 = p15; p15 = temp; }
			if (p12.CompareTo(p16) > 0) { temp = p12; p12 = p16; p16 = temp; }
			if (p12.CompareTo(p15) > 0) { temp = p12; p12 = p15; p15 = temp; }
			if (p11.CompareTo(p13) > 0) { temp = p11; p11 = p13; p13 = temp; }
			if (p12.CompareTo(p14) > 0) { temp = p12; p12 = p14; p14 = temp; }
			if (p12.CompareTo(p13) > 0) { temp = p12; p12 = p13; p13 = temp; }
#else
			if (GreaterThan(ref p1, ref p2)) { temp = p1; p1 = p2; p2 = temp; }
			if (GreaterThan(ref p0, ref p2)) { temp = p0; p0 = p2; p2 = temp; }
			if (GreaterThan(ref p0, ref p1)) { temp = p0; p0 = p1; p1 = temp; }
			if (GreaterThan(ref p4, ref p5)) { temp = p4; p4 = p5; p5 = temp; }
			if (GreaterThan(ref p3, ref p5)) { temp = p3; p3 = p5; p5 = temp; }
			if (GreaterThan(ref p3, ref p4)) { temp = p3; p3 = p4; p4 = temp; }
			if (GreaterThan(ref p0, ref p4)) { temp = p0; p0 = p4; p4 = temp; }
			if (GreaterThan(ref p0, ref p3)) { temp = p0; p0 = p3; p3 = temp; }
			if (GreaterThan(ref p1, ref p5)) { temp = p1; p1 = p5; p5 = temp; }
			if (GreaterThan(ref p2, ref p5)) { temp = p2; p2 = p5; p5 = temp; }
			if (GreaterThan(ref p1, ref p3)) { temp = p1; p1 = p3; p3 = temp; }
			if (GreaterThan(ref p2, ref p4)) { temp = p2; p2 = p4; p4 = temp; }
			if (GreaterThan(ref p2, ref p3)) { temp = p2; p2 = p3; p3 = temp; }
			if (GreaterThan(ref p7, ref p8)) { temp = p7; p7 = p8; p8 = temp; }
			if (GreaterThan(ref p6, ref p8)) { temp = p6; p6 = p8; p8 = temp; }
			if (GreaterThan(ref p6, ref p7)) { temp = p6; p6 = p7; p7 = temp; }
			if (GreaterThan(ref p9, ref p10)) { temp = p9; p9 = p10; p10 = temp; }
			if (GreaterThan(ref p11, ref p12)) { temp = p11; p11 = p12; p12 = temp; }
			if (GreaterThan(ref p9, ref p11)) { temp = p9; p9 = p11; p11 = temp; }
			if (GreaterThan(ref p10, ref p12)) { temp = p10; p10 = p12; p12 = temp; }
			if (GreaterThan(ref p10, ref p11)) { temp = p10; p10 = p11; p11 = temp; }
			if (GreaterThan(ref p6, ref p10)) { temp = p6; p6 = p10; p10 = temp; }
			if (GreaterThan(ref p6, ref p9)) { temp = p6; p6 = p9; p9 = temp; }
			if (GreaterThan(ref p7, ref p11)) { temp = p7; p7 = p11; p11 = temp; }
			if (GreaterThan(ref p8, ref p12)) { temp = p8; p8 = p12; p12 = temp; }
			if (GreaterThan(ref p8, ref p11)) { temp = p8; p8 = p11; p11 = temp; }
			if (GreaterThan(ref p7, ref p9)) { temp = p7; p7 = p9; p9 = temp; }
			if (GreaterThan(ref p8, ref p10)) { temp = p8; p8 = p10; p10 = temp; }
			if (GreaterThan(ref p8, ref p9)) { temp = p8; p8 = p9; p9 = temp; }
			if (GreaterThan(ref p0, ref p7)) { temp = p0; p0 = p7; p7 = temp; }
			if (GreaterThan(ref p0, ref p6)) { temp = p0; p0 = p6; p6 = temp; }
			if (GreaterThan(ref p1, ref p8)) { temp = p1; p1 = p8; p8 = temp; }
			if (GreaterThan(ref p2, ref p9)) { temp = p2; p2 = p9; p9 = temp; }
			if (GreaterThan(ref p2, ref p8)) { temp = p2; p2 = p8; p8 = temp; }
			if (GreaterThan(ref p1, ref p6)) { temp = p1; p1 = p6; p6 = temp; }
			if (GreaterThan(ref p2, ref p7)) { temp = p2; p2 = p7; p7 = temp; }
			if (GreaterThan(ref p2, ref p6)) { temp = p2; p2 = p6; p6 = temp; }
			if (GreaterThan(ref p3, ref p11)) { temp = p3; p3 = p11; p11 = temp; }
			if (GreaterThan(ref p3, ref p10)) { temp = p3; p3 = p10; p10 = temp; }
			if (GreaterThan(ref p4, ref p12)) { temp = p4; p4 = p12; p12 = temp; }
			if (GreaterThan(ref p5, ref p12)) { temp = p5; p5 = p12; p12 = temp; }
			if (GreaterThan(ref p4, ref p10)) { temp = p4; p4 = p10; p10 = temp; }
			if (GreaterThan(ref p5, ref p11)) { temp = p5; p5 = p11; p11 = temp; }
			if (GreaterThan(ref p5, ref p10)) { temp = p5; p5 = p10; p10 = temp; }
			if (GreaterThan(ref p3, ref p7)) { temp = p3; p3 = p7; p7 = temp; }
			if (GreaterThan(ref p3, ref p6)) { temp = p3; p3 = p6; p6 = temp; }
			if (GreaterThan(ref p4, ref p8)) { temp = p4; p4 = p8; p8 = temp; }
			if (GreaterThan(ref p5, ref p9)) { temp = p5; p5 = p9; p9 = temp; }
			if (GreaterThan(ref p5, ref p8)) { temp = p5; p5 = p8; p8 = temp; }
			if (GreaterThan(ref p4, ref p6)) { temp = p4; p4 = p6; p6 = temp; }
			if (GreaterThan(ref p5, ref p7)) { temp = p5; p5 = p7; p7 = temp; }
			if (GreaterThan(ref p5, ref p6)) { temp = p5; p5 = p6; p6 = temp; }
			if (GreaterThan(ref p14, ref p15)) { temp = p14; p14 = p15; p15 = temp; }
			if (GreaterThan(ref p13, ref p15)) { temp = p13; p13 = p15; p15 = temp; }
			if (GreaterThan(ref p13, ref p14)) { temp = p13; p13 = p14; p14 = temp; }
			if (GreaterThan(ref p16, ref p17)) { temp = p16; p16 = p17; p17 = temp; }
			if (GreaterThan(ref p18, ref p19)) { temp = p18; p18 = p19; p19 = temp; }
			if (GreaterThan(ref p16, ref p18)) { temp = p16; p16 = p18; p18 = temp; }
			if (GreaterThan(ref p17, ref p19)) { temp = p17; p17 = p19; p19 = temp; }
			if (GreaterThan(ref p17, ref p18)) { temp = p17; p17 = p18; p18 = temp; }
			if (GreaterThan(ref p13, ref p17)) { temp = p13; p13 = p17; p17 = temp; }
			if (GreaterThan(ref p13, ref p16)) { temp = p13; p13 = p16; p16 = temp; }
			if (GreaterThan(ref p14, ref p18)) { temp = p14; p14 = p18; p18 = temp; }
			if (GreaterThan(ref p15, ref p19)) { temp = p15; p15 = p19; p19 = temp; }
			if (GreaterThan(ref p15, ref p18)) { temp = p15; p15 = p18; p18 = temp; }
			if (GreaterThan(ref p14, ref p16)) { temp = p14; p14 = p16; p16 = temp; }
			if (GreaterThan(ref p15, ref p17)) { temp = p15; p15 = p17; p17 = temp; }
			if (GreaterThan(ref p15, ref p16)) { temp = p15; p15 = p16; p16 = temp; }
			if (GreaterThan(ref p21, ref p22)) { temp = p21; p21 = p22; p22 = temp; }
			if (GreaterThan(ref p20, ref p22)) { temp = p20; p20 = p22; p22 = temp; }
			if (GreaterThan(ref p20, ref p21)) { temp = p20; p20 = p21; p21 = temp; }
			if (GreaterThan(ref p23, ref p24)) { temp = p23; p23 = p24; p24 = temp; }
			if (GreaterThan(ref p25, ref p26)) { temp = p25; p25 = p26; p26 = temp; }
			if (GreaterThan(ref p23, ref p25)) { temp = p23; p23 = p25; p25 = temp; }
			if (GreaterThan(ref p24, ref p26)) { temp = p24; p24 = p26; p26 = temp; }
			if (GreaterThan(ref p24, ref p25)) { temp = p24; p24 = p25; p25 = temp; }
			if (GreaterThan(ref p20, ref p24)) { temp = p20; p20 = p24; p24 = temp; }
			if (GreaterThan(ref p20, ref p23)) { temp = p20; p20 = p23; p23 = temp; }
			if (GreaterThan(ref p21, ref p25)) { temp = p21; p21 = p25; p25 = temp; }
			if (GreaterThan(ref p22, ref p26)) { temp = p22; p22 = p26; p26 = temp; }
			if (GreaterThan(ref p22, ref p25)) { temp = p22; p22 = p25; p25 = temp; }
			if (GreaterThan(ref p21, ref p23)) { temp = p21; p21 = p23; p23 = temp; }
			if (GreaterThan(ref p22, ref p24)) { temp = p22; p22 = p24; p24 = temp; }
			if (GreaterThan(ref p22, ref p23)) { temp = p22; p22 = p23; p23 = temp; }
			if (GreaterThan(ref p13, ref p21)) { temp = p13; p13 = p21; p21 = temp; }
			if (GreaterThan(ref p13, ref p20)) { temp = p13; p13 = p20; p20 = temp; }
			if (GreaterThan(ref p14, ref p22)) { temp = p14; p14 = p22; p22 = temp; }
			if (GreaterThan(ref p15, ref p23)) { temp = p15; p15 = p23; p23 = temp; }
			if (GreaterThan(ref p15, ref p22)) { temp = p15; p15 = p22; p22 = temp; }
			if (GreaterThan(ref p14, ref p20)) { temp = p14; p14 = p20; p20 = temp; }
			if (GreaterThan(ref p15, ref p21)) { temp = p15; p15 = p21; p21 = temp; }
			if (GreaterThan(ref p15, ref p20)) { temp = p15; p15 = p20; p20 = temp; }
			if (GreaterThan(ref p16, ref p24)) { temp = p16; p16 = p24; p24 = temp; }
			if (GreaterThan(ref p17, ref p25)) { temp = p17; p17 = p25; p25 = temp; }
			if (GreaterThan(ref p17, ref p24)) { temp = p17; p17 = p24; p24 = temp; }
			if (GreaterThan(ref p18, ref p26)) { temp = p18; p18 = p26; p26 = temp; }
			if (GreaterThan(ref p19, ref p26)) { temp = p19; p19 = p26; p26 = temp; }
			if (GreaterThan(ref p18, ref p24)) { temp = p18; p18 = p24; p24 = temp; }
			if (GreaterThan(ref p19, ref p25)) { temp = p19; p19 = p25; p25 = temp; }
			if (GreaterThan(ref p19, ref p24)) { temp = p19; p19 = p24; p24 = temp; }
			if (GreaterThan(ref p16, ref p20)) { temp = p16; p16 = p20; p20 = temp; }
			if (GreaterThan(ref p17, ref p21)) { temp = p17; p17 = p21; p21 = temp; }
			if (GreaterThan(ref p17, ref p20)) { temp = p17; p17 = p20; p20 = temp; }
			if (GreaterThan(ref p18, ref p22)) { temp = p18; p18 = p22; p22 = temp; }
			if (GreaterThan(ref p19, ref p23)) { temp = p19; p19 = p23; p23 = temp; }
			if (GreaterThan(ref p19, ref p22)) { temp = p19; p19 = p22; p22 = temp; }
			if (GreaterThan(ref p18, ref p20)) { temp = p18; p18 = p20; p20 = temp; }
			if (GreaterThan(ref p19, ref p21)) { temp = p19; p19 = p21; p21 = temp; }
			if (GreaterThan(ref p19, ref p20)) { temp = p19; p19 = p20; p20 = temp; }
			if (GreaterThan(ref p0, ref p14)) { temp = p0; p0 = p14; p14 = temp; }
			if (GreaterThan(ref p0, ref p13)) { temp = p0; p0 = p13; p13 = temp; }
			if (GreaterThan(ref p1, ref p15)) { temp = p1; p1 = p15; p15 = temp; }
			if (GreaterThan(ref p2, ref p16)) { temp = p2; p2 = p16; p16 = temp; }
			if (GreaterThan(ref p2, ref p15)) { temp = p2; p2 = p15; p15 = temp; }
			if (GreaterThan(ref p1, ref p13)) { temp = p1; p1 = p13; p13 = temp; }
			if (GreaterThan(ref p2, ref p14)) { temp = p2; p2 = p14; p14 = temp; }
			if (GreaterThan(ref p2, ref p13)) { temp = p2; p2 = p13; p13 = temp; }
			if (GreaterThan(ref p3, ref p18)) { temp = p3; p3 = p18; p18 = temp; }
			if (GreaterThan(ref p3, ref p17)) { temp = p3; p3 = p17; p17 = temp; }
			if (GreaterThan(ref p4, ref p19)) { temp = p4; p4 = p19; p19 = temp; }
			if (GreaterThan(ref p5, ref p19)) { temp = p5; p5 = p19; p19 = temp; }
			if (GreaterThan(ref p4, ref p17)) { temp = p4; p4 = p17; p17 = temp; }
			if (GreaterThan(ref p5, ref p18)) { temp = p5; p5 = p18; p18 = temp; }
			if (GreaterThan(ref p5, ref p17)) { temp = p5; p5 = p17; p17 = temp; }
			if (GreaterThan(ref p3, ref p14)) { temp = p3; p3 = p14; p14 = temp; }
			if (GreaterThan(ref p3, ref p13)) { temp = p3; p3 = p13; p13 = temp; }
			if (GreaterThan(ref p4, ref p15)) { temp = p4; p4 = p15; p15 = temp; }
			if (GreaterThan(ref p5, ref p16)) { temp = p5; p5 = p16; p16 = temp; }
			if (GreaterThan(ref p5, ref p15)) { temp = p5; p5 = p15; p15 = temp; }
			if (GreaterThan(ref p4, ref p13)) { temp = p4; p4 = p13; p13 = temp; }
			if (GreaterThan(ref p5, ref p14)) { temp = p5; p5 = p14; p14 = temp; }
			if (GreaterThan(ref p5, ref p13)) { temp = p5; p5 = p13; p13 = temp; }
			if (GreaterThan(ref p6, ref p21)) { temp = p6; p6 = p21; p21 = temp; }
			if (GreaterThan(ref p6, ref p20)) { temp = p6; p6 = p20; p20 = temp; }
			if (GreaterThan(ref p7, ref p22)) { temp = p7; p7 = p22; p22 = temp; }
			if (GreaterThan(ref p8, ref p23)) { temp = p8; p8 = p23; p23 = temp; }
			if (GreaterThan(ref p8, ref p22)) { temp = p8; p8 = p22; p22 = temp; }
			if (GreaterThan(ref p7, ref p20)) { temp = p7; p7 = p20; p20 = temp; }
			if (GreaterThan(ref p8, ref p21)) { temp = p8; p8 = p21; p21 = temp; }
			if (GreaterThan(ref p8, ref p20)) { temp = p8; p8 = p20; p20 = temp; }
			if (GreaterThan(ref p9, ref p24)) { temp = p9; p9 = p24; p24 = temp; }
			if (GreaterThan(ref p10, ref p25)) { temp = p10; p10 = p25; p25 = temp; }
			if (GreaterThan(ref p10, ref p24)) { temp = p10; p10 = p24; p24 = temp; }
			if (GreaterThan(ref p11, ref p26)) { temp = p11; p11 = p26; p26 = temp; }
			if (GreaterThan(ref p12, ref p26)) { temp = p12; p12 = p26; p26 = temp; }
			if (GreaterThan(ref p11, ref p24)) { temp = p11; p11 = p24; p24 = temp; }
			if (GreaterThan(ref p12, ref p25)) { temp = p12; p12 = p25; p25 = temp; }
			if (GreaterThan(ref p12, ref p24)) { temp = p12; p12 = p24; p24 = temp; }
			if (GreaterThan(ref p9, ref p20)) { temp = p9; p9 = p20; p20 = temp; }
			if (GreaterThan(ref p10, ref p21)) { temp = p10; p10 = p21; p21 = temp; }
			if (GreaterThan(ref p10, ref p20)) { temp = p10; p10 = p20; p20 = temp; }
			if (GreaterThan(ref p11, ref p22)) { temp = p11; p11 = p22; p22 = temp; }
			if (GreaterThan(ref p12, ref p23)) { temp = p12; p12 = p23; p23 = temp; }
			if (GreaterThan(ref p12, ref p22)) { temp = p12; p12 = p22; p22 = temp; }
			if (GreaterThan(ref p11, ref p20)) { temp = p11; p11 = p20; p20 = temp; }
			if (GreaterThan(ref p12, ref p21)) { temp = p12; p12 = p21; p21 = temp; }
			if (GreaterThan(ref p12, ref p20)) { temp = p12; p12 = p20; p20 = temp; }
			if (GreaterThan(ref p6, ref p14)) { temp = p6; p6 = p14; p14 = temp; }
			if (GreaterThan(ref p6, ref p13)) { temp = p6; p6 = p13; p13 = temp; }
			if (GreaterThan(ref p7, ref p15)) { temp = p7; p7 = p15; p15 = temp; }
			if (GreaterThan(ref p8, ref p16)) { temp = p8; p8 = p16; p16 = temp; }
			if (GreaterThan(ref p8, ref p15)) { temp = p8; p8 = p15; p15 = temp; }
			if (GreaterThan(ref p7, ref p13)) { temp = p7; p7 = p13; p13 = temp; }
			if (GreaterThan(ref p8, ref p14)) { temp = p8; p8 = p14; p14 = temp; }
			if (GreaterThan(ref p8, ref p13)) { temp = p8; p8 = p13; p13 = temp; }
			if (GreaterThan(ref p9, ref p17)) { temp = p9; p9 = p17; p17 = temp; }
			if (GreaterThan(ref p10, ref p18)) { temp = p10; p10 = p18; p18 = temp; }
			if (GreaterThan(ref p10, ref p17)) { temp = p10; p10 = p17; p17 = temp; }
			if (GreaterThan(ref p11, ref p19)) { temp = p11; p11 = p19; p19 = temp; }
			if (GreaterThan(ref p12, ref p19)) { temp = p12; p12 = p19; p19 = temp; }
			if (GreaterThan(ref p11, ref p17)) { temp = p11; p11 = p17; p17 = temp; }
			if (GreaterThan(ref p12, ref p18)) { temp = p12; p12 = p18; p18 = temp; }
			if (GreaterThan(ref p12, ref p17)) { temp = p12; p12 = p17; p17 = temp; }
			if (GreaterThan(ref p9, ref p13)) { temp = p9; p9 = p13; p13 = temp; }
			if (GreaterThan(ref p10, ref p14)) { temp = p10; p10 = p14; p14 = temp; }
			if (GreaterThan(ref p10, ref p13)) { temp = p10; p10 = p13; p13 = temp; }
			if (GreaterThan(ref p11, ref p15)) { temp = p11; p11 = p15; p15 = temp; }
			if (GreaterThan(ref p12, ref p16)) { temp = p12; p12 = p16; p16 = temp; }
			if (GreaterThan(ref p12, ref p15)) { temp = p12; p12 = p15; p15 = temp; }
			if (GreaterThan(ref p11, ref p13)) { temp = p11; p11 = p13; p13 = temp; }
			if (GreaterThan(ref p12, ref p14)) { temp = p12; p12 = p14; p14 = temp; }
			if (GreaterThan(ref p12, ref p13)) { temp = p12; p12 = p13; p13 = temp; }
#endif
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
#if NETSTANDARD1_3
			if (p1.CompareTo(p2) > 0) { temp = p1; p1 = p2; p2 = temp; }
			if (p0.CompareTo(p2) > 0) { temp = p0; p0 = p2; p2 = temp; }
			if (p0.CompareTo(p1) > 0) { temp = p0; p0 = p1; p1 = temp; }
			if (p3.CompareTo(p4) > 0) { temp = p3; p3 = p4; p4 = temp; }
			if (p5.CompareTo(p6) > 0) { temp = p5; p5 = p6; p6 = temp; }
			if (p3.CompareTo(p5) > 0) { temp = p3; p3 = p5; p5 = temp; }
			if (p4.CompareTo(p6) > 0) { temp = p4; p4 = p6; p6 = temp; }
			if (p4.CompareTo(p5) > 0) { temp = p4; p4 = p5; p5 = temp; }
			if (p0.CompareTo(p4) > 0) { temp = p0; p0 = p4; p4 = temp; }
			if (p0.CompareTo(p3) > 0) { temp = p0; p0 = p3; p3 = temp; }
			if (p1.CompareTo(p5) > 0) { temp = p1; p1 = p5; p5 = temp; }
			if (p2.CompareTo(p6) > 0) { temp = p2; p2 = p6; p6 = temp; }
			if (p2.CompareTo(p5) > 0) { temp = p2; p2 = p5; p5 = temp; }
			if (p1.CompareTo(p3) > 0) { temp = p1; p1 = p3; p3 = temp; }
			if (p2.CompareTo(p4) > 0) { temp = p2; p2 = p4; p4 = temp; }
			if (p2.CompareTo(p3) > 0) { temp = p2; p2 = p3; p3 = temp; }
			if (p8.CompareTo(p9) > 0) { temp = p8; p8 = p9; p9 = temp; }
			if (p7.CompareTo(p9) > 0) { temp = p7; p7 = p9; p9 = temp; }
			if (p7.CompareTo(p8) > 0) { temp = p7; p7 = p8; p8 = temp; }
			if (p10.CompareTo(p11) > 0) { temp = p10; p10 = p11; p11 = temp; }
			if (p12.CompareTo(p13) > 0) { temp = p12; p12 = p13; p13 = temp; }
			if (p10.CompareTo(p12) > 0) { temp = p10; p10 = p12; p12 = temp; }
			if (p11.CompareTo(p13) > 0) { temp = p11; p11 = p13; p13 = temp; }
			if (p11.CompareTo(p12) > 0) { temp = p11; p11 = p12; p12 = temp; }
			if (p7.CompareTo(p11) > 0) { temp = p7; p7 = p11; p11 = temp; }
			if (p7.CompareTo(p10) > 0) { temp = p7; p7 = p10; p10 = temp; }
			if (p8.CompareTo(p12) > 0) { temp = p8; p8 = p12; p12 = temp; }
			if (p9.CompareTo(p13) > 0) { temp = p9; p9 = p13; p13 = temp; }
			if (p9.CompareTo(p12) > 0) { temp = p9; p9 = p12; p12 = temp; }
			if (p8.CompareTo(p10) > 0) { temp = p8; p8 = p10; p10 = temp; }
			if (p9.CompareTo(p11) > 0) { temp = p9; p9 = p11; p11 = temp; }
			if (p9.CompareTo(p10) > 0) { temp = p9; p9 = p10; p10 = temp; }
			if (p0.CompareTo(p8) > 0) { temp = p0; p0 = p8; p8 = temp; }
			if (p0.CompareTo(p7) > 0) { temp = p0; p0 = p7; p7 = temp; }
			if (p1.CompareTo(p9) > 0) { temp = p1; p1 = p9; p9 = temp; }
			if (p2.CompareTo(p10) > 0) { temp = p2; p2 = p10; p10 = temp; }
			if (p2.CompareTo(p9) > 0) { temp = p2; p2 = p9; p9 = temp; }
			if (p1.CompareTo(p7) > 0) { temp = p1; p1 = p7; p7 = temp; }
			if (p2.CompareTo(p8) > 0) { temp = p2; p2 = p8; p8 = temp; }
			if (p2.CompareTo(p7) > 0) { temp = p2; p2 = p7; p7 = temp; }
			if (p3.CompareTo(p11) > 0) { temp = p3; p3 = p11; p11 = temp; }
			if (p4.CompareTo(p12) > 0) { temp = p4; p4 = p12; p12 = temp; }
			if (p4.CompareTo(p11) > 0) { temp = p4; p4 = p11; p11 = temp; }
			if (p5.CompareTo(p13) > 0) { temp = p5; p5 = p13; p13 = temp; }
			if (p6.CompareTo(p13) > 0) { temp = p6; p6 = p13; p13 = temp; }
			if (p5.CompareTo(p11) > 0) { temp = p5; p5 = p11; p11 = temp; }
			if (p6.CompareTo(p12) > 0) { temp = p6; p6 = p12; p12 = temp; }
			if (p6.CompareTo(p11) > 0) { temp = p6; p6 = p11; p11 = temp; }
			if (p3.CompareTo(p7) > 0) { temp = p3; p3 = p7; p7 = temp; }
			if (p4.CompareTo(p8) > 0) { temp = p4; p4 = p8; p8 = temp; }
			if (p4.CompareTo(p7) > 0) { temp = p4; p4 = p7; p7 = temp; }
			if (p5.CompareTo(p9) > 0) { temp = p5; p5 = p9; p9 = temp; }
			if (p6.CompareTo(p10) > 0) { temp = p6; p6 = p10; p10 = temp; }
			if (p6.CompareTo(p9) > 0) { temp = p6; p6 = p9; p9 = temp; }
			if (p5.CompareTo(p7) > 0) { temp = p5; p5 = p7; p7 = temp; }
			if (p6.CompareTo(p8) > 0) { temp = p6; p6 = p8; p8 = temp; }
			if (p6.CompareTo(p7) > 0) { temp = p6; p6 = p7; p7 = temp; }
			if (p15.CompareTo(p16) > 0) { temp = p15; p15 = p16; p16 = temp; }
			if (p14.CompareTo(p16) > 0) { temp = p14; p14 = p16; p16 = temp; }
			if (p14.CompareTo(p15) > 0) { temp = p14; p14 = p15; p15 = temp; }
			if (p17.CompareTo(p18) > 0) { temp = p17; p17 = p18; p18 = temp; }
			if (p19.CompareTo(p20) > 0) { temp = p19; p19 = p20; p20 = temp; }
			if (p17.CompareTo(p19) > 0) { temp = p17; p17 = p19; p19 = temp; }
			if (p18.CompareTo(p20) > 0) { temp = p18; p18 = p20; p20 = temp; }
			if (p18.CompareTo(p19) > 0) { temp = p18; p18 = p19; p19 = temp; }
			if (p14.CompareTo(p18) > 0) { temp = p14; p14 = p18; p18 = temp; }
			if (p14.CompareTo(p17) > 0) { temp = p14; p14 = p17; p17 = temp; }
			if (p15.CompareTo(p19) > 0) { temp = p15; p15 = p19; p19 = temp; }
			if (p16.CompareTo(p20) > 0) { temp = p16; p16 = p20; p20 = temp; }
			if (p16.CompareTo(p19) > 0) { temp = p16; p16 = p19; p19 = temp; }
			if (p15.CompareTo(p17) > 0) { temp = p15; p15 = p17; p17 = temp; }
			if (p16.CompareTo(p18) > 0) { temp = p16; p16 = p18; p18 = temp; }
			if (p16.CompareTo(p17) > 0) { temp = p16; p16 = p17; p17 = temp; }
			if (p22.CompareTo(p23) > 0) { temp = p22; p22 = p23; p23 = temp; }
			if (p21.CompareTo(p23) > 0) { temp = p21; p21 = p23; p23 = temp; }
			if (p21.CompareTo(p22) > 0) { temp = p21; p21 = p22; p22 = temp; }
			if (p24.CompareTo(p25) > 0) { temp = p24; p24 = p25; p25 = temp; }
			if (p26.CompareTo(p27) > 0) { temp = p26; p26 = p27; p27 = temp; }
			if (p24.CompareTo(p26) > 0) { temp = p24; p24 = p26; p26 = temp; }
			if (p25.CompareTo(p27) > 0) { temp = p25; p25 = p27; p27 = temp; }
			if (p25.CompareTo(p26) > 0) { temp = p25; p25 = p26; p26 = temp; }
			if (p21.CompareTo(p25) > 0) { temp = p21; p21 = p25; p25 = temp; }
			if (p21.CompareTo(p24) > 0) { temp = p21; p21 = p24; p24 = temp; }
			if (p22.CompareTo(p26) > 0) { temp = p22; p22 = p26; p26 = temp; }
			if (p23.CompareTo(p27) > 0) { temp = p23; p23 = p27; p27 = temp; }
			if (p23.CompareTo(p26) > 0) { temp = p23; p23 = p26; p26 = temp; }
			if (p22.CompareTo(p24) > 0) { temp = p22; p22 = p24; p24 = temp; }
			if (p23.CompareTo(p25) > 0) { temp = p23; p23 = p25; p25 = temp; }
			if (p23.CompareTo(p24) > 0) { temp = p23; p23 = p24; p24 = temp; }
			if (p14.CompareTo(p22) > 0) { temp = p14; p14 = p22; p22 = temp; }
			if (p14.CompareTo(p21) > 0) { temp = p14; p14 = p21; p21 = temp; }
			if (p15.CompareTo(p23) > 0) { temp = p15; p15 = p23; p23 = temp; }
			if (p16.CompareTo(p24) > 0) { temp = p16; p16 = p24; p24 = temp; }
			if (p16.CompareTo(p23) > 0) { temp = p16; p16 = p23; p23 = temp; }
			if (p15.CompareTo(p21) > 0) { temp = p15; p15 = p21; p21 = temp; }
			if (p16.CompareTo(p22) > 0) { temp = p16; p16 = p22; p22 = temp; }
			if (p16.CompareTo(p21) > 0) { temp = p16; p16 = p21; p21 = temp; }
			if (p17.CompareTo(p25) > 0) { temp = p17; p17 = p25; p25 = temp; }
			if (p18.CompareTo(p26) > 0) { temp = p18; p18 = p26; p26 = temp; }
			if (p18.CompareTo(p25) > 0) { temp = p18; p18 = p25; p25 = temp; }
			if (p19.CompareTo(p27) > 0) { temp = p19; p19 = p27; p27 = temp; }
			if (p20.CompareTo(p27) > 0) { temp = p20; p20 = p27; p27 = temp; }
			if (p19.CompareTo(p25) > 0) { temp = p19; p19 = p25; p25 = temp; }
			if (p20.CompareTo(p26) > 0) { temp = p20; p20 = p26; p26 = temp; }
			if (p20.CompareTo(p25) > 0) { temp = p20; p20 = p25; p25 = temp; }
			if (p17.CompareTo(p21) > 0) { temp = p17; p17 = p21; p21 = temp; }
			if (p18.CompareTo(p22) > 0) { temp = p18; p18 = p22; p22 = temp; }
			if (p18.CompareTo(p21) > 0) { temp = p18; p18 = p21; p21 = temp; }
			if (p19.CompareTo(p23) > 0) { temp = p19; p19 = p23; p23 = temp; }
			if (p20.CompareTo(p24) > 0) { temp = p20; p20 = p24; p24 = temp; }
			if (p20.CompareTo(p23) > 0) { temp = p20; p20 = p23; p23 = temp; }
			if (p19.CompareTo(p21) > 0) { temp = p19; p19 = p21; p21 = temp; }
			if (p20.CompareTo(p22) > 0) { temp = p20; p20 = p22; p22 = temp; }
			if (p20.CompareTo(p21) > 0) { temp = p20; p20 = p21; p21 = temp; }
			if (p0.CompareTo(p15) > 0) { temp = p0; p0 = p15; p15 = temp; }
			if (p0.CompareTo(p14) > 0) { temp = p0; p0 = p14; p14 = temp; }
			if (p1.CompareTo(p16) > 0) { temp = p1; p1 = p16; p16 = temp; }
			if (p2.CompareTo(p17) > 0) { temp = p2; p2 = p17; p17 = temp; }
			if (p2.CompareTo(p16) > 0) { temp = p2; p2 = p16; p16 = temp; }
			if (p1.CompareTo(p14) > 0) { temp = p1; p1 = p14; p14 = temp; }
			if (p2.CompareTo(p15) > 0) { temp = p2; p2 = p15; p15 = temp; }
			if (p2.CompareTo(p14) > 0) { temp = p2; p2 = p14; p14 = temp; }
			if (p3.CompareTo(p18) > 0) { temp = p3; p3 = p18; p18 = temp; }
			if (p4.CompareTo(p19) > 0) { temp = p4; p4 = p19; p19 = temp; }
			if (p4.CompareTo(p18) > 0) { temp = p4; p4 = p18; p18 = temp; }
			if (p5.CompareTo(p20) > 0) { temp = p5; p5 = p20; p20 = temp; }
			if (p6.CompareTo(p20) > 0) { temp = p6; p6 = p20; p20 = temp; }
			if (p5.CompareTo(p18) > 0) { temp = p5; p5 = p18; p18 = temp; }
			if (p6.CompareTo(p19) > 0) { temp = p6; p6 = p19; p19 = temp; }
			if (p6.CompareTo(p18) > 0) { temp = p6; p6 = p18; p18 = temp; }
			if (p3.CompareTo(p14) > 0) { temp = p3; p3 = p14; p14 = temp; }
			if (p4.CompareTo(p15) > 0) { temp = p4; p4 = p15; p15 = temp; }
			if (p4.CompareTo(p14) > 0) { temp = p4; p4 = p14; p14 = temp; }
			if (p5.CompareTo(p16) > 0) { temp = p5; p5 = p16; p16 = temp; }
			if (p6.CompareTo(p17) > 0) { temp = p6; p6 = p17; p17 = temp; }
			if (p6.CompareTo(p16) > 0) { temp = p6; p6 = p16; p16 = temp; }
			if (p5.CompareTo(p14) > 0) { temp = p5; p5 = p14; p14 = temp; }
			if (p6.CompareTo(p15) > 0) { temp = p6; p6 = p15; p15 = temp; }
			if (p6.CompareTo(p14) > 0) { temp = p6; p6 = p14; p14 = temp; }
			if (p7.CompareTo(p22) > 0) { temp = p7; p7 = p22; p22 = temp; }
			if (p7.CompareTo(p21) > 0) { temp = p7; p7 = p21; p21 = temp; }
			if (p8.CompareTo(p23) > 0) { temp = p8; p8 = p23; p23 = temp; }
			if (p9.CompareTo(p24) > 0) { temp = p9; p9 = p24; p24 = temp; }
			if (p9.CompareTo(p23) > 0) { temp = p9; p9 = p23; p23 = temp; }
			if (p8.CompareTo(p21) > 0) { temp = p8; p8 = p21; p21 = temp; }
			if (p9.CompareTo(p22) > 0) { temp = p9; p9 = p22; p22 = temp; }
			if (p9.CompareTo(p21) > 0) { temp = p9; p9 = p21; p21 = temp; }
			if (p10.CompareTo(p25) > 0) { temp = p10; p10 = p25; p25 = temp; }
			if (p11.CompareTo(p26) > 0) { temp = p11; p11 = p26; p26 = temp; }
			if (p11.CompareTo(p25) > 0) { temp = p11; p11 = p25; p25 = temp; }
			if (p12.CompareTo(p27) > 0) { temp = p12; p12 = p27; p27 = temp; }
			if (p13.CompareTo(p27) > 0) { temp = p13; p13 = p27; p27 = temp; }
			if (p12.CompareTo(p25) > 0) { temp = p12; p12 = p25; p25 = temp; }
			if (p13.CompareTo(p26) > 0) { temp = p13; p13 = p26; p26 = temp; }
			if (p13.CompareTo(p25) > 0) { temp = p13; p13 = p25; p25 = temp; }
			if (p10.CompareTo(p21) > 0) { temp = p10; p10 = p21; p21 = temp; }
			if (p11.CompareTo(p22) > 0) { temp = p11; p11 = p22; p22 = temp; }
			if (p11.CompareTo(p21) > 0) { temp = p11; p11 = p21; p21 = temp; }
			if (p12.CompareTo(p23) > 0) { temp = p12; p12 = p23; p23 = temp; }
			if (p13.CompareTo(p24) > 0) { temp = p13; p13 = p24; p24 = temp; }
			if (p13.CompareTo(p23) > 0) { temp = p13; p13 = p23; p23 = temp; }
			if (p12.CompareTo(p21) > 0) { temp = p12; p12 = p21; p21 = temp; }
			if (p13.CompareTo(p22) > 0) { temp = p13; p13 = p22; p22 = temp; }
			if (p13.CompareTo(p21) > 0) { temp = p13; p13 = p21; p21 = temp; }
			if (p7.CompareTo(p15) > 0) { temp = p7; p7 = p15; p15 = temp; }
			if (p7.CompareTo(p14) > 0) { temp = p7; p7 = p14; p14 = temp; }
			if (p8.CompareTo(p16) > 0) { temp = p8; p8 = p16; p16 = temp; }
			if (p9.CompareTo(p17) > 0) { temp = p9; p9 = p17; p17 = temp; }
			if (p9.CompareTo(p16) > 0) { temp = p9; p9 = p16; p16 = temp; }
			if (p8.CompareTo(p14) > 0) { temp = p8; p8 = p14; p14 = temp; }
			if (p9.CompareTo(p15) > 0) { temp = p9; p9 = p15; p15 = temp; }
			if (p9.CompareTo(p14) > 0) { temp = p9; p9 = p14; p14 = temp; }
			if (p10.CompareTo(p18) > 0) { temp = p10; p10 = p18; p18 = temp; }
			if (p11.CompareTo(p19) > 0) { temp = p11; p11 = p19; p19 = temp; }
			if (p11.CompareTo(p18) > 0) { temp = p11; p11 = p18; p18 = temp; }
			if (p12.CompareTo(p20) > 0) { temp = p12; p12 = p20; p20 = temp; }
			if (p13.CompareTo(p20) > 0) { temp = p13; p13 = p20; p20 = temp; }
			if (p12.CompareTo(p18) > 0) { temp = p12; p12 = p18; p18 = temp; }
			if (p13.CompareTo(p19) > 0) { temp = p13; p13 = p19; p19 = temp; }
			if (p13.CompareTo(p18) > 0) { temp = p13; p13 = p18; p18 = temp; }
			if (p10.CompareTo(p14) > 0) { temp = p10; p10 = p14; p14 = temp; }
			if (p11.CompareTo(p15) > 0) { temp = p11; p11 = p15; p15 = temp; }
			if (p11.CompareTo(p14) > 0) { temp = p11; p11 = p14; p14 = temp; }
			if (p12.CompareTo(p16) > 0) { temp = p12; p12 = p16; p16 = temp; }
			if (p13.CompareTo(p17) > 0) { temp = p13; p13 = p17; p17 = temp; }
			if (p13.CompareTo(p16) > 0) { temp = p13; p13 = p16; p16 = temp; }
			if (p12.CompareTo(p14) > 0) { temp = p12; p12 = p14; p14 = temp; }
			if (p13.CompareTo(p15) > 0) { temp = p13; p13 = p15; p15 = temp; }
			if (p13.CompareTo(p14) > 0) { temp = p13; p13 = p14; p14 = temp; }
#else
			if (GreaterThan(ref p1, ref p2)) { temp = p1; p1 = p2; p2 = temp; }
			if (GreaterThan(ref p0, ref p2)) { temp = p0; p0 = p2; p2 = temp; }
			if (GreaterThan(ref p0, ref p1)) { temp = p0; p0 = p1; p1 = temp; }
			if (GreaterThan(ref p3, ref p4)) { temp = p3; p3 = p4; p4 = temp; }
			if (GreaterThan(ref p5, ref p6)) { temp = p5; p5 = p6; p6 = temp; }
			if (GreaterThan(ref p3, ref p5)) { temp = p3; p3 = p5; p5 = temp; }
			if (GreaterThan(ref p4, ref p6)) { temp = p4; p4 = p6; p6 = temp; }
			if (GreaterThan(ref p4, ref p5)) { temp = p4; p4 = p5; p5 = temp; }
			if (GreaterThan(ref p0, ref p4)) { temp = p0; p0 = p4; p4 = temp; }
			if (GreaterThan(ref p0, ref p3)) { temp = p0; p0 = p3; p3 = temp; }
			if (GreaterThan(ref p1, ref p5)) { temp = p1; p1 = p5; p5 = temp; }
			if (GreaterThan(ref p2, ref p6)) { temp = p2; p2 = p6; p6 = temp; }
			if (GreaterThan(ref p2, ref p5)) { temp = p2; p2 = p5; p5 = temp; }
			if (GreaterThan(ref p1, ref p3)) { temp = p1; p1 = p3; p3 = temp; }
			if (GreaterThan(ref p2, ref p4)) { temp = p2; p2 = p4; p4 = temp; }
			if (GreaterThan(ref p2, ref p3)) { temp = p2; p2 = p3; p3 = temp; }
			if (GreaterThan(ref p8, ref p9)) { temp = p8; p8 = p9; p9 = temp; }
			if (GreaterThan(ref p7, ref p9)) { temp = p7; p7 = p9; p9 = temp; }
			if (GreaterThan(ref p7, ref p8)) { temp = p7; p7 = p8; p8 = temp; }
			if (GreaterThan(ref p10, ref p11)) { temp = p10; p10 = p11; p11 = temp; }
			if (GreaterThan(ref p12, ref p13)) { temp = p12; p12 = p13; p13 = temp; }
			if (GreaterThan(ref p10, ref p12)) { temp = p10; p10 = p12; p12 = temp; }
			if (GreaterThan(ref p11, ref p13)) { temp = p11; p11 = p13; p13 = temp; }
			if (GreaterThan(ref p11, ref p12)) { temp = p11; p11 = p12; p12 = temp; }
			if (GreaterThan(ref p7, ref p11)) { temp = p7; p7 = p11; p11 = temp; }
			if (GreaterThan(ref p7, ref p10)) { temp = p7; p7 = p10; p10 = temp; }
			if (GreaterThan(ref p8, ref p12)) { temp = p8; p8 = p12; p12 = temp; }
			if (GreaterThan(ref p9, ref p13)) { temp = p9; p9 = p13; p13 = temp; }
			if (GreaterThan(ref p9, ref p12)) { temp = p9; p9 = p12; p12 = temp; }
			if (GreaterThan(ref p8, ref p10)) { temp = p8; p8 = p10; p10 = temp; }
			if (GreaterThan(ref p9, ref p11)) { temp = p9; p9 = p11; p11 = temp; }
			if (GreaterThan(ref p9, ref p10)) { temp = p9; p9 = p10; p10 = temp; }
			if (GreaterThan(ref p0, ref p8)) { temp = p0; p0 = p8; p8 = temp; }
			if (GreaterThan(ref p0, ref p7)) { temp = p0; p0 = p7; p7 = temp; }
			if (GreaterThan(ref p1, ref p9)) { temp = p1; p1 = p9; p9 = temp; }
			if (GreaterThan(ref p2, ref p10)) { temp = p2; p2 = p10; p10 = temp; }
			if (GreaterThan(ref p2, ref p9)) { temp = p2; p2 = p9; p9 = temp; }
			if (GreaterThan(ref p1, ref p7)) { temp = p1; p1 = p7; p7 = temp; }
			if (GreaterThan(ref p2, ref p8)) { temp = p2; p2 = p8; p8 = temp; }
			if (GreaterThan(ref p2, ref p7)) { temp = p2; p2 = p7; p7 = temp; }
			if (GreaterThan(ref p3, ref p11)) { temp = p3; p3 = p11; p11 = temp; }
			if (GreaterThan(ref p4, ref p12)) { temp = p4; p4 = p12; p12 = temp; }
			if (GreaterThan(ref p4, ref p11)) { temp = p4; p4 = p11; p11 = temp; }
			if (GreaterThan(ref p5, ref p13)) { temp = p5; p5 = p13; p13 = temp; }
			if (GreaterThan(ref p6, ref p13)) { temp = p6; p6 = p13; p13 = temp; }
			if (GreaterThan(ref p5, ref p11)) { temp = p5; p5 = p11; p11 = temp; }
			if (GreaterThan(ref p6, ref p12)) { temp = p6; p6 = p12; p12 = temp; }
			if (GreaterThan(ref p6, ref p11)) { temp = p6; p6 = p11; p11 = temp; }
			if (GreaterThan(ref p3, ref p7)) { temp = p3; p3 = p7; p7 = temp; }
			if (GreaterThan(ref p4, ref p8)) { temp = p4; p4 = p8; p8 = temp; }
			if (GreaterThan(ref p4, ref p7)) { temp = p4; p4 = p7; p7 = temp; }
			if (GreaterThan(ref p5, ref p9)) { temp = p5; p5 = p9; p9 = temp; }
			if (GreaterThan(ref p6, ref p10)) { temp = p6; p6 = p10; p10 = temp; }
			if (GreaterThan(ref p6, ref p9)) { temp = p6; p6 = p9; p9 = temp; }
			if (GreaterThan(ref p5, ref p7)) { temp = p5; p5 = p7; p7 = temp; }
			if (GreaterThan(ref p6, ref p8)) { temp = p6; p6 = p8; p8 = temp; }
			if (GreaterThan(ref p6, ref p7)) { temp = p6; p6 = p7; p7 = temp; }
			if (GreaterThan(ref p15, ref p16)) { temp = p15; p15 = p16; p16 = temp; }
			if (GreaterThan(ref p14, ref p16)) { temp = p14; p14 = p16; p16 = temp; }
			if (GreaterThan(ref p14, ref p15)) { temp = p14; p14 = p15; p15 = temp; }
			if (GreaterThan(ref p17, ref p18)) { temp = p17; p17 = p18; p18 = temp; }
			if (GreaterThan(ref p19, ref p20)) { temp = p19; p19 = p20; p20 = temp; }
			if (GreaterThan(ref p17, ref p19)) { temp = p17; p17 = p19; p19 = temp; }
			if (GreaterThan(ref p18, ref p20)) { temp = p18; p18 = p20; p20 = temp; }
			if (GreaterThan(ref p18, ref p19)) { temp = p18; p18 = p19; p19 = temp; }
			if (GreaterThan(ref p14, ref p18)) { temp = p14; p14 = p18; p18 = temp; }
			if (GreaterThan(ref p14, ref p17)) { temp = p14; p14 = p17; p17 = temp; }
			if (GreaterThan(ref p15, ref p19)) { temp = p15; p15 = p19; p19 = temp; }
			if (GreaterThan(ref p16, ref p20)) { temp = p16; p16 = p20; p20 = temp; }
			if (GreaterThan(ref p16, ref p19)) { temp = p16; p16 = p19; p19 = temp; }
			if (GreaterThan(ref p15, ref p17)) { temp = p15; p15 = p17; p17 = temp; }
			if (GreaterThan(ref p16, ref p18)) { temp = p16; p16 = p18; p18 = temp; }
			if (GreaterThan(ref p16, ref p17)) { temp = p16; p16 = p17; p17 = temp; }
			if (GreaterThan(ref p22, ref p23)) { temp = p22; p22 = p23; p23 = temp; }
			if (GreaterThan(ref p21, ref p23)) { temp = p21; p21 = p23; p23 = temp; }
			if (GreaterThan(ref p21, ref p22)) { temp = p21; p21 = p22; p22 = temp; }
			if (GreaterThan(ref p24, ref p25)) { temp = p24; p24 = p25; p25 = temp; }
			if (GreaterThan(ref p26, ref p27)) { temp = p26; p26 = p27; p27 = temp; }
			if (GreaterThan(ref p24, ref p26)) { temp = p24; p24 = p26; p26 = temp; }
			if (GreaterThan(ref p25, ref p27)) { temp = p25; p25 = p27; p27 = temp; }
			if (GreaterThan(ref p25, ref p26)) { temp = p25; p25 = p26; p26 = temp; }
			if (GreaterThan(ref p21, ref p25)) { temp = p21; p21 = p25; p25 = temp; }
			if (GreaterThan(ref p21, ref p24)) { temp = p21; p21 = p24; p24 = temp; }
			if (GreaterThan(ref p22, ref p26)) { temp = p22; p22 = p26; p26 = temp; }
			if (GreaterThan(ref p23, ref p27)) { temp = p23; p23 = p27; p27 = temp; }
			if (GreaterThan(ref p23, ref p26)) { temp = p23; p23 = p26; p26 = temp; }
			if (GreaterThan(ref p22, ref p24)) { temp = p22; p22 = p24; p24 = temp; }
			if (GreaterThan(ref p23, ref p25)) { temp = p23; p23 = p25; p25 = temp; }
			if (GreaterThan(ref p23, ref p24)) { temp = p23; p23 = p24; p24 = temp; }
			if (GreaterThan(ref p14, ref p22)) { temp = p14; p14 = p22; p22 = temp; }
			if (GreaterThan(ref p14, ref p21)) { temp = p14; p14 = p21; p21 = temp; }
			if (GreaterThan(ref p15, ref p23)) { temp = p15; p15 = p23; p23 = temp; }
			if (GreaterThan(ref p16, ref p24)) { temp = p16; p16 = p24; p24 = temp; }
			if (GreaterThan(ref p16, ref p23)) { temp = p16; p16 = p23; p23 = temp; }
			if (GreaterThan(ref p15, ref p21)) { temp = p15; p15 = p21; p21 = temp; }
			if (GreaterThan(ref p16, ref p22)) { temp = p16; p16 = p22; p22 = temp; }
			if (GreaterThan(ref p16, ref p21)) { temp = p16; p16 = p21; p21 = temp; }
			if (GreaterThan(ref p17, ref p25)) { temp = p17; p17 = p25; p25 = temp; }
			if (GreaterThan(ref p18, ref p26)) { temp = p18; p18 = p26; p26 = temp; }
			if (GreaterThan(ref p18, ref p25)) { temp = p18; p18 = p25; p25 = temp; }
			if (GreaterThan(ref p19, ref p27)) { temp = p19; p19 = p27; p27 = temp; }
			if (GreaterThan(ref p20, ref p27)) { temp = p20; p20 = p27; p27 = temp; }
			if (GreaterThan(ref p19, ref p25)) { temp = p19; p19 = p25; p25 = temp; }
			if (GreaterThan(ref p20, ref p26)) { temp = p20; p20 = p26; p26 = temp; }
			if (GreaterThan(ref p20, ref p25)) { temp = p20; p20 = p25; p25 = temp; }
			if (GreaterThan(ref p17, ref p21)) { temp = p17; p17 = p21; p21 = temp; }
			if (GreaterThan(ref p18, ref p22)) { temp = p18; p18 = p22; p22 = temp; }
			if (GreaterThan(ref p18, ref p21)) { temp = p18; p18 = p21; p21 = temp; }
			if (GreaterThan(ref p19, ref p23)) { temp = p19; p19 = p23; p23 = temp; }
			if (GreaterThan(ref p20, ref p24)) { temp = p20; p20 = p24; p24 = temp; }
			if (GreaterThan(ref p20, ref p23)) { temp = p20; p20 = p23; p23 = temp; }
			if (GreaterThan(ref p19, ref p21)) { temp = p19; p19 = p21; p21 = temp; }
			if (GreaterThan(ref p20, ref p22)) { temp = p20; p20 = p22; p22 = temp; }
			if (GreaterThan(ref p20, ref p21)) { temp = p20; p20 = p21; p21 = temp; }
			if (GreaterThan(ref p0, ref p15)) { temp = p0; p0 = p15; p15 = temp; }
			if (GreaterThan(ref p0, ref p14)) { temp = p0; p0 = p14; p14 = temp; }
			if (GreaterThan(ref p1, ref p16)) { temp = p1; p1 = p16; p16 = temp; }
			if (GreaterThan(ref p2, ref p17)) { temp = p2; p2 = p17; p17 = temp; }
			if (GreaterThan(ref p2, ref p16)) { temp = p2; p2 = p16; p16 = temp; }
			if (GreaterThan(ref p1, ref p14)) { temp = p1; p1 = p14; p14 = temp; }
			if (GreaterThan(ref p2, ref p15)) { temp = p2; p2 = p15; p15 = temp; }
			if (GreaterThan(ref p2, ref p14)) { temp = p2; p2 = p14; p14 = temp; }
			if (GreaterThan(ref p3, ref p18)) { temp = p3; p3 = p18; p18 = temp; }
			if (GreaterThan(ref p4, ref p19)) { temp = p4; p4 = p19; p19 = temp; }
			if (GreaterThan(ref p4, ref p18)) { temp = p4; p4 = p18; p18 = temp; }
			if (GreaterThan(ref p5, ref p20)) { temp = p5; p5 = p20; p20 = temp; }
			if (GreaterThan(ref p6, ref p20)) { temp = p6; p6 = p20; p20 = temp; }
			if (GreaterThan(ref p5, ref p18)) { temp = p5; p5 = p18; p18 = temp; }
			if (GreaterThan(ref p6, ref p19)) { temp = p6; p6 = p19; p19 = temp; }
			if (GreaterThan(ref p6, ref p18)) { temp = p6; p6 = p18; p18 = temp; }
			if (GreaterThan(ref p3, ref p14)) { temp = p3; p3 = p14; p14 = temp; }
			if (GreaterThan(ref p4, ref p15)) { temp = p4; p4 = p15; p15 = temp; }
			if (GreaterThan(ref p4, ref p14)) { temp = p4; p4 = p14; p14 = temp; }
			if (GreaterThan(ref p5, ref p16)) { temp = p5; p5 = p16; p16 = temp; }
			if (GreaterThan(ref p6, ref p17)) { temp = p6; p6 = p17; p17 = temp; }
			if (GreaterThan(ref p6, ref p16)) { temp = p6; p6 = p16; p16 = temp; }
			if (GreaterThan(ref p5, ref p14)) { temp = p5; p5 = p14; p14 = temp; }
			if (GreaterThan(ref p6, ref p15)) { temp = p6; p6 = p15; p15 = temp; }
			if (GreaterThan(ref p6, ref p14)) { temp = p6; p6 = p14; p14 = temp; }
			if (GreaterThan(ref p7, ref p22)) { temp = p7; p7 = p22; p22 = temp; }
			if (GreaterThan(ref p7, ref p21)) { temp = p7; p7 = p21; p21 = temp; }
			if (GreaterThan(ref p8, ref p23)) { temp = p8; p8 = p23; p23 = temp; }
			if (GreaterThan(ref p9, ref p24)) { temp = p9; p9 = p24; p24 = temp; }
			if (GreaterThan(ref p9, ref p23)) { temp = p9; p9 = p23; p23 = temp; }
			if (GreaterThan(ref p8, ref p21)) { temp = p8; p8 = p21; p21 = temp; }
			if (GreaterThan(ref p9, ref p22)) { temp = p9; p9 = p22; p22 = temp; }
			if (GreaterThan(ref p9, ref p21)) { temp = p9; p9 = p21; p21 = temp; }
			if (GreaterThan(ref p10, ref p25)) { temp = p10; p10 = p25; p25 = temp; }
			if (GreaterThan(ref p11, ref p26)) { temp = p11; p11 = p26; p26 = temp; }
			if (GreaterThan(ref p11, ref p25)) { temp = p11; p11 = p25; p25 = temp; }
			if (GreaterThan(ref p12, ref p27)) { temp = p12; p12 = p27; p27 = temp; }
			if (GreaterThan(ref p13, ref p27)) { temp = p13; p13 = p27; p27 = temp; }
			if (GreaterThan(ref p12, ref p25)) { temp = p12; p12 = p25; p25 = temp; }
			if (GreaterThan(ref p13, ref p26)) { temp = p13; p13 = p26; p26 = temp; }
			if (GreaterThan(ref p13, ref p25)) { temp = p13; p13 = p25; p25 = temp; }
			if (GreaterThan(ref p10, ref p21)) { temp = p10; p10 = p21; p21 = temp; }
			if (GreaterThan(ref p11, ref p22)) { temp = p11; p11 = p22; p22 = temp; }
			if (GreaterThan(ref p11, ref p21)) { temp = p11; p11 = p21; p21 = temp; }
			if (GreaterThan(ref p12, ref p23)) { temp = p12; p12 = p23; p23 = temp; }
			if (GreaterThan(ref p13, ref p24)) { temp = p13; p13 = p24; p24 = temp; }
			if (GreaterThan(ref p13, ref p23)) { temp = p13; p13 = p23; p23 = temp; }
			if (GreaterThan(ref p12, ref p21)) { temp = p12; p12 = p21; p21 = temp; }
			if (GreaterThan(ref p13, ref p22)) { temp = p13; p13 = p22; p22 = temp; }
			if (GreaterThan(ref p13, ref p21)) { temp = p13; p13 = p21; p21 = temp; }
			if (GreaterThan(ref p7, ref p15)) { temp = p7; p7 = p15; p15 = temp; }
			if (GreaterThan(ref p7, ref p14)) { temp = p7; p7 = p14; p14 = temp; }
			if (GreaterThan(ref p8, ref p16)) { temp = p8; p8 = p16; p16 = temp; }
			if (GreaterThan(ref p9, ref p17)) { temp = p9; p9 = p17; p17 = temp; }
			if (GreaterThan(ref p9, ref p16)) { temp = p9; p9 = p16; p16 = temp; }
			if (GreaterThan(ref p8, ref p14)) { temp = p8; p8 = p14; p14 = temp; }
			if (GreaterThan(ref p9, ref p15)) { temp = p9; p9 = p15; p15 = temp; }
			if (GreaterThan(ref p9, ref p14)) { temp = p9; p9 = p14; p14 = temp; }
			if (GreaterThan(ref p10, ref p18)) { temp = p10; p10 = p18; p18 = temp; }
			if (GreaterThan(ref p11, ref p19)) { temp = p11; p11 = p19; p19 = temp; }
			if (GreaterThan(ref p11, ref p18)) { temp = p11; p11 = p18; p18 = temp; }
			if (GreaterThan(ref p12, ref p20)) { temp = p12; p12 = p20; p20 = temp; }
			if (GreaterThan(ref p13, ref p20)) { temp = p13; p13 = p20; p20 = temp; }
			if (GreaterThan(ref p12, ref p18)) { temp = p12; p12 = p18; p18 = temp; }
			if (GreaterThan(ref p13, ref p19)) { temp = p13; p13 = p19; p19 = temp; }
			if (GreaterThan(ref p13, ref p18)) { temp = p13; p13 = p18; p18 = temp; }
			if (GreaterThan(ref p10, ref p14)) { temp = p10; p10 = p14; p14 = temp; }
			if (GreaterThan(ref p11, ref p15)) { temp = p11; p11 = p15; p15 = temp; }
			if (GreaterThan(ref p11, ref p14)) { temp = p11; p11 = p14; p14 = temp; }
			if (GreaterThan(ref p12, ref p16)) { temp = p12; p12 = p16; p16 = temp; }
			if (GreaterThan(ref p13, ref p17)) { temp = p13; p13 = p17; p17 = temp; }
			if (GreaterThan(ref p13, ref p16)) { temp = p13; p13 = p16; p16 = temp; }
			if (GreaterThan(ref p12, ref p14)) { temp = p12; p12 = p14; p14 = temp; }
			if (GreaterThan(ref p13, ref p15)) { temp = p13; p13 = p15; p15 = temp; }
			if (GreaterThan(ref p13, ref p14)) { temp = p13; p13 = p14; p14 = temp; }
#endif
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
#if NETSTANDARD1_3
			if (p1.CompareTo(p2) > 0) { temp = p1; p1 = p2; p2 = temp; }
			if (p0.CompareTo(p2) > 0) { temp = p0; p0 = p2; p2 = temp; }
			if (p0.CompareTo(p1) > 0) { temp = p0; p0 = p1; p1 = temp; }
			if (p3.CompareTo(p4) > 0) { temp = p3; p3 = p4; p4 = temp; }
			if (p5.CompareTo(p6) > 0) { temp = p5; p5 = p6; p6 = temp; }
			if (p3.CompareTo(p5) > 0) { temp = p3; p3 = p5; p5 = temp; }
			if (p4.CompareTo(p6) > 0) { temp = p4; p4 = p6; p6 = temp; }
			if (p4.CompareTo(p5) > 0) { temp = p4; p4 = p5; p5 = temp; }
			if (p0.CompareTo(p4) > 0) { temp = p0; p0 = p4; p4 = temp; }
			if (p0.CompareTo(p3) > 0) { temp = p0; p0 = p3; p3 = temp; }
			if (p1.CompareTo(p5) > 0) { temp = p1; p1 = p5; p5 = temp; }
			if (p2.CompareTo(p6) > 0) { temp = p2; p2 = p6; p6 = temp; }
			if (p2.CompareTo(p5) > 0) { temp = p2; p2 = p5; p5 = temp; }
			if (p1.CompareTo(p3) > 0) { temp = p1; p1 = p3; p3 = temp; }
			if (p2.CompareTo(p4) > 0) { temp = p2; p2 = p4; p4 = temp; }
			if (p2.CompareTo(p3) > 0) { temp = p2; p2 = p3; p3 = temp; }
			if (p8.CompareTo(p9) > 0) { temp = p8; p8 = p9; p9 = temp; }
			if (p7.CompareTo(p9) > 0) { temp = p7; p7 = p9; p9 = temp; }
			if (p7.CompareTo(p8) > 0) { temp = p7; p7 = p8; p8 = temp; }
			if (p10.CompareTo(p11) > 0) { temp = p10; p10 = p11; p11 = temp; }
			if (p12.CompareTo(p13) > 0) { temp = p12; p12 = p13; p13 = temp; }
			if (p10.CompareTo(p12) > 0) { temp = p10; p10 = p12; p12 = temp; }
			if (p11.CompareTo(p13) > 0) { temp = p11; p11 = p13; p13 = temp; }
			if (p11.CompareTo(p12) > 0) { temp = p11; p11 = p12; p12 = temp; }
			if (p7.CompareTo(p11) > 0) { temp = p7; p7 = p11; p11 = temp; }
			if (p7.CompareTo(p10) > 0) { temp = p7; p7 = p10; p10 = temp; }
			if (p8.CompareTo(p12) > 0) { temp = p8; p8 = p12; p12 = temp; }
			if (p9.CompareTo(p13) > 0) { temp = p9; p9 = p13; p13 = temp; }
			if (p9.CompareTo(p12) > 0) { temp = p9; p9 = p12; p12 = temp; }
			if (p8.CompareTo(p10) > 0) { temp = p8; p8 = p10; p10 = temp; }
			if (p9.CompareTo(p11) > 0) { temp = p9; p9 = p11; p11 = temp; }
			if (p9.CompareTo(p10) > 0) { temp = p9; p9 = p10; p10 = temp; }
			if (p0.CompareTo(p8) > 0) { temp = p0; p0 = p8; p8 = temp; }
			if (p0.CompareTo(p7) > 0) { temp = p0; p0 = p7; p7 = temp; }
			if (p1.CompareTo(p9) > 0) { temp = p1; p1 = p9; p9 = temp; }
			if (p2.CompareTo(p10) > 0) { temp = p2; p2 = p10; p10 = temp; }
			if (p2.CompareTo(p9) > 0) { temp = p2; p2 = p9; p9 = temp; }
			if (p1.CompareTo(p7) > 0) { temp = p1; p1 = p7; p7 = temp; }
			if (p2.CompareTo(p8) > 0) { temp = p2; p2 = p8; p8 = temp; }
			if (p2.CompareTo(p7) > 0) { temp = p2; p2 = p7; p7 = temp; }
			if (p3.CompareTo(p11) > 0) { temp = p3; p3 = p11; p11 = temp; }
			if (p4.CompareTo(p12) > 0) { temp = p4; p4 = p12; p12 = temp; }
			if (p4.CompareTo(p11) > 0) { temp = p4; p4 = p11; p11 = temp; }
			if (p5.CompareTo(p13) > 0) { temp = p5; p5 = p13; p13 = temp; }
			if (p6.CompareTo(p13) > 0) { temp = p6; p6 = p13; p13 = temp; }
			if (p5.CompareTo(p11) > 0) { temp = p5; p5 = p11; p11 = temp; }
			if (p6.CompareTo(p12) > 0) { temp = p6; p6 = p12; p12 = temp; }
			if (p6.CompareTo(p11) > 0) { temp = p6; p6 = p11; p11 = temp; }
			if (p3.CompareTo(p7) > 0) { temp = p3; p3 = p7; p7 = temp; }
			if (p4.CompareTo(p8) > 0) { temp = p4; p4 = p8; p8 = temp; }
			if (p4.CompareTo(p7) > 0) { temp = p4; p4 = p7; p7 = temp; }
			if (p5.CompareTo(p9) > 0) { temp = p5; p5 = p9; p9 = temp; }
			if (p6.CompareTo(p10) > 0) { temp = p6; p6 = p10; p10 = temp; }
			if (p6.CompareTo(p9) > 0) { temp = p6; p6 = p9; p9 = temp; }
			if (p5.CompareTo(p7) > 0) { temp = p5; p5 = p7; p7 = temp; }
			if (p6.CompareTo(p8) > 0) { temp = p6; p6 = p8; p8 = temp; }
			if (p6.CompareTo(p7) > 0) { temp = p6; p6 = p7; p7 = temp; }
			if (p15.CompareTo(p16) > 0) { temp = p15; p15 = p16; p16 = temp; }
			if (p14.CompareTo(p16) > 0) { temp = p14; p14 = p16; p16 = temp; }
			if (p14.CompareTo(p15) > 0) { temp = p14; p14 = p15; p15 = temp; }
			if (p17.CompareTo(p18) > 0) { temp = p17; p17 = p18; p18 = temp; }
			if (p19.CompareTo(p20) > 0) { temp = p19; p19 = p20; p20 = temp; }
			if (p17.CompareTo(p19) > 0) { temp = p17; p17 = p19; p19 = temp; }
			if (p18.CompareTo(p20) > 0) { temp = p18; p18 = p20; p20 = temp; }
			if (p18.CompareTo(p19) > 0) { temp = p18; p18 = p19; p19 = temp; }
			if (p14.CompareTo(p18) > 0) { temp = p14; p14 = p18; p18 = temp; }
			if (p14.CompareTo(p17) > 0) { temp = p14; p14 = p17; p17 = temp; }
			if (p15.CompareTo(p19) > 0) { temp = p15; p15 = p19; p19 = temp; }
			if (p16.CompareTo(p20) > 0) { temp = p16; p16 = p20; p20 = temp; }
			if (p16.CompareTo(p19) > 0) { temp = p16; p16 = p19; p19 = temp; }
			if (p15.CompareTo(p17) > 0) { temp = p15; p15 = p17; p17 = temp; }
			if (p16.CompareTo(p18) > 0) { temp = p16; p16 = p18; p18 = temp; }
			if (p16.CompareTo(p17) > 0) { temp = p16; p16 = p17; p17 = temp; }
			if (p21.CompareTo(p22) > 0) { temp = p21; p21 = p22; p22 = temp; }
			if (p23.CompareTo(p24) > 0) { temp = p23; p23 = p24; p24 = temp; }
			if (p21.CompareTo(p23) > 0) { temp = p21; p21 = p23; p23 = temp; }
			if (p22.CompareTo(p24) > 0) { temp = p22; p22 = p24; p24 = temp; }
			if (p22.CompareTo(p23) > 0) { temp = p22; p22 = p23; p23 = temp; }
			if (p25.CompareTo(p26) > 0) { temp = p25; p25 = p26; p26 = temp; }
			if (p27.CompareTo(p28) > 0) { temp = p27; p27 = p28; p28 = temp; }
			if (p25.CompareTo(p27) > 0) { temp = p25; p25 = p27; p27 = temp; }
			if (p26.CompareTo(p28) > 0) { temp = p26; p26 = p28; p28 = temp; }
			if (p26.CompareTo(p27) > 0) { temp = p26; p26 = p27; p27 = temp; }
			if (p21.CompareTo(p25) > 0) { temp = p21; p21 = p25; p25 = temp; }
			if (p22.CompareTo(p26) > 0) { temp = p22; p22 = p26; p26 = temp; }
			if (p22.CompareTo(p25) > 0) { temp = p22; p22 = p25; p25 = temp; }
			if (p23.CompareTo(p27) > 0) { temp = p23; p23 = p27; p27 = temp; }
			if (p24.CompareTo(p28) > 0) { temp = p24; p24 = p28; p28 = temp; }
			if (p24.CompareTo(p27) > 0) { temp = p24; p24 = p27; p27 = temp; }
			if (p23.CompareTo(p25) > 0) { temp = p23; p23 = p25; p25 = temp; }
			if (p24.CompareTo(p26) > 0) { temp = p24; p24 = p26; p26 = temp; }
			if (p24.CompareTo(p25) > 0) { temp = p24; p24 = p25; p25 = temp; }
			if (p14.CompareTo(p22) > 0) { temp = p14; p14 = p22; p22 = temp; }
			if (p14.CompareTo(p21) > 0) { temp = p14; p14 = p21; p21 = temp; }
			if (p15.CompareTo(p23) > 0) { temp = p15; p15 = p23; p23 = temp; }
			if (p16.CompareTo(p24) > 0) { temp = p16; p16 = p24; p24 = temp; }
			if (p16.CompareTo(p23) > 0) { temp = p16; p16 = p23; p23 = temp; }
			if (p15.CompareTo(p21) > 0) { temp = p15; p15 = p21; p21 = temp; }
			if (p16.CompareTo(p22) > 0) { temp = p16; p16 = p22; p22 = temp; }
			if (p16.CompareTo(p21) > 0) { temp = p16; p16 = p21; p21 = temp; }
			if (p17.CompareTo(p25) > 0) { temp = p17; p17 = p25; p25 = temp; }
			if (p18.CompareTo(p26) > 0) { temp = p18; p18 = p26; p26 = temp; }
			if (p18.CompareTo(p25) > 0) { temp = p18; p18 = p25; p25 = temp; }
			if (p19.CompareTo(p27) > 0) { temp = p19; p19 = p27; p27 = temp; }
			if (p20.CompareTo(p28) > 0) { temp = p20; p20 = p28; p28 = temp; }
			if (p20.CompareTo(p27) > 0) { temp = p20; p20 = p27; p27 = temp; }
			if (p19.CompareTo(p25) > 0) { temp = p19; p19 = p25; p25 = temp; }
			if (p20.CompareTo(p26) > 0) { temp = p20; p20 = p26; p26 = temp; }
			if (p20.CompareTo(p25) > 0) { temp = p20; p20 = p25; p25 = temp; }
			if (p17.CompareTo(p21) > 0) { temp = p17; p17 = p21; p21 = temp; }
			if (p18.CompareTo(p22) > 0) { temp = p18; p18 = p22; p22 = temp; }
			if (p18.CompareTo(p21) > 0) { temp = p18; p18 = p21; p21 = temp; }
			if (p19.CompareTo(p23) > 0) { temp = p19; p19 = p23; p23 = temp; }
			if (p20.CompareTo(p24) > 0) { temp = p20; p20 = p24; p24 = temp; }
			if (p20.CompareTo(p23) > 0) { temp = p20; p20 = p23; p23 = temp; }
			if (p19.CompareTo(p21) > 0) { temp = p19; p19 = p21; p21 = temp; }
			if (p20.CompareTo(p22) > 0) { temp = p20; p20 = p22; p22 = temp; }
			if (p20.CompareTo(p21) > 0) { temp = p20; p20 = p21; p21 = temp; }
			if (p0.CompareTo(p15) > 0) { temp = p0; p0 = p15; p15 = temp; }
			if (p0.CompareTo(p14) > 0) { temp = p0; p0 = p14; p14 = temp; }
			if (p1.CompareTo(p16) > 0) { temp = p1; p1 = p16; p16 = temp; }
			if (p2.CompareTo(p17) > 0) { temp = p2; p2 = p17; p17 = temp; }
			if (p2.CompareTo(p16) > 0) { temp = p2; p2 = p16; p16 = temp; }
			if (p1.CompareTo(p14) > 0) { temp = p1; p1 = p14; p14 = temp; }
			if (p2.CompareTo(p15) > 0) { temp = p2; p2 = p15; p15 = temp; }
			if (p2.CompareTo(p14) > 0) { temp = p2; p2 = p14; p14 = temp; }
			if (p3.CompareTo(p18) > 0) { temp = p3; p3 = p18; p18 = temp; }
			if (p4.CompareTo(p19) > 0) { temp = p4; p4 = p19; p19 = temp; }
			if (p4.CompareTo(p18) > 0) { temp = p4; p4 = p18; p18 = temp; }
			if (p5.CompareTo(p20) > 0) { temp = p5; p5 = p20; p20 = temp; }
			if (p6.CompareTo(p21) > 0) { temp = p6; p6 = p21; p21 = temp; }
			if (p6.CompareTo(p20) > 0) { temp = p6; p6 = p20; p20 = temp; }
			if (p5.CompareTo(p18) > 0) { temp = p5; p5 = p18; p18 = temp; }
			if (p6.CompareTo(p19) > 0) { temp = p6; p6 = p19; p19 = temp; }
			if (p6.CompareTo(p18) > 0) { temp = p6; p6 = p18; p18 = temp; }
			if (p3.CompareTo(p14) > 0) { temp = p3; p3 = p14; p14 = temp; }
			if (p4.CompareTo(p15) > 0) { temp = p4; p4 = p15; p15 = temp; }
			if (p4.CompareTo(p14) > 0) { temp = p4; p4 = p14; p14 = temp; }
			if (p5.CompareTo(p16) > 0) { temp = p5; p5 = p16; p16 = temp; }
			if (p6.CompareTo(p17) > 0) { temp = p6; p6 = p17; p17 = temp; }
			if (p6.CompareTo(p16) > 0) { temp = p6; p6 = p16; p16 = temp; }
			if (p5.CompareTo(p14) > 0) { temp = p5; p5 = p14; p14 = temp; }
			if (p6.CompareTo(p15) > 0) { temp = p6; p6 = p15; p15 = temp; }
			if (p6.CompareTo(p14) > 0) { temp = p6; p6 = p14; p14 = temp; }
			if (p7.CompareTo(p23) > 0) { temp = p7; p7 = p23; p23 = temp; }
			if (p7.CompareTo(p22) > 0) { temp = p7; p7 = p22; p22 = temp; }
			if (p8.CompareTo(p24) > 0) { temp = p8; p8 = p24; p24 = temp; }
			if (p9.CompareTo(p25) > 0) { temp = p9; p9 = p25; p25 = temp; }
			if (p9.CompareTo(p24) > 0) { temp = p9; p9 = p24; p24 = temp; }
			if (p8.CompareTo(p22) > 0) { temp = p8; p8 = p22; p22 = temp; }
			if (p9.CompareTo(p23) > 0) { temp = p9; p9 = p23; p23 = temp; }
			if (p9.CompareTo(p22) > 0) { temp = p9; p9 = p22; p22 = temp; }
			if (p10.CompareTo(p26) > 0) { temp = p10; p10 = p26; p26 = temp; }
			if (p11.CompareTo(p27) > 0) { temp = p11; p11 = p27; p27 = temp; }
			if (p11.CompareTo(p26) > 0) { temp = p11; p11 = p26; p26 = temp; }
			if (p12.CompareTo(p28) > 0) { temp = p12; p12 = p28; p28 = temp; }
			if (p13.CompareTo(p28) > 0) { temp = p13; p13 = p28; p28 = temp; }
			if (p12.CompareTo(p26) > 0) { temp = p12; p12 = p26; p26 = temp; }
			if (p13.CompareTo(p27) > 0) { temp = p13; p13 = p27; p27 = temp; }
			if (p13.CompareTo(p26) > 0) { temp = p13; p13 = p26; p26 = temp; }
			if (p10.CompareTo(p22) > 0) { temp = p10; p10 = p22; p22 = temp; }
			if (p11.CompareTo(p23) > 0) { temp = p11; p11 = p23; p23 = temp; }
			if (p11.CompareTo(p22) > 0) { temp = p11; p11 = p22; p22 = temp; }
			if (p12.CompareTo(p24) > 0) { temp = p12; p12 = p24; p24 = temp; }
			if (p13.CompareTo(p25) > 0) { temp = p13; p13 = p25; p25 = temp; }
			if (p13.CompareTo(p24) > 0) { temp = p13; p13 = p24; p24 = temp; }
			if (p12.CompareTo(p22) > 0) { temp = p12; p12 = p22; p22 = temp; }
			if (p13.CompareTo(p23) > 0) { temp = p13; p13 = p23; p23 = temp; }
			if (p13.CompareTo(p22) > 0) { temp = p13; p13 = p22; p22 = temp; }
			if (p7.CompareTo(p15) > 0) { temp = p7; p7 = p15; p15 = temp; }
			if (p7.CompareTo(p14) > 0) { temp = p7; p7 = p14; p14 = temp; }
			if (p8.CompareTo(p16) > 0) { temp = p8; p8 = p16; p16 = temp; }
			if (p9.CompareTo(p17) > 0) { temp = p9; p9 = p17; p17 = temp; }
			if (p9.CompareTo(p16) > 0) { temp = p9; p9 = p16; p16 = temp; }
			if (p8.CompareTo(p14) > 0) { temp = p8; p8 = p14; p14 = temp; }
			if (p9.CompareTo(p15) > 0) { temp = p9; p9 = p15; p15 = temp; }
			if (p9.CompareTo(p14) > 0) { temp = p9; p9 = p14; p14 = temp; }
			if (p10.CompareTo(p18) > 0) { temp = p10; p10 = p18; p18 = temp; }
			if (p11.CompareTo(p19) > 0) { temp = p11; p11 = p19; p19 = temp; }
			if (p11.CompareTo(p18) > 0) { temp = p11; p11 = p18; p18 = temp; }
			if (p12.CompareTo(p20) > 0) { temp = p12; p12 = p20; p20 = temp; }
			if (p13.CompareTo(p21) > 0) { temp = p13; p13 = p21; p21 = temp; }
			if (p13.CompareTo(p20) > 0) { temp = p13; p13 = p20; p20 = temp; }
			if (p12.CompareTo(p18) > 0) { temp = p12; p12 = p18; p18 = temp; }
			if (p13.CompareTo(p19) > 0) { temp = p13; p13 = p19; p19 = temp; }
			if (p13.CompareTo(p18) > 0) { temp = p13; p13 = p18; p18 = temp; }
			if (p10.CompareTo(p14) > 0) { temp = p10; p10 = p14; p14 = temp; }
			if (p11.CompareTo(p15) > 0) { temp = p11; p11 = p15; p15 = temp; }
			if (p11.CompareTo(p14) > 0) { temp = p11; p11 = p14; p14 = temp; }
			if (p12.CompareTo(p16) > 0) { temp = p12; p12 = p16; p16 = temp; }
			if (p13.CompareTo(p17) > 0) { temp = p13; p13 = p17; p17 = temp; }
			if (p13.CompareTo(p16) > 0) { temp = p13; p13 = p16; p16 = temp; }
			if (p12.CompareTo(p14) > 0) { temp = p12; p12 = p14; p14 = temp; }
			if (p13.CompareTo(p15) > 0) { temp = p13; p13 = p15; p15 = temp; }
			if (p13.CompareTo(p14) > 0) { temp = p13; p13 = p14; p14 = temp; }
#else
			if (GreaterThan(ref p1, ref p2)) { temp = p1; p1 = p2; p2 = temp; }
			if (GreaterThan(ref p0, ref p2)) { temp = p0; p0 = p2; p2 = temp; }
			if (GreaterThan(ref p0, ref p1)) { temp = p0; p0 = p1; p1 = temp; }
			if (GreaterThan(ref p3, ref p4)) { temp = p3; p3 = p4; p4 = temp; }
			if (GreaterThan(ref p5, ref p6)) { temp = p5; p5 = p6; p6 = temp; }
			if (GreaterThan(ref p3, ref p5)) { temp = p3; p3 = p5; p5 = temp; }
			if (GreaterThan(ref p4, ref p6)) { temp = p4; p4 = p6; p6 = temp; }
			if (GreaterThan(ref p4, ref p5)) { temp = p4; p4 = p5; p5 = temp; }
			if (GreaterThan(ref p0, ref p4)) { temp = p0; p0 = p4; p4 = temp; }
			if (GreaterThan(ref p0, ref p3)) { temp = p0; p0 = p3; p3 = temp; }
			if (GreaterThan(ref p1, ref p5)) { temp = p1; p1 = p5; p5 = temp; }
			if (GreaterThan(ref p2, ref p6)) { temp = p2; p2 = p6; p6 = temp; }
			if (GreaterThan(ref p2, ref p5)) { temp = p2; p2 = p5; p5 = temp; }
			if (GreaterThan(ref p1, ref p3)) { temp = p1; p1 = p3; p3 = temp; }
			if (GreaterThan(ref p2, ref p4)) { temp = p2; p2 = p4; p4 = temp; }
			if (GreaterThan(ref p2, ref p3)) { temp = p2; p2 = p3; p3 = temp; }
			if (GreaterThan(ref p8, ref p9)) { temp = p8; p8 = p9; p9 = temp; }
			if (GreaterThan(ref p7, ref p9)) { temp = p7; p7 = p9; p9 = temp; }
			if (GreaterThan(ref p7, ref p8)) { temp = p7; p7 = p8; p8 = temp; }
			if (GreaterThan(ref p10, ref p11)) { temp = p10; p10 = p11; p11 = temp; }
			if (GreaterThan(ref p12, ref p13)) { temp = p12; p12 = p13; p13 = temp; }
			if (GreaterThan(ref p10, ref p12)) { temp = p10; p10 = p12; p12 = temp; }
			if (GreaterThan(ref p11, ref p13)) { temp = p11; p11 = p13; p13 = temp; }
			if (GreaterThan(ref p11, ref p12)) { temp = p11; p11 = p12; p12 = temp; }
			if (GreaterThan(ref p7, ref p11)) { temp = p7; p7 = p11; p11 = temp; }
			if (GreaterThan(ref p7, ref p10)) { temp = p7; p7 = p10; p10 = temp; }
			if (GreaterThan(ref p8, ref p12)) { temp = p8; p8 = p12; p12 = temp; }
			if (GreaterThan(ref p9, ref p13)) { temp = p9; p9 = p13; p13 = temp; }
			if (GreaterThan(ref p9, ref p12)) { temp = p9; p9 = p12; p12 = temp; }
			if (GreaterThan(ref p8, ref p10)) { temp = p8; p8 = p10; p10 = temp; }
			if (GreaterThan(ref p9, ref p11)) { temp = p9; p9 = p11; p11 = temp; }
			if (GreaterThan(ref p9, ref p10)) { temp = p9; p9 = p10; p10 = temp; }
			if (GreaterThan(ref p0, ref p8)) { temp = p0; p0 = p8; p8 = temp; }
			if (GreaterThan(ref p0, ref p7)) { temp = p0; p0 = p7; p7 = temp; }
			if (GreaterThan(ref p1, ref p9)) { temp = p1; p1 = p9; p9 = temp; }
			if (GreaterThan(ref p2, ref p10)) { temp = p2; p2 = p10; p10 = temp; }
			if (GreaterThan(ref p2, ref p9)) { temp = p2; p2 = p9; p9 = temp; }
			if (GreaterThan(ref p1, ref p7)) { temp = p1; p1 = p7; p7 = temp; }
			if (GreaterThan(ref p2, ref p8)) { temp = p2; p2 = p8; p8 = temp; }
			if (GreaterThan(ref p2, ref p7)) { temp = p2; p2 = p7; p7 = temp; }
			if (GreaterThan(ref p3, ref p11)) { temp = p3; p3 = p11; p11 = temp; }
			if (GreaterThan(ref p4, ref p12)) { temp = p4; p4 = p12; p12 = temp; }
			if (GreaterThan(ref p4, ref p11)) { temp = p4; p4 = p11; p11 = temp; }
			if (GreaterThan(ref p5, ref p13)) { temp = p5; p5 = p13; p13 = temp; }
			if (GreaterThan(ref p6, ref p13)) { temp = p6; p6 = p13; p13 = temp; }
			if (GreaterThan(ref p5, ref p11)) { temp = p5; p5 = p11; p11 = temp; }
			if (GreaterThan(ref p6, ref p12)) { temp = p6; p6 = p12; p12 = temp; }
			if (GreaterThan(ref p6, ref p11)) { temp = p6; p6 = p11; p11 = temp; }
			if (GreaterThan(ref p3, ref p7)) { temp = p3; p3 = p7; p7 = temp; }
			if (GreaterThan(ref p4, ref p8)) { temp = p4; p4 = p8; p8 = temp; }
			if (GreaterThan(ref p4, ref p7)) { temp = p4; p4 = p7; p7 = temp; }
			if (GreaterThan(ref p5, ref p9)) { temp = p5; p5 = p9; p9 = temp; }
			if (GreaterThan(ref p6, ref p10)) { temp = p6; p6 = p10; p10 = temp; }
			if (GreaterThan(ref p6, ref p9)) { temp = p6; p6 = p9; p9 = temp; }
			if (GreaterThan(ref p5, ref p7)) { temp = p5; p5 = p7; p7 = temp; }
			if (GreaterThan(ref p6, ref p8)) { temp = p6; p6 = p8; p8 = temp; }
			if (GreaterThan(ref p6, ref p7)) { temp = p6; p6 = p7; p7 = temp; }
			if (GreaterThan(ref p15, ref p16)) { temp = p15; p15 = p16; p16 = temp; }
			if (GreaterThan(ref p14, ref p16)) { temp = p14; p14 = p16; p16 = temp; }
			if (GreaterThan(ref p14, ref p15)) { temp = p14; p14 = p15; p15 = temp; }
			if (GreaterThan(ref p17, ref p18)) { temp = p17; p17 = p18; p18 = temp; }
			if (GreaterThan(ref p19, ref p20)) { temp = p19; p19 = p20; p20 = temp; }
			if (GreaterThan(ref p17, ref p19)) { temp = p17; p17 = p19; p19 = temp; }
			if (GreaterThan(ref p18, ref p20)) { temp = p18; p18 = p20; p20 = temp; }
			if (GreaterThan(ref p18, ref p19)) { temp = p18; p18 = p19; p19 = temp; }
			if (GreaterThan(ref p14, ref p18)) { temp = p14; p14 = p18; p18 = temp; }
			if (GreaterThan(ref p14, ref p17)) { temp = p14; p14 = p17; p17 = temp; }
			if (GreaterThan(ref p15, ref p19)) { temp = p15; p15 = p19; p19 = temp; }
			if (GreaterThan(ref p16, ref p20)) { temp = p16; p16 = p20; p20 = temp; }
			if (GreaterThan(ref p16, ref p19)) { temp = p16; p16 = p19; p19 = temp; }
			if (GreaterThan(ref p15, ref p17)) { temp = p15; p15 = p17; p17 = temp; }
			if (GreaterThan(ref p16, ref p18)) { temp = p16; p16 = p18; p18 = temp; }
			if (GreaterThan(ref p16, ref p17)) { temp = p16; p16 = p17; p17 = temp; }
			if (GreaterThan(ref p21, ref p22)) { temp = p21; p21 = p22; p22 = temp; }
			if (GreaterThan(ref p23, ref p24)) { temp = p23; p23 = p24; p24 = temp; }
			if (GreaterThan(ref p21, ref p23)) { temp = p21; p21 = p23; p23 = temp; }
			if (GreaterThan(ref p22, ref p24)) { temp = p22; p22 = p24; p24 = temp; }
			if (GreaterThan(ref p22, ref p23)) { temp = p22; p22 = p23; p23 = temp; }
			if (GreaterThan(ref p25, ref p26)) { temp = p25; p25 = p26; p26 = temp; }
			if (GreaterThan(ref p27, ref p28)) { temp = p27; p27 = p28; p28 = temp; }
			if (GreaterThan(ref p25, ref p27)) { temp = p25; p25 = p27; p27 = temp; }
			if (GreaterThan(ref p26, ref p28)) { temp = p26; p26 = p28; p28 = temp; }
			if (GreaterThan(ref p26, ref p27)) { temp = p26; p26 = p27; p27 = temp; }
			if (GreaterThan(ref p21, ref p25)) { temp = p21; p21 = p25; p25 = temp; }
			if (GreaterThan(ref p22, ref p26)) { temp = p22; p22 = p26; p26 = temp; }
			if (GreaterThan(ref p22, ref p25)) { temp = p22; p22 = p25; p25 = temp; }
			if (GreaterThan(ref p23, ref p27)) { temp = p23; p23 = p27; p27 = temp; }
			if (GreaterThan(ref p24, ref p28)) { temp = p24; p24 = p28; p28 = temp; }
			if (GreaterThan(ref p24, ref p27)) { temp = p24; p24 = p27; p27 = temp; }
			if (GreaterThan(ref p23, ref p25)) { temp = p23; p23 = p25; p25 = temp; }
			if (GreaterThan(ref p24, ref p26)) { temp = p24; p24 = p26; p26 = temp; }
			if (GreaterThan(ref p24, ref p25)) { temp = p24; p24 = p25; p25 = temp; }
			if (GreaterThan(ref p14, ref p22)) { temp = p14; p14 = p22; p22 = temp; }
			if (GreaterThan(ref p14, ref p21)) { temp = p14; p14 = p21; p21 = temp; }
			if (GreaterThan(ref p15, ref p23)) { temp = p15; p15 = p23; p23 = temp; }
			if (GreaterThan(ref p16, ref p24)) { temp = p16; p16 = p24; p24 = temp; }
			if (GreaterThan(ref p16, ref p23)) { temp = p16; p16 = p23; p23 = temp; }
			if (GreaterThan(ref p15, ref p21)) { temp = p15; p15 = p21; p21 = temp; }
			if (GreaterThan(ref p16, ref p22)) { temp = p16; p16 = p22; p22 = temp; }
			if (GreaterThan(ref p16, ref p21)) { temp = p16; p16 = p21; p21 = temp; }
			if (GreaterThan(ref p17, ref p25)) { temp = p17; p17 = p25; p25 = temp; }
			if (GreaterThan(ref p18, ref p26)) { temp = p18; p18 = p26; p26 = temp; }
			if (GreaterThan(ref p18, ref p25)) { temp = p18; p18 = p25; p25 = temp; }
			if (GreaterThan(ref p19, ref p27)) { temp = p19; p19 = p27; p27 = temp; }
			if (GreaterThan(ref p20, ref p28)) { temp = p20; p20 = p28; p28 = temp; }
			if (GreaterThan(ref p20, ref p27)) { temp = p20; p20 = p27; p27 = temp; }
			if (GreaterThan(ref p19, ref p25)) { temp = p19; p19 = p25; p25 = temp; }
			if (GreaterThan(ref p20, ref p26)) { temp = p20; p20 = p26; p26 = temp; }
			if (GreaterThan(ref p20, ref p25)) { temp = p20; p20 = p25; p25 = temp; }
			if (GreaterThan(ref p17, ref p21)) { temp = p17; p17 = p21; p21 = temp; }
			if (GreaterThan(ref p18, ref p22)) { temp = p18; p18 = p22; p22 = temp; }
			if (GreaterThan(ref p18, ref p21)) { temp = p18; p18 = p21; p21 = temp; }
			if (GreaterThan(ref p19, ref p23)) { temp = p19; p19 = p23; p23 = temp; }
			if (GreaterThan(ref p20, ref p24)) { temp = p20; p20 = p24; p24 = temp; }
			if (GreaterThan(ref p20, ref p23)) { temp = p20; p20 = p23; p23 = temp; }
			if (GreaterThan(ref p19, ref p21)) { temp = p19; p19 = p21; p21 = temp; }
			if (GreaterThan(ref p20, ref p22)) { temp = p20; p20 = p22; p22 = temp; }
			if (GreaterThan(ref p20, ref p21)) { temp = p20; p20 = p21; p21 = temp; }
			if (GreaterThan(ref p0, ref p15)) { temp = p0; p0 = p15; p15 = temp; }
			if (GreaterThan(ref p0, ref p14)) { temp = p0; p0 = p14; p14 = temp; }
			if (GreaterThan(ref p1, ref p16)) { temp = p1; p1 = p16; p16 = temp; }
			if (GreaterThan(ref p2, ref p17)) { temp = p2; p2 = p17; p17 = temp; }
			if (GreaterThan(ref p2, ref p16)) { temp = p2; p2 = p16; p16 = temp; }
			if (GreaterThan(ref p1, ref p14)) { temp = p1; p1 = p14; p14 = temp; }
			if (GreaterThan(ref p2, ref p15)) { temp = p2; p2 = p15; p15 = temp; }
			if (GreaterThan(ref p2, ref p14)) { temp = p2; p2 = p14; p14 = temp; }
			if (GreaterThan(ref p3, ref p18)) { temp = p3; p3 = p18; p18 = temp; }
			if (GreaterThan(ref p4, ref p19)) { temp = p4; p4 = p19; p19 = temp; }
			if (GreaterThan(ref p4, ref p18)) { temp = p4; p4 = p18; p18 = temp; }
			if (GreaterThan(ref p5, ref p20)) { temp = p5; p5 = p20; p20 = temp; }
			if (GreaterThan(ref p6, ref p21)) { temp = p6; p6 = p21; p21 = temp; }
			if (GreaterThan(ref p6, ref p20)) { temp = p6; p6 = p20; p20 = temp; }
			if (GreaterThan(ref p5, ref p18)) { temp = p5; p5 = p18; p18 = temp; }
			if (GreaterThan(ref p6, ref p19)) { temp = p6; p6 = p19; p19 = temp; }
			if (GreaterThan(ref p6, ref p18)) { temp = p6; p6 = p18; p18 = temp; }
			if (GreaterThan(ref p3, ref p14)) { temp = p3; p3 = p14; p14 = temp; }
			if (GreaterThan(ref p4, ref p15)) { temp = p4; p4 = p15; p15 = temp; }
			if (GreaterThan(ref p4, ref p14)) { temp = p4; p4 = p14; p14 = temp; }
			if (GreaterThan(ref p5, ref p16)) { temp = p5; p5 = p16; p16 = temp; }
			if (GreaterThan(ref p6, ref p17)) { temp = p6; p6 = p17; p17 = temp; }
			if (GreaterThan(ref p6, ref p16)) { temp = p6; p6 = p16; p16 = temp; }
			if (GreaterThan(ref p5, ref p14)) { temp = p5; p5 = p14; p14 = temp; }
			if (GreaterThan(ref p6, ref p15)) { temp = p6; p6 = p15; p15 = temp; }
			if (GreaterThan(ref p6, ref p14)) { temp = p6; p6 = p14; p14 = temp; }
			if (GreaterThan(ref p7, ref p23)) { temp = p7; p7 = p23; p23 = temp; }
			if (GreaterThan(ref p7, ref p22)) { temp = p7; p7 = p22; p22 = temp; }
			if (GreaterThan(ref p8, ref p24)) { temp = p8; p8 = p24; p24 = temp; }
			if (GreaterThan(ref p9, ref p25)) { temp = p9; p9 = p25; p25 = temp; }
			if (GreaterThan(ref p9, ref p24)) { temp = p9; p9 = p24; p24 = temp; }
			if (GreaterThan(ref p8, ref p22)) { temp = p8; p8 = p22; p22 = temp; }
			if (GreaterThan(ref p9, ref p23)) { temp = p9; p9 = p23; p23 = temp; }
			if (GreaterThan(ref p9, ref p22)) { temp = p9; p9 = p22; p22 = temp; }
			if (GreaterThan(ref p10, ref p26)) { temp = p10; p10 = p26; p26 = temp; }
			if (GreaterThan(ref p11, ref p27)) { temp = p11; p11 = p27; p27 = temp; }
			if (GreaterThan(ref p11, ref p26)) { temp = p11; p11 = p26; p26 = temp; }
			if (GreaterThan(ref p12, ref p28)) { temp = p12; p12 = p28; p28 = temp; }
			if (GreaterThan(ref p13, ref p28)) { temp = p13; p13 = p28; p28 = temp; }
			if (GreaterThan(ref p12, ref p26)) { temp = p12; p12 = p26; p26 = temp; }
			if (GreaterThan(ref p13, ref p27)) { temp = p13; p13 = p27; p27 = temp; }
			if (GreaterThan(ref p13, ref p26)) { temp = p13; p13 = p26; p26 = temp; }
			if (GreaterThan(ref p10, ref p22)) { temp = p10; p10 = p22; p22 = temp; }
			if (GreaterThan(ref p11, ref p23)) { temp = p11; p11 = p23; p23 = temp; }
			if (GreaterThan(ref p11, ref p22)) { temp = p11; p11 = p22; p22 = temp; }
			if (GreaterThan(ref p12, ref p24)) { temp = p12; p12 = p24; p24 = temp; }
			if (GreaterThan(ref p13, ref p25)) { temp = p13; p13 = p25; p25 = temp; }
			if (GreaterThan(ref p13, ref p24)) { temp = p13; p13 = p24; p24 = temp; }
			if (GreaterThan(ref p12, ref p22)) { temp = p12; p12 = p22; p22 = temp; }
			if (GreaterThan(ref p13, ref p23)) { temp = p13; p13 = p23; p23 = temp; }
			if (GreaterThan(ref p13, ref p22)) { temp = p13; p13 = p22; p22 = temp; }
			if (GreaterThan(ref p7, ref p15)) { temp = p7; p7 = p15; p15 = temp; }
			if (GreaterThan(ref p7, ref p14)) { temp = p7; p7 = p14; p14 = temp; }
			if (GreaterThan(ref p8, ref p16)) { temp = p8; p8 = p16; p16 = temp; }
			if (GreaterThan(ref p9, ref p17)) { temp = p9; p9 = p17; p17 = temp; }
			if (GreaterThan(ref p9, ref p16)) { temp = p9; p9 = p16; p16 = temp; }
			if (GreaterThan(ref p8, ref p14)) { temp = p8; p8 = p14; p14 = temp; }
			if (GreaterThan(ref p9, ref p15)) { temp = p9; p9 = p15; p15 = temp; }
			if (GreaterThan(ref p9, ref p14)) { temp = p9; p9 = p14; p14 = temp; }
			if (GreaterThan(ref p10, ref p18)) { temp = p10; p10 = p18; p18 = temp; }
			if (GreaterThan(ref p11, ref p19)) { temp = p11; p11 = p19; p19 = temp; }
			if (GreaterThan(ref p11, ref p18)) { temp = p11; p11 = p18; p18 = temp; }
			if (GreaterThan(ref p12, ref p20)) { temp = p12; p12 = p20; p20 = temp; }
			if (GreaterThan(ref p13, ref p21)) { temp = p13; p13 = p21; p21 = temp; }
			if (GreaterThan(ref p13, ref p20)) { temp = p13; p13 = p20; p20 = temp; }
			if (GreaterThan(ref p12, ref p18)) { temp = p12; p12 = p18; p18 = temp; }
			if (GreaterThan(ref p13, ref p19)) { temp = p13; p13 = p19; p19 = temp; }
			if (GreaterThan(ref p13, ref p18)) { temp = p13; p13 = p18; p18 = temp; }
			if (GreaterThan(ref p10, ref p14)) { temp = p10; p10 = p14; p14 = temp; }
			if (GreaterThan(ref p11, ref p15)) { temp = p11; p11 = p15; p15 = temp; }
			if (GreaterThan(ref p11, ref p14)) { temp = p11; p11 = p14; p14 = temp; }
			if (GreaterThan(ref p12, ref p16)) { temp = p12; p12 = p16; p16 = temp; }
			if (GreaterThan(ref p13, ref p17)) { temp = p13; p13 = p17; p17 = temp; }
			if (GreaterThan(ref p13, ref p16)) { temp = p13; p13 = p16; p16 = temp; }
			if (GreaterThan(ref p12, ref p14)) { temp = p12; p12 = p14; p14 = temp; }
			if (GreaterThan(ref p13, ref p15)) { temp = p13; p13 = p15; p15 = temp; }
			if (GreaterThan(ref p13, ref p14)) { temp = p13; p13 = p14; p14 = temp; }
#endif
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
#if NETSTANDARD1_3
			if (p1.CompareTo(p2) > 0) { temp = p1; p1 = p2; p2 = temp; }
			if (p0.CompareTo(p2) > 0) { temp = p0; p0 = p2; p2 = temp; }
			if (p0.CompareTo(p1) > 0) { temp = p0; p0 = p1; p1 = temp; }
			if (p3.CompareTo(p4) > 0) { temp = p3; p3 = p4; p4 = temp; }
			if (p5.CompareTo(p6) > 0) { temp = p5; p5 = p6; p6 = temp; }
			if (p3.CompareTo(p5) > 0) { temp = p3; p3 = p5; p5 = temp; }
			if (p4.CompareTo(p6) > 0) { temp = p4; p4 = p6; p6 = temp; }
			if (p4.CompareTo(p5) > 0) { temp = p4; p4 = p5; p5 = temp; }
			if (p0.CompareTo(p4) > 0) { temp = p0; p0 = p4; p4 = temp; }
			if (p0.CompareTo(p3) > 0) { temp = p0; p0 = p3; p3 = temp; }
			if (p1.CompareTo(p5) > 0) { temp = p1; p1 = p5; p5 = temp; }
			if (p2.CompareTo(p6) > 0) { temp = p2; p2 = p6; p6 = temp; }
			if (p2.CompareTo(p5) > 0) { temp = p2; p2 = p5; p5 = temp; }
			if (p1.CompareTo(p3) > 0) { temp = p1; p1 = p3; p3 = temp; }
			if (p2.CompareTo(p4) > 0) { temp = p2; p2 = p4; p4 = temp; }
			if (p2.CompareTo(p3) > 0) { temp = p2; p2 = p3; p3 = temp; }
			if (p7.CompareTo(p8) > 0) { temp = p7; p7 = p8; p8 = temp; }
			if (p9.CompareTo(p10) > 0) { temp = p9; p9 = p10; p10 = temp; }
			if (p7.CompareTo(p9) > 0) { temp = p7; p7 = p9; p9 = temp; }
			if (p8.CompareTo(p10) > 0) { temp = p8; p8 = p10; p10 = temp; }
			if (p8.CompareTo(p9) > 0) { temp = p8; p8 = p9; p9 = temp; }
			if (p11.CompareTo(p12) > 0) { temp = p11; p11 = p12; p12 = temp; }
			if (p13.CompareTo(p14) > 0) { temp = p13; p13 = p14; p14 = temp; }
			if (p11.CompareTo(p13) > 0) { temp = p11; p11 = p13; p13 = temp; }
			if (p12.CompareTo(p14) > 0) { temp = p12; p12 = p14; p14 = temp; }
			if (p12.CompareTo(p13) > 0) { temp = p12; p12 = p13; p13 = temp; }
			if (p7.CompareTo(p11) > 0) { temp = p7; p7 = p11; p11 = temp; }
			if (p8.CompareTo(p12) > 0) { temp = p8; p8 = p12; p12 = temp; }
			if (p8.CompareTo(p11) > 0) { temp = p8; p8 = p11; p11 = temp; }
			if (p9.CompareTo(p13) > 0) { temp = p9; p9 = p13; p13 = temp; }
			if (p10.CompareTo(p14) > 0) { temp = p10; p10 = p14; p14 = temp; }
			if (p10.CompareTo(p13) > 0) { temp = p10; p10 = p13; p13 = temp; }
			if (p9.CompareTo(p11) > 0) { temp = p9; p9 = p11; p11 = temp; }
			if (p10.CompareTo(p12) > 0) { temp = p10; p10 = p12; p12 = temp; }
			if (p10.CompareTo(p11) > 0) { temp = p10; p10 = p11; p11 = temp; }
			if (p0.CompareTo(p8) > 0) { temp = p0; p0 = p8; p8 = temp; }
			if (p0.CompareTo(p7) > 0) { temp = p0; p0 = p7; p7 = temp; }
			if (p1.CompareTo(p9) > 0) { temp = p1; p1 = p9; p9 = temp; }
			if (p2.CompareTo(p10) > 0) { temp = p2; p2 = p10; p10 = temp; }
			if (p2.CompareTo(p9) > 0) { temp = p2; p2 = p9; p9 = temp; }
			if (p1.CompareTo(p7) > 0) { temp = p1; p1 = p7; p7 = temp; }
			if (p2.CompareTo(p8) > 0) { temp = p2; p2 = p8; p8 = temp; }
			if (p2.CompareTo(p7) > 0) { temp = p2; p2 = p7; p7 = temp; }
			if (p3.CompareTo(p11) > 0) { temp = p3; p3 = p11; p11 = temp; }
			if (p4.CompareTo(p12) > 0) { temp = p4; p4 = p12; p12 = temp; }
			if (p4.CompareTo(p11) > 0) { temp = p4; p4 = p11; p11 = temp; }
			if (p5.CompareTo(p13) > 0) { temp = p5; p5 = p13; p13 = temp; }
			if (p6.CompareTo(p14) > 0) { temp = p6; p6 = p14; p14 = temp; }
			if (p6.CompareTo(p13) > 0) { temp = p6; p6 = p13; p13 = temp; }
			if (p5.CompareTo(p11) > 0) { temp = p5; p5 = p11; p11 = temp; }
			if (p6.CompareTo(p12) > 0) { temp = p6; p6 = p12; p12 = temp; }
			if (p6.CompareTo(p11) > 0) { temp = p6; p6 = p11; p11 = temp; }
			if (p3.CompareTo(p7) > 0) { temp = p3; p3 = p7; p7 = temp; }
			if (p4.CompareTo(p8) > 0) { temp = p4; p4 = p8; p8 = temp; }
			if (p4.CompareTo(p7) > 0) { temp = p4; p4 = p7; p7 = temp; }
			if (p5.CompareTo(p9) > 0) { temp = p5; p5 = p9; p9 = temp; }
			if (p6.CompareTo(p10) > 0) { temp = p6; p6 = p10; p10 = temp; }
			if (p6.CompareTo(p9) > 0) { temp = p6; p6 = p9; p9 = temp; }
			if (p5.CompareTo(p7) > 0) { temp = p5; p5 = p7; p7 = temp; }
			if (p6.CompareTo(p8) > 0) { temp = p6; p6 = p8; p8 = temp; }
			if (p6.CompareTo(p7) > 0) { temp = p6; p6 = p7; p7 = temp; }
			if (p16.CompareTo(p17) > 0) { temp = p16; p16 = p17; p17 = temp; }
			if (p15.CompareTo(p17) > 0) { temp = p15; p15 = p17; p17 = temp; }
			if (p15.CompareTo(p16) > 0) { temp = p15; p15 = p16; p16 = temp; }
			if (p18.CompareTo(p19) > 0) { temp = p18; p18 = p19; p19 = temp; }
			if (p20.CompareTo(p21) > 0) { temp = p20; p20 = p21; p21 = temp; }
			if (p18.CompareTo(p20) > 0) { temp = p18; p18 = p20; p20 = temp; }
			if (p19.CompareTo(p21) > 0) { temp = p19; p19 = p21; p21 = temp; }
			if (p19.CompareTo(p20) > 0) { temp = p19; p19 = p20; p20 = temp; }
			if (p15.CompareTo(p19) > 0) { temp = p15; p15 = p19; p19 = temp; }
			if (p15.CompareTo(p18) > 0) { temp = p15; p15 = p18; p18 = temp; }
			if (p16.CompareTo(p20) > 0) { temp = p16; p16 = p20; p20 = temp; }
			if (p17.CompareTo(p21) > 0) { temp = p17; p17 = p21; p21 = temp; }
			if (p17.CompareTo(p20) > 0) { temp = p17; p17 = p20; p20 = temp; }
			if (p16.CompareTo(p18) > 0) { temp = p16; p16 = p18; p18 = temp; }
			if (p17.CompareTo(p19) > 0) { temp = p17; p17 = p19; p19 = temp; }
			if (p17.CompareTo(p18) > 0) { temp = p17; p17 = p18; p18 = temp; }
			if (p22.CompareTo(p23) > 0) { temp = p22; p22 = p23; p23 = temp; }
			if (p24.CompareTo(p25) > 0) { temp = p24; p24 = p25; p25 = temp; }
			if (p22.CompareTo(p24) > 0) { temp = p22; p22 = p24; p24 = temp; }
			if (p23.CompareTo(p25) > 0) { temp = p23; p23 = p25; p25 = temp; }
			if (p23.CompareTo(p24) > 0) { temp = p23; p23 = p24; p24 = temp; }
			if (p26.CompareTo(p27) > 0) { temp = p26; p26 = p27; p27 = temp; }
			if (p28.CompareTo(p29) > 0) { temp = p28; p28 = p29; p29 = temp; }
			if (p26.CompareTo(p28) > 0) { temp = p26; p26 = p28; p28 = temp; }
			if (p27.CompareTo(p29) > 0) { temp = p27; p27 = p29; p29 = temp; }
			if (p27.CompareTo(p28) > 0) { temp = p27; p27 = p28; p28 = temp; }
			if (p22.CompareTo(p26) > 0) { temp = p22; p22 = p26; p26 = temp; }
			if (p23.CompareTo(p27) > 0) { temp = p23; p23 = p27; p27 = temp; }
			if (p23.CompareTo(p26) > 0) { temp = p23; p23 = p26; p26 = temp; }
			if (p24.CompareTo(p28) > 0) { temp = p24; p24 = p28; p28 = temp; }
			if (p25.CompareTo(p29) > 0) { temp = p25; p25 = p29; p29 = temp; }
			if (p25.CompareTo(p28) > 0) { temp = p25; p25 = p28; p28 = temp; }
			if (p24.CompareTo(p26) > 0) { temp = p24; p24 = p26; p26 = temp; }
			if (p25.CompareTo(p27) > 0) { temp = p25; p25 = p27; p27 = temp; }
			if (p25.CompareTo(p26) > 0) { temp = p25; p25 = p26; p26 = temp; }
			if (p15.CompareTo(p23) > 0) { temp = p15; p15 = p23; p23 = temp; }
			if (p15.CompareTo(p22) > 0) { temp = p15; p15 = p22; p22 = temp; }
			if (p16.CompareTo(p24) > 0) { temp = p16; p16 = p24; p24 = temp; }
			if (p17.CompareTo(p25) > 0) { temp = p17; p17 = p25; p25 = temp; }
			if (p17.CompareTo(p24) > 0) { temp = p17; p17 = p24; p24 = temp; }
			if (p16.CompareTo(p22) > 0) { temp = p16; p16 = p22; p22 = temp; }
			if (p17.CompareTo(p23) > 0) { temp = p17; p17 = p23; p23 = temp; }
			if (p17.CompareTo(p22) > 0) { temp = p17; p17 = p22; p22 = temp; }
			if (p18.CompareTo(p26) > 0) { temp = p18; p18 = p26; p26 = temp; }
			if (p19.CompareTo(p27) > 0) { temp = p19; p19 = p27; p27 = temp; }
			if (p19.CompareTo(p26) > 0) { temp = p19; p19 = p26; p26 = temp; }
			if (p20.CompareTo(p28) > 0) { temp = p20; p20 = p28; p28 = temp; }
			if (p21.CompareTo(p29) > 0) { temp = p21; p21 = p29; p29 = temp; }
			if (p21.CompareTo(p28) > 0) { temp = p21; p21 = p28; p28 = temp; }
			if (p20.CompareTo(p26) > 0) { temp = p20; p20 = p26; p26 = temp; }
			if (p21.CompareTo(p27) > 0) { temp = p21; p21 = p27; p27 = temp; }
			if (p21.CompareTo(p26) > 0) { temp = p21; p21 = p26; p26 = temp; }
			if (p18.CompareTo(p22) > 0) { temp = p18; p18 = p22; p22 = temp; }
			if (p19.CompareTo(p23) > 0) { temp = p19; p19 = p23; p23 = temp; }
			if (p19.CompareTo(p22) > 0) { temp = p19; p19 = p22; p22 = temp; }
			if (p20.CompareTo(p24) > 0) { temp = p20; p20 = p24; p24 = temp; }
			if (p21.CompareTo(p25) > 0) { temp = p21; p21 = p25; p25 = temp; }
			if (p21.CompareTo(p24) > 0) { temp = p21; p21 = p24; p24 = temp; }
			if (p20.CompareTo(p22) > 0) { temp = p20; p20 = p22; p22 = temp; }
			if (p21.CompareTo(p23) > 0) { temp = p21; p21 = p23; p23 = temp; }
			if (p21.CompareTo(p22) > 0) { temp = p21; p21 = p22; p22 = temp; }
			if (p0.CompareTo(p16) > 0) { temp = p0; p0 = p16; p16 = temp; }
			if (p0.CompareTo(p15) > 0) { temp = p0; p0 = p15; p15 = temp; }
			if (p1.CompareTo(p17) > 0) { temp = p1; p1 = p17; p17 = temp; }
			if (p2.CompareTo(p18) > 0) { temp = p2; p2 = p18; p18 = temp; }
			if (p2.CompareTo(p17) > 0) { temp = p2; p2 = p17; p17 = temp; }
			if (p1.CompareTo(p15) > 0) { temp = p1; p1 = p15; p15 = temp; }
			if (p2.CompareTo(p16) > 0) { temp = p2; p2 = p16; p16 = temp; }
			if (p2.CompareTo(p15) > 0) { temp = p2; p2 = p15; p15 = temp; }
			if (p3.CompareTo(p19) > 0) { temp = p3; p3 = p19; p19 = temp; }
			if (p4.CompareTo(p20) > 0) { temp = p4; p4 = p20; p20 = temp; }
			if (p4.CompareTo(p19) > 0) { temp = p4; p4 = p19; p19 = temp; }
			if (p5.CompareTo(p21) > 0) { temp = p5; p5 = p21; p21 = temp; }
			if (p6.CompareTo(p22) > 0) { temp = p6; p6 = p22; p22 = temp; }
			if (p6.CompareTo(p21) > 0) { temp = p6; p6 = p21; p21 = temp; }
			if (p5.CompareTo(p19) > 0) { temp = p5; p5 = p19; p19 = temp; }
			if (p6.CompareTo(p20) > 0) { temp = p6; p6 = p20; p20 = temp; }
			if (p6.CompareTo(p19) > 0) { temp = p6; p6 = p19; p19 = temp; }
			if (p3.CompareTo(p15) > 0) { temp = p3; p3 = p15; p15 = temp; }
			if (p4.CompareTo(p16) > 0) { temp = p4; p4 = p16; p16 = temp; }
			if (p4.CompareTo(p15) > 0) { temp = p4; p4 = p15; p15 = temp; }
			if (p5.CompareTo(p17) > 0) { temp = p5; p5 = p17; p17 = temp; }
			if (p6.CompareTo(p18) > 0) { temp = p6; p6 = p18; p18 = temp; }
			if (p6.CompareTo(p17) > 0) { temp = p6; p6 = p17; p17 = temp; }
			if (p5.CompareTo(p15) > 0) { temp = p5; p5 = p15; p15 = temp; }
			if (p6.CompareTo(p16) > 0) { temp = p6; p6 = p16; p16 = temp; }
			if (p6.CompareTo(p15) > 0) { temp = p6; p6 = p15; p15 = temp; }
			if (p7.CompareTo(p23) > 0) { temp = p7; p7 = p23; p23 = temp; }
			if (p8.CompareTo(p24) > 0) { temp = p8; p8 = p24; p24 = temp; }
			if (p8.CompareTo(p23) > 0) { temp = p8; p8 = p23; p23 = temp; }
			if (p9.CompareTo(p25) > 0) { temp = p9; p9 = p25; p25 = temp; }
			if (p10.CompareTo(p26) > 0) { temp = p10; p10 = p26; p26 = temp; }
			if (p10.CompareTo(p25) > 0) { temp = p10; p10 = p25; p25 = temp; }
			if (p9.CompareTo(p23) > 0) { temp = p9; p9 = p23; p23 = temp; }
			if (p10.CompareTo(p24) > 0) { temp = p10; p10 = p24; p24 = temp; }
			if (p10.CompareTo(p23) > 0) { temp = p10; p10 = p23; p23 = temp; }
			if (p11.CompareTo(p27) > 0) { temp = p11; p11 = p27; p27 = temp; }
			if (p12.CompareTo(p28) > 0) { temp = p12; p12 = p28; p28 = temp; }
			if (p12.CompareTo(p27) > 0) { temp = p12; p12 = p27; p27 = temp; }
			if (p13.CompareTo(p29) > 0) { temp = p13; p13 = p29; p29 = temp; }
			if (p14.CompareTo(p29) > 0) { temp = p14; p14 = p29; p29 = temp; }
			if (p13.CompareTo(p27) > 0) { temp = p13; p13 = p27; p27 = temp; }
			if (p14.CompareTo(p28) > 0) { temp = p14; p14 = p28; p28 = temp; }
			if (p14.CompareTo(p27) > 0) { temp = p14; p14 = p27; p27 = temp; }
			if (p11.CompareTo(p23) > 0) { temp = p11; p11 = p23; p23 = temp; }
			if (p12.CompareTo(p24) > 0) { temp = p12; p12 = p24; p24 = temp; }
			if (p12.CompareTo(p23) > 0) { temp = p12; p12 = p23; p23 = temp; }
			if (p13.CompareTo(p25) > 0) { temp = p13; p13 = p25; p25 = temp; }
			if (p14.CompareTo(p26) > 0) { temp = p14; p14 = p26; p26 = temp; }
			if (p14.CompareTo(p25) > 0) { temp = p14; p14 = p25; p25 = temp; }
			if (p13.CompareTo(p23) > 0) { temp = p13; p13 = p23; p23 = temp; }
			if (p14.CompareTo(p24) > 0) { temp = p14; p14 = p24; p24 = temp; }
			if (p14.CompareTo(p23) > 0) { temp = p14; p14 = p23; p23 = temp; }
			if (p7.CompareTo(p15) > 0) { temp = p7; p7 = p15; p15 = temp; }
			if (p8.CompareTo(p16) > 0) { temp = p8; p8 = p16; p16 = temp; }
			if (p8.CompareTo(p15) > 0) { temp = p8; p8 = p15; p15 = temp; }
			if (p9.CompareTo(p17) > 0) { temp = p9; p9 = p17; p17 = temp; }
			if (p10.CompareTo(p18) > 0) { temp = p10; p10 = p18; p18 = temp; }
			if (p10.CompareTo(p17) > 0) { temp = p10; p10 = p17; p17 = temp; }
			if (p9.CompareTo(p15) > 0) { temp = p9; p9 = p15; p15 = temp; }
			if (p10.CompareTo(p16) > 0) { temp = p10; p10 = p16; p16 = temp; }
			if (p10.CompareTo(p15) > 0) { temp = p10; p10 = p15; p15 = temp; }
			if (p11.CompareTo(p19) > 0) { temp = p11; p11 = p19; p19 = temp; }
			if (p12.CompareTo(p20) > 0) { temp = p12; p12 = p20; p20 = temp; }
			if (p12.CompareTo(p19) > 0) { temp = p12; p12 = p19; p19 = temp; }
			if (p13.CompareTo(p21) > 0) { temp = p13; p13 = p21; p21 = temp; }
			if (p14.CompareTo(p22) > 0) { temp = p14; p14 = p22; p22 = temp; }
			if (p14.CompareTo(p21) > 0) { temp = p14; p14 = p21; p21 = temp; }
			if (p13.CompareTo(p19) > 0) { temp = p13; p13 = p19; p19 = temp; }
			if (p14.CompareTo(p20) > 0) { temp = p14; p14 = p20; p20 = temp; }
			if (p14.CompareTo(p19) > 0) { temp = p14; p14 = p19; p19 = temp; }
			if (p11.CompareTo(p15) > 0) { temp = p11; p11 = p15; p15 = temp; }
			if (p12.CompareTo(p16) > 0) { temp = p12; p12 = p16; p16 = temp; }
			if (p12.CompareTo(p15) > 0) { temp = p12; p12 = p15; p15 = temp; }
			if (p13.CompareTo(p17) > 0) { temp = p13; p13 = p17; p17 = temp; }
			if (p14.CompareTo(p18) > 0) { temp = p14; p14 = p18; p18 = temp; }
			if (p14.CompareTo(p17) > 0) { temp = p14; p14 = p17; p17 = temp; }
			if (p13.CompareTo(p15) > 0) { temp = p13; p13 = p15; p15 = temp; }
			if (p14.CompareTo(p16) > 0) { temp = p14; p14 = p16; p16 = temp; }
			if (p14.CompareTo(p15) > 0) { temp = p14; p14 = p15; p15 = temp; }
#else
			if (GreaterThan(ref p1, ref p2)) { temp = p1; p1 = p2; p2 = temp; }
			if (GreaterThan(ref p0, ref p2)) { temp = p0; p0 = p2; p2 = temp; }
			if (GreaterThan(ref p0, ref p1)) { temp = p0; p0 = p1; p1 = temp; }
			if (GreaterThan(ref p3, ref p4)) { temp = p3; p3 = p4; p4 = temp; }
			if (GreaterThan(ref p5, ref p6)) { temp = p5; p5 = p6; p6 = temp; }
			if (GreaterThan(ref p3, ref p5)) { temp = p3; p3 = p5; p5 = temp; }
			if (GreaterThan(ref p4, ref p6)) { temp = p4; p4 = p6; p6 = temp; }
			if (GreaterThan(ref p4, ref p5)) { temp = p4; p4 = p5; p5 = temp; }
			if (GreaterThan(ref p0, ref p4)) { temp = p0; p0 = p4; p4 = temp; }
			if (GreaterThan(ref p0, ref p3)) { temp = p0; p0 = p3; p3 = temp; }
			if (GreaterThan(ref p1, ref p5)) { temp = p1; p1 = p5; p5 = temp; }
			if (GreaterThan(ref p2, ref p6)) { temp = p2; p2 = p6; p6 = temp; }
			if (GreaterThan(ref p2, ref p5)) { temp = p2; p2 = p5; p5 = temp; }
			if (GreaterThan(ref p1, ref p3)) { temp = p1; p1 = p3; p3 = temp; }
			if (GreaterThan(ref p2, ref p4)) { temp = p2; p2 = p4; p4 = temp; }
			if (GreaterThan(ref p2, ref p3)) { temp = p2; p2 = p3; p3 = temp; }
			if (GreaterThan(ref p7, ref p8)) { temp = p7; p7 = p8; p8 = temp; }
			if (GreaterThan(ref p9, ref p10)) { temp = p9; p9 = p10; p10 = temp; }
			if (GreaterThan(ref p7, ref p9)) { temp = p7; p7 = p9; p9 = temp; }
			if (GreaterThan(ref p8, ref p10)) { temp = p8; p8 = p10; p10 = temp; }
			if (GreaterThan(ref p8, ref p9)) { temp = p8; p8 = p9; p9 = temp; }
			if (GreaterThan(ref p11, ref p12)) { temp = p11; p11 = p12; p12 = temp; }
			if (GreaterThan(ref p13, ref p14)) { temp = p13; p13 = p14; p14 = temp; }
			if (GreaterThan(ref p11, ref p13)) { temp = p11; p11 = p13; p13 = temp; }
			if (GreaterThan(ref p12, ref p14)) { temp = p12; p12 = p14; p14 = temp; }
			if (GreaterThan(ref p12, ref p13)) { temp = p12; p12 = p13; p13 = temp; }
			if (GreaterThan(ref p7, ref p11)) { temp = p7; p7 = p11; p11 = temp; }
			if (GreaterThan(ref p8, ref p12)) { temp = p8; p8 = p12; p12 = temp; }
			if (GreaterThan(ref p8, ref p11)) { temp = p8; p8 = p11; p11 = temp; }
			if (GreaterThan(ref p9, ref p13)) { temp = p9; p9 = p13; p13 = temp; }
			if (GreaterThan(ref p10, ref p14)) { temp = p10; p10 = p14; p14 = temp; }
			if (GreaterThan(ref p10, ref p13)) { temp = p10; p10 = p13; p13 = temp; }
			if (GreaterThan(ref p9, ref p11)) { temp = p9; p9 = p11; p11 = temp; }
			if (GreaterThan(ref p10, ref p12)) { temp = p10; p10 = p12; p12 = temp; }
			if (GreaterThan(ref p10, ref p11)) { temp = p10; p10 = p11; p11 = temp; }
			if (GreaterThan(ref p0, ref p8)) { temp = p0; p0 = p8; p8 = temp; }
			if (GreaterThan(ref p0, ref p7)) { temp = p0; p0 = p7; p7 = temp; }
			if (GreaterThan(ref p1, ref p9)) { temp = p1; p1 = p9; p9 = temp; }
			if (GreaterThan(ref p2, ref p10)) { temp = p2; p2 = p10; p10 = temp; }
			if (GreaterThan(ref p2, ref p9)) { temp = p2; p2 = p9; p9 = temp; }
			if (GreaterThan(ref p1, ref p7)) { temp = p1; p1 = p7; p7 = temp; }
			if (GreaterThan(ref p2, ref p8)) { temp = p2; p2 = p8; p8 = temp; }
			if (GreaterThan(ref p2, ref p7)) { temp = p2; p2 = p7; p7 = temp; }
			if (GreaterThan(ref p3, ref p11)) { temp = p3; p3 = p11; p11 = temp; }
			if (GreaterThan(ref p4, ref p12)) { temp = p4; p4 = p12; p12 = temp; }
			if (GreaterThan(ref p4, ref p11)) { temp = p4; p4 = p11; p11 = temp; }
			if (GreaterThan(ref p5, ref p13)) { temp = p5; p5 = p13; p13 = temp; }
			if (GreaterThan(ref p6, ref p14)) { temp = p6; p6 = p14; p14 = temp; }
			if (GreaterThan(ref p6, ref p13)) { temp = p6; p6 = p13; p13 = temp; }
			if (GreaterThan(ref p5, ref p11)) { temp = p5; p5 = p11; p11 = temp; }
			if (GreaterThan(ref p6, ref p12)) { temp = p6; p6 = p12; p12 = temp; }
			if (GreaterThan(ref p6, ref p11)) { temp = p6; p6 = p11; p11 = temp; }
			if (GreaterThan(ref p3, ref p7)) { temp = p3; p3 = p7; p7 = temp; }
			if (GreaterThan(ref p4, ref p8)) { temp = p4; p4 = p8; p8 = temp; }
			if (GreaterThan(ref p4, ref p7)) { temp = p4; p4 = p7; p7 = temp; }
			if (GreaterThan(ref p5, ref p9)) { temp = p5; p5 = p9; p9 = temp; }
			if (GreaterThan(ref p6, ref p10)) { temp = p6; p6 = p10; p10 = temp; }
			if (GreaterThan(ref p6, ref p9)) { temp = p6; p6 = p9; p9 = temp; }
			if (GreaterThan(ref p5, ref p7)) { temp = p5; p5 = p7; p7 = temp; }
			if (GreaterThan(ref p6, ref p8)) { temp = p6; p6 = p8; p8 = temp; }
			if (GreaterThan(ref p6, ref p7)) { temp = p6; p6 = p7; p7 = temp; }
			if (GreaterThan(ref p16, ref p17)) { temp = p16; p16 = p17; p17 = temp; }
			if (GreaterThan(ref p15, ref p17)) { temp = p15; p15 = p17; p17 = temp; }
			if (GreaterThan(ref p15, ref p16)) { temp = p15; p15 = p16; p16 = temp; }
			if (GreaterThan(ref p18, ref p19)) { temp = p18; p18 = p19; p19 = temp; }
			if (GreaterThan(ref p20, ref p21)) { temp = p20; p20 = p21; p21 = temp; }
			if (GreaterThan(ref p18, ref p20)) { temp = p18; p18 = p20; p20 = temp; }
			if (GreaterThan(ref p19, ref p21)) { temp = p19; p19 = p21; p21 = temp; }
			if (GreaterThan(ref p19, ref p20)) { temp = p19; p19 = p20; p20 = temp; }
			if (GreaterThan(ref p15, ref p19)) { temp = p15; p15 = p19; p19 = temp; }
			if (GreaterThan(ref p15, ref p18)) { temp = p15; p15 = p18; p18 = temp; }
			if (GreaterThan(ref p16, ref p20)) { temp = p16; p16 = p20; p20 = temp; }
			if (GreaterThan(ref p17, ref p21)) { temp = p17; p17 = p21; p21 = temp; }
			if (GreaterThan(ref p17, ref p20)) { temp = p17; p17 = p20; p20 = temp; }
			if (GreaterThan(ref p16, ref p18)) { temp = p16; p16 = p18; p18 = temp; }
			if (GreaterThan(ref p17, ref p19)) { temp = p17; p17 = p19; p19 = temp; }
			if (GreaterThan(ref p17, ref p18)) { temp = p17; p17 = p18; p18 = temp; }
			if (GreaterThan(ref p22, ref p23)) { temp = p22; p22 = p23; p23 = temp; }
			if (GreaterThan(ref p24, ref p25)) { temp = p24; p24 = p25; p25 = temp; }
			if (GreaterThan(ref p22, ref p24)) { temp = p22; p22 = p24; p24 = temp; }
			if (GreaterThan(ref p23, ref p25)) { temp = p23; p23 = p25; p25 = temp; }
			if (GreaterThan(ref p23, ref p24)) { temp = p23; p23 = p24; p24 = temp; }
			if (GreaterThan(ref p26, ref p27)) { temp = p26; p26 = p27; p27 = temp; }
			if (GreaterThan(ref p28, ref p29)) { temp = p28; p28 = p29; p29 = temp; }
			if (GreaterThan(ref p26, ref p28)) { temp = p26; p26 = p28; p28 = temp; }
			if (GreaterThan(ref p27, ref p29)) { temp = p27; p27 = p29; p29 = temp; }
			if (GreaterThan(ref p27, ref p28)) { temp = p27; p27 = p28; p28 = temp; }
			if (GreaterThan(ref p22, ref p26)) { temp = p22; p22 = p26; p26 = temp; }
			if (GreaterThan(ref p23, ref p27)) { temp = p23; p23 = p27; p27 = temp; }
			if (GreaterThan(ref p23, ref p26)) { temp = p23; p23 = p26; p26 = temp; }
			if (GreaterThan(ref p24, ref p28)) { temp = p24; p24 = p28; p28 = temp; }
			if (GreaterThan(ref p25, ref p29)) { temp = p25; p25 = p29; p29 = temp; }
			if (GreaterThan(ref p25, ref p28)) { temp = p25; p25 = p28; p28 = temp; }
			if (GreaterThan(ref p24, ref p26)) { temp = p24; p24 = p26; p26 = temp; }
			if (GreaterThan(ref p25, ref p27)) { temp = p25; p25 = p27; p27 = temp; }
			if (GreaterThan(ref p25, ref p26)) { temp = p25; p25 = p26; p26 = temp; }
			if (GreaterThan(ref p15, ref p23)) { temp = p15; p15 = p23; p23 = temp; }
			if (GreaterThan(ref p15, ref p22)) { temp = p15; p15 = p22; p22 = temp; }
			if (GreaterThan(ref p16, ref p24)) { temp = p16; p16 = p24; p24 = temp; }
			if (GreaterThan(ref p17, ref p25)) { temp = p17; p17 = p25; p25 = temp; }
			if (GreaterThan(ref p17, ref p24)) { temp = p17; p17 = p24; p24 = temp; }
			if (GreaterThan(ref p16, ref p22)) { temp = p16; p16 = p22; p22 = temp; }
			if (GreaterThan(ref p17, ref p23)) { temp = p17; p17 = p23; p23 = temp; }
			if (GreaterThan(ref p17, ref p22)) { temp = p17; p17 = p22; p22 = temp; }
			if (GreaterThan(ref p18, ref p26)) { temp = p18; p18 = p26; p26 = temp; }
			if (GreaterThan(ref p19, ref p27)) { temp = p19; p19 = p27; p27 = temp; }
			if (GreaterThan(ref p19, ref p26)) { temp = p19; p19 = p26; p26 = temp; }
			if (GreaterThan(ref p20, ref p28)) { temp = p20; p20 = p28; p28 = temp; }
			if (GreaterThan(ref p21, ref p29)) { temp = p21; p21 = p29; p29 = temp; }
			if (GreaterThan(ref p21, ref p28)) { temp = p21; p21 = p28; p28 = temp; }
			if (GreaterThan(ref p20, ref p26)) { temp = p20; p20 = p26; p26 = temp; }
			if (GreaterThan(ref p21, ref p27)) { temp = p21; p21 = p27; p27 = temp; }
			if (GreaterThan(ref p21, ref p26)) { temp = p21; p21 = p26; p26 = temp; }
			if (GreaterThan(ref p18, ref p22)) { temp = p18; p18 = p22; p22 = temp; }
			if (GreaterThan(ref p19, ref p23)) { temp = p19; p19 = p23; p23 = temp; }
			if (GreaterThan(ref p19, ref p22)) { temp = p19; p19 = p22; p22 = temp; }
			if (GreaterThan(ref p20, ref p24)) { temp = p20; p20 = p24; p24 = temp; }
			if (GreaterThan(ref p21, ref p25)) { temp = p21; p21 = p25; p25 = temp; }
			if (GreaterThan(ref p21, ref p24)) { temp = p21; p21 = p24; p24 = temp; }
			if (GreaterThan(ref p20, ref p22)) { temp = p20; p20 = p22; p22 = temp; }
			if (GreaterThan(ref p21, ref p23)) { temp = p21; p21 = p23; p23 = temp; }
			if (GreaterThan(ref p21, ref p22)) { temp = p21; p21 = p22; p22 = temp; }
			if (GreaterThan(ref p0, ref p16)) { temp = p0; p0 = p16; p16 = temp; }
			if (GreaterThan(ref p0, ref p15)) { temp = p0; p0 = p15; p15 = temp; }
			if (GreaterThan(ref p1, ref p17)) { temp = p1; p1 = p17; p17 = temp; }
			if (GreaterThan(ref p2, ref p18)) { temp = p2; p2 = p18; p18 = temp; }
			if (GreaterThan(ref p2, ref p17)) { temp = p2; p2 = p17; p17 = temp; }
			if (GreaterThan(ref p1, ref p15)) { temp = p1; p1 = p15; p15 = temp; }
			if (GreaterThan(ref p2, ref p16)) { temp = p2; p2 = p16; p16 = temp; }
			if (GreaterThan(ref p2, ref p15)) { temp = p2; p2 = p15; p15 = temp; }
			if (GreaterThan(ref p3, ref p19)) { temp = p3; p3 = p19; p19 = temp; }
			if (GreaterThan(ref p4, ref p20)) { temp = p4; p4 = p20; p20 = temp; }
			if (GreaterThan(ref p4, ref p19)) { temp = p4; p4 = p19; p19 = temp; }
			if (GreaterThan(ref p5, ref p21)) { temp = p5; p5 = p21; p21 = temp; }
			if (GreaterThan(ref p6, ref p22)) { temp = p6; p6 = p22; p22 = temp; }
			if (GreaterThan(ref p6, ref p21)) { temp = p6; p6 = p21; p21 = temp; }
			if (GreaterThan(ref p5, ref p19)) { temp = p5; p5 = p19; p19 = temp; }
			if (GreaterThan(ref p6, ref p20)) { temp = p6; p6 = p20; p20 = temp; }
			if (GreaterThan(ref p6, ref p19)) { temp = p6; p6 = p19; p19 = temp; }
			if (GreaterThan(ref p3, ref p15)) { temp = p3; p3 = p15; p15 = temp; }
			if (GreaterThan(ref p4, ref p16)) { temp = p4; p4 = p16; p16 = temp; }
			if (GreaterThan(ref p4, ref p15)) { temp = p4; p4 = p15; p15 = temp; }
			if (GreaterThan(ref p5, ref p17)) { temp = p5; p5 = p17; p17 = temp; }
			if (GreaterThan(ref p6, ref p18)) { temp = p6; p6 = p18; p18 = temp; }
			if (GreaterThan(ref p6, ref p17)) { temp = p6; p6 = p17; p17 = temp; }
			if (GreaterThan(ref p5, ref p15)) { temp = p5; p5 = p15; p15 = temp; }
			if (GreaterThan(ref p6, ref p16)) { temp = p6; p6 = p16; p16 = temp; }
			if (GreaterThan(ref p6, ref p15)) { temp = p6; p6 = p15; p15 = temp; }
			if (GreaterThan(ref p7, ref p23)) { temp = p7; p7 = p23; p23 = temp; }
			if (GreaterThan(ref p8, ref p24)) { temp = p8; p8 = p24; p24 = temp; }
			if (GreaterThan(ref p8, ref p23)) { temp = p8; p8 = p23; p23 = temp; }
			if (GreaterThan(ref p9, ref p25)) { temp = p9; p9 = p25; p25 = temp; }
			if (GreaterThan(ref p10, ref p26)) { temp = p10; p10 = p26; p26 = temp; }
			if (GreaterThan(ref p10, ref p25)) { temp = p10; p10 = p25; p25 = temp; }
			if (GreaterThan(ref p9, ref p23)) { temp = p9; p9 = p23; p23 = temp; }
			if (GreaterThan(ref p10, ref p24)) { temp = p10; p10 = p24; p24 = temp; }
			if (GreaterThan(ref p10, ref p23)) { temp = p10; p10 = p23; p23 = temp; }
			if (GreaterThan(ref p11, ref p27)) { temp = p11; p11 = p27; p27 = temp; }
			if (GreaterThan(ref p12, ref p28)) { temp = p12; p12 = p28; p28 = temp; }
			if (GreaterThan(ref p12, ref p27)) { temp = p12; p12 = p27; p27 = temp; }
			if (GreaterThan(ref p13, ref p29)) { temp = p13; p13 = p29; p29 = temp; }
			if (GreaterThan(ref p14, ref p29)) { temp = p14; p14 = p29; p29 = temp; }
			if (GreaterThan(ref p13, ref p27)) { temp = p13; p13 = p27; p27 = temp; }
			if (GreaterThan(ref p14, ref p28)) { temp = p14; p14 = p28; p28 = temp; }
			if (GreaterThan(ref p14, ref p27)) { temp = p14; p14 = p27; p27 = temp; }
			if (GreaterThan(ref p11, ref p23)) { temp = p11; p11 = p23; p23 = temp; }
			if (GreaterThan(ref p12, ref p24)) { temp = p12; p12 = p24; p24 = temp; }
			if (GreaterThan(ref p12, ref p23)) { temp = p12; p12 = p23; p23 = temp; }
			if (GreaterThan(ref p13, ref p25)) { temp = p13; p13 = p25; p25 = temp; }
			if (GreaterThan(ref p14, ref p26)) { temp = p14; p14 = p26; p26 = temp; }
			if (GreaterThan(ref p14, ref p25)) { temp = p14; p14 = p25; p25 = temp; }
			if (GreaterThan(ref p13, ref p23)) { temp = p13; p13 = p23; p23 = temp; }
			if (GreaterThan(ref p14, ref p24)) { temp = p14; p14 = p24; p24 = temp; }
			if (GreaterThan(ref p14, ref p23)) { temp = p14; p14 = p23; p23 = temp; }
			if (GreaterThan(ref p7, ref p15)) { temp = p7; p7 = p15; p15 = temp; }
			if (GreaterThan(ref p8, ref p16)) { temp = p8; p8 = p16; p16 = temp; }
			if (GreaterThan(ref p8, ref p15)) { temp = p8; p8 = p15; p15 = temp; }
			if (GreaterThan(ref p9, ref p17)) { temp = p9; p9 = p17; p17 = temp; }
			if (GreaterThan(ref p10, ref p18)) { temp = p10; p10 = p18; p18 = temp; }
			if (GreaterThan(ref p10, ref p17)) { temp = p10; p10 = p17; p17 = temp; }
			if (GreaterThan(ref p9, ref p15)) { temp = p9; p9 = p15; p15 = temp; }
			if (GreaterThan(ref p10, ref p16)) { temp = p10; p10 = p16; p16 = temp; }
			if (GreaterThan(ref p10, ref p15)) { temp = p10; p10 = p15; p15 = temp; }
			if (GreaterThan(ref p11, ref p19)) { temp = p11; p11 = p19; p19 = temp; }
			if (GreaterThan(ref p12, ref p20)) { temp = p12; p12 = p20; p20 = temp; }
			if (GreaterThan(ref p12, ref p19)) { temp = p12; p12 = p19; p19 = temp; }
			if (GreaterThan(ref p13, ref p21)) { temp = p13; p13 = p21; p21 = temp; }
			if (GreaterThan(ref p14, ref p22)) { temp = p14; p14 = p22; p22 = temp; }
			if (GreaterThan(ref p14, ref p21)) { temp = p14; p14 = p21; p21 = temp; }
			if (GreaterThan(ref p13, ref p19)) { temp = p13; p13 = p19; p19 = temp; }
			if (GreaterThan(ref p14, ref p20)) { temp = p14; p14 = p20; p20 = temp; }
			if (GreaterThan(ref p14, ref p19)) { temp = p14; p14 = p19; p19 = temp; }
			if (GreaterThan(ref p11, ref p15)) { temp = p11; p11 = p15; p15 = temp; }
			if (GreaterThan(ref p12, ref p16)) { temp = p12; p12 = p16; p16 = temp; }
			if (GreaterThan(ref p12, ref p15)) { temp = p12; p12 = p15; p15 = temp; }
			if (GreaterThan(ref p13, ref p17)) { temp = p13; p13 = p17; p17 = temp; }
			if (GreaterThan(ref p14, ref p18)) { temp = p14; p14 = p18; p18 = temp; }
			if (GreaterThan(ref p14, ref p17)) { temp = p14; p14 = p17; p17 = temp; }
			if (GreaterThan(ref p13, ref p15)) { temp = p13; p13 = p15; p15 = temp; }
			if (GreaterThan(ref p14, ref p16)) { temp = p14; p14 = p16; p16 = temp; }
			if (GreaterThan(ref p14, ref p15)) { temp = p14; p14 = p15; p15 = temp; }
#endif
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
#if NETSTANDARD1_3
			if (p1.CompareTo(p2) > 0) { temp = p1; p1 = p2; p2 = temp; }
			if (p0.CompareTo(p2) > 0) { temp = p0; p0 = p2; p2 = temp; }
			if (p0.CompareTo(p1) > 0) { temp = p0; p0 = p1; p1 = temp; }
			if (p3.CompareTo(p4) > 0) { temp = p3; p3 = p4; p4 = temp; }
			if (p5.CompareTo(p6) > 0) { temp = p5; p5 = p6; p6 = temp; }
			if (p3.CompareTo(p5) > 0) { temp = p3; p3 = p5; p5 = temp; }
			if (p4.CompareTo(p6) > 0) { temp = p4; p4 = p6; p6 = temp; }
			if (p4.CompareTo(p5) > 0) { temp = p4; p4 = p5; p5 = temp; }
			if (p0.CompareTo(p4) > 0) { temp = p0; p0 = p4; p4 = temp; }
			if (p0.CompareTo(p3) > 0) { temp = p0; p0 = p3; p3 = temp; }
			if (p1.CompareTo(p5) > 0) { temp = p1; p1 = p5; p5 = temp; }
			if (p2.CompareTo(p6) > 0) { temp = p2; p2 = p6; p6 = temp; }
			if (p2.CompareTo(p5) > 0) { temp = p2; p2 = p5; p5 = temp; }
			if (p1.CompareTo(p3) > 0) { temp = p1; p1 = p3; p3 = temp; }
			if (p2.CompareTo(p4) > 0) { temp = p2; p2 = p4; p4 = temp; }
			if (p2.CompareTo(p3) > 0) { temp = p2; p2 = p3; p3 = temp; }
			if (p7.CompareTo(p8) > 0) { temp = p7; p7 = p8; p8 = temp; }
			if (p9.CompareTo(p10) > 0) { temp = p9; p9 = p10; p10 = temp; }
			if (p7.CompareTo(p9) > 0) { temp = p7; p7 = p9; p9 = temp; }
			if (p8.CompareTo(p10) > 0) { temp = p8; p8 = p10; p10 = temp; }
			if (p8.CompareTo(p9) > 0) { temp = p8; p8 = p9; p9 = temp; }
			if (p11.CompareTo(p12) > 0) { temp = p11; p11 = p12; p12 = temp; }
			if (p13.CompareTo(p14) > 0) { temp = p13; p13 = p14; p14 = temp; }
			if (p11.CompareTo(p13) > 0) { temp = p11; p11 = p13; p13 = temp; }
			if (p12.CompareTo(p14) > 0) { temp = p12; p12 = p14; p14 = temp; }
			if (p12.CompareTo(p13) > 0) { temp = p12; p12 = p13; p13 = temp; }
			if (p7.CompareTo(p11) > 0) { temp = p7; p7 = p11; p11 = temp; }
			if (p8.CompareTo(p12) > 0) { temp = p8; p8 = p12; p12 = temp; }
			if (p8.CompareTo(p11) > 0) { temp = p8; p8 = p11; p11 = temp; }
			if (p9.CompareTo(p13) > 0) { temp = p9; p9 = p13; p13 = temp; }
			if (p10.CompareTo(p14) > 0) { temp = p10; p10 = p14; p14 = temp; }
			if (p10.CompareTo(p13) > 0) { temp = p10; p10 = p13; p13 = temp; }
			if (p9.CompareTo(p11) > 0) { temp = p9; p9 = p11; p11 = temp; }
			if (p10.CompareTo(p12) > 0) { temp = p10; p10 = p12; p12 = temp; }
			if (p10.CompareTo(p11) > 0) { temp = p10; p10 = p11; p11 = temp; }
			if (p0.CompareTo(p8) > 0) { temp = p0; p0 = p8; p8 = temp; }
			if (p0.CompareTo(p7) > 0) { temp = p0; p0 = p7; p7 = temp; }
			if (p1.CompareTo(p9) > 0) { temp = p1; p1 = p9; p9 = temp; }
			if (p2.CompareTo(p10) > 0) { temp = p2; p2 = p10; p10 = temp; }
			if (p2.CompareTo(p9) > 0) { temp = p2; p2 = p9; p9 = temp; }
			if (p1.CompareTo(p7) > 0) { temp = p1; p1 = p7; p7 = temp; }
			if (p2.CompareTo(p8) > 0) { temp = p2; p2 = p8; p8 = temp; }
			if (p2.CompareTo(p7) > 0) { temp = p2; p2 = p7; p7 = temp; }
			if (p3.CompareTo(p11) > 0) { temp = p3; p3 = p11; p11 = temp; }
			if (p4.CompareTo(p12) > 0) { temp = p4; p4 = p12; p12 = temp; }
			if (p4.CompareTo(p11) > 0) { temp = p4; p4 = p11; p11 = temp; }
			if (p5.CompareTo(p13) > 0) { temp = p5; p5 = p13; p13 = temp; }
			if (p6.CompareTo(p14) > 0) { temp = p6; p6 = p14; p14 = temp; }
			if (p6.CompareTo(p13) > 0) { temp = p6; p6 = p13; p13 = temp; }
			if (p5.CompareTo(p11) > 0) { temp = p5; p5 = p11; p11 = temp; }
			if (p6.CompareTo(p12) > 0) { temp = p6; p6 = p12; p12 = temp; }
			if (p6.CompareTo(p11) > 0) { temp = p6; p6 = p11; p11 = temp; }
			if (p3.CompareTo(p7) > 0) { temp = p3; p3 = p7; p7 = temp; }
			if (p4.CompareTo(p8) > 0) { temp = p4; p4 = p8; p8 = temp; }
			if (p4.CompareTo(p7) > 0) { temp = p4; p4 = p7; p7 = temp; }
			if (p5.CompareTo(p9) > 0) { temp = p5; p5 = p9; p9 = temp; }
			if (p6.CompareTo(p10) > 0) { temp = p6; p6 = p10; p10 = temp; }
			if (p6.CompareTo(p9) > 0) { temp = p6; p6 = p9; p9 = temp; }
			if (p5.CompareTo(p7) > 0) { temp = p5; p5 = p7; p7 = temp; }
			if (p6.CompareTo(p8) > 0) { temp = p6; p6 = p8; p8 = temp; }
			if (p6.CompareTo(p7) > 0) { temp = p6; p6 = p7; p7 = temp; }
			if (p15.CompareTo(p16) > 0) { temp = p15; p15 = p16; p16 = temp; }
			if (p17.CompareTo(p18) > 0) { temp = p17; p17 = p18; p18 = temp; }
			if (p15.CompareTo(p17) > 0) { temp = p15; p15 = p17; p17 = temp; }
			if (p16.CompareTo(p18) > 0) { temp = p16; p16 = p18; p18 = temp; }
			if (p16.CompareTo(p17) > 0) { temp = p16; p16 = p17; p17 = temp; }
			if (p19.CompareTo(p20) > 0) { temp = p19; p19 = p20; p20 = temp; }
			if (p21.CompareTo(p22) > 0) { temp = p21; p21 = p22; p22 = temp; }
			if (p19.CompareTo(p21) > 0) { temp = p19; p19 = p21; p21 = temp; }
			if (p20.CompareTo(p22) > 0) { temp = p20; p20 = p22; p22 = temp; }
			if (p20.CompareTo(p21) > 0) { temp = p20; p20 = p21; p21 = temp; }
			if (p15.CompareTo(p19) > 0) { temp = p15; p15 = p19; p19 = temp; }
			if (p16.CompareTo(p20) > 0) { temp = p16; p16 = p20; p20 = temp; }
			if (p16.CompareTo(p19) > 0) { temp = p16; p16 = p19; p19 = temp; }
			if (p17.CompareTo(p21) > 0) { temp = p17; p17 = p21; p21 = temp; }
			if (p18.CompareTo(p22) > 0) { temp = p18; p18 = p22; p22 = temp; }
			if (p18.CompareTo(p21) > 0) { temp = p18; p18 = p21; p21 = temp; }
			if (p17.CompareTo(p19) > 0) { temp = p17; p17 = p19; p19 = temp; }
			if (p18.CompareTo(p20) > 0) { temp = p18; p18 = p20; p20 = temp; }
			if (p18.CompareTo(p19) > 0) { temp = p18; p18 = p19; p19 = temp; }
			if (p23.CompareTo(p24) > 0) { temp = p23; p23 = p24; p24 = temp; }
			if (p25.CompareTo(p26) > 0) { temp = p25; p25 = p26; p26 = temp; }
			if (p23.CompareTo(p25) > 0) { temp = p23; p23 = p25; p25 = temp; }
			if (p24.CompareTo(p26) > 0) { temp = p24; p24 = p26; p26 = temp; }
			if (p24.CompareTo(p25) > 0) { temp = p24; p24 = p25; p25 = temp; }
			if (p27.CompareTo(p28) > 0) { temp = p27; p27 = p28; p28 = temp; }
			if (p29.CompareTo(p30) > 0) { temp = p29; p29 = p30; p30 = temp; }
			if (p27.CompareTo(p29) > 0) { temp = p27; p27 = p29; p29 = temp; }
			if (p28.CompareTo(p30) > 0) { temp = p28; p28 = p30; p30 = temp; }
			if (p28.CompareTo(p29) > 0) { temp = p28; p28 = p29; p29 = temp; }
			if (p23.CompareTo(p27) > 0) { temp = p23; p23 = p27; p27 = temp; }
			if (p24.CompareTo(p28) > 0) { temp = p24; p24 = p28; p28 = temp; }
			if (p24.CompareTo(p27) > 0) { temp = p24; p24 = p27; p27 = temp; }
			if (p25.CompareTo(p29) > 0) { temp = p25; p25 = p29; p29 = temp; }
			if (p26.CompareTo(p30) > 0) { temp = p26; p26 = p30; p30 = temp; }
			if (p26.CompareTo(p29) > 0) { temp = p26; p26 = p29; p29 = temp; }
			if (p25.CompareTo(p27) > 0) { temp = p25; p25 = p27; p27 = temp; }
			if (p26.CompareTo(p28) > 0) { temp = p26; p26 = p28; p28 = temp; }
			if (p26.CompareTo(p27) > 0) { temp = p26; p26 = p27; p27 = temp; }
			if (p15.CompareTo(p23) > 0) { temp = p15; p15 = p23; p23 = temp; }
			if (p16.CompareTo(p24) > 0) { temp = p16; p16 = p24; p24 = temp; }
			if (p16.CompareTo(p23) > 0) { temp = p16; p16 = p23; p23 = temp; }
			if (p17.CompareTo(p25) > 0) { temp = p17; p17 = p25; p25 = temp; }
			if (p18.CompareTo(p26) > 0) { temp = p18; p18 = p26; p26 = temp; }
			if (p18.CompareTo(p25) > 0) { temp = p18; p18 = p25; p25 = temp; }
			if (p17.CompareTo(p23) > 0) { temp = p17; p17 = p23; p23 = temp; }
			if (p18.CompareTo(p24) > 0) { temp = p18; p18 = p24; p24 = temp; }
			if (p18.CompareTo(p23) > 0) { temp = p18; p18 = p23; p23 = temp; }
			if (p19.CompareTo(p27) > 0) { temp = p19; p19 = p27; p27 = temp; }
			if (p20.CompareTo(p28) > 0) { temp = p20; p20 = p28; p28 = temp; }
			if (p20.CompareTo(p27) > 0) { temp = p20; p20 = p27; p27 = temp; }
			if (p21.CompareTo(p29) > 0) { temp = p21; p21 = p29; p29 = temp; }
			if (p22.CompareTo(p30) > 0) { temp = p22; p22 = p30; p30 = temp; }
			if (p22.CompareTo(p29) > 0) { temp = p22; p22 = p29; p29 = temp; }
			if (p21.CompareTo(p27) > 0) { temp = p21; p21 = p27; p27 = temp; }
			if (p22.CompareTo(p28) > 0) { temp = p22; p22 = p28; p28 = temp; }
			if (p22.CompareTo(p27) > 0) { temp = p22; p22 = p27; p27 = temp; }
			if (p19.CompareTo(p23) > 0) { temp = p19; p19 = p23; p23 = temp; }
			if (p20.CompareTo(p24) > 0) { temp = p20; p20 = p24; p24 = temp; }
			if (p20.CompareTo(p23) > 0) { temp = p20; p20 = p23; p23 = temp; }
			if (p21.CompareTo(p25) > 0) { temp = p21; p21 = p25; p25 = temp; }
			if (p22.CompareTo(p26) > 0) { temp = p22; p22 = p26; p26 = temp; }
			if (p22.CompareTo(p25) > 0) { temp = p22; p22 = p25; p25 = temp; }
			if (p21.CompareTo(p23) > 0) { temp = p21; p21 = p23; p23 = temp; }
			if (p22.CompareTo(p24) > 0) { temp = p22; p22 = p24; p24 = temp; }
			if (p22.CompareTo(p23) > 0) { temp = p22; p22 = p23; p23 = temp; }
			if (p0.CompareTo(p16) > 0) { temp = p0; p0 = p16; p16 = temp; }
			if (p0.CompareTo(p15) > 0) { temp = p0; p0 = p15; p15 = temp; }
			if (p1.CompareTo(p17) > 0) { temp = p1; p1 = p17; p17 = temp; }
			if (p2.CompareTo(p18) > 0) { temp = p2; p2 = p18; p18 = temp; }
			if (p2.CompareTo(p17) > 0) { temp = p2; p2 = p17; p17 = temp; }
			if (p1.CompareTo(p15) > 0) { temp = p1; p1 = p15; p15 = temp; }
			if (p2.CompareTo(p16) > 0) { temp = p2; p2 = p16; p16 = temp; }
			if (p2.CompareTo(p15) > 0) { temp = p2; p2 = p15; p15 = temp; }
			if (p3.CompareTo(p19) > 0) { temp = p3; p3 = p19; p19 = temp; }
			if (p4.CompareTo(p20) > 0) { temp = p4; p4 = p20; p20 = temp; }
			if (p4.CompareTo(p19) > 0) { temp = p4; p4 = p19; p19 = temp; }
			if (p5.CompareTo(p21) > 0) { temp = p5; p5 = p21; p21 = temp; }
			if (p6.CompareTo(p22) > 0) { temp = p6; p6 = p22; p22 = temp; }
			if (p6.CompareTo(p21) > 0) { temp = p6; p6 = p21; p21 = temp; }
			if (p5.CompareTo(p19) > 0) { temp = p5; p5 = p19; p19 = temp; }
			if (p6.CompareTo(p20) > 0) { temp = p6; p6 = p20; p20 = temp; }
			if (p6.CompareTo(p19) > 0) { temp = p6; p6 = p19; p19 = temp; }
			if (p3.CompareTo(p15) > 0) { temp = p3; p3 = p15; p15 = temp; }
			if (p4.CompareTo(p16) > 0) { temp = p4; p4 = p16; p16 = temp; }
			if (p4.CompareTo(p15) > 0) { temp = p4; p4 = p15; p15 = temp; }
			if (p5.CompareTo(p17) > 0) { temp = p5; p5 = p17; p17 = temp; }
			if (p6.CompareTo(p18) > 0) { temp = p6; p6 = p18; p18 = temp; }
			if (p6.CompareTo(p17) > 0) { temp = p6; p6 = p17; p17 = temp; }
			if (p5.CompareTo(p15) > 0) { temp = p5; p5 = p15; p15 = temp; }
			if (p6.CompareTo(p16) > 0) { temp = p6; p6 = p16; p16 = temp; }
			if (p6.CompareTo(p15) > 0) { temp = p6; p6 = p15; p15 = temp; }
			if (p7.CompareTo(p23) > 0) { temp = p7; p7 = p23; p23 = temp; }
			if (p8.CompareTo(p24) > 0) { temp = p8; p8 = p24; p24 = temp; }
			if (p8.CompareTo(p23) > 0) { temp = p8; p8 = p23; p23 = temp; }
			if (p9.CompareTo(p25) > 0) { temp = p9; p9 = p25; p25 = temp; }
			if (p10.CompareTo(p26) > 0) { temp = p10; p10 = p26; p26 = temp; }
			if (p10.CompareTo(p25) > 0) { temp = p10; p10 = p25; p25 = temp; }
			if (p9.CompareTo(p23) > 0) { temp = p9; p9 = p23; p23 = temp; }
			if (p10.CompareTo(p24) > 0) { temp = p10; p10 = p24; p24 = temp; }
			if (p10.CompareTo(p23) > 0) { temp = p10; p10 = p23; p23 = temp; }
			if (p11.CompareTo(p27) > 0) { temp = p11; p11 = p27; p27 = temp; }
			if (p12.CompareTo(p28) > 0) { temp = p12; p12 = p28; p28 = temp; }
			if (p12.CompareTo(p27) > 0) { temp = p12; p12 = p27; p27 = temp; }
			if (p13.CompareTo(p29) > 0) { temp = p13; p13 = p29; p29 = temp; }
			if (p14.CompareTo(p30) > 0) { temp = p14; p14 = p30; p30 = temp; }
			if (p14.CompareTo(p29) > 0) { temp = p14; p14 = p29; p29 = temp; }
			if (p13.CompareTo(p27) > 0) { temp = p13; p13 = p27; p27 = temp; }
			if (p14.CompareTo(p28) > 0) { temp = p14; p14 = p28; p28 = temp; }
			if (p14.CompareTo(p27) > 0) { temp = p14; p14 = p27; p27 = temp; }
			if (p11.CompareTo(p23) > 0) { temp = p11; p11 = p23; p23 = temp; }
			if (p12.CompareTo(p24) > 0) { temp = p12; p12 = p24; p24 = temp; }
			if (p12.CompareTo(p23) > 0) { temp = p12; p12 = p23; p23 = temp; }
			if (p13.CompareTo(p25) > 0) { temp = p13; p13 = p25; p25 = temp; }
			if (p14.CompareTo(p26) > 0) { temp = p14; p14 = p26; p26 = temp; }
			if (p14.CompareTo(p25) > 0) { temp = p14; p14 = p25; p25 = temp; }
			if (p13.CompareTo(p23) > 0) { temp = p13; p13 = p23; p23 = temp; }
			if (p14.CompareTo(p24) > 0) { temp = p14; p14 = p24; p24 = temp; }
			if (p14.CompareTo(p23) > 0) { temp = p14; p14 = p23; p23 = temp; }
			if (p7.CompareTo(p15) > 0) { temp = p7; p7 = p15; p15 = temp; }
			if (p8.CompareTo(p16) > 0) { temp = p8; p8 = p16; p16 = temp; }
			if (p8.CompareTo(p15) > 0) { temp = p8; p8 = p15; p15 = temp; }
			if (p9.CompareTo(p17) > 0) { temp = p9; p9 = p17; p17 = temp; }
			if (p10.CompareTo(p18) > 0) { temp = p10; p10 = p18; p18 = temp; }
			if (p10.CompareTo(p17) > 0) { temp = p10; p10 = p17; p17 = temp; }
			if (p9.CompareTo(p15) > 0) { temp = p9; p9 = p15; p15 = temp; }
			if (p10.CompareTo(p16) > 0) { temp = p10; p10 = p16; p16 = temp; }
			if (p10.CompareTo(p15) > 0) { temp = p10; p10 = p15; p15 = temp; }
			if (p11.CompareTo(p19) > 0) { temp = p11; p11 = p19; p19 = temp; }
			if (p12.CompareTo(p20) > 0) { temp = p12; p12 = p20; p20 = temp; }
			if (p12.CompareTo(p19) > 0) { temp = p12; p12 = p19; p19 = temp; }
			if (p13.CompareTo(p21) > 0) { temp = p13; p13 = p21; p21 = temp; }
			if (p14.CompareTo(p22) > 0) { temp = p14; p14 = p22; p22 = temp; }
			if (p14.CompareTo(p21) > 0) { temp = p14; p14 = p21; p21 = temp; }
			if (p13.CompareTo(p19) > 0) { temp = p13; p13 = p19; p19 = temp; }
			if (p14.CompareTo(p20) > 0) { temp = p14; p14 = p20; p20 = temp; }
			if (p14.CompareTo(p19) > 0) { temp = p14; p14 = p19; p19 = temp; }
			if (p11.CompareTo(p15) > 0) { temp = p11; p11 = p15; p15 = temp; }
			if (p12.CompareTo(p16) > 0) { temp = p12; p12 = p16; p16 = temp; }
			if (p12.CompareTo(p15) > 0) { temp = p12; p12 = p15; p15 = temp; }
			if (p13.CompareTo(p17) > 0) { temp = p13; p13 = p17; p17 = temp; }
			if (p14.CompareTo(p18) > 0) { temp = p14; p14 = p18; p18 = temp; }
			if (p14.CompareTo(p17) > 0) { temp = p14; p14 = p17; p17 = temp; }
			if (p13.CompareTo(p15) > 0) { temp = p13; p13 = p15; p15 = temp; }
			if (p14.CompareTo(p16) > 0) { temp = p14; p14 = p16; p16 = temp; }
			if (p14.CompareTo(p15) > 0) { temp = p14; p14 = p15; p15 = temp; }
#else
			if (GreaterThan(ref p1, ref p2)) { temp = p1; p1 = p2; p2 = temp; }
			if (GreaterThan(ref p0, ref p2)) { temp = p0; p0 = p2; p2 = temp; }
			if (GreaterThan(ref p0, ref p1)) { temp = p0; p0 = p1; p1 = temp; }
			if (GreaterThan(ref p3, ref p4)) { temp = p3; p3 = p4; p4 = temp; }
			if (GreaterThan(ref p5, ref p6)) { temp = p5; p5 = p6; p6 = temp; }
			if (GreaterThan(ref p3, ref p5)) { temp = p3; p3 = p5; p5 = temp; }
			if (GreaterThan(ref p4, ref p6)) { temp = p4; p4 = p6; p6 = temp; }
			if (GreaterThan(ref p4, ref p5)) { temp = p4; p4 = p5; p5 = temp; }
			if (GreaterThan(ref p0, ref p4)) { temp = p0; p0 = p4; p4 = temp; }
			if (GreaterThan(ref p0, ref p3)) { temp = p0; p0 = p3; p3 = temp; }
			if (GreaterThan(ref p1, ref p5)) { temp = p1; p1 = p5; p5 = temp; }
			if (GreaterThan(ref p2, ref p6)) { temp = p2; p2 = p6; p6 = temp; }
			if (GreaterThan(ref p2, ref p5)) { temp = p2; p2 = p5; p5 = temp; }
			if (GreaterThan(ref p1, ref p3)) { temp = p1; p1 = p3; p3 = temp; }
			if (GreaterThan(ref p2, ref p4)) { temp = p2; p2 = p4; p4 = temp; }
			if (GreaterThan(ref p2, ref p3)) { temp = p2; p2 = p3; p3 = temp; }
			if (GreaterThan(ref p7, ref p8)) { temp = p7; p7 = p8; p8 = temp; }
			if (GreaterThan(ref p9, ref p10)) { temp = p9; p9 = p10; p10 = temp; }
			if (GreaterThan(ref p7, ref p9)) { temp = p7; p7 = p9; p9 = temp; }
			if (GreaterThan(ref p8, ref p10)) { temp = p8; p8 = p10; p10 = temp; }
			if (GreaterThan(ref p8, ref p9)) { temp = p8; p8 = p9; p9 = temp; }
			if (GreaterThan(ref p11, ref p12)) { temp = p11; p11 = p12; p12 = temp; }
			if (GreaterThan(ref p13, ref p14)) { temp = p13; p13 = p14; p14 = temp; }
			if (GreaterThan(ref p11, ref p13)) { temp = p11; p11 = p13; p13 = temp; }
			if (GreaterThan(ref p12, ref p14)) { temp = p12; p12 = p14; p14 = temp; }
			if (GreaterThan(ref p12, ref p13)) { temp = p12; p12 = p13; p13 = temp; }
			if (GreaterThan(ref p7, ref p11)) { temp = p7; p7 = p11; p11 = temp; }
			if (GreaterThan(ref p8, ref p12)) { temp = p8; p8 = p12; p12 = temp; }
			if (GreaterThan(ref p8, ref p11)) { temp = p8; p8 = p11; p11 = temp; }
			if (GreaterThan(ref p9, ref p13)) { temp = p9; p9 = p13; p13 = temp; }
			if (GreaterThan(ref p10, ref p14)) { temp = p10; p10 = p14; p14 = temp; }
			if (GreaterThan(ref p10, ref p13)) { temp = p10; p10 = p13; p13 = temp; }
			if (GreaterThan(ref p9, ref p11)) { temp = p9; p9 = p11; p11 = temp; }
			if (GreaterThan(ref p10, ref p12)) { temp = p10; p10 = p12; p12 = temp; }
			if (GreaterThan(ref p10, ref p11)) { temp = p10; p10 = p11; p11 = temp; }
			if (GreaterThan(ref p0, ref p8)) { temp = p0; p0 = p8; p8 = temp; }
			if (GreaterThan(ref p0, ref p7)) { temp = p0; p0 = p7; p7 = temp; }
			if (GreaterThan(ref p1, ref p9)) { temp = p1; p1 = p9; p9 = temp; }
			if (GreaterThan(ref p2, ref p10)) { temp = p2; p2 = p10; p10 = temp; }
			if (GreaterThan(ref p2, ref p9)) { temp = p2; p2 = p9; p9 = temp; }
			if (GreaterThan(ref p1, ref p7)) { temp = p1; p1 = p7; p7 = temp; }
			if (GreaterThan(ref p2, ref p8)) { temp = p2; p2 = p8; p8 = temp; }
			if (GreaterThan(ref p2, ref p7)) { temp = p2; p2 = p7; p7 = temp; }
			if (GreaterThan(ref p3, ref p11)) { temp = p3; p3 = p11; p11 = temp; }
			if (GreaterThan(ref p4, ref p12)) { temp = p4; p4 = p12; p12 = temp; }
			if (GreaterThan(ref p4, ref p11)) { temp = p4; p4 = p11; p11 = temp; }
			if (GreaterThan(ref p5, ref p13)) { temp = p5; p5 = p13; p13 = temp; }
			if (GreaterThan(ref p6, ref p14)) { temp = p6; p6 = p14; p14 = temp; }
			if (GreaterThan(ref p6, ref p13)) { temp = p6; p6 = p13; p13 = temp; }
			if (GreaterThan(ref p5, ref p11)) { temp = p5; p5 = p11; p11 = temp; }
			if (GreaterThan(ref p6, ref p12)) { temp = p6; p6 = p12; p12 = temp; }
			if (GreaterThan(ref p6, ref p11)) { temp = p6; p6 = p11; p11 = temp; }
			if (GreaterThan(ref p3, ref p7)) { temp = p3; p3 = p7; p7 = temp; }
			if (GreaterThan(ref p4, ref p8)) { temp = p4; p4 = p8; p8 = temp; }
			if (GreaterThan(ref p4, ref p7)) { temp = p4; p4 = p7; p7 = temp; }
			if (GreaterThan(ref p5, ref p9)) { temp = p5; p5 = p9; p9 = temp; }
			if (GreaterThan(ref p6, ref p10)) { temp = p6; p6 = p10; p10 = temp; }
			if (GreaterThan(ref p6, ref p9)) { temp = p6; p6 = p9; p9 = temp; }
			if (GreaterThan(ref p5, ref p7)) { temp = p5; p5 = p7; p7 = temp; }
			if (GreaterThan(ref p6, ref p8)) { temp = p6; p6 = p8; p8 = temp; }
			if (GreaterThan(ref p6, ref p7)) { temp = p6; p6 = p7; p7 = temp; }
			if (GreaterThan(ref p15, ref p16)) { temp = p15; p15 = p16; p16 = temp; }
			if (GreaterThan(ref p17, ref p18)) { temp = p17; p17 = p18; p18 = temp; }
			if (GreaterThan(ref p15, ref p17)) { temp = p15; p15 = p17; p17 = temp; }
			if (GreaterThan(ref p16, ref p18)) { temp = p16; p16 = p18; p18 = temp; }
			if (GreaterThan(ref p16, ref p17)) { temp = p16; p16 = p17; p17 = temp; }
			if (GreaterThan(ref p19, ref p20)) { temp = p19; p19 = p20; p20 = temp; }
			if (GreaterThan(ref p21, ref p22)) { temp = p21; p21 = p22; p22 = temp; }
			if (GreaterThan(ref p19, ref p21)) { temp = p19; p19 = p21; p21 = temp; }
			if (GreaterThan(ref p20, ref p22)) { temp = p20; p20 = p22; p22 = temp; }
			if (GreaterThan(ref p20, ref p21)) { temp = p20; p20 = p21; p21 = temp; }
			if (GreaterThan(ref p15, ref p19)) { temp = p15; p15 = p19; p19 = temp; }
			if (GreaterThan(ref p16, ref p20)) { temp = p16; p16 = p20; p20 = temp; }
			if (GreaterThan(ref p16, ref p19)) { temp = p16; p16 = p19; p19 = temp; }
			if (GreaterThan(ref p17, ref p21)) { temp = p17; p17 = p21; p21 = temp; }
			if (GreaterThan(ref p18, ref p22)) { temp = p18; p18 = p22; p22 = temp; }
			if (GreaterThan(ref p18, ref p21)) { temp = p18; p18 = p21; p21 = temp; }
			if (GreaterThan(ref p17, ref p19)) { temp = p17; p17 = p19; p19 = temp; }
			if (GreaterThan(ref p18, ref p20)) { temp = p18; p18 = p20; p20 = temp; }
			if (GreaterThan(ref p18, ref p19)) { temp = p18; p18 = p19; p19 = temp; }
			if (GreaterThan(ref p23, ref p24)) { temp = p23; p23 = p24; p24 = temp; }
			if (GreaterThan(ref p25, ref p26)) { temp = p25; p25 = p26; p26 = temp; }
			if (GreaterThan(ref p23, ref p25)) { temp = p23; p23 = p25; p25 = temp; }
			if (GreaterThan(ref p24, ref p26)) { temp = p24; p24 = p26; p26 = temp; }
			if (GreaterThan(ref p24, ref p25)) { temp = p24; p24 = p25; p25 = temp; }
			if (GreaterThan(ref p27, ref p28)) { temp = p27; p27 = p28; p28 = temp; }
			if (GreaterThan(ref p29, ref p30)) { temp = p29; p29 = p30; p30 = temp; }
			if (GreaterThan(ref p27, ref p29)) { temp = p27; p27 = p29; p29 = temp; }
			if (GreaterThan(ref p28, ref p30)) { temp = p28; p28 = p30; p30 = temp; }
			if (GreaterThan(ref p28, ref p29)) { temp = p28; p28 = p29; p29 = temp; }
			if (GreaterThan(ref p23, ref p27)) { temp = p23; p23 = p27; p27 = temp; }
			if (GreaterThan(ref p24, ref p28)) { temp = p24; p24 = p28; p28 = temp; }
			if (GreaterThan(ref p24, ref p27)) { temp = p24; p24 = p27; p27 = temp; }
			if (GreaterThan(ref p25, ref p29)) { temp = p25; p25 = p29; p29 = temp; }
			if (GreaterThan(ref p26, ref p30)) { temp = p26; p26 = p30; p30 = temp; }
			if (GreaterThan(ref p26, ref p29)) { temp = p26; p26 = p29; p29 = temp; }
			if (GreaterThan(ref p25, ref p27)) { temp = p25; p25 = p27; p27 = temp; }
			if (GreaterThan(ref p26, ref p28)) { temp = p26; p26 = p28; p28 = temp; }
			if (GreaterThan(ref p26, ref p27)) { temp = p26; p26 = p27; p27 = temp; }
			if (GreaterThan(ref p15, ref p23)) { temp = p15; p15 = p23; p23 = temp; }
			if (GreaterThan(ref p16, ref p24)) { temp = p16; p16 = p24; p24 = temp; }
			if (GreaterThan(ref p16, ref p23)) { temp = p16; p16 = p23; p23 = temp; }
			if (GreaterThan(ref p17, ref p25)) { temp = p17; p17 = p25; p25 = temp; }
			if (GreaterThan(ref p18, ref p26)) { temp = p18; p18 = p26; p26 = temp; }
			if (GreaterThan(ref p18, ref p25)) { temp = p18; p18 = p25; p25 = temp; }
			if (GreaterThan(ref p17, ref p23)) { temp = p17; p17 = p23; p23 = temp; }
			if (GreaterThan(ref p18, ref p24)) { temp = p18; p18 = p24; p24 = temp; }
			if (GreaterThan(ref p18, ref p23)) { temp = p18; p18 = p23; p23 = temp; }
			if (GreaterThan(ref p19, ref p27)) { temp = p19; p19 = p27; p27 = temp; }
			if (GreaterThan(ref p20, ref p28)) { temp = p20; p20 = p28; p28 = temp; }
			if (GreaterThan(ref p20, ref p27)) { temp = p20; p20 = p27; p27 = temp; }
			if (GreaterThan(ref p21, ref p29)) { temp = p21; p21 = p29; p29 = temp; }
			if (GreaterThan(ref p22, ref p30)) { temp = p22; p22 = p30; p30 = temp; }
			if (GreaterThan(ref p22, ref p29)) { temp = p22; p22 = p29; p29 = temp; }
			if (GreaterThan(ref p21, ref p27)) { temp = p21; p21 = p27; p27 = temp; }
			if (GreaterThan(ref p22, ref p28)) { temp = p22; p22 = p28; p28 = temp; }
			if (GreaterThan(ref p22, ref p27)) { temp = p22; p22 = p27; p27 = temp; }
			if (GreaterThan(ref p19, ref p23)) { temp = p19; p19 = p23; p23 = temp; }
			if (GreaterThan(ref p20, ref p24)) { temp = p20; p20 = p24; p24 = temp; }
			if (GreaterThan(ref p20, ref p23)) { temp = p20; p20 = p23; p23 = temp; }
			if (GreaterThan(ref p21, ref p25)) { temp = p21; p21 = p25; p25 = temp; }
			if (GreaterThan(ref p22, ref p26)) { temp = p22; p22 = p26; p26 = temp; }
			if (GreaterThan(ref p22, ref p25)) { temp = p22; p22 = p25; p25 = temp; }
			if (GreaterThan(ref p21, ref p23)) { temp = p21; p21 = p23; p23 = temp; }
			if (GreaterThan(ref p22, ref p24)) { temp = p22; p22 = p24; p24 = temp; }
			if (GreaterThan(ref p22, ref p23)) { temp = p22; p22 = p23; p23 = temp; }
			if (GreaterThan(ref p0, ref p16)) { temp = p0; p0 = p16; p16 = temp; }
			if (GreaterThan(ref p0, ref p15)) { temp = p0; p0 = p15; p15 = temp; }
			if (GreaterThan(ref p1, ref p17)) { temp = p1; p1 = p17; p17 = temp; }
			if (GreaterThan(ref p2, ref p18)) { temp = p2; p2 = p18; p18 = temp; }
			if (GreaterThan(ref p2, ref p17)) { temp = p2; p2 = p17; p17 = temp; }
			if (GreaterThan(ref p1, ref p15)) { temp = p1; p1 = p15; p15 = temp; }
			if (GreaterThan(ref p2, ref p16)) { temp = p2; p2 = p16; p16 = temp; }
			if (GreaterThan(ref p2, ref p15)) { temp = p2; p2 = p15; p15 = temp; }
			if (GreaterThan(ref p3, ref p19)) { temp = p3; p3 = p19; p19 = temp; }
			if (GreaterThan(ref p4, ref p20)) { temp = p4; p4 = p20; p20 = temp; }
			if (GreaterThan(ref p4, ref p19)) { temp = p4; p4 = p19; p19 = temp; }
			if (GreaterThan(ref p5, ref p21)) { temp = p5; p5 = p21; p21 = temp; }
			if (GreaterThan(ref p6, ref p22)) { temp = p6; p6 = p22; p22 = temp; }
			if (GreaterThan(ref p6, ref p21)) { temp = p6; p6 = p21; p21 = temp; }
			if (GreaterThan(ref p5, ref p19)) { temp = p5; p5 = p19; p19 = temp; }
			if (GreaterThan(ref p6, ref p20)) { temp = p6; p6 = p20; p20 = temp; }
			if (GreaterThan(ref p6, ref p19)) { temp = p6; p6 = p19; p19 = temp; }
			if (GreaterThan(ref p3, ref p15)) { temp = p3; p3 = p15; p15 = temp; }
			if (GreaterThan(ref p4, ref p16)) { temp = p4; p4 = p16; p16 = temp; }
			if (GreaterThan(ref p4, ref p15)) { temp = p4; p4 = p15; p15 = temp; }
			if (GreaterThan(ref p5, ref p17)) { temp = p5; p5 = p17; p17 = temp; }
			if (GreaterThan(ref p6, ref p18)) { temp = p6; p6 = p18; p18 = temp; }
			if (GreaterThan(ref p6, ref p17)) { temp = p6; p6 = p17; p17 = temp; }
			if (GreaterThan(ref p5, ref p15)) { temp = p5; p5 = p15; p15 = temp; }
			if (GreaterThan(ref p6, ref p16)) { temp = p6; p6 = p16; p16 = temp; }
			if (GreaterThan(ref p6, ref p15)) { temp = p6; p6 = p15; p15 = temp; }
			if (GreaterThan(ref p7, ref p23)) { temp = p7; p7 = p23; p23 = temp; }
			if (GreaterThan(ref p8, ref p24)) { temp = p8; p8 = p24; p24 = temp; }
			if (GreaterThan(ref p8, ref p23)) { temp = p8; p8 = p23; p23 = temp; }
			if (GreaterThan(ref p9, ref p25)) { temp = p9; p9 = p25; p25 = temp; }
			if (GreaterThan(ref p10, ref p26)) { temp = p10; p10 = p26; p26 = temp; }
			if (GreaterThan(ref p10, ref p25)) { temp = p10; p10 = p25; p25 = temp; }
			if (GreaterThan(ref p9, ref p23)) { temp = p9; p9 = p23; p23 = temp; }
			if (GreaterThan(ref p10, ref p24)) { temp = p10; p10 = p24; p24 = temp; }
			if (GreaterThan(ref p10, ref p23)) { temp = p10; p10 = p23; p23 = temp; }
			if (GreaterThan(ref p11, ref p27)) { temp = p11; p11 = p27; p27 = temp; }
			if (GreaterThan(ref p12, ref p28)) { temp = p12; p12 = p28; p28 = temp; }
			if (GreaterThan(ref p12, ref p27)) { temp = p12; p12 = p27; p27 = temp; }
			if (GreaterThan(ref p13, ref p29)) { temp = p13; p13 = p29; p29 = temp; }
			if (GreaterThan(ref p14, ref p30)) { temp = p14; p14 = p30; p30 = temp; }
			if (GreaterThan(ref p14, ref p29)) { temp = p14; p14 = p29; p29 = temp; }
			if (GreaterThan(ref p13, ref p27)) { temp = p13; p13 = p27; p27 = temp; }
			if (GreaterThan(ref p14, ref p28)) { temp = p14; p14 = p28; p28 = temp; }
			if (GreaterThan(ref p14, ref p27)) { temp = p14; p14 = p27; p27 = temp; }
			if (GreaterThan(ref p11, ref p23)) { temp = p11; p11 = p23; p23 = temp; }
			if (GreaterThan(ref p12, ref p24)) { temp = p12; p12 = p24; p24 = temp; }
			if (GreaterThan(ref p12, ref p23)) { temp = p12; p12 = p23; p23 = temp; }
			if (GreaterThan(ref p13, ref p25)) { temp = p13; p13 = p25; p25 = temp; }
			if (GreaterThan(ref p14, ref p26)) { temp = p14; p14 = p26; p26 = temp; }
			if (GreaterThan(ref p14, ref p25)) { temp = p14; p14 = p25; p25 = temp; }
			if (GreaterThan(ref p13, ref p23)) { temp = p13; p13 = p23; p23 = temp; }
			if (GreaterThan(ref p14, ref p24)) { temp = p14; p14 = p24; p24 = temp; }
			if (GreaterThan(ref p14, ref p23)) { temp = p14; p14 = p23; p23 = temp; }
			if (GreaterThan(ref p7, ref p15)) { temp = p7; p7 = p15; p15 = temp; }
			if (GreaterThan(ref p8, ref p16)) { temp = p8; p8 = p16; p16 = temp; }
			if (GreaterThan(ref p8, ref p15)) { temp = p8; p8 = p15; p15 = temp; }
			if (GreaterThan(ref p9, ref p17)) { temp = p9; p9 = p17; p17 = temp; }
			if (GreaterThan(ref p10, ref p18)) { temp = p10; p10 = p18; p18 = temp; }
			if (GreaterThan(ref p10, ref p17)) { temp = p10; p10 = p17; p17 = temp; }
			if (GreaterThan(ref p9, ref p15)) { temp = p9; p9 = p15; p15 = temp; }
			if (GreaterThan(ref p10, ref p16)) { temp = p10; p10 = p16; p16 = temp; }
			if (GreaterThan(ref p10, ref p15)) { temp = p10; p10 = p15; p15 = temp; }
			if (GreaterThan(ref p11, ref p19)) { temp = p11; p11 = p19; p19 = temp; }
			if (GreaterThan(ref p12, ref p20)) { temp = p12; p12 = p20; p20 = temp; }
			if (GreaterThan(ref p12, ref p19)) { temp = p12; p12 = p19; p19 = temp; }
			if (GreaterThan(ref p13, ref p21)) { temp = p13; p13 = p21; p21 = temp; }
			if (GreaterThan(ref p14, ref p22)) { temp = p14; p14 = p22; p22 = temp; }
			if (GreaterThan(ref p14, ref p21)) { temp = p14; p14 = p21; p21 = temp; }
			if (GreaterThan(ref p13, ref p19)) { temp = p13; p13 = p19; p19 = temp; }
			if (GreaterThan(ref p14, ref p20)) { temp = p14; p14 = p20; p20 = temp; }
			if (GreaterThan(ref p14, ref p19)) { temp = p14; p14 = p19; p19 = temp; }
			if (GreaterThan(ref p11, ref p15)) { temp = p11; p11 = p15; p15 = temp; }
			if (GreaterThan(ref p12, ref p16)) { temp = p12; p12 = p16; p16 = temp; }
			if (GreaterThan(ref p12, ref p15)) { temp = p12; p12 = p15; p15 = temp; }
			if (GreaterThan(ref p13, ref p17)) { temp = p13; p13 = p17; p17 = temp; }
			if (GreaterThan(ref p14, ref p18)) { temp = p14; p14 = p18; p18 = temp; }
			if (GreaterThan(ref p14, ref p17)) { temp = p14; p14 = p17; p17 = temp; }
			if (GreaterThan(ref p13, ref p15)) { temp = p13; p13 = p15; p15 = temp; }
			if (GreaterThan(ref p14, ref p16)) { temp = p14; p14 = p16; p16 = temp; }
			if (GreaterThan(ref p14, ref p15)) { temp = p14; p14 = p15; p15 = temp; }
#endif
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
#if NETSTANDARD1_3
			if (p0.CompareTo(p1) > 0) { temp = p0; p0 = p1; p1 = temp; }
			if (p2.CompareTo(p3) > 0) { temp = p2; p2 = p3; p3 = temp; }
			if (p0.CompareTo(p2) > 0) { temp = p0; p0 = p2; p2 = temp; }
			if (p1.CompareTo(p3) > 0) { temp = p1; p1 = p3; p3 = temp; }
			if (p1.CompareTo(p2) > 0) { temp = p1; p1 = p2; p2 = temp; }
			if (p4.CompareTo(p5) > 0) { temp = p4; p4 = p5; p5 = temp; }
			if (p6.CompareTo(p7) > 0) { temp = p6; p6 = p7; p7 = temp; }
			if (p4.CompareTo(p6) > 0) { temp = p4; p4 = p6; p6 = temp; }
			if (p5.CompareTo(p7) > 0) { temp = p5; p5 = p7; p7 = temp; }
			if (p5.CompareTo(p6) > 0) { temp = p5; p5 = p6; p6 = temp; }
			if (p0.CompareTo(p4) > 0) { temp = p0; p0 = p4; p4 = temp; }
			if (p1.CompareTo(p5) > 0) { temp = p1; p1 = p5; p5 = temp; }
			if (p1.CompareTo(p4) > 0) { temp = p1; p1 = p4; p4 = temp; }
			if (p2.CompareTo(p6) > 0) { temp = p2; p2 = p6; p6 = temp; }
			if (p3.CompareTo(p7) > 0) { temp = p3; p3 = p7; p7 = temp; }
			if (p3.CompareTo(p6) > 0) { temp = p3; p3 = p6; p6 = temp; }
			if (p2.CompareTo(p4) > 0) { temp = p2; p2 = p4; p4 = temp; }
			if (p3.CompareTo(p5) > 0) { temp = p3; p3 = p5; p5 = temp; }
			if (p3.CompareTo(p4) > 0) { temp = p3; p3 = p4; p4 = temp; }
			if (p8.CompareTo(p9) > 0) { temp = p8; p8 = p9; p9 = temp; }
			if (p10.CompareTo(p11) > 0) { temp = p10; p10 = p11; p11 = temp; }
			if (p8.CompareTo(p10) > 0) { temp = p8; p8 = p10; p10 = temp; }
			if (p9.CompareTo(p11) > 0) { temp = p9; p9 = p11; p11 = temp; }
			if (p9.CompareTo(p10) > 0) { temp = p9; p9 = p10; p10 = temp; }
			if (p12.CompareTo(p13) > 0) { temp = p12; p12 = p13; p13 = temp; }
			if (p14.CompareTo(p15) > 0) { temp = p14; p14 = p15; p15 = temp; }
			if (p12.CompareTo(p14) > 0) { temp = p12; p12 = p14; p14 = temp; }
			if (p13.CompareTo(p15) > 0) { temp = p13; p13 = p15; p15 = temp; }
			if (p13.CompareTo(p14) > 0) { temp = p13; p13 = p14; p14 = temp; }
			if (p8.CompareTo(p12) > 0) { temp = p8; p8 = p12; p12 = temp; }
			if (p9.CompareTo(p13) > 0) { temp = p9; p9 = p13; p13 = temp; }
			if (p9.CompareTo(p12) > 0) { temp = p9; p9 = p12; p12 = temp; }
			if (p10.CompareTo(p14) > 0) { temp = p10; p10 = p14; p14 = temp; }
			if (p11.CompareTo(p15) > 0) { temp = p11; p11 = p15; p15 = temp; }
			if (p11.CompareTo(p14) > 0) { temp = p11; p11 = p14; p14 = temp; }
			if (p10.CompareTo(p12) > 0) { temp = p10; p10 = p12; p12 = temp; }
			if (p11.CompareTo(p13) > 0) { temp = p11; p11 = p13; p13 = temp; }
			if (p11.CompareTo(p12) > 0) { temp = p11; p11 = p12; p12 = temp; }
			if (p0.CompareTo(p8) > 0) { temp = p0; p0 = p8; p8 = temp; }
			if (p1.CompareTo(p9) > 0) { temp = p1; p1 = p9; p9 = temp; }
			if (p1.CompareTo(p8) > 0) { temp = p1; p1 = p8; p8 = temp; }
			if (p2.CompareTo(p10) > 0) { temp = p2; p2 = p10; p10 = temp; }
			if (p3.CompareTo(p11) > 0) { temp = p3; p3 = p11; p11 = temp; }
			if (p3.CompareTo(p10) > 0) { temp = p3; p3 = p10; p10 = temp; }
			if (p2.CompareTo(p8) > 0) { temp = p2; p2 = p8; p8 = temp; }
			if (p3.CompareTo(p9) > 0) { temp = p3; p3 = p9; p9 = temp; }
			if (p3.CompareTo(p8) > 0) { temp = p3; p3 = p8; p8 = temp; }
			if (p4.CompareTo(p12) > 0) { temp = p4; p4 = p12; p12 = temp; }
			if (p5.CompareTo(p13) > 0) { temp = p5; p5 = p13; p13 = temp; }
			if (p5.CompareTo(p12) > 0) { temp = p5; p5 = p12; p12 = temp; }
			if (p6.CompareTo(p14) > 0) { temp = p6; p6 = p14; p14 = temp; }
			if (p7.CompareTo(p15) > 0) { temp = p7; p7 = p15; p15 = temp; }
			if (p7.CompareTo(p14) > 0) { temp = p7; p7 = p14; p14 = temp; }
			if (p6.CompareTo(p12) > 0) { temp = p6; p6 = p12; p12 = temp; }
			if (p7.CompareTo(p13) > 0) { temp = p7; p7 = p13; p13 = temp; }
			if (p7.CompareTo(p12) > 0) { temp = p7; p7 = p12; p12 = temp; }
			if (p4.CompareTo(p8) > 0) { temp = p4; p4 = p8; p8 = temp; }
			if (p5.CompareTo(p9) > 0) { temp = p5; p5 = p9; p9 = temp; }
			if (p5.CompareTo(p8) > 0) { temp = p5; p5 = p8; p8 = temp; }
			if (p6.CompareTo(p10) > 0) { temp = p6; p6 = p10; p10 = temp; }
			if (p7.CompareTo(p11) > 0) { temp = p7; p7 = p11; p11 = temp; }
			if (p7.CompareTo(p10) > 0) { temp = p7; p7 = p10; p10 = temp; }
			if (p6.CompareTo(p8) > 0) { temp = p6; p6 = p8; p8 = temp; }
			if (p7.CompareTo(p9) > 0) { temp = p7; p7 = p9; p9 = temp; }
			if (p7.CompareTo(p8) > 0) { temp = p7; p7 = p8; p8 = temp; }
			if (p16.CompareTo(p17) > 0) { temp = p16; p16 = p17; p17 = temp; }
			if (p18.CompareTo(p19) > 0) { temp = p18; p18 = p19; p19 = temp; }
			if (p16.CompareTo(p18) > 0) { temp = p16; p16 = p18; p18 = temp; }
			if (p17.CompareTo(p19) > 0) { temp = p17; p17 = p19; p19 = temp; }
			if (p17.CompareTo(p18) > 0) { temp = p17; p17 = p18; p18 = temp; }
			if (p20.CompareTo(p21) > 0) { temp = p20; p20 = p21; p21 = temp; }
			if (p22.CompareTo(p23) > 0) { temp = p22; p22 = p23; p23 = temp; }
			if (p20.CompareTo(p22) > 0) { temp = p20; p20 = p22; p22 = temp; }
			if (p21.CompareTo(p23) > 0) { temp = p21; p21 = p23; p23 = temp; }
			if (p21.CompareTo(p22) > 0) { temp = p21; p21 = p22; p22 = temp; }
			if (p16.CompareTo(p20) > 0) { temp = p16; p16 = p20; p20 = temp; }
			if (p17.CompareTo(p21) > 0) { temp = p17; p17 = p21; p21 = temp; }
			if (p17.CompareTo(p20) > 0) { temp = p17; p17 = p20; p20 = temp; }
			if (p18.CompareTo(p22) > 0) { temp = p18; p18 = p22; p22 = temp; }
			if (p19.CompareTo(p23) > 0) { temp = p19; p19 = p23; p23 = temp; }
			if (p19.CompareTo(p22) > 0) { temp = p19; p19 = p22; p22 = temp; }
			if (p18.CompareTo(p20) > 0) { temp = p18; p18 = p20; p20 = temp; }
			if (p19.CompareTo(p21) > 0) { temp = p19; p19 = p21; p21 = temp; }
			if (p19.CompareTo(p20) > 0) { temp = p19; p19 = p20; p20 = temp; }
			if (p24.CompareTo(p25) > 0) { temp = p24; p24 = p25; p25 = temp; }
			if (p26.CompareTo(p27) > 0) { temp = p26; p26 = p27; p27 = temp; }
			if (p24.CompareTo(p26) > 0) { temp = p24; p24 = p26; p26 = temp; }
			if (p25.CompareTo(p27) > 0) { temp = p25; p25 = p27; p27 = temp; }
			if (p25.CompareTo(p26) > 0) { temp = p25; p25 = p26; p26 = temp; }
			if (p28.CompareTo(p29) > 0) { temp = p28; p28 = p29; p29 = temp; }
			if (p30.CompareTo(p31) > 0) { temp = p30; p30 = p31; p31 = temp; }
			if (p28.CompareTo(p30) > 0) { temp = p28; p28 = p30; p30 = temp; }
			if (p29.CompareTo(p31) > 0) { temp = p29; p29 = p31; p31 = temp; }
			if (p29.CompareTo(p30) > 0) { temp = p29; p29 = p30; p30 = temp; }
			if (p24.CompareTo(p28) > 0) { temp = p24; p24 = p28; p28 = temp; }
			if (p25.CompareTo(p29) > 0) { temp = p25; p25 = p29; p29 = temp; }
			if (p25.CompareTo(p28) > 0) { temp = p25; p25 = p28; p28 = temp; }
			if (p26.CompareTo(p30) > 0) { temp = p26; p26 = p30; p30 = temp; }
			if (p27.CompareTo(p31) > 0) { temp = p27; p27 = p31; p31 = temp; }
			if (p27.CompareTo(p30) > 0) { temp = p27; p27 = p30; p30 = temp; }
			if (p26.CompareTo(p28) > 0) { temp = p26; p26 = p28; p28 = temp; }
			if (p27.CompareTo(p29) > 0) { temp = p27; p27 = p29; p29 = temp; }
			if (p27.CompareTo(p28) > 0) { temp = p27; p27 = p28; p28 = temp; }
			if (p16.CompareTo(p24) > 0) { temp = p16; p16 = p24; p24 = temp; }
			if (p17.CompareTo(p25) > 0) { temp = p17; p17 = p25; p25 = temp; }
			if (p17.CompareTo(p24) > 0) { temp = p17; p17 = p24; p24 = temp; }
			if (p18.CompareTo(p26) > 0) { temp = p18; p18 = p26; p26 = temp; }
			if (p19.CompareTo(p27) > 0) { temp = p19; p19 = p27; p27 = temp; }
			if (p19.CompareTo(p26) > 0) { temp = p19; p19 = p26; p26 = temp; }
			if (p18.CompareTo(p24) > 0) { temp = p18; p18 = p24; p24 = temp; }
			if (p19.CompareTo(p25) > 0) { temp = p19; p19 = p25; p25 = temp; }
			if (p19.CompareTo(p24) > 0) { temp = p19; p19 = p24; p24 = temp; }
			if (p20.CompareTo(p28) > 0) { temp = p20; p20 = p28; p28 = temp; }
			if (p21.CompareTo(p29) > 0) { temp = p21; p21 = p29; p29 = temp; }
			if (p21.CompareTo(p28) > 0) { temp = p21; p21 = p28; p28 = temp; }
			if (p22.CompareTo(p30) > 0) { temp = p22; p22 = p30; p30 = temp; }
			if (p23.CompareTo(p31) > 0) { temp = p23; p23 = p31; p31 = temp; }
			if (p23.CompareTo(p30) > 0) { temp = p23; p23 = p30; p30 = temp; }
			if (p22.CompareTo(p28) > 0) { temp = p22; p22 = p28; p28 = temp; }
			if (p23.CompareTo(p29) > 0) { temp = p23; p23 = p29; p29 = temp; }
			if (p23.CompareTo(p28) > 0) { temp = p23; p23 = p28; p28 = temp; }
			if (p20.CompareTo(p24) > 0) { temp = p20; p20 = p24; p24 = temp; }
			if (p21.CompareTo(p25) > 0) { temp = p21; p21 = p25; p25 = temp; }
			if (p21.CompareTo(p24) > 0) { temp = p21; p21 = p24; p24 = temp; }
			if (p22.CompareTo(p26) > 0) { temp = p22; p22 = p26; p26 = temp; }
			if (p23.CompareTo(p27) > 0) { temp = p23; p23 = p27; p27 = temp; }
			if (p23.CompareTo(p26) > 0) { temp = p23; p23 = p26; p26 = temp; }
			if (p22.CompareTo(p24) > 0) { temp = p22; p22 = p24; p24 = temp; }
			if (p23.CompareTo(p25) > 0) { temp = p23; p23 = p25; p25 = temp; }
			if (p23.CompareTo(p24) > 0) { temp = p23; p23 = p24; p24 = temp; }
			if (p0.CompareTo(p16) > 0) { temp = p0; p0 = p16; p16 = temp; }
			if (p1.CompareTo(p17) > 0) { temp = p1; p1 = p17; p17 = temp; }
			if (p1.CompareTo(p16) > 0) { temp = p1; p1 = p16; p16 = temp; }
			if (p2.CompareTo(p18) > 0) { temp = p2; p2 = p18; p18 = temp; }
			if (p3.CompareTo(p19) > 0) { temp = p3; p3 = p19; p19 = temp; }
			if (p3.CompareTo(p18) > 0) { temp = p3; p3 = p18; p18 = temp; }
			if (p2.CompareTo(p16) > 0) { temp = p2; p2 = p16; p16 = temp; }
			if (p3.CompareTo(p17) > 0) { temp = p3; p3 = p17; p17 = temp; }
			if (p3.CompareTo(p16) > 0) { temp = p3; p3 = p16; p16 = temp; }
			if (p4.CompareTo(p20) > 0) { temp = p4; p4 = p20; p20 = temp; }
			if (p5.CompareTo(p21) > 0) { temp = p5; p5 = p21; p21 = temp; }
			if (p5.CompareTo(p20) > 0) { temp = p5; p5 = p20; p20 = temp; }
			if (p6.CompareTo(p22) > 0) { temp = p6; p6 = p22; p22 = temp; }
			if (p7.CompareTo(p23) > 0) { temp = p7; p7 = p23; p23 = temp; }
			if (p7.CompareTo(p22) > 0) { temp = p7; p7 = p22; p22 = temp; }
			if (p6.CompareTo(p20) > 0) { temp = p6; p6 = p20; p20 = temp; }
			if (p7.CompareTo(p21) > 0) { temp = p7; p7 = p21; p21 = temp; }
			if (p7.CompareTo(p20) > 0) { temp = p7; p7 = p20; p20 = temp; }
			if (p4.CompareTo(p16) > 0) { temp = p4; p4 = p16; p16 = temp; }
			if (p5.CompareTo(p17) > 0) { temp = p5; p5 = p17; p17 = temp; }
			if (p5.CompareTo(p16) > 0) { temp = p5; p5 = p16; p16 = temp; }
			if (p6.CompareTo(p18) > 0) { temp = p6; p6 = p18; p18 = temp; }
			if (p7.CompareTo(p19) > 0) { temp = p7; p7 = p19; p19 = temp; }
			if (p7.CompareTo(p18) > 0) { temp = p7; p7 = p18; p18 = temp; }
			if (p6.CompareTo(p16) > 0) { temp = p6; p6 = p16; p16 = temp; }
			if (p7.CompareTo(p17) > 0) { temp = p7; p7 = p17; p17 = temp; }
			if (p7.CompareTo(p16) > 0) { temp = p7; p7 = p16; p16 = temp; }
			if (p8.CompareTo(p24) > 0) { temp = p8; p8 = p24; p24 = temp; }
			if (p9.CompareTo(p25) > 0) { temp = p9; p9 = p25; p25 = temp; }
			if (p9.CompareTo(p24) > 0) { temp = p9; p9 = p24; p24 = temp; }
			if (p10.CompareTo(p26) > 0) { temp = p10; p10 = p26; p26 = temp; }
			if (p11.CompareTo(p27) > 0) { temp = p11; p11 = p27; p27 = temp; }
			if (p11.CompareTo(p26) > 0) { temp = p11; p11 = p26; p26 = temp; }
			if (p10.CompareTo(p24) > 0) { temp = p10; p10 = p24; p24 = temp; }
			if (p11.CompareTo(p25) > 0) { temp = p11; p11 = p25; p25 = temp; }
			if (p11.CompareTo(p24) > 0) { temp = p11; p11 = p24; p24 = temp; }
			if (p12.CompareTo(p28) > 0) { temp = p12; p12 = p28; p28 = temp; }
			if (p13.CompareTo(p29) > 0) { temp = p13; p13 = p29; p29 = temp; }
			if (p13.CompareTo(p28) > 0) { temp = p13; p13 = p28; p28 = temp; }
			if (p14.CompareTo(p30) > 0) { temp = p14; p14 = p30; p30 = temp; }
			if (p15.CompareTo(p31) > 0) { temp = p15; p15 = p31; p31 = temp; }
			if (p15.CompareTo(p30) > 0) { temp = p15; p15 = p30; p30 = temp; }
			if (p14.CompareTo(p28) > 0) { temp = p14; p14 = p28; p28 = temp; }
			if (p15.CompareTo(p29) > 0) { temp = p15; p15 = p29; p29 = temp; }
			if (p15.CompareTo(p28) > 0) { temp = p15; p15 = p28; p28 = temp; }
			if (p12.CompareTo(p24) > 0) { temp = p12; p12 = p24; p24 = temp; }
			if (p13.CompareTo(p25) > 0) { temp = p13; p13 = p25; p25 = temp; }
			if (p13.CompareTo(p24) > 0) { temp = p13; p13 = p24; p24 = temp; }
			if (p14.CompareTo(p26) > 0) { temp = p14; p14 = p26; p26 = temp; }
			if (p15.CompareTo(p27) > 0) { temp = p15; p15 = p27; p27 = temp; }
			if (p15.CompareTo(p26) > 0) { temp = p15; p15 = p26; p26 = temp; }
			if (p14.CompareTo(p24) > 0) { temp = p14; p14 = p24; p24 = temp; }
			if (p15.CompareTo(p25) > 0) { temp = p15; p15 = p25; p25 = temp; }
			if (p15.CompareTo(p24) > 0) { temp = p15; p15 = p24; p24 = temp; }
			if (p8.CompareTo(p16) > 0) { temp = p8; p8 = p16; p16 = temp; }
			if (p9.CompareTo(p17) > 0) { temp = p9; p9 = p17; p17 = temp; }
			if (p9.CompareTo(p16) > 0) { temp = p9; p9 = p16; p16 = temp; }
			if (p10.CompareTo(p18) > 0) { temp = p10; p10 = p18; p18 = temp; }
			if (p11.CompareTo(p19) > 0) { temp = p11; p11 = p19; p19 = temp; }
			if (p11.CompareTo(p18) > 0) { temp = p11; p11 = p18; p18 = temp; }
			if (p10.CompareTo(p16) > 0) { temp = p10; p10 = p16; p16 = temp; }
			if (p11.CompareTo(p17) > 0) { temp = p11; p11 = p17; p17 = temp; }
			if (p11.CompareTo(p16) > 0) { temp = p11; p11 = p16; p16 = temp; }
			if (p12.CompareTo(p20) > 0) { temp = p12; p12 = p20; p20 = temp; }
			if (p13.CompareTo(p21) > 0) { temp = p13; p13 = p21; p21 = temp; }
			if (p13.CompareTo(p20) > 0) { temp = p13; p13 = p20; p20 = temp; }
			if (p14.CompareTo(p22) > 0) { temp = p14; p14 = p22; p22 = temp; }
			if (p15.CompareTo(p23) > 0) { temp = p15; p15 = p23; p23 = temp; }
			if (p15.CompareTo(p22) > 0) { temp = p15; p15 = p22; p22 = temp; }
			if (p14.CompareTo(p20) > 0) { temp = p14; p14 = p20; p20 = temp; }
			if (p15.CompareTo(p21) > 0) { temp = p15; p15 = p21; p21 = temp; }
			if (p15.CompareTo(p20) > 0) { temp = p15; p15 = p20; p20 = temp; }
			if (p12.CompareTo(p16) > 0) { temp = p12; p12 = p16; p16 = temp; }
			if (p13.CompareTo(p17) > 0) { temp = p13; p13 = p17; p17 = temp; }
			if (p13.CompareTo(p16) > 0) { temp = p13; p13 = p16; p16 = temp; }
			if (p14.CompareTo(p18) > 0) { temp = p14; p14 = p18; p18 = temp; }
			if (p15.CompareTo(p19) > 0) { temp = p15; p15 = p19; p19 = temp; }
			if (p15.CompareTo(p18) > 0) { temp = p15; p15 = p18; p18 = temp; }
			if (p14.CompareTo(p16) > 0) { temp = p14; p14 = p16; p16 = temp; }
			if (p15.CompareTo(p17) > 0) { temp = p15; p15 = p17; p17 = temp; }
			if (p15.CompareTo(p16) > 0) { temp = p15; p15 = p16; p16 = temp; }
#else
			if (GreaterThan(ref p0, ref p1)) { temp = p0; p0 = p1; p1 = temp; }
			if (GreaterThan(ref p2, ref p3)) { temp = p2; p2 = p3; p3 = temp; }
			if (GreaterThan(ref p0, ref p2)) { temp = p0; p0 = p2; p2 = temp; }
			if (GreaterThan(ref p1, ref p3)) { temp = p1; p1 = p3; p3 = temp; }
			if (GreaterThan(ref p1, ref p2)) { temp = p1; p1 = p2; p2 = temp; }
			if (GreaterThan(ref p4, ref p5)) { temp = p4; p4 = p5; p5 = temp; }
			if (GreaterThan(ref p6, ref p7)) { temp = p6; p6 = p7; p7 = temp; }
			if (GreaterThan(ref p4, ref p6)) { temp = p4; p4 = p6; p6 = temp; }
			if (GreaterThan(ref p5, ref p7)) { temp = p5; p5 = p7; p7 = temp; }
			if (GreaterThan(ref p5, ref p6)) { temp = p5; p5 = p6; p6 = temp; }
			if (GreaterThan(ref p0, ref p4)) { temp = p0; p0 = p4; p4 = temp; }
			if (GreaterThan(ref p1, ref p5)) { temp = p1; p1 = p5; p5 = temp; }
			if (GreaterThan(ref p1, ref p4)) { temp = p1; p1 = p4; p4 = temp; }
			if (GreaterThan(ref p2, ref p6)) { temp = p2; p2 = p6; p6 = temp; }
			if (GreaterThan(ref p3, ref p7)) { temp = p3; p3 = p7; p7 = temp; }
			if (GreaterThan(ref p3, ref p6)) { temp = p3; p3 = p6; p6 = temp; }
			if (GreaterThan(ref p2, ref p4)) { temp = p2; p2 = p4; p4 = temp; }
			if (GreaterThan(ref p3, ref p5)) { temp = p3; p3 = p5; p5 = temp; }
			if (GreaterThan(ref p3, ref p4)) { temp = p3; p3 = p4; p4 = temp; }
			if (GreaterThan(ref p8, ref p9)) { temp = p8; p8 = p9; p9 = temp; }
			if (GreaterThan(ref p10, ref p11)) { temp = p10; p10 = p11; p11 = temp; }
			if (GreaterThan(ref p8, ref p10)) { temp = p8; p8 = p10; p10 = temp; }
			if (GreaterThan(ref p9, ref p11)) { temp = p9; p9 = p11; p11 = temp; }
			if (GreaterThan(ref p9, ref p10)) { temp = p9; p9 = p10; p10 = temp; }
			if (GreaterThan(ref p12, ref p13)) { temp = p12; p12 = p13; p13 = temp; }
			if (GreaterThan(ref p14, ref p15)) { temp = p14; p14 = p15; p15 = temp; }
			if (GreaterThan(ref p12, ref p14)) { temp = p12; p12 = p14; p14 = temp; }
			if (GreaterThan(ref p13, ref p15)) { temp = p13; p13 = p15; p15 = temp; }
			if (GreaterThan(ref p13, ref p14)) { temp = p13; p13 = p14; p14 = temp; }
			if (GreaterThan(ref p8, ref p12)) { temp = p8; p8 = p12; p12 = temp; }
			if (GreaterThan(ref p9, ref p13)) { temp = p9; p9 = p13; p13 = temp; }
			if (GreaterThan(ref p9, ref p12)) { temp = p9; p9 = p12; p12 = temp; }
			if (GreaterThan(ref p10, ref p14)) { temp = p10; p10 = p14; p14 = temp; }
			if (GreaterThan(ref p11, ref p15)) { temp = p11; p11 = p15; p15 = temp; }
			if (GreaterThan(ref p11, ref p14)) { temp = p11; p11 = p14; p14 = temp; }
			if (GreaterThan(ref p10, ref p12)) { temp = p10; p10 = p12; p12 = temp; }
			if (GreaterThan(ref p11, ref p13)) { temp = p11; p11 = p13; p13 = temp; }
			if (GreaterThan(ref p11, ref p12)) { temp = p11; p11 = p12; p12 = temp; }
			if (GreaterThan(ref p0, ref p8)) { temp = p0; p0 = p8; p8 = temp; }
			if (GreaterThan(ref p1, ref p9)) { temp = p1; p1 = p9; p9 = temp; }
			if (GreaterThan(ref p1, ref p8)) { temp = p1; p1 = p8; p8 = temp; }
			if (GreaterThan(ref p2, ref p10)) { temp = p2; p2 = p10; p10 = temp; }
			if (GreaterThan(ref p3, ref p11)) { temp = p3; p3 = p11; p11 = temp; }
			if (GreaterThan(ref p3, ref p10)) { temp = p3; p3 = p10; p10 = temp; }
			if (GreaterThan(ref p2, ref p8)) { temp = p2; p2 = p8; p8 = temp; }
			if (GreaterThan(ref p3, ref p9)) { temp = p3; p3 = p9; p9 = temp; }
			if (GreaterThan(ref p3, ref p8)) { temp = p3; p3 = p8; p8 = temp; }
			if (GreaterThan(ref p4, ref p12)) { temp = p4; p4 = p12; p12 = temp; }
			if (GreaterThan(ref p5, ref p13)) { temp = p5; p5 = p13; p13 = temp; }
			if (GreaterThan(ref p5, ref p12)) { temp = p5; p5 = p12; p12 = temp; }
			if (GreaterThan(ref p6, ref p14)) { temp = p6; p6 = p14; p14 = temp; }
			if (GreaterThan(ref p7, ref p15)) { temp = p7; p7 = p15; p15 = temp; }
			if (GreaterThan(ref p7, ref p14)) { temp = p7; p7 = p14; p14 = temp; }
			if (GreaterThan(ref p6, ref p12)) { temp = p6; p6 = p12; p12 = temp; }
			if (GreaterThan(ref p7, ref p13)) { temp = p7; p7 = p13; p13 = temp; }
			if (GreaterThan(ref p7, ref p12)) { temp = p7; p7 = p12; p12 = temp; }
			if (GreaterThan(ref p4, ref p8)) { temp = p4; p4 = p8; p8 = temp; }
			if (GreaterThan(ref p5, ref p9)) { temp = p5; p5 = p9; p9 = temp; }
			if (GreaterThan(ref p5, ref p8)) { temp = p5; p5 = p8; p8 = temp; }
			if (GreaterThan(ref p6, ref p10)) { temp = p6; p6 = p10; p10 = temp; }
			if (GreaterThan(ref p7, ref p11)) { temp = p7; p7 = p11; p11 = temp; }
			if (GreaterThan(ref p7, ref p10)) { temp = p7; p7 = p10; p10 = temp; }
			if (GreaterThan(ref p6, ref p8)) { temp = p6; p6 = p8; p8 = temp; }
			if (GreaterThan(ref p7, ref p9)) { temp = p7; p7 = p9; p9 = temp; }
			if (GreaterThan(ref p7, ref p8)) { temp = p7; p7 = p8; p8 = temp; }
			if (GreaterThan(ref p16, ref p17)) { temp = p16; p16 = p17; p17 = temp; }
			if (GreaterThan(ref p18, ref p19)) { temp = p18; p18 = p19; p19 = temp; }
			if (GreaterThan(ref p16, ref p18)) { temp = p16; p16 = p18; p18 = temp; }
			if (GreaterThan(ref p17, ref p19)) { temp = p17; p17 = p19; p19 = temp; }
			if (GreaterThan(ref p17, ref p18)) { temp = p17; p17 = p18; p18 = temp; }
			if (GreaterThan(ref p20, ref p21)) { temp = p20; p20 = p21; p21 = temp; }
			if (GreaterThan(ref p22, ref p23)) { temp = p22; p22 = p23; p23 = temp; }
			if (GreaterThan(ref p20, ref p22)) { temp = p20; p20 = p22; p22 = temp; }
			if (GreaterThan(ref p21, ref p23)) { temp = p21; p21 = p23; p23 = temp; }
			if (GreaterThan(ref p21, ref p22)) { temp = p21; p21 = p22; p22 = temp; }
			if (GreaterThan(ref p16, ref p20)) { temp = p16; p16 = p20; p20 = temp; }
			if (GreaterThan(ref p17, ref p21)) { temp = p17; p17 = p21; p21 = temp; }
			if (GreaterThan(ref p17, ref p20)) { temp = p17; p17 = p20; p20 = temp; }
			if (GreaterThan(ref p18, ref p22)) { temp = p18; p18 = p22; p22 = temp; }
			if (GreaterThan(ref p19, ref p23)) { temp = p19; p19 = p23; p23 = temp; }
			if (GreaterThan(ref p19, ref p22)) { temp = p19; p19 = p22; p22 = temp; }
			if (GreaterThan(ref p18, ref p20)) { temp = p18; p18 = p20; p20 = temp; }
			if (GreaterThan(ref p19, ref p21)) { temp = p19; p19 = p21; p21 = temp; }
			if (GreaterThan(ref p19, ref p20)) { temp = p19; p19 = p20; p20 = temp; }
			if (GreaterThan(ref p24, ref p25)) { temp = p24; p24 = p25; p25 = temp; }
			if (GreaterThan(ref p26, ref p27)) { temp = p26; p26 = p27; p27 = temp; }
			if (GreaterThan(ref p24, ref p26)) { temp = p24; p24 = p26; p26 = temp; }
			if (GreaterThan(ref p25, ref p27)) { temp = p25; p25 = p27; p27 = temp; }
			if (GreaterThan(ref p25, ref p26)) { temp = p25; p25 = p26; p26 = temp; }
			if (GreaterThan(ref p28, ref p29)) { temp = p28; p28 = p29; p29 = temp; }
			if (GreaterThan(ref p30, ref p31)) { temp = p30; p30 = p31; p31 = temp; }
			if (GreaterThan(ref p28, ref p30)) { temp = p28; p28 = p30; p30 = temp; }
			if (GreaterThan(ref p29, ref p31)) { temp = p29; p29 = p31; p31 = temp; }
			if (GreaterThan(ref p29, ref p30)) { temp = p29; p29 = p30; p30 = temp; }
			if (GreaterThan(ref p24, ref p28)) { temp = p24; p24 = p28; p28 = temp; }
			if (GreaterThan(ref p25, ref p29)) { temp = p25; p25 = p29; p29 = temp; }
			if (GreaterThan(ref p25, ref p28)) { temp = p25; p25 = p28; p28 = temp; }
			if (GreaterThan(ref p26, ref p30)) { temp = p26; p26 = p30; p30 = temp; }
			if (GreaterThan(ref p27, ref p31)) { temp = p27; p27 = p31; p31 = temp; }
			if (GreaterThan(ref p27, ref p30)) { temp = p27; p27 = p30; p30 = temp; }
			if (GreaterThan(ref p26, ref p28)) { temp = p26; p26 = p28; p28 = temp; }
			if (GreaterThan(ref p27, ref p29)) { temp = p27; p27 = p29; p29 = temp; }
			if (GreaterThan(ref p27, ref p28)) { temp = p27; p27 = p28; p28 = temp; }
			if (GreaterThan(ref p16, ref p24)) { temp = p16; p16 = p24; p24 = temp; }
			if (GreaterThan(ref p17, ref p25)) { temp = p17; p17 = p25; p25 = temp; }
			if (GreaterThan(ref p17, ref p24)) { temp = p17; p17 = p24; p24 = temp; }
			if (GreaterThan(ref p18, ref p26)) { temp = p18; p18 = p26; p26 = temp; }
			if (GreaterThan(ref p19, ref p27)) { temp = p19; p19 = p27; p27 = temp; }
			if (GreaterThan(ref p19, ref p26)) { temp = p19; p19 = p26; p26 = temp; }
			if (GreaterThan(ref p18, ref p24)) { temp = p18; p18 = p24; p24 = temp; }
			if (GreaterThan(ref p19, ref p25)) { temp = p19; p19 = p25; p25 = temp; }
			if (GreaterThan(ref p19, ref p24)) { temp = p19; p19 = p24; p24 = temp; }
			if (GreaterThan(ref p20, ref p28)) { temp = p20; p20 = p28; p28 = temp; }
			if (GreaterThan(ref p21, ref p29)) { temp = p21; p21 = p29; p29 = temp; }
			if (GreaterThan(ref p21, ref p28)) { temp = p21; p21 = p28; p28 = temp; }
			if (GreaterThan(ref p22, ref p30)) { temp = p22; p22 = p30; p30 = temp; }
			if (GreaterThan(ref p23, ref p31)) { temp = p23; p23 = p31; p31 = temp; }
			if (GreaterThan(ref p23, ref p30)) { temp = p23; p23 = p30; p30 = temp; }
			if (GreaterThan(ref p22, ref p28)) { temp = p22; p22 = p28; p28 = temp; }
			if (GreaterThan(ref p23, ref p29)) { temp = p23; p23 = p29; p29 = temp; }
			if (GreaterThan(ref p23, ref p28)) { temp = p23; p23 = p28; p28 = temp; }
			if (GreaterThan(ref p20, ref p24)) { temp = p20; p20 = p24; p24 = temp; }
			if (GreaterThan(ref p21, ref p25)) { temp = p21; p21 = p25; p25 = temp; }
			if (GreaterThan(ref p21, ref p24)) { temp = p21; p21 = p24; p24 = temp; }
			if (GreaterThan(ref p22, ref p26)) { temp = p22; p22 = p26; p26 = temp; }
			if (GreaterThan(ref p23, ref p27)) { temp = p23; p23 = p27; p27 = temp; }
			if (GreaterThan(ref p23, ref p26)) { temp = p23; p23 = p26; p26 = temp; }
			if (GreaterThan(ref p22, ref p24)) { temp = p22; p22 = p24; p24 = temp; }
			if (GreaterThan(ref p23, ref p25)) { temp = p23; p23 = p25; p25 = temp; }
			if (GreaterThan(ref p23, ref p24)) { temp = p23; p23 = p24; p24 = temp; }
			if (GreaterThan(ref p0, ref p16)) { temp = p0; p0 = p16; p16 = temp; }
			if (GreaterThan(ref p1, ref p17)) { temp = p1; p1 = p17; p17 = temp; }
			if (GreaterThan(ref p1, ref p16)) { temp = p1; p1 = p16; p16 = temp; }
			if (GreaterThan(ref p2, ref p18)) { temp = p2; p2 = p18; p18 = temp; }
			if (GreaterThan(ref p3, ref p19)) { temp = p3; p3 = p19; p19 = temp; }
			if (GreaterThan(ref p3, ref p18)) { temp = p3; p3 = p18; p18 = temp; }
			if (GreaterThan(ref p2, ref p16)) { temp = p2; p2 = p16; p16 = temp; }
			if (GreaterThan(ref p3, ref p17)) { temp = p3; p3 = p17; p17 = temp; }
			if (GreaterThan(ref p3, ref p16)) { temp = p3; p3 = p16; p16 = temp; }
			if (GreaterThan(ref p4, ref p20)) { temp = p4; p4 = p20; p20 = temp; }
			if (GreaterThan(ref p5, ref p21)) { temp = p5; p5 = p21; p21 = temp; }
			if (GreaterThan(ref p5, ref p20)) { temp = p5; p5 = p20; p20 = temp; }
			if (GreaterThan(ref p6, ref p22)) { temp = p6; p6 = p22; p22 = temp; }
			if (GreaterThan(ref p7, ref p23)) { temp = p7; p7 = p23; p23 = temp; }
			if (GreaterThan(ref p7, ref p22)) { temp = p7; p7 = p22; p22 = temp; }
			if (GreaterThan(ref p6, ref p20)) { temp = p6; p6 = p20; p20 = temp; }
			if (GreaterThan(ref p7, ref p21)) { temp = p7; p7 = p21; p21 = temp; }
			if (GreaterThan(ref p7, ref p20)) { temp = p7; p7 = p20; p20 = temp; }
			if (GreaterThan(ref p4, ref p16)) { temp = p4; p4 = p16; p16 = temp; }
			if (GreaterThan(ref p5, ref p17)) { temp = p5; p5 = p17; p17 = temp; }
			if (GreaterThan(ref p5, ref p16)) { temp = p5; p5 = p16; p16 = temp; }
			if (GreaterThan(ref p6, ref p18)) { temp = p6; p6 = p18; p18 = temp; }
			if (GreaterThan(ref p7, ref p19)) { temp = p7; p7 = p19; p19 = temp; }
			if (GreaterThan(ref p7, ref p18)) { temp = p7; p7 = p18; p18 = temp; }
			if (GreaterThan(ref p6, ref p16)) { temp = p6; p6 = p16; p16 = temp; }
			if (GreaterThan(ref p7, ref p17)) { temp = p7; p7 = p17; p17 = temp; }
			if (GreaterThan(ref p7, ref p16)) { temp = p7; p7 = p16; p16 = temp; }
			if (GreaterThan(ref p8, ref p24)) { temp = p8; p8 = p24; p24 = temp; }
			if (GreaterThan(ref p9, ref p25)) { temp = p9; p9 = p25; p25 = temp; }
			if (GreaterThan(ref p9, ref p24)) { temp = p9; p9 = p24; p24 = temp; }
			if (GreaterThan(ref p10, ref p26)) { temp = p10; p10 = p26; p26 = temp; }
			if (GreaterThan(ref p11, ref p27)) { temp = p11; p11 = p27; p27 = temp; }
			if (GreaterThan(ref p11, ref p26)) { temp = p11; p11 = p26; p26 = temp; }
			if (GreaterThan(ref p10, ref p24)) { temp = p10; p10 = p24; p24 = temp; }
			if (GreaterThan(ref p11, ref p25)) { temp = p11; p11 = p25; p25 = temp; }
			if (GreaterThan(ref p11, ref p24)) { temp = p11; p11 = p24; p24 = temp; }
			if (GreaterThan(ref p12, ref p28)) { temp = p12; p12 = p28; p28 = temp; }
			if (GreaterThan(ref p13, ref p29)) { temp = p13; p13 = p29; p29 = temp; }
			if (GreaterThan(ref p13, ref p28)) { temp = p13; p13 = p28; p28 = temp; }
			if (GreaterThan(ref p14, ref p30)) { temp = p14; p14 = p30; p30 = temp; }
			if (GreaterThan(ref p15, ref p31)) { temp = p15; p15 = p31; p31 = temp; }
			if (GreaterThan(ref p15, ref p30)) { temp = p15; p15 = p30; p30 = temp; }
			if (GreaterThan(ref p14, ref p28)) { temp = p14; p14 = p28; p28 = temp; }
			if (GreaterThan(ref p15, ref p29)) { temp = p15; p15 = p29; p29 = temp; }
			if (GreaterThan(ref p15, ref p28)) { temp = p15; p15 = p28; p28 = temp; }
			if (GreaterThan(ref p12, ref p24)) { temp = p12; p12 = p24; p24 = temp; }
			if (GreaterThan(ref p13, ref p25)) { temp = p13; p13 = p25; p25 = temp; }
			if (GreaterThan(ref p13, ref p24)) { temp = p13; p13 = p24; p24 = temp; }
			if (GreaterThan(ref p14, ref p26)) { temp = p14; p14 = p26; p26 = temp; }
			if (GreaterThan(ref p15, ref p27)) { temp = p15; p15 = p27; p27 = temp; }
			if (GreaterThan(ref p15, ref p26)) { temp = p15; p15 = p26; p26 = temp; }
			if (GreaterThan(ref p14, ref p24)) { temp = p14; p14 = p24; p24 = temp; }
			if (GreaterThan(ref p15, ref p25)) { temp = p15; p15 = p25; p25 = temp; }
			if (GreaterThan(ref p15, ref p24)) { temp = p15; p15 = p24; p24 = temp; }
			if (GreaterThan(ref p8, ref p16)) { temp = p8; p8 = p16; p16 = temp; }
			if (GreaterThan(ref p9, ref p17)) { temp = p9; p9 = p17; p17 = temp; }
			if (GreaterThan(ref p9, ref p16)) { temp = p9; p9 = p16; p16 = temp; }
			if (GreaterThan(ref p10, ref p18)) { temp = p10; p10 = p18; p18 = temp; }
			if (GreaterThan(ref p11, ref p19)) { temp = p11; p11 = p19; p19 = temp; }
			if (GreaterThan(ref p11, ref p18)) { temp = p11; p11 = p18; p18 = temp; }
			if (GreaterThan(ref p10, ref p16)) { temp = p10; p10 = p16; p16 = temp; }
			if (GreaterThan(ref p11, ref p17)) { temp = p11; p11 = p17; p17 = temp; }
			if (GreaterThan(ref p11, ref p16)) { temp = p11; p11 = p16; p16 = temp; }
			if (GreaterThan(ref p12, ref p20)) { temp = p12; p12 = p20; p20 = temp; }
			if (GreaterThan(ref p13, ref p21)) { temp = p13; p13 = p21; p21 = temp; }
			if (GreaterThan(ref p13, ref p20)) { temp = p13; p13 = p20; p20 = temp; }
			if (GreaterThan(ref p14, ref p22)) { temp = p14; p14 = p22; p22 = temp; }
			if (GreaterThan(ref p15, ref p23)) { temp = p15; p15 = p23; p23 = temp; }
			if (GreaterThan(ref p15, ref p22)) { temp = p15; p15 = p22; p22 = temp; }
			if (GreaterThan(ref p14, ref p20)) { temp = p14; p14 = p20; p20 = temp; }
			if (GreaterThan(ref p15, ref p21)) { temp = p15; p15 = p21; p21 = temp; }
			if (GreaterThan(ref p15, ref p20)) { temp = p15; p15 = p20; p20 = temp; }
			if (GreaterThan(ref p12, ref p16)) { temp = p12; p12 = p16; p16 = temp; }
			if (GreaterThan(ref p13, ref p17)) { temp = p13; p13 = p17; p17 = temp; }
			if (GreaterThan(ref p13, ref p16)) { temp = p13; p13 = p16; p16 = temp; }
			if (GreaterThan(ref p14, ref p18)) { temp = p14; p14 = p18; p18 = temp; }
			if (GreaterThan(ref p15, ref p19)) { temp = p15; p15 = p19; p19 = temp; }
			if (GreaterThan(ref p15, ref p18)) { temp = p15; p15 = p18; p18 = temp; }
			if (GreaterThan(ref p14, ref p16)) { temp = p14; p14 = p16; p16 = temp; }
			if (GreaterThan(ref p15, ref p17)) { temp = p15; p15 = p17; p17 = temp; }
			if (GreaterThan(ref p15, ref p16)) { temp = p15; p15 = p16; p16 = temp; }
#endif
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
	}
}