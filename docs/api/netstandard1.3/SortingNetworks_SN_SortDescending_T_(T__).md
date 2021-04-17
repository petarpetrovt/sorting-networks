#### [SortingNetworks](index.md 'index')
### [SortingNetworks](SortingNetworks.md 'SortingNetworks').[SN](SortingNetworks_SN.md 'SortingNetworks.SN')
## SN.SortDescending&lt;T&gt;(T[]) Method
Sorts the elements in an entire [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') in descending order using the [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic  
interface implementation of each element of the [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array').  
```csharp
public static void SortDescending<T>(T[] array)
    where T : System.IComparable<T>;
```
#### Type parameters
<a name='SortingNetworks_SN_SortDescending_T_(T__)_T'></a>
`T`  
The type of the elements of the array.
  
#### Parameters
<a name='SortingNetworks_SN_SortDescending_T_(T__)_array'></a>
`array` [T](SortingNetworks_SN_SortDescending_T_(T__).md#SortingNetworks_SN_SortDescending_T_(T__)_T 'SortingNetworks.SN.SortDescending&lt;T&gt;(T[]).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The one-dimensional, zero-based [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') to sort.
  
#### Exceptions
[System.ArgumentNullException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentNullException 'System.ArgumentNullException')  
array is null
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
array length is not between [MinLength](SortingNetworks_SN_MinLength.md 'SortingNetworks.SN.MinLength') and [MaxLength](SortingNetworks_SN_MaxLength.md 'SortingNetworks.SN.MaxLength')
