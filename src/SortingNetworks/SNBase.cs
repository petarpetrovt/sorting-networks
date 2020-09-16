namespace SortingNetworks
{
	using System;
	using System.Diagnostics;
	using System.Runtime.CompilerServices;

	/// <summary>
	/// Represents a base for different sorting network implementations.
	/// </summary>
	public abstract class SNBase
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void SwapIfGreater<T>(ref T p0, ref T p1)
			where T : IComparable<T>
		{
			if (p0.CompareTo(p1) > 0)
			{
				T temp = p0;
				p0 = p1;
				p1 = temp;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void SwapIfLesser<T>(ref T p0, ref T p1)
			where T : IComparable<T>
		{
			if (p0.CompareTo(p1) < 0)
			{
				T temp = p0;
				p0 = p1;
				p1 = temp;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void SwapIfGreater<T>(ref T p0, ref T p1, Comparison<T> comparison)
		{
			Debug.Assert(comparison != null);

			if (comparison.Invoke(p0, p1) > 0)
			{
				T temp = p0;
				p0 = p1;
				p1 = temp;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void SwapIfLesser<T>(ref T p0, ref T p1, Comparison<T> comparison)
		{
			Debug.Assert(comparison != null);

			if (comparison.Invoke(p0, p1) < 0)
			{
				T temp = p0;
				p0 = p1;
				p1 = temp;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe static void SwapIfGreater<T>(ref T p0, ref T p1, delegate* managed<T, T, int> comparisonPointer)
		{
			if (comparisonPointer(p0, p1) > 0)
			{
				T temp = p0;
				p0 = p1;
				p1 = temp;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe static void SwapIfLesser<T>(ref T p0, ref T p1, delegate* managed<T, T, int> comparisonPointer)
		{
			if (comparisonPointer(p0, p1) < 0)
			{
				T temp = p0;
				p0 = p1;
				p1 = temp;
			}
		}
	}
}