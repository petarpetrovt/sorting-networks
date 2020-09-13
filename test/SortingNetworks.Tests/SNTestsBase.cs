namespace SortingNetworks.Tests
{
	using System.Linq;

	public abstract class SNTestsBase
	{
		protected static void GenerateArraysAscending(int length, out int[] expected, out int[] actual)
		{
			expected = Enumerable.Range(0, length).ToArray();
			actual = expected.Reverse().ToArray();
		}

		protected static void GenerateArraysDescending(int length, out int[] expected, out int[] actual)
		{
			actual = Enumerable.Range(0, length).ToArray();
			expected = actual.Reverse().ToArray();
		}
	}
}
