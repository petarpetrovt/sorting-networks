#### [SortingNetworks](./index.md 'index')
### [SortingNetworks](./SortingNetworks.md 'SortingNetworks').[SNBestKnown](./SortingNetworks-SNBestKnown.md 'SortingNetworks.SNBestKnown')
## SNBestKnown.SortAscending&lt;T&gt;(T, int) Method
Sorts a collection of specified number of elements in ascending order using the [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic  
interface implementation of each element.  
```csharp
public static void SortAscending<T>(ref T p0, in int length)
    where T : System.IComparable<T>;
```
#### Type parameters
<a name='SortingNetworks-SNBestKnown-SortAscending-T-(T_int)-T'></a>
`T`  
The type of the elements of the collection.  

Constraints [System.IComparable&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1')[T](#SortingNetworks-SNBestKnown-SortAscending-T-(T_int)-T 'SortingNetworks.SNBestKnown.SortAscending&lt;T&gt;(T, int).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1')  
  
#### Parameters
<a name='SortingNetworks-SNBestKnown-SortAscending-T-(T_int)-p0'></a>
`p0` [T](#SortingNetworks-SNBestKnown-SortAscending-T-(T_int)-T 'SortingNetworks.SNBestKnown.SortAscending&lt;T&gt;(T, int).T')  
the reference to the first element of the collection  
  
<a name='SortingNetworks-SNBestKnown-SortAscending-T-(T_int)-length'></a>
`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
the length of the collection  
  
#### Exceptions
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
collection length is not between [MinLength](./SortingNetworks-SNBestKnown-MinLength.md 'SortingNetworks.SNBestKnown.MinLength') and [MaxLength](./SortingNetworks-SNBestKnown-MaxLength.md 'SortingNetworks.SNBestKnown.MaxLength')  
