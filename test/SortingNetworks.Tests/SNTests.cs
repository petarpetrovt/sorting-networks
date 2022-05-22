namespace SortingNetworks.Tests;

using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class SNTests : SNTestsBase
{
	[TestMethod]
	public void SN_Array_Ascending_Comparable()
	{
		for (int length = SN.MinLength; length <= SN.MaxLength; length++)
		{
			GenerateArraysAscending(default, length, out int[] expected, out int[] actual);

			SN.SortAscending(actual);

			CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
		}
	}

	[TestMethod]
	public void SN_Array_Descending_Comparable()
	{
		for (int length = SN.MinLength; length <= SN.MaxLength; length++)
		{
			GenerateArraysDescending(default, length, out int[] expected, out int[] actual);

			SN.SortDescending(actual);

			CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
		}
	}

	[TestMethod]
	public void SN_Array_Ascending_Comparison()
	{
		for (int length = SN.MinLength; length <= SN.MaxLength; length++)
		{
			GenerateArraysAscending(default, length, out int[] expected, out int[] actual);

			SN.SortAscending(actual, InternalComparison);

			CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
		}
	}

	[TestMethod]
	public void SN_Array_Descending_Comparison()
	{
		for (int length = SN.MinLength; length <= SN.MaxLength; length++)
		{
			GenerateArraysDescending(default, length, out int[] expected, out int[] actual);

			SN.SortDescending(actual, InternalComparison);

			CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
		}
	}

	[TestMethod]
	public unsafe void SN_Array_Ascending_ComparisonPointer()
	{
		for (int length = SN.MinLength; length <= SN.MaxLength; length++)
		{
			GenerateArraysAscending(default, length, out int[] expected, out int[] actual);

			SN.SortAscending(actual, &InternalComparison);

			CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
		}
	}

	[TestMethod]
	public unsafe void SN_Array_Descending_ComparisonPointer()
	{
		for (int length = SN.MinLength; length <= SN.MaxLength; length++)
		{
			GenerateArraysDescending(default, length, out int[] expected, out int[] actual);

			SN.SortDescending(actual, &InternalComparison);

			CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
		}
	}

	[TestMethod]
	public void SN_Span_Ascending_Comparable()
	{
		for (int length = SN.MinLength; length <= SN.MaxLength; length++)
		{
			GenerateSpansAscending(default, length, out Span<int> expected, out Span<int> actual);

			SN.SortAscending(actual);

			AssertAreEqual(expected, actual, $"Collections differs for length `{length}`.");
		}
	}

	[TestMethod]
	public void SN_Span_Descending_Comparable()
	{
		for (int length = SN.MinLength; length <= SN.MaxLength; length++)
		{
			GenerateSpansDescending(default, length, out Span<int> expected, out Span<int> actual);

			SN.SortDescending(actual);

			AssertAreEqual(expected, actual, $"Collections differs for length `{length}`.");
		}
	}

	[TestMethod]
	public void SN_Span_Ascending_Comparison()
	{
		for (int length = SN.MinLength; length <= SN.MaxLength; length++)
		{
			GenerateSpansAscending(default, length, out Span<int> expected, out Span<int> actual);

			SN.SortAscending(actual, InternalComparison);

			AssertAreEqual(expected, actual, $"Collections differs for length `{length}`.");
		}
	}

	[TestMethod]
	public void SN_Span_Descending_Comparison()
	{
		for (int length = SN.MinLength; length <= SN.MaxLength; length++)
		{
			GenerateSpansDescending(default, length, out Span<int> expected, out Span<int> actual);

			SN.SortDescending(actual, InternalComparison);

			AssertAreEqual(expected, actual, $"Collections differs for length `{length}`.");
		}
	}

	[TestMethod]
	public unsafe void SN_Span_Ascending_ComparisonPointer()
	{
		for (int length = SN.MinLength; length <= SN.MaxLength; length++)
		{
			GenerateSpansAscending(default, length, out Span<int> expected, out Span<int> actual);

			SN.SortAscending(actual, &InternalComparison);

			AssertAreEqual(expected, actual, $"Collections differs for length `{length}`.");
		}
	}

	[TestMethod]
	public unsafe void SN_Span_Descending_ComparisonPointer()
	{
		for (int length = SN.MinLength; length <= SN.MaxLength; length++)
		{
			GenerateSpansDescending(default, length, out Span<int> expected, out Span<int> actual);

			SN.SortDescending(actual, &InternalComparison);

			AssertAreEqual(expected, actual, $"Collections differs for length `{length}`.");
		}
	}

	[TestMethod]
	[DataRow(0)]
	[DataRow(SN.MinLength - 1)]
	[DataRow(SN.MaxLength + 1)]
	public void SN_Array_Ascending_Comparable_OutOfRange(int length)
	{
		Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
		{
			GenerateArraysAscending(default, length, out int[] expected, out int[] actual);

			SN.SortAscending(actual);
		});
	}

	[TestMethod]
	[DataRow(0)]
	[DataRow(SN.MinLength - 1)]
	[DataRow(SN.MaxLength + 1)]
	public void SN_Array_Descending_Comparable_OutOfRange(int length)
	{
		Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
		{
			GenerateArraysDescending(default, length, out int[] expected, out int[] actual);

			SN.SortDescending(actual);
		});
	}

	[TestMethod]
	[DataRow(0)]
	[DataRow(SN.MinLength - 1)]
	[DataRow(SN.MaxLength + 1)]
	public void SN_Array_Ascending_Comparison_OutOfRange(int length)
	{
		Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
		{
			GenerateArraysAscending(default, length, out int[] expected, out int[] actual);

			SN.SortAscending(actual, InternalComparison);
		});
	}

	[TestMethod]
	[DataRow(0)]
	[DataRow(SN.MinLength - 1)]
	[DataRow(SN.MaxLength + 1)]
	public void SN_Array_Descending_Comparison_OutOfRange(int length)
	{
		Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
		{
			GenerateArraysDescending(default, length, out int[] expected, out int[] actual);

			SN.SortDescending(actual, InternalComparison);
		});
	}

	[TestMethod]
	[DataRow(0)]
	[DataRow(SN.MinLength - 1)]
	[DataRow(SN.MaxLength + 1)]
	public unsafe void SN_Array_Ascending_ComparisonPointer_OutOfRange(int length)
	{
		Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
		{
			GenerateArraysAscending(default, length, out int[] expected, out int[] actual);

			SN.SortAscending(actual, &InternalComparison);
		});
	}

	[TestMethod]
	[DataRow(0)]
	[DataRow(SN.MinLength - 1)]
	[DataRow(SN.MaxLength + 1)]
	public unsafe void SN_Array_Descending_ComparisonPointer_OutOfRange(int length)
	{
		Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
		{
			GenerateArraysDescending(default, length, out int[] expected, out int[] actual);

			SN.SortDescending(actual, &InternalComparison);
		});
	}

	[TestMethod]
	[DataRow(0)]
	[DataRow(SN.MinLength - 1)]
	[DataRow(SN.MaxLength + 1)]
	public void SN_Span_Ascending_Comparable_OutOfRange(int length)
	{
		Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
		{
			GenerateSpansAscending(default, length, out Span<int> expected, out Span<int> actual);

			SN.SortAscending(actual);
		});
	}

	[TestMethod]
	[DataRow(0)]
	[DataRow(SN.MinLength - 1)]
	[DataRow(SN.MaxLength + 1)]
	public void SN_Span_Descending_Comparable_OutOfRange(int length)
	{
		Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
		{
			GenerateSpansDescending(default, length, out Span<int> expected, out Span<int> actual);

			SN.SortDescending(actual);
		});
	}

	[TestMethod]
	[DataRow(0)]
	[DataRow(SN.MinLength - 1)]
	[DataRow(SN.MaxLength + 1)]
	public void SN_Span_Ascending_Comparison_OutOfRange(int length)
	{
		Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
		{
			GenerateSpansAscending(default, length, out Span<int> expected, out Span<int> actual);

			SN.SortAscending(actual, InternalComparison);
		});
	}

	[TestMethod]
	[DataRow(0)]
	[DataRow(SN.MinLength - 1)]
	[DataRow(SN.MaxLength + 1)]
	public void SN_Span_Descending_Comparison_OutOfRange(int length)
	{
		Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
		{
			GenerateSpansDescending(default, length, out Span<int> expected, out Span<int> actual);

			SN.SortDescending(actual, InternalComparison);
		});
	}

	[TestMethod]
	[DataRow(0)]
	[DataRow(SN.MinLength - 1)]
	[DataRow(SN.MaxLength + 1)]
	public unsafe void SN_Span_Ascending_ComparisonPointer_OutOfRange(int length)
	{
		Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
		{
			GenerateSpansAscending(default, length, out Span<int> expected, out Span<int> actual);

			SN.SortAscending(actual, &InternalComparison);
		});
	}

	[TestMethod]
	[DataRow(0)]
	[DataRow(SN.MinLength - 1)]
	[DataRow(SN.MaxLength + 1)]
	public unsafe void SN_Span_Descending_ComparisonPointer_OutOfRange(int length)
	{
		Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
		{
			GenerateSpansDescending(default, length, out Span<int> expected, out Span<int> actual);

			SN.SortDescending(actual, &InternalComparison);
		});
	}

	[TestMethod]
	public void SN_Array_Ascending_Comparable_ArrayNull()
	{
		Assert.ThrowsException<ArgumentNullException>(() =>
		{
			int[] actual = null;

			SN.SortAscending(actual);
		});
	}

	[TestMethod]
	public void SN_Array_Descending_Comparable_ArrayNull()
	{
		Assert.ThrowsException<ArgumentNullException>(() =>
		{
			int[] actual = null;

			SN.SortDescending(actual);
		});
	}

	[TestMethod]
	public void SN_Array_Ascending_Comparison_ArrayNull()
	{
		Assert.ThrowsException<ArgumentNullException>(() =>
		{
			int[] actual = null;

			SN.SortAscending(actual, InternalComparison);
		});
	}

	[TestMethod]
	public void SN_Array_Descending_Comparison_ArrayNull()
	{
		Assert.ThrowsException<ArgumentNullException>(() =>
		{
			int[] actual = null;

			SN.SortDescending(actual, InternalComparison);
		});
	}

	[TestMethod]
	public unsafe void SN_Array_Ascending_ComparisonPointer_ArrayNull()
	{
		Assert.ThrowsException<ArgumentNullException>(() =>
		{
			int[] actual = null;

			SN.SortAscending(actual, &InternalComparison);
		});
	}

	[TestMethod]
	public unsafe void SN_Array_Descending_ComparisonPointer_ArrayNull()
	{
		Assert.ThrowsException<ArgumentNullException>(() =>
		{
			int[] actual = null;

			SN.SortDescending(actual, &InternalComparison);
		});
	}

	[TestMethod]
	public void SN_Array_Ascending_Comparison_ComparisonNull()
	{
		Assert.ThrowsException<ArgumentNullException>(() =>
		{
			GenerateArraysAscending(default, SN.MinLength - 1, out int[] expected, out int[] actual);

			SN.SortAscending(actual, comparison: null);
		});
	}

	[TestMethod]
	public void SN_Array_Descending_Comparison_ComparisonNull()
	{
		Assert.ThrowsException<ArgumentNullException>(() =>
		{
			GenerateArraysDescending(default, SN.MinLength - 1, out int[] expected, out int[] actual);

			SN.SortDescending(actual, comparison: null);
		});
	}

	[TestMethod]
	public void SN_Span_Ascending_Comparison_ComparisonNull()
	{
		Assert.ThrowsException<ArgumentNullException>(() =>
		{
			GenerateSpansAscending(default, SN.MinLength - 1, out Span<int> expected, out Span<int> actual);

			SN.SortAscending(actual, comparison: null);
		});
	}

	[TestMethod]
	public void SN_Span_Descending_Comparison_ComparisonNull()
	{
		Assert.ThrowsException<ArgumentNullException>(() =>
		{
			GenerateSpansDescending(default, SN.MinLength - 1, out Span<int> expected, out Span<int> actual);

			SN.SortDescending(actual, comparison: null);
		});
	}
}
