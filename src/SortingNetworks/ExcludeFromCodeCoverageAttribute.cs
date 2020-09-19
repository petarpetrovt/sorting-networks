#if NETSTANDARD1_3
namespace System.Diagnostics.CodeAnalysis
{
	/// <exclude/>
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Event, Inherited = false, AllowMultiple = false)]
	internal sealed class ExcludeFromCodeCoverageAttribute : Attribute
	{
		/// <summary>
		/// Gets or sets the justification for excluding the member from code coverage.
		/// </summary>
		public string? Justification { get; set; }
	}
}
#endif