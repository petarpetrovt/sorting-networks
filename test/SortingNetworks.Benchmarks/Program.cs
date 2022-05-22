namespace SortingNetworks.Benchmarks;

using System.Reflection;
using BenchmarkDotNet.Running;

public static class Program
{
	public static void Main(string[] args)
		=> BenchmarkRunner.Run(Assembly.GetExecutingAssembly(), args: args);
}