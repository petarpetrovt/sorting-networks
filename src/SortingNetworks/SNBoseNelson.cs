namespace SortingNetworks
{
	using System.Diagnostics;

	/// <summary>
	/// Sorting networks implementation using Bose-Nelson algorithm.
	/// </summary>
	public abstract partial class SNBoseNelson : SNBase
	{
		/// <summary>
		/// The minimum supported length for sorting.
		/// </summary>
		public const int MinLength = 2;

		/// <summary>
		/// The maximum supported length for sorting.
		/// </summary>
		public const int MaxLength = 32;

		/// <summary>
		/// Disable inheritance outside of the assembly.
		/// </summary>
		[DebuggerNonUserCode]
		internal SNBoseNelson() { }
	}
}