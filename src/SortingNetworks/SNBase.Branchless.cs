namespace SortingNetworks
{
	using System.Runtime.CompilerServices;
#if NETSTANDARD1_3
	using EXCLUDE_FROM_CODE_COVERAGE = System.Diagnostics.DebuggerNonUserCodeAttribute;
#else
	using EXCLUDE_FROM_CODE_COVERAGE = System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute;
#endif

	partial class SNBase
	{
		/// <exclude/>
		[EXCLUDE_FROM_CODE_COVERAGE]
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
		[EXCLUDE_FROM_CODE_COVERAGE]
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
		[EXCLUDE_FROM_CODE_COVERAGE]
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
		[EXCLUDE_FROM_CODE_COVERAGE]
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
		[EXCLUDE_FROM_CODE_COVERAGE]
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
		[EXCLUDE_FROM_CODE_COVERAGE]
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
		[EXCLUDE_FROM_CODE_COVERAGE]
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
		[EXCLUDE_FROM_CODE_COVERAGE]
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
		[EXCLUDE_FROM_CODE_COVERAGE]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		protected internal static void SwapBranchlessLessThan(ref int left, ref int right)
		{
			int diff = left - right;
			int dsgn = diff >> 31;
			int max = left - (diff & dsgn);
			int min = right + (diff & dsgn);

			right = min;
			left = max;
		}

		/// <exclude/>
		[EXCLUDE_FROM_CODE_COVERAGE]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
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
