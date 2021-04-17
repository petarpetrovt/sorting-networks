#### [SortingNetworks](index.md 'index')
### [SortingNetworks](SortingNetworks.md 'SortingNetworks').[ArrayHelper](SortingNetworks_ArrayHelper.md 'SortingNetworks.ArrayHelper')
## ArrayHelper.GetReference&lt;T&gt;(T[]) Method
Returns a reference to the first element within a given [T](SortingNetworks_ArrayHelper_GetReference_T_(T__).md#SortingNetworks_ArrayHelper_GetReference_T_(T__)_T 'SortingNetworks.ArrayHelper.GetReference&lt;T&gt;(T[]).T') array, with no bounds checks.  
```csharp
public static ref T GetReference<T>(T[] array);
```
#### Type parameters
<a name='SortingNetworks_ArrayHelper_GetReference_T_(T__)_T'></a>
`T`  
The type of elements in the input [T](SortingNetworks_ArrayHelper_GetReference_T_(T__).md#SortingNetworks_ArrayHelper_GetReference_T_(T__)_T 'SortingNetworks.ArrayHelper.GetReference&lt;T&gt;(T[]).T') array instance.
  
#### Parameters
<a name='SortingNetworks_ArrayHelper_GetReference_T_(T__)_array'></a>
`array` [T](SortingNetworks_ArrayHelper_GetReference_T_(T__).md#SortingNetworks_ArrayHelper_GetReference_T_(T__)_T 'SortingNetworks.ArrayHelper.GetReference&lt;T&gt;(T[]).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The input [T](SortingNetworks_ArrayHelper_GetReference_T_(T__).md#SortingNetworks_ArrayHelper_GetReference_T_(T__)_T 'SortingNetworks.ArrayHelper.GetReference&lt;T&gt;(T[]).T') array instance.
  
#### Returns
[T](SortingNetworks_ArrayHelper_GetReference_T_(T__).md#SortingNetworks_ArrayHelper_GetReference_T_(T__)_T 'SortingNetworks.ArrayHelper.GetReference&lt;T&gt;(T[]).T')  
A reference to the first element within [array](SortingNetworks_ArrayHelper_GetReference_T_(T__).md#SortingNetworks_ArrayHelper_GetReference_T_(T__)_array 'SortingNetworks.ArrayHelper.GetReference&lt;T&gt;(T[]).array'), or the location  
            it would have used, if [array](SortingNetworks_ArrayHelper_GetReference_T_(T__).md#SortingNetworks_ArrayHelper_GetReference_T_(T__)_array 'SortingNetworks.ArrayHelper.GetReference&lt;T&gt;(T[]).array') is empty.
### Remarks
This method doesn't do any bounds checks, therefore it is responsibility of the caller  
to perform checks in case the returned value is dereferenced.  
