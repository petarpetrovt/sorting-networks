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
			for (int i = 0; i < _iterationItems.Length; i += Length)
			{
				SNBestKnown.Sort9Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void SortAscending_Comparison()
		{
			for (int i = 0; i < _iterationItems.Length; i += Length)
			{
				SNBestKnown.Sort9Ascending(ref _iterationItems[i], InternalComparison);
			}
		}

		[Benchmark]
		public unsafe void SortAscending_ComparisonPointer()
		{
			for (int i = 0; i < _iterationItems.Length; i += Length)
			{
				SNBestKnown.Sort9Ascending(ref _iterationItems[i], &InternalComparison);
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
			for (int i = 0; i < _iterationItems.Length; i += Length)
			{
				SNBestKnown.Sort10Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void SortAscending_Comparison()
		{
			for (int i = 0; i < _iterationItems.Length; i += Length)
			{
				SNBestKnown.Sort10Ascending(ref _iterationItems[i], InternalComparison);
			}
		}

		[Benchmark]
		public unsafe void SortAscending_ComparisonPointer()
		{
			for (int i = 0; i < _iterationItems.Length; i += Length)
			{
				SNBestKnown.Sort10Ascending(ref _iterationItems[i], &InternalComparison);
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
			for (int i = 0; i < _iterationItems.Length; i += Length)
			{
				SNBestKnown.Sort11Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void SortAscending_Comparison()
		{
			for (int i = 0; i < _iterationItems.Length; i += Length)
			{
				SNBestKnown.Sort11Ascending(ref _iterationItems[i], InternalComparison);
			}
		}

		[Benchmark]
		public unsafe void SortAscending_ComparisonPointer()
		{
			for (int i = 0; i < _iterationItems.Length; i += Length)
			{
				SNBestKnown.Sort11Ascending(ref _iterationItems[i], &InternalComparison);
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
			for (int i = 0; i < _iterationItems.Length; i += Length)
			{
				SNBestKnown.Sort12Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void SortAscending_Comparison()
		{
			for (int i = 0; i < _iterationItems.Length; i += Length)
			{
				SNBestKnown.Sort12Ascending(ref _iterationItems[i], InternalComparison);
			}
		}

		[Benchmark]
		public unsafe void SortAscending_ComparisonPointer()
		{
			for (int i = 0; i < _iterationItems.Length; i += Length)
			{
				SNBestKnown.Sort12Ascending(ref _iterationItems[i], &InternalComparison);
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
			for (int i = 0; i < _iterationItems.Length; i += Length)
			{
				SNBestKnown.Sort13Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void SortAscending_Comparison()
		{
			for (int i = 0; i < _iterationItems.Length; i += Length)
			{
				SNBestKnown.Sort13Ascending(ref _iterationItems[i], InternalComparison);
			}
		}

		[Benchmark]
		public unsafe void SortAscending_ComparisonPointer()
		{
			for (int i = 0; i < _iterationItems.Length; i += Length)
			{
				SNBestKnown.Sort13Ascending(ref _iterationItems[i], &InternalComparison);
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
			for (int i = 0; i < _iterationItems.Length; i += Length)
			{
				SNBestKnown.Sort14Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void SortAscending_Comparison()
		{
			for (int i = 0; i < _iterationItems.Length; i += Length)
			{
				SNBestKnown.Sort14Ascending(ref _iterationItems[i], InternalComparison);
			}
		}

		[Benchmark]
		public unsafe void SortAscending_ComparisonPointer()
		{
			for (int i = 0; i < _iterationItems.Length; i += Length)
			{
				SNBestKnown.Sort14Ascending(ref _iterationItems[i], &InternalComparison);
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
			for (int i = 0; i < _iterationItems.Length; i += Length)
			{
				SNBestKnown.Sort15Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void SortAscending_Comparison()
		{
			for (int i = 0; i < _iterationItems.Length; i += Length)
			{
				SNBestKnown.Sort15Ascending(ref _iterationItems[i], InternalComparison);
			}
		}

		[Benchmark]
		public unsafe void SortAscending_ComparisonPointer()
		{
			for (int i = 0; i < _iterationItems.Length; i += Length)
			{
				SNBestKnown.Sort15Ascending(ref _iterationItems[i], &InternalComparison);
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
			for (int i = 0; i < _iterationItems.Length; i += Length)
			{
				SNBestKnown.Sort16Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void SortAscending_Comparison()
		{
			for (int i = 0; i < _iterationItems.Length; i += Length)
			{
				SNBestKnown.Sort16Ascending(ref _iterationItems[i], InternalComparison);
			}
		}

		[Benchmark]
		public unsafe void SortAscending_ComparisonPointer()
		{
			for (int i = 0; i < _iterationItems.Length; i += Length)
			{
				SNBestKnown.Sort16Ascending(ref _iterationItems[i], &InternalComparison);
			}
		}
	}

}