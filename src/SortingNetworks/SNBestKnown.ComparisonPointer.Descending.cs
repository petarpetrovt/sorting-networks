﻿namespace SortingNetworks
{
	using System;
	using System.Runtime.CompilerServices;

	partial class SNBestKnown
	{
		public unsafe static void Sort9Descending<T>(ref T p0, delegate* managed<T, T, int> comparisonPointer)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);
			ref var p5 = ref Unsafe.Add(ref p0, 5);
			ref var p6 = ref Unsafe.Add(ref p0, 6);
			ref var p7 = ref Unsafe.Add(ref p0, 7);
			ref var p8 = ref Unsafe.Add(ref p0, 8);

			SwapIfLesser(ref p0, ref p1, comparisonPointer);
			SwapIfLesser(ref p3, ref p4, comparisonPointer);
			SwapIfLesser(ref p6, ref p7, comparisonPointer);
			SwapIfLesser(ref p1, ref p2, comparisonPointer);
			SwapIfLesser(ref p4, ref p5, comparisonPointer);
			SwapIfLesser(ref p7, ref p8, comparisonPointer);
			SwapIfLesser(ref p0, ref p1, comparisonPointer);
			SwapIfLesser(ref p3, ref p4, comparisonPointer);
			SwapIfLesser(ref p6, ref p7, comparisonPointer);
			SwapIfLesser(ref p0, ref p3, comparisonPointer);
			SwapIfLesser(ref p3, ref p6, comparisonPointer);
			SwapIfLesser(ref p0, ref p3, comparisonPointer);
			SwapIfLesser(ref p1, ref p4, comparisonPointer);
			SwapIfLesser(ref p4, ref p7, comparisonPointer);
			SwapIfLesser(ref p1, ref p4, comparisonPointer);
			SwapIfLesser(ref p2, ref p5, comparisonPointer);
			SwapIfLesser(ref p5, ref p8, comparisonPointer);
			SwapIfLesser(ref p2, ref p5, comparisonPointer);
			SwapIfLesser(ref p1, ref p3, comparisonPointer);
			SwapIfLesser(ref p5, ref p7, comparisonPointer);
			SwapIfLesser(ref p2, ref p6, comparisonPointer);
			SwapIfLesser(ref p4, ref p6, comparisonPointer);
			SwapIfLesser(ref p2, ref p4, comparisonPointer);
			SwapIfLesser(ref p2, ref p3, comparisonPointer);
			SwapIfLesser(ref p5, ref p6, comparisonPointer);
		}

		public unsafe static void Sort10Descending<T>(ref T p0, delegate* managed<T, T, int> comparisonPointer)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);
			ref var p5 = ref Unsafe.Add(ref p0, 5);
			ref var p6 = ref Unsafe.Add(ref p0, 6);
			ref var p7 = ref Unsafe.Add(ref p0, 7);
			ref var p8 = ref Unsafe.Add(ref p0, 8);
			ref var p9 = ref Unsafe.Add(ref p0, 9);

			SwapIfLesser(ref p4, ref p9, comparisonPointer);
			SwapIfLesser(ref p3, ref p8, comparisonPointer);
			SwapIfLesser(ref p2, ref p7, comparisonPointer);
			SwapIfLesser(ref p1, ref p6, comparisonPointer);
			SwapIfLesser(ref p0, ref p5, comparisonPointer);
			SwapIfLesser(ref p1, ref p4, comparisonPointer);
			SwapIfLesser(ref p6, ref p9, comparisonPointer);
			SwapIfLesser(ref p0, ref p3, comparisonPointer);
			SwapIfLesser(ref p5, ref p8, comparisonPointer);
			SwapIfLesser(ref p0, ref p2, comparisonPointer);
			SwapIfLesser(ref p3, ref p6, comparisonPointer);
			SwapIfLesser(ref p7, ref p9, comparisonPointer);
			SwapIfLesser(ref p0, ref p1, comparisonPointer);
			SwapIfLesser(ref p2, ref p4, comparisonPointer);
			SwapIfLesser(ref p5, ref p7, comparisonPointer);
			SwapIfLesser(ref p8, ref p9, comparisonPointer);
			SwapIfLesser(ref p1, ref p2, comparisonPointer);
			SwapIfLesser(ref p4, ref p6, comparisonPointer);
			SwapIfLesser(ref p7, ref p8, comparisonPointer);
			SwapIfLesser(ref p3, ref p5, comparisonPointer);
			SwapIfLesser(ref p2, ref p5, comparisonPointer);
			SwapIfLesser(ref p6, ref p8, comparisonPointer);
			SwapIfLesser(ref p1, ref p3, comparisonPointer);
			SwapIfLesser(ref p4, ref p7, comparisonPointer);
			SwapIfLesser(ref p2, ref p3, comparisonPointer);
			SwapIfLesser(ref p6, ref p7, comparisonPointer);
			SwapIfLesser(ref p3, ref p4, comparisonPointer);
			SwapIfLesser(ref p5, ref p6, comparisonPointer);
			SwapIfLesser(ref p4, ref p5, comparisonPointer);
		}

		public unsafe static void Sort11Descending<T>(ref T p0, delegate* managed<T, T, int> comparisonPointer)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);
			ref var p5 = ref Unsafe.Add(ref p0, 5);
			ref var p6 = ref Unsafe.Add(ref p0, 6);
			ref var p7 = ref Unsafe.Add(ref p0, 7);
			ref var p8 = ref Unsafe.Add(ref p0, 8);
			ref var p9 = ref Unsafe.Add(ref p0, 9);
			ref var p10 = ref Unsafe.Add(ref p0, 10);

			SwapIfLesser(ref p0, ref p1, comparisonPointer);
			SwapIfLesser(ref p2, ref p3, comparisonPointer);
			SwapIfLesser(ref p4, ref p5, comparisonPointer);
			SwapIfLesser(ref p6, ref p7, comparisonPointer);
			SwapIfLesser(ref p8, ref p9, comparisonPointer);
			SwapIfLesser(ref p1, ref p3, comparisonPointer);
			SwapIfLesser(ref p5, ref p7, comparisonPointer);
			SwapIfLesser(ref p0, ref p2, comparisonPointer);
			SwapIfLesser(ref p4, ref p6, comparisonPointer);
			SwapIfLesser(ref p8, ref p10, comparisonPointer);
			SwapIfLesser(ref p1, ref p2, comparisonPointer);
			SwapIfLesser(ref p5, ref p6, comparisonPointer);
			SwapIfLesser(ref p9, ref p10, comparisonPointer);
			SwapIfLesser(ref p1, ref p5, comparisonPointer);
			SwapIfLesser(ref p6, ref p10, comparisonPointer);
			SwapIfLesser(ref p5, ref p9, comparisonPointer);
			SwapIfLesser(ref p2, ref p6, comparisonPointer);
			SwapIfLesser(ref p1, ref p5, comparisonPointer);
			SwapIfLesser(ref p6, ref p10, comparisonPointer);
			SwapIfLesser(ref p0, ref p4, comparisonPointer);
			SwapIfLesser(ref p3, ref p7, comparisonPointer);
			SwapIfLesser(ref p4, ref p8, comparisonPointer);
			SwapIfLesser(ref p0, ref p4, comparisonPointer);
			SwapIfLesser(ref p1, ref p4, comparisonPointer);
			SwapIfLesser(ref p7, ref p10, comparisonPointer);
			SwapIfLesser(ref p3, ref p8, comparisonPointer);
			SwapIfLesser(ref p2, ref p3, comparisonPointer);
			SwapIfLesser(ref p8, ref p9, comparisonPointer);
			SwapIfLesser(ref p2, ref p4, comparisonPointer);
			SwapIfLesser(ref p7, ref p9, comparisonPointer);
			SwapIfLesser(ref p3, ref p5, comparisonPointer);
			SwapIfLesser(ref p6, ref p8, comparisonPointer);
			SwapIfLesser(ref p3, ref p4, comparisonPointer);
			SwapIfLesser(ref p5, ref p6, comparisonPointer);
			SwapIfLesser(ref p7, ref p8, comparisonPointer);
		}

		public unsafe static void Sort12Descending<T>(ref T p0, delegate* managed<T, T, int> comparisonPointer)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);
			ref var p5 = ref Unsafe.Add(ref p0, 5);
			ref var p6 = ref Unsafe.Add(ref p0, 6);
			ref var p7 = ref Unsafe.Add(ref p0, 7);
			ref var p8 = ref Unsafe.Add(ref p0, 8);
			ref var p9 = ref Unsafe.Add(ref p0, 9);
			ref var p10 = ref Unsafe.Add(ref p0, 10);
			ref var p11 = ref Unsafe.Add(ref p0, 11);

			SwapIfLesser(ref p0, ref p1, comparisonPointer);
			SwapIfLesser(ref p2, ref p3, comparisonPointer);
			SwapIfLesser(ref p4, ref p5, comparisonPointer);
			SwapIfLesser(ref p6, ref p7, comparisonPointer);
			SwapIfLesser(ref p8, ref p9, comparisonPointer);
			SwapIfLesser(ref p10, ref p11, comparisonPointer);
			SwapIfLesser(ref p1, ref p3, comparisonPointer);
			SwapIfLesser(ref p5, ref p7, comparisonPointer);
			SwapIfLesser(ref p9, ref p11, comparisonPointer);
			SwapIfLesser(ref p0, ref p2, comparisonPointer);
			SwapIfLesser(ref p4, ref p6, comparisonPointer);
			SwapIfLesser(ref p8, ref p10, comparisonPointer);
			SwapIfLesser(ref p1, ref p2, comparisonPointer);
			SwapIfLesser(ref p5, ref p6, comparisonPointer);
			SwapIfLesser(ref p9, ref p10, comparisonPointer);
			SwapIfLesser(ref p1, ref p5, comparisonPointer);
			SwapIfLesser(ref p6, ref p10, comparisonPointer);
			SwapIfLesser(ref p5, ref p9, comparisonPointer);
			SwapIfLesser(ref p2, ref p6, comparisonPointer);
			SwapIfLesser(ref p1, ref p5, comparisonPointer);
			SwapIfLesser(ref p6, ref p10, comparisonPointer);
			SwapIfLesser(ref p0, ref p4, comparisonPointer);
			SwapIfLesser(ref p7, ref p11, comparisonPointer);
			SwapIfLesser(ref p3, ref p7, comparisonPointer);
			SwapIfLesser(ref p4, ref p8, comparisonPointer);
			SwapIfLesser(ref p0, ref p4, comparisonPointer);
			SwapIfLesser(ref p7, ref p11, comparisonPointer);
			SwapIfLesser(ref p1, ref p4, comparisonPointer);
			SwapIfLesser(ref p7, ref p10, comparisonPointer);
			SwapIfLesser(ref p3, ref p8, comparisonPointer);
			SwapIfLesser(ref p2, ref p3, comparisonPointer);
			SwapIfLesser(ref p8, ref p9, comparisonPointer);
			SwapIfLesser(ref p2, ref p4, comparisonPointer);
			SwapIfLesser(ref p7, ref p9, comparisonPointer);
			SwapIfLesser(ref p3, ref p5, comparisonPointer);
			SwapIfLesser(ref p6, ref p8, comparisonPointer);
			SwapIfLesser(ref p3, ref p4, comparisonPointer);
			SwapIfLesser(ref p5, ref p6, comparisonPointer);
			SwapIfLesser(ref p7, ref p8, comparisonPointer);
		}

		public unsafe static void Sort13Descending<T>(ref T p0, delegate* managed<T, T, int> comparisonPointer)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);
			ref var p5 = ref Unsafe.Add(ref p0, 5);
			ref var p6 = ref Unsafe.Add(ref p0, 6);
			ref var p7 = ref Unsafe.Add(ref p0, 7);
			ref var p8 = ref Unsafe.Add(ref p0, 8);
			ref var p9 = ref Unsafe.Add(ref p0, 9);
			ref var p10 = ref Unsafe.Add(ref p0, 10);
			ref var p11 = ref Unsafe.Add(ref p0, 11);
			ref var p12 = ref Unsafe.Add(ref p0, 12);

			SwapIfLesser(ref p1, ref p7, comparisonPointer);
			SwapIfLesser(ref p9, ref p11, comparisonPointer);
			SwapIfLesser(ref p3, ref p4, comparisonPointer);
			SwapIfLesser(ref p5, ref p8, comparisonPointer);
			SwapIfLesser(ref p0, ref p12, comparisonPointer);
			SwapIfLesser(ref p2, ref p6, comparisonPointer);
			SwapIfLesser(ref p0, ref p1, comparisonPointer);
			SwapIfLesser(ref p2, ref p3, comparisonPointer);
			SwapIfLesser(ref p4, ref p6, comparisonPointer);
			SwapIfLesser(ref p8, ref p11, comparisonPointer);
			SwapIfLesser(ref p7, ref p12, comparisonPointer);
			SwapIfLesser(ref p5, ref p9, comparisonPointer);
			SwapIfLesser(ref p0, ref p2, comparisonPointer);
			SwapIfLesser(ref p3, ref p7, comparisonPointer);
			SwapIfLesser(ref p10, ref p11, comparisonPointer);
			SwapIfLesser(ref p1, ref p4, comparisonPointer);
			SwapIfLesser(ref p6, ref p12, comparisonPointer);
			SwapIfLesser(ref p7, ref p8, comparisonPointer);
			SwapIfLesser(ref p11, ref p12, comparisonPointer);
			SwapIfLesser(ref p4, ref p9, comparisonPointer);
			SwapIfLesser(ref p6, ref p10, comparisonPointer);
			SwapIfLesser(ref p3, ref p4, comparisonPointer);
			SwapIfLesser(ref p5, ref p6, comparisonPointer);
			SwapIfLesser(ref p8, ref p9, comparisonPointer);
			SwapIfLesser(ref p10, ref p11, comparisonPointer);
			SwapIfLesser(ref p1, ref p7, comparisonPointer);
			SwapIfLesser(ref p2, ref p6, comparisonPointer);
			SwapIfLesser(ref p9, ref p11, comparisonPointer);
			SwapIfLesser(ref p1, ref p3, comparisonPointer);
			SwapIfLesser(ref p4, ref p7, comparisonPointer);
			SwapIfLesser(ref p8, ref p10, comparisonPointer);
			SwapIfLesser(ref p0, ref p5, comparisonPointer);
			SwapIfLesser(ref p2, ref p5, comparisonPointer);
			SwapIfLesser(ref p6, ref p8, comparisonPointer);
			SwapIfLesser(ref p9, ref p10, comparisonPointer);
			SwapIfLesser(ref p1, ref p2, comparisonPointer);
			SwapIfLesser(ref p3, ref p5, comparisonPointer);
			SwapIfLesser(ref p7, ref p8, comparisonPointer);
			SwapIfLesser(ref p4, ref p6, comparisonPointer);
			SwapIfLesser(ref p2, ref p3, comparisonPointer);
			SwapIfLesser(ref p4, ref p5, comparisonPointer);
			SwapIfLesser(ref p6, ref p7, comparisonPointer);
			SwapIfLesser(ref p8, ref p9, comparisonPointer);
			SwapIfLesser(ref p3, ref p4, comparisonPointer);
			SwapIfLesser(ref p5, ref p6, comparisonPointer);
		}

		public unsafe static void Sort14Descending<T>(ref T p0, delegate* managed<T, T, int> comparisonPointer)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);
			ref var p5 = ref Unsafe.Add(ref p0, 5);
			ref var p6 = ref Unsafe.Add(ref p0, 6);
			ref var p7 = ref Unsafe.Add(ref p0, 7);
			ref var p8 = ref Unsafe.Add(ref p0, 8);
			ref var p9 = ref Unsafe.Add(ref p0, 9);
			ref var p10 = ref Unsafe.Add(ref p0, 10);
			ref var p11 = ref Unsafe.Add(ref p0, 11);
			ref var p12 = ref Unsafe.Add(ref p0, 12);
			ref var p13 = ref Unsafe.Add(ref p0, 13);

			SwapIfLesser(ref p0, ref p1, comparisonPointer);
			SwapIfLesser(ref p2, ref p3, comparisonPointer);
			SwapIfLesser(ref p4, ref p5, comparisonPointer);
			SwapIfLesser(ref p6, ref p7, comparisonPointer);
			SwapIfLesser(ref p8, ref p9, comparisonPointer);
			SwapIfLesser(ref p10, ref p11, comparisonPointer);
			SwapIfLesser(ref p12, ref p13, comparisonPointer);
			SwapIfLesser(ref p0, ref p2, comparisonPointer);
			SwapIfLesser(ref p4, ref p6, comparisonPointer);
			SwapIfLesser(ref p8, ref p10, comparisonPointer);
			SwapIfLesser(ref p1, ref p3, comparisonPointer);
			SwapIfLesser(ref p5, ref p7, comparisonPointer);
			SwapIfLesser(ref p9, ref p11, comparisonPointer);
			SwapIfLesser(ref p0, ref p4, comparisonPointer);
			SwapIfLesser(ref p8, ref p12, comparisonPointer);
			SwapIfLesser(ref p1, ref p5, comparisonPointer);
			SwapIfLesser(ref p9, ref p13, comparisonPointer);
			SwapIfLesser(ref p2, ref p6, comparisonPointer);
			SwapIfLesser(ref p3, ref p7, comparisonPointer);
			SwapIfLesser(ref p0, ref p8, comparisonPointer);
			SwapIfLesser(ref p1, ref p9, comparisonPointer);
			SwapIfLesser(ref p2, ref p10, comparisonPointer);
			SwapIfLesser(ref p3, ref p11, comparisonPointer);
			SwapIfLesser(ref p4, ref p12, comparisonPointer);
			SwapIfLesser(ref p5, ref p13, comparisonPointer);
			SwapIfLesser(ref p5, ref p10, comparisonPointer);
			SwapIfLesser(ref p6, ref p9, comparisonPointer);
			SwapIfLesser(ref p3, ref p12, comparisonPointer);
			SwapIfLesser(ref p7, ref p11, comparisonPointer);
			SwapIfLesser(ref p1, ref p2, comparisonPointer);
			SwapIfLesser(ref p4, ref p8, comparisonPointer);
			SwapIfLesser(ref p1, ref p4, comparisonPointer);
			SwapIfLesser(ref p7, ref p13, comparisonPointer);
			SwapIfLesser(ref p2, ref p8, comparisonPointer);
			SwapIfLesser(ref p2, ref p4, comparisonPointer);
			SwapIfLesser(ref p5, ref p6, comparisonPointer);
			SwapIfLesser(ref p9, ref p10, comparisonPointer);
			SwapIfLesser(ref p11, ref p13, comparisonPointer);
			SwapIfLesser(ref p3, ref p8, comparisonPointer);
			SwapIfLesser(ref p7, ref p12, comparisonPointer);
			SwapIfLesser(ref p6, ref p8, comparisonPointer);
			SwapIfLesser(ref p10, ref p12, comparisonPointer);
			SwapIfLesser(ref p3, ref p5, comparisonPointer);
			SwapIfLesser(ref p7, ref p9, comparisonPointer);
			SwapIfLesser(ref p3, ref p4, comparisonPointer);
			SwapIfLesser(ref p5, ref p6, comparisonPointer);
			SwapIfLesser(ref p7, ref p8, comparisonPointer);
			SwapIfLesser(ref p9, ref p10, comparisonPointer);
			SwapIfLesser(ref p11, ref p12, comparisonPointer);
			SwapIfLesser(ref p6, ref p7, comparisonPointer);
			SwapIfLesser(ref p8, ref p9, comparisonPointer);
		}

		public unsafe static void Sort15Descending<T>(ref T p0, delegate* managed<T, T, int> comparisonPointer)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);
			ref var p5 = ref Unsafe.Add(ref p0, 5);
			ref var p6 = ref Unsafe.Add(ref p0, 6);
			ref var p7 = ref Unsafe.Add(ref p0, 7);
			ref var p8 = ref Unsafe.Add(ref p0, 8);
			ref var p9 = ref Unsafe.Add(ref p0, 9);
			ref var p10 = ref Unsafe.Add(ref p0, 10);
			ref var p11 = ref Unsafe.Add(ref p0, 11);
			ref var p12 = ref Unsafe.Add(ref p0, 12);
			ref var p13 = ref Unsafe.Add(ref p0, 13);
			ref var p14 = ref Unsafe.Add(ref p0, 14);

			SwapIfLesser(ref p0, ref p1, comparisonPointer);
			SwapIfLesser(ref p2, ref p3, comparisonPointer);
			SwapIfLesser(ref p4, ref p5, comparisonPointer);
			SwapIfLesser(ref p6, ref p7, comparisonPointer);
			SwapIfLesser(ref p8, ref p9, comparisonPointer);
			SwapIfLesser(ref p10, ref p11, comparisonPointer);
			SwapIfLesser(ref p12, ref p13, comparisonPointer);
			SwapIfLesser(ref p0, ref p2, comparisonPointer);
			SwapIfLesser(ref p4, ref p6, comparisonPointer);
			SwapIfLesser(ref p8, ref p10, comparisonPointer);
			SwapIfLesser(ref p12, ref p14, comparisonPointer);
			SwapIfLesser(ref p1, ref p3, comparisonPointer);
			SwapIfLesser(ref p5, ref p7, comparisonPointer);
			SwapIfLesser(ref p9, ref p11, comparisonPointer);
			SwapIfLesser(ref p0, ref p4, comparisonPointer);
			SwapIfLesser(ref p8, ref p12, comparisonPointer);
			SwapIfLesser(ref p1, ref p5, comparisonPointer);
			SwapIfLesser(ref p9, ref p13, comparisonPointer);
			SwapIfLesser(ref p2, ref p6, comparisonPointer);
			SwapIfLesser(ref p10, ref p14, comparisonPointer);
			SwapIfLesser(ref p3, ref p7, comparisonPointer);
			SwapIfLesser(ref p0, ref p8, comparisonPointer);
			SwapIfLesser(ref p1, ref p9, comparisonPointer);
			SwapIfLesser(ref p2, ref p10, comparisonPointer);
			SwapIfLesser(ref p3, ref p11, comparisonPointer);
			SwapIfLesser(ref p4, ref p12, comparisonPointer);
			SwapIfLesser(ref p5, ref p13, comparisonPointer);
			SwapIfLesser(ref p6, ref p14, comparisonPointer);
			SwapIfLesser(ref p5, ref p10, comparisonPointer);
			SwapIfLesser(ref p6, ref p9, comparisonPointer);
			SwapIfLesser(ref p3, ref p12, comparisonPointer);
			SwapIfLesser(ref p13, ref p14, comparisonPointer);
			SwapIfLesser(ref p7, ref p11, comparisonPointer);
			SwapIfLesser(ref p1, ref p2, comparisonPointer);
			SwapIfLesser(ref p4, ref p8, comparisonPointer);
			SwapIfLesser(ref p1, ref p4, comparisonPointer);
			SwapIfLesser(ref p7, ref p13, comparisonPointer);
			SwapIfLesser(ref p2, ref p8, comparisonPointer);
			SwapIfLesser(ref p11, ref p14, comparisonPointer);
			SwapIfLesser(ref p2, ref p4, comparisonPointer);
			SwapIfLesser(ref p5, ref p6, comparisonPointer);
			SwapIfLesser(ref p9, ref p10, comparisonPointer);
			SwapIfLesser(ref p11, ref p13, comparisonPointer);
			SwapIfLesser(ref p3, ref p8, comparisonPointer);
			SwapIfLesser(ref p7, ref p12, comparisonPointer);
			SwapIfLesser(ref p6, ref p8, comparisonPointer);
			SwapIfLesser(ref p10, ref p12, comparisonPointer);
			SwapIfLesser(ref p3, ref p5, comparisonPointer);
			SwapIfLesser(ref p7, ref p9, comparisonPointer);
			SwapIfLesser(ref p3, ref p4, comparisonPointer);
			SwapIfLesser(ref p5, ref p6, comparisonPointer);
			SwapIfLesser(ref p7, ref p8, comparisonPointer);
			SwapIfLesser(ref p9, ref p10, comparisonPointer);
			SwapIfLesser(ref p11, ref p12, comparisonPointer);
			SwapIfLesser(ref p6, ref p7, comparisonPointer);
			SwapIfLesser(ref p8, ref p9, comparisonPointer);
		}

		public unsafe static void Sort16Descending<T>(ref T p0, delegate* managed<T, T, int> comparisonPointer)
		{
			ref var p1 = ref Unsafe.Add(ref p0, 1);
			ref var p2 = ref Unsafe.Add(ref p0, 2);
			ref var p3 = ref Unsafe.Add(ref p0, 3);
			ref var p4 = ref Unsafe.Add(ref p0, 4);
			ref var p5 = ref Unsafe.Add(ref p0, 5);
			ref var p6 = ref Unsafe.Add(ref p0, 6);
			ref var p7 = ref Unsafe.Add(ref p0, 7);
			ref var p8 = ref Unsafe.Add(ref p0, 8);
			ref var p9 = ref Unsafe.Add(ref p0, 9);
			ref var p10 = ref Unsafe.Add(ref p0, 10);
			ref var p11 = ref Unsafe.Add(ref p0, 11);
			ref var p12 = ref Unsafe.Add(ref p0, 12);
			ref var p13 = ref Unsafe.Add(ref p0, 13);
			ref var p14 = ref Unsafe.Add(ref p0, 14);
			ref var p15 = ref Unsafe.Add(ref p0, 15);

			SwapIfLesser(ref p0, ref p1, comparisonPointer);
			SwapIfLesser(ref p2, ref p3, comparisonPointer);
			SwapIfLesser(ref p4, ref p5, comparisonPointer);
			SwapIfLesser(ref p6, ref p7, comparisonPointer);
			SwapIfLesser(ref p8, ref p9, comparisonPointer);
			SwapIfLesser(ref p10, ref p11, comparisonPointer);
			SwapIfLesser(ref p12, ref p13, comparisonPointer);
			SwapIfLesser(ref p14, ref p15, comparisonPointer);
			SwapIfLesser(ref p0, ref p2, comparisonPointer);
			SwapIfLesser(ref p4, ref p6, comparisonPointer);
			SwapIfLesser(ref p8, ref p10, comparisonPointer);
			SwapIfLesser(ref p12, ref p14, comparisonPointer);
			SwapIfLesser(ref p1, ref p3, comparisonPointer);
			SwapIfLesser(ref p5, ref p7, comparisonPointer);
			SwapIfLesser(ref p9, ref p11, comparisonPointer);
			SwapIfLesser(ref p13, ref p15, comparisonPointer);
			SwapIfLesser(ref p0, ref p4, comparisonPointer);
			SwapIfLesser(ref p8, ref p12, comparisonPointer);
			SwapIfLesser(ref p1, ref p5, comparisonPointer);
			SwapIfLesser(ref p9, ref p13, comparisonPointer);
			SwapIfLesser(ref p2, ref p6, comparisonPointer);
			SwapIfLesser(ref p10, ref p14, comparisonPointer);
			SwapIfLesser(ref p3, ref p7, comparisonPointer);
			SwapIfLesser(ref p11, ref p15, comparisonPointer);
			SwapIfLesser(ref p0, ref p8, comparisonPointer);
			SwapIfLesser(ref p1, ref p9, comparisonPointer);
			SwapIfLesser(ref p2, ref p10, comparisonPointer);
			SwapIfLesser(ref p3, ref p11, comparisonPointer);
			SwapIfLesser(ref p4, ref p12, comparisonPointer);
			SwapIfLesser(ref p5, ref p13, comparisonPointer);
			SwapIfLesser(ref p6, ref p14, comparisonPointer);
			SwapIfLesser(ref p7, ref p15, comparisonPointer);
			SwapIfLesser(ref p5, ref p10, comparisonPointer);
			SwapIfLesser(ref p6, ref p9, comparisonPointer);
			SwapIfLesser(ref p3, ref p12, comparisonPointer);
			SwapIfLesser(ref p13, ref p14, comparisonPointer);
			SwapIfLesser(ref p7, ref p11, comparisonPointer);
			SwapIfLesser(ref p1, ref p2, comparisonPointer);
			SwapIfLesser(ref p4, ref p8, comparisonPointer);
			SwapIfLesser(ref p1, ref p4, comparisonPointer);
			SwapIfLesser(ref p7, ref p13, comparisonPointer);
			SwapIfLesser(ref p2, ref p8, comparisonPointer);
			SwapIfLesser(ref p11, ref p14, comparisonPointer);
			SwapIfLesser(ref p2, ref p4, comparisonPointer);
			SwapIfLesser(ref p5, ref p6, comparisonPointer);
			SwapIfLesser(ref p9, ref p10, comparisonPointer);
			SwapIfLesser(ref p11, ref p13, comparisonPointer);
			SwapIfLesser(ref p3, ref p8, comparisonPointer);
			SwapIfLesser(ref p7, ref p12, comparisonPointer);
			SwapIfLesser(ref p6, ref p8, comparisonPointer);
			SwapIfLesser(ref p10, ref p12, comparisonPointer);
			SwapIfLesser(ref p3, ref p5, comparisonPointer);
			SwapIfLesser(ref p7, ref p9, comparisonPointer);
			SwapIfLesser(ref p3, ref p4, comparisonPointer);
			SwapIfLesser(ref p5, ref p6, comparisonPointer);
			SwapIfLesser(ref p7, ref p8, comparisonPointer);
			SwapIfLesser(ref p9, ref p10, comparisonPointer);
			SwapIfLesser(ref p11, ref p12, comparisonPointer);
			SwapIfLesser(ref p6, ref p7, comparisonPointer);
			SwapIfLesser(ref p8, ref p9, comparisonPointer);
		}

		public unsafe static void SortDescending<T>(ref T p0, in int length, delegate* managed<T, T, int> comparisonPointer)
		{
			switch (length)
			{
				case 9: Sort9Descending(ref p0, comparisonPointer); break;
				case 10: Sort10Descending(ref p0, comparisonPointer); break;
				case 11: Sort11Descending(ref p0, comparisonPointer); break;
				case 12: Sort12Descending(ref p0, comparisonPointer); break;
				case 13: Sort13Descending(ref p0, comparisonPointer); break;
				case 14: Sort14Descending(ref p0, comparisonPointer); break;
				case 15: Sort15Descending(ref p0, comparisonPointer); break;
				case 16: Sort16Descending(ref p0, comparisonPointer); break;
				default: throw new ArgumentOutOfRangeException(nameof(length), $"Sorting network length `{length}` must be between `{MinLength}` and `{MaxLength}`.");
			}
		}
	}
}