#### [SortingNetworks](./index.md 'index')
### [System.Diagnostics.CodeAnalysis](./System-Diagnostics-CodeAnalysis.md 'System.Diagnostics.CodeAnalysis').[MemberNotNullWhenAttribute](./System-Diagnostics-CodeAnalysis-MemberNotNullWhenAttribute.md 'System.Diagnostics.CodeAnalysis.MemberNotNullWhenAttribute')
## MemberNotNullWhenAttribute(bool, string[]) Constructor
Initializes the attribute with the specified return value condition and list  
of field and property members.  
```csharp
public MemberNotNullWhenAttribute(bool returnValue, params string[] members);
```
#### Parameters
<a name='System-Diagnostics-CodeAnalysis-MemberNotNullWhenAttribute-MemberNotNullWhenAttribute(bool_string--)-returnValue'></a>
`returnValue` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The return value condition. If the method returns this value,  
the associated parameter will not be https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null.  
  
<a name='System-Diagnostics-CodeAnalysis-MemberNotNullWhenAttribute-MemberNotNullWhenAttribute(bool_string--)-members'></a>
`members` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The list of field and property members that are promised to be not-null.  
  
