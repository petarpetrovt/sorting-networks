namespace SortingNetworks.Tests
{
	using System;
	using System.Linq;
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	public abstract class SNTestsBase
	{
		protected static void GenerateArraysAscending(GenerationMode mode, int length, out int[] expected, out int[] actual)
		{
			expected = Enumerable.Range(1, length).ToArray();
			actual = PrivateGenerateArrays(mode, expected, length);
		}

		protected static void GenerateSpansAscending(GenerationMode mode, int length, out Span<int> expected, out Span<int> actual)
		{
			int[] expectedArray = Enumerable.Range(1, length).ToArray();

			expected = expectedArray.AsSpan();
			actual = PrivateGenerateArrays(mode, expectedArray, length);
		}

		protected static void GenerateArraysDescending(GenerationMode mode, int length, out int[] expected, out int[] actual)
		{
			expected = Enumerable.Range(1, length).Reverse().ToArray();
			actual = PrivateGenerateArrays(mode, expected, length);
		}

		protected static void GenerateSpansDescending(GenerationMode mode, int length, out Span<int> expected, out Span<int> actual)
		{
			int[] expectedArray = Enumerable.Range(1, length).Reverse().ToArray();

			expected = expectedArray.AsSpan();
			actual = PrivateGenerateArrays(mode, expectedArray, length);
		}

		protected static void AssertAreEqual(Span<int> expected, Span<int> actual, string message)
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

		protected static int InternalComparison(int a, int b)
			=> a.CompareTo(b);

		private static int[] PrivateGenerateArrays(GenerationMode mode, int[] expected, int length)
		{
			int[] actual = mode switch
			{
				GenerationMode.Sorted
					=> expected.ToArray(),
				GenerationMode.Reverse
					=> expected.Reverse().ToArray(),
				GenerationMode.OddBiggerThanEven
					=> expected.Select(x =>
					{
						if (x % 2 == 0)
						{
							return x - 1;
						}
						else if (x + 1 < length || length % 2 == 0)
						{
							return x + 1;
						}
						else
						{
							return x;
						}
					}).ToArray(),
				GenerationMode.EvenBiggerThanOdd
					=> expected.Select(x =>
					{
						if (x % 2 == 0)
						{
							return x - 1;
						}
						else if (x + 1 < length || length % 2 == 0)
						{
							return x + 1;
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
