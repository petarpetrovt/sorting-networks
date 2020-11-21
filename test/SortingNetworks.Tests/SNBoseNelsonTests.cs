namespace SortingNetworks.Tests
{
	using System;
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class SNBoseNelsonTests : SNTestsBase
	{
		[TestMethod]
		[DataRow(GenerationMode.Sorted)]
		[DataRow(GenerationMode.Random)]
		[DataRow(GenerationMode.Reverse)]
		public void Ascending_Comparable(GenerationMode mode)
		{
			for (int length = SNBoseNelson.MinLength; length <= SNBoseNelson.MaxLength; length++)
			{
				GenerateArraysAscending(mode, length, out int[] expected, out int[] actual);

				SNBoseNelson.SortAscending(ref actual[0], length);

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		[DataRow(GenerationMode.Sorted)]
		[DataRow(GenerationMode.Random)]
		[DataRow(GenerationMode.Reverse)]
		public void Descending_Comparable(GenerationMode mode)
		{
			for (int length = SNBoseNelson.MinLength; length <= SNBoseNelson.MaxLength; length++)
			{
				GenerateArraysDescending(mode, length, out int[] expected, out int[] actual);

				SNBoseNelson.SortDescending(ref actual[0], length);

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		[DataRow(GenerationMode.Sorted)]
		[DataRow(GenerationMode.Random)]
		[DataRow(GenerationMode.Reverse)]
		public void Ascending_Comparison(GenerationMode mode)
		{
			for (int length = SNBoseNelson.MinLength; length <= SNBoseNelson.MaxLength; length++)
			{
				GenerateArraysAscending(mode, length, out int[] expected, out int[] actual);

				SNBoseNelson.SortAscending(ref actual[0], length, InternalComparison);

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		[DataRow(GenerationMode.Sorted)]
		[DataRow(GenerationMode.Random)]
		[DataRow(GenerationMode.Reverse)]
		public void Descending_Comparison(GenerationMode mode)
		{
			for (int length = SNBoseNelson.MinLength; length <= SNBoseNelson.MaxLength; length++)
			{
				GenerateArraysDescending(mode, length, out int[] expected, out int[] actual);

				SNBoseNelson.SortDescending(ref actual[0], length, InternalComparison);

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		[DataRow(GenerationMode.Sorted)]
		[DataRow(GenerationMode.Random)]
		[DataRow(GenerationMode.Reverse)]
		public unsafe void Ascending_ComparisonPointer(GenerationMode mode)
		{
			for (int length = SNBoseNelson.MinLength; length <= SNBoseNelson.MaxLength; length++)
			{
				GenerateArraysAscending(mode, length, out int[] expected, out int[] actual);

				SNBoseNelson.SortAscending(ref actual[0], length, &InternalComparison);

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		[DataRow(GenerationMode.Sorted)]
		[DataRow(GenerationMode.Random)]
		[DataRow(GenerationMode.Reverse)]
		public unsafe void Descending_ComparisonPointer(GenerationMode mode)
		{
			for (int length = SNBoseNelson.MinLength; length <= SNBoseNelson.MaxLength; length++)
			{
				GenerateArraysDescending(mode, length, out int[] expected, out int[] actual);

				SNBoseNelson.SortDescending(ref actual[0], length, &InternalComparison);

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		public void Ascending_Comparable_OutOfRange()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
			{
				GenerateArraysAscending(default, SNBoseNelson.MinLength - 1, out int[] expected, out int[] actual);

				SNBoseNelson.SortAscending(ref actual[0], actual.Length);
			});
		}

		[TestMethod]
		public void Descending_Comparable_OutOfRange()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
			{
				GenerateArraysDescending(default, SNBoseNelson.MinLength - 1, out int[] expected, out int[] actual);

				SNBoseNelson.SortDescending(ref actual[0], actual.Length);
			});
		}

		[TestMethod]
		public void Ascending_Comparison_OutOfRange()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
			{
				GenerateArraysAscending(default, SNBoseNelson.MinLength - 1, out int[] expected, out int[] actual);

				SNBoseNelson.SortAscending(ref actual[0], actual.Length, (a, b) => a.CompareTo(b));
			});
		}

		[TestMethod]
		public void Descending_Comparison_OutOfRange()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
			{
				GenerateArraysDescending(default, SNBoseNelson.MinLength - 1, out int[] expected, out int[] actual);

				SNBoseNelson.SortDescending(ref actual[0], actual.Length, (a, b) => a.CompareTo(b));
			});
		}

		[TestMethod]
		public unsafe void Ascending_ComparisonPointer_OutOfRange()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
			{
				GenerateArraysAscending(default, SNBoseNelson.MinLength - 1, out int[] expected, out int[] actual);

				SNBoseNelson.SortAscending(ref actual[0], actual.Length, &InternalComparison);
			});
		}

		[TestMethod]
		public unsafe void Descending_ComparisonPointer_OutOfRange()
		{
			Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
			{
				GenerateArraysDescending(default, SNBoseNelson.MinLength - 1, out int[] expected, out int[] actual);

				SNBoseNelson.SortDescending(ref actual[0], actual.Length, &InternalComparison);
			});
		}

		[TestMethod]
		public void Ascending_Comparison_Null()
		{
			Assert.ThrowsException<ArgumentNullException>(() =>
			{
				Span<int> actual = stackalloc int[1];

				SNBoseNelson.SortAscending(ref actual[0], actual.Length, comparison: null);
			});
		}

		[TestMethod]
		public void Descending_Comparison_Null()
		{
			Assert.ThrowsException<ArgumentNullException>(() =>
			{
				Span<int> actual = stackalloc int[1];

				SNBoseNelson.SortDescending(ref actual[0], actual.Length, comparison: null);
			});
		}
	}
}
