### [SortingNetworks](SortingNetworks.md 'SortingNetworks').[SNBestKnown](SortingNetworks.SNBestKnown.md 'SortingNetworks.SNBestKnown')

## SNBestKnown.SortAscending<T>(T, int, Comparison<T>) Method

Sorts a collection of specified number of elements in ascending order using the specified [System.Comparison&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1').

```csharp
public static void SortAscending<T>(ref T p0, in int length, System.Comparison<T> comparison)
    where T : System.IComparable<T>;
```
#### Type parameters

<a name='SortingNetworks.SNBestKnown.SortAscending_T_(T,int,System.Comparison_T_).T'></a>

`T`

The type of the elements of the collection.
#### Parameters

<a name='SortingNetworks.SNBestKnown.SortAscending_T_(T,int,System.Comparison_T_).p0'></a>

`p0` [T](SortingNetworks.SNBestKnown.SortAscending_T_(T,int,System.Comparison_T_).md#SortingNetworks.SNBestKnown.SortAscending_T_(T,int,System.Comparison_T_).T 'SortingNetworks.SNBestKnown.SortAscending<T>(T, int, System.Comparison<T>).T')

the reference to the first element of the collection

<a name='SortingNetworks.SNBestKnown.SortAscending_T_(T,int,System.Comparison_T_).length'></a>

`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the length of the collection

<a name='SortingNetworks.SNBestKnown.SortAscending_T_(T,int,System.Comparison_T_).comparison'></a>

`comparison` [System.Comparison&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1')[T](SortingNetworks.SNBestKnown.SortAscending_T_(T,int,System.Comparison_T_).md#SortingNetworks.SNBestKnown.SortAscending_T_(T,int,System.Comparison_T_).T 'SortingNetworks.SNBestKnown.SortAscending<T>(T, int, System.Comparison<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1')

The [System.Comparison&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1') to use when comparing elements.

#### Exceptions

[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
collection length is not between [MinLength](SortingNetworks.SNBestKnown.MinLength.md 'SortingNetworks.SNBestKnown.MinLength') and [MaxLength](SortingNetworks.SNBestKnown.MaxLength.md 'SortingNetworks.SNBestKnown.MaxLength')