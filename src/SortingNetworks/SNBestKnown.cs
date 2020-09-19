namespace SortingNetworks
{
	/// <summary>
	/// Sorting networks implementation using the best known arrangement of comparators.
	/// </summary>
	/// <remarks>
	/// SWAP macros generated from: https://pages.ripco.net/~jgamble/nw.html
	/// </remarks>
	public abstract partial class SNBestKnown : SNBase
	{
		/// <summary>
		/// The minimum supported length for sorting.
		/// </summary>
		public const int MinLength = 9;

		/// <summary>
		/// The maximum supported length for sorting.
		/// </summary>
		public const int MaxLength = 16;

		/// <summary>
		/// Disable inheritance outside of the assembly.
		/// </summary>
		internal SNBestKnown() { }
	}
}