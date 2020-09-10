namespace SortingNetworks
{
	using System;
	using System.Runtime.CompilerServices;

#if NET5_0
	[SkipLocalsInitAttribute]
#endif
	public abstract class SN2
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Sort2<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);

			SwapIfGreater(ref p0, ref p1);
		}

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
	}

	public abstract class SN3 : SN2
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Sort3<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);

			SwapIfGreater(ref p1, ref p2);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p0, ref p1);
		}
	}

	public abstract class SN4 : SN3
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Sort4<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);

			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p2, ref p3);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p1, ref p3);
			SwapIfGreater(ref p1, ref p2);
		}
	}

	public abstract class SN5 : SN4
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Sort5<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);

			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p3, ref p4);
			SwapIfGreater(ref p2, ref p4);
			SwapIfGreater(ref p2, ref p3);
			SwapIfGreater(ref p0, ref p3);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p1, ref p4);
			SwapIfGreater(ref p1, ref p3);
			SwapIfGreater(ref p1, ref p2);
		}
	}

	public abstract class SN6 : SN5
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Sort6<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);
			ref var p5 = ref Unsafe.Add(ref p0, 5);

			SwapIfGreater(ref p1, ref p2);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p4, ref p5);
			SwapIfGreater(ref p3, ref p5);
			SwapIfGreater(ref p3, ref p4);
			SwapIfGreater(ref p0, ref p3);
			SwapIfGreater(ref p1, ref p4);
			SwapIfGreater(ref p2, ref p5);
			SwapIfGreater(ref p2, ref p4);
			SwapIfGreater(ref p1, ref p3);
			SwapIfGreater(ref p2, ref p3);
		}
	}

	public abstract class SN7 : SN6
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Sort7<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);
			ref var p5 = ref Unsafe.Add(ref p0, 5);
			ref var p6 = ref Unsafe.Add(ref p0, 6);

			SwapIfGreater(ref p1, ref p2);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p3, ref p4);
			SwapIfGreater(ref p5, ref p6);
			SwapIfGreater(ref p3, ref p5);
			SwapIfGreater(ref p4, ref p6);
			SwapIfGreater(ref p4, ref p5);
			SwapIfGreater(ref p0, ref p4);
			SwapIfGreater(ref p0, ref p3);
			SwapIfGreater(ref p1, ref p5);
			SwapIfGreater(ref p2, ref p6);
			SwapIfGreater(ref p2, ref p5);
			SwapIfGreater(ref p1, ref p3);
			SwapIfGreater(ref p2, ref p4);
			SwapIfGreater(ref p2, ref p3);
		}
	}

	public abstract class SN8 : SN7
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Sort8<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);
			ref var p5 = ref Unsafe.Add(ref p0, 5);
			ref var p6 = ref Unsafe.Add(ref p0, 6);
			ref var p7 = ref Unsafe.Add(ref p0, 7);

			SwapIfGreater(ref p0, ref p1);
			SwapIfGreater(ref p2, ref p3);
			SwapIfGreater(ref p0, ref p2);
			SwapIfGreater(ref p1, ref p3);
			SwapIfGreater(ref p1, ref p2);
			SwapIfGreater(ref p4, ref p5);
			SwapIfGreater(ref p6, ref p7);
			SwapIfGreater(ref p4, ref p6);
			SwapIfGreater(ref p5, ref p7);
			SwapIfGreater(ref p5, ref p6);
			SwapIfGreater(ref p0, ref p4);
			SwapIfGreater(ref p1, ref p5);
			SwapIfGreater(ref p1, ref p4);
			SwapIfGreater(ref p2, ref p6);
			SwapIfGreater(ref p3, ref p7);
			SwapIfGreater(ref p3, ref p6);
			SwapIfGreater(ref p2, ref p4);
			SwapIfGreater(ref p3, ref p5);
			SwapIfGreater(ref p3, ref p4);
		}
	}

	public abstract class SN : SN8
	{
		public const int MinLength = 2;
		public const int MaxLength = 8;

		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Sort<T>(ref T p0, in int length)
			where T : IComparable<T>
		{
			switch (length)
			{
				case 2: Sort2(ref p0); break;
				case 3: Sort3(ref p0); break;
				case 4: Sort4(ref p0); break;
				case 5: Sort5(ref p0); break;
				case 6: Sort6(ref p0); break;
				case 7: Sort7(ref p0); break;
				case 8: Sort8(ref p0); break;
				default: throw new ArgumentException($"Sorting network length `{length}` is not supported in this context.");
			}
		}
	}
}