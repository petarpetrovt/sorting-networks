### [SortingNetworks](SortingNetworks.md 'SortingNetworks').[SN](SortingNetworks.SN.md 'SortingNetworks.SN')

## SN.SortDescending<T>(T[], Comparison<T>) Method

Sorts the elements in an [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') in descending order using the specified [System.Comparison&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1').

```csharp
public static void SortDescending<T>(T[] array, System.Comparison<T> comparison);
```
#### Type parameters

<a name='SortingNetworks.SN.SortDescending_T_(T[],System.Comparison_T_).T'></a>

`T`

The type of the elements of the array.
#### Parameters

<a name='SortingNetworks.SN.SortDescending_T_(T[],System.Comparison_T_).array'></a>

`array` [T](SortingNetworks.SN.SortDescending_T_(T[],System.Comparison_T_).md#SortingNetworks.SN.SortDescending_T_(T[],System.Comparison_T_).T 'SortingNetworks.SN.SortDescending<T>(T[], System.Comparison<T>).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The one-dimensional, zero-based [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') to sort.

<a name='SortingNetworks.SN.SortDescending_T_(T[],System.Comparison_T_).comparison'></a>

`comparison` [System.Comparison&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1')[T](SortingNetworks.SN.SortDescending_T_(T[],System.Comparison_T_).md#SortingNetworks.SN.SortDescending_T_(T[],System.Comparison_T_).T 'SortingNetworks.SN.SortDescending<T>(T[], System.Comparison<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1')

The [System.Comparison&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1') to use when comparing elements.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
array is null

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
comparison is null

[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
array length is not between [MinLength](SortingNetworks.SN.MinLength.md 'SortingNetworks.SN.MinLength') and [MaxLength](SortingNetworks.SN.MaxLength.md 'SortingNetworks.SN.MaxLength')