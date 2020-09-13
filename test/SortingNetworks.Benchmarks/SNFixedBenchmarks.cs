namespace SortingNetworks.Benchmarks
{
	using BenchmarkDotNet.Attributes;

	public class SN2SortBenchmark : SNFixedBenchmarkBase
	{
		#region SNFixedBenchmarkBase Members

		[Params]
		public override int Length => 2;

		#endregion

		[Benchmark]
		public void SortAscending_Comparable()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBoseNelson.Sort2Ascending(ref Items[i]);
			}
		}

		[Benchmark]
		public void SortAscending_Comparison()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBoseNelson.Sort2Ascending(ref Items[i], InternalComparison);
			}
		}

		[Benchmark]
		public unsafe void SortAscending_ComparisonPointer()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBoseNelson.Sort2Ascending(ref Items[i], &InternalComparison);
			}
		}
	}

	public class SN3SortBenchmark : SNFixedBenchmarkBase
	{
		#region SNFixedBenchmarkBase Members

		public override int Length => 3;

		#endregion

		[Benchmark]
		public void SortAscending_Comparable()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBoseNelson.Sort3Ascending(ref Items[i]);
			}
		}

		[Benchmark]
		public void SortAscending_Comparison()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBoseNelson.Sort3Ascending(ref Items[i], InternalComparison);
			}
		}

		[Benchmark]
		public unsafe void SortAscending_ComparisonPointer()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBoseNelson.Sort3Ascending(ref Items[i], &InternalComparison);
			}
		}
	}

	public class SN4SortBenchmark : SNFixedBenchmarkBase
	{
		#region SNFixedBenchmarkBase Members

		public override int Length => 4;

		#endregion

		[Benchmark]
		public void SortAscending_Comparable()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBoseNelson.Sort4Ascending(ref Items[i]);
			}
		}

		[Benchmark]
		public void SortAscending_Comparison()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBoseNelson.Sort4Ascending(ref Items[i], InternalComparison);
			}
		}

		[Benchmark]
		public unsafe void SortAscending_ComparisonPointer()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBoseNelson.Sort4Ascending(ref Items[i], &InternalComparison);
			}
		}
	}

	public class SN5SortBenchmark : SNFixedBenchmarkBase
	{
		#region SNFixedBenchmarkBase Members

		public override int Length => 5;

		#endregion

		[Benchmark]
		public void SortAscending_Comparable()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBoseNelson.Sort5Ascending(ref Items[i]);
			}
		}

		[Benchmark]
		public void SortAscending_Comparison()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBoseNelson.Sort5Ascending(ref Items[i], InternalComparison);
			}
		}

		[Benchmark]
		public unsafe void SortAscending_ComparisonPointer()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBoseNelson.Sort5Ascending(ref Items[i], &InternalComparison);
			}
		}
	}

	public class SN6SortBenchmark : SNFixedBenchmarkBase
	{
		#region SNFixedBenchmarkBase Members

		public override int Length => 6;

		#endregion

		[Benchmark]
		public void SortAscending_Comparable()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBoseNelson.Sort6Ascending(ref Items[i]);
			}
		}

		[Benchmark]
		public void SortAscending_Comparison()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBoseNelson.Sort6Ascending(ref Items[i], InternalComparison);
			}
		}

		[Benchmark]
		public unsafe void SortAscending_ComparisonPointer()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBoseNelson.Sort6Ascending(ref Items[i], &InternalComparison);
			}
		}
	}

	public class SN7SortBenchmark : SNFixedBenchmarkBase
	{
		#region SNFixedBenchmarkBase Members

		public override int Length => 7;

		#endregion

		[Benchmark]
		public void SortAscending_Comparable()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBoseNelson.Sort7Ascending(ref Items[i]);
			}
		}

		[Benchmark]
		public void SortAscending_Comparison()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBoseNelson.Sort7Ascending(ref Items[i], InternalComparison);
			}
		}

		[Benchmark]
		public unsafe void SortAscending_ComparisonPointer()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBoseNelson.Sort7Ascending(ref Items[i], &InternalComparison);
			}
		}
	}

	public class SN8SortBenchmark : SNFixedBenchmarkBase
	{
		#region SNFixedBenchmarkBase Members

		public override int Length => 8;

		#endregion

		[Benchmark]
		public void SortAscending_Comparable()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBoseNelson.Sort8Ascending(ref Items[i]);
			}
		}

		[Benchmark]
		public void SortAscending_Comparison()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBoseNelson.Sort8Ascending(ref Items[i], InternalComparison);
			}
		}

		[Benchmark]
		public unsafe void SortAscending_ComparisonPointer()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBoseNelson.Sort8Ascending(ref Items[i], &InternalComparison);
			}
		}
	}

	public class SN9SortBenchmark : SNFixedBenchmarkBase
	{
		#region SNFixedBenchmarkBase Members

		public override int Length => 9;

		#endregion

		[Benchmark]
		public void SortAscending_Comparable()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBestKnown.Sort9Ascending(ref Items[i]);
			}
		}

		[Benchmark]
		public void SortAscending_Comparison()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBestKnown.Sort9Ascending(ref Items[i], InternalComparison);
			}
		}

		[Benchmark]
		public unsafe void SortAscending_ComparisonPointer()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBestKnown.Sort9Ascending(ref Items[i], &InternalComparison);
			}
		}
	}

	public class SN10SortBenchmark : SNFixedBenchmarkBase
	{
		#region SNFixedBenchmarkBase Members

		public override int Length => 10;

		#endregion

		[Benchmark]
		public void SortAscending_Comparable()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBestKnown.Sort10Ascending(ref Items[i]);
			}
		}

		[Benchmark]
		public void SortAscending_Comparison()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBestKnown.Sort10Ascending(ref Items[i], InternalComparison);
			}
		}

		[Benchmark]
		public unsafe void SortAscending_ComparisonPointer()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBestKnown.Sort10Ascending(ref Items[i], &InternalComparison);
			}
		}
	}

	public class SN11SortBenchmark : SNFixedBenchmarkBase
	{
		#region SNFixedBenchmarkBase Members

		public override int Length => 11;

		#endregion

		[Benchmark]
		public void SortAscending_Comparable()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBestKnown.Sort11Ascending(ref Items[i]);
			}
		}

		[Benchmark]
		public void SortAscending_Comparison()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBestKnown.Sort11Ascending(ref Items[i], InternalComparison);
			}
		}

		[Benchmark]
		public unsafe void SortAscending_ComparisonPointer()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBestKnown.Sort11Ascending(ref Items[i], &InternalComparison);
			}
		}
	}

	public class SN12SortBenchmark : SNFixedBenchmarkBase
	{
		#region SNFixedBenchmarkBase Members

		public override int Length => 12;

		#endregion

		[Benchmark]
		public void SortAscending_Comparable()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBestKnown.Sort12Ascending(ref Items[i]);
			}
		}

		[Benchmark]
		public void SortAscending_Comparison()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBestKnown.Sort12Ascending(ref Items[i], InternalComparison);
			}
		}

		[Benchmark]
		public unsafe void SortAscending_ComparisonPointer()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBestKnown.Sort12Ascending(ref Items[i], &InternalComparison);
			}
		}
	}

	public class SN13SortBenchmark : SNFixedBenchmarkBase
	{
		#region SNFixedBenchmarkBase Members

		public override int Length => 13;

		#endregion

		[Benchmark]
		public void SortAscending_Comparable()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBestKnown.Sort13Ascending(ref Items[i]);
			}
		}

		[Benchmark]
		public void SortAscending_Comparison()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBestKnown.Sort13Ascending(ref Items[i], InternalComparison);
			}
		}

		[Benchmark]
		public unsafe void SortAscending_ComparisonPointer()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBestKnown.Sort13Ascending(ref Items[i], &InternalComparison);
			}
		}
	}

	public class SN14SortBenchmark : SNFixedBenchmarkBase
	{
		#region SNFixedBenchmarkBase Members

		public override int Length => 14;

		#endregion

		[Benchmark]
		public void SortAscending_Comparable()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBestKnown.Sort14Ascending(ref Items[i]);
			}
		}

		[Benchmark]
		public void SortAscending_Comparison()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBestKnown.Sort14Ascending(ref Items[i], InternalComparison);
			}
		}

		[Benchmark]
		public unsafe void SortAscending_ComparisonPointer()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBestKnown.Sort14Ascending(ref Items[i], &InternalComparison);
			}
		}
	}

	public class SN15SortBenchmark : SNFixedBenchmarkBase
	{
		#region SNFixedBenchmarkBase Members

		public override int Length => 15;

		#endregion

		[Benchmark]
		public void SortAscending_Comparable()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBestKnown.Sort15Ascending(ref Items[i]);
			}
		}

		[Benchmark]
		public void SortAscending_Comparison()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBestKnown.Sort15Ascending(ref Items[i], InternalComparison);
			}
		}

		[Benchmark]
		public unsafe void SortAscending_ComparisonPointer()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBestKnown.Sort15Ascending(ref Items[i], &InternalComparison);
			}
		}
	}

	public class SN16SortBenchmark : SNFixedBenchmarkBase
	{
		#region SNFixedBenchmarkBase Members

		public override int Length => 16;

		#endregion

		[Benchmark]
		public void SortAscending_Comparable()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBestKnown.Sort16Ascending(ref Items[i]);
			}
		}

		[Benchmark]
		public void SortAscending_Comparison()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBestKnown.Sort16Ascending(ref Items[i], InternalComparison);
			}
		}

		[Benchmark]
		public unsafe void SortAscending_ComparisonPointer()
		{
			for (int i = 0; i < N; i += Length)
			{
				SNBestKnown.Sort16Ascending(ref Items[i], &InternalComparison);
			}
		}
	}

}