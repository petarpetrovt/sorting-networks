namespace SortingNetworks.Tests
{
	using System;
	using System.Collections.Generic;
	using System.Globalization;
	using System.Linq;
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	public abstract class SNTestsBase
	{
		protected static void GenerateArraysAscending<T>(GenerationMode mode, int length, out T[] expected, out T[] actual)
			where T : unmanaged, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
		{
			expected = PrivateGenerateArrays<T>(mode, ascending: true, length);
			actual = PrivateGenerateArrays(mode, expected, length);
		}

		protected static void GenerateSpansAscending<T>(GenerationMode mode, int length, out Span<T> expected, out Span<T> actual)
			where T : unmanaged, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
		{
			T[] expectedArray = PrivateGenerateArrays<T>(mode, ascending: true, length);

			expected = expectedArray.AsSpan();
			actual = PrivateGenerateArrays(mode, expectedArray, length);
		}

		protected static void GenerateArraysDescending<T>(GenerationMode mode, int length, out T[] expected, out T[] actual)
			where T : unmanaged, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
		{
			expected = PrivateGenerateArrays<T>(mode, ascending: false, length);
			actual = PrivateGenerateArrays(mode, expected, length);
		}

		protected static void GenerateSpansDescending<T>(GenerationMode mode, int length, out Span<T> expected, out Span<T> actual)
			where T : unmanaged, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
		{
			T[] expectedArray = PrivateGenerateArrays<T>(mode, ascending: false, length);

			expected = expectedArray.AsSpan();
			actual = PrivateGenerateArrays(mode, expectedArray, length);
		}

		protected static void AssertAreEqual<T>(Span<T> expected, Span<T> actual, string message)
			where T : unmanaged, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
		{
			if (message is null)
			{
				throw new ArgumentNullException(nameof(message));
			}

			if (expected.Length != actual.Length)
			{
				Assert.Fail(message);
			}

			for (int i = 0; i < expected.Length; i++)
			{
				if (expected[i].CompareTo(actual[i]) != 0)
				{
					Assert.Fail(message);
				}
			}
		}

		protected static int InternalComparison<T>(T a, T b)
			where T : unmanaged, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
			=> a.CompareTo(b);

		private static T[] PrivateGenerateArrays<T>(GenerationMode mode, T[] expected, int length)
			where T : unmanaged, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
		{
			T[] actual = mode switch
			{
				GenerationMode.Sorted
					=> expected.ToArray(),
				GenerationMode.Reverse
					=> expected.Reverse().ToArray(),
				GenerationMode.OddBiggerThanEven
					=> expected.Select(x =>
					{
						long value = Convert.ToInt64(x, CultureInfo.InvariantCulture);
						if (value % 2 == 0)
						{
							return (T)Convert.ChangeType(value - 1, typeof(T), CultureInfo.InvariantCulture);
						}
						else if (value + 1 < length || length % 2 == 0)
						{
							return (T)Convert.ChangeType(value + 1, typeof(T), CultureInfo.InvariantCulture);
						}
						else
						{
							return x;
						}
					}).ToArray(),
				GenerationMode.EvenBiggerThanOdd
					=> expected.Select(x =>
					{
						long value = Convert.ToInt64(x, CultureInfo.InvariantCulture);
						if (value % 2 == 0)
						{
							return (T)Convert.ChangeType(value - 1, typeof(T), CultureInfo.InvariantCulture);
						}
						else if (value + 1 < length || length % 2 == 0)
						{
							return (T)Convert.ChangeType(value + 1, typeof(T), CultureInfo.InvariantCulture);
						}
						else
						{
							return x;
						}
					}).Reverse().ToArray(),
				GenerationMode.Random
					=> expected.OrderBy(x => ThreadSafeRandom.Next()).ToArray(),
				GenerationMode.SpecialValues
					=> expected.ToArray(),
				_
					=> throw new Exception($"Generation mode `{mode}` is not supported in this context."),
			};

			//Debug.WriteLine(string.Join(", ", actual));
			//Debug.Assert(expected.Length == actual.Length);
			//Debug.Assert(expected.Length == actual.Distinct().Count());

			return actual;
		}

		private static T[] PrivateGenerateArrays<T>(GenerationMode mode, bool ascending, int length)
			where T : unmanaged, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
		{
			IEnumerable<T> result;

			if (mode == GenerationMode.SpecialValues)
			{
				result = Enumerable
					.Range(1, length)
					.Select(x => Helper<T>.Values[ThreadSafeRandom.Next(0, Helper<T>.Values.Length)])
					.OrderBy(x => x)
					.Select(x => (T)Convert.ChangeType(x, typeof(T), CultureInfo.InvariantCulture));
			}
			else
			{
				result = Enumerable
					.Range(1, length)
					.Select(x => (T)Convert.ChangeType(x, typeof(T), CultureInfo.InvariantCulture));
			}

			if (!ascending)
			{
				result = result.Reverse();
			}

			return result.ToArray();
		}

		private static class Helper<T>
			where T : unmanaged
		{
			public readonly static T[] Values;

			static Helper()
			{
				Values = typeof(T) switch
				{
#pragma warning disable CA1508 // Avoid dead conditional code
					Type type when type == typeof(byte)
						=> (new byte[] { byte.MinValue, byte.MaxValue }).Select(x => (T)Convert.ChangeType(x, typeof(T), CultureInfo.InvariantCulture)).ToArray(),
					Type type when type == typeof(sbyte)
						=> (new sbyte[] { sbyte.MinValue, sbyte.MaxValue }).Select(x => (T)Convert.ChangeType(x, typeof(T), CultureInfo.InvariantCulture)).ToArray(),
					Type type when type == typeof(ushort)
						=> (new ushort[] { ushort.MinValue, ushort.MaxValue }).Select(x => (T)Convert.ChangeType(x, typeof(T), CultureInfo.InvariantCulture)).ToArray(),
					Type type when type == typeof(short)
						=> (new short[] { short.MinValue, short.MaxValue }).Select(x => (T)Convert.ChangeType(x, typeof(T), CultureInfo.InvariantCulture)).ToArray(),
					Type type when type == typeof(uint)
						=> (new uint[] { uint.MinValue, uint.MaxValue }).Select(x => (T)Convert.ChangeType(x, typeof(T), CultureInfo.InvariantCulture)).ToArray(),
					Type type when type == typeof(int)
						=> (new int[] { int.MinValue, int.MaxValue }).Select(x => (T)Convert.ChangeType(x, typeof(T), CultureInfo.InvariantCulture)).ToArray(),
#pragma warning restore CA1508 // Avoid dead conditional code
					_
						=> Array.Empty<T>(),
				};
			}
		}
	}
}
