### [SortingNetworks](SortingNetworks.md 'SortingNetworks').[SNBoseNelson](SortingNetworks.SNBoseNelson.md 'SortingNetworks.SNBoseNelson')

## SNBoseNelson.SortAscendingBranchless(uint, int) Method

Sorts a collection of specified number of elements in ascending order using branchless min/max swap.

```csharp
public static void SortAscendingBranchless(ref uint p0, in int length);
```
#### Parameters

<a name='SortingNetworks.SNBoseNelson.SortAscendingBranchless(uint,int).p0'></a>

`p0` [System.UInt32](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32 'System.UInt32')

the reference to the first element of the collection

<a name='SortingNetworks.SNBoseNelson.SortAscendingBranchless(uint,int).length'></a>

`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the length of the collection

#### Exceptions

[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
collection length is not between [MinLength](SortingNetworks.SNBoseNelson.MinLength.md 'SortingNetworks.SNBoseNelson.MinLength') and [MaxLength](SortingNetworks.SNBoseNelson.MaxLength.md 'SortingNetworks.SNBoseNelson.MaxLength')