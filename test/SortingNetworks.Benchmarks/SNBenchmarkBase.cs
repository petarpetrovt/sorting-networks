namespace SortingNetworks.Benchmarks;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;

[SimpleJob(RuntimeMoniker.Net50, baseline: true)]
[SimpleJob(RuntimeMoniker.Net60)]
[SimpleJob(RuntimeMoniker.CoreRt60)]
[MemoryDiagnoser]
public abstract class SNBenchmarkBase
{
	private int[] _globalItems;

	protected int[] IterationItems;

	/// <summary>
	/// Gets or sets the length of the sorting network.
	/// </summary>
	public abstract int Length { get; set; }

	/// <summary>
	/// Gets the count of the iteration items depending on the length of the sorting network.
	/// </summary>
	/// <remarks>
	/// The values are adjusted in `TemplateUtilities.ttinclude -> GetOptimalBenchmarkCount` so that
	/// the lowest benchmark of N length will run at least 100 ms per iteration.
	/// </remarks>
	public abstract int Count { get; set; }

	[GlobalSetup]
	public void GlobalSetup()
	{
		_globalItems = new int[110_000_000];
		IterationItems = new int[110_000_000];

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
		IterationItems = null;
	}

	[IterationSetup]
	public void IterationSetup()
		=> _globalItems
			.AsSpan(0, Count)
			.CopyTo(IterationItems);

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
