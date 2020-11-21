### [SortingNetworks](./SortingNetworks.md 'SortingNetworks').[SNBase](./SortingNetworks-SNBase.md 'SortingNetworks.SNBase')
## SNBase.GreaterThan&lt;T&gt;(T, T) Method
Gets a flag indicating whether [left](#SortingNetworks-SNBase-GreaterThan-T-(T_T)-left 'SortingNetworks.SNBase.GreaterThan&lt;T&gt;(T, T).left') is greater than [right](#SortingNetworks-SNBase-GreaterThan-T-(T_T)-right 'SortingNetworks.SNBase.GreaterThan&lt;T&gt;(T, T).right').  
```csharp
protected internal static bool GreaterThan<T>(ref T left, ref T right);
```
#### Type parameters
<a name='SortingNetworks-SNBase-GreaterThan-T-(T_T)-T'></a>
`T`  
the parameter type  
  
#### Parameters
<a name='SortingNetworks-SNBase-GreaterThan-T-(T_T)-left'></a>
`left` [T](#SortingNetworks-SNBase-GreaterThan-T-(T_T)-T 'SortingNetworks.SNBase.GreaterThan&lt;T&gt;(T, T).T')  
the left parameter  
  
<a name='SortingNetworks-SNBase-GreaterThan-T-(T_T)-right'></a>
`right` [T](#SortingNetworks-SNBase-GreaterThan-T-(T_T)-T 'SortingNetworks.SNBase.GreaterThan&lt;T&gt;(T, T).T')  
the right parameter  
  
#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
true if [left](#SortingNetworks-SNBase-GreaterThan-T-(T_T)-left 'SortingNetworks.SNBase.GreaterThan&lt;T&gt;(T, T).left') is greater than [right](#SortingNetworks-SNBase-GreaterThan-T-(T_T)-right 'SortingNetworks.SNBase.GreaterThan&lt;T&gt;(T, T).right'); otherwise false  
### Remarks
Compiles to a single comparison or method call.  
