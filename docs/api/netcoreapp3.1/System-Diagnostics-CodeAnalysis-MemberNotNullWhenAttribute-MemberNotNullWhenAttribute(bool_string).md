#### [SortingNetworks](./index.md 'index')
### [System.Diagnostics.CodeAnalysis](./System-Diagnostics-CodeAnalysis.md 'System.Diagnostics.CodeAnalysis').[MemberNotNullWhenAttribute](./System-Diagnostics-CodeAnalysis-MemberNotNullWhenAttribute.md 'System.Diagnostics.CodeAnalysis.MemberNotNullWhenAttribute')
## MemberNotNullWhenAttribute(bool, string) Constructor
Initializes the attribute with the specified return value condition and a field or property member.  
```csharp
public MemberNotNullWhenAttribute(bool returnValue, string member);
```
#### Parameters
<a name='System-Diagnostics-CodeAnalysis-MemberNotNullWhenAttribute-MemberNotNullWhenAttribute(bool_string)-returnValue'></a>
`returnValue` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The return value condition. If the method returns this value,  
the associated parameter will not be https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null.  
  
<a name='System-Diagnostics-CodeAnalysis-MemberNotNullWhenAttribute-MemberNotNullWhenAttribute(bool_string)-member'></a>
`member` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The field or property member that is promised to be not-https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null.  
  
