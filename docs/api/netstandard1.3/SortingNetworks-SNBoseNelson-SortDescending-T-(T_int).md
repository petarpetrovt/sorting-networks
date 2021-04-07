#### [SortingNetworks](./index.md 'index')
### [SortingNetworks](./SortingNetworks.md 'SortingNetworks').[SNBoseNelson](./SortingNetworks-SNBoseNelson.md 'SortingNetworks.SNBoseNelson')
## SNBoseNelson.SortDescending&lt;T&gt;(T, int) Method
Sorts a collection of specified number of elements in descending order using the [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic  
interface implementation of each element.  
```csharp
public static void SortDescending<T>(ref T p0, in int length)
    where T : System.IComparable<T>;
```
#### Type parameters
<a name='SortingNetworks-SNBoseNelson-SortDescending-T-(T_int)-T'></a>
`T`  
The type of the elements of the collection.  

Constraints [System.IComparable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1')[T](#SortingNetworks-SNBoseNelson-SortDescending-T-(T_int)-T 'SortingNetworks.SNBoseNelson.SortDescending&lt;T&gt;(T, int).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1')  
  
#### Parameters
<a name='SortingNetworks-SNBoseNelson-SortDescending-T-(T_int)-p0'></a>
`p0` [T](#SortingNetworks-SNBoseNelson-SortDescending-T-(T_int)-T 'SortingNetworks.SNBoseNelson.SortDescending&lt;T&gt;(T, int).T')  
the reference to the first element of the collection  
  
<a name='SortingNetworks-SNBoseNelson-SortDescending-T-(T_int)-length'></a>
`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
the length of the collection  
  
#### Exceptions
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
collection length is not between [MinLength](./SortingNetworks-SNBoseNelson-MinLength.md 'SortingNetworks.SNBoseNelson.MinLength') and [MaxLength](./SortingNetworks-SNBoseNelson-MaxLength.md 'SortingNetworks.SNBoseNelson.MaxLength')  
