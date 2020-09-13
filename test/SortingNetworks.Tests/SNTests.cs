using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortingNetworks.Tests
{
	[TestClass]
	public class SNTests : SNTestsBase
	{
		[TestMethod]
		public void SN_Array_Ascending_IComparable()
		{
			for (int length = SN.MinLength; length <= SN.MaxLength; length++)
			{
				GenerateArraysAscending(length, out int[] expected, out int[] actual);

				SN.SortAscending(actual);

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		public void SN_Array_Descending_IComparable()
		{
			for (int length = SN.MinLength; length <= SN.MaxLength; length++)
			{
				GenerateArraysDescending(length, out int[] expected, out int[] actual);

				SN.SortDescending(actual);

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		public void SN_Array_Ascending_Comparison()
		{
			for (int length = SN.MinLength; length <= SN.MaxLength; length++)
			{
				GenerateArraysAscending(length, out int[] expected, out int[] actual);

				SN.SortAscending(actual, (a, b) => a.CompareTo(b));

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		public void SN_Array_Descending_Comparison()
		{
			for (int length = SN.MinLength; length <= SN.MaxLength; length++)
			{
				GenerateArraysDescending(length, out int[] expected, out int[] actual);

				SN.SortDescending(actual, (a, b) => a.CompareTo(b));

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		public void SN_Span_Ascending_IComparable()
		{
			for (int length = SN.MinLength; length <= SN.MaxLength; length++)
			{
				GenerateSpansAscending(length, out Span<int> expected, out Span<int> actual);

				SN.SortAscending(actual);

				AssertAreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		public void SN_Span_Descending_IComparable()
		{
			for (int length = SN.MinLength; length <= SN.MaxLength; length++)
			{
				GenerateSpansDescending(length, out Span<int> expected, out Span<int> actual);

				SN.SortDescending(actual);

				AssertAreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		public void SN_Span_Ascending_Comparison()
		{
			for (int length = SN.MinLength; length <= SN.MaxLength; length++)
			{
				GenerateSpansAscending(length, out Span<int> expected, out Span<int> actual);

				SN.SortAscending(actual, (a, b) => a.CompareTo(b));

				AssertAreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		public void SN_Span_Descending_Comparison()
		{
			for (int length = SN.MinLength; length <= SN.MaxLength; length++)
			{
				GenerateSpansDescending(length, out Span<int> expected, out Span<int> actual);

				SN.SortDescending(actual, (a, b) => a.CompareTo(b));

				AssertAreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}
	}
}
