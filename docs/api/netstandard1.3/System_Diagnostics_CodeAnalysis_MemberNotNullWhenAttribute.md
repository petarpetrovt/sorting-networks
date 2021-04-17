#### [SortingNetworks](index.md 'index')
### [System.Diagnostics.CodeAnalysis](System_Diagnostics_CodeAnalysis.md 'System.Diagnostics.CodeAnalysis')
## MemberNotNullWhenAttribute Class
Specifies that the method or property will ensure that the listed field and property members have  
non-[null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null') values when returning with the specified return value condition.  
```csharp
internal sealed class MemberNotNullWhenAttribute : System.Attribute
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Attribute](https://docs.microsoft.com/en-us/dotnet/api/System.Attribute 'System.Attribute') &#129106; MemberNotNullWhenAttribute  
### Constructors

***
[MemberNotNullWhenAttribute(bool, string)](System_Diagnostics_CodeAnalysis_MemberNotNullWhenAttribute_MemberNotNullWhenAttribute(bool_string).md 'System.Diagnostics.CodeAnalysis.MemberNotNullWhenAttribute.MemberNotNullWhenAttribute(bool, string)')

Initializes the attribute with the specified return value condition and a field or property member.  

***
[MemberNotNullWhenAttribute(bool, string[])](System_Diagnostics_CodeAnalysis_MemberNotNullWhenAttribute_MemberNotNullWhenAttribute(bool_string__).md 'System.Diagnostics.CodeAnalysis.MemberNotNullWhenAttribute.MemberNotNullWhenAttribute(bool, string[])')

Initializes the attribute with the specified return value condition and list  
of field and property members.  
### Properties

***
[Members](System_Diagnostics_CodeAnalysis_MemberNotNullWhenAttribute_Members.md 'System.Diagnostics.CodeAnalysis.MemberNotNullWhenAttribute.Members')

Gets field or property member names.  

***
[ReturnValue](System_Diagnostics_CodeAnalysis_MemberNotNullWhenAttribute_ReturnValue.md 'System.Diagnostics.CodeAnalysis.MemberNotNullWhenAttribute.ReturnValue')

Gets the return value condition.  
