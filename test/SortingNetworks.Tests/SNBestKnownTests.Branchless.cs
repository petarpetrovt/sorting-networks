namespace SortingNetworks.Tests
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	partial class SNBestKnownTests
	{
		[TestMethod]
		[DynamicData(nameof(GetModeAndIterations), DynamicDataSourceType.Method)]
		public void Ascending_Branchless_Byte(GenerationMode mode, int iterations)
		{
			for (int length = SNBestKnown.MinLength; length <= SNBestKnown.MaxLength; length++)
			{
				for (int i = 0; i < iterations; i++)
				{
					GenerateArraysAscending(mode, length, out byte[] expected, out byte[] actual);

					SNBestKnown.SortAscendingBranchless(ref actual[0], length);

					CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
				}
			}
		}

		[TestMethod]
		[DynamicData(nameof(GetModeAndIterations), DynamicDataSourceType.Method)]
		public void Descending_Branchless_Byte(GenerationMode mode, int iterations)
		{
			for (int length = SNBestKnown.MinLength; length <= SNBestKnown.MaxLength; length++)
			{
				for (int i = 0; i < iterations; i++)
				{
					GenerateArraysDescending(mode, length, out byte[] expected, out byte[] actual);

					SNBestKnown.SortDescendingBranchless(ref actual[0], length);

					CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
				}
			}
		}

		[TestMethod]
		[DynamicData(nameof(GetModeAndIterations), DynamicDataSourceType.Method)]
		public void Ascending_Branchless_SByte(GenerationMode mode, int iterations)
		{
			for (int length = SNBestKnown.MinLength; length <= SNBestKnown.MaxLength; length++)
			{
				for (int i = 0; i < iterations; i++)
				{
					GenerateArraysAscending(mode, length, out sbyte[] expected, out sbyte[] actual);

					SNBestKnown.SortAscendingBranchless(ref actual[0], length);

					CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
				}
			}
		}

		[TestMethod]
		[DynamicData(nameof(GetModeAndIterations), DynamicDataSourceType.Method)]
		public void Descending_Branchless_SByte(GenerationMode mode, int iterations)
		{
			for (int length = SNBestKnown.MinLength; length <= SNBestKnown.MaxLength; length++)
			{
				for (int i = 0; i < iterations; i++)
				{
					GenerateArraysDescending(mode, length, out sbyte[] expected, out sbyte[] actual);

					SNBestKnown.SortDescendingBranchless(ref actual[0], length);

					CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
				}
			}
		}

		[TestMethod]
		[DynamicData(nameof(GetModeAndIterations), DynamicDataSourceType.Method)]
		public void Ascending_Branchless_UInt16(GenerationMode mode, int iterations)
		{
			for (int length = SNBestKnown.MinLength; length <= SNBestKnown.MaxLength; length++)
			{
				for (int i = 0; i < iterations; i++)
				{
					GenerateArraysAscending(mode, length, out ushort[] expected, out ushort[] actual);

					SNBestKnown.SortAscendingBranchless(ref actual[0], length);

					CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
				}
			}
		}

		[TestMethod]
		[DynamicData(nameof(GetModeAndIterations), DynamicDataSourceType.Method)]
		public void Descending_Branchless_UInt16(GenerationMode mode, int iterations)
		{
			for (int length = SNBestKnown.MinLength; length <= SNBestKnown.MaxLength; length++)
			{
				for (int i = 0; i < iterations; i++)
				{
					GenerateArraysDescending(mode, length, out ushort[] expected, out ushort[] actual);

					SNBestKnown.SortDescendingBranchless(ref actual[0], length);

					CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
				}
			}
		}

		[TestMethod]
		[DynamicData(nameof(GetModeAndIterations), DynamicDataSourceType.Method)]
		public void Ascending_Branchless_Int16(GenerationMode mode, int iterations)
		{
			for (int length = SNBestKnown.MinLength; length <= SNBestKnown.MaxLength; length++)
			{
				for (int i = 0; i < iterations; i++)
				{
					GenerateArraysAscending(mode, length, out short[] expected, out short[] actual);

					SNBestKnown.SortAscendingBranchless(ref actual[0], length);

					CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
				}
			}
		}

		[TestMethod]
		[DynamicData(nameof(GetModeAndIterations), DynamicDataSourceType.Method)]
		public void Descending_Branchless_Int16(GenerationMode mode, int iterations)
		{
			for (int length = SNBestKnown.MinLength; length <= SNBestKnown.MaxLength; length++)
			{
				for (int i = 0; i < iterations; i++)
				{
					GenerateArraysDescending(mode, length, out short[] expected, out short[] actual);

					SNBestKnown.SortDescendingBranchless(ref actual[0], length);

					CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
				}
			}
		}

		[TestMethod]
		[DynamicData(nameof(GetModeAndIterations), DynamicDataSourceType.Method)]
		public void Ascending_Branchless_Int32(GenerationMode mode, int iterations)
		{
			for (int length = SNBestKnown.MinLength; length <= SNBestKnown.MaxLength; length++)
			{
				for (int i = 0; i < iterations; i++)
				{
					GenerateArraysAscending(mode, length, out int[] expected, out int[] actual);

					SNBestKnown.SortAscendingBranchless(ref actual[0], length);

					CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
				}
			}
		}

		[TestMethod]
		[DynamicData(nameof(GetModeAndIterations), DynamicDataSourceType.Method)]
		public void Descending_Branchless_Int32(GenerationMode mode, int iterations)
		{
			for (int length = SNBestKnown.MinLength; length <= SNBestKnown.MaxLength; length++)
			{
				for (int i = 0; i < iterations; i++)
				{
					GenerateArraysDescending(mode, length, out int[] expected, out int[] actual);

					SNBestKnown.SortDescendingBranchless(ref actual[0], length);

					CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
				}
			}
		}

	}
}
