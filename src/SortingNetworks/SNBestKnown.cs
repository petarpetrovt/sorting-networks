namespace SortingNetworks
{
	using System.Diagnostics.CodeAnalysis;

	/// <summary>
	/// Sorting networks implementation using the best known arrangement of comparators.
	/// </summary>
	/// <remarks>
	/// Custom arrangement or comparators are used only for length between [9, 16] otherwise Bose-Nelson algorithm is used.
	/// SWAP macros generated from: https://pages.ripco.net/~jgamble/nw.html
	/// </remarks>
	public abstract partial class SNBestKnown : SNBoseNelson
	{
		/// <summary>
		/// The minimum supported length for sorting.
		/// </summary>
		public new const int MinLength = 2;

		/// <summary>
		/// The maximum supported length for sorting.
		/// </summary>
		public new const int MaxLength = 16;

		/// <summary>
		/// Disable inheritance outside of the assembly.
		/// </summary>
		[ExcludeFromCodeCoverage]
		internal SNBestKnown() { }
	}
}