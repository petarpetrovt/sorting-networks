namespace SortingNetworks.Tests
{
	using System;
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class SNBestKnownTests : SNTestsBase
	{
		[TestMethod]
		public void Ascending_IComparable()
		{
			for (int length = SNBestKnown.MinLength; length <= SNBestKnown.MaxLength; length++)
			{
				GenerateArraysAscending(length, out int[] expected, out int[] actual);

				SNBestKnown.SortAscending(ref actual[0], length);

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		public void Descending_IComparable()
		{
			for (int length = SNBestKnown.MinLength; length <= SNBestKnown.MaxLength; length++)
			{
				GenerateArraysDescending(length, out int[] expected, out int[] actual);

				SNBestKnown.SortDescending(ref actual[0], length);

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		public void Ascending_Comparison()
		{
			for (int length = SNBestKnown.MinLength; length <= SNBestKnown.MaxLength; length++)
			{
				GenerateArraysAscending(length, out int[] expected, out int[] actual);

				SNBestKnown.SortAscending(ref actual[0], length, (a, b) => a.CompareTo(b));

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		public void Descending_Comparison()
		{
			for (int length = SNBestKnown.MinLength; length <= SNBestKnown.MaxLength; length++)
			{
				GenerateArraysDescending(length, out int[] expected, out int[] actual);

				SNBestKnown.SortDescending(ref actual[0], length, (a, b) => a.CompareTo(b));

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		public void Ascending_IComparable_OutOfRange()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
			{
				GenerateArraysAscending(SNBestKnown.MinLength - 1, out int[] expected, out int[] actual);

				SNBestKnown.SortAscending(ref actual[0], actual.Length);
			});
		}

		[TestMethod]
		public void Descending_IComparable_OutOfRange()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
			{
				GenerateArraysDescending(SNBestKnown.MinLength - 1, out int[] expected, out int[] actual);

				SNBestKnown.SortDescending(ref actual[0], actual.Length);
			});
		}

		[TestMethod]
		public void Ascending_Comparison_OutOfRange()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
			{
				GenerateArraysAscending(SNBestKnown.MinLength - 1, out int[] expected, out int[] actual);

				SNBestKnown.SortAscending(ref actual[0], actual.Length, (a, b) => a.CompareTo(b));
			});
		}

		[TestMethod]
		public void Descending_Comparison_OutOfRange()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
			{
				GenerateArraysDescending(SNBestKnown.MinLength - 1, out int[] expected, out int[] actual);

				SNBestKnown.SortDescending(ref actual[0], actual.Length, (a, b) => a.CompareTo(b));
			});
		}

		[TestMethod]
		public void Ascending_Comparison_ComparisonNull()
		{
			Assert.ThrowsException<ArgumentNullException>(() =>
			{
				GenerateArraysAscending(SNBestKnown.MinLength - 1, out int[] expected, out int[] actual);

				SNBestKnown.SortAscending(ref actual[0], actual.Length, comparison: null);
			});
		}

		[TestMethod]
		public void Descending_Comparison_ComparisonNull()
		{
			Assert.ThrowsException<ArgumentNullException>(() =>
			{
				GenerateArraysDescending(SNBestKnown.MinLength - 1, out int[] expected, out int[] actual);

				SNBestKnown.SortDescending(ref actual[0], actual.Length, comparison: null);
			});
		}
	}
}
