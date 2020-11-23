namespace SortingNetworks.Benchmarks
{
	using System;
	using System.Buffers;
	using System.Runtime.CompilerServices;
	using BenchmarkDotNet.Attributes;
	using BenchmarkDotNet.Jobs;

	[SimpleJob(RuntimeMoniker.Net48)]
	[SimpleJob(RuntimeMoniker.NetCoreApp31)]
	[SimpleJob(RuntimeMoniker.NetCoreApp50)]
	[SimpleJob(RuntimeMoniker.CoreRt31)]
	[MemoryDiagnoser]
	public abstract class SNBenchmarkBase
	{
		private int[] _globalItems;

		protected int[] _iterationItems;

		public abstract int Length { get; set; }

		public int Count
			=> Length switch
			{
				int length when length <= 04 => 110_000_000,
				int length when length <= 07 => 90_000_000,
				int length when length <= 13 => 35_000_000,
				int length when length <= 16 => 21_000_000,
				int length when length <= 20 => 13_000_000,
				int length when length <= 26 => 11_000_000,
				int length when length <= 32 => 09_000_000,
				_ => -1,
			};

		[GlobalSetup]
		public void GlobalSetup()
		{
			_globalItems = new int[Count];

			var random = new Random(new Random().Next());
			for (int i = 0; i < _globalItems.Length; i++)
			{
				_globalItems[i] = random.Next(int.MinValue, int.MaxValue);
			}
		}

		[GlobalCleanup]
		public void GlobalCleanup()
		{
			_globalItems = null;
			GC.Collect();
		}

		[IterationSetup]
		public void IterationSetup()
		{
			_iterationItems = ArrayPool<int>.Shared.Rent(Count);
			_globalItems.AsSpan().CopyTo(_iterationItems);
		}

		[IterationCleanup]
		public void IterationCleanup()
		{
			ArrayPool<int>.Shared.Return(_iterationItems);
			_iterationItems = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void PrivateInsertionSortAscending<T>(Span<T> span)
			where T : IComparable<T>
		{
			int length = span.Length;

			for (int i = 1; i < length; ++i)
			{
				T key = span[i];
				int j = i - 1;

				while (j >= 0 && span[j].CompareTo(key) > 0)
				{
					span[j + 1] = span[j];
					j -= 1;
				}

				span[j + 1] = key;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		protected static void PrivateInsertionSortDescending<T>(Span<T> span)
			where T : IComparable<T>
		{
			int length = span.Length;

			for (int i = 1; i < length; ++i)
			{
				T key = span[i];
				int j = i - 1;

				while (j >= 0 && span[j].CompareTo(key) < 0)
				{
					span[j + 1] = span[j];
					j -= 1;
				}

				span[j + 1] = key;
			}
		}
	}
}
