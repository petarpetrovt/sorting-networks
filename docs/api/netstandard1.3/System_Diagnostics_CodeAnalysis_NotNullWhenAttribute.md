#### [SortingNetworks](index.md 'index')
### [System.Diagnostics.CodeAnalysis](System_Diagnostics_CodeAnalysis.md 'System.Diagnostics.CodeAnalysis')
## NotNullWhenAttribute Class
Specifies that when a method returns [ReturnValue](System_Diagnostics_CodeAnalysis_NotNullWhenAttribute_ReturnValue.md 'System.Diagnostics.CodeAnalysis.NotNullWhenAttribute.ReturnValue'),  
the parameter will not be [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null') even if the corresponding type allows it.  
```csharp
internal sealed class NotNullWhenAttribute : System.Attribute
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Attribute](https://docs.microsoft.com/en-us/dotnet/api/System.Attribute 'System.Attribute') &#129106; NotNullWhenAttribute  
### Constructors

***
[NotNullWhenAttribute(bool)](System_Diagnostics_CodeAnalysis_NotNullWhenAttribute_NotNullWhenAttribute(bool).md 'System.Diagnostics.CodeAnalysis.NotNullWhenAttribute.NotNullWhenAttribute(bool)')

Initializes the attribute with the specified return value condition.  
### Properties

***
[ReturnValue](System_Diagnostics_CodeAnalysis_NotNullWhenAttribute_ReturnValue.md 'System.Diagnostics.CodeAnalysis.NotNullWhenAttribute.ReturnValue')

Gets the return value condition.  
If the method returns this value, the associated parameter will not be [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null').  
