namespace SortingNetworks.Benchmarks
{
	using System;
	using BenchmarkDotNet.Attributes;

	public class SN2SortSNBoseNelsonBenchmark : SNBenchmarkBase
	{
		[Params(2)]
		public override int Length { get; set; }

		[Benchmark]
		public void SN_Generic_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.SortAscending(ref _iterationItems[i], Length);
			}
		}

		[Benchmark]
		public void SN_Fixed_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort2Ascending(ref _iterationItems[i]);
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

	public class SN3SortSNBoseNelsonBenchmark : SNBenchmarkBase
	{
		[Params(3)]
		public override int Length { get; set; }

		[Benchmark]
		public void SN_Generic_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.SortAscending(ref _iterationItems[i], Length);
			}
		}

		[Benchmark]
		public void SN_Fixed_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort3Ascending(ref _iterationItems[i]);
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

	public class SN4SortSNBoseNelsonBenchmark : SNBenchmarkBase
	{
		[Params(4)]
		public override int Length { get; set; }

		[Benchmark]
		public void SN_Generic_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.SortAscending(ref _iterationItems[i], Length);
			}
		}

		[Benchmark]
		public void SN_Fixed_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort4Ascending(ref _iterationItems[i]);
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

	public class SN5SortSNBoseNelsonBenchmark : SNBenchmarkBase
	{
		[Params(5)]
		public override int Length { get; set; }

		[Benchmark]
		public void SN_Generic_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.SortAscending(ref _iterationItems[i], Length);
			}
		}

		[Benchmark]
		public void SN_Fixed_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort5Ascending(ref _iterationItems[i]);
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

	public class SN6SortSNBoseNelsonBenchmark : SNBenchmarkBase
	{
		[Params(6)]
		public override int Length { get; set; }

		[Benchmark]
		public void SN_Generic_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.SortAscending(ref _iterationItems[i], Length);
			}
		}

		[Benchmark]
		public void SN_Fixed_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort6Ascending(ref _iterationItems[i]);
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

	public class SN7SortSNBoseNelsonBenchmark : SNBenchmarkBase
	{
		[Params(7)]
		public override int Length { get; set; }

		[Benchmark]
		public void SN_Generic_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.SortAscending(ref _iterationItems[i], Length);
			}
		}

		[Benchmark]
		public void SN_Fixed_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort7Ascending(ref _iterationItems[i]);
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

	public class SN8SortSNBoseNelsonBenchmark : SNBenchmarkBase
	{
		[Params(8)]
		public override int Length { get; set; }

		[Benchmark]
		public void SN_Generic_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.SortAscending(ref _iterationItems[i], Length);
			}
		}

		[Benchmark]
		public void SN_Fixed_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort8Ascending(ref _iterationItems[i]);
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

	public class SN9SortSNBoseNelsonBenchmark : SNBenchmarkBase
	{
		[Params(9)]
		public override int Length { get; set; }

		[Benchmark]
		public void SN_Generic_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.SortAscending(ref _iterationItems[i], Length);
			}
		}

		[Benchmark]
		public void SN_Fixed_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort9Ascending(ref _iterationItems[i]);
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

	public class SN10SortSNBoseNelsonBenchmark : SNBenchmarkBase
	{
		[Params(10)]
		public override int Length { get; set; }

		[Benchmark]
		public void SN_Generic_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.SortAscending(ref _iterationItems[i], Length);
			}
		}

		[Benchmark]
		public void SN_Fixed_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort10Ascending(ref _iterationItems[i]);
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

	public class SN11SortSNBoseNelsonBenchmark : SNBenchmarkBase
	{
		[Params(11)]
		public override int Length { get; set; }

		[Benchmark]
		public void SN_Generic_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.SortAscending(ref _iterationItems[i], Length);
			}
		}

		[Benchmark]
		public void SN_Fixed_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort11Ascending(ref _iterationItems[i]);
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

	public class SN12SortSNBoseNelsonBenchmark : SNBenchmarkBase
	{
		[Params(12)]
		public override int Length { get; set; }

		[Benchmark]
		public void SN_Generic_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.SortAscending(ref _iterationItems[i], Length);
			}
		}

		[Benchmark]
		public void SN_Fixed_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort12Ascending(ref _iterationItems[i]);
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

	public class SN13SortSNBoseNelsonBenchmark : SNBenchmarkBase
	{
		[Params(13)]
		public override int Length { get; set; }

		[Benchmark]
		public void SN_Generic_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.SortAscending(ref _iterationItems[i], Length);
			}
		}

		[Benchmark]
		public void SN_Fixed_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort13Ascending(ref _iterationItems[i]);
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

	public class SN14SortSNBoseNelsonBenchmark : SNBenchmarkBase
	{
		[Params(14)]
		public override int Length { get; set; }

		[Benchmark]
		public void SN_Generic_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.SortAscending(ref _iterationItems[i], Length);
			}
		}

		[Benchmark]
		public void SN_Fixed_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort14Ascending(ref _iterationItems[i]);
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

	public class SN15SortSNBoseNelsonBenchmark : SNBenchmarkBase
	{
		[Params(15)]
		public override int Length { get; set; }

		[Benchmark]
		public void SN_Generic_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.SortAscending(ref _iterationItems[i], Length);
			}
		}

		[Benchmark]
		public void SN_Fixed_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort15Ascending(ref _iterationItems[i]);
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

	public class SN16SortSNBoseNelsonBenchmark : SNBenchmarkBase
	{
		[Params(16)]
		public override int Length { get; set; }

		[Benchmark]
		public void SN_Generic_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.SortAscending(ref _iterationItems[i], Length);
			}
		}

		[Benchmark]
		public void SN_Fixed_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort16Ascending(ref _iterationItems[i]);
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

	public class SN17SortSNBoseNelsonBenchmark : SNBenchmarkBase
	{
		[Params(17)]
		public override int Length { get; set; }

		[Benchmark]
		public void SN_Generic_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.SortAscending(ref _iterationItems[i], Length);
			}
		}

		[Benchmark]
		public void SN_Fixed_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort17Ascending(ref _iterationItems[i]);
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

	public class SN18SortSNBoseNelsonBenchmark : SNBenchmarkBase
	{
		[Params(18)]
		public override int Length { get; set; }

		[Benchmark]
		public void SN_Generic_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.SortAscending(ref _iterationItems[i], Length);
			}
		}

		[Benchmark]
		public void SN_Fixed_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort18Ascending(ref _iterationItems[i]);
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

	public class SN19SortSNBoseNelsonBenchmark : SNBenchmarkBase
	{
		[Params(19)]
		public override int Length { get; set; }

		[Benchmark]
		public void SN_Generic_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.SortAscending(ref _iterationItems[i], Length);
			}
		}

		[Benchmark]
		public void SN_Fixed_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort19Ascending(ref _iterationItems[i]);
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

	public class SN20SortSNBoseNelsonBenchmark : SNBenchmarkBase
	{
		[Params(20)]
		public override int Length { get; set; }

		[Benchmark]
		public void SN_Generic_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.SortAscending(ref _iterationItems[i], Length);
			}
		}

		[Benchmark]
		public void SN_Fixed_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort20Ascending(ref _iterationItems[i]);
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

	public class SN21SortSNBoseNelsonBenchmark : SNBenchmarkBase
	{
		[Params(21)]
		public override int Length { get; set; }

		[Benchmark]
		public void SN_Generic_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.SortAscending(ref _iterationItems[i], Length);
			}
		}

		[Benchmark]
		public void SN_Fixed_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort21Ascending(ref _iterationItems[i]);
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

	public class SN22SortSNBoseNelsonBenchmark : SNBenchmarkBase
	{
		[Params(22)]
		public override int Length { get; set; }

		[Benchmark]
		public void SN_Generic_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.SortAscending(ref _iterationItems[i], Length);
			}
		}

		[Benchmark]
		public void SN_Fixed_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort22Ascending(ref _iterationItems[i]);
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

	public class SN23SortSNBoseNelsonBenchmark : SNBenchmarkBase
	{
		[Params(23)]
		public override int Length { get; set; }

		[Benchmark]
		public void SN_Generic_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.SortAscending(ref _iterationItems[i], Length);
			}
		}

		[Benchmark]
		public void SN_Fixed_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort23Ascending(ref _iterationItems[i]);
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

	public class SN24SortSNBoseNelsonBenchmark : SNBenchmarkBase
	{
		[Params(24)]
		public override int Length { get; set; }

		[Benchmark]
		public void SN_Generic_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.SortAscending(ref _iterationItems[i], Length);
			}
		}

		[Benchmark]
		public void SN_Fixed_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort24Ascending(ref _iterationItems[i]);
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

	public class SN25SortSNBoseNelsonBenchmark : SNBenchmarkBase
	{
		[Params(25)]
		public override int Length { get; set; }

		[Benchmark]
		public void SN_Generic_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.SortAscending(ref _iterationItems[i], Length);
			}
		}

		[Benchmark]
		public void SN_Fixed_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort25Ascending(ref _iterationItems[i]);
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

	public class SN26SortSNBoseNelsonBenchmark : SNBenchmarkBase
	{
		[Params(26)]
		public override int Length { get; set; }

		[Benchmark]
		public void SN_Generic_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.SortAscending(ref _iterationItems[i], Length);
			}
		}

		[Benchmark]
		public void SN_Fixed_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort26Ascending(ref _iterationItems[i]);
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

	public class SN27SortSNBoseNelsonBenchmark : SNBenchmarkBase
	{
		[Params(27)]
		public override int Length { get; set; }

		[Benchmark]
		public void SN_Generic_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.SortAscending(ref _iterationItems[i], Length);
			}
		}

		[Benchmark]
		public void SN_Fixed_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort27Ascending(ref _iterationItems[i]);
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

	public class SN28SortSNBoseNelsonBenchmark : SNBenchmarkBase
	{
		[Params(28)]
		public override int Length { get; set; }

		[Benchmark]
		public void SN_Generic_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.SortAscending(ref _iterationItems[i], Length);
			}
		}

		[Benchmark]
		public void SN_Fixed_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort28Ascending(ref _iterationItems[i]);
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

	public class SN29SortSNBoseNelsonBenchmark : SNBenchmarkBase
	{
		[Params(29)]
		public override int Length { get; set; }

		[Benchmark]
		public void SN_Generic_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.SortAscending(ref _iterationItems[i], Length);
			}
		}

		[Benchmark]
		public void SN_Fixed_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort29Ascending(ref _iterationItems[i]);
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

	public class SN30SortSNBoseNelsonBenchmark : SNBenchmarkBase
	{
		[Params(30)]
		public override int Length { get; set; }

		[Benchmark]
		public void SN_Generic_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.SortAscending(ref _iterationItems[i], Length);
			}
		}

		[Benchmark]
		public void SN_Fixed_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort30Ascending(ref _iterationItems[i]);
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

	public class SN31SortSNBoseNelsonBenchmark : SNBenchmarkBase
	{
		[Params(31)]
		public override int Length { get; set; }

		[Benchmark]
		public void SN_Generic_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.SortAscending(ref _iterationItems[i], Length);
			}
		}

		[Benchmark]
		public void SN_Fixed_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort31Ascending(ref _iterationItems[i]);
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

	public class SN32SortSNBoseNelsonBenchmark : SNBenchmarkBase
	{
		[Params(32)]
		public override int Length { get; set; }

		[Benchmark]
		public void SN_Generic_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.SortAscending(ref _iterationItems[i], Length);
			}
		}

		[Benchmark]
		public void SN_Fixed_Comparable()
		{
			int maximumLength = _iterationItems.Length - Length;

			for (int i = 0; i < maximumLength; i += Length)
			{
				SNBoseNelson.Sort32Ascending(ref _iterationItems[i]);
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