namespace SortingNetworks
{
	using System;
	using System.Runtime.CompilerServices;

	public abstract class SN
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		protected static void SwapIfGreater<T>(ref T p0, ref T p1)
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
		protected static void SwapIfLesser<T>(ref T p0, ref T p1)
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
		protected static void SwapIfGreater<T>(ref T p0, ref T p1, Comparison<T> comparison)
		{
			if (comparison.Invoke(p0, p1) > 0)
			{
				T temp = p0;
				p0 = p1;
				p1 = temp;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		protected static void SwapIfLesser<T>(ref T p0, ref T p1, Comparison<T> comparison)
		{
			if (comparison.Invoke(p0, p1) < 0)
			{
				T temp = p0;
				p0 = p1;
				p1 = temp;
			}
		}
	}
}