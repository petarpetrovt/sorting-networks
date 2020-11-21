namespace SortingNetworks
{
	using System;
	using System.Runtime.InteropServices;

	/// <summary>
	/// Contains generic sorting methods for collections with length from <see cref="MinLength"/> to <see cref="MaxLength"/>.
	/// </summary>
	public static class SN
	{
		/// <summary>
		/// The minimum supported length for sorting.
		/// </summary>
		public const int MinLength = 2;

		/// <summary>
		/// The maximum supported length for sorting.
		/// </summary>
		public const int MaxLength = 32;

		/// <summary>
		/// Sorts the elements in an entire <see cref="Array"/> in ascending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element of the <see cref="Array"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the array.</typeparam>
		/// <param name="array">The one-dimensional, zero-based <see cref="Array"/> to sort.</param>
		/// <exception cref="ArgumentNullException">array is null</exception>
		/// <exception cref="ArgumentOutOfRangeException">array length is not between <see cref="MinLength"/> and <see cref="MaxLength"/></exception>
		public static void SortAscending<T>(T[] array)
			where T : IComparable<T>
		{
			if (array is null)
			{
				throw new ArgumentNullException(nameof(array));
			}

#if NET5_0
			ref T p0 = ref MemoryMarshal.GetArrayDataReference(array);
#else
			ref T p0 = ref array[0];
#endif

			switch (array.Length)
			{
				case 2: SNBoseNelson.Sort2Ascending(ref p0); break;
				case 3: SNBoseNelson.Sort3Ascending(ref p0); break;
				case 4: SNBoseNelson.Sort4Ascending(ref p0); break;
				case 5: SNBoseNelson.Sort5Ascending(ref p0); break;
				case 6: SNBoseNelson.Sort6Ascending(ref p0); break;
				case 7: SNBoseNelson.Sort7Ascending(ref p0); break;
				case 8: SNBoseNelson.Sort8Ascending(ref p0); break;
				case 9: SNBestKnown.Sort9Ascending(ref p0); break;
				case 10: SNBestKnown.Sort10Ascending(ref p0); break;
				case 11: SNBestKnown.Sort11Ascending(ref p0); break;
				case 12: SNBestKnown.Sort12Ascending(ref p0); break;
				case 13: SNBestKnown.Sort13Ascending(ref p0); break;
				case 14: SNBestKnown.Sort14Ascending(ref p0); break;
				case 15: SNBestKnown.Sort15Ascending(ref p0); break;
				case 16: SNBestKnown.Sort16Ascending(ref p0); break;
				case 17: SNBoseNelson.Sort17Ascending(ref p0); break;
				case 18: SNBoseNelson.Sort18Ascending(ref p0); break;
				case 19: SNBoseNelson.Sort19Ascending(ref p0); break;
				case 20: SNBoseNelson.Sort20Ascending(ref p0); break;
				case 21: SNBoseNelson.Sort21Ascending(ref p0); break;
				case 22: SNBoseNelson.Sort22Ascending(ref p0); break;
				case 23: SNBoseNelson.Sort23Ascending(ref p0); break;
				case 24: SNBoseNelson.Sort24Ascending(ref p0); break;
				case 25: SNBoseNelson.Sort25Ascending(ref p0); break;
				case 26: SNBoseNelson.Sort26Ascending(ref p0); break;
				case 27: SNBoseNelson.Sort27Ascending(ref p0); break;
				case 28: SNBoseNelson.Sort28Ascending(ref p0); break;
				case 29: SNBoseNelson.Sort29Ascending(ref p0); break;
				case 30: SNBoseNelson.Sort30Ascending(ref p0); break;
				case 31: SNBoseNelson.Sort31Ascending(ref p0); break;
				case 32: SNBoseNelson.Sort32Ascending(ref p0); break;
				default:
					{
						throw new ArgumentOutOfRangeException(nameof(array), $"Array length `{array.Length}` must be between `{MinLength}` and `{MaxLength}`.");
					}
			}
		}

		/// <summary>
		/// Sorts the elements in an entire <see cref="Array"/> in descending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element of the <see cref="Array"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the array.</typeparam>
		/// <param name="array">The one-dimensional, zero-based <see cref="Array"/> to sort.</param>
		/// <exception cref="ArgumentNullException">array is null</exception>
		/// <exception cref="ArgumentOutOfRangeException">array length is not between <see cref="MinLength"/> and <see cref="MaxLength"/></exception>
		public static void SortDescending<T>(T[] array)
			where T : IComparable<T>
		{
			if (array is null)
			{
				throw new ArgumentNullException(nameof(array));
			}

#if NET5_0
			ref T p0 = ref MemoryMarshal.GetArrayDataReference(array);
#else
			ref T p0 = ref array[0];
#endif

			switch (array.Length)
			{
				case 2: SNBoseNelson.Sort2Descending(ref p0); break;
				case 3: SNBoseNelson.Sort3Descending(ref p0); break;
				case 4: SNBoseNelson.Sort4Descending(ref p0); break;
				case 5: SNBoseNelson.Sort5Descending(ref p0); break;
				case 6: SNBoseNelson.Sort6Descending(ref p0); break;
				case 7: SNBoseNelson.Sort7Descending(ref p0); break;
				case 8: SNBoseNelson.Sort8Descending(ref p0); break;
				case 9: SNBestKnown.Sort9Descending(ref p0); break;
				case 10: SNBestKnown.Sort10Descending(ref p0); break;
				case 11: SNBestKnown.Sort11Descending(ref p0); break;
				case 12: SNBestKnown.Sort12Descending(ref p0); break;
				case 13: SNBestKnown.Sort13Descending(ref p0); break;
				case 14: SNBestKnown.Sort14Descending(ref p0); break;
				case 15: SNBestKnown.Sort15Descending(ref p0); break;
				case 16: SNBestKnown.Sort16Descending(ref p0); break;
				case 17: SNBoseNelson.Sort17Descending(ref p0); break;
				case 18: SNBoseNelson.Sort18Descending(ref p0); break;
				case 19: SNBoseNelson.Sort19Descending(ref p0); break;
				case 20: SNBoseNelson.Sort20Descending(ref p0); break;
				case 21: SNBoseNelson.Sort21Descending(ref p0); break;
				case 22: SNBoseNelson.Sort22Descending(ref p0); break;
				case 23: SNBoseNelson.Sort23Descending(ref p0); break;
				case 24: SNBoseNelson.Sort24Descending(ref p0); break;
				case 25: SNBoseNelson.Sort25Descending(ref p0); break;
				case 26: SNBoseNelson.Sort26Descending(ref p0); break;
				case 27: SNBoseNelson.Sort27Descending(ref p0); break;
				case 28: SNBoseNelson.Sort28Descending(ref p0); break;
				case 29: SNBoseNelson.Sort29Descending(ref p0); break;
				case 30: SNBoseNelson.Sort30Descending(ref p0); break;
				case 31: SNBoseNelson.Sort31Descending(ref p0); break;
				case 32: SNBoseNelson.Sort32Descending(ref p0); break;
				default:
					{
						throw new ArgumentOutOfRangeException(nameof(array), $"Array length `{array.Length}` must be between `{MinLength}` and `{MaxLength}`.");
					}
			}
		}

		/// <summary>
		/// Sorts the elements in an entire <see cref="Span{T}"/> in ascending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element of the <see cref="Span{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the span.</typeparam>
		/// <param name="buffer">The one-dimensional, zero-based <see cref="Span{T}"/> to sort.</param>
		/// <exception cref="ArgumentOutOfRangeException">span length is not between <see cref="MinLength"/> and <see cref="MaxLength"/></exception>
		public static void SortAscending<T>(Span<T> buffer)
			where T : IComparable<T>
		{
			ref T p0 = ref MemoryMarshal.GetReference(buffer);

			switch (buffer.Length)
			{
				case 2: SNBoseNelson.Sort2Ascending(ref p0); break;
				case 3: SNBoseNelson.Sort3Ascending(ref p0); break;
				case 4: SNBoseNelson.Sort4Ascending(ref p0); break;
				case 5: SNBoseNelson.Sort5Ascending(ref p0); break;
				case 6: SNBoseNelson.Sort6Ascending(ref p0); break;
				case 7: SNBoseNelson.Sort7Ascending(ref p0); break;
				case 8: SNBoseNelson.Sort8Ascending(ref p0); break;
				case 9: SNBestKnown.Sort9Ascending(ref p0); break;
				case 10: SNBestKnown.Sort10Ascending(ref p0); break;
				case 11: SNBestKnown.Sort11Ascending(ref p0); break;
				case 12: SNBestKnown.Sort12Ascending(ref p0); break;
				case 13: SNBestKnown.Sort13Ascending(ref p0); break;
				case 14: SNBestKnown.Sort14Ascending(ref p0); break;
				case 15: SNBestKnown.Sort15Ascending(ref p0); break;
				case 16: SNBestKnown.Sort16Ascending(ref p0); break;
				case 17: SNBoseNelson.Sort17Ascending(ref p0); break;
				case 18: SNBoseNelson.Sort18Ascending(ref p0); break;
				case 19: SNBoseNelson.Sort19Ascending(ref p0); break;
				case 20: SNBoseNelson.Sort20Ascending(ref p0); break;
				case 21: SNBoseNelson.Sort21Ascending(ref p0); break;
				case 22: SNBoseNelson.Sort22Ascending(ref p0); break;
				case 23: SNBoseNelson.Sort23Ascending(ref p0); break;
				case 24: SNBoseNelson.Sort24Ascending(ref p0); break;
				case 25: SNBoseNelson.Sort25Ascending(ref p0); break;
				case 26: SNBoseNelson.Sort26Ascending(ref p0); break;
				case 27: SNBoseNelson.Sort27Ascending(ref p0); break;
				case 28: SNBoseNelson.Sort28Ascending(ref p0); break;
				case 29: SNBoseNelson.Sort29Ascending(ref p0); break;
				case 30: SNBoseNelson.Sort30Ascending(ref p0); break;
				case 31: SNBoseNelson.Sort31Ascending(ref p0); break;
				case 32: SNBoseNelson.Sort32Ascending(ref p0); break;
				default:
					{
						throw new ArgumentOutOfRangeException(nameof(buffer), $"Buffer length `{buffer.Length}` must be between `{MinLength}` and `{MaxLength}`.");
					}
			}
		}

		/// <summary>
		/// Sorts the elements in an entire <see cref="Span{T}"/> in descending order using the <see cref="IComparable{T}"/> generic
		/// interface implementation of each element of the <see cref="Span{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the span.</typeparam>
		/// <param name="buffer">The one-dimensional, zero-based <see cref="Span{T}"/> to sort.</param>
		/// <exception cref="ArgumentOutOfRangeException">span length is not between <see cref="MinLength"/> and <see cref="MaxLength"/></exception>
		public static void SortDescending<T>(Span<T> buffer)
			where T : IComparable<T>
		{
			ref T p0 = ref MemoryMarshal.GetReference(buffer);

			switch (buffer.Length)
			{
				case 2: SNBoseNelson.Sort2Descending(ref p0); break;
				case 3: SNBoseNelson.Sort3Descending(ref p0); break;
				case 4: SNBoseNelson.Sort4Descending(ref p0); break;
				case 5: SNBoseNelson.Sort5Descending(ref p0); break;
				case 6: SNBoseNelson.Sort6Descending(ref p0); break;
				case 7: SNBoseNelson.Sort7Descending(ref p0); break;
				case 8: SNBoseNelson.Sort8Descending(ref p0); break;
				case 9: SNBestKnown.Sort9Descending(ref p0); break;
				case 10: SNBestKnown.Sort10Descending(ref p0); break;
				case 11: SNBestKnown.Sort11Descending(ref p0); break;
				case 12: SNBestKnown.Sort12Descending(ref p0); break;
				case 13: SNBestKnown.Sort13Descending(ref p0); break;
				case 14: SNBestKnown.Sort14Descending(ref p0); break;
				case 15: SNBestKnown.Sort15Descending(ref p0); break;
				case 16: SNBestKnown.Sort16Descending(ref p0); break;
				case 17: SNBoseNelson.Sort17Descending(ref p0); break;
				case 18: SNBoseNelson.Sort18Descending(ref p0); break;
				case 19: SNBoseNelson.Sort19Descending(ref p0); break;
				case 20: SNBoseNelson.Sort20Descending(ref p0); break;
				case 21: SNBoseNelson.Sort21Descending(ref p0); break;
				case 22: SNBoseNelson.Sort22Descending(ref p0); break;
				case 23: SNBoseNelson.Sort23Descending(ref p0); break;
				case 24: SNBoseNelson.Sort24Descending(ref p0); break;
				case 25: SNBoseNelson.Sort25Descending(ref p0); break;
				case 26: SNBoseNelson.Sort26Descending(ref p0); break;
				case 27: SNBoseNelson.Sort27Descending(ref p0); break;
				case 28: SNBoseNelson.Sort28Descending(ref p0); break;
				case 29: SNBoseNelson.Sort29Descending(ref p0); break;
				case 30: SNBoseNelson.Sort30Descending(ref p0); break;
				case 31: SNBoseNelson.Sort31Descending(ref p0); break;
				case 32: SNBoseNelson.Sort32Descending(ref p0); break;
				default:
					{
						throw new ArgumentOutOfRangeException(nameof(buffer), $"Buffer length `{buffer.Length}` must be between `{MinLength}` and `{MaxLength}`.");
					}
			}
		}

		/// <summary>
		/// Sorts the elements in an <see cref="Array"/> in ascending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the array.</typeparam>
		/// <param name="array">The one-dimensional, zero-based <see cref="Array"/> to sort.</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		/// <exception cref="ArgumentNullException">array is null</exception>
		/// <exception cref="ArgumentNullException">comparison is null</exception>
		/// <exception cref="ArgumentOutOfRangeException">array length is not between <see cref="MinLength"/> and <see cref="MaxLength"/></exception>
		public static void SortAscending<T>(T[] array, Comparison<T> comparison)
		{
			if (array is null)
			{
				throw new ArgumentNullException(nameof(array));
			}

			if (comparison is null)
			{
				throw new ArgumentNullException(nameof(comparison));
			}

#if NET5_0
			ref T p0 = ref MemoryMarshal.GetArrayDataReference(array);
#else
			ref T p0 = ref array[0];
#endif

			switch (array.Length)
			{
				case 2: SNBoseNelson.Sort2Ascending(ref p0, comparison); break;
				case 3: SNBoseNelson.Sort3Ascending(ref p0, comparison); break;
				case 4: SNBoseNelson.Sort4Ascending(ref p0, comparison); break;
				case 5: SNBoseNelson.Sort5Ascending(ref p0, comparison); break;
				case 6: SNBoseNelson.Sort6Ascending(ref p0, comparison); break;
				case 7: SNBoseNelson.Sort7Ascending(ref p0, comparison); break;
				case 8: SNBoseNelson.Sort8Ascending(ref p0, comparison); break;
				case 9: SNBestKnown.Sort9Ascending(ref p0, comparison); break;
				case 10: SNBestKnown.Sort10Ascending(ref p0, comparison); break;
				case 11: SNBestKnown.Sort11Ascending(ref p0, comparison); break;
				case 12: SNBestKnown.Sort12Ascending(ref p0, comparison); break;
				case 13: SNBestKnown.Sort13Ascending(ref p0, comparison); break;
				case 14: SNBestKnown.Sort14Ascending(ref p0, comparison); break;
				case 15: SNBestKnown.Sort15Ascending(ref p0, comparison); break;
				case 16: SNBestKnown.Sort16Ascending(ref p0, comparison); break;
				case 17: SNBoseNelson.Sort17Ascending(ref p0, comparison); break;
				case 18: SNBoseNelson.Sort18Ascending(ref p0, comparison); break;
				case 19: SNBoseNelson.Sort19Ascending(ref p0, comparison); break;
				case 20: SNBoseNelson.Sort20Ascending(ref p0, comparison); break;
				case 21: SNBoseNelson.Sort21Ascending(ref p0, comparison); break;
				case 22: SNBoseNelson.Sort22Ascending(ref p0, comparison); break;
				case 23: SNBoseNelson.Sort23Ascending(ref p0, comparison); break;
				case 24: SNBoseNelson.Sort24Ascending(ref p0, comparison); break;
				case 25: SNBoseNelson.Sort25Ascending(ref p0, comparison); break;
				case 26: SNBoseNelson.Sort26Ascending(ref p0, comparison); break;
				case 27: SNBoseNelson.Sort27Ascending(ref p0, comparison); break;
				case 28: SNBoseNelson.Sort28Ascending(ref p0, comparison); break;
				case 29: SNBoseNelson.Sort29Ascending(ref p0, comparison); break;
				case 30: SNBoseNelson.Sort30Ascending(ref p0, comparison); break;
				case 31: SNBoseNelson.Sort31Ascending(ref p0, comparison); break;
				case 32: SNBoseNelson.Sort32Ascending(ref p0, comparison); break;
				default:
					{
						throw new ArgumentOutOfRangeException(nameof(array), $"Array length `{array.Length}` must be between `{MinLength}` and `{MaxLength}`.");
					}
			}
		}

		/// <summary>
		/// Sorts the elements in an <see cref="Array"/> in descending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the array.</typeparam>
		/// <param name="array">The one-dimensional, zero-based <see cref="Array"/> to sort.</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		/// <exception cref="ArgumentNullException">array is null</exception>
		/// <exception cref="ArgumentNullException">comparison is null</exception>
		/// <exception cref="ArgumentOutOfRangeException">array length is not between <see cref="MinLength"/> and <see cref="MaxLength"/></exception>
		public static void SortDescending<T>(T[] array, Comparison<T> comparison)
		{
			if (array is null)
			{
				throw new ArgumentNullException(nameof(array));
			}

			if (comparison is null)
			{
				throw new ArgumentNullException(nameof(comparison));
			}

#if NET5_0
			ref T p0 = ref MemoryMarshal.GetArrayDataReference(array);
#else
			ref T p0 = ref array[0];
#endif

			switch (array.Length)
			{
				case 2: SNBoseNelson.Sort2Descending(ref p0, comparison); break;
				case 3: SNBoseNelson.Sort3Descending(ref p0, comparison); break;
				case 4: SNBoseNelson.Sort4Descending(ref p0, comparison); break;
				case 5: SNBoseNelson.Sort5Descending(ref p0, comparison); break;
				case 6: SNBoseNelson.Sort6Descending(ref p0, comparison); break;
				case 7: SNBoseNelson.Sort7Descending(ref p0, comparison); break;
				case 8: SNBoseNelson.Sort8Descending(ref p0, comparison); break;
				case 9: SNBestKnown.Sort9Descending(ref p0, comparison); break;
				case 10: SNBestKnown.Sort10Descending(ref p0, comparison); break;
				case 11: SNBestKnown.Sort11Descending(ref p0, comparison); break;
				case 12: SNBestKnown.Sort12Descending(ref p0, comparison); break;
				case 13: SNBestKnown.Sort13Descending(ref p0, comparison); break;
				case 14: SNBestKnown.Sort14Descending(ref p0, comparison); break;
				case 15: SNBestKnown.Sort15Descending(ref p0, comparison); break;
				case 16: SNBestKnown.Sort16Descending(ref p0, comparison); break;
				case 17: SNBoseNelson.Sort17Descending(ref p0, comparison); break;
				case 18: SNBoseNelson.Sort18Descending(ref p0, comparison); break;
				case 19: SNBoseNelson.Sort19Descending(ref p0, comparison); break;
				case 20: SNBoseNelson.Sort20Descending(ref p0, comparison); break;
				case 21: SNBoseNelson.Sort21Descending(ref p0, comparison); break;
				case 22: SNBoseNelson.Sort22Descending(ref p0, comparison); break;
				case 23: SNBoseNelson.Sort23Descending(ref p0, comparison); break;
				case 24: SNBoseNelson.Sort24Descending(ref p0, comparison); break;
				case 25: SNBoseNelson.Sort25Descending(ref p0, comparison); break;
				case 26: SNBoseNelson.Sort26Descending(ref p0, comparison); break;
				case 27: SNBoseNelson.Sort27Descending(ref p0, comparison); break;
				case 28: SNBoseNelson.Sort28Descending(ref p0, comparison); break;
				case 29: SNBoseNelson.Sort29Descending(ref p0, comparison); break;
				case 30: SNBoseNelson.Sort30Descending(ref p0, comparison); break;
				case 31: SNBoseNelson.Sort31Descending(ref p0, comparison); break;
				case 32: SNBoseNelson.Sort32Descending(ref p0, comparison); break;
				default:
					{
						throw new ArgumentOutOfRangeException(nameof(array), $"Array length `{array.Length}` must be between `{MinLength}` and `{MaxLength}`.");
					}
			}
		}

		/// <summary>
		/// Sorts the elements in an <see cref="Span{T}"/> in ascending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the span.</typeparam>
		/// <param name="buffer">The one-dimensional, zero-based <see cref="Span{T}"/> to sort.</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		/// <exception cref="ArgumentNullException">comparison is null</exception>
		/// <exception cref="ArgumentOutOfRangeException">span length is not between <see cref="MinLength"/> and <see cref="MaxLength"/></exception>
		public static void SortAscending<T>(Span<T> buffer, Comparison<T> comparison)
		{
			if (comparison is null)
			{
				throw new ArgumentNullException(nameof(comparison));
			}

			ref T p0 = ref MemoryMarshal.GetReference(buffer);

			switch (buffer.Length)
			{
				case 2: SNBoseNelson.Sort2Ascending(ref p0, comparison); break;
				case 3: SNBoseNelson.Sort3Ascending(ref p0, comparison); break;
				case 4: SNBoseNelson.Sort4Ascending(ref p0, comparison); break;
				case 5: SNBoseNelson.Sort5Ascending(ref p0, comparison); break;
				case 6: SNBoseNelson.Sort6Ascending(ref p0, comparison); break;
				case 7: SNBoseNelson.Sort7Ascending(ref p0, comparison); break;
				case 8: SNBoseNelson.Sort8Ascending(ref p0, comparison); break;
				case 9: SNBestKnown.Sort9Ascending(ref p0, comparison); break;
				case 10: SNBestKnown.Sort10Ascending(ref p0, comparison); break;
				case 11: SNBestKnown.Sort11Ascending(ref p0, comparison); break;
				case 12: SNBestKnown.Sort12Ascending(ref p0, comparison); break;
				case 13: SNBestKnown.Sort13Ascending(ref p0, comparison); break;
				case 14: SNBestKnown.Sort14Ascending(ref p0, comparison); break;
				case 15: SNBestKnown.Sort15Ascending(ref p0, comparison); break;
				case 16: SNBestKnown.Sort16Ascending(ref p0, comparison); break;
				case 17: SNBoseNelson.Sort17Ascending(ref p0, comparison); break;
				case 18: SNBoseNelson.Sort18Ascending(ref p0, comparison); break;
				case 19: SNBoseNelson.Sort19Ascending(ref p0, comparison); break;
				case 20: SNBoseNelson.Sort20Ascending(ref p0, comparison); break;
				case 21: SNBoseNelson.Sort21Ascending(ref p0, comparison); break;
				case 22: SNBoseNelson.Sort22Ascending(ref p0, comparison); break;
				case 23: SNBoseNelson.Sort23Ascending(ref p0, comparison); break;
				case 24: SNBoseNelson.Sort24Ascending(ref p0, comparison); break;
				case 25: SNBoseNelson.Sort25Ascending(ref p0, comparison); break;
				case 26: SNBoseNelson.Sort26Ascending(ref p0, comparison); break;
				case 27: SNBoseNelson.Sort27Ascending(ref p0, comparison); break;
				case 28: SNBoseNelson.Sort28Ascending(ref p0, comparison); break;
				case 29: SNBoseNelson.Sort29Ascending(ref p0, comparison); break;
				case 30: SNBoseNelson.Sort30Ascending(ref p0, comparison); break;
				case 31: SNBoseNelson.Sort31Ascending(ref p0, comparison); break;
				case 32: SNBoseNelson.Sort32Ascending(ref p0, comparison); break;
				default:
					{
						throw new ArgumentOutOfRangeException(nameof(buffer), $"Buffer length `{buffer.Length}` must be between `{MinLength}` and `{MaxLength}`.");
					}
			}
		}

		/// <summary>
		/// Sorts the elements in an <see cref="Span{T}"/> in descending order using the specified <see cref="Comparison{T}"/>.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the span.</typeparam>
		/// <param name="buffer">The one-dimensional, zero-based <see cref="Span{T}"/> to sort.</param>
		/// <param name="comparison">The <see cref="Comparison{T}"/> to use when comparing elements.</param>
		/// <exception cref="ArgumentNullException">comparison is null</exception>
		/// <exception cref="ArgumentOutOfRangeException">span length is not between <see cref="MinLength"/> and <see cref="MaxLength"/></exception>
		public static void SortDescending<T>(Span<T> buffer, Comparison<T> comparison)
		{
			if (comparison is null)
			{
				throw new ArgumentNullException(nameof(comparison));
			}

			ref T p0 = ref MemoryMarshal.GetReference(buffer);

			switch (buffer.Length)
			{
				case 2: SNBoseNelson.Sort2Descending(ref p0, comparison); break;
				case 3: SNBoseNelson.Sort3Descending(ref p0, comparison); break;
				case 4: SNBoseNelson.Sort4Descending(ref p0, comparison); break;
				case 5: SNBoseNelson.Sort5Descending(ref p0, comparison); break;
				case 6: SNBoseNelson.Sort6Descending(ref p0, comparison); break;
				case 7: SNBoseNelson.Sort7Descending(ref p0, comparison); break;
				case 8: SNBoseNelson.Sort8Descending(ref p0, comparison); break;
				case 9: SNBestKnown.Sort9Descending(ref p0, comparison); break;
				case 10: SNBestKnown.Sort10Descending(ref p0, comparison); break;
				case 11: SNBestKnown.Sort11Descending(ref p0, comparison); break;
				case 12: SNBestKnown.Sort12Descending(ref p0, comparison); break;
				case 13: SNBestKnown.Sort13Descending(ref p0, comparison); break;
				case 14: SNBestKnown.Sort14Descending(ref p0, comparison); break;
				case 15: SNBestKnown.Sort15Descending(ref p0, comparison); break;
				case 16: SNBestKnown.Sort16Descending(ref p0, comparison); break;
				case 17: SNBoseNelson.Sort17Descending(ref p0, comparison); break;
				case 18: SNBoseNelson.Sort18Descending(ref p0, comparison); break;
				case 19: SNBoseNelson.Sort19Descending(ref p0, comparison); break;
				case 20: SNBoseNelson.Sort20Descending(ref p0, comparison); break;
				case 21: SNBoseNelson.Sort21Descending(ref p0, comparison); break;
				case 22: SNBoseNelson.Sort22Descending(ref p0, comparison); break;
				case 23: SNBoseNelson.Sort23Descending(ref p0, comparison); break;
				case 24: SNBoseNelson.Sort24Descending(ref p0, comparison); break;
				case 25: SNBoseNelson.Sort25Descending(ref p0, comparison); break;
				case 26: SNBoseNelson.Sort26Descending(ref p0, comparison); break;
				case 27: SNBoseNelson.Sort27Descending(ref p0, comparison); break;
				case 28: SNBoseNelson.Sort28Descending(ref p0, comparison); break;
				case 29: SNBoseNelson.Sort29Descending(ref p0, comparison); break;
				case 30: SNBoseNelson.Sort30Descending(ref p0, comparison); break;
				case 31: SNBoseNelson.Sort31Descending(ref p0, comparison); break;
				case 32: SNBoseNelson.Sort32Descending(ref p0, comparison); break;
				default:
					{
						throw new ArgumentOutOfRangeException(nameof(buffer), $"Buffer length `{buffer.Length}` must be between `{MinLength}` and `{MaxLength}`.");
					}
			}
		}

		/// <summary>
		/// Sorts the elements in an <see cref="Array"/> in ascending order using the specified function pointer.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the array.</typeparam>
		/// <param name="array">The one-dimensional, zero-based <see cref="Array"/> to sort.</param>
		/// <param name="comparisonPointer">The function pointer to use when comparing elements.</param>
		/// <exception cref="ArgumentNullException">array is null</exception>
		/// <exception cref="ArgumentOutOfRangeException">array length is not between <see cref="MinLength"/> and <see cref="MaxLength"/></exception>
		public unsafe static void SortAscending<T>(T[] array, delegate* managed<T, T, int> comparisonPointer)
		{
			if (array is null)
			{
				throw new ArgumentNullException(nameof(array));
			}

#if NET5_0
			ref T p0 = ref MemoryMarshal.GetArrayDataReference(array);
#else
			ref T p0 = ref array[0];
#endif

			switch (array.Length)
			{
				case 2: SNBoseNelson.Sort2Ascending(ref p0, comparisonPointer); break;
				case 3: SNBoseNelson.Sort3Ascending(ref p0, comparisonPointer); break;
				case 4: SNBoseNelson.Sort4Ascending(ref p0, comparisonPointer); break;
				case 5: SNBoseNelson.Sort5Ascending(ref p0, comparisonPointer); break;
				case 6: SNBoseNelson.Sort6Ascending(ref p0, comparisonPointer); break;
				case 7: SNBoseNelson.Sort7Ascending(ref p0, comparisonPointer); break;
				case 8: SNBoseNelson.Sort8Ascending(ref p0, comparisonPointer); break;
				case 9: SNBestKnown.Sort9Ascending(ref p0, comparisonPointer); break;
				case 10: SNBestKnown.Sort10Ascending(ref p0, comparisonPointer); break;
				case 11: SNBestKnown.Sort11Ascending(ref p0, comparisonPointer); break;
				case 12: SNBestKnown.Sort12Ascending(ref p0, comparisonPointer); break;
				case 13: SNBestKnown.Sort13Ascending(ref p0, comparisonPointer); break;
				case 14: SNBestKnown.Sort14Ascending(ref p0, comparisonPointer); break;
				case 15: SNBestKnown.Sort15Ascending(ref p0, comparisonPointer); break;
				case 16: SNBestKnown.Sort16Ascending(ref p0, comparisonPointer); break;
				case 17: SNBoseNelson.Sort17Ascending(ref p0, comparisonPointer); break;
				case 18: SNBoseNelson.Sort18Ascending(ref p0, comparisonPointer); break;
				case 19: SNBoseNelson.Sort19Ascending(ref p0, comparisonPointer); break;
				case 20: SNBoseNelson.Sort20Ascending(ref p0, comparisonPointer); break;
				case 21: SNBoseNelson.Sort21Ascending(ref p0, comparisonPointer); break;
				case 22: SNBoseNelson.Sort22Ascending(ref p0, comparisonPointer); break;
				case 23: SNBoseNelson.Sort23Ascending(ref p0, comparisonPointer); break;
				case 24: SNBoseNelson.Sort24Ascending(ref p0, comparisonPointer); break;
				case 25: SNBoseNelson.Sort25Ascending(ref p0, comparisonPointer); break;
				case 26: SNBoseNelson.Sort26Ascending(ref p0, comparisonPointer); break;
				case 27: SNBoseNelson.Sort27Ascending(ref p0, comparisonPointer); break;
				case 28: SNBoseNelson.Sort28Ascending(ref p0, comparisonPointer); break;
				case 29: SNBoseNelson.Sort29Ascending(ref p0, comparisonPointer); break;
				case 30: SNBoseNelson.Sort30Ascending(ref p0, comparisonPointer); break;
				case 31: SNBoseNelson.Sort31Ascending(ref p0, comparisonPointer); break;
				case 32: SNBoseNelson.Sort32Ascending(ref p0, comparisonPointer); break;
				default:
					{
						throw new ArgumentOutOfRangeException(nameof(array), $"Array length `{array.Length}` must be between `{MinLength}` and `{MaxLength}`.");
					}
			}
		}

		/// <summary>
		/// Sorts the elements in an <see cref="Array"/> in descending order using the specified function pointer.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the array.</typeparam>
		/// <param name="array">The one-dimensional, zero-based <see cref="Array"/> to sort.</param>
		/// <param name="comparisonPointer">The function pointer to use when comparing elements.</param>
		/// <exception cref="ArgumentNullException">array is null</exception>
		/// <exception cref="ArgumentOutOfRangeException">array length is not between <see cref="MinLength"/> and <see cref="MaxLength"/></exception>
		public unsafe static void SortDescending<T>(T[] array, delegate* managed<T, T, int> comparisonPointer)
		{
			if (array is null)
			{
				throw new ArgumentNullException(nameof(array));
			}

#if NET5_0
			ref T p0 = ref MemoryMarshal.GetArrayDataReference(array);
#else
			ref T p0 = ref array[0];
#endif

			switch (array.Length)
			{
				case 2: SNBoseNelson.Sort2Descending(ref p0, comparisonPointer); break;
				case 3: SNBoseNelson.Sort3Descending(ref p0, comparisonPointer); break;
				case 4: SNBoseNelson.Sort4Descending(ref p0, comparisonPointer); break;
				case 5: SNBoseNelson.Sort5Descending(ref p0, comparisonPointer); break;
				case 6: SNBoseNelson.Sort6Descending(ref p0, comparisonPointer); break;
				case 7: SNBoseNelson.Sort7Descending(ref p0, comparisonPointer); break;
				case 8: SNBoseNelson.Sort8Descending(ref p0, comparisonPointer); break;
				case 9: SNBestKnown.Sort9Descending(ref p0, comparisonPointer); break;
				case 10: SNBestKnown.Sort10Descending(ref p0, comparisonPointer); break;
				case 11: SNBestKnown.Sort11Descending(ref p0, comparisonPointer); break;
				case 12: SNBestKnown.Sort12Descending(ref p0, comparisonPointer); break;
				case 13: SNBestKnown.Sort13Descending(ref p0, comparisonPointer); break;
				case 14: SNBestKnown.Sort14Descending(ref p0, comparisonPointer); break;
				case 15: SNBestKnown.Sort15Descending(ref p0, comparisonPointer); break;
				case 16: SNBestKnown.Sort16Descending(ref p0, comparisonPointer); break;
				case 17: SNBoseNelson.Sort17Descending(ref p0, comparisonPointer); break;
				case 18: SNBoseNelson.Sort18Descending(ref p0, comparisonPointer); break;
				case 19: SNBoseNelson.Sort19Descending(ref p0, comparisonPointer); break;
				case 20: SNBoseNelson.Sort20Descending(ref p0, comparisonPointer); break;
				case 21: SNBoseNelson.Sort21Descending(ref p0, comparisonPointer); break;
				case 22: SNBoseNelson.Sort22Descending(ref p0, comparisonPointer); break;
				case 23: SNBoseNelson.Sort23Descending(ref p0, comparisonPointer); break;
				case 24: SNBoseNelson.Sort24Descending(ref p0, comparisonPointer); break;
				case 25: SNBoseNelson.Sort25Descending(ref p0, comparisonPointer); break;
				case 26: SNBoseNelson.Sort26Descending(ref p0, comparisonPointer); break;
				case 27: SNBoseNelson.Sort27Descending(ref p0, comparisonPointer); break;
				case 28: SNBoseNelson.Sort28Descending(ref p0, comparisonPointer); break;
				case 29: SNBoseNelson.Sort29Descending(ref p0, comparisonPointer); break;
				case 30: SNBoseNelson.Sort30Descending(ref p0, comparisonPointer); break;
				case 31: SNBoseNelson.Sort31Descending(ref p0, comparisonPointer); break;
				case 32: SNBoseNelson.Sort32Descending(ref p0, comparisonPointer); break;
				default:
					{
						throw new ArgumentOutOfRangeException(nameof(array), $"Array length `{array.Length}` must be between `{MinLength}` and `{MaxLength}`.");
					}
			}
		}

		/// <summary>
		/// Sorts the elements in an <see cref="Span{T}"/> in ascending order using the specified function pointer.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the span.</typeparam>
		/// <param name="buffer">The one-dimensional, zero-based <see cref="Span{T}"/> to sort.</param>
		/// <param name="comparisonPointer">The function pointer to use when comparing elements.</param>
		/// <exception cref="ArgumentOutOfRangeException">span length is not between <see cref="MinLength"/> and <see cref="MaxLength"/></exception>
		public unsafe static void SortAscending<T>(Span<T> buffer, delegate* managed<T, T, int> comparisonPointer)
		{
			ref T p0 = ref MemoryMarshal.GetReference(buffer);

			switch (buffer.Length)
			{
				case 2: SNBoseNelson.Sort2Ascending(ref p0, comparisonPointer); break;
				case 3: SNBoseNelson.Sort3Ascending(ref p0, comparisonPointer); break;
				case 4: SNBoseNelson.Sort4Ascending(ref p0, comparisonPointer); break;
				case 5: SNBoseNelson.Sort5Ascending(ref p0, comparisonPointer); break;
				case 6: SNBoseNelson.Sort6Ascending(ref p0, comparisonPointer); break;
				case 7: SNBoseNelson.Sort7Ascending(ref p0, comparisonPointer); break;
				case 8: SNBoseNelson.Sort8Ascending(ref p0, comparisonPointer); break;
				case 9: SNBestKnown.Sort9Ascending(ref p0, comparisonPointer); break;
				case 10: SNBestKnown.Sort10Ascending(ref p0, comparisonPointer); break;
				case 11: SNBestKnown.Sort11Ascending(ref p0, comparisonPointer); break;
				case 12: SNBestKnown.Sort12Ascending(ref p0, comparisonPointer); break;
				case 13: SNBestKnown.Sort13Ascending(ref p0, comparisonPointer); break;
				case 14: SNBestKnown.Sort14Ascending(ref p0, comparisonPointer); break;
				case 15: SNBestKnown.Sort15Ascending(ref p0, comparisonPointer); break;
				case 16: SNBestKnown.Sort16Ascending(ref p0, comparisonPointer); break;
				case 17: SNBoseNelson.Sort17Ascending(ref p0, comparisonPointer); break;
				case 18: SNBoseNelson.Sort18Ascending(ref p0, comparisonPointer); break;
				case 19: SNBoseNelson.Sort19Ascending(ref p0, comparisonPointer); break;
				case 20: SNBoseNelson.Sort20Ascending(ref p0, comparisonPointer); break;
				case 21: SNBoseNelson.Sort21Ascending(ref p0, comparisonPointer); break;
				case 22: SNBoseNelson.Sort22Ascending(ref p0, comparisonPointer); break;
				case 23: SNBoseNelson.Sort23Ascending(ref p0, comparisonPointer); break;
				case 24: SNBoseNelson.Sort24Ascending(ref p0, comparisonPointer); break;
				case 25: SNBoseNelson.Sort25Ascending(ref p0, comparisonPointer); break;
				case 26: SNBoseNelson.Sort26Ascending(ref p0, comparisonPointer); break;
				case 27: SNBoseNelson.Sort27Ascending(ref p0, comparisonPointer); break;
				case 28: SNBoseNelson.Sort28Ascending(ref p0, comparisonPointer); break;
				case 29: SNBoseNelson.Sort29Ascending(ref p0, comparisonPointer); break;
				case 30: SNBoseNelson.Sort30Ascending(ref p0, comparisonPointer); break;
				case 31: SNBoseNelson.Sort31Ascending(ref p0, comparisonPointer); break;
				case 32: SNBoseNelson.Sort32Ascending(ref p0, comparisonPointer); break;
				default:
					{
						throw new ArgumentOutOfRangeException(nameof(buffer), $"Buffer length `{buffer.Length}` must be between `{MinLength}` and `{MaxLength}`.");
					}
			}
		}

		/// <summary>
		/// Sorts the elements in an <see cref="Span{T}"/> in descending order using the specified function pointer.
		/// </summary>
		/// <typeparam name="T">The type of the elements of the span.</typeparam>
		/// <param name="buffer">The one-dimensional, zero-based <see cref="Span{T}"/> to sort.</param>
		/// <param name="comparisonPointer">The function pointer to use when comparing elements.</param>
		/// <exception cref="ArgumentOutOfRangeException">span length is not between <see cref="MinLength"/> and <see cref="MaxLength"/></exception>
		public unsafe static void SortDescending<T>(Span<T> buffer, delegate* managed<T, T, int> comparisonPointer)
		{
			ref T p0 = ref MemoryMarshal.GetReference(buffer);

			switch (buffer.Length)
			{
				case 2: SNBoseNelson.Sort2Descending(ref p0, comparisonPointer); break;
				case 3: SNBoseNelson.Sort3Descending(ref p0, comparisonPointer); break;
				case 4: SNBoseNelson.Sort4Descending(ref p0, comparisonPointer); break;
				case 5: SNBoseNelson.Sort5Descending(ref p0, comparisonPointer); break;
				case 6: SNBoseNelson.Sort6Descending(ref p0, comparisonPointer); break;
				case 7: SNBoseNelson.Sort7Descending(ref p0, comparisonPointer); break;
				case 8: SNBoseNelson.Sort8Descending(ref p0, comparisonPointer); break;
				case 9: SNBestKnown.Sort9Descending(ref p0, comparisonPointer); break;
				case 10: SNBestKnown.Sort10Descending(ref p0, comparisonPointer); break;
				case 11: SNBestKnown.Sort11Descending(ref p0, comparisonPointer); break;
				case 12: SNBestKnown.Sort12Descending(ref p0, comparisonPointer); break;
				case 13: SNBestKnown.Sort13Descending(ref p0, comparisonPointer); break;
				case 14: SNBestKnown.Sort14Descending(ref p0, comparisonPointer); break;
				case 15: SNBestKnown.Sort15Descending(ref p0, comparisonPointer); break;
				case 16: SNBestKnown.Sort16Descending(ref p0, comparisonPointer); break;
				case 17: SNBoseNelson.Sort17Descending(ref p0, comparisonPointer); break;
				case 18: SNBoseNelson.Sort18Descending(ref p0, comparisonPointer); break;
				case 19: SNBoseNelson.Sort19Descending(ref p0, comparisonPointer); break;
				case 20: SNBoseNelson.Sort20Descending(ref p0, comparisonPointer); break;
				case 21: SNBoseNelson.Sort21Descending(ref p0, comparisonPointer); break;
				case 22: SNBoseNelson.Sort22Descending(ref p0, comparisonPointer); break;
				case 23: SNBoseNelson.Sort23Descending(ref p0, comparisonPointer); break;
				case 24: SNBoseNelson.Sort24Descending(ref p0, comparisonPointer); break;
				case 25: SNBoseNelson.Sort25Descending(ref p0, comparisonPointer); break;
				case 26: SNBoseNelson.Sort26Descending(ref p0, comparisonPointer); break;
				case 27: SNBoseNelson.Sort27Descending(ref p0, comparisonPointer); break;
				case 28: SNBoseNelson.Sort28Descending(ref p0, comparisonPointer); break;
				case 29: SNBoseNelson.Sort29Descending(ref p0, comparisonPointer); break;
				case 30: SNBoseNelson.Sort30Descending(ref p0, comparisonPointer); break;
				case 31: SNBoseNelson.Sort31Descending(ref p0, comparisonPointer); break;
				case 32: SNBoseNelson.Sort32Descending(ref p0, comparisonPointer); break;
				default:
					{
						throw new ArgumentOutOfRangeException(nameof(buffer), $"Buffer length `{buffer.Length}` must be between `{MinLength}` and `{MaxLength}`.");
					}
			}
		}
	}
}