namespace SortingNetworks
{
	using System.Diagnostics.CodeAnalysis;
	using System.Runtime.CompilerServices;

	partial class SNBase
	{
		/// <exclude/>
		[ExcludeFromCodeCoverage]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		protected internal static void SwapBranchlessLessThan(ref byte left, ref byte right)
		{
			int diff = left - right;
			int dsgn = diff >> 31;
			byte max = (byte)(left - (diff & dsgn));
			byte min = (byte)(right + (diff & dsgn));

			right = min;
			left = max;
		}

		/// <exclude/>
		[ExcludeFromCodeCoverage]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		protected internal static void SwapBranchlessGreaterThan(ref byte left, ref byte right)
		{
			int diff = left - right;
			int dsgn = diff >> 31;
			byte max = (byte)(left - (diff & dsgn));
			byte min = (byte)(right + (diff & dsgn));

			right = max;
			left = min;
		}

		/// <exclude/>
		[ExcludeFromCodeCoverage]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		protected internal static void SwapBranchlessLessThan(ref sbyte left, ref sbyte right)
		{
			int diff = left - right;
			int dsgn = diff >> 31;
			sbyte max = (sbyte)(left - (diff & dsgn));
			sbyte min = (sbyte)(right + (diff & dsgn));

			right = min;
			left = max;
		}

		/// <exclude/>
		[ExcludeFromCodeCoverage]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		protected internal static void SwapBranchlessGreaterThan(ref sbyte left, ref sbyte right)
		{
			int diff = left - right;
			int dsgn = diff >> 31;
			sbyte max = (sbyte)(left - (diff & dsgn));
			sbyte min = (sbyte)(right + (diff & dsgn));

			right = max;
			left = min;
		}

		/// <exclude/>
		[ExcludeFromCodeCoverage]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		protected internal static void SwapBranchlessLessThan(ref ushort left, ref ushort right)
		{
			int diff = left - right;
			int dsgn = diff >> 31;
			ushort max = (ushort)(left - (diff & dsgn));
			ushort min = (ushort)(right + (diff & dsgn));

			right = min;
			left = max;
		}

		/// <exclude/>
		[ExcludeFromCodeCoverage]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		protected internal static void SwapBranchlessGreaterThan(ref ushort left, ref ushort right)
		{
			int diff = left - right;
			int dsgn = diff >> 31;
			ushort max = (ushort)(left - (diff & dsgn));
			ushort min = (ushort)(right + (diff & dsgn));

			right = max;
			left = min;
		}

		/// <exclude/>
		[ExcludeFromCodeCoverage]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		protected internal static void SwapBranchlessLessThan(ref short left, ref short right)
		{
			int diff = left - right;
			int dsgn = diff >> 31;
			short max = (short)(left - (diff & dsgn));
			short min = (short)(right + (diff & dsgn));

			right = min;
			left = max;
		}

		/// <exclude/>
		[ExcludeFromCodeCoverage]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		protected internal static void SwapBranchlessGreaterThan(ref short left, ref short right)
		{
			int diff = left - right;
			int dsgn = diff >> 31;
			short max = (short)(left - (diff & dsgn));
			short min = (short)(right + (diff & dsgn));

			right = max;
			left = min;
		}

		/// <exclude/>
		[ExcludeFromCodeCoverage]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		protected internal static void SwapBranchlessLessThan(ref uint left, ref uint right)
		{
			long diff = (long)left - right;
			long dsgn = diff >> 63;
			uint max = (uint)(left - (diff & dsgn));
			uint min = (uint)(right + (diff & dsgn));

			right = min;
			left = max;
		}

		/// <exclude/>
		[ExcludeFromCodeCoverage]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		protected internal static void SwapBranchlessGreaterThan(ref uint left, ref uint right)
		{
			long diff = (long)left - right;
			long dsgn = diff >> 63;
			uint max = (uint)(left - (diff & dsgn));
			uint min = (uint)(right + (diff & dsgn));

			right = max;
			left = min;
		}

		/// <exclude/>
		[ExcludeFromCodeCoverage]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		protected internal static void SwapBranchlessLessThan(ref int left, ref int right)
		{
			long diff = (long)left - right;
			long dsgn = diff >> 63;
			int max = (int)(left - (diff & dsgn));
			int min = (int)(right + (diff & dsgn));

			right = min;
			left = max;
		}

		/// <exclude/>
		[ExcludeFromCodeCoverage]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		protected internal static void SwapBranchlessGreaterThan(ref int left, ref int right)
		{
			long diff = (long)left - right;
			long dsgn = diff >> 63;
			int max = (int)(left - (diff & dsgn));
			int min = (int)(right + (diff & dsgn));

			right = max;
			left = min;
		}
	}
}
