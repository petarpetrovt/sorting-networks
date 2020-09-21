namespace SortingNetworks.Tests
{
	using System;
	using System.Linq;
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	public abstract class SNTestsBase
	{
		protected static void GenerateArraysAscending(GenerationMode mode, int length, out int[] expected, out int[] actual)
		{
			expected = Enumerable.Range(0, length).ToArray();
			actual = mode switch
			{
				GenerationMode.Sorted => expected.ToArray(),
				GenerationMode.Reverse => expected.Reverse().ToArray(),
				GenerationMode.Random => expected.OrderBy(x => ThreadSafeRandom.Next()).ToArray(),
				_ => throw new Exception($"Generation mode `{mode}` is not supported in this context."),
			};
		}

		protected static void GenerateSpansAscending(GenerationMode mode, int length, out Span<int> expected, out Span<int> actual)
		{
			int[] temp = Enumerable.Range(0, length).ToArray();

			expected = temp.AsSpan();
			actual = mode switch
			{
				GenerationMode.Sorted => temp.ToArray().AsSpan(),
				GenerationMode.Reverse => temp.Reverse().ToArray().AsSpan(),
				GenerationMode.Random => temp.ToArray().OrderBy(x => ThreadSafeRandom.Next()).ToArray().AsSpan(),
				_ => throw new Exception($"Generation mode `{mode}` is not supported in this context."),
			};
		}

		protected static void GenerateArraysDescending(GenerationMode mode, int length, out int[] expected, out int[] actual)
		{
			expected = Enumerable.Range(0, length).Reverse().ToArray();
			actual = mode switch
			{
				GenerationMode.Sorted => expected.ToArray(),
				GenerationMode.Reverse => expected.Reverse().ToArray(),
				GenerationMode.Random => expected.OrderBy(x => ThreadSafeRandom.Next()).ToArray(),
				_ => throw new Exception($"Generation mode `{mode}` is not supported in this context."),
			};
		}

		protected static void GenerateSpansDescending(GenerationMode mode, int length, out Span<int> expected, out Span<int> actual)
		{
			int[] temp = Enumerable.Range(0, length).Reverse().ToArray();

			expected = temp.AsSpan();
			actual = mode switch
			{
				GenerationMode.Sorted => temp.ToArray().AsSpan(),
				GenerationMode.Reverse => temp.Reverse().ToArray().AsSpan(),
				GenerationMode.Random => temp.ToArray().OrderBy(x => ThreadSafeRandom.Next()).ToArray().AsSpan(),
				_ => throw new Exception($"Generation mode `{mode}` is not supported in this context."),
			};
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
	}
}
