namespace ConsoleApp7
{
	using System;
	using System.Runtime.CompilerServices;
	using System.Runtime.InteropServices;
	using System.Threading.Tasks;
	using BenchmarkDotNet.Attributes;

	[MemoryDiagnoser,
		DisassemblyDiagnoser(exportHtml: true, printInstructionAddresses: true, exportCombinedDisassemblyReport: true, exportDiff: true),
		HtmlExporter]
	public class ArrayBenchmark
	{
		[Params(512, 4096, 32768, 262144)]
		public int N;

		[Benchmark]
		public void ArrayFillMax()
		{
			var array = new uint[N];

			Array.Fill(array, uint.MaxValue);
		}

		[Benchmark]
		public void ArrayFillMaxParallel()
		{
			var array = new uint[N];

			Parallel.For(0, N, i => array[i] = uint.MaxValue);
		}

		[Benchmark]
		public void ArrayFillMaxBlockCopy()
		{
			var array = new uint[N];

			FillUsingBlockCopy(array, uint.MaxValue);
		}

		[Benchmark]
		public unsafe void ArrayFillMaxInitBlock()
		{
			var array = new uint[N];

			Unsafe.InitBlock(Unsafe.AsPointer(ref array[0]), 255, (uint)(array.Length * sizeof(uint)));
		}

		[Benchmark]
		public unsafe void ArrayFillMaxInitBlockUnaligned()
		{
			var array = new uint[N];

			Unsafe.InitBlockUnaligned(Unsafe.AsPointer(ref array[0]), 255, (uint)(array.Length * sizeof(uint)));
		}

		[Benchmark]
		public void SpanFillMax()
		{
			var array = new uint[N];

			var span = new Span<uint>(array);

			span.Fill(uint.MaxValue);
		}

		[Benchmark]
		public void SpanFillMaxBytes()
		{
			var array = new uint[N];

			var span = new Span<uint>(array);

			MemoryMarshal.AsBytes(span).Fill(255);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static void FillUsingBlockCopy<T>(T[] array, T value) where T : struct
		{
			int numBytesInItem = sizeof(uint);
			int block = 32;
			int index = 0;
			int endIndex = Math.Min(block, array.Length);

			while (index < endIndex)
			{
				array[index++] = value;
			}

			endIndex = array.Length;
			for (; index < endIndex; index += block, block *= 2)
			{
				int actualBlockSize = Math.Min(block, endIndex - index);
				Buffer.BlockCopy(array, 0, array, index * numBytesInItem, actualBlockSize * numBytesInItem);
			}
		}
	}
}
