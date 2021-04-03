#if !NET5_0_OR_GREATER
namespace SortingNetworks
{
	using System;
	using System.Runtime.CompilerServices;
	using System.Runtime.InteropServices;

#if NETSTANDARD1_3
	[System.Diagnostics.DebuggerNonUserCode]
#else
	[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
#endif
	internal static class ArrayHelper
	{
		/// <summary>
		/// Returns a reference to the first element within a given <typeparamref name="T"/> array, with no bounds checks.
		/// </summary>
		/// <typeparam name="T">The type of elements in the input <typeparamref name="T"/> array instance.</typeparam>
		/// <param name="array">The input <typeparamref name="T"/> array instance.</param>
		/// <returns>A reference to the first element within <paramref name="array"/>, or the location
		/// it would have used, if <paramref name="array"/> is empty.</returns>
		/// <remarks>
		/// This method doesn't do any bounds checks, therefore it is responsibility of the caller
		/// to perform checks in case the returned value is dereferenced.
		/// </remarks>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ref T GetReference<T>(T[] array)
			=> ref Unsafe.As<byte, T>(ref Unsafe.As<RawArrayData>(array).Data);

		// Description taken from CoreCLR: see https://source.dot.net/#System.Private.CoreLib/src/System/Runtime/CompilerServices/RuntimeHelpers.CoreCLR.cs,285.
		// CLR arrays are laid out in memory as follows (multidimensional array bounds are optional):
		// [ sync block || pMethodTable || num components || MD array bounds || array data .. ]
		//                 ^                                 ^                  ^ returned reference
		//                 |                                 \-- ref Unsafe.As<RawArrayData>(array).Data
		//                 \-- array
		// The base size of an array includes all the fields before the array data,
		// including the sync block and method table. The reference to RawData.Data
		// points at the number of components, skipping over these two pointer-sized fields.
		[StructLayout(LayoutKind.Sequential)]
		private sealed class RawArrayData
		{
#pragma warning disable CS0649 // Unassigned fields
			public IntPtr Length;
			public byte Data;
#pragma warning restore CS0649
		}
	}
}
#endif