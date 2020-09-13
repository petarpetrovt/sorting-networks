namespace SortingNetworks.Tests
{
	using System;
	using System.Linq;
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	public abstract class SNTestsBase
	{
		protected static void GenerateArraysAscending(int length, out int[] expected, out int[] actual)
		{
			expected = Enumerable.Range(0, length).ToArray();
			actual = expected.Reverse().ToArray();
		}

		protected static void GenerateSpansAscending(int length, out Span<int> expected, out Span<int> actual)
		{
			int[] temp = Enumerable.Range(0, length).ToArray();

			expected = temp.AsSpan();
			actual = temp.Reverse().ToArray().AsSpan();
		}

		protected static void GenerateArraysDescending(int length, out int[] expected, out int[] actual)
		{
			actual = Enumerable.Range(0, length).ToArray();
			expected = actual.Reverse().ToArray();
		}

		protected static void GenerateSpansDescending(int length, out Span<int> expected, out Span<int> actual)
		{
			int[] temp = Enumerable.Range(0, length).ToArray();

			actual = temp.AsSpan();
			expected = temp.Reverse().ToArray().AsSpan();
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
	}
}
