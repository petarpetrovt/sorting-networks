### [SortingNetworks](SortingNetworks.md 'SortingNetworks').[SN](SortingNetworks.SN.md 'SortingNetworks.SN')

## SN.SortAscending<T>(Span<T>, Comparison<T>) Method

Sorts the elements in an [System.Span&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1') in ascending order using the specified [System.Comparison&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1').

```csharp
public static void SortAscending<T>(System.Span<T> buffer, System.Comparison<T> comparison);
```
#### Type parameters

<a name='SortingNetworks.SN.SortAscending_T_(System.Span_T_,System.Comparison_T_).T'></a>

`T`

The type of the elements of the span.
#### Parameters

<a name='SortingNetworks.SN.SortAscending_T_(System.Span_T_,System.Comparison_T_).buffer'></a>

`buffer` [System.Span&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1')[T](SortingNetworks.SN.SortAscending_T_(System.Span_T_,System.Comparison_T_).md#SortingNetworks.SN.SortAscending_T_(System.Span_T_,System.Comparison_T_).T 'SortingNetworks.SN.SortAscending<T>(System.Span<T>, System.Comparison<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1')

The one-dimensional, zero-based [System.Span&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1') to sort.

<a name='SortingNetworks.SN.SortAscending_T_(System.Span_T_,System.Comparison_T_).comparison'></a>

`comparison` [System.Comparison&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1')[T](SortingNetworks.SN.SortAscending_T_(System.Span_T_,System.Comparison_T_).md#SortingNetworks.SN.SortAscending_T_(System.Span_T_,System.Comparison_T_).T 'SortingNetworks.SN.SortAscending<T>(System.Span<T>, System.Comparison<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1')

The [System.Comparison&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1') to use when comparing elements.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
comparison is null

[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
span length is not between [MinLength](SortingNetworks.SN.MinLength.md 'SortingNetworks.SN.MinLength') and [MaxLength](SortingNetworks.SN.MaxLength.md 'SortingNetworks.SN.MaxLength')