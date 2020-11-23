namespace SortingNetworks.Tests
{
	using System;
	using System.Linq;
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	public abstract class SNTestsBase
	{
		protected static void GenerateArraysAscending<T>(GenerationMode mode, int length, out T[] expected, out T[] actual)
			where T : unmanaged, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
		{
			expected = Enumerable.Range(1, length).Select(x => (T)Convert.ChangeType(x, typeof(T))).ToArray();
			actual = PrivateGenerateArrays(mode, expected, length);
		}

		protected static void GenerateSpansAscending<T>(GenerationMode mode, int length, out Span<T> expected, out Span<T> actual)
			where T : unmanaged, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
		{
			T[] expectedArray = Enumerable.Range(1, length).Select(x => (T)Convert.ChangeType(x, typeof(T))).ToArray();

			expected = expectedArray.AsSpan();
			actual = PrivateGenerateArrays(mode, expectedArray, length);
		}

		protected static void GenerateArraysDescending<T>(GenerationMode mode, int length, out T[] expected, out T[] actual)
			where T : unmanaged, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
		{
			expected = Enumerable.Range(1, length).Reverse().Select(x => (T)Convert.ChangeType(x, typeof(T))).ToArray();
			actual = PrivateGenerateArrays(mode, expected, length);
		}

		protected static void GenerateSpansDescending<T>(GenerationMode mode, int length, out Span<T> expected, out Span<T> actual)
			where T : unmanaged, IComparable, IComparable<T>, IConvertible, IEquatable<T>, IFormattable
		{
			T[] expectedArray = Enumerable.Range(1, length).Reverse().Select(x => (T)Convert.ChangeType(x, typeof(T))).ToArray();

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
			where T : unmanaged
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
						long value = Convert.ToInt64(x);
						if (value % 2 == 0)
						{
							return (T)Convert.ChangeType(value - 1, typeof(T));
						}
						else if (value + 1 < length || length % 2 == 0)
						{
							return (T)Convert.ChangeType(value + 1, typeof(T));
						}
						else
						{
							return x;
						}
					}).ToArray(),
				GenerationMode.EvenBiggerThanOdd
					=> expected.Select(x =>
					{
						long value = Convert.ToInt64(x);
						if (value % 2 == 0)
						{
							return (T)Convert.ChangeType(value - 1, typeof(T));
						}
						else if (value + 1 < length || length % 2 == 0)
						{
							return (T)Convert.ChangeType(value + 1, typeof(T));
						}
						else
						{
							return x;
						}
					}).Reverse().ToArray(),
				GenerationMode.Random
					=> expected.OrderBy(x => ThreadSafeRandom.Next()).ToArray(),
				_
					=> throw new Exception($"Generation mode `{mode}` is not supported in this context."),
			};

			//Debug.WriteLine(string.Join(", ", actual));
			//Debug.Assert(expected.Length == actual.Length);
			//Debug.Assert(expected.Length == actual.Distinct().Count());

			return actual;
		}
	}
}
