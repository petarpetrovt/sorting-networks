### [SortingNetworks](./SortingNetworks.md 'SortingNetworks').[SNBoseNelson](./SortingNetworks-SNBoseNelson.md 'SortingNetworks.SNBoseNelson')
## SNBoseNelson.SortAscending&lt;T&gt;(T, int, System.Comparison&lt;T&gt;) Method
Sorts a collection of specified number of elements in ascending order using the specified [System.Comparison&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1').  
```csharp
public static void SortAscending<T>(ref T p0, in int length, System.Comparison<T> comparison);
```
#### Type parameters
<a name='SortingNetworks-SNBoseNelson-SortAscending-T-(T_int_System-Comparison-T-)-T'></a>
`T`  
The type of the elements of the collection.  
  
#### Parameters
<a name='SortingNetworks-SNBoseNelson-SortAscending-T-(T_int_System-Comparison-T-)-p0'></a>
`p0` [T](#SortingNetworks-SNBoseNelson-SortAscending-T-(T_int_System-Comparison-T-)-T 'SortingNetworks.SNBoseNelson.SortAscending&lt;T&gt;(T, int, System.Comparison&lt;T&gt;).T')  
the reference to the first element of the collection  
  
<a name='SortingNetworks-SNBoseNelson-SortAscending-T-(T_int_System-Comparison-T-)-length'></a>
`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
the length of the collection  
  
<a name='SortingNetworks-SNBoseNelson-SortAscending-T-(T_int_System-Comparison-T-)-comparison'></a>
`comparison` [System.Comparison&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1')[T](#SortingNetworks-SNBoseNelson-SortAscending-T-(T_int_System-Comparison-T-)-T 'SortingNetworks.SNBoseNelson.SortAscending&lt;T&gt;(T, int, System.Comparison&lt;T&gt;).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1')  
The [System.Comparison&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1') to use when comparing elements.  
  
#### Exceptions
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
collection length is not between [MinLength](./SortingNetworks-SNBoseNelson-MinLength.md 'SortingNetworks.SNBoseNelson.MinLength') and [MaxLength](./SortingNetworks-SNBoseNelson-MaxLength.md 'SortingNetworks.SNBoseNelson.MaxLength')  
