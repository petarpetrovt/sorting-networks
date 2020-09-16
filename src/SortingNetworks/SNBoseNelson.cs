namespace SortingNetworks
{
	/// <summary>
	/// Sorting networks implementation using Bose-Nelson algorithm.
	/// </summary>
	/// <remarks>
	/// SWAP macros generated from: https://pages.ripco.net/~jgamble/nw.html
	/// </remarks>
	public sealed partial class SNBoseNelson : SNBase
	{
		/// <summary>
		/// The minimum supported length for sorting.
		/// </summary>
		public const int MinLength = 2;

		/// <summary>
		/// The maximum supported length for sorting.
		/// </summary>
		public const int MaxLength = 8;
	}
}