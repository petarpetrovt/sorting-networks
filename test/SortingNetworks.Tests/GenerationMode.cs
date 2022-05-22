namespace SortingNetworks.Tests;

/// <summary>
/// Represents an enumeration of array generation modes.
/// </summary>
public enum GenerationMode
{
	/// <summary>
	/// Sorted
	/// </summary>
	Sorted,

	/// <summary>
	/// Random
	/// </summary>
	Random,

	/// <summary>
	/// Reverse
	/// </summary>
	Reverse,

	/// <summary>
	/// Odd bigger than even
	/// </summary>
	OddBiggerThanEven,

	/// <summary>
	/// Even bigger than odd
	/// </summary>
	EvenBiggerThanOdd,

	/// <summary>
	/// Special values (NaN, Min, Max, etc)
	/// </summary>
	SpecialValues,
}
