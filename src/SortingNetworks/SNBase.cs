namespace SortingNetworks;

/// <summary>
/// Represents a base for different sorting network implementations.
/// </summary>
[SkipLocalsInit]
public abstract partial class SNBase
{
	/// <summary>
	/// Disable inheritance outside of the assembly.
	/// </summary>
	/// <exclude/>
	[ExcludeFromCodeCoverage]
	internal SNBase() { }

	// Copied from https://github.com/dotnet/runtime/blob/6072e4d3a7a2a1493f514cdf4be75a3d56580e84/src/libraries/System.Private.CoreLib/src/System/Collections/Generic/ArraySortHelper.cs
	// - These methods exist for use in sorting, where the additional operations present in
	//   the CompareTo methods that would otherwise be used on these primitives add non-trivial overhead,
	//   in particular for floating point where the CompareTo methods need to factor in NaNs.
	// - The floating-point comparisons here assume no NaNs, which is valid only because the sorting routines
	//   themselves special-case NaN with a pre-pass that ensures none are present in the values being sorted
	//   by moving them all to the front first and then sorting the rest.
	// - The `? true : false` is to work-around poor codegen: https://github.com/dotnet/runtime/issues/37904#issuecomment-644180265.
	// - These are duplicated here rather than being on a helper type due to current limitations around generic inlining.
#pragma warning disable IDE0075 // Simplify conditional expression
	/// <exclude/>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	protected internal static bool LessThan<T>(ref T left, ref T right)
		where T : IComparable<T>
	{
		if (typeof(T) == typeof(byte)) return (byte)(object)left < (byte)(object)right ? true : false;
		if (typeof(T) == typeof(sbyte)) return (sbyte)(object)left < (sbyte)(object)right ? true : false;
		if (typeof(T) == typeof(ushort)) return (ushort)(object)left < (ushort)(object)right ? true : false;
		if (typeof(T) == typeof(short)) return (short)(object)left < (short)(object)right ? true : false;
		if (typeof(T) == typeof(uint)) return (uint)(object)left < (uint)(object)right ? true : false;
		if (typeof(T) == typeof(int)) return (int)(object)left < (int)(object)right ? true : false;
		if (typeof(T) == typeof(ulong)) return (ulong)(object)left < (ulong)(object)right ? true : false;
		if (typeof(T) == typeof(long)) return (long)(object)left < (long)(object)right ? true : false;
		if (typeof(T) == typeof(nuint)) return (nuint)(object)left < (nuint)(object)right ? true : false;
		if (typeof(T) == typeof(nint)) return (nint)(object)left < (nint)(object)right ? true : false;
		if (typeof(T) == typeof(float)) return (float)(object)left < (float)(object)right ? true : false;
		if (typeof(T) == typeof(double)) return (double)(object)left < (double)(object)right ? true : false;
		if (typeof(T) == typeof(Half)) return (Half)(object)left < (Half)(object)right ? true : false;

		return left.CompareTo(right) < 0 ? true : false;
	}

	/// <exclude/>
	[ExcludeFromCodeCoverage]
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	protected internal static bool GreaterThan<T>(ref T left, ref T right)
		where T : IComparable<T>
	{
		if (typeof(T) == typeof(byte)) return (byte)(object)left > (byte)(object)right ? true : false;
		if (typeof(T) == typeof(sbyte)) return (sbyte)(object)left > (sbyte)(object)right ? true : false;
		if (typeof(T) == typeof(ushort)) return (ushort)(object)left > (ushort)(object)right ? true : false;
		if (typeof(T) == typeof(short)) return (short)(object)left > (short)(object)right ? true : false;
		if (typeof(T) == typeof(uint)) return (uint)(object)left > (uint)(object)right ? true : false;
		if (typeof(T) == typeof(int)) return (int)(object)left > (int)(object)right ? true : false;
		if (typeof(T) == typeof(ulong)) return (ulong)(object)left > (ulong)(object)right ? true : false;
		if (typeof(T) == typeof(long)) return (long)(object)left > (long)(object)right ? true : false;
		if (typeof(T) == typeof(nuint)) return (nuint)(object)left > (nuint)(object)right ? true : false;
		if (typeof(T) == typeof(nint)) return (nint)(object)left > (nint)(object)right ? true : false;
		if (typeof(T) == typeof(float)) return (float)(object)left > (float)(object)right ? true : false;
		if (typeof(T) == typeof(double)) return (double)(object)left > (double)(object)right ? true : false;
		if (typeof(T) == typeof(Half)) return (Half)(object)left > (Half)(object)right ? true : false;

		return left.CompareTo(right) > 0 ? true : false;
	}
#pragma warning restore IDE0075 // Simplify conditional expression
}
