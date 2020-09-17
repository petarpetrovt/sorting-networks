### [SortingNetworks](./SortingNetworks.md 'SortingNetworks').[SN](./SortingNetworks-SN.md 'SortingNetworks.SN')
## SN.SortAscending&lt;T&gt;(Span&lt;T&gt;) Method
Sorts the elements in an entire [System.Span&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1') in ascending order using the [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic  
interface implementation of each element of the [System.Span&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1').  
```csharp
public static void SortAscending<T>(Span<T> buffer);
```
#### Type parameters
<a name='SortingNetworks-SN-SortAscending-T-(Span-T-)-T'></a>
`T`  
The type of the elements of the span.  
  
#### Parameters
<a name='SortingNetworks-SN-SortAscending-T-(Span-T-)-buffer'></a>
`buffer` [System.Span](https://docs.microsoft.com/en-us/dotnet/api/System.Span 'System.Span')  
The one-dimensional, zero-based [System.Span&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1') to sort.  
  
#### Exceptions
[System.ArgumentOutOfRangeException](https://docs.microsoft.com/en-us/dotnet/api/System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException')  
span length is not between [MinLength](./SortingNetworks-SN-MinLength.md 'SortingNetworks.SN.MinLength') and [MaxLength](./SortingNetworks-SN-MaxLength.md 'SortingNetworks.SN.MaxLength')  
