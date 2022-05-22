### [SortingNetworks](SortingNetworks.md 'SortingNetworks')

## SN Class

Contains generic sorting methods for collections with length from [MinLength](SortingNetworks.SN.MinLength.md 'SortingNetworks.SN.MinLength') to [MaxLength](SortingNetworks.SN.MaxLength.md 'SortingNetworks.SN.MaxLength').

```csharp
public static class SN
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SN

| Fields | |
| :--- | :--- |
| [MaxLength](SortingNetworks.SN.MaxLength.md 'SortingNetworks.SN.MaxLength') | The maximum supported length for sorting. |
| [MinLength](SortingNetworks.SN.MinLength.md 'SortingNetworks.SN.MinLength') | The minimum supported length for sorting. |

| Methods | |
| :--- | :--- |
| [SortAscending&lt;T&gt;(Span&lt;T&gt;)](SortingNetworks.SN.SortAscending_T_(System.Span_T_).md 'SortingNetworks.SN.SortAscending<T>(System.Span<T>)') | Sorts the elements in an entire [System.Span&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1') in ascending order using the [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic<br/>interface implementation of each element of the [System.Span&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1'). |
| [SortAscending&lt;T&gt;(Span&lt;T&gt;, Comparison&lt;T&gt;)](SortingNetworks.SN.SortAscending_T_(System.Span_T_,System.Comparison_T_).md 'SortingNetworks.SN.SortAscending<T>(System.Span<T>, System.Comparison<T>)') | Sorts the elements in an [System.Span&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1') in ascending order using the specified [System.Comparison&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1'). |
| [SortAscending&lt;T&gt;(T[])](SortingNetworks.SN.SortAscending_T_(T[]).md 'SortingNetworks.SN.SortAscending<T>(T[])') | Sorts the elements in an entire [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') in ascending order using the [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic<br/>interface implementation of each element of the [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array'). |
| [SortAscending&lt;T&gt;(T[], Comparison&lt;T&gt;)](SortingNetworks.SN.SortAscending_T_(T[],System.Comparison_T_).md 'SortingNetworks.SN.SortAscending<T>(T[], System.Comparison<T>)') | Sorts the elements in an [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') in ascending order using the specified [System.Comparison&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1'). |
| [SortDescending&lt;T&gt;(Span&lt;T&gt;)](SortingNetworks.SN.SortDescending_T_(System.Span_T_).md 'SortingNetworks.SN.SortDescending<T>(System.Span<T>)') | Sorts the elements in an entire [System.Span&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1') in descending order using the [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic<br/>interface implementation of each element of the [System.Span&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1'). |
| [SortDescending&lt;T&gt;(Span&lt;T&gt;, Comparison&lt;T&gt;)](SortingNetworks.SN.SortDescending_T_(System.Span_T_,System.Comparison_T_).md 'SortingNetworks.SN.SortDescending<T>(System.Span<T>, System.Comparison<T>)') | Sorts the elements in an [System.Span&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1') in descending order using the specified [System.Comparison&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1'). |
| [SortDescending&lt;T&gt;(T[])](SortingNetworks.SN.SortDescending_T_(T[]).md 'SortingNetworks.SN.SortDescending<T>(T[])') | Sorts the elements in an entire [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') in descending order using the [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic<br/>interface implementation of each element of the [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array'). |
| [SortDescending&lt;T&gt;(T[], Comparison&lt;T&gt;)](SortingNetworks.SN.SortDescending_T_(T[],System.Comparison_T_).md 'SortingNetworks.SN.SortDescending<T>(T[], System.Comparison<T>)') | Sorts the elements in an [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') in descending order using the specified [System.Comparison&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1'). |
