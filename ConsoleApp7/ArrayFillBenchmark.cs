namespace ConsoleApp7
{
	using System;
	using System.Runtime.CompilerServices;
	using BenchmarkDotNet.Attributes;

	[MemoryDiagnoser,
		DisassemblyDiagnoser(exportHtml: true, printInstructionAddresses: true, exportCombinedDisassemblyReport: true, exportDiff: true),
		HtmlExporter]
	public class ArrayFillBenchmark
	{
		private uint _denseLength = 0;
		private uint[] _denseHandles = new uint[10];
		private TestValue[] _denseValues = new TestValue[10];

		[Benchmark(OperationsPerInvoke = 10000)]
		public void TestGetDense()
		{
			for (int i = 0; i < 100; i++)
			{
				ref TestValue value = ref GetDense(1, default, out uint denseIndex);
			}
		}

		[Benchmark(OperationsPerInvoke = 10000)]
		public void TestGetDenseInlined()
		{
			for (int i = 0; i < 100; i++)
			{
				uint denseIndex = GetDenseInlined(1, default);

				ref TestValue value = ref _denseValues[denseIndex];
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private ref TestValue GetDense(in uint handle, in TestValue component, out uint denseIndex)
		{
			denseIndex = _denseLength + 1;

			if (denseIndex >= _denseHandles.Length)
			{
				// TODO: resize strategy
				Array.Resize(ref _denseHandles, _denseHandles.Length * 2);
				Array.Resize(ref _denseValues, _denseValues.Length * 2);
			}

			_denseHandles[denseIndex] = handle;
			_denseValues[denseIndex] = component;

			return ref _denseValues[denseIndex];
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private uint GetDenseInlined(in uint handle, in TestValue component)
		{
			uint denseIndex = _denseLength + 1;

			if (denseIndex >= _denseHandles.Length)
			{
				// TODO: resize strategy
				Array.Resize(ref _denseHandles, _denseHandles.Length * 2);
				Array.Resize(ref _denseValues, _denseValues.Length * 2);
			}

			_denseHandles[denseIndex] = handle;
			_denseValues[denseIndex] = component;

			return denseIndex;
		}

		public struct TestValue
		{
			public int x;
		}
	}
}
