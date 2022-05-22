### [SortingNetworks](SortingNetworks.md 'SortingNetworks').[SNBestKnown](SortingNetworks.SNBestKnown.md 'SortingNetworks.SNBestKnown')

## SNBestKnown.SortAscendingBranchless(ushort, int) Method

Sorts a collection of specified number of elements in ascending order using branchless min/max swap.

```csharp
public static void SortAscendingBranchless(ref ushort p0, in int length);
```
#### Parameters

<a name='SortingNetworks.SNBestKnown.SortAscendingBranchless(ushort,int).p0'></a>

`p0` [System.UInt16](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16 'System.UInt16')

the reference to the first element of the collection

<a name='SortingNetworks.SNBestKnown.SortAscendingBranchless(ushort,int).length'></a>

`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the length of the collection

#### Exceptions

[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
collection length is not between [MinLength](SortingNetworks.SNBestKnown.MinLength.md 'SortingNetworks.SNBestKnown.MinLength') and [MaxLength](SortingNetworks.SNBestKnown.MaxLength.md 'SortingNetworks.SNBestKnown.MaxLength')