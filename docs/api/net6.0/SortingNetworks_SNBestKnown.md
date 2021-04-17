### [SortingNetworks](SortingNetworks.md 'SortingNetworks')
## SNBestKnown Class
Sorting networks implementation using the best known arrangement of comparators.  
```csharp
public abstract class SNBestKnown : SortingNetworks.SNBoseNelson
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [SNBase](SortingNetworks_SNBase.md 'SortingNetworks.SNBase') &#129106; [SNBoseNelson](SortingNetworks_SNBoseNelson.md 'SortingNetworks.SNBoseNelson') &#129106; SNBestKnown  
### Remarks
Custom arrangement or comparators are used only for length between [9, 16] otherwise Bose-Nelson algorithm is used.  
SWAP macros generated from: https://pages.ripco.net/~jgamble/nw.html  
### Fields

***
[MaxLength](SortingNetworks_SNBestKnown_MaxLength.md 'SortingNetworks.SNBestKnown.MaxLength')

The maximum supported length for sorting.  

***
[MinLength](SortingNetworks_SNBestKnown_MinLength.md 'SortingNetworks.SNBestKnown.MinLength')

The minimum supported length for sorting.  
### Methods

***
[Sort10Ascending&lt;T&gt;(T)](SortingNetworks_SNBestKnown_Sort10Ascending_T_(T).md 'SortingNetworks.SNBestKnown.Sort10Ascending&lt;T&gt;(T)')

Sorts a collection of 10 elements in ascending order using the [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic  
interface implementation of each element.  

***
[Sort10Ascending&lt;T&gt;(T, Comparison&lt;T&gt;)](SortingNetworks_SNBestKnown_Sort10Ascending_T_(T_System_Comparison_T_).md 'SortingNetworks.SNBestKnown.Sort10Ascending&lt;T&gt;(T, System.Comparison&lt;T&gt;)')

Sorts a collection of 10 elements in ascending order using the specified [System.Comparison&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1').  

***
[Sort10AscendingBranchless(byte)](SortingNetworks_SNBestKnown_Sort10AscendingBranchless(byte).md 'SortingNetworks.SNBestKnown.Sort10AscendingBranchless(byte)')

Sorts a collection of 10 elements in ascending order using branchless min/max swap.  

***
[Sort10AscendingBranchless(int)](SortingNetworks_SNBestKnown_Sort10AscendingBranchless(int).md 'SortingNetworks.SNBestKnown.Sort10AscendingBranchless(int)')

Sorts a collection of 10 elements in ascending order using branchless min/max swap.  

***
[Sort10AscendingBranchless(sbyte)](SortingNetworks_SNBestKnown_Sort10AscendingBranchless(sbyte).md 'SortingNetworks.SNBestKnown.Sort10AscendingBranchless(sbyte)')

Sorts a collection of 10 elements in ascending order using branchless min/max swap.  

***
[Sort10AscendingBranchless(short)](SortingNetworks_SNBestKnown_Sort10AscendingBranchless(short).md 'SortingNetworks.SNBestKnown.Sort10AscendingBranchless(short)')

Sorts a collection of 10 elements in ascending order using branchless min/max swap.  

***
[Sort10AscendingBranchless(uint)](SortingNetworks_SNBestKnown_Sort10AscendingBranchless(uint).md 'SortingNetworks.SNBestKnown.Sort10AscendingBranchless(uint)')

Sorts a collection of 10 elements in ascending order using branchless min/max swap.  

***
[Sort10AscendingBranchless(ushort)](SortingNetworks_SNBestKnown_Sort10AscendingBranchless(ushort).md 'SortingNetworks.SNBestKnown.Sort10AscendingBranchless(ushort)')

Sorts a collection of 10 elements in ascending order using branchless min/max swap.  

***
[Sort10Descending&lt;T&gt;(T)](SortingNetworks_SNBestKnown_Sort10Descending_T_(T).md 'SortingNetworks.SNBestKnown.Sort10Descending&lt;T&gt;(T)')

Sorts a collection of 10 elements in descending order using the [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic  
interface implementation of each element.  

***
[Sort10Descending&lt;T&gt;(T, Comparison&lt;T&gt;)](SortingNetworks_SNBestKnown_Sort10Descending_T_(T_System_Comparison_T_).md 'SortingNetworks.SNBestKnown.Sort10Descending&lt;T&gt;(T, System.Comparison&lt;T&gt;)')

Sorts a collection of 10 elements in descending order using the specified [System.Comparison&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1').  

***
[Sort10DescendingBranchless(byte)](SortingNetworks_SNBestKnown_Sort10DescendingBranchless(byte).md 'SortingNetworks.SNBestKnown.Sort10DescendingBranchless(byte)')

Sorts a collection of 10 elements in descending order using branchless min/max swap.  

***
[Sort10DescendingBranchless(int)](SortingNetworks_SNBestKnown_Sort10DescendingBranchless(int).md 'SortingNetworks.SNBestKnown.Sort10DescendingBranchless(int)')

Sorts a collection of 10 elements in descending order using branchless min/max swap.  

***
[Sort10DescendingBranchless(sbyte)](SortingNetworks_SNBestKnown_Sort10DescendingBranchless(sbyte).md 'SortingNetworks.SNBestKnown.Sort10DescendingBranchless(sbyte)')

Sorts a collection of 10 elements in descending order using branchless min/max swap.  

***
[Sort10DescendingBranchless(short)](SortingNetworks_SNBestKnown_Sort10DescendingBranchless(short).md 'SortingNetworks.SNBestKnown.Sort10DescendingBranchless(short)')

Sorts a collection of 10 elements in descending order using branchless min/max swap.  

***
[Sort10DescendingBranchless(uint)](SortingNetworks_SNBestKnown_Sort10DescendingBranchless(uint).md 'SortingNetworks.SNBestKnown.Sort10DescendingBranchless(uint)')

Sorts a collection of 10 elements in descending order using branchless min/max swap.  

***
[Sort10DescendingBranchless(ushort)](SortingNetworks_SNBestKnown_Sort10DescendingBranchless(ushort).md 'SortingNetworks.SNBestKnown.Sort10DescendingBranchless(ushort)')

Sorts a collection of 10 elements in descending order using branchless min/max swap.  

***
[Sort11Ascending&lt;T&gt;(T)](SortingNetworks_SNBestKnown_Sort11Ascending_T_(T).md 'SortingNetworks.SNBestKnown.Sort11Ascending&lt;T&gt;(T)')

Sorts a collection of 11 elements in ascending order using the [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic  
interface implementation of each element.  

***
[Sort11Ascending&lt;T&gt;(T, Comparison&lt;T&gt;)](SortingNetworks_SNBestKnown_Sort11Ascending_T_(T_System_Comparison_T_).md 'SortingNetworks.SNBestKnown.Sort11Ascending&lt;T&gt;(T, System.Comparison&lt;T&gt;)')

Sorts a collection of 11 elements in ascending order using the specified [System.Comparison&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1').  

***
[Sort11AscendingBranchless(byte)](SortingNetworks_SNBestKnown_Sort11AscendingBranchless(byte).md 'SortingNetworks.SNBestKnown.Sort11AscendingBranchless(byte)')

Sorts a collection of 11 elements in ascending order using branchless min/max swap.  

***
[Sort11AscendingBranchless(int)](SortingNetworks_SNBestKnown_Sort11AscendingBranchless(int).md 'SortingNetworks.SNBestKnown.Sort11AscendingBranchless(int)')

Sorts a collection of 11 elements in ascending order using branchless min/max swap.  

***
[Sort11AscendingBranchless(sbyte)](SortingNetworks_SNBestKnown_Sort11AscendingBranchless(sbyte).md 'SortingNetworks.SNBestKnown.Sort11AscendingBranchless(sbyte)')

Sorts a collection of 11 elements in ascending order using branchless min/max swap.  

***
[Sort11AscendingBranchless(short)](SortingNetworks_SNBestKnown_Sort11AscendingBranchless(short).md 'SortingNetworks.SNBestKnown.Sort11AscendingBranchless(short)')

Sorts a collection of 11 elements in ascending order using branchless min/max swap.  

***
[Sort11AscendingBranchless(uint)](SortingNetworks_SNBestKnown_Sort11AscendingBranchless(uint).md 'SortingNetworks.SNBestKnown.Sort11AscendingBranchless(uint)')

Sorts a collection of 11 elements in ascending order using branchless min/max swap.  

***
[Sort11AscendingBranchless(ushort)](SortingNetworks_SNBestKnown_Sort11AscendingBranchless(ushort).md 'SortingNetworks.SNBestKnown.Sort11AscendingBranchless(ushort)')

Sorts a collection of 11 elements in ascending order using branchless min/max swap.  

***
[Sort11Descending&lt;T&gt;(T)](SortingNetworks_SNBestKnown_Sort11Descending_T_(T).md 'SortingNetworks.SNBestKnown.Sort11Descending&lt;T&gt;(T)')

Sorts a collection of 11 elements in descending order using the [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic  
interface implementation of each element.  

***
[Sort11Descending&lt;T&gt;(T, Comparison&lt;T&gt;)](SortingNetworks_SNBestKnown_Sort11Descending_T_(T_System_Comparison_T_).md 'SortingNetworks.SNBestKnown.Sort11Descending&lt;T&gt;(T, System.Comparison&lt;T&gt;)')

Sorts a collection of 11 elements in descending order using the specified [System.Comparison&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1').  

***
[Sort11DescendingBranchless(byte)](SortingNetworks_SNBestKnown_Sort11DescendingBranchless(byte).md 'SortingNetworks.SNBestKnown.Sort11DescendingBranchless(byte)')

Sorts a collection of 11 elements in descending order using branchless min/max swap.  

***
[Sort11DescendingBranchless(int)](SortingNetworks_SNBestKnown_Sort11DescendingBranchless(int).md 'SortingNetworks.SNBestKnown.Sort11DescendingBranchless(int)')

Sorts a collection of 11 elements in descending order using branchless min/max swap.  

***
[Sort11DescendingBranchless(sbyte)](SortingNetworks_SNBestKnown_Sort11DescendingBranchless(sbyte).md 'SortingNetworks.SNBestKnown.Sort11DescendingBranchless(sbyte)')

Sorts a collection of 11 elements in descending order using branchless min/max swap.  

***
[Sort11DescendingBranchless(short)](SortingNetworks_SNBestKnown_Sort11DescendingBranchless(short).md 'SortingNetworks.SNBestKnown.Sort11DescendingBranchless(short)')

Sorts a collection of 11 elements in descending order using branchless min/max swap.  

***
[Sort11DescendingBranchless(uint)](SortingNetworks_SNBestKnown_Sort11DescendingBranchless(uint).md 'SortingNetworks.SNBestKnown.Sort11DescendingBranchless(uint)')

Sorts a collection of 11 elements in descending order using branchless min/max swap.  

***
[Sort11DescendingBranchless(ushort)](SortingNetworks_SNBestKnown_Sort11DescendingBranchless(ushort).md 'SortingNetworks.SNBestKnown.Sort11DescendingBranchless(ushort)')

Sorts a collection of 11 elements in descending order using branchless min/max swap.  

***
[Sort12Ascending&lt;T&gt;(T)](SortingNetworks_SNBestKnown_Sort12Ascending_T_(T).md 'SortingNetworks.SNBestKnown.Sort12Ascending&lt;T&gt;(T)')

Sorts a collection of 12 elements in ascending order using the [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic  
interface implementation of each element.  

***
[Sort12Ascending&lt;T&gt;(T, Comparison&lt;T&gt;)](SortingNetworks_SNBestKnown_Sort12Ascending_T_(T_System_Comparison_T_).md 'SortingNetworks.SNBestKnown.Sort12Ascending&lt;T&gt;(T, System.Comparison&lt;T&gt;)')

Sorts a collection of 12 elements in ascending order using the specified [System.Comparison&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1').  

***
[Sort12AscendingBranchless(byte)](SortingNetworks_SNBestKnown_Sort12AscendingBranchless(byte).md 'SortingNetworks.SNBestKnown.Sort12AscendingBranchless(byte)')

Sorts a collection of 12 elements in ascending order using branchless min/max swap.  

***
[Sort12AscendingBranchless(int)](SortingNetworks_SNBestKnown_Sort12AscendingBranchless(int).md 'SortingNetworks.SNBestKnown.Sort12AscendingBranchless(int)')

Sorts a collection of 12 elements in ascending order using branchless min/max swap.  

***
[Sort12AscendingBranchless(sbyte)](SortingNetworks_SNBestKnown_Sort12AscendingBranchless(sbyte).md 'SortingNetworks.SNBestKnown.Sort12AscendingBranchless(sbyte)')

Sorts a collection of 12 elements in ascending order using branchless min/max swap.  

***
[Sort12AscendingBranchless(short)](SortingNetworks_SNBestKnown_Sort12AscendingBranchless(short).md 'SortingNetworks.SNBestKnown.Sort12AscendingBranchless(short)')

Sorts a collection of 12 elements in ascending order using branchless min/max swap.  

***
[Sort12AscendingBranchless(uint)](SortingNetworks_SNBestKnown_Sort12AscendingBranchless(uint).md 'SortingNetworks.SNBestKnown.Sort12AscendingBranchless(uint)')

Sorts a collection of 12 elements in ascending order using branchless min/max swap.  

***
[Sort12AscendingBranchless(ushort)](SortingNetworks_SNBestKnown_Sort12AscendingBranchless(ushort).md 'SortingNetworks.SNBestKnown.Sort12AscendingBranchless(ushort)')

Sorts a collection of 12 elements in ascending order using branchless min/max swap.  

***
[Sort12Descending&lt;T&gt;(T)](SortingNetworks_SNBestKnown_Sort12Descending_T_(T).md 'SortingNetworks.SNBestKnown.Sort12Descending&lt;T&gt;(T)')

Sorts a collection of 12 elements in descending order using the [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic  
interface implementation of each element.  

***
[Sort12Descending&lt;T&gt;(T, Comparison&lt;T&gt;)](SortingNetworks_SNBestKnown_Sort12Descending_T_(T_System_Comparison_T_).md 'SortingNetworks.SNBestKnown.Sort12Descending&lt;T&gt;(T, System.Comparison&lt;T&gt;)')

Sorts a collection of 12 elements in descending order using the specified [System.Comparison&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1').  

***
[Sort12DescendingBranchless(byte)](SortingNetworks_SNBestKnown_Sort12DescendingBranchless(byte).md 'SortingNetworks.SNBestKnown.Sort12DescendingBranchless(byte)')

Sorts a collection of 12 elements in descending order using branchless min/max swap.  

***
[Sort12DescendingBranchless(int)](SortingNetworks_SNBestKnown_Sort12DescendingBranchless(int).md 'SortingNetworks.SNBestKnown.Sort12DescendingBranchless(int)')

Sorts a collection of 12 elements in descending order using branchless min/max swap.  

***
[Sort12DescendingBranchless(sbyte)](SortingNetworks_SNBestKnown_Sort12DescendingBranchless(sbyte).md 'SortingNetworks.SNBestKnown.Sort12DescendingBranchless(sbyte)')

Sorts a collection of 12 elements in descending order using branchless min/max swap.  

***
[Sort12DescendingBranchless(short)](SortingNetworks_SNBestKnown_Sort12DescendingBranchless(short).md 'SortingNetworks.SNBestKnown.Sort12DescendingBranchless(short)')

Sorts a collection of 12 elements in descending order using branchless min/max swap.  

***
[Sort12DescendingBranchless(uint)](SortingNetworks_SNBestKnown_Sort12DescendingBranchless(uint).md 'SortingNetworks.SNBestKnown.Sort12DescendingBranchless(uint)')

Sorts a collection of 12 elements in descending order using branchless min/max swap.  

***
[Sort12DescendingBranchless(ushort)](SortingNetworks_SNBestKnown_Sort12DescendingBranchless(ushort).md 'SortingNetworks.SNBestKnown.Sort12DescendingBranchless(ushort)')

Sorts a collection of 12 elements in descending order using branchless min/max swap.  

***
[Sort13Ascending&lt;T&gt;(T)](SortingNetworks_SNBestKnown_Sort13Ascending_T_(T).md 'SortingNetworks.SNBestKnown.Sort13Ascending&lt;T&gt;(T)')

Sorts a collection of 13 elements in ascending order using the [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic  
interface implementation of each element.  

***
[Sort13Ascending&lt;T&gt;(T, Comparison&lt;T&gt;)](SortingNetworks_SNBestKnown_Sort13Ascending_T_(T_System_Comparison_T_).md 'SortingNetworks.SNBestKnown.Sort13Ascending&lt;T&gt;(T, System.Comparison&lt;T&gt;)')

Sorts a collection of 13 elements in ascending order using the specified [System.Comparison&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1').  

***
[Sort13AscendingBranchless(byte)](SortingNetworks_SNBestKnown_Sort13AscendingBranchless(byte).md 'SortingNetworks.SNBestKnown.Sort13AscendingBranchless(byte)')

Sorts a collection of 13 elements in ascending order using branchless min/max swap.  

***
[Sort13AscendingBranchless(int)](SortingNetworks_SNBestKnown_Sort13AscendingBranchless(int).md 'SortingNetworks.SNBestKnown.Sort13AscendingBranchless(int)')

Sorts a collection of 13 elements in ascending order using branchless min/max swap.  

***
[Sort13AscendingBranchless(sbyte)](SortingNetworks_SNBestKnown_Sort13AscendingBranchless(sbyte).md 'SortingNetworks.SNBestKnown.Sort13AscendingBranchless(sbyte)')

Sorts a collection of 13 elements in ascending order using branchless min/max swap.  

***
[Sort13AscendingBranchless(short)](SortingNetworks_SNBestKnown_Sort13AscendingBranchless(short).md 'SortingNetworks.SNBestKnown.Sort13AscendingBranchless(short)')

Sorts a collection of 13 elements in ascending order using branchless min/max swap.  

***
[Sort13AscendingBranchless(uint)](SortingNetworks_SNBestKnown_Sort13AscendingBranchless(uint).md 'SortingNetworks.SNBestKnown.Sort13AscendingBranchless(uint)')

Sorts a collection of 13 elements in ascending order using branchless min/max swap.  

***
[Sort13AscendingBranchless(ushort)](SortingNetworks_SNBestKnown_Sort13AscendingBranchless(ushort).md 'SortingNetworks.SNBestKnown.Sort13AscendingBranchless(ushort)')

Sorts a collection of 13 elements in ascending order using branchless min/max swap.  

***
[Sort13Descending&lt;T&gt;(T)](SortingNetworks_SNBestKnown_Sort13Descending_T_(T).md 'SortingNetworks.SNBestKnown.Sort13Descending&lt;T&gt;(T)')

Sorts a collection of 13 elements in descending order using the [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic  
interface implementation of each element.  

***
[Sort13Descending&lt;T&gt;(T, Comparison&lt;T&gt;)](SortingNetworks_SNBestKnown_Sort13Descending_T_(T_System_Comparison_T_).md 'SortingNetworks.SNBestKnown.Sort13Descending&lt;T&gt;(T, System.Comparison&lt;T&gt;)')

Sorts a collection of 13 elements in descending order using the specified [System.Comparison&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1').  

***
[Sort13DescendingBranchless(byte)](SortingNetworks_SNBestKnown_Sort13DescendingBranchless(byte).md 'SortingNetworks.SNBestKnown.Sort13DescendingBranchless(byte)')

Sorts a collection of 13 elements in descending order using branchless min/max swap.  

***
[Sort13DescendingBranchless(int)](SortingNetworks_SNBestKnown_Sort13DescendingBranchless(int).md 'SortingNetworks.SNBestKnown.Sort13DescendingBranchless(int)')

Sorts a collection of 13 elements in descending order using branchless min/max swap.  

***
[Sort13DescendingBranchless(sbyte)](SortingNetworks_SNBestKnown_Sort13DescendingBranchless(sbyte).md 'SortingNetworks.SNBestKnown.Sort13DescendingBranchless(sbyte)')

Sorts a collection of 13 elements in descending order using branchless min/max swap.  

***
[Sort13DescendingBranchless(short)](SortingNetworks_SNBestKnown_Sort13DescendingBranchless(short).md 'SortingNetworks.SNBestKnown.Sort13DescendingBranchless(short)')

Sorts a collection of 13 elements in descending order using branchless min/max swap.  

***
[Sort13DescendingBranchless(uint)](SortingNetworks_SNBestKnown_Sort13DescendingBranchless(uint).md 'SortingNetworks.SNBestKnown.Sort13DescendingBranchless(uint)')

Sorts a collection of 13 elements in descending order using branchless min/max swap.  

***
[Sort13DescendingBranchless(ushort)](SortingNetworks_SNBestKnown_Sort13DescendingBranchless(ushort).md 'SortingNetworks.SNBestKnown.Sort13DescendingBranchless(ushort)')

Sorts a collection of 13 elements in descending order using branchless min/max swap.  

***
[Sort14Ascending&lt;T&gt;(T)](SortingNetworks_SNBestKnown_Sort14Ascending_T_(T).md 'SortingNetworks.SNBestKnown.Sort14Ascending&lt;T&gt;(T)')

Sorts a collection of 14 elements in ascending order using the [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic  
interface implementation of each element.  

***
[Sort14Ascending&lt;T&gt;(T, Comparison&lt;T&gt;)](SortingNetworks_SNBestKnown_Sort14Ascending_T_(T_System_Comparison_T_).md 'SortingNetworks.SNBestKnown.Sort14Ascending&lt;T&gt;(T, System.Comparison&lt;T&gt;)')

Sorts a collection of 14 elements in ascending order using the specified [System.Comparison&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1').  

***
[Sort14AscendingBranchless(byte)](SortingNetworks_SNBestKnown_Sort14AscendingBranchless(byte).md 'SortingNetworks.SNBestKnown.Sort14AscendingBranchless(byte)')

Sorts a collection of 14 elements in ascending order using branchless min/max swap.  

***
[Sort14AscendingBranchless(int)](SortingNetworks_SNBestKnown_Sort14AscendingBranchless(int).md 'SortingNetworks.SNBestKnown.Sort14AscendingBranchless(int)')

Sorts a collection of 14 elements in ascending order using branchless min/max swap.  

***
[Sort14AscendingBranchless(sbyte)](SortingNetworks_SNBestKnown_Sort14AscendingBranchless(sbyte).md 'SortingNetworks.SNBestKnown.Sort14AscendingBranchless(sbyte)')

Sorts a collection of 14 elements in ascending order using branchless min/max swap.  

***
[Sort14AscendingBranchless(short)](SortingNetworks_SNBestKnown_Sort14AscendingBranchless(short).md 'SortingNetworks.SNBestKnown.Sort14AscendingBranchless(short)')

Sorts a collection of 14 elements in ascending order using branchless min/max swap.  

***
[Sort14AscendingBranchless(uint)](SortingNetworks_SNBestKnown_Sort14AscendingBranchless(uint).md 'SortingNetworks.SNBestKnown.Sort14AscendingBranchless(uint)')

Sorts a collection of 14 elements in ascending order using branchless min/max swap.  

***
[Sort14AscendingBranchless(ushort)](SortingNetworks_SNBestKnown_Sort14AscendingBranchless(ushort).md 'SortingNetworks.SNBestKnown.Sort14AscendingBranchless(ushort)')

Sorts a collection of 14 elements in ascending order using branchless min/max swap.  

***
[Sort14Descending&lt;T&gt;(T)](SortingNetworks_SNBestKnown_Sort14Descending_T_(T).md 'SortingNetworks.SNBestKnown.Sort14Descending&lt;T&gt;(T)')

Sorts a collection of 14 elements in descending order using the [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic  
interface implementation of each element.  

***
[Sort14Descending&lt;T&gt;(T, Comparison&lt;T&gt;)](SortingNetworks_SNBestKnown_Sort14Descending_T_(T_System_Comparison_T_).md 'SortingNetworks.SNBestKnown.Sort14Descending&lt;T&gt;(T, System.Comparison&lt;T&gt;)')

Sorts a collection of 14 elements in descending order using the specified [System.Comparison&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1').  

***
[Sort14DescendingBranchless(byte)](SortingNetworks_SNBestKnown_Sort14DescendingBranchless(byte).md 'SortingNetworks.SNBestKnown.Sort14DescendingBranchless(byte)')

Sorts a collection of 14 elements in descending order using branchless min/max swap.  

***
[Sort14DescendingBranchless(int)](SortingNetworks_SNBestKnown_Sort14DescendingBranchless(int).md 'SortingNetworks.SNBestKnown.Sort14DescendingBranchless(int)')

Sorts a collection of 14 elements in descending order using branchless min/max swap.  

***
[Sort14DescendingBranchless(sbyte)](SortingNetworks_SNBestKnown_Sort14DescendingBranchless(sbyte).md 'SortingNetworks.SNBestKnown.Sort14DescendingBranchless(sbyte)')

Sorts a collection of 14 elements in descending order using branchless min/max swap.  

***
[Sort14DescendingBranchless(short)](SortingNetworks_SNBestKnown_Sort14DescendingBranchless(short).md 'SortingNetworks.SNBestKnown.Sort14DescendingBranchless(short)')

Sorts a collection of 14 elements in descending order using branchless min/max swap.  

***
[Sort14DescendingBranchless(uint)](SortingNetworks_SNBestKnown_Sort14DescendingBranchless(uint).md 'SortingNetworks.SNBestKnown.Sort14DescendingBranchless(uint)')

Sorts a collection of 14 elements in descending order using branchless min/max swap.  

***
[Sort14DescendingBranchless(ushort)](SortingNetworks_SNBestKnown_Sort14DescendingBranchless(ushort).md 'SortingNetworks.SNBestKnown.Sort14DescendingBranchless(ushort)')

Sorts a collection of 14 elements in descending order using branchless min/max swap.  

***
[Sort15Ascending&lt;T&gt;(T)](SortingNetworks_SNBestKnown_Sort15Ascending_T_(T).md 'SortingNetworks.SNBestKnown.Sort15Ascending&lt;T&gt;(T)')

Sorts a collection of 15 elements in ascending order using the [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic  
interface implementation of each element.  

***
[Sort15Ascending&lt;T&gt;(T, Comparison&lt;T&gt;)](SortingNetworks_SNBestKnown_Sort15Ascending_T_(T_System_Comparison_T_).md 'SortingNetworks.SNBestKnown.Sort15Ascending&lt;T&gt;(T, System.Comparison&lt;T&gt;)')

Sorts a collection of 15 elements in ascending order using the specified [System.Comparison&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1').  

***
[Sort15AscendingBranchless(byte)](SortingNetworks_SNBestKnown_Sort15AscendingBranchless(byte).md 'SortingNetworks.SNBestKnown.Sort15AscendingBranchless(byte)')

Sorts a collection of 15 elements in ascending order using branchless min/max swap.  

***
[Sort15AscendingBranchless(int)](SortingNetworks_SNBestKnown_Sort15AscendingBranchless(int).md 'SortingNetworks.SNBestKnown.Sort15AscendingBranchless(int)')

Sorts a collection of 15 elements in ascending order using branchless min/max swap.  

***
[Sort15AscendingBranchless(sbyte)](SortingNetworks_SNBestKnown_Sort15AscendingBranchless(sbyte).md 'SortingNetworks.SNBestKnown.Sort15AscendingBranchless(sbyte)')

Sorts a collection of 15 elements in ascending order using branchless min/max swap.  

***
[Sort15AscendingBranchless(short)](SortingNetworks_SNBestKnown_Sort15AscendingBranchless(short).md 'SortingNetworks.SNBestKnown.Sort15AscendingBranchless(short)')

Sorts a collection of 15 elements in ascending order using branchless min/max swap.  

***
[Sort15AscendingBranchless(uint)](SortingNetworks_SNBestKnown_Sort15AscendingBranchless(uint).md 'SortingNetworks.SNBestKnown.Sort15AscendingBranchless(uint)')

Sorts a collection of 15 elements in ascending order using branchless min/max swap.  

***
[Sort15AscendingBranchless(ushort)](SortingNetworks_SNBestKnown_Sort15AscendingBranchless(ushort).md 'SortingNetworks.SNBestKnown.Sort15AscendingBranchless(ushort)')

Sorts a collection of 15 elements in ascending order using branchless min/max swap.  

***
[Sort15Descending&lt;T&gt;(T)](SortingNetworks_SNBestKnown_Sort15Descending_T_(T).md 'SortingNetworks.SNBestKnown.Sort15Descending&lt;T&gt;(T)')

Sorts a collection of 15 elements in descending order using the [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic  
interface implementation of each element.  

***
[Sort15Descending&lt;T&gt;(T, Comparison&lt;T&gt;)](SortingNetworks_SNBestKnown_Sort15Descending_T_(T_System_Comparison_T_).md 'SortingNetworks.SNBestKnown.Sort15Descending&lt;T&gt;(T, System.Comparison&lt;T&gt;)')

Sorts a collection of 15 elements in descending order using the specified [System.Comparison&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1').  

***
[Sort15DescendingBranchless(byte)](SortingNetworks_SNBestKnown_Sort15DescendingBranchless(byte).md 'SortingNetworks.SNBestKnown.Sort15DescendingBranchless(byte)')

Sorts a collection of 15 elements in descending order using branchless min/max swap.  

***
[Sort15DescendingBranchless(int)](SortingNetworks_SNBestKnown_Sort15DescendingBranchless(int).md 'SortingNetworks.SNBestKnown.Sort15DescendingBranchless(int)')

Sorts a collection of 15 elements in descending order using branchless min/max swap.  

***
[Sort15DescendingBranchless(sbyte)](SortingNetworks_SNBestKnown_Sort15DescendingBranchless(sbyte).md 'SortingNetworks.SNBestKnown.Sort15DescendingBranchless(sbyte)')

Sorts a collection of 15 elements in descending order using branchless min/max swap.  

***
[Sort15DescendingBranchless(short)](SortingNetworks_SNBestKnown_Sort15DescendingBranchless(short).md 'SortingNetworks.SNBestKnown.Sort15DescendingBranchless(short)')

Sorts a collection of 15 elements in descending order using branchless min/max swap.  

***
[Sort15DescendingBranchless(uint)](SortingNetworks_SNBestKnown_Sort15DescendingBranchless(uint).md 'SortingNetworks.SNBestKnown.Sort15DescendingBranchless(uint)')

Sorts a collection of 15 elements in descending order using branchless min/max swap.  

***
[Sort15DescendingBranchless(ushort)](SortingNetworks_SNBestKnown_Sort15DescendingBranchless(ushort).md 'SortingNetworks.SNBestKnown.Sort15DescendingBranchless(ushort)')

Sorts a collection of 15 elements in descending order using branchless min/max swap.  

***
[Sort16Ascending&lt;T&gt;(T)](SortingNetworks_SNBestKnown_Sort16Ascending_T_(T).md 'SortingNetworks.SNBestKnown.Sort16Ascending&lt;T&gt;(T)')

Sorts a collection of 16 elements in ascending order using the [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic  
interface implementation of each element.  

***
[Sort16Ascending&lt;T&gt;(T, Comparison&lt;T&gt;)](SortingNetworks_SNBestKnown_Sort16Ascending_T_(T_System_Comparison_T_).md 'SortingNetworks.SNBestKnown.Sort16Ascending&lt;T&gt;(T, System.Comparison&lt;T&gt;)')

Sorts a collection of 16 elements in ascending order using the specified [System.Comparison&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1').  

***
[Sort16AscendingBranchless(byte)](SortingNetworks_SNBestKnown_Sort16AscendingBranchless(byte).md 'SortingNetworks.SNBestKnown.Sort16AscendingBranchless(byte)')

Sorts a collection of 16 elements in ascending order using branchless min/max swap.  

***
[Sort16AscendingBranchless(int)](SortingNetworks_SNBestKnown_Sort16AscendingBranchless(int).md 'SortingNetworks.SNBestKnown.Sort16AscendingBranchless(int)')

Sorts a collection of 16 elements in ascending order using branchless min/max swap.  

***
[Sort16AscendingBranchless(sbyte)](SortingNetworks_SNBestKnown_Sort16AscendingBranchless(sbyte).md 'SortingNetworks.SNBestKnown.Sort16AscendingBranchless(sbyte)')

Sorts a collection of 16 elements in ascending order using branchless min/max swap.  

***
[Sort16AscendingBranchless(short)](SortingNetworks_SNBestKnown_Sort16AscendingBranchless(short).md 'SortingNetworks.SNBestKnown.Sort16AscendingBranchless(short)')

Sorts a collection of 16 elements in ascending order using branchless min/max swap.  

***
[Sort16AscendingBranchless(uint)](SortingNetworks_SNBestKnown_Sort16AscendingBranchless(uint).md 'SortingNetworks.SNBestKnown.Sort16AscendingBranchless(uint)')

Sorts a collection of 16 elements in ascending order using branchless min/max swap.  

***
[Sort16AscendingBranchless(ushort)](SortingNetworks_SNBestKnown_Sort16AscendingBranchless(ushort).md 'SortingNetworks.SNBestKnown.Sort16AscendingBranchless(ushort)')

Sorts a collection of 16 elements in ascending order using branchless min/max swap.  

***
[Sort16Descending&lt;T&gt;(T)](SortingNetworks_SNBestKnown_Sort16Descending_T_(T).md 'SortingNetworks.SNBestKnown.Sort16Descending&lt;T&gt;(T)')

Sorts a collection of 16 elements in descending order using the [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic  
interface implementation of each element.  

***
[Sort16Descending&lt;T&gt;(T, Comparison&lt;T&gt;)](SortingNetworks_SNBestKnown_Sort16Descending_T_(T_System_Comparison_T_).md 'SortingNetworks.SNBestKnown.Sort16Descending&lt;T&gt;(T, System.Comparison&lt;T&gt;)')

Sorts a collection of 16 elements in descending order using the specified [System.Comparison&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1').  

***
[Sort16DescendingBranchless(byte)](SortingNetworks_SNBestKnown_Sort16DescendingBranchless(byte).md 'SortingNetworks.SNBestKnown.Sort16DescendingBranchless(byte)')

Sorts a collection of 16 elements in descending order using branchless min/max swap.  

***
[Sort16DescendingBranchless(int)](SortingNetworks_SNBestKnown_Sort16DescendingBranchless(int).md 'SortingNetworks.SNBestKnown.Sort16DescendingBranchless(int)')

Sorts a collection of 16 elements in descending order using branchless min/max swap.  

***
[Sort16DescendingBranchless(sbyte)](SortingNetworks_SNBestKnown_Sort16DescendingBranchless(sbyte).md 'SortingNetworks.SNBestKnown.Sort16DescendingBranchless(sbyte)')

Sorts a collection of 16 elements in descending order using branchless min/max swap.  

***
[Sort16DescendingBranchless(short)](SortingNetworks_SNBestKnown_Sort16DescendingBranchless(short).md 'SortingNetworks.SNBestKnown.Sort16DescendingBranchless(short)')

Sorts a collection of 16 elements in descending order using branchless min/max swap.  

***
[Sort16DescendingBranchless(uint)](SortingNetworks_SNBestKnown_Sort16DescendingBranchless(uint).md 'SortingNetworks.SNBestKnown.Sort16DescendingBranchless(uint)')

Sorts a collection of 16 elements in descending order using branchless min/max swap.  

***
[Sort16DescendingBranchless(ushort)](SortingNetworks_SNBestKnown_Sort16DescendingBranchless(ushort).md 'SortingNetworks.SNBestKnown.Sort16DescendingBranchless(ushort)')

Sorts a collection of 16 elements in descending order using branchless min/max swap.  

***
[Sort9Ascending&lt;T&gt;(T)](SortingNetworks_SNBestKnown_Sort9Ascending_T_(T).md 'SortingNetworks.SNBestKnown.Sort9Ascending&lt;T&gt;(T)')

Sorts a collection of 9 elements in ascending order using the [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic  
interface implementation of each element.  

***
[Sort9Ascending&lt;T&gt;(T, Comparison&lt;T&gt;)](SortingNetworks_SNBestKnown_Sort9Ascending_T_(T_System_Comparison_T_).md 'SortingNetworks.SNBestKnown.Sort9Ascending&lt;T&gt;(T, System.Comparison&lt;T&gt;)')

Sorts a collection of 9 elements in ascending order using the specified [System.Comparison&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1').  

***
[Sort9AscendingBranchless(byte)](SortingNetworks_SNBestKnown_Sort9AscendingBranchless(byte).md 'SortingNetworks.SNBestKnown.Sort9AscendingBranchless(byte)')

Sorts a collection of 9 elements in ascending order using branchless min/max swap.  

***
[Sort9AscendingBranchless(int)](SortingNetworks_SNBestKnown_Sort9AscendingBranchless(int).md 'SortingNetworks.SNBestKnown.Sort9AscendingBranchless(int)')

Sorts a collection of 9 elements in ascending order using branchless min/max swap.  

***
[Sort9AscendingBranchless(sbyte)](SortingNetworks_SNBestKnown_Sort9AscendingBranchless(sbyte).md 'SortingNetworks.SNBestKnown.Sort9AscendingBranchless(sbyte)')

Sorts a collection of 9 elements in ascending order using branchless min/max swap.  

***
[Sort9AscendingBranchless(short)](SortingNetworks_SNBestKnown_Sort9AscendingBranchless(short).md 'SortingNetworks.SNBestKnown.Sort9AscendingBranchless(short)')

Sorts a collection of 9 elements in ascending order using branchless min/max swap.  

***
[Sort9AscendingBranchless(uint)](SortingNetworks_SNBestKnown_Sort9AscendingBranchless(uint).md 'SortingNetworks.SNBestKnown.Sort9AscendingBranchless(uint)')

Sorts a collection of 9 elements in ascending order using branchless min/max swap.  

***
[Sort9AscendingBranchless(ushort)](SortingNetworks_SNBestKnown_Sort9AscendingBranchless(ushort).md 'SortingNetworks.SNBestKnown.Sort9AscendingBranchless(ushort)')

Sorts a collection of 9 elements in ascending order using branchless min/max swap.  

***
[Sort9Descending&lt;T&gt;(T)](SortingNetworks_SNBestKnown_Sort9Descending_T_(T).md 'SortingNetworks.SNBestKnown.Sort9Descending&lt;T&gt;(T)')

Sorts a collection of 9 elements in descending order using the [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic  
interface implementation of each element.  

***
[Sort9Descending&lt;T&gt;(T, Comparison&lt;T&gt;)](SortingNetworks_SNBestKnown_Sort9Descending_T_(T_System_Comparison_T_).md 'SortingNetworks.SNBestKnown.Sort9Descending&lt;T&gt;(T, System.Comparison&lt;T&gt;)')

Sorts a collection of 9 elements in descending order using the specified [System.Comparison&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1').  

***
[Sort9DescendingBranchless(byte)](SortingNetworks_SNBestKnown_Sort9DescendingBranchless(byte).md 'SortingNetworks.SNBestKnown.Sort9DescendingBranchless(byte)')

Sorts a collection of 9 elements in descending order using branchless min/max swap.  

***
[Sort9DescendingBranchless(int)](SortingNetworks_SNBestKnown_Sort9DescendingBranchless(int).md 'SortingNetworks.SNBestKnown.Sort9DescendingBranchless(int)')

Sorts a collection of 9 elements in descending order using branchless min/max swap.  

***
[Sort9DescendingBranchless(sbyte)](SortingNetworks_SNBestKnown_Sort9DescendingBranchless(sbyte).md 'SortingNetworks.SNBestKnown.Sort9DescendingBranchless(sbyte)')

Sorts a collection of 9 elements in descending order using branchless min/max swap.  

***
[Sort9DescendingBranchless(short)](SortingNetworks_SNBestKnown_Sort9DescendingBranchless(short).md 'SortingNetworks.SNBestKnown.Sort9DescendingBranchless(short)')

Sorts a collection of 9 elements in descending order using branchless min/max swap.  

***
[Sort9DescendingBranchless(uint)](SortingNetworks_SNBestKnown_Sort9DescendingBranchless(uint).md 'SortingNetworks.SNBestKnown.Sort9DescendingBranchless(uint)')

Sorts a collection of 9 elements in descending order using branchless min/max swap.  

***
[Sort9DescendingBranchless(ushort)](SortingNetworks_SNBestKnown_Sort9DescendingBranchless(ushort).md 'SortingNetworks.SNBestKnown.Sort9DescendingBranchless(ushort)')

Sorts a collection of 9 elements in descending order using branchless min/max swap.  

***
[SortAscending&lt;T&gt;(T, int)](SortingNetworks_SNBestKnown_SortAscending_T_(T_int).md 'SortingNetworks.SNBestKnown.SortAscending&lt;T&gt;(T, int)')

Sorts a collection of specified number of elements in ascending order using the [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic  
interface implementation of each element.  

***
[SortAscending&lt;T&gt;(T, int, Comparison&lt;T&gt;)](SortingNetworks_SNBestKnown_SortAscending_T_(T_int_System_Comparison_T_).md 'SortingNetworks.SNBestKnown.SortAscending&lt;T&gt;(T, int, System.Comparison&lt;T&gt;)')

Sorts a collection of specified number of elements in ascending order using the specified [System.Comparison&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1').  

***
[SortAscendingBranchless(byte, int)](SortingNetworks_SNBestKnown_SortAscendingBranchless(byte_int).md 'SortingNetworks.SNBestKnown.SortAscendingBranchless(byte, int)')

Sorts a collection of specified number of elements in ascending order using branchless min/max swap.  

***
[SortAscendingBranchless(int, int)](SortingNetworks_SNBestKnown_SortAscendingBranchless(int_int).md 'SortingNetworks.SNBestKnown.SortAscendingBranchless(int, int)')

Sorts a collection of specified number of elements in ascending order using branchless min/max swap.  

***
[SortAscendingBranchless(sbyte, int)](SortingNetworks_SNBestKnown_SortAscendingBranchless(sbyte_int).md 'SortingNetworks.SNBestKnown.SortAscendingBranchless(sbyte, int)')

Sorts a collection of specified number of elements in ascending order using branchless min/max swap.  

***
[SortAscendingBranchless(short, int)](SortingNetworks_SNBestKnown_SortAscendingBranchless(short_int).md 'SortingNetworks.SNBestKnown.SortAscendingBranchless(short, int)')

Sorts a collection of specified number of elements in ascending order using branchless min/max swap.  

***
[SortAscendingBranchless(uint, int)](SortingNetworks_SNBestKnown_SortAscendingBranchless(uint_int).md 'SortingNetworks.SNBestKnown.SortAscendingBranchless(uint, int)')

Sorts a collection of specified number of elements in ascending order using branchless min/max swap.  

***
[SortAscendingBranchless(ushort, int)](SortingNetworks_SNBestKnown_SortAscendingBranchless(ushort_int).md 'SortingNetworks.SNBestKnown.SortAscendingBranchless(ushort, int)')

Sorts a collection of specified number of elements in ascending order using branchless min/max swap.  

***
[SortDescending&lt;T&gt;(T, int)](SortingNetworks_SNBestKnown_SortDescending_T_(T_int).md 'SortingNetworks.SNBestKnown.SortDescending&lt;T&gt;(T, int)')

Sorts a collection of specified number of elements in descending order using the [System.IComparable&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1 'System.IComparable`1') generic  
interface implementation of each element.  

