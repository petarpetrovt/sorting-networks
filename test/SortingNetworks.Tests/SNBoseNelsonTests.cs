namespace SortingNetworks.Tests
{
	using System;
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class SNBoseNelsonTests : SNTestsBase
	{
		[TestMethod]
		public void Ascending_Comparable()
		{
			for (int length = SNBoseNelson.MinLength; length <= SNBoseNelson.MaxLength; length++)
			{
				GenerateArraysAscending(length, out int[] expected, out int[] actual);

				SNBoseNelson.SortAscending(ref actual[0], length);

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		public void Descending_Comparable()
		{
			for (int length = SNBoseNelson.MinLength; length <= SNBoseNelson.MaxLength; length++)
			{
				GenerateArraysDescending(length, out int[] expected, out int[] actual);

				SNBoseNelson.SortDescending(ref actual[0], length);

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		public void Ascending_Comparison()
		{
			for (int length = SNBoseNelson.MinLength; length <= SNBoseNelson.MaxLength; length++)
			{
				GenerateArraysAscending(length, out int[] expected, out int[] actual);

				SNBoseNelson.SortAscending(ref actual[0], length, InternalComparison);

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		public void Descending_Comparison()
		{
			for (int length = SNBoseNelson.MinLength; length <= SNBoseNelson.MaxLength; length++)
			{
				GenerateArraysDescending(length, out int[] expected, out int[] actual);

				SNBoseNelson.SortDescending(ref actual[0], length, InternalComparison);

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		public unsafe void Ascending_ComparisonPointer()
		{
			for (int length = SNBoseNelson.MinLength; length <= SNBoseNelson.MaxLength; length++)
			{
				GenerateArraysAscending(length, out int[] expected, out int[] actual);

				SNBoseNelson.SortAscending(ref actual[0], length, &InternalComparison);

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		public unsafe void Descending_ComparisonPointer()
		{
			for (int length = SNBoseNelson.MinLength; length <= SNBoseNelson.MaxLength; length++)
			{
				GenerateArraysDescending(length, out int[] expected, out int[] actual);

				SNBoseNelson.SortDescending(ref actual[0], length, &InternalComparison);

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		public void Ascending_Comparable_OutOfRange()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
			{
				GenerateArraysAscending(SNBoseNelson.MinLength - 1, out int[] expected, out int[] actual);

				SNBoseNelson.SortAscending(ref actual[0], actual.Length);
			});
		}

		[TestMethod]
		public void Descending_Comparable_OutOfRange()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
			{
				GenerateArraysDescending(SNBoseNelson.MinLength - 1, out int[] expected, out int[] actual);

				SNBoseNelson.SortDescending(ref actual[0], actual.Length);
			});
		}

		[TestMethod]
		public void Ascending_Comparison_OutOfRange()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
			{
				GenerateArraysAscending(SNBoseNelson.MinLength - 1, out int[] expected, out int[] actual);

				SNBoseNelson.SortAscending(ref actual[0], actual.Length, (a, b) => a.CompareTo(b));
			});
		}

		[TestMethod]
		public void Descending_Comparison_OutOfRange()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
			{
				GenerateArraysDescending(SNBoseNelson.MinLength - 1, out int[] expected, out int[] actual);

				SNBoseNelson.SortDescending(ref actual[0], actual.Length, (a, b) => a.CompareTo(b));
			});
		}

		[TestMethod]
		public unsafe void Ascending_ComparisonPointer_OutOfRange()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
			{
				GenerateArraysAscending(SNBoseNelson.MinLength - 1, out int[] expected, out int[] actual);

				SNBoseNelson.SortAscending(ref actual[0], actual.Length, &InternalComparison);
			});
		}

		[TestMethod]
		public unsafe void Descending_ComparisonPointer_OutOfRange()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
			{
				GenerateArraysDescending(SNBoseNelson.MinLength - 1, out int[] expected, out int[] actual);

				SNBoseNelson.SortDescending(ref actual[0], actual.Length, &InternalComparison);
			});
		}

		[TestMethod]
		public void Ascending_Comparison_ComparisonNull()
		{
			Assert.ThrowsException<ArgumentNullException>(() =>
			{
				GenerateArraysAscending(SNBoseNelson.MinLength - 1, out int[] expected, out int[] actual);

				SNBoseNelson.SortAscending(ref actual[0], actual.Length, comparison: null);
			});
		}

		[TestMethod]
		public void Descending_Comparison_ComparisonNull()
		{
			Assert.ThrowsException<ArgumentNullException>(() =>
			{
				GenerateArraysDescending(SNBoseNelson.MinLength - 1, out int[] expected, out int[] actual);

				SNBoseNelson.SortDescending(ref actual[0], actual.Length, comparison: null);
			});
		}
	}
}
