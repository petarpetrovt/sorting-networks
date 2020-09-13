namespace SortingNetworks.Benchmarks
{
	using BenchmarkDotNet.Attributes;

	public class SN2SortSNBoseNelsonBenchmark : SNFixedBenchmarkBase
	{
		#region SNFixedBenchmarkBase Members

		[Params(2)]
		public override int Length { get; set; }

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

	public class SN3SortSNBoseNelsonBenchmark : SNFixedBenchmarkBase
	{
		#region SNFixedBenchmarkBase Members

		[Params(3)]
		public override int Length { get; set; }

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

	public class SN4SortSNBoseNelsonBenchmark : SNFixedBenchmarkBase
	{
		#region SNFixedBenchmarkBase Members

		[Params(4)]
		public override int Length { get; set; }

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

	public class SN5SortSNBoseNelsonBenchmark : SNFixedBenchmarkBase
	{
		#region SNFixedBenchmarkBase Members

		[Params(5)]
		public override int Length { get; set; }

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

	public class SN6SortSNBoseNelsonBenchmark : SNFixedBenchmarkBase
	{
		#region SNFixedBenchmarkBase Members

		[Params(6)]
		public override int Length { get; set; }

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

	public class SN7SortSNBoseNelsonBenchmark : SNFixedBenchmarkBase
	{
		#region SNFixedBenchmarkBase Members

		[Params(7)]
		public override int Length { get; set; }

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

	public class SN8SortSNBoseNelsonBenchmark : SNFixedBenchmarkBase
	{
		#region SNFixedBenchmarkBase Members

		[Params(8)]
		public override int Length { get; set; }

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

}