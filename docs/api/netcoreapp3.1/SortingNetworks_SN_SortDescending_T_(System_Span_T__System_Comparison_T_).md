#### [SortingNetworks](index.md 'index')
### [SortingNetworks](SortingNetworks.md 'SortingNetworks').[SN](SortingNetworks_SN.md 'SortingNetworks.SN')
## SN.SortDescending&lt;T&gt;(Span&lt;T&gt;, Comparison&lt;T&gt;) Method
Sorts the elements in an [System.Span&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1') in descending order using the specified [System.Comparison&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1').  
```csharp
public static void SortDescending<T>(System.Span<T> buffer, System.Comparison<T> comparison);
```
#### Type parameters
<a name='SortingNetworks_SN_SortDescending_T_(System_Span_T__System_Comparison_T_)_T'></a>
`T`  
The type of the elements of the span.
  
#### Parameters
<a name='SortingNetworks_SN_SortDescending_T_(System_Span_T__System_Comparison_T_)_buffer'></a>
`buffer` [System.Span&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1')[T](SortingNetworks_SN_SortDescending_T_(System_Span_T__System_Comparison_T_).md#SortingNetworks_SN_SortDescending_T_(System_Span_T__System_Comparison_T_)_T 'SortingNetworks.SN.SortDescending&lt;T&gt;(System.Span&lt;T&gt;, System.Comparison&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1')  
The one-dimensional, zero-based [System.Span&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1') to sort.
  
<a name='SortingNetworks_SN_SortDescending_T_(System_Span_T__System_Comparison_T_)_comparison'></a>
`comparison` [System.Comparison&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1')[T](SortingNetworks_SN_SortDescending_T_(System_Span_T__System_Comparison_T_).md#SortingNetworks_SN_SortDescending_T_(System_Span_T__System_Comparison_T_)_T 'SortingNetworks.SN.SortDescending&lt;T&gt;(System.Span&lt;T&gt;, System.Comparison&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1')  
The [System.Comparison&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1') to use when comparing elements.
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
comparison is null
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
span length is not between [MinLength](SortingNetworks_SN_MinLength.md 'SortingNetworks.SN.MinLength') and [MaxLength](SortingNetworks_SN_MaxLength.md 'SortingNetworks.SN.MaxLength')
