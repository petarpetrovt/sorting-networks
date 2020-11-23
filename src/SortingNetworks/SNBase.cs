namespace SortingNetworks
{
	using System;
	using System.Runtime.CompilerServices;

	/// <summary>
	/// Represents a base for different sorting network implementations.
	/// </summary>
#if NET5_0
	[SkipLocalsInit]
#endif
	public abstract class SNBase
	{
		/// <summary>
		/// Disable inheritance outside of the assembly.
		/// </summary>
		/// <exclude/>
#if NETSTANDARD1_3
		[System.Diagnostics.DebuggerNonUserCode]
#else
		[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
#endif
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
		/// <summary>
		/// Gets a flag indicating whether <paramref name="left"/> is less than <paramref name="right"/>.
		/// </summary>
		/// <remarks>
		/// Compiles to a single comparison or method call.
		/// </remarks>
		/// <typeparam name="T">the parameter type</typeparam>
		/// <param name="left">the left parameter</param>
		/// <param name="right">the right parameter</param>
		/// <returns>true if <paramref name="left"/> is less than <paramref name="right"/>; otherwise false</returns>
		/// <exclude/>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
#if NETSTANDARD1_3
		[System.Diagnostics.DebuggerNonUserCode]
#else
		[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
#endif
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
#if NET5_0
			if (typeof(T) == typeof(Half)) return (Half)(object)left < (Half)(object)right ? true : false;
#endif

			return left.CompareTo(right) < 0 ? true : false;
		}

		/// <summary>
		/// Gets a flag indicating whether <paramref name="left"/> is greater than <paramref name="right"/>.
		/// </summary>
		/// <remarks>
		/// Compiles to a single comparison or method call.
		/// </remarks>
		/// <typeparam name="T">the parameter type</typeparam>
		/// <param name="left">the left parameter</param>
		/// <param name="right">the right parameter</param>
		/// <returns>true if <paramref name="left"/> is greater than <paramref name="right"/>; otherwise false</returns>
		/// <exclude/>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
#if NETSTANDARD1_3
		[System.Diagnostics.DebuggerNonUserCode]
#else
		[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
#endif
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
#if NET5_0
			if (typeof(T) == typeof(Half)) return (Half)(object)left > (Half)(object)right ? true : false;
#endif

			return left.CompareTo(right) > 0 ? true : false;
		}
#pragma warning restore IDE0075 // Simplify conditional expression

		/// <summary>
		/// Performs a branch-less swap if <paramref name="left"/> value is lesser than <paramref name="right"/> value.
		/// </summary>
		/// <param name="left">the left value</param>
		/// <param name="right">the right value</param>
		/// <exclude/>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
#if NETSTANDARD1_3
		[System.Diagnostics.DebuggerNonUserCode]
#else
		[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
#endif
		protected internal static void SwapBranchlessLessThan(ref int left, ref int right)
		{
			int diff = left - right;
			int dsgn = diff >> 31;
			int max = left - (diff & dsgn);
			int min = right + (diff & dsgn);

			right = min;
			left = max;
		}

		/// <summary>
		/// Performs a branch-less swap if <paramref name="left"/> value is greater than <paramref name="right"/> value.
		/// </summary>
		/// <param name="left">the left value</param>
		/// <param name="right">the right value</param>
		/// <exclude/>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
#if NETSTANDARD1_3
		[System.Diagnostics.DebuggerNonUserCode]
#else
		[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
#endif
		protected internal static void SwapBranchlessGreaterThan(ref int left, ref int right)
		{
			int diff = left - right;
			int dsgn = diff >> 31;
			int max = left - (diff & dsgn);
			int min = right + (diff & dsgn);

			right = max;
			left = min;
		}
	}
}
