namespace SortingNetworks.Benchmarks
{
	using BenchmarkDotNet.Attributes;

	public class SN2SortSNBoseNelsonBenchmark : SNBenchmarkBase
	{
		[Params(2)]
		public override int Length { get; set; }

		[Benchmark]
		public void SortAscending_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort2Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void SortAscending_Comparison()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort2Ascending(ref _iterationItems[i], InternalComparison);
			}
		}

		[Benchmark]
		public unsafe void SortAscending_ComparisonPointer()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort2Ascending(ref _iterationItems[i], &InternalComparison);
			}
		}
	}

	public class SN3SortSNBoseNelsonBenchmark : SNBenchmarkBase
	{
		[Params(3)]
		public override int Length { get; set; }

		[Benchmark]
		public void SortAscending_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort3Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void SortAscending_Comparison()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort3Ascending(ref _iterationItems[i], InternalComparison);
			}
		}

		[Benchmark]
		public unsafe void SortAscending_ComparisonPointer()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort3Ascending(ref _iterationItems[i], &InternalComparison);
			}
		}
	}

	public class SN4SortSNBoseNelsonBenchmark : SNBenchmarkBase
	{
		[Params(4)]
		public override int Length { get; set; }

		[Benchmark]
		public void SortAscending_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort4Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void SortAscending_Comparison()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort4Ascending(ref _iterationItems[i], InternalComparison);
			}
		}

		[Benchmark]
		public unsafe void SortAscending_ComparisonPointer()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort4Ascending(ref _iterationItems[i], &InternalComparison);
			}
		}
	}

	public class SN5SortSNBoseNelsonBenchmark : SNBenchmarkBase
	{
		[Params(5)]
		public override int Length { get; set; }

		[Benchmark]
		public void SortAscending_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort5Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void SortAscending_Comparison()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort5Ascending(ref _iterationItems[i], InternalComparison);
			}
		}

		[Benchmark]
		public unsafe void SortAscending_ComparisonPointer()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort5Ascending(ref _iterationItems[i], &InternalComparison);
			}
		}
	}

	public class SN6SortSNBoseNelsonBenchmark : SNBenchmarkBase
	{
		[Params(6)]
		public override int Length { get; set; }

		[Benchmark]
		public void SortAscending_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort6Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void SortAscending_Comparison()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort6Ascending(ref _iterationItems[i], InternalComparison);
			}
		}

		[Benchmark]
		public unsafe void SortAscending_ComparisonPointer()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort6Ascending(ref _iterationItems[i], &InternalComparison);
			}
		}
	}

	public class SN7SortSNBoseNelsonBenchmark : SNBenchmarkBase
	{
		[Params(7)]
		public override int Length { get; set; }

		[Benchmark]
		public void SortAscending_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort7Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void SortAscending_Comparison()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort7Ascending(ref _iterationItems[i], InternalComparison);
			}
		}

		[Benchmark]
		public unsafe void SortAscending_ComparisonPointer()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort7Ascending(ref _iterationItems[i], &InternalComparison);
			}
		}
	}

	public class SN8SortSNBoseNelsonBenchmark : SNBenchmarkBase
	{
		[Params(8)]
		public override int Length { get; set; }

		[Benchmark]
		public void SortAscending_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort8Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void SortAscending_Comparison()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort8Ascending(ref _iterationItems[i], InternalComparison);
			}
		}

		[Benchmark]
		public unsafe void SortAscending_ComparisonPointer()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort8Ascending(ref _iterationItems[i], &InternalComparison);
			}
		}
	}

}