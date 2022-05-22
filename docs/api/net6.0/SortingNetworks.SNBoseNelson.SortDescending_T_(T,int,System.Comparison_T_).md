### [SortingNetworks](SortingNetworks.md 'SortingNetworks').[SNBoseNelson](SortingNetworks.SNBoseNelson.md 'SortingNetworks.SNBoseNelson')

## SNBoseNelson.SortDescending<T>(T, int, Comparison<T>) Method

Sorts a collection of specified number of elements in descending order using the specified [System.Comparison&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1').

```csharp
public static void SortDescending<T>(ref T p0, in int length, System.Comparison<T> comparison)
    where T : System.IComparable<T>;
```
#### Type parameters

<a name='SortingNetworks.SNBoseNelson.SortDescending_T_(T,int,System.Comparison_T_).T'></a>

`T`

The type of the elements of the collection.
#### Parameters

<a name='SortingNetworks.SNBoseNelson.SortDescending_T_(T,int,System.Comparison_T_).p0'></a>

`p0` [T](SortingNetworks.SNBoseNelson.SortDescending_T_(T,int,System.Comparison_T_).md#SortingNetworks.SNBoseNelson.SortDescending_T_(T,int,System.Comparison_T_).T 'SortingNetworks.SNBoseNelson.SortDescending<T>(T, int, System.Comparison<T>).T')

the reference to the first element of the collection

<a name='SortingNetworks.SNBoseNelson.SortDescending_T_(T,int,System.Comparison_T_).length'></a>

`length` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

the length of the collection

<a name='SortingNetworks.SNBoseNelson.SortDescending_T_(T,int,System.Comparison_T_).comparison'></a>

`comparison` [System.Comparison&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1')[T](SortingNetworks.SNBoseNelson.SortDescending_T_(T,int,System.Comparison_T_).md#SortingNetworks.SNBoseNelson.SortDescending_T_(T,int,System.Comparison_T_).T 'SortingNetworks.SNBoseNelson.SortDescending<T>(T, int, System.Comparison<T>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1')

The [System.Comparison&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1') to use when comparing elements.

#### Exceptions

[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
collection length is not between [MinLength](SortingNetworks.SNBoseNelson.MinLength.md 'SortingNetworks.SNBoseNelson.MinLength') and [MaxLength](SortingNetworks.SNBoseNelson.MaxLength.md 'SortingNetworks.SNBoseNelson.MaxLength')