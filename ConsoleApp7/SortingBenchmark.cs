namespace ConsoleApp7
{
	using System;
	using System.Diagnostics.CodeAnalysis;
	using System.Runtime.CompilerServices;
	using BenchmarkDotNet.Attributes;
	using BenchmarkDotNet.Jobs;

	[SimpleJob(RuntimeMoniker.NetCoreApp31)]
	[SimpleJob(RuntimeMoniker.NetCoreApp50)]
	[HtmlExporter]
	[MemoryDiagnoser]
	[DisassemblyDiagnoser(exportHtml: true, printInstructionAddresses: true, exportCombinedDisassemblyReport: true, exportDiff: true)]
	public class SortingBenchmark
	{
		private const int N = 1_000_000;
		private Sortable[] sortables;

		[IterationSetup]
		public void Setup()
		{
			sortables = new Sortable[N * 10];

			for (int i = 0; i < N * 10; i++)
			{
				sortables[i] = new Sortable(i);
			}
		}

		[Benchmark]
		public void SA8()
		{
			for (int i = 0; i < N; i += 8)
			{
				ref Sortable p0 = ref Unsafe.Add(ref sortables[0], i);

				SA.Sort8(ref p0);
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
