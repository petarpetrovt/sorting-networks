namespace SortingNetworks.Benchmarks
{
	using BenchmarkDotNet.Attributes;

	public class SN9SortSNBestKnownBenchmark : SNFixedBenchmarkBase
	{
		#region SNFixedBenchmarkBase Members

		[Params(9)]
		public override int Length { get; set; }

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

	public class SN10SortSNBestKnownBenchmark : SNFixedBenchmarkBase
	{
		#region SNFixedBenchmarkBase Members

		[Params(10)]
		public override int Length { get; set; }

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

	public class SN11SortSNBestKnownBenchmark : SNFixedBenchmarkBase
	{
		#region SNFixedBenchmarkBase Members

		[Params(11)]
		public override int Length { get; set; }

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

	public class SN12SortSNBestKnownBenchmark : SNFixedBenchmarkBase
	{
		#region SNFixedBenchmarkBase Members

		[Params(12)]
		public override int Length { get; set; }

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

	public class SN13SortSNBestKnownBenchmark : SNFixedBenchmarkBase
	{
		#region SNFixedBenchmarkBase Members

		[Params(13)]
		public override int Length { get; set; }

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

	public class SN14SortSNBestKnownBenchmark : SNFixedBenchmarkBase
	{
		#region SNFixedBenchmarkBase Members

		[Params(14)]
		public override int Length { get; set; }

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

	public class SN15SortSNBestKnownBenchmark : SNFixedBenchmarkBase
	{
		#region SNFixedBenchmarkBase Members

		[Params(15)]
		public override int Length { get; set; }

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

	public class SN16SortSNBestKnownBenchmark : SNFixedBenchmarkBase
	{
		#region SNFixedBenchmarkBase Members

		[Params(16)]
		public override int Length { get; set; }

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