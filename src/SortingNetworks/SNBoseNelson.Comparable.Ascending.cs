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

			SwapIfGreater(ref p1, ref p2);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p0, ref p1);
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

			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p2, ref p3);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p1, ref p3);
			SwapIfGreater(ref p1, ref p2);
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

			SwapIfGreater(ref p1, ref p2);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p4, ref p5);
			SwapIfGreater(ref p3, ref p5);
			SwapIfGreater(ref p3, ref p4);
			SwapIfGreater(ref p0, ref p3);
			SwapIfGreater(ref p1, ref p4);
			SwapIfGreater(ref p2, ref p5);
			SwapIfGreater(ref p2, ref p4);
			SwapIfGreater(ref p1, ref p3);
			SwapIfGreater(ref p2, ref p3);
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
				default: throw new ArgumentOutOfRangeException(nameof(length), $"Sorting network length `{length}` must be between `{MinLength}` and `{MaxLength}`.");
			}
		}
	}
}