namespace SortingNetworks
{
	using System;
	using System.Diagnostics;
	using System.Diagnostics.CodeAnalysis;
	using System.Runtime.CompilerServices;

#if NETSTANDARD1_3
	[DebuggerNonUserCode]
#else
	[ExcludeFromCodeCoverage]
#endif
	[DebuggerStepThrough]
	internal static class ThrowHelper
	{
		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ArgumentNull(string argumentName)
		{
			if (argumentName is null)
			{
				throw new ArgumentNullException(nameof(argumentName));
			}

			throw new ArgumentNullException(argumentName);
		}

		[DoesNotReturn]
		[MethodImpl(MethodImplOptions.NoInlining)]
		public static void ArrayArgumentOutOfRange(string paramName, int length, int minLength, int maxLenggth)
		{
			if (paramName is null)
			{
				throw new ArgumentNullException(nameof(paramName));
			}

			throw new ArgumentOutOfRangeException(paramName, $"Array length `{length}` must be between `{minLength}` and `{maxLenggth}`.");
		}
	}
}
