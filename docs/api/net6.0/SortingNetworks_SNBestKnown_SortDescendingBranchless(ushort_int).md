### [SortingNetworks](SortingNetworks.md 'SortingNetworks').[SNBestKnown](SortingNetworks_SNBestKnown.md 'SortingNetworks.SNBestKnown')
## SNBestKnown.SortDescendingBranchless(ushort, int) Method
Sorts a collection of specified number of elements in descending order using branchless min/max swap.  
```csharp
public static void SortDescendingBranchless(ref ushort p0, in int length);
```
#### Parameters
<a name='SortingNetworks_SNBestKnown_SortDescendingBranchless(ushort_int)_p0'></a>
`p0` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')  
the reference to the first element of the collection
  
<a name='SortingNetworks_SNBestKnown_SortDescendingBranchless(ushort_int)_length'></a>
`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')  
the length of the collection
  
#### Exceptions
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
collection length is not between [MinLength](SortingNetworks_SNBestKnown_MinLength.md 'SortingNetworks.SNBestKnown.MinLength') and [MaxLength](SortingNetworks_SNBestKnown_MaxLength.md 'SortingNetworks.SNBestKnown.MaxLength')
