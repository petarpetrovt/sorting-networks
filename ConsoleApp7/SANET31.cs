#if NETCOREAPP3_1
using System;
using System.Runtime.CompilerServices;

namespace ConsoleApp7
{
	public abstract class SA2
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Sort2<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);

			SWAP(ref p0, ref p1);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		protected static void SWAP<T>(ref T p0, ref T p1)
			where T : IComparable<T>
		{
			if (p0.CompareTo(p1) < 0)
			{
				ref T temp = ref p0;
				p0 = p1;
				p1 = temp;
			}
		}
	}

	public abstract class SA3 : SA2
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Sort3<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);

			SWAP(ref p1, ref p2);
			SWAP(ref p0, ref p2);
			SWAP(ref p0, ref p1);
		}
	}

	public abstract class SA4 : SA3
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Sort4<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);

			SWAP(ref p0, ref p1);
			SWAP(ref p2, ref p3);
			SWAP(ref p0, ref p2);
			SWAP(ref p1, ref p3);
			SWAP(ref p1, ref p2);
		}
	}

	public abstract class SA5 : SA4
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void Sort5<T>(ref T p0)
			where T : IComparable<T>
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);

			SWAP(ref p0, ref p1);
			SWAP(ref p3, ref p4);
			SWAP(ref p2, ref p4);
			SWAP(ref p2, ref p3);
			SWAP(ref p0, ref p3);
			SWAP(ref p0, ref p2);
			SWAP(ref p1, ref p4);
			SWAP(ref p1, ref p3);
			SWAP(ref p1, ref p2);
		}
	}

	public abstract class SA6 : SA5
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

			SWAP(ref p1, ref p2);
			SWAP(ref p0, ref p2);
			SWAP(ref p0, ref p1);
			SWAP(ref p4, ref p5);
			SWAP(ref p3, ref p5);
			SWAP(ref p3, ref p4);
			SWAP(ref p0, ref p3);
			SWAP(ref p1, ref p4);
			SWAP(ref p2, ref p5);
			SWAP(ref p2, ref p4);
			SWAP(ref p1, ref p3);
			SWAP(ref p2, ref p3);
		}
	}

	public abstract class SA7 : SA6
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

			SWAP(ref p1, ref p2);
			SWAP(ref p0, ref p2);
			SWAP(ref p0, ref p1);
			SWAP(ref p3, ref p4);
			SWAP(ref p5, ref p6);
			SWAP(ref p3, ref p5);
			SWAP(ref p4, ref p6);
			SWAP(ref p4, ref p5);
			SWAP(ref p0, ref p4);
			SWAP(ref p0, ref p3);
			SWAP(ref p1, ref p5);
			SWAP(ref p2, ref p6);
			SWAP(ref p2, ref p5);
			SWAP(ref p1, ref p3);
			SWAP(ref p2, ref p4);
			SWAP(ref p2, ref p3);
		}
	}

	public abstract class SA8 : SA7
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

			SWAP(ref p0, ref p1);
			SWAP(ref p2, ref p3);
			SWAP(ref p0, ref p2);
			SWAP(ref p1, ref p3);
			SWAP(ref p1, ref p2);
			SWAP(ref p4, ref p5);
			SWAP(ref p6, ref p7);
			SWAP(ref p4, ref p6);
			SWAP(ref p5, ref p7);
			SWAP(ref p5, ref p6);
			SWAP(ref p0, ref p4);
			SWAP(ref p1, ref p5);
			SWAP(ref p1, ref p4);
			SWAP(ref p2, ref p6);
			SWAP(ref p3, ref p7);
			SWAP(ref p3, ref p6);
			SWAP(ref p2, ref p4);
			SWAP(ref p3, ref p5);
			SWAP(ref p3, ref p4);
		}
	}

	public abstract class SA : SA8
	{
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
#endif