***
[SortDescending&lt;T&gt;(T, int, Comparison&lt;T&gt;)](SortingNetworks_SNBestKnown_SortDescending_T_(T_int_System_Comparison_T_).md 'SortingNetworks.SNBestKnown.SortDescending&lt;T&gt;(T, int, System.Comparison&lt;T&gt;)')

Sorts a collection of specified number of elements in descending order using the specified [System.Comparison&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Comparison-1 'System.Comparison`1').  

***
[SortDescendingBranchless(byte, int)](SortingNetworks_SNBestKnown_SortDescendingBranchless(byte_int).md 'SortingNetworks.SNBestKnown.SortDescendingBranchless(byte, int)')

Sorts a collection of specified number of elements in descending order using branchless min/max swap.  

***
[SortDescendingBranchless(int, int)](SortingNetworks_SNBestKnown_SortDescendingBranchless(int_int).md 'SortingNetworks.SNBestKnown.SortDescendingBranchless(int, int)')

Sorts a collection of specified number of elements in descending order using branchless min/max swap.  

***
[SortDescendingBranchless(sbyte, int)](SortingNetworks_SNBestKnown_SortDescendingBranchless(sbyte_int).md 'SortingNetworks.SNBestKnown.SortDescendingBranchless(sbyte, int)')

Sorts a collection of specified number of elements in descending order using branchless min/max swap.  

***
[SortDescendingBranchless(short, int)](SortingNetworks_SNBestKnown_SortDescendingBranchless(short_int).md 'SortingNetworks.SNBestKnown.SortDescendingBranchless(short, int)')

Sorts a collection of specified number of elements in descending order using branchless min/max swap.  

***
[SortDescendingBranchless(uint, int)](SortingNetworks_SNBestKnown_SortDescendingBranchless(uint_int).md 'SortingNetworks.SNBestKnown.SortDescendingBranchless(uint, int)')

Sorts a collection of specified number of elements in descending order using branchless min/max swap.  

***
[SortDescendingBranchless(ushort, int)](SortingNetworks_SNBestKnown_SortDescendingBranchless(ushort_int).md 'SortingNetworks.SNBestKnown.SortDescendingBranchless(ushort, int)')

Sorts a collection of specified number of elements in descending order using branchless min/max swap.  
