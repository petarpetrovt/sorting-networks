#### [SortingNetworks](index.md 'index')
### [SortingNetworks](SortingNetworks.md 'SortingNetworks').[SNBoseNelson](SortingNetworks_SNBoseNelson.md 'SortingNetworks.SNBoseNelson')
## SNBoseNelson.SortAscendingBranchless(byte, int) Method
Sorts a collection of specified number of elements in ascending order using branchless min/max swap.  
```csharp
public static void SortAscendingBranchless(ref byte p0, in int length);
```
#### Parameters
<a name='SortingNetworks_SNBoseNelson_SortAscendingBranchless(byte_int)_p0'></a>
`p0` [System.Byte](https://docs.microsoft.com/en-us/dotnet/api/System.Byte 'System.Byte')  
the reference to the first element of the collection
  
<a name='SortingNetworks_SNBoseNelson_SortAscendingBranchless(byte_int)_length'></a>
`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
the length of the collection
  
#### Exceptions
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
collection length is not between [MinLength](SortingNetworks_SNBoseNelson_MinLength.md 'SortingNetworks.SNBoseNelson.MinLength') and [MaxLength](SortingNetworks_SNBoseNelson_MaxLength.md 'SortingNetworks.SNBoseNelson.MaxLength')
