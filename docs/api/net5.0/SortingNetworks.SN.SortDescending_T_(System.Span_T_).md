### [SortingNetworks](SortingNetworks.md 'SortingNetworks').[SN](SortingNetworks.SN.md 'SortingNetworks.SN')

## SN.SortDescending<T>(Span<T>) Method

Sorts the elements in an entire [System.Span&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1') in descending order using the [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic  
interface implementation of each element of the [System.Span&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1').

```csharp
public static void SortDescending<T>(System.Span<T> buffer)
    where T : System.IComparable<T>;
```
#### Type parameters

<a name='SortingNetworks.SN.SortDescending_T_(System.Span_T_).T'></a>

`T`

The type of the elements of the span.
#### Parameters

<a name='SortingNetworks.SN.SortDescending_T_(System.Span_T_).buffer'></a>

`buffer` [System.Span&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1')[T](SortingNetworks.SN.SortDescending_T_(System.Span_T_).md#SortingNetworks.SN.SortDescending_T_(System.Span_T_).T 'SortingNetworks.SN.SortDescending<T>(System.Span<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1')

The one-dimensional, zero-based [System.Span&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1') to sort.

#### Exceptions

[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
span length is not between [MinLength](SortingNetworks.SN.MinLength.md 'SortingNetworks.SN.MinLength') and [MaxLength](SortingNetworks.SN.MaxLength.md 'SortingNetworks.SN.MaxLength')