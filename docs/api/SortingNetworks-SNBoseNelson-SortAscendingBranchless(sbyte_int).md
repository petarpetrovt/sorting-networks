### [SortingNetworks](./SortingNetworks.md 'SortingNetworks').[SNBoseNelson](./SortingNetworks-SNBoseNelson.md 'SortingNetworks.SNBoseNelson')
## SNBoseNelson.SortAscendingBranchless(sbyte, int) Method
Sorts a collection of specified number of elements in ascending order using the [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic  
interface implementation of each element.  
```csharp
public static void SortAscendingBranchless(ref sbyte p0, in int length);
```
#### Parameters
<a name='SortingNetworks-SNBoseNelson-SortAscendingBranchless(sbyte_int)-p0'></a>
`p0` [System.SByte](https://docs.microsoft.com/en-us/dotnet/api/System.SByte 'System.SByte')  
the reference to the first element of the collection  
  
<a name='SortingNetworks-SNBoseNelson-SortAscendingBranchless(sbyte_int)-length'></a>
`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
the length of the collection  
  
#### Exceptions
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
collection length is not between [MinLength](./SortingNetworks-SNBoseNelson-MinLength.md 'SortingNetworks.SNBoseNelson.MinLength') and [MaxLength](./SortingNetworks-SNBoseNelson-MaxLength.md 'SortingNetworks.SNBoseNelson.MaxLength')  