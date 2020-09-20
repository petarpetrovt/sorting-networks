namespace SortingNetworks
{
	using System;
	using System.Diagnostics;
	using System.Diagnostics.CodeAnalysis;
	using System.Runtime.CompilerServices;

	[DebuggerStepThrough]
	internal static class Assert
	{
		private const string AssertConditionName = "DEBUG";

		[Conditional(AssertConditionName)]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void NotNull([AllowNull] object argument, string argumentName)
		{
			if (argument is null)
			{
				throw new ArgumentNullException(argumentName);
			}
		}
	}
}
