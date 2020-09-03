namespace ConsoleApp7
{
	using System;

	public class Sortable : ISortable
	{
		private readonly uint _count;

		public ref readonly uint Count
			=> ref _count;

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
