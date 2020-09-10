namespace SortingNetworks.Tests
{
	using System.Linq;
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class SNTests
	{
		[TestMethod]
		public void SNBoseNelson_Ascending_IComparable()
		{
			for (int length = SNBoseNelson.MinLength; length <= SNBoseNelson.MaxLength; length++)
			{
				int[] expected = Enumerable.Range(0, length).ToArray();
				int[] actual = expected.Reverse().ToArray();

				SNBoseNelson.SortAscending(ref actual[0], length);

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		public void SNBoseNelson_Descending_IComparable()
		{
			for (int length = SNBoseNelson.MinLength; length <= SNBoseNelson.MaxLength; length++)
			{
				int[] actual = Enumerable.Range(0, length).ToArray();
				int[] expected = actual.Reverse().ToArray();

				SNBoseNelson.SortDescending(ref actual[0], length);

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		public void SNBestKnown_Ascending_IComparable()
		{
			for (int length = SNBestKnown.MinLength; length <= SNBestKnown.MaxLength; length++)
			{
				int[] expected = Enumerable.Range(0, length).ToArray();
				int[] actual = expected.Reverse().ToArray();

				SNBestKnown.SortAscending(ref actual[0], length);

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		public void SNBestKnown_Descending_IComparable()
		{
			for (int length = SNBestKnown.MinLength; length <= SNBestKnown.MaxLength; length++)
			{
				int[] actual = Enumerable.Range(0, length).ToArray();
				int[] expected = actual.Reverse().ToArray();

				SNBestKnown.SortDescending(ref actual[0], length);

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		public void SNBoseNelson_Ascending_Comparison()
		{
			for (int length = SNBoseNelson.MinLength; length <= SNBoseNelson.MaxLength; length++)
			{
				int[] expected = Enumerable.Range(0, length).ToArray();
				int[] actual = expected.Reverse().ToArray();

				SNBoseNelson.SortAscending(ref actual[0], length, (a, b) => a.CompareTo(b));

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		public void SNBoseNelson_Descending_Comparison()
		{
			for (int length = SNBoseNelson.MinLength; length <= SNBoseNelson.MaxLength; length++)
			{
				int[] actual = Enumerable.Range(0, length).ToArray();
				int[] expected = actual.Reverse().ToArray();

				SNBoseNelson.SortDescending(ref actual[0], length, (a, b) => a.CompareTo(b));

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		public void SNBestKnown_Ascending_Comparison()
		{
			for (int length = SNBestKnown.MinLength; length <= SNBestKnown.MaxLength; length++)
			{
				int[] expected = Enumerable.Range(0, length).ToArray();
				int[] actual = expected.Reverse().ToArray();

				SNBestKnown.SortAscending(ref actual[0], length, (a, b) => a.CompareTo(b));

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		public void SNBestKnown_Descending_Comparison()
		{
			for (int length = SNBestKnown.MinLength; length <= SNBestKnown.MaxLength; length++)
			{
				int[] actual = Enumerable.Range(0, length).ToArray();
				int[] expected = actual.Reverse().ToArray();

				SNBestKnown.SortDescending(ref actual[0], length, (a, b) => a.CompareTo(b));

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}
	}
}
