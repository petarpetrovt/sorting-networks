namespace SortingNetworks.Tests
{
	using System;

	internal static class ThreadSafeRandom
	{
		private readonly static Random _global = new Random();

		[ThreadStatic]
		private static Random _local;

		public static int Next()
		{
			lock (_global)
			{
				if (_local is null)
				{
					_local = new Random(_global.Next());
				}
			}

			return _local.Next();
		}

		public static int Next(int minValue, int maxValue)
		{
			lock (_global)
			{
				if (_local is null)
				{
					_local = new Random(_global.Next());
				}
			}

			return _local.Next(minValue, maxValue);
		}
	}
}
