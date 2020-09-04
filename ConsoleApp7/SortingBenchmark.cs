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
		public void SA2()
		{
			for (int i = 0; i < N; i += 2)
			{
				ref Sortable p0 = ref Unsafe.Add(ref sortables[0], i);

				SA.Sort2(ref p0);
			}
		}

		[Benchmark]
		public void SA3()
		{
			for (int i = 0; i < N; i += 3)
			{
				ref Sortable p0 = ref Unsafe.Add(ref sortables[0], i);

				SA.Sort3(ref p0);
			}
		}

		[Benchmark]
		public void SA4()
		{
			for (int i = 0; i < N; i += 4)
			{
				ref Sortable p0 = ref Unsafe.Add(ref sortables[0], i);

				SA.Sort4(ref p0);
			}
		}

		[Benchmark]
		public void SA5()
		{
			for (int i = 0; i < N; i += 5)
			{
				ref Sortable p0 = ref Unsafe.Add(ref sortables[0], i);

				SA.Sort5(ref p0);
			}
		}

		[Benchmark]
		public void SA6()
		{
			for (int i = 0; i < N; i += 6)
			{
				ref Sortable p0 = ref Unsafe.Add(ref sortables[0], i);

				SA.Sort6(ref p0);
			}
		}

		[Benchmark]
		public void SA7()
		{
			for (int i = 0; i < N; i += 7)
			{
				ref Sortable p0 = ref Unsafe.Add(ref sortables[0], i);

				SA.Sort7(ref p0);
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
