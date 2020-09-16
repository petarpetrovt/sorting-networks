namespace SortingNetworks
{
	using System;
	using System.Runtime.CompilerServices;

	partial class SNBoseNelson
	{
		/// <summary>
		/// Sorts a collection of 2 elements in descending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		public static void Sort2Descending<T>(ref T p0, Comparison<T> comparison)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);

			SwapIfLesser(ref p0, ref p1, comparison);
		}

		/// <summary>
		/// Sorts a collection of 3 elements in descending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		public static void Sort3Descending<T>(ref T p0, Comparison<T> comparison)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);

			SwapIfLesser(ref p1, ref p2, comparison);
			SwapIfLesser(ref p0, ref p2, comparison);
			SwapIfLesser(ref p0, ref p1, comparison);
		}

		/// <summary>
		/// Sorts a collection of 4 elements in descending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		public static void Sort4Descending<T>(ref T p0, Comparison<T> comparison)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);

			SwapIfLesser(ref p0, ref p1, comparison);
			SwapIfLesser(ref p2, ref p3, comparison);
			SwapIfLesser(ref p0, ref p2, comparison);
			SwapIfLesser(ref p1, ref p3, comparison);
			SwapIfLesser(ref p1, ref p2, comparison);
		}

		/// <summary>
		/// Sorts a collection of 5 elements in descending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		public static void Sort5Descending<T>(ref T p0, Comparison<T> comparison)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);

			SwapIfLesser(ref p0, ref p1, comparison);
			SwapIfLesser(ref p3, ref p4, comparison);
			SwapIfLesser(ref p2, ref p4, comparison);
			SwapIfLesser(ref p2, ref p3, comparison);
			SwapIfLesser(ref p0, ref p3, comparison);
			SwapIfLesser(ref p0, ref p2, comparison);
			SwapIfLesser(ref p1, ref p4, comparison);
			SwapIfLesser(ref p1, ref p3, comparison);
			SwapIfLesser(ref p1, ref p2, comparison);
		}

		/// <summary>
		/// Sorts a collection of 6 elements in descending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		public static void Sort6Descending<T>(ref T p0, Comparison<T> comparison)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);
			ref var p5 = ref Unsafe.Add(ref p0, 5);

			SwapIfLesser(ref p1, ref p2, comparison);
			SwapIfLesser(ref p0, ref p2, comparison);
			SwapIfLesser(ref p0, ref p1, comparison);
			SwapIfLesser(ref p4, ref p5, comparison);
			SwapIfLesser(ref p3, ref p5, comparison);
			SwapIfLesser(ref p3, ref p4, comparison);
			SwapIfLesser(ref p0, ref p3, comparison);
			SwapIfLesser(ref p1, ref p4, comparison);
			SwapIfLesser(ref p2, ref p5, comparison);
			SwapIfLesser(ref p2, ref p4, comparison);
			SwapIfLesser(ref p1, ref p3, comparison);
			SwapIfLesser(ref p2, ref p3, comparison);
		}

		/// <summary>
		/// Sorts a collection of 7 elements in descending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		public static void Sort7Descending<T>(ref T p0, Comparison<T> comparison)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);
			ref var p5 = ref Unsafe.Add(ref p0, 5);
			ref var p6 = ref Unsafe.Add(ref p0, 6);

			SwapIfLesser(ref p1, ref p2, comparison);
			SwapIfLesser(ref p0, ref p2, comparison);
			SwapIfLesser(ref p0, ref p1, comparison);
			SwapIfLesser(ref p3, ref p4, comparison);
			SwapIfLesser(ref p5, ref p6, comparison);
			SwapIfLesser(ref p3, ref p5, comparison);
			SwapIfLesser(ref p4, ref p6, comparison);
			SwapIfLesser(ref p4, ref p5, comparison);
			SwapIfLesser(ref p0, ref p4, comparison);
			SwapIfLesser(ref p0, ref p3, comparison);
			SwapIfLesser(ref p1, ref p5, comparison);
			SwapIfLesser(ref p2, ref p6, comparison);
			SwapIfLesser(ref p2, ref p5, comparison);
			SwapIfLesser(ref p1, ref p3, comparison);
			SwapIfLesser(ref p2, ref p4, comparison);
			SwapIfLesser(ref p2, ref p3, comparison);
		}

		/// <summary>
		/// Sorts a collection of 8 elements in descending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		public static void Sort8Descending<T>(ref T p0, Comparison<T> comparison)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);
			ref var p5 = ref Unsafe.Add(ref p0, 5);
			ref var p6 = ref Unsafe.Add(ref p0, 6);
			ref var p7 = ref Unsafe.Add(ref p0, 7);

			SwapIfLesser(ref p0, ref p1, comparison);
			SwapIfLesser(ref p2, ref p3, comparison);
			SwapIfLesser(ref p0, ref p2, comparison);
			SwapIfLesser(ref p1, ref p3, comparison);
			SwapIfLesser(ref p1, ref p2, comparison);
			SwapIfLesser(ref p4, ref p5, comparison);
			SwapIfLesser(ref p6, ref p7, comparison);
			SwapIfLesser(ref p4, ref p6, comparison);
			SwapIfLesser(ref p5, ref p7, comparison);
			SwapIfLesser(ref p5, ref p6, comparison);
			SwapIfLesser(ref p0, ref p4, comparison);
			SwapIfLesser(ref p1, ref p5, comparison);
			SwapIfLesser(ref p1, ref p4, comparison);
			SwapIfLesser(ref p2, ref p6, comparison);
			SwapIfLesser(ref p3, ref p7, comparison);
			SwapIfLesser(ref p3, ref p6, comparison);
			SwapIfLesser(ref p2, ref p4, comparison);
			SwapIfLesser(ref p3, ref p5, comparison);
			SwapIfLesser(ref p3, ref p4, comparison);
		}

		/// <summary>
		/// Sorts a collection of specified number of elements in descending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the collection.</typeparam>
		/// <param name="p0">the reference to the first element of the collection</param>
		/// <param name="length">the length of the collection</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		/// <exception cref="ArgumentNullException">comparison is null</exception>
		/// <exception cref="ArgumentOutOfRangeException">collection length is not between <see cref="MinLength"/> and <see cref="MaxLength"/></exception>
		public static void SortDescending<T>(ref T p0, in int length, Comparison<T> comparison)
		{
			if (comparison is null)
			{
				throw new ArgumentNullException(nameof(comparison));
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
				default: throw new ArgumentOutOfRangeException(nameof(length), $"Sorting network length `{length}` must be between `{MinLength}` and `{MaxLength}`.");
			}
		}
	}
}