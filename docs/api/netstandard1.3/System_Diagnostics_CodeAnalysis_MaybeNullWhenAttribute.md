#### [SortingNetworks](index.md 'index')
### [System.Diagnostics.CodeAnalysis](System_Diagnostics_CodeAnalysis.md 'System.Diagnostics.CodeAnalysis')
## MaybeNullWhenAttribute Class
Specifies that when a method returns [ReturnValue](System_Diagnostics_CodeAnalysis_MaybeNullWhenAttribute_ReturnValue.md 'System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute.ReturnValue'),   
the parameter may be [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null') even if the corresponding type disallows it.  
```csharp
internal sealed class MaybeNullWhenAttribute : System.Attribute
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Attribute](https://docs.microsoft.com/en-us/dotnet/api/System.Attribute 'System.Attribute') &#129106; MaybeNullWhenAttribute  
### Constructors

***
[MaybeNullWhenAttribute(bool)](System_Diagnostics_CodeAnalysis_MaybeNullWhenAttribute_MaybeNullWhenAttribute(bool).md 'System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute.MaybeNullWhenAttribute(bool)')

Initializes the attribute with the specified return value condition.  
### Properties

***
[ReturnValue](System_Diagnostics_CodeAnalysis_MaybeNullWhenAttribute_ReturnValue.md 'System.Diagnostics.CodeAnalysis.MaybeNullWhenAttribute.ReturnValue')

Gets the return value condition.  
If the method returns this value, the associated parameter may be [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').  
