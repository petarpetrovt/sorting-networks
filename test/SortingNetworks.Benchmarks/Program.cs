﻿namespace SortingNetworks.Benchmarks
{
	using System.Reflection;
	using BenchmarkDotNet.Running;

	public class Program
	{
		public static void Main(string[] args)
			=> BenchmarkSwitcher
				.FromAssembly(Assembly.GetExecutingAssembly())
				.Run(args);
	}
}
