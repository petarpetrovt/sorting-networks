### [SortingNetworks](SortingNetworks.md 'SortingNetworks').[SN](SortingNetworks.SN.md 'SortingNetworks.SN')

## SN.SortAscending<T>(T[]) Method

Sorts the elements in an entire [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') in ascending order using the [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic  
interface implementation of each element of the [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array').

```csharp
public static void SortAscending<T>(T[] array)
    where T : System.IComparable<T>;
```
#### Type parameters

<a name='SortingNetworks.SN.SortAscending_T_(T[]).T'></a>

`T`

The type of the elements of the array.
#### Parameters

<a name='SortingNetworks.SN.SortAscending_T_(T[]).array'></a>

`array` [T](SortingNetworks.SN.SortAscending_T_(T[]).md#SortingNetworks.SN.SortAscending_T_(T[]).T 'SortingNetworks.SN.SortAscending<T>(T[]).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The one-dimensional, zero-based [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') to sort.

#### Exceptions

[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
array is null

[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
array length is not between [MinLength](SortingNetworks.SN.MinLength.md 'SortingNetworks.SN.MinLength') and [MaxLength](SortingNetworks.SN.MaxLength.md 'SortingNetworks.SN.MaxLength')