namespace SortingNetworks.Benchmarks
{
	using System;
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
		private static int[] _globalItems = new int[110_000_000];

		static SNBenchmarkBase()
		{
			var random = new Random(new Random().Next());
			for (int i = 0; i < _globalItems.Length; i++)
			{
				_globalItems[i] = random.Next(int.MinValue, int.MaxValue);
			}
		}

		protected readonly int[] IterationItems = new int[110_000_000];

		public abstract int Length { get; set; }

		/// <summary>
		/// Gets the count of the iteration items depending on the length of the sorting network.
		/// </summary>
		/// <remarks>
		/// The values are adjusted so that the lowest benchmark of N length will run at least 100 ms per iteration.
		/// </remarks>
		public int Count
			=> Length switch
			{
				02 => 110_000_000,
				03 => 110_000_000,
				04 => 110_000_000,
				05 => 90_000_000,
				06 => 85_000_000,
				07 => 85_000_000,
				08 => 55_000_000,
				09 => 50_000_000,
				10 => 45_000_000,
				11 => 43_000_000,
				12 => 36_000_000,
				13 => 35_000_000,
				14 => 22_000_000,
				15 => 21_000_000,
				16 => 21_000_000,
				17 => 13_000_000,
				18 => 12_000_000,
				19 => 12_000_000,
				20 => 11_000_000,
				21 => 11_000_000,
				22 => 10_000_000,
				23 => 10_000_000,
				24 => 10_000_000,
				25 => 10_000_000,
				26 => 09_000_000,
				27 => 09_000_000,
				28 => 09_000_000,
				29 => 09_000_000,
				30 => 09_000_000,
				31 => 09_000_000,
				32 => 09_000_000,
				_ => -1,
			};

		[IterationSetup]
		public void IterationSetup()
			=> _globalItems.AsSpan(0, Count).CopyTo(IterationItems);

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
