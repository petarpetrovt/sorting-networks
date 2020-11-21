namespace SortingNetworks.Tests
{
	using System;
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class SNBestKnownTests : SNTestsBase
	{
		[TestMethod]
		[DataRow(GenerationMode.Sorted)]
		[DataRow(GenerationMode.Random)]
		[DataRow(GenerationMode.Reverse)]
		public void Ascending_Comparable(GenerationMode mode)
		{
			for (int length = SNBestKnown.MinLength; length <= SNBestKnown.MaxLength; length++)
			{
				GenerateArraysAscending(mode, length, out int[] expected, out int[] actual);

				SNBestKnown.SortAscending(ref actual[0], length);

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		[DataRow(GenerationMode.Sorted)]
		[DataRow(GenerationMode.Random)]
		[DataRow(GenerationMode.Reverse)]
		public void Descending_Comparable(GenerationMode mode)
		{
			for (int length = SNBestKnown.MinLength; length <= SNBestKnown.MaxLength; length++)
			{
				GenerateArraysDescending(mode, length, out int[] expected, out int[] actual);

				SNBestKnown.SortDescending(ref actual[0], length);

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		[DataRow(GenerationMode.Sorted)]
		[DataRow(GenerationMode.Random)]
		[DataRow(GenerationMode.Reverse)]
		public void Ascending_Comparison(GenerationMode mode)
		{
			for (int length = SNBestKnown.MinLength; length <= SNBestKnown.MaxLength; length++)
			{
				GenerateArraysAscending(mode, length, out int[] expected, out int[] actual);

				SNBestKnown.SortAscending(ref actual[0], length, InternalComparison);

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		[DataRow(GenerationMode.Sorted)]
		[DataRow(GenerationMode.Random)]
		[DataRow(GenerationMode.Reverse)]
		public void Descending_Comparison(GenerationMode mode)
		{
			for (int length = SNBestKnown.MinLength; length <= SNBestKnown.MaxLength; length++)
			{
				GenerateArraysDescending(mode, length, out int[] expected, out int[] actual);

				SNBestKnown.SortDescending(ref actual[0], length, InternalComparison);

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		[DataRow(GenerationMode.Sorted)]
		[DataRow(GenerationMode.Random)]
		[DataRow(GenerationMode.Reverse)]
		public unsafe void Ascending_ComparisonPointer(GenerationMode mode)
		{
			for (int length = SNBestKnown.MinLength; length <= SNBestKnown.MaxLength; length++)
			{
				GenerateArraysAscending(mode, length, out int[] expected, out int[] actual);

				SNBestKnown.SortAscending(ref actual[0], length, &InternalComparison);

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		[DataRow(GenerationMode.Sorted)]
		[DataRow(GenerationMode.Random)]
		[DataRow(GenerationMode.Reverse)]
		public unsafe void Descending_ComparisonPointer(GenerationMode mode)
		{
			for (int length = SNBestKnown.MinLength; length <= SNBestKnown.MaxLength; length++)
			{
				GenerateArraysDescending(mode, length, out int[] expected, out int[] actual);

				SNBestKnown.SortDescending(ref actual[0], length, &InternalComparison);

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		public void Ascending_Comparable_OutOfRange()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
			{
				GenerateArraysAscending(default, SNBestKnown.MinLength - 1, out int[] expected, out int[] actual);

				SNBestKnown.SortAscending(ref actual[0], actual.Length);
			});
		}

		[TestMethod]
		public void Descending_Comparable_OutOfRange()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
			{
				GenerateArraysDescending(default, SNBestKnown.MinLength - 1, out int[] expected, out int[] actual);

				SNBestKnown.SortDescending(ref actual[0], actual.Length);
			});
		}

		[TestMethod]
		public void Ascending_Comparison_OutOfRange()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
			{
				GenerateArraysAscending(default, SNBestKnown.MinLength - 1, out int[] expected, out int[] actual);

				SNBestKnown.SortAscending(ref actual[0], actual.Length, InternalComparison);
			});
		}

		[TestMethod]
		public void Descending_Comparison_OutOfRange()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
			{
				GenerateArraysDescending(default, SNBestKnown.MinLength - 1, out int[] expected, out int[] actual);

				SNBestKnown.SortDescending(ref actual[0], actual.Length, InternalComparison);
			});
		}

		[TestMethod]
		public unsafe void Ascending_ComparisonPointer_OutOfRange()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
			{
				GenerateArraysAscending(default, SNBestKnown.MinLength - 1, out int[] expected, out int[] actual);

				SNBestKnown.SortAscending(ref actual[0], actual.Length, &InternalComparison);
			});
		}

		[TestMethod]
		public unsafe void Descending_ComparisonPointer_OutOfRange()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
			{
				GenerateArraysDescending(default, SNBestKnown.MinLength - 1, out int[] expected, out int[] actual);

				SNBestKnown.SortDescending(ref actual[0], actual.Length, &InternalComparison);
			});
		}

		[TestMethod]
		public void Ascending_Comparison_Null()
		{
			Assert.ThrowsException<ArgumentNullException>(() =>
			{
				Span<int> actual = stackalloc int[1];

				SNBestKnown.SortAscending(ref actual[0], actual.Length, comparison: null);
			});
		}

		[TestMethod]
		public void Descending_Comparison_Null()
		{
			Assert.ThrowsException<ArgumentNullException>(() =>
			{
				Span<int> actual = stackalloc int[1];

				SNBestKnown.SortDescending(ref actual[0], actual.Length, comparison: null);
			});
		}
	}
}
