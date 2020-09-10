namespace SortingNetworks.Tests
{
	using System.Linq;
	using Microsoft.VisualStudio.TestTools.UnitTesting;

	[TestClass]
	public class SNTests
	{
		[TestMethod]
		public void Sort_IComparable()
		{
			for (int length = SN.MinLength; length <= SN.MaxLength; length++)
			{
				int[] expected = Enumerable.Range(0, length).ToArray();
				int[] actual = expected.Reverse().ToArray();

				SN.Sort(ref actual[0], length);

				CollectionAssert.AreEqual(expected, actual, $"Collections differs for length `{length}`.");
			}
		}
	}
}
