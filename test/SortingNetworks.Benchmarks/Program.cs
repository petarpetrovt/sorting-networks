// issue - https://github.com/dotnet/roslyn-analyzers/issues/6141
#pragma warning disable CA1852

using System.Reflection;
using BenchmarkDotNet.Running;

BenchmarkRunner.Run(Assembly.GetExecutingAssembly(), args: args);