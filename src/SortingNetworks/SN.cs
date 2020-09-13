namespace SortingNetworks
{
	using System;

	public static class SN
	{
		public const int MinLength = 2;
		public const int MaxLength = 16;

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
				default:
					{
						throw new ArgumentOutOfRangeException(nameof(array), $"Array length `{array.Length}` must be between `{MinLength}` and `{MaxLength}`.");
					}
			}
		}

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
				default:
					{
						throw new ArgumentOutOfRangeException(nameof(array), $"Array length `{array.Length}` must be between `{MinLength}` and `{MaxLength}`.");
					}
			}
		}

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
				default:
					{
						throw new ArgumentOutOfRangeException(nameof(buffer), $"Buffer length `{buffer.Length}` must be between `{MinLength}` and `{MaxLength}`.");
					}
			}
		}

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
				default:
					{
						throw new ArgumentOutOfRangeException(nameof(buffer), $"Buffer length `{buffer.Length}` must be between `{MinLength}` and `{MaxLength}`.");
					}
			}
		}

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
				default:
					{
						throw new ArgumentOutOfRangeException(nameof(array), $"Array length `{array.Length}` must be between `{MinLength}` and `{MaxLength}`.");
					}
			}
		}

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
				default:
					{
						throw new ArgumentOutOfRangeException(nameof(array), $"Array length `{array.Length}` must be between `{MinLength}` and `{MaxLength}`.");
					}
			}
		}

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
				default:
					{
						throw new ArgumentOutOfRangeException(nameof(buffer), $"Buffer length `{buffer.Length}` must be between `{MinLength}` and `{MaxLength}`.");
					}
			}
		}

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
				default:
					{
						throw new ArgumentOutOfRangeException(nameof(buffer), $"Buffer length `{buffer.Length}` must be between `{MinLength}` and `{MaxLength}`.");
					}
			}
		}

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
				default:
					{
						throw new ArgumentOutOfRangeException(nameof(array), $"Array length `{array.Length}` must be between `{MinLength}` and `{MaxLength}`.");
					}
			}
		}

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
				default:
					{
						throw new ArgumentOutOfRangeException(nameof(array), $"Array length `{array.Length}` must be between `{MinLength}` and `{MaxLength}`.");
					}
			}
		}

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
				default:
					{
						throw new ArgumentOutOfRangeException(nameof(buffer), $"Buffer length `{buffer.Length}` must be between `{MinLength}` and `{MaxLength}`.");
					}
			}
		}

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
				default:
					{
						throw new ArgumentOutOfRangeException(nameof(buffer), $"Buffer length `{buffer.Length}` must be between `{MinLength}` and `{MaxLength}`.");
					}
			}
		}
	}
}