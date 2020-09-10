namespace SortingNetworks.Tests
{
	using System.Linq;
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class SNTests
	{
		[TestMethod]
		public void SNBoseNelson_IComparable()
		{
			for (int length = SNBoseNelson.MinLength; length <= SNBoseNelson.MaxLength; length++)
			{
				int[] expected = Enumerable.Range(0, length).ToArray();
				int[] actual = expected.Reverse().ToArray();

				SNBoseNelson.Sort(ref actual[0], length);

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}

		[TestMethod]
		public void SNBestKnown_IComparable()
		{
			for (int length = SNBestKnown.MinLength; length <= SNBestKnown.MaxLength; length++)
			{
				int[] expected = Enumerable.Range(0, length).ToArray();
				int[] actual = expected.Reverse().ToArray();

				SNBestKnown.Sort(ref actual[0], length);

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}
	}
}
