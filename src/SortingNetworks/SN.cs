namespace SortingNetworks
{
	using System;

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

			switch (array.Length)
			{
				case 2: SNBoseNelson.Sort2Ascending(ref array[0]); break;
				case 3: SNBoseNelson.Sort3Ascending(ref array[0]); break;
				case 4: SNBoseNelson.Sort4Ascending(ref array[0]); break;
				case 5: SNBoseNelson.Sort5Ascending(ref array[0]); break;
				case 6: SNBoseNelson.Sort6Ascending(ref array[0]); break;
				case 7: SNBoseNelson.Sort7Ascending(ref array[0]); break;
				case 8: SNBoseNelson.Sort8Ascending(ref array[0]); break;
				case 9: SNBestKnown.Sort9Ascending(ref array[0]); break;
				case 10: SNBestKnown.Sort10Ascending(ref array[0]); break;
				case 11: SNBestKnown.Sort11Ascending(ref array[0]); break;
				case 12: SNBestKnown.Sort12Ascending(ref array[0]); break;
				case 13: SNBestKnown.Sort13Ascending(ref array[0]); break;
				case 14: SNBestKnown.Sort14Ascending(ref array[0]); break;
				case 15: SNBestKnown.Sort15Ascending(ref array[0]); break;
				case 16: SNBestKnown.Sort16Ascending(ref array[0]); break;
				case 17: SNBoseNelson.Sort17Ascending(ref array[0]); break;
				case 18: SNBoseNelson.Sort18Ascending(ref array[0]); break;
				case 19: SNBoseNelson.Sort19Ascending(ref array[0]); break;
				case 20: SNBoseNelson.Sort20Ascending(ref array[0]); break;
				case 21: SNBoseNelson.Sort21Ascending(ref array[0]); break;
				case 22: SNBoseNelson.Sort22Ascending(ref array[0]); break;
				case 23: SNBoseNelson.Sort23Ascending(ref array[0]); break;
				case 24: SNBoseNelson.Sort24Ascending(ref array[0]); break;
				case 25: SNBoseNelson.Sort25Ascending(ref array[0]); break;
				case 26: SNBoseNelson.Sort26Ascending(ref array[0]); break;
				case 27: SNBoseNelson.Sort27Ascending(ref array[0]); break;
				case 28: SNBoseNelson.Sort28Ascending(ref array[0]); break;
				case 29: SNBoseNelson.Sort29Ascending(ref array[0]); break;
				case 30: SNBoseNelson.Sort30Ascending(ref array[0]); break;
				case 31: SNBoseNelson.Sort31Ascending(ref array[0]); break;
				case 32: SNBoseNelson.Sort32Ascending(ref array[0]); break;
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

			switch (array.Length)
			{
				case 2: SNBoseNelson.Sort2Descending(ref array[0]); break;
				case 3: SNBoseNelson.Sort3Descending(ref array[0]); break;
				case 4: SNBoseNelson.Sort4Descending(ref array[0]); break;
				case 5: SNBoseNelson.Sort5Descending(ref array[0]); break;
				case 6: SNBoseNelson.Sort6Descending(ref array[0]); break;
				case 7: SNBoseNelson.Sort7Descending(ref array[0]); break;
				case 8: SNBoseNelson.Sort8Descending(ref array[0]); break;
				case 9: SNBestKnown.Sort9Descending(ref array[0]); break;
				case 10: SNBestKnown.Sort10Descending(ref array[0]); break;
				case 11: SNBestKnown.Sort11Descending(ref array[0]); break;
				case 12: SNBestKnown.Sort12Descending(ref array[0]); break;
				case 13: SNBestKnown.Sort13Descending(ref array[0]); break;
				case 14: SNBestKnown.Sort14Descending(ref array[0]); break;
				case 15: SNBestKnown.Sort15Descending(ref array[0]); break;
				case 16: SNBestKnown.Sort16Descending(ref array[0]); break;
				case 17: SNBoseNelson.Sort17Descending(ref array[0]); break;
				case 18: SNBoseNelson.Sort18Descending(ref array[0]); break;
				case 19: SNBoseNelson.Sort19Descending(ref array[0]); break;
				case 20: SNBoseNelson.Sort20Descending(ref array[0]); break;
				case 21: SNBoseNelson.Sort21Descending(ref array[0]); break;
				case 22: SNBoseNelson.Sort22Descending(ref array[0]); break;
				case 23: SNBoseNelson.Sort23Descending(ref array[0]); break;
				case 24: SNBoseNelson.Sort24Descending(ref array[0]); break;
				case 25: SNBoseNelson.Sort25Descending(ref array[0]); break;
				case 26: SNBoseNelson.Sort26Descending(ref array[0]); break;
				case 27: SNBoseNelson.Sort27Descending(ref array[0]); break;
				case 28: SNBoseNelson.Sort28Descending(ref array[0]); break;
				case 29: SNBoseNelson.Sort29Descending(ref array[0]); break;
				case 30: SNBoseNelson.Sort30Descending(ref array[0]); break;
				case 31: SNBoseNelson.Sort31Descending(ref array[0]); break;
				case 32: SNBoseNelson.Sort32Descending(ref array[0]); break;
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
			switch (buffer.Length)
			{
				case 2: SNBoseNelson.Sort2Ascending(ref buffer[0]); break;
				case 3: SNBoseNelson.Sort3Ascending(ref buffer[0]); break;
				case 4: SNBoseNelson.Sort4Ascending(ref buffer[0]); break;
				case 5: SNBoseNelson.Sort5Ascending(ref buffer[0]); break;
				case 6: SNBoseNelson.Sort6Ascending(ref buffer[0]); break;
				case 7: SNBoseNelson.Sort7Ascending(ref buffer[0]); break;
				case 8: SNBoseNelson.Sort8Ascending(ref buffer[0]); break;
				case 9: SNBestKnown.Sort9Ascending(ref buffer[0]); break;
				case 10: SNBestKnown.Sort10Ascending(ref buffer[0]); break;
				case 11: SNBestKnown.Sort11Ascending(ref buffer[0]); break;
				case 12: SNBestKnown.Sort12Ascending(ref buffer[0]); break;
				case 13: SNBestKnown.Sort13Ascending(ref buffer[0]); break;
				case 14: SNBestKnown.Sort14Ascending(ref buffer[0]); break;
				case 15: SNBestKnown.Sort15Ascending(ref buffer[0]); break;
				case 16: SNBestKnown.Sort16Ascending(ref buffer[0]); break;
				case 17: SNBoseNelson.Sort17Ascending(ref buffer[0]); break;
				case 18: SNBoseNelson.Sort18Ascending(ref buffer[0]); break;
				case 19: SNBoseNelson.Sort19Ascending(ref buffer[0]); break;
				case 20: SNBoseNelson.Sort20Ascending(ref buffer[0]); break;
				case 21: SNBoseNelson.Sort21Ascending(ref buffer[0]); break;
				case 22: SNBoseNelson.Sort22Ascending(ref buffer[0]); break;
				case 23: SNBoseNelson.Sort23Ascending(ref buffer[0]); break;
				case 24: SNBoseNelson.Sort24Ascending(ref buffer[0]); break;
				case 25: SNBoseNelson.Sort25Ascending(ref buffer[0]); break;
				case 26: SNBoseNelson.Sort26Ascending(ref buffer[0]); break;
				case 27: SNBoseNelson.Sort27Ascending(ref buffer[0]); break;
				case 28: SNBoseNelson.Sort28Ascending(ref buffer[0]); break;
				case 29: SNBoseNelson.Sort29Ascending(ref buffer[0]); break;
				case 30: SNBoseNelson.Sort30Ascending(ref buffer[0]); break;
				case 31: SNBoseNelson.Sort31Ascending(ref buffer[0]); break;
				case 32: SNBoseNelson.Sort32Ascending(ref buffer[0]); break;
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
			switch (buffer.Length)
			{
				case 2: SNBoseNelson.Sort2Descending(ref buffer[0]); break;
				case 3: SNBoseNelson.Sort3Descending(ref buffer[0]); break;
				case 4: SNBoseNelson.Sort4Descending(ref buffer[0]); break;
				case 5: SNBoseNelson.Sort5Descending(ref buffer[0]); break;
				case 6: SNBoseNelson.Sort6Descending(ref buffer[0]); break;
				case 7: SNBoseNelson.Sort7Descending(ref buffer[0]); break;
				case 8: SNBoseNelson.Sort8Descending(ref buffer[0]); break;
				case 9: SNBestKnown.Sort9Descending(ref buffer[0]); break;
				case 10: SNBestKnown.Sort10Descending(ref buffer[0]); break;
				case 11: SNBestKnown.Sort11Descending(ref buffer[0]); break;
				case 12: SNBestKnown.Sort12Descending(ref buffer[0]); break;
				case 13: SNBestKnown.Sort13Descending(ref buffer[0]); break;
				case 14: SNBestKnown.Sort14Descending(ref buffer[0]); break;
				case 15: SNBestKnown.Sort15Descending(ref buffer[0]); break;
				case 16: SNBestKnown.Sort16Descending(ref buffer[0]); break;
				case 17: SNBoseNelson.Sort17Descending(ref buffer[0]); break;
				case 18: SNBoseNelson.Sort18Descending(ref buffer[0]); break;
				case 19: SNBoseNelson.Sort19Descending(ref buffer[0]); break;
				case 20: SNBoseNelson.Sort20Descending(ref buffer[0]); break;
				case 21: SNBoseNelson.Sort21Descending(ref buffer[0]); break;
				case 22: SNBoseNelson.Sort22Descending(ref buffer[0]); break;
				case 23: SNBoseNelson.Sort23Descending(ref buffer[0]); break;
				case 24: SNBoseNelson.Sort24Descending(ref buffer[0]); break;
				case 25: SNBoseNelson.Sort25Descending(ref buffer[0]); break;
				case 26: SNBoseNelson.Sort26Descending(ref buffer[0]); break;
				case 27: SNBoseNelson.Sort27Descending(ref buffer[0]); break;
				case 28: SNBoseNelson.Sort28Descending(ref buffer[0]); break;
				case 29: SNBoseNelson.Sort29Descending(ref buffer[0]); break;
				case 30: SNBoseNelson.Sort30Descending(ref buffer[0]); break;
				case 31: SNBoseNelson.Sort31Descending(ref buffer[0]); break;
				case 32: SNBoseNelson.Sort32Descending(ref buffer[0]); break;
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

			switch (array.Length)
			{
				case 2: SNBoseNelson.Sort2Ascending(ref array[0], comparison); break;
				case 3: SNBoseNelson.Sort3Ascending(ref array[0], comparison); break;
				case 4: SNBoseNelson.Sort4Ascending(ref array[0], comparison); break;
				case 5: SNBoseNelson.Sort5Ascending(ref array[0], comparison); break;
				case 6: SNBoseNelson.Sort6Ascending(ref array[0], comparison); break;
				case 7: SNBoseNelson.Sort7Ascending(ref array[0], comparison); break;
				case 8: SNBoseNelson.Sort8Ascending(ref array[0], comparison); break;
				case 9: SNBestKnown.Sort9Ascending(ref array[0], comparison); break;
				case 10: SNBestKnown.Sort10Ascending(ref array[0], comparison); break;
				case 11: SNBestKnown.Sort11Ascending(ref array[0], comparison); break;
				case 12: SNBestKnown.Sort12Ascending(ref array[0], comparison); break;
				case 13: SNBestKnown.Sort13Ascending(ref array[0], comparison); break;
				case 14: SNBestKnown.Sort14Ascending(ref array[0], comparison); break;
				case 15: SNBestKnown.Sort15Ascending(ref array[0], comparison); break;
				case 16: SNBestKnown.Sort16Ascending(ref array[0], comparison); break;
				case 17: SNBoseNelson.Sort17Ascending(ref array[0], comparison); break;
				case 18: SNBoseNelson.Sort18Ascending(ref array[0], comparison); break;
				case 19: SNBoseNelson.Sort19Ascending(ref array[0], comparison); break;
				case 20: SNBoseNelson.Sort20Ascending(ref array[0], comparison); break;
				case 21: SNBoseNelson.Sort21Ascending(ref array[0], comparison); break;
				case 22: SNBoseNelson.Sort22Ascending(ref array[0], comparison); break;
				case 23: SNBoseNelson.Sort23Ascending(ref array[0], comparison); break;
				case 24: SNBoseNelson.Sort24Ascending(ref array[0], comparison); break;
				case 25: SNBoseNelson.Sort25Ascending(ref array[0], comparison); break;
				case 26: SNBoseNelson.Sort26Ascending(ref array[0], comparison); break;
				case 27: SNBoseNelson.Sort27Ascending(ref array[0], comparison); break;
				case 28: SNBoseNelson.Sort28Ascending(ref array[0], comparison); break;
				case 29: SNBoseNelson.Sort29Ascending(ref array[0], comparison); break;
				case 30: SNBoseNelson.Sort30Ascending(ref array[0], comparison); break;
				case 31: SNBoseNelson.Sort31Ascending(ref array[0], comparison); break;
				case 32: SNBoseNelson.Sort32Ascending(ref array[0], comparison); break;
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

			switch (array.Length)
			{
				case 2: SNBoseNelson.Sort2Descending(ref array[0], comparison); break;
				case 3: SNBoseNelson.Sort3Descending(ref array[0], comparison); break;
				case 4: SNBoseNelson.Sort4Descending(ref array[0], comparison); break;
				case 5: SNBoseNelson.Sort5Descending(ref array[0], comparison); break;
				case 6: SNBoseNelson.Sort6Descending(ref array[0], comparison); break;
				case 7: SNBoseNelson.Sort7Descending(ref array[0], comparison); break;
				case 8: SNBoseNelson.Sort8Descending(ref array[0], comparison); break;
				case 9: SNBestKnown.Sort9Descending(ref array[0], comparison); break;
				case 10: SNBestKnown.Sort10Descending(ref array[0], comparison); break;
				case 11: SNBestKnown.Sort11Descending(ref array[0], comparison); break;
				case 12: SNBestKnown.Sort12Descending(ref array[0], comparison); break;
				case 13: SNBestKnown.Sort13Descending(ref array[0], comparison); break;
				case 14: SNBestKnown.Sort14Descending(ref array[0], comparison); break;
				case 15: SNBestKnown.Sort15Descending(ref array[0], comparison); break;
				case 16: SNBestKnown.Sort16Descending(ref array[0], comparison); break;
				case 17: SNBoseNelson.Sort17Descending(ref array[0], comparison); break;
				case 18: SNBoseNelson.Sort18Descending(ref array[0], comparison); break;
				case 19: SNBoseNelson.Sort19Descending(ref array[0], comparison); break;
				case 20: SNBoseNelson.Sort20Descending(ref array[0], comparison); break;
				case 21: SNBoseNelson.Sort21Descending(ref array[0], comparison); break;
				case 22: SNBoseNelson.Sort22Descending(ref array[0], comparison); break;
				case 23: SNBoseNelson.Sort23Descending(ref array[0], comparison); break;
				case 24: SNBoseNelson.Sort24Descending(ref array[0], comparison); break;
				case 25: SNBoseNelson.Sort25Descending(ref array[0], comparison); break;
				case 26: SNBoseNelson.Sort26Descending(ref array[0], comparison); break;
				case 27: SNBoseNelson.Sort27Descending(ref array[0], comparison); break;
				case 28: SNBoseNelson.Sort28Descending(ref array[0], comparison); break;
				case 29: SNBoseNelson.Sort29Descending(ref array[0], comparison); break;
				case 30: SNBoseNelson.Sort30Descending(ref array[0], comparison); break;
				case 31: SNBoseNelson.Sort31Descending(ref array[0], comparison); break;
				case 32: SNBoseNelson.Sort32Descending(ref array[0], comparison); break;
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

			switch (buffer.Length)
			{
				case 2: SNBoseNelson.Sort2Ascending(ref buffer[0], comparison); break;
				case 3: SNBoseNelson.Sort3Ascending(ref buffer[0], comparison); break;
				case 4: SNBoseNelson.Sort4Ascending(ref buffer[0], comparison); break;
				case 5: SNBoseNelson.Sort5Ascending(ref buffer[0], comparison); break;
				case 6: SNBoseNelson.Sort6Ascending(ref buffer[0], comparison); break;
				case 7: SNBoseNelson.Sort7Ascending(ref buffer[0], comparison); break;
				case 8: SNBoseNelson.Sort8Ascending(ref buffer[0], comparison); break;
				case 9: SNBestKnown.Sort9Ascending(ref buffer[0], comparison); break;
				case 10: SNBestKnown.Sort10Ascending(ref buffer[0], comparison); break;
				case 11: SNBestKnown.Sort11Ascending(ref buffer[0], comparison); break;
				case 12: SNBestKnown.Sort12Ascending(ref buffer[0], comparison); break;
				case 13: SNBestKnown.Sort13Ascending(ref buffer[0], comparison); break;
				case 14: SNBestKnown.Sort14Ascending(ref buffer[0], comparison); break;
				case 15: SNBestKnown.Sort15Ascending(ref buffer[0], comparison); break;
				case 16: SNBestKnown.Sort16Ascending(ref buffer[0], comparison); break;
				case 17: SNBoseNelson.Sort17Ascending(ref buffer[0], comparison); break;
				case 18: SNBoseNelson.Sort18Ascending(ref buffer[0], comparison); break;
				case 19: SNBoseNelson.Sort19Ascending(ref buffer[0], comparison); break;
				case 20: SNBoseNelson.Sort20Ascending(ref buffer[0], comparison); break;
				case 21: SNBoseNelson.Sort21Ascending(ref buffer[0], comparison); break;
				case 22: SNBoseNelson.Sort22Ascending(ref buffer[0], comparison); break;
				case 23: SNBoseNelson.Sort23Ascending(ref buffer[0], comparison); break;
				case 24: SNBoseNelson.Sort24Ascending(ref buffer[0], comparison); break;
				case 25: SNBoseNelson.Sort25Ascending(ref buffer[0], comparison); break;
				case 26: SNBoseNelson.Sort26Ascending(ref buffer[0], comparison); break;
				case 27: SNBoseNelson.Sort27Ascending(ref buffer[0], comparison); break;
				case 28: SNBoseNelson.Sort28Ascending(ref buffer[0], comparison); break;
				case 29: SNBoseNelson.Sort29Ascending(ref buffer[0], comparison); break;
				case 30: SNBoseNelson.Sort30Ascending(ref buffer[0], comparison); break;
				case 31: SNBoseNelson.Sort31Ascending(ref buffer[0], comparison); break;
				case 32: SNBoseNelson.Sort32Ascending(ref buffer[0], comparison); break;
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

			switch (buffer.Length)
			{
				case 2: SNBoseNelson.Sort2Descending(ref buffer[0], comparison); break;
				case 3: SNBoseNelson.Sort3Descending(ref buffer[0], comparison); break;
				case 4: SNBoseNelson.Sort4Descending(ref buffer[0], comparison); break;
				case 5: SNBoseNelson.Sort5Descending(ref buffer[0], comparison); break;
				case 6: SNBoseNelson.Sort6Descending(ref buffer[0], comparison); break;
				case 7: SNBoseNelson.Sort7Descending(ref buffer[0], comparison); break;
				case 8: SNBoseNelson.Sort8Descending(ref buffer[0], comparison); break;
				case 9: SNBestKnown.Sort9Descending(ref buffer[0], comparison); break;
				case 10: SNBestKnown.Sort10Descending(ref buffer[0], comparison); break;
				case 11: SNBestKnown.Sort11Descending(ref buffer[0], comparison); break;
				case 12: SNBestKnown.Sort12Descending(ref buffer[0], comparison); break;
				case 13: SNBestKnown.Sort13Descending(ref buffer[0], comparison); break;
				case 14: SNBestKnown.Sort14Descending(ref buffer[0], comparison); break;
				case 15: SNBestKnown.Sort15Descending(ref buffer[0], comparison); break;
				case 16: SNBestKnown.Sort16Descending(ref buffer[0], comparison); break;
				case 17: SNBoseNelson.Sort17Descending(ref buffer[0], comparison); break;
				case 18: SNBoseNelson.Sort18Descending(ref buffer[0], comparison); break;
				case 19: SNBoseNelson.Sort19Descending(ref buffer[0], comparison); break;
				case 20: SNBoseNelson.Sort20Descending(ref buffer[0], comparison); break;
				case 21: SNBoseNelson.Sort21Descending(ref buffer[0], comparison); break;
				case 22: SNBoseNelson.Sort22Descending(ref buffer[0], comparison); break;
				case 23: SNBoseNelson.Sort23Descending(ref buffer[0], comparison); break;
				case 24: SNBoseNelson.Sort24Descending(ref buffer[0], comparison); break;
				case 25: SNBoseNelson.Sort25Descending(ref buffer[0], comparison); break;
				case 26: SNBoseNelson.Sort26Descending(ref buffer[0], comparison); break;
				case 27: SNBoseNelson.Sort27Descending(ref buffer[0], comparison); break;
				case 28: SNBoseNelson.Sort28Descending(ref buffer[0], comparison); break;
				case 29: SNBoseNelson.Sort29Descending(ref buffer[0], comparison); break;
				case 30: SNBoseNelson.Sort30Descending(ref buffer[0], comparison); break;
				case 31: SNBoseNelson.Sort31Descending(ref buffer[0], comparison); break;
				case 32: SNBoseNelson.Sort32Descending(ref buffer[0], comparison); break;
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

			switch (array.Length)
			{
				case 2: SNBoseNelson.Sort2Ascending(ref array[0], comparisonPointer); break;
				case 3: SNBoseNelson.Sort3Ascending(ref array[0], comparisonPointer); break;
				case 4: SNBoseNelson.Sort4Ascending(ref array[0], comparisonPointer); break;
				case 5: SNBoseNelson.Sort5Ascending(ref array[0], comparisonPointer); break;
				case 6: SNBoseNelson.Sort6Ascending(ref array[0], comparisonPointer); break;
				case 7: SNBoseNelson.Sort7Ascending(ref array[0], comparisonPointer); break;
				case 8: SNBoseNelson.Sort8Ascending(ref array[0], comparisonPointer); break;
				case 9: SNBestKnown.Sort9Ascending(ref array[0], comparisonPointer); break;
				case 10: SNBestKnown.Sort10Ascending(ref array[0], comparisonPointer); break;
				case 11: SNBestKnown.Sort11Ascending(ref array[0], comparisonPointer); break;
				case 12: SNBestKnown.Sort12Ascending(ref array[0], comparisonPointer); break;
				case 13: SNBestKnown.Sort13Ascending(ref array[0], comparisonPointer); break;
				case 14: SNBestKnown.Sort14Ascending(ref array[0], comparisonPointer); break;
				case 15: SNBestKnown.Sort15Ascending(ref array[0], comparisonPointer); break;
				case 16: SNBestKnown.Sort16Ascending(ref array[0], comparisonPointer); break;
				case 17: SNBoseNelson.Sort17Ascending(ref array[0], comparisonPointer); break;
				case 18: SNBoseNelson.Sort18Ascending(ref array[0], comparisonPointer); break;
				case 19: SNBoseNelson.Sort19Ascending(ref array[0], comparisonPointer); break;
				case 20: SNBoseNelson.Sort20Ascending(ref array[0], comparisonPointer); break;
				case 21: SNBoseNelson.Sort21Ascending(ref array[0], comparisonPointer); break;
				case 22: SNBoseNelson.Sort22Ascending(ref array[0], comparisonPointer); break;
				case 23: SNBoseNelson.Sort23Ascending(ref array[0], comparisonPointer); break;
				case 24: SNBoseNelson.Sort24Ascending(ref array[0], comparisonPointer); break;
				case 25: SNBoseNelson.Sort25Ascending(ref array[0], comparisonPointer); break;
				case 26: SNBoseNelson.Sort26Ascending(ref array[0], comparisonPointer); break;
				case 27: SNBoseNelson.Sort27Ascending(ref array[0], comparisonPointer); break;
				case 28: SNBoseNelson.Sort28Ascending(ref array[0], comparisonPointer); break;
				case 29: SNBoseNelson.Sort29Ascending(ref array[0], comparisonPointer); break;
				case 30: SNBoseNelson.Sort30Ascending(ref array[0], comparisonPointer); break;
				case 31: SNBoseNelson.Sort31Ascending(ref array[0], comparisonPointer); break;
				case 32: SNBoseNelson.Sort32Ascending(ref array[0], comparisonPointer); break;
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

			switch (array.Length)
			{
				case 2: SNBoseNelson.Sort2Descending(ref array[0], comparisonPointer); break;
				case 3: SNBoseNelson.Sort3Descending(ref array[0], comparisonPointer); break;
				case 4: SNBoseNelson.Sort4Descending(ref array[0], comparisonPointer); break;
				case 5: SNBoseNelson.Sort5Descending(ref array[0], comparisonPointer); break;
				case 6: SNBoseNelson.Sort6Descending(ref array[0], comparisonPointer); break;
				case 7: SNBoseNelson.Sort7Descending(ref array[0], comparisonPointer); break;
				case 8: SNBoseNelson.Sort8Descending(ref array[0], comparisonPointer); break;
				case 9: SNBestKnown.Sort9Descending(ref array[0], comparisonPointer); break;
				case 10: SNBestKnown.Sort10Descending(ref array[0], comparisonPointer); break;
				case 11: SNBestKnown.Sort11Descending(ref array[0], comparisonPointer); break;
				case 12: SNBestKnown.Sort12Descending(ref array[0], comparisonPointer); break;
				case 13: SNBestKnown.Sort13Descending(ref array[0], comparisonPointer); break;
				case 14: SNBestKnown.Sort14Descending(ref array[0], comparisonPointer); break;
				case 15: SNBestKnown.Sort15Descending(ref array[0], comparisonPointer); break;
				case 16: SNBestKnown.Sort16Descending(ref array[0], comparisonPointer); break;
				case 17: SNBoseNelson.Sort17Descending(ref array[0], comparisonPointer); break;
				case 18: SNBoseNelson.Sort18Descending(ref array[0], comparisonPointer); break;
				case 19: SNBoseNelson.Sort19Descending(ref array[0], comparisonPointer); break;
				case 20: SNBoseNelson.Sort20Descending(ref array[0], comparisonPointer); break;
				case 21: SNBoseNelson.Sort21Descending(ref array[0], comparisonPointer); break;
				case 22: SNBoseNelson.Sort22Descending(ref array[0], comparisonPointer); break;
				case 23: SNBoseNelson.Sort23Descending(ref array[0], comparisonPointer); break;
				case 24: SNBoseNelson.Sort24Descending(ref array[0], comparisonPointer); break;
				case 25: SNBoseNelson.Sort25Descending(ref array[0], comparisonPointer); break;
				case 26: SNBoseNelson.Sort26Descending(ref array[0], comparisonPointer); break;
				case 27: SNBoseNelson.Sort27Descending(ref array[0], comparisonPointer); break;
				case 28: SNBoseNelson.Sort28Descending(ref array[0], comparisonPointer); break;
				case 29: SNBoseNelson.Sort29Descending(ref array[0], comparisonPointer); break;
				case 30: SNBoseNelson.Sort30Descending(ref array[0], comparisonPointer); break;
				case 31: SNBoseNelson.Sort31Descending(ref array[0], comparisonPointer); break;
				case 32: SNBoseNelson.Sort32Descending(ref array[0], comparisonPointer); break;
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
			switch (buffer.Length)
			{
				case 2: SNBoseNelson.Sort2Ascending(ref buffer[0], comparisonPointer); break;
				case 3: SNBoseNelson.Sort3Ascending(ref buffer[0], comparisonPointer); break;
				case 4: SNBoseNelson.Sort4Ascending(ref buffer[0], comparisonPointer); break;
				case 5: SNBoseNelson.Sort5Ascending(ref buffer[0], comparisonPointer); break;
				case 6: SNBoseNelson.Sort6Ascending(ref buffer[0], comparisonPointer); break;
				case 7: SNBoseNelson.Sort7Ascending(ref buffer[0], comparisonPointer); break;
				case 8: SNBoseNelson.Sort8Ascending(ref buffer[0], comparisonPointer); break;
				case 9: SNBestKnown.Sort9Ascending(ref buffer[0], comparisonPointer); break;
				case 10: SNBestKnown.Sort10Ascending(ref buffer[0], comparisonPointer); break;
				case 11: SNBestKnown.Sort11Ascending(ref buffer[0], comparisonPointer); break;
				case 12: SNBestKnown.Sort12Ascending(ref buffer[0], comparisonPointer); break;
				case 13: SNBestKnown.Sort13Ascending(ref buffer[0], comparisonPointer); break;
				case 14: SNBestKnown.Sort14Ascending(ref buffer[0], comparisonPointer); break;
				case 15: SNBestKnown.Sort15Ascending(ref buffer[0], comparisonPointer); break;
				case 16: SNBestKnown.Sort16Ascending(ref buffer[0], comparisonPointer); break;
				case 17: SNBoseNelson.Sort17Ascending(ref buffer[0], comparisonPointer); break;
				case 18: SNBoseNelson.Sort18Ascending(ref buffer[0], comparisonPointer); break;
				case 19: SNBoseNelson.Sort19Ascending(ref buffer[0], comparisonPointer); break;
				case 20: SNBoseNelson.Sort20Ascending(ref buffer[0], comparisonPointer); break;
				case 21: SNBoseNelson.Sort21Ascending(ref buffer[0], comparisonPointer); break;
				case 22: SNBoseNelson.Sort22Ascending(ref buffer[0], comparisonPointer); break;
				case 23: SNBoseNelson.Sort23Ascending(ref buffer[0], comparisonPointer); break;
				case 24: SNBoseNelson.Sort24Ascending(ref buffer[0], comparisonPointer); break;
				case 25: SNBoseNelson.Sort25Ascending(ref buffer[0], comparisonPointer); break;
				case 26: SNBoseNelson.Sort26Ascending(ref buffer[0], comparisonPointer); break;
				case 27: SNBoseNelson.Sort27Ascending(ref buffer[0], comparisonPointer); break;
				case 28: SNBoseNelson.Sort28Ascending(ref buffer[0], comparisonPointer); break;
				case 29: SNBoseNelson.Sort29Ascending(ref buffer[0], comparisonPointer); break;
				case 30: SNBoseNelson.Sort30Ascending(ref buffer[0], comparisonPointer); break;
				case 31: SNBoseNelson.Sort31Ascending(ref buffer[0], comparisonPointer); break;
				case 32: SNBoseNelson.Sort32Ascending(ref buffer[0], comparisonPointer); break;
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
			switch (buffer.Length)
			{
				case 2: SNBoseNelson.Sort2Descending(ref buffer[0], comparisonPointer); break;
				case 3: SNBoseNelson.Sort3Descending(ref buffer[0], comparisonPointer); break;
				case 4: SNBoseNelson.Sort4Descending(ref buffer[0], comparisonPointer); break;
				case 5: SNBoseNelson.Sort5Descending(ref buffer[0], comparisonPointer); break;
				case 6: SNBoseNelson.Sort6Descending(ref buffer[0], comparisonPointer); break;
				case 7: SNBoseNelson.Sort7Descending(ref buffer[0], comparisonPointer); break;
				case 8: SNBoseNelson.Sort8Descending(ref buffer[0], comparisonPointer); break;
				case 9: SNBestKnown.Sort9Descending(ref buffer[0], comparisonPointer); break;
				case 10: SNBestKnown.Sort10Descending(ref buffer[0], comparisonPointer); break;
				case 11: SNBestKnown.Sort11Descending(ref buffer[0], comparisonPointer); break;
				case 12: SNBestKnown.Sort12Descending(ref buffer[0], comparisonPointer); break;
				case 13: SNBestKnown.Sort13Descending(ref buffer[0], comparisonPointer); break;
				case 14: SNBestKnown.Sort14Descending(ref buffer[0], comparisonPointer); break;
				case 15: SNBestKnown.Sort15Descending(ref buffer[0], comparisonPointer); break;
				case 16: SNBestKnown.Sort16Descending(ref buffer[0], comparisonPointer); break;
				case 17: SNBoseNelson.Sort17Descending(ref buffer[0], comparisonPointer); break;
				case 18: SNBoseNelson.Sort18Descending(ref buffer[0], comparisonPointer); break;
				case 19: SNBoseNelson.Sort19Descending(ref buffer[0], comparisonPointer); break;
				case 20: SNBoseNelson.Sort20Descending(ref buffer[0], comparisonPointer); break;
				case 21: SNBoseNelson.Sort21Descending(ref buffer[0], comparisonPointer); break;
				case 22: SNBoseNelson.Sort22Descending(ref buffer[0], comparisonPointer); break;
				case 23: SNBoseNelson.Sort23Descending(ref buffer[0], comparisonPointer); break;
				case 24: SNBoseNelson.Sort24Descending(ref buffer[0], comparisonPointer); break;
				case 25: SNBoseNelson.Sort25Descending(ref buffer[0], comparisonPointer); break;
				case 26: SNBoseNelson.Sort26Descending(ref buffer[0], comparisonPointer); break;
				case 27: SNBoseNelson.Sort27Descending(ref buffer[0], comparisonPointer); break;
				case 28: SNBoseNelson.Sort28Descending(ref buffer[0], comparisonPointer); break;
				case 29: SNBoseNelson.Sort29Descending(ref buffer[0], comparisonPointer); break;
				case 30: SNBoseNelson.Sort30Descending(ref buffer[0], comparisonPointer); break;
				case 31: SNBoseNelson.Sort31Descending(ref buffer[0], comparisonPointer); break;
				case 32: SNBoseNelson.Sort32Descending(ref buffer[0], comparisonPointer); break;
				default:
					{
						throw new ArgumentOutOfRangeException(nameof(buffer), $"Buffer length `{buffer.Length}` must be between `{MinLength}` and `{MaxLength}`.");
					}
			}
		}
	}
}