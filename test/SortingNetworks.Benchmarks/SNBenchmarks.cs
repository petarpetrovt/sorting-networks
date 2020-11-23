﻿namespace SortingNetworks.Benchmarks
{
	using System;
	using BenchmarkDotNet.Attributes;

	public class SN02Benchmark : SNBenchmarkBase
	{
		[Params(2)]
		public override int Length { get; set; }

		[Benchmark]
		public void BoseNelson_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort2Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BoseNelson_Branchless()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort2AscendingBranchless(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void Insertion_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				Span<int> slice = _iterationItems.AsSpan(i, length);

				PrivateInsertionSortAscending(slice);
			}
		}
	}

	public class SN03Benchmark : SNBenchmarkBase
	{
		[Params(3)]
		public override int Length { get; set; }

		[Benchmark]
		public void BoseNelson_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort3Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BoseNelson_Branchless()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort3AscendingBranchless(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void Insertion_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				Span<int> slice = _iterationItems.AsSpan(i, length);

				PrivateInsertionSortAscending(slice);
			}
		}
	}

	public class SN04Benchmark : SNBenchmarkBase
	{
		[Params(4)]
		public override int Length { get; set; }

		[Benchmark]
		public void BoseNelson_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort4Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BoseNelson_Branchless()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort4AscendingBranchless(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void Insertion_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				Span<int> slice = _iterationItems.AsSpan(i, length);

				PrivateInsertionSortAscending(slice);
			}
		}
	}

	public class SN05Benchmark : SNBenchmarkBase
	{
		[Params(5)]
		public override int Length { get; set; }

		[Benchmark]
		public void BoseNelson_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort5Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BoseNelson_Branchless()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort5AscendingBranchless(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void Insertion_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				Span<int> slice = _iterationItems.AsSpan(i, length);

				PrivateInsertionSortAscending(slice);
			}
		}
	}

	public class SN06Benchmark : SNBenchmarkBase
	{
		[Params(6)]
		public override int Length { get; set; }

		[Benchmark]
		public void BoseNelson_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort6Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BoseNelson_Branchless()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort6AscendingBranchless(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void Insertion_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				Span<int> slice = _iterationItems.AsSpan(i, length);

				PrivateInsertionSortAscending(slice);
			}
		}
	}

	public class SN07Benchmark : SNBenchmarkBase
	{
		[Params(7)]
		public override int Length { get; set; }

		[Benchmark]
		public void BoseNelson_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort7Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BoseNelson_Branchless()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort7AscendingBranchless(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void Insertion_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				Span<int> slice = _iterationItems.AsSpan(i, length);

				PrivateInsertionSortAscending(slice);
			}
		}
	}

	public class SN08Benchmark : SNBenchmarkBase
	{
		[Params(8)]
		public override int Length { get; set; }

		[Benchmark]
		public void BoseNelson_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort8Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BoseNelson_Branchless()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort8AscendingBranchless(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void Insertion_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				Span<int> slice = _iterationItems.AsSpan(i, length);

				PrivateInsertionSortAscending(slice);
			}
		}
	}

	public class SN09Benchmark : SNBenchmarkBase
	{
		[Params(9)]
		public override int Length { get; set; }

		[Benchmark]
		public void BoseNelson_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort9Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BoseNelson_Branchless()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort9AscendingBranchless(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BestKnown_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBestKnown.Sort9Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BestKnown_Branchless()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBestKnown.Sort9AscendingBranchless(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void Insertion_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				Span<int> slice = _iterationItems.AsSpan(i, length);

				PrivateInsertionSortAscending(slice);
			}
		}
	}

	public class SN10Benchmark : SNBenchmarkBase
	{
		[Params(10)]
		public override int Length { get; set; }

		[Benchmark]
		public void BoseNelson_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort10Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BoseNelson_Branchless()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort10AscendingBranchless(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BestKnown_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBestKnown.Sort10Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BestKnown_Branchless()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBestKnown.Sort10AscendingBranchless(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void Insertion_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				Span<int> slice = _iterationItems.AsSpan(i, length);

				PrivateInsertionSortAscending(slice);
			}
		}
	}

	public class SN11Benchmark : SNBenchmarkBase
	{
		[Params(11)]
		public override int Length { get; set; }

		[Benchmark]
		public void BoseNelson_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort11Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BoseNelson_Branchless()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort11AscendingBranchless(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BestKnown_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBestKnown.Sort11Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BestKnown_Branchless()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBestKnown.Sort11AscendingBranchless(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void Insertion_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				Span<int> slice = _iterationItems.AsSpan(i, length);

				PrivateInsertionSortAscending(slice);
			}
		}
	}

	public class SN12Benchmark : SNBenchmarkBase
	{
		[Params(12)]
		public override int Length { get; set; }

		[Benchmark]
		public void BoseNelson_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort12Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BoseNelson_Branchless()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort12AscendingBranchless(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BestKnown_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBestKnown.Sort12Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BestKnown_Branchless()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBestKnown.Sort12AscendingBranchless(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void Insertion_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				Span<int> slice = _iterationItems.AsSpan(i, length);

				PrivateInsertionSortAscending(slice);
			}
		}
	}

	public class SN13Benchmark : SNBenchmarkBase
	{
		[Params(13)]
		public override int Length { get; set; }

		[Benchmark]
		public void BoseNelson_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort13Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BoseNelson_Branchless()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort13AscendingBranchless(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BestKnown_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBestKnown.Sort13Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BestKnown_Branchless()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBestKnown.Sort13AscendingBranchless(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void Insertion_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				Span<int> slice = _iterationItems.AsSpan(i, length);

				PrivateInsertionSortAscending(slice);
			}
		}
	}

	public class SN14Benchmark : SNBenchmarkBase
	{
		[Params(14)]
		public override int Length { get; set; }

		[Benchmark]
		public void BoseNelson_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort14Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BoseNelson_Branchless()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort14AscendingBranchless(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BestKnown_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBestKnown.Sort14Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BestKnown_Branchless()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBestKnown.Sort14AscendingBranchless(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void Insertion_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				Span<int> slice = _iterationItems.AsSpan(i, length);

				PrivateInsertionSortAscending(slice);
			}
		}
	}

	public class SN15Benchmark : SNBenchmarkBase
	{
		[Params(15)]
		public override int Length { get; set; }

		[Benchmark]
		public void BoseNelson_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort15Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BoseNelson_Branchless()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort15AscendingBranchless(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BestKnown_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBestKnown.Sort15Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BestKnown_Branchless()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBestKnown.Sort15AscendingBranchless(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void Insertion_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				Span<int> slice = _iterationItems.AsSpan(i, length);

				PrivateInsertionSortAscending(slice);
			}
		}
	}

	public class SN16Benchmark : SNBenchmarkBase
	{
		[Params(16)]
		public override int Length { get; set; }

		[Benchmark]
		public void BoseNelson_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort16Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BoseNelson_Branchless()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort16AscendingBranchless(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BestKnown_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBestKnown.Sort16Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BestKnown_Branchless()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBestKnown.Sort16AscendingBranchless(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void Insertion_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				Span<int> slice = _iterationItems.AsSpan(i, length);

				PrivateInsertionSortAscending(slice);
			}
		}
	}

	public class SN17Benchmark : SNBenchmarkBase
	{
		[Params(17)]
		public override int Length { get; set; }

		[Benchmark]
		public void BoseNelson_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort17Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BoseNelson_Branchless()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort17AscendingBranchless(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void Insertion_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				Span<int> slice = _iterationItems.AsSpan(i, length);

				PrivateInsertionSortAscending(slice);
			}
		}
	}

	public class SN18Benchmark : SNBenchmarkBase
	{
		[Params(18)]
		public override int Length { get; set; }

		[Benchmark]
		public void BoseNelson_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort18Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BoseNelson_Branchless()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort18AscendingBranchless(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void Insertion_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				Span<int> slice = _iterationItems.AsSpan(i, length);

				PrivateInsertionSortAscending(slice);
			}
		}
	}

	public class SN19Benchmark : SNBenchmarkBase
	{
		[Params(19)]
		public override int Length { get; set; }

		[Benchmark]
		public void BoseNelson_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort19Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BoseNelson_Branchless()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort19AscendingBranchless(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void Insertion_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				Span<int> slice = _iterationItems.AsSpan(i, length);

				PrivateInsertionSortAscending(slice);
			}
		}
	}

	public class SN20Benchmark : SNBenchmarkBase
	{
		[Params(20)]
		public override int Length { get; set; }

		[Benchmark]
		public void BoseNelson_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort20Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BoseNelson_Branchless()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort20AscendingBranchless(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void Insertion_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				Span<int> slice = _iterationItems.AsSpan(i, length);

				PrivateInsertionSortAscending(slice);
			}
		}
	}

	public class SN21Benchmark : SNBenchmarkBase
	{
		[Params(21)]
		public override int Length { get; set; }

		[Benchmark]
		public void BoseNelson_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort21Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BoseNelson_Branchless()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort21AscendingBranchless(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void Insertion_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				Span<int> slice = _iterationItems.AsSpan(i, length);

				PrivateInsertionSortAscending(slice);
			}
		}
	}

	public class SN22Benchmark : SNBenchmarkBase
	{
		[Params(22)]
		public override int Length { get; set; }

		[Benchmark]
		public void BoseNelson_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort22Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BoseNelson_Branchless()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort22AscendingBranchless(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void Insertion_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				Span<int> slice = _iterationItems.AsSpan(i, length);

				PrivateInsertionSortAscending(slice);
			}
		}
	}

	public class SN23Benchmark : SNBenchmarkBase
	{
		[Params(23)]
		public override int Length { get; set; }

		[Benchmark]
		public void BoseNelson_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort23Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BoseNelson_Branchless()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort23AscendingBranchless(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void Insertion_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				Span<int> slice = _iterationItems.AsSpan(i, length);

				PrivateInsertionSortAscending(slice);
			}
		}
	}

	public class SN24Benchmark : SNBenchmarkBase
	{
		[Params(24)]
		public override int Length { get; set; }

		[Benchmark]
		public void BoseNelson_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort24Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BoseNelson_Branchless()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort24AscendingBranchless(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void Insertion_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				Span<int> slice = _iterationItems.AsSpan(i, length);

				PrivateInsertionSortAscending(slice);
			}
		}
	}

	public class SN25Benchmark : SNBenchmarkBase
	{
		[Params(25)]
		public override int Length { get; set; }

		[Benchmark]
		public void BoseNelson_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort25Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BoseNelson_Branchless()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort25AscendingBranchless(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void Insertion_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				Span<int> slice = _iterationItems.AsSpan(i, length);

				PrivateInsertionSortAscending(slice);
			}
		}
	}

	public class SN26Benchmark : SNBenchmarkBase
	{
		[Params(26)]
		public override int Length { get; set; }

		[Benchmark]
		public void BoseNelson_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort26Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BoseNelson_Branchless()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort26AscendingBranchless(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void Insertion_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				Span<int> slice = _iterationItems.AsSpan(i, length);

				PrivateInsertionSortAscending(slice);
			}
		}
	}

	public class SN27Benchmark : SNBenchmarkBase
	{
		[Params(27)]
		public override int Length { get; set; }

		[Benchmark]
		public void BoseNelson_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort27Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BoseNelson_Branchless()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort27AscendingBranchless(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void Insertion_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				Span<int> slice = _iterationItems.AsSpan(i, length);

				PrivateInsertionSortAscending(slice);
			}
		}
	}

	public class SN28Benchmark : SNBenchmarkBase
	{
		[Params(28)]
		public override int Length { get; set; }

		[Benchmark]
		public void BoseNelson_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort28Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BoseNelson_Branchless()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort28AscendingBranchless(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void Insertion_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				Span<int> slice = _iterationItems.AsSpan(i, length);

				PrivateInsertionSortAscending(slice);
			}
		}
	}

	public class SN29Benchmark : SNBenchmarkBase
	{
		[Params(29)]
		public override int Length { get; set; }

		[Benchmark]
		public void BoseNelson_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort29Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BoseNelson_Branchless()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort29AscendingBranchless(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void Insertion_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				Span<int> slice = _iterationItems.AsSpan(i, length);

				PrivateInsertionSortAscending(slice);
			}
		}
	}

	public class SN30Benchmark : SNBenchmarkBase
	{
		[Params(30)]
		public override int Length { get; set; }

		[Benchmark]
		public void BoseNelson_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort30Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BoseNelson_Branchless()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort30AscendingBranchless(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void Insertion_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				Span<int> slice = _iterationItems.AsSpan(i, length);

				PrivateInsertionSortAscending(slice);
			}
		}
	}

	public class SN31Benchmark : SNBenchmarkBase
	{
		[Params(31)]
		public override int Length { get; set; }

		[Benchmark]
		public void BoseNelson_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort31Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BoseNelson_Branchless()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort31AscendingBranchless(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void Insertion_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				Span<int> slice = _iterationItems.AsSpan(i, length);

				PrivateInsertionSortAscending(slice);
			}
		}
	}

	public class SN32Benchmark : SNBenchmarkBase
	{
		[Params(32)]
		public override int Length { get; set; }

		[Benchmark]
		public void BoseNelson_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort32Ascending(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void BoseNelson_Branchless()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				SNBoseNelson.Sort32AscendingBranchless(ref _iterationItems[i]);
			}
		}

		[Benchmark]
		public void Insertion_Comparable()
		{
			int length = Length;
			int maximumLength = Count - length;

			for (int i = 0; i < maximumLength; i += length)
			{
				Span<int> slice = _iterationItems.AsSpan(i, length);

				PrivateInsertionSortAscending(slice);
			}
		}
	}

}