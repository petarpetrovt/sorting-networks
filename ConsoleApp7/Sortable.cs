namespace ConsoleApp7
{
	using System;
	using System.Runtime.CompilerServices;

	public class Sortable : ISortable
	{
		private readonly uint _count;

		public ref readonly uint Count
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get => ref _count;
		}

		public Sortable()
		{
			_count = (uint)new Random().Next(0, int.MaxValue / 2);
		}

		public Sortable(uint count)
		{
			_count = count;
		}
	}
}
