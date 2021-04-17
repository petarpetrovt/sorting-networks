#### [SortingNetworks](index.md 'index')
### [SortingNetworks](SortingNetworks.md 'SortingNetworks').[SNBoseNelson](SortingNetworks_SNBoseNelson.md 'SortingNetworks.SNBoseNelson')
## SNBoseNelson.SortAscending&lt;T&gt;(T, int) Method
Sorts a collection of specified number of elements in ascending order using the [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic  
interface implementation of each element.  
```csharp
public static void SortAscending<T>(ref T p0, in int length)
    where T : System.IComparable<T>;
```
#### Type parameters
<a name='SortingNetworks_SNBoseNelson_SortAscending_T_(T_int)_T'></a>
`T`  
The type of the elements of the collection.
  
#### Parameters
<a name='SortingNetworks_SNBoseNelson_SortAscending_T_(T_int)_p0'></a>
`p0` [T](SortingNetworks_SNBoseNelson_SortAscending_T_(T_int).md#SortingNetworks_SNBoseNelson_SortAscending_T_(T_int)_T 'SortingNetworks.SNBoseNelson.SortAscending&lt;T&gt;(T, int).T')  
the reference to the first element of the collection
  
<a name='SortingNetworks_SNBoseNelson_SortAscending_T_(T_int)_length'></a>
`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
the length of the collection
  
#### Exceptions
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
collection length is not between [MinLength](SortingNetworks_SNBoseNelson_MinLength.md 'SortingNetworks.SNBoseNelson.MinLength') and [MaxLength](SortingNetworks_SNBoseNelson_MaxLength.md 'SortingNetworks.SNBoseNelson.MaxLength')
