### [SortingNetworks](SortingNetworks.md 'SortingNetworks').[ArrayHelper](SortingNetworks.ArrayHelper.md 'SortingNetworks.ArrayHelper')

## ArrayHelper.GetReference<T>(T[]) Method

Returns a reference to the first element within a given [T](SortingNetworks.ArrayHelper.GetReference_T_(T[]).md#SortingNetworks.ArrayHelper.GetReference_T_(T[]).T 'SortingNetworks.ArrayHelper.GetReference<T>(T[]).T') array, with no bounds checks.

```csharp
public static ref T GetReference<T>(T[] array);
```
#### Type parameters

<a name='SortingNetworks.ArrayHelper.GetReference_T_(T[]).T'></a>

`T`

The type of elements in the input [T](SortingNetworks.ArrayHelper.GetReference_T_(T[]).md#SortingNetworks.ArrayHelper.GetReference_T_(T[]).T 'SortingNetworks.ArrayHelper.GetReference<T>(T[]).T') array instance.
#### Parameters

<a name='SortingNetworks.ArrayHelper.GetReference_T_(T[]).array'></a>

`array` [T](SortingNetworks.ArrayHelper.GetReference_T_(T[]).md#SortingNetworks.ArrayHelper.GetReference_T_(T[]).T 'SortingNetworks.ArrayHelper.GetReference<T>(T[]).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The input [T](SortingNetworks.ArrayHelper.GetReference_T_(T[]).md#SortingNetworks.ArrayHelper.GetReference_T_(T[]).T 'SortingNetworks.ArrayHelper.GetReference<T>(T[]).T') array instance.

#### Returns
[T](SortingNetworks.ArrayHelper.GetReference_T_(T[]).md#SortingNetworks.ArrayHelper.GetReference_T_(T[]).T 'SortingNetworks.ArrayHelper.GetReference<T>(T[]).T')  
A reference to the first element within [array](SortingNetworks.ArrayHelper.GetReference_T_(T[]).md#SortingNetworks.ArrayHelper.GetReference_T_(T[]).array 'SortingNetworks.ArrayHelper.GetReference<T>(T[]).array'), or the location  
            it would have used, if [array](SortingNetworks.ArrayHelper.GetReference_T_(T[]).md#SortingNetworks.ArrayHelper.GetReference_T_(T[]).array 'SortingNetworks.ArrayHelper.GetReference<T>(T[]).array') is empty.

### Remarks
This method doesn't do any bounds checks, therefore it is responsibility of the caller  
to perform checks in case the returned value is dereferenced.