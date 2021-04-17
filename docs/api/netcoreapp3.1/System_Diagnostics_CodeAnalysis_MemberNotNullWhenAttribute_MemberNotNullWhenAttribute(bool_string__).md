#### [SortingNetworks](index.md 'index')
### [System.Diagnostics.CodeAnalysis](System_Diagnostics_CodeAnalysis.md 'System.Diagnostics.CodeAnalysis').[MemberNotNullWhenAttribute](System_Diagnostics_CodeAnalysis_MemberNotNullWhenAttribute.md 'System.Diagnostics.CodeAnalysis.MemberNotNullWhenAttribute')
## MemberNotNullWhenAttribute.MemberNotNullWhenAttribute(bool, string[]) Constructor
Initializes the attribute with the specified return value condition and list  
of field and property members.  
```csharp
public MemberNotNullWhenAttribute(bool returnValue, params string[] members);
```
#### Parameters
<a name='System_Diagnostics_CodeAnalysis_MemberNotNullWhenAttribute_MemberNotNullWhenAttribute(bool_string__)_returnValue'></a>
`returnValue` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The return value condition. If the method returns this value,  
the associated parameter will not be [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').  
  
<a name='System_Diagnostics_CodeAnalysis_MemberNotNullWhenAttribute_MemberNotNullWhenAttribute(bool_string__)_members'></a>
`members` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
The list of field and property members that are promised to be not-null.  
  
