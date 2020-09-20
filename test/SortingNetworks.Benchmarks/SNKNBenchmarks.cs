namespace SortingNetworks.Benchmarks
{
	using System;
	using BenchmarkDotNet.Attributes;

	public class SN9SortSNBestKnownBenchmark : SNBenchmarkBase
	{
		[Params(9)]
		public override int Length { get; set; }

		[Benchmark]
		public void SN_Generic_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBestKnown.SortAscending(ref _iterationItems[i], Length);
			}
		}

		[Benchmark]
		public void SN_Fixed_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBestKnown.Sort9Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void Insertion_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				Span<int> slice = _iterationItems.AsSpan(i, Length);

				PrivateInsertionSortAscending(slice);
			}
		}
	}

	public class SN10SortSNBestKnownBenchmark : SNBenchmarkBase
	{
		[Params(10)]
		public override int Length { get; set; }

		[Benchmark]
		public void SN_Generic_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBestKnown.SortAscending(ref _iterationItems[i], Length);
			}
		}

		[Benchmark]
		public void SN_Fixed_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBestKnown.Sort10Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void Insertion_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				Span<int> slice = _iterationItems.AsSpan(i, Length);

				PrivateInsertionSortAscending(slice);
			}
		}
	}

	public class SN11SortSNBestKnownBenchmark : SNBenchmarkBase
	{
		[Params(11)]
		public override int Length { get; set; }

		[Benchmark]
		public void SN_Generic_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBestKnown.SortAscending(ref _iterationItems[i], Length);
			}
		}

		[Benchmark]
		public void SN_Fixed_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBestKnown.Sort11Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void Insertion_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				Span<int> slice = _iterationItems.AsSpan(i, Length);

				PrivateInsertionSortAscending(slice);
			}
		}
	}

	public class SN12SortSNBestKnownBenchmark : SNBenchmarkBase
	{
		[Params(12)]
		public override int Length { get; set; }

		[Benchmark]
		public void SN_Generic_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBestKnown.SortAscending(ref _iterationItems[i], Length);
			}
		}

		[Benchmark]
		public void SN_Fixed_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBestKnown.Sort12Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void Insertion_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				Span<int> slice = _iterationItems.AsSpan(i, Length);

				PrivateInsertionSortAscending(slice);
			}
		}
	}

	public class SN13SortSNBestKnownBenchmark : SNBenchmarkBase
	{
		[Params(13)]
		public override int Length { get; set; }

		[Benchmark]
		public void SN_Generic_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBestKnown.SortAscending(ref _iterationItems[i], Length);
			}
		}

		[Benchmark]
		public void SN_Fixed_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBestKnown.Sort13Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void Insertion_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				Span<int> slice = _iterationItems.AsSpan(i, Length);

				PrivateInsertionSortAscending(slice);
			}
		}
	}

	public class SN14SortSNBestKnownBenchmark : SNBenchmarkBase
	{
		[Params(14)]
		public override int Length { get; set; }

		[Benchmark]
		public void SN_Generic_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBestKnown.SortAscending(ref _iterationItems[i], Length);
			}
		}

		[Benchmark]
		public void SN_Fixed_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBestKnown.Sort14Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void Insertion_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				Span<int> slice = _iterationItems.AsSpan(i, Length);

				PrivateInsertionSortAscending(slice);
			}
		}
	}

	public class SN15SortSNBestKnownBenchmark : SNBenchmarkBase
	{
		[Params(15)]
		public override int Length { get; set; }

		[Benchmark]
		public void SN_Generic_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBestKnown.SortAscending(ref _iterationItems[i], Length);
			}
		}

		[Benchmark]
		public void SN_Fixed_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBestKnown.Sort15Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void Insertion_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				Span<int> slice = _iterationItems.AsSpan(i, Length);

				PrivateInsertionSortAscending(slice);
			}
		}
	}

	public class SN16SortSNBestKnownBenchmark : SNBenchmarkBase
	{
		[Params(16)]
		public override int Length { get; set; }

		[Benchmark]
		public void SN_Generic_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBestKnown.SortAscending(ref _iterationItems[i], Length);
			}
		}

		[Benchmark]
		public void SN_Fixed_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBestKnown.Sort16Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void Insertion_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				Span<int> slice = _iterationItems.AsSpan(i, Length);

				PrivateInsertionSortAscending(slice);
			}
		}
	}

}