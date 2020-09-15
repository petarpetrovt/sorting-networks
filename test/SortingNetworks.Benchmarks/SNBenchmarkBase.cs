namespace SortingNetworks.Benchmarks
{
	using System;
	using System.Runtime.CompilerServices;
	using BenchmarkDotNet.Attributes;
	using BenchmarkDotNet.Jobs;

	[SimpleJob(RuntimeMoniker.Net48)]
	[SimpleJob(RuntimeMoniker.NetCoreApp31)]
	[MemoryDiagnoser]
	public abstract class SNBenchmarkBase
	{
		private const int N = 100_000_000;

		private int[] _globalItems;
		protected int[] _iterationItems;

		[GlobalSetup]
		public void GlobalSetup()
		{
			_globalItems = new int[N];

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
			_iterationItems = new int[N];
			_globalItems.AsSpan().CopyTo(_iterationItems);
		}

		[IterationCleanup]
		public void IterationCleanup()
		{
			_iterationItems = null;
			GC.Collect();
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		protected static int InternalComparison(int a, int b)
			=> a.CompareTo(b);
	}
}
