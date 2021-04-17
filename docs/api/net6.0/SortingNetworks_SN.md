### [SortingNetworks](SortingNetworks.md 'SortingNetworks')
## SN Class
Contains generic sorting methods for collections with length from [MinLength](SortingNetworks_SN_MinLength.md 'SortingNetworks.SN.MinLength') to [MaxLength](SortingNetworks_SN_MaxLength.md 'SortingNetworks.SN.MaxLength').  
```csharp
public static class SN
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; SN  
### Fields

***
[MaxLength](SortingNetworks_SN_MaxLength.md 'SortingNetworks.SN.MaxLength')

The maximum supported length for sorting.  

***
[MinLength](SortingNetworks_SN_MinLength.md 'SortingNetworks.SN.MinLength')

The minimum supported length for sorting.  
### Methods

***
[SortAscending&lt;T&gt;(Span&lt;T&gt;)](SortingNetworks_SN_SortAscending_T_(System_Span_T_).md 'SortingNetworks.SN.SortAscending&lt;T&gt;(System.Span&lt;T&gt;)')

Sorts the elements in an entire [System.Span&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1') in ascending order using the [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic  
interface implementation of each element of the [System.Span&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1').  

***
[SortAscending&lt;T&gt;(Span&lt;T&gt;, Comparison&lt;T&gt;)](SortingNetworks_SN_SortAscending_T_(System_Span_T__System_Comparison_T_).md 'SortingNetworks.SN.SortAscending&lt;T&gt;(System.Span&lt;T&gt;, System.Comparison&lt;T&gt;)')

Sorts the elements in an [System.Span&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1') in ascending order using the specified [System.Comparison&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1').  

***
[SortAscending&lt;T&gt;(T[])](SortingNetworks_SN_SortAscending_T_(T__).md 'SortingNetworks.SN.SortAscending&lt;T&gt;(T[])')

Sorts the elements in an entire [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') in ascending order using the [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic  
interface implementation of each element of the [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array').  

***
[SortAscending&lt;T&gt;(T[], Comparison&lt;T&gt;)](SortingNetworks_SN_SortAscending_T_(T___System_Comparison_T_).md 'SortingNetworks.SN.SortAscending&lt;T&gt;(T[], System.Comparison&lt;T&gt;)')

Sorts the elements in an [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') in ascending order using the specified [System.Comparison&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1').  

***
[SortDescending&lt;T&gt;(Span&lt;T&gt;)](SortingNetworks_SN_SortDescending_T_(System_Span_T_).md 'SortingNetworks.SN.SortDescending&lt;T&gt;(System.Span&lt;T&gt;)')

Sorts the elements in an entire [System.Span&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1') in descending order using the [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic  
interface implementation of each element of the [System.Span&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1').  

***
[SortDescending&lt;T&gt;(Span&lt;T&gt;, Comparison&lt;T&gt;)](SortingNetworks_SN_SortDescending_T_(System_Span_T__System_Comparison_T_).md 'SortingNetworks.SN.SortDescending&lt;T&gt;(System.Span&lt;T&gt;, System.Comparison&lt;T&gt;)')

Sorts the elements in an [System.Span&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Span-1 'System.Span`1') in descending order using the specified [System.Comparison&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1').  

***
[SortDescending&lt;T&gt;(T[])](SortingNetworks_SN_SortDescending_T_(T__).md 'SortingNetworks.SN.SortDescending&lt;T&gt;(T[])')

Sorts the elements in an entire [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') in descending order using the [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic  
interface implementation of each element of the [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array').  

***
[SortDescending&lt;T&gt;(T[], Comparison&lt;T&gt;)](SortingNetworks_SN_SortDescending_T_(T___System_Comparison_T_).md 'SortingNetworks.SN.SortDescending&lt;T&gt;(T[], System.Comparison&lt;T&gt;)')

Sorts the elements in an [System.Array](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array') in descending order using the specified [System.Comparison&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1').  
