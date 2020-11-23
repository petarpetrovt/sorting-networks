### [SortingNetworks](./SortingNetworks.md 'SortingNetworks').[SNBoseNelson](./SortingNetworks-SNBoseNelson.md 'SortingNetworks.SNBoseNelson')
## SNBoseNelson.SortDescendingBranchless(ushort, int) Method
Sorts a collection of specified number of elements in descending order using the [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic  
interface implementation of each element.  
```csharp
public static void SortDescendingBranchless(ref ushort p0, in int length);
```
#### Parameters
<a name='SortingNetworks-SNBoseNelson-SortDescendingBranchless(ushort_int)-p0'></a>
`p0` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')  
the reference to the first element of the collection  
  
<a name='SortingNetworks-SNBoseNelson-SortDescendingBranchless(ushort_int)-length'></a>
`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
the length of the collection  
  
#### Exceptions
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
collection length is not between [MinLength](./SortingNetworks-SNBoseNelson-MinLength.md 'SortingNetworks.SNBoseNelson.MinLength') and [MaxLength](./SortingNetworks-SNBoseNelson-MaxLength.md 'SortingNetworks.SNBoseNelson.MaxLength')  
