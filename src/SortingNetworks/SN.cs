namespace SortingNetworks
{
	using System;

	public abstract class SN
	{
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
	}
}