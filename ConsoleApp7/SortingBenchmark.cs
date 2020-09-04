namespace ConsoleApp7
{
	using System;
	using System.Diagnostics.CodeAnalysis;
	using System.Runtime.CompilerServices;
	using BenchmarkDotNet.Attributes;

	[HtmlExporter]
	[MemoryDiagnoser]
	[DisassemblyDiagnoser(exportHtml: true, printInstructionAddresses: true, exportCombinedDisassemblyReport: true, exportDiff: true)]
	public class SortingBenchmark
	{
		private const int N = 1_000_000;
		private Sortable[] sortables;

		[Params(2, 3, 4, 5, 6, 7, 8)]
		public int Size;

		[IterationSetup]
		public void Setup()
		{
			sortables = new Sortable[N * Size];

			for (int i = 0; i < N * Size; i++)
			{
				sortables[i] = new Sortable(i);
			}
		}

		[Benchmark]
		public void InsertionSort()
		{
			for (int i = 0; i < N; i += Size)
			{
				InsertionSort(sortables.AsSpan(i, Size));
			}
		}

		[Benchmark]
		public void SortingNetworkGeneric()
		{
			for (int i = 0; i < N; i += Size)
			{
				ref Sortable p0 = ref Unsafe.Add(ref sortables[0], i);

				SA.Sort(ref p0, Size);
			}
		}

		private static void InsertionSort<T>(Span<T> input)
			where T : IComparable<T>
		{
			for (int i = 0; i < input.Length - 1; i++)
			{
				for (int j = i + 1; j > 0; j--)
				{
					if (input[j - 1].CompareTo(input[j]) > 0)
					{
						ref T temp = ref input[j - 1];
						input[j - 1] = input[j];
						input[j] = temp;
					}
				}
			}
		}

		#region Nested type: Sortable

		public sealed class Sortable : IComparable<Sortable>
		{
			private readonly int _value;

			public Sortable(int value)
			{
				_value = value;
			}

			#region IComparable<Sortable> Members

			public int CompareTo([AllowNull] Sortable other)
				=> _value.CompareTo(other?._value);

			#endregion
		}

		#endregion
	}
}
