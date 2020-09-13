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
				case int length
					when length >= SNBoseNelson.MinLength
						&& length <= SNBoseNelson.MaxLength:
					{
						SNBoseNelson.SortAscending(ref array[0], length);
						break;
					}
				case int length
					when length >= SNBestKnown.MinLength
						&& length <= SNBestKnown.MaxLength:
					{
						SNBestKnown.SortAscending(ref array[0], length);
						break;
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
				case int length
					when length >= SNBoseNelson.MinLength
						&& length <= SNBoseNelson.MaxLength:
					{
						SNBoseNelson.SortDescending(ref array[0], length);
						break;
					}
				case int length
					when length >= SNBestKnown.MinLength
						&& length <= SNBestKnown.MaxLength:
					{
						SNBestKnown.SortDescending(ref array[0], length);
						break;
					}
			}
		}

		public static void SortAscending<T>(Span<T> buffer)
			where T : IComparable<T>
		{
			switch (buffer.Length)
			{
				case int length
					when length >= SNBoseNelson.MinLength
						&& length <= SNBoseNelson.MaxLength:
					{
						SNBoseNelson.SortAscending(ref buffer[0], length);
						break;
					}
				case int length
					when length >= SNBestKnown.MinLength
						&& length <= SNBestKnown.MaxLength:
					{
						SNBestKnown.SortAscending(ref buffer[0], length);
						break;
					}
			}
		}

		public static void SortDescending<T>(Span<T> buffer)
			where T : IComparable<T>
		{
			switch (buffer.Length)
			{
				case int length
					when length >= SNBoseNelson.MinLength
						&& length <= SNBoseNelson.MaxLength:
					{
						SNBoseNelson.SortDescending(ref buffer[0], length);
						break;
					}
				case int length
					when length >= SNBestKnown.MinLength
						&& length <= SNBestKnown.MaxLength:
					{
						SNBestKnown.SortDescending(ref buffer[0], length);
						break;
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
				case int length
					when length >= SNBoseNelson.MinLength
						&& length <= SNBoseNelson.MaxLength:
					{
						SNBoseNelson.SortAscending(ref array[0], length, comparison);
						break;
					}
				case int length
					when length >= SNBestKnown.MinLength
						&& length <= SNBestKnown.MaxLength:
					{
						SNBestKnown.SortAscending(ref array[0], length, comparison);
						break;
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
				case int length
					when length >= SNBoseNelson.MinLength
						&& length <= SNBoseNelson.MaxLength:
					{
						SNBoseNelson.SortDescending(ref array[0], length, comparison);
						break;
					}
				case int length
					when length >= SNBestKnown.MinLength
						&& length <= SNBestKnown.MaxLength:
					{
						SNBestKnown.SortDescending(ref array[0], length, comparison);
						break;
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
				case int length
					when length >= SNBoseNelson.MinLength
						&& length <= SNBoseNelson.MaxLength:
					{
						SNBoseNelson.SortAscending(ref buffer[0], length, comparison);
						break;
					}
				case int length
					when length >= SNBestKnown.MinLength
						&& length <= SNBestKnown.MaxLength:
					{
						SNBestKnown.SortAscending(ref buffer[0], length, comparison);
						break;
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
				case int length
					when length >= SNBoseNelson.MinLength
						&& length <= SNBoseNelson.MaxLength:
					{
						SNBoseNelson.SortDescending(ref buffer[0], length, comparison);
						break;
					}
				case int length
					when length >= SNBestKnown.MinLength
						&& length <= SNBestKnown.MaxLength:
					{
						SNBestKnown.SortDescending(ref buffer[0], length, comparison);
						break;
					}
			}
		}
	}
}