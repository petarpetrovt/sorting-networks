namespace SortingNetworks.Tests
{
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class SNBestKnownTests : SNTestsBase
	{
		[TestMethod]
		public void SNBestKnown_Ascending_IComparable()
		{
			for (int length = SNBestKnown.MinLength; length <= SNBestKnown.MaxLength; length++)
			{
				GenerateArraysAscending(length, out int[] expected, out int[] actual);

				SNBestKnown.SortAscending(ref actual[0], length);

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		public void SNBestKnown_Descending_IComparable()
		{
			for (int length = SNBestKnown.MinLength; length <= SNBestKnown.MaxLength; length++)
			{
				GenerateArraysDescending(length, out int[] expected, out int[] actual);

				SNBestKnown.SortDescending(ref actual[0], length);

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		public void SNBestKnown_Ascending_Comparison()
		{
			for (int length = SNBestKnown.MinLength; length <= SNBestKnown.MaxLength; length++)
			{
				GenerateArraysAscending(length, out int[] expected, out int[] actual);

				SNBestKnown.SortAscending(ref actual[0], length, (a, b) => a.CompareTo(b));

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		public void SNBestKnown_Descending_Comparison()
		{
			for (int length = SNBestKnown.MinLength; length <= SNBestKnown.MaxLength; length++)
			{
				GenerateArraysDescending(length, out int[] expected, out int[] actual);

				SNBestKnown.SortDescending(ref actual[0], length, (a, b) => a.CompareTo(b));

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}
	}
}
