### [SortingNetworks](SortingNetworks.md 'SortingNetworks').[SNBestKnown](SortingNetworks.SNBestKnown.md 'SortingNetworks.SNBestKnown')

## SNBestKnown.SortDescending<T>(T, int) Method

Sorts a collection of specified number of elements in descending order using the [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic  
interface implementation of each element.

```csharp
public static void SortDescending<T>(ref T p0, in int length)
    where T : System.IComparable<T>;
```
#### Type parameters

<a name='SortingNetworks.SNBestKnown.SortDescending_T_(T,int).T'></a>

`T`

The type of the elements of the collection.
#### Parameters

<a name='SortingNetworks.SNBestKnown.SortDescending_T_(T,int).p0'></a>

`p0` [T](SortingNetworks.SNBestKnown.SortDescending_T_(T,int).md#SortingNetworks.SNBestKnown.SortDescending_T_(T,int).T 'SortingNetworks.SNBestKnown.SortDescending<T>(T, int).T')

the reference to the first element of the collection

<a name='SortingNetworks.SNBestKnown.SortDescending_T_(T,int).length'></a>

`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the length of the collection

#### Exceptions

[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
collection length is not between [MinLength](SortingNetworks.SNBestKnown.MinLength.md 'SortingNetworks.SNBestKnown.MinLength') and [MaxLength](SortingNetworks.SNBestKnown.MaxLength.md 'SortingNetworks.SNBestKnown.MaxLength')