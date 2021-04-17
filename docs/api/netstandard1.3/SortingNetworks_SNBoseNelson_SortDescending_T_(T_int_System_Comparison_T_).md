#### [SortingNetworks](index.md 'index')
### [SortingNetworks](SortingNetworks.md 'SortingNetworks').[SNBoseNelson](SortingNetworks_SNBoseNelson.md 'SortingNetworks.SNBoseNelson')
## SNBoseNelson.SortDescending&lt;T&gt;(T, int, Comparison&lt;T&gt;) Method
Sorts a collection of specified number of elements in descending order using the specified [System.Comparison&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1').  
```csharp
public static void SortDescending<T>(ref T p0, in int length, System.Comparison<T> comparison)
    where T : System.IComparable<T>;
```
#### Type parameters
<a name='SortingNetworks_SNBoseNelson_SortDescending_T_(T_int_System_Comparison_T_)_T'></a>
`T`  
The type of the elements of the collection.
  
#### Parameters
<a name='SortingNetworks_SNBoseNelson_SortDescending_T_(T_int_System_Comparison_T_)_p0'></a>
`p0` [T](SortingNetworks_SNBoseNelson_SortDescending_T_(T_int_System_Comparison_T_).md#SortingNetworks_SNBoseNelson_SortDescending_T_(T_int_System_Comparison_T_)_T 'SortingNetworks.SNBoseNelson.SortDescending&lt;T&gt;(T, int, System.Comparison&lt;T&gt;).T')  
the reference to the first element of the collection
  
<a name='SortingNetworks_SNBoseNelson_SortDescending_T_(T_int_System_Comparison_T_)_length'></a>
`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
the length of the collection
  
<a name='SortingNetworks_SNBoseNelson_SortDescending_T_(T_int_System_Comparison_T_)_comparison'></a>
`comparison` [System.Comparison&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1')[T](SortingNetworks_SNBoseNelson_SortDescending_T_(T_int_System_Comparison_T_).md#SortingNetworks_SNBoseNelson_SortDescending_T_(T_int_System_Comparison_T_)_T 'SortingNetworks.SNBoseNelson.SortDescending&lt;T&gt;(T, int, System.Comparison&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1')  
The [System.Comparison&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1') to use when comparing elements.
  
#### Exceptions
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
collection length is not between [MinLength](SortingNetworks_SNBoseNelson_MinLength.md 'SortingNetworks.SNBoseNelson.MinLength') and [MaxLength](SortingNetworks_SNBoseNelson_MaxLength.md 'SortingNetworks.SNBoseNelson.MaxLength')